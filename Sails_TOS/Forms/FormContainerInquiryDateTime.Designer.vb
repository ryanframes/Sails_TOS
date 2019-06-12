<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContainerInquiryDateTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormContainerInquiryDateTime))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.pnl_in = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_stacking = New System.Windows.Forms.TextBox()
        Me.txt_truck_out = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_terminal_in = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.pnl_out = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_on_chassis = New System.Windows.Forms.TextBox()
        Me.txt_terminal_out = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_truck_in = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnl_discharge = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_discharging = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnl_loading = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txt_loading = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnl_in.SuspendLayout()
        Me.pnl_out.SuspendLayout()
        Me.pnl_discharge.SuspendLayout()
        Me.pnl_loading.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'pnl_in
        '
        Me.pnl_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_in.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_in.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_in.Controls.Add(Me.txt_stacking)
        Me.pnl_in.Controls.Add(Me.txt_truck_out)
        Me.pnl_in.Controls.Add(Me.Label28)
        Me.pnl_in.Controls.Add(Me.Label29)
        Me.pnl_in.Controls.Add(Me.txt_terminal_in)
        Me.pnl_in.Controls.Add(Me.Label30)
        Me.pnl_in.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_in.DrawTitleBox = False
        Me.pnl_in.Location = New System.Drawing.Point(0, 4)
        Me.pnl_in.Name = "pnl_in"
        Me.pnl_in.Size = New System.Drawing.Size(259, 108)
        '
        '
        '
        Me.pnl_in.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_in.Style.BackColorGradientAngle = 90
        Me.pnl_in.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_in.Style.BorderBottomWidth = 1
        Me.pnl_in.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_in.Style.BorderLeftWidth = 1
        Me.pnl_in.Style.BorderRightWidth = 1
        Me.pnl_in.Style.BorderTopWidth = 1
        Me.pnl_in.Style.CornerDiameter = 4
        Me.pnl_in.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_in.Style.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_in.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_in.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_in.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_in.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_in.TabIndex = 29
        Me.pnl_in.Text = "In Date / Time"
        Me.pnl_in.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'txt_stacking
        '
        Me.txt_stacking.BackColor = System.Drawing.Color.White
        Me.txt_stacking.Enabled = False
        Me.txt_stacking.ForeColor = System.Drawing.Color.Black
        Me.txt_stacking.Location = New System.Drawing.Point(103, 31)
        Me.txt_stacking.MaxLength = 0
        Me.txt_stacking.Name = "txt_stacking"
        Me.txt_stacking.Size = New System.Drawing.Size(144, 22)
        Me.txt_stacking.TabIndex = 75
        '
        'txt_truck_out
        '
        Me.txt_truck_out.BackColor = System.Drawing.Color.White
        Me.txt_truck_out.Enabled = False
        Me.txt_truck_out.ForeColor = System.Drawing.Color.Black
        Me.txt_truck_out.Location = New System.Drawing.Point(103, 59)
        Me.txt_truck_out.MaxLength = 0
        Me.txt_truck_out.Name = "txt_truck_out"
        Me.txt_truck_out.Size = New System.Drawing.Size(144, 22)
        Me.txt_truck_out.TabIndex = 65
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(3, 60)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 22)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = "Truck Out"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(3, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 22)
        Me.Label29.TabIndex = 62
        Me.Label29.Text = "Stacking"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_terminal_in
        '
        Me.txt_terminal_in.BackColor = System.Drawing.Color.White
        Me.txt_terminal_in.Enabled = False
        Me.txt_terminal_in.ForeColor = System.Drawing.Color.Black
        Me.txt_terminal_in.Location = New System.Drawing.Point(103, 3)
        Me.txt_terminal_in.MaxLength = 0
        Me.txt_terminal_in.Name = "txt_terminal_in"
        Me.txt_terminal_in.Size = New System.Drawing.Size(144, 22)
        Me.txt_terminal_in.TabIndex = 59
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(3, 4)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 22)
        Me.Label30.TabIndex = 60
        Me.Label30.Text = "Terminal In"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_out
        '
        Me.pnl_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_out.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_out.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_out.Controls.Add(Me.txt_on_chassis)
        Me.pnl_out.Controls.Add(Me.txt_terminal_out)
        Me.pnl_out.Controls.Add(Me.Label1)
        Me.pnl_out.Controls.Add(Me.Label2)
        Me.pnl_out.Controls.Add(Me.txt_truck_in)
        Me.pnl_out.Controls.Add(Me.Label3)
        Me.pnl_out.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_out.DrawTitleBox = False
        Me.pnl_out.Location = New System.Drawing.Point(265, 4)
        Me.pnl_out.Name = "pnl_out"
        Me.pnl_out.Size = New System.Drawing.Size(259, 108)
        '
        '
        '
        Me.pnl_out.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_out.Style.BackColorGradientAngle = 90
        Me.pnl_out.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_out.Style.BorderBottomWidth = 1
        Me.pnl_out.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_out.Style.BorderLeftWidth = 1
        Me.pnl_out.Style.BorderRightWidth = 1
        Me.pnl_out.Style.BorderTopWidth = 1
        Me.pnl_out.Style.CornerDiameter = 4
        Me.pnl_out.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_out.Style.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_out.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_out.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_out.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_out.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_out.TabIndex = 30
        Me.pnl_out.Text = "Out Date / Time"
        Me.pnl_out.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'txt_on_chassis
        '
        Me.txt_on_chassis.BackColor = System.Drawing.Color.White
        Me.txt_on_chassis.Enabled = False
        Me.txt_on_chassis.ForeColor = System.Drawing.Color.Black
        Me.txt_on_chassis.Location = New System.Drawing.Point(103, 31)
        Me.txt_on_chassis.MaxLength = 0
        Me.txt_on_chassis.Name = "txt_on_chassis"
        Me.txt_on_chassis.Size = New System.Drawing.Size(144, 22)
        Me.txt_on_chassis.TabIndex = 75
        '
        'txt_terminal_out
        '
        Me.txt_terminal_out.BackColor = System.Drawing.Color.White
        Me.txt_terminal_out.Enabled = False
        Me.txt_terminal_out.ForeColor = System.Drawing.Color.Black
        Me.txt_terminal_out.Location = New System.Drawing.Point(103, 59)
        Me.txt_terminal_out.MaxLength = 0
        Me.txt_terminal_out.Name = "txt_terminal_out"
        Me.txt_terminal_out.Size = New System.Drawing.Size(144, 22)
        Me.txt_terminal_out.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Terminal Out"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 22)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "On Chassis"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_truck_in
        '
        Me.txt_truck_in.BackColor = System.Drawing.Color.White
        Me.txt_truck_in.Enabled = False
        Me.txt_truck_in.ForeColor = System.Drawing.Color.Black
        Me.txt_truck_in.Location = New System.Drawing.Point(103, 3)
        Me.txt_truck_in.MaxLength = 0
        Me.txt_truck_in.Name = "txt_truck_in"
        Me.txt_truck_in.Size = New System.Drawing.Size(144, 22)
        Me.txt_truck_in.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Truck In"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_discharge
        '
        Me.pnl_discharge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_discharge.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_discharge.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_discharge.Controls.Add(Me.txt_discharging)
        Me.pnl_discharge.Controls.Add(Me.Label6)
        Me.pnl_discharge.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_discharge.DrawTitleBox = False
        Me.pnl_discharge.Location = New System.Drawing.Point(265, 118)
        Me.pnl_discharge.Name = "pnl_discharge"
        Me.pnl_discharge.Size = New System.Drawing.Size(259, 51)
        '
        '
        '
        Me.pnl_discharge.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_discharge.Style.BackColorGradientAngle = 90
        Me.pnl_discharge.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_discharge.Style.BorderBottomWidth = 1
        Me.pnl_discharge.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_discharge.Style.BorderLeftWidth = 1
        Me.pnl_discharge.Style.BorderRightWidth = 1
        Me.pnl_discharge.Style.BorderTopWidth = 1
        Me.pnl_discharge.Style.CornerDiameter = 4
        Me.pnl_discharge.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_discharge.Style.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_discharge.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_discharge.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_discharge.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_discharge.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_discharge.TabIndex = 31
        Me.pnl_discharge.Text = "Discharge Date / Time"
        Me.pnl_discharge.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'txt_discharging
        '
        Me.txt_discharging.BackColor = System.Drawing.Color.White
        Me.txt_discharging.Enabled = False
        Me.txt_discharging.ForeColor = System.Drawing.Color.Black
        Me.txt_discharging.Location = New System.Drawing.Point(103, 3)
        Me.txt_discharging.MaxLength = 0
        Me.txt_discharging.Name = "txt_discharging"
        Me.txt_discharging.Size = New System.Drawing.Size(144, 22)
        Me.txt_discharging.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 22)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Discharging"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_loading
        '
        Me.pnl_loading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_loading.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnl_loading.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.pnl_loading.Controls.Add(Me.txt_loading)
        Me.pnl_loading.Controls.Add(Me.Label9)
        Me.pnl_loading.DisabledBackColor = System.Drawing.Color.Empty
        Me.pnl_loading.DrawTitleBox = False
        Me.pnl_loading.Location = New System.Drawing.Point(0, 118)
        Me.pnl_loading.Name = "pnl_loading"
        Me.pnl_loading.Size = New System.Drawing.Size(259, 51)
        '
        '
        '
        Me.pnl_loading.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnl_loading.Style.BackColorGradientAngle = 90
        Me.pnl_loading.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnl_loading.Style.BorderBottomWidth = 1
        Me.pnl_loading.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnl_loading.Style.BorderLeftWidth = 1
        Me.pnl_loading.Style.BorderRightWidth = 1
        Me.pnl_loading.Style.BorderTopWidth = 1
        Me.pnl_loading.Style.CornerDiameter = 4
        Me.pnl_loading.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.pnl_loading.Style.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_loading.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnl_loading.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.pnl_loading.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.pnl_loading.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pnl_loading.TabIndex = 32
        Me.pnl_loading.Text = "Loading Date / Time"
        Me.pnl_loading.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center
        '
        'txt_loading
        '
        Me.txt_loading.BackColor = System.Drawing.Color.White
        Me.txt_loading.Enabled = False
        Me.txt_loading.ForeColor = System.Drawing.Color.Black
        Me.txt_loading.Location = New System.Drawing.Point(103, 3)
        Me.txt_loading.MaxLength = 0
        Me.txt_loading.Name = "txt_loading"
        Me.txt_loading.Size = New System.Drawing.Size(144, 22)
        Me.txt_loading.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 22)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Loading"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormContainerInquiryDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 172)
        Me.Controls.Add(Me.pnl_loading)
        Me.Controls.Add(Me.pnl_discharge)
        Me.Controls.Add(Me.pnl_out)
        Me.Controls.Add(Me.pnl_in)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormContainerInquiryDateTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date Time"
        Me.pnl_in.ResumeLayout(False)
        Me.pnl_in.PerformLayout()
        Me.pnl_out.ResumeLayout(False)
        Me.pnl_out.PerformLayout()
        Me.pnl_discharge.ResumeLayout(False)
        Me.pnl_discharge.PerformLayout()
        Me.pnl_loading.ResumeLayout(False)
        Me.pnl_loading.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents pnl_in As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txt_stacking As TextBox
    Friend WithEvents txt_truck_out As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_terminal_in As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents pnl_out As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txt_on_chassis As TextBox
    Friend WithEvents txt_terminal_out As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_truck_in As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pnl_discharge As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txt_discharging As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pnl_loading As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txt_loading As TextBox
    Friend WithEvents Label9 As Label
End Class
