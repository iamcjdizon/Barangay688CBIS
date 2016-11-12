<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brgyformpreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(brgyformpreview))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.date1 = New System.Windows.Forms.Label()
        Me.suffix = New System.Windows.Forms.Label()
        Me.purpose = New System.Windows.Forms.Label()
        Me.textStreet = New System.Windows.Forms.Label()
        Me.textHNo = New System.Windows.Forms.Label()
        Me.middleName = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.date1)
        Me.Panel1.Controls.Add(Me.suffix)
        Me.Panel1.Controls.Add(Me.purpose)
        Me.Panel1.Controls.Add(Me.textStreet)
        Me.Panel1.Controls.Add(Me.textHNo)
        Me.Panel1.Controls.Add(Me.middleName)
        Me.Panel1.Controls.Add(Me.lastname)
        Me.Panel1.Controls.Add(Me.firstname)
        Me.Panel1.Location = New System.Drawing.Point(3, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 648)
        Me.Panel1.TabIndex = 4
        '
        'date1
        '
        Me.date1.AutoSize = True
        Me.date1.BackColor = System.Drawing.Color.Transparent
        Me.date1.Location = New System.Drawing.Point(295, 403)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(28, 13)
        Me.date1.TabIndex = 7
        Me.date1.Text = "date"
        Me.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'suffix
        '
        Me.suffix.AutoSize = True
        Me.suffix.BackColor = System.Drawing.Color.Transparent
        Me.suffix.Location = New System.Drawing.Point(466, 205)
        Me.suffix.Name = "suffix"
        Me.suffix.Size = New System.Drawing.Size(31, 13)
        Me.suffix.TabIndex = 6
        Me.suffix.Text = "suffix"
        Me.suffix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'purpose
        '
        Me.purpose.AutoSize = True
        Me.purpose.BackColor = System.Drawing.Color.Transparent
        Me.purpose.Location = New System.Drawing.Point(274, 467)
        Me.purpose.Name = "purpose"
        Me.purpose.Size = New System.Drawing.Size(45, 13)
        Me.purpose.TabIndex = 5
        Me.purpose.Text = "purpose"
        Me.purpose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textStreet
        '
        Me.textStreet.AutoSize = True
        Me.textStreet.BackColor = System.Drawing.Color.Transparent
        Me.textStreet.Location = New System.Drawing.Point(216, 267)
        Me.textStreet.Name = "textStreet"
        Me.textStreet.Size = New System.Drawing.Size(52, 13)
        Me.textStreet.TabIndex = 4
        Me.textStreet.Text = "textStreet"
        Me.textStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textHNo
        '
        Me.textHNo.AutoSize = True
        Me.textHNo.BackColor = System.Drawing.Color.Transparent
        Me.textHNo.Location = New System.Drawing.Point(467, 240)
        Me.textHNo.Name = "textHNo"
        Me.textHNo.Size = New System.Drawing.Size(46, 13)
        Me.textHNo.TabIndex = 3
        Me.textHNo.Text = "textHNo"
        Me.textHNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'middleName
        '
        Me.middleName.AutoSize = True
        Me.middleName.BackColor = System.Drawing.Color.Transparent
        Me.middleName.Location = New System.Drawing.Point(358, 205)
        Me.middleName.Name = "middleName"
        Me.middleName.Size = New System.Drawing.Size(39, 13)
        Me.middleName.TabIndex = 1
        Me.middleName.Text = "Label2"
        Me.middleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lastname
        '
        Me.lastname.AutoSize = True
        Me.lastname.BackColor = System.Drawing.Color.Transparent
        Me.lastname.Location = New System.Drawing.Point(421, 205)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(39, 13)
        Me.lastname.TabIndex = 2
        Me.lastname.Text = "Label3"
        Me.lastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.BackColor = System.Drawing.Color.Transparent
        Me.firstname.Location = New System.Drawing.Point(295, 205)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(39, 13)
        Me.firstname.TabIndex = 0
        Me.firstname.Text = "Label1"
        Me.firstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(563, -2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 27)
        Me.Label17.TabIndex = 428
        Me.Label17.Text = "X"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'brgyformpreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 671)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(350, 20)
        Me.Name = "brgyformpreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "brgyformpreview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents date1 As Label
    Friend WithEvents suffix As Label
    Friend WithEvents purpose As Label
    Friend WithEvents textStreet As Label
    Friend WithEvents textHNo As Label
    Friend WithEvents middleName As Label
    Friend WithEvents lastname As Label
    Friend WithEvents firstname As Label
    Friend WithEvents Label17 As Label
End Class
