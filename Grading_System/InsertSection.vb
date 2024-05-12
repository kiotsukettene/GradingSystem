Imports MySql.Data.MySqlClient
Public Class InsertSection
    Dim mycon As New DBConnection

    Function addSubSec(ByVal ProfessorID As String, ByVal Program As String,
                       ByVal Year As String, ByVal Section As String, ByVal Subject As String) As Boolean
        mycon.open()
        Dim cmd As New MySqlCommand("INSERT INTO `user_subsec`(`prof_id`, `program`, `year`, `section`, `subject`) 
                                    VALUES (@prof_id,@program,@year,@section,@subject)", mycon.getCon())
        cmd.Parameters.Add("@prof_id", MySqlDbType.VarChar).Value = ProfessorID
        cmd.Parameters.Add("@program", MySqlDbType.VarChar).Value = Program
        cmd.Parameters.Add("@section", MySqlDbType.VarChar).Value = Section
        cmd.Parameters.Add("@subject", MySqlDbType.VarChar).Value = Subject
        cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = Year

        If cmd.ExecuteNonQuery() > 0 Then
            mycon.close()
            Return True

        Else

            mycon.close()
            Return False
        End If
    End Function


End Class
