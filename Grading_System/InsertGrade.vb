Imports System.Security
Imports MySql.Data.MySqlClient
Public Class InsertGrade
    Dim mycon As New DBConnection

    Function insertGrade(ByVal studentnum As String, ByVal surname As String, ByVal firstname As String,
                         ByVal middlename As String, ByVal sectionbox As String, ByVal activity1 As String,
                         ByVal activity2 As String, ByVal totalactivity As String, ByVal actpercentage As String,
                         ByVal quiz1score As String, ByVal quiz2score As String, ByVal totalquiz As String, ByVal quizpercentage As String,
                         ByVal participationbox As String, ByVal partpercent As String, ByVal attendance As String, ByVal attPercent As String,
                         ByVal midtermexam As String, ByVal midtermtotalscore As String, ByVal midtermpercentage As String,
                         ByVal midtermgrade As String) As Boolean

        mycon.open()

        Dim cmd As New MySqlCommand("")
    End Function
End Class
