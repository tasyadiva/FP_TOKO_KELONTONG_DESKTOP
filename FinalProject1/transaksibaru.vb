Imports System.Data.OracleClient
Public Class transaksibaru
    Dim cmd As New OracleCommand
    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Dim dr As OracleDataReader
    Sub koneksi()
        cn.Close()
        cn = New OracleConnection("Data Source=XE;Persist Security Info=True;User ID=mbakpa;Unicode=True;password=mbakpa;")
        cn.Open()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.TBLBARANG' table. You can move, or remove it, as needed.
        Me.TBLBARANGTableAdapter1.Fill(Me.DataSet3.TBLBARANG)
        'TODO: This line of code loads data into the 'DataSet1.TBLBARANG' table. You can move, or remove it, as needed.
        Me.TBLBARANGTableAdapter.Fill(Me.DataSet1.TBLBARANG)
        koneksi()
        Panelsliding.Visible = False
        pbmenu.Visible = True
        pbback.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        barang.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles pbhome.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbmenu.Click
        Panelsliding.Visible = True
        pbmenu.Visible = False
        pbback.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panelsliding.Visible = False
        pbmenu.Visible = True
        Me.Hide()
        login.Show()
    End Sub

    Private Sub pbback_Click(sender As Object, e As EventArgs) Handles pbback.Click
        Panelsliding.Visible = False
        pbback.Visible = False
        pbmenu.Visible = True
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Me.Hide()
        laporannn.Show()
    End Sub

    Private Sub brg_Click(sender As Object, e As EventArgs) Handles brg.Click
        Me.Hide()
        barang.Show()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        cmd = New OracleCommand("select kodebrg, namabrg, jenis, jumlah, satuan, hargabeli, hargajual from tblbarang", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        CbBrg.Text = dr("kodebrg")
        namabrgtrns.Text = dr("namabrg")
        jenistrns.Text = dr("jenis")
        hargabrg.Text = dr("hargajual")
        cmd = New OracleCommand("insert into tbltransaksi values ('" & kodetrns.Text & "','" & CbBrg.Text & "'," & "'" & namabrgtrns.Text &
                                "','" & jenistrns.Text & "'," & jumlahtrns.Text & "," & hargabrg.Text & "," & bayar.Text & ")", cn)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil disimpan")
    End Sub

    Private Sub jumlahtrns_TextChanged(sender As Object, e As EventArgs) Handles jumlahtrns.TextChanged
        totalbrg.Text = jumlahtrns.Text * hargabrg.Text
    End Sub

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged
        Kembalian.Text = bayar.Text - totalbrg.Text
    End Sub

    Private Sub Kembalian_TextChanged(sender As Object, e As EventArgs) Handles Kembalian.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub totalbrg_TextChanged(sender As Object, e As EventArgs) Handles totalbrg.TextChanged

    End Sub

    Private Sub hargabrg_TextChanged(sender As Object, e As EventArgs) Handles hargabrg.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class