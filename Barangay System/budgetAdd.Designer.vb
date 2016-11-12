<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class budgetAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(budgetAdd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textFiscalYr = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.textProjTitle = New System.Windows.Forms.TextBox()
        Me.btnEndFYr = New System.Windows.Forms.Button()
        Me.textEI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1Budget = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textTotalLabor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboEndDate = New System.Windows.Forms.ComboBox()
        Me.comboStartDate = New System.Windows.Forms.ComboBox()
        Me.comboServices = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textCapital = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textExpectedOutput = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.textMOOE = New System.Windows.Forms.TextBox()
        Me.textFundingSources = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.textLabor = New System.Windows.Forms.TextBox()
        Me.btnAddBudget = New System.Windows.Forms.Button()
        Me.textSubtotal = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextProgram = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelClose = New System.Windows.Forms.Label()
        Me.textTotal = New System.Windows.Forms.TextBox()
        Me.textTotalMOOE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textTotalCapital = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1Budget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(703, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 16)
        Me.Label7.TabIndex = 698
        Me.Label7.Text = "Current Available Resources:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'textFiscalYr
        '
        Me.textFiscalYr.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textFiscalYr.Location = New System.Drawing.Point(88, 92)
        Me.textFiscalYr.Name = "textFiscalYr"
        Me.textFiscalYr.ReadOnly = True
        Me.textFiscalYr.Size = New System.Drawing.Size(172, 27)
        Me.textFiscalYr.TabIndex = 685
        Me.textFiscalYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 697
        Me.Label16.Text = "Fiscal Year:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(115, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 16)
        Me.Label18.TabIndex = 658
        Me.Label18.Text = "Project Title:"
        '
        'textProjTitle
        '
        Me.textProjTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textProjTitle.Location = New System.Drawing.Point(197, 77)
        Me.textProjTitle.Name = "textProjTitle"
        Me.textProjTitle.Size = New System.Drawing.Size(244, 27)
        Me.textProjTitle.TabIndex = 1
        '
        'btnEndFYr
        '
        Me.btnEndFYr.BackgroundImage = CType(resources.GetObject("btnEndFYr.BackgroundImage"), System.Drawing.Image)
        Me.btnEndFYr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEndFYr.Location = New System.Drawing.Point(846, 201)
        Me.btnEndFYr.Name = "btnEndFYr"
        Me.btnEndFYr.Size = New System.Drawing.Size(181, 60)
        Me.btnEndFYr.TabIndex = 12
        Me.btnEndFYr.UseVisualStyleBackColor = True
        '
        'textEI
        '
        Me.textEI.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textEI.Location = New System.Drawing.Point(875, 91)
        Me.textEI.MaxLength = 12
        Me.textEI.Name = "textEI"
        Me.textEI.ReadOnly = True
        Me.textEI.Size = New System.Drawing.Size(172, 27)
        Me.textEI.TabIndex = 686
        Me.textEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 669)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 16)
        Me.Label4.TabIndex = 692
        Me.Label4.Text = "Total Labor Personal Servoce:"
        '
        'DataGridView1Budget
        '
        Me.DataGridView1Budget.AllowUserToAddRows = False
        Me.DataGridView1Budget.AllowUserToDeleteRows = False
        Me.DataGridView1Budget.AllowUserToResizeColumns = False
        Me.DataGridView1Budget.AllowUserToResizeRows = False
        Me.DataGridView1Budget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1Budget.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridView1Budget.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1Budget.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1Budget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1Budget.EnableHeadersVisualStyles = False
        Me.DataGridView1Budget.Location = New System.Drawing.Point(15, 436)
        Me.DataGridView1Budget.Name = "DataGridView1Budget"
        Me.DataGridView1Budget.ReadOnly = True
        Me.DataGridView1Budget.RowHeadersVisible = False
        Me.DataGridView1Budget.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1Budget.Size = New System.Drawing.Size(1039, 229)
        Me.DataGridView1Budget.TabIndex = 688
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 669)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 690
        Me.Label5.Text = "Total MOOE:"
        '
        'textTotalLabor
        '
        Me.textTotalLabor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textTotalLabor.Location = New System.Drawing.Point(18, 686)
        Me.textTotalLabor.Name = "textTotalLabor"
        Me.textTotalLabor.ReadOnly = True
        Me.textTotalLabor.Size = New System.Drawing.Size(213, 27)
        Me.textTotalLabor.TabIndex = 689
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboEndDate)
        Me.GroupBox1.Controls.Add(Me.comboStartDate)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.textProjTitle)
        Me.GroupBox1.Controls.Add(Me.btnEndFYr)
        Me.GroupBox1.Controls.Add(Me.comboServices)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.textCapital)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textExpectedOutput)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.textMOOE)
        Me.GroupBox1.Controls.Add(Me.textFundingSources)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.textLabor)
        Me.GroupBox1.Controls.Add(Me.btnAddBudget)
        Me.GroupBox1.Controls.Add(Me.textSubtotal)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TextProgram)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1039, 275)
        Me.GroupBox1.TabIndex = 684
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part B. Estimated Expenditures"
        '
        'comboEndDate
        '
        Me.comboEndDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboEndDate.FormattingEnabled = True
        Me.comboEndDate.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.comboEndDate.Location = New System.Drawing.Point(196, 199)
        Me.comboEndDate.Name = "comboEndDate"
        Me.comboEndDate.Size = New System.Drawing.Size(244, 27)
        Me.comboEndDate.TabIndex = 660
        '
        'comboStartDate
        '
        Me.comboStartDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboStartDate.FormattingEnabled = True
        Me.comboStartDate.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.comboStartDate.Location = New System.Drawing.Point(196, 163)
        Me.comboStartDate.Name = "comboStartDate"
        Me.comboStartDate.Size = New System.Drawing.Size(244, 27)
        Me.comboStartDate.TabIndex = 659
        '
        'comboServices
        '
        Me.comboServices.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboServices.FormattingEnabled = True
        Me.comboServices.Items.AddRange(New Object() {"General Public Services", "% Development Fund", "Youth Development Fund", "Barangay Disaster Risk Reduction Management Council", "Gender and Development Fund", "Barangay Council for the Protection of Children", "Elderly and Person with Disability", "Other Services / Election Expenses"})
        Me.comboServices.Location = New System.Drawing.Point(197, 42)
        Me.comboServices.Name = "comboServices"
        Me.comboServices.Size = New System.Drawing.Size(244, 27)
        Me.comboServices.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB Demi", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(559, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 18)
        Me.Label13.TabIndex = 647
        Me.Label13.Text = "Subtotal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(86, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 16)
        Me.Label10.TabIndex = 644
        Me.Label10.Text = "Completion Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(528, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 649
        Me.Label8.Text = "Funding Sources:"
        '
        'textCapital
        '
        Me.textCapital.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCapital.Location = New System.Drawing.Point(632, 149)
        Me.textCapital.MaxLength = 12
        Me.textCapital.Name = "textCapital"
        Me.textCapital.Size = New System.Drawing.Size(172, 27)
        Me.textCapital.TabIndex = 9
        Me.textCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 16)
        Me.Label6.TabIndex = 652
        Me.Label6.Text = "Services/Development Project"
        '
        'textExpectedOutput
        '
        Me.textExpectedOutput.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textExpectedOutput.Location = New System.Drawing.Point(196, 237)
        Me.textExpectedOutput.Name = "textExpectedOutput"
        Me.textExpectedOutput.Size = New System.Drawing.Size(245, 27)
        Me.textExpectedOutput.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(104, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 16)
        Me.Label14.TabIndex = 643
        Me.Label14.Text = "Starting Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 642
        Me.Label9.Text = "Expected Ouputs:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(534, 154)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 646
        Me.Label30.Text = "Capital Outlay:"
        '
        'textMOOE
        '
        Me.textMOOE.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textMOOE.Location = New System.Drawing.Point(632, 113)
        Me.textMOOE.MaxLength = 12
        Me.textMOOE.Name = "textMOOE"
        Me.textMOOE.Size = New System.Drawing.Size(172, 27)
        Me.textMOOE.TabIndex = 8
        Me.textMOOE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textFundingSources
        '
        Me.textFundingSources.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textFundingSources.Location = New System.Drawing.Point(632, 42)
        Me.textFundingSources.Name = "textFundingSources"
        Me.textFundingSources.Size = New System.Drawing.Size(172, 27)
        Me.textFundingSources.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(514, 118)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(116, 16)
        Me.Label33.TabIndex = 645
        Me.Label33.Text = "Materials (MOOE):"
        '
        'textLabor
        '
        Me.textLabor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLabor.Location = New System.Drawing.Point(632, 77)
        Me.textLabor.MaxLength = 12
        Me.textLabor.Name = "textLabor"
        Me.textLabor.Size = New System.Drawing.Size(172, 27)
        Me.textLabor.TabIndex = 7
        Me.textLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddBudget
        '
        Me.btnAddBudget.BackgroundImage = CType(resources.GetObject("btnAddBudget.BackgroundImage"), System.Drawing.Image)
        Me.btnAddBudget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddBudget.Location = New System.Drawing.Point(846, 116)
        Me.btnAddBudget.Name = "btnAddBudget"
        Me.btnAddBudget.Size = New System.Drawing.Size(181, 57)
        Me.btnAddBudget.TabIndex = 11
        Me.btnAddBudget.UseVisualStyleBackColor = True
        '
        'textSubtotal
        '
        Me.textSubtotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSubtotal.Location = New System.Drawing.Point(632, 198)
        Me.textSubtotal.MaxLength = 12
        Me.textSubtotal.Name = "textSubtotal"
        Me.textSubtotal.ReadOnly = True
        Me.textSubtotal.Size = New System.Drawing.Size(172, 27)
        Me.textSubtotal.TabIndex = 10
        Me.textSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(58, 139)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(124, 16)
        Me.Label32.TabIndex = 641
        Me.Label32.Text = "Description/Location"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(45, 122)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(149, 16)
        Me.Label31.TabIndex = 640
        Me.Label31.Text = "Program/Project/Activity"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(486, 82)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(144, 16)
        Me.Label29.TabIndex = 648
        Me.Label29.Text = "Labor Personal Services:"
        '
        'TextProgram
        '
        Me.TextProgram.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextProgram.Location = New System.Drawing.Point(197, 126)
        Me.TextProgram.Name = "TextProgram"
        Me.TextProgram.Size = New System.Drawing.Size(244, 27)
        Me.TextProgram.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(129, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 42)
        Me.Label2.TabIndex = 569
        Me.Label2.Text = "Budget System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.labelClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1073, 69)
        Me.Panel2.TabIndex = 687
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(461, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox2.TabIndex = 573
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox1.TabIndex = 572
        Me.PictureBox1.TabStop = False
        '
        'labelClose
        '
        Me.labelClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labelClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelClose.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelClose.ForeColor = System.Drawing.Color.White
        Me.labelClose.Location = New System.Drawing.Point(1035, 0)
        Me.labelClose.Name = "labelClose"
        Me.labelClose.Size = New System.Drawing.Size(35, 39)
        Me.labelClose.TabIndex = 568
        Me.labelClose.Text = "X"
        '
        'textTotal
        '
        Me.textTotal.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textTotal.Location = New System.Drawing.Point(834, 685)
        Me.textTotal.Name = "textTotal"
        Me.textTotal.ReadOnly = True
        Me.textTotal.Size = New System.Drawing.Size(213, 27)
        Me.textTotal.TabIndex = 696
        '
        'textTotalMOOE
        '
        Me.textTotalMOOE.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textTotalMOOE.Location = New System.Drawing.Point(300, 687)
        Me.textTotalMOOE.Name = "textTotalMOOE"
        Me.textTotalMOOE.ReadOnly = True
        Me.textTotalMOOE.Size = New System.Drawing.Size(213, 27)
        Me.textTotalMOOE.TabIndex = 691
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(568, 669)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 694
        Me.Label3.Text = "Total Capital Outlay:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(831, 668)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 695
        Me.Label1.Text = "Total:"
        '
        'textTotalCapital
        '
        Me.textTotalCapital.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textTotalCapital.Location = New System.Drawing.Point(571, 687)
        Me.textTotalCapital.Name = "textTotalCapital"
        Me.textTotalCapital.ReadOnly = True
        Me.textTotalCapital.Size = New System.Drawing.Size(213, 27)
        Me.textTotalCapital.TabIndex = 693
        '
        'budgetAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 718)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textFiscalYr)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.textEI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1Budget)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textTotalLabor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.textTotal)
        Me.Controls.Add(Me.textTotalMOOE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textTotalCapital)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(200, 115)
        Me.Name = "budgetAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "addbudget"
        CType(Me.DataGridView1Budget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents textFiscalYr As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents textProjTitle As TextBox
    Friend WithEvents btnEndFYr As Button
    Friend WithEvents textEI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1Budget As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents textTotalLabor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents comboServices As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textCapital As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textExpectedOutput As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents textMOOE As TextBox
    Friend WithEvents textFundingSources As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents textLabor As TextBox
    Friend WithEvents btnAddBudget As Button
    Friend WithEvents textSubtotal As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextProgram As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelClose As Label
    Friend WithEvents textTotal As TextBox
    Friend WithEvents textTotalMOOE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textTotalCapital As TextBox
    Friend WithEvents comboEndDate As ComboBox
    Friend WithEvents comboStartDate As ComboBox
End Class
