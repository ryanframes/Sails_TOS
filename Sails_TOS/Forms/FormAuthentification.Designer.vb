<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuthentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAuthentification))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_mch_type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_mch_name = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmb_team = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_shift = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl_vmt = New DevComponents.DotNetBar.PanelEx()
        Me.pnl_vmt.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 63)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "VMT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        Me.txt_user.ForeColor = System.Drawing.Color.Black
        Me.txt_user.Location = New System.Drawing.Point(106, 3)
        Me.txt_user.MaxLength = 0
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(188, 22)
        Me.txt_user.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_user, "Press enter to verify")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_pwd
        '
        Me.txt_pwd.BackColor = System.Drawing.Color.White
        Me.txt_pwd.ForeColor = System.Drawing.Color.Black
        Me.txt_pwd.Location = New System.Drawing.Point(106, 31)
        Me.txt_pwd.MaxLength = 0
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(188, 22)
        Me.txt_pwd.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txt_pwd, "Press enter to verify")
        Me.txt_pwd.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.White
        Me.txt_name.Enabled = False
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(106, 59)
        Me.txt_name.MaxLength = 0
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(188, 22)
        Me.txt_name.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_mch_type
        '
        Me.cmb_mch_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_mch_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_mch_type.DisplayMember = "Text"
        Me.cmb_mch_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_mch_type.ForeColor = System.Drawing.Color.Black
        Me.cmb_mch_type.FormattingEnabled = True
        Me.cmb_mch_type.ItemHeight = 17
        Me.cmb_mch_type.Location = New System.Drawing.Point(106, 87)
        Me.cmb_mch_type.Name = "cmb_mch_type"
        Me.cmb_mch_type.Size = New System.Drawing.Size(187, 23)
        Me.cmb_mch_type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_mch_type.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 23)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Machine Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_mch_name
        '
        Me.cmb_mch_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_mch_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_mch_name.DisplayMember = "Text"
        Me.cmb_mch_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_mch_name.ForeColor = System.Drawing.Color.Black
        Me.cmb_mch_name.FormattingEnabled = True
        Me.cmb_mch_name.ItemHeight = 17
        Me.cmb_mch_name.Location = New System.Drawing.Point(106, 116)
        Me.cmb_mch_name.Name = "cmb_mch_name"
        Me.cmb_mch_name.Size = New System.Drawing.Size(187, 23)
        Me.cmb_mch_name.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_mch_name.TabIndex = 4
        '
        'cmb_team
        '
        Me.cmb_team.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_team.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_team.DisplayMember = "Text"
        Me.cmb_team.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_team.ForeColor = System.Drawing.Color.Black
        Me.cmb_team.FormattingEnabled = True
        Me.cmb_team.ItemHeight = 17
        Me.cmb_team.Location = New System.Drawing.Point(106, 145)
        Me.cmb_team.Name = "cmb_team"
        Me.cmb_team.Size = New System.Drawing.Size(187, 23)
        Me.cmb_team.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_team.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 23)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Team"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_shift
        '
        Me.cmb_shift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_shift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_shift.DisplayMember = "Text"
        Me.cmb_shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_shift.ForeColor = System.Drawing.Color.Black
        Me.cmb_shift.FormattingEnabled = True
        Me.cmb_shift.ItemHeight = 17
        Me.cmb_shift.Location = New System.Drawing.Point(106, 174)
        Me.cmb_shift.Name = "cmb_shift"
        Me.cmb_shift.Size = New System.Drawing.Size(187, 23)
        Me.cmb_shift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_shift.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 24)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Shift"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 23)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Machine Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(242, 286)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(66, 25)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Log In"
        Me.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'pnl_vmt
        '
        Me.pnl_vmt.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnl_vmt.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnl_vmt.Controls.Add(Me.txt_user)
        Me.pnl_vmt.Controls.Add(Me.Label2)
        Me.pnl_vmt.Controls.Add(Me.Label6)
        Me.pnl_vmt.Controls.Add(Me.Label1)
        Me.pnl_vmt.Controls.Add(Me.cmb_shift)
        Me.pnl_vmt.Controls.Add(Me.txt_pwd)
        Me.pnl_vmt.Controls.Add(Me.Label8)
        Me.pnl_vmt.Controls.Add(Me.Label3)
        Me.pnl_vmt.Controls.Add(Me.cmb_team)
        Me.pnl_vmt.Controls.Add(Me.txt_name)
        Me.pnl_vmt.Controls.Add(Me.Label7)
        Me.pnl_vmt.Controls.Add(Me.Label5)
        Me.pnl_vmt.Controls.Add(Me.cmb_mch_name)
        Me.pnl_vmt.Controls.Add(Me.cmb_mch_type)
        Me.pnl_vmt.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_vmt.Location = New System.Drawing.Point(10, 75)
        Me.pnl_vmt.Name = "pnl_vmt"
        Me.pnl_vmt.Size = New System.Drawing.Size(298, 205)
        Me.pnl_vmt.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnl_vmt.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_vmt.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_vmt.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_vmt.Style.GradientAngle = 90
        Me.pnl_vmt.TabIndex = 80
        '
        'FormAuthentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 314)
        Me.Controls.Add(Me.pnl_vmt)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAuthentification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAILS TOS"
        Me.pnl_vmt.ResumeLayout(False)
        Me.pnl_vmt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents cmb_mch_type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label5 As Label
    Private WithEvents cmb_mch_name As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents cmb_team As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label7 As Label
    Private WithEvents cmb_shift As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnl_vmt As DevComponents.DotNetBar.PanelEx
End Class
