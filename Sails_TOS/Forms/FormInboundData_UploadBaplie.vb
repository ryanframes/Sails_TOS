Imports LumenWorks.Framework.IO.Csv
Imports DevComponents.DotNetBar
Imports System.IO
Imports Sails_TOS

Enum importTypes
    Append = 1
    Overwrite = 2
End Enum

Public Class FormInboundData_UploadBaplie

    Private _pForm As FormInboundData
    Private _v_pub_id_vvd As String

    Public Property PForm As FormInboundData
        Get
            Return _pForm
        End Get
        Set(value As FormInboundData)
            _pForm = value
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

    Private Sub fill_combo()
        cmb_type.Items.Add("CSV")
        cmb_type.Items.Add("EDIFACT")
        cmb_type.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_type.SelectedIndex = 0
        cmb_method.Items.Add("Append")
        cmb_method.Items.Add("Overwrite")
        cmb_method.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_method.SelectedIndex = 0
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_gen_template_Click(sender As Object, e As EventArgs) Handles btn_gen_template.Click

    End Sub

    Private Sub FormInboundData_UploadBaplie_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill_combo()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cmb_type.Text = "CSV" Then
            dlg.Filter = "CSV File (Comma Delimited)|*.csv;*.csv"
        Else
            dlg.Filter = "EDIFACT File|*.EDIFACT;*.edifact"
        End If
        Dim res As DialogResult = dlg.ShowDialog
        If res = DialogResult.Cancel Then Return
        txt_file.Text = dlg.FileName
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not System.IO.File.Exists(txt_file.Text) Then
            MessageBoxEx.Show("File doesn't exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmb_type.Text = "CSV" Then
            If cmb_method.Text = "Append" Then importCsvAdo(importTypes.Append) Else importCsvAdo(importTypes.Overwrite)
        Else
            MessageBoxEx.Show("Feature Coming Soon", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'For i As Integer = 0 To dt.Rows.Count - 1
        'Dim sCol As New Dictionary(Of String, String)
        'sCol.Add("NO_CONT", dt.Rows(i)(1).ToString)
        'sCol.Add("ID_VVD", _v_pub_id_vvd)
        'sCol.Add("STW_PLAN", dt.Rows(i)(2).ToString)
        'sCol.Add("CLASS", dt.Rows(i)(3).ToString)
        'sCol.Add("ISO", dt.Rows(i)(4).ToString)
        'sCol.Add("SIZE", dt.Rows(i)(5).ToString)
        'sCol.Add("CONT_TYPE", dt.Rows(i)(6).ToString)
        'sCol.Add("HEIGHT", dt.Rows(i)(7).ToString)
        'sCol.Add("COMMODITY", dt.Rows(i)(8).ToString)
        'sCol.Add("FM", dt.Rows(i)(9).ToString)
        'sCol.Add("WEIGHT", dt.Rows(i)(10).ToString)
        'sCol.Add("VGM", dt.Rows(i)(11).ToString)
        'sCol.Add("TEMP", dt.Rows(i)(12).ToString)
        'sCol.Add("IMDG", dt.Rows(i)(13).ToString)
        'sCol.Add("UNNO", dt.Rows(i)(14).ToString)
        'sCol.Add("POR", dt.Rows(i)(15).ToString)
        'sCol.Add("POL", dt.Rows(i)(16).ToString)
        'sCol.Add("POD", dt.Rows(i)(17).ToString)
        'sCol.Add("OPERATOR", dt.Rows(i)(18).ToString)
        'sCol.Add("OVER_FRONT", dt.Rows(i)(19).ToString)
        'sCol.Add("OVER_BACK", dt.Rows(i)(20).ToString)
        'sCol.Add("OVER_LEFT", dt.Rows(i)(21).ToString)
        'sCol.Add("OVER_RIGHT", dt.Rows(i)(22).ToString)
        'sCol.Add("OVER_TOP", dt.Rows(i)(23).ToString)

        ''cek bay info
        'stowage = dt.Rows(i)(2)
        'bayNo = stowage.Substring(0, 2)
        'rowNo = IIf(stowage.Length > 3, stowage.Substring(2, 2), "")
        'tierNo = IIf(stowage.Length > 5, stowage.Substring(4, 2), "")
        'sCol.Add("BAY_NO", bayNo)
        'sCol.Add("ROW_NO", rowNo)
        'sCol.Add("TIER_NO", tierNo)
        'sCol.Add("AVAIL_STATUS", 1)
        ''jika size = 40,tambahkan kondisi ini
        'If CInt(dt.Rows(i)(5)) = 45 Then sCol.Add("CELL_45", 1) : sCol.Add("BAY_SIZE", 40)
        ''jika type = reefer / rf tambahkan kondisi ini
        'If dt.Rows(i)(5) = "RF" Then sCol.Add("CELL_REEFER_RACK", 1)

        'If importType = importTypes.Append Then
        '    isOk = fc_inbdta_savedata(sCol)
        'Else
        '    'get con data id
        '    _conDataID = dt.Rows(i)(0)
        '    'del prev info
        '    isOk = fc_inbdta_deldata(_conDataID)
        '    'save new info
        '    isOk = fc_inbdta_savedata(sCol)
        'End If
        'Next
    End Sub

    Private Function importCsvAdo(importType As importTypes)
        Dim dt As DataTable '= getDataTableFromCsv(txt_file.Text, True)
        'If IsNothing(dt) Then Return False

        Dim isOk As Boolean
        Dim stowage As String
        Dim bayNo As String
        Dim rowNo As String
        Dim tierNo As String
        Dim _conDataID As Long
        Try
            Dim col As Integer
            Using csv As New CsvReader(New StreamReader(txt_file.Text), True)
                col = csv.FieldCount
                Do While csv.ReadNextRecord
                    Dim sCol As New Dictionary(Of String, String)
                    sCol.Add("NO_CONT", csv(1).ToString)
                    sCol.Add("ID_VVD", _v_pub_id_vvd)
                    sCol.Add("STW_PLAN", csv(2).ToString)
                    sCol.Add("CLASS", csv(3).ToString)
                    sCol.Add("ISO", csv(4).ToString)
                    sCol.Add("SIZE", csv(5).ToString)
                    sCol.Add("CONT_TYPE", csv(6).ToString)
                    sCol.Add("HEIGHT", csv(7).ToString)
                    sCol.Add("COMMODITY", csv(8).ToString)
                    sCol.Add("FM", csv(9).ToString)
                    sCol.Add("WEIGHT", csv(10).ToString)
                    sCol.Add("VGM", csv(11).ToString)
                    sCol.Add("TEMP", csv(12).ToString)
                    sCol.Add("IMDG", csv(13).ToString)
                    sCol.Add("UNNO", csv(14).ToString)
                    sCol.Add("POR", csv(15).ToString)
                    sCol.Add("POL", csv(16).ToString)
                    sCol.Add("POD", csv(17).ToString)
                    sCol.Add("OPERATOR", csv(18).ToString)
                    sCol.Add("OVER_FRONT", csv(19).ToString)
                    sCol.Add("OVER_BACK", csv(20).ToString)
                    sCol.Add("OVER_LEFT", csv(21).ToString)
                    sCol.Add("OVER_RIGHT", csv(22).ToString)
                    sCol.Add("OVER_TOP", csv(23).ToString)

                    'cek bay info
                    stowage = csv(2)
                    bayNo = stowage.Substring(0, 2)
                    rowNo = IIf(stowage.Length > 3, stowage.Substring(2, 2), "")
                    tierNo = IIf(stowage.Length > 5, stowage.Substring(4, 2), "")
                    sCol.Add("BAY_NO", bayNo)
                    sCol.Add("ROW_NO", rowNo)
                    sCol.Add("TIER_NO", tierNo)
                    sCol.Add("AVAIL_STATUS", 1)
                    'jika size = 40,tambahkan kondisi ini
                    If CInt(csv(5)) = 45 Then sCol.Add("CELL_45", 1) : sCol.Add("BAY_SIZE", 40)
                    'jika type = reefer / rf tambahkan kondisi ini
                    If csv(5) = "RF" Then sCol.Add("CELL_REEFER_RACK", 1)

                    If importType = importTypes.Append Then
                        isOk = fc_inbdta_savedata(sCol)
                    Else
                        'get con data id
                        _conDataID = csv(0)
                        dt = fc_inbdta_getdata(pubApiAddress, "no_cont=" & csv(1).ToString & "&stowage=" & stowage)
                        If dt.Rows.Count > 0 Then
                            For i = 0 To dt.Rows.Count - 1
                                'del prev info
                                isOk = fc_inbdta_deldata(dt.Rows(i)("ID_CON_DATA"))
                            Next

                        End If
                        'save new info
                        isOk = fc_inbdta_savedata(sCol)
                    End If
                Loop
            End Using

            If isOk Then
                MessageBoxEx.Show("Upload Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PForm.fill_grid()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return isok
    End Function
End Class