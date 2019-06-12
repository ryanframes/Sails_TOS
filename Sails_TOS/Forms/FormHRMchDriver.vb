Public Class FormHRMchDriver
    Private Sub FormHRMchDriver_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_grid()
    End Sub

    Private Sub FormHRMchDriver_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub fill_grid()
        fc_hrmchdvr_getdata(grid_mch, pubApiAddress, "?user=" & txt_user.Text & "&name=" & txt_name.Text)
    End Sub

    Private Sub grid_mch_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_mch.CellBeginEdit
        If btn_save.Visible And e.ColumnIndex = grid_mch.Columns("Pilih").Index Then
            e.Cancel = False 'if edit mode, then do not allow user to uncheck 
        ElseIf btn_save.Visible = False Then
            e.Cancel = e.ColumnIndex <> grid_mch.Columns("Pilih").Index
        End If
    End Sub

    Private Sub btn_add_type_Click(sender As Object, e As EventArgs) Handles btn_add_type.Click
        Dim is_checked As Boolean = False
        For i As Integer = 0 To grid_mch.Rows.Count - 1
            If grid_mch.Rows(i).Cells("Pilih").Value = True Or grid_mch.Rows(i).Cells("Pilih").Value = 1 Then
                is_checked = True
                'change all type col to checkbox
                For j As Integer = grid_mch.Columns("Name").Index + 1 To grid_mch.Columns.Count - 1
                    Dim chkCell As New DataGridViewCheckBoxCell 'init new checkbox cell
                    If Not IsNothing(grid_mch.Rows(i).Cells(j).Tag) Then
                        chkCell.Value = grid_mch.Rows(i).Cells(j).Tag 'set value checkboxcell
                        chkCell.Tag = grid_mch.Rows(i).Cells(j).Tag 'store value to tag
                    Else
                        chkCell.Value = False
                    End If
                    grid_mch.Rows(i).Cells(j) = chkCell 'change celltype
                Next
            End If
        Next
        btn_save.Visible = is_checked
        btn_cancel.Visible = is_checked
    End Sub

    Private Sub grid_mch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_mch.CellContentClick
        If e.ColumnIndex = grid_mch.Columns("Pilih").Index Then
            If btn_save.Visible = False Then
                'hanya bisa di edit saat bukan mode edit
                grid_mch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = grid_mch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> True
            End If
        End If
        If btn_save.Visible = True And e.ColumnIndex > 3 And grid_mch.Rows(e.RowIndex).Cells("Pilih").Value = True Then
            'set checkbox
            grid_mch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = grid_mch.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> True
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        For i As Integer = 0 To grid_mch.Rows.Count - 1
            If grid_mch.Rows(i).Cells("Pilih").Value = True Or grid_mch.Rows(i).Cells("Pilih").Value = 1 Then
                'change all type col to imagecell
                For j As Integer = grid_mch.Columns("Name").Index + 1 To grid_mch.Columns.Count - 1
                    Dim imgCell As New DataGridViewImageCell 'init new img cell
                    If Not IsNothing(grid_mch.Rows(i).Cells(j).Tag) Then
                        If grid_mch.Rows(i).Cells(j).Tag = True Then
                            imgCell.Tag = grid_mch.Rows(i).Cells(j).Tag 'set tag imagecell from checkbox value
                            imgCell.Value = My.Resources.icons8_checkmark_16
                        Else
                            imgCell.Tag = False
                        End If
                    Else
                        imgCell.Tag = False
                    End If
                    grid_mch.Rows(i).Cells(j) = imgCell 'change celltype
                Next
            End If
        Next
        btn_save.Visible = False
        btn_cancel.Visible = False
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'save type
        Dim stype As String
        Dim isOk As Boolean
        For i As Integer = 0 To grid_mch.Rows.Count - 1
            If grid_mch.Rows(i).Cells("Pilih").Value = True Or grid_mch.Rows(i).Cells("Pilih").Value = 1 Then
                stype = "" 'reset type
                For j As Integer = grid_mch.Columns("Name").Index + 1 To grid_mch.Columns.Count - 1
                    If grid_mch.Rows(i).Cells(j).Value Then 'if type checked
                        stype = stype & IIf(stype = "", "", ",") & grid_mch.Columns(j).HeaderText
                    End If
                Next
                Dim sCol As New Dictionary(Of String, String)
                sCol.Add("user", grid_mch.Rows(i).Cells("USERNAME").Value)
                sCol.Add("MACHINE_DRIVER", stype)
                isOk = fc_hrmchdvr_savedata(sCol)
            End If
        Next
        btn_save.Visible = False
        btn_cancel.Visible = False

        'refresh grid
        fill_grid()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        fill_grid()
    End Sub
End Class