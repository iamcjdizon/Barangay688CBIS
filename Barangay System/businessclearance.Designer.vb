<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class businessclearance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(businessclearance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2Business = New System.Windows.Forms.DataGridView()
        Me.comboSearchBusiness = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAddBusiness = New System.Windows.Forms.Button()
        Me.btnEditBusiness = New System.Windows.Forms.Button()
        Me.btnDeleteBusiness = New System.Windows.Forms.Button()
        Me.btnPrintBusiness = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.myimage2 = New System.Windows.Forms.PictureBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.labelClose = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2Business, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.myimage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-256, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 349
        Me.Label1.Text = "Address:"
        '
        'DataGridView2Business
        '
        Me.DataGridView2Business.AllowUserToAddRows = False
        Me.DataGridView2Business.AllowUserToDeleteRows = False
        Me.DataGridView2Business.AllowUserToResizeColumns = False
        Me.DataGridView2Business.AllowUserToResizeRows = False
        Me.DataGridView2Business.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2Business.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2Business.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2Business.ColumnHeadersHeight = 35
        Me.DataGridView2Business.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2Business.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2Business.EnableHeadersVisualStyles = False
        Me.DataGridView2Business.Location = New System.Drawing.Point(216, 124)
        Me.DataGridView2Business.Name = "DataGridView2Business"
        Me.DataGridView2Business.ReadOnly = True
        Me.DataGridView2Business.RowHeadersVisible = False
        Me.DataGridView2Business.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2Business.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2Business.Size = New System.Drawing.Size(723, 325)
        Me.DataGridView2Business.TabIndex = 332
        '
        'comboSearchBusiness
        '
        Me.comboSearchBusiness.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSearchBusiness.FormattingEnabled = True
        Me.comboSearchBusiness.Items.AddRange(New Object() {"All Applications"})
        Me.comboSearchBusiness.Location = New System.Drawing.Point(277, 91)
        Me.comboSearchBusiness.Name = "comboSearchBusiness"
        Me.comboSearchBusiness.Size = New System.Drawing.Size(121, 27)
        Me.comboSearchBusiness.TabIndex = 12
        Me.comboSearchBusiness.Text = "--Select--"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Berlin Sans FB Demi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(213, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 18)
        Me.Label20.TabIndex = 382
        Me.Label20.Text = "Search:"
        '
        'btnAddBusiness
        '
        Me.btnAddBusiness.BackColor = System.Drawing.Color.White
        Me.btnAddBusiness.BackgroundImage = CType(resources.GetObject("btnAddBusiness.BackgroundImage"), System.Drawing.Image)
        Me.btnAddBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBusiness.Location = New System.Drawing.Point(14, 6)
        Me.btnAddBusiness.Name = "btnAddBusiness"
        Me.btnAddBusiness.Size = New System.Drawing.Size(137, 72)
        Me.btnAddBusiness.TabIndex = 314
        Me.btnAddBusiness.UseVisualStyleBackColor = False
        '
        'btnEditBusiness
        '
        Me.btnEditBusiness.BackgroundImage = CType(resources.GetObject("btnEditBusiness.BackgroundImage"), System.Drawing.Image)
        Me.btnEditBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditBusiness.Location = New System.Drawing.Point(174, 6)
        Me.btnEditBusiness.Name = "btnEditBusiness"
        Me.btnEditBusiness.Size = New System.Drawing.Size(137, 72)
        Me.btnEditBusiness.TabIndex = 315
        Me.btnEditBusiness.UseVisualStyleBackColor = True
        Me.btnEditBusiness.Visible = False
        '
        'btnDeleteBusiness
        '
        Me.btnDeleteBusiness.BackgroundImage = CType(resources.GetObject("btnDeleteBusiness.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeleteBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteBusiness.Location = New System.Drawing.Point(338, 6)
        Me.btnDeleteBusiness.Name = "btnDeleteBusiness"
        Me.btnDeleteBusiness.Size = New System.Drawing.Size(137, 72)
        Me.btnDeleteBusiness.TabIndex = 316
        Me.btnDeleteBusiness.UseVisualStyleBackColor = True
        Me.btnDeleteBusiness.Visible = False
        '
        'btnPrintBusiness
        '
        Me.btnPrintBusiness.BackgroundImage = CType(resources.GetObject("btnPrintBusiness.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintBusiness.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintBusiness.Location = New System.Drawing.Point(802, 6)
        Me.btnPrintBusiness.Name = "btnPrintBusiness"
        Me.btnPrintBusiness.Size = New System.Drawing.Size(137, 72)
        Me.btnPrintBusiness.TabIndex = 317
        Me.btnPrintBusiness.UseVisualStyleBackColor = True
        Me.btnPrintBusiness.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.btnAddBusiness)
        Me.Panel1.Controls.Add(Me.btnEditBusiness)
        Me.Panel1.Controls.Add(Me.btnDeleteBusiness)
        Me.Panel1.Controls.Add(Me.btnPrintBusiness)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 476)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 84)
        Me.Panel1.TabIndex = 429
        '
        'myimage2
        '
        Me.myimage2.BackColor = System.Drawing.Color.Lavender
        Me.myimage2.BackgroundImage = CType(resources.GetObject("myimage2.BackgroundImage"), System.Drawing.Image)
        Me.myimage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myimage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myimage2.Location = New System.Drawing.Point(10, 124)
        Me.myimage2.Name = "myimage2"
        Me.myimage2.Size = New System.Drawing.Size(198, 303)
        Me.myimage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.myimage2.TabIndex = 443
        Me.myimage2.TabStop = False
        '
        'lblPreview
        '
        Me.lblPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPreview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.Color.White
        Me.lblPreview.Location = New System.Drawing.Point(11, 430)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(197, 18)
        Me.lblPreview.TabIndex = 444
        Me.lblPreview.Text = "Preview"
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPreview.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.labelClose)
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
        Me.PictureBox2.Location = New System.Drawing.Point(442, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox2.TabIndex = 571
        Me.PictureBox2.TabStop = False
        '
        'labelClose
        '
        Me.labelClose.AutoSize = True
        Me.labelClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelClose.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClose.ForeColor = System.Drawing.Color.White
        Me.labelClose.Location = New System.Drawing.Point(916, 0)
        Me.labelClose.Name = "labelClose"
        Me.labelClose.Size = New System.Drawing.Size(35, 39)
        Me.labelClose.TabIndex = 566
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(95, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 42)
        Me.Label3.TabIndex = 569
        Me.Label3.Text = "Business Clearance"
        '
        'businessclearance
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
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.comboSearchBusiness)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2Business)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(12, 30)
        Me.Name = "businessclearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Tag = "addbusiness"
        Me.Text = "businessclearance"
        CType(Me.DataGridView2Business, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.myimage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2Business As DataGridView
    Friend WithEvents comboSearchBusiness As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnAddBusiness As Button
    Friend WithEvents btnEditBusiness As Button
    Friend WithEvents btnDeleteBusiness As Button
    Friend WithEvents btnPrintBusiness As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents myimage2 As PictureBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents labelClose As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
