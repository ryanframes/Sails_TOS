Imports DevComponents.DotNetBar

Public Class FormTruckCode
    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        '{"TRUCK_ID", "TID", "Truck Number", "Status", "RFID Code", "Last In Date",
        '   "Last Out Date", "ITV Flag", "Trucking Company", "Remarks"}
        'SETTING COL
        sCol.Add("TRUCK_ID", "")
        sCol.Add("TID", "")
        sCol.Add("TRUCK_NUMBER", "Truck Number")
        sCol.Add("STATUS", "Status")
        sCol.Add("RFID_CODE", "RFID Code")
        sCol.Add("LAST_IN_DATE", "Last In Date")
        sCol.Add("LAST_OUT_DATE", "Last Out Date")
        sCol.Add("ITV_FLAG", "ITV Flag")
        sCol.Add("TRUCKING_COMPANY", "Trucking Company")
        sCol.Add("REMARKS", "Remarks")

        Dim whereCondition As String = IIf(txt_code.Text = "", "", "field=TRUCK_NUMBER&val=" & txt_code.Text & "&cond=1")
        showDataGrid(grid_truck_code, pubApiAddress, "rts_trucde_getdata", whereCondition, sCol)

        'add col check
        Dim chk As New DataGridViewCheckBoxColumn
        chk.HeaderText = "Select"
        chk.Name = "Pilih"
        grid_truck_code.Columns.Insert(0, chk)
        grid_truck_code.Columns("TRUCK_ID").Visible = False

        grid_truck_code.ReadOnly = False
        autoColWidth(grid_truck_code.Columns.Count - 1, grid_truck_code)
    End Sub

    Private Sub FormTruckCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim frm As New FormTruckCode_Input
        frm.pForm = Me
        frm.inputType = FormTruckCode_Input.inputTypes.insert
        frm.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If Not allowEditDel() Then Return
        Dim frm As New FormTruckCode_Input
        With frm
            .pForm = Me
            .Text = "Edit Truck Code"
            .inputType = FormTruckCode_Input.inputTypes.edit
            .truckID = grid_truck_code.CurrentRow.Cells("TRUCK_ID").Value
            .txt_tid.Text = grid_truck_code.CurrentRow.Cells("TID").Value
            .txt_truck_number.Text = grid_truck_code.CurrentRow.Cells("Truck Number").Value
            .txt_rfid.Text = grid_truck_code.CurrentRow.Cells("RFID Code").Value
            .txt_truck_company.Text = grid_truck_code.CurrentRow.Cells("Trucking Company").Value
            .cmb_itv.Text = IIf(grid_truck_code.CurrentRow.Cells("ITV Flag").Value = "Y", "Yes", "No")
            .txt_remarks.Text = grid_truck_code.CurrentRow.Cells("Remarks").Value
            .ShowDialog()
        End With

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not allowEditDel() Then Return
        Dim iRow As Integer = 0
        Dim truckId As New List(Of Integer)
        'cek apakah row yang dipilih lebih dari 1
        For i As Integer = 0 To grid_truck_code.Rows.Count - 1
            If grid_truck_code.Rows(i).Cells("Pilih").Value = True Or grid_truck_code.Rows(i).Cells("Pilih").Value = 1 Then
                'masukan truck id ke list untuk di looping proses delete
                truckId.Add(grid_truck_code.Rows(i).Cells("TRUCK_ID").Value)
            End If
        Next
        If truckId.Count = 0 Then Return

        Dim res As DialogResult
        Dim isOk As Boolean
        Dim sMsg As String
        If truckId.Count = 1 Then
            sMsg = "Are you sure want to delete " & vbCrLf & "Truck No. " & grid_truck_code.CurrentRow.Cells("Truck Number").Value & " ?"
        Else
            sMsg = "Are you sure want to delete selected records ?"
        End If
        res = MessageBoxEx.Show(sMsg, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        For i = 0 To truckId.Count - 1
            isOk = fc_trucde_deldata(truckId(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid()
    End Sub

    Private Sub btn_code_search_Click(sender As Object, e As EventArgs) Handles btn_code_search.Click
        fill_grid()
    End Sub

    Private Function allowEditDel() As Boolean
        If grid_truck_code.Rows.Count = 0 Then Return False
        If grid_truck_code.CurrentRow Is Nothing Then Return False
        If Not IsNumeric(grid_truck_code.CurrentRow.Cells("TRUCK_ID").Value) Then Return False
        Return True
    End Function

    Private Sub txt_code_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub txt_code_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_code.KeyUp
        If e.KeyCode = Keys.Enter Then fill_grid()
    End Sub

    Private Sub FormTruckCode_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If grid_truck_code.Columns.Count > 0 Then autoColWidth(grid_truck_code.Columns.Count - 1, grid_truck_code)
    End Sub

    Private Sub grid_truck_code_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_truck_code.CellContentClick

    End Sub

    Private Sub grid_truck_code_DoubleClick(sender As Object, e As EventArgs) Handles grid_truck_code.DoubleClick
        btn_edit.PerformClick()
    End Sub

    Private Sub grid_truck_code_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_truck_code.CellBeginEdit
        If grid_truck_code.Columns(e.ColumnIndex).Name = "Pilih" Then e.Cancel = False Else e.Cancel = True
    End Sub

    Private Sub FormTruckCode_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_grid()
    End Sub
End Class