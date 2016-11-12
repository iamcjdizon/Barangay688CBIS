Imports System.Data.SqlClient

Public Class Form2
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim sqlCommand, userPassword, sqlCommandLogin, sqlCommandUpdate As String
    Public username, nameUser As String
    Public account, budget, setting As Integer


    Private Function validation(ByVal toEval As String) As Boolean
        Dim str1 As String
        Dim haba As Integer

        str1 = Trim(toEval)
        haba = Len(str1)

        For x = 0 To haba - 1
            If Char.IsDigit(str1(x)) OrElse Char.IsControl(str1(x)) OrElse Char.IsLetter(str1(x)) Then
                Return False
            Else
                Return True
            End If
        Next x
        Return False

    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function isAllOk() As Boolean
        Dim MSG As String = ""

        isAllOk = True
        If textNewPassword.Text = "" Or textConfirmPassword.Text = "" Then
            MSG = "Enter necessary Information "
            isAllOk = False
        End If

        If textNewPassword.Text <> textConfirmPassword.Text Then
            MSG = "Passwords did not match!"
            isAllOk = False
        End If

        If Not isAllOk Then MsgBox(MSG)
    End Function

    Private Sub login()
        If isAllOk() = True Then
            sqlCommand = "Update logintbl 
                                Set password = HASHBYTES('Sha1', '" & textNewPassword.Text & "'), userStatus = 'Cleared'
                                Where username = '" & textUsername.Text & "'"
            CNN.Execute(sqlCommand)
            sqlCommandLogin = "Insert Into loginLogin
                              values ('" & nameUser & "' , '" & Today & "', '" & TimeOfDay & "', 'login', '" & nameUser & "')"
            CNN.Execute(sqlCommandLogin)
            MsgBox("Successfully Saved")
            Me.Close()
            home.nameUser = nameUser
            home.username = textUsername.Text
            If account = 0 Then
                home.ResidentsToolStripMenuItem.Visible = False
                home.ApplicatinsToolStripMenuItem.Visible = False
            End If

            If budget = 0 Then
                home.BudgetToolStripMenuItem.Visible = False
            End If

            home.labelWelcome.Text = "Welcome " & nameUser & "!"

            home.Show()
        End If
    End Sub

    Private Sub pbexit_Click(sender As Object, e As EventArgs) Handles pbexit.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        login()
        textUsername.Focus()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()
        MsgBox("Account has been reset. Please change your password.")
        textUsername.Text = username
        textUsername.Focus()
    End Sub

    Private Sub textConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textConfirmPassword.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            If e.KeyChar = Chr(13) Then
                If validation(textUsername.Text) = False And validation(textNewPassword.Text) = False And validation(textConfirmPassword.Text) = False Then
                    login()
                    textUsername.Focus()
                Else
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    textUsername.Text = ""
                    textNewPassword.Text = ""
                    textUsername.Focus()
                End If
            End If
        Else
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub textNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textNewPassword.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("INVALID")
            e.Handled = True
        End If
    End Sub
End Class