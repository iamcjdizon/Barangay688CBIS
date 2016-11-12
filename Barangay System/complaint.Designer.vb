<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class complaint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complaint))
        Me.DataGridView2Complaint = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAddComplaint = New System.Windows.Forms.Button()
        Me.btnEditComplaint = New System.Windows.Forms.Button()
        Me.btnDeleteComplaint = New System.Windows.Forms.Button()
        Me.btnPrintComplaint = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.myimage2 = New System.Windows.Forms.PictureBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelClose = New System.Windows.Forms.Label()
        Me.comboSearchComplaint = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2Complaint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.myimage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2Complaint
        '
        Me.DataGridView2Complaint.AllowUserToAddRows = False
        Me.DataGridView2Complaint.AllowUserToDeleteRows = False
        Me.DataGridView2Complaint.AllowUserToResizeColumns = False
        Me.DataGridView2Complaint.AllowUserToResizeRows = False
        Me.DataGridView2Complaint.BackgroundColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2Complaint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2Complaint.ColumnHeadersHeight = 35
        Me.DataGridView2Complaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2Complaint.EnableHeadersVisualStyles = False
        Me.DataGridView2Complaint.Location = New System.Drawing.Point(219, 122)
        Me.DataGridView2Complaint.Name = "DataGridView2Complaint"
        Me.DataGridView2Complaint.ReadOnly = True
        Me.DataGridView2Complaint.RowHeadersVisible = False
        Me.DataGridView2Complaint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2Complaint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2Complaint.Size = New System.Drawing.Size(723, 325)
        Me.DataGridView2Complaint.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(216, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 18)
        Me.Label20.TabIndex = 453
        Me.Label20.Text = "Search:"
        '
        'btnAddComplaint
        '
        Me.btnAddComplaint.BackColor = System.Drawing.Color.White
        Me.btnAddComplaint.BackgroundImage = CType(resources.GetObject("btnAddComplaint.BackgroundImage"), System.Drawing.Image)
        Me.btnAddComplaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddComplaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddComplaint.Location = New System.Drawing.Point(10, 6)
        Me.btnAddComplaint.Name = "btnAddComplaint"
        Me.btnAddComplaint.Size = New System.Drawing.Size(137, 72)
        Me.btnAddComplaint.TabIndex = 314
        Me.btnAddComplaint.UseVisualStyleBackColor = False
        '
        'btnEditComplaint
        '
        Me.btnEditComplaint.BackgroundImage = CType(resources.GetObject("btnEditComplaint.BackgroundImage"), System.Drawing.Image)
        Me.btnEditComplaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditComplaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditComplaint.Location = New System.Drawing.Point(174, 6)
        Me.btnEditComplaint.Name = "btnEditComplaint"
        Me.btnEditComplaint.Size = New System.Drawing.Size(137, 72)
        Me.btnEditComplaint.TabIndex = 315
        Me.btnEditComplaint.UseVisualStyleBackColor = True
        Me.btnEditComplaint.Visible = False
        '
        'btnDeleteComplaint
        '
        Me.btnDeleteComplaint.BackgroundImage = CType(resources.GetObject("btnDeleteComplaint.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteComplaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteComplaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteComplaint.Location = New System.Drawing.Point(338, 6)
        Me.btnDeleteComplaint.Name = "btnDeleteComplaint"
        Me.btnDeleteComplaint.Size = New System.Drawing.Size(137, 72)
        Me.btnDeleteComplaint.TabIndex = 316
        Me.btnDeleteComplaint.UseVisualStyleBackColor = True
        Me.btnDeleteComplaint.Visible = False
        '
        'btnPrintComplaint
        '
        Me.btnPrintComplaint.BackgroundImage = CType(resources.GetObject("btnPrintComplaint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintComplaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintComplaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintComplaint.Location = New System.Drawing.Point(809, 6)
        Me.btnPrintComplaint.Name = "btnPrintComplaint"
        Me.btnPrintComplaint.Size = New System.Drawing.Size(137, 72)
        Me.btnPrintComplaint.TabIndex = 317
        Me.btnPrintComplaint.UseVisualStyleBackColor = True
        Me.btnPrintComplaint.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.btnAddComplaint)
        Me.Panel1.Controls.Add(Me.btnEditComplaint)
        Me.Panel1.Controls.Add(Me.btnDeleteComplaint)
        Me.Panel1.Controls.Add(Me.btnPrintComplaint)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 476)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 84)
        Me.Panel1.TabIndex = 454
        '
        'myimage2
        '
        Me.myimage2.BackColor = System.Drawing.Color.Lavender
        Me.myimage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myimage2.Location = New System.Drawing.Point(12, 122)
        Me.myimage2.Name = "myimage2"
        Me.myimage2.Size = New System.Drawing.Size(198, 303)
        Me.myimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.myimage2.TabIndex = 458
        Me.myimage2.TabStop = False
        '
        'lblPreview
        '
        Me.lblPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.Black
        Me.lblPreview.Location = New System.Drawing.Point(25, 203)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(86, 18)
        Me.lblPreview.TabIndex = 459
        Me.lblPreview.Text = "Preview"
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 18)
        Me.Label1.TabIndex = 460
        Me.Label1.Text = "Preview"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'labelClose
        '
        Me.labelClose.AutoSize = True
        Me.labelClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelClose.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClose.ForeColor = System.Drawing.Color.White
        Me.labelClose.Location = New System.Drawing.Point(916, -1)
        Me.labelClose.Name = "labelClose"
        Me.labelClose.Size = New System.Drawing.Size(35, 39)
        Me.labelClose.TabIndex = 565
        Me.labelClose.Text = "X"
        '
        'comboSearchComplaint
        '
        Me.comboSearchComplaint.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSearchComplaint.FormattingEnabled = True
        Me.comboSearchComplaint.Items.AddRange(New Object() {"ALL Records"})
        Me.comboSearchComplaint.Location = New System.Drawing.Point(280, 89)
        Me.comboSearchComplaint.Name = "comboSearchComplaint"
        Me.comboSearchComplaint.Size = New System.Drawing.Size(110, 27)
        Me.comboSearchComplaint.TabIndex = 566
        Me.comboSearchComplaint.Text = "--Select--"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(951, 69)
        Me.Panel2.TabIndex = 574
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(338, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox2.TabIndex = 571
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(916, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 39)
        Me.Label2.TabIndex = 565
        Me.Label2.Text = "X"
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(147, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 42)
        Me.Label3.TabIndex = 569
        Me.Label3.Text = "Blotter"
        '
        'complaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 560)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.comboSearchComplaint)
        Me.Controls.Add(Me.labelClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.myimage2)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DataGridView2Complaint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(12, 30)
        Me.Name = "complaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "addcomplaint"
        Me.Text = "complaint"
        CType(Me.DataGridView2Complaint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.myimage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2Complaint As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents btnAddComplaint As Button
    Friend WithEvents btnEditComplaint As Button
    Friend WithEvents btnDeleteComplaint As Button
    Friend WithEvents btnPrintComplaint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents myimage2 As PictureBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labelClose As Label
    Friend WithEvents comboSearchComplaint As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
