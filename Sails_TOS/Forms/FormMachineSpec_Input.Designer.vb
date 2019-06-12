<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMachineSpec_Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMachineSpec_Input))
        Me.txt_tocov = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_fromcov = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_tocvrg = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_fromcvrg = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sw_stat = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_forecolor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_backcolor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_capacity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cp_forecolor = New DevComponents.DotNetBar.ColorPickerButton()
        Me.cp_backcolor = New DevComponents.DotNetBar.ColorPickerButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_tocov
        '
        Me.txt_tocov.BackColor = System.Drawing.Color.White
        Me.txt_tocov.ForeColor = System.Drawing.Color.Black
        Me.txt_tocov.Location = New System.Drawing.Point(388, 96)
        Me.txt_tocov.MaxLength = 10
        Me.txt_tocov.Name = "txt_tocov"
        Me.txt_tocov.Size = New System.Drawing.Size(66, 22)
        Me.txt_tocov.TabIndex = 10
        Me.txt_tocov.Text = "0"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(298, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 22)
        Me.Label13.TabIndex = 143
        Me.Label13.Text = "From COV2"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_fromcov
        '
        Me.txt_fromcov.BackColor = System.Drawing.Color.White
        Me.txt_fromcov.ForeColor = System.Drawing.Color.Black
        Me.txt_fromcov.Location = New System.Drawing.Point(388, 68)
        Me.txt_fromcov.MaxLength = 10
        Me.txt_fromcov.Name = "txt_fromcov"
        Me.txt_fromcov.Size = New System.Drawing.Size(66, 22)
        Me.txt_fromcov.TabIndex = 9
        Me.txt_fromcov.Text = "0"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(298, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 22)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "To Coverage"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_tocvrg
        '
        Me.txt_tocvrg.BackColor = System.Drawing.Color.White
        Me.txt_tocvrg.ForeColor = System.Drawing.Color.Black
        Me.txt_tocvrg.Location = New System.Drawing.Point(388, 40)
        Me.txt_tocvrg.MaxLength = 10
        Me.txt_tocvrg.Name = "txt_tocvrg"
        Me.txt_tocvrg.Size = New System.Drawing.Size(66, 22)
        Me.txt_tocvrg.TabIndex = 8
        Me.txt_tocvrg.Text = "0"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(298, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 22)
        Me.Label14.TabIndex = 145
        Me.Label14.Text = "To COV2"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(298, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 22)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "From Coverage"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_fromcvrg
        '
        Me.txt_fromcvrg.BackColor = System.Drawing.Color.White
        Me.txt_fromcvrg.ForeColor = System.Drawing.Color.Black
        Me.txt_fromcvrg.Location = New System.Drawing.Point(388, 12)
        Me.txt_fromcvrg.MaxLength = 10
        Me.txt_fromcvrg.Name = "txt_fromcvrg"
        Me.txt_fromcvrg.Size = New System.Drawing.Size(66, 22)
        Me.txt_fromcvrg.TabIndex = 7
        Me.txt_fromcvrg.Text = "0"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 22)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Status"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sw_stat
        '
        Me.sw_stat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.sw_stat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sw_stat.ForeColor = System.Drawing.Color.Black
        Me.sw_stat.Location = New System.Drawing.Point(95, 181)
        Me.sw_stat.Name = "sw_stat"
        Me.sw_stat.Size = New System.Drawing.Size(66, 22)
        Me.sw_stat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sw_stat.TabIndex = 6
        Me.sw_stat.ValueFalse = "0"
        Me.sw_stat.ValueObject = "0"
        Me.sw_stat.ValueTrue = "1"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 22)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Fore Color"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_forecolor
        '
        Me.txt_forecolor.BackColor = System.Drawing.Color.White
        Me.txt_forecolor.Enabled = False
        Me.txt_forecolor.ForeColor = System.Drawing.Color.Black
        Me.txt_forecolor.Location = New System.Drawing.Point(139, 153)
        Me.txt_forecolor.MaxLength = 10
        Me.txt_forecolor.Name = "txt_forecolor"
        Me.txt_forecolor.Size = New System.Drawing.Size(144, 22)
        Me.txt_forecolor.TabIndex = 133
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 22)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Back Color"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_backcolor
        '
        Me.txt_backcolor.BackColor = System.Drawing.Color.White
        Me.txt_backcolor.Enabled = False
        Me.txt_backcolor.ForeColor = System.Drawing.Color.Black
        Me.txt_backcolor.Location = New System.Drawing.Point(139, 125)
        Me.txt_backcolor.MaxLength = 10
        Me.txt_backcolor.Name = "txt_backcolor"
        Me.txt_backcolor.Size = New System.Drawing.Size(144, 22)
        Me.txt_backcolor.TabIndex = 131
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Capacity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_capacity
        '
        Me.txt_capacity.BackColor = System.Drawing.Color.White
        Me.txt_capacity.ForeColor = System.Drawing.Color.Black
        Me.txt_capacity.Location = New System.Drawing.Point(95, 97)
        Me.txt_capacity.MaxLength = 10
        Me.txt_capacity.Name = "txt_capacity"
        Me.txt_capacity.Size = New System.Drawing.Size(66, 22)
        Me.txt_capacity.TabIndex = 3
        Me.txt_capacity.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Height"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_height
        '
        Me.txt_height.BackColor = System.Drawing.Color.White
        Me.txt_height.ForeColor = System.Drawing.Color.Black
        Me.txt_height.Location = New System.Drawing.Point(95, 69)
        Me.txt_height.MaxLength = 10
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(66, 22)
        Me.txt_height.TabIndex = 2
        Me.txt_height.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.cmb_type.Location = New System.Drawing.Point(95, 40)
        Me.cmb_type.MaxLength = 10
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(188, 23)
        Me.cmb_type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_type.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Code *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_code
        '
        Me.txt_code.BackColor = System.Drawing.Color.White
        Me.txt_code.ForeColor = System.Drawing.Color.Black
        Me.txt_code.Location = New System.Drawing.Point(95, 12)
        Me.txt_code.MaxLength = 10
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(188, 22)
        Me.txt_code.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 52)
        Me.Panel1.TabIndex = 117
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Sails_TOS.My.Resources.Resources.Save_2
        Me.btn_save.Location = New System.Drawing.Point(297, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 25)
        Me.btn_save.TabIndex = 11
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Image = Global.Sails_TOS.My.Resources.Resources.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(369, 12)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 25)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'cp_forecolor
        '
        Me.cp_forecolor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cp_forecolor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cp_forecolor.Image = CType(resources.GetObject("cp_forecolor.Image"), System.Drawing.Image)
        Me.cp_forecolor.Location = New System.Drawing.Point(95, 153)
        Me.cp_forecolor.Name = "cp_forecolor"
        Me.cp_forecolor.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.cp_forecolor.Size = New System.Drawing.Size(38, 22)
        Me.cp_forecolor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cp_forecolor.TabIndex = 5
        '
        'cp_backcolor
        '
        Me.cp_backcolor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cp_backcolor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cp_backcolor.Image = CType(resources.GetObject("cp_backcolor.Image"), System.Drawing.Image)
        Me.cp_backcolor.Location = New System.Drawing.Point(95, 125)
        Me.cp_backcolor.Name = "cp_backcolor"
        Me.cp_backcolor.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.cp_backcolor.Size = New System.Drawing.Size(38, 22)
        Me.cp_backcolor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cp_backcolor.TabIndex = 4
        '
        'FormMachineSpec_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 261)
        Me.Controls.Add(Me.txt_tocov)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_fromcov)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_tocvrg)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_fromcvrg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.sw_stat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cp_forecolor)
        Me.Controls.Add(Me.txt_forecolor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_backcolor)
        Me.Controls.Add(Me.cp_backcolor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_capacity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_height)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMachineSpec_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Machine Specification"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_tocov As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_fromcov As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_tocvrg As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_fromcvrg As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents sw_stat As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Label9 As Label
    Friend WithEvents cp_forecolor As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents txt_forecolor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_backcolor As TextBox
    Friend WithEvents cp_backcolor As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_capacity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_height As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents Panel1 As Panel
    Public WithEvents cmb_type As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
