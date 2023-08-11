Imports System.Data.Odbc
Public Class buku
    Private Sub buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
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

        idbk.Enabled = False
        jncb.Enabled = False
        jdtb.Enabled = False
        pntb.Enabled = False
        jmtb.Enabled = False
        crtb.Enabled = True

        idbk.Text = ""
        jncb.Text = ""
        jdtb.Text = ""
        pntb.Text = ""
        jmtb.Text = ""
        crtb.Text = ""
    End Sub
    Sub dgv()
        btambah.Enabled = False
        bsimpan.Enabled = False
        bhapus.Enabled = True
        bubah.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False

        idbk.Enabled = False
        jncb.Enabled = True
        jdtb.Enabled = True
        pntb.Enabled = True
        jmtb.Enabled = True
        crtb.Enabled = False
    End Sub
    Sub tambah()
        btambah.Enabled = False
        bsimpan.Enabled = True
        bhapus.Enabled = False
        bubah.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = False

        idbk.Enabled = False
        jncb.Enabled = True
        jdtb.Enabled = True
        pntb.Enabled = True
        jmtb.Enabled = True
        crtb.Enabled = False
    End Sub
    Sub atur()
        dgvbk.Columns(0).Width = 60
        dgvbk.Columns(1).Width = 70
        dgvbk.Columns(2).Width = 240
        dgvbk.Columns(3).Width = 115
        dgvbk.Columns(4).Width = 70
    End Sub
    Sub judul()
        dgvbk.Columns(0).HeaderText = "ID"
        dgvbk.Columns(1).HeaderText = "Jenis"
        dgvbk.Columns(2).HeaderText = "Judul"
        dgvbk.Columns(3).HeaderText = "Penerbit"
        dgvbk.Columns(4).HeaderText = "Jumlah"
    End Sub
    Sub simpan()
        Dim simpandata As String
        simpandata = "insert into buku values('" & idbk.Text & "','" & jncb.Text & "','" & jdtb.Text & "','" & pntb.Text & "','" & jmtb.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menyimpan Data")
        tampil()
    End Sub
    Sub hapus()
        Dim hapusdata As String
        hapusdata = "delete from buku where id='" & idbk.Text & "';"
        cmd = New OdbcCommand(hapusdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Data")
        tampil()
    End Sub
    Sub ubah()
        Dim ubahdata As String = "update buku set jenis ='" & jncb.Text & "', judul ='" & jdtb.Text & "', penerbit ='" & pntb.Text & "', jumlah ='" & jmtb.Text & "'where id ='" & idbk.Text & "'"
        cmd = New OdbcCommand(ubahdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Mengubah Data")
        tampil()
    End Sub
    Sub tampil()
        connection()
        da = New OdbcDataAdapter("select * from buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "buku")
        dgvbk.DataSource = (ds.Tables("buku"))
        atur()
        judul()
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        connection()
        cmd = New OdbcCommand("select * from buku where id in (select max(id) from buku)", conn)
        Dim urut As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "BK" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urut = "BK" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        idbk.Text = urut
        tambah()
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

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub dgvbk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvbk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbk.CellClick
        Dim i As Integer
        i = dgvbk.CurrentRow.Index
        idbk.Text = dgvbk.Item(0, i).Value
        jncb.Text = dgvbk.Item(1, i).Value
        jdtb.Text = dgvbk.Item(2, i).Value
        pntb.Text = dgvbk.Item(3, i).Value
        jmtb.Text = dgvbk.Item(4, i).Value
        dgv()
    End Sub

    Private Sub crtb_TextChanged(sender As Object, e As EventArgs) Handles crtb.TextChanged
        da = New OdbcDataAdapter(" select * from buku where jenis like '" & crtb.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "buku")
        dgvbk.DataSource = ds.Tables("buku").DefaultView
    End Sub
End Class