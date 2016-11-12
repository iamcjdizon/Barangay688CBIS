Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Residents
    Dim sqlCommand, sqlCommandRes, sqlCommandDel, sqlCommandResDel, sqlCommandLogin, photo, resID, sqlString As String
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Public nameUser As String
    Dim conaccess As New OleDbConnection

    Public Sub generateAutoID(ByVal id As Integer)
        'Dim year As String
        'year = DateTime.Now.Year

        id = id + 1

        ResidentRegister.textResID.Text = "688" & Format(id, "0000")

    End Sub

    'retrieve autoID In SQL And pass To generateAutoID
    Public Function forAutoID() As Integer
        Dim Rs1 As OleDb.OleDbDataReader
        Dim SqlComm1 As OleDb.OleDbCommand
        Dim CON As New OleDbConnection

        Dim residenttbl = 0
        Try
            CON = New OleDb.OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
            CON.Open()

            SqlComm1 = CON.CreateCommand
            SqlComm1.CommandText = "SELECT autoID from populationtbl Order By autoID DESC"
            Rs1 = SqlComm1.ExecuteReader

            If Rs1.Read = True Then
                residenttbl = Rs1(0)
                Return residenttbl
            End If

            Rs1.Close()
            CON.Close()
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Private Sub allEnabled()
        ResidentRegister.textFName.Enabled = True
        ResidentRegister.textMName.Enabled = True
        ResidentRegister.textLName.Enabled = True
        ResidentRegister.suffix.Enabled = True
        ResidentRegister.textHNo.Enabled = True
        ResidentRegister.comboStreet.Enabled = True
        ResidentRegister.textOccupation.Enabled = True
        ResidentRegister.textBPlace.Enabled = True
        ResidentRegister.comboCitizenship.Enabled = True
        ResidentRegister.comboReligion.Enabled = True
        ResidentRegister.DateTimePicker1.Enabled = True
        ResidentRegister.comboCivilStatus.Enabled = True
        ResidentRegister.textTelNo.Enabled = True
    End Sub

    Private Sub allDisabled()
        ResidentRegister.ShowDialog()
        ResidentRegister.textFName.Enabled = False
        ResidentRegister.textMName.Enabled = False
        ResidentRegister.textLName.Enabled = False
        ResidentRegister.textHNo.Enabled = False
        ResidentRegister.comboStreet.Enabled = False
        ResidentRegister.textOccupation.Enabled = False
        ResidentRegister.textBPlace.Enabled = False
        ResidentRegister.textTelNo.Enabled = False
        ResidentRegister.comboCitizenship.Enabled = False
        ResidentRegister.comboReligion.Enabled = False
        ResidentRegister.DateTimePicker1.Enabled = False
        ResidentRegister.comboCivilStatus.Enabled = False
    End Sub

    Public Sub hideBtn()
        btnPrint.Hide()
        btnDelete.Hide()
        btnEdit.Hide()
        myimage2.Image = Nothing
    End Sub

    Public Sub dgvrefresh()
        Try
            Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
                conn.Open()
                Dim command As New OleDbCommand("Select resID [Resident ID], lastName [Last Name], firstName [First Name],
                      middleName [Middle Name], suffix [Suffix], age [Age], gender [Gender], telNo [Telephone Number],
                    houseNo [House Number], street [street], barangay [Barangay], city [City], birthplace [Birth Place],
                    religion [Region], occupation [Occupation], citizenship [Citizenhsip], civilStatus [Civil Status],
                    birthday [Birthday] from populationtbl where isArchived = '0'", conn)
                Dim adapter As New OleDbDataAdapter
                Dim dt As New DataTable
                adapter.SelectCommand = command
                adapter.Fill(dt)
                DataGridView2.DataSource = dt
                adapter.Dispose()
                command.Dispose()
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'connecting to SQL in order to retrieve information and display to data grid
    Private Sub Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DataGridView2.EditMode = False
            Dim CS As String = "Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;"
            conaccess.ConnectionString = CS
            conaccess.Open()
            dgvrefresh()
            myConn = New SqlConnection("Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True")
            myConn.Open()
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'retrieving information from SQL and display in data grid
    Private Sub loadGrid()
        Try
            Dim access As String
            access = "Select resID [Resident ID], lastName [Last Name], firstName [First Name],
                      middleName [Middle Name], suffix [Suffix], age [Age], gender [Gender], telNo [Telephone Number],
                    houseNo [House Number], street [street], barangay [Barangay], city [City], birthplace [Birth Place],
                    religion [Region], occupation [Occupation], citizenship [Citizenhsip], civilStatus [Civil Status],
                    birthday [Birthday] from populationtbl where isArchived = '0'"
            Dim dataTab As New DataTable
            Dim Adpt As New OleDbDataAdapter(access, conaccess)
            Adpt.Fill(dataTab)
            DataGridView2.DataSource = dataTab
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'register button (add)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ResidentRegister.clearAll()
        ResidentRegister.btnSaveEdit.Hide()
        ResidentRegister.btnSave.Show()
        allEnabled()
        btnAdd.Hide()

        hideBtn()
        Me.Show()
        generateAutoID(forAutoID)
        With ResidentRegister
            .nameUser = nameUser
            .ShowDialog()
        End With
    End Sub
    'edit button
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit()
        allEnabled()
        ResidentRegister.btnSaveEdit.Show()
        ResidentRegister.btnSave.Hide()
        hideBtn()
        Try
            ResidentRegister.myimage.Image = Image.FromFile(System.IO.Path.Combine(photo))
        Catch ex As Exception
            ResidentRegister.myimage.Image = Nothing
        End Try
        With ResidentRegister
            .nameUser = nameUser
            .ShowDialog()
        End With
    End Sub
    Private Function Edit() As Integer
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        ResidentRegister.textResID.Text = DataGridView2.Item(0, i).Value
        ResidentRegister.textLName.Text = DataGridView2.Item(1, i).Value
        ResidentRegister.textFName.Text = DataGridView2.Item(2, i).Value
        ResidentRegister.textMName.Text = DataGridView2.Item(3, i).Value
        ResidentRegister.suffix.Text = DataGridView2.Item(4, i).Value
        ResidentRegister.textHNo.Text = DataGridView2.Item(8, i).Value
        ResidentRegister.comboStreet.Text = DataGridView2.Item(9, i).Value
        ResidentRegister.textAge.Text = DataGridView2.Item(5, i).Value
        ResidentRegister.textBPlace.Text = DataGridView2.Item(12, i).Value
        ResidentRegister.comboReligion.Text = DataGridView2.Item(13, i).Value
        ResidentRegister.textOccupation.Text = DataGridView2.Item(14, i).Value
        ResidentRegister.textTelNo.Text = DataGridView2.Item(7, i).Value
        ResidentRegister.comboCitizenship.Text = DataGridView2.Item(15, i).Value
        ResidentRegister.comboCivilStatus.Text = DataGridView2.Item(16, i).Value
        ResidentRegister.DateTimePicker1.Text = DataGridView2.Item(17, i).Value
        If ResidentRegister.radioFemale.Text = DataGridView2.Item(6, i).Value Then
            ResidentRegister.radioFemale.Checked = 1
        ElseIf ResidentRegister.radioMale.Text = DataGridView2.Item(6, i).Value Then
            ResidentRegister.radioMale.Checked = 1
        End If
        Return i
    End Function

    'DataGrid when click show buttons
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'btnPrint.Show()
        btnEdit.Show()
        btnDelete.Show()
        ResidentRegister.btnSaveEdit.Show()
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        Try
            resID = DataGridView2.Item(0, i).Value
        Catch ex As Exception
            MsgBox("error")
        End Try

        forPhoto()
        Try
            myimage2.Image = Image.FromFile(System.IO.Path.Combine(photo))
        Catch ex As Exception
            myimage2.Image = Nothing
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles labelClose.Click

        Me.Close()
    End Sub

    'Delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hideBtn()
        Try
            If MsgBox("Are you sure you want To Delete this Information?", vbYesNo) = vbYes Then
                Me.Show()
                Dim i As Integer
                i = DataGridView2.CurrentRow.Index
                sqlCommandRes = "Update populationtbl
                                SET isArchived = '1'
                            where resID = '" & DataGridView2.Item(0, i).Value & "'"
                CNN.Execute(sqlCommandRes)
                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'Delete Resident', '" & resID & "')"
                CNN.Execute(sqlCommandLogin)
                MsgBox("Delete Successful")
                dgvrefresh()
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
            With residentform
                .sqlString = sqlString
                .ShowDialog()
            End With
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT Population', '" & comboSearch.Text & "')"
            CNN.Execute(sqlCommandLogin)
        End If
    End Sub


    Private Sub comboSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboSearch.KeyPress
        Try
            If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(13) Then
                e.Handled = False
                If e.KeyChar = Chr(13) Then
                    Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                    Dim con As New SqlConnection(str)
                    sqlString = "Select resID [Resident ID], lastName [Last Name], firstName [First Name],
                      middleName [Middle Name], suffix [Suffix], age [Age], gender [Gender], telNo [Telephone Number],
                    houseNo [House Number], street [street], barangay [Barangay], city [City], birthplace [Birth Place],
                    religion [Region], occupation [Occupation], citizenship [Citizenhsip], civilStatus [Civil Status],
                    birthday [Birthday] from populationtbl where isArchived = '0' AND (resID like @search OR lastName Like @search
                                        OR firstName Like @search OR middleName Like @search
                                        OR suffix Like @search OR age Like @search OR gender Like @search
                                        OR telNo Like @search OR houseNo Like @search OR street Like @search
                                        OR birthplace Like @search OR religion Like @search OR occupation Like @search
                                        OR citizenship Like @search OR civilStatus Like @search OR birthday Like @search)"
                    Dim cmd4 As New SqlCommand(sqlString, con)
                    cmd4.Parameters.Add(New SqlClient.SqlParameter("search", comboSearch.Text)) 'This is to prevent sql injection
                    Dim Adpt4 As New SqlDataAdapter(cmd4)
                    Dim ds4 As New DataSet()
                    If (Adpt4.Fill(ds4, "populationtbl")) Then
                        loadGrid()
                        DataGridView2.DataSource = ds4.Tables(0)
                        btnPrint.Show()
                        MessageBox.Show("Match Found", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                'e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'e.Handled = True
    End Sub

    Private Sub comboSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles comboSearch.MouseClick
        hideBtn()
    End Sub


    Private Sub comboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSearch.SelectedIndexChanged
        Try
            If comboSearch.SelectedIndex = 1 Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim sql As String
                sql = "Select resID [Resident ID], lastName [Last Name], firstName [First Name],
                      middleName [Middle Name], suffix [Suffix], age [Age], gender [Gender], telNo [Telephone Number],
                    houseNo [House Number], street [street], barangay [Barangay], city [City], birthplace [Birth Place],
                    religion [Region], occupation [Occupation], citizenship [Citizenhsip], civilStatus [Civil Status],
                    birthday [Birthday] from populationtbl where isArchived = '0' AND Age >= 60"
                sqlString = "Select * From populationtbl where isArchived = '0' and age >= 60"

                Dim cmd4 As New SqlCommand(sql, con)
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "populationtbl")) Then
                    loadGrid()
                    DataGridView2.DataSource = ds4.Tables(0)
                    MessageBox.Show("All senior citizen", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            ElseIf comboSearch.SelectedIndex = 2 Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim sql As String
                sql = "Select resID [Resident ID], lastName [Last Name], firstName [First Name],
                      middleName [Middle Name], suffix [Suffix], age [Age], gender [Gender], telNo [Telephone Number],
                    houseNo [House Number], street [street], barangay [Barangay], city [City], birthplace [Birth Place],
                    religion [Region], occupation [Occupation], citizenship [Citizenhsip], civilStatus [Civil Status],
                    birthday [Birthday] from populationtbl where isArchived = '0' AND Age <= 17"
                sqlString = "Select * From populationtbl where isArchived = '0' AND Age <=17"
                Dim cmd5 As New SqlCommand(sql, con)
                Dim Adpt5 As New SqlDataAdapter(cmd5)
                Dim ds5 As New DataSet()
                If (Adpt5.Fill(ds5, "populationtbl")) Then
                    loadGrid()
                    DataGridView2.DataSource = ds5.Tables(0)
                    MessageBox.Show("All minor citizen", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf comboSearch.SelectedIndex = 0 Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim sql As String
                sql = "Select resID [Resident ID], lastName [Last Name], firstName [First Name],
                      middleName [Middle Name], suffix [Suffix], age [Age], gender [Gender], telNo [Telephone Number],
                    houseNo [House Number], street [street], barangay [Barangay], city [City], birthplace [Birth Place],
                    religion [Region], occupation [Occupation], citizenship [Citizenhsip], civilStatus [Civil Status],
                    birthday [Birthday] from populationtbl where isArchived = '0'"
                sqlString = "Select * From populationtbl where isArchived = '0'"
                Dim cmd4 As New SqlCommand(sql, con)
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "populationtbl")) Then
                    loadGrid()
                    DataGridView2.DataSource = ds4.Tables(0)
                    MessageBox.Show("All data", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            btnPrint.Show()
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub forPhoto()
        Dim str As String
        Try
            str = "Select * From populationTBL where resID = '" & resID & "'"
            myCmd = New SqlCommand(str, myConn)
            Dim myAdapt = New SqlDataAdapter(myCmd)


            Dim dr As SqlDataReader
            dr = myCmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                photo = dr.Item("photo")
                dr.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
