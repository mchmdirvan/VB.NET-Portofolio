Public Class Form_UTS

    Sub Buat_Tabel_Laporan()
        LV_Laporan.Columns.Add("No", 30, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("NIK", 80, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Nama Karyawan", 120, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Jenis Kelamin", 100, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Jabatan", 100, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Status", 120, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Jumlah Anak", 80, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Gaji Pokok", 120, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Tunjangan Istri", 120, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Tunjangan Anak", 120, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("Gaji Lembur", 80, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("PPh", 80, HorizontalAlignment.Center)
        LV_Laporan.Columns.Add("GAJI BERSIH", 120, HorizontalAlignment.Center)
        LV_Laporan.View = View.Details
        LV_Laporan.GridLines = True
        LV_Laporan.FullRowSelect = True
        LV_Laporan.BackColor = Color.SkyBlue
    End Sub

    Sub Isi_Tabel_Laporan()
        Dim lst As New ListViewItem
        lst.Text = LV_Laporan.Items.Count + 1
        lst.SubItems.Add(NIK.Text)
        lst.SubItems.Add(Nama.Text)
        lst.SubItems.Add(JenisKelamin.Text)
        lst.SubItems.Add(jabatan.Text)
        lst.SubItems.Add(cmb_status.Text)
        lst.SubItems.Add(jmlanak.Text)
        lst.SubItems.Add(gjpokok.Text)
        lst.SubItems.Add(tjistri.Text)
        lst.SubItems.Add(tjanak.Text)
        lst.SubItems.Add(total_lembur.Text)
        lst.SubItems.Add(pph.Text)
        lst.SubItems.Add(gjbersih.Text)
        LV_Laporan.Items.Add(lst)
    End Sub

    Sub MATIKAN_KONTROL()
        Nama.Enabled = False
        JenisKelamin.Enabled = False
        tmasuk.Enabled = False
        jabatan.Enabled = False
        gjpokok.Enabled = False
        tjistri.Enabled = False
        tjanak.Enabled = False
        gjlembur.Enabled = False
        total_lembur.Enabled = False
        pph.Enabled = False
        gjbersih.Enabled = False

    End Sub

    Sub KOSONGKAN_KONTROL()
        NIK.Focus()
        NIK.Text = ""
        Nama.Text = ""
        JenisKelamin.Text = ""
        tmasuk.Text = ""
        jabatan.Text = ""
        gjpokok.Text = ""
        gjlembur.Text = ""
        gjbersih.Text = ""
        pph.Text = ""
        jamlembur.Text = ""
        total_lembur.Text = ""
        tjanak.Text = ""
        tjistri.Text = ""
        cmb_status.Text = ""
        jmlanak.Text = "0"
    End Sub
    Private Sub NIK_TextChanged(sender As Object, e As EventArgs) Handles NIK.TextChanged
        tmasuk.Text = "20" + Microsoft.VisualBasic.Left(NIK.Text, 2)

        JenisKelamin.Text = Microsoft.VisualBasic.Mid(NIK.Text, 3, 2)

        If JenisKelamin.Text = "10" Then
            JenisKelamin.Text = "Laki laki"
        ElseIf JenisKelamin.Text = "20" Then
            JenisKelamin.Text = "Perempuan"
        Else JenisKelamin.Text = "Error"
        End If

        jabatan.Text = Microsoft.VisualBasic.Mid(NIK.Text, 5, 3)

        If jabatan.Text = "100" Then
            jabatan.Text = "Direktur"
        ElseIf jabatan.Text = "200" Then
            jabatan.Text = "Kepala Direksi"
        ElseIf jabatan.Text = "300" Then
            jabatan.Text = "Staff"
        Else jabatan.Text = "Error"
        End If

        '

        If NIK.Text = "10101001" Then
            Nama.Text = "Abimanyu Pradipta"
            Nama.Enabled = False
        ElseIf NIK.Text = "10202001" Then
            Nama.Text = "Keysha Rifana"
            Nama.Enabled = False
        ElseIf NIK.Text = "10202002" Then
            Nama.Text = "Rina Nurhandani"
            Nama.Enabled = False
        ElseIf NIK.Text = "20101001" Then
            Nama.Text = "Mochamad Irvan"
            Nama.Enabled = False
        ElseIf NIK.Text = "20102001" Then
            Nama.Text = "Edward Bona"
            Nama.Enabled = False
        ElseIf NIK.Text = "20103001" Then
            Nama.Text = "Kamil Rustandi"
            Nama.Enabled = False
        ElseIf NIK.Text = "21101001" Then
            Nama.Text = "Adi Putra"
            Nama.Enabled = False
        ElseIf NIK.Text = "21202001" Then
            Nama.Text = "Nabila Putri"
            Nama.Enabled = False
        ElseIf NIK.Text = "21103001" Then
            Nama.Text = "Gerry Putra"
            Nama.Enabled = False
        ElseIf NIK.Text = "21103002" Then
            Nama.Text = "Galih Hadi"
            Nama.Enabled = False

        Else
            Nama.Text = "TIDAK TERDAFTAR"
            Nama.Enabled = True
        End If
    End Sub

    Private Sub Form_UTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NIK.Focus()
        cmb_status.Items.Clear()
        cmb_status.Items.Add("Menikah")
        cmb_status.Items.Add("Belum Menikah")
        MATIKAN_KONTROL()
        Buat_Tabel_Laporan()
    End Sub


    Private Sub jabatan_TextChanged(sender As Object, e As EventArgs) Handles jabatan.TextChanged

        If jabatan.Text = "Direktur" Then
            gjpokok.Text = "5000000"
            gjlembur.Text = "25000"
        ElseIf jabatan.Text = "Kepala Direksi" Then
            gjpokok.Text = "3000000"
            gjlembur.Text = "20000"
        ElseIf jabatan.Text = "Staff" Then
            gjpokok.Text = "1500000"
            gjlembur.Text = "15000"
        End If

        pph.Text = Val(gjpokok.Text) * 2 / 100

    End Sub

    Private Sub cmb_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_status.SelectedIndexChanged
        Select Case cmb_status.Text
            Case "Menikah" : tjistri.Text = Val(gjpokok.Text) * 10 / 100
            Case "Belum Menikah" : tjistri.Text = 0
        End Select
    End Sub

    Private Sub jmlanak_TextChanged(sender As Object, e As EventArgs) Handles jmlanak.TextChanged
        If IsNumeric(Me.jmlanak.Text) = False Then
            MessageBox.Show("MASUKAN JUMLAH ANAK DENGAN ANGKA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Select Case jmlanak.Text
            Case "0" : tjanak.Text = 0
            Case "1" : tjanak.Text = Val(gjpokok.Text) * 5 / 100
            Case "2" : tjanak.Text = Val(gjpokok.Text) * 10 / 100
            Case >= "2" : tjanak.Text = Val(gjpokok.Text) * 10 / 100
        End Select
    End Sub
    Private Sub jamlembur_TextChanged(sender As Object, e As EventArgs) Handles jamlembur.TextChanged
        total_lembur.Text = Val(jamlembur.Text) * Val(gjlembur.Text)
    End Sub

    Private Sub btn_total_Click(sender As Object, e As EventArgs) Handles btn_total.Click
        gjbersih.Text = Val(gjpokok.Text) + Val(tjanak.Text) + Val(tjistri.Text) + Val(total_lembur.Text) - Val(pph.Text)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim tanya As String
        tanya = MessageBox.Show("KELUAR DARI APLIKASI INI?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Me.Close()
        Else
            MsgBox("Silahkan Lanjut")
            NIK.Focus()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Call MATIKAN_KONTROL()
        Call KOSONGKAN_KONTROL()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hitung As Integer
        For i As Integer = 0 To LV_Laporan.Items.Count - 1
            Hitung = Hitung + LV_Laporan.Items(i).SubItems(12).Text

        Next
        txt_total.Text = Hitung
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Call Isi_Tabel_Laporan()
    End Sub
End Class