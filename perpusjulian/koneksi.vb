Imports System.Data.Odbc
Module koneksi
    Public conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public sql1 As String
    Public sql2 As String

    Sub connection()
        sql1 = "Driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=perpus;port=3306"
        conn = New OdbcConnection(sql1)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
