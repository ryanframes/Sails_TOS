<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDamageCode
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDamageCode))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.tabMenu = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btn_delete_grade = New System.Windows.Forms.Button()
        Me.btn_edit_grade = New System.Windows.Forms.Button()
        Me.btn_add_grade = New System.Windows.Forms.Button()
        Me.grid_grade = New System.Windows.Forms.DataGridView()
        Me.tab_dmg_grade = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btn_delete_part = New System.Windows.Forms.Button()
        Me.btn_edit_part = New System.Windows.Forms.Button()
        Me.btn_add_part = New System.Windows.Forms.Button()
        Me.grid_part = New System.Windows.Forms.DataGridView()
        Me.tab_dmg_part = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btn_delete_type = New System.Windows.Forms.Button()
        Me.btn_edit_type = New System.Windows.Forms.Button()
        Me.btn_add_type = New System.Windows.Forms.Button()
        Me.grid_type = New System.Windows.Forms.DataGridView()
        Me.tab_dmg_type = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.tabMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMenu.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.grid_grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.grid_part, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.grid_type, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabMenu.Controls.Add(Me.SuperTabControlPanel3)
        Me.tabMenu.Controls.Add(Me.SuperTabControlPanel2)
        Me.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMenu.FixedTabSize = New System.Drawing.Size(150, 0)
        Me.tabMenu.ForeColor = System.Drawing.Color.Black
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.ReorderTabsEnabled = True
        Me.tabMenu.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabMenu.SelectedTabIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(879, 436)
        Me.tabMenu.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
        Me.tabMenu.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMenu.TabHorizontalSpacing = 7
        Me.tabMenu.TabIndex = 26
        Me.tabMenu.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tab_dmg_type, Me.tab_dmg_part, Me.tab_dmg_grade})
        Me.tabMenu.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.btn_delete_grade)
        Me.SuperTabControlPanel3.Controls.Add(Me.btn_edit_grade)
        Me.SuperTabControlPanel3.Controls.Add(Me.btn_add_grade)
        Me.SuperTabControlPanel3.Controls.Add(Me.grid_grade)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(727, 436)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.tab_dmg_grade
        '
        'btn_delete_grade
        '
        Me.btn_delete_grade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete_grade.FlatAppearance.BorderSize = 0
        Me.btn_delete_grade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_grade.ForeColor = System.Drawing.Color.Black
        Me.btn_delete_grade.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete_grade.Location = New System.Drawing.Point(148, 3)
        Me.btn_delete_grade.Name = "btn_delete_grade"
        Me.btn_delete_grade.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete_grade.TabIndex = 44
        Me.btn_delete_grade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete_grade.UseVisualStyleBackColor = False
        '
        'btn_edit_grade
        '
        Me.btn_edit_grade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit_grade.FlatAppearance.BorderSize = 0
        Me.btn_edit_grade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_grade.ForeColor = System.Drawing.Color.Black
        Me.btn_edit_grade.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.btn_edit_grade.Location = New System.Drawing.Point(77, 3)
        Me.btn_edit_grade.Name = "btn_edit_grade"
        Me.btn_edit_grade.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit_grade.TabIndex = 43
        Me.btn_edit_grade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit_grade.UseVisualStyleBackColor = False
        '
        'btn_add_grade
        '
        Me.btn_add_grade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_grade.FlatAppearance.BorderSize = 0
        Me.btn_add_grade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add_grade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_grade.ForeColor = System.Drawing.Color.Black
        Me.btn_add_grade.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.btn_add_grade.Location = New System.Drawing.Point(6, 3)
        Me.btn_add_grade.Name = "btn_add_grade"
        Me.btn_add_grade.Size = New System.Drawing.Size(66, 25)
        Me.btn_add_grade.TabIndex = 42
        Me.btn_add_grade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add_grade.UseVisualStyleBackColor = False
        '
        'grid_grade
        '
        Me.grid_grade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_grade.Location = New System.Drawing.Point(6, 32)
        Me.grid_grade.Name = "grid_grade"
        Me.grid_grade.Size = New System.Drawing.Size(715, 395)
        Me.grid_grade.TabIndex = 41
        '
        'tab_dmg_grade
        '
        Me.tab_dmg_grade.AttachedControl = Me.SuperTabControlPanel3
        Me.tab_dmg_grade.GlobalItem = False
        Me.tab_dmg_grade.Name = "tab_dmg_grade"
        Me.tab_dmg_grade.Text = "Damage Grade"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.btn_delete_part)
        Me.SuperTabControlPanel2.Controls.Add(Me.btn_edit_part)
        Me.SuperTabControlPanel2.Controls.Add(Me.btn_add_part)
        Me.SuperTabControlPanel2.Controls.Add(Me.grid_part)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(727, 436)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.tab_dmg_part
        '
        'btn_delete_part
        '
        Me.btn_delete_part.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete_part.FlatAppearance.BorderSize = 0
        Me.btn_delete_part.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete_part.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_part.ForeColor = System.Drawing.Color.Black
        Me.btn_delete_part.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete_part.Location = New System.Drawing.Point(148, 3)
        Me.btn_delete_part.Name = "btn_delete_part"
        Me.btn_delete_part.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete_part.TabIndex = 45
        Me.btn_delete_part.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete_part.UseVisualStyleBackColor = False
        '
        'btn_edit_part
        '
        Me.btn_edit_part.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit_part.FlatAppearance.BorderSize = 0
        Me.btn_edit_part.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit_part.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_part.ForeColor = System.Drawing.Color.Black
        Me.btn_edit_part.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.btn_edit_part.Location = New System.Drawing.Point(77, 3)
        Me.btn_edit_part.Name = "btn_edit_part"
        Me.btn_edit_part.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit_part.TabIndex = 44
        Me.btn_edit_part.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit_part.UseVisualStyleBackColor = False
        '
        'btn_add_part
        '
        Me.btn_add_part.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_part.FlatAppearance.BorderSize = 0
        Me.btn_add_part.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add_part.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_part.ForeColor = System.Drawing.Color.Black
        Me.btn_add_part.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.btn_add_part.Location = New System.Drawing.Point(6, 3)
        Me.btn_add_part.Name = "btn_add_part"
        Me.btn_add_part.Size = New System.Drawing.Size(66, 25)
        Me.btn_add_part.TabIndex = 43
        Me.btn_add_part.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add_part.UseVisualStyleBackColor = False
        '
        'grid_part
        '
        Me.grid_part.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_part.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_part.Location = New System.Drawing.Point(6, 32)
        Me.grid_part.Name = "grid_part"
        Me.grid_part.Size = New System.Drawing.Size(715, 395)
        Me.grid_part.TabIndex = 42
        '
        'tab_dmg_part
        '
        Me.tab_dmg_part.AttachedControl = Me.SuperTabControlPanel2
        Me.tab_dmg_part.GlobalItem = False
        Me.tab_dmg_part.Image = CType(resources.GetObject("tab_dmg_part.Image"), System.Drawing.Image)
        Me.tab_dmg_part.Name = "tab_dmg_part"
        Me.tab_dmg_part.Text = "Damage Part"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.btn_delete_type)
        Me.SuperTabControlPanel1.Controls.Add(Me.btn_edit_type)
        Me.SuperTabControlPanel1.Controls.Add(Me.btn_add_type)
        Me.SuperTabControlPanel1.Controls.Add(Me.grid_type)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(727, 436)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.tab_dmg_type
        '
        'btn_delete_type
        '
        Me.btn_delete_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete_type.FlatAppearance.BorderSize = 0
        Me.btn_delete_type.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_type.ForeColor = System.Drawing.Color.Black
        Me.btn_delete_type.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete_type.Location = New System.Drawing.Point(148, 3)
        Me.btn_delete_type.Name = "btn_delete_type"
        Me.btn_delete_type.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete_type.TabIndex = 40
        Me.btn_delete_type.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete_type.UseVisualStyleBackColor = False
        '
        'btn_edit_type
        '
        Me.btn_edit_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit_type.FlatAppearance.BorderSize = 0
        Me.btn_edit_type.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_type.ForeColor = System.Drawing.Color.Black
        Me.btn_edit_type.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.btn_edit_type.Location = New System.Drawing.Point(77, 3)
        Me.btn_edit_type.Name = "btn_edit_type"
        Me.btn_edit_type.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit_type.TabIndex = 39
        Me.btn_edit_type.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit_type.UseVisualStyleBackColor = False
        '
        'btn_add_type
        '
        Me.btn_add_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_type.FlatAppearance.BorderSize = 0
        Me.btn_add_type.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_type.ForeColor = System.Drawing.Color.Black
        Me.btn_add_type.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.btn_add_type.Location = New System.Drawing.Point(6, 3)
        Me.btn_add_type.Name = "btn_add_type"
        Me.btn_add_type.Size = New System.Drawing.Size(66, 25)
        Me.btn_add_type.TabIndex = 38
        Me.btn_add_type.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add_type.UseVisualStyleBackColor = False
        '
        'grid_type
        '
        Me.grid_type.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_type.Location = New System.Drawing.Point(6, 32)
        Me.grid_type.Name = "grid_type"
        Me.grid_type.Size = New System.Drawing.Size(715, 395)
        Me.grid_type.TabIndex = 37
        '
        'tab_dmg_type
        '
        Me.tab_dmg_type.AttachedControl = Me.SuperTabControlPanel1
        Me.tab_dmg_type.GlobalItem = False
        Me.tab_dmg_type.Image = CType(resources.GetObject("tab_dmg_type.Image"), System.Drawing.Image)
        Me.tab_dmg_type.Name = "tab_dmg_type"
        Me.tab_dmg_type.Text = "Damage Type"
        '
        'FormDamageCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 436)
        Me.Controls.Add(Me.tabMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormDamageCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Damage Code"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tabMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMenu.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me.grid_grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.grid_part, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.grid_type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents tabMenu As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents btn_delete_type As Button
    Friend WithEvents btn_edit_type As Button
    Friend WithEvents btn_add_type As Button
    Friend WithEvents grid_type As DataGridView
    Friend WithEvents tab_dmg_type As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents btn_delete_part As Button
    Friend WithEvents btn_edit_part As Button
    Friend WithEvents btn_add_part As Button
    Friend WithEvents grid_part As DataGridView
    Friend WithEvents tab_dmg_part As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents tab_dmg_grade As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents btn_delete_grade As Button
    Friend WithEvents btn_edit_grade As Button
    Friend WithEvents btn_add_grade As Button
    Friend WithEvents grid_grade As DataGridView
End Class
