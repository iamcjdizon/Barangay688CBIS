Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class businessclearance
    Dim sqlCommandBusinessDel, sqlCommandLogin As String
    Dim conaccessbusiness As New OleDbConnection
    Public nameUser As String
    Dim forCompanyName, forTimeEdit, forDateEdit, singleQs As String

    Public Sub clearAllBusiness()
        businessClearanceRegister.textOrNo.Clear()
        businessClearanceRegister.textResIDBusi.Clear()
        businessClearanceRegister.comboStatusBusiness.ResetText()
        businessClearanceRegister.textFNameBusiness.Clear()
        businessClearanceRegister.textMNameBusiness.Clear()
        businessClearanceRegister.textLNameBusiness.Clear()
        businessClearanceRegister.suffixBusi.Clear()
        businessClearanceRegister.textCompanyName.Clear()
        businessClearanceRegister.textTradeName.Clear()
        businessClearanceRegister.textTelNoBusiness.Clear()
        businessClearanceRegister.textHNoBusi.Clear()
        businessClearanceRegister.comboStreetBusi.Text = String.Empty
        businessClearanceRegister.comboStreetBusi.SelectedIndex = -1
        businessClearanceRegister.textAmount.Clear()
        businessClearanceRegister.textNatureBusiness.Clear()
        businessClearanceRegister.comboStatusBusiness.SelectedIndex = -1
        businessClearanceRegister.comboStatusBusiness.Text = String.Empty
    End Sub

    Public Sub allEnabled()
        businessClearanceRegister.textCompanyName.Enabled = True
        businessClearanceRegister.textTradeName.Enabled = True
        businessClearanceRegister.textTelNoBusiness.Enabled = True
        businessClearanceRegister.textHNoBusi.Enabled = True
        businessClearanceRegister.comboStreetBusi.Enabled = True
        businessClearanceRegister.textAmount.Enabled = True
        businessClearanceRegister.textNatureBusiness.Enabled = True
        businessClearanceRegister.comboStatusBusiness.Enabled = True
        businessClearanceRegister.textFNameBusiness.Enabled = True
        businessClearanceRegister.textMNameBusiness.Enabled = True
        businessClearanceRegister.textLNameBusiness.Enabled = True
        businessClearanceRegister.suffixBusi.Enabled = True
    End Sub

    Public Sub allDisabled()
        businessClearanceRegister.textFNameBusiness.Enabled = False
        businessClearanceRegister.textMNameBusiness.Enabled = False
        businessClearanceRegister.textLNameBusiness.Enabled = False
        businessClearanceRegister.suffixBusi.Enabled = False
        businessClearanceRegister.textCompanyName.Enabled = False
        businessClearanceRegister.textTradeName.Enabled = False
        businessClearanceRegister.textTelNoBusiness.Enabled = False
        businessClearanceRegister.textHNoBusi.Enabled = False
        businessClearanceRegister.comboStreetBusi.Enabled = False
        businessClearanceRegister.textAmount.Enabled = False
        businessClearanceRegister.textNatureBusiness.Enabled = False
        businessClearanceRegister.comboStatusBusiness.Enabled = False
    End Sub

    'this is to check the textbox if it has an aphostrophe.
    Private Function checkSingleQuote(ByVal search As String)
        Dim str1, str2 As String
        Dim haba As Integer
        str2 = ""
        str1 = Trim(search)
        haba = Len(str1)

        For x = 0 To haba - 1
            If str1(x) = "'" Then
                str2 = str2 + "' + char(39) + '"
            Else
                str2 = str2 + str1(x)
            End If
        Next x
        Return str2
    End Function

    'connecting to SQL
    Private Sub businessclearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2Business.EditMode = False
        Dim CS As String = "Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;"
        conaccessbusiness.ConnectionString = CS
        conaccessbusiness.Open()
        refreshBusi()
    End Sub

    'retrieving information from SQL and display in data grid
    Private Sub loadGridBusiness()
        Dim access As String
        Try
            access = "select * from businessCTBL"
            Dim dataTab As New DataTable
            Dim Adpt As New OleDbDataAdapter(access, conaccessbusiness)
            Adpt.Fill(dataTab)
            DataGridView2Business.DataSource = dataTab
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'register button (add)
    Private Sub btnAddBusiness_Click(sender As Object, e As EventArgs) Handles btnAddBusiness.Click
        allDisabled()
        clearAllBusiness()
        businessClearanceRegister.textOrNo.Clear()
        businessClearanceRegister.btnSaveEditBusi.Hide()
        businessClearanceRegister.btnSaveBusi.Show()
        businessClearanceRegister.btnSaveBusi.Focus()
        businessClearanceRegister.radioResident.Enabled = True
        businessClearanceRegister.radioNonResident.Enabled = True
        With businessClearanceRegister
            .nameUser = nameUser
            .ShowDialog()
        End With
    End Sub

    'edit button
    Private Sub btnEditBusiness_Click(sender As Object, e As EventArgs) Handles btnEditBusiness.Click
        allEnabled()
        editBusi()
        businessClearanceRegister.textResIDBusi.Enabled = False
        businessClearanceRegister.textOrNo.Enabled = False
        businessClearanceRegister.btnSaveBusi.Hide()
        businessClearanceRegister.btnSaveEditBusi.Show()
        businessClearanceRegister.DateTimePicker1Busi.Enabled = False
        businessClearanceRegister.radioResident.Enabled = False
        businessClearanceRegister.radioNonResident.Enabled = False
        With businessClearanceRegister
            .nameUser = nameUser
            .forTimeEdit = forTimeEdit
            .forDateEdit = forDateEdit
            .ShowDialog()
        End With
    End Sub

    Private Function editBusi() As Integer
        Dim i As Integer
        i = DataGridView2Business.CurrentRow.Index
        businessClearanceRegister.textOrNo.Text = DataGridView2Business.Item(0, i).Value
        businessClearanceRegister.textResIDBusi.Text = DataGridView2Business.Item(1, i).Value
        businessClearanceRegister.textLNameBusiness.Text = DataGridView2Business.Item(2, i).Value
        businessClearanceRegister.textFNameBusiness.Text = DataGridView2Business.Item(3, i).Value
        businessClearanceRegister.textMNameBusiness.Text = DataGridView2Business.Item(4, i).Value
        businessClearanceRegister.suffixBusi.Text = DataGridView2Business.Item(5, i).Value
        businessClearanceRegister.textHNoBusi.Text = DataGridView2Business.Item(8, i).Value
        businessClearanceRegister.comboStreetBusi.Text = DataGridView2Business.Item(9, i).Value
        businessClearanceRegister.textCompanyName.Text = DataGridView2Business.Item(10, i).Value
        businessClearanceRegister.textTradeName.Text = DataGridView2Business.Item(6, i).Value
        businessClearanceRegister.textTelNoBusiness.Text = DataGridView2Business.Item(7, i).Value
        businessClearanceRegister.textNatureBusiness.Text = DataGridView2Business.Item(11, i).Value
        businessClearanceRegister.comboStatusBusiness.Text = DataGridView2Business.Item(12, i).Value
        businessClearanceRegister.textAmount.Text = DataGridView2Business.Item(13, i).Value
        Return i
    End Function

    'delete button
    Private Sub btnDeleteBusiness_Click(sender As Object, e As EventArgs) Handles btnDeleteBusiness.Click
        Try
            If MsgBox("Are you sure you want to Delete this Information?", vbYesNo) = vbYes Then
                Me.Show()
                Dim i As Integer
                i = DataGridView2Business.CurrentRow.Index
                sqlCommandBusinessDel = "Update businessCTBL
                                SET isArchived = '1'
                            where businessDate = '" & forDateEdit & "' AND businessTime = '" & forTimeEdit & "'"
                CNN.Execute(sqlCommandBusinessDel)

                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Delete Business Clearance', '" & singleQs & "')"
                CNN.Execute(sqlCommandLogin)
                MsgBox("Delete Successful")
                refreshBusi()
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'displaying the information from the data grid to the textbox and combobox
    Private Sub DataGridView2Business_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2Business.CellClick
        btnEditBusiness.Show()
        btnDeleteBusiness.Show()
        btnPrintBusiness.Show()
        lblPreview.Show()
        Dim i As Integer
        i = DataGridView2Business.CurrentRow.Index
        Try
            forDateEdit = DataGridView2Business.Item(14, i).Value
            forTimeEdit = DataGridView2Business.Item(15, i).Value
            forCompanyName = DataGridView2Business.Item(10, i).Value
            singleQs = checkSingleQuote(forCompanyName)
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    'refresh function
    Public Sub refreshBusi()
        Try
            Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
                conn.Open()
                Dim command As New OleDbCommand("Select officialReceipt [Official Receipt], resID [Resident ID], lastName [Last Name],
                                            firstName [First Name], middleName [Middle Name], suffix [Suffix], tradeName [Trade Name],
                                            telNo [Mobile Number], houseNo [House Number], street [Street], companyName [Company Name],
                                            natBus [Nature of Business], status [Status], amount [Amount],
                                            businessDate [Date Issued], businessTime [Time Issued] 
                                            From businessCTBL where isArchived = '0'", conn)
                Dim adapter As New OleDbDataAdapter
                Dim dt As New DataTable
                adapter.SelectCommand = command
                adapter.Fill(dt)
                DataGridView2Business.DataSource = dt
                adapter.Dispose()
                command.Dispose()
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'when search textbox clicked all will be cleared and disabled
    Private Sub textSearch_Click(sender As Object, e As EventArgs)
        btnPrintBusiness.Hide()
        btnEditBusiness.Hide()
        btnDeleteBusiness.Hide()
        clearAllBusiness()
        businessClearanceRegister.textResIDBusi.Clear()
    End Sub

    Private Sub textOrNo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso
        Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub textFNameBusiness_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textMNameBusiness_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textLNameBusiness_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsSeparator(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub textHNoBusiness_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso
        Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub comboSearchBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboSearchBusiness.KeyPress
        Try
            Dim singleQ As String
            singleQ = checkSingleQuote(comboSearchBusiness.Text)
            If e.KeyChar = Chr(13) Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim cmd4 As New SqlCommand("Select officialReceipt [Official Receipt], resID [Resident ID], lastName [Last Name],
                                            firstName [First Name], middleName [Middle Name], suffix [Suffix], tradeName [Trade Name],
                                            telNo [Mobile Number], houseNo [House Number], street [Street], companyName [Company Name],
                                            natBus [Nature of Business], status [Status], amount [Amount],
                                            businessDate [Date Issued], businessTime [Time Issued] from businessCtbl where isArchived = '0' AND (officialReceipt Like @search OR resID like @search OR lastName Like @search
                                        OR firstName Like @search OR middleName Like @search OR tradeName like @search OR companyName like @search
                                        OR suffix Like @search OR telNo Like @search OR houseNo Like @search
                                        OR street Like @search OR natBus Like @search OR status like @search OR
                                        amount like @search OR businessDate like @search OR businessTime like @search)", con)
                cmd4.Parameters.Add(New SqlClient.SqlParameter("search", singleQ)) 'This is to prevent sql injection
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "businessCTBL")) Then
                    refreshBusi()
                    DataGridView2Business.DataSource = ds4.Tables(0)
                    MessageBox.Show("Match Found", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub comboStatusBusiness_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    'print function business
    Private Function getinfo() As Integer
        Dim i As Integer
        i = DataGridView2Business.CurrentRow.Index
        businessformpreview.permitlastname.Text = DataGridView2Business.Item(2, i).Value
        businessformpreview.permitfirstname.Text = DataGridView2Business.Item(3, i).Value
        businessformpreview.permitmiddlename.Text = DataGridView2Business.Item(4, i).Value
        businessformpreview.permitsuffix.Text = DataGridView2Business.Item(5, i).Value
        businessformpreview.textHNo.Text = DataGridView2Business.Item(8, i).Value
        businessformpreview.textStreet.Text = DataGridView2Business.Item(9, i).Value
        businessformpreview.date1.Text = DataGridView2Business.Item(14, i).Value
        businessformpreview.companyNameBusi.Text = DataGridView2Business.Item(10, i).Value
        businessformpreview.tradeName.Text = DataGridView2Business.Item(6, i).Value
        Return i
    End Function

    'print preview business
    Private Sub lblPreview_Click(sender As Object, e As EventArgs) Handles lblPreview.Click
        getinfo()
        businessformpreview.ShowDialog()
    End Sub

    Private Sub btnPrintBusiness_Click(sender As Object, e As EventArgs) Handles btnPrintBusiness.Click
        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
            With businessForm
                .forDate = forDateEdit
                .forTime = forTimeEdit
                .ShowDialog()
            End With
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT Business Clearance', '" & singleQs & "')"
            CNN.Execute(sqlCommandLogin)
        End If
    End Sub

    Private Sub comboSearchBusiness_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSearchBusiness.SelectedIndexChanged
        Try
            If comboSearchBusiness.SelectedIndex = 0 Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim cmd4 As New SqlCommand("Select officialReceipt [Official Receipt], resID [Resident ID], lastName [Last Name],
                                            firstName [First Name], middleName [Middle Name], suffix [Suffix], tradeName [Trade Name],
                                            telNo [Mobile Number], houseNo [House Number], street [Street], companyName [Company Name],
                                            natBus [Nature of Business], status [Status], amount [Amount],
                                            businessDate [Date Issued], businessTime [Time Issued] from businessCTBL where isArchived ='0'", con)
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "businessCTBL")) Then
                    refreshBusi()
                    DataGridView2Business.DataSource = ds4.Tables(0)
                    MessageBox.Show("All Applicants", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Close()
    End Sub
End Class