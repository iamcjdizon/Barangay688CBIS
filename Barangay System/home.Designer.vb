<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResidentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicatinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangayClearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusinessClearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BudgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.labelWelcome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(994, 44)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.AutoSize = False
        Me.MenuToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MenuToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResidentsToolStripMenuItem, Me.ApplicatinsToolStripMenuItem, Me.BudgetToolStripMenuItem, Me.SettingToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(94, 40)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ResidentsToolStripMenuItem
        '
        Me.ResidentsToolStripMenuItem.Name = "ResidentsToolStripMenuItem"
        Me.ResidentsToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.ResidentsToolStripMenuItem.Text = "Residents"
        '
        'ApplicatinsToolStripMenuItem
        '
        Me.ApplicatinsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangayClearanceToolStripMenuItem, Me.BusinessClearanceToolStripMenuItem, Me.ComplaintsToolStripMenuItem})
        Me.ApplicatinsToolStripMenuItem.Name = "ApplicatinsToolStripMenuItem"
        Me.ApplicatinsToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.ApplicatinsToolStripMenuItem.Text = "Applications"
        '
        'BarangayClearanceToolStripMenuItem
        '
        Me.BarangayClearanceToolStripMenuItem.Name = "BarangayClearanceToolStripMenuItem"
        Me.BarangayClearanceToolStripMenuItem.Size = New System.Drawing.Size(273, 28)
        Me.BarangayClearanceToolStripMenuItem.Text = "Barangay Clearance"
        '
        'BusinessClearanceToolStripMenuItem
        '
        Me.BusinessClearanceToolStripMenuItem.Name = "BusinessClearanceToolStripMenuItem"
        Me.BusinessClearanceToolStripMenuItem.Size = New System.Drawing.Size(273, 28)
        Me.BusinessClearanceToolStripMenuItem.Text = "Business Clearance"
        '
        'ComplaintsToolStripMenuItem
        '
        Me.ComplaintsToolStripMenuItem.Name = "ComplaintsToolStripMenuItem"
        Me.ComplaintsToolStripMenuItem.Size = New System.Drawing.Size(273, 28)
        Me.ComplaintsToolStripMenuItem.Text = "Blotter"
        '
        'BudgetToolStripMenuItem
        '
        Me.BudgetToolStripMenuItem.Name = "BudgetToolStripMenuItem"
        Me.BudgetToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.BudgetToolStripMenuItem.Text = "Budget"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'labelTime
        '
        Me.labelTime.BackColor = System.Drawing.Color.Black
        Me.labelTime.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTime.ForeColor = System.Drawing.Color.White
        Me.labelTime.Location = New System.Drawing.Point(833, 15)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(108, 22)
        Me.labelTime.TabIndex = 2
        Me.labelTime.Text = "time"
        '
        'labelDate
        '
        Me.labelDate.BackColor = System.Drawing.Color.Black
        Me.labelDate.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDate.ForeColor = System.Drawing.Color.White
        Me.labelDate.Location = New System.Drawing.Point(703, 15)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(108, 22)
        Me.labelDate.TabIndex = 3
        Me.labelDate.Text = "date"
        '
        'labelWelcome
        '
        Me.labelWelcome.BackColor = System.Drawing.Color.Black
        Me.labelWelcome.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWelcome.ForeColor = System.Drawing.Color.White
        Me.labelWelcome.Location = New System.Drawing.Point(445, 15)
        Me.labelWelcome.Name = "labelWelcome"
        Me.labelWelcome.Size = New System.Drawing.Size(230, 22)
        Me.labelWelcome.TabIndex = 4
        Me.labelWelcome.Text = "welcome"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 676)
        Me.Controls.Add(Me.labelWelcome)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1010, 715)
        Me.Name = "home"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents labelTime As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents labelWelcome As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ResidentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicatinsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangayClearanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusinessClearanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComplaintsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BudgetToolStripMenuItem As ToolStripMenuItem
End Class
