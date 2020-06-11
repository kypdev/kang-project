Public Class Login
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim passwords As String
        username = textBoxUsername.Text
        passwords = textBoxPassword.Text
        Console.WriteLine(username + " , " + passwords)
    End Sub
End Class