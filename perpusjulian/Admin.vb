Imports System.Data.Odbc
Public Class Admin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        tampil()
        bawaan()
    End Sub
    Sub dgvcl()
        btambah.Enabled = False
        bsimpan.Enabled = False
        bhapus.Enabled = True
        bubah.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False

        idad.Enabled = False
        nmad.Enabled = True
        jkad.Enabled = True
        ntad.Enabled = True
        usad.Enabled = True
        pwad.Enabled = True
    End Sub
    Sub ubah()
        connection()
        Dim ubahdata As String = "update admin set nama ='" & nmad.Text & "', jk ='" & jkad.Text & "', telepon ='" & ntad.Text & "', username ='" & usad.Text & "', password = '" & pwad.Text & "'where id ='" & idad.Text & "'"
        cmd = New OdbcCommand(ubahdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Mengubah Data")
        tampil()
        bawaan()
    End Sub
    Sub hapus()
        connection()
        Dim hapusdata As String = "delete from admin where id='" & idad.Text & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        tampil()
        bawaan()
    End Sub
    Sub simpan()
        connection()
        Dim simpandata As String = "insert into admin values('" & idad.Text & "','" & nmad.Text & "','" & jkad.Text & "','" & ntad.Text & "','" & usad.Text & "','" & pwad.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menambah Data")
        tampil()
        bawaan()
    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = False
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        idad.Enabled = False
        nmad.Enabled = False
        jkad.Enabled = False
        ntad.Enabled = False
        usad.Enabled = False
        pwad.Enabled = False

        idad.Text = ""
        nmad.Text = ""
        jkad.Text = "~Pilih Jenis Kelamin~"
        ntad.Text = ""
        usad.Text = ""
        pwad.Text = ""
    End Sub
    Sub tambah()
        btambah.Enabled = False
        bsimpan.Enabled = True
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False

        idad.Enabled = False
        nmad.Enabled = True
        jkad.Enabled = True
        ntad.Enabled = True
        usad.Enabled = True
        pwad.Enabled = True
    End Sub
    Sub atur()
        dgvadm.Columns(0).Width = 50
        dgvadm.Columns(1).Width = 120
        dgvadm.Columns(2).Width = 65
        dgvadm.Columns(3).Width = 80
        dgvadm.Columns(4).Width = 100
        dgvadm.Columns(5).Width = 100
    End Sub
    Sub judul()
        dgvadm.Columns(0).HeaderText = "ID"
        dgvadm.Columns(1).HeaderText = "Nama"
        dgvadm.Columns(2).HeaderText = "Jenis Kelamin"
        dgvadm.Columns(3).HeaderText = "No.Telp"
        dgvadm.Columns(4).HeaderText = "Username"
        dgvadm.Columns(5).HeaderText = "Password"
    End Sub

    Sub tampil()
        connection()
        da = New OdbcDataAdapter("SELECT * From admin", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "admin")
        dgvadm.DataSource = (ds.Tables("admin"))
        atur()
        judul()
    End Sub

    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        connection()
        cmd = New OdbcCommand("select * from admin where id in (select max(id) from admin)", conn)
        Dim urut As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "ADM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urut = "ADM" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        idad.Text = urut
        tambah()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
        bawaan()
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        hapus()
        bawaan()
    End Sub

    Private Sub bubah_Click(sender As Object, e As EventArgs) Handles bubah.Click
        ubah()
        bawaan()
    End Sub

    Private Sub dgvadm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvadm.CellClick
        Dim i As Integer
        i = dgvadm.CurrentRow.Index
        idad.Text = dgvadm.Item(0, i).Value
        nmad.Text = dgvadm.Item(1, i).Value
        jkad.Text = dgvadm.Item(2, i).Value
        ntad.Text = dgvadm.Item(3, i).Value
        usad.Text = dgvadm.Item(4, i).Value
        pwad.Text = dgvadm.Item(5, i).Value

        dgvcl()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub idad_TextChanged(sender As Object, e As EventArgs) Handles idad.TextChanged

    End Sub
End Class
