Imports System.Data.SqlClient
Public Class MakeConnection
    Dim con As SqlConnection
    Public Sub MakeConnection()
        con = New SqlConnection("server=vb;database=MyDB;uid=faiq;password=faiq;")
        con.Open()
    End Sub
End Class
