<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kd_pelanggan = New System.Windows.Forms.ComboBox()
        Me.total_tagihan = New System.Windows.Forms.TextBox()
        Me.pembayaran = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.tipe = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jml_pemakaian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.daerah = New System.Windows.Forms.TextBox()
        Me.biaya_beban = New System.Windows.Forms.TextBox()
        Me.pajak = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.LV = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAGIHAN AIR MINUM PDAM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga M3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Pemakaian"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Tagihan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pembayaran"
        '
        'kd_pelanggan
        '
        Me.kd_pelanggan.FormattingEnabled = True
        Me.kd_pelanggan.Location = New System.Drawing.Point(164, 68)
        Me.kd_pelanggan.Name = "kd_pelanggan"
        Me.kd_pelanggan.Size = New System.Drawing.Size(121, 24)
        Me.kd_pelanggan.TabIndex = 8
        '
        'total_tagihan
        '
        Me.total_tagihan.Location = New System.Drawing.Point(164, 262)
        Me.total_tagihan.Name = "total_tagihan"
        Me.total_tagihan.Size = New System.Drawing.Size(121, 22)
        Me.total_tagihan.TabIndex = 9
        '
        'pembayaran
        '
        Me.pembayaran.Location = New System.Drawing.Point(164, 300)
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.Size = New System.Drawing.Size(121, 22)
        Me.pembayaran.TabIndex = 10
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(164, 109)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(121, 22)
        Me.nama.TabIndex = 11
        '
        'tipe
        '
        Me.tipe.Location = New System.Drawing.Point(164, 142)
        Me.tipe.Name = "tipe"
        Me.tipe.Size = New System.Drawing.Size(121, 22)
        Me.tipe.TabIndex = 12
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(164, 182)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(121, 22)
        Me.harga.TabIndex = 13
        '
        'jml_pemakaian
        '
        Me.jml_pemakaian.Location = New System.Drawing.Point(164, 224)
        Me.jml_pemakaian.Name = "jml_pemakaian"
        Me.jml_pemakaian.Size = New System.Drawing.Size(121, 22)
        Me.jml_pemakaian.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Daerah"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Biaya Beban"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(396, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Pajak"
        '
        'daerah
        '
        Me.daerah.Location = New System.Drawing.Point(505, 70)
        Me.daerah.Name = "daerah"
        Me.daerah.Size = New System.Drawing.Size(181, 22)
        Me.daerah.TabIndex = 18
        '
        'biaya_beban
        '
        Me.biaya_beban.Location = New System.Drawing.Point(505, 104)
        Me.biaya_beban.Name = "biaya_beban"
        Me.biaya_beban.Size = New System.Drawing.Size(181, 22)
        Me.biaya_beban.TabIndex = 19
        '
        'pajak
        '
        Me.pajak.Location = New System.Drawing.Point(505, 142)
        Me.pajak.Name = "pajak"
        Me.pajak.Size = New System.Drawing.Size(181, 22)
        Me.pajak.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(399, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Simpan Listview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(538, 185)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 22
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(619, 185)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 23
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(34, 378)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(738, 226)
        Me.LV.TabIndex = 24
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 644)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pajak)
        Me.Controls.Add(Me.biaya_beban)
        Me.Controls.Add(Me.daerah)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.jml_pemakaian)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.tipe)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.pembayaran)
        Me.Controls.Add(Me.total_tagihan)
        Me.Controls.Add(Me.kd_pelanggan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUIZ PDAM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents kd_pelanggan As ComboBox
    Friend WithEvents total_tagihan As TextBox
    Friend WithEvents pembayaran As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents tipe As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents jml_pemakaian As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents daerah As TextBox
    Friend WithEvents biaya_beban As TextBox
    Friend WithEvents pajak As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents LV As ListView
End Class
