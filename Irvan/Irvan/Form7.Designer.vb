<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.cmb_kode = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis = New System.Windows.Forms.ComboBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.list_transaksi = New System.Windows.Forms.ListView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_bayar = New System.Windows.Forms.TextBox()
        Me.txt_kembali = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.list_laporan = New System.Windows.Forms.ListView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txt_pemasukan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'cmb_kode
        '
        Me.cmb_kode.FormattingEnabled = True
        Me.cmb_kode.Location = New System.Drawing.Point(142, 66)
        Me.cmb_kode.Name = "cmb_kode"
        Me.cmb_kode.Size = New System.Drawing.Size(174, 24)
        Me.cmb_kode.TabIndex = 5
        '
        'cmb_jenis
        '
        Me.cmb_jenis.FormattingEnabled = True
        Me.cmb_jenis.Location = New System.Drawing.Point(142, 26)
        Me.cmb_jenis.Name = "cmb_jenis"
        Me.cmb_jenis.Size = New System.Drawing.Size(174, 24)
        Me.cmb_jenis.TabIndex = 6
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(142, 108)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(174, 22)
        Me.txt_nama.TabIndex = 7
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(142, 146)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(174, 22)
        Me.txt_harga.TabIndex = 8
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(142, 181)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(174, 22)
        Me.txt_jumlah.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "INPUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "CLEAR ITEM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(211, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "CLEAR ALL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'list_transaksi
        '
        Me.list_transaksi.HideSelection = False
        Me.list_transaksi.Location = New System.Drawing.Point(19, 281)
        Me.list_transaksi.Name = "list_transaksi"
        Me.list_transaksi.Size = New System.Drawing.Size(510, 213)
        Me.list_transaksi.TabIndex = 13
        Me.list_transaksi.UseCompatibleStateImageBehavior = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(19, 517)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "NEW"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(95, 517)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "CANCEL"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(192, 518)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 23)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "TOTAL BAYAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(333, 518)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(196, 22)
        Me.txt_total.TabIndex = 17
        '
        'txt_bayar
        '
        Me.txt_bayar.Location = New System.Drawing.Point(333, 554)
        Me.txt_bayar.Name = "txt_bayar"
        Me.txt_bayar.Size = New System.Drawing.Size(196, 22)
        Me.txt_bayar.TabIndex = 18
        '
        'txt_kembali
        '
        Me.txt_kembali.Location = New System.Drawing.Point(333, 591)
        Me.txt_kembali.Name = "txt_kembali"
        Me.txt_kembali.Size = New System.Drawing.Size(196, 22)
        Me.txt_kembali.TabIndex = 19
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 641)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(517, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "CLOSE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 559)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTAL TUNAI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 596)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "KEMBALI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(722, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 38)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "LAPORAN PENJUALAN"
        '
        'list_laporan
        '
        Me.list_laporan.HideSelection = False
        Me.list_laporan.Location = New System.Drawing.Point(587, 115)
        Me.list_laporan.Name = "list_laporan"
        Me.list_laporan.Size = New System.Drawing.Size(695, 522)
        Me.list_laporan.TabIndex = 24
        Me.list_laporan.UseCompatibleStateImageBehavior = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(587, 644)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(114, 23)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "CLEAR ITEM"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(921, 644)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(160, 23)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "TOTAL PEMASUKAN"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txt_pemasukan
        '
        Me.txt_pemasukan.Location = New System.Drawing.Point(1087, 645)
        Me.txt_pemasukan.Name = "txt_pemasukan"
        Me.txt_pemasukan.Size = New System.Drawing.Size(195, 22)
        Me.txt_pemasukan.TabIndex = 27
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 757)
        Me.Controls.Add(Me.txt_pemasukan)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.list_laporan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.txt_kembali)
        Me.Controls.Add(Me.txt_bayar)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.list_transaksi)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_jumlah)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.cmb_jenis)
        Me.Controls.Add(Me.cmb_kode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_kode As ComboBox
    Friend WithEvents cmb_jenis As ComboBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents list_transaksi As ListView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_bayar As TextBox
    Friend WithEvents txt_kembali As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents list_laporan As ListView
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents txt_pemasukan As TextBox
End Class
