<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.textNewPassword = New System.Windows.Forms.TextBox()
        Me.textConfirmPassword = New System.Windows.Forms.TextBox()
        Me.pbexit = New System.Windows.Forms.PictureBox()
        CType(Me.pbexit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textUsername
        '
        Me.textUsername.Enabled = False
        Me.textUsername.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textUsername.Location = New System.Drawing.Point(154, 174)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(134, 27)
        Me.textUsername.TabIndex = 0
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(154, 331)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(134, 39)
        Me.btnChangePassword.TabIndex = 3
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'textNewPassword
        '
        Me.textNewPassword.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textNewPassword.Location = New System.Drawing.Point(154, 230)
        Me.textNewPassword.Name = "textNewPassword"
        Me.textNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textNewPassword.Size = New System.Drawing.Size(134, 27)
        Me.textNewPassword.TabIndex = 1
        '
        'textConfirmPassword
        '
        Me.textConfirmPassword.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textConfirmPassword.Location = New System.Drawing.Point(153, 291)
        Me.textConfirmPassword.Name = "textConfirmPassword"
        Me.textConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textConfirmPassword.Size = New System.Drawing.Size(134, 27)
        Me.textConfirmPassword.TabIndex = 2
        '
        'pbexit
        '
        Me.pbexit.BackColor = System.Drawing.Color.Transparent
        Me.pbexit.BackgroundImage = CType(resources.GetObject("pbexit.BackgroundImage"), System.Drawing.Image)
        Me.pbexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbexit.Location = New System.Drawing.Point(320, -1)
        Me.pbexit.Name = "pbexit"
        Me.pbexit.Size = New System.Drawing.Size(33, 28)
        Me.pbexit.TabIndex = 8
        Me.pbexit.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(353, 432)
        Me.Controls.Add(Me.pbexit)
        Me.Controls.Add(Me.textConfirmPassword)
        Me.Controls.Add(Me.textNewPassword)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.textUsername)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.pbexit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textUsername As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents textNewPassword As TextBox
    Friend WithEvents textConfirmPassword As TextBox
    Friend WithEvents pbexit As PictureBox
End Class
