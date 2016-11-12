Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class setting
    Inherits System.Windows.Forms.Form
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim sqlCommand, userPassword, sqlCommandLogin, sqlCommandUpdate, termStart, sqlString As String
    Public username, nameUser, forSetting As String
    Dim account, budget, setting As Integer

    Private Sub boDisabled()
        textBrgyChairman.Enabled = False
        textSecretary.Enabled = False
        textTreasurer.Enabled = False
        textCouncilorAppro.Enabled = False
        textCouncilorWAM.Enabled = False
        textCouncilorHAS.Enabled = False
        textCouncilorRAE.Enabled = False
        textCouncilorPAO.Enabled = False
        textCouncilorCAG.Enabled = False
        textCouncilorVAWC.Enabled = False
    End Sub

    Private Sub boEnabled()
        textBrgyChairman.Enabled = True
        textSecretary.Enabled = True
        textTreasurer.Enabled = True
        textCouncilorAppro.Enabled = True
        textCouncilorWAM.Enabled = True
        textCouncilorHAS.Enabled = True
        textCouncilorRAE.Enabled = True
        textCouncilorPAO.Enabled = True
        textCouncilorCAG.Enabled = True
        textCouncilorVAWC.Enabled = True
    End Sub

    Private Sub boClear()
        textBrgyChairman.Clear()
        textSecretary.Clear()
        textTreasurer.Clear()
        textCouncilorAppro.Clear()
        textCouncilorWAM.Clear()
        textCouncilorHAS.Clear()
        textCouncilorRAE.Clear()
        textCouncilorPAO.Clear()
        textCouncilorCAG.Clear()
        textCouncilorVAWC.Clear()
    End Sub

    'This is to check if the string has single quote
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

    'This function is used to check if the inputted password is correct or not.
    Private Function passValid(ByVal name As String) As Boolean
        Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim cmd As New SqlCommand("Select * FROM logintbl WHERE username = '" & username & "' and password = HASHBYTES ('Sha1', '" & textOldPassword.Text & "')", con)
        Dim Adpt As New SqlDataAdapter(cmd)
        con.Open()

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            Return True
        End If
        Return False
    End Function

    Private Function checkAccount(ByVal uname As String) As Boolean
        Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim cmd As New SqlCommand("Select * From logintbl where username = '" & uname & "'", con)
        Dim Adpt As New SqlDataAdapter(cmd)
        con.Open()
        Dim status As String
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader

        If dr.HasRows Then

            dr.Read()
            status = dr.Item("userStatus")
            dr.Close()
            If status = "Blocked" Then
                Return True
            End If

        End If
        Return False
    End Function

    'This function is to check if the text boxes are null.
    Private Function isAllOk() As Boolean
        Dim MSG As String = ""

        isAllOk = True
        If textNewPassword.Text = "" Or textOldPassword.Text = "" Or textConfirmPassword.Text = "" Then
            MSG = "Enter necessary Information "
            isAllOk = False
        End If

        If passValid(username) = False Then
            MSG = "Old password did not match."
            isAllOk = False
        End If

        If textNewPassword.Text <> textConfirmPassword.Text Then
            MSG = "Passwords did not match"
            isAllOk = False
        End If

        If Not isAllOk Then MsgBox(MSG)
    End Function


    'This function is to check if the text boxes are null.
    Private Function isAllOk3() As Boolean
        Dim MSG As String = ""

        isAllOk3 = True
        If textUsernameClear.Text = "" Then
            MSG = "Enter username"
            isAllOk3 = False
        ElseIf checkAccount(textUsernameClear.Text) = False Then
            MSG = "Account is not blocked!"
            isAllOk3 = False
        End If

        If Not isAllOk3 Then MsgBox(MSG)
    End Function

    Private Function isAllOk4() As Boolean
        Dim MSG As String = ""

        isAllOk4 = True
        If textBrgyChairman.Text = "" Then
            MSG = MSG & vbCrLf & "Enter new barangay chariman's name"
            isAllOk4 = False
        End If

        If textSecretary.Text = "" Then
            MSG = MSG & vbCrLf & "Enter new secretary's name "
            isAllOk4 = False
        End If

        If textTreasurer.Text = "" Then
            MSG = MSG & vbCrLf & "Enter new treasurer's name"
            isAllOk4 = False
        End If

        If textCouncilorAppro.Text = "" Or textCouncilorCAG.Text = "" Or textCouncilorHAS.Text = "" Or textCouncilorPAO.Text = "" Or textCouncilorRAE.Text = "" Or textCouncilorVAWC.Text = "" Or textCouncilorWAM.Text = "" Then
            MSG = MSG & vbCrLf & "Enter councilor's name"
            isAllOk4 = False
        End If

        If Not isAllOk4 Then MsgBox(MSG)
    End Function


    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()
        forLogs()
        If forSetting = 0 Then
            TabControl1.TabPages.Remove(TabPage3)
            TabControl1.TabPages.Remove(TabPage4)
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage5)
        End If

        forBrgyOffice()
        boDisabled()
        forAccountSetting()
        forComboAccount(username)
    End Sub

    'This function is used to close the form.
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        home.Show()
        Me.Close()
    End Sub

    'This function is triggered when the Save button in the Change Password is clicked.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isAllOk() Then
            sqlCommand = "Update logintbl 
                                Set password = HASHBYTES('Sha1', '" & textNewPassword.Text & "')
                                Where username = '" & username & "'"
            CNN.Execute(sqlCommand)
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Change Password', '" & nameUser & "')"
            CNN.Execute(sqlCommandLogin)
            MsgBox("Successfully Saved")
            textOldPassword.Clear()
            textNewPassword.Clear()
            textConfirmPassword.Clear()
            Me.Close()
            home.Show()
        End If
    End Sub

    'This function is triggered when the Save button in the Clear Account is clicked.
    Private Sub btnSaveClear_Click(sender As Object, e As EventArgs) Handles btnSaveClear.Click
        If isAllOk3() Then
            sqlCommand = "Update logintbl 
                                Set password = HASHBYTES('Sha1', '1234'), userStatus = 'Pending'
                                Where username = '" & textUsernameClear.Text & "'"
            CNN.Execute(sqlCommand)
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Clear Account', '" & textUsernameClear.Text & "')"
            CNN.Execute(sqlCommandLogin)
            MsgBox("Account Successfully Cleared")
            textUsernameClear.Clear()
            home.Show()
            Me.Close()
        End If
    End Sub

    'This will close the form.
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        home.Show()
        Me.Close()
    End Sub

    'This will close the form.
    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        home.Show()
        Me.Close()
    End Sub

    'This function is triggered when the Save button in the Change Password is clicked.
    Private Sub textConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textConfirmPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If isAllOk() Then
                sqlCommand = "Update logintbl 
                                Set password = HASHBYTES('Sha1', '" & textNewPassword.Text & "')
                                Where username = '" & username & "'"
                CNN.Execute(sqlCommand)
                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Change Password', '" & nameUser & "')"
                CNN.Execute(sqlCommandLogin)
                MsgBox("Account Successfully Updated")
                Me.Close()
                home.Show()
            End If
        End If
    End Sub

    'This function is triggered when the Save button in the Change Account is clicked.
    'Private Sub textConfirmClear_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    '    If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    '    If e.KeyChar = Chr(13) Then
    '        If isAllOk3() Then
    '            sqlCommand = "Update logintbl 
    '                            Set password = HASHBYTES('Sha1', '" & textConfirmClear.Text & "'), username = '" & textUsernameClear.Text & "',
    '                            userStatus = 'Cleared'
    '                            Where username = '" & textUsernameClear.Text & "'"
    '            CNN.Execute(sqlCommand)

    '            MsgBox("Account Cleared.")
    '            Me.Close()
    '            home.Show()
    '        End If
    '    End If
    'End Sub

    'This function is triggered when the Save button in the Change Password is clicked.
    Private Sub textOldPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textOldPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'This is used for validation purposes.
    Private Sub textNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'This is used for validation purposes.
    Private Sub textUsername_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'This is used for validation purposes.
    Private Sub textPassword_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'This is used for validation purposes.
    Private Sub textconfirmadd_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'This is used for validation purposes.
    Private Sub textName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub bOEndTerm_Click(sender As Object, e As EventArgs) Handles bOEndTerm.Click
        If MsgBox("Is it the end of the term?", vbYesNo) = vbYes Then
            sqlCommand = "Update barangayOfficials 
                                Set termEnd = '" & dtpTermEnd.Text & "'
                                Where termStart = '" & termStart & "'"
            CNN.Execute(sqlCommand)
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'End Term for Barangay', '" & nameUser & "')"
            CNN.Execute(sqlCommandLogin)

            MsgBox("Successfully Saved")
            btnSaveBO.Visible = True
            bOEndTerm.Visible = False
            labelTermEnd.Visible = False
            boEnabled()
            dtpTermEnd.Visible = False
            btnCloseBO.Visible = False
            TabControl1.TabPages.Remove(TabPage3)
            TabControl1.TabPages.Remove(TabPage1)
            TabControl1.TabPages.Remove(TabPage4)
        End If
    End Sub

    Private Sub btnSaveBO_Click(sender As Object, e As EventArgs) Handles btnSaveBO.Click
        If isAllOk4() Then
            If MsgBox("Are the entries correct?", vbYesNo) = vbYes Then
                sqlCommand = "insert into barangayOfficials
                        values ('" & Today & " " & TimeOfDay & "', '', '" & textBrgyChairman.Text & "', '" & textSecretary.Text & "', 
                        '" & textTreasurer.Text & "', '" & textCouncilorAppro.Text & "', '" & textCouncilorWAM.Text & "',
                        '" & textCouncilorHAS.Text & "', '" & textCouncilorRAE.Text & "', '" & textCouncilorPAO.Text & "',
                        '" & textCouncilorCAG.Text & "', '" & textCouncilorVAWC.Text & "')"
                CNN.Execute(sqlCommand)
                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Start Term for Barangay', '" & nameUser & "')"
                CNN.Execute(sqlCommandLogin)
                sqlCommandUpdate = "Update loginTbl
                                    Set password = HASHBYTES('Sha1', '1234'), userStatus = 'Pending'
                                    WHERE username = 'chairman' or username = 'secretary' or username = 'treasurer'"
                CNN.Execute(sqlCommandUpdate)
                MsgBox("Successfully Saved." & vbCrLf & "All accounts have been reset into default password")
                boDisabled()
                btnSaveBO.Visible = False
                bOEndTerm.Visible = True
                labelTermEnd.Visible = True
                dtpTermEnd.Visible = True
                btnCloseBO.Visible = True
                TabControl1.TabPages.Add(TabPage3)
                TabControl1.TabPages.Add(TabPage1)
                TabControl1.TabPages.Add(TabPage4)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCloseBO_Click(sender As Object, e As EventArgs) Handles btnCloseBO.Click
        Me.Close()
    End Sub

    'This is used for validation purposes.
    Private Sub textUsernameClear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textUsernameClear.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    'This is used for validation purposes.
    Private Sub textNewPasswordClear_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnSaveAccountSetting_Click(sender As Object, e As EventArgs) Handles btnSaveAccountSetting.Click
        Dim account, budget, setting As Integer
        account = 0
        budget = 0
        setting = 0
        If checkApp.Checked = True Then
            account = 1
        End If

        If checkBudget.Checked = True Then
            budget = 1
        End If

        If checkSettings.Checked = True Then
            setting = 1
        End If

        sqlCommand = "Update logintbl 
                                Set enabledApplication = '" & account & "', enabledBudget = '" & budget & "', enabledSetting = '" & setting & "'
                                Where username = '" & comboAccount.Text & "'"
        CNN.Execute(sqlCommand)
        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Changed Account Setting', '" & comboAccount.Text & "')"
        CNN.Execute(sqlCommandLogin)

        MsgBox("Successfully Saved")
        Me.Close()
    End Sub

    Private Sub forBrgyOffice()
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * From barangayOfficials Order by autoID desc"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        dscmd.Fill(ds, "barangayOfficials")
        termStart = CStr(ds.Tables("barangayOfficials").Rows(0).Item(0))
        textBrgyChairman.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(2))
        textSecretary.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(3))
        textTreasurer.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(4))
        textCouncilorAppro.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(5))
        textCouncilorWAM.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(6))
        textCouncilorHAS.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(7))
        textCouncilorRAE.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(8))
        textCouncilorPAO.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(9))
        textCouncilorCAG.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(10))
        textCouncilorVAWC.Text = CStr(ds.Tables("barangayOfficials").Rows(0).Item(11))
        cnn.Close()

    End Sub

    Private Sub forAccountSetting()
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * From logintbl Order by username asc"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        dscmd.Fill(ds, "loginTbl")
        comboAccount.DataSource = ds.Tables("logintbl")
        comboAccount.ValueMember = "username"
        comboAccount.DisplayMember = "username"
        cnn.Close()

    End Sub

    Private Sub forComboAccount(ByVal users As String)

        Dim str As String
        Dim account, budget As Integer

        str = "Select * From logintbl where username = '" & users & "'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader


        If dr.HasRows Then

            dr.Read()
            account = dr.Item("enabledApplication")
            budget = dr.Item("enabledBudget")
            setting = dr.Item("enabledSetting")
            dr.Close() 'treasurer = 9 secretary = 9, chairman = 9

            If account = 1 Then
                checkApp.Checked = True
            Else
                checkApp.Checked = False
            End If


            If budget = 1 Then
                checkBudget.Checked = True
            Else
                checkBudget.Checked = False
            End If


            If setting = 1 Then
                checkSettings.Checked = True
            Else
                checkSettings.Checked = False
            End If

        End If
        dr.Close()
    End Sub

    Private Sub comboAccount_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboAccount.SelectedValueChanged
        forComboAccount(comboAccount.Text)
    End Sub

    Private Sub comboName_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub forLogs()
        Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
            conn.Open()
            Dim command As New OleDbCommand("Select userName [Username], dateRecord [Date], timeRecord [Time],
                                 details [Details], recordDetails [Record Details] from loginLogin order by Date desc, Time desc", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            dgvLogs.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    Private Sub comboAccount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboAccount.KeyPress
        e.Handled = True
    End Sub

    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Close()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub textBrgyChairman_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBrgyChairman.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub


    Private Sub textTreasurer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textTreasurer.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorAppro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorAppro.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorWAM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorWAM.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorHAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorHAS.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorRAE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorRAE.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorPAO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorPAO.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorCAG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorCAG.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textCouncilorVAWC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCouncilorVAWC.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub logsSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles logsSearch.KeyPress
        Dim singleQ As String
        singleQ = checkSingleQuote(logsSearch.Text)
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(13) Or e.KeyChar = "'" Then
                e.Handled = False
                If e.KeyChar = Chr(13) Then
                    Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                    Dim con As New SqlConnection(str)
                    sqlString = "Select userName [Username], dateRecord [Date], timeRecord [Time],
                                 details [Details], recordDetails [Record Details]
                                from loginlogin where userName like '%" & singleQ & "%' OR dateRecord Like '%" & singleQ & "%'
                                         OR details Like '%" & singleQ & "%' OR recordDetails Like '%" & singleQ & "%' OR timeRecord Like '%" & singleQ & "%'"
                    Dim cmd4 As New SqlCommand(sqlString, con)
                    Dim Adpt4 As New SqlDataAdapter(cmd4)
                    Dim ds4 As New DataSet()
                    If (Adpt4.Fill(ds4, "populationtbl")) Then
                        forLogs()
                        dgvLogs.DataSource = ds4.Tables(0)
                        MessageBox.Show("Match Found", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class