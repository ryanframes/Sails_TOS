<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFindContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFindContainer))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.pnl_search = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.token_container = New DevComponents.DotNetBar.Controls.TokenEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_operator = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmb_class = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmb_commodity = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grid_container = New System.Windows.Forms.DataGridView()
        Me.btn_export_csv = New System.Windows.Forms.Button()
        Me.dlgExport = New System.Windows.Forms.SaveFileDialog()
        Me.pnl_search.SuspendLayout()
        CType(Me.grid_container, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'pnl_search
        '
        Me.pnl_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_search.Controls.Add(Me.token_container)
        Me.pnl_search.Controls.Add(Me.Label5)
        Me.pnl_search.Controls.Add(Me.Label3)
        Me.pnl_search.Controls.Add(Me.cmb_operator)
        Me.pnl_search.Controls.Add(Me.cmb_class)
        Me.pnl_search.Controls.Add(Me.cmb_commodity)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Controls.Add(Me.btn_search)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.Label4)
        Me.pnl_search.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search.Location = New System.Drawing.Point(0, 4)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(873, 96)
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
        Me.pnl_search.TabIndex = 24
        '
        'token_container
        '
        Me.token_container.AutoSizeHeight = False
        Me.token_container.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.token_container.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.token_container.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.token_container.ForeColor = System.Drawing.Color.Black
        Me.token_container.Location = New System.Drawing.Point(148, 5)
        Me.token_container.MaxHeightLines = 0
        Me.token_container.Name = "token_container"
        Me.token_container.Separators.Add(";")
        Me.token_container.Separators.Add(",")
        Me.token_container.Size = New System.Drawing.Size(243, 81)
        Me.token_container.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "*Can choose more than 1 data"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(397, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 23)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Operator"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_operator
        '
        Me.cmb_operator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_operator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_operator.DisplayMember = "Text"
        Me.cmb_operator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_operator.ForeColor = System.Drawing.Color.Black
        Me.cmb_operator.FormattingEnabled = True
        Me.cmb_operator.ItemHeight = 17
        Me.cmb_operator.Location = New System.Drawing.Point(472, 63)
        Me.cmb_operator.Name = "cmb_operator"
        Me.cmb_operator.Size = New System.Drawing.Size(250, 23)
        Me.cmb_operator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_operator.TabIndex = 64
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
        Me.cmb_class.Location = New System.Drawing.Point(472, 5)
        Me.cmb_class.Name = "cmb_class"
        Me.cmb_class.Size = New System.Drawing.Size(250, 23)
        Me.cmb_class.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_class.TabIndex = 59
        '
        'cmb_commodity
        '
        Me.cmb_commodity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_commodity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_commodity.DisplayMember = "Text"
        Me.cmb_commodity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_commodity.ForeColor = System.Drawing.Color.Black
        Me.cmb_commodity.FormattingEnabled = True
        Me.cmb_commodity.ItemHeight = 17
        Me.cmb_commodity.Location = New System.Drawing.Point(472, 34)
        Me.cmb_commodity.Name = "cmb_commodity"
        Me.cmb_commodity.Size = New System.Drawing.Size(250, 23)
        Me.cmb_commodity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_commodity.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(397, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Class"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.btn_search.Location = New System.Drawing.Point(728, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_search.TabIndex = 61
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(397, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Commodity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Container Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grid_container
        '
        Me.grid_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_container.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_container.Location = New System.Drawing.Point(0, 140)
        Me.grid_container.Name = "grid_container"
        Me.grid_container.Size = New System.Drawing.Size(873, 294)
        Me.grid_container.TabIndex = 23
        '
        'btn_export_csv
        '
        Me.btn_export_csv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_export_csv.FlatAppearance.BorderSize = 0
        Me.btn_export_csv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_export_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export_csv.ForeColor = System.Drawing.Color.Black
        Me.btn_export_csv.Image = Global.Sails_TOS.My.Resources.Resources.Export2
        Me.btn_export_csv.Location = New System.Drawing.Point(0, 106)
        Me.btn_export_csv.Name = "btn_export_csv"
        Me.btn_export_csv.Size = New System.Drawing.Size(121, 25)
        Me.btn_export_csv.TabIndex = 25
        Me.btn_export_csv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_export_csv.UseVisualStyleBackColor = False
        '
        'dlgExport
        '
        Me.dlgExport.Filter = "Microsoft Excel 2007 Workbook|*.xlsx"
        '
        'FormFindContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 436)
        Me.Controls.Add(Me.btn_export_csv)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.grid_container)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFindContainer"
        Me.Text = "Find Container"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_search.ResumeLayout(False)
        CType(Me.grid_container, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents pnl_search As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents grid_container As DataGridView
    Friend WithEvents btn_export_csv As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents cmb_operator As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents cmb_class As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents cmb_commodity As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents token_container As DevComponents.DotNetBar.Controls.TokenEditor
    Friend WithEvents dlgExport As SaveFileDialog
End Class
