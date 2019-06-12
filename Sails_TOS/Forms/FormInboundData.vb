Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports ClosedXML.Excel
Public Class FormInboundData
    Private _v_pub_id_vvd As String

    Private Sub FormInboundData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAPIConf()
    End Sub

    Sub getVesselInfo(ByVal v_id_vvd As String)
        Dim dt As DataTable = fc_vessched_getdata(pubApiAddress, "code=" & v_id_vvd)
        If dt.Rows.Count > 0 Then
            'txt_vessel_voyage.Text = dt.Rows(0)("VOY_CODE")
            'txt_vessel_name.Text = dt.Rows(0)("VES_NAME")
            'txt_vessel_year.Text = dt.Rows(0)("YEAR")
        End If
        'refresh grid dengan vessel terbaru
        fill_grid(v_id_vvd)
        _v_pub_id_vvd = v_id_vvd
    End Sub

    Sub fill_combo()
        Dim dt As DataTable = fc_inbdta_getsize(pubApiAddress)
        fill_combo_dt(dt, cmb_size, 1, 1)
        dt = fc_inbdta_getclass(pubApiAddress)
        fill_combo_dt(dt, cmb_class, 1, 2)
        dt = fc_inbdta_getcontyp(pubApiAddress)
        fill_combo_dt(dt, cmb_type, 1, 2)
    End Sub

    Sub fill_grid(Optional v_id_vvd As String = "")
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_CONT_DATA", "")
        sCol.Add("NO_CONT", "No. Container")
        sCol.Add("STW_PLAN", "Stowage")
        sCol.Add("LOCATION_PLAN", "Location")
        sCol.Add("ISO", "")
        sCol.Add("CLASS_DESC", "Class")
        sCol.Add("OPERATOR", "Operator")
        sCol.Add("ISO_SIZE", "Size")
        sCol.Add("TYPE_DESC", "Type")
        sCol.Add("HEIGHT", "Height")
        sCol.Add("FM", "F/M")
        sCol.Add("COMMODITY", "Commodity")
        sCol.Add("POL", "POL")
        sCol.Add("POD", "POD")
        sCol.Add("POR", "POR")
        sCol.Add("WEIGHT", "Weight (Ton)")
        sCol.Add("TEMP", "Temp (C)")
        sCol.Add("IMDG", "")
        sCol.Add("UNNO", "")
        sCol.Add("OVER_FRONT", "OD-F")
        sCol.Add("OVER_BACK", "OD-B")
        sCol.Add("OVER_LEFT", "OD-L")
        sCol.Add("OVER_RIGHT", "OD-R")
        sCol.Add("OVER_TOP", "OD-T")
        sCol.Add("VGM", "VGM")

        Dim whereCondition As String = ""
        If Not IsNothing(cmb_class.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "class=" & cmb_class.Text)
        If Not IsNothing(cmb_size.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "size=" & cmb_size.Text)
        If Not IsNothing(cmb_type.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "type=" & cmb_type.Text)
        If v_id_vvd <> "" Then whereCondition = whereCondition.Concat(whereCondition, "&", "id_vvd=" & v_id_vvd)
        'whereCondition = IIf(whereCondition <> "", Strings.Right(whereCondition, whereCondition.Length - 1), "")
        showDataGrid(grid_inbound, pubApiAddress, "rts_inbdta_getdata", whereCondition, sCol)
        grid_inbound.Columns("ID_CONT_DATA").Visible = False
        grid_inbound.Columns("VGM").Visible = False
        'add col check
        Dim chk As New DataGridViewCheckBoxColumn
        chk.HeaderText = "Select"
        chk.Name = "Pilih"
        grid_inbound.Columns.Insert(0, chk)
        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"
        grid_inbound.Columns.Insert(0, colNo)
        'CType(grid_inbound.DataSource, DataTable).Columns.Add("No.").SetOrdinal(0)
        'fill col no.
        For i As Integer = 0 To grid_inbound.Rows.Count - 1
            'CType(grid_inbound.DataSource, DataTable).Rows(i)(0) = i + 1
            grid_inbound.Rows(i).Cells("No").Value = i + 1
        Next
        grid_inbound.ReadOnly = False
        autoColWidth(grid_inbound.Columns.Count - 1, grid_inbound)
    End Sub

    Private Sub btn_code_search_Click(sender As Object, e As EventArgs) Handles btn_code_search.Click
        fill_grid()
    End Sub

    Private Sub cmb_vessel_schedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_vessel_schedule.SelectedIndexChanged
        getVesselInfo(cmb_vessel_schedule.SelectedValue)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim frm As New FormInboundData_Input
        frm.pForm = Me
        frm.v_out_service_code = ""
        frm.inputType = FormInboundData_Input.inputTypes.insert
        frm.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If Not allowEditDel() Then Return
        Dim conID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_inbound.Rows.Count - 1
            If grid_inbound.Rows(i).Cells("Pilih").Value = True Or grid_inbound.Rows(i).Cells("Pilih").Value = 1 Then
                conID.Add(grid_inbound.Rows(i).Cells("ID_CONT_DATA").Value)
            End If
        Next

        If conID.Count = 0 Then Return
        Dim dt As DataTable = fc_inbdta_getdata(pubApiAddress, "id_con_data=" & conID.Last)
        If dt.Rows.Count > 0 Then
            Dim frm As New FormInboundData_Input
            With frm
                .pForm = Me
                .Text = "Edit Detail Container"
                .ConDataID = dt.Rows(0)("ID_CONT_DATA")
                .V_pub_id_vvd = dt.Rows(0)("ID_VVD")
                .inputType = FormInboundData_Input.inputTypes.edit
                .txt_cont_number.Text = dt.Rows(0)("No. Container")
                .txt_cont_number.Enabled = False
                .txt_stowage.Text = dt.Rows(0)("Stowage")
                .txt_stowage.Tag = dt.Rows(0)("Stowage") 'store prev stowage here
                .cmb_class.Text = dt.Rows(0)("Class")
                .txt_iso_code.Text = dt.Rows(0)("ISO")
                .getIsoInfo(dt.Rows(0)("ISO"))
                .cmb_iso_size.Text = dt.Rows(0)("Size")
                .cmb_iso_type.Text = dt.Rows(0)("CONT_TYPE")
                .cmb_iso_height.Text = dt.Rows(0)("Height")
                .cmb_commodity.Text = dt.Rows(0)("Commodity")
                .cmb_fm.Text = dt.Rows(0)("F/M")
                .txt_weight.Text = dt.Rows(0)("Weight (Ton)")
                .txt_temp.Text = IIf(IsDBNull(dt.Rows(0)("Temp (C)")), 0, dt.Rows(0)("Temp (C)"))
                .txt_imdg.Text = dt.Rows(0)("IMDG")
                .txt_unno.Text = dt.Rows(0)("UNNO")
                .txt_pol.Text = dt.Rows(0)("POL")
                .txt_por.Text = dt.Rows(0)("POR")
                .txt_pod.Text = dt.Rows(0)("POD")
                .txt_operator.Text = IIf(IsDBNull(dt.Rows(0)("Operator")), "", dt.Rows(0)("Operator"))
                .txt_odf.Text = IIf(IsDBNull(dt.Rows(0)("OD-F")), 0, dt.Rows(0)("OD-F"))
                .txt_odb.Text = IIf(IsDBNull(dt.Rows(0)("OD-B")), 0, dt.Rows(0)("OD-B"))
                .txt_odr.Text = IIf(IsDBNull(dt.Rows(0)("OD-R")), 0, dt.Rows(0)("OD-R"))
                .txt_odl.Text = IIf(IsDBNull(dt.Rows(0)("OD-L")), 0, dt.Rows(0)("OD-L"))
                .txt_odt.Text = IIf(IsDBNull(dt.Rows(0)("OD-T")), 0, dt.Rows(0)("OD-T"))
                .ShowDialog()
            End With
        End If
    End Sub

    Private Function allowEditDel() As Boolean
        If grid_inbound.Rows.Count = 0 Then Return False
        If grid_inbound.CurrentRow Is Nothing Then Return False
        If Not IsNumeric(grid_inbound.CurrentRow.Cells("ID_CONT_DATA").Value) Then Return False
        Return True
    End Function

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not allowEditDel() Then Return
        Dim conID As New List(Of Integer)
        Dim isOk As Boolean
        'cek apakah row yang dipilih lebih dari 1
        For i As Integer = 0 To grid_inbound.Rows.Count - 1
            If grid_inbound.Rows(i).Cells("Pilih").Value = True Or grid_inbound.Rows(i).Cells("Pilih").Value = 1 Then
                'check jml cell tier yang status =1
                If fc_inbdta_deldata_validation(_v_pub_id_vvd, grid_inbound.Rows(i).Cells("No. Container").Value) = False Then
                    MessageBoxEx.Show("Delete failed because container is in progress", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                'masukan id ke list untuk di looping proses delete
                conID.Add(grid_inbound.Rows(i).Cells("ID_CONT_DATA").Value)
            End If
        Next
        If conID.Count = 0 Then Return

        Dim res As DialogResult

        res = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        For i = 0 To conID.Count - 1
            isOk = fc_inbdta_deldata(conID(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid()
    End Sub

    Private Sub btn_export_csv_Click(sender As Object, e As EventArgs) Handles btn_export_csv.Click
        Dim res As DialogResult = dlgExport.ShowDialog
        If res = DialogResult.Cancel Then Return
        Dim fName As String = dlgExport.FileName
        'dataTableToExcel(CType(grid_inbound.DataSource, DataTable), fName, "")
        ''create header
        'My.Computer.FileSystem.WriteAllText(fName, "")

        Using wb As XLWorkbook = New XLWorkbook
            Dim ws As IXLWorksheet = wb.Worksheets.Add("Container Data")
            With ws
                Dim colAdd As Integer = 0
                'For col As Integer = 0 To grid_inbound.Columns.Count - 1
                '    If grid_inbound.Columns(col).Visible = True And col <> grid_inbound.Columns("Pilih").Index Then
                '        .Cell(1, colAdd + 1).Value = grid_inbound.Columns(col).HeaderText
                '        .Cell(1, colAdd + 1).Style.Fill.BackgroundColor = XLColor.Blue
                '        .Cell(1, colAdd + 1).Style.Font.Bold = True
                '        .Cell(1, colAdd + 1).Style.Font.FontColor = XLColor.White
                '        For row As Integer = 0 To grid_inbound.Rows.Count - 1
                '            .Cell(row + 2, colAdd + 1).Value = grid_inbound.Rows(row).Cells(col).Value
                '        Next
                '        .Columns(colAdd + 1).AdjustToContents()
                '        colAdd = colAdd + 1
                '    End If
                'Next
                'sCol.Add("ID_CONT_DATA", "")
                'sCol.Add("NO_CONT", "")
                'sCol.Add("STW_PLAN", "Stowage")
                'sCol.Add("LOCATION_PLAN", "Location")
                'sCol.Add("ISO", "")
                'sCol.Add("CLASS_DESC", "Class")
                'sCol.Add("OPERATOR", "Operator")
                'sCol.Add("ISO_SIZE", "Size")
                'sCol.Add("TYPE_DESC", "Type")
                'sCol.Add("HEIGHT", "Height")
                'sCol.Add("FM", "F/M")
                'sCol.Add("COMMODITY", "Commodity")
                'sCol.Add("POL", "POL")
                'sCol.Add("POD", "POD")
                'sCol.Add("POR", "POR")
                'sCol.Add("WEIGHT", "Weight (Ton)")
                'sCol.Add("TEMP", "Temp (C)")
                'sCol.Add("IMDG", "")
                'sCol.Add("UNNO", "")
                'sCol.Add("OVER_FRONT", "OD-F")
                'sCol.Add("OVER_BACK", "OD-B")
                'sCol.Add("OVER_LEFT", "OD-L")
                'sCol.Add("OVER_RIGHT", "OD-R")
                'sCol.Add("OVER_TOP", "OD-T")
                Dim sHeader As String() = {"No", "Container Number", "Stowage", "Class", "ISO Code", "Size", "Type", "Height",
                    "Commodity", "F/M", "Weight", "VGM", "Temp", "IMDG", "UNNO", "POR", "POL", "POD", "Operator", "OD-F", "OD-B",
                    "OD-B", "OD-L", "OD-T"}
                For i = 0 To sHeader.Length - 1
                    .Cell(1, i + 1).Value = sHeader(i)
                    .Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.Blue
                    .Cell(1, i + 1).Style.Font.Bold = True
                    .Cell(1, i + 1).Style.Font.FontColor = XLColor.White
                Next

                For row As Integer = 0 To grid_inbound.Rows.Count - 1
                    .Cell(row + 2, 1).Value = row + 1
                    .Cell(row + 2, 2).Value = grid_inbound.Rows(row).Cells("No. Container").Value
                    .Cell(row + 2, 3).Value = grid_inbound.Rows(row).Cells("Stowage").Value
                    .Cell(row + 2, 4).Value = grid_inbound.Rows(row).Cells("Class").Value
                    .Cell(row + 2, 5).Value = grid_inbound.Rows(row).Cells("ISO").Value
                    .Cell(row + 2, 6).Value = grid_inbound.Rows(row).Cells("Size").Value
                    .Cell(row + 2, 7).Value = grid_inbound.Rows(row).Cells("Type").Value
                    .Cell(row + 2, 8).Value = grid_inbound.Rows(row).Cells("Height").Value
                    .Cell(row + 2, 9).Value = grid_inbound.Rows(row).Cells("Commodity").Value
                    .Cell(row + 2, 10).Value = grid_inbound.Rows(row).Cells("F/M").Value
                    .Cell(row + 2, 11).Value = grid_inbound.Rows(row).Cells("Weight (Ton)").Value
                    .Cell(row + 2, 12).Value = grid_inbound.Rows(row).Cells("VGM").Value
                    .Cell(row + 2, 13).Value = grid_inbound.Rows(row).Cells("Temp (C)").Value
                    .Cell(row + 2, 14).Value = grid_inbound.Rows(row).Cells("IMDG").Value
                    .Cell(row + 2, 15).Value = grid_inbound.Rows(row).Cells("UNNO").Value
                    .Cell(row + 2, 16).Value = grid_inbound.Rows(row).Cells("POR").Value
                    .Cell(row + 2, 17).Value = grid_inbound.Rows(row).Cells("POL").Value
                    .Cell(row + 2, 18).Value = grid_inbound.Rows(row).Cells("POD").Value
                    .Cell(row + 2, 19).Value = grid_inbound.Rows(row).Cells("Operator").Value
                    .Cell(row + 2, 20).Value = grid_inbound.Rows(row).Cells("OD-F").Value
                    .Cell(row + 2, 21).Value = grid_inbound.Rows(row).Cells("OD-B").Value
                    .Cell(row + 2, 22).Value = grid_inbound.Rows(row).Cells("OD-L").Value
                    .Cell(row + 2, 23).Value = grid_inbound.Rows(row).Cells("OD-R").Value
                    .Cell(row + 2, 24).Value = grid_inbound.Rows(row).Cells("OD-T").Value
                Next
                
            End With
            wb.SaveAs(fName)
        End Using
        Process.Start(fName)
    End Sub

    Private Sub btn_export_baplie_Click(sender As Object, e As EventArgs) Handles btn_export_baplie.Click
        Dim frm As New FormInboundData_UploadBaplie
        frm.PForm = Me
        frm.ShowDialog()
    End Sub

    Private Sub grid_inbound_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_inbound.CellBeginEdit
        e.Cancel = e.ColumnIndex <> grid_inbound.Columns("Pilih").Index
    End Sub

    Private Sub FormInboundData_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_combo()
        fill_grid()
    End Sub
End Class