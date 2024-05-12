Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class DBConnection
    Public con As New MySqlConnection("Datasource=localhost; user=root; password=; database=professor")
    Public result As String
    Public dataTable As New DataTable
    Public sqlAdapter As New MySqlDataAdapter
    Public cmd As New MySqlCommand


    Public Function getCon() As MySqlConnection
        Return con
    End Function

    Public Sub open()
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub close()
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class
