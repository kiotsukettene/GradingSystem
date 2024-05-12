Imports MySql.Data.MySqlClient

Public Class RegisterCode
    Dim mycon As New DBConnection

    Function registerForm(ByVal professorID As String, ByVal firstname As String, ByVal lastname As String,
                          ByVal email As String, ByVal password As String) As Boolean

        mycon.open()
        Dim cmd As New MySqlCommand("INSERT INTO `user_info`(`prof_id`, `firstname`, `lastname`, `email`, `password`) 
                    VALUES (@prof_id,@firstname,@lastname,@email, @password)", mycon.getCon)
        cmd.Parameters.Add("@prof_id", MySqlDbType.VarChar).Value = professorID
        cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname
        cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname
        cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        If cmd.ExecuteNonQuery() > 0 Then
            mycon.close()
            Return True

        Else

            mycon.close()
            Return False
        End If
    End Function

End Class
