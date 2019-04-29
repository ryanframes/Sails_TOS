Imports DevComponents.DotNetBar

Public Class FormYardDefinition
    Sub fill_combo()
        Dim dt As DataTable = fc_mchtyp_getdata(pubApiAddress)
        cmb_search_code.Items.Clear()
        Dim item As ComboBoxItem
        cmb_search_code.Items.Add("")
        For i As Integer = 0 To dt.Rows.Count - 1
            item = New ComboBoxItem
            item.Tag = dt.Rows(i)("MCH_TYPE_CODE")
            item.Text = dt.Rows(i)("MCH_TYPE_CODE")
            cmb_search_code.Items.Add(item)
        Next
    End Sub

    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_BLOCK", "")
        sCol.Add("BLOCK_NAME", "Block Name")
        sCol.Add("BLOCK_TYPE", "Type")
        sCol.Add("MAX_ROW", "Max Row")
        sCol.Add("MAX_TIER", "Max Tier")
        sCol.Add("AVB_TIER", "Available Tier")
        sCol.Add("POS_X", "Pos X")
        sCol.Add("POS_Y", "Pos Y")
        sCol.Add("DESIGN_CAPACITY", "Design Capacity")
        sCol.Add("AVB_CAPACITY", "Available Capacity")
        sCol.Add("STACK_DIRECTION", "Stack Direction")
        sCol.Add("ROW_DIRECTION", "Row Direction")
        sCol.Add("USE_FLAG", "Status")

        Dim whereCondition As String = IIf(cmb_search_code.Text = "", "", "kode=" & cmb_search_code.Text)
        showDataGrid(grid_block, pubApiAddress, "rts_yrddef_getblock", whereCondition, sCol)
        grid_block.Columns("ID_BLOCK").Visible = False

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"
        grid_block.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_block.Rows.Count - 1
            grid_block.Rows(i).Cells("No").Value = i + 1
        Next
        Dim colChk As New DataGridViewCheckBoxColumn
        colChk.HeaderText = "Select"
        colChk.Name = "Pilih"
        grid_block.Columns.Insert(1, colChk)

        grid_block.ReadOnly = False

        autoColWidth(3, grid_block)
    End Sub

    Private Sub btn_code_search_Click(sender As Object, e As EventArgs) Handles btn_code_search.Click
        fill_grid()
    End Sub

    Private Sub FormYardDefinition_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
        fill_combo()
        fill_grid()
    End Sub

    Private Sub FormYardDefinition_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If grid_block.Columns.Count > 0 Then autoColWidth(3, grid_block)
    End Sub

    Private Sub grid_block_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_block.CellBeginEdit
        If e.ColumnIndex = grid_block.Columns("Pilih").Index Then e.Cancel = False Else e.Cancel = True
    End Sub
End Class