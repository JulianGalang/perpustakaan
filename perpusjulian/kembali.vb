Imports System.Data.Odbc
Public Class kembali

    Private Sub kembali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relasi()
        bawaan()
    End Sub
    Sub relasi()
        connection()
        cmd = New OdbcCommand("select * from  pinjam", conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            npcb.Items.Add(dr.GetString(0))
        Loop
    End Sub
    Sub bawaan()
        nktb.Enabled = False
        dtp1.Enabled = False
        npcb.Enabled = False
        iatb.Enabled = False
        natb.Enabled = False
        nttb.Enabled = False
        ibtb.Enabled = False
        jbtb.Enabled = False
        jptb.Enabled = False
        jktb.Enabled = False
        dntb.Enabled = False

        btambah.Enabled = True
        bsimpan.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True

        nktb.Text = ""
        npcb.Text = ""
        iatb.Text = ""
        natb.Text = ""
        nttb.Text = ""
        ibtb.Text = ""
        jbtb.Text = ""
        jptb.Text = ""
        jktb.Text = ""
        dntb.Text = ""
    End Sub
    Sub tambah()
        nktb.Enabled = False
        dtp1.Enabled = True
        npcb.Enabled = True
        iatb.Enabled = True
        natb.Enabled = True
        nttb.Enabled = True
        ibtb.Enabled = True
        jbtb.Enabled = True
        jptb.Enabled = True
        jktb.Enabled = True
        dntb.Enabled = True

        btambah.Enabled = False
        bsimpan.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False
    End Sub
    Sub simpan()
        connection()
        Dim tgl As String
        tgl = Format(dtp1.Value, "yyyy-MM-dd-hh-mm-ss")
        Dim simpandata As String
        simpandata = "insert into kembali values('" & nktb.Text & "','" & tgl & "','" & npcb.Text & "','" & iatb.Text & "','" & natb.Text & "','" & nttb.Text & "','" & ibtb.Text & "','" & jbtb.Text & "','" & jptb.Text & "','" & jktb.Text & "','" & dntb.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menyimpan Data")
    End Sub
    Sub np()
        connection()
        cmd = New OdbcCommand("select * from pinjam where id='" & npcb.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            iatb.Text = dr.GetString(2)
            natb.Text = dr.GetString(3)
            nttb.Text = dr.GetString(4)
            ibtb.Text = dr.GetString(5)
            jbtb.Text = dr.GetString(6)
            jptb.Text = dr.GetString(8)
        End If
        nktb.Enabled = True
        dtp1.Enabled = True
        npcb.Enabled = True
        iatb.Enabled = False
        natb.Enabled = False
        nttb.Enabled = False
        ibtb.Enabled = False
        jbtb.Enabled = False
        jptb.Enabled = False
        jktb.Enabled = True
        dntb.Enabled = True
    End Sub
    Sub ato()
        connection()
        cmd = New OdbcCommand("select * from kembali where nokem in (select max(nokem) from kembali)", conn)
        Dim urut As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "NK" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urut = "NK" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        nktb.Text = urut

    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        ato()
        tambah()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
        bawaan()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub

    Private Sub npcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles npcb.SelectedIndexChanged
        np()
    End Sub

    Private Sub nktb_TextChanged(sender As Object, e As EventArgs) Handles nktb.TextChanged

    End Sub
End Class