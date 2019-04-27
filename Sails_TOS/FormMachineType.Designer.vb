<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMachineType
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMachineType))
        Me.pnl_search = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_search_code = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btn_code_search = New System.Windows.Forms.Button()
        Me.grid_machine_type = New System.Windows.Forms.DataGridView()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_search.SuspendLayout()
        CType(Me.grid_machine_type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_search
        '
        Me.pnl_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Controls.Add(Me.cmb_search_code)
        Me.pnl_search.Controls.Add(Me.btn_code_search)
        Me.pnl_search.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search.Location = New System.Drawing.Point(0, 9)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(651, 36)
        '
        '
        '
        Me.pnl_search.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_search.Style.BackColorGradientAngle = 90
        Me.pnl_search.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_search.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search.Style.BorderBottomWidth = 1
        Me.pnl_search.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_search.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search.Style.BorderLeftWidth = 1
        Me.pnl_search.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search.Style.BorderRightWidth = 1
        Me.pnl_search.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.pnl_search.Style.BorderTopWidth = 1
        Me.pnl_search.Style.CornerDiameter = 4
        Me.pnl_search.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_search.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.pnl_search.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_search.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_search.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_search.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_search.TabIndex = 0
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
        Me.btn_code_search.Location = New System.Drawing.Point(193, 3)
        Me.btn_code_search.Name = "btn_code_search"
        Me.btn_code_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_code_search.TabIndex = 7
        Me.btn_code_search.UseVisualStyleBackColor = False
        '
        'grid_machine_type
        '
        Me.grid_machine_type.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_machine_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_machine_type.Location = New System.Drawing.Point(0, 80)
        Me.grid_machine_type.Name = "grid_machine_type"
        Me.grid_machine_type.Size = New System.Drawing.Size(651, 357)
        Me.grid_machine_type.TabIndex = 5
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete.Location = New System.Drawing.Point(142, 51)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Image = Global.Sails_TOS.My.Resources.Resources.Edit
        Me.btn_edit.Location = New System.Drawing.Point(71, 51)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.btn_add.Location = New System.Drawing.Point(0, 51)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(66, 25)
        Me.btn_add.TabIndex = 8
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'FormMachineType
        '
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.grid_machine_type)
        Me.Controls.Add(Me.pnl_search)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMachineType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Type"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_search.ResumeLayout(False)
        CType(Me.grid_machine_type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_code_search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grid_machine_type As DataGridView
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents pnl_search As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents cmb_search_code As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
