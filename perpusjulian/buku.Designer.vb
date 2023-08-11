<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buku
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
        Me.idbk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btutup = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bubah = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.btambah = New System.Windows.Forms.Button()
        Me.ppb = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.jncb = New System.Windows.Forms.ComboBox()
        Me.jdtb = New System.Windows.Forms.TextBox()
        Me.pntb = New System.Windows.Forms.TextBox()
        Me.jmtb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.crtb = New System.Windows.Forms.TextBox()
        Me.dgvbk = New System.Windows.Forms.DataGridView()
        CType(Me.ppb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvbk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idbk
        '
        Me.idbk.Location = New System.Drawing.Point(317, 54)
        Me.idbk.Name = "idbk"
        Me.idbk.Size = New System.Drawing.Size(266, 20)
        Me.idbk.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Penerbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Judul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Jenis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "BUKU"
        '
        'btutup
        '
        Me.btutup.Location = New System.Drawing.Point(7, 320)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(116, 36)
        Me.btutup.TabIndex = 6
        Me.btutup.Text = "TUTUP"
        Me.btutup.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.Location = New System.Drawing.Point(7, 280)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(116, 36)
        Me.bbatal.TabIndex = 5
        Me.bbatal.Text = "BATAL"
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'bubah
        '
        Me.bubah.Location = New System.Drawing.Point(7, 240)
        Me.bubah.Name = "bubah"
        Me.bubah.Size = New System.Drawing.Size(116, 36)
        Me.bubah.TabIndex = 4
        Me.bubah.Text = "UBAH"
        Me.bubah.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.Location = New System.Drawing.Point(7, 200)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(116, 36)
        Me.bhapus.TabIndex = 3
        Me.bhapus.Text = "HAPUS"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bsimpan
        '
        Me.bsimpan.Location = New System.Drawing.Point(7, 160)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(116, 36)
        Me.bsimpan.TabIndex = 2
        Me.bsimpan.Text = "SIMPAN"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'btambah
        '
        Me.btambah.Location = New System.Drawing.Point(7, 120)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(116, 36)
        Me.btambah.TabIndex = 1
        Me.btambah.Text = "TAMBAH"
        Me.btambah.UseVisualStyleBackColor = True
        '
        'ppb
        '
        Me.ppb.Location = New System.Drawing.Point(3, 3)
        Me.ppb.Name = "ppb"
        Me.ppb.Size = New System.Drawing.Size(125, 110)
        Me.ppb.TabIndex = 0
        Me.ppb.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btutup)
        Me.Panel1.Controls.Add(Me.bbatal)
        Me.Panel1.Controls.Add(Me.bubah)
        Me.Panel1.Controls.Add(Me.bhapus)
        Me.Panel1.Controls.Add(Me.bsimpan)
        Me.Panel1.Controls.Add(Me.btambah)
        Me.Panel1.Controls.Add(Me.ppb)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 393)
        Me.Panel1.TabIndex = 11
        '
        'jncb
        '
        Me.jncb.FormattingEnabled = True
        Me.jncb.Items.AddRange(New Object() {"Novel", "Majalah", "Kamus", "Komik", "Manga", "Ensiklopedia", "Biografi", "Naskah"})
        Me.jncb.Location = New System.Drawing.Point(317, 84)
        Me.jncb.Name = "jncb"
        Me.jncb.Size = New System.Drawing.Size(266, 21)
        Me.jncb.TabIndex = 26
        '
        'jdtb
        '
        Me.jdtb.Location = New System.Drawing.Point(317, 114)
        Me.jdtb.Name = "jdtb"
        Me.jdtb.Size = New System.Drawing.Size(266, 20)
        Me.jdtb.TabIndex = 27
        '
        'pntb
        '
        Me.pntb.Location = New System.Drawing.Point(317, 144)
        Me.pntb.Name = "pntb"
        Me.pntb.Size = New System.Drawing.Size(266, 20)
        Me.pntb.TabIndex = 28
        '
        'jmtb
        '
        Me.jmtb.Location = New System.Drawing.Point(317, 174)
        Me.jmtb.Name = "jmtb"
        Me.jmtb.Size = New System.Drawing.Size(266, 20)
        Me.jmtb.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(439, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cari"
        '
        'crtb
        '
        Me.crtb.Location = New System.Drawing.Point(482, 360)
        Me.crtb.Name = "crtb"
        Me.crtb.Size = New System.Drawing.Size(215, 20)
        Me.crtb.TabIndex = 32
        '
        'dgvbk
        '
        Me.dgvbk.AllowUserToAddRows = False
        Me.dgvbk.AllowUserToDeleteRows = False
        Me.dgvbk.AllowUserToResizeColumns = False
        Me.dgvbk.AllowUserToResizeRows = False
        Me.dgvbk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbk.Location = New System.Drawing.Point(154, 206)
        Me.dgvbk.Name = "dgvbk"
        Me.dgvbk.ReadOnly = True
        Me.dgvbk.Size = New System.Drawing.Size(543, 150)
        Me.dgvbk.TabIndex = 33
        '
        'buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(724, 392)
        Me.Controls.Add(Me.dgvbk)
        Me.Controls.Add(Me.crtb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jmtb)
        Me.Controls.Add(Me.pntb)
        Me.Controls.Add(Me.jdtb)
        Me.Controls.Add(Me.jncb)
        Me.Controls.Add(Me.idbk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "buku"
        Me.Text = "buku"
        CType(Me.ppb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvbk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idbk As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btutup As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bubah As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents btambah As System.Windows.Forms.Button
    Friend WithEvents ppb As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents jncb As System.Windows.Forms.ComboBox
    Friend WithEvents jdtb As System.Windows.Forms.TextBox
    Friend WithEvents pntb As System.Windows.Forms.TextBox
    Friend WithEvents jmtb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents crtb As System.Windows.Forms.TextBox
    Friend WithEvents dgvbk As System.Windows.Forms.DataGridView
End Class
