Public Class home
    Private Sub btnlogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        login.Show()
    End Sub
    Private Sub btnstok_Click(sender As Object, e As EventArgs) Handles btnstok.Click
        Me.Hide()
        barang.Show()
    End Sub
    Private Sub btnlaporan_Click_1(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Me.Hide()
        laporan.Show()
    End Sub
    Private Sub btntransaksi_Click(sender As Object, e As EventArgs) Handles btntransaksi.Click
        Me.Hide()
        transaksi.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class