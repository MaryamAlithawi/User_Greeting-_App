Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim title As String = If(rbMr.Checked, "mr.", "ms.")
        Dim usernames As String = txtName.Text
        MessageBox.Show("welcome the systew," & title & username, "Greeting")

    End Sub
End Class
