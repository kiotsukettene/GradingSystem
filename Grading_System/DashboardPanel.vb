Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class DashboardPanel
    Dim mycon As New DBConnection
    Dim dataTable As New DataTable



    Private Sub BSCSSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BSCSSection.SelectedIndexChanged
        Dim program As String

        program = Program1.Text

        'Dim SelectedValue As String = BSCSSection.SelectedItem.ToString()

        DisplayCSSectionGrid()

        GeneralGradeComputation.ProgramBox.Text = Program1.Text
        GeneralGradeComputation.SectionBox.Text = BSCSSection.Text

        BSITSection.Text = "Select Section..."
        BSISSection.Text = "Select Section..."
        BSEMCSection.Text = "Select Section..."
        'DisplayCSSectionGrid()
    End Sub

    Public Sub Combo1()
        Dim profID As String = ProfManagement.DisplayProfID.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT CONCAT(year, section) AS ConcatenatedValue FROM user_subsec WHERE program = 'BSCS' AND prof_id=@prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)

        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()

        BSCSSection.Items.Clear()
        While dataReader.Read()
            BSCSSection.Items.Add(dataReader("ConcatenatedValue"))
        End While
        mycon.close()


    End Sub

    Public Sub Combo2()
        Dim profID As String = ProfManagement.DisplayProfID.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT CONCAT(year, section) AS ConcatenatedValue FROM user_subsec WHERE program = 'BSIT'  AND prof_id=@prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)
        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()

        BSITSection.Items.Clear()
        While dataReader.Read()
            BSITSection.Items.Add(dataReader("ConcatenatedValue"))
        End While
        mycon.close()
    End Sub
    Public Sub Combo3()
        Dim profID As String = ProfManagement.DisplayProfID.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT CONCAT(year, section) AS ConcatenatedValue FROM user_subsec WHERE program = 'BSIS'  AND prof_id=@prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)
        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()

        BSISSection.Items.Clear()
        While dataReader.Read()
            BSISSection.Items.Add(dataReader("ConcatenatedValue"))
        End While
        mycon.close()
    End Sub
    Public Sub Combo4()

        Dim profID As String = ProfManagement.DisplayProfID.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT DISTINCT CONCAT(year, section) AS ConcatenatedValue FROM user_subsec WHERE program = 'BSEMC'  AND prof_id=@prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)
        Dim dataReader As MySqlDataReader = cmd.ExecuteReader()

        BSEMCSection.Items.Clear()
        While dataReader.Read()
            BSEMCSection.Items.Add(dataReader("ConcatenatedValue"))
        End While
        mycon.close()
    End Sub
    Public Sub Count1()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT COUNT(1) AS SectionCount FROM user_subsec WHERE program = 'BSCS' AND prof_id = @prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)

        Dim sectionCount As Object = cmd.ExecuteScalar()

        If sectionCount IsNot DBNull.Value Then
            TotalCS.Text = sectionCount.ToString()
        Else
            MsgBox("Invalid")
        End If

        mycon.close()
    End Sub

    Public Sub Count2()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT COUNT(1) AS SectionCount FROM user_subsec WHERE program = 'BSIT' AND prof_id = @prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)

        Dim sectionCount As Object = cmd.ExecuteScalar()

        If sectionCount IsNot DBNull.Value Then
            TotalIT.Text = sectionCount.ToString()
        Else
            MsgBox("Invalid")
        End If

        mycon.close()
    End Sub
    Public Sub Count3()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT COUNT(1) AS SectionCount FROM user_subsec WHERE program = 'BSIS' AND prof_id = @prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)

        Dim sectionCount As Object = cmd.ExecuteScalar()

        If sectionCount IsNot DBNull.Value Then
            TotalIS.Text = sectionCount.ToString()
        Else
            MsgBox("Invalid")
        End If

        mycon.close()
    End Sub

    Public Sub Count4()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT COUNT(1) AS SectionCount FROM user_subsec WHERE program = 'BSEMC' AND prof_id = @prof_id", mycon.getCon())
        cmd.Parameters.AddWithValue("@prof_id", profID)

        Dim sectionCount As Object = cmd.ExecuteScalar()

        If sectionCount IsNot DBNull.Value Then
            TotalEMC.Text = sectionCount.ToString()
        Else
            MsgBox("Invalid")
        End If

        mycon.close()
    End Sub

    'Public Sub LoadData()
    'Dim cmd As New MySqlCommand
    'Dim profid As String = ProfManagement.DisplayProfID.Text
    'Try
    'mycon.Reload("SELECT Section FROM user_subsec", BSCSSection)
    'BSCSSection.DisplayMember = "Section"
    'BSCSSection.ValueMember = "prof_id"

    'Catch ex As Exception
    ' Handle exceptions here if needed
    'End Try
    'End Sub
    Public Sub DisplayCSSectionGrid()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        Dim selectedSection As String = BSCSSection.Text

        mycon.open()

        ' Assuming the 'year' is the first character(s) and 'section' is the last character
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)

        Dim cmd As New MySqlCommand("SELECT `Student_No.`, `Surname`, `FirstName`, `MiddleName`, `Gender`, `Course`, `Year`, `Status`
                                    FROM student_profile 
                                    WHERE `Section` = @Section
                                    AND Course LIKE @Course
                                    ", mycon.getCon())

        cmd.Parameters.AddWithValue("@Section", section)
        cmd.Parameters.AddWithValue("@Course", "%" + Program1.Text + "%")
        Dim sqlAdapter As New MySqlDataAdapter
        sqlAdapter.SelectCommand = cmd

        Dim dataTable As New DataTable
        dataTable.Clear()
        sqlAdapter.Fill(dataTable)
        SectionDataView.DataSource = dataTable
        mycon.close()


    End Sub
    Public Sub FirstDisplayCSSection()
        Dim selectedValue As String = BSCSSection.SelectedItem.ToString()
        Dim program As String
        program = Program1.Text
        mycon.open()

        Dim cmd As New MySqlCommand("SELECT `Student_No.`, `Name`, `Program`, `Section`, `Email`, `Gender`, `Status` 
                                        FROM section_data WHERE `Section` LIKE '%" + BSCSSection.Text + "%'
                                        AND Program LIKE '%" + Program1.Text + "%' ", mycon.getCon())
        'cmd.Parameters.Add("@SelectedValue", MySqlDbType.VarChar).Value = selectedValue
        'cmd.Parameters.Add("@program", MySqlDbType.VarChar).Value = program
        Dim sqlAdapter As New MySqlDataAdapter
        sqlAdapter.SelectCommand = cmd

        Dim dataTable As New DataTable
        dataTable.Clear()
        sqlAdapter.Fill(dataTable)
        SectionDataView.DataSource = dataTable
        mycon.close()
    End Sub
    Public Sub DisplayITSectionGrid()


        Dim selectedSection As String = BSITSection.Text

        mycon.open()

        ' Assuming the 'year' is the first character(s) and 'section' is the last character
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)

        Dim cmd As New MySqlCommand("SELECT `Student_No.`, `Surname`, `FirstName`, `MiddleName`, `Gender`, `Course`, `Year`, `Status`
                                    FROM student_profile 
                                    WHERE `Section` = @Section
                                    AND Course LIKE @Course
                                    ", mycon.getCon())

        cmd.Parameters.AddWithValue("@Section", section)
        cmd.Parameters.AddWithValue("@Course", "%" + Program2.Text + "%")
        Dim sqlAdapter As New MySqlDataAdapter
        sqlAdapter.SelectCommand = cmd

        Dim dataTable As New DataTable
        dataTable.Clear()
        sqlAdapter.Fill(dataTable)
        SectionDataView.DataSource = dataTable
        mycon.close()
    End Sub

    Public Sub DisplayISSectionGrid()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        Dim selectedSection As String = BSISSection.Text

        mycon.open()

        ' Assuming the 'year' is the first character(s) and 'section' is the last character
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)

        Dim cmd As New MySqlCommand("SELECT `Student_No.`, `Surname`, `FirstName`, `MiddleName`, `Gender`, `Course`, `Year`, `Status`
                                    FROM student_profile 
                                    WHERE `Section` = @Section
                                    AND Course LIKE @Course
                                    ", mycon.getCon())

        cmd.Parameters.AddWithValue("@Section", section)
        cmd.Parameters.AddWithValue("@Course", "%" + Program3.Text + "%")
        Dim sqlAdapter As New MySqlDataAdapter
        sqlAdapter.SelectCommand = cmd

        Dim dataTable As New DataTable
        dataTable.Clear()
        sqlAdapter.Fill(dataTable)
        SectionDataView.DataSource = dataTable
        mycon.close()
    End Sub
    Public Sub DisplayEMCSectionGrid()
        Dim profID As String = ProfManagement.DisplayProfID.Text

        Dim selectedSection As String = BSEMCSection.Text

        mycon.open()

        ' Assuming the 'year' is the first character(s) and 'section' is the last character
        Dim year As String = selectedSection.Substring(0, selectedSection.Length - 1)
        Dim section As String = selectedSection.Substring(selectedSection.Length - 1)

        Dim cmd As New MySqlCommand("SELECT `Student_No.`, `Surname`, `FirstName`, `MiddleName`, `Gender`, `Course`, `Year`, `Status`
                                    FROM student_profile 
                                    WHERE `Section` = @Section
                                    AND Course LIKE @Course
                                    ", mycon.getCon())

        cmd.Parameters.AddWithValue("@Section", section)
        cmd.Parameters.AddWithValue("@Course", "%" + Program4.Text + "%")
        Dim sqlAdapter As New MySqlDataAdapter
        sqlAdapter.SelectCommand = cmd

        Dim dataTable As New DataTable
        dataTable.Clear()
        sqlAdapter.Fill(dataTable)
        SectionDataView.DataSource = dataTable
        mycon.close()
    End Sub

    Private Sub DashboardPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycon = New DBConnection
        Combo1()
        Combo2()
        Combo3()
        Combo4()
        Count1()
        Count2()
        Count3()
        Count4()

        'LoadData()
    End Sub

    Private Sub BSITSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BSITSection.SelectedIndexChanged
        'Dim SelectedValue As String = BSITSection.SelectedItem.ToString()
        Dim program As String = Program2.Text

        DisplayITSectionGrid()
        GeneralGradeComputation.ProgramBox.Text = Program2.Text
        GeneralGradeComputation.SectionBox.Text = BSITSection.Text
        BSCSSection.Text = "Select Section..."
        BSISSection.Text = "Select Section..."
        BSEMCSection.Text = "Select Section..."
    End Sub

    Private Sub BSISSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BSISSection.SelectedIndexChanged
        Dim program As String = Program3.Text

        DisplayISSectionGrid()
        GeneralGradeComputation.ProgramBox.Text = Program3.Text
        GeneralGradeComputation.SectionBox.Text = BSISSection.Text
        BSCSSection.Text = "Select Section..."
        BSITSection.Text = "Select Section..."
        BSEMCSection.Text = "Select Section..."
    End Sub

    Private Sub BSEMCSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BSEMCSection.SelectedIndexChanged
        Dim program As String = Program3.Text


        DisplayEMCSectionGrid()
        GeneralGradeComputation.ProgramBox.Text = Program4.Text
        GeneralGradeComputation.SectionBox.Text = BSEMCSection.Text
        BSCSSection.Text = "Select Section..."
        BSISSection.Text = "Select Section..."
        BSITSection.Text = "Select Section..."
    End Sub



    Public Sub Search()

        mycon.open()

        Dim cmd As New MySqlCommand("SELECT `Student_No.`, `Surname`, `FirstName`, `MiddleName`, `Gender`, `Course`, `Year`, `Status` " &
                            "FROM student_profile WHERE `Student_No.` LIKE @SearchText OR `Surname` LIKE @SearchText", mycon.getCon())
        cmd.Parameters.AddWithValue("@SearchText", "%" & SearchBox.Text & "%")
        Dim sqlAdapter As New MySqlDataAdapter
        Dim dataTable As New DataTable

        sqlAdapter.SelectCommand = cmd
        dataTable.Clear()
        sqlAdapter.Fill(dataTable)

        SectionDataView.DataSource = dataTable


        mycon.close()



    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Search()
    End Sub
End Class