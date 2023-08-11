Imports System.Data.Odbc
Public Class pinjam
    Sub simpan()
        connection()
        Dim simpandata As String
        Dim tgl As String
        tgl = Format(DateTimePicker1.Value, "yyyy-MM-dd-hh-mm-ss")
        simpandata = "insert into pinjam values('" & nptb.Text & "','" & tgl & "','" & iacb.Text & "','" & natb.Text & "','" & nttb.Text & "','" & ibcb.Text & "','" & jdtb.Text & "','" & pntb.Text & "','" & sbtb.Text & "')"
        cmd = New OdbcCommand(simpandata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil Menyimpan Data")
        bawaan()
    End Sub
    Sub idangg()
        connection()
        cmd = New OdbcCommand("select * from anggota where id='" & iacb.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            natb.Text = dr.GetString(1)
            nttb.Text = dr.GetString(4)
        End If
        natb.Enabled = False
        nttb.Enabled = False
    End Sub
    Sub ibuk()
        connection()
        cmd = New OdbcCommand("select * from buku where id='" & ibcb.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            jdtb.Text = dr.GetString(2)
            pntb.Text = dr.GetString(3)
            sbtb.Text = dr.GetString(4)
        End If
        jdtb.Enabled = False
        pntb.Enabled = False
        sbtb.Enabled = False
    End Sub
    Sub bawaan()
        nptb.Enabled = False
        DateTimePicker1.Enabled = False
        iacb.Enabled = False
        natb.Enabled = False
        nttb.Enabled = False
        DateTimePicker1.Enabled = False
        ibcb.Enabled = False
        jdtb.Enabled = False
        pntb.Enabled = False
        sbtb.Enabled = False

        nptb.Text = ""
        DateTimePicker1.Text = ""
        iacb.Text = ""
        natb.Text = ""
        nttb.Text = ""
        DateTimePicker1.Text = ""
        ibcb.Text = ""
        jdtb.Text = ""
        pntb.Text = ""
        sbtb.Text = ""

        btambah.Enabled = True
        bsimpan.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True
    End Sub
    Sub tambah()
        nptb.Enabled = False
        DateTimePicker1.Enabled = True
        iacb.Enabled = True
        natb.Enabled = True
        nttb.Enabled = True
        DateTimePicker1.Enabled = True
        ibcb.Enabled = True
        jdtb.Enabled = True
        pntb.Enabled = True
        sbtb.Enabled = True

        btambah.Enabled = False
        bsimpan.Enabled = True
        bbatal.Enabled = True
        btutup.Enabled = False
    End Sub
    Sub relasi2()
        connection()
        cmd = New OdbcCommand(" select * anggota where id='" & iacb.Text & "'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then

        End If
    End Sub
    Sub relasi()
        connection()
        cmd = New OdbcCommand("select * from anggota", conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            iacb.Items.Add(dr.GetString(0))
        Loop

        cmd = New OdbcCommand("select * from buku", conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            ibcb.Items.Add(dr.GetString(0))
        Loop
    End Sub
    Private Sub ibcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ibcb.SelectedIndexChanged
        ibuk()
    End Sub
    Private Sub iacb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles iacb.SelectedIndexChanged
        idangg()
    End Sub
    Private Sub pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        relasi()
        bawaan()
    End Sub

    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        connection()
        cmd = New OdbcCommand("select * from pinjam where id in (select max(id) from pinjam)", conn)
        Dim urut As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urut = "PIN" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
            urut = "PIN" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        nptb.Text = urut
        tambah()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        simpan()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub



End Class