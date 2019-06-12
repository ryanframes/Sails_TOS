<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHRMchDriver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHRMchDriver))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.grid_mch = New System.Windows.Forms.DataGridView()
        Me.btn_add_type = New System.Windows.Forms.Button()
        Me.pnl_search = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        CType(Me.grid_mch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_search.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Sails_TOS.My.Resources.Resources.Save_2
        Me.btn_save.Location = New System.Drawing.Point(107, 54)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 25)
        Me.btn_save.TabIndex = 5
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = Global.Sails_TOS.My.Resources.Resources.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(179, 54)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 25)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'grid_mch
        '
        Me.grid_mch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_mch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_mch.Location = New System.Drawing.Point(2, 85)
        Me.grid_mch.Name = "grid_mch"
        Me.grid_mch.Size = New System.Drawing.Size(765, 346)
        Me.grid_mch.TabIndex = 4
        '
        'btn_add_type
        '
        Me.btn_add_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_add_type.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_type.ForeColor = System.Drawing.Color.Black
        Me.btn_add_type.Location = New System.Drawing.Point(2, 54)
        Me.btn_add_type.Name = "btn_add_type"
        Me.btn_add_type.Size = New System.Drawing.Size(99, 25)
        Me.btn_add_type.TabIndex = 3
        Me.btn_add_type.Text = "Set Machine"
        Me.btn_add_type.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_add_type.UseVisualStyleBackColor = False
        '
        'pnl_search
        '
        Me.pnl_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_search.Controls.Add(Me.txt_user)
        Me.pnl_search.Controls.Add(Me.txt_name)
        Me.pnl_search.Controls.Add(Me.Label2)
        Me.pnl_search.Controls.Add(Me.Label1)
        Me.pnl_search.Controls.Add(Me.btn_search)
        Me.pnl_search.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_search.Location = New System.Drawing.Point(2, 12)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(765, 36)
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
        Me.pnl_search.TabIndex = 47
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        Me.txt_user.ForeColor = System.Drawing.Color.Black
        Me.txt_user.Location = New System.Drawing.Point(82, 4)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(158, 22)
        Me.txt_user.TabIndex = 0
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(313, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(158, 22)
        Me.txt_name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(246, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Image = Global.Sails_TOS.My.Resources.Resources.Search
        Me.btn_search.Location = New System.Drawing.Point(477, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(97, 23)
        Me.btn_search.TabIndex = 2
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'FormHRMchDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 436)
        Me.Controls.Add(Me.pnl_search)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.grid_mch)
        Me.Controls.Add(Me.btn_add_type)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormHRMchDriver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR Machine Driver"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid_mch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents grid_mch As DataGridView
    Friend WithEvents btn_add_type As Button
    Private WithEvents pnl_search As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_name As TextBox
End Class
