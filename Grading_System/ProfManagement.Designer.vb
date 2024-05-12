<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfManagement
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        RoundCornerPanel1 = New RoundCornerPanel()
        Panel16 = New Panel()
        DisplayProfID = New RoundCornerTextbox()
        Label29 = New Label()
        DisplayPass = New RoundCornerTextbox()
        DisplayEmail = New RoundCornerTextbox()
        DisplayLname = New RoundCornerTextbox()
        DisplayFname = New RoundCornerTextbox()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        PassProfile = New Label()
        EmailProfile = New Label()
        LnameProfile = New Label()
        FnameProfile = New Label()
        Label2 = New Label()
        ProfEditBtn = New Label()
        GradeEdit = New Label()
        Label9 = New Label()
        GradePercentagePanel = New RoundCornerPanel()
        Panel12 = New Panel()
        AttBox = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Panel8 = New Panel()
        Panel7 = New Panel()
        PerfBox = New ComboBox()
        QuizBox = New ComboBox()
        ActivityBox = New ComboBox()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        TotalPercentageBox = New TextBox()
        Label14 = New Label()
        FinalExamBox = New ComboBox()
        ClassOSBox = New ComboBox()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        HandledSectionView = New DataGridView()
        Label15 = New Label()
        AddSec = New Label()
        Label21 = New Label()
        RoundCornerPanel2 = New RoundCornerPanel()
        AddYear = New ComboBox()
        Label3 = New Label()
        AddSubject = New ComboBox()
        AddSection = New ComboBox()
        AddProgram = New ComboBox()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        RoundCornerPanel3 = New RoundCornerPanel()
        ProfileUpdBtn = New RoundCornerPanel()
        SaveChanges = New Label()
        SaveChangesGrade = New RoundCornerPanel()
        PercentageSave = New Label()
        Panel13 = New Panel()
        TotalStanding = New ComboBox()
        Timer1 = New Timer(components)
        RoundCornerPanel1.SuspendLayout()
        GradePercentagePanel.SuspendLayout()
        CType(HandledSectionView, ComponentModel.ISupportInitialize).BeginInit()
        RoundCornerPanel2.SuspendLayout()
        RoundCornerPanel3.SuspendLayout()
        ProfileUpdBtn.SuspendLayout()
        SaveChangesGrade.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label1.Location = New Point(0, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 32)
        Label1.TabIndex = 30
        Label1.Text = "PROFESSOR MANAGEMENT"
        ' 
        ' RoundCornerPanel1
        ' 
        RoundCornerPanel1.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel1.Controls.Add(Panel16)
        RoundCornerPanel1.Controls.Add(DisplayProfID)
        RoundCornerPanel1.Controls.Add(Label29)
        RoundCornerPanel1.Controls.Add(DisplayPass)
        RoundCornerPanel1.Controls.Add(DisplayEmail)
        RoundCornerPanel1.Controls.Add(DisplayLname)
        RoundCornerPanel1.Controls.Add(DisplayFname)
        RoundCornerPanel1.Controls.Add(Panel3)
        RoundCornerPanel1.Controls.Add(Panel2)
        RoundCornerPanel1.Controls.Add(Panel1)
        RoundCornerPanel1.Controls.Add(PassProfile)
        RoundCornerPanel1.Controls.Add(EmailProfile)
        RoundCornerPanel1.Controls.Add(LnameProfile)
        RoundCornerPanel1.Controls.Add(FnameProfile)
        RoundCornerPanel1.Location = New Point(10, 62)
        RoundCornerPanel1.Name = "RoundCornerPanel1"
        RoundCornerPanel1.Size = New Size(438, 188)
        RoundCornerPanel1.TabIndex = 31
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.White
        Panel16.Location = New Point(3, 156)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(435, 1)
        Panel16.TabIndex = 40
        ' 
        ' DisplayProfID
        ' 
        DisplayProfID.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        DisplayProfID.BorderStyle = BorderStyle.None
        DisplayProfID.Enabled = False
        DisplayProfID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayProfID.ForeColor = Color.White
        DisplayProfID.Location = New Point(142, 159)
        DisplayProfID.Multiline = True
        DisplayProfID.Name = "DisplayProfID"
        DisplayProfID.ReadOnly = True
        DisplayProfID.Size = New Size(292, 23)
        DisplayProfID.TabIndex = 38
        DisplayProfID.Text = "892"
        DisplayProfID.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.FlatStyle = FlatStyle.Flat
        Label29.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label29.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label29.Location = New Point(6, 159)
        Label29.Name = "Label29"
        Label29.Size = New Size(120, 21)
        Label29.TabIndex = 39
        Label29.Text = "PROFESSOR ID"
        ' 
        ' DisplayPass
        ' 
        DisplayPass.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        DisplayPass.BorderStyle = BorderStyle.None
        DisplayPass.Enabled = False
        DisplayPass.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayPass.ForeColor = Color.White
        DisplayPass.Location = New Point(142, 124)
        DisplayPass.Multiline = True
        DisplayPass.Name = "DisplayPass"
        DisplayPass.PasswordChar = "*"c
        DisplayPass.Size = New Size(292, 23)
        DisplayPass.TabIndex = 35
        DisplayPass.Text = "russellpogi"
        DisplayPass.TextAlign = HorizontalAlignment.Right
        ' 
        ' DisplayEmail
        ' 
        DisplayEmail.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        DisplayEmail.BorderStyle = BorderStyle.None
        DisplayEmail.Enabled = False
        DisplayEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayEmail.ForeColor = Color.White
        DisplayEmail.Location = New Point(142, 85)
        DisplayEmail.Multiline = True
        DisplayEmail.Name = "DisplayEmail"
        DisplayEmail.Size = New Size(292, 23)
        DisplayEmail.TabIndex = 35
        DisplayEmail.Text = "barrios@gmail.com"
        DisplayEmail.TextAlign = HorizontalAlignment.Right
        ' 
        ' DisplayLname
        ' 
        DisplayLname.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        DisplayLname.BorderStyle = BorderStyle.None
        DisplayLname.Enabled = False
        DisplayLname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayLname.ForeColor = Color.White
        DisplayLname.Location = New Point(142, 46)
        DisplayLname.Multiline = True
        DisplayLname.Name = "DisplayLname"
        DisplayLname.Size = New Size(292, 23)
        DisplayLname.TabIndex = 35
        DisplayLname.Text = "BARRIOS"
        DisplayLname.TextAlign = HorizontalAlignment.Right
        ' 
        ' DisplayFname
        ' 
        DisplayFname.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        DisplayFname.BorderStyle = BorderStyle.None
        DisplayFname.Enabled = False
        DisplayFname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayFname.ForeColor = Color.White
        DisplayFname.Location = New Point(142, 8)
        DisplayFname.Margin = New Padding(4)
        DisplayFname.Multiline = True
        DisplayFname.Name = "DisplayFname"
        DisplayFname.Size = New Size(292, 23)
        DisplayFname.TabIndex = 34
        DisplayFname.Text = "JOEMEN"
        DisplayFname.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Location = New Point(3, 117)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(435, 1)
        Panel3.TabIndex = 35
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(3, 78)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(435, 1)
        Panel2.TabIndex = 35
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(3, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(435, 1)
        Panel1.TabIndex = 34
        ' 
        ' PassProfile
        ' 
        PassProfile.AutoSize = True
        PassProfile.FlatStyle = FlatStyle.Flat
        PassProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PassProfile.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        PassProfile.Location = New Point(6, 127)
        PassProfile.Name = "PassProfile"
        PassProfile.Size = New Size(98, 21)
        PassProfile.TabIndex = 37
        PassProfile.Text = "PASSWORD"
        ' 
        ' EmailProfile
        ' 
        EmailProfile.AutoSize = True
        EmailProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        EmailProfile.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        EmailProfile.Location = New Point(6, 89)
        EmailProfile.Name = "EmailProfile"
        EmailProfile.Size = New Size(58, 21)
        EmailProfile.TabIndex = 36
        EmailProfile.Text = "EMAIL"
        ' 
        ' LnameProfile
        ' 
        LnameProfile.AutoSize = True
        LnameProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LnameProfile.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        LnameProfile.Location = New Point(6, 50)
        LnameProfile.Name = "LnameProfile"
        LnameProfile.Size = New Size(99, 21)
        LnameProfile.TabIndex = 35
        LnameProfile.Text = "LAST NAME"
        ' 
        ' FnameProfile
        ' 
        FnameProfile.AutoSize = True
        FnameProfile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FnameProfile.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        FnameProfile.Location = New Point(6, 13)
        FnameProfile.Name = "FnameProfile"
        FnameProfile.Size = New Size(103, 21)
        FnameProfile.TabIndex = 34
        FnameProfile.Text = "FIRST NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label2.Location = New Point(10, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 21)
        Label2.TabIndex = 32
        Label2.Text = "PROFESSOR PROFILE"
        ' 
        ' ProfEditBtn
        ' 
        ProfEditBtn.AutoSize = True
        ProfEditBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ProfEditBtn.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        ProfEditBtn.Location = New Point(399, 41)
        ProfEditBtn.Name = "ProfEditBtn"
        ProfEditBtn.Size = New Size(45, 21)
        ProfEditBtn.TabIndex = 33
        ProfEditBtn.Text = "EDIT"
        ' 
        ' GradeEdit
        ' 
        GradeEdit.AutoSize = True
        GradeEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GradeEdit.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        GradeEdit.Location = New Point(786, 41)
        GradeEdit.Name = "GradeEdit"
        GradeEdit.Size = New Size(45, 21)
        GradeEdit.TabIndex = 36
        GradeEdit.Text = "EDIT"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label9.Location = New Point(454, 41)
        Label9.Name = "Label9"
        Label9.Size = New Size(167, 21)
        Label9.TabIndex = 35
        Label9.Text = "GRADE PERCENTAGE"
        ' 
        ' GradePercentagePanel
        ' 
        GradePercentagePanel.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        GradePercentagePanel.Controls.Add(Panel12)
        GradePercentagePanel.Controls.Add(AttBox)
        GradePercentagePanel.Controls.Add(Label4)
        GradePercentagePanel.Controls.Add(Label5)
        GradePercentagePanel.Controls.Add(Panel8)
        GradePercentagePanel.Controls.Add(Panel7)
        GradePercentagePanel.Controls.Add(PerfBox)
        GradePercentagePanel.Controls.Add(QuizBox)
        GradePercentagePanel.Controls.Add(ActivityBox)
        GradePercentagePanel.Controls.Add(Label19)
        GradePercentagePanel.Controls.Add(Label18)
        GradePercentagePanel.Controls.Add(Label17)
        GradePercentagePanel.Controls.Add(TotalPercentageBox)
        GradePercentagePanel.Controls.Add(Label14)
        GradePercentagePanel.Controls.Add(FinalExamBox)
        GradePercentagePanel.Controls.Add(ClassOSBox)
        GradePercentagePanel.Controls.Add(Panel4)
        GradePercentagePanel.Controls.Add(Panel5)
        GradePercentagePanel.Controls.Add(Panel6)
        GradePercentagePanel.Controls.Add(Label10)
        GradePercentagePanel.Controls.Add(Label11)
        GradePercentagePanel.Controls.Add(Label12)
        GradePercentagePanel.Controls.Add(Label13)
        GradePercentagePanel.Location = New Point(454, 62)
        GradePercentagePanel.Name = "GradePercentagePanel"
        GradePercentagePanel.Size = New Size(395, 295)
        GradePercentagePanel.TabIndex = 34
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.White
        Panel12.Location = New Point(2, 232)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(390, 1)
        Panel12.TabIndex = 44
        ' 
        ' AttBox
        ' 
        AttBox.Enabled = False
        AttBox.FlatStyle = FlatStyle.Flat
        AttBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AttBox.FormattingEnabled = True
        AttBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        AttBox.Location = New Point(332, 235)
        AttBox.Name = "AttBox"
        AttBox.Size = New Size(49, 23)
        AttBox.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label4.Location = New Point(7, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 21)
        Label4.TabIndex = 46
        Label4.Text = "ATTENDANCE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label5.Location = New Point(7, 264)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 21)
        Label5.TabIndex = 49
        Label5.Text = "TOTAL"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Location = New Point(3, 205)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(390, 1)
        Panel8.TabIndex = 40
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Location = New Point(3, 178)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(390, 1)
        Panel7.TabIndex = 40
        ' 
        ' PerfBox
        ' 
        PerfBox.Enabled = False
        PerfBox.FlatStyle = FlatStyle.Flat
        PerfBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        PerfBox.FormattingEnabled = True
        PerfBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        PerfBox.Location = New Point(332, 208)
        PerfBox.Name = "PerfBox"
        PerfBox.Size = New Size(49, 23)
        PerfBox.TabIndex = 40
        ' 
        ' QuizBox
        ' 
        QuizBox.Enabled = False
        QuizBox.FlatStyle = FlatStyle.Flat
        QuizBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        QuizBox.FormattingEnabled = True
        QuizBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        QuizBox.Location = New Point(332, 180)
        QuizBox.Name = "QuizBox"
        QuizBox.Size = New Size(49, 23)
        QuizBox.TabIndex = 43
        ' 
        ' ActivityBox
        ' 
        ActivityBox.Enabled = False
        ActivityBox.FlatStyle = FlatStyle.Flat
        ActivityBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ActivityBox.FormattingEnabled = True
        ActivityBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        ActivityBox.Location = New Point(332, 154)
        ActivityBox.Name = "ActivityBox"
        ActivityBox.Size = New Size(49, 23)
        ActivityBox.TabIndex = 40
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.FlatStyle = FlatStyle.Flat
        Label19.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label19.Location = New Point(7, 208)
        Label19.Name = "Label19"
        Label19.Size = New Size(127, 21)
        Label19.TabIndex = 42
        Label19.Text = "PARTICIPATION"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.FlatStyle = FlatStyle.Flat
        Label18.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label18.Location = New Point(7, 181)
        Label18.Name = "Label18"
        Label18.Size = New Size(77, 21)
        Label18.TabIndex = 41
        Label18.Text = "QUIZZES"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.FlatStyle = FlatStyle.Flat
        Label17.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label17.Location = New Point(7, 154)
        Label17.Name = "Label17"
        Label17.Size = New Size(80, 21)
        Label17.TabIndex = 40
        Label17.Text = "ACTIVITY"
        ' 
        ' TotalPercentageBox
        ' 
        TotalPercentageBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TotalPercentageBox.Location = New Point(332, 87)
        TotalPercentageBox.Name = "TotalPercentageBox"
        TotalPercentageBox.ReadOnly = True
        TotalPercentageBox.Size = New Size(49, 23)
        TotalPercentageBox.TabIndex = 39
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label14.Location = New Point(7, 106)
        Label14.Name = "Label14"
        Label14.Size = New Size(171, 11)
        Label14.TabIndex = 37
        Label14.Text = "GRADE PERCENTAGE MUST BE EQUAL TO 100%"
        ' 
        ' FinalExamBox
        ' 
        FinalExamBox.Enabled = False
        FinalExamBox.FlatStyle = FlatStyle.Flat
        FinalExamBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FinalExamBox.FormattingEnabled = True
        FinalExamBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        FinalExamBox.Location = New Point(332, 49)
        FinalExamBox.Name = "FinalExamBox"
        FinalExamBox.Size = New Size(49, 23)
        FinalExamBox.TabIndex = 38
        ' 
        ' ClassOSBox
        ' 
        ClassOSBox.Enabled = False
        ClassOSBox.FlatStyle = FlatStyle.Flat
        ClassOSBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ClassOSBox.FormattingEnabled = True
        ClassOSBox.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        ClassOSBox.Location = New Point(332, 11)
        ClassOSBox.Name = "ClassOSBox"
        ClassOSBox.Size = New Size(49, 23)
        ClassOSBox.TabIndex = 37
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Location = New Point(3, 117)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(390, 1)
        Panel4.TabIndex = 35
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Location = New Point(3, 78)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(390, 1)
        Panel5.TabIndex = 35
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Location = New Point(3, 39)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(390, 1)
        Panel6.TabIndex = 34
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(6, 127)
        Label10.Name = "Label10"
        Label10.Size = New Size(237, 20)
        Label10.TabIndex = 37
        Label10.Text = "BREAKDOWN CLASS STANDING"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label11.Location = New Point(6, 88)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 21)
        Label11.TabIndex = 36
        Label11.Text = "% TOTAL"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label12.Location = New Point(6, 50)
        Label12.Name = "Label12"
        Label12.Size = New Size(104, 21)
        Label12.TabIndex = 35
        Label12.Text = "FINAL EXAM"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label13.Location = New Point(6, 13)
        Label13.Name = "Label13"
        Label13.Size = New Size(143, 21)
        Label13.TabIndex = 34
        Label13.Text = "CLASS STANDING"
        ' 
        ' HandledSectionView
        ' 
        HandledSectionView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        HandledSectionView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        HandledSectionView.BackgroundColor = Color.White
        HandledSectionView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HandledSectionView.GridColor = Color.Black
        HandledSectionView.Location = New Point(10, 341)
        HandledSectionView.Name = "HandledSectionView"
        HandledSectionView.ReadOnly = True
        HandledSectionView.RowHeadersVisible = False
        HandledSectionView.RowHeadersWidth = 51
        HandledSectionView.RowTemplate.Height = 25
        HandledSectionView.Size = New Size(438, 304)
        HandledSectionView.TabIndex = 37
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label15.Location = New Point(8, 313)
        Label15.Name = "Label15"
        Label15.Size = New Size(167, 21)
        Label15.TabIndex = 38
        Label15.Text = "HANDLED SECTIONS"
        ' 
        ' AddSec
        ' 
        AddSec.Dock = DockStyle.Fill
        AddSec.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AddSec.ForeColor = Color.White
        AddSec.Location = New Point(0, 0)
        AddSec.Name = "AddSec"
        AddSec.Size = New Size(78, 34)
        AddSec.TabIndex = 42
        AddSec.Text = "ADD"
        AddSec.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label21.Location = New Point(461, 423)
        Label21.Name = "Label21"
        Label21.Size = New Size(226, 21)
        Label21.TabIndex = 41
        Label21.Text = "ADD SUBJECT AND SECTION"
        ' 
        ' RoundCornerPanel2
        ' 
        RoundCornerPanel2.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel2.Controls.Add(AddYear)
        RoundCornerPanel2.Controls.Add(Label3)
        RoundCornerPanel2.Controls.Add(AddSubject)
        RoundCornerPanel2.Controls.Add(AddSection)
        RoundCornerPanel2.Controls.Add(AddProgram)
        RoundCornerPanel2.Controls.Add(Panel9)
        RoundCornerPanel2.Controls.Add(Panel10)
        RoundCornerPanel2.Controls.Add(Panel11)
        RoundCornerPanel2.Controls.Add(Label23)
        RoundCornerPanel2.Controls.Add(Label24)
        RoundCornerPanel2.Controls.Add(Label25)
        RoundCornerPanel2.Location = New Point(458, 447)
        RoundCornerPanel2.Name = "RoundCornerPanel2"
        RoundCornerPanel2.Size = New Size(390, 154)
        RoundCornerPanel2.TabIndex = 40
        ' 
        ' AddYear
        ' 
        AddYear.FlatStyle = FlatStyle.Flat
        AddYear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddYear.FormattingEnabled = True
        AddYear.Items.AddRange(New Object() {"1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B"})
        AddYear.Location = New Point(328, 46)
        AddYear.Name = "AddYear"
        AddYear.Size = New Size(49, 23)
        AddYear.TabIndex = 48
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label3.Location = New Point(6, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 21)
        Label3.TabIndex = 47
        Label3.Text = "YEAR"
        ' 
        ' AddSubject
        ' 
        AddSubject.FlatStyle = FlatStyle.Flat
        AddSubject.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddSubject.FormattingEnabled = True
        AddSubject.Location = New Point(155, 124)
        AddSubject.Name = "AddSubject"
        AddSubject.Size = New Size(222, 23)
        AddSubject.TabIndex = 46
        ' 
        ' AddSection
        ' 
        AddSection.FlatStyle = FlatStyle.Flat
        AddSection.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddSection.FormattingEnabled = True
        AddSection.Items.AddRange(New Object() {"A", "B", "C"})
        AddSection.Location = New Point(328, 85)
        AddSection.Name = "AddSection"
        AddSection.Size = New Size(49, 23)
        AddSection.TabIndex = 45
        ' 
        ' AddProgram
        ' 
        AddProgram.FlatStyle = FlatStyle.Flat
        AddProgram.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AddProgram.FormattingEnabled = True
        AddProgram.Items.AddRange(New Object() {"BSCS", "BSIT", "BSIS", "BSEMC"})
        AddProgram.Location = New Point(311, 11)
        AddProgram.Name = "AddProgram"
        AddProgram.Size = New Size(65, 23)
        AddProgram.TabIndex = 44
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Location = New Point(3, 117)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(386, 1)
        Panel9.TabIndex = 35
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Location = New Point(3, 78)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(386, 1)
        Panel10.TabIndex = 35
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Location = New Point(3, 39)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(386, 1)
        Panel11.TabIndex = 34
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label23.Location = New Point(6, 127)
        Label23.Name = "Label23"
        Label23.Size = New Size(76, 21)
        Label23.TabIndex = 36
        Label23.Text = "SUBJECT"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label24.Location = New Point(6, 87)
        Label24.Name = "Label24"
        Label24.Size = New Size(77, 21)
        Label24.TabIndex = 35
        Label24.Text = "SECTION"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label25.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label25.Location = New Point(6, 13)
        Label25.Name = "Label25"
        Label25.Size = New Size(89, 21)
        Label25.TabIndex = 34
        Label25.Text = "PROGRAM"
        ' 
        ' RoundCornerPanel3
        ' 
        RoundCornerPanel3.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        RoundCornerPanel3.Controls.Add(AddSec)
        RoundCornerPanel3.Location = New Point(769, 607)
        RoundCornerPanel3.Name = "RoundCornerPanel3"
        RoundCornerPanel3.Size = New Size(78, 34)
        RoundCornerPanel3.TabIndex = 43
        ' 
        ' ProfileUpdBtn
        ' 
        ProfileUpdBtn.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        ProfileUpdBtn.Controls.Add(SaveChanges)
        ProfileUpdBtn.Location = New Point(331, 259)
        ProfileUpdBtn.Name = "ProfileUpdBtn"
        ProfileUpdBtn.Size = New Size(113, 34)
        ProfileUpdBtn.TabIndex = 44
        ProfileUpdBtn.Visible = False
        ' 
        ' SaveChanges
        ' 
        SaveChanges.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        SaveChanges.ForeColor = Color.White
        SaveChanges.Location = New Point(3, 0)
        SaveChanges.Name = "SaveChanges"
        SaveChanges.Size = New Size(107, 34)
        SaveChanges.TabIndex = 42
        SaveChanges.Text = "SAVE CHANGES"
        SaveChanges.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SaveChangesGrade
        ' 
        SaveChangesGrade.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        SaveChangesGrade.Controls.Add(PercentageSave)
        SaveChangesGrade.Location = New Point(742, 363)
        SaveChangesGrade.Name = "SaveChangesGrade"
        SaveChangesGrade.Size = New Size(107, 34)
        SaveChangesGrade.TabIndex = 45
        SaveChangesGrade.Visible = False
        ' 
        ' PercentageSave
        ' 
        PercentageSave.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        PercentageSave.ForeColor = Color.White
        PercentageSave.Location = New Point(2, 1)
        PercentageSave.Name = "PercentageSave"
        PercentageSave.Size = New Size(107, 34)
        PercentageSave.TabIndex = 46
        PercentageSave.Text = "SAVE CHANGES"
        PercentageSave.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.Location = New Point(456, 321)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(390, 1)
        Panel13.TabIndex = 47
        ' 
        ' TotalStanding
        ' 
        TotalStanding.Enabled = False
        TotalStanding.FlatStyle = FlatStyle.Flat
        TotalStanding.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TotalStanding.FormattingEnabled = True
        TotalStanding.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        TotalStanding.Location = New Point(786, 324)
        TotalStanding.Name = "TotalStanding"
        TotalStanding.Size = New Size(49, 23)
        TotalStanding.TabIndex = 48
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 2000
        ' 
        ' ProfManagement
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(Panel13)
        Controls.Add(TotalStanding)
        Controls.Add(SaveChangesGrade)
        Controls.Add(ProfileUpdBtn)
        Controls.Add(RoundCornerPanel3)
        Controls.Add(Label21)
        Controls.Add(RoundCornerPanel2)
        Controls.Add(Label15)
        Controls.Add(HandledSectionView)
        Controls.Add(GradeEdit)
        Controls.Add(Label9)
        Controls.Add(ProfEditBtn)
        Controls.Add(Label2)
        Controls.Add(RoundCornerPanel1)
        Controls.Add(Label1)
        Controls.Add(GradePercentagePanel)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(861, 648)
        MinimumSize = New Size(861, 648)
        Name = "ProfManagement"
        Text = "ProfManagement"
        RoundCornerPanel1.ResumeLayout(False)
        RoundCornerPanel1.PerformLayout()
        GradePercentagePanel.ResumeLayout(False)
        GradePercentagePanel.PerformLayout()
        CType(HandledSectionView, ComponentModel.ISupportInitialize).EndInit()
        RoundCornerPanel2.ResumeLayout(False)
        RoundCornerPanel2.PerformLayout()
        RoundCornerPanel3.ResumeLayout(False)
        ProfileUpdBtn.ResumeLayout(False)
        SaveChangesGrade.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RoundCornerPanel1 As RoundCornerPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents ProfEditBtn As Label
    Friend WithEvents PassProfile As Label
    Friend WithEvents EmailProfile As Label
    Friend WithEvents LnameProfile As Label
    Friend WithEvents FnameProfile As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DisplayPass As RoundCornerTextbox
    Friend WithEvents DisplayEmail As RoundCornerTextbox
    Friend WithEvents DisplayLname As RoundCornerTextbox
    Friend WithEvents DisplayFname As RoundCornerTextbox
    Friend WithEvents GradeEdit As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GradePercentagePanel As RoundCornerPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents FinalExamBox As ComboBox
    Friend WithEvents ClassOSBox As ComboBox
    Friend WithEvents TotalPercentageBox As TextBox
    Friend WithEvents HandledSectionView As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents PerfBox As ComboBox
    Friend WithEvents QuizBox As ComboBox
    Friend WithEvents ActivityBox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents AddSec As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents RoundCornerPanel2 As RoundCornerPanel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents AddProgram As ComboBox
    Friend WithEvents AddSection As ComboBox
    Friend WithEvents DisplayProfID As RoundCornerTextbox
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents RoundCornerPanel3 As RoundCornerPanel
    Friend WithEvents ProfileUpdBtn As RoundCornerPanel
    Friend WithEvents SaveChanges As Label
    Friend WithEvents AddSubject As ComboBox
    Friend WithEvents AddYear As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveChangesGrade As RoundCornerPanel
    Friend WithEvents PercentageSave As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents AttBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TotalStanding As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
