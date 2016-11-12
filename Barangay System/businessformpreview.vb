Public Class businessformpreview
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Close()
        businessclearance.btnEditBusiness.Hide()
        businessclearance.btnPrintBusiness.Hide()
        businessclearance.btnDeleteBusiness.Hide()
        businessclearance.lblPreview.Hide()
        businessclearance.comboSearchBusiness.Text = String.Empty
        businessclearance.comboSearchBusiness.SelectedIndex = -1
        businessclearance.comboSearchBusiness.Text = "--Select--"
        businessclearance.refreshBusi()
    End Sub
End Class