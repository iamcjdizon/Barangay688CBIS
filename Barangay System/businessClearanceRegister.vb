Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class businessClearanceRegister
    Dim sqlCommandBusiness, sqlCommandLogin As String
    Dim countDigit, orStatus, resIDStatus As Integer
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Public nameUser, forDateEdit, forTimeEdit, forDate, forTime As String
    Dim conaccessBarangay As New OleDbConnection

    Private Sub hideBtn()
        businessclearance.btnEditBusiness.Hide()
        businessclearance.btnDeleteBusiness.Hide()
        businessclearance.btnPrintBusiness.Hide()
    End Sub

    Private Sub allDisabled()
        textFNameBusiness.Enabled = False
        textMNameBusiness.Enabled = False
        textLNameBusiness.Enabled = False
        suffixBusi.Enabled = False
        textCompanyName.Enabled = False
        textTradeName.Enabled = False
        textTelNoBusiness.Enabled = False
        textHNoBusi.Enabled = False
        comboStreetBusi.Enabled = False
        textAmount.Enabled = False
        textNatureBusiness.Enabled = False
        comboStatusBusiness.Enabled = False
    End Sub

    Public Sub allEnabled()
        textCompanyName.Enabled = True
        textTradeName.Enabled = True
        textTelNoBusiness.Enabled = True
        textHNoBusi.Enabled = True
        comboStreetBusi.Enabled = True
        'textAmount.Enabled = True
        textNatureBusiness.Enabled = True
        comboStatusBusiness.Enabled = True
        textFNameBusiness.Enabled = True
        textMNameBusiness.Enabled = True
        textLNameBusiness.Enabled = True
        suffixBusi.Enabled = True
    End Sub

    Public Sub clearAllBusiness()
        textOrNo.Clear()
        'textResIDBusi.Clear()
        comboStatusBusiness.ResetText()
        textFNameBusiness.Clear()
        textMNameBusiness.Clear()
        textLNameBusiness.Clear()
        suffixBusi.Clear()
        textCompanyName.Clear()
        textTradeName.Clear()
        textTelNoBusiness.Clear()
        textHNoBusi.Clear()
        comboStreetBusi.Text = String.Empty
        comboStreetBusi.SelectedIndex = -1
        textAmount.Clear()
        textNatureBusiness.Clear()
        comboStatusBusiness.SelectedIndex = -1
        comboStatusBusiness.Text = String.Empty
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

    'Error message for unfinish filling of information
    Private Function isAllOk() As Boolean
        Dim MSG As String = ""

        isAllOk = True

        If textFNameBusiness.Text = "" Then
            MSG = MSG & vbCrLf & “Enter First name”
            isAllOk = False
        End If
        If textLNameBusiness.Text = "" Then
            MSG = MSG & vbCrLf & “Enter Last Name”
            isAllOk = False
        End If
        If textMNameBusiness.Text = "" Then
            MSG = MSG & vbCrLf & “Enter Middle name”
            isAllOk = False
        End If
        If textHNoBusi.Text = "" Then
            MSG = MSG & vbCrLf & “Enter house number address”
            isAllOk = False
        End If
        If comboStreetBusi.Text = "" Then
            MSG = MSG & vbCrLf & “Enter street address”
            isAllOk = False
        End If
        If textCompanyName.Text = "" Then
            MSG = MSG & vbCrLf & “Enter company name”
            isAllOk = False
        End If
        If textTradeName.Text = "" Then
            MSG = MSG & vbCrLf & “Enter trade name”
            isAllOk = False
        End If
        If textTelNoBusiness.Text = "" Then
            MSG = MSG & vbCrLf & “Enter contact number”
            isAllOk = False
        End If
        If textNatureBusiness.Text = "" Then
            MSG = MSG & vbCrLf & “Enter nature of business”
            isAllOk = False
        End If

        If comboStatusBusiness.Text = "" Then
            MSG = MSG & vbCrLf & “Enter Status of business”
            isAllOk = False
        End If

        If Not isAllOk Then MsgBox(MSG)

    End Function

    'save button (add)
    Private Sub btnSaveBusi_Click(sender As Object, e As EventArgs) Handles btnSaveBusi.Click
        Try
            Dim singleQ As String
            Dim detailsReport As String = ""
            singleQ = checkSingleQuote(textCompanyName.Text)

            If (radioNonResident.Checked = True) Then
                checkORNo()
                detailsReport = textOrNo.Text
            End If

            If (radioResident.Checked = True) Then
                detailsReport = textResIDBusi.Text
            End If

            If (orStatus > 0) Then
                MessageBox.Show("Enter valid Official Receipt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textOrNo.Clear()
            Else
                If MsgBox("Are you sure you want To Save?", vbYesNo) = vbYes Then
                    If Me.Tag = "addbusiness" Then
                        If isAllOk() Then
                            forDate = Today
                            forTime = TimeOfDay
                            sqlCommandBusiness = "INSERT INTO businessCTBL (officialReceipt, resID, lastName, firstName, middleName, suffix, houseNo, street,
                                        barangay, zoneSitio, district, city, businessDate, businessTime, companyName, tradeName, telNo, natBus, status, amount, isArchived) 
                                        VALUES ('" & textOrNo.Text & "','" & textResIDBusi.Text & "','" & textLNameBusiness.Text & "','" & textFNameBusiness.Text & "','" & textMNameBusiness.Text &
                                        "','" & suffixBusi.Text & "','" & textHNoBusi.Text & "','" & comboStreetBusi.Text & "','Barangay 688', 'Zone 75', 'District V', 'Manila', 
                                        '" & forDate & "','" & forTime & "','" & singleQ & "','" & textTradeName.Text & "','" & textTelNoBusiness.Text &
                                        "','" & textNatureBusiness.Text & "','" & comboStatusBusiness.Text & "','" & textAmount.Text &
                                        "', '0')"
                            CNN.Execute(sqlCommandBusiness)

                            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'ADD BusinessClearance', '" & detailsReport & "')"
                            CNN.Execute(sqlCommandLogin)

                            MsgBox("Successfully Saved")

                            If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
                                With businessForm
                                    .forDate = forDate
                                    .forTime = forTime
                                    .ShowDialog()
                                End With
                                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT BusinessClearance', '" & detailsReport & "')"
                                CNN.Execute(sqlCommandLogin)
                            End If

                            businessclearance.clearAllBusiness()
                            textResIDBusi.Clear()
                            businessclearance.refreshBusi()
                            Me.Close()
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Enter valid Official Receipt Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'save edit button (edit > save)
    Private Sub btnSaveEditBusi_Click(sender As Object, e As EventArgs) Handles btnSaveEditBusi.Click
        Dim singleQ As String
        singleQ = checkSingleQuote(textCompanyName.Text)

        If MsgBox("Are you sure ", vbYesNo) = vbYes Then
                Me.Show()
            If isAllOk() Then
                If Me.Tag = "addbusiness" Then
                    sqlCommandBusiness = "Update businessCtbl 
                                SET lastName = '" & textLNameBusiness.Text & "', firstName = '" & textFNameBusiness.Text & "', middleName = '" & textMNameBusiness.Text &
                            "', suffix = '" & suffixBusi.Text & "', houseNo = '" & textHNoBusi.Text & "', street = '" & comboStreetBusi.Text &
                            "', barangay = 'Barangay 688', zoneSitio = 'Zone 75', district = 'District V', city = 'Manila', amount = '" & textAmount.Text &
                            "', companyName = '" & singleQ & "', tradeName = '" & textTradeName.Text & "', telNo = '" & textTelNoBusiness.Text &
                            "', natBus = '" & textNatureBusiness.Text & "', status = '" & comboStatusBusiness.Text &
                            "', isArchived = '0' WHERE businessDate = '" & forDateEdit & "' AND businessTime = '" & forTimeEdit & "'"
                    CNN.Execute(sqlCommandBusiness)

                    sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'EDIT BusinessClearance', '" & singleQ & "')"
                    CNN.Execute(sqlCommandLogin)
                    MsgBox("Edit Saved")

                    If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
                        With businessForm
                            .forDate = forDateEdit
                            .forTime = forTimeEdit
                            .ShowDialog()
                        End With
                        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT BrgyClearance', '" & singleQ & "')"
                        CNN.Execute(sqlCommandLogin)
                    End If

                    clearAllBusiness()
                    textResIDBusi.Clear()
                    btnSaveBusi.Hide()
                    businessclearance.btnAddBusiness.Show()
                    businessclearance.refreshBusi()
                    Me.Close()
                End If
            End If
        End If
        Me.Hide()
        businessclearance.refreshBusi()
    End Sub

    'close button
    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        home.Show()
        clearAllBusiness()
        radioNonResident.Checked = False
        radioResident.Checked = True
        countDigit = 0
        Me.Close()
        hideBtn()
    End Sub

    Private Sub textOrNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textOrNo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            textResIDBusi.Enabled = False
        Else
            e.Handled = True
        End If

    End Sub

    'resident textbox
    Private Sub textResIDBusi_TextChanged(sender As Object, e As EventArgs) Handles textResIDBusi.TextChanged
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From populationtbl where resID = '" & textResIDBusi.Text & "'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If (countDigit = 7) Then
            If dr.HasRows Then
                dr.Read()
                textFNameBusiness.Text = dr.Item("firstName")
                textMNameBusiness.Text = dr.Item("middleName")
                textLNameBusiness.Text = dr.Item("lastName")
                suffixBusi.Text = dr.Item("suffix")
                textTelNoBusiness.Text = dr.Item("telNo")
                dr.Close()

                allEnabled()
                textFNameBusiness.Enabled = 0
                textMNameBusiness.Enabled = 0
                textLNameBusiness.Enabled = 0
                suffixBusi.Enabled = 0
                textOrNo.Enabled = False
                textAmount.Enabled = False
                'Else
                '    MessageBox.Show("Not a Resident", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    textResIDBusi.Clear()
                '    allEnabled()
                '    textFNameBusiness.Enabled = 1
                '    textMNameBusiness.Enabled = 1
                '    textLNameBusiness.Enabled = 1
                '    suffixBusi.Enabled = 1
                '    textAmount.Enabled = True
                '    textOrNo.Focus()
                '    countDigit = 0
            End If
        ElseIf (countDigit = 0) Then
            textResIDBusi.Clear()
        ElseIf (countDigit < 7) Then
            clearAllBusiness()
            'allDisabled()
        End If
    End Sub

    'text resident ID keypress business
    Private Sub textResIDBusi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textResIDBusi.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            countDigit = countDigit + 1
        ElseIf e.KeyChar = Chr(8) Then
            countDigit = countDigit - 1
        Else
            countDigit = 0
        End If
    End Sub

    'Private Sub textResIDBusi_LostFocus(sender As Object, e As EventArgs) Handles textResIDBusi.LostFocus
    '    checkResID()
    '    If (resIDStatus <> 1) Then
    '        MessageBox.Show("Not a Resident of the barangay!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        textResIDBusi.Clear()
    '        textResIDBusi.Enabled = False
    '        allEnabled()
    '    Else

    '        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
    '        myConn.Open()

    '        Dim str As String
    '        str = "Select * From populationtbl where resID = '" & textResIDBusi.Text & "'"
    '        myCmd = New SqlCommand(str, myConn)
    '        Dim myAdapt = New SqlDataAdapter(myCmd)

    '        Dim dr As SqlDataReader
    '        dr = myCmd.ExecuteReader

    '        If dr.HasRows Then
    '            dr.Read()
    '            textFNameBusiness.Text = dr.Item("firstName")
    '            textMNameBusiness.Text = dr.Item("middleName")
    '            textLNameBusiness.Text = dr.Item("lastName")
    '            suffixBusi.Text = dr.Item("suffix")
    '            dr.Close()
    '            textFNameBusiness.Enabled = False
    '            textMNameBusiness.Enabled = False
    '            textLNameBusiness.Enabled = False
    '            suffixBusi.Enabled = False
    '            textOrNo.Enabled = False
    '            textAmount.Enabled = False
    '        Else

    '            businessclearance.clearAllBusiness()
    '        End If
    '    End If
    'End Sub

    Public Sub checkResID()
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * FROM populationTBL WHERE resID = '" & textResIDBusi.Text & "'"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        dscmd.Fill(ds, "populationTBL")
        'MsgBox(ds.Tables(2).Rows.Count)
        resIDStatus = ds.Tables("populationTBL").Rows.Count
        cnn.Close()
    End Sub

    Public Sub checkORNo()
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * FROM businessCTBL WHERE officialReceipt = '" & textOrNo.Text & "'"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        dscmd.Fill(ds, "businessCTBL")
        'MsgBox(ds.Tables(2).Rows.Count)
        orStatus = ds.Tables("businessCTBL").Rows.Count
        cnn.Close()
    End Sub

    Private Sub textFNameBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textFNameBusiness.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textFNameBusiness_LostFocus(sender As Object, e As EventArgs) Handles textFNameBusiness.LostFocus
        textFNameBusiness.Text = StrConv(textFNameBusiness.Text, vbProperCase)
    End Sub

    Private Sub textMNameBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMNameBusiness.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textMNameBusiness_LostFocus(sender As Object, e As EventArgs) Handles textMNameBusiness.LostFocus
        textMNameBusiness.Text = StrConv(textMNameBusiness.Text, vbProperCase)
    End Sub

    Private Sub textLNameBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLNameBusiness.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textLNameBusiness_LostFocus(sender As Object, e As EventArgs) Handles textLNameBusiness.LostFocus
        textLNameBusiness.Text = StrConv(textLNameBusiness.Text, vbProperCase)
    End Sub

    Private Sub suffixBusi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles suffixBusi.KeyPress
        e.Handled = Not (e.KeyChar = "j" Or e.KeyChar = "r" Or e.KeyChar = "s" Or e.KeyChar = "." Or e.KeyChar = "i" Or e.KeyChar = "v" Or e.KeyChar = "x" Or e.KeyChar = Chr(Keys.Space) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub textHNoBusi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textHNoBusi.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textStreetBusiness_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub radioResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioResident.CheckedChanged
        If radioResident.Checked = True Then
            clearAllBusiness()
            allEnabled()
            textResIDBusi.Enabled = True
            textOrNo.Enabled = False
            textAmount.Enabled = False
            textFNameBusiness.Enabled = 0
            textMNameBusiness.Enabled = 0
            textLNameBusiness.Enabled = 0
            suffixBusi.Enabled = 0
            textOrNo.Clear()
            textAmount.Clear()
        End If
    End Sub

    Private Sub radioNonResident_CheckedChanged(sender As Object, e As EventArgs) Handles radioNonResident.CheckedChanged
        If radioNonResident.Checked = True Then
            clearAllBusiness()
            textResIDBusi.Clear()
            textResIDBusi.Enabled = False
            textOrNo.Enabled = True
            textAmount.Enabled = True
            allEnabled()
            countDigit = 0
        End If
    End Sub

    Private Sub textCompanyName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCompanyName.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "/") Or (e.KeyChar = Chr(Keys.Space)) Or (e.KeyChar = "'") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textTradeName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textTradeName.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "/") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textTelNoBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textTelNoBusiness.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "-") Or (e.KeyChar = "/") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Or (e.KeyChar = Chr(Keys.Delete)) Or (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textFNameBusiness_TextChanged(sender As Object, e As EventArgs) Handles textFNameBusiness.TextChanged

    End Sub

    Private Sub textMNameBusiness_TextChanged(sender As Object, e As EventArgs) Handles textMNameBusiness.TextChanged

    End Sub

    Private Sub textLNameBusiness_TextChanged(sender As Object, e As EventArgs) Handles textLNameBusiness.TextChanged

    End Sub

    Private Sub textHNoBusi_TextChanged(sender As Object, e As EventArgs) Handles textHNoBusi.TextChanged

    End Sub

    Private Sub businessClearanceRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allDisabled()
    End Sub

    Private Sub textNatureBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textNatureBusiness.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "/") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textAmount.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub comboStatusBusiness_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStatusBusiness.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboStreetBusi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStreetBusi.KeyPress
        e.Handled = True
    End Sub

    Private Sub suffixBusi_LostFocus(sender As Object, e As EventArgs) Handles suffixBusi.LostFocus
        suffixBusi.Text = StrConv(suffixBusi.Text, vbUpperCase)
    End Sub

    Private Sub textResIDBusi_LostFocus(sender As Object, e As EventArgs) Handles textResIDBusi.LostFocus
        countDigit = 0
    End Sub
End Class