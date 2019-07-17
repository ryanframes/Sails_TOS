Imports DevComponents.DotNetBar

Public Class FormVMT
    Private _pubUser As String
    Private _pubMch As String
    Private _popUp As String
    Private _preferedCell As Control 'variable untuk menyimpan posisi prefered cell
    Private _formMode As formMode
    'Private _selectedJob As New selectedJob With {.ContNo = "", .Job = "", .Location = "", .IdTruck = 0, .IdVVD = 0, .Point = 0} 'set default selectedJob
    Private dtJob As DataTable
    Private dtJobSelected As DataTable

    Private Class selectedJob
        'private class untuk store selected job info
        Private _contNo As String
        Private _job As String
        Private _location As String
        Private _idTruck As Integer
        Private _idVVD As Integer
        Private _point As Integer

        Public Property ContNo As String
            Get
                Return _contNo
            End Get
            Set(value As String)
                _contNo = value
            End Set
        End Property

        Public Property Job As String
            Get
                Return _job
            End Get
            Set(value As String)
                _job = value
            End Set
        End Property

        Public Property Location As String
            Get
                Return _location
            End Get
            Set(value As String)
                _location = value
            End Set
        End Property

        Public Property IdTruck As Integer
            Get
                Return _idTruck
            End Get
            Set(value As Integer)
                _idTruck = value
            End Set
        End Property

        Public Property IdVVD As Integer
            Get
                Return _idVVD
            End Get
            Set(value As Integer)
                _idVVD = value
            End Set
        End Property

        Public Property Point As Integer
            Get
                Return _point
            End Get
            Set(value As Integer)
                _point = value
            End Set
        End Property
    End Class

    Private Enum formMode
        _onPlacement = 1
        _onChasis = 2
    End Enum

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'this is magic code that has an enormous positive effect on reducing flickering.
        'don't remove this.
        'found this nugget here: http://www.vbmigration.com/detknowledgebase.aspx?Id=692
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property

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

    Private Sub refresh_visualisasi()
        Dim crs As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        show_list_row_tier()
        _formMode = Nothing
        Cursor.Current = crs
    End Sub

    Sub set_block(ByVal txt As String, ByVal id As String)
        If txt = "All" Then 'jika all maka jadikan ke block selanjutnya (sumber data dari combobox)
            txt_block.Tag = 0
            set_block_next() 'set block next akan memanggil set_block lagi oleh krn itu setelah set next kita exit
            Return
        Else
            txt_block.Text = txt
            txt_block.Tag = id
            'reset slot
            txt_slot.Text = ""
            txt_slot.Tag = 0
            set_slot_next()
        End If
    End Sub

    Sub set_slot(ByVal txt As String, ByVal id As String)
        txt_slot.Text = txt
        txt_slot.Tag = id
        refresh_visualisasi()
    End Sub

    Private Sub set_block_next()
        Dim idBlock As Integer
        If IsNothing(txt_block.Tag) Then
            idBlock = 0
        ElseIf IsNumeric(txt_block.Tag) = False Then
            idBlock = 0
        Else
            idBlock = txt_block.Tag
        End If
        Dim dt As DataTable = fc_vmtyrd_getblocklist(pubApiAddress)
        dt.DefaultView.Sort = "ID_BLOCK ASC"
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_BLOCK") > idBlock Then
                set_block(dt.Rows(i)("BLOCK_NAME"), dt.Rows(i)("ID_BLOCK"))
                Exit For
            End If
        Next
    End Sub

    Private Sub set_block_prev()
        Dim idBlock As Integer
        If IsNothing(txt_block.Tag) Then
            idBlock = 0
        ElseIf IsNumeric(txt_block.Tag) = False Then
            idBlock = 0
        Else
            idBlock = txt_block.Tag
        End If
        Dim dt As DataTable = fc_vmtyrd_getblocklist(pubApiAddress)
        dt.DefaultView.Sort = "ID_BLOCK DESC"
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_BLOCK") < idBlock Then
                set_block(dt.Rows(i)("BLOCK_NAME"), dt.Rows(i)("ID_BLOCK"))
                Exit For
            End If
        Next
    End Sub

    Private Sub set_slot_next()
        Dim idBlock As Integer
        If IsNothing(txt_block.Tag) Then
            idBlock = 0
        ElseIf IsNumeric(txt_block.Tag) = False Then
            idBlock = 0
        Else
            idBlock = txt_block.Tag
        End If

        Dim idSlot As Integer
        If IsNothing(txt_slot.Tag) Then
            idSlot = 0
        ElseIf IsNumeric(txt_slot.Tag) = False Then
            idSlot = 0
        Else
            idSlot = txt_slot.Tag
        End If

        Dim dt As DataTable = fc_vmtyrd_getslotlist(pubApiAddress, "id_block=" & idBlock)
        dt.DefaultView.Sort = "ID_STACK ASC"
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_STACK") > idSlot Then
                set_slot(dt.Rows(i)("20_STACKNAME"), dt.Rows(i)("ID_STACK"))
                Exit For
            End If
        Next
    End Sub

    Private Sub set_slot_prev()
        Dim idBlock As Integer
        If IsNothing(txt_block.Tag) Then
            idBlock = 0
        ElseIf IsNumeric(txt_block.Tag) = False Then
            idBlock = 0
        Else
            idBlock = txt_block.Tag
        End If

        Dim idSlot As Integer
        If IsNothing(txt_slot.Tag) Then
            idSlot = 0
        ElseIf IsNumeric(txt_slot.Tag) = False Then
            idSlot = 0
        Else
            idSlot = txt_slot.Tag
        End If

        Dim dt As DataTable = fc_vmtyrd_getslotlist(pubApiAddress, "id_block=" & idBlock)
        dt.DefaultView.Sort = "ID_STACK DESC"
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_STACK") < idSlot Then
                set_slot(dt.Rows(i)("20_STACKNAME"), dt.Rows(i)("ID_STACK"))
                Exit For
            End If
        Next
    End Sub

    Private Sub lbl_cell_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Label).BackColor = Color.FromArgb(255, 255, 192)
        CType(CType(sender, Label).Parent, Panel).BackColor = Color.FromArgb(255, 255, 192)
        CType(CType(sender, Label).Parent.Parent, Panel).BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub lbl_cell_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Label).BackColor = Color.Transparent
        CType(CType(sender, Label).Parent, Panel).BackColor = Color.Transparent
        CType(CType(sender, Label).Parent.Parent, Panel).BackColor = SystemColors.HighlightText
    End Sub

    Private Sub pnl_cell_Click(sender As Object, e As EventArgs)
        'event saat cell di click 
        If _formMode = 0 Then Return

        If txt_no_cont.Text = "" Then Return
        'find tier and row address
        Dim str As String()
        If TypeOf sender Is Panel Then
            'panel cell langsung tanpa label2
            str = Strings.Split(CType(sender, Panel).Name, "_row")
        Else
            'label yg di click
            str = Strings.Split(CType(sender, Label).Parent.Parent.Name, "_row")
        End If
        'get tier and row
        Dim iTier As Long = str(0).Replace("pnl_cell_tier", "")
        Dim iRow As String = str(1).PadLeft(2, "0")
        Dim res As DialogResult
        Dim dt As DataTable
        Dim isOk As Boolean
        'check kondisi job
        Dim job As String = ""
        If dtJobSelected.Rows(0)("CLASS") = "I" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "P" Then
            job = "DS"
        ElseIf dtJobSelected.Rows(0)("CLASS") = "E" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "P" Then
            job = "GI"
        ElseIf dtJobSelected.Rows(0)("CLASS") = "I" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "O" Then
            job = "GO"
        ElseIf dtJobSelected.Rows(0)("CLASS") = "E" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "O" Then
            job = "LD"
        End If
        If _formMode = formMode._onPlacement Then
