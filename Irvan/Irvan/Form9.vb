Public Class Form9

    Sub buattable()
        'MEMBUAT MODULE UNTUK STRUKTUR PADA TABEL LIST VIEW
        LV.Columns.Add("No", 40, HorizontalAlignment.Left)
        LV.Columns.Add("Kode", 90, HorizontalAlignment.Left)
        LV.Columns.Add("Tipe", 100, HorizontalAlignment.Left)
        LV.Columns.Add("Harga", 100, HorizontalAlignment.Left)
        LV.Columns.Add("Jml Pemakaian", 100, HorizontalAlignment.Left)
        LV.Columns.Add("Daerah", 100, HorizontalAlignment.Left)
        LV.Columns.Add("Biaya Beban", 180, HorizontalAlignment.Left)
        LV.Columns.Add("Pajak", 100, HorizontalAlignment.Left)
        LV.Columns.Add("Pembayaran", 100, HorizontalAlignment.Left)
        LV.Columns.Add("Total Tagihan", 100, HorizontalAlignment.Left)
        LV.View = View.Details
        LV.GridLines = True
        LV.FullRowSelect = True

    End Sub
    'MEMBUAT MODULE UNTUK MENGISI TABEL LISTVIEW
    Sub isitable()
        Dim lst As New ListViewItem
        lst.Text = LV.Items.Count + 1
        lst.SubItems.Add(kd_pelanggan.Text)
        lst.SubItems.Add(tipe.Text)
        lst.SubItems.Add(harga.Text)
        lst.SubItems.Add(jml_pemakaian.Text)
        lst.SubItems.Add(daerah.Text)
        lst.SubItems.Add(biaya_beban.Text)
        lst.SubItems.Add(pajak.Text)
        lst.SubItems.Add(pembayaran.Text)
        lst.SubItems.Add(total_tagihan.Text)
        LV.Items.Add(lst)
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MEMANGGIL MODUL CODING BUAT TABEL  
        buattable()
        'CODING UNTUK KETENTUAN NOMOR 1 
        kd_pelanggan.Items.Add("PAB-MED-100")
        kd_pelanggan.Items.Add("RUM-MED-101")
        kd_pelanggan.Items.Add("TOK-BEL-102")
        kd_pelanggan.Items.Add("SWA-MED-103")

    End Sub

    Private Sub kd_pelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kd_pelanggan.SelectedIndexChanged
        Dim x As String
        'CODING UNTUK KETENTUAN NOMOR 2 
        x = Microsoft.VisualBasic.Right(kd_pelanggan.Text, 3)
        Select Case x
            Case "100" : nama.Text = "UCOK"
            Case "101" : nama.Text = "JHAN F"
            Case "102" : nama.Text = "ERIN"
            Case "103" : nama.Text = "ERIN"
        End Select
        'CODING UNTUK KETENTUAN NOMOR 3 
        x = Microsoft.VisualBasic.Left(kd_pelanggan.Text, 3)
        Select Case x
            Case "TOK"
                harga.Text = 250
                biaya_beban.Text = 15000
                tipe.Text = "TOKO"
            Case "RUM"
                harga.Text = 150
                biaya_beban.Text = 10000
                tipe.Text = "RUMAN"
            Case "PAB"
                harga.Text = 25000
                biaya_beban.Text = 25000
                tipe.Text = "PABRIK"
            Case "SWA"
                harga.Text = 20000
                biaya_beban.Text = 60000
                tipe.Text = "SWALAYAN"
        End Select
        'CODING UNTUK KETENTUAN NOMOR 4 
        x = Microsoft.VisualBasic.Mid(kd_pelanggan.Text, 5, 3)
        Select Case x
            Case "MED" : daerah.Text = "Medan"
            Case "BEL" : daerah.Text = "Belawan"
            Case Else : daerah.Text = "-"
        End Select
    End Sub

    Private Sub jml_pemakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jml_pemakaian.KeyPress
        If jml_pemakaian.Text = "" Then
            jml_pemakaian.Focus()
        ElseIf Asc(e.KeyChar) = 13 Then
            total_tagihan.Text = Val(biaya_beban.Text) + (harga.Text * jml_pemakaian.Text)
            pajak.Text = 0.01 * total_tagihan.Text
            pembayaran.Text = Val(total_tagihan.Text) + Val(pajak.Text)
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        kd_pelanggan.Text = ""
        nama.Text = ""
        tipe.Text = ""
        harga.Text = ""
        jml_pemakaian.Text = ""
        total_tagihan.Text = ""
        pembayaran.Text = ""
        daerah.Text = ""
        biaya_beban.Text = ""
        pajak.Text = ""


    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Dim k As String
        k = MsgBox("Apakah Anda yakin Ingin Keluar", MsgBoxStyle.YesNo)
        If k = vbYes Then
            Me.Close()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isitable()
    End Sub
End Class