Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Budget
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Public nameUser As String
    Dim conaccess As New OleDbConnection
    Dim sqlCommandLogin As String

    Private Function checkCurrentYear()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From barangayBudgetInput where endFiscalYear = '0'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If dr.HasRows Then
            Return True
        End If

        Return False
    End Function

    Private Sub getInfo()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From barangayBudgetInput where endFiscalYear = '0'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            budgetAdd.clearAll()
            budgetAdd.textFiscalYr.Text = dr.Item("fiscalYear")
            Estimated_Income.textBudgetYr.Text = dr.Item("fiscalYear")
            Estimated_Income.textIRA.Text = dr.Item("increaseIRA")
            Estimated_Income.textSurplus.Text = dr.Item("unappropriateSurplus")
            Estimated_Income.textIRC.Text = dr.Item("internalRevenueCollections")
            Estimated_Income.textBrgyCityAid.Text = dr.Item("cityAid")
            Estimated_Income.textRPT.Text = dr.Item("realPropertyTax")
            Estimated_Income.textIncRPT.Text = dr.Item("increaseRPT")
            Estimated_Income.textTotalResources.Text = dr.Item("totalAvailRecources")
            budgetAdd.textEI.Text = dr.Item("currentResources")
            dr.Close()

            budgetAdd.DataGridView1Budget.DataSource = Nothing
        End If
    End Sub

    Public Sub dgvrefresh()
        Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
            conn.Open()
            Dim command As New OleDbCommand("SELECT servicesProjects as 'Services / Projects', projectTitle as 'Project Title', programDescription as 'Program / Project / Activity', startingDate AS 'Starting Date', completionDate AS 'Completion Date', 
                                             expectedOutput AS 'Expected Outputs', fundingSources AS 'Funding Sources', laborServices AS 'Labor Personal Services', materialsMOOE AS 'Materials MOOE', capitalOutlay AS 'Capital Outaly', subtotal as 'Total' 
                                            from barangayBudget where endFiscalYear = '0'", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            DataGridView2.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using

    End Sub

    Private Sub forYear()
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * From barangayBudgetInput Order by fiscalYear desc"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        dscmd.Fill(ds, "barangayBudgetInput")
        comboSearchBudget.DataSource = ds.Tables("barangayBudgetInput")
        comboSearchBudget.ValueMember = "fiscalYear"
        comboSearchBudget.DisplayMember = "fiscalYear"
        cnn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnPrint.Hide()
        If checkCurrentYear() = False Then
            Dim result As Integer = MessageBox.Show("No active Fiscal Year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Me.Show()
            Else

            End If
        Else
            getInfo()
            budgetAdd.nameUser = nameUser
            budgetAdd.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkCurrentYear() = False Then
            'budgetAdd.textFiscalYr.Text = Date.Today.Year
            Estimated_Income.btnSaveEI.Show()
            Estimated_Income.textIRA.Enabled = 1
            Estimated_Income.textSurplus.Enabled = 1
            Estimated_Income.textIRC.Enabled = 1
            Estimated_Income.textRPT.Enabled = 1
            Estimated_Income.textIncRPT.Enabled = 1
            Estimated_Income.textBrgyCityAid.Enabled = 1
            Estimated_Income.textTotalResources.Enabled = 1
            Estimated_Income.textIRA.Clear()
            Estimated_Income.textSurplus.Clear()
            Estimated_Income.textIRC.Clear()
            Estimated_Income.textRPT.Clear()
            Estimated_Income.textIncRPT.Clear()
            Estimated_Income.textBrgyCityAid.Clear()
            Estimated_Income.textTotalResources.Clear()
            Estimated_Income.nameUser = nameUser
            Estimated_Income.ShowDialog()
            btnPrint.Hide()
        Else
            Estimated_Income.textIRA.Enabled = False
            Estimated_Income.textSurplus.Enabled = False
            Estimated_Income.textIRC.Enabled = False
            Estimated_Income.textRPT.Enabled = False
            Estimated_Income.textIncRPT.Enabled = False
            Estimated_Income.textBrgyCityAid.Enabled = False
            Estimated_Income.textTotalResources.Enabled = False
            Estimated_Income.textBudgetYr.Enabled = False
            Estimated_Income.btnSaveEI.Enabled = False
            getInfo()
            Estimated_Income.ShowDialog()
        End If

    End Sub

    Private Sub Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forYear()
        comboSearchBudget.Text = "--Select--"
        dgvrefresh()
        btnPrint.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub comboSearchBudget_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSearchBudget.SelectedIndexChanged
        Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim sql As String
        sql = "Select servicesProjects As 'Services / Projects', projectTitle as 'Project Title', programDescription as 'Program / Project / Activity', 
                                            startingDate AS 'Starting Date', completionDate AS 'Completion Date', 
                                             expectedOutput AS 'Expected Outputs', fundingSources AS 'Funding Sources', laborServices AS 'Labor Personal Services', 
                                            materialsMOOE AS 'Materials MOOE', capitalOutlay AS 'Capital Outaly', subtotal as 'Total' 
                                            From barangayBudget Where fiscalYear = '" & comboSearchBudget.Text & "'"
        Dim cmd4 As New SqlCommand(sql, con)
        Dim Adpt4 As New SqlDataAdapter(cmd4)
        Dim ds4 As New DataSet()
        If (Adpt4.Fill(ds4, "populationtbl")) Then
            dgvrefresh()
            DataGridView2.DataSource = ds4.Tables(0)
            btnPrint.Show()
        Else
        End If
    End Sub

    Private Sub comboSearchBudget_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboSearchBudget.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
            With budgetform
                .fiscalYear = comboSearchBudget.Text
                .ShowDialog()
            End With
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT Budget', '" & comboSearchBudget.Text & "')"
            CNN.Execute(sqlCommandLogin)
        End If
    End Sub
End Class