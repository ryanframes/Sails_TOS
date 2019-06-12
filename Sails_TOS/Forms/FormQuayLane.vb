Public Class FormQuayLane
    Dim is_edit As Boolean = False
    Private Sub fill_grid()
        'Dim dt_machine As DataTable 
        Dim dt_quay As DataTable = fc_quylne_getdata(pubApiAddress)

        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_CODE", "Equipment")
        sCol.Add("LANE", "")
        showDataGrid(grid_quay, pubApiAddress, "rts_mchlne_getdata", "kode=QC", sCol)
        'dt_machine = CType(grid_quay.DataSource, DataTable)
        grid_quay.Columns("LANE").Visible = False
        'add data quay to datatable machine
        For i As Integer = 0 To dt_quay.Rows.Count - 1
            Dim chk As New DataGridViewImageColumn
            chk.HeaderText = dt_quay.Rows(i)("QUAY_DESC")
            chk.Name = dt_quay.Rows(i)("QUAY_DESC")
            chk.DefaultCellStyle.NullValue = Nothing
            chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grid_quay.Columns.Add(chk)
        Next

        'set lane value here
        Dim arr_lane As String()
        For i = 0 To grid_quay.Rows.Count - 1
            'Separated by comma
            arr_lane = Split(grid_quay.Rows(i).Cells("LANE").Value.ToString, ",")
            'looping grid col
            For j As Integer = 0 To grid_quay.Columns.Count - 1
                'check if this machine have selected lane
                If arr_lane.Contains(grid_quay.Columns(j).HeaderText) Then
                    grid_quay.Rows(i).Cells(j).Value = My.Resources.icons8_checkmark_16
                    grid_quay.Rows(i).Cells(j).Tag = True
                End If
            Next
        Next

        'add col check
        Dim colChk As New DataGridViewCheckBoxColumn
        colChk.HeaderText = "Select"
        colChk.Name = "Pilih"
        grid_quay.Columns.Insert(0, colChk)

        autoColWidth(1, grid_quay)
    End Sub
    Private Sub FormQuayLane_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_grid()
    End Sub

    Private Sub FormQuayLane_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub grid_quay_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_quay.CellBeginEdit
        If btn_save.Visible And e.ColumnIndex = grid_quay.Columns("Pilih").Index Then
            e.Cancel = False 'if edit mode, then do not allow user to uncheck 
        ElseIf btn_save.Visible = False Then
            e.Cancel = e.ColumnIndex <> grid_quay.Columns("Pilih").Index
        End If
    End Sub

    Private Sub btn_add_type_Click(sender As Object, e As EventArgs) Handles btn_add_type.Click
        Dim is_checked As Boolean = False
        For i As Integer = 0 To grid_quay.Rows.Count - 1
            If grid_quay.Rows(i).Cells("Pilih").Value = True Or grid_quay.Rows(i).Cells("Pilih").Value = 1 Then
                is_checked = True
                'change all lane col to checkbox
                For j As Integer = 3 To grid_quay.Columns.Count - 1
                    Dim chkCell As New DataGridViewCheckBoxCell 'init new checkbox cell
                    If Not IsNothing(grid_quay.Rows(i).Cells(j).Tag) Then
                        chkCell.Value = grid_quay.Rows(i).Cells(j).Tag 'set value checkboxcell
                        chkCell.Tag = grid_quay.Rows(i).Cells(j).Tag 'store value to tag
                    Else
                        chkCell.Value = False
                    End If
                    grid_quay.Rows(i).Cells(j) = chkCell 'change celltype
                Next
            End If
        Next
        btn_save.Visible = is_checked
        btn_cancel.Visible = is_checked
    End Sub

    Private Sub grid_quay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_quay.CellContentClick
        If e.ColumnIndex = grid_quay.Columns("Pilih").Index Then
            If btn_save.Visible = False Then
                'hanya bisa di edit saat bukan mode edit
                grid_quay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = grid_quay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> True
            End If
        End If
        If btn_save.Visible = True And e.ColumnIndex > 2 And grid_quay.Rows(e.RowIndex).Cells("Pilih").Value = True Then
            'set checkbox
            grid_quay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = grid_quay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> True
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        For i As Integer = 0 To grid_quay.Rows.Count - 1
            If grid_quay.Rows(i).Cells("Pilih").Value = True Or grid_quay.Rows(i).Cells("Pilih").Value = 1 Then
                'change all lane col to imagecell
                For j As Integer = 3 To grid_quay.Columns.Count - 1
                    Dim imgCell As New DataGridViewImageCell 'init new img cell
                    If Not IsNothing(grid_quay.Rows(i).Cells(j).Tag) Then
                        If grid_quay.Rows(i).Cells(j).Tag = True Then
                            imgCell.Tag = grid_quay.Rows(i).Cells(j).Tag 'set tag imagecell from checkbox value
                            imgCell.Value = My.Resources.icons8_checkmark_16
                        End If
                    Else
                        imgCell.Tag = False
                    End If
                    grid_quay.Rows(i).Cells(j) = imgCell 'change celltype
                Next
            End If
        Next
        btn_save.Visible = False
        btn_cancel.Visible = False
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'save lane
        Dim lane As String
        Dim isOk As Boolean
        For i As Integer = 0 To grid_quay.Rows.Count - 1
            If grid_quay.Rows(i).Cells("Pilih").Value = True Or grid_quay.Rows(i).Cells("Pilih").Value = 1 Then
                lane = "" 'reset lane
                For j As Integer = 3 To grid_quay.Columns.Count - 1
                    If grid_quay.Rows(i).Cells(j).Value Then 'if lane checked
                        lane = lane & IIf(lane = "", "", ",") & grid_quay.Columns(j).HeaderText
                    End If
                Next
                Dim sCol As New Dictionary(Of String, String)
                sCol.Add("kode", grid_quay.Rows(i).Cells("Equipment").Value)
                sCol.Add("LANE", lane)
                isOk = fc_mchlne_upddata(sCol)
            End If
        Next
        btn_save.Visible = False
        btn_cancel.Visible = False

        'refresh grid
        fill_grid()
    End Sub
End Class