<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        signUpTab = New Label()
        BtnSignIn = New RoundCornerButton()
        signPanel = New RoundCornerPanel()
        EmailPanel = New RoundCornerPanel()
        emailBox = New TextBox()
        PassPanel = New RoundCornerPanel()
        PasswordBox = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        signPanel.SuspendLayout()
        EmailPanel.SuspendLayout()
        PassPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(6), CByte(81), CByte(189))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(433, 40)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Cursor = Cursors.Hand
        Panel3.Location = New Point(368, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(33, 34)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Cursor = Cursors.Hand
        Panel2.Location = New Point(398, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(33, 34)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(263, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(158, 106)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(12, 155)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(409, 90)
        Panel4.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.ForeColor = Color.White
        Label2.Location = New Point(136, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 23)
        Label2.TabIndex = 1
        Label2.Text = "SIGN IN TO CONTINUE"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 58)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label3.Location = New Point(38, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 26)
        Label3.TabIndex = 3
        Label3.Text = "EMAIL"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label4.Location = New Point(38, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 28)
        Label4.TabIndex = 5
        Label4.Text = "PASSWORD"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' signUpTab
        ' 
        signUpTab.Font = New Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point)
        signUpTab.ForeColor = Color.White
        signUpTab.Location = New Point(10, 3)
        signUpTab.Name = "signUpTab"
        signUpTab.Size = New Size(79, 26)
        signUpTab.TabIndex = 7
        signUpTab.Text = "SIGN UP"
        signUpTab.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnSignIn
        ' 
        BtnSignIn.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        BtnSignIn.FlatAppearance.BorderSize = 0
        BtnSignIn.FlatStyle = FlatStyle.Flat
        BtnSignIn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSignIn.ForeColor = Color.White
        BtnSignIn.Location = New Point(291, 483)
        BtnSignIn.Name = "BtnSignIn"
        BtnSignIn.Size = New Size(104, 35)
        BtnSignIn.TabIndex = 9
        BtnSignIn.Text = "SIGN IN"
        BtnSignIn.UseVisualStyleBackColor = False
        ' 
        ' signPanel
        ' 
        signPanel.BackColor = Color.Transparent
        signPanel.Controls.Add(signUpTab)
        signPanel.Location = New Point(44, 483)
        signPanel.Name = "signPanel"
        signPanel.Size = New Size(89, 31)
        signPanel.TabIndex = 11
        ' 
        ' EmailPanel
        ' 
        EmailPanel.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        EmailPanel.BorderStyle = BorderStyle.FixedSingle
        EmailPanel.Controls.Add(emailBox)
        EmailPanel.Location = New Point(38, 298)
        EmailPanel.Name = "EmailPanel"
        EmailPanel.Size = New Size(357, 42)
        EmailPanel.TabIndex = 12
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        emailBox.BorderStyle = BorderStyle.None
        emailBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        emailBox.Location = New Point(14, 12)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(329, 22)
        emailBox.TabIndex = 0
        emailBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' PassPanel
        ' 
        PassPanel.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        PassPanel.Controls.Add(PasswordBox)
        PassPanel.Location = New Point(38, 374)
        PassPanel.Name = "PassPanel"
        PassPanel.Size = New Size(357, 42)
        PassPanel.TabIndex = 13
        ' 
        ' PasswordBox
        ' 
        PasswordBox.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        PasswordBox.BorderStyle = BorderStyle.None
        PasswordBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordBox.Location = New Point(14, 12)
        PasswordBox.Name = "PasswordBox"
        PasswordBox.PasswordChar = "*"c
        PasswordBox.Size = New Size(329, 22)
        PasswordBox.TabIndex = 0
        PasswordBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        ClientSize = New Size(433, 554)
        Controls.Add(PassPanel)
        Controls.Add(EmailPanel)
        Controls.Add(signPanel)
        Controls.Add(BtnSignIn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel4)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        signPanel.ResumeLayout(False)
        EmailPanel.ResumeLayout(False)
        EmailPanel.PerformLayout()
        PassPanel.ResumeLayout(False)
        PassPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents signUpTab As Label
    Friend WithEvents BtnSignIn As RoundCornerButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents signPanel As RoundCornerPanel
    Friend WithEvents EmailPanel As RoundCornerPanel
    Friend WithEvents emailBox As TextBox
    Friend WithEvents PassPanel As RoundCornerPanel
    Friend WithEvents PasswordBox As TextBox
End Class
