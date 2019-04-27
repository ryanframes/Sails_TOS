<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_machine_type = New System.Windows.Forms.Button()
        Me.btn_truck_code = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btn_machine_type
        '
        Me.btn_machine_type.Location = New System.Drawing.Point(12, 12)
        Me.btn_machine_type.Name = "btn_machine_type"
        Me.btn_machine_type.Size = New System.Drawing.Size(244, 23)
        Me.btn_machine_type.TabIndex = 2
        Me.btn_machine_type.Text = "Machine Type"
        Me.btn_machine_type.UseVisualStyleBackColor = True
        '
        'btn_truck_code
        '
        Me.btn_truck_code.Location = New System.Drawing.Point(12, 41)
        Me.btn_truck_code.Name = "btn_truck_code"
        Me.btn_truck_code.Size = New System.Drawing.Size(244, 23)
        Me.btn_truck_code.TabIndex = 3
        Me.btn_truck_code.Text = "Truck Code"
        Me.btn_truck_code.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 77)
        Me.Controls.Add(Me.btn_truck_code)
        Me.Controls.Add(Me.btn_machine_type)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btn_machine_type As Button
    Friend WithEvents btn_truck_code As Button
End Class
