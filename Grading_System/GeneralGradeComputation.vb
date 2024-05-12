Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Public Class GeneralGradeComputation
    Dim mycon As New DBConnection

    Public Sub Combo1()
        Dim profID As String = ProfManagement.DisplayProfID.Text
        Dim program As String = ProgramBox.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT CONCAT(year, section) AS ConcatenatedValue
                                    FROM user_subsec WHERE prof_id=@prof_id AND program=@program", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)
        cmd.Parameters.AddWithValue("@program", program)
        Dim DR As MySqlDataReader
        DR = cmd.ExecuteReader()

        SectionBox.Items.Clear()
        While DR.Read()
            SectionBox.Items.Add(DR("ConcatenatedValue"))
        End While
        mycon.close()

    End Sub
    Public Sub Combo2()
        Dim profID As String = ProfManagement.DisplayProfID.Text
        Dim program As String = ProgramBox.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT program FROM user_subsec WHERE prof_id=@prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)
        Dim DR As MySqlDataReader
        DR = cmd.ExecuteReader()

        ProgramBox.Items.Clear()
        While DR.Read()
            ProgramBox.Items.Add(DR("program"))
        End While
        mycon.close()
    End Sub
    Public Sub Display()
        Dim program As String = ProgramBox.Text
        Dim studentNo As String = StudentManagement.DisplayStudentNo.Text
        Dim selectedSection As String = SectionBox.Text
        mycon.open()
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)

        Dim cmd As New MySqlCommand("SELECT Student_No, Surname, FirstName, MiddleName, Activities, TotalAct, ActPercent,
Quiz, TotalQuiz, QuizPercent, Participation, PartPercent, Attendance, AttPercent, MidtermExam, MidtermTotal, MidtermPercent, MidtermGrade
FROM midterm_record WHERE course LIKE @course AND section=@section", mycon.getCon())
        cmd.Parameters.AddWithValue("@course", "%" + ProgramBox.Text + "%")
        cmd.Parameters.AddWithValue("@section", section)

        Dim DA As New MySqlDataAdapter
        DA.SelectCommand = cmd

        Dim DT As New DataTable
        DA.Fill(DT)

        RecordView.DataSource = DT
        mycon.close()
    End Sub

    Public Sub StudCombo()
        Dim StudentList As String = StudentBox.Text
        Dim selectedSection As String = SectionBox.Text
        Dim Program As String = ProgramBox.Text
        mycon.open()
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)
        Dim cmd As New MySqlCommand("SELECT Student_No FROM midterm_record WHERE course=@course AND section=@section", mycon.getCon())
        cmd.Parameters.AddWithValue("@course", Program)
        cmd.Parameters.AddWithValue("@section", section)

        Dim DR As MySqlDataReader = cmd.ExecuteReader()
        StudentBox.Items.Clear()

        While DR.Read
            StudentBox.Items.Add(DR("Student_No"))
        End While

        mycon.close()
    End Sub
    Public Sub DisplayNames()
        Dim selectedSection As String = SectionBox.Text
        Dim Program As String = ProgramBox.Text
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)
        Dim studentnum As String = StudentBox.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT Surname, Firstname FROM midterm_record WHERE Student_No=@Student_No", mycon.getCon())
        cmd.Parameters.AddWithValue("@Student_No", studentnum)
        Dim DR As MySqlDataReader = cmd.ExecuteReader()

        While DR.Read
            SurnameBox.Text = (DR("Surname"))
            FirstnameBox.Text = (DR("Firstname"))
        End While
        mycon.close()
    End Sub



    Private Sub GeneralGradeComputation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo2()
        StudCombo()
        'DisplayJoin()
        Display()

    End Sub

    Private Sub ProgramBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Combo1()
    End Sub

    Private Sub StudentBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentBox.SelectedIndexChanged
        DisplayNames()
    End Sub

    Public Sub calculate()


    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        calculate()
    End Sub

    Private Sub ProgramBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ProgramBox.SelectedIndexChanged

    End Sub

    Private Sub RecordView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RecordView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = RecordView.Rows(index)

        StudentBox.Text = selectedRow.Cells(0).Value.ToString()
        'FirstnameBox.Text = selectedRow.Cells(1).Value.ToString()
        'SurnameBox.Text = selectedRow.Cells(2).Value.ToString()




    End Sub
End Class