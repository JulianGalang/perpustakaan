<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btutup = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.bubah = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.btambah = New System.Windows.Forms.Button()
        Me.ppb = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.idad = New System.Windows.Forms.TextBox()
        Me.nmad = New System.Windows.Forms.TextBox()
        Me.jkad = New System.Windows.Forms.ComboBox()
        Me.ntad = New System.Windows.Forms.TextBox()
        Me.usad = New System.Windows.Forms.TextBox()
        Me.pwad = New System.Windows.Forms.TextBox()
        Me.dgvadm = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.ppb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvadm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "No. Telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(155, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Password"
        '
        'idad
        '
        Me.idad.Location = New System.Drawing.Point(305, 65)
        Me.idad.Name = "idad"
        Me.idad.Size = New System.Drawing.Size(266, 20)
        Me.idad.TabIndex = 3
        '
        'nmad
        '
        Me.nmad.Location = New System.Drawing.Point(305, 95)
        Me.nmad.Name = "nmad"
        Me.nmad.Size = New System.Drawing.Size(266, 20)
        Me.nmad.TabIndex = 4
        '
        'jkad
        '
        Me.jkad.FormattingEnabled = True
        Me.jkad.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.jkad.Location = New System.Drawing.Point(305, 125)
        Me.jkad.Name = "jkad"
        Me.jkad.Size = New System.Drawing.Size(266, 21)
        Me.jkad.TabIndex = 5
        '
        'ntad
        '
        Me.ntad.Location = New System.Drawing.Point(305, 155)
        Me.ntad.Name = "ntad"
        Me.ntad.Size = New System.Drawing.Size(266, 20)
        Me.ntad.TabIndex = 6
        '
        'usad
        '
        Me.usad.Location = New System.Drawing.Point(305, 185)
        Me.usad.Name = "usad"
        Me.usad.Size = New System.Drawing.Size(266, 20)
        Me.usad.TabIndex = 7
        '
        'pwad
        '
        Me.pwad.Location = New System.Drawing.Point(305, 215)
        Me.pwad.Name = "pwad"
        Me.pwad.Size = New System.Drawing.Size(266, 20)
        Me.pwad.TabIndex = 8
        '
        'dgvadm
        '
        Me.dgvadm.AllowUserToAddRows = False
        Me.dgvadm.AllowUserToDeleteRows = False
        Me.dgvadm.AllowUserToResizeColumns = False
        Me.dgvadm.AllowUserToResizeRows = False
        Me.dgvadm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvadm.Location = New System.Drawing.Point(155, 240)
        Me.dgvadm.Name = "dgvadm"
        Me.dgvadm.ReadOnly = True
        Me.dgvadm.Size = New System.Drawing.Size(545, 150)
        Me.dgvadm.TabIndex = 10
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(724, 392)
        Me.Controls.Add(Me.dgvadm)
        Me.Controls.Add(Me.pwad)
        Me.Controls.Add(Me.usad)
        Me.Controls.Add(Me.ntad)
        Me.Controls.Add(Me.jkad)
        Me.Controls.Add(Me.nmad)
        Me.Controls.Add(Me.idad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Admin"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ppb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvadm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btutup As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bubah As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents btambah As System.Windows.Forms.Button
    Friend WithEvents ppb As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents idad As System.Windows.Forms.TextBox
    Friend WithEvents nmad As System.Windows.Forms.TextBox
    Friend WithEvents jkad As System.Windows.Forms.ComboBox
    Friend WithEvents ntad As System.Windows.Forms.TextBox
    Friend WithEvents usad As System.Windows.Forms.TextBox
    Friend WithEvents pwad As System.Windows.Forms.TextBox
    Friend WithEvents dgvadm As System.Windows.Forms.DataGridView

End Class
