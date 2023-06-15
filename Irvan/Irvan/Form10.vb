Public Class Form10
    Sub Buat_Tabel_Mahasiswa()
        List_Mahasiswa.Columns.Add("No", 30, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Tanggal Pendaftaran", 130, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Nama Mahasiswa", 150, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("NPM", 80, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Jenjang", 50, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Jurusan", 150, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Biaya Pendidikan", 120, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Biaya Pendaftaran", 120, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Biaya SKS", 70, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Jumlah SKS", 70, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Total Biaya SKS", 100, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("Keterangan", 100, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("SUBTOTAL", 80, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("POTONGAN", 80, HorizontalAlignment.Center)
        List_Mahasiswa.Columns.Add("TOTAL", 80, HorizontalAlignment.Center)
        List_Mahasiswa.View = View.Details
        List_Mahasiswa.GridLines = True
        List_Mahasiswa.FullRowSelect = True
        List_Mahasiswa.BackColor = Color.SkyBlue
    End Sub

    Sub Isi_Tabel_Mahasiswa()
        Dim lst As New ListViewItem
        lst.Text = List_Mahasiswa.Items.Count + 1
        lst.SubItems.Add(Format(Now, "dd-MMM-yyyy"))
        lst.SubItems.Add(Nama.Text)
        lst.SubItems.Add(NPM.Text)
        lst.SubItems.Add(cmb_jenjang.Text)
        lst.SubItems.Add(Cmb_jurusan.Text)
        lst.SubItems.Add(Txt_biaya.Text)
        lst.SubItems.Add(txt_daftar.Text)
        lst.SubItems.Add(Txt_SKS.Text)
        lst.SubItems.Add(txt_jumlahSKS.Text)
        lst.SubItems.Add(Txt_bayarSKS.Text)
        lst.SubItems.Add(Potongan1.Text Or Potongan2.Text)
        lst.SubItems.Add(Txt_SUBTOTAL.Text)
        lst.SubItems.Add(Txt_potongan.Text)
        lst.SubItems.Add(Txt_Total.Text)
        List_Mahasiswa.Items.Add(lst)
    End Sub
    'MEMBUAT PERINTAH UNTUK MENGOSONGKAN SEMUA TOOLS
    Sub KOSONGKAN_KONTROL()
        Cmb_jurusan.Text = ""
        txt_jumlahSKS.Text = ""
        Txt_SKS.Text = ""
        Txt_bayarSKS.Text = ""
        Txt_SUBTOTAL.Text = ""
        Txt_potongan.Text = ""
        Txt_Total.Text = ""
        Potongan1.Checked = False
        Potongan2.Checked = False
        Potongan3.Checked = False
    End Sub
    Sub Matikan_Kontrol()
        Txt_biaya.Enabled = False
        txt_daftar.Enabled = False
        Txt_SKS.Enabled = False
        Txt_bayarSKS.Enabled = False
        Txt_SUBTOTAL.Enabled = False
        Txt_potongan.Enabled = False
        Txt_Total.Enabled = False
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Welcome As String
        Welcome = MessageBox.Show("Selamat Datang di STMIK MH.Thamrin, Jakarta.", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)

        NPM.Focus()
        cmb_jenjang.Items.Add("S1")
        cmb_jenjang.Items.Add("D3")
        Buat_Tabel_Mahasiswa()
        Matikan_Kontrol()
    End Sub

    Private Sub NPM_TextChanged(sender As Object, e As EventArgs) Handles NPM.TextChanged
        If NPM.Text = "10101001" Then
            Nama.Text = "Abimanyu Pradipta"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101002" Then
            Nama.Text = "Keysha Rifana"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101003" Then
            Nama.Text = "Rina Nurhandani"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101004" Then
            Nama.Text = "Mochamad Irvan"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101005" Then
            Nama.Text = "Edward Bona"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101006" Then
            Nama.Text = "Kamil Rustandi"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101007" Then
            Nama.Text = "Adi Putra"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101008" Then
            Nama.Text = "Nabila Putri"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101009" Then
            Nama.Text = "Gerry Putra"
            Nama.Enabled = False
        ElseIf NPM.Text = "10101000" Then
            Nama.Text = "Galih Hadi"
            Nama.Enabled = False

        Else
            Nama.Text = "TIDAK TERDAFTAR"
            Nama.Enabled = True
        End If
    End Sub
    Private Sub cmb_jenjang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenjang.SelectedIndexChanged
        If cmb_jenjang.Text = "S1" Then
            Call Matikan_Kontrol()
            Call KOSONGKAN_KONTROL()
            Cmb_jurusan.Items.Clear()
            Cmb_jurusan.Items.Add("Teknik Informatika")
            Cmb_jurusan.Items.Add("Sistem Informasi")
        ElseIf cmb_jenjang.Text = "D3" Then
            Call Matikan_Kontrol()
            Call KOSONGKAN_KONTROL()
            Cmb_jurusan.Items.Clear()
            Cmb_jurusan.Items.Add("Management Informatika")
            Cmb_jurusan.Items.Add("Komputerisasi Akuntasi")
            Cmb_jurusan.Items.Add("Teknik Komputer")
        End If

        Select Case cmb_jenjang.Text
            Case "S1" : txt_daftar.Text = 150000
            Case "D3" : txt_daftar.Text = 75000
        End Select

        Select Case cmb_jenjang.Text
            Case "S1" : Txt_SKS.Text = 150000
            Case "D3" : Txt_SKS.Text = 75000
        End Select

    End Sub
    Private Sub Cmb_jurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_jurusan.SelectedIndexChanged

        Select Case Cmb_jurusan.Text
            Case "Sistem Informasi" : Txt_biaya.Text = 2500000
            Case "Teknik Informatika" : Txt_biaya.Text = 2750000
            Case "Management Informatika" : Txt_biaya.Text = 1500000
            Case "Komputerisasi Akuntasi" : Txt_biaya.Text = 1650000
            Case "Teknik Komputer" : Txt_biaya.Text = 1250000
        End Select

    End Sub


    Private Sub txt_jumlahSKS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlahSKS.KeyPress
        Txt_bayarSKS.Text = Val(txt_jumlahSKS.Text) * Val(Txt_SKS.Text)
        Txt_SUBTOTAL.Text = Val(txt_daftar.Text) + Val(Txt_bayarSKS.Text) + Val(Txt_biaya.Text)
    End Sub

    Private Sub Potongan1_CheckedChanged(sender As Object, e As EventArgs) Handles Potongan1.CheckedChanged
        If Me.Potongan1.Checked = True Then
            Me.Txt_potongan.Text = Val(Txt_SUBTOTAL.Text) * 50 / 100
        End If
        Txt_Total.Text = Val(Txt_SUBTOTAL.Text) - Val(Txt_potongan.Text)
    End Sub

    Private Sub Potongan2_CheckedChanged(sender As Object, e As EventArgs) Handles Potongan2.CheckedChanged
        If Me.Potongan2.Checked = True Then
            Me.Txt_potongan.Text = Val(Txt_SUBTOTAL.Text) * 10 / 100
        End If
        Txt_Total.Text = Val(Txt_SUBTOTAL.Text) - Val(Txt_potongan.Text)
    End Sub

    Private Sub Potongan3_CheckedChanged(sender As Object, e As EventArgs) Handles Potongan3.CheckedChanged
        If Me.Potongan3.Checked = True Then
            Me.Txt_potongan.Text = 0
        End If
        Txt_Total.Text = Val(Txt_SUBTOTAL.Text) - Val(Txt_potongan.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = vbYes Then
            Me.Close()
        Else
            MsgBox("Silahkan Lanjut")
            NPM.Focus()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call KOSONGKAN_KONTROL()
        Call Matikan_Kontrol()
        Nama.Text = ""
        NPM.Text = ""
        Txt_biaya.Text = ""
        txt_daftar.Text = ""
        cmb_jenjang.Text = ""

        NPM.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(Me.txt_jumlahSKS.Text) = False Then
            MsgBox("JUMLAH SKS BELUM DIISI", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Call Isi_Tabel_Mahasiswa()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Hitung As Integer
        For i As Integer = 0 To List_Mahasiswa.Items.Count - 1
            Hitung = Hitung + List_Mahasiswa.Items(i).SubItems(13).Text

        Next
        Txt_pemasukan.Text = Hitung
    End Sub
End Class