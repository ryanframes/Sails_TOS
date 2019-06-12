Imports DevComponents.DotNetBar

Public Class FormInboundData_Input
    Private _v_out_service_code As String
    Private _conDataID As Long
    Private _v_pub_id_vvd As String

    Enum inputTypes
        insert = 1
        edit = 2
    End Enum
    Private _inputType As inputTypes = inputTypes.insert
    Private _pForm As FormInboundData

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fill_combo()
    End Sub

    Public Property inputType As inputTypes
        Get
            Return _inputType
        End Get
        Set(value As inputTypes)
            _inputType = value
        End Set
    End Property

    Public Property pForm As FormInboundData
        Get
            Return _pForm
        End Get
        Set(value As FormInboundData)
            _pForm = value
        End Set
    End Property

    Public Property v_out_service_code As String
        Get
            Return _v_out_service_code
        End Get
        Set(value As String)
            _v_out_service_code = value
        End Set
    End Property

    Public Property ConDataID As Long
        Get
            Return _conDataID
        End Get
        Set(value As Long)
            _conDataID = value
        End Set
    End Property

    Public Property V_pub_id_vvd As String
        Get
            Return _v_pub_id_vvd
        End Get
        Set(value As String)
            _v_pub_id_vvd = value
        End Set
    End Property

    Sub fill_combo()

        Dim ds As New Dictionary(Of String, String)
        ds.Add("F", "Full")
        ds.Add("E", "Empty")
        cmb_fm.DataSource = New BindingSource(ds, Nothing)
        cmb_fm.DisplayMember = "value"
        cmb_fm.ValueMember = "key"

        Dim dt As DataTable
        dt = fc_inbdta_getclass(pubApiAddress)
        fill_combo_dt(dt, cmb_class, 1, 2)

        dt = fc_inbdta_getiso(pubApiAddress)
        autocomplete_text(txt_iso_code, dt, "ISO_CODE")

        dt = fc_inbdta_getport(pubApiAddress, "code=" & _v_out_service_code)
        autocomplete_text(txt_pol, dt, "PORT_CODE")

        dt = fc_inbdta_getport(pubApiAddress, "code=" & _v_out_service_code)
        autocomplete_text(txt_pod, dt, "PORT_CODE")

        dt = fc_inbdta_getopr(pubApiAddress, "code=" & _v_out_service_code)
        autocomplete_text(txt_operator, dt, "OP_CODE")

        dt = fc_inbdta_getimdg(pubApiAddress)
        autocomplete_text(txt_imdg, dt, "IMDG_CODE")

        dt = fc_inbdta_getunno(pubApiAddress)
        autocomplete_text(txt_unno, dt, "UNNO_CODE")

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Function allowSave() As Boolean
        If textValidation(txt_cont_number, "Container Number") = False Then Return False
        If textValidation(txt_stowage, "Stowage") = False Then Return False
        If textValidation(cmb_class, "Class") = False Then Return False
        If textValidation(txt_iso_code, "ISO Code") = False Then Return False
        If textValidation(txt_pol, "POL") = False Then Return False
        If textValidation(txt_pod, "POD") = False Then Return False
        If textValidation(txt_operator, "Operator") = False Then Return False
        If CDec(txt_weight.Text) = 0 Then
            MessageBoxEx.Show("Weight must be greater than zero (0)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_weight.Focus()
            Return False
        End If
        If cmb_iso_type.SelectedValue = "RF" And CDec(txt_temp.Text) = 0 Then
            MessageBoxEx.Show("Temperature be greater than zero (0)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_temp.Focus()
            Return False
        End If
        'validasi di 1 id_vvd tidak boleh ada no_cont yang sama
        If Not fc_inbdta_savedata_validation(_v_pub_id_vvd, txt_cont_number.Text, _conDataID, txt_stowage.Text) Then
            MessageBoxEx.Show("Container Number already exist, please input another Container Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_stowage.Focus()
            Return False
            Return False
        End If
        'validasi di 1 id_vvd tidak boleh ada no_cont dan no_stowage yg sma di 1 id_vvd
        'If Not fc_inbdta_savedata_validation(_v_pub_id_vvd, txt_cont_number.Text, _conDataID, txt_stowage.Text) Then Return False
        'cek bay info
        Dim bayNo As String = txt_stowage.Text.Substring(0, 2)
        Dim rowNo As String = IIf(txt_stowage.Text.Length > 3, txt_stowage.Text.Substring(2, 2), "")
        Dim tierNo As String = IIf(txt_stowage.Text.Length > 5, txt_stowage.Text.Substring(4, 2), "")
        Dim dt As DataTable = fc_inbdta_getbay(pubApiAddress, "bay_no=" & bayNo)
        If dt.Rows.Count = 0 Then
            MessageBoxEx.Show("Bay Size not found, please check if the stowage is correct", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_stowage.Focus()
            Return False
        Else
            'cek if bay info size = iso code size
            If CInt(dt.Rows(0)("BAY_SIZE")) <> CInt(IIf(IsNumeric(cmb_iso_size.Text), cmb_iso_size.Text, 0)) Then
                MessageBoxEx.Show("Bay Size Stowage must be equal with ISO Code Size." & vbCrLf &
                                  "Bay Size Stowage : " & dt.Rows(0)("BAY_SIZE") & vbCrLf &
                                  "ISO Code Size : " & cmb_iso_size.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_stowage.Focus()
                Return False
            End If

            'check jika stowage nya ada perubahan
            txt_stowage.Tag = IIf(IsNothing(txt_stowage.Tag), "", txt_stowage.Tag)
            If txt_stowage.Tag <> txt_stowage.Text Then
                Dim row As DataRow()
                Dim whereCondition As String = "BAY_NO = '" & bayNo & "' AND ROW_NO='" & rowNo & "' AND TIER_NO='" & tierNo & "' " &
                                "AND CELL_STATUS=1 AND AVAIL_STATUS = 0"
                'jika size = 40,tambahkan kondisi ini
                If CInt(cmb_iso_size.Text) = 45 Then whereCondition = whereCondition & "AND CELL_45=1 AND BAY_SIZE=40"
                'jika type = reefer / rf tambahkan kondisi ini
                If cmb_iso_type.Text = "RF" Then whereCondition = whereCondition & "AND CELL_REEFER_RACK=1"
                row = dt.Select(whereCondition)
                If row.Length = 0 Then 'TIDAK ADA DATA DARI KONDISI TERPILIH
                    MessageBoxEx.Show("Bay Cell info not available !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt_stowage.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not allowSave() Then Return
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("NO_CONT", txt_cont_number.Text)
        sCol.Add("ID_VVD", _v_pub_id_vvd)
        sCol.Add("ISO", txt_iso_code.Text)
        sCol.Add("CLASS", cmb_class.SelectedValue)
        sCol.Add("OPERATOR", txt_operator.Text)
        sCol.Add("FM", cmb_fm.SelectedValue)
        sCol.Add("POL", txt_pol.Text)
        sCol.Add("POD", txt_pod.Text)
        sCol.Add("POR", txt_por.Text)
        sCol.Add("WEIGHT", Replace(CDec(txt_weight.Text), ",", "."))
        sCol.Add("TEMP", Replace(CDec(txt_temp.Text), ",", "."))
        sCol.Add("IMDG", txt_imdg.Text)
        sCol.Add("UNNO", txt_unno.Text)
        sCol.Add("COMMODITY", cmb_commodity.Text)
        sCol.Add("OVER_FRONT", Replace(CDec(txt_odf.Text), ",", "."))
        sCol.Add("OVER_LEFT", Replace(CDec(txt_odl.Text), ",", "."))
        sCol.Add("OVER_RIGHT", Replace(CDec(txt_odr.Text), ",", "."))
        sCol.Add("OVER_TOP", Replace(CDec(txt_odt.Text), ",", "."))
        sCol.Add("OVER_BACK", Replace(CDec(txt_odb.Text), ",", "."))
        sCol.Add("STW_PLAN", txt_stowage.Text)
        sCol.Add("SIZE", cmb_iso_size.Text)
        sCol.Add("CONT_TYPE", cmb_iso_type.Text)
        sCol.Add("HEIGHT", Replace(CDec(cmb_iso_height.Text), ",", "."))
        'sCol.Add("ID_VVD", IIf(_v_pub_id_vvd = Nothing, "", _v_pub_id_vvd))
        'cek bay info
        Dim bayNo As String = txt_stowage.Text.Substring(0, 2)
        Dim rowNo As String = IIf(txt_stowage.Text.Length > 3, txt_stowage.Text.Substring(2, 2), "")
        Dim tierNo As String = IIf(txt_stowage.Text.Length > 5, txt_stowage.Text.Substring(4, 2), "")
        sCol.Add("BAY_NO", bayNo)
        sCol.Add("ROW_NO", rowNo)
        sCol.Add("TIER_NO", tierNo)
        sCol.Add("AVAIL_STATUS", 1)
        'jika size = 40,tambahkan kondisi ini
        If CInt(cmb_iso_size.Text) = 45 Then sCol.Add("CELL_45", 1) : sCol.Add("BAY_SIZE", 40)
        'jika type = reefer / rf tambahkan kondisi ini
        If cmb_iso_type.Text = "RF" Then sCol.Add("CELL_REEFER_RACK", 1)
        Dim isOk As Boolean
        If _inputType = inputTypes.insert Then
            isOk = fc_inbdta_savedata(sCol)
        Else
            sCol.Add("id", _conDataID)
            isOk = fc_inbdta_upddata(sCol)
        End If
        msgSave(isOk)
        If isOk Then
            pForm.fill_grid()
            Me.Close()
        End If
    End Sub

    Sub txt_iso_code_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_iso_code.KeyDown
        If e.KeyCode = Keys.Enter Then
            getIsoInfo(txt_iso_code.Text)
        End If
    End Sub

    Sub getIsoInfo(ByVal isoCode As String)
        'get iso info
        Dim dt As DataTable = fc_inbdta_getiso(pubApiAddress, "code=" & isoCode)
        If dt.Rows.Count > 0 Then
            fill_combo_dt(dt, cmb_iso_size, "SIZE", "SIZE", False)
            fill_combo_dt(dt, cmb_iso_type, "CONT_TYPE", "CONT_TYPE", False)
            fill_combo_dt(dt, cmb_iso_height, "HEIGHT", "HEIGHT", False)
            fill_combo_dt(dt, cmb_commodity, "COMMODITY", "COMMODITY", False)
        End If
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_odf.KeyPress, txt_weight.KeyPress,
            txt_temp.KeyPress, txt_odf.KeyPress, txt_odb.KeyPress, txt_odl.KeyPress, txt_odr.KeyPress, txt_odt.KeyPress
        e.KeyChar = keyNum(e.KeyChar)
    End Sub

    Private Sub txt_LostFocus(sender As Object, e As EventArgs) Handles txt_odf.LostFocus, txt_weight.LostFocus,
            txt_temp.LostFocus, txt_odf.LostFocus, txt_odb.LostFocus, txt_odl.LostFocus, txt_odr.LostFocus, txt_odt.LostFocus
        txtLostNotNumeric(CType(sender, TextBox), 2)
    End Sub

    Private Sub txt_iso_code_TextChanged(sender As Object, e As EventArgs) Handles txt_iso_code.TextChanged

    End Sub
End Class