Public Class home
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        login.Show()
    End Sub
    Private Sub btnstok_Click(sender As Object, e As EventArgs) Handles btnstok.Click
        Me.Hide()
        barang.Show()
    End Sub
    Private Sub btnlaporan_Click_1(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Me.Hide()
        laporannn.Show()
    End Sub
    Private Sub btntransaksi_Click(sender As Object, e As EventArgs) Handles btntransaksi.Click
        Me.Hide()
        transaksibaru.Show()
    End Sub
End Class