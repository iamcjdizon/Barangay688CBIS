Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ComplaintRegister
    Dim sqlCommandComplaint, sqlCommandLogin As String
    Public nameUser, isEdit, refID As String
    Dim conaccessComplaint As New OleDbConnection
    Dim complainant As Integer = 0
    Dim defendant As Integer = 0

    'clear all text
    Public Sub clearAllComplaint()
        textFNameComplaint.Clear()
        textMNameComplaint.Clear()
        textLNameComplaint.Clear()
        suffixComplaint.Clear()
        textHNoComplaint.Clear()
        textStreetComplaint.Clear()
        textBrgyComplaint.Clear()
        textCityComplaint.Clear()
        textTelNoComplaint.Clear()
        textAgeComplaint.Clear()
        radioComplainant.Checked = False
        radioDefendant.Checked = False
    End Sub

    Public Sub clearComplaint()
        textPlaceOfIncident.Clear()
        textStatus.Clear()
        richConcern.Clear()
        richRemarks.Clear()
    End Sub

    'Error message for unfinish filling of information
    Private Function isAllOk() As Boolean
        Dim MSG As String = ""

        isAllOk = True
        If textFNameComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter first name”
            isAllOk = False
        End If
        If textMNameComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter middle name”
            isAllOk = False
        End If
        If textLNameComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter last name”
            isAllOk = False
        End If
        If textHNoComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter house number address”
            isAllOk = False
        End If
        If textStreetComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter street address”
            isAllOk = False
        End If
        If textBrgyComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter barangay address”
            isAllOk = False
        End If
        If textCityComplaint.Text = "" Then
            MSG = MSG & vbCrLf & “Enter city address”
            isAllOk = False
        End If

        If radioComplainant.Checked = False And radioDefendant.Checked = False Then
            MSG = MSG & vbCrLf & "Select defendant or Complainant"
            isAllOk = False
        End If

        If Not isAllOk Then MsgBox(MSG)

    End Function

    Function isAllOk2() As Boolean
        Dim MSG As String = ""
        isAllOk2 = True
        If textPlaceOfIncident.Text = "" Then
            MSG = MSG & vbCrLf & “Enter place of incident”
            isAllOk2 = False
        End If

        If richConcern.Text = "" Then
            MSG = MSG & vbCrLf & “Enter your concern”
            isAllOk2 = False
        End If

        If richRemarks.Text = "" Then
            MSG = MSG & vbCrLf & “Enter your remarks”
            isAllOk2 = False
        End If

        If Not isAllOk2 Then MsgBox(MSG)
    End Function

    'add button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim person As String = ""
        If radioComplainant.Checked = True Then
            person = radioComplainant.Text
            complainant = complainant + 1
        ElseIf radioDefendant.Checked = True Then
            person = radioDefendant.Text
            defendant = defendant + 1
        End If

        Try
            If MsgBox("Are you sure you want to Save?", vbYesNo) = vbYes Then
                Me.Show()
                If isAllOk() Then
                    If Me.Tag = "addcomplaint" Then
                        sqlCommandComplaint = "INSERT INTO complaintTypeTBL 
                                           VALUES ('" & textCaseNo.Text & "','" & person & "','" & textLNameComplaint.Text & "','" & textFNameComplaint.Text &
                                               "', '" & textMNameComplaint.Text & "','" & suffixComplaint.Text & "','" & textAgeComplaint.Text & "', '" & textTelNoComplaint.Text &
                                               "', '" & textHNoComplaint.Text & "', '" & textStreetComplaint.Text & "', '" & textBrgyComplaint.Text & "', '" & textCityComplaint.Text & "')"
                        CNN.Execute(sqlCommandComplaint)



                        MsgBox("Successfully Saved")
                        refreshDataGrid()
                        clearAllComplaint()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'save button
    Private Sub btnSaveComplaint_Click_1(sender As Object, e As EventArgs) Handles btnSaveComplaint.Click
        Try
            If MsgBox("Are you sure you want to Save?", vbYesNo) = vbYes Then
                Me.Show()
                If isAllOk2() Then
                    If complainant > 0 And defendant > 0 Then
                        'MsgBox(complainant & vbCrLf & defendant)
                        If Me.Tag = "addcomplaint" Then
                            sqlCommandComplaint = "INSERT INTO complaintTBL 
                                           VALUES ('" & textCaseNo.Text & "','" & DateTimePicker1Complaint.Text & "','" & textPlaceOfIncident.Text &
                                                   "', '" & textStatus.Text & "','" & richConcern.Text & "','" & richRemarks.Text & "', '0')"
                            CNN.Execute(sqlCommandComplaint)

                            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'ADD Blotter', '" & textCaseNo.Text & "')"
                            CNN.Execute(sqlCommandLogin)

                            MsgBox("Successfully Saved")
                            clearComplaint()
                            clearAllComplaint()
                            complaint.refreshComplaint()
                            Me.Close()
                        End If
                    ElseIf complainant < 1 Then
                        MsgBox("Please enter complaint")

                    ElseIf defendant < 1 Then
                        MsgBox("Please enter defendant")

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'edit save button (edit > save)
    Private Sub btnSaveEditComplaint_Click_1(sender As Object, e As EventArgs) Handles btnSaveEditComplaint.Click
        If MsgBox("Are you sure ", vbYesNo) = vbYes Then
            Me.Show()
            If isAllOk2() Then
                If Me.Tag = "addcomplaint" Then
                    sqlCommandComplaint = "Update complaintTBL
                                            SET placeOfIncident = '" & textPlaceOfIncident.Text & "', complaintConcern = '" & richConcern.Text & "', 
                                            status = '" & textStatus.Text & "', remarks = '" & richRemarks.Text & "' WHERE caseNo = '" & textCaseNo.Text & "'"
                    CNN.Execute(sqlCommandComplaint)

                    sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'EDIT Blotter', '" & textCaseNo.Text & "')"
                    CNN.Execute(sqlCommandLogin)
                    MsgBox("Edit Saved")
                    complaint.refreshComplaint()
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub refreshDataGrid()
        Try
            Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
                conn.Open()

                Dim command As New OleDbCommand("SELECT complainantDefendant [Person Type], firstName [First Name],
                                            middleName [Middle Name], lastName [Last Name], suffix [Suffix],
                                            age [Age], telNo [Contact Number], houseNo [House Number], street [Street],
                                            barangay [Barangay], city [City], autoID [Count] FROM complaintTypeTBL where caseNo = '" & textCaseNo.Text & "'", conn)
                Dim adapter As New OleDbDataAdapter
                Dim dt As New DataTable
                adapter.SelectCommand = command
                adapter.Fill(dt)
                dgvCVType.DataSource = dt
                adapter.Dispose()
                command.Dispose()
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub textCaseNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCaseNo.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textPlaceOfIncident_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPlaceOfIncident.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textFNameComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textFNameComplaint.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textFNameComplainant_LostFocus(sender As Object, e As EventArgs) Handles textFNameComplaint.LostFocus
        textFNameComplaint.Text = StrConv(textFNameComplaint.Text, vbProperCase)
    End Sub

    Private Sub textMNameComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMNameComplaint.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textMNameComplainant_LostFocus(sender As Object, e As EventArgs) Handles textMNameComplaint.LostFocus
        textMNameComplaint.Text = StrConv(textMNameComplaint.Text, vbProperCase)
    End Sub

    Private Sub textLNameComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLNameComplaint.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textLNameComplainant_LostFocus(sender As Object, e As EventArgs) Handles textLNameComplaint.LostFocus
        textLNameComplaint.Text = StrConv(textLNameComplaint.Text, vbProperCase)
    End Sub

    Private Sub suffixComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles suffixComplaint.KeyPress
        e.Handled = Not (e.KeyChar = "j" Or e.KeyChar = "r" Or e.KeyChar = "s" Or e.KeyChar = "." Or e.KeyChar = "i" Or e.KeyChar = "v" Or e.KeyChar = "x" Or e.KeyChar = Chr(Keys.Space) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub suffixComplainant_LostFocus(sender As Object, e As EventArgs) Handles suffixComplaint.LostFocus
        suffixComplaint.Text = StrConv(suffixComplaint.Text, vbUpperCase)
    End Sub

    Private Sub textHNoComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textHNoComplaint.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textStreetComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textStreetComplaint.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textStreetComplainant_LostFocus(sender As Object, e As EventArgs) Handles textStreetComplaint.LostFocus
        textStreetComplaint.Text = StrConv(textStreetComplaint.Text, vbProperCase)
    End Sub

    Private Sub textBrgyComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBrgyComplaint.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textBrgyComplainant_LostFocus(sender As Object, e As EventArgs) Handles textBrgyComplaint.LostFocus
        textBrgyComplaint.Text = StrConv(textBrgyComplaint.Text, vbProperCase)
    End Sub

    Private Sub textCityComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCityComplaint.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textCityComplainant_LostFocus(sender As Object, e As EventArgs) Handles textCityComplaint.LostFocus
        textCityComplaint.Text = StrConv(textCityComplaint.Text, vbProperCase)
    End Sub

    Private Sub textTelNoComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textTelNoComplaint.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "-") Or (e.KeyChar = "/") Or (e.KeyChar = ",") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textAgeComplainant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textAgeComplaint.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        If isEdit <> "1" Then
            sqlCommandComplaint = "Delete complaintTypeTBL
                               where caseNo = '" & textCaseNo.Text & "'"
            CNN.Execute(sqlCommandComplaint)
        End If
        clearAllComplaint()
        clearComplaint()
        Me.Close()
        complaint.Show()
    End Sub

    Private Sub ComplaintRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDataGrid()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearAllComplaint()
        btnSaveType.Visible = False
        btnAdd.Visible = True

    End Sub

    'Edit button of Complaints
    Private Sub btnSaveType_Click(sender As Object, e As EventArgs) Handles btnSaveType.Click
        Dim person As String = ""
        If radioComplainant.Checked = True Then
            person = radioComplainant.Text
            complainant = complainant + 1
        ElseIf radioDefendant.Checked = True Then
            person = radioDefendant.Text
            defendant = defendant + 1
        End If

        Try
            If MsgBox("Are you sure you want to Save?", vbYesNo) = vbYes Then
                Me.Show()
                If isAllOk() Then
                    If Me.Tag = "addcomplaint" Then
                        sqlCommandComplaint = "Update ComplaintTypeTbl
                                           Set complainantDefendant =  '" & person & "', lastName = '" & textLNameComplaint.Text & "', firstName = '" & textFNameComplaint.Text &
                                               "', middleName = '" & textMNameComplaint.Text & "', suffix = '" & suffixComplaint.Text & "', age = '" & textAgeComplaint.Text & "',
                                               telNo = '" & textTelNoComplaint.Text & "', houseNo = '" & textHNoComplaint.Text & "', street = '" & textStreetComplaint.Text & "',
                                               barangay = '" & textBrgyComplaint.Text & "', city = '" & textCityComplaint.Text & "' 
                                               WHERE caseNo = '" & textCaseNo.Text & "' AND autoID = '" & refID & "'"
                        CNN.Execute(sqlCommandComplaint)

                        MsgBox("Successfully Saved")
                        refreshDataGrid()
                        clearAllComplaint()
                        btnSaveType.Visible = False
                        btnAdd.Visible = True
                        complaint.refreshComplaint()
                    End If
                End If
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error message")
        End Try
    End Sub

    Private Sub dgvCVType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCVType.CellClick
        Try
            Dim i As Integer
            i = dgvCVType.CurrentRow.Index
            textFNameComplaint.Text = dgvCVType.Item(1, i).Value
            textMNameComplaint.Text = dgvCVType.Item(2, i).Value
            textLNameComplaint.Text = dgvCVType.Item(3, i).Value
            suffixComplaint.Text = dgvCVType.Item(4, i).Value
            textHNoComplaint.Text = dgvCVType.Item(7, i).Value
            textStreetComplaint.Text = dgvCVType.Item(8, i).Value
            textBrgyComplaint.Text = dgvCVType.Item(9, i).Value
            textCityComplaint.Text = dgvCVType.Item(10, i).Value
            textTelNoComplaint.Text = dgvCVType.Item(6, i).Value
            textAgeComplaint.Text = dgvCVType.Item(5, i).Value
            If radioComplainant.Text = dgvCVType.Item(0, i).Value Then
                radioComplainant.Checked = True
            ElseIf radioDefendant.Text = dgvCVType.Item(0, i).Value Then
                radioDefendant.Checked = True
            End If
            refID = dgvCVType.Item(11, i).Value
        Catch ex As Exception
            MsgBox("Ërror")
        End Try
        btnSaveType.Visible = True
        btnAdd.Visible = False
    End Sub

End Class