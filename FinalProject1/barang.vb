Imports System.Data.OracleClient
Public Class barang
    Dim cmd As New OracleCommand
    Dim cn As New OracleConnection
    Dim da As New OracleDataAdapter
    Dim ds As New DataSet
    Sub koneksi()
        cn.Close()
        cn = New OracleConnection("Data Source=XE;Persist Security Info=True;User ID=mbakpa;Unicode=True;password=mbakpa;")
        cn.Open()
    End Sub
    Private Sub btnkembali_Click(sender As Object, e As EventArgs)
        Me.Hide()
        home.Show()
    End Sub
    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelsliding.Visible = False
        pbmenu.Visible = True
        pbback.Visible = False
        DGVstockbarang.Visible = False
        koneksi()
        da = New OracleDataAdapter("select kodebrg, namabrg, jenis, jumlah, satuan, hargabeli, hargajual from tblbarang", cn)
        da.Fill(ds, "xxx")
        DGVstockbarang.DataSource = ds.Tables("xxx").DefaultView
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        da = New OracleDataAdapter("insert into tblbarang values ('" & kodebrg.Text & "','" & namabrg.Text & "','" & jenis.Text & "','" & jumlah.Text & "','" & satuan.Text & "','" & hargabeli.Text & "','" & hargajual.Text & "')", cn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil disimpan")
        ds.Clear()
        da = New OracleDataAdapter("select kodebrg, namabrg, jenis, jumlah, satuan, hargabeli, hargajual from tblbarang", cn)
        da.Fill(ds, "xxx")
        DGVstockbarang.DataSource = ds.Tables("xxx").DefaultView
        kodebrg.Text = ""
        namabrg.Text = ""
        jenis.Text = ""
        jumlah.Text = ""
        satuan.Text = ""
        hargabeli.Text = ""
        hargajual.Text = ""
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        da = New OracleDataAdapter("delete tblbarang where kodebrg='" & kodebrg.Text & "'", cn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil dihapus")
        ds.Clear()
        da = New OracleDataAdapter("select kodebrg, namabrg, jenis, jumlah, satuan, hargabeli, hargajual from tblbarang", cn)
        da.Fill(ds, "xxx")
        DGVstockbarang.DataSource = ds.Tables("xxx").DefaultView
        kodebrg.Text = ""
        namabrg.Text = ""
        jenis.Text = ""
        jumlah.Text = ""
        satuan.Text = ""
        hargabeli.Text = ""
        hargajual.Text = ""
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        da = New OracleDataAdapter("update tblbarang set jumlah='" & jumlah.Text & "', hargabeli='" & hargabeli.Text & "', hargajual='" & hargajual.Text & "'
            where kodebrg='" & kodebrg.Text & "'", cn)
        da.Fill(ds, "xxx")
        MsgBox("data berhasil diubah")
        ds.Clear()
        da = New OracleDataAdapter("select kodebrg, namabrg, jenis, jumlah, satuan, hargabeli, hargajual from tblbarang", cn)
        da.Fill(ds, "xxx")
        DGVstockbarang.DataSource = ds.Tables("xxx").DefaultView
        kodebrg.Text = ""
        namabrg.Text = ""
        jenis.Text = ""
        jumlah.Text = ""
        satuan.Text = ""
        hargabeli.Text = ""
        hargajual.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbmenu.Click
        panelsliding.Visible = True
        pbmenu.Visible = False
        pbback.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbback.Click
        panelsliding.Visible = False
        pbback.Visible = False
        pbmenu.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub


    Dim ctr As Control
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        laporanbarang.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        laporannn.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles pbhome.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub brg_Click(sender As Object, e As EventArgs) Handles brg.Click

    End Sub

    Private Sub trns_Click(sender As Object, e As EventArgs) Handles trns.Click
        Me.Hide()
        transaksibaru.Show()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Me.Hide()
        laporannn.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        login.Show()
    End Sub
End Class