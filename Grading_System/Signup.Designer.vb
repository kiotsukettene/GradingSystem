<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        min = New Panel()
        btnClose = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        FnameLabel = New Label()
        LnameLabel = New Label()
        EmailLabel = New Label()
        PassLabel = New Label()
        BtnSignUp = New RoundCornerButton()
        signPanel = New RoundCornerPanel()
        signInTab = New Label()
        RoundCornerPanel1 = New RoundCornerPanel()
        Fname = New TextBox()
        RoundCornerPanel2 = New RoundCornerPanel()
        Lname = New TextBox()
        RoundCornerPanel3 = New RoundCornerPanel()
        EmailReg = New TextBox()
        RoundCornerPanel4 = New RoundCornerPanel()
        PassReg = New TextBox()
        Label1 = New Label()
        RoundCornerPanel5 = New RoundCornerPanel()
        ProfIDReg = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        signPanel.SuspendLayout()
        RoundCornerPanel1.SuspendLayout()
        RoundCornerPanel2.SuspendLayout()
        RoundCornerPanel3.SuspendLayout()
        RoundCornerPanel4.SuspendLayout()
        RoundCornerPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' min
        ' 
        min.BackgroundImage = CType(resources.GetObject("min.BackgroundImage"), Image)
        min.BackgroundImageLayout = ImageLayout.Center
        min.Cursor = Cursors.Hand
        min.Location = New Point(368, 3)
        min.Name = "min"
        min.Size = New Size(33, 34)
        min.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), Image)
        btnClose.BackgroundImageLayout = ImageLayout.Center
        btnClose.Cursor = Cursors.Hand
        btnClose.Location = New Point(398, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(33, 34)
        btnClose.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(6), CByte(81), CByte(189))
        Panel1.Controls.Add(min)
        Panel1.Controls.Add(btnClose)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(433, 40)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(304, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(129, 91)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' FnameLabel
        ' 
        FnameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FnameLabel.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        FnameLabel.Location = New Point(38, 198)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New Size(129, 26)
        FnameLabel.TabIndex = 5
        FnameLabel.Text = "FIRST NAME"
        FnameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LnameLabel
        ' 
        LnameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LnameLabel.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        LnameLabel.Location = New Point(38, 272)
        LnameLabel.Name = "LnameLabel"
        LnameLabel.Size = New Size(129, 26)
        LnameLabel.TabIndex = 7
        LnameLabel.Text = "LAST NAME"
        LnameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EmailLabel
        ' 
        EmailLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EmailLabel.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        EmailLabel.Location = New Point(38, 346)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(129, 26)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "EMAIL"
        EmailLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PassLabel
        ' 
        PassLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PassLabel.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        PassLabel.Location = New Point(38, 420)
        PassLabel.Name = "PassLabel"
        PassLabel.Size = New Size(129, 26)
        PassLabel.TabIndex = 11
        PassLabel.Text = "PASSWORD"
        PassLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnSignUp
        ' 
        BtnSignUp.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        BtnSignUp.FlatAppearance.BorderSize = 0
        BtnSignUp.FlatStyle = FlatStyle.Flat
        BtnSignUp.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSignUp.ForeColor = Color.White
        BtnSignUp.Location = New Point(297, 507)
        BtnSignUp.Name = "BtnSignUp"
        BtnSignUp.Size = New Size(104, 35)
        BtnSignUp.TabIndex = 16
        BtnSignUp.Text = "SIGN UP"
        BtnSignUp.UseVisualStyleBackColor = False
        ' 
        ' signPanel
        ' 
        signPanel.BackColor = Color.Transparent
        signPanel.Controls.Add(signInTab)
        signPanel.Location = New Point(44, 507)
        signPanel.Name = "signPanel"
        signPanel.Size = New Size(89, 31)
        signPanel.TabIndex = 17
        ' 
        ' signInTab
        ' 
        signInTab.Font = New Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point)
        signInTab.ForeColor = Color.White
        signInTab.Location = New Point(10, 3)
        signInTab.Name = "signInTab"
        signInTab.Size = New Size(79, 26)
        signInTab.TabIndex = 7
        signInTab.Text = "SIGN IN"
        signInTab.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerPanel1
        ' 
        RoundCornerPanel1.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerPanel1.Controls.Add(Fname)
        RoundCornerPanel1.Location = New Point(38, 227)
        RoundCornerPanel1.Name = "RoundCornerPanel1"
        RoundCornerPanel1.Size = New Size(357, 42)
        RoundCornerPanel1.TabIndex = 18
        ' 
        ' Fname
        ' 
        Fname.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Fname.BorderStyle = BorderStyle.None
        Fname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Fname.Location = New Point(14, 12)
        Fname.Name = "Fname"
        Fname.Size = New Size(329, 22)
        Fname.TabIndex = 0
        Fname.TextAlign = HorizontalAlignment.Center
        ' 
        ' RoundCornerPanel2
        ' 
        RoundCornerPanel2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerPanel2.Controls.Add(Lname)
        RoundCornerPanel2.Location = New Point(38, 301)
        RoundCornerPanel2.Name = "RoundCornerPanel2"
        RoundCornerPanel2.Size = New Size(357, 42)
        RoundCornerPanel2.TabIndex = 19
        ' 
        ' Lname
        ' 
        Lname.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Lname.BorderStyle = BorderStyle.None
        Lname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lname.Location = New Point(14, 12)
        Lname.Name = "Lname"
        Lname.Size = New Size(329, 22)
        Lname.TabIndex = 0
        Lname.TextAlign = HorizontalAlignment.Center
        ' 
        ' RoundCornerPanel3
        ' 
        RoundCornerPanel3.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerPanel3.Controls.Add(EmailReg)
        RoundCornerPanel3.Location = New Point(38, 375)
        RoundCornerPanel3.Name = "RoundCornerPanel3"
        RoundCornerPanel3.Size = New Size(357, 42)
        RoundCornerPanel3.TabIndex = 20
        ' 
        ' EmailReg
        ' 
        EmailReg.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        EmailReg.BorderStyle = BorderStyle.None
        EmailReg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EmailReg.Location = New Point(14, 12)
        EmailReg.Name = "EmailReg"
        EmailReg.Size = New Size(329, 22)
        EmailReg.TabIndex = 0
        EmailReg.TextAlign = HorizontalAlignment.Center
        ' 
        ' RoundCornerPanel4
        ' 
        RoundCornerPanel4.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerPanel4.Controls.Add(PassReg)
        RoundCornerPanel4.Location = New Point(38, 449)
        RoundCornerPanel4.Name = "RoundCornerPanel4"
        RoundCornerPanel4.Size = New Size(357, 42)
        RoundCornerPanel4.TabIndex = 19
        ' 
        ' PassReg
        ' 
        PassReg.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        PassReg.BorderStyle = BorderStyle.None
        PassReg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PassReg.Location = New Point(14, 12)
        PassReg.Name = "PassReg"
        PassReg.PasswordChar = "*"c
        PassReg.Size = New Size(329, 22)
        PassReg.TabIndex = 0
        PassReg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label1.Location = New Point(38, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 26)
        Label1.TabIndex = 21
        Label1.Text = "PROFESSOR ID"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerPanel5
        ' 
        RoundCornerPanel5.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerPanel5.Controls.Add(ProfIDReg)
        RoundCornerPanel5.Location = New Point(38, 153)
        RoundCornerPanel5.Name = "RoundCornerPanel5"
        RoundCornerPanel5.Size = New Size(357, 42)
        RoundCornerPanel5.TabIndex = 22
        ' 
        ' ProfIDReg
        ' 
        ProfIDReg.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        ProfIDReg.BorderStyle = BorderStyle.None
        ProfIDReg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ProfIDReg.Location = New Point(14, 12)
        ProfIDReg.Name = "ProfIDReg"
        ProfIDReg.Size = New Size(329, 22)
        ProfIDReg.TabIndex = 0
        ProfIDReg.TextAlign = HorizontalAlignment.Center
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        ClientSize = New Size(433, 554)
        Controls.Add(RoundCornerPanel5)
        Controls.Add(Label1)
        Controls.Add(RoundCornerPanel4)
        Controls.Add(RoundCornerPanel3)
        Controls.Add(RoundCornerPanel2)
        Controls.Add(RoundCornerPanel1)
        Controls.Add(signPanel)
        Controls.Add(BtnSignUp)
        Controls.Add(PassLabel)
        Controls.Add(EmailLabel)
        Controls.Add(LnameLabel)
        Controls.Add(FnameLabel)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        signPanel.ResumeLayout(False)
        RoundCornerPanel1.ResumeLayout(False)
        RoundCornerPanel1.PerformLayout()
        RoundCornerPanel2.ResumeLayout(False)
        RoundCornerPanel2.PerformLayout()
        RoundCornerPanel3.ResumeLayout(False)
        RoundCornerPanel3.PerformLayout()
        RoundCornerPanel4.ResumeLayout(False)
        RoundCornerPanel4.PerformLayout()
        RoundCornerPanel5.ResumeLayout(False)
        RoundCornerPanel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents min As Panel
    Friend WithEvents btnClose As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FnameLabel As Label
    Friend WithEvents LnameLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PassLabel As Label
    Friend WithEvents BtnSignUp As RoundCornerButton
    Friend WithEvents signPanel As RoundCornerPanel
    Friend WithEvents signInTab As Label
    Friend WithEvents RoundCornerPanel1 As RoundCornerPanel
    Friend WithEvents Fname As TextBox
    Friend WithEvents RoundCornerPanel2 As RoundCornerPanel
    Friend WithEvents Lname As TextBox
    Friend WithEvents RoundCornerPanel3 As RoundCornerPanel
    Friend WithEvents EmailReg As TextBox
    Friend WithEvents RoundCornerPanel4 As RoundCornerPanel
    Friend WithEvents PassReg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundCornerPanel5 As RoundCornerPanel
    Friend WithEvents ProfIDReg As TextBox
End Class
