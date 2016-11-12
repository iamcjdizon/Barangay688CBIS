Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class budgetReport
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Dim conaccess As New OleDbConnection
    'part A
    Public Sub showReportA()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From barangayBudgetInput where fiscalYear = '" & budgetAdd.textFiscalYr.Text & "'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            textIRAreport.Text = dr.Item("increaseIRA")
            textSurplusReport.Text = dr.Item("unappropriateSurplus")
            textIRCreport.Text = dr.Item("internalRevenueCollections")
            textRPTreport.Text = dr.Item("realPropertyTax")
            textIncRPTreport.Text = dr.Item("increaseRPT")
            textBrgyCityAidReport.Text = dr.Item("cityAid")
            textAvailResourcesReport.Text = dr.Item("currentResources")
            dr.Close()

        End If
    End Sub
    'part B
    Public Sub showReportB()
        myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
        myConn.Open()

        Dim str As String
        str = "Select * From barangayBudgetInput where fiscalYear = '" & budgetAdd.textFiscalYr.Text & "'"
        myCmd = New SqlCommand(str, myConn)
        Dim myAdapt = New SqlDataAdapter(myCmd)

        Dim dr As SqlDataReader
        dr = myCmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            textIRAreport.Text = dr.Item("increaseIRA")
            textSurplusReport.Text = dr.Item("unappropriateSurplus")
            textIRCreport.Text = dr.Item("internalRevenueCollections")
            textRPTreport.Text = dr.Item("realPropertyTax")
            textIncRPTreport.Text = dr.Item("increaseRPT")
            textBrgyCityAidReport.Text = dr.Item("cityAid")
            textAvailResourcesReport.Text = dr.Item("currentResources")
            dr.Close()

        End If
    End Sub

    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Close()
    End Sub
End Class