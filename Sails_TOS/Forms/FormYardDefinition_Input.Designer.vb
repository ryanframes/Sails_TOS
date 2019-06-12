<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYardDefinition_Input
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_available_tier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_max_row = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_max_tier = New System.Windows.Forms.TextBox()
        Me.txt_block_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_block_type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txt_position_x = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_stack_direction = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmb_row_direction = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_position_y = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_design_capacity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_avail_capacity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 52)
        Me.Panel1.TabIndex = 44
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Sails_TOS.My.Resources.Resources.Save_2
        Me.btn_save.Location = New System.Drawing.Point(436, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 25)
        Me.btn_save.TabIndex = 12
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
        Me.btn_cancel.Location = New System.Drawing.Point(508, 12)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 25)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Position X"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_available_tier
        '
        Me.txt_available_tier.BackColor = System.Drawing.Color.White
        Me.txt_available_tier.ForeColor = System.Drawing.Color.Black
        Me.txt_available_tier.Location = New System.Drawing.Point(95, 119)
        Me.txt_available_tier.Name = "txt_available_tier"
        Me.txt_available_tier.Size = New System.Drawing.Size(188, 22)
        Me.txt_available_tier.TabIndex = 8
        Me.txt_available_tier.Text = "0"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Available Tier"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_max_row
        '
        Me.txt_max_row.BackColor = System.Drawing.Color.White
        Me.txt_max_row.ForeColor = System.Drawing.Color.Black
        Me.txt_max_row.Location = New System.Drawing.Point(95, 62)
        Me.txt_max_row.Name = "txt_max_row"
        Me.txt_max_row.Size = New System.Drawing.Size(188, 22)
        Me.txt_max_row.TabIndex = 4
        Me.txt_max_row.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Max Row"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_max_tier
        '
        Me.txt_max_tier.BackColor = System.Drawing.Color.White
        Me.txt_max_tier.ForeColor = System.Drawing.Color.Black
        Me.txt_max_tier.Location = New System.Drawing.Point(95, 90)
        Me.txt_max_tier.Name = "txt_max_tier"
        Me.txt_max_tier.Size = New System.Drawing.Size(188, 22)
        Me.txt_max_tier.TabIndex = 6
        Me.txt_max_tier.Text = "0"
        '
        'txt_block_name
        '
        Me.txt_block_name.BackColor = System.Drawing.Color.White
        Me.txt_block_name.ForeColor = System.Drawing.Color.Black
        Me.txt_block_name.Location = New System.Drawing.Point(95, 6)
        Me.txt_block_name.Name = "txt_block_name"
        Me.txt_block_name.Size = New System.Drawing.Size(188, 22)
        Me.txt_block_name.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Block Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Block Name *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Max Tier"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_block_type
        '
        Me.cmb_block_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_block_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_block_type.DisplayMember = "Text"
        Me.cmb_block_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_block_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_block_type.ForeColor = System.Drawing.Color.Black
        Me.cmb_block_type.FormattingEnabled = True
        Me.cmb_block_type.ItemHeight = 17
        Me.cmb_block_type.Location = New System.Drawing.Point(95, 33)
        Me.cmb_block_type.Name = "cmb_block_type"
        Me.cmb_block_type.Size = New System.Drawing.Size(188, 23)
        Me.cmb_block_type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_block_type.TabIndex = 2
        '
        'txt_position_x
        '
        Me.txt_position_x.BackColor = System.Drawing.Color.White
        Me.txt_position_x.ForeColor = System.Drawing.Color.Black
        Me.txt_position_x.Location = New System.Drawing.Point(95, 147)
        Me.txt_position_x.Name = "txt_position_x"
        Me.txt_position_x.Size = New System.Drawing.Size(188, 22)
        Me.txt_position_x.TabIndex = 10
        Me.txt_position_x.Text = "0"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(293, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Stack Direction"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_stack_direction
        '
        Me.cmb_stack_direction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_stack_direction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_stack_direction.DisplayMember = "Text"
        Me.cmb_stack_direction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_stack_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_stack_direction.ForeColor = System.Drawing.Color.Black
        Me.cmb_stack_direction.FormattingEnabled = True
        Me.cmb_stack_direction.ItemHeight = 17
        Me.cmb_stack_direction.Location = New System.Drawing.Point(404, 6)
        Me.cmb_stack_direction.Name = "cmb_stack_direction"
        Me.cmb_stack_direction.Size = New System.Drawing.Size(188, 23)
        Me.cmb_stack_direction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_stack_direction.TabIndex = 1
        '
        'cmb_row_direction
        '
        Me.cmb_row_direction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_row_direction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_row_direction.DisplayMember = "Text"
        Me.cmb_row_direction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_row_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_row_direction.ForeColor = System.Drawing.Color.Black
        Me.cmb_row_direction.FormattingEnabled = True
        Me.cmb_row_direction.ItemHeight = 17
        Me.cmb_row_direction.Location = New System.Drawing.Point(404, 33)
        Me.cmb_row_direction.Name = "cmb_row_direction"
        Me.cmb_row_direction.Size = New System.Drawing.Size(188, 23)
        Me.cmb_row_direction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_row_direction.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(293, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 22)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Row Direction"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_status
        '
        Me.cmb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_status.DisplayMember = "Text"
        Me.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.ForeColor = System.Drawing.Color.Black
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.ItemHeight = 17
        Me.cmb_status.Location = New System.Drawing.Point(404, 118)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(188, 23)
        Me.cmb_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_status.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(293, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 22)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_position_y
        '
        Me.txt_position_y.BackColor = System.Drawing.Color.White
        Me.txt_position_y.ForeColor = System.Drawing.Color.Black
        Me.txt_position_y.Location = New System.Drawing.Point(404, 147)
        Me.txt_position_y.Name = "txt_position_y"
        Me.txt_position_y.Size = New System.Drawing.Size(188, 22)
        Me.txt_position_y.TabIndex = 11
        Me.txt_position_y.Text = "0"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(293, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 23)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Position Y"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_design_capacity
        '
        Me.txt_design_capacity.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_design_capacity.Enabled = False
        Me.txt_design_capacity.ForeColor = System.Drawing.Color.Black
        Me.txt_design_capacity.Location = New System.Drawing.Point(404, 62)
        Me.txt_design_capacity.Name = "txt_design_capacity"
        Me.txt_design_capacity.ReadOnly = True
        Me.txt_design_capacity.Size = New System.Drawing.Size(188, 22)
        Me.txt_design_capacity.TabIndex = 5
        Me.txt_design_capacity.Text = "0"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(293, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 23)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Design Capacity"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_avail_capacity
        '
        Me.txt_avail_capacity.BackColor = System.Drawing.Color.White
        Me.txt_avail_capacity.ForeColor = System.Drawing.Color.Black
        Me.txt_avail_capacity.Location = New System.Drawing.Point(404, 90)
        Me.txt_avail_capacity.Name = "txt_avail_capacity"
        Me.txt_avail_capacity.Size = New System.Drawing.Size(188, 22)
        Me.txt_avail_capacity.TabIndex = 7
        Me.txt_avail_capacity.Text = "0"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(293, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 23)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Available Capacity"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormYardDefinition_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 234)
        Me.Controls.Add(Me.txt_avail_capacity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_design_capacity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_position_y)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_row_direction)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_stack_direction)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_position_x)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_available_tier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_max_row)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_max_tier)
        Me.Controls.Add(Me.txt_block_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_block_type)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormYardDefinition_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Block"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_available_tier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_max_row As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_max_tier As TextBox
    Friend WithEvents txt_block_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_block_type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txt_position_x As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_stack_direction As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmb_row_direction As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_status As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_position_y As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_design_capacity As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_avail_capacity As TextBox
    Friend WithEvents Label12 As Label
End Class
