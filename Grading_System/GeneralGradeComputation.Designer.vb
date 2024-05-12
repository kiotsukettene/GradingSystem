<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralGradeComputation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        Label1 = New Label()
        SectionBox = New ComboBox()
        FirstnameBox = New TextBox()
        SurnameBox = New TextBox()
        Label8 = New Label()
        Label6 = New Label()
        StudentBox = New ComboBox()
        Label2 = New Label()
        RoundCornerPanel1 = New RoundCornerPanel()
        Label3 = New Label()
        Act2 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        TotalAct = New TextBox()
        ProgramBox = New ComboBox()
        Label7 = New Label()
        ActPercent = New TextBox()
        Label10 = New Label()
        Quiz2 = New TextBox()
        Label15 = New Label()
        TotalQuiz = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        QuizPercent = New TextBox()
        Label19 = New Label()
        Participation = New TextBox()
        Label20 = New Label()
        ParticipationPercent = New TextBox()
        Label21 = New Label()
        attendancebox = New TextBox()
        Label22 = New Label()
        MidtermScore = New TextBox()
        Label23 = New Label()
        MidtermTotal = New TextBox()
        MidtermPercent = New TextBox()
        Label24 = New Label()
        MidtermGrade = New TextBox()
        Label25 = New Label()
        RoundCornerPanel2 = New RoundCornerPanel()
        CalculateBtn = New Label()
        Label9 = New Label()
        AttendancePercent = New TextBox()
        RecordView = New DataGridView()
        ActivityNum = New ComboBox()
        QuizNum = New ComboBox()
        RoundCornerPanel1.SuspendLayout()
        RoundCornerPanel2.SuspendLayout()
        CType(RecordView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label5.Location = New Point(226, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(242, 21)
        Label5.TabIndex = 44
        Label5.Text = "INFORMATION MANAGEMENT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(547, 32)
        Label1.TabIndex = 45
        Label1.Text = "GENERAL GRADING CALCULATION - MIDTERM"
        ' 
        ' SectionBox
        ' 
        SectionBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        SectionBox.FormattingEnabled = True
        SectionBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        SectionBox.Location = New Point(124, 40)
        SectionBox.Name = "SectionBox"
        SectionBox.Size = New Size(96, 23)
        SectionBox.TabIndex = 50
        ' 
        ' FirstnameBox
        ' 
        FirstnameBox.BorderStyle = BorderStyle.FixedSingle
        FirstnameBox.Location = New Point(169, 131)
        FirstnameBox.Margin = New Padding(3, 2, 3, 2)
        FirstnameBox.Name = "FirstnameBox"
        FirstnameBox.Size = New Size(132, 23)
        FirstnameBox.TabIndex = 64
        ' 
        ' SurnameBox
        ' 
        SurnameBox.BorderStyle = BorderStyle.FixedSingle
        SurnameBox.Location = New Point(169, 105)
        SurnameBox.Margin = New Padding(3, 2, 3, 2)
        SurnameBox.Name = "SurnameBox"
        SurnameBox.Size = New Size(132, 23)
        SurnameBox.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label8.Location = New Point(22, 131)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 21)
        Label8.TabIndex = 62
        Label8.Text = "FIRSTNAME:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label6.Location = New Point(22, 102)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 21)
        Label6.TabIndex = 61
        Label6.Text = "SURNAME:"
        ' 
        ' StudentBox
        ' 
        StudentBox.FormattingEnabled = True
        StudentBox.Items.AddRange(New Object() {"ACTIVITIES", "QUIZZES", "PARTICIPATION", "ATTENDANCE ", "EXAM"})
        StudentBox.Location = New Point(169, 78)
        StudentBox.Margin = New Padding(3, 2, 3, 2)
        StudentBox.Name = "StudentBox"
        StudentBox.Size = New Size(133, 23)
        StudentBox.TabIndex = 60
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label2.Location = New Point(22, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 21)
        Label2.TabIndex = 59
        Label2.Text = "SELECT STUDENT:"
        ' 
        ' RoundCornerPanel1
        ' 
        RoundCornerPanel1.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel1.Controls.Add(Label3)
        RoundCornerPanel1.Location = New Point(24, 608)
        RoundCornerPanel1.Name = "RoundCornerPanel1"
        RoundCornerPanel1.Size = New Size(131, 28)
        RoundCornerPanel1.TabIndex = 58
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 28)
        Label3.TabIndex = 42
        Label3.Text = "ADD"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Act2
        ' 
        Act2.BorderStyle = BorderStyle.FixedSingle
        Act2.Location = New Point(169, 190)
        Act2.Margin = New Padding(3, 2, 3, 2)
        Act2.Name = "Act2"
        Act2.Size = New Size(132, 23)
        Act2.TabIndex = 57
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label11.Location = New Point(22, 160)
        Label11.Name = "Label11"
        Label11.Size = New Size(97, 21)
        Label11.TabIndex = 51
        Label11.Text = "ACTIVITY #:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label12.Location = New Point(22, 219)
        Label12.Name = "Label12"
        Label12.Size = New Size(94, 21)
        Label12.TabIndex = 65
        Label12.Text = "TOTAL ACT:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label14.Location = New Point(22, 190)
        Label14.Name = "Label14"
        Label14.Size = New Size(138, 21)
        Label14.TabIndex = 71
        Label14.Text = "ACTIVITY SCORE:"
        ' 
        ' TotalAct
        ' 
        TotalAct.BorderStyle = BorderStyle.FixedSingle
        TotalAct.Location = New Point(169, 217)
        TotalAct.Margin = New Padding(3, 2, 3, 2)
        TotalAct.Name = "TotalAct"
        TotalAct.Size = New Size(132, 23)
        TotalAct.TabIndex = 73
        ' 
        ' ProgramBox
        ' 
        ProgramBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ProgramBox.FormattingEnabled = True
        ProgramBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        ProgramBox.Location = New Point(22, 41)
        ProgramBox.Name = "ProgramBox"
        ProgramBox.Size = New Size(96, 23)
        ProgramBox.TabIndex = 74
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label7.Location = New Point(22, 245)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 21)
        Label7.TabIndex = 75
        Label7.Text = "ACTIVITY %:"
        ' 
        ' ActPercent
        ' 
        ActPercent.BorderStyle = BorderStyle.FixedSingle
        ActPercent.Location = New Point(169, 243)
        ActPercent.Margin = New Padding(3, 2, 3, 2)
        ActPercent.Name = "ActPercent"
        ActPercent.Size = New Size(132, 23)
        ActPercent.TabIndex = 76
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label10.Location = New Point(22, 276)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 21)
        Label10.TabIndex = 77
        Label10.Text = "QUIZ #:"
        ' 
        ' Quiz2
        ' 
        Quiz2.BorderStyle = BorderStyle.FixedSingle
        Quiz2.Location = New Point(169, 299)
        Quiz2.Margin = New Padding(3, 2, 3, 2)
        Quiz2.Name = "Quiz2"
        Quiz2.Size = New Size(132, 23)
        Quiz2.TabIndex = 80
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label15.Location = New Point(22, 301)
        Label15.Name = "Label15"
        Label15.Size = New Size(107, 21)
        Label15.TabIndex = 79
        Label15.Text = "QUIZ SCORE:"
        ' 
        ' TotalQuiz
        ' 
        TotalQuiz.BorderStyle = BorderStyle.FixedSingle
        TotalQuiz.Location = New Point(169, 326)
        TotalQuiz.Margin = New Padding(3, 2, 3, 2)
        TotalQuiz.Name = "TotalQuiz"
        TotalQuiz.Size = New Size(132, 23)
        TotalQuiz.TabIndex = 82
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label16.Location = New Point(22, 352)
        Label16.Name = "Label16"
        Label16.Size = New Size(0, 21)
        Label16.TabIndex = 81
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label17.Location = New Point(22, 328)
        Label17.Name = "Label17"
        Label17.Size = New Size(103, 21)
        Label17.TabIndex = 83
        Label17.Text = "TOTAL QUIZ:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label18.Location = New Point(22, 355)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 21)
        Label18.TabIndex = 85
        Label18.Text = "QUIZ %:"
        ' 
        ' QuizPercent
        ' 
        QuizPercent.BorderStyle = BorderStyle.FixedSingle
        QuizPercent.Location = New Point(169, 353)
        QuizPercent.Margin = New Padding(3, 2, 3, 2)
        QuizPercent.Name = "QuizPercent"
        QuizPercent.Size = New Size(132, 23)
        QuizPercent.TabIndex = 84
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label19.Location = New Point(22, 381)
        Label19.Name = "Label19"
        Label19.Size = New Size(131, 21)
        Label19.TabIndex = 86
        Label19.Text = "PARTICIPATION:"
        ' 
        ' Participation
        ' 
        Participation.BorderStyle = BorderStyle.FixedSingle
        Participation.Location = New Point(169, 381)
        Participation.Margin = New Padding(3, 2, 3, 2)
        Participation.Name = "Participation"
        Participation.Size = New Size(132, 23)
        Participation.TabIndex = 87
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label20.Location = New Point(22, 406)
        Label20.Name = "Label20"
        Label20.Size = New Size(149, 21)
        Label20.TabIndex = 88
        Label20.Text = "PARTICIPATION %:"
        ' 
        ' ParticipationPercent
        ' 
        ParticipationPercent.BorderStyle = BorderStyle.FixedSingle
        ParticipationPercent.Location = New Point(169, 408)
        ParticipationPercent.Margin = New Padding(3, 2, 3, 2)
        ParticipationPercent.Name = "ParticipationPercent"
        ParticipationPercent.Size = New Size(132, 23)
        ParticipationPercent.TabIndex = 89
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label21.Location = New Point(22, 433)
        Label21.Name = "Label21"
        Label21.Size = New Size(123, 21)
        Label21.TabIndex = 90
        Label21.Text = "ATTENDANCE :"
        ' 
        ' attendancebox
        ' 
        attendancebox.BorderStyle = BorderStyle.FixedSingle
        attendancebox.Location = New Point(169, 435)
        attendancebox.Margin = New Padding(3, 2, 3, 2)
        attendancebox.Name = "attendancebox"
        attendancebox.Size = New Size(132, 23)
        attendancebox.TabIndex = 91
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label22.Location = New Point(22, 489)
        Label22.Name = "Label22"
        Label22.Size = New Size(142, 21)
        Label22.TabIndex = 92
        Label22.Text = "MIDTERM SCORE:"
        ' 
        ' MidtermScore
        ' 
        MidtermScore.BorderStyle = BorderStyle.FixedSingle
        MidtermScore.Location = New Point(169, 489)
        MidtermScore.Margin = New Padding(3, 2, 3, 2)
        MidtermScore.Name = "MidtermScore"
        MidtermScore.Size = New Size(132, 23)
        MidtermScore.TabIndex = 93
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label23.Location = New Point(22, 519)
        Label23.Name = "Label23"
        Label23.Size = New Size(138, 21)
        Label23.TabIndex = 94
        Label23.Text = "MIDTERM TOTAL:"
        ' 
        ' MidtermTotal
        ' 
        MidtermTotal.BorderStyle = BorderStyle.FixedSingle
        MidtermTotal.Location = New Point(169, 519)
        MidtermTotal.Margin = New Padding(3, 2, 3, 2)
        MidtermTotal.Name = "MidtermTotal"
        MidtermTotal.Size = New Size(132, 23)
        MidtermTotal.TabIndex = 95
        ' 
        ' MidtermPercent
        ' 
        MidtermPercent.BorderStyle = BorderStyle.FixedSingle
        MidtermPercent.Location = New Point(169, 547)
        MidtermPercent.Margin = New Padding(3, 2, 3, 2)
        MidtermPercent.Name = "MidtermPercent"
        MidtermPercent.Size = New Size(132, 23)
        MidtermPercent.TabIndex = 97
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label24.Location = New Point(22, 547)
        Label24.Name = "Label24"
        Label24.Size = New Size(106, 21)
        Label24.TabIndex = 96
        Label24.Text = "MIDTERM %:"
        ' 
        ' MidtermGrade
        ' 
        MidtermGrade.BorderStyle = BorderStyle.FixedSingle
        MidtermGrade.Location = New Point(169, 578)
        MidtermGrade.Margin = New Padding(3, 2, 3, 2)
        MidtermGrade.Name = "MidtermGrade"
        MidtermGrade.Size = New Size(132, 23)
        MidtermGrade.TabIndex = 99
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label25.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label25.Location = New Point(22, 578)
        Label25.Name = "Label25"
        Label25.Size = New Size(145, 21)
        Label25.TabIndex = 98
        Label25.Text = "MIDTERM GRADE:"
        ' 
        ' RoundCornerPanel2
        ' 
        RoundCornerPanel2.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel2.Controls.Add(CalculateBtn)
        RoundCornerPanel2.Location = New Point(169, 607)
        RoundCornerPanel2.Name = "RoundCornerPanel2"
        RoundCornerPanel2.Size = New Size(131, 28)
        RoundCornerPanel2.TabIndex = 100
        ' 
        ' CalculateBtn
        ' 
        CalculateBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CalculateBtn.ForeColor = Color.White
        CalculateBtn.Location = New Point(26, 1)
        CalculateBtn.Name = "CalculateBtn"
        CalculateBtn.Size = New Size(82, 28)
        CalculateBtn.TabIndex = 42
        CalculateBtn.Text = "CALCULATE"
        CalculateBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label9.Location = New Point(22, 460)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 21)
        Label9.TabIndex = 101
        Label9.Text = "ATTENDANCE %:"
        ' 
        ' AttendancePercent
        ' 
        AttendancePercent.BorderStyle = BorderStyle.FixedSingle
        AttendancePercent.Location = New Point(169, 462)
        AttendancePercent.Margin = New Padding(3, 2, 3, 2)
        AttendancePercent.Name = "AttendancePercent"
        AttendancePercent.Size = New Size(132, 23)
        AttendancePercent.TabIndex = 102
        ' 
        ' RecordView
        ' 
        RecordView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RecordView.Location = New Point(314, 72)
        RecordView.Name = "RecordView"
        RecordView.RowTemplate.Height = 25
        RecordView.Size = New Size(535, 566)
        RecordView.TabIndex = 103
        ' 
        ' ActivityNum
        ' 
        ActivityNum.FormattingEnabled = True
        ActivityNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ActivityNum.Location = New Point(169, 158)
        ActivityNum.Margin = New Padding(3, 2, 3, 2)
        ActivityNum.Name = "ActivityNum"
        ActivityNum.Size = New Size(133, 23)
        ActivityNum.TabIndex = 104
        ' 
        ' QuizNum
        ' 
        QuizNum.FormattingEnabled = True
        QuizNum.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        QuizNum.Location = New Point(169, 270)
        QuizNum.Margin = New Padding(3, 2, 3, 2)
        QuizNum.Name = "QuizNum"
        QuizNum.Size = New Size(133, 23)
        QuizNum.TabIndex = 105
        ' 
        ' GeneralGradeComputation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(QuizNum)
        Controls.Add(ActivityNum)
        Controls.Add(RecordView)
        Controls.Add(AttendancePercent)
        Controls.Add(Label9)
        Controls.Add(RoundCornerPanel2)
        Controls.Add(MidtermGrade)
        Controls.Add(Label25)
        Controls.Add(MidtermPercent)
        Controls.Add(Label24)
        Controls.Add(MidtermTotal)
        Controls.Add(Label23)
        Controls.Add(MidtermScore)
        Controls.Add(Label22)
        Controls.Add(attendancebox)
        Controls.Add(Label21)
        Controls.Add(ParticipationPercent)
        Controls.Add(Label20)
        Controls.Add(Participation)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(QuizPercent)
        Controls.Add(Label17)
        Controls.Add(TotalQuiz)
        Controls.Add(Label16)
        Controls.Add(Quiz2)
        Controls.Add(Label15)
        Controls.Add(Label10)
        Controls.Add(ActPercent)
        Controls.Add(Label7)
        Controls.Add(ProgramBox)
        Controls.Add(TotalAct)
        Controls.Add(Label14)
        Controls.Add(Label12)
        Controls.Add(FirstnameBox)
        Controls.Add(SurnameBox)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(StudentBox)
        Controls.Add(Label2)
        Controls.Add(RoundCornerPanel1)
        Controls.Add(Act2)
        Controls.Add(Label11)
        Controls.Add(SectionBox)
        Controls.Add(Label1)
        Controls.Add(Label5)
        FormBorderStyle = FormBorderStyle.None
        Name = "GeneralGradeComputation"
        Text = "GeneralGradeComputation"
        RoundCornerPanel1.ResumeLayout(False)
        RoundCornerPanel2.ResumeLayout(False)
        CType(RecordView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SectionBox As ComboBox
    Friend WithEvents FirstnameBox As TextBox
    Friend WithEvents SurnameBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StudentBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundCornerPanel1 As RoundCornerPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Act2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TotalAct As TextBox
    Friend WithEvents ProgramBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ActPercent As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Quiz2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TotalQuiz As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents QuizPercent As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Participation As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ParticipationPercent As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents attendancebox As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents MidtermScore As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents MidtermTotal As TextBox
    Friend WithEvents MidtermPercent As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents MidtermGrade As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents RoundCornerPanel2 As RoundCornerPanel
    Friend WithEvents CalculateBtn As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AttendancePercent As TextBox
    Friend WithEvents RecordView As DataGridView
    Friend WithEvents ActivityNum As ComboBox
    Friend WithEvents QuizNum As ComboBox
End Class
