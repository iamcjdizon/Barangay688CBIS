Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System
Imports System.Globalization

Public Class budgetAdd
    Dim tlabor As Double
    Dim totalamt As Double
    Dim subtotal As Double
    Dim totalEI As Double = 0
    Dim sqlCommand, sqlCommandLogin, sqlCommandUpdate, sqlCommandBudget As String
    Public nameUser As String
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Dim conaccess As New OleDbConnection

    'clear all
    Public Sub clearAll()
        Estimated_Income.textIRA.Clear()
        Estimated_Income.textSurplus.Clear()
        Estimated_Income.textIRC.Clear()
        Estimated_Income.textRPT.Clear()
        Estimated_Income.textIncRPT.Clear()
        Estimated_Income.textBrgyCityAid.Clear()
        Estimated_Income.textTotalResources.Clear()
        textTotalLabor.Clear()
        textTotalMOOE.Clear()
        textTotalCapital.Clear()
        textTotal.Clear()
    End Sub

    Public Sub clearBudget()
        ' comboServices.SelectedIndex = -1
        'comboServices.Text = String.Empty
        textProjTitle.Clear()
        TextProgram.Clear()
        comboStartDate.SelectedIndex = -1
        comboStartDate.Text = String.Empty
        comboEndDate.SelectedIndex = -1
        comboEndDate.Text = String.Empty
        textExpectedOutput.Clear()
        textFundingSources.Clear()
        textLabor.Clear()
        textMOOE.Clear()
        textCapital.Clear()
        textSubtotal.Clear()
    End Sub

    'isAllOk function
    Public Function isAllOk()
        Dim msg As String = ""
        isAllOk = True
        If comboServices.Text = "" Then
            msg = "PROGRAM/PROJECT/ACTIVITY is empty."
            isAllOk = False
        End If
        If Not isAllOk Then MsgBox(msg)
    End Function

    'retrieving information from SQL and display in data grid
    Private Sub loadGrid()
        Dim access As String
        access = "select * from barangayBudget where fiscalYear = '" & textFiscalYr.Text & "'"
        Dim dataTab As New DataTable
        Dim Adpt As New OleDbDataAdapter(access, conaccess)
        Adpt.Fill(dataTab)
        DataGridView1Budget.DataSource = dataTab
    End Sub

    'load form
    Private Sub budgetAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'textFiscalYr.Text = Estimated_Income.textBudgetYr.Text
        dgvrefresh()
        total()
    End Sub

    'close button
    Private Sub labelClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'save button
    Private Sub btnSaveBudget_Click(sender As Object, e As EventArgs)
        DataGridView1Budget.DataSource = Nothing
        Me.Close()

    End Sub

    'refresh , yung total ay SUBTOTAL talaga
    Private Sub dgvrefresh()
        Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
            conn.Open()
            Dim command As New OleDbCommand("SELECT servicesProjects as 'Services / Projects', projectTitle as 'Project Title', programDescription as 'Program / Project / Activity', 
                                            startingDate AS 'Starting Date', completionDate AS 'Completion Date', 
                                             expectedOutput AS 'Expected Outputs', fundingSources AS 'Funding Sources', laborServices AS 'Labor Personal Services', 
                                            materialsMOOE AS 'Materials MOOE', capitalOutlay AS 'Capital Outaly', subtotal as 'Total' 
                                            from barangayBudget where endFiscalYear = '0'", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            DataGridView1Budget.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using

    End Sub

    Private Sub labelClose_Click_1(sender As Object, e As EventArgs) Handles labelClose.Click
        Budget.dgvrefresh()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEndFYr.Click
        Dim result As Integer = MessageBox.Show("Are you sure? Do you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If Me.Tag = "addbudget" Then
                sqlCommand = "UPDATE barangayBudgetInput set endFiscalYear = '1'"
                CNN.Execute(sqlCommand)
                sqlCommand = "UPDATE barangayBudget set endFiscalYear = '1'"
                CNN.Execute(sqlCommand)
                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'END Fiscal Year', '" & textFiscalYr.Text & "')"
                CNN.Execute(sqlCommandLogin)
                MsgBox("Archived")

                If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
                    With budgetform
                        .fiscalYear = textFiscalYr.Text
                        .ShowDialog()
                    End With
                    sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT Budget', '" & textFiscalYr.Text & "')"
                    CNN.Execute(sqlCommandLogin)
                End If

                clearAll()
                clearBudget()
                Estimated_Income.textBudgetYr.Enabled = 1
                textEI.Clear()
                dgvrefresh()
                Me.Close()
            End If

        End If


    End Sub

    'add button
    Private Sub btnAddBudget_Click_1(sender As Object, e As EventArgs) Handles btnAddBudget.Click

        If isAllOk() Then
            If MsgBox("Are you sure ", vbYesNo) = vbYes Then
                subtotals()
                If Me.Tag = "addbudget" Then
                    sqlCommand = "INSERT INTO barangayBudget (fiscalYear, endFiscalYear, servicesProjects, projectTitle, programDescription, startingDate, completionDate, 
                                    expectedOutput, fundingSources, laborServices, materialsMOOE, capitalOutlay, subtotal, currentTotal)
                                    VALUES ('" & textFiscalYr.Text & "', '0', '" & comboServices.Text & "','" & textProjTitle.Text & "','" & TextProgram.Text &
                                            "','" & comboStartDate.Text & " " & Date.Today.Year & "','" & comboEndDate.Text & " " & Date.Today.Year &
                                            "','" & textExpectedOutput.Text & "','" & textFundingSources.Text & "','" & textLabor.Text & "','" & textMOOE.Text &
                                            "','" & textCapital.Text & "','" & textSubtotal.Text & "','" & " " & "')"

                    CNN.Execute(sqlCommand)

                    dgvrefresh()
                    total()

                    sqlCommandUpdate = "Update barangayBudget
                                            SET currentTotal = '" & totalEI & "'
                                            WHERE fiscalYear = '" & textFiscalYr.Text & "' AND servicesProjects = '" & comboServices.Text & "' AND projectTitle = '" & textProjTitle.Text &
                                            "' AND programDescription = '" & TextProgram.Text & "' AND laborServices = '" & textLabor.Text & "' AND materialsMOOE = '" & textMOOE.Text &
                                            "' AND capitalOutlay = '" & textCapital.Text & "'"
                    CNN.Execute(sqlCommandUpdate)

                    sqlCommandBudget = "Update barangayBudgetInput
                                            SET currentResources = '" & totalEI & "'
                                            WHERE fiscalYear = '" & textFiscalYr.Text & "'"
                    CNN.Execute(sqlCommandBudget)

                    MsgBox("Added")
                    sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'ADD Project', '" & textProjTitle.Text & "')"
                    CNN.Execute(sqlCommandLogin)
                    clearBudget()
                End If
            End If
        End If
    End Sub

    'subtotals
    Public Sub subtotals()
        Dim mooe As Double
        Dim labor As Double
        Dim capital As Double

        labor = Val(textLabor.Text)
        mooe = Val(textMOOE.Text)
        capital = Val(textCapital.Text)
        subtotal = labor + mooe + capital
        textSubtotal.Text = Math.Round(subtotal, 2)

    End Sub

    'total
    Public Sub total()

        Dim sum As Double = 0
        Dim tsubtotal As Double = 0
        Dim tmooe As Double = 0
        Dim tcapital As Double = 0
        startBudget()
        For i As Integer = 0 To DataGridView1Budget.Rows.Count() - 1 Step +1

            sum = sum + DataGridView1Budget.Rows(i).Cells(7).Value
            tmooe = tmooe + DataGridView1Budget.Rows(i).Cells(8).Value
            tcapital = tcapital + DataGridView1Budget.Rows(i).Cells(9).Value
            tsubtotal = tsubtotal + DataGridView1Budget.Rows(i).Cells(10).Value
        Next

        textTotalLabor.Text = sum
        textTotalMOOE.Text = tmooe
        textTotalCapital.Text = tcapital
        textTotal.Text = tsubtotal

        Dim totalResources As Double = 0


        totalResources = Val(Estimated_Income.textTotalResources.Text)
        totalEI = totalResources - tsubtotal
        textEI.Text = totalEI


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Estimated_Income.textIRA.Enabled = 0
        Estimated_Income.textSurplus.Enabled = 0
        Estimated_Income.textIRC.Enabled = 0
        Estimated_Income.textRPT.Enabled = 0
        Estimated_Income.textIncRPT.Enabled = 0
        Estimated_Income.textBrgyCityAid.Enabled = 0
        Estimated_Income.textTotalResources.Enabled = 0
        Estimated_Income.btnSaveEI.Hide()
        startBudget()
        Estimated_Income.ShowDialog()
    End Sub


    'start fiscal budget
    Private Sub startBudget()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From barangayBudgetInput where fiscalYear = '" & textFiscalYr.Text & "' AND endFiscalYear = '0'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            Estimated_Income.textIRA.Text = dr.Item("increaseIRA")
            Estimated_Income.textSurplus.Text = dr.Item("unappropriateSurplus")
            Estimated_Income.textIRC.Text = dr.Item("internalRevenueCollections")
            Estimated_Income.textRPT.Text = dr.Item("realPropertyTax")
            Estimated_Income.textIncRPT.Text = dr.Item("increaseRPT")
            Estimated_Income.textBrgyCityAid.Text = dr.Item("cityAid")
            Estimated_Income.textTotalResources.Text = dr.Item("totalAvailRecources")
            dr.Close()

        End If
    End Sub


    Private Sub textLabor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLabor.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textMOOE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMOOE.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textCapital_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textCapital.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = ".") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub comboServices_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboServices.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboStartDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboStartDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub comboEndDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboEndDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub textLabor_LostFocus(sender As Object, e As EventArgs) Handles textLabor.LostFocus
        textLabor.Text = Math.Round(Val(textLabor.Text), 2)
    End Sub

    Private Sub textMOOE_LostFocus(sender As Object, e As EventArgs) Handles textMOOE.LostFocus
        textMOOE.Text = Math.Round(Val(textMOOE.Text), 2)
    End Sub

    Private Sub textCapital_LostFocus(sender As Object, e As EventArgs) Handles textCapital.LostFocus
        textCapital.Text = Math.Round(Val(textCapital.Text), 2)
    End Sub
End Class