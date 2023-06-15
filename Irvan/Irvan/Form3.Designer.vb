<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_namabarang = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Discount = New System.Windows.Forms.RadioButton()
        Me.Tidak_Discount = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(38, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Belanja Yuk!"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_namabarang)
        Me.GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.GroupBox1.Controls.Add(Me.txt_harga)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 122)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(154, 21)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(195, 22)
        Me.txt_namabarang.TabIndex = 5
        Me.txt_namabarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(154, 78)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(195, 22)
        Me.txt_jumlah.TabIndex = 4
        Me.txt_jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(154, 50)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(195, 22)
        Me.txt_harga.TabIndex = 3
        Me.txt_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Discount"
        '
        'Discount
        '
        Me.Discount.AutoSize = True
        Me.Discount.Location = New System.Drawing.Point(199, 227)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(116, 21)
        Me.Discount.TabIndex = 3
        Me.Discount.TabStop = True
        Me.Discount.Text = "Discount 10%"
        Me.Discount.UseVisualStyleBackColor = True
        '
        'Tidak_Discount
        '
        Me.Tidak_Discount.AutoSize = True
        Me.Tidak_Discount.Location = New System.Drawing.Point(199, 254)
        Me.Tidak_Discount.Name = "Tidak_Discount"
        Me.Tidak_Discount.Size = New System.Drawing.Size(123, 21)
        Me.Tidak_Discount.TabIndex = 4
        Me.Tidak_Discount.TabStop = True
        Me.Tidak_Discount.Text = "Tidak Discount"
        Me.Tidak_Discount.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(51, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(431, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "HITUNG TOTAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sub Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Besar Discount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "T O T A L"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(199, 393)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(195, 22)
        Me.txt_total.TabIndex = 9
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(199, 365)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(195, 22)
        Me.txt_discount.TabIndex = 10
        Me.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(199, 336)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(195, 22)
        Me.txt_subtotal.TabIndex = 11
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(319, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "NEW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 459)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 536)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tidak_Discount)
        Me.Controls.Add(Me.Discount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Belanja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_namabarang As TextBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Discount As RadioButton
    Friend WithEvents Tidak_Discount As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
