Imports System.Data.SqlClient

Public Class budgetform
    Public fiscalYear, forDate, forTime As String
    Dim termStart As String
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * From barangayBudget WHERE fiscalYear = '" & fiscalYear & "' order by servicesProjects asc"
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        Dim dataReport As New DataSet()
        'MsgBox(ds.Tables("barangayBudget").Rows.Count & vbCrLf & fiscalYear & vbCrLf & forDate & vbCrLf & forTime)
        dscmd.Fill(dataReport, "barangayBudget")

        cnn.Close()

        'cnn.Open()
        'sql = "SELECT * From barangayOfficials order by autoID desc"
        'Dim amdc As New SqlDataAdapter(sql, cnn)
        ''Dim ds As New Barangay688DBDataSet
        'amdc.Fill(ds, "barangayOfficials")
        'termStart = CStr(ds.Tables("barangayOfficials").Rows(0).Item(0))
        'cnn.Close()

        'cnn.Open()
        'sql = "SELECT * From barangayOfficials where termStart = '" & termStart & "'"
        'Dim dsca As New SqlDataAdapter(sql, cnn)
        'dsca.Fill(dataReport, "barangayOfficials")
        'cnn.Close()


        Dim objRpt As New reportBudgetProjects
        objRpt.SetDataSource(dataReport)
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class