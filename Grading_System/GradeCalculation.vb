Imports MySql.Data.MySqlClient

Public Class GradeCalculation
    Dim mycon As New DBConnection
    Dim Actpercentage As String = ProfManagement.ActivityBox.Text
    Dim Quizpercentage As String = ProfManagement.QuizBox.Text
    Dim Performancepercentage As String = ProfManagement.PerfBox.Text
    Dim Attendance As String = ProfManagement.AttBox.Text
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectionBox.SelectedIndexChanged

        If SelectionBox.Text = "ACTIVITIES" Then
            PercentBox.Text = ProfManagement.ActivityBox.Text
        ElseIf SelectionBox.Text = "QUIZZES" Then
            PercentBox.Text = ProfManagement.QuizBox.Text
        ElseIf SelectionBox.Text = "PARTICIPATION" Then
            PercentBox.Text = ProfManagement.PerfBox.Text
        ElseIf SelectionBox.Text = "ATTENDANCE" Then
            PercentBox.Text = ProfManagement.AttBox.Text
        ElseIf SelectionBox.Text = "EXAM" Then
            PercentBox.Text = ProfManagement.FinalExamBox.Text
        End If
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Public Sub StudCombo()
        Dim StudentList As String = StudentBox.Text
        Dim Sec As String = GeneralGradeComputation.SectionBox.Text
        Dim Program As String = GeneralGradeComputation.ProgramBox.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT Student_No FROM midterm_record WHERE course=@course", mycon.getCon())
        cmd.Parameters.AddWithValue("@course", Program)

        Dim DR As MySqlDataReader = cmd.ExecuteReader()
        StudentBox.Items.Clear()

        While DR.Read
            StudentBox.Items.Add(DR("Student_No"))
        End While

        mycon.close()
    End Sub

    Public Sub DisplayNames()
        Dim Sec As String = GeneralGradeComputation.SectionBox.Text
        Dim Program As String = GeneralGradeComputation.ProgramBox.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT Surname, Firstname FROM midterm_record WHERE course=@course and section=@section", mycon.getCon())
        cmd.Parameters.AddWithValue("@course", Program)
        cmd.Parameters.AddWithValue("@section", Sec)
        Dim DR As MySqlDataReader = cmd.ExecuteReader()

        While DR.Read
            SurnameBox.Text = (DR("Surname"))
            SurnameBox.Text = (DR("Firstname"))
        End While
        mycon.close()
    End Sub

    Private Sub GradeCalculation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudCombo()
    End Sub

    Private Sub StudentBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentBox.SelectedIndexChanged
        DisplayNames()
    End Sub
End Class