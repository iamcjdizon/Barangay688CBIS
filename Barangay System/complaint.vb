Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class complaint
    Dim sqlCommandComplaintDel, sqlCommandComplainant, sqlCommandComplainantDel, caseNo, sqlCommandLogin As String
    Public nameUser As String
    Dim conaccessComplaint As New OleDbConnection
    'Get autoID And increment To have resident ID
    Public Sub generateAutoID(ByVal id As Integer)
        Dim year As String
        year = DateTime.Now.Year

        id = id + 1

        ComplaintRegister.textCaseNo.Text = year & Format(id, "0000")

    End Sub
    'retrieve autoID In SQL And pass To generateAutoID
    Public Function forAutoID() As Integer
        Dim Rs1 As OleDb.OleDbDataReader
        Dim SqlComm1 As OleDb.OleDbCommand
        Dim CON As New OleDbConnection

        Dim complainttbl = 0
        Try
            CON = New OleDb.OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
            CON.Open()


            SqlComm1 = CON.CreateCommand
            SqlComm1.CommandText = "SELECT autoID from complaintTBL Order By autoID DESC"
            Rs1 = SqlComm1.ExecuteReader

            If Rs1.Read = True Then
                complainttbl = Rs1(0)
                Return complainttbl
            End If

            Rs1.Close()
            CON.Close()
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    'connecting to SQL
    Private Sub complaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2Complaint.EditMode = False
        Dim CS As String = "Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;"
        conaccessComplaint.ConnectionString = CS
        conaccessComplaint.Open()
        loadGridComplaint()
    End Sub

    'button close
    Private Sub btnback_Click(sender As Object, e As EventArgs)
        home.Show()
        Me.Hide()
    End Sub

    'retrieving information from SQL and display in data grid
    Private Sub loadGridComplaint()
        Dim access As String
        Try
            access = "Select caseNo [Case Number], complaintDate[Complaint Date], placeOfIncident [Place of Incident],
                    status [Status], complaintConcern[Complaint Concern], remarks [Remarks]
                    From complaintTBL where isArchived = '0'"
            Dim dataTab As New DataTable
            Dim Adpt As New OleDbDataAdapter(access, conaccessComplaint)
            Adpt.Fill(dataTab)
            DataGridView2Complaint.DataSource = dataTab
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'register button
    Private Sub btnAddComplaint_Click_1(sender As Object, e As EventArgs) Handles btnAddComplaint.Click
        Me.Show()
        ComplaintRegister.btnSaveComplaint.Show()
        ComplaintRegister.btnSaveEditComplaint.Hide()
        ComplaintRegister.textCaseNo.Enabled = False
        ComplaintRegister.clearAllComplaint()
        generateAutoID(forAutoID)
        With ComplaintRegister
            .nameUser = nameUser
            .ShowDialog()
        End With
    End Sub

    'edit button
    Private Sub btnEditComplaint_Click(sender As Object, e As EventArgs) Handles btnEditComplaint.Click
        editComplaint()
        ComplaintRegister.btnSaveComplaint.Hide()
        ComplaintRegister.btnSaveEditComplaint.Show()
        ComplaintRegister.textCaseNo.Enabled = 0
        With ComplaintRegister
            .nameUser = nameUser
            .isEdit = 1
            .ShowDialog()
        End With
    End Sub

    Private Function editComplaint() As Integer
        Dim i As Integer
        i = DataGridView2Complaint.CurrentRow.Index
        ComplaintRegister.textCaseNo.Text = DataGridView2Complaint.Item(0, i).Value
        ComplaintRegister.DateTimePicker1Complaint.Text = DataGridView2Complaint.Item(1, i).Value
        ComplaintRegister.textPlaceOfIncident.Text = DataGridView2Complaint.Item(2, i).Value
        ComplaintRegister.textStatus.Text = DataGridView2Complaint.Item(3, i).Value
        ComplaintRegister.richConcern.Text = DataGridView2Complaint.Item(4, i).Value
        ComplaintRegister.richRemarks.Text = DataGridView2Complaint.Item(5, i).Value
        Return i
    End Function

    'displaying the information from the data grid to the textbox and combobox
    Private Sub DataGridView2Complaint_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2Complaint.CellClick
        btnEditComplaint.Show()
        btnDeleteComplaint.Show()
        btnPrintComplaint.Show()
        Dim i As Integer
        i = DataGridView2Complaint.CurrentRow.Index
        Try
            caseNo = DataGridView2Complaint.Item(0, i).Value
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    'delete button
    Private Sub btnDeleteComplaint_Click(sender As Object, e As EventArgs) Handles btnDeleteComplaint.Click
        Try
            If MsgBox("Are you sure you want to Delete this Information?", vbYesNo) = vbYes Then
                Me.Show()
                Dim i As Integer
                i = DataGridView2Complaint.CurrentRow.Index
                sqlCommandComplaintDel = "Update complaintTBL
                                SET isArchived = '1'
                            where caseNo = '" & DataGridView2Complaint.Item(0, i).Value & "'"
                CNN.Execute(sqlCommandComplaintDel)
                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'DELETE Blotter', '" & caseNo & "')"
                CNN.Execute(sqlCommandLogin)
                MsgBox("Delete Successful")
                refreshComplaint()
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'refresh button
    Private Sub btnRefreshComplaint_Click(sender As Object, e As EventArgs)
        refreshComplaint()
    End Sub

    Public Sub refreshComplaint()
        Try
            Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
                conn.Open()
                Dim command As New OleDbCommand("Select caseNo [Case Number], complaintDate[Complaint Date], placeOfIncident [Place of Incident],
                    status [Status], complaintConcern[Complaint Concern], remarks [Remarks]
                    From complaintTBL where isArchived = '0'", conn)
                Dim adapter As New OleDbDataAdapter
                Dim dt As New DataTable
                adapter.SelectCommand = command
                adapter.Fill(dt)
                DataGridView2Complaint.DataSource = dt
                adapter.Dispose()
                command.Dispose()
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'btn close'
    Private Sub labelClose_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub btnPrintComplaint_Click(sender As Object, e As EventArgs) Handles btnPrintComplaint.Click
        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
            With complaintForm
                .caseNo = caseNo
                .ShowDialog()
            End With
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT Blotter', '" & caseNo & "')"
            CNN.Execute(sqlCommandLogin)
        End If
    End Sub

    Private Sub comboSearchComplaint_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comboSearchComplaint.SelectedIndexChanged
        Try
            If comboSearchComplaint.SelectedIndex = 0 Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim cmd4 As New SqlCommand("Select caseNo [Case Number], complaintDate[Complaint Date], placeOfIncident [Place of Incident],
                    status [Status], complaintConcern[Complaint Concern], remarks [Remarks]
                    From complaintTBL where isArchived = '0'", con)
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "complainttbl")) Then
                    loadGridComplaint()
                    DataGridView2Complaint.DataSource = ds4.Tables(0)
                    MessageBox.Show("All senior citizen", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub comboSearchComplaint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboSearchComplaint.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim cmd4 As New SqlCommand("Select caseNo [Case Number], complaintDate[Complaint Date], placeOfIncident [Place Of Incident],
                    status [Status], complaintConcern[Complaint Concern], remarks [Remarks]
                    From complaintTBL Where isArchived = '0' AND (caseNo like @search OR complaintDate Like @search
                                        Or placeOfIncident Like @search OR complaintConcern Like @search
                                        Or remarks Like @search OR status Like @search)", con)
                cmd4.Parameters.Add(New SqlClient.SqlParameter("search", comboSearchComplaint.Text)) 'This is to prevent sql injection
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "complainttbl")) Then
                    loadGridComplaint()
                    DataGridView2Complaint.DataSource = ds4.Tables(0)
                    MessageBox.Show("Match Found", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class