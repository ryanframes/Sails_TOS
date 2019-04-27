Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Dictionary(Of String, String)
        a.Add("1", "Bos")
        a.Add("2", "Mozart")
        For Each d As KeyValuePair(Of String, String) In a
            MsgBox(d.Key & ":" & d.Value)
        Next
    End Sub

    Private Sub btn_machine_type_Click(sender As Object, e As EventArgs) Handles btn_machine_type.Click
        Dim frm As New FormMachineType
        frm.Show()
    End Sub

    Private Sub btn_truck_code_Click(sender As Object, e As EventArgs) Handles btn_truck_code.Click
        Dim frm As New FormTruckCode
        frm.Show()
    End Sub
End Class