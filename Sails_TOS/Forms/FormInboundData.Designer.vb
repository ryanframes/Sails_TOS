<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInboundData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInboundData))
        Me.pnl_search = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_vessel_schedule = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txt_vessel_year = New System.Windows.Forms.TextBox()
        Me.txt_vessel_voyage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_vessel_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_code_search = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_class = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_size = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.grid_inbound = New System.Windows.Forms.DataGridView()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog()
        Me.btn_export_csv = New System.Windows.Forms.Button()
        Me.btn_export_baplie = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_search.SuspendLayout()
        CType(Me.grid_inbound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_search
        '
        Me.pnl_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_search.Controls.Add(Me.Label6)
        Me.pnl_search.Controls.Add(Me.cmb_vessel_schedule)
        Me.pnl_search.Controls.Add(Me.txt_vessel_year)
        Me.pnl_search.Controls.Add(Me.txt_vessel_voyage)
        Me.pnl_search.Controls.Add(Me.Label3)
        Me.pnl_search.Controls.Add(Me.txt_vessel_name)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.btn_code_search)
        Me.pnl_search.Controls.Add(Me.Label5)
        Me.pnl_search.Controls.Add(Me.cmb_type)
        Me.pnl_search.Controls.Add(Me.Label4)
        Me.pnl_search.Controls.Add(Me.cmb_class)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Controls.Add(Me.cmb_size)
        Me.pnl_search.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search.Location = New System.Drawing.Point(1, 4)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(844, 96)
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
        Me.pnl_search.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Vessel Schedule"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_vessel_schedule
        '
        Me.cmb_vessel_schedule.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_vessel_schedule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_vessel_schedule.DisplayMember = "Text"
        Me.cmb_vessel_schedule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_vessel_schedule.ForeColor = System.Drawing.Color.Black
        Me.cmb_vessel_schedule.FormattingEnabled = True
        Me.cmb_vessel_schedule.ItemHeight = 17
        Me.cmb_vessel_schedule.Location = New System.Drawing.Point(103, 7)
        Me.cmb_vessel_schedule.Name = "cmb_vessel_schedule"
        Me.cmb_vessel_schedule.Size = New System.Drawing.Size(223, 23)
        Me.cmb_vessel_schedule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_vessel_schedule.TabIndex = 37
        '
        'txt_vessel_year
        '
        Me.txt_vessel_year.BackColor = System.Drawing.Color.White
        Me.txt_vessel_year.Enabled = False
        Me.txt_vessel_year.ForeColor = System.Drawing.Color.Black
        Me.txt_vessel_year.Location = New System.Drawing.Point(265, 36)
        Me.txt_vessel_year.Name = "txt_vessel_year"
        Me.txt_vessel_year.Size = New System.Drawing.Size(61, 22)
        Me.txt_vessel_year.TabIndex = 36
        '
        'txt_vessel_voyage
        '
        Me.txt_vessel_voyage.BackColor = System.Drawing.Color.White
        Me.txt_vessel_voyage.Enabled = False
        Me.txt_vessel_voyage.ForeColor = System.Drawing.Color.Black
        Me.txt_vessel_voyage.Location = New System.Drawing.Point(103, 65)
        Me.txt_vessel_voyage.Name = "txt_vessel_voyage"
        Me.txt_vessel_voyage.Size = New System.Drawing.Size(156, 22)
        Me.txt_vessel_voyage.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Voyage"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_vessel_name
        '
        Me.txt_vessel_name.BackColor = System.Drawing.Color.White
        Me.txt_vessel_name.Enabled = False
        Me.txt_vessel_name.ForeColor = System.Drawing.Color.Black
        Me.txt_vessel_name.Location = New System.Drawing.Point(103, 36)
        Me.txt_vessel_name.Name = "txt_vessel_name"
        Me.txt_vessel_name.Size = New System.Drawing.Size(156, 22)
        Me.txt_vessel_name.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Vessel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_code_search
        '
        Me.btn_code_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_code_search.FlatAppearance.BorderSize = 0
        Me.btn_code_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_code_search.ForeColor = System.Drawing.Color.Black
        Me.btn_code_search.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.btn_code_search.Location = New System.Drawing.Point(451, 65)
        Me.btn_code_search.Name = "btn_code_search"
        Me.btn_code_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_code_search.TabIndex = 28
        Me.btn_code_search.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(585, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Container Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_type
        '
        Me.cmb_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_type.DisplayMember = "Text"
        Me.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_type.ForeColor = System.Drawing.Color.Black
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.ItemHeight = 17
        Me.cmb_type.Location = New System.Drawing.Point(687, 7)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(121, 23)
        Me.cmb_type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_type.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(349, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Container Class"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_class
        '
        Me.cmb_class.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_class.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_class.DisplayMember = "Text"
        Me.cmb_class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_class.ForeColor = System.Drawing.Color.Black
        Me.cmb_class.FormattingEnabled = True
        Me.cmb_class.ItemHeight = 17
        Me.cmb_class.Location = New System.Drawing.Point(451, 36)
        Me.cmb_class.Name = "cmb_class"
        Me.cmb_class.Size = New System.Drawing.Size(121, 23)
        Me.cmb_class.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_class.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(349, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Container Size"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_size
        '
        Me.cmb_size.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_size.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_size.DisplayMember = "Text"
        Me.cmb_size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_size.ForeColor = System.Drawing.Color.Black
        Me.cmb_size.FormattingEnabled = True
        Me.cmb_size.ItemHeight = 17
        Me.cmb_size.Location = New System.Drawing.Point(451, 7)
        Me.cmb_size.Name = "cmb_size"
        Me.cmb_size.Size = New System.Drawing.Size(121, 23)
        Me.cmb_size.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_size.TabIndex = 6
        '
        'grid_inbound
        '
        Me.grid_inbound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_inbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_inbound.Location = New System.Drawing.Point(1, 137)
        Me.grid_inbound.Name = "grid_inbound"
        Me.grid_inbound.Size = New System.Drawing.Size(844, 295)
        Me.grid_inbound.TabIndex = 12
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'dlgExport
        '
        Me.dlgExport.Filter = "Microsoft Excel 2007 Workbook|*.xlsx"
        '
        'btn_export_csv
        '
        Me.btn_export_csv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_export_csv.FlatAppearance.BorderSize = 0
        Me.btn_export_csv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_export_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export_csv.ForeColor = System.Drawing.Color.Black
        Me.btn_export_csv.Image = Global.Sails_TOS.My.Resources.Resources.Export2
        Me.btn_export_csv.Location = New System.Drawing.Point(271, 106)
        Me.btn_export_csv.Name = "btn_export_csv"
        Me.btn_export_csv.Size = New System.Drawing.Size(121, 25)
        Me.btn_export_csv.TabIndex = 17
        Me.btn_export_csv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_export_csv.UseVisualStyleBackColor = False
        '
        'btn_export_baplie
        '
        Me.btn_export_baplie.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_export_baplie.FlatAppearance.BorderSize = 0
        Me.btn_export_baplie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_export_baplie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export_baplie.ForeColor = System.Drawing.Color.Black
        Me.btn_export_baplie.Image = Global.Sails_TOS.My.Resources.Resources.Export1
        Me.btn_export_baplie.Location = New System.Drawing.Point(144, 106)
        Me.btn_export_baplie.Name = "btn_export_baplie"
        Me.btn_export_baplie.Size = New System.Drawing.Size(121, 25)
        Me.btn_export_baplie.TabIndex = 16
        Me.btn_export_baplie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_export_baplie.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete.Location = New System.Drawing.Point(398, 106)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete.TabIndex = 15
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
        Me.btn_edit.Location = New System.Drawing.Point(72, 106)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit.TabIndex = 14
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
        Me.btn_add.Location = New System.Drawing.Point(1, 106)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(66, 25)
        Me.btn_add.TabIndex = 13
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'FormInboundData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 436)
        Me.Controls.Add(Me.btn_export_csv)
        Me.Controls.Add(Me.btn_export_baplie)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.grid_inbound)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInboundData"
        Me.Text = "Inbound Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        CType(Me.grid_inbound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pnl_search As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As Label
    Private WithEvents cmb_size As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents grid_inbound As DataGridView
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label5 As Label
    Private WithEvents cmb_type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As Label
    Private WithEvents cmb_class As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btn_code_search As Button
    Friend WithEvents Label6 As Label
    Private WithEvents cmb_vessel_schedule As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txt_vessel_year As TextBox
    Friend WithEvents txt_vessel_voyage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_vessel_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_export_baplie As Button
    Friend WithEvents btn_export_csv As Button
    Friend WithEvents dlgExport As SaveFileDialog
End Class
