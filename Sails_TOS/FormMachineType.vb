Imports DevComponents.DotNetBar

Public Class FormMachineType
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
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
        sCol.Add("MCH_TYPE_CODE", "Code")
        sCol.Add("MCH_TYPE_NAME", "Description")
        Dim whereCondition As String = IIf(cmb_search_code.Text = "", "", "kode=" & cmb_search_code.Text)
        showDataGrid(grid_machine_type, pubApiAddress, "rts_mchtyp_getdata", whereCondition, sCol)
        autoColWidth(1, grid_machine_type)

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"

        grid_machine_type.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_machine_type.Rows.Count - 1
            grid_machine_type.Rows(i).Cells("No").Value = i + 1
        Next
    End Sub

    Private Sub FormMachineType_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
        fill_grid()
        fill_combo()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim frm As New FormMachineType_Input
        frm.pForm = Me
        frm.inputType = FormMachineType_Input.inputTypes.insert
        frm.ShowDialog()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If Not allowEditDel() Then Return
        Dim frm As New FormMachineType_Input
        With frm
            .pForm = Me
            .Text = "Edit Machine Type"
            .inputType = FormMachineType_Input.inputTypes.edit
            .txt_code.Enabled = False
            .txt_code.Text = grid_machine_type.CurrentRow.Cells("Code").Value
            .txt_description.Text = grid_machine_type.CurrentRow.Cells("Description").Value
            .ShowDialog()
        End With

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not allowEditDel() Then Return
        Dim res As DialogResult = confirmDel()
        If res = DialogResult.No Then Return

        Dim isOk As Boolean = fc_mchtyp_deldata(grid_machine_type.CurrentRow.Cells("Code").Value)
        msgDel(isOk)
        If isOk Then grid_machine_type.Rows.Remove(grid_machine_type.CurrentRow) : fill_combo()
    End Sub

    Private Sub btn_code_search_Click(sender As Object, e As EventArgs) Handles btn_code_search.Click
        fill_grid()
    End Sub

    Private Sub grid_machine_type_DoubleClick(sender As Object, e As EventArgs) Handles grid_machine_type.DoubleClick
        btn_edit.PerformClick()
    End Sub

    Private Sub FormMachineType_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If grid_machine_type.Columns.Count > 0 Then autoColWidth(1, grid_machine_type)
    End Sub

    Private Function allowEditDel() As Boolean
        If grid_machine_type.Rows.Count = 0 Then Return False
        If grid_machine_type.SelectedRows Is Nothing Then Return False
        Return True
    End Function

    Private Sub grid_machine_type_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_machine_type.CellContentClick

    End Sub
End Class
