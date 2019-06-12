Imports DevComponents.DotNetBar

Public Class FormMachineSpec
    Sub fill_combo()
        Dim dt As DataTable = fc_mchspc_getdata(pubApiAddress)
        'set auto complete
        autocomplete_text(txt_code, dt, "MCH_CODE")

        dt = dt.DefaultView.ToTable(True, "MCH_TYPE_CODE")
        cmb_type.Items.Clear()
        Dim item As ComboBoxItem
        cmb_type.Items.Add("")
        For i As Integer = 0 To dt.Rows.Count - 1
            item = New ComboBoxItem
            item.Tag = dt.Rows(i)("MCH_TYPE_CODE")
            item.Text = dt.Rows(i)("MCH_TYPE_CODE")
            cmb_type.Items.Add(item)
        Next

    End Sub

    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_CODE", "Code")
        sCol.Add("MCH_TYPE_CODE", "Type")
        sCol.Add("HEIGHT", "Height")
        sCol.Add("CAPACITY", "Capacity")
        sCol.Add("COLOR_B", "B.Color")
        sCol.Add("COLOR_F", "F.Color")
        sCol.Add("ON_OFF", "Status")
        sCol.Add("FROM_COVERAGE", "From Coverage")
        sCol.Add("TO_COVERAGE", "To Coverage")
        sCol.Add("FROM_COV2", "From COV2")
        sCol.Add("TO_COV2", "To COV2")

        Dim whereCondition As String = IIf(txt_code.Text = "", "", "kode=" & txt_code.Text)
        whereCondition = whereCondition & IIf(whereCondition = "", "", "&") & "tipe=" & cmb_type.Text
        showDataGrid(grid_spec, pubApiAddress, "rts_mchspc_getdata", whereCondition, sCol)
        autoColWidth(1, grid_spec)

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"

        grid_spec.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_spec.Rows.Count - 1
            grid_spec.Rows(i).Cells("No").Value = i + 1
            'change backcolor grid
            grid_spec.Rows(i).Cells("B.Color").Style.BackColor = ColorTranslator.FromHtml(grid_spec.Rows(i).Cells("B.Color").Value)
            grid_spec.Rows(i).Cells("F.Color").Style.BackColor = ColorTranslator.FromHtml(grid_spec.Rows(i).Cells("F.Color").Value)
            'convert status
            grid_spec.Rows(i).Cells("Status").Value = IIf(grid_spec.Rows(i).Cells("Status").Value = 1, "On", "Off")
        Next
    End Sub

    Private Sub FormMachineSpec_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
        'fill_grid()
        'fill_combo()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim frm As New FormMachineSpec_Input
        frm.PForm = Me
        frm.InputType = inputTypes.insert
        frm.ShowDialog()
    End Sub

    Private Sub txt_code_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_code.KeyUp
        'fill_grid()
    End Sub

    Private Sub cmb_type_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedValueChanged
        'fill_grid()
    End Sub

    Private Function allowEditDel() As Boolean
        If grid_spec.Rows.Count = 0 Then Return False
        If grid_spec.SelectedRows Is Nothing Then Return False
        Return True
    End Function

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If Not allowEditDel() Then Return
        Dim frm As New FormMachineSpec_Input
        With frm
            .Text = "Edit Machine Specification"
            .PForm = Me
            .InputType = inputTypes.edit
            .txt_code.Text = grid_spec.CurrentRow.Cells("Code").Value
            .txt_code.Enabled = False
            For i As Integer = 0 To .cmb_type.Items.Count - 1
                If .cmb_type.Items(i).Tag = grid_spec.CurrentRow.Cells("Type").Value Then
                    .cmb_type.SelectedIndex = i
                    Exit For
                End If
            Next
            .txt_capacity.Text = grid_spec.CurrentRow.Cells("Capacity").Value
            .cp_backcolor.SelectedColor = grid_spec.CurrentRow.Cells("B.Color").Style.BackColor
            .cp_forecolor.SelectedColor = grid_spec.CurrentRow.Cells("F.Color").Style.BackColor
            .sw_stat.Value = grid_spec.CurrentRow.Cells("Status").Value = "On"
            .txt_fromcvrg.Text = grid_spec.CurrentRow.Cells("From Coverage").Value
            .txt_tocvrg.Text = grid_spec.CurrentRow.Cells("To Coverage").Value
            .txt_fromcov.Text = grid_spec.CurrentRow.Cells("From COV2").Value
            .txt_tocov.Text = grid_spec.CurrentRow.Cells("To COV2").Value
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not allowEditDel() Then Return
        Dim res As DialogResult = confirmDel()
        If res = DialogResult.No Then Return

        Dim isOk As Boolean = fc_mchspc_deldata(grid_spec.CurrentRow.Cells("Code").Value)
        msgDel(isOk)
        If isOk Then grid_spec.Rows.Remove(grid_spec.CurrentRow) : fill_combo()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        fill_grid()
    End Sub

    Private Sub FormMachineSpec_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_combo()
        fill_grid()
    End Sub
End Class