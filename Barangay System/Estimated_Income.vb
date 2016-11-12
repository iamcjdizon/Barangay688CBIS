Imports System
Imports System.Globalization
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Estimated_Income
    Dim sqlCommand, sqlCommandLogin As String
    Dim conaccess As New OleDbConnection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Public nameUser As String

    Public Function isAllOk() As Boolean
        Dim MSG As String = ""

        isAllOk = True
        If textBudgetYr.Text = "" Then
            MSG = MSG & vbCrLf & “Enter Fiscal Year.”
            isAllOk = False
        End If

        If checkCurrentYear() = True Then
            MSG = MSG & vbCrLf & “Fiscal Year already exist!”
            isAllOk = False
        End If

        If Not isAllOk Then MsgBox(MSG)
    End Function

    Private Function checkCurrentYear()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From barangayBudgetInput where fiscalYear = '" & textBudgetYr.Text & "'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If dr.HasRows Then
            Return True
        End If

        Return False
    End Function

    Public Sub totalResources()
        Dim ira As Double
        Dim surplus As Double
        Dim irc As Double
        Dim rpt As Double
        Dim incRpt As Double
        Dim brgyCA As Double
        Dim totalIncome As Double
        ira = Val(textIRA.Text)
        surplus = Val(textSurplus.Text)
        irc = Val(textIRC.Text)
        rpt = Val(textRPT.Text)
        incRpt = Val(textIncRPT.Text)
        brgyCA = Val(textBrgyCityAid.Text)

        totalIncome = ira + surplus + irc + rpt + incRpt + brgyCA
        textTotalResources.Text = totalIncome
        budgetAdd.textEI.Text = totalIncome

    End Sub

    Private Sub btnSaveEI_Click(sender As Object, e As EventArgs) Handles btnSaveEI.Click
        If isAllOk() Then
            Dim result As Integer = MessageBox.Show("Are all entries correct? Do you want to proceed?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                textIRA.Enabled = 0
                textSurplus.Enabled = 0
                textIRC.Enabled = 0
                textRPT.Enabled = 0
                textBrgyCityAid.Enabled = 0
                textIncRPT.Enabled = 0
                textTotalResources.Enabled = 0
                textBudgetYr.Enabled = 0
                totalResources()
                Try
                    If Me.Tag = "fiscalyr" Then

                        sqlCommand = "INSERT INTO barangayBudgetInput (fiscalYear, endFiscalYear, beginBalance, increaseIRA, unappropriateSurplus, internalRevenueCollections, 
                                    realPropertyTax, increaseRPT, cityAid, totalAvailRecources, currentResources)
                                    VALUES ('" & textBudgetYr.Text & "','" & "0" & "','" & "       " & "','" & Val(textIRA.Text) & "','" & Val(textSurplus.Text) &
                                                    "','" & Val(textIRC.Text) & "','" & Val(textRPT.Text) & "','" & Val(textIncRPT.Text) & "','" & Val(textBrgyCityAid.Text) &
                                                    "','" & textTotalResources.Text & "','" & Val(budgetAdd.textEI.Text) & "')"
                        CNN.Execute(sqlCommand)
                        MsgBox("saved")

                        sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Entered Fiscal Year', '" & textBudgetYr.Text & "')"
                        CNN.Execute(sqlCommandLogin)
                    End If
                Catch
                    MessageBox.Show("There is already an Estimated Income for " & textBudgetYr.Text & ".", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
                    Me.Close()
                    textBudgetYr.Enabled = 1
                End Try
            End If
        End If
    End Sub

    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Close()
    End Sub

    Private Sub textIRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textIRA.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textSurplus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textSurplus.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textIRC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textIRC.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textBrgyCityAid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBrgyCityAid.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textRPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textRPT.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textIncRPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textIncRPT.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textBudgetYr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBudgetYr.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class