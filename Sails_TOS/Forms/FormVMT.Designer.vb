<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVMT
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVMT))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.pnlTop = New DevComponents.DotNetBar.PanelEx()
        Me.lbl_machine = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.pnl_left = New DevComponents.DotNetBar.PanelEx()
        Me.pnl_job_list = New DevComponents.DotNetBar.PanelEx()
        Me.pnl_job = New DevComponents.DotNetBar.PanelEx()
        Me.lbl_block_cell_slot = New System.Windows.Forms.Label()
        Me.lbl_cont_data = New System.Windows.Forms.Label()
        Me.lbl_job = New System.Windows.Forms.Label()
        Me.pnl_job_block = New System.Windows.Forms.Panel()
        Me.cmb_block = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_job = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.pnl_right = New DevComponents.DotNetBar.PanelEx()
        Me.pnl_visual_block_slot = New DevComponents.DotNetBar.PanelEx()
        Me.pnl_row = New System.Windows.Forms.Panel()
        Me.lbl_row = New System.Windows.Forms.Label()
        Me.pnl_tier = New System.Windows.Forms.Panel()
        Me.lbl_tier = New System.Windows.Forms.Label()
        Me.pnl_cell = New DevComponents.DotNetBar.PanelEx()
        Me.pnl_cell_no_cont = New System.Windows.Forms.Panel()
        Me.lbl_cell_no_cont = New System.Windows.Forms.Label()
        Me.pnl_cell_commodity = New System.Windows.Forms.Panel()
        Me.lbl_cell_commodity = New System.Windows.Forms.Label()
        Me.pnl_cell_iso_class = New System.Windows.Forms.Panel()
        Me.lbl_cell_class = New System.Windows.Forms.Label()
        Me.lbl_cell_iso = New System.Windows.Forms.Label()
        Me.pnl_action = New DevComponents.DotNetBar.PanelEx()
        Me.btn_clear_selection = New System.Windows.Forms.Button()
        Me.txt_no_cont = New System.Windows.Forms.TextBox()
        Me.btn_chasis = New System.Windows.Forms.Button()
        Me.btn_active_job = New System.Windows.Forms.Button()
        Me.pnl_block_slot = New System.Windows.Forms.Panel()
        Me.btn_slot_prev = New System.Windows.Forms.Button()
        Me.txt_slot = New System.Windows.Forms.TextBox()
        Me.btn_slot_next = New System.Windows.Forms.Button()
        Me.btn_block_prev = New System.Windows.Forms.Button()
        Me.txt_block = New System.Windows.Forms.TextBox()
        Me.btn_block_next = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlTop.SuspendLayout()
        Me.pnl_left.SuspendLayout()
        Me.pnl_job.SuspendLayout()
        Me.pnl_job_block.SuspendLayout()
        Me.pnl_right.SuspendLayout()
        Me.pnl_visual_block_slot.SuspendLayout()
        Me.pnl_row.SuspendLayout()
        Me.pnl_tier.SuspendLayout()
        Me.pnl_cell.SuspendLayout()
        Me.pnl_cell_no_cont.SuspendLayout()
        Me.pnl_cell_commodity.SuspendLayout()
        Me.pnl_cell_iso_class.SuspendLayout()
        Me.pnl_action.SuspendLayout()
        Me.pnl_block_slot.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.Black
        Me.btn_logout.Location = New System.Drawing.Point(778, 7)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(66, 25)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "Log Out"
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlTop.Controls.Add(Me.lbl_machine)
        Me.pnlTop.Controls.Add(Me.btn_logout)
        Me.pnlTop.Controls.Add(Me.lbl_user)
        Me.pnlTop.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(851, 43)
        Me.pnlTop.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlTop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlTop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlTop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlTop.Style.GradientAngle = 90
        Me.pnlTop.TabIndex = 68
        '
        'lbl_machine
        '
        Me.lbl_machine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_machine.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_machine.ForeColor = System.Drawing.Color.Black
        Me.lbl_machine.Location = New System.Drawing.Point(3, 7)
        Me.lbl_machine.Name = "lbl_machine"
        Me.lbl_machine.Size = New System.Drawing.Size(464, 25)
        Me.lbl_machine.TabIndex = 68
        Me.lbl_machine.Text = "Machine"
        Me.lbl_machine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_user.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Black
        Me.lbl_user.Image = CType(resources.GetObject("lbl_user.Image"), System.Drawing.Image)
        Me.lbl_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_user.Location = New System.Drawing.Point(656, 7)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(116, 25)
        Me.lbl_user.TabIndex = 67
        Me.lbl_user.Text = "Username"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl_left
        '
        Me.pnl_left.AutoScroll = True
        Me.pnl_left.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_left.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_left.Controls.Add(Me.pnl_job_list)
        Me.pnl_left.Controls.Add(Me.pnl_job)
        Me.pnl_left.Controls.Add(Me.pnl_job_block)
        Me.pnl_left.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_left.Location = New System.Drawing.Point(0, 43)
        Me.pnl_left.Name = "pnl_left"
        Me.pnl_left.Size = New System.Drawing.Size(269, 393)
        Me.pnl_left.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_left.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_left.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnl_left.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_left.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_left.Style.GradientAngle = 90
        Me.pnl_left.TabIndex = 72
        '
        'pnl_job_list
        '
        Me.pnl_job_list.AutoScroll = True
        Me.pnl_job_list.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_job_list.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_job_list.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_job_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_job_list.Location = New System.Drawing.Point(0, 120)
        Me.pnl_job_list.Name = "pnl_job_list"
        Me.pnl_job_list.Padding = New System.Windows.Forms.Padding(4)
        Me.pnl_job_list.Size = New System.Drawing.Size(269, 273)
        Me.pnl_job_list.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_job_list.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_job_list.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_job_list.Style.GradientAngle = 90
        Me.pnl_job_list.TabIndex = 42
        '
        'pnl_job
        '
        Me.pnl_job.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_job.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_job.Controls.Add(Me.lbl_block_cell_slot)
        Me.pnl_job.Controls.Add(Me.lbl_cont_data)
        Me.pnl_job.Controls.Add(Me.lbl_job)
        Me.pnl_job.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_job.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_job.Location = New System.Drawing.Point(0, 66)
        Me.pnl_job.Name = "pnl_job"
        Me.pnl_job.Padding = New System.Windows.Forms.Padding(5)
        Me.pnl_job.Size = New System.Drawing.Size(269, 54)
        Me.pnl_job.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_job.Style.BackColor1.Color = System.Drawing.SystemColors.ButtonFace
        Me.pnl_job.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnl_job.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_job.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_job.Style.GradientAngle = 90
        Me.pnl_job.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl_job.TabIndex = 7
        Me.pnl_job.Visible = False
        '
        'lbl_block_cell_slot
        '
        Me.lbl_block_cell_slot.BackColor = System.Drawing.Color.Transparent
        Me.lbl_block_cell_slot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_block_cell_slot.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_block_cell_slot.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_block_cell_slot.ForeColor = System.Drawing.Color.Black
        Me.lbl_block_cell_slot.Location = New System.Drawing.Point(38, 28)
        Me.lbl_block_cell_slot.Name = "lbl_block_cell_slot"
        Me.lbl_block_cell_slot.Size = New System.Drawing.Size(226, 23)
        Me.lbl_block_cell_slot.TabIndex = 72
        Me.lbl_block_cell_slot.Text = "Job"
        Me.lbl_block_cell_slot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_cont_data
        '
        Me.lbl_cont_data.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cont_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_cont_data.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_cont_data.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cont_data.ForeColor = System.Drawing.Color.Black
        Me.lbl_cont_data.Location = New System.Drawing.Point(38, 5)
        Me.lbl_cont_data.Name = "lbl_cont_data"
        Me.lbl_cont_data.Size = New System.Drawing.Size(226, 23)
        Me.lbl_cont_data.TabIndex = 71
        Me.lbl_cont_data.Text = "BARY02111112 2200 G I MRBM IDJKT"
        Me.lbl_cont_data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_job
        '
        Me.lbl_job.BackColor = System.Drawing.Color.Transparent
        Me.lbl_job.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_job.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_job.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_job.ForeColor = System.Drawing.Color.Black
        Me.lbl_job.Location = New System.Drawing.Point(5, 5)
        Me.lbl_job.Name = "lbl_job"
        Me.lbl_job.Size = New System.Drawing.Size(33, 44)
        Me.lbl_job.TabIndex = 70
        Me.lbl_job.Text = "DS"
        Me.lbl_job.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_job_block
        '
        Me.pnl_job_block.Controls.Add(Me.cmb_block)
        Me.pnl_job_block.Controls.Add(Me.Label2)
        Me.pnl_job_block.Controls.Add(Me.cmb_job)
        Me.pnl_job_block.Controls.Add(Me.Label1)
        Me.pnl_job_block.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_job_block.ForeColor = System.Drawing.Color.Black
        Me.pnl_job_block.Location = New System.Drawing.Point(0, 0)
        Me.pnl_job_block.Name = "pnl_job_block"
        Me.pnl_job_block.Size = New System.Drawing.Size(269, 66)
        Me.pnl_job_block.TabIndex = 1
        '
        'cmb_block
        '
        Me.cmb_block.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_block.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_block.DisplayMember = "Text"
        Me.cmb_block.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_block.ForeColor = System.Drawing.Color.Black
        Me.cmb_block.FormattingEnabled = True
        Me.cmb_block.ItemHeight = 17
        Me.cmb_block.Location = New System.Drawing.Point(82, 35)
        Me.cmb_block.Name = "cmb_block"
        Me.cmb_block.Size = New System.Drawing.Size(181, 23)
        Me.cmb_block.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_block.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Block"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_job
        '
        Me.cmb_job.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_job.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_job.DisplayMember = "Text"
        Me.cmb_job.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_job.ForeColor = System.Drawing.Color.Black
        Me.cmb_job.FormattingEnabled = True
        Me.cmb_job.ItemHeight = 17
        Me.cmb_job.Location = New System.Drawing.Point(82, 6)
        Me.cmb_job.Name = "cmb_job"
        Me.cmb_job.Size = New System.Drawing.Size(181, 23)
        Me.cmb_job.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_job.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 23)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Job"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.ExpandableControl = Me.pnl_left
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.Black
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.ForeColor = System.Drawing.Color.Black
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.Black
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.Empty
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.Black
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(269, 43)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 393)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 76
        Me.ExpandableSplitter1.TabStop = False
        '
        'pnl_right
        '
        Me.pnl_right.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_right.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_right.Controls.Add(Me.pnl_visual_block_slot)
        Me.pnl_right.Controls.Add(Me.pnl_action)
        Me.pnl_right.Controls.Add(Me.pnl_block_slot)
        Me.pnl_right.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_right.Location = New System.Drawing.Point(275, 43)
        Me.pnl_right.Name = "pnl_right"
        Me.pnl_right.Size = New System.Drawing.Size(576, 393)
        Me.pnl_right.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_right.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_right.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnl_right.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_right.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_right.Style.GradientAngle = 90
        Me.pnl_right.TabIndex = 80
        '
        'pnl_visual_block_slot
        '
        Me.pnl_visual_block_slot.AutoScroll = True
        Me.pnl_visual_block_slot.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_visual_block_slot.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_visual_block_slot.Controls.Add(Me.pnl_row)
        Me.pnl_visual_block_slot.Controls.Add(Me.pnl_tier)
        Me.pnl_visual_block_slot.Controls.Add(Me.pnl_cell)
        Me.pnl_visual_block_slot.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_visual_block_slot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_visual_block_slot.Location = New System.Drawing.Point(0, 103)
        Me.pnl_visual_block_slot.Name = "pnl_visual_block_slot"
        Me.pnl_visual_block_slot.Padding = New System.Windows.Forms.Padding(10)
        Me.pnl_visual_block_slot.Size = New System.Drawing.Size(576, 290)
        Me.pnl_visual_block_slot.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_visual_block_slot.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_visual_block_slot.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnl_visual_block_slot.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_visual_block_slot.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_visual_block_slot.Style.GradientAngle = 90
        Me.pnl_visual_block_slot.TabIndex = 11
        '
        'pnl_row
        '
        Me.pnl_row.AutoSize = True
        Me.pnl_row.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_row.Controls.Add(Me.lbl_row)
        Me.pnl_row.ForeColor = System.Drawing.Color.Black
        Me.pnl_row.Location = New System.Drawing.Point(40, 76)
        Me.pnl_row.MinimumSize = New System.Drawing.Size(67, 25)
        Me.pnl_row.Name = "pnl_row"
        Me.pnl_row.Padding = New System.Windows.Forms.Padding(2)
        Me.pnl_row.Size = New System.Drawing.Size(71, 25)
        Me.pnl_row.TabIndex = 22
        '
        'lbl_row
        '
        Me.lbl_row.AutoSize = True
        Me.lbl_row.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_row.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_row.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_row.ForeColor = System.Drawing.Color.Black
        Me.lbl_row.Location = New System.Drawing.Point(2, 2)
        Me.lbl_row.MinimumSize = New System.Drawing.Size(64, 2)
        Me.lbl_row.Name = "lbl_row"
        Me.lbl_row.Size = New System.Drawing.Size(64, 17)
        Me.lbl_row.TabIndex = 74
        Me.lbl_row.Text = "04"
        Me.lbl_row.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_row.Visible = False
        '
        'pnl_tier
        '
        Me.pnl_tier.AutoSize = True
        Me.pnl_tier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_tier.Controls.Add(Me.lbl_tier)
        Me.pnl_tier.ForeColor = System.Drawing.Color.Black
        Me.pnl_tier.Location = New System.Drawing.Point(10, 10)
        Me.pnl_tier.MinimumSize = New System.Drawing.Size(25, 60)
        Me.pnl_tier.Name = "pnl_tier"
        Me.pnl_tier.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_tier.Size = New System.Drawing.Size(25, 62)
        Me.pnl_tier.TabIndex = 18
        '
        'lbl_tier
        '
        Me.lbl_tier.AutoSize = True
        Me.lbl_tier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_tier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_tier.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tier.ForeColor = System.Drawing.Color.Black
        Me.lbl_tier.Location = New System.Drawing.Point(1, 1)
        Me.lbl_tier.MinimumSize = New System.Drawing.Size(15, 60)
        Me.lbl_tier.Name = "lbl_tier"
        Me.lbl_tier.Size = New System.Drawing.Size(15, 60)
        Me.lbl_tier.TabIndex = 77
        Me.lbl_tier.Text = "1"
        Me.lbl_tier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_tier.Visible = False
        '
        'pnl_cell
        '
        Me.pnl_cell.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_cell.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_cell.Controls.Add(Me.pnl_cell_no_cont)
        Me.pnl_cell.Controls.Add(Me.pnl_cell_commodity)
        Me.pnl_cell.Controls.Add(Me.pnl_cell_iso_class)
        Me.pnl_cell.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_cell.Location = New System.Drawing.Point(40, 10)
        Me.pnl_cell.Name = "pnl_cell"
        Me.pnl_cell.Padding = New System.Windows.Forms.Padding(3)
        Me.pnl_cell.Size = New System.Drawing.Size(62, 60)
        Me.pnl_cell.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_cell.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_cell.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnl_cell.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_cell.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_cell.Style.GradientAngle = 90
        Me.pnl_cell.TabIndex = 14
        Me.pnl_cell.Visible = False
        '
        'pnl_cell_no_cont
        '
        Me.pnl_cell_no_cont.Controls.Add(Me.lbl_cell_no_cont)
        Me.pnl_cell_no_cont.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_cell_no_cont.ForeColor = System.Drawing.Color.Black
        Me.pnl_cell_no_cont.Location = New System.Drawing.Point(3, 39)
        Me.pnl_cell_no_cont.Name = "pnl_cell_no_cont"
        Me.pnl_cell_no_cont.Size = New System.Drawing.Size(56, 18)
        Me.pnl_cell_no_cont.TabIndex = 2
        '
        'lbl_cell_no_cont
        '
        Me.lbl_cell_no_cont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_cell_no_cont.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_cell_no_cont.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell_no_cont.ForeColor = System.Drawing.Color.Black
        Me.lbl_cell_no_cont.Location = New System.Drawing.Point(0, 3)
        Me.lbl_cell_no_cont.Name = "lbl_cell_no_cont"
        Me.lbl_cell_no_cont.Size = New System.Drawing.Size(56, 15)
        Me.lbl_cell_no_cont.TabIndex = 71
        Me.lbl_cell_no_cont.Text = "1234"
        Me.lbl_cell_no_cont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl_cell_commodity
        '
        Me.pnl_cell_commodity.Controls.Add(Me.lbl_cell_commodity)
        Me.pnl_cell_commodity.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_cell_commodity.ForeColor = System.Drawing.Color.Black
        Me.pnl_cell_commodity.Location = New System.Drawing.Point(3, 21)
        Me.pnl_cell_commodity.Name = "pnl_cell_commodity"
        Me.pnl_cell_commodity.Size = New System.Drawing.Size(56, 18)
        Me.pnl_cell_commodity.TabIndex = 1
        '
        'lbl_cell_commodity
        '
        Me.lbl_cell_commodity.AutoSize = True
        Me.lbl_cell_commodity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_cell_commodity.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_cell_commodity.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell_commodity.ForeColor = System.Drawing.Color.Black
        Me.lbl_cell_commodity.Location = New System.Drawing.Point(0, 0)
        Me.lbl_cell_commodity.Name = "lbl_cell_commodity"
        Me.lbl_cell_commodity.Size = New System.Drawing.Size(15, 15)
        Me.lbl_cell_commodity.TabIndex = 70
        Me.lbl_cell_commodity.Text = "G"
        Me.lbl_cell_commodity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_cell_iso_class
        '
        Me.pnl_cell_iso_class.Controls.Add(Me.lbl_cell_class)
        Me.pnl_cell_iso_class.Controls.Add(Me.lbl_cell_iso)
        Me.pnl_cell_iso_class.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_cell_iso_class.ForeColor = System.Drawing.Color.Black
        Me.pnl_cell_iso_class.Location = New System.Drawing.Point(3, 3)
        Me.pnl_cell_iso_class.Name = "pnl_cell_iso_class"
        Me.pnl_cell_iso_class.Size = New System.Drawing.Size(56, 18)
        Me.pnl_cell_iso_class.TabIndex = 0
        '
        'lbl_cell_class
        '
        Me.lbl_cell_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_cell_class.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_cell_class.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell_class.ForeColor = System.Drawing.Color.Black
        Me.lbl_cell_class.Location = New System.Drawing.Point(35, 0)
        Me.lbl_cell_class.Name = "lbl_cell_class"
        Me.lbl_cell_class.Size = New System.Drawing.Size(21, 18)
        Me.lbl_cell_class.TabIndex = 71
        Me.lbl_cell_class.Text = "I"
        Me.lbl_cell_class.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_cell_iso
        '
        Me.lbl_cell_iso.AutoSize = True
        Me.lbl_cell_iso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_cell_iso.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_cell_iso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cell_iso.ForeColor = System.Drawing.Color.Black
        Me.lbl_cell_iso.Location = New System.Drawing.Point(0, 0)
        Me.lbl_cell_iso.Name = "lbl_cell_iso"
        Me.lbl_cell_iso.Size = New System.Drawing.Size(35, 15)
        Me.lbl_cell_iso.TabIndex = 70
        Me.lbl_cell_iso.Text = "2200"
        Me.lbl_cell_iso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_action
        '
        Me.pnl_action.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_action.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_action.Controls.Add(Me.btn_clear_selection)
        Me.pnl_action.Controls.Add(Me.txt_no_cont)
        Me.pnl_action.Controls.Add(Me.btn_chasis)
        Me.pnl_action.Controls.Add(Me.btn_active_job)
        Me.pnl_action.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_action.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_action.Location = New System.Drawing.Point(0, 63)
        Me.pnl_action.Name = "pnl_action"
        Me.pnl_action.Size = New System.Drawing.Size(576, 40)
        Me.pnl_action.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_action.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_action.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnl_action.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_action.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_action.Style.GradientAngle = 90
        Me.pnl_action.TabIndex = 4
        '
        'btn_clear_selection
        '
        Me.btn_clear_selection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear_selection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_clear_selection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_clear_selection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear_selection.ForeColor = System.Drawing.Color.Black
        Me.btn_clear_selection.Image = CType(resources.GetObject("btn_clear_selection.Image"), System.Drawing.Image)
        Me.btn_clear_selection.Location = New System.Drawing.Point(542, 6)
        Me.btn_clear_selection.Name = "btn_clear_selection"
        Me.btn_clear_selection.Size = New System.Drawing.Size(27, 25)
        Me.btn_clear_selection.TabIndex = 15
        Me.btn_clear_selection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clear_selection.UseVisualStyleBackColor = False
        '
        'txt_no_cont
        '
        Me.txt_no_cont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_no_cont.BackColor = System.Drawing.Color.White
        Me.txt_no_cont.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_cont.ForeColor = System.Drawing.Color.Black
        Me.txt_no_cont.Location = New System.Drawing.Point(394, 6)
        Me.txt_no_cont.Name = "txt_no_cont"
        Me.txt_no_cont.Size = New System.Drawing.Size(142, 25)
        Me.txt_no_cont.TabIndex = 14
        '
        'btn_chasis
        '
        Me.btn_chasis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_chasis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_chasis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_chasis.ForeColor = System.Drawing.Color.Black
        Me.btn_chasis.Location = New System.Drawing.Point(113, 6)
        Me.btn_chasis.Name = "btn_chasis"
        Me.btn_chasis.Size = New System.Drawing.Size(101, 25)
        Me.btn_chasis.TabIndex = 12
        Me.btn_chasis.Text = "On Chassis"
        Me.btn_chasis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_chasis.UseVisualStyleBackColor = False
        '
        'btn_active_job
        '
        Me.btn_active_job.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_active_job.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_active_job.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_active_job.ForeColor = System.Drawing.Color.Black
        Me.btn_active_job.Location = New System.Drawing.Point(6, 6)
        Me.btn_active_job.Name = "btn_active_job"
        Me.btn_active_job.Size = New System.Drawing.Size(101, 25)
        Me.btn_active_job.TabIndex = 11
        Me.btn_active_job.Text = "Activate Job"
        Me.btn_active_job.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_active_job.UseVisualStyleBackColor = False
        '
        'pnl_block_slot
        '
        Me.pnl_block_slot.Controls.Add(Me.btn_slot_prev)
        Me.pnl_block_slot.Controls.Add(Me.txt_slot)
        Me.pnl_block_slot.Controls.Add(Me.btn_slot_next)
        Me.pnl_block_slot.Controls.Add(Me.btn_block_prev)
        Me.pnl_block_slot.Controls.Add(Me.txt_block)
        Me.pnl_block_slot.Controls.Add(Me.btn_block_next)
        Me.pnl_block_slot.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_block_slot.ForeColor = System.Drawing.Color.Black
        Me.pnl_block_slot.Location = New System.Drawing.Point(0, 0)
        Me.pnl_block_slot.Name = "pnl_block_slot"
        Me.pnl_block_slot.Size = New System.Drawing.Size(576, 63)
        Me.pnl_block_slot.TabIndex = 2
        '
        'btn_slot_prev
        '
        Me.btn_slot_prev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_slot_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_slot_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slot_prev.ForeColor = System.Drawing.Color.Black
        Me.btn_slot_prev.Image = CType(resources.GetObject("btn_slot_prev.Image"), System.Drawing.Image)
        Me.btn_slot_prev.Location = New System.Drawing.Point(336, 6)
        Me.btn_slot_prev.Name = "btn_slot_prev"
        Me.btn_slot_prev.Size = New System.Drawing.Size(52, 50)
        Me.btn_slot_prev.TabIndex = 14
        Me.btn_slot_prev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_slot_prev.UseVisualStyleBackColor = False
        '
        'txt_slot
        '
        Me.txt_slot.BackColor = System.Drawing.Color.White
        Me.txt_slot.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_slot.ForeColor = System.Drawing.Color.Black
        Me.txt_slot.Location = New System.Drawing.Point(258, 6)
        Me.txt_slot.Name = "txt_slot"
        Me.txt_slot.ReadOnly = True
        Me.txt_slot.Size = New System.Drawing.Size(72, 50)
        Me.txt_slot.TabIndex = 13
        Me.txt_slot.Text = "16"
        Me.txt_slot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_slot_next
        '
        Me.btn_slot_next.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_slot_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_slot_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_slot_next.ForeColor = System.Drawing.Color.Black
        Me.btn_slot_next.Image = CType(resources.GetObject("btn_slot_next.Image"), System.Drawing.Image)
        Me.btn_slot_next.Location = New System.Drawing.Point(200, 6)
        Me.btn_slot_next.Name = "btn_slot_next"
        Me.btn_slot_next.Size = New System.Drawing.Size(52, 50)
        Me.btn_slot_next.TabIndex = 12
        Me.btn_slot_next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_slot_next.UseVisualStyleBackColor = False
        '
        'btn_block_prev
        '
        Me.btn_block_prev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_block_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_block_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_block_prev.ForeColor = System.Drawing.Color.Black
        Me.btn_block_prev.Image = CType(resources.GetObject("btn_block_prev.Image"), System.Drawing.Image)
        Me.btn_block_prev.Location = New System.Drawing.Point(142, 6)
        Me.btn_block_prev.Name = "btn_block_prev"
        Me.btn_block_prev.Size = New System.Drawing.Size(52, 50)
        Me.btn_block_prev.TabIndex = 11
        Me.btn_block_prev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_block_prev.UseVisualStyleBackColor = False
        '
        'txt_block
        '
        Me.txt_block.BackColor = System.Drawing.Color.White
        Me.txt_block.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_block.ForeColor = System.Drawing.Color.Black
        Me.txt_block.Location = New System.Drawing.Point(64, 6)
        Me.txt_block.Name = "txt_block"
        Me.txt_block.ReadOnly = True
        Me.txt_block.Size = New System.Drawing.Size(72, 50)
        Me.txt_block.TabIndex = 10
        Me.txt_block.Text = "2I"
        Me.txt_block.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_block_next
        '
        Me.btn_block_next.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_block_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_block_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_block_next.ForeColor = System.Drawing.Color.Black
        Me.btn_block_next.Image = CType(resources.GetObject("btn_block_next.Image"), System.Drawing.Image)
        Me.btn_block_next.Location = New System.Drawing.Point(6, 6)
        Me.btn_block_next.Name = "btn_block_next"
        Me.btn_block_next.Size = New System.Drawing.Size(52, 50)
        Me.btn_block_next.TabIndex = 9
        Me.btn_block_next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_block_next.UseVisualStyleBackColor = False
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "6. No Work Area.png")
        '
        'FormVMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 436)
        Me.Controls.Add(Me.pnl_right)
        Me.Controls.Add(Me.ExpandableSplitter1)
        Me.Controls.Add(Me.pnl_left)
        Me.Controls.Add(Me.pnlTop)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FormVMT"
        Me.Text = "VMT"
        Me.pnlTop.ResumeLayout(False)
        Me.pnl_left.ResumeLayout(False)
        Me.pnl_job.ResumeLayout(False)
        Me.pnl_job_block.ResumeLayout(False)
        Me.pnl_right.ResumeLayout(False)
        Me.pnl_visual_block_slot.ResumeLayout(False)
        Me.pnl_visual_block_slot.PerformLayout()
        Me.pnl_row.ResumeLayout(False)
        Me.pnl_row.PerformLayout()
        Me.pnl_tier.ResumeLayout(False)
        Me.pnl_tier.PerformLayout()
        Me.pnl_cell.ResumeLayout(False)
        Me.pnl_cell_no_cont.ResumeLayout(False)
        Me.pnl_cell_commodity.ResumeLayout(False)
        Me.pnl_cell_commodity.PerformLayout()
        Me.pnl_cell_iso_class.ResumeLayout(False)
        Me.pnl_cell_iso_class.PerformLayout()
        Me.pnl_action.ResumeLayout(False)
        Me.pnl_action.PerformLayout()
        Me.pnl_block_slot.ResumeLayout(False)
        Me.pnl_block_slot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btn_logout As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents pnlTop As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lbl_machine As Label
    Friend WithEvents pnl_left As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents pnl_right As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnl_job_block As Panel
    Friend WithEvents pnl_block_slot As Panel
    Friend WithEvents Label1 As Label
    Private WithEvents cmb_block As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label2 As Label
    Private WithEvents cmb_job As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_block_next As Button
    Friend WithEvents btn_block_prev As Button
    Friend WithEvents txt_block As TextBox
    Friend WithEvents btn_slot_prev As Button
    Friend WithEvents txt_slot As TextBox
    Friend WithEvents btn_slot_next As Button
    Friend WithEvents pnl_action As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btn_chasis As Button
    Friend WithEvents btn_active_job As Button
    Friend WithEvents btn_clear_selection As Button
    Friend WithEvents txt_no_cont As TextBox
    Friend WithEvents pnl_job_list As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnl_job As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lbl_job As Label
    Friend WithEvents lbl_block_cell_slot As Label
    Friend WithEvents lbl_cont_data As Label
    Friend WithEvents pnl_visual_block_slot As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnl_row As Panel
    Friend WithEvents lbl_row As Label
    Friend WithEvents pnl_tier As Panel
    Friend WithEvents pnl_cell As DevComponents.DotNetBar.PanelEx
    Friend WithEvents pnl_cell_no_cont As Panel
    Friend WithEvents lbl_cell_no_cont As Label
    Friend WithEvents pnl_cell_commodity As Panel
    Friend WithEvents lbl_cell_commodity As Label
    Friend WithEvents pnl_cell_iso_class As Panel
    Friend WithEvents lbl_cell_class As Label
    Friend WithEvents lbl_cell_iso As Label
    Friend WithEvents lbl_tier As Label
    Friend WithEvents img As ImageList
End Class
