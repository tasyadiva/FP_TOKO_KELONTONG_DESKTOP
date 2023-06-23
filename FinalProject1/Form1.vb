Public Class login

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If username.Text = "mbakpa" And password.Text = "123" Then
            Me.Hide()
            home.Show()
        ElseIf username.Text = "" And password.Text = "" Then
            MsgBox("Silakan Isi Username dan Password!", vbInformation, "Hint")
        ElseIf username.Text = "" Then
            MsgBox("Username Kosong", vbCritical, "Error!!")
        ElseIf password.Text = "" Then
            MsgBox("Password Kosong", vbCritical, "Error!!")
        Else
            MsgBox("Username atau Password salah!", vbCritical, "Error!!")
        End If
        password.Text = ""
        username.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
