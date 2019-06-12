Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim defDt As New DataTable
        defDt.Columns.Add("key")
        defDt.Columns.Add("value")
        defDt.Rows.Add(1, "Test")
        defDt.Rows.Add(2, "Start")
        defDt.Rows.Add(3, "OKasd adas")
        defDt.Rows.Add(4, "asd ertas sad ")
        defDt.Rows.Add(5, "sad eera das")
        defDt.Rows.Add(6, "adew few fs")
        cmb.AutoCompleteMode = AutoCompleteMode.Suggest
        cmb.ValueMember = "key"
        cmb.DisplayMember = "value"
        cmb.DataSource = defDt

        TextBoxDatatableAutoComplete1.DtTableSource = defDt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New Dictionary(Of String, String)
        ds.Add("F", "Full")
        ds.Add("E", "Empty")
        cmb.DataSource = New BindingSource(ds, Nothing)
        cmb.DisplayMember = "value"
        cmb.ValueMember = "key"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxEx1_TextChanged(sender As Object, e As EventArgs) Handles cmb.TextChanged
        'CType(cmb.DataSource, DataTable).DefaultView.RowFilter = "value like '%" & cmb.Text & "%'"
        'cmb.DroppedDown = True

    End Sub

    Private Sub refreshCmb(defDt As DataTable)
        Dim dt As New DataTable
        Try
            lv.Visible = False
            dt = defDt.Copy
            dt.DefaultView.RowFilter = "value like '%" & cmb.Text & "%'"
            If dt.DefaultView.Count > 0 Then
                lv.Clear()
                lv.View = View.SmallIcon
                For i As Integer = 0 To dt.DefaultView.Count - 1
                    Dim item As New ListViewItem
                    item.Tag = dt.DefaultView(i)(0)
                    item.Text = dt.DefaultView(i)(1)
                    lv.Items.Add(item)
                Next
                lv.Height = lv.GetItemRect(0).Height * lv.Items.Count + 10
                lv.Top = cmb.Top + cmb.Height
                lv.BringToFront()
                lv.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lv_LostFocus(sender As Object, e As EventArgs) Handles lv.LostFocus
        lv.Visible = False
    End Sub

    Private Sub cmb_DoubleClick(sender As Object, e As EventArgs) Handles cmb.DoubleClick
        refreshCmb(CType(cmb.DataSource, DataTable))
    End Sub

    Private Sub cmb_KeyUp(sender As Object, e As KeyEventArgs) Handles cmb.KeyUp
        refreshCmb(CType(cmb.DataSource, DataTable))
    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs) Handles lv.Click
        cmb.Text = lv.SelectedItems.Item(0).Text
        lv.Visible = False
    End Sub
End Class