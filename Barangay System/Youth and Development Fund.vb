Public Class Youth_and_Development_Fund
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        home.Show()
        budget.Hide()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        TextBox4.Show()

    End Sub

    Private Sub Youth_and_Development_Fund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        TextBox4.Hide()



    End Sub

End Class