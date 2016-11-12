<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class barangayclearance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(barangayclearance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2Bar = New System.Windows.Forms.DataGridView()
        Me.comboSearchBar = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnRegisterBar = New System.Windows.Forms.Button()
        Me.btnEditBar = New System.Windows.Forms.Button()
        Me.btnDeleteBar = New System.Windows.Forms.Button()
        Me.btnPrintBar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.myimage2 = New System.Windows.Forms.PictureBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.labelClose = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView2Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.myimage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-265, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "Address:"
        '
        'DataGridView2Bar
        '
        Me.DataGridView2Bar.AllowUserToAddRows = False
        Me.DataGridView2Bar.AllowUserToDeleteRows = False
        Me.DataGridView2Bar.AllowUserToResizeColumns = False
        Me.DataGridView2Bar.AllowUserToResizeRows = False
        Me.DataGridView2Bar.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2Bar.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2Bar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2Bar.ColumnHeadersHeight = 35
        Me.DataGridView2Bar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2Bar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2Bar.EnableHeadersVisualStyles = False
        Me.DataGridView2Bar.Location = New System.Drawing.Point(216, 124)
        Me.DataGridView2Bar.Name = "DataGridView2Bar"
        Me.DataGridView2Bar.ReadOnly = True
        Me.DataGridView2Bar.RowHeadersVisible = False
        Me.DataGridView2Bar.RowHeadersWidth = 60
        Me.DataGridView2Bar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2Bar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2Bar.Size = New System.Drawing.Size(723, 325)
        Me.DataGridView2Bar.TabIndex = 393
        '
        'comboSearchBar
        '
        Me.comboSearchBar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSearchBar.FormattingEnabled = True
        Me.comboSearchBar.Items.AddRange(New Object() {"All Applicants"})
        Me.comboSearchBar.Location = New System.Drawing.Point(280, 91)
        Me.comboSearchBar.Name = "comboSearchBar"
        Me.comboSearchBar.Size = New System.Drawing.Size(133, 27)
        Me.comboSearchBar.TabIndex = 7
        Me.comboSearchBar.Text = "--Select--"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(216, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 18)
        Me.Label14.TabIndex = 425
        Me.Label14.Text = "Search:"
        '
        'btnRegisterBar
        '
        Me.btnRegisterBar.BackColor = System.Drawing.Color.White
        Me.btnRegisterBar.BackgroundImage = CType(resources.GetObject("btnRegisterBar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegisterBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegisterBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegisterBar.Location = New System.Drawing.Point(13, 7)
        Me.btnRegisterBar.Name = "btnRegisterBar"
        Me.btnRegisterBar.Size = New System.Drawing.Size(137, 72)
        Me.btnRegisterBar.TabIndex = 314
        Me.btnRegisterBar.UseVisualStyleBackColor = False
        '
        'btnEditBar
        '
        Me.btnEditBar.BackgroundImage = CType(resources.GetObject("btnEditBar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditBar.Location = New System.Drawing.Point(174, 6)
        Me.btnEditBar.Name = "btnEditBar"
        Me.btnEditBar.Size = New System.Drawing.Size(137, 72)
        Me.btnEditBar.TabIndex = 315
        Me.btnEditBar.UseVisualStyleBackColor = True
        Me.btnEditBar.Visible = False
        '
        'btnDeleteBar
        '
        Me.btnDeleteBar.BackgroundImage = CType(resources.GetObject("btnDeleteBar.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteBar.Location = New System.Drawing.Point(338, 6)
        Me.btnDeleteBar.Name = "btnDeleteBar"
        Me.btnDeleteBar.Size = New System.Drawing.Size(137, 72)
        Me.btnDeleteBar.TabIndex = 316
        Me.btnDeleteBar.UseVisualStyleBackColor = True
        Me.btnDeleteBar.Visible = False
        '
        'btnPrintBar
        '
        Me.btnPrintBar.BackgroundImage = CType(resources.GetObject("btnPrintBar.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintBar.Location = New System.Drawing.Point(811, 6)
        Me.btnPrintBar.Name = "btnPrintBar"
        Me.btnPrintBar.Size = New System.Drawing.Size(137, 72)
        Me.btnPrintBar.TabIndex = 317
        Me.btnPrintBar.UseVisualStyleBackColor = True
        Me.btnPrintBar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.btnRegisterBar)
        Me.Panel1.Controls.Add(Me.btnEditBar)
        Me.Panel1.Controls.Add(Me.btnDeleteBar)
        Me.Panel1.Controls.Add(Me.btnPrintBar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 476)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 84)
        Me.Panel1.TabIndex = 426
        '
        'myimage2
        '
        Me.myimage2.BackColor = System.Drawing.Color.Lavender
        Me.myimage2.BackgroundImage = CType(resources.GetObject("myimage2.BackgroundImage"), System.Drawing.Image)
        Me.myimage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myimage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myimage2.Location = New System.Drawing.Point(10, 125)
        Me.myimage2.Name = "myimage2"
        Me.myimage2.Size = New System.Drawing.Size(198, 303)
        Me.myimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.myimage2.TabIndex = 430
        Me.myimage2.TabStop = False
        '
        'lblPreview
        '
        Me.lblPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPreview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.White
        Me.lblPreview.Location = New System.Drawing.Point(10, 431)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(198, 18)
        Me.lblPreview.TabIndex = 431
        Me.lblPreview.Text = "Preview"
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPreview.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(442, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox2.TabIndex = 571
        Me.PictureBox2.TabStop = False
        '
        'labelClose
        '
        Me.labelClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelClose.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClose.ForeColor = System.Drawing.Color.White
        Me.labelClose.Location = New System.Drawing.Point(916, 0)
        Me.labelClose.Name = "labelClose"
        Me.labelClose.Size = New System.Drawing.Size(35, 35)
        Me.labelClose.TabIndex = 567
        Me.labelClose.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox1.TabIndex = 570
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(86, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 42)
        Me.Label2.TabIndex = 569
        Me.Label2.Text = "Barangay Clearance"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.labelClose)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(951, 69)
        Me.Panel2.TabIndex = 573
        '
        'barangayclearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 560)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.myimage2)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.comboSearchBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2Bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(12, 30)
        Me.Name = "barangayclearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "addbarangay"
        Me.Text = "A"
        CType(Me.DataGridView2Bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.myimage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2Bar As DataGridView
    Friend WithEvents comboSearchBar As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnRegisterBar As Button
    Friend WithEvents btnEditBar As Button
    Friend WithEvents btnDeleteBar As Button
    Friend WithEvents btnPrintBar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents myimage2 As PictureBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents labelClose As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class
