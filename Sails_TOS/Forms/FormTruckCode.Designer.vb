<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTruckCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTruckCode))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.pnl_search = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_code_search = New System.Windows.Forms.Button()
        Me.grid_truck_code = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.pnl_search.SuspendLayout()
        CType(Me.grid_truck_code, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl_search.Controls.Add(Me.txt_code)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Controls.Add(Me.btn_code_search)
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
        Me.pnl_search.TabIndex = 11
        '
        'txt_code
        '
        Me.txt_code.BackColor = System.Drawing.Color.White
        Me.txt_code.ForeColor = System.Drawing.Color.Black
        Me.txt_code.Location = New System.Drawing.Point(91, 4)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(156, 22)
        Me.txt_code.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Truck Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_code_search
        '
        Me.btn_code_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_code_search.FlatAppearance.BorderSize = 0
        Me.btn_code_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_code_search.ForeColor = System.Drawing.Color.Black
        Me.btn_code_search.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.btn_code_search.Location = New System.Drawing.Point(253, 3)
        Me.btn_code_search.Name = "btn_code_search"
        Me.btn_code_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_code_search.TabIndex = 1
        Me.btn_code_search.UseVisualStyleBackColor = False
        '
        'grid_truck_code
        '
        Me.grid_truck_code.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_truck_code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_truck_code.Location = New System.Drawing.Point(1, 75)
        Me.grid_truck_code.Name = "grid_truck_code"
        Me.grid_truck_code.Size = New System.Drawing.Size(651, 357)
        Me.grid_truck_code.TabIndex = 3
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Sails_TOS.My.Resources.Resources.Delete
        Me.btn_delete.Location = New System.Drawing.Point(143, 46)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(78, 25)
        Me.btn_delete.TabIndex = 5
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
        Me.btn_edit.Location = New System.Drawing.Point(72, 46)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(66, 25)
        Me.btn_edit.TabIndex = 4
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
        Me.btn_add.Location = New System.Drawing.Point(1, 46)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(66, 25)
        Me.btn_add.TabIndex = 2
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'FormTruckCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.grid_truck_code)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTruckCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Truck Code"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        CType(Me.grid_truck_code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents pnl_search As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_code_search As Button
    Friend WithEvents grid_truck_code As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_code As TextBox
End Class