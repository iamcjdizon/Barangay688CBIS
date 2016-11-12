
Imports System.Data.OleDb

Public Class home
    Public nameUser, sqlCommand, username, forSetting As String

    'This is used for the time and date.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelDate.Text = Today
        labelTime.Text = TimeOfDay
    End Sub

    'This is used in order to enable the timer for the date and time.
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    'This is used for the animaton.
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity = Me.Opacity + 1
        'If Me.Opacity >= 1 Then
        '    Timer2.Enabled = False
        '    Me.Opacity = 1

        'End If
    End Sub

    'This function is used to display the Residents.vb
    Private Sub ResidentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResidentsToolStripMenuItem.Click
        Residents.MdiParent = Me
        barangayclearance.Close()
        businessclearance.Close()
        complaint.Close()
        Budget.Close()
        Residents.nameUser = nameUser
        Residents.Show()
    End Sub

    'This function is used to display the barangayclearance.vb
    Private Sub BarangayClearanceToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BarangayClearanceToolStripMenuItem.Click
        barangayclearance.MdiParent = Me
        Residents.Close()
        businessclearance.Close()
        complaint.Close()
        setting.Close()
        Budget.Close()
        barangayclearance.nameUser = nameUser
        barangayclearance.Show()
    End Sub


    'This function is used to display the complaint.vb
    Private Sub ComplaintsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplaintsToolStripMenuItem.Click
        complaint.MdiParent = Me
        Residents.Close()
        barangayclearance.Close()
        businessclearance.Close()
        setting.Close()
        Budget.Close()
        complaint.nameUser = nameUser
        complaint.Show()
    End Sub

    'This function is used to display the Budget System.vb
    Private Sub BudgetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BudgetToolStripMenuItem.Click
        Budget.MdiParent = Me
        Residents.Close()
        barangayclearance.Close()
        businessclearance.Close()
        complaint.Close()
        Budget.nameUser = nameUser
        Budget.Show()
    End Sub

    'This function is used to display the setting.vb
    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        setting.MdiParent = Me
        Residents.Close()
        barangayclearance.Close()
        businessclearance.Close()
        complaint.Close()
        Budget.Close()
        setting.username = username
        setting.nameUser = nameUser
        setting.forSetting = forSetting
        setting.Show()
    End Sub

    'This function is used to display the businessclearance.vb
    Private Sub BusinessClearanceToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BusinessClearanceToolStripMenuItem.Click
        businessclearance.MdiParent = Me
        Residents.Close()
        barangayclearance.Close()
        complaint.Close()
        Budget.Close()
        setting.Close()
        businessclearance.nameUser = nameUser
        businessclearance.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        sqlCommand = "Insert Into loginLogin
                        values('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Logout', '" & nameUser & "')"
        CNN.Execute(sqlCommand)

        Form1.Show()
        Me.Close()
    End Sub

End Class