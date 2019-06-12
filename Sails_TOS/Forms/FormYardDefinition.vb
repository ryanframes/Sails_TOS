Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Sails_TOS

Public Class FormYardDefinition

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim item As ComboBoxItem
        cmb_search_block_type.Items.Clear()
        item = New ComboBoxItem
        item.Tag = "Area"
        item.Text = "Area"
        cmb_search_block_type.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "Block"
        item.Text = "Block"
        cmb_search_block_type.Items.Add(item)
        cmb_search_block_type.SelectedIndex = 0
    End Sub

    Sub fill_combo()
        Dim dt As DataTable = fc_yrddef_getblock(pubApiAddress, "id_yd=1")
        cmb_search_block_name.Items.Clear()
        cmb_search_slot_block.Items.Clear()
        Dim item As ComboBoxItem
        'default 
        item = New ComboBoxItem
        item.Tag = 0
        item.Text = ""
        cmb_search_block_name.Items.Add(item)
        cmb_search_slot_block.Items.Add(item)
        For i As Integer = 0 To dt.Rows.Count - 1
            item = New ComboBoxItem
            item.Tag = dt.Rows(i)("ID_BLOCK")
            item.Text = dt.Rows(i)("Block Name")
            cmb_search_block_name.Items.Add(item)
            cmb_search_slot_block.Items.Add(item)
        Next
        cmb_search_block_name.SelectedIndex = 0
        cmb_search_slot_block.SelectedIndex = 0
    End Sub

    Sub fill_grid_slot()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_CELL", "")
        sCol.Add("BLOCK_NAME", "Block")
        sCol.Add("ID_STACK", "ID")
        sCol.Add("20_STACKNAME", "20 Stack Name")
        sCol.Add("40_STACKNAME", "40 Stack Name")
        sCol.Add("SIZE_TYPE", "Size Type")
        sCol.Add("CARGO_TYPE", "Cargo Type")
        sCol.Add("USE_FLAG", "Status")

        Dim idBlock As String
        If IsNothing(cmb_search_slot_block.SelectedItem) Then
            idBlock = 0
        Else
            idBlock = cmb_search_slot_block.SelectedItem.tag
        End If
        showDataGrid(grid_slot, pubApiAddress, "rts_yrddef_getslot", "id_block=" & idBlock, sCol)
        grid_slot.Columns("ID_CELL").Visible = False

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"
        grid_slot.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_slot.Rows.Count - 1
            grid_slot.Rows(i).Cells("No").Value = i + 1
        Next
        Dim colChk As New DataGridViewCheckBoxColumn
        colChk.HeaderText = "Select"
        colChk.Name = "Pilih"
        grid_slot.Columns.Insert(1, colChk)

        grid_slot.ReadOnly = False
        autoColWidth(3, grid_slot)
    End Sub

    Sub fill_grid_block()
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

        showDataGrid(grid_block, pubApiAddress, "rts_yrddef_getblock", "id_yd=1&name=" & cmb_search_block_name.Text & "&type=" & cmb_search_block_type.Text, sCol)
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

    Private Sub btn_code_search_Click(sender As Object, e As EventArgs) Handles cmd_search_block.Click
        fill_grid_block()
    End Sub

    Private Sub FormYardDefinition_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub FormYardDefinition_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If grid_block.Columns.Count > 0 Then autoColWidth(3, grid_block)
        If grid_slot.Columns.Count > 0 Then autoColWidth(3, grid_slot)
    End Sub

    Private Sub grid_block_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_block.CellBeginEdit
        If e.ColumnIndex = grid_block.Columns("Pilih").Index Then e.Cancel = False Else e.Cancel = True
    End Sub

    Private Sub btn_add_block_Click(sender As Object, e As EventArgs) Handles btn_add_block.Click
        Dim frm As New FormYardDefinition_Input
        frm.InputType = FormYardDefinition_Input.inputTypes.insert
        frm.PForm = Me
        frm.ShowDialog()
    End Sub

    Private Sub cmd_search_slot_block_Click(sender As Object, e As EventArgs) Handles cmd_search_slot_block.Click
        fill_grid_slot()
    End Sub

    Private Sub cmb_search_slot_block_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_search_slot_block.SelectedIndexChanged

    End Sub

    Private Sub cmb_search_slot_block_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_search_slot_block.SelectedValueChanged
        'fill_grid_slot()
    End Sub

    Private Sub tabMenu_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles tabMenu.SelectedTabChanged
        If pubApiAddress = "" Then Return
        If e.NewValue.Name = "" Then Return
        If e.NewValue.Name = tab_slot.Name Then
            fill_grid_slot()
        ElseIf e.NewValue.Name = tab_block.Name Then
            fill_grid_block()
        End If
    End Sub

    Private Sub cmd_add_slot_Click(sender As Object, e As EventArgs) Handles cmd_add_slot.Click
        If cmb_search_slot_block.Text = "" Then
            MessageBoxEx.Show("Please choose Block Name first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_search_slot_block.Focus()
            Return
        End If
        Dim frm As New FormYardDefinition_InputSlot
        frm.PForm = Me
        frm.BlockID = cmb_search_slot_block.SelectedItem.tag
        frm.InputType = FormYardDefinition_InputSlot.inputTypes.insert
        frm.txt_block_name.Text = cmb_search_slot_block.Text
        frm.ShowDialog()
    End Sub

    Private Function allowEditDelSlot() As Boolean
        If grid_slot.Rows.Count = 0 Then Return False
        If grid_slot.CurrentRow Is Nothing Then Return False
        If Not IsNumeric(grid_slot.CurrentRow.Cells("ID_CELL").Value) Then Return False
        Return True
    End Function

    Private Function allowEditDelBlock() As Boolean
        If grid_block.Rows.Count = 0 Then Return False
        If grid_block.CurrentRow Is Nothing Then Return False
        If Not IsNumeric(grid_block.CurrentRow.Cells("ID_BLOCK").Value) Then Return False
        Return True
    End Function

    Private Sub cmd_delete_slot_Click(sender As Object, e As EventArgs) Handles cmd_delete_slot.Click
        If Not allowEditDelSlot() Then Return
        Dim cellID As New List(Of Integer)
        Dim isOk As Boolean
        'cek apakah row yang dipilih lebih dari 1
        For i As Integer = 0 To grid_slot.Rows.Count - 1
            If grid_slot.Rows(i).Cells("Pilih").Value = True Or grid_slot.Rows(i).Cells("Pilih").Value = 1 Then
                'check jml cell tier yang status =1
                If fc_yrddef_delslot_validation(grid_slot.Rows(i).Cells("ID_CELL").Value) = False Then
                    MessageBoxEx.Show("Delete failed because there is/are slot in use", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                'masukan id ke list untuk di looping proses delete
                cellID.Add(grid_slot.Rows(i).Cells("ID_CELL").Value)
            End If
        Next
        If cellID.Count = 0 Then Return

        Dim res As DialogResult

        res = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        For i = 0 To cellID.Count - 1
            isOk = fc_yrddef_delslot(cellID(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid_slot()
    End Sub

    Private Sub cmd_edit_slot_Click(sender As Object, e As EventArgs) Handles cmd_edit_slot.Click
        If Not allowEditDelSlot() Then Return
        Dim cellID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_slot.Rows.Count - 1
            If grid_slot.Rows(i).Cells("Pilih").Value = True Or grid_slot.Rows(i).Cells("Pilih").Value = 1 Then
                cellID.Add(grid_slot.Rows(i).Cells("ID_CELL").Value)
            End If
        Next

        If cellID.Count = 0 Then Return
        'ambil select yang terakhir
        Dim dt As DataTable = fc_yrddef_getslot(pubApiAddress, "id_cell=" & cellID.Last)
        Dim frm As New FormYardDefinition_InputSlot
        With frm
            .Text = "Edit Slot"
            .InputType = FormYardDefinition_InputSlot.inputTypes.edit
            .PForm = Me
            .CellID = cellID(0)
            .BlockID = cmb_search_slot_block.SelectedItem.tag
            .txt_block_name.Text = cmb_search_slot_block.Text
            .txt_20stack.Text = dt.Rows(0)("20_STACKNAME")
            .txt_40stack.Text = dt.Rows(0)("40_STACKNAME")
            Dim s() As String = Split(dt.Rows(0)("SIZE_TYPE"), ",")
            For i = 0 To s.Length - 1
                For Each t As Controls.EditToken In .cmb_size_type.Tokens
                    If t.Text = s(i) Then
                        .cmb_size_type.SelectedTokens.Add(t)
                    End If
                Next
            Next
            s = Split(dt.Rows(0)("CARGO_TYPE"), ",")
            For i = 0 To s.Length - 1
                For Each t As Controls.EditToken In .cmb_cargo_type.Tokens
                    If t.Text = s(i) Then
                        .cmb_cargo_type.SelectedTokens.Add(t)
                    End If
                Next
            Next
            .cmb_status.SelectedIndex = IIf(dt.Rows(0)("USE_FLAG") = "N", 1, 0)
            .ShowDialog()
        End With
    End Sub

    Private Sub grid_slot_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_slot.CellBeginEdit
        e.Cancel = e.ColumnIndex <> grid_slot.Columns("Pilih").Index
    End Sub

    Private Sub btn_delete_block_Click(sender As Object, e As EventArgs) Handles btn_delete_block.Click
        If Not allowEditDelBlock() Then Return
        Dim blockID As New List(Of Integer)
        Dim isOk As Boolean
        'cek apakah row yang dipilih lebih dari 1
        For i As Integer = 0 To grid_block.Rows.Count - 1
            If grid_block.Rows(i).Cells("Pilih").Value = True Or grid_block.Rows(i).Cells("Pilih").Value = 1 Then
                'check jml cell tier yang status =1
                If fc_yrddef_delblock_validation(grid_block.Rows(i).Cells("ID_BLOCK").Value) = False Then
                    MessageBoxEx.Show("Delete failed because there is/are slot in use", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                'masukan id ke list untuk di looping proses delete
                blockID.Add(grid_block.Rows(i).Cells("ID_BLOCK").Value)
            End If
        Next
        If blockID.Count = 0 Then Return

        Dim res As DialogResult

        res = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        For i = 0 To blockID.Count - 1
            isOk = fc_yrddef_delblock(blockID(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid_block()
    End Sub

    Private Sub btn_edit_block_Click(sender As Object, e As EventArgs) Handles btn_edit_block.Click
        If Not allowEditDelBlock() Then Return

        Dim blockID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_block.Rows.Count - 1
            If grid_block.Rows(i).Cells("Pilih").Value = True Or grid_block.Rows(i).Cells("Pilih").Value = 1 Then
                blockID.Add(grid_block.Rows(i).Cells("ID_BLOCK").Value)
            End If
        Next

        If blockID.Count = 0 Then Return
        'ambil select yang terakhir
        'Dim sCol As New Dictionary(Of String, String)
        'sCol.Add("ID_BLOCK", "")
        'sCol.Add("BLOCK_NAME", "Block Name")
        'sCol.Add("BLOCK_TYPE", "Type")
        'sCol.Add("MAX_ROW", "Max Row")
        'sCol.Add("MAX_TIER", "Max Tier")
        'sCol.Add("AVB_TIER", "Available Tier")
        'sCol.Add("POS_X", "Pos X")
        'sCol.Add("POS_Y", "Pos Y")
        'sCol.Add("DESIGN_CAPACITY", "Design Capacity")
        'sCol.Add("AVB_CAPACITY", "Available Capacity")
        'sCol.Add("STACK_DIRECTION", "Stack Direction")
        'sCol.Add("ROW_DIRECTION", "Row Direction")
        'sCol.Add("USE_FLAG", "Status")
        Dim dt As DataTable = fc_yrddef_getblock(pubApiAddress, "id=" & blockID.Last)
        Dim frm As New FormYardDefinition_Input
        With frm
            .Text = "Edit Block"
            .InputType = FormYardDefinition_Input.inputTypes.edit
            .PForm = Me
            .BlockID = blockID.Last
            .txt_block_name.Text = dt.Rows(0)("Block Name")
            .cmb_stack_direction.SelectedIndex = getComboIndexByKey(.cmb_stack_direction, dt.Rows(0)("Stack Direction"))
            .cmb_block_type.SelectedIndex = getComboIndexByKey(.cmb_block_type, dt.Rows(0)("Type"))
            .cmb_row_direction.SelectedIndex = getComboIndexByKey(.cmb_row_direction, dt.Rows(0)("Row Direction"))
            .txt_max_row.Text = dt.Rows(0)("Max Row")
            .txt_design_capacity.Text = dt.Rows(0)("Design Capacity")
            .txt_max_tier.Text = dt.Rows(0)("Max Tier")
            .txt_avail_capacity.Text = dt.Rows(0)("Available Capacity")
            .txt_available_tier.Text = dt.Rows(0)("Available Tier")
            .txt_position_x.Text = dt.Rows(0)("Pos X")
            .txt_position_y.Text = dt.Rows(0)("Pos Y")
            .cmb_status.SelectedIndex = IIf(dt.Rows(0)("Status") = "N", 1, 0)
            .ShowDialog()
        End With
    End Sub


    Private Function getComboIndexByKey(ByVal cmb As ComboBoxEx, ByVal val As String) As Integer
        For i = 0 To cmb.Items.Count - 1
            If cmb.Items(i).tag = val Then
                Return i
            End If
        Next
        Return 0
    End Function

    Private Sub FormYardDefinition_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_combo()
        fill_grid_block()
    End Sub
End Class