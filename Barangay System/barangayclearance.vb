Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class barangayclearance
    Dim sqlCommandBarangayC, sqlCommandBarangayCDel, sqlCommandLogin As String
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Public nameUser As String
    Dim conaccessBarangay As New OleDbConnection
    Dim forResID, forTimeEdit, forDateEdit As String

    'clear all text
    Public Sub clearAllBar()
        BrgyClearanceRegister.textFNameBar.Clear()
        BrgyClearanceRegister.textMNameBar.Clear()
        BrgyClearanceRegister.textLNameBar.Clear()
        BrgyClearanceRegister.suffixBar.Clear()
        BrgyClearanceRegister.textHnoBar.Clear()
        BrgyClearanceRegister.comboStreetBar.Text = String.Empty
        BrgyClearanceRegister.comboStreetBar.SelectedIndex = -1
        BrgyClearanceRegister.textTelNoBar.Clear()
        BrgyClearanceRegister.textPurposeBar.Clear()
    End Sub

    'connecting to SQL
    Private Sub barangayclearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2Bar.EditMode = False
        Dim CS As String = "Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;"
        conaccessBarangay.ConnectionString = CS
        conaccessBarangay.Open()
        refreshBrgy()
    End Sub

    'retrieving information from SQL and display in data grid
    Private Sub loadGridBar()
        Dim access As String
        Try
            access = "Select resid [Resident ID], lastName [Last Name], firstName [First Name],
                                            middleName [Middle Name], suffix [Suffix], telNo [Contact Number],
                                            houseNo [House Number], street [Street], purpose [Purpose], barangayDate [Date Issued], barangayTime [Time Issued]  
                                            FROM barangayCTBL where isArchived = '0'"
            Dim dataTab As New DataTable
            Dim Adpt As New OleDbDataAdapter(access, conaccessBarangay)
            Adpt.Fill(dataTab)
            DataGridView2Bar.DataSource = dataTab
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'combo search brgy
    Private Sub comboSearchBar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSearchBar.SelectedIndexChanged
        Try
            If comboSearchBar.SelectedIndex = 0 Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim cmd4 As New SqlCommand("select * from barangayCTBL where isArchived ='0'", con)
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "barangayCTBL")) Then
                    refreshBrgy()
                    DataGridView2Bar.DataSource = ds4.Tables(0)
                    MessageBox.Show("All Applicants", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'displaying the information from the data grid to the textbox and combobox
    Private Sub DataGridView2Bar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2Bar.CellClick
        btnPrintBar.Show()
        btnEditBar.Show()
        btnDeleteBar.Show()
        lblPreview.Show()
        Dim i As Integer
        i = DataGridView2Bar.CurrentRow.Index
        Try
            forDateEdit = DataGridView2Bar.Item(9, i).Value
            forTimeEdit = DataGridView2Bar.Item(10, i).Value
            forResID = DataGridView2Bar.Item(0, i).Value
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    'register button brgy
    Private Sub btnAddBar_Click_1(sender As Object, e As EventArgs) Handles btnRegisterBar.Click
        Me.Show()
        clearAllBar()
        BrgyClearanceRegister.textResIDBar.Clear()
        'btnRegisterBar.Hide()
        btnPrintBar.Hide()
        btnEditBar.Hide()
        btnDeleteBar.Hide()
        BrgyClearanceRegister.textResIDBar.Enabled = 1
        BrgyClearanceRegister.textFNameBar.Enabled = 0
        BrgyClearanceRegister.textMNameBar.Enabled = 0
        BrgyClearanceRegister.textLNameBar.Enabled = 0
        BrgyClearanceRegister.textHnoBar.Enabled = 0
        BrgyClearanceRegister.comboStreetBar.Enabled = 0
        BrgyClearanceRegister.btnSaveEditBar.Hide()
        BrgyClearanceRegister.btnSaveBar.Show()
        BrgyClearanceRegister.DateTimePicker1Barc.Enabled = 0
        With BrgyClearanceRegister
            .nameUser = nameUser
            .ShowDialog()
        End With
    End Sub

    'edit button brgy
    Public Sub btnEditBar_Click(sender As Object, e As EventArgs) Handles btnEditBar.Click
        editBar()
        BrgyClearanceRegister.textResIDBar.Enabled = 0
        BrgyClearanceRegister.textTelNoBar.Enabled = 1
        BrgyClearanceRegister.textPurposeBar.Enabled = 1
        BrgyClearanceRegister.btnSaveEditBar.Show()
        BrgyClearanceRegister.btnSaveBar.Hide()
        With BrgyClearanceRegister
            .nameUser = nameUser
            .forTimeEdit = forTimeEdit
            .forDateEdit = forDateEdit
            .ShowDialog()
        End With
    End Sub

    Private Function editBar() As Integer
        Dim i As Integer
        i = DataGridView2Bar.CurrentRow.Index
        BrgyClearanceRegister.textResIDBar.Text = DataGridView2Bar.Item(0, i).Value
        BrgyClearanceRegister.textLNameBar.Text = DataGridView2Bar.Item(1, i).Value
        BrgyClearanceRegister.textFNameBar.Text = DataGridView2Bar.Item(2, i).Value
        BrgyClearanceRegister.textMNameBar.Text = DataGridView2Bar.Item(3, i).Value
        BrgyClearanceRegister.suffixBar.Text = DataGridView2Bar.Item(4, i).Value
        BrgyClearanceRegister.textHnoBar.Text = DataGridView2Bar.Item(6, i).Value
        BrgyClearanceRegister.comboStreetBar.Text = DataGridView2Bar.Item(7, i).Value
        BrgyClearanceRegister.textTelNoBar.Text = DataGridView2Bar.Item(5, i).Value
        BrgyClearanceRegister.textPurposeBar.Text = DataGridView2Bar.Item(8, i).Value
        Return i
    End Function

    'delete button brgy
    Private Sub btnDeleteBar_Click_1(sender As Object, e As EventArgs) Handles btnDeleteBar.Click
        Try
            If MsgBox("Are you sure you want to Delete this Information?", vbYesNo) = vbYes Then
                Me.Show()
                Dim i As Integer
                i = DataGridView2Bar.CurrentRow.Index
                sqlCommandBarangayC = "Update barangayCTBL
                                SET isArchived = '1'
                            where resID = '" & DataGridView2Bar.Item(0, i).Value & "' AND barangayDate = '" & forDateEdit & "' AND barangayTime = '" & forTimeEdit & "'"
                CNN.Execute(sqlCommandBarangayC)
                sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'DELETE BrgyClearance', '" & forResID & "')"
                CNN.Execute(sqlCommandLogin)
                MsgBox("Delete Successful")
                refreshBrgy()
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'refresh function brgy
    Public Sub refreshBrgy()
        Try
            Using conn As New OleDbConnection("Provider=sqloledb;Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=SSPI;")
                conn.Open()
                Dim command As New OleDbCommand("Select resid [Resident ID], lastName [Last Name], firstName [First Name],
                                            middleName [Middle Name], suffix [Suffix], telNo [Contact Number],
                                            houseNo [House Number], street [Street], purpose [Purpose], 
                                            barangayDate [Date Issued], barangayTime [Time Issued]  
                                            FROM barangayCTBL where isArchived = '0'", conn)
                Dim adapter As New OleDbDataAdapter
                Dim dt As New DataTable
                adapter.SelectCommand = command
                adapter.Fill(dt)
                DataGridView2Bar.DataSource = dt
                adapter.Dispose()
                command.Dispose()
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'preview function
    Private Function getinfo() As Integer
        Dim i As Integer
        i = DataGridView2Bar.CurrentRow.Index
        brgyformpreview.lastname.Text = DataGridView2Bar.Item(1, i).Value
        brgyformpreview.firstname.Text = DataGridView2Bar.Item(2, i).Value
        brgyformpreview.middleName.Text = DataGridView2Bar.Item(3, i).Value
        brgyformpreview.suffix.Text = DataGridView2Bar.Item(4, i).Value
        brgyformpreview.textHNo.Text = DataGridView2Bar.Item(6, i).Value
        brgyformpreview.textStreet.Text = DataGridView2Bar.Item(7, i).Value
        brgyformpreview.date1.Text = DataGridView2Bar.Item(9, i).Value
        brgyformpreview.purpose.Text = DataGridView2Bar.Item(8, i).Value

        Return i
    End Function

    'label preview
    Private Sub lblPreview_Click(sender As Object, e As EventArgs) Handles lblPreview.Click
        getinfo()
        brgyformpreview.ShowDialog()
    End Sub

    Private Sub textOrNoBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textResIDBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textFNameBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textMNameBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textLNameBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And Char.IsSeparator(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub textHNoBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso
        Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub comboSearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comboSearchBar.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Dim str As String = "Data Source=CIRJON;Initial Catalog=Barangay688DB;Integrated Security=True"
                Dim con As New SqlConnection(str)
                Dim cmd4 As New SqlCommand("select * from barangayCtbl where isArchived = '0' AND (resID like @search OR lastName Like @search
                                        OR firstName Like @search OR middleName Like @search
                                        OR suffix Like @search OR telNo Like @search OR houseNo Like @search
                                        OR street Like @search OR purpose Like @search)", con)
                cmd4.Parameters.Add(New SqlClient.SqlParameter("search", comboSearchBar.Text)) 'This is to prevent sql injection
                Dim Adpt4 As New SqlDataAdapter(cmd4)
                Dim ds4 As New DataSet()
                If (Adpt4.Fill(ds4, "barangayCTBL")) Then
                    refreshBrgy()
                    DataGridView2Bar.DataSource = ds4.Tables(0)
                    MessageBox.Show("Match Found", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Match not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Print function
    Private Sub btnPrintBar_Click(sender As Object, e As EventArgs) Handles btnPrintBar.Click
        If MsgBox("Do you want to print?", vbYesNo) = vbYes Then
            With brgyclearanceform
                .resID = forResID
                .forDate = forDateEdit
                .forTime = forTimeEdit
                .ShowDialog()
            End With
            sqlCommandLogin = "Insert into loginLogin Values ('" & nameUser & "', '" & Today & "', '" & TimeOfDay & "', 'PRINT BrgyClearance', '" & forResID & "')"
            CNN.Execute(sqlCommandLogin)
        End If
    End Sub

    'btn closer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles labelClose.Click
        Me.Close()
    End Sub

    Private Sub comboPurposeBar_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    'Private Sub barangayclearance_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
    '    btnPrintBar.Hide()
    '    btnEditBar.Hide()
    '    btnDeleteBar.Hide()
    '    lblPreview.Hide()
    'End Sub

    'Private Sub DataGridView2Bar_LostFocus(sender As Object, e As EventArgs) Handles DataGridView2Bar.LostFocus
    '    btnPrintBar.Hide()
    '    btnEditBar.Hide()
    '    btnDeleteBar.Hide()
    '    lblPreview.Hide()
    'End Sub
End Class