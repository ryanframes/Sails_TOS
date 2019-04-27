<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTruckCode_Input
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
        Me.txt_truck_number = New System.Windows.Forms.TextBox()
        Me.txt_tid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rfid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_truck_company = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.cmb_itv = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_truck_number
        '
        Me.txt_truck_number.BackColor = System.Drawing.Color.White
        Me.txt_truck_number.ForeColor = System.Drawing.Color.Black
        Me.txt_truck_number.Location = New System.Drawing.Point(123, 40)
        Me.txt_truck_number.Name = "txt_truck_number"
        Me.txt_truck_number.Size = New System.Drawing.Size(188, 22)
        Me.txt_truck_number.TabIndex = 1
        '
        'txt_tid
        '
        Me.txt_tid.BackColor = System.Drawing.Color.White
        Me.txt_tid.ForeColor = System.Drawing.Color.Black
        Me.txt_tid.Location = New System.Drawing.Point(123, 12)
        Me.txt_tid.Name = "txt_tid"
        Me.txt_tid.Size = New System.Drawing.Size(188, 22)
        Me.txt_tid.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Truck Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 22)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "TID *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_rfid
        '
        Me.txt_rfid.BackColor = System.Drawing.Color.White
        Me.txt_rfid.ForeColor = System.Drawing.Color.Black
        Me.txt_rfid.Location = New System.Drawing.Point(123, 68)
        Me.txt_rfid.Name = "txt_rfid"
        Me.txt_rfid.Size = New System.Drawing.Size(188, 22)
        Me.txt_rfid.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "RFID Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_truck_company
        '
        Me.txt_truck_company.BackColor = System.Drawing.Color.White
        Me.txt_truck_company.ForeColor = System.Drawing.Color.Black
        Me.txt_truck_company.Location = New System.Drawing.Point(123, 125)
        Me.txt_truck_company.Name = "txt_truck_company"
        Me.txt_truck_company.Size = New System.Drawing.Size(188, 22)
        Me.txt_truck_company.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Trucking Company"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_remarks
        '
        Me.txt_remarks.BackColor = System.Drawing.Color.White
        Me.txt_remarks.ForeColor = System.Drawing.Color.Black
        Me.txt_remarks.Location = New System.Drawing.Point(123, 153)
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_remarks.Size = New System.Drawing.Size(188, 59)
        Me.txt_remarks.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Remarks"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 52)
        Me.Panel1.TabIndex = 30
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Sails_TOS.My.Resources.Resources.Save_2
        Me.btn_save.Location = New System.Drawing.Point(239, 12)
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
        Me.btn_cancel.Location = New System.Drawing.Point(227, 12)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 25)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'cmb_itv
        '
        Me.cmb_itv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_itv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_itv.DisplayMember = "Text"
        Me.cmb_itv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_itv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_itv.ForeColor = System.Drawing.Color.Black
        Me.cmb_itv.FormattingEnabled = True
        Me.cmb_itv.ItemHeight = 17
        Me.cmb_itv.Location = New System.Drawing.Point(123, 96)
        Me.cmb_itv.Name = "cmb_itv"
        Me.cmb_itv.Size = New System.Drawing.Size(188, 23)
        Me.cmb_itv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmb_itv.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "ITV Flag"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormTruckCode_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 271)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_itv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_truck_company)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_rfid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_truck_number)
        Me.Controls.Add(Me.txt_tid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTruckCode_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Truck Code"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_truck_number As TextBox
    Friend WithEvents txt_tid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_rfid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_truck_company As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_remarks As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_itv As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
