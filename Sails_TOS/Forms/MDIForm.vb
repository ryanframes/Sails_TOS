Public Class MDIForm
    Private Sub ButtonItem14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MachineSpecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MachineSpecToolStripMenuItem.Click
        Dim frm As New FormMachineSpec
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub DamageCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamageCodeToolStripMenuItem.Click
        Dim frm As New FormDamageCode
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub QuayLaneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuayLaneToolStripMenuItem.Click
        Dim frm As New FormQuayLane
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub InboundDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InboundDataToolStripMenuItem.Click
        Dim frm As New FormInboundData
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub FindContainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindContainerToolStripMenuItem.Click
        Dim frm As New FormFindContainer
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub MachineSpecToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MachineSpecToolStripMenuItem1.Click
        Dim frm As New FormJobController
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub MachineTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MachineTypeToolStripMenuItem.Click
        Dim frm As New FormMachineType
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub TruckCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TruckCodeToolStripMenuItem.Click
        Dim frm As New FormTruckCode
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub YardDefinitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YardDefinitionToolStripMenuItem.Click
        Dim frm As New FormYardDefinition
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub HRMachineDriverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HRMachineDriverToolStripMenuItem.Click
        Dim frm As New FormHRMchDriver
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub InquiryContainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InquiryContainerToolStripMenuItem.Click
        Dim frm As New FormContainerInquiry
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub

    Private Sub AuthentificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthentificationToolStripMenuItem.Click
        Dim frm As New FormAuthentification
        frm.ShowDialog()
    End Sub

    Private Sub VMTYardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VMTYardToolStripMenuItem.Click
        Dim frm As New FormVMT
        frm.MdiParent = Me
        frm.Show()
        Me.Refresh()
    End Sub
End Class