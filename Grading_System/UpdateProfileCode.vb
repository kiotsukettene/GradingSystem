Imports MySql.Data.MySqlClient

Public Class UpdateProfileCode
    ReadOnly mycon As DBConnection

    Sub New()
        mycon = New DBConnection
    End Sub
    Function UpdInfo(ByVal professorID As String, ByVal firstname As String, ByVal lastname As String,
                          ByVal email As String, ByVal password As String) As Boolean

        mycon.open()
        Dim cmd As New MySqlCommand("UPDATE `user_info` 
                                    SET `firstname`=@firstname,`lastname`=@lastname,`email`=@email,`password`=@password 
                                    WHERE `prof_id`=@prof_id", mycon.getCon())
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
