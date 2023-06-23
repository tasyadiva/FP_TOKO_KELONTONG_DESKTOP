Public Class laporannn
    Private Sub btnkembali_Click(sender As Object, e As EventArgs)
        Me.Hide()
        home.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub laporannn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelsliding.Visible = False
        pbmenu.Visible = True
        pbback.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles trns.Click
        Me.Hide()
        transaksibaru.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles pbhome.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub pbmenu_Click(sender As Object, e As EventArgs) Handles pbmenu.Click
        Panelsliding.Visible = True
        pbmenu.Visible = False
        pbback.Visible = True
    End Sub

    Private Sub pbback_Click(sender As Object, e As EventArgs) Handles pbback.Click
        Panelsliding.Visible = False
        pbback.Visible = False
        pbmenu.Visible = True
    End Sub

    Private Sub brg_Click(sender As Object, e As EventArgs) Handles brg.Click
        Me.Hide()
        barang.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        laporanbarang.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        laporanTransaksi.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Me.Hide()
        login.Show()
    End Sub
End Class