Imports DevComponents.DotNetBar

Public Class FormDamageCode
    Sub fill_grid_type()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_DMG", "")
        sCol.Add("DMG_CODE", "Code")
        sCol.Add("DMG_DESC", "Description")
        showDataGrid(grid_type, pubApiAddress, "rts_dmgcde_gettype", Nothing, sCol)

        grid_type.Columns("ID_DMG").Visible = False
        ''add col no
        'Dim colNo As New DataGridViewTextBoxColumn
        'colNo.HeaderText = "No."
        'colNo.Name = "No"

        'grid_type.Columns.Insert(0, colNo)
        ''fill col no.
        'For i As Integer = 0 To grid_type.Rows.Count - 1
        '    grid_type.Rows(i).Cells("No").Value = i + 1
        'Next
        'add col check
        Dim colChk As New DataGridViewCheckBoxColumn
        colChk.HeaderText = "Select"
        colChk.Name = "Pilih"
        grid_type.Columns.Insert(1, colChk)

        grid_type.ReadOnly = False
        autoColWidth(3, grid_type)
    End Sub

    Sub fill_grid_part()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_DMG_LOC", "")
        sCol.Add("LOC_CODE", "Code")
        sCol.Add("LOC_DESC", "Description")
        showDataGrid(grid_part, pubApiAddress, "rts_dmgcde_getpart", Nothing, sCol)

        grid_part.Columns("ID_DMG_LOC").Visible = False
        ''add col no
        'Dim colNo As New DataGridViewTextBoxColumn
        'colNo.HeaderText = "No."
        'colNo.Name = "No"

        'grid_part.Columns.Insert(0, colNo)
        ''fill col no.
        'For i As Integer = 0 To grid_part.Rows.Count - 1
        '    grid_part.Rows(i).Cells("No").Value = i + 1
        'Next
        'add col check
        Dim colChk As New DataGridViewCheckBoxColumn
        colChk.HeaderText = "Select"
        colChk.Name = "Pilih"
        grid_part.Columns.Insert(1, colChk)

        grid_part.ReadOnly = False
        autoColWidth(3, grid_part)
    End Sub

    Sub fill_grid_grade()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_DMG_GRADE", "")
        sCol.Add("GRADE_CODE", "Code")
        sCol.Add("GRADE_DESC", "Description")
        showDataGrid(grid_grade, pubApiAddress, "rts_dmgcde_getgrade", Nothing, sCol)

        grid_grade.Columns("ID_DMG_GRADE").Visible = False
        ''add col no
        'Dim colNo As New DataGridViewTextBoxColumn
        'colNo.HeaderText = "No."
        'colNo.Name = "No"

        'grid_grade.Columns.Insert(0, colNo)
        ''fill col no.
        'For i As Integer = 0 To grid_grade.Rows.Count - 1
        '    grid_grade.Rows(i).Cells("No").Value = i + 1
        'Next
        'add col check
        Dim colChk As New DataGridViewCheckBoxColumn
        colChk.HeaderText = "Select"
        colChk.Name = "Pilih"
        grid_grade.Columns.Insert(1, colChk)

        grid_grade.ReadOnly = False
        autoColWidth(3, grid_grade)
    End Sub

    Private Sub FormDamageCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub FormDamageCode_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If grid_type.Columns.Count > 0 Then autoColWidth(3, grid_type)
        If grid_part.Columns.Count > 0 Then autoColWidth(3, grid_part)
        If grid_grade.Columns.Count > 0 Then autoColWidth(3, grid_grade)
    End Sub

    Private Sub tabMenu_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles tabMenu.SelectedTabChanged
        If e.NewValue.Name = "" Then Return
        If e.NewValue.Name = tab_dmg_type.Name Then
            fill_grid_type()
        ElseIf e.NewValue.Name = tab_dmg_part.Name Then
            fill_grid_part()
        ElseIf e.NewValue.Name = tab_dmg_grade.Name Then
            fill_grid_grade()
        End If
    End Sub

    Private Function allowEditDel(dg As DataGridView, keyCell As String)
        If dg.Rows.Count = 0 Then Return False
        If dg.CurrentRow Is Nothing Then Return False
        If Not IsNumeric(dg.CurrentRow.Cells(keyCell).Value) Then Return False
        Return True
    End Function

    Private Sub btn_edit_type_Click(sender As Object, e As EventArgs) Handles btn_edit_type.Click
        If Not allowEditDel(grid_type, "ID_DMG") Then Return

        Dim typeID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_type.Rows.Count - 1
            If grid_type.Rows(i).Cells("Pilih").Value = True Or grid_type.Rows(i).Cells("Pilih").Value = 1 Then
                typeID.Add(grid_type.Rows(i).Cells("ID_DMG").Value)
            End If
        Next

        If typeID.Count = 0 Then Return
        Dim dt As DataTable = fc_dmgcde_gettype(pubApiAddress, "id=" & typeID.Last)
        Dim frm As New FormDamageCode_InputType
        With frm
            .Text = "Edit Damage Type"
            .PForm = Me
            .InputType = inputTypes.edit
            .IdType = typeID.Last
            .txt_code.Text = dt.Rows(0)("DMG_CODE")
            .txt_desc.Text = dt.Rows(0)("DMG_DESC")
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_delete_type_Click(sender As Object, e As EventArgs) Handles btn_delete_type.Click
        If Not allowEditDel(grid_type, "ID_DMG") Then Return

        Dim typeID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_type.Rows.Count - 1
            If grid_type.Rows(i).Cells("Pilih").Value = True Or grid_type.Rows(i).Cells("Pilih").Value = 1 Then
                typeID.Add(grid_type.Rows(i).Cells("ID_DMG").Value)
            End If
        Next
        Dim res As DialogResult
        res = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        Dim isOk As Boolean
        For i = 0 To typeID.Count - 1
            isOk = fc_dmgcde_deltype(typeID(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid_type()
    End Sub

    Private Sub grid_type_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_type.CellBeginEdit
        e.Cancel = e.ColumnIndex <> grid_type.Columns("Pilih").Index
    End Sub

    Private Sub grid_type_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_type.CellContentClick

    End Sub

    Private Sub btn_add_type_Click(sender As Object, e As EventArgs) Handles btn_add_type.Click
        Dim frm As New FormDamageCode_InputType
        frm.InputType = inputTypes.insert
        frm.PForm = Me
        frm.ShowDialog()
    End Sub

    Private Sub grid_part_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_part.CellBeginEdit
        e.Cancel = e.ColumnIndex <> grid_part.Columns("Pilih").Index
    End Sub

    Private Sub btn_edit_part_Click(sender As Object, e As EventArgs) Handles btn_edit_part.Click
        If Not allowEditDel(grid_part, "ID_DMG_LOC") Then Return

        Dim partID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_part.Rows.Count - 1
            If grid_part.Rows(i).Cells("Pilih").Value = True Or grid_part.Rows(i).Cells("Pilih").Value = 1 Then
                partID.Add(grid_part.Rows(i).Cells("ID_DMG_LOC").Value)
            End If
        Next

        If partID.Count = 0 Then Return
        Dim dt As DataTable = fc_dmgcde_getpart(pubApiAddress, "id=" & partID.Last)
        Dim frm As New FormDamageCode_InputPart
        With frm
            .Text = "Edit Damage Part"
            .PForm = Me
            .InputType = inputTypes.edit
            .idPart = partID.Last
            .txt_code.Text = dt.Rows(0)("LOC_CODE")
            .txt_desc.Text = dt.Rows(0)("LOC_DESC")
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_delete_part_Click(sender As Object, e As EventArgs) Handles btn_delete_part.Click
        If Not allowEditDel(grid_part, "ID_DMG_LOC") Then Return

        Dim partID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_part.Rows.Count - 1
            If grid_part.Rows(i).Cells("Pilih").Value = True Or grid_part.Rows(i).Cells("Pilih").Value = 1 Then
                partID.Add(grid_part.Rows(i).Cells("ID_DMG_LOC").Value)
            End If
        Next
        Dim res As DialogResult
        res = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        Dim isOk As Boolean
        For i = 0 To partID.Count - 1
            isOk = fc_dmgcde_delpart(partID(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid_part()
    End Sub

    Private Sub btn_add_part_Click(sender As Object, e As EventArgs) Handles btn_add_part.Click
        Dim frm As New FormDamageCode_InputPart
        frm.InputType = inputTypes.insert
        frm.PForm = Me
        frm.ShowDialog()
    End Sub

    Private Sub btn_add_grade_Click(sender As Object, e As EventArgs) Handles btn_add_grade.Click
        Dim frm As New FormDamageCode_InputGrade
        frm.InputType = inputTypes.insert
        frm.PForm = Me
        frm.ShowDialog()
    End Sub

    Private Sub btn_edit_grade_Click(sender As Object, e As EventArgs) Handles btn_edit_grade.Click
        If Not allowEditDel(grid_grade, "ID_DMG_GRADE") Then Return

        Dim gradeID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_grade.Rows.Count - 1
            If grid_grade.Rows(i).Cells("Pilih").Value = True Or grid_grade.Rows(i).Cells("Pilih").Value = 1 Then
                gradeID.Add(grid_grade.Rows(i).Cells("ID_DMG_GRADE").Value)
            End If
        Next

        If gradeID.Count = 0 Then Return
        Dim dt As DataTable = fc_dmgcde_getgrade(pubApiAddress, "id=" & gradeID.Last)
        Dim frm As New FormDamageCode_InputGrade
        With frm
            .Text = "Edit Damage Grade"
            .PForm = Me
            .InputType = inputTypes.edit
            .idGrade = gradeID.Last
            .txt_code.Text = dt.Rows(0)("GRADE_CODE")
            .txt_desc.Text = dt.Rows(0)("GRADE_DESC")
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_delete_grade_Click(sender As Object, e As EventArgs) Handles btn_delete_grade.Click
        If Not allowEditDel(grid_grade, "ID_DMG_GRADE") Then Return

        Dim gradeID As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_grade.Rows.Count - 1
            If grid_grade.Rows(i).Cells("Pilih").Value = True Or grid_grade.Rows(i).Cells("Pilih").Value = 1 Then
                gradeID.Add(grid_grade.Rows(i).Cells("ID_DMG_GRADE").Value)
            End If
        Next
        Dim res As DialogResult
        res = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        Dim isOk As Boolean
        For i = 0 To gradeID.Count - 1
            isOk = fc_dmgcde_delgrade(gradeID(i))
        Next
        msgDel(isOk)
        If isOk Then fill_grid_grade()
    End Sub

    Private Sub FormDamageCode_RegionChanged(sender As Object, e As EventArgs) Handles Me.RegionChanged

    End Sub

    Private Sub grid_grade_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_grade.CellBeginEdit
        e.Cancel = e.ColumnIndex <> grid_grade.Columns("Pilih").Index
    End Sub

    Private Sub FormDamageCode_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_grid_type()
    End Sub
End Class