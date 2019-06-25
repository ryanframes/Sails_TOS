<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIForm
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
        Me.components = New System.ComponentModel.Container()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MachineSpecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboundDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MachineSpecToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MachineTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TruckCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YardDefinitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuayLaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindContainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InquiryContainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HRMachineDriverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthentificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip()
        Me.VMTYardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.ForeColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MachineSpecToolStripMenuItem, Me.DamageCodeToolStripMenuItem, Me.InboundDataToolStripMenuItem, Me.MachineSpecToolStripMenuItem1, Me.MachineTypeToolStripMenuItem, Me.TruckCodeToolStripMenuItem, Me.YardDefinitionToolStripMenuItem, Me.QuayLaneToolStripMenuItem, Me.FindContainerToolStripMenuItem, Me.InquiryContainerToolStripMenuItem, Me.HRMachineDriverToolStripMenuItem, Me.AuthentificationToolStripMenuItem, Me.VMTYardToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MachineSpecToolStripMenuItem
        '
        Me.MachineSpecToolStripMenuItem.Name = "MachineSpecToolStripMenuItem"
        Me.MachineSpecToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MachineSpecToolStripMenuItem.Text = "Machine Spec"
        '
        'DamageCodeToolStripMenuItem
        '
        Me.DamageCodeToolStripMenuItem.Name = "DamageCodeToolStripMenuItem"
        Me.DamageCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DamageCodeToolStripMenuItem.Text = "Damage Code"
        '
        'InboundDataToolStripMenuItem
        '
        Me.InboundDataToolStripMenuItem.Name = "InboundDataToolStripMenuItem"
        Me.InboundDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InboundDataToolStripMenuItem.Text = "Inbound Data"
        '
        'MachineSpecToolStripMenuItem1
        '
        Me.MachineSpecToolStripMenuItem1.Name = "MachineSpecToolStripMenuItem1"
        Me.MachineSpecToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MachineSpecToolStripMenuItem1.Text = "Job Controller"
        '
        'MachineTypeToolStripMenuItem
        '
        Me.MachineTypeToolStripMenuItem.Name = "MachineTypeToolStripMenuItem"
        Me.MachineTypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MachineTypeToolStripMenuItem.Text = "Machine Type"
        '
        'TruckCodeToolStripMenuItem
        '
        Me.TruckCodeToolStripMenuItem.Name = "TruckCodeToolStripMenuItem"
        Me.TruckCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TruckCodeToolStripMenuItem.Text = "Truck Code"
        '
        'YardDefinitionToolStripMenuItem
        '
        Me.YardDefinitionToolStripMenuItem.Name = "YardDefinitionToolStripMenuItem"
        Me.YardDefinitionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YardDefinitionToolStripMenuItem.Text = "Yard Definition"
        '
        'QuayLaneToolStripMenuItem
        '
        Me.QuayLaneToolStripMenuItem.Name = "QuayLaneToolStripMenuItem"
        Me.QuayLaneToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuayLaneToolStripMenuItem.Text = "Quay Lane"
        '
        'FindContainerToolStripMenuItem
        '
        Me.FindContainerToolStripMenuItem.Name = "FindContainerToolStripMenuItem"
        Me.FindContainerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FindContainerToolStripMenuItem.Text = "Find Container"
        '
        'InquiryContainerToolStripMenuItem
        '
        Me.InquiryContainerToolStripMenuItem.Name = "InquiryContainerToolStripMenuItem"
        Me.InquiryContainerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InquiryContainerToolStripMenuItem.Text = "Inquiry Container"
        '
        'HRMachineDriverToolStripMenuItem
        '
        Me.HRMachineDriverToolStripMenuItem.Name = "HRMachineDriverToolStripMenuItem"
        Me.HRMachineDriverToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HRMachineDriverToolStripMenuItem.Text = "HR Machine Driver"
        '
        'AuthentificationToolStripMenuItem
        '
        Me.AuthentificationToolStripMenuItem.Name = "AuthentificationToolStripMenuItem"
        Me.AuthentificationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AuthentificationToolStripMenuItem.Text = "Authentification"
        '
        'tabStrip1
        '
        Me.tabStrip1.AutoSelectAttachedControl = True
        Me.tabStrip1.CanReorderTabs = True
        Me.tabStrip1.CloseButtonOnTabsVisible = True
        Me.tabStrip1.CloseButtonVisible = False
        Me.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.ForeColor = System.Drawing.Color.Black
        Me.tabStrip1.Location = New System.Drawing.Point(0, 24)
        Me.tabStrip1.MdiForm = Me
        Me.tabStrip1.MdiTabbedDocuments = True
        Me.tabStrip1.Name = "tabStrip1"
        Me.tabStrip1.SelectedTab = Nothing
        Me.tabStrip1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.Size = New System.Drawing.Size(653, 26)
        Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.tabStrip1.TabIndex = 8
        Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabStrip1.Text = "tabStrip1"
        '
        'VMTYardToolStripMenuItem
        '
        Me.VMTYardToolStripMenuItem.Name = "VMTYardToolStripMenuItem"
        Me.VMTYardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VMTYardToolStripMenuItem.Text = "VMT Yard"
        '
        'MDIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.tabStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIForm"
        Me.Text = "MetroForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MachineSpecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DamageCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InboundDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MachineSpecToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MachineTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TruckCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YardDefinitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuayLaneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindContainerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InquiryContainerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HRMachineDriverToolStripMenuItem As ToolStripMenuItem
    Private WithEvents tabStrip1 As DevComponents.DotNetBar.TabStrip
    Friend WithEvents AuthentificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VMTYardToolStripMenuItem As ToolStripMenuItem
End Class
