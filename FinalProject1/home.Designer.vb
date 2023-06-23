<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnstok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntransaksi = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.ForeColor = System.Drawing.Color.White
        Me.btnlaporan.Location = New System.Drawing.Point(645, 437)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(204, 69)
        Me.btnlaporan.TabIndex = 0
        Me.btnlaporan.Text = "Lihat Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'btnstok
        '
        Me.btnstok.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnstok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstok.ForeColor = System.Drawing.Color.White
        Me.btnstok.Location = New System.Drawing.Point(92, 437)
        Me.btnstok.Name = "btnstok"
        Me.btnstok.Size = New System.Drawing.Size(204, 69)
        Me.btnstok.TabIndex = 1
        Me.btnstok.Text = "Stok Barang"
        Me.btnstok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome, Mbak Pa!"
        '
        'btntransaksi
        '
        Me.btntransaksi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btntransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransaksi.ForeColor = System.Drawing.Color.White
        Me.btntransaksi.Location = New System.Drawing.Point(366, 437)
        Me.btntransaksi.Name = "btntransaksi"
        Me.btntransaksi.Size = New System.Drawing.Size(204, 69)
        Me.btntransaksi.TabIndex = 3
        Me.btntransaksi.Text = "Transaksi"
        Me.btntransaksi.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(831, 623)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(116, 52)
        Me.btnlogout.TabIndex = 4
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FinalProject1.My.Resources.Resources.lihat_laporann
        Me.PictureBox3.Location = New System.Drawing.Point(645, 239)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(204, 161)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FinalProject1.My.Resources.Resources.transaksii
        Me.PictureBox2.Location = New System.Drawing.Point(360, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 161)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalProject1.My.Resources.Resources.stockkk
        Me.PictureBox1.Location = New System.Drawing.Point(79, 239)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 691)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btntransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnstok)
        Me.Controls.Add(Me.btnlaporan)
        Me.Name = "home"
        Me.Text = "home"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlaporan As Button
    Friend WithEvents btnstok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btntransaksi As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
