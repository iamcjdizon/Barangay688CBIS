Public Class brgyformpreview
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Close()
        barangayclearance.Show()
        barangayclearance.lblPreview.Hide()
        barangayclearance.btnEditBar.Hide()
        barangayclearance.btnPrintBar.Hide()
        barangayclearance.btnDeleteBar.Hide()
        barangayclearance.refreshBrgy()
        barangayclearance.comboSearchBar.Text = String.Empty
        barangayclearance.comboSearchBar.SelectedIndex = -1
        barangayclearance.comboSearchBar.Text = "--Select--"
    End Sub
End Class