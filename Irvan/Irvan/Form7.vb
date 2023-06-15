Public Class Form7

    'Membuat Struktur Tabel Transaksi
    Sub Buat_tabel_TRANSAKSI()
        list_transaksi.Columns.Add("Kode Barang", 80, HorizontalAlignment.Center)
        list_transaksi.Columns.Add("Nama Barang", 80, HorizontalAlignment.Center)
        list_transaksi.Columns.Add("Harga", 80, HorizontalAlignment.Center)
        list_transaksi.Columns.Add("Jumlah", 50, HorizontalAlignment.Center)
        list_transaksi.Columns.Add("subtotal", 80, HorizontalAlignment.Center)
        list_transaksi.View = View.Details
        list_transaksi.GridLines = True
        list_transaksi.FullRowSelect = True
        list_transaksi.BackColor = Color.CornflowerBlue
    End Sub

    'MEMBUAT STRUKTUR TABEL LAPORAN
    Sub Buat_Tabel_LAPORAN()
        list_laporan.Columns.Add("Tanggal Pembelian", 125, HorizontalAlignment.Center)
        list_laporan.Columns.Add("Kode Barang", 80, HorizontalAlignment.Center)
        list_laporan.Columns.Add("Nama Barang", 80, HorizontalAlignment.Center)
        list_laporan.Columns.Add("Harga", 80, HorizontalAlignment.Center)
        list_laporan.Columns.Add("Jumlah", 50, HorizontalAlignment.Center)
        list_laporan.Columns.Add("Subtotal", 80, HorizontalAlignment.Center)
        list_laporan.View = View.Details
        list_laporan.GridLines = True
        list_laporan.FullRowSelect = True
        list_laporan.BackColor = Color.Coral
    End Sub
    'MEMBUAT PERINTAH UNTUK MENGISI TABEL TRANSAKSI DARI DATA YANG TELAHH DI DINPUT
    Sub Isi_Tabel_TRANSAKSI()
        Dim isi As New ListViewItem
        isi.Text = cmb_kode.Text
        isi.SubItems.Add(txt_nama.Text)
        isi.SubItems.Add(txt_harga.Text)
        isi.SubItems.Add(txt_jumlah.Text)
        isi.SubItems.Add(Val(txt_harga.Text) * Val(txt_jumlah.Text))
        list_transaksi.Items.Add(isi)
    End Sub
    'MEMBUAT PERINTAH UNTUK MENGISI TABEL LAPORAN DARI DATA YANG TELAH DI INPUT
    Sub Isi_Tabel_LAPORAN()
        Dim isi As New ListViewItem
        isi.Text = Format(Now, "dd-MMM-yyyy")
        isi.SubItems.Add(cmb_kode.Text)
        isi.SubItems.Add(txt_nama.Text)
        isi.SubItems.Add(txt_harga.Text)
        isi.SubItems.Add(txt_jumlah.Text)
        isi.SubItems.Add(Val(txt_harga.Text) * Val(txt_jumlah.Text))
        list_laporan.Items.Add(isi)
    End Sub
    'MEMBUAT PERINTAH UNTUK MENGOSONGKAN SEMUA TOOLS
    Sub KOSONGKAN_KONTROL()
        cmb_kode.Text = ""
        txt_nama.Text = ""
        txt_harga.Text = ""
        txt_jumlah.Text = ""
        txt_total.Text = ""
        txt_kembali.Text = ""
        txt_bayar.Text = ""
    End Sub
    'MEMBUAT PERINTAH UNTUK MEMATIKAN FUNGSI INPUT DARI TOOLS
    Sub MATIKAN_KONTROL()
        txt_nama.Enabled = False
        txt_harga.Enabled = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'FUNGSI = MENGOSONGKAN TABEL TRANSAKSI DAN TOOLS LAINNYA (MEMBUAT INPUT DATA BARU)
        'LALU MELETAKAN KURSOR PADA CMB JENIS
        list_transaksi.Items.Clear()
        Call KOSONGKAN_KONTROL()
        Call MATIKAN_KONTROL()
        cmb_jenis.Select()
        cmb_jenis.Text = ""
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MEMANGGIL PERINTAH BUAT TABEL TRANSAKSI, BUAT TABEL LAPORAN,MATIKAN KONTROL
        'FUNGSI CODING DIBAWAH ADALAH
        '1. SAAT FORM DIJALANKAN, TABEL TRANSAKSI DAN TABEL LAPORAN AKAN TERBENTUK
        '2 TEXT BOX NAMA DAN HARGA TIDAK BISA DI INPUT
        '3 KURSOR AKAN BERADA PADA COMBO BOX JENIS
        Call Buat_tabel_TRANSAKSI()
        Call Buat_Tabel_LAPORAN()
        Call MATIKAN_KONTROL()
        cmb_jenis.Select()
    End Sub

    Private Sub cmb_jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis.SelectedIndexChanged

    End Sub

    Private Sub cmb_jenis_Click(sender As Object, e As EventArgs) Handles cmb_jenis.Click
        cmb_jenis.Items.Clear()
        cmb_jenis.Items.Add("Makanan")
        cmb_jenis.Items.Add("Minuman")
        cmb_jenis.Items.Add("Sembako")
        cmb_jenis.Items.Add("Data Baru")
    End Sub

    Private Sub cmb_jenis_TextChanged(sender As Object, e As EventArgs) Handles cmb_jenis.TextChanged
        'FUNGSI = MENGATUR ISI DARI COMBO BOX KODE BARANG DARI JENIS BARANG YANG DIPILIH
        If cmb_jenis.Text = "Makanan" Then
            Call KOSONGKAN_KONTROL()
            Call MATIKAN_KONTROL()
            cmb_kode.Items.Clear()
            cmb_kode.Items.Add("MK001")
            cmb_kode.Items.Add("MK002")
            cmb_kode.Items.Add("MK003")

        ElseIf cmb_jenis.Text = "Minuman" Then
            Call KOSONGKAN_KONTROL()
            Call MATIKAN_KONTROL()
            cmb_kode.Items.Clear()
            cmb_kode.Items.Add("N001")
            cmb_kode.Items.Add("N002")
            cmb_kode.Items.Add("N003")

        ElseIf cmb_jenis.Text = "Sembako" Then
            Call KOSONGKAN_KONTROL()
            Call MATIKAN_KONTROL()
            cmb_kode.Items.Clear()
            cmb_kode.Items.Add("S001")
            cmb_kode.Items.Add("S002")
            cmb_kode.Items.Add("S003")
            Call MATIKAN_KONTROL()

        ElseIf cmb_jenis.Text = "Data Baru" Then
            Call KOSONGKAN_KONTROL()
            cmb_kode.Items.Clear()
            txt_nama.Enabled = True
            txt_harga.Enabled = True

        End If
    End Sub

    Private Sub cmb_kode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_kode.SelectedIndexChanged

    End Sub

    Private Sub cmb_kode_TextChanged(sender As Object, e As EventArgs) Handles cmb_kode.TextChanged
        'FUNGSI = MENGATUR ISI NAMA BARANG DAN HARGA BARANG DARI KODE BARANG YANG DI INPUT
        Select Case cmb_kode.Text
            Case "MK001" : txt_nama.Text = "INDOMIE GORENG" : txt_harga.Text = 3500
            Case "MK002" : txt_nama.Text = "BISKUIT" : txt_harga.Text = 6500
            Case "MK003" : txt_nama.Text = "INDOMIE REBUS" : txt_harga.Text = 3000
            Case "N001" : txt_nama.Text = "SUSU" : txt_harga.Text = 4000
            Case "N002" : txt_nama.Text = "COLA" : txt_harga.Text = 2000
            Case "N003" : txt_nama.Text = "KOPI" : txt_harga.Text = 1500
            Case "S001" : txt_nama.Text = "BERAS 25KG" : txt_harga.Text = 25000
            Case "S002" : txt_nama.Text = "GULA PASIR" : txt_harga.Text = 8000
            Case "S003" : txt_nama.Text = "MINYAK" : txt_harga.Text = 20000

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'FUNGSI = MENGATUR TEXTBOX JUMLAH HANYA BISA DIISI DENGAN ANGKA
        'MEMANGGIL PERINTAH MENGISI TABEL TRANSAKSI DAN LAPORAN
        If IsNumeric(Me.txt_jumlah.Text) = False Then
            MsgBox("JUMLAH BELUM DI ISI", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Call Isi_Tabel_TRANSAKSI()
        Call Isi_Tabel_LAPORAN()

        cmb_jenis.Text = ""
        cmb_kode.Text = ""
        txt_nama.Text = ""
        txt_harga.Text = ""
        txt_jumlah.Text = ""
        cmb_kode.Select()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'FUNGSI = MENGHIUNG TOTAL NILAI YANG TERDAPAT PADA KOLOM SUBTOTAL TABEL TRANSAKSI

        Dim Hitung As Integer
        For i As Integer = 0 To list_transaksi.Items.Count - 1
            Hitung = Hitung + list_transaksi.Items(i).SubItems(4).Text
        Next
        'MENAMPILKAN HASIL DARI TOTAL BAYAR
        txt_total.Text = Hitung
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'FUNGSI = MENGHAPUS SALAH SATU DARI BARIS YANG TERDAPAT PADA TABEL TRANSAKSI
        Try
            'KODING HAPUS ITEM PERBARIS PADA LIST VIEW
            list_transaksi.Items.Remove(list_transaksi.SelectedItems(0))
        Catch
            MsgBox("PILIH ITEM TRANSAKSI YANG MAU DIHAPUS")
        Finally
            Call KOSONGKAN_KONTROL()

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'FUNGSI MENGOSONGKAN ISI TABEL TRANSAKSI
        list_transaksi.Items.Clear()
    End Sub

    Private Sub txt_bayar_TextChanged(sender As Object, e As EventArgs) Handles txt_bayar.TextChanged
        'FUNGSI = MENGHITUNG TOTAL TUNAI DIKURANG TOTAL BAYAR (UNTUK MENAMPILKAN UANG KEMBALIAN)
        txt_kembali.Text = Val(txt_bayar.Text) - Val(txt_total.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'FUNGSI = MEMBATALKAN TRANSAKSI DAN MENGOSONGKAN ISI DARI TOOLS
        ' DENGAN MEMANGGIL PERINTAH KOSONGKAN KONTROL
        Call KOSONGKAN_KONTROL()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'FUNGSI = MENGHITUNG TOTAL NILAI YANG TERDAPAT PADA KOLOM SUBTOTAL TABEL LAPORAN
        Dim Hitung As Integer
        For i As Integer = 0 To list_laporan.Items.Count - 1
            Hitung = Hitung + list_laporan.Items(i).SubItems(5).Text

        Next
        txt_pemasukan.Text = Hitung
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'FUNGSI = MENGHAPUS SALAH SATU BARIS YANG TERDAPAT PADA TABEL LAPORAN
        Try
            'KODING HAPUS ITEM PERBARIS PADA LIST VIEW
            list_laporan.Items.Remove(list_laporan.SelectedItems(0))
        Catch
            MsgBox("PILIH ITEM LAPORAN YANG INGIN DI HAPUS")
        Finally
            Call KOSONGKAN_KONTROL()
        End Try
        'REFRESH TOTAL PEMASUKAN
        Dim HITUNG As Integer
        For i As Integer = 0 To list_laporan.Items.Count - 1
            HITUNG = HITUNG + list_laporan.Items(i).SubItems(5).Text
        Next
        'MENAMPILAKAN HASIL DARI SUBTOTAL DI LIST CIEW PEMASUKAN
        txt_pemasukan.Text = HITUNG
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()

        End If
    End Sub

    Private Sub txt_nama_TextChanged(sender As Object, e As EventArgs) Handles txt_nama.TextChanged

    End Sub

    Private Sub txt_pemasukan_TextChanged(sender As Object, e As EventArgs) Handles txt_pemasukan.TextChanged

    End Sub
End Class