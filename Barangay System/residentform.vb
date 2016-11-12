Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data

Public Class residentform
    Public sqlString, forDate, forTime As String
    Dim termStart As String
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String
        Try
            connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
            cnn = New SqlConnection(connectionString)
            cnn.Open()
            'sqlString = "SELECT * From barangayCTBL WHERE isArchieved = '0'"
            Dim dscmd As New SqlDataAdapter(sqlString, cnn)
            Dim ds As New Barangay688DBDataSet
            Dim dataReport As New DataSet()
            'MsgBox(ds.Tables("populationTBL").Rows.Count & vbCrLf & sqlString & vbCrLf & forDate & vbCrLf & forTime)
            dscmd.Fill(dataReport, "populationTbl")

            cnn.Close()

            cnn.Open()
            sql = "SELECT * From barangayOfficials order by autoID desc"
            Dim amdc As New SqlDataAdapter(sql, cnn)
            'Dim ds As New Barangay688DBDataSet
            amdc.Fill(ds, "barangayOfficials")
            termStart = CStr(ds.Tables("barangayOfficials").Rows(0).Item(0))
            cnn.Close()

            cnn.Open()
            sql = "SELECT * From barangayOfficials where termStart = '" & termStart & "'"
            Dim dsca As New SqlDataAdapter(sql, cnn)
            dsca.Fill(dataReport, "barangayOfficials")
            cnn.Close()

            Dim objRpt As New reportResidents
            objRpt.SetDataSource(dataReport)
            CrystalReportViewer1.ReportSource = objRpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class