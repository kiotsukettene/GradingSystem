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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        emailBox = New RoundCornerTextbox()
        Label4 = New Label()
        RoundCornerTextbox2 = New RoundCornerTextbox()
        signUpTab = New Label()
        RoundCornerButton2 = New RoundCornerButton()
        signPanel = New RoundCornerPanel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        signPanel.SuspendLayout()
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
        ' emailBox
        ' 
        emailBox.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        emailBox.BorderStyle = BorderStyle.None
        emailBox.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        emailBox.ForeColor = SystemColors.WindowFrame
        emailBox.Location = New Point(38, 298)
        emailBox.Margin = New Padding(5, 3, 3, 3)
        emailBox.Multiline = True
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(357, 42)
        emailBox.TabIndex = 4
        emailBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label4.Location = New Point(38, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 28)
        Label4.TabIndex = 5
        Label4.Text = "PASSWORD"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerTextbox2
        ' 
        RoundCornerTextbox2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerTextbox2.BorderStyle = BorderStyle.None
        RoundCornerTextbox2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        RoundCornerTextbox2.ForeColor = SystemColors.WindowFrame
        RoundCornerTextbox2.Location = New Point(38, 374)
        RoundCornerTextbox2.Multiline = True
        RoundCornerTextbox2.Name = "RoundCornerTextbox2"
        RoundCornerTextbox2.PasswordChar = "*"c
        RoundCornerTextbox2.Size = New Size(357, 42)
        RoundCornerTextbox2.TabIndex = 6
        RoundCornerTextbox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' signUpTab
        ' 
        signUpTab.Font = New Font("Segoe UI", 12.0F, FontStyle.Underline, GraphicsUnit.Point)
        signUpTab.ForeColor = Color.White
        signUpTab.Location = New Point(10, 3)
        signUpTab.Name = "signUpTab"
        signUpTab.Size = New Size(79, 26)
        signUpTab.TabIndex = 7
        signUpTab.Text = "SIGN UP"
        signUpTab.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerButton2
        ' 
        RoundCornerButton2.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        RoundCornerButton2.FlatAppearance.BorderSize = 0
        RoundCornerButton2.FlatStyle = FlatStyle.Flat
        RoundCornerButton2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        RoundCornerButton2.ForeColor = Color.White
        RoundCornerButton2.Location = New Point(291, 422)
        RoundCornerButton2.Name = "RoundCornerButton2"
        RoundCornerButton2.Size = New Size(104, 35)
        RoundCornerButton2.TabIndex = 9
        RoundCornerButton2.Text = "SIGN IN"
        RoundCornerButton2.UseVisualStyleBackColor = False
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
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        ClientSize = New Size(433, 554)
        Controls.Add(signPanel)
        Controls.Add(RoundCornerButton2)
        Controls.Add(RoundCornerTextbox2)
        Controls.Add(Label4)
        Controls.Add(emailBox)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents emailBox As RoundCornerTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundCornerTextbox2 As RoundCornerTextbox
    Friend WithEvents signUpTab As Label
    Friend WithEvents RoundCornerButton2 As RoundCornerButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents signPanel As RoundCornerPanel
End Class
