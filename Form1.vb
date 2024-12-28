Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Neeta Kadam" And TextBox2.Text = "kneeta" Then
            MessageBox.Show("You Have logged successfully..")
            Home.Show()
            Hide()
        Else
            MessageBox.Show("login fail")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
