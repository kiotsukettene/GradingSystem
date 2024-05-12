Imports System.Collections.Specialized.BitVector32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Public Class ProfManagement
    Dim ClassStanding As Integer
    Dim FinalExam As Integer
    Dim Total As Integer
    Dim Activity As Integer
    Dim Quiz As Integer
    Dim Performance As Integer
    Dim Attendance As Integer
    Dim mycon As New DBConnection
    Dim InsertSubSec As New InsertSection
    Dim green As Color = Color.FromArgb(CByte(69), CByte(176), CByte(99))

    Private totalSelectedValue As Integer

    Private Sub ProfManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClassOSBox.SelectedIndex = 5
        FinalExamBox.SelectedIndex = 3

        If ClassOSBox.SelectedIndex = 5 Then
            ClassStanding = 60
        End If
        If FinalExamBox.SelectedItem = "40%" Then
            FinalExam = 40
        End If
        TotalPercentageBox.Text = Total
        TotalPercentageBox.Text = ClassStanding + FinalExam

        ActivityBox.Text = "40%"
        QuizBox.Text = "30%"
        PerfBox.Text = "10%"
        AttBox.Text = "20%"




        DataGridDisplay()
        SubjectBox()

    End Sub

    Public Sub SubjectBox()
        Dim program As String = AddProgram.SelectedItem
        Dim year As String = AddYear.SelectedItem
        mycon.open()
        Dim cmd As New MySqlCommand("SELECT DISTINCT subject_description FROM subject_data 
                                  WHERE program = @Program AND year = @year", mycon.getCon())
        cmd.Parameters.AddWithValue("@Program", program)
        cmd.Parameters.AddWithValue("@year", year)
        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()
        AddSubject.Items.Clear()

        While dataReader.Read()
            AddSubject.Items.Add(dataReader("subject_description"))
        End While

        dataReader.Close() ' Close the data reader when done
        mycon.close()
    End Sub

    Public Sub YearBox()
        Dim year As String = AddYear.SelectedItem
        Dim program As String = AddProgram.SelectedItem
        mycon.open()
        Dim cmd As New MySqlCommand("SELECT DISTINCT year FROM subject_data WHERE program = @Program", mycon.getCon())
        cmd.Parameters.AddWithValue("@Program", program)

        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()
        AddYear.Items.Clear()

        While dataReader.Read()
            AddYear.Items.Add(dataReader("year"))
        End While

        dataReader.Close()
        mycon.close()
    End Sub
    Public Sub SectionBox()
        Dim year As String = AddYear.SelectedItem
        Dim course As String = AddProgram.SelectedItem

        mycon.open()
        Dim cmd As New MySqlCommand("SELECT DISTINCT section from student_profile WHERE course =@course", mycon.getCon())
        cmd.Parameters.AddWithValue("@course", course)
        'cmd.Parameters.AddWithValue("@year", year)
        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()
        AddSection.Items.Clear()

        While dataReader.Read()
            AddSection.Items.Add(dataReader("section"))
        End While

        dataReader.Close()
        mycon.close()
    End Sub
    Private Sub AddSec_Click(sender As Object, e As EventArgs) Handles AddSec.Click
        Dim professorID As String = DisplayProfID.Text
        Dim Program As String = AddProgram.SelectedItem
        Dim Section As String = AddSection.SelectedItem
        Dim Subject As String = AddSubject.SelectedItem
        Dim Year As String = AddYear.SelectedItem
        mycon.open()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM user_subsec WHERE prof_id = @prof_id AND program = @program AND section = @section AND year = @year", mycon.getCon())
        cmd.Parameters.Add("@prof_id", MySqlDbType.VarChar).Value = professorID
        cmd.Parameters.Add("@program", MySqlDbType.VarChar).Value = Program
        cmd.Parameters.Add("@section", MySqlDbType.VarChar).Value = Section
        cmd.Parameters.Add("@year", MySqlDbType.VarChar).Value = Year

        Dim count As Integer = CInt(cmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("You already added this section")
            mycon.close()
        Else
            If InsertSubSec.addSubSec(professorID, Program, Year, Section, Subject) Then


                MsgBox("Added Successfully")
                AddProgram.Text = ""
                AddSection.Text = ""
                AddSubject.Text = ""
                AddYear.Text = ""

                mycon.close()
            Else
                MsgBox("Error")
                mycon.close()
            End If
        End If


        Timer1.Start()
        DataGridDisplay()
    End Sub


    Private Sub DataGridDisplay()
        Dim profId As String = DisplayProfID.Text
        Dim Program As String = AddProgram.SelectedItem
        Dim Section As String = AddSection.SelectedItem
        Dim Subject As String = AddSubject.Text


        mycon.open()
        Dim cmd As New MySqlCommand("SELECT Program, Year, Section, Subject FROM `user_subsec` WHERE prof_id = @prof_id", mycon.getCon())
        cmd.Parameters.Add("@prof_id", MySqlDbType.VarChar).Value = profId
        Dim sqlAdapter As New MySqlDataAdapter
        Dim dataTable As New DataTable

        sqlAdapter.SelectCommand = cmd
        sqlAdapter.Fill(dataTable)
        HandledSectionView.DataSource = dataTable
        mycon.close()


    End Sub

    Private Sub ProfEditBtn_Click(sender As Object, e As EventArgs) Handles ProfEditBtn.Click
        ProfileUpdBtn.Visible = True
        ProfEditBtn.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))

        DisplayFname.Enabled = True
        DisplayLname.Enabled = True
        DisplayEmail.Enabled = True
        DisplayPass.Enabled = True



    End Sub

    Private Sub SaveChanges_Click(sender As Object, e As EventArgs) Handles SaveChanges.Click
        Dim profId As String = DisplayProfID.Text
        Dim fnameChange As String = DisplayFname.Text
        Dim lnameChange As String = DisplayLname.Text
        Dim emailChange As String = DisplayEmail.Text
        Dim passChange As String = DisplayPass.Text
        Dim UpdateProfile As New UpdateProfileCode
        mycon.open()

        If fnameChange.Trim().Equals("") Then
            FnameProfile.ForeColor = Color.Red
            MessageBox.Show("Fill up your first name")
            FnameProfile.ForeColor = green
            mycon.close()
        ElseIf lnameChange.Trim().Equals("") Then
            LnameProfile.ForeColor = Color.Red
            MessageBox.Show("Fill up your last name")
            LnameProfile.ForeColor = green
            mycon.close()
        ElseIf emailChange.Trim().Equals("") Then
            EmailProfile.ForeColor = Color.Red
            MessageBox.Show("Fill up your email")
            EmailProfile.ForeColor = green
            mycon.close()
        ElseIf passChange.Trim().Equals("") Then
            PassProfile.ForeColor = Color.Red
            MessageBox.Show("Fill up your password")
            EmailProfile.ForeColor = green
            mycon.close()
        Else
            If UpdateProfile.UpdInfo(profId, fnameChange, lnameChange, emailChange, passChange) Then
                MessageBox.Show("Updated Successfuly")
                DashboardPanel.WelcomeDisplay.Text = "WElCOME, PROFESSOR " & fnameChange.ToUpper & " " & lnameChange.ToUpper
                ProfileUpdBtn.Visible = False
                ProfEditBtn.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
                DisplayFname.Enabled = False
                DisplayLname.Enabled = False
                DisplayEmail.Enabled = False
                DisplayPass.Enabled = False
            Else
                MessageBox.Show("Update Failed")
            End If
            mycon.close()
        End If


    End Sub

    Private Sub DisplayFname_Enter(sender As Object, e As EventArgs) Handles DisplayFname.Enter
        FnameProfile.ForeColor = green
    End Sub

    Private Sub DisplayLname_Enter(sender As Object, e As EventArgs) Handles DisplayLname.Enter
        LnameProfile.ForeColor = green
    End Sub

    Private Sub DisplayEmail_Enter(sender As Object, e As EventArgs) Handles DisplayEmail.Enter
        EmailProfile.ForeColor = green
    End Sub

    Private Sub DisplayPass_TextChanged(sender As Object, e As EventArgs) Handles DisplayPass.TextChanged
        PassProfile.ForeColor = green
    End Sub

    Private Sub AddProgram_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddProgram.SelectedIndexChanged
        YearBox()
        SubjectBox()
    End Sub

    Private Sub AddYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddYear.SelectedIndexChanged
        SubjectBox()
    End Sub

    Private Sub GradeEdit_Click(sender As Object, e As EventArgs) Handles GradeEdit.Click
        ActivityBox.Enabled = True
        QuizBox.Enabled = True
        PerfBox.Enabled = True
        SaveChangesGrade.Visible = True
    End Sub

    Private Sub PercentageSave_Click(sender As Object, e As EventArgs) Handles PercentageSave.Click
        ActivityBox.Enabled = False
        QuizBox.Enabled = False
        PerfBox.Enabled = False
        SaveChangesGrade.Visible = True
    End Sub
    Public Sub UpdateTotalValue()

    End Sub
    Private Sub ActivityBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ActivityBox.SelectedIndexChanged
        Dim selectedText As String = ActivityBox.SelectedItem.ToString()

        Dim selectedValue As Integer

        If Integer.TryParse(selectedText.Replace("%", ""), selectedValue) Then

        Else
            MessageBox.Show("Invalid selection")
        End If
    End Sub

    Private Sub QuizBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuizBox.SelectedIndexChanged
        Dim selectedText As String = QuizBox.SelectedItem.ToString()

        Dim selectedValue As Integer

        If Integer.TryParse(selectedText.Replace("%", ""), selectedValue) Then

        Else
            MessageBox.Show("Invalid selection")
        End If
    End Sub

    Private Sub PerfBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PerfBox.SelectedIndexChanged
        Dim selectedText As String = PerfBox.SelectedItem.ToString()

        Dim selectedValue As Integer

        If Integer.TryParse(selectedText.Replace("%", ""), selectedValue) Then

        Else
            MessageBox.Show("Invalid selection")
        End If
    End Sub

    Private Sub AttBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttBox.SelectedIndexChanged
        Dim selectedText As String = AttBox.SelectedItem.ToString()

        Dim selectedValue As Integer

        If Integer.TryParse(selectedText.Replace("%", ""), selectedValue) Then

        Else
            MessageBox.Show("Invalid selection")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        DashboardPanel.Combo1()
        DashboardPanel.Combo2()
        DashboardPanel.Combo3()
        DashboardPanel.Combo4()
        DashboardPanel.Count1()
        DashboardPanel.Count2()
        DashboardPanel.Count3()
        DashboardPanel.Count4()
    End Sub


End Class