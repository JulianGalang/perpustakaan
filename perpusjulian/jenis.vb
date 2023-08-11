Imports System.Data.Odbc
Public Class jenis

    Private Sub jenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
    End Sub
    Sub bawaan()
        idjen.Enabled = False
        namjen.Enabled = False
        bijen.Enabled = False
        cajen.Enabled = True

        btambah.Enabled = True
        bsimpan.Enabled = False
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        idjen.Text = ""
        namjen.Text = ""
        bijen.Text = ""
        cajen.Text = ""
    End Sub
    Sub tambah()
        idjen.Enabled = False
        namjen.Enabled = True
        bijen.Enabled = True
        cajen.Enabled = False

        btambah.Enabled = False
        bsimpan.Enabled = True
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False
    End Sub
    Sub atur()
        dgvjen.Columns(0).Width = 60
        dgvjen.Columns(1).Width = 337
        dgvjen.Columns(2).Width = 100

        dgvjen.Columns(0).HeaderText = "ID"
        dgvjen.Columns(1).HeaderText = "NAMA"
        dgvjen.Columns(2).HeaderText = "BIAYA PINJAM"
    End Sub
    Sub tampil()
        connection()
        da = New OdbcDataAdapter("select * from jenis", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jenis")
        dgvjen.DataSource = (ds.Tables("jenis"))
        atur()
    End Sub
    Sub simpan()
        Dim simpandata As String
        simpandata = "insert into jenis value ('" & idjen.Text & "','" & namjen.Text & "','" & bijen.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menyimpan Data")
        tampil()
        bawaan()
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from jenis where idj ='" & idjen.Text & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Mengahapus Data")
        tampil()
        bawaan()
    End Sub
    Sub ubah()
        Dim ubahdata As String
        ubahdata = "update jenis set namaj = '" & namjen.Text & "', biayaj = '" & bijen.Text & "' where idj = '" & idjen.Text & "'"
        cmd = New OdbcCommand(ubahdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Mengubah Data")
        tampil()
        bawaan()
    End Sub
    Sub dgv()
        idjen.Enabled = False
        namjen.Enabled = True
        bijen.Enabled = True
        cajen.Enabled = False

        btambah.Enabled = False
        bsimpan.Enabled = False
        bhapus.Enabled = True
        bubah.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        connection()
        cmd = New OdbcCommand("select * from jenis where idj in (select max(idj) from jenis)", conn)
        Dim urut As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "JEN" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urut = "JEN" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        idjen.Text = urut
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
    Private Sub cajen_TextChanged(sender As Object, e As EventArgs) Handles cajen.TextChanged
        da = New OdbcDataAdapter(" select * from jenis where namaj like '" & cajen.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "jenis")
        dgvjen.DataSource = ds.Tables("jenis").DefaultView
    End Sub

    Private Sub dgvjen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvjen.CellContentClick
        Dim i As Integer
        i = dgvjen.CurrentRow.Index
        idjen.Text = dgvjen.Item(0, i).Value
        namjen.Text = dgvjen.Item(1, i).Value
        bijen.Text = dgvjen.Item(2, i).Value
        dgv()
    End Sub
End Class