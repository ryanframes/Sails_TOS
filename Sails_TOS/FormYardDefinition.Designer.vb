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
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btn_delete_block = New System.Windows.Forms.Button()
        Me.btn_edit_block = New System.Windows.Forms.Button()
        Me.btn_add_block = New System.Windows.Forms.Button()
        Me.grid_block = New System.Windows.Forms.DataGridView()
        Me.pnl_search_block = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_search_block = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_search_code = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_code_search = New System.Windows.Forms.Button()
        Me.tab_block = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tab_slot = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.grid_block, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_search_block.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.FixedTabSize = New System.Drawing.Size(150, 0)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(802, 436)
        Me.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabHorizontalSpacing = 7
        Me.SuperTabControl1.TabIndex = 25
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tab_block, Me.tab_slot})
        Me.SuperTabControl1.Text = "SuperTabControl1"
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
        Me.pnl_search_block.Controls.Add(Me.cmb_search_block)
        Me.pnl_search_block.Controls.Add(Me.Label1)
        Me.pnl_search_block.Controls.Add(Me.cmb_search_code)
        Me.pnl_search_block.Controls.Add(Me.btn_code_search)
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
        Me.Label2.Location = New System.Drawing.Point(202, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Block Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_search_block
        '
        Me.cmb_search_block.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_search_block.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_search_block.DisplayMember = "Text"
        Me.cmb_search_block.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_search_block.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_search_block.ForeColor = System.Drawing.Color.Black
        Me.cmb_search_block.FormattingEnabled = True
        Me.cmb_search_block.ItemHeight = 17
        Me.cmb_search_block.Location = New System.Drawing.Point(283, 3)
        Me.cmb_search_block.Name = "cmb_search_block"
        Me.cmb_search_block.Size = New System.Drawing.Size(121, 23)
        Me.cmb_search_block.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_search_block.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_search_code
        '
        Me.cmb_search_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_search_code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_search_code.DisplayMember = "Text"
        Me.cmb_search_code.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_search_code.ForeColor = System.Drawing.Color.Black
        Me.cmb_search_code.FormattingEnabled = True
        Me.cmb_search_code.ItemHeight = 17
        Me.cmb_search_code.Location = New System.Drawing.Point(66, 3)
        Me.cmb_search_code.Name = "cmb_search_code"
        Me.cmb_search_code.Size = New System.Drawing.Size(121, 23)
        Me.cmb_search_code.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_search_code.TabIndex = 6
        '
        'btn_code_search
        '
        Me.btn_code_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_code_search.FlatAppearance.BorderSize = 0
        Me.btn_code_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_code_search.ForeColor = System.Drawing.Color.Black
        Me.btn_code_search.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.btn_code_search.Location = New System.Drawing.Point(410, 3)
        Me.btn_code_search.Name = "btn_code_search"
        Me.btn_code_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_code_search.TabIndex = 7
        Me.btn_code_search.UseVisualStyleBackColor = False
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
        Me.SuperTabControlPanel2.Controls.Add(Me.Button1)
        Me.SuperTabControlPanel2.Controls.Add(Me.Button2)
        Me.SuperTabControlPanel2.Controls.Add(Me.Button3)
        Me.SuperTabControlPanel2.Controls.Add(Me.DataGridView1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(650, 436)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.tab_slot
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.Button1.Location = New System.Drawing.Point(148, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 25)
        Me.Button1.TabIndex = 44
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.Button2.Location = New System.Drawing.Point(77, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 25)
        Me.Button2.TabIndex = 43
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.Button3.Location = New System.Drawing.Point(6, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 25)
        Me.Button3.TabIndex = 42
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 383)
        Me.DataGridView1.TabIndex = 41
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
        Me.Controls.Add(Me.SuperTabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormYardDefinition"
        Me.Text = "Yard Definition"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.grid_block, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_search_block.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
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
    Private WithEvents cmb_search_code As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_code_search As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Private WithEvents cmb_search_block As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
