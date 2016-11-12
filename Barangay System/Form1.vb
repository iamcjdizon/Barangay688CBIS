Imports System.Data.SqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results, nameUser, userStatus As String
    Private account, budget, setting As Integer
    Dim attempt As Integer = 0

    'This function is used for blocking SQL Injection.
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

    'This will connect the Database to the System.
    Private Sub DBConnect()
        Dim CS As String
        CS = "Server=CIRJON;Driver={SQL Server};uid=;pwd=;database=Barangay688DB;"
        CNN.ConnectionString = CS
        CNN.Open()
    End Sub

    'This function is triggered the the Login Button was clicked.
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If validation(textUsername.Text) = False And validation(textPassword.Text) = False Then
            login()
        Else
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        textUsername.Focus()
        Me.CenterToScreen()
        DBConnect()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()
    End Sub

    'This function will be triggered when the enter button is pressed
    Private Sub textPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPassword.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            If e.KeyChar = Chr(13) Then
                If validation(textUsername.Text) = False And validation(textPassword.Text) = False Then
                    login()
                Else
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    textUsername.Text = ""
                    textPassword.Text = ""
                    textUsername.Focus()
                End If
            End If
        Else
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    'This function is called when the button function is clicked and there are no validation failures.
    Private Sub login()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.Open()
        If textUsername.Text = "" Or textPassword.Text = "" Then
            MessageBox.Show("Enter username or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textUsername.Focus()
        ElseIf loginValid(textUsername.Text) = 0 Then
            MessageBox.Show("Please contact admin to reset your password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textUsername.Focus()
        ElseIf loginValid(textUsername.Text) = 3 Then
            MessageBox.Show("No account record!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textUsername.Focus()

        Else
            Dim str, sqlCommand As String
            str = "Select * FROM logintbl WHERE username = '" & textUsername.Text & "' and password = HASHBYTES ('Sha1', '" & textPassword.Text & "')"
            myCmd = New SqlCommand(str, myConn)
            Dim myAdapt = New SqlDataAdapter(myCmd)
            Dim datTable = New DataTable()
            myAdapt.Fill(datTable)

            If (datTable.Rows.Count = 0) Then
                If attempt < 2 Then
                    MessageBox.Show("Login Failed", "Invalid Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    textUsername.Text = ""
                    textPassword.Text = ""
                    textUsername.Focus()
                    attempt = attempt + 1
                ElseIf (loginValid(textUsername.Text) = 2) Then
                    MessageBox.Show("Account has been reset. Please check admin for default passowrd", "Invalid Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If nameUser.ToLower <> "admin" Then
                        If userStatus = "Cleared" Then
                            sqlCommand = "Update logintbl
                                        SET userStatus = 'Blocked'
                                        WHERE username = '" & textUsername.Text & "'"
                            CNN.Execute(sqlCommand)
                            MsgBox("You have three attempts. Please contact admin to reset your password!")
                            'ElseIf userStatus = "Pending" Then
                            '    MessageBox.Show("No Accounts found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            '    textUsername.Focus()
                            '    Else
                            '        MessageBox.Show("No Accounts found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MsgBox("You have three attempts.")
                        Me.Close()
                    End If

                End If
            Else
                If loginValid(textUsername.Text) = 1 Then
                    attempt = 0
                    sqlCommand = "Insert Into loginLogin
                              values ('" & nameUser & "' , '" & Today & "', '" & TimeOfDay & "', 'login', '" & nameUser & "')"
                    CNN.Execute(sqlCommand)
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
                    textUsername.Focus()
                    home.forSetting = setting
                    home.Show()
                    Me.Hide()

                ElseIf loginValid(textUsername.Text) = 2 Then
                    textUsername.Focus()
                    Form2.username = textUsername.Text
                    Form2.setting = setting
                    Form2.account = account
                    Form2.budget = budget
                    Form2.nameUser = nameUser
                    Form2.Show()
                    Me.Hide()
                End If

            End If
        End If

        textUsername.Text = ""
        textPassword.Text = ""

    End Sub

    Private Sub textUsername_TextChanged(sender As Object, e As EventArgs) Handles textUsername.TextChanged

    End Sub

    Private Sub pbexit_Click(sender As Object, e As EventArgs) Handles pbexit.Click
        Me.Close()
    End Sub


    'This function is used fr the animation.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 1

        'If Me.Opacity >= 1 Then
        '    Timer1.Enabled = False
        '    Me.Opacity = 1

        'End If
    End Sub

    'This function is used for validations/
    Private Sub textUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textUsername.KeyPress
        If Char.IsControl(e.KeyChar) OrElse Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("INVALID")
            e.Handled = True
        End If
    End Sub

    'This function is called in order to determine if an account is available for login.
    Private Function loginValid(ByVal name As String) As Integer
        Dim str As String
        str = "Select * From logintbl where username = '" & name & "'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)


        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader
        Try
            If dr.HasRows Then

                dr.Read()
                userStatus = dr.Item("userStatus")
                nameUser = dr.Item("nameUser")
                account = dr.Item("enabledApplication")
                budget = dr.Item("enabledBudget")
                setting = dr.Item("enabledSetting")
                'MsgBox(account & vbCrLf & budget)
                dr.Close()
                If nameUser.ToLower = "admin" Then

                    Return 1
                Else
                    If userStatus = "Cleared" Then
                        Return 1
                    ElseIf userStatus = "Blocked" Then
                        Return 0
                    ElseIf userStatus = "Pending" Then
                        Return 2
                    End If
                End If
            End If
            dr.Close()
        Catch ex As Exception

        End Try
        Return 3

    End Function

End Class
