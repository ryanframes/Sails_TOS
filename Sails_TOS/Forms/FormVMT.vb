Imports DevComponents.DotNetBar

Public Class FormVMT
    Private _pubUser As String
    Private _pubMch As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each obj As Control In pnl_list_job.Controls
            If TypeOf obj Is Label Then
                AddHandler obj.MouseEnter, AddressOf lbl_listing_MouseEnter
                AddHandler obj.MouseLeave, AddressOf lbl_listing_MouseLeave
            End If
        Next
    End Sub

    Public Property PubUser As String
        Get
            Return _pubUser
        End Get
        Set(value As String)
            _pubUser = value
            lbl_user.Text = _pubUser
        End Set
    End Property

    Public Property PubMch As String
        Get
            Return _pubMch
        End Get
        Set(value As String)
            _pubMch = value
            lbl_machine.Text = "Machine : " & _pubMch
        End Set
    End Property

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        fc_vmtauth_logout(Me)
    End Sub

    Private Sub lbl_listing_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Label).BackColor = Color.FromArgb(255, 255, 192)
        CType(CType(sender, Label).Parent, PanelEx).Style.BackColor1.Color = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub lbl_listing_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Label).BackColor = Color.Transparent
        CType(CType(sender, Label).Parent, PanelEx).Style.BackColor1.Color = SystemColors.ButtonFace
    End Sub

    Private Sub fill_combo()
        cmb_job.Items.Clear()
        cmb_job.Items.Add("All")
        cmb_job.Items.Add("GI")
        cmb_job.Items.Add("GO")
        cmb_job.Items.Add("DS")
        cmb_job.Items.Add("LD")
    End Sub

End Class