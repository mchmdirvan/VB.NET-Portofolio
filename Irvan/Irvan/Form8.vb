Public Class Form8
    Private Sub NPM_TextChanged(sender As Object, e As EventArgs) Handles NPM.TextChanged
        'mencari Tahun Angkatan dengan menggunakan fungsi LEFT
        TAHUN.Text = “20” + Microsoft.VisualBasic.Left(NPM.Text, 2)
        'mencari Nomor Absen dengan menggunakan fungsi Rigth
        ABSEN.Text = Microsoft.VisualBasic.Right(NPM.Text, 3)

        'mencari Program Studi dengan menggunakan fungsi Mid
        'PRODI      KELAS                   SEMESTER 
        '08 = TI    01 = REGULER            1 = GANJIL
        '06 = SI    02 = P2K                2 = GENAP
        '07 = MI    03 = EKSTENSI REGULER
        '           04 = EKSTENSI P2K

        PRODI.Text = Microsoft.VisualBasic.Mid(NPM.Text, 3, 2)
        Select Case PRODI.Text
            Case "07" : PRODI.Text = "MI"
            Case "08" : PRODI.Text = "TI"
            Case "06" : PRODI.Text = "SI"
            Case Else
                PRODI.Text = "Error"
        End Select

        '1708011001 
        'mencari kelas pendidikan dengan menggunakan fungsi Mid
        KELAS.Text = Microsoft.VisualBasic.Mid(NPM.Text, 5, 2)
        Select Case KELAS.Text
            Case "01" : KELAS.Text = "Reguler"
            Case "02" : KELAS.Text = "P2k"
            Case "03" : KELAS.Text = "Ekstensi"
            Case Else
                KELAS.Text = "Error"
        End Select
        '1708011001 
        'mencari Semester Masuk dengan menggunakan fungsi Mid 
        SEMESTER.Text = Microsoft.VisualBasic.Mid(NPM.Text, 7, 1)
        Select Case SEMESTER.Text
            Case "1" : SEMESTER.Text = "Ganjil"
            Case "2" : SEMESTER.Text = "Genap"
            Case Else
                SEMESTER.Text = "Error"
        End Select
        'NAMA MAHASISWA 
        If NPM.Text = "1606012076" Then
            NAMA.Text = "PUJI"
            NAMA.Enabled = False
        Else
            If NPM.Text = "1406011098" Then
                NAMA.Text = "YUNI"
                NAMA.Enabled = False
            Else
                NAMA.Text = "MHS TIDAK TERDATA"
                NAMA.Enabled = True
            End If
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim masukingambar As New Windows.Forms.OpenFileDialog
        masukingambar.Filter = "File Gambar(*.bmp; *.jpg;*.GIF)|*.BMP;*.JPG;*.GIF|All  files(*.*)|*.*"
        'tampilkan file yang berformat .jpg .bmp .gif  
        If masukingambar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.PictureBox1.Image = Image.FromFile(masukingambar.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            'biar tampilan image pas dengan kotak image yang di sediakan  Else 
        Else
            MsgBox("Masukan Gambar!", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub
End Class