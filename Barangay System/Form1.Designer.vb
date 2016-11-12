<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbexit = New System.Windows.Forms.PictureBox()
        CType(Me.pbexit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Location = New System.Drawing.Point(163, 301)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(134, 39)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'textUsername
        '
        Me.textUsername.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUsername.Location = New System.Drawing.Point(163, 187)
        Me.textUsername.MaxLength = 25
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(134, 27)
        Me.textUsername.TabIndex = 0
        '
        'textPassword
        '
        Me.textPassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.Location = New System.Drawing.Point(163, 253)
        Me.textPassword.MaxLength = 25
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textPassword.Size = New System.Drawing.Size(134, 27)
        Me.textPassword.TabIndex = 1
        '
        'Timer1
        '
        '
        'pbexit
        '
        Me.pbexit.BackColor = System.Drawing.Color.Transparent
        Me.pbexit.BackgroundImage = CType(resources.GetObject("pbexit.BackgroundImage"), System.Drawing.Image)
        Me.pbexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbexit.Location = New System.Drawing.Point(336, 0)
        Me.pbexit.Name = "pbexit"
        Me.pbexit.Size = New System.Drawing.Size(33, 28)
        Me.pbexit.TabIndex = 4
        Me.pbexit.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(369, 471)
        Me.Controls.Add(Me.pbexit)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.textUsername)
        Me.Controls.Add(Me.btnlogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbexit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents textUsername As TextBox
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbexit As PictureBox
End Class
