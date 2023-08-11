Imports System.Data.Odbc
Public Class anggota
    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
    End Sub
    Sub tampil()
        connection()
        da = New OdbcDataAdapter("select * from anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "anggota")
        dgvag.DataSource = (ds.Tables("anggota"))
        atur()
    End Sub
    Sub hapus()
        connection()
        Dim hapusdata As String
        hapusdata = "delete from anggota where id='" & idag.Text & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        tampil()
        bawaan()

    End Sub
    Sub dgv()
        btambah.Enabled = False
        bsimpan.Enabled = False
        bhapus.Enabled = True
        bubah.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False

        idag.Enabled = False
        nmag.Enabled = True
        alag.Enabled = True
        jkag.Enabled = True
        ntag.Enabled = True
        crag.Enabled = False
    End Sub
    Sub atur()
        dgvag.Columns(0).Width = 55
        dgvag.Columns(1).Width = 120
        dgvag.Columns(2).Width = 200
        dgvag.Columns(3).Width = 65
        dgvag.Columns(4).Width = 100

        dgvag.Columns(0).HeaderText = "ID"
        dgvag.Columns(1).HeaderText = "Nama"
        dgvag.Columns(2).HeaderText = "Alamat"
        dgvag.Columns(3).HeaderText = "Kelamin"
        dgvag.Columns(4).HeaderText = "Telepon"
    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = False
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        idag.Enabled = False
        nmag.Enabled = False
        alag.Enabled = False
        jkag.Enabled = False
        ntag.Enabled = False
        crag.Enabled = False

        idag.Text = ""
        nmag.Text = ""
        alag.Text = ""
        jkag.Text = ""
        ntag.Text = ""
        crag.Text = ""
    End Sub
    Sub tambah()
        btambah.Enabled = False
        bsimpan.Enabled = True
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False

        idag.Enabled = False
        nmag.Enabled = True
        alag.Enabled = True
        jkag.Enabled = True
        ntag.Enabled = True
        crag.Enabled = False
    End Sub
    Sub simpan()
        Dim simpandata As String
        simpandata = "insert into anggota values('" & idag.Text & "','" & nmag.Text & "','" & alag.Text & "','" & jkag.Text & "','" & ntag.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menyimpan Data")
        tampil()
        bawaan()
    End Sub
    Sub ubah()
        Dim ubahdata As String
        ubahdata = "update anggota set nama='" & nmag.Text & "', alamat='" & alag.Text & "', jk='" & jkag.Text & "', telepon='" & ntag.Text & "'where id='" & idag.Text & "'"
        cmd = New OdbcCommand(ubahdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Mengubah Data")
        tampil()
        bawaan()
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        connection()
        cmd = New OdbcCommand("select * from anggota where id in (select max(id) from anggota)", conn)
        Dim urut As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "ANG" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urut = "ANG" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        idag.Text = urut
        tambah()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        hapus()
    End Sub

    Private Sub bubah_Click(sender As Object, e As EventArgs) Handles bubah.Click
        ubah()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub dgvag_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvag.CellClick
        Dim i As Integer
        i = dgvag.CurrentRow.Index
        idag.Text = dgvag.Item(0, i).Value
        nmag.Text = dgvag.Item(1, i).Value
        alag.Text = dgvag.Item(2, i).Value
        jkag.Text = dgvag.Item(3, i).Value
        ntag.Text = dgvag.Item(4, i).Value
        dgv()
    End Sub
End Class