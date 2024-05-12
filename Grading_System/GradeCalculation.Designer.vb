<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeCalculation
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
        Label1 = New Label()
        SelectionBox = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        PercentBox = New ComboBox()
        Label4 = New Label()
        ScoreBox = New TextBox()
        RoundCornerPanel2 = New RoundCornerPanel()
        Label7 = New Label()
        StudentBox = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        SurnameBox = New TextBox()
        FirstnameBox = New TextBox()
        RoundCornerPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(368, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 0
        Label1.Text = "SELECT"
        ' 
        ' SelectionBox
        ' 
        SelectionBox.FormattingEnabled = True
        SelectionBox.Items.AddRange(New Object() {"ACTIVITIES", "QUIZZES", "PARTICIPATION", "ATTENDANCE ", "EXAM"})
        SelectionBox.Location = New Point(557, 89)
        SelectionBox.Margin = New Padding(3, 2, 3, 2)
        SelectionBox.Name = "SelectionBox"
        SelectionBox.Size = New Size(133, 23)
        SelectionBox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(287, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 21)
        Label2.TabIndex = 2
        Label2.Text = "ADD RECORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(368, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 21)
        Label3.TabIndex = 3
        Label3.Text = "PERCENTAGE"
        ' 
        ' PercentBox
        ' 
        PercentBox.FormattingEnabled = True
        PercentBox.Location = New Point(557, 126)
        PercentBox.Margin = New Padding(3, 2, 3, 2)
        PercentBox.Name = "PercentBox"
        PercentBox.Size = New Size(133, 23)
        PercentBox.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(368, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 21)
        Label4.TabIndex = 5
        Label4.Text = "SCORE"
        ' 
        ' ScoreBox
        ' 
        ScoreBox.BorderStyle = BorderStyle.FixedSingle
        ScoreBox.Location = New Point(557, 163)
        ScoreBox.Margin = New Padding(3, 2, 3, 2)
        ScoreBox.Name = "ScoreBox"
        ScoreBox.Size = New Size(132, 23)
        ScoreBox.TabIndex = 6
        ' 
        ' RoundCornerPanel2
        ' 
        RoundCornerPanel2.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel2.Controls.Add(Label7)
        RoundCornerPanel2.Location = New Point(557, 199)
        RoundCornerPanel2.Name = "RoundCornerPanel2"
        RoundCornerPanel2.Size = New Size(75, 28)
        RoundCornerPanel2.TabIndex = 43
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 28)
        Label7.TabIndex = 42
        Label7.Text = "ADD"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StudentBox
        ' 
        StudentBox.FormattingEnabled = True
        StudentBox.Items.AddRange(New Object() {"ACTIVITIES", "QUIZZES", "PARTICIPATION", "ATTENDANCE ", "EXAM"})
        StudentBox.Location = New Point(216, 87)
        StudentBox.Margin = New Padding(3, 2, 3, 2)
        StudentBox.Name = "StudentBox"
        StudentBox.Size = New Size(133, 23)
        StudentBox.TabIndex = 45
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(27, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 21)
        Label5.TabIndex = 44
        Label5.Text = "SELECT STUDENT"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(27, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 21)
        Label6.TabIndex = 46
        Label6.Text = "SURNAME"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(27, 160)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 21)
        Label8.TabIndex = 48
        Label8.Text = "FIRSTNAME"
        ' 
        ' SurnameBox
        ' 
        SurnameBox.BorderStyle = BorderStyle.FixedSingle
        SurnameBox.Location = New Point(216, 124)
        SurnameBox.Margin = New Padding(3, 2, 3, 2)
        SurnameBox.Name = "SurnameBox"
        SurnameBox.Size = New Size(132, 23)
        SurnameBox.TabIndex = 49
        ' 
        ' FirstnameBox
        ' 
        FirstnameBox.BorderStyle = BorderStyle.FixedSingle
        FirstnameBox.Location = New Point(216, 163)
        FirstnameBox.Margin = New Padding(3, 2, 3, 2)
        FirstnameBox.Name = "FirstnameBox"
        FirstnameBox.Size = New Size(132, 23)
        FirstnameBox.TabIndex = 50
        ' 
        ' GradeCalculation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(712, 267)
        Controls.Add(FirstnameBox)
        Controls.Add(SurnameBox)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(StudentBox)
        Controls.Add(Label5)
        Controls.Add(RoundCornerPanel2)
        Controls.Add(ScoreBox)
        Controls.Add(Label4)
        Controls.Add(PercentBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(SelectionBox)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(3, 2, 3, 2)
        Name = "GradeCalculation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GradeCalculation"
        RoundCornerPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SelectionBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PercentBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ScoreBox As TextBox
    Friend WithEvents RoundCornerPanel2 As RoundCornerPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents StudentBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SurnameBox As TextBox
    Friend WithEvents FirstnameBox As TextBox
End Class
