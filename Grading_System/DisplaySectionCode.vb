Imports MySql.Data.MySqlClient

Public Class DisplaySectionCode
    Dim mycon As New DBConnection

    Sub New()
        mycon = New DBConnection
    End Sub

    Function UpdInfo(ByVal StudentNo As String, ByVal Fullname As String, ByVal Section As String,
                          ByVal StudentEmail As String, ByVal Gender As String, ByVal Remarks As String) As Boolean
        mycon.open()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM `section_data` 
                                    WHERE `Student_No.`=@Student_No., `Name`=@Name, `Section`=@Section, 
                                    `Email`=@Email, `Gender`=@Gender, `Remarks`=@Remarks", mycon.getCon())
        cmd.Parameters.Add("@Student_No.", MySqlDbType.VarChar).Value = StudentNo
        cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Fullname
        cmd.Parameters.Add("@Section", MySqlDbType.VarChar).Value = Section
        cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = StudentEmail
        cmd.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = Gender
        cmd.Parameters.Add("@Remarks", MySqlDbType.VarChar).Value = Remarks

        If cmd.ExecuteNonQuery() > 0 Then
            mycon.close()
            Return True

        Else

            mycon.close()
            Return False
        End If
    End Function

End Class
