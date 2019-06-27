Imports DevComponents.DotNetBar

Public Class FormVMT
    Private _pubUser As String
    Private _pubMch As String
    Private _popUp As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub addJobEffect(ByVal parentPnl As PanelEx)
        'highlight panel list
        For Each obj As Control In parentPnl.Controls
            If TypeOf obj Is Label Then
                obj.Font = lbl_job.Font
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

    Private Sub show_list_job()
        Dim whereCondition As String
        whereCondition = IIf(cmb_job.Text = "All", "", "&job_code=" & cmb_job.Text)
        'unmark this before send to ILCS
        'whereCondition = whereCondition.Concat(whereCondition, "&mch_code=" & _pubMch)
        Dim dt As DataTable = fc_vmtyrd_getjob(pubApiAddress, whereCondition)

        'clear prev job list
        For Each obj As Control In pnl_job_list.Controls
            'remove event handler
            If TypeOf obj Is Label Then
                RemoveHandler obj.MouseEnter, AddressOf lbl_listing_MouseEnter
                RemoveHandler obj.MouseLeave, AddressOf lbl_listing_MouseLeave
            End If
        Next
        pnl_job_list.Controls.Clear()

        For i As Integer = 0 To dt.Rows.Count - 1
            'add panel
            Dim objPnl As New PanelEx
            objPnl.Name = dt.Rows(i)("NO_CONT")
            pnl_job_list.Controls.Add(objPnl)
            objPnl.Dock = DockStyle.Top
            objPnl.Padding = New Windows.Forms.Padding(5)
            objPnl.Style.Border = eBorderType.SingleLine
            objPnl.Style.BorderColor.Color = Color.FromArgb(204, 204, 204)
            objPnl.Style.BorderDashStyle = Drawing2D.DashStyle.Solid
            objPnl.Style.BorderWidth = 1
            objPnl.Visible = True
            objPnl.Size = pnl_job.Size
            objPnl.Style.BackColor1.Color = SystemColors.ButtonFace
            Dim lbl As Label

            'add label block cell slot (?)
            lbl = New Label
            lbl.Dock = DockStyle.Top
            lbl.Name = "lbl_block_cell_slot_" & dt.Rows(i)("NO_CONT")
            lbl.Text = dt.Rows(i)("PA_PLAN") & " " & dt.Rows(i)("WEIGHT") & "T" & " " & dt.Rows(i)("TID") & " " & dt.Rows(i)("FA")
            lbl.Visible = True
            lbl.TextAlign = ContentAlignment.MiddleLeft
            objPnl.Controls.Add(lbl)


            'add label cont_data
            lbl = New Label
            lbl.Dock = DockStyle.Top
            lbl.Name = "lbl_cont_data_" & dt.Rows(i)("NO_CONT")
            lbl.Text = dt.Rows(i)("NO_CONT") & " " & dt.Rows(i)("ISO") & " " &
                dt.Rows(i)("COMMODITY") & " " & dt.Rows(i)("CLASS") & " " &
                Strings.Left(dt.Rows(i)("ID_VVD"), 4) & " " & dt.Rows(i)("POD")
            lbl.TextAlign = ContentAlignment.MiddleLeft
            lbl.Visible = True
            objPnl.Controls.Add(lbl)

            'add label job 
            lbl = New Label
            objPnl.Controls.Add(lbl)
            lbl.Name = "lbl_job_" & dt.Rows(i)("NO_CONT")
            lbl.Size = lbl_job.Size
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Dock = DockStyle.Left
            If dt.Rows(i)("CLASS") & dt.Rows(i)("ONCH_PLCMT") = "IO" Then lbl.Text = "GO"
            If dt.Rows(i)("CLASS") & dt.Rows(i)("ONCH_PLCMT") = "IP" Then lbl.Text = "DS"
            If dt.Rows(i)("CLASS") & dt.Rows(i)("ONCH_PLCMT") = "EO" Then lbl.Text = "LD"
            If dt.Rows(i)("CLASS") & dt.Rows(i)("ONCH_PLCMT") = "EP" Then lbl.Text = "GI"
            lbl.Visible = True
            lbl.SendToBack()
            addJobEffect(objPnl)
        Next
    End Sub

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
        'kategori job
        cmb_job.Items.Clear()
        cmb_job.Items.Add("All")
        cmb_job.Items.Add("GI")
        cmb_job.Items.Add("GO")
        cmb_job.Items.Add("DS")
        cmb_job.Items.Add("LD")
        cmb_job.SelectedIndex = 0
        'block
        Dim dt As DataTable = fc_vmtyrd_getblocklist(pubApiAddress)
        fill_combo_dt(dt, cmb_block, "ID_BLOCK", "BLOCK_NAME", False)
    End Sub

    Private Sub cmb_job_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_job.SelectedIndexChanged
        show_list_job()
    End Sub

    Private Sub FormVMT_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
        fill_combo()
    End Sub

    Private Sub txt_block_TextChanged(sender As Object, e As EventArgs) Handles txt_block.TextChanged

    End Sub

    Private Sub txt_block_Click(sender As Object, e As EventArgs) Handles txt_block.Click
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("BLOCK_NAME", "")
        _popUp = "block"

        Dim frm As New FormVMTBlock
        frm.PForm = Me
        frm.Text = "Select Block"
        frm.CtrlParent = txt_block
        frm.ShowDialog()
    End Sub

    Sub popReturn(ByVal str As String())
        If _popUp = "block" Then
            txt_block.Text = str(1)
            txt_block.Tag = str(0)
        ElseIf _popUp = "slot" Then
            txt_slot.Text = str(0)
        End If
    End Sub

    Private Sub txt_slot_TextChanged(sender As Object, e As EventArgs) Handles txt_slot.TextChanged

    End Sub

    Private Sub txt_slot_Click(sender As Object, e As EventArgs) Handles txt_slot.Click
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("20_STACKNAME", "")
        _popUp = "slot"

        Dim frm As New FormVMTSlot
        frm.PForm = Me
        frm.IdBlock = IIf(IsNothing(txt_block.Tag), "", txt_block.Tag)
        frm.Text = "Select Slot"
        frm.CtrlParent = txt_slot
        frm.ShowDialog()
    End Sub

    Private Sub cmb_block_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_block.SelectedIndexChanged

    End Sub

    Sub set_slot(ByVal id_block As String)
        Dim dt As DataTable = fc_vmtyrd_getslotlist(pubApiAddress, "id_block=" & id_block)
        If dt.Rows.Count = 0 Then
            txt_slot.Text = ""
        Else
            txt_slot.Text = dt.Rows(0)(0)
        End If
    End Sub

    Private Sub set_block(ByVal txt As String, ByVal id As String)
        txt_block.Text = txt
        txt_block.Tag = id
    End Sub

    Private Sub cmb_block_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_block.SelectedValueChanged
        set_block(cmb_block.Text, IIf(IsNothing(cmb_block.SelectedValue), "", cmb_block.SelectedValue))
        set_slot(IIf(IsNothing(cmb_block.SelectedValue), "", cmb_block.SelectedValue))
    End Sub

    Private Sub lbl_cont_data_Click(sender As Object, e As EventArgs) Handles lbl_cont_data.Click

    End Sub
End Class