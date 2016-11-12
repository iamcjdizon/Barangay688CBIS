Imports System.Data.SqlClient


Public Class brgyclearanceform
    Public resID, forDate, forTime As String
    Dim termStart As String
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cnn As SqlConnection
        Dim connectionString As String
        Dim sql As String

        connectionString = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        cnn.Open()
        sql = "SELECT * From barangayCTBL WHERE resID = '" & resID & "' AND barangayDate = '" & forDate & "' AND barangayTime = '" & forTime & "' "
        Dim dscmd As New SqlDataAdapter(sql, cnn)
        Dim ds As New Barangay688DBDataSet
        Dim dataReport As New DataSet()
        'MsgBox(ds.Tables("barangayCTBL").Rows.Count & vbCrLf & resID & vbCrLf & forDate & vbCrLf & forTime)
        dscmd.Fill(dataReport, "BarangayCTBL")

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


        Dim objRpt As New reportBarangayClearance
        objRpt.SetDataSource(dataReport)
        CrystalReportViewer1.ReportSource = objRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class