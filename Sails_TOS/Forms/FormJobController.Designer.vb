<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJobController
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJobController))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.pnl_search = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cmb_pool = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.grid_job = New System.Windows.Forms.DataGridView()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_search.SuspendLayout()
        CType(Me.grid_job, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_search.Controls.Add(Me.cmb_pool)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.cmb_status)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Controls.Add(Me.btn_search)
        Me.pnl_search.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search.Location = New System.Drawing.Point(1, 4)
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
        Me.pnl_search.TabIndex = 21
        '
        'cmb_pool
        '
        Me.cmb_pool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_pool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_pool.DisplayMember = "Text"
        Me.cmb_pool.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_pool.ForeColor = System.Drawing.Color.Black
        Me.cmb_pool.FormattingEnabled = True
        Me.cmb_pool.ItemHeight = 17
        Me.cmb_pool.Location = New System.Drawing.Point(68, 4)
        Me.cmb_pool.Name = "cmb_pool"
        Me.cmb_pool.Size = New System.Drawing.Size(121, 23)
        Me.cmb_pool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_pool.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(195, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_status
        '
        Me.cmb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_status.DisplayMember = "Text"
        Me.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_status.ForeColor = System.Drawing.Color.Black
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.ItemHeight = 17
        Me.cmb_status.Location = New System.Drawing.Point(262, 4)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(121, 23)
        Me.cmb_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_status.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pool"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.btn_search.Location = New System.Drawing.Point(389, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_search.TabIndex = 2
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'grid_job
        '
        Me.grid_job.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_job.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_job.Location = New System.Drawing.Point(1, 75)
        Me.grid_job.Name = "grid_job"
        Me.grid_job.Size = New System.Drawing.Size(651, 357)
        Me.grid_job.TabIndex = 4
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Image = Global.Sails_TOS.My.Resources.Resources.Add
        Me.btn_add.Location = New System.Drawing.Point(1, 46)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(66, 25)
        Me.btn_add.TabIndex = 3
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'FormJobController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.grid_job)
        Me.Controls.Add(Me.btn_add)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormJobController"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Controller"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_search.ResumeLayout(False)
        CType(Me.grid_job, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents pnl_search As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label2 As Label
    Private WithEvents cmb_status As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents grid_job As DataGridView
    Friend WithEvents btn_add As Button
    Private WithEvents cmb_pool As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