#Region "Save OnPlacement"
            'validasi placement
            If CType(sender, Control).Parent.Name <> "pnl_visual_block_slot" Then
                MessageBoxEx.Show("Location is already in used.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            'get cont size based iso code
            dt = fc_vmtyrd_getjob_contsize(pubApiAddress, "no_cont=" & txt_no_cont.Text)
            If dt.Rows.Count > 0 Then
                'jika cont size > 20 then
                If dt.Rows(0)("SIZE") > 20 Then
                    dt = fc_vmtyrd_plcmnt_check_next_slot(pubApiAddress, "id_block=" & txt_block.Tag & "&row=" & iRow & "&tier=" & iTier & "&id_stack=" & txt_slot.Tag)
                    If dt.Rows.Count > 0 Then
                        If dt.Rows(0)("STATUS") <> 0 Or dt.Rows(0)("USE_FLAG") = "N" Then
                            'Block-row-tier dari slot selanjutnya sudah terpakai
                            MessageBoxEx.Show("Block-Row-Tier of next slot is not available for Size/Commodity Container.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    Else
                        'tidak ada slot selanjutnya
                        MessageBoxEx.Show("Block-Row-Tier of next slot is not available for Size/Commodity Container.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If
            End If
            'CHECK JIKA SUDAH DIPLACEMENT
            dt = fc_vmtyrd_getcont(pubApiAddress, "no_cont=" & dtJobSelected.Rows(0)("NO_CONT") &
                                   "&point=" & dtJobSelected.Rows(0)("POINT") & "&id_vvd=" & dtJobSelected.Rows(0)("ID_VVD"))
            If dt.Rows.Count > 0 Then
                res = MessageBoxEx.Show("Change Location " & txt_no_cont.Text & " from " & vbCrLf & dt.Rows(0)("LOCATION") & " to " & txt_block.Text & "-" & txt_slot.Text & "-" & iRow & "-" & iTier, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res <> DialogResult.Yes Then Return
                'change placement
                isOk = fc_vmtyrd_chgloc(dtJobSelected.Rows(0)("NO_CONT"), dtJobSelected.Rows(0)("POINT"),
                    dtJobSelected.Rows(0)("ID_VVD"), _pubUser, _pubMch, txt_block.Tag, txt_block.Text, iRow, iTier, txt_slot.Tag,
                    dtJobSelected.Rows(0)("SIZE"), dt.Rows(0)("ID_BLOCK"), dt.Rows(0)("ROW"), dt.Rows(0)("TIER"))
            Else
                'JIKA NEW PLACEMENT HANYA Khusus CLASS = I & ONCH_PLCMT = P --> DS DAN if CLASS = E & ONCH_PLCMT = P --> GI
                'If job = "DS" Or job = "GI" Then
                res = MessageBoxEx.Show("Stack " & txt_no_cont.Text & " in " & txt_block.Text & "-" & txt_slot.Text & "-" & iRow & "-" & iTier, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res <> DialogResult.Yes Then Return
                'new placement
                isOk = fc_vmtyrd_plcmnt(job, dtJobSelected.Rows(0)("TRUCK_ID"), dtJobSelected.Rows(0)("NO_CONT"),
                    dtJobSelected.Rows(0)("POINT"), dtJobSelected.Rows(0)("ID_VVD"), dtJobSelected.Rows(0)("ID_CONT_DATA"),
                    _pubUser, _pubMch, txt_block.Tag, txt_block.Text, iRow, iTier, txt_slot.Tag, dtJobSelected.Rows(0)("SIZE"))
                'Else
                '    MessageBoxEx.Show("Record Placement only for Job Type GI or GS", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question)
                '    Return
                'End If
            End If
            btn_clear_selection.PerformClick()
#End Region
        End If
        'REFRESH VISUALISASI
        refresh_visualisasi()
    End Sub

    Private Sub show_list_row_tier()
        'tampilkan list row dan tier
        'hide panels for better visual when loading data
        pnl_visual_block_slot.Visible = False
        'clear list tier
        pnl_tier.Controls.Clear()
        pnl_row.Controls.Clear()
        Dim idBlock As Integer
        If IsNothing(txt_block.Tag) Then
            idBlock = 0
        ElseIf IsNumeric(txt_block.Tag) = False Then
            idBlock = 0
        Else
            idBlock = txt_block.Tag
        End If
        Dim dt As DataTable
        Dim maxTier As Long, maxRow As Long, avbTier As Long
        Dim lbl As Label
        Dim pos_x As Integer = 1, pos_y As Integer = 1
        Dim i As Long
#Region "Tampil List tier"
        'get tier
        dt = fc_vmtyrd_gettierlist(pubApiAddress, "id_block=" & idBlock)
        If dt.Rows.Count > 0 Then
            maxTier = dt.Rows(0)("MAX_TIER")
            avbTier = dt.Rows(0)("AVB_TIER")
            i = maxTier
            Do While i > 0
                lbl = New Label
                lbl.TextAlign = ContentAlignment.MiddleCenter
                lbl.Name = "lbl_tier" & i
                lbl.AutoSize = True
                lbl.Text = i
                lbl.MinimumSize = New Size(15, pnl_cell.Height)
                lbl.Location = New Point(pos_x, pos_y)
                pos_y = pos_y + pnl_cell.Height + 3 '(3=jarak antara pnl_cell)
                pnl_tier.Controls.Add(lbl)
                lbl.Visible = True
                i = i - 1
            Loop
        End If
#End Region

#Region "Tampil List row"
        pos_x = 2 : pos_y = 2 'reset pos x dan y
        dt = fc_vmtyrd_getrowlist(pubApiAddress, "id_block=" & idBlock)
        If dt.Rows.Count > 0 Then
            maxRow = dt.Rows(0)("MAX_ROW")
            i = maxRow
            Do While i > 0
                lbl = New Label
                lbl.TextAlign = ContentAlignment.MiddleCenter
                lbl.AutoSize = True
                If dt.Rows(0)("ROW_DIRECTION") = "TB" Then
                    lbl.Name = "lbl_row" & maxRow - (i - 1)
                    lbl.Text = (maxRow - (i - 1)).ToString.PadLeft(2, "0")
                ElseIf dt.Rows(0)("ROW_DIRECTION") = "BT" Then
                    lbl.Name = "lbl_row" & i
                    lbl.Text = i.ToString.PadLeft(2, "0")
                End If
                lbl.MinimumSize = New Size(pnl_cell.Width, 0)
                lbl.Location = New Point(pos_x, pos_y)
                pos_x = pos_x + lbl.MinimumSize.Width + pnl_row.Padding.Left
                pnl_row.Controls.Add(lbl)
                lbl.Visible = True
                i = i - 1
            Loop
        End If
        pnl_row.Location = New Point(pnl_row.Location.X, pnl_tier.Height + pnl_tier.Top)
#End Region

#Region "Tampil Cells"
        'clear all cells
        Do While pnl_visual_block_slot.Controls.Count > 6
            For Each obj As Control In pnl_visual_block_slot.Controls
                If obj.Name.Contains("pnl_cell") And obj.Name <> pnl_cell.Name Then
                    For Each chldObj As Control In obj.Controls
                        'remove handler
                        RemoveHandler chldObj.Click, AddressOf pnl_cell_Click
                    Next
                    RemoveHandler obj.Click, AddressOf pnl_cell_Click
                    pnl_visual_block_slot.Controls.Remove(obj)
                End If
            Next
        Loop
        Dim pnl As Panel
        Dim pnlChld As Panel
        Dim iTier As Long = maxTier
        Dim posTier As Long = 0
        Dim dtSize As DataTable
        Do While iTier >= 1
            For Each lblRow As Label In pnl_row.Controls
                'create panel cell
                pnl = New Panel
                pnl.Size = pnl_cell.Size
                pnl.BorderStyle = BorderStyle.FixedSingle
                pnl.Left = pnl_tier.Left + pnl_tier.Width + 3
                pnl.Visible = True
                posTier = maxTier - iTier
                pnl.Name = "pnl_cell_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", ""))
                pnl.Top = pnl_tier.Top + (pnl_cell.Height * posTier) + (3 * posTier)
                pnl.Left = pnl_row.Left + pnl_row.Controls(0).Left * 2 + lblRow.Left
                pnl_visual_block_slot.Controls.Add(pnl)
                AddHandler pnl.Click, AddressOf pnl_cell_Click
                'pnl.Controls.Add(New Label With {.Text = "t" & iTier & "r" & CLng(Replace(lblRow.Name, "lbl_row", "")), .Visible = True, .Dock = DockStyle.Fill, .AutoSize = True})

                If iTier > avbTier Then
                    'jika tier i lebih besar dari avb tier maka 
                    pnl.Enabled = False
                    pnl.Controls.Add(New PictureBox With {.Image = My.Resources.remove_icon_20, .SizeMode = PictureBoxSizeMode.StretchImage, .Dock = DockStyle.Fill, .Visible = True})
                    'pnl.BackgroundImage = My.Resources.remove_icon_20
                    'pnl.BackgroundImageLayout = ImageLayout.Tile
                    Continue For
                End If

                'get cell info
                dt = fc_vmtyrd_getcell(pubApiAddress, "id_block=" & idBlock & "&tier=" & iTier & "&row=" &
                                       CLng(Replace(lblRow.Name, "lbl_row", "")) & "&id_stack=" & txt_slot.Tag)

                If dt.Rows.Count > 0 Then
                    'id cell di simpan di panel cell tag, supaya saat pengecekan cell save 
                    pnl.Tag = dt.Rows(0)("ID_CELL")
                    If IIf(IsDBNull(dt.Rows(0)("VOID")), 0, dt.Rows(0)("VOID")) = 1 Then
                        'check void status
                        pnl.Enabled = False
                        pnl.Controls.Add(New PictureBox With {.Image = My.Resources.remove_icon_20, .SizeMode = PictureBoxSizeMode.StretchImage, .Dock = DockStyle.Fill, .Visible = True})
                        'pnl.BackgroundImage = My.Resources.remove_icon_20
                        'pnl.BackgroundImageLayout = ImageLayout.Tile
                        Continue For
                    ElseIf dt.Rows(0)("STATUS") <> 1 Then
                        Continue For 'ONLY FOR STATUS=1 
                    End If
                    'check size
                    dtSize = fc_vmtyrd_getjob_contsize(pubApiAddress, "no_cont=" & dt.Rows(0)("NO_CONT"))
                    If dtSize.Rows(0)("SIZE") > 20 Then
                        'SIZE > 20, CEK APAKAH ADA DATA DI SLOT SEBELUMNYA
                        dtSize = fc_vmtyrd_check_prev_slot(pubApiAddress, "id_block=" & idBlock & "&tier=" & iTier & "&row=" &
                                       CLng(Replace(lblRow.Name, "lbl_row", "")) & "&id_stack=" & txt_slot.Tag)
                        If dtSize.Rows.Count > 0 Then
                            'jika ada maka cell ini di SILANG
                            pnl.Controls.Add(New PictureBox With {.Image = My.Resources.Red_Cross_PNG_File, .SizeMode = PictureBoxSizeMode.StretchImage, .Dock = DockStyle.Fill, .Visible = True})
                            Continue For
                        End If
                    End If
                    'add no cont
                    pnlChld = New Panel
                    'pnlChld.Tag = dt.Rows(0)("ID_CELL")
                    pnlChld.Size = pnl_cell_no_cont.Size
                    pnlChld.Dock = DockStyle.Top
                    pnlChld.Name = "pnl_cell_cont_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", ""))
                    pnlChld.Controls.Add(New Label With {.Name = "lbl_cell_cont_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", "")),
                                     .Dock = DockStyle.Bottom, .AutoSize = False, .Font = lbl_cell_iso.Font,
                                     .Visible = True, .Text = Strings.Right(dt.Rows(0)("NO_CONT"), 4),
                                     .MinimumSize = pnl_cell_no_cont.Size, .TextAlign = ContentAlignment.MiddleRight})
                    pnl.Controls.Add(pnlChld)

                    'add commodity
                    pnlChld = New Panel
                    pnlChld.Dock = DockStyle.Top
                    pnlChld.Size = pnl_cell_commodity.Size
                    pnlChld.Name = "pnl_cell_commodity_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", ""))
                    pnlChld.Controls.Add(New Label With {.Name = "lbl_cell_commodity_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", "")),
                                     .Dock = DockStyle.Left, .AutoSize = True, .Font = lbl_cell_iso.Font,
                                     .Visible = True, .Text = dt.Rows(0)("COMMODITY"), .MinimumSize = pnl_cell_no_cont.Size})
                    pnl.Controls.Add(pnlChld)

                    'add iso & class
                    pnlChld = New Panel
                    pnlChld.Dock = DockStyle.Top
                    pnlChld.Size = pnl_cell_iso_class.Size
                    pnlChld.Name = "pnl_cell_iso_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", ""))
                    pnlChld.Controls.Add(New Label With {.Name = "lbl_cell_iso_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", "")),
                                     .Dock = DockStyle.Fill, .AutoSize = True, .Font = lbl_cell_iso.Font,
                                     .Visible = True, .Text = dt.Rows(0)("ISO")})
                    pnlChld.Controls.Add(New Label With {.Name = "lbl_cell_class_tier" & iTier & "_row" & CLng(Replace(lblRow.Name, "lbl_row", "")),
                                     .Dock = DockStyle.Right, .AutoSize = True, .Font = lbl_cell_iso.Font,
                                     .Visible = True, .Text = dt.Rows(0)("CLASS")})
                    pnl.Controls.Add(pnlChld)

                    'add event mouse enter and leave for every label in pnl cell
                    For Each obj As Control In pnl.Controls
                        obj.BackColor = Color.Transparent
                        If TypeOf obj Is Panel Then
                            For Each ctrl As Control In obj.Controls
                                If TypeOf ctrl Is Label Then
                                    'AddHandler ctrl.MouseEnter, AddressOf lbl_cell_MouseEnter
                                    'AddHandler ctrl.MouseLeave, AddressOf lbl_cell_MouseLeave
                                    AddHandler ctrl.Click, AddressOf pnl_cell_Click
                                End If
                            Next
                        End If
                    Next
                End If
            Next
            iTier = iTier - 1
        Loop
