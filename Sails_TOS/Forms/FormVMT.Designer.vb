<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVMT
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
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'btn_logout
        '
        Me.btn_logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.Color.Black
        Me.btn_logout.Location = New System.Drawing.Point(586, 4)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(66, 25)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "Log Out"
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'lbl_user
        '
        Me.lbl_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_user.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Black
        Me.lbl_user.Location = New System.Drawing.Point(488, 4)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(92, 25)
        Me.lbl_user.TabIndex = 67
        Me.lbl_user.Text = "Username"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormVMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_logout)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormVMT"
        Me.Text = "VMT"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btn_logout As Button
    Friend WithEvents lbl_user As Label
End Class