<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormYardDefinition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormYardDefinition))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.tabMenu = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btn_delete_block = New System.Windows.Forms.Button()
        Me.btn_edit_block = New System.Windows.Forms.Button()
        Me.btn_add_block = New System.Windows.Forms.Button()
        Me.grid_block = New System.Windows.Forms.DataGridView()
        Me.pnl_search_block = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_search_block_type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmb_search_block_name = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmd_search_block = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_block = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.cmd_delete_slot = New System.Windows.Forms.Button()
        Me.cmd_edit_slot = New System.Windows.Forms.Button()
        Me.cmd_add_slot = New System.Windows.Forms.Button()
        Me.grid_slot = New System.Windows.Forms.DataGridView()
        Me.pnl_search_slot = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmd_search_slot_block = New System.Windows.Forms.Button()
        Me.cmb_search_slot_block = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab_slot = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.tabMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMenu.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.grid_block, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_search_block.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.grid_slot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_search_slot.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'tabMenu
        '
        Me.tabMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.tabMenu.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.tabMenu.ControlBox.MenuBox.Name = ""
        Me.tabMenu.ControlBox.Name = ""
        Me.tabMenu.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabMenu.ControlBox.MenuBox, Me.tabMenu.ControlBox.CloseBox})
        Me.tabMenu.Controls.Add(Me.SuperTabControlPanel1)
        Me.tabMenu.Controls.Add(Me.SuperTabControlPanel2)
        Me.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMenu.FixedTabSize = New System.Drawing.Size(150, 0)
        Me.tabMenu.ForeColor = System.Drawing.Color.Black
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.ReorderTabsEnabled = True
        Me.tabMenu.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabMenu.SelectedTabIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(802, 436)
        Me.tabMenu.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
        Me.tabMenu.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMenu.TabHorizontalSpacing = 7
        Me.tabMenu.TabIndex = 25
        Me.tabMenu.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tab_block, Me.tab_slot})
        Me.tabMenu.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.btn_delete_block)
        Me.SuperTabControlPanel1.Controls.Add(Me.btn_edit_block)
        Me.SuperTabControlPanel1.Controls.Add(Me.btn_add_block)
        Me.SuperTabControlPanel1.Controls.Add(Me.grid_block)
        Me.SuperTabControlPanel1.Controls.Add(Me.pnl_search_block)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(650, 436)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.tab_block
        '
        'btn_delete_block
        '
        Me.btn_delete_block.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete_block.FlatAppearance.BorderSize = 0
        Me.btn_delete_block.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_block.ForeColor = System.Drawing.Color.Black
        Me.btn_delete_block.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete_block.Location = New System.Drawing.Point(148, 52)
        Me.btn_delete_block.Name = "btn_delete_block"
        Me.btn_delete_block.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete_block.TabIndex = 40
        Me.btn_delete_block.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete_block.UseVisualStyleBackColor = False
        '
        'btn_edit_block
        '
        Me.btn_edit_block.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit_block.FlatAppearance.BorderSize = 0
        Me.btn_edit_block.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_block.ForeColor = System.Drawing.Color.Black
        Me.btn_edit_block.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.btn_edit_block.Location = New System.Drawing.Point(77, 52)
        Me.btn_edit_block.Name = "btn_edit_block"
        Me.btn_edit_block.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit_block.TabIndex = 39
        Me.btn_edit_block.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit_block.UseVisualStyleBackColor = False
        '
        'btn_add_block
        '
        Me.btn_add_block.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_block.FlatAppearance.BorderSize = 0
        Me.btn_add_block.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_block.ForeColor = System.Drawing.Color.Black
        Me.btn_add_block.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.btn_add_block.Location = New System.Drawing.Point(6, 52)
        Me.btn_add_block.Name = "btn_add_block"
        Me.btn_add_block.Size = New System.Drawing.Size(66, 25)
        Me.btn_add_block.TabIndex = 38
        Me.btn_add_block.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add_block.UseVisualStyleBackColor = False
        '
        'grid_block
        '
        Me.grid_block.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_block.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_block.Location = New System.Drawing.Point(6, 81)
        Me.grid_block.Name = "grid_block"
        Me.grid_block.Size = New System.Drawing.Size(638, 345)
        Me.grid_block.TabIndex = 37
        '
        'pnl_search_block
        '
        Me.pnl_search_block.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_search_block.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search_block.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search_block.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_search_block.Controls.Add(Me.Label2)
        Me.pnl_search_block.Controls.Add(Me.cmb_search_block_type)
        Me.pnl_search_block.Controls.Add(Me.cmb_search_block_name)
        Me.pnl_search_block.Controls.Add(Me.cmd_search_block)
        Me.pnl_search_block.Controls.Add(Me.Label1)
        Me.pnl_search_block.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search_block.Location = New System.Drawing.Point(6, 10)
        Me.pnl_search_block.Name = "pnl_search_block"
        Me.pnl_search_block.Size = New System.Drawing.Size(638, 36)
        '
        '
        '
        Me.pnl_search_block.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_search_block.Style.BackColorGradientAngle = 90
        Me.pnl_search_block.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_search_block.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_block.Style.BorderBottomWidth = 1
        Me.pnl_search_block.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_search_block.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_block.Style.BorderLeftWidth = 1
        Me.pnl_search_block.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_block.Style.BorderRightWidth = 1
        Me.pnl_search_block.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_block.Style.BorderTopWidth = 1
        Me.pnl_search_block.Style.CornerDiameter = 4
        Me.pnl_search_block.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_search_block.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.pnl_search_block.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_search_block.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_search_block.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_search_block.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_search_block.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(233, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Block Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_search_block_type
        '
        Me.cmb_search_block_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_search_block_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_search_block_type.DisplayMember = "Text"
        Me.cmb_search_block_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_search_block_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_search_block_type.ForeColor = System.Drawing.Color.Black
        Me.cmb_search_block_type.FormattingEnabled = True
        Me.cmb_search_block_type.ItemHeight = 17
        Me.cmb_search_block_type.Location = New System.Drawing.Point(314, 3)
        Me.cmb_search_block_type.Name = "cmb_search_block_type"
        Me.cmb_search_block_type.Size = New System.Drawing.Size(121, 23)
        Me.cmb_search_block_type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_search_block_type.TabIndex = 9
        '
        'cmb_search_block_name
        '
        Me.cmb_search_block_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_search_block_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_search_block_name.DisplayMember = "Text"
        Me.cmb_search_block_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_search_block_name.ForeColor = System.Drawing.Color.Black
        Me.cmb_search_block_name.FormattingEnabled = True
        Me.cmb_search_block_name.ItemHeight = 17
        Me.cmb_search_block_name.Location = New System.Drawing.Point(96, 3)
        Me.cmb_search_block_name.Name = "cmb_search_block_name"
        Me.cmb_search_block_name.Size = New System.Drawing.Size(121, 23)
        Me.cmb_search_block_name.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_search_block_name.TabIndex = 6
        '
        'cmd_search_block
        '
        Me.cmd_search_block.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_search_block.FlatAppearance.BorderSize = 0
        Me.cmd_search_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_search_block.ForeColor = System.Drawing.Color.Black
        Me.cmd_search_block.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.cmd_search_block.Location = New System.Drawing.Point(441, 3)
        Me.cmd_search_block.Name = "cmd_search_block"
        Me.cmd_search_block.Size = New System.Drawing.Size(97, 23)
        Me.cmd_search_block.TabIndex = 7
        Me.cmd_search_block.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Block Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tab_block
        '
        Me.tab_block.AttachedControl = Me.SuperTabControlPanel1
        Me.tab_block.GlobalItem = False
        Me.tab_block.Image = CType(resources.GetObject("tab_block.Image"), System.Drawing.Image)
        Me.tab_block.Name = "tab_block"
        Me.tab_block.Text = "Block"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.cmd_delete_slot)
        Me.SuperTabControlPanel2.Controls.Add(Me.cmd_edit_slot)
        Me.SuperTabControlPanel2.Controls.Add(Me.cmd_add_slot)
        Me.SuperTabControlPanel2.Controls.Add(Me.grid_slot)
        Me.SuperTabControlPanel2.Controls.Add(Me.pnl_search_slot)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(650, 436)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.tab_slot
        '
        'cmd_delete_slot
        '
        Me.cmd_delete_slot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_delete_slot.FlatAppearance.BorderSize = 0
        Me.cmd_delete_slot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_delete_slot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_delete_slot.ForeColor = System.Drawing.Color.Black
        Me.cmd_delete_slot.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.cmd_delete_slot.Location = New System.Drawing.Point(148, 52)
        Me.cmd_delete_slot.Name = "cmd_delete_slot"
        Me.cmd_delete_slot.Size = New System.Drawing.Size(78, 25)
        Me.cmd_delete_slot.TabIndex = 45
        Me.cmd_delete_slot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmd_delete_slot.UseVisualStyleBackColor = False
        '
        'cmd_edit_slot
        '
        Me.cmd_edit_slot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_edit_slot.FlatAppearance.BorderSize = 0
        Me.cmd_edit_slot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_edit_slot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_edit_slot.ForeColor = System.Drawing.Color.Black
        Me.cmd_edit_slot.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.cmd_edit_slot.Location = New System.Drawing.Point(77, 52)
        Me.cmd_edit_slot.Name = "cmd_edit_slot"
        Me.cmd_edit_slot.Size = New System.Drawing.Size(66, 25)
        Me.cmd_edit_slot.TabIndex = 44
        Me.cmd_edit_slot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit_slot.UseVisualStyleBackColor = False
        '
        'cmd_add_slot
        '
        Me.cmd_add_slot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_add_slot.FlatAppearance.BorderSize = 0
        Me.cmd_add_slot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_add_slot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_add_slot.ForeColor = System.Drawing.Color.Black
        Me.cmd_add_slot.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.cmd_add_slot.Location = New System.Drawing.Point(6, 52)
        Me.cmd_add_slot.Name = "cmd_add_slot"
        Me.cmd_add_slot.Size = New System.Drawing.Size(66, 25)
        Me.cmd_add_slot.TabIndex = 43
        Me.cmd_add_slot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_add_slot.UseVisualStyleBackColor = False
        '
        'grid_slot
        '
        Me.grid_slot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_slot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_slot.Location = New System.Drawing.Point(6, 81)
        Me.grid_slot.Name = "grid_slot"
        Me.grid_slot.Size = New System.Drawing.Size(638, 345)
        Me.grid_slot.TabIndex = 42
        '
        'pnl_search_slot
        '
        Me.pnl_search_slot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_search_slot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search_slot.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search_slot.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_search_slot.Controls.Add(Me.cmd_search_slot_block)
        Me.pnl_search_slot.Controls.Add(Me.cmb_search_slot_block)
        Me.pnl_search_slot.Controls.Add(Me.Label4)
        Me.pnl_search_slot.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search_slot.Location = New System.Drawing.Point(6, 10)
        Me.pnl_search_slot.Name = "pnl_search_slot"
        Me.pnl_search_slot.Size = New System.Drawing.Size(638, 36)
        '
        '
        '
        Me.pnl_search_slot.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_search_slot.Style.BackColorGradientAngle = 90
        Me.pnl_search_slot.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_search_slot.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_slot.Style.BorderBottomWidth = 1
        Me.pnl_search_slot.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_search_slot.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_slot.Style.BorderLeftWidth = 1
        Me.pnl_search_slot.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_slot.Style.BorderRightWidth = 1
        Me.pnl_search_slot.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search_slot.Style.BorderTopWidth = 1
        Me.pnl_search_slot.Style.CornerDiameter = 4
        Me.pnl_search_slot.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_search_slot.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.pnl_search_slot.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_search_slot.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_search_slot.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_search_slot.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_search_slot.TabIndex = 41
        '
        'cmd_search_slot_block
        '
        Me.cmd_search_slot_block.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_search_slot_block.FlatAppearance.BorderSize = 0
        Me.cmd_search_slot_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_search_slot_block.ForeColor = System.Drawing.Color.Black
        Me.cmd_search_slot_block.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.cmd_search_slot_block.Location = New System.Drawing.Point(223, 3)
        Me.cmd_search_slot_block.Name = "cmd_search_slot_block"
        Me.cmd_search_slot_block.Size = New System.Drawing.Size(97, 23)
        Me.cmd_search_slot_block.TabIndex = 9
        Me.cmd_search_slot_block.UseVisualStyleBackColor = False
        '
        'cmb_search_slot_block
        '
        Me.cmb_search_slot_block.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_search_slot_block.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_search_slot_block.DisplayMember = "Text"
        Me.cmb_search_slot_block.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_search_slot_block.ForeColor = System.Drawing.Color.Black
        Me.cmb_search_slot_block.FormattingEnabled = True
        Me.cmb_search_slot_block.ItemHeight = 17
        Me.cmb_search_slot_block.Location = New System.Drawing.Point(96, 3)
        Me.cmb_search_slot_block.Name = "cmb_search_slot_block"
        Me.cmb_search_slot_block.Size = New System.Drawing.Size(121, 23)
        Me.cmb_search_slot_block.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_search_slot_block.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Block Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tab_slot
        '
        Me.tab_slot.AttachedControl = Me.SuperTabControlPanel2
        Me.tab_slot.GlobalItem = False
        Me.tab_slot.Image = CType(resources.GetObject("tab_slot.Image"), System.Drawing.Image)
        Me.tab_slot.Name = "tab_slot"
        Me.tab_slot.Text = "Slot"
        '
        'FormYardDefinition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 436)
        Me.Controls.Add(Me.tabMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormYardDefinition"
        Me.Text = "Yard Definition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tabMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMenu.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.grid_block, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_search_block.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.grid_slot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_search_slot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents tabMenu As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents tab_slot As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents tab_block As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents btn_delete_block As Button
    Friend WithEvents btn_edit_block As Button
    Friend WithEvents btn_add_block As Button
    Friend WithEvents grid_block As DataGridView
    Private WithEvents pnl_search_block As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As Label
    Private WithEvents cmb_search_block_name As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmd_search_block As Button
    Friend WithEvents Label2 As Label
    Private WithEvents cmb_search_block_type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmd_delete_slot As Button
    Friend WithEvents cmd_edit_slot As Button
    Friend WithEvents cmd_add_slot As Button
    Friend WithEvents grid_slot As DataGridView
    Private WithEvents pnl_search_slot As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents cmb_search_slot_block As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As Label
    Friend WithEvents cmd_search_slot_block As Button
End Class
