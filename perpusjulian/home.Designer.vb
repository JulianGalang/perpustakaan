<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.badmin = New System.Windows.Forms.Button()
        Me.bbuku = New System.Windows.Forms.Button()
        Me.banggota = New System.Windows.Forms.Button()
        Me.binjam = New System.Windows.Forms.Button()
        Me.benis = New System.Windows.Forms.Button()
        Me.bali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PERPUSTAKAAN"
        '
        'badmin
        '
        Me.badmin.BackColor = System.Drawing.Color.Coral
        Me.badmin.FlatAppearance.BorderSize = 0
        Me.badmin.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badmin.Location = New System.Drawing.Point(90, 87)
        Me.badmin.Name = "badmin"
        Me.badmin.Size = New System.Drawing.Size(147, 68)
        Me.badmin.TabIndex = 2
        Me.badmin.Text = "ADMIN"
        Me.badmin.UseVisualStyleBackColor = False
        '
        'bbuku
        '
        Me.bbuku.BackColor = System.Drawing.Color.Coral
        Me.bbuku.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold)
        Me.bbuku.Location = New System.Drawing.Point(90, 176)
        Me.bbuku.Name = "bbuku"
        Me.bbuku.Size = New System.Drawing.Size(147, 68)
        Me.bbuku.TabIndex = 3
        Me.bbuku.Text = "BUKU"
        Me.bbuku.UseVisualStyleBackColor = False
        '
        'banggota
        '
        Me.banggota.BackColor = System.Drawing.Color.Coral
        Me.banggota.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold)
        Me.banggota.Location = New System.Drawing.Point(90, 269)
        Me.banggota.Name = "banggota"
        Me.banggota.Size = New System.Drawing.Size(147, 68)
        Me.banggota.TabIndex = 4
        Me.banggota.Text = "ANGGOTA"
        Me.banggota.UseVisualStyleBackColor = False
        '
        'binjam
        '
        Me.binjam.BackColor = System.Drawing.Color.Coral
        Me.binjam.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.binjam.Location = New System.Drawing.Point(459, 87)
        Me.binjam.Name = "binjam"
        Me.binjam.Size = New System.Drawing.Size(147, 68)
        Me.binjam.TabIndex = 5
        Me.binjam.Text = "PEMINJAMAN"
        Me.binjam.UseVisualStyleBackColor = False
        '
        'benis
        '
        Me.benis.BackColor = System.Drawing.Color.Coral
        Me.benis.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold)
        Me.benis.Location = New System.Drawing.Point(459, 175)
        Me.benis.Name = "benis"
        Me.benis.Size = New System.Drawing.Size(147, 69)
        Me.benis.TabIndex = 6
        Me.benis.Text = "JENIS"
        Me.benis.UseVisualStyleBackColor = False
        '
        'bali
        '
        Me.bali.BackColor = System.Drawing.Color.Coral
        Me.bali.Font = New System.Drawing.Font("Orbitron", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bali.Location = New System.Drawing.Point(459, 269)
        Me.bali.Name = "bali"
        Me.bali.Size = New System.Drawing.Size(147, 68)
        Me.bali.TabIndex = 7
        Me.bali.Text = "PENGEMBALIAN"
        Me.bali.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.BackgroundImage = Global.perpusjulian.My.Resources.Resources._737400
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 392)
        Me.Controls.Add(Me.bali)
        Me.Controls.Add(Me.benis)
        Me.Controls.Add(Me.binjam)
        Me.Controls.Add(Me.banggota)
        Me.Controls.Add(Me.bbuku)
        Me.Controls.Add(Me.badmin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "home"
        Me.Text = "home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents badmin As System.Windows.Forms.Button
    Friend WithEvents bbuku As System.Windows.Forms.Button
    Friend WithEvents banggota As System.Windows.Forms.Button
    Friend WithEvents binjam As System.Windows.Forms.Button
    Friend WithEvents benis As System.Windows.Forms.Button
    Friend WithEvents bali As System.Windows.Forms.Button
End Class
