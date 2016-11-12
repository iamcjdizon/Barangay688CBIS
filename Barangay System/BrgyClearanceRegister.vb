Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class BrgyClearanceRegister
    Dim sqlCommandBarangayC, sqlCommandBarangayCDel, sqlCommandLogin As String
    Dim countDigit, resIDStatus As Integer
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Public nameUser, forDateEdit, forTimeEdit, forDate, forTime As String
    Dim conaccessBarangay As New OleDbConnection

    'hide buttons
    Private Sub hideBtn()
        barangayclearance.btnEditBar.Hide()
        barangayclearance.btnPrintBar.Hide()
        barangayclearance.btnDeleteBar.Hide()
    End Sub

    'enable all textbox
    Private Sub allEnabled()
        textResIDBar.Enabled = 1
        textFNameBar.Enabled = 1
        textMNameBar.Enabled = 1
        textLNameBar.Enabled = 1
        suffixBar.Enabled = 1
        textHnoBar.Enabled = 1
        comboStreetBar.Enabled = 1
        textTelNoBar.Enabled = 1
        textPurposeBar.Enabled = 1
    End Sub

    'disable all textbox
    Private Sub allDisabeld()
        textFNameBar.Enabled = 0
        textMNameBar.Enabled = 0
        textLNameBar.Enabled = 0
        suffixBar.Enabled = 0
        textHnoBar.Enabled = 0
        comboStreetBar.Enabled = 0
        textTelNoBar.Enabled = 0
        textPurposeBar.Enabled = 0
    End Sub

    'Error message for unfinish filling of information
    Public Function isAllOkBar() As Boolean
        Dim MSG As String = ""

        isAllOkBar = True
        If textResIDBar.Text = "" Then
            MSG = MSG & vbCrLf & “Enter resident ID”
            isAllOkBar = False
        End If
        If textTelNoBar.Text = "" Then
            MSG = MSG & vbCrLf & “Enter contact number”
            isAllOkBar = False
        End If
        If textPurposeBar.Text = "" Then
            MSG = MSG & vbCrLf & “Enter the purpose”
            isAllOkBar = False
        End If

        If textFNameBar.Text = "" Then
            MSG = MSG & vbCrLf & "Not a Resident!"
            isAllOkBar = False
        End If

        If Not isAllOkBar Then MsgBox(MSG)
    End Function

    'when this form appears it will call the ff functions
    Private Sub BrgyClearanceRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideBtn()
        DateTimePicker1Barc.Enabled = 0
    End Sub

    'close button
    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Hide()
        hideBtn()
        barangayclearance.clearAllBar()
        textResIDBar.Clear()
        barangayclearance.Show()
        barangayclearance.btnRegisterBar.Show()
        barangayclearance.refreshBrgy()
    End Sub

    'save button (adding) information
    Private Sub btnSaveAddBar_Click(sender As Object, e As EventArgs) Handles btnSaveBar.Click
        Try
            If isAllOkBar() Then
                If MsgBox("Are you sure you want To Save?", vbYesNo) = vbYes Then
                    If Me.Tag = "addbarangay" Then
                        forDate = Today
                        forTime = TimeOfDay
                        sqlCommandBarangayC = "INSERT INTO barangayCTBL (resID, lastName, firstName, middleName, suffix, houseNo, street,
                                            barangay, zoneSitio, district, city, barangayDate, barangayTime, telNo, purpose, isArchived)
                                        VALUES ('" & textResIDBar.Text & "','" & textLNameBar.Text & "','" & textFNameBar.Text &
                                            "','" & textMNameBar.Text & "','" & suffixBar.Text & "','" & textHnoBar.Text & "','" & comboStreetBar.Text &
                                            "','Barangay 688', 'Zone 75', 'District V', 'Manila', '" & forDate & "','" & forTime &
                                            "','" & textTelNoBar.Text & "','" & textPurposeBar.Text &
                                            "', '0')"

                        CNN.Execute(sqlCommandBarangayC)
                        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'ADD BrgyClearance', '" & textResIDBar.Text & "')"
                        CNN.Execute(sqlCommandLogin)
                        MsgBox("Successfully Saved")

                        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
                            With brgyclearanceform
                                .resID = textResIDBar.Text
                                .forDate = forDate
                                .forTime = forTime
                                .ShowDialog()
                            End With
                            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT BrgyClearance', '" & textResIDBar.Text & "')"
                            CNN.Execute(sqlCommandLogin)
                        End If

                        barangayclearance.clearAllBar()
                        textResIDBar.Clear()
                        btnSaveEditBar.Hide()
                        barangayclearance.refreshBrgy()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'edit save button (edit > save)
    Private Sub btnSaveEditBar_Click(sender As Object, e As EventArgs) Handles btnSaveEditBar.Click
        Try
            If MsgBox("Are you sure ", vbYesNo) = vbYes Then
                Me.Show()
                If isAllOkBar() Then
                    If Me.Tag = "addbarangay" Then
                        sqlCommandBarangayC = "Update barangayCTBL 
                                SET lastName = '" & textLNameBar.Text & "', firstName = '" & textFNameBar.Text & "', middleName = '" & textMNameBar.Text &
                                "', houseNo = '" & textHnoBar.Text & "', street = '" & comboStreetBar.Text &
                                "', barangay = 'Barangay 688', zoneSitio = 'Zone 75', district = 'District V', city = 'Manila'
                                , telNo = '" & textTelNoBar.Text &
                                "', purpose = '" & textPurposeBar.Text & "' WHERE resID = '" & textResIDBar.Text & "'"

                        CNN.Execute(sqlCommandBarangayC)
                        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'EDIT BrgyClearance', '" & textResIDBar.Text & "')"
                        CNN.Execute(sqlCommandLogin)
                        MsgBox("Edit Saved")

                        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
                            With brgyclearanceform
                                .resID = textResIDBar.Text
                                .forDate = forDateEdit
                                .forTime = forTimeEdit
                                .ShowDialog()
                            End With
                            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT BrgyClearance', '" & textResIDBar.Text & "')"
                            CNN.Execute(sqlCommandLogin)
                        End If

                        barangayclearance.clearAllBar()
                        textResIDBar.Clear()
                        btnSaveBar.Hide()
                        barangayclearance.btnRegisterBar.Show()
                        barangayclearance.refreshBrgy()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    'check resID function brgy
    Public Sub checkResIDbar()
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * FROM populationtbl WHERE resID = '" & textResIDBar.Text & "'"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        dscmd.Fill(ds, "populationtbl")
        'MsgBox(ds.Tables(2).Rows.Count)
        resIDStatus = ds.Tables("populationtbl").Rows.Count
        cnn.Close()
    End Sub

    Private Sub textResIDBar_TextChanged(sender As Object, e As EventArgs) Handles textResIDBar.TextChanged
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()
        Try
            Dim str As String
            str = "Select * From populationtbl where resID = '" & textResIDBar.Text & "'"
            myCmd = New SqlCommand(str, myConn)
            Dim myAdapt = New SqlDataAdapter(myCmd)

            Dim dr As SqlDataReader
            dr = myCmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                textFNameBar.Text = dr.Item("firstName")
                textMNameBar.Text = dr.Item("middleName")
                textLNameBar.Text = dr.Item("lastName")
                suffixBar.Text = dr.Item("suffix")
                textHnoBar.Text = dr.Item("houseNo")
                comboStreetBar.Text = dr.Item("street")
                textTelNoBar.Text = dr.Item("telNo")
                dr.Close()
            Else
                If (countDigit = 7) Then
                    MsgBox("Not a resident")
                ElseIf (countDigit = 0) Then
                    textResIDBar.Clear()
                End If
                barangayclearance.clearAllBar()
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub textResIDBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textResIDBar.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            countDigit = countDigit + 1
        ElseIf e.KeyChar = Chr(8) Then
            countDigit = countDigit - 1
        Else
            countDigit = 0
        End If
    End Sub

    Private Sub textTelNoBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textTelNoBar.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "-") Or (e.KeyChar = "/") Or (e.KeyChar = ",") Or (e.KeyChar = Chr(Keys.Space)) Or (e.KeyChar = Chr(Keys.Delete)) Or (e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textPurposeBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPurposeBar.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class