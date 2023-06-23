<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kodebrg = New System.Windows.Forms.TextBox()
        Me.namabrg = New System.Windows.Forms.TextBox()
        Me.hargabeli = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.satuan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hargajual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jenis = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbhome = New System.Windows.Forms.PictureBox()
        Me.pbback = New System.Windows.Forms.PictureBox()
        Me.pbmenu = New System.Windows.Forms.PictureBox()
        Me.panelsliding = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.laporan = New System.Windows.Forms.Button()
        Me.trns = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.brg = New System.Windows.Forms.Button()
        Me.DGVstockbarang = New System.Windows.Forms.DataGridView()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbhome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelsliding.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVstockbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stok Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(523, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga Beli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 237)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jumlah"
        '
        'kodebrg
        '
        Me.kodebrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebrg.Location = New System.Drawing.Point(305, 124)
        Me.kodebrg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kodebrg.Name = "kodebrg"
        Me.kodebrg.Size = New System.Drawing.Size(184, 23)
        Me.kodebrg.TabIndex = 6
        '
        'namabrg
        '
        Me.namabrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namabrg.Location = New System.Drawing.Point(305, 162)
        Me.namabrg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.namabrg.Name = "namabrg"
        Me.namabrg.Size = New System.Drawing.Size(184, 23)
        Me.namabrg.TabIndex = 7
        '
        'hargabeli
        '
        Me.hargabeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hargabeli.Location = New System.Drawing.Point(637, 168)
        Me.hargabeli.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.hargabeli.Name = "hargabeli"
        Me.hargabeli.Size = New System.Drawing.Size(183, 23)
        Me.hargabeli.TabIndex = 8
        '
        'jumlah
        '
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(305, 233)
        Me.jumlah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(184, 23)
        Me.jumlah.TabIndex = 9
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(225, 269)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(119, 28)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(388, 269)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(121, 28)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(555, 269)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(113, 28)
        Me.btnUbah.TabIndex = 13
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(705, 269)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'satuan
        '
        Me.satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.satuan.Location = New System.Drawing.Point(637, 129)
        Me.satuan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(183, 23)
        Me.satuan.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Satuan"
        '
        'hargajual
        '
        Me.hargajual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hargajual.Location = New System.Drawing.Point(637, 213)
        Me.hargajual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.hargajual.Name = "hargajual"
        Me.hargajual.Size = New System.Drawing.Size(183, 23)
        Me.hargajual.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(523, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Harga Jual"
        '
        'jenis
        '
        Me.jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis.Location = New System.Drawing.Point(305, 198)
        Me.jenis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(184, 23)
        Me.jenis.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 201)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Jenis"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.pbhome)
        Me.Panel1.Controls.Add(Me.pbback)
        Me.Panel1.Controls.Add(Me.pbmenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 33)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FinalProject1.My.Resources.Resources._9_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(785, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'pbhome
        '
        Me.pbhome.Image = Global.FinalProject1.My.Resources.Resources._22_removebg_preview
        Me.pbhome.Location = New System.Drawing.Point(34, 0)
        Me.pbhome.Name = "pbhome"
        Me.pbhome.Size = New System.Drawing.Size(34, 32)
        Me.pbhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbhome.TabIndex = 25
        Me.pbhome.TabStop = False
        '
        'pbback
        '
        Me.pbback.Image = Global.FinalProject1.My.Resources.Resources._9_removebg_preview
        Me.pbback.Location = New System.Drawing.Point(0, 1)
        Me.pbback.Name = "pbback"
        Me.pbback.Size = New System.Drawing.Size(34, 31)
        Me.pbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbback.TabIndex = 24
        Me.pbback.TabStop = False
        '
        'pbmenu
        '
        Me.pbmenu.Image = Global.FinalProject1.My.Resources.Resources._11_removebg_preview
        Me.pbmenu.Location = New System.Drawing.Point(0, 0)
        Me.pbmenu.Name = "pbmenu"
        Me.pbmenu.Size = New System.Drawing.Size(34, 32)
        Me.pbmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbmenu.TabIndex = 23
        Me.pbmenu.TabStop = False
        '
        'panelsliding
        '
        Me.panelsliding.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.panelsliding.Controls.Add(Me.Label9)
        Me.panelsliding.Controls.Add(Me.PictureBox7)
        Me.panelsliding.Controls.Add(Me.PictureBox5)
        Me.panelsliding.Controls.Add(Me.PictureBox4)
        Me.panelsliding.Controls.Add(Me.laporan)
        Me.panelsliding.Controls.Add(Me.trns)
        Me.panelsliding.Controls.Add(Me.PictureBox3)
        Me.panelsliding.Controls.Add(Me.brg)
        Me.panelsliding.Location = New System.Drawing.Point(0, 33)
        Me.panelsliding.Name = "panelsliding"
        Me.panelsliding.Size = New System.Drawing.Size(182, 418)
        Me.panelsliding.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hanifah"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.FinalProject1.My.Resources.Resources._764_removebg_preview
        Me.PictureBox7.Location = New System.Drawing.Point(51, 7)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(74, 69)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.PictureBox5.Image = Global.FinalProject1.My.Resources.Resources._1_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(17, 177)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.PictureBox4.Image = Global.FinalProject1.My.Resources.Resources._4_removebg_preview
        Me.PictureBox4.Location = New System.Drawing.Point(17, 141)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'laporan
        '
        Me.laporan.BackColor = System.Drawing.Color.MediumAquamarine
        Me.laporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.laporan.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.laporan.Location = New System.Drawing.Point(0, 173)
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(182, 33)
        Me.laporan.TabIndex = 13
        Me.laporan.Text = "Laporan"
        Me.laporan.UseVisualStyleBackColor = False
        '
        'trns
        '
        Me.trns.BackColor = System.Drawing.Color.MediumAquamarine
        Me.trns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.trns.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.trns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trns.Location = New System.Drawing.Point(0, 138)
        Me.trns.Name = "trns"
        Me.trns.Size = New System.Drawing.Size(182, 33)
        Me.trns.TabIndex = 12
        Me.trns.Text = "Transaksi"
        Me.trns.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Ivory
        Me.PictureBox3.Image = Global.FinalProject1.My.Resources.Resources.package_removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(17, 107)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'brg
        '
        Me.brg.BackColor = System.Drawing.Color.Ivory
        Me.brg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brg.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.brg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.brg.Location = New System.Drawing.Point(0, 104)
        Me.brg.Name = "brg"
        Me.brg.Size = New System.Drawing.Size(182, 33)
        Me.brg.TabIndex = 10
        Me.brg.Text = "Barang"
        Me.brg.UseVisualStyleBackColor = False
        '
        'DGVstockbarang
        '
        Me.DGVstockbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVstockbarang.Location = New System.Drawing.Point(225, 316)
        Me.DGVstockbarang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGVstockbarang.Name = "DGVstockbarang"
        Me.DGVstockbarang.RowHeadersWidth = 51
        Me.DGVstockbarang.RowTemplate.Height = 24
        Me.DGVstockbarang.Size = New System.Drawing.Size(594, 118)
        Me.DGVstockbarang.TabIndex = 0
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.FinalProject1.My.Resources.Resources.MBAKPA3
        Me.PictureBox9.Location = New System.Drawing.Point(194, 53)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(185, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 71
        Me.PictureBox9.TabStop = False
        '
        'barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(827, 449)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.panelsliding)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hargajual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.hargabeli)
        Me.Controls.Add(Me.namabrg)
        Me.Controls.Add(Me.kodebrg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVstockbarang)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "barang"
        Me.Text = "barang"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbhome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelsliding.ResumeLayout(False)
        Me.panelsliding.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVstockbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kodebrg As TextBox
    Friend WithEvents namabrg As TextBox
    Friend WithEvents hargabeli As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents satuan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents hargajual As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents jenis As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelsliding As Panel
    Friend WithEvents pbmenu As PictureBox
    Friend WithEvents pbback As PictureBox
    Friend WithEvents pbhome As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents laporan As Button
    Friend WithEvents trns As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents brg As Button
    Friend WithEvents DGVstockbarang As DataGridView
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
