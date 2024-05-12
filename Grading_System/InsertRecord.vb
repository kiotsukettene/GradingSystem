Imports System.Collections.Specialized.BitVector32
Imports MySql.Data.MySqlClient
Public Class InsertRecord
    Dim mycon As New DBConnection

    Public Function InsertStudentRecord(ByVal studentNo As String, ByVal activities As String, ByVal quizzes As String,
                                        ByVal performance As String, ByVal mExam As String) As Boolean

        mycon.open()

        Dim cmd As New MySqlCommand("INSERT INTO `midterm_record`(`Student_No`, `Activities`, `Quizzes`, `Performance`, `Midterm Exam`) 
                                    VALUES (@student_no, @activities, @quizzes, @performance, @midtermexam)", mycon.getCon())
        cmd.Parameters.Add("@student_no", MySqlDbType.VarChar).Value = studentNo
        cmd.Parameters.Add("@activities", MySqlDbType.VarChar).Value = activities
        cmd.Parameters.Add("@quizzes", MySqlDbType.VarChar).Value = quizzes
        cmd.Parameters.Add("@performance", MySqlDbType.VarChar).Value = performance
        cmd.Parameters.Add("@midtermexam", MySqlDbType.VarChar).Value = mExam

        If cmd.ExecuteNonQuery() > 0 Then
            mycon.close()
            Return True

        Else

            mycon.close()
            Return False
        End If
    End Function
End Class
