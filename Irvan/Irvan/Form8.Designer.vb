<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.NPM = New System.Windows.Forms.TextBox()
        Me.NAMA = New System.Windows.Forms.TextBox()
        Me.PRODI = New System.Windows.Forms.TextBox()
        Me.TAHUN = New System.Windows.Forms.TextBox()
        Me.KELAS = New System.Windows.Forms.TextBox()
        Me.SEMESTER = New System.Windows.Forms.TextBox()
        Me.ABSEN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMOR POKOK MAHASISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA MAHASISWA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PROGRAM STUDI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TAHUN ANGKATAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "KELAS PENDIDIKAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SEMESTER MASUK"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "NO ABSEN"
        '
        'NPM
        '
        Me.NPM.Location = New System.Drawing.Point(244, 32)
        Me.NPM.Name = "NPM"
        Me.NPM.Size = New System.Drawing.Size(143, 22)
        Me.NPM.TabIndex = 7
        '
        'NAMA
        '
        Me.NAMA.Location = New System.Drawing.Point(244, 67)
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Size = New System.Drawing.Size(143, 22)
        Me.NAMA.TabIndex = 8
        '
        'PRODI
        '
        Me.PRODI.Location = New System.Drawing.Point(244, 99)
        Me.PRODI.Name = "PRODI"
        Me.PRODI.Size = New System.Drawing.Size(143, 22)
        Me.PRODI.TabIndex = 9
        '
        'TAHUN
        '
        Me.TAHUN.Location = New System.Drawing.Point(244, 135)
        Me.TAHUN.Name = "TAHUN"
        Me.TAHUN.Size = New System.Drawing.Size(143, 22)
        Me.TAHUN.TabIndex = 10
        '
        'KELAS
        '
        Me.KELAS.Location = New System.Drawing.Point(244, 169)
        Me.KELAS.Name = "KELAS"
        Me.KELAS.Size = New System.Drawing.Size(143, 22)
        Me.KELAS.TabIndex = 11
        '
        'SEMESTER
        '
        Me.SEMESTER.Location = New System.Drawing.Point(244, 203)
        Me.SEMESTER.Name = "SEMESTER"
        Me.SEMESTER.Size = New System.Drawing.Size(143, 22)
        Me.SEMESTER.TabIndex = 12
        '
        'ABSEN
        '
        Me.ABSEN.Location = New System.Drawing.Point(244, 241)
        Me.ABSEN.Name = "ABSEN"
        Me.ABSEN.Size = New System.Drawing.Size(143, 22)
        Me.ABSEN.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 355)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FOTO MAHASISWA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(82, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 279)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ABSEN)
        Me.Controls.Add(Me.SEMESTER)
        Me.Controls.Add(Me.KELAS)
        Me.Controls.Add(Me.TAHUN)
        Me.Controls.Add(Me.PRODI)
        Me.Controls.Add(Me.NAMA)
        Me.Controls.Add(Me.NPM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NIM"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NPM As TextBox
    Friend WithEvents NAMA As TextBox
    Friend WithEvents PRODI As TextBox
    Friend WithEvents TAHUN As TextBox
    Friend WithEvents KELAS As TextBox
    Friend WithEvents SEMESTER As TextBox
    Friend WithEvents ABSEN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
