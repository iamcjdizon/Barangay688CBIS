Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ResidentRegister
    Dim sqlCommand, sqlCommandRes, sqlCommandDel, sqlCommandResDel, sqlCommandLogin, gender As String
    Public nameUser As String
    Dim conaccess As New OleDbConnection
    Dim photo As String = ""

    'Error message for unfinish filling of information
    Public Function isAllOk() As Boolean
        Dim MSG As String = ""

        isAllOk = True
        If textFName.Text = "" Then
            MSG = MSG & vbCrLf & “Enter first name”
            isAllOk = False
        End If
        If textLName.Text = "" Then
            MSG = MSG & vbCrLf & “Enter last Name”
            isAllOk = False
        End If
        If textTelNo.Text = "" Then
            MSG = MSG & vbCrLf & “Enter Telephone number”
            isAllOk = False
        End If
        If textAge.Text = "" Then
            MSG = MSG & vbCrLf & “Enter birth date”
            isAllOk = False
        End If
        If textBPlace.Text = "" Then
            MSG = MSG & vbCrLf & “Enter birth place”
            isAllOk = False
        End If
        If comboReligion.Text = "" Then
            MSG = MSG & vbCrLf & “Enter religion”
            isAllOk = False
        End If
        If textOccupation.Text = "" Then
            MSG = MSG & vbCrLf & “Enter occupation”
            isAllOk = False
        End If
        If comboCitizenship.Text = "" Then
            MSG = MSG & vbCrLf & “Enter citizenship”
            isAllOk = False
        End If
        If comboCivilStatus.Text = "" Then
            MSG = MSG & vbCrLf & “Enter civil status”
            isAllOk = False
        End If
        If radioFemale.Checked = False And radioMale.Checked = False Then
            MSG = MSG & vbCrLf & “Enter gender”
            isAllOk = False
        End If
        If comboStreet.Text = "" Then
            MSG = MSG & vbCrLf & “Enter Street”
            isAllOk = False
        End If
        If Not isAllOk Then MsgBox(MSG)
    End Function

    'clear all text
    Public Sub clearAll()
        textFName.Clear()
        textMName.Clear()
        textLName.Clear()
        suffix.Clear()
        textHNo.Clear()
        comboStreet.Text = String.Empty
        comboStreet.SelectedIndex = -1
        textAge.Clear()
        textBPlace.Clear()
        textOccupation.Clear()
        textTelNo.Clear()
        comboReligion.Text = String.Empty
        comboReligion.Text = String.Empty
        comboCitizenship.Text = String.Empty
        comboCivilStatus.Text = String.Empty
        comboReligion.SelectedIndex = -1
        comboReligion.SelectedIndex = -1
        comboCitizenship.SelectedIndex = -1
        comboCivilStatus.SelectedIndex = -1
        radioMale.Checked = 0
        radioFemale.Checked = 0
        DateTimePicker1.ResetText()
        myimage.Image = Nothing
    End Sub

    Private Sub allDisabled()
        textFName.Enabled = False
        textMName.Enabled = False
        textLName.Enabled = False
        textHNo.Enabled = False
        comboStreet.Enabled = False
        textOccupation.Enabled = False
        textBPlace.Enabled = False
        textTelNo.Enabled = False
        textAge.Enabled = False
        comboCitizenship.Enabled = False
        comboReligion.Enabled = False
        comboCivilStatus.Enabled = False
        suffix.Enabled = False
        DateTimePicker1.Enabled = False

    End Sub

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

    Private Function checkDigit(ByVal search As String)
        Dim str1, str2 As String
        Dim haba As Integer
        str2 = ""
        str1 = Trim(search)
        haba = Len(str1)

        For x = 0 To haba - 1
            If Char.IsDigit(str1(x)) Or str1 = "-" Or str1 = "+" Or str1 = "," Or str1 = "/" Then
                str2 = str2 + str1(x)
            End If
        Next x
        Return str2
    End Function

    'save button (add)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim singleQ As String
            singleQ = checkSingleQuote(textLName.Text)
            If radioMale.Checked = True Then
                gender = radioMale.Text.ToString
            Else
                gender = radioFemale.Text.ToString
            End If
            If isAllOk() Then
                If MsgBox("Are you sure you want To Save?", vbYesNo) = vbYes Then
                    If Me.Tag = "add" Then

                        sqlCommand = "Insert Into populationtbl ( resiD, lastName, firstName, middleName, suffix, 
                                    houseNo, street, age, birthplace, 
                                    religion, occupation, citizenship, civilStatus, gender, birthday, telNo, barangay, zoneSitio, district,
                                    city, province, region, photo, isArchived)
                                        VALUES ('" & textResID.Text & "','" & singleQ & "','" & textFName.Text & "','" & textMName.Text & "','" & suffix.Text &
                                                      "','" & textHNo.Text & "','" & comboStreet.Text & "','" & textAge.Text & "','" & textBPlace.Text &
                                                      "','" & comboReligion.Text & "','" & textOccupation.Text & "','" & comboCitizenship.Text &
                                                      "','" & comboCivilStatus.Text & "','" & gender & "','" & DateTimePicker1.Text & "','" & textTelNo.Text &
                                                      "', 'Barangay 688','Zone 75','District V','Manila','Metro Manila','NCR', '" & photo & "', '0')"
                        CNN.Execute(sqlCommand)

                        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'ADD Resident', '" & textResID.Text & "')"
                        CNN.Execute(sqlCommandLogin)

                        MsgBox("Successfully Saved")
                        clearAll()
                        Residents.generateAutoID(Residents.forAutoID)
                        Residents.dgvrefresh()
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        clearAll()
    End Sub

    'saving info after editting
    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Try
            Dim singleQ As String
            singleQ = checkSingleQuote(textLName.Text)
            If radioMale.Checked = True Then
                gender = radioMale.Text.ToString
            Else
                gender = radioFemale.Text.ToString
            End If
            If MsgBox("Are you sure ", vbYesNo) = vbYes Then
                Me.Show()
                If isAllOk() Then
                    If Me.Tag = "add" Then
                        sqlCommand = "Update populationtbl 
                                SET lastName = '" & singleQ & "', firstName = '" & textFName.Text & "', middleName = '" & textMName.Text & "', suffix = '" & suffix.Text &
                                    "', houseNo = '" & textHNo.Text & "', street = '" & comboStreet.Text & "', 
                                 barangay = 'Barangay 688', zoneSitio = 'Zone 71', district = 'District V', city = 'Manila',
                                 province = 'Metro Manila', region = 'NCR' , age ='" & textAge.Text &
                                    "', birthplace = '" & textBPlace.Text & "', religion = '" & comboReligion.Text &
                                    "', occupation = '" & textOccupation.Text & "', citizenship = '" & comboCitizenship.Text &
                                    "', civilStatus = '" & comboCivilStatus.Text & "', gender = '" & gender &
                                    "', birthday = '" & DateTimePicker1.Text & "', telNo = '" & textTelNo.Text & "', photo = '" & photo & "' WHERE resID = '" & textResID.Text & "';"

                        CNN.Execute(sqlCommand)
                        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'EDIT Resident', '" & textResID.Text & "')"
                        CNN.Execute(sqlCommandLogin)
                        MsgBox("Edit Saved")
                        clearAll()
                        allDisabled()
                        Me.Hide()
                        Residents.dgvrefresh()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'date to your birthday
    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker1.CloseUp
        Dim Age As Double = Math.Floor(DateDiff(DateInterval.Month, DateTimePicker1.Value, System.DateTime.Now) / 12)
        If Age < 1 Then
            MsgBox("Enter Correct Birthday")
        Else
            textAge.Text = Age
        End If
    End Sub

    'close button
    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Residents.Show()
        Residents.btnAdd.Show()
        Me.Close()
        textResID.Clear()
        clearAll()
    End Sub

    Private Sub textFName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textFName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textFName_LostFocus(sender As Object, e As EventArgs) Handles textFName.LostFocus
        textFName.Text = StrConv(textFName.Text, vbProperCase)
    End Sub

    Private Sub textMName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textMName_LostFocus(sender As Object, e As EventArgs) Handles textMName.LostFocus
        textMName.Text = StrConv(textMName.Text, vbProperCase)
    End Sub

    Private Sub textLName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) And Not (e.KeyChar = "'") Then
            e.Handled = True
        End If
    End Sub

    Private Sub textLName_LostFocus(sender As Object, e As EventArgs) Handles textLName.LostFocus
        textLName.Text = StrConv(textLName.Text, vbProperCase)
    End Sub

    Private Sub suffix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles suffix.KeyPress
        e.Handled = Not (e.KeyChar = "j" Or e.KeyChar = "J" Or e.KeyChar = "r" Or e.KeyChar = "S" Or e.KeyChar = "s" Or e.KeyChar = "i" Or e.KeyChar = "I" Or e.KeyChar = "v" Or e.KeyChar = "V" Or e.KeyChar = "x" Or e.KeyChar = "X" Or e.KeyChar = "." Or e.KeyChar = Chr(Keys.Space) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub suffix_LostFocus(sender As Object, e As EventArgs) Handles suffix.LostFocus
        suffix.Text = StrConv(suffix.Text, vbUpperCase)
    End Sub

    Private Sub textHNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textHNo.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textTelNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textTelNo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "-") Or (e.KeyChar = "/") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Or (e.KeyChar = Chr(Keys.Delete)) Or (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textOccupation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textOccupation.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub comboReligion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboReligion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub myimage_Click(sender As Object, e As EventArgs) Handles myimage.Click
        forPicture()
    End Sub

    Private Sub comboCitizenship_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboCitizenship.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        forPicture()
    End Sub

    Private Sub comboCivilStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboCivilStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub textOccupation_LostFocus(sender As Object, e As EventArgs) Handles textOccupation.LostFocus
        textOccupation.Text = StrConv(textOccupation.Text, vbProperCase)
    End Sub

    Private Sub comboStreet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStreet.KeyPress
        e.Handled = True
    End Sub

    Private Sub forPicture()
        Try
            If (Not System.IO.Directory.Exists("Resource")) Then
                System.IO.Directory.CreateDirectory("Resource")
            End If
            Dim OpenFileDialog1 As New OpenFileDialog
            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2


                If .ShowDialog = DialogResult.OK Then
                    Dim FName() As String = OpenFileDialog1.FileName.Split("\\")
                    System.IO.File.Copy(OpenFileDialog1.FileName, "Resource\\" + FName(FName.Length - 1), True) 'This command will copy the picture sa mismong application folder.
                    myimage.Image = Image.FromFile(.FileName)
                    photo = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub textTelNo_LostFocus(sender As Object, e As EventArgs) Handles textTelNo.LostFocus
        textTelNo.Text = checkDigit(textTelNo.Text)
    End Sub
End Class