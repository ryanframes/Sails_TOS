<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormYardDefinition_InputSlot
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
        Me.cmb_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_20stack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_40stack = New System.Windows.Forms.TextBox()
        Me.txt_block_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_size_type = New DevComponents.DotNetBar.Controls.TokenEditor()
        Me.cmb_cargo_type = New DevComponents.DotNetBar.Controls.TokenEditor()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 52)
        Me.Panel1.TabIndex = 76
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Sails_TOS.My.Resources.Resources.Save_2
        Me.btn_save.Location = New System.Drawing.Point(129, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 25)
        Me.btn_save.TabIndex = 6
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
        Me.btn_cancel.Location = New System.Drawing.Point(201, 12)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 25)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
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
        Me.cmb_status.Location = New System.Drawing.Point(95, 148)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(188, 23)
        Me.cmb_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_status.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 22)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Cargo Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Size Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_20stack
        '
        Me.txt_20stack.BackColor = System.Drawing.Color.White
        Me.txt_20stack.ForeColor = System.Drawing.Color.Black
        Me.txt_20stack.Location = New System.Drawing.Point(95, 35)
        Me.txt_20stack.Name = "txt_20stack"
        Me.txt_20stack.Size = New System.Drawing.Size(188, 22)
        Me.txt_20stack.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "20 Stack Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_40stack
        '
        Me.txt_40stack.BackColor = System.Drawing.Color.White
        Me.txt_40stack.ForeColor = System.Drawing.Color.Black
        Me.txt_40stack.Location = New System.Drawing.Point(95, 63)
        Me.txt_40stack.Name = "txt_40stack"
        Me.txt_40stack.Size = New System.Drawing.Size(188, 22)
        Me.txt_40stack.TabIndex = 2
        '
        'txt_block_name
        '
        Me.txt_block_name.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_block_name.Enabled = False
        Me.txt_block_name.ForeColor = System.Drawing.Color.Black
        Me.txt_block_name.Location = New System.Drawing.Point(95, 7)
        Me.txt_block_name.Name = "txt_block_name"
        Me.txt_block_name.Size = New System.Drawing.Size(188, 22)
        Me.txt_block_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Block Name *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "40 Stack Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_size_type
        '
        Me.cmb_size_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.cmb_size_type.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.cmb_size_type.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmb_size_type.CheckBoxesVisible = True
        Me.cmb_size_type.DropDownButtonVisible = True
        Me.cmb_size_type.ForeColor = System.Drawing.Color.Black
        Me.cmb_size_type.Location = New System.Drawing.Point(95, 91)
        Me.cmb_size_type.Name = "cmb_size_type"
        Me.cmb_size_type.Separators.Add(";")
        Me.cmb_size_type.Separators.Add(",")
        Me.cmb_size_type.Size = New System.Drawing.Size(188, 23)
        Me.cmb_size_type.TabIndex = 3
        '
        'cmb_cargo_type
        '
        Me.cmb_cargo_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.cmb_cargo_type.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.cmb_cargo_type.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cmb_cargo_type.CheckBoxesVisible = True
        Me.cmb_cargo_type.DropDownButtonVisible = True
        Me.cmb_cargo_type.ForeColor = System.Drawing.Color.Black
        Me.cmb_cargo_type.Location = New System.Drawing.Point(95, 120)
        Me.cmb_cargo_type.Name = "cmb_cargo_type"
        Me.cmb_cargo_type.Separators.Add(";")
        Me.cmb_cargo_type.Separators.Add(",")
        Me.cmb_cargo_type.Size = New System.Drawing.Size(188, 23)
        Me.cmb_cargo_type.TabIndex = 4
        '
        'FormYardDefinition_InputSlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 233)
        Me.Controls.Add(Me.cmb_cargo_type)
        Me.Controls.Add(Me.cmb_size_type)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_20stack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_40stack)
        Me.Controls.Add(Me.txt_block_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormYardDefinition_InputSlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Slot"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents cmb_status As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_20stack As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_40stack As TextBox
    Friend WithEvents txt_block_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_size_type As DevComponents.DotNetBar.Controls.TokenEditor
    Friend WithEvents cmb_cargo_type As DevComponents.DotNetBar.Controls.TokenEditor
End Class
