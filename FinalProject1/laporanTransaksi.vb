Imports System.Data.OracleClient
Public Class laporanTransaksi
    Dim cmd As New OracleCommand
    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Sub koneksi()
        cn = New OracleConnection("Data Source=XE;Persist Security Info=True;User ID=mbakpa;Unicode=True;password=mbakpa;")
    End Sub
    Private Sub laporanTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet5.TBLTRANSAKSI' table. You can move, or remove it, as needed.
        Me.TBLTRANSAKSITableAdapter1.Fill(Me.DataSet5.TBLTRANSAKSI)

        koneksi()
        da = New OracleDataAdapter("select kodetransaksi, kodebrgtrnsksi, namabrg, jenistrns, jumlahtrns, total, bayar from tbltransaksi", cn)
        da.Fill(ds, "xxx")
        DGVtransaksi.DataSource = ds.Tables("xxx").DefaultView

        Panelsliding.Visible = False
        pbmenu.Visible = True
        pbback.Visible = False
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Me.Hide()
        laporannn.Show()
    End Sub

    Private Sub brg_Click(sender As Object, e As EventArgs) Handles brg.Click
        Me.Hide()
        barang.Show()
    End Sub

    Private Sub trns_Click(sender As Object, e As EventArgs) Handles trns.Click
        Me.Hide()
        transaksibaru.Show()
    End Sub

    Private Sub pbback_Click(sender As Object, e As EventArgs) Handles pbback.Click
        Panelsliding.Visible = False
        pbback.Visible = False
        pbmenu.Visible = True
    End Sub

    Private Sub pbmenu_Click(sender As Object, e As EventArgs)
        Panelsliding.Visible = True
        pbmenu.Visible = False
        pbback.Visible = True
    End Sub

    Private Sub pbhome_Click(sender As Object, e As EventArgs) Handles pbhome.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub pbmenu_Click_1(sender As Object, e As EventArgs) Handles pbmenu.Click
        Panelsliding.Visible = True
        pbmenu.Visible = False
        pbback.Visible = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        login.Show()
    End Sub
End Class