#End Region
        pnl_visual_block_slot.Visible = True
    End Sub

    Private Sub show_data_cell()
        Dim dt As DataTable = fc_vmtyrd_getcell(pubApiAddress, "")
    End Sub

    Private Sub lbl_list_job_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Label).BackColor = Color.FromArgb(255, 255, 192)
        CType(CType(sender, Label).Parent, PanelEx).Style.BackColor1.Color = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub lbl_list_job_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Label).BackColor = Color.Transparent
        CType(CType(sender, Label).Parent, PanelEx).Style.BackColor1.Color = SystemColors.ButtonFace
    End Sub

    Private Sub lbl_list_job_Click(sender As Object, e As EventArgs)
        'set form mode to nothing
        _formMode = Nothing

        'find pa plan control and pa plan loc
        txt_no_cont.Text = sender.PARENT.NAME
        Dim str As String() = Strings.Split(CType(CType(sender, Label).Parent, PanelEx).Controls(0).Name, "_loc")
        Dim strLoc As String() = Split(str(1), "-") 'split pa plan; format block_name, stack_name, row, tier

        'set prev preferred cell bg to normal
        If _preferedCell IsNot Nothing Then _preferedCell.BackColor = SystemColors.HighlightText
        'get onch_plcmt selected job
        dtJobSelected = Nothing
        dtJobSelected = dtJob.Select("NO_CONT= '" & txt_no_cont.Text & "' AND TRUCK_ID = " & CType(CType(sender, Label).Parent, PanelEx).Tag).CopyToDataTable
            btn_chasis.Visible = dtJobSelected.Rows(0)("ONCH_PLCMT") = "O" 'btn chassis hanya muncul jika status job = O
        If strLoc(0) <> txt_block.Text Or strLoc(1) <> txt_slot.Text Then Return

        'find prefered cell, and change its bgcolor
        Dim iTier As Long = strLoc(3), iRow As Long = strLoc(2)
        Dim ctrl As Control() = pnl_visual_block_slot.Controls.Find("pnl_cell_tier" & iTier & "_row" & iRow, True)
        _preferedCell = ctrl(0)
        _preferedCell.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub show_list_job()
        Dim whereCondition As String
        whereCondition = IIf(cmb_job.Text = "All", "", "&job_code=" & cmb_job.Text)
        whereCondition = whereCondition.Concat(whereCondition, "&block_code=" & IIf(cmb_block.Text = "All", "", cmb_block.Text))
        'unmark this before send to ILCS
        whereCondition = whereCondition.Concat(whereCondition, "&mch_code=" & _pubMch)
        dtJob = fc_vmtyrd_getjob(pubApiAddress, whereCondition)

        'clear prev job list
        For Each obj As Control In pnl_job_list.Controls
            'remove event handler
            If TypeOf obj Is Label Then
                RemoveHandler obj.MouseEnter, AddressOf lbl_list_job_MouseEnter
                RemoveHandler obj.MouseLeave, AddressOf lbl_list_job_MouseLeave
            End If
        Next
        pnl_job_list.Controls.Clear()

        For i As Integer = 0 To dtJob.Rows.Count - 1
            'add panel
            Dim objPnl As New PanelEx
            objPnl.Name = dtJob.Rows(i)("NO_CONT")
            objPnl.Tag = dtJob.Rows(i)("TRUCK_ID")
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
            lbl.Name = "lbl_pa_plan" & dtJob.Rows(i)("NO_CONT") & "_loc" & dtJob.Rows(i)("PA_PLAN")
            lbl.Text = dtJob.Rows(i)("PA_PLAN") & " " & dtJob.Rows(i)("WEIGHT") & "T" & " " & dtJob.Rows(i)("TID") & " " & dtJob.Rows(i)("FA")
            lbl.Visible = True
            lbl.TextAlign = ContentAlignment.MiddleLeft
            objPnl.Controls.Add(lbl)

            'add label cont_data
            lbl = New Label
            lbl.Dock = DockStyle.Top
            lbl.Name = "lbl_cont_data_" & dtJob.Rows(i)("NO_CONT")
            lbl.Text = dtJob.Rows(i)("NO_CONT") & " " & dtJob.Rows(i)("ISO") & " " &
                dtJob.Rows(i)("COMMODITY") & " " & dtJob.Rows(i)("CLASS") & " " &
                Strings.Left(dtJob.Rows(i)("ID_VVD"), 4) & " " & dtJob.Rows(i)("POD")
            lbl.TextAlign = ContentAlignment.MiddleLeft
            lbl.Visible = True
            objPnl.Controls.Add(lbl)

            'add label job 
            lbl = New Label
            objPnl.Controls.Add(lbl)
            lbl.Name = "lbl_job_" & dtJob.Rows(i)("NO_CONT")
            lbl.Size = lbl_job.Size
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Dock = DockStyle.Left
            If dtJob.Rows(i)("CLASS") & dtJob.Rows(i)("ONCH_PLCMT") = "IO" Then lbl.Text = "GO"
            If dtJob.Rows(i)("CLASS") & dtJob.Rows(i)("ONCH_PLCMT") = "IP" Then lbl.Text = "DS"
            If dtJob.Rows(i)("CLASS") & dtJob.Rows(i)("ONCH_PLCMT") = "EO" Then lbl.Text = "LD"
            If dtJob.Rows(i)("CLASS") & dtJob.Rows(i)("ONCH_PLCMT") = "EP" Then lbl.Text = "GI"
            lbl.Visible = True
            lbl.SendToBack()

            'highlight panel list
            For Each obj As Control In objPnl.Controls
                If TypeOf obj Is Label Then
                    obj.Font = lbl_job.Font
                    AddHandler obj.MouseEnter, AddressOf lbl_list_job_MouseEnter
                    AddHandler obj.MouseLeave, AddressOf lbl_list_job_MouseLeave
                    AddHandler obj.Click, AddressOf lbl_list_job_Click
                End If
            Next
        Next
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        fc_vmtauth_logout(Me)
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
        Dim dr As DataRow = dt.NewRow
        dr("ID_BLOCK") = 0
        dr("BLOCK_NAME") = "All"
        dt.Rows.InsertAt(dr, 0)
        fill_combo_dt(dt, cmb_block, "ID_BLOCK", "BLOCK_NAME", False)
    End Sub

    Private Sub cmb_job_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_job.SelectedIndexChanged
        show_list_job()
    End Sub

    Private Sub FormVMT_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
        fill_combo()
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
            set_block(str(1), str(0))
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

    Private Sub cmb_block_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_block.SelectedValueChanged
        If cmb_block.Text <> "" Then
            set_block(cmb_block.Text, IIf(IsNothing(cmb_block.SelectedValue), "", cmb_block.SelectedValue))
            show_list_job()
        End If
    End Sub

    Private Sub pnl_tier_Resize(sender As Object, e As EventArgs) Handles pnl_tier.Resize
        'pnl_row.Location = New Point(pnl_row.Location.X, pnl_tier.PointToScreen(Point.Empty).Y + pnl_row.Height + 5)
    End Sub

    Private Sub txt_block_TextChanged(sender As Object, e As EventArgs) Handles txt_block.TextChanged

    End Sub

    Private Sub btn_block_next_Click(sender As Object, e As EventArgs) Handles btn_block_next.Click
        set_block_next()
    End Sub

    Private Sub btn_block_prev_Click(sender As Object, e As EventArgs) Handles btn_block_prev.Click
        set_block_prev()
    End Sub

    Private Sub btn_slot_next_Click(sender As Object, e As EventArgs) Handles btn_slot_next.Click
        set_slot_next()
    End Sub

    Private Sub btn_slot_prev_Click(sender As Object, e As EventArgs) Handles btn_slot_prev.Click
        set_slot_prev()
    End Sub

    Private Sub pnl_cell_commodity_Paint(sender As Object, e As PaintEventArgs) Handles pnl_cell_commodity.Paint

    End Sub

    Private Sub btn_clear_selection_Click(sender As Object, e As EventArgs) Handles btn_clear_selection.Click
        txt_no_cont.Text = ""
        If _preferedCell IsNot Nothing Then
            _preferedCell.BackColor = SystemColors.HighlightText
            _preferedCell = Nothing
        End If
        'clear selected cell
        '_selectedJob.ContNo = ""
        '_selectedJob.Job = ""
        '_selectedJob.Location = ""
        dtJobSelected.Clear()

        btn_chasis.Visible = False
        _formMode = Nothing
    End Sub

    Private Sub btn_active_job_Click(sender As Object, e As EventArgs) Handles btn_active_job.Click
        _formMode = formMode._onPlacement
    End Sub

    Private Sub btn_chasis_Click(sender As Object, e As EventArgs) Handles btn_chasis.Click
        '_formMode = formMode._onChasis
        Dim isOk As Boolean
        'check kondisi job
        Dim job As String = ""
        If dtJobSelected.Rows(0)("CLASS") = "I" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "P" Then
            job = "DS"
        ElseIf dtJobSelected.Rows(0)("CLASS") = "E" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "P" Then
            job = "GI"
        ElseIf dtJobSelected.Rows(0)("CLASS") = "I" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "O" Then
            job = "GO"
        ElseIf dtJobSelected.Rows(0)("CLASS") = "E" And dtJobSelected.Rows(0)("ONCH_PLCMT") = "O" Then
            job = "LD"
        End If
        'GET CONT CELL INFO
        Dim dt As DataTable = fc_vmtyrd_getpaloc(pubApiAddress, "no_cont=" & dtJobSelected.Rows(0)("NO_CONT") &
                                                 "&point=" & dtJobSelected.Rows(0)("POINT") & "&id_vvd=" & dtJobSelected.Rows(0)("ID_VVD"))
        If dt.Rows.Count = 0 Then
            'TIDAK ADA CONTAINER YANG STATUS = 1
            MessageBoxEx.Show("No Placement Found for this Container.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim res As DialogResult
        Dim iRow As Integer = dt.Rows(0)("ROW")
        Dim iTier As Integer = dt.Rows(0)("TIER")
        res = MessageBoxEx.Show("Lift on " & txt_no_cont.Text & " to " & dtJobSelected.Rows(0)("TID"), "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.No Then Return
        'get location of selected job
#Region "Save onChassis"
        'ON CHASIS HANYA Khusus CLASS = I & ONCH_PLCMT = O --> GO DAN if CLASS = E & ONCH_PLCMT = O --> LD
        If job = "LD" Or job = "GO" Then
            'CHECK JIKA ADA CONTAINER DIATAS CONTAINER YANG DIPILIH (TIER > TIER YG DIPILIH)
            dt = fc_vmtyrd_plcmnt_check_next_tier(pubApiAddress, "id_block=" & txt_block.Tag & "&row=" & iRow & "&tier=" & iTier & "&id_stack=" & txt_slot.Tag)
            If dt.Rows.Count > 1 Then
                MessageBoxEx.Show("Can not Lift Container because there's a container above it.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            isOk = fc_vmtyrd_onchs(job, dtJobSelected.Rows(0)("TRUCK_ID"), dtJobSelected.Rows(0)("NO_CONT"),
                        dtJobSelected.Rows(0)("POINT"), dtJobSelected.Rows(0)("ID_VVD"), dtJobSelected.Rows(0)("ID_CONT_DATA"),
                        _pubUser, _pubMch, txt_block.Tag, txt_block.Text, iRow, iTier, txt_slot.Tag,
                        dtJobSelected.Rows(0)("SIZE"))
            'REFRESH VISUALISASI
            refresh_visualisasi()
        Else
            MessageBoxEx.Show("On Chassis only for Job Type DS or GI", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
#End Region
    End Sub

End Class