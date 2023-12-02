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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Signup))
        min = New Panel()
        btnClose = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        RoundCornerTextbox1 = New RoundCornerTextbox()
        Label1 = New Label()
        RoundCornerTextbox2 = New RoundCornerTextbox()
        Label2 = New Label()
        RoundCornerTextbox3 = New RoundCornerTextbox()
        Label3 = New Label()
        RoundCornerTextbox4 = New RoundCornerTextbox()
        Label4 = New Label()
        RoundCornerButton2 = New RoundCornerButton()
        signPanel = New RoundCornerPanel()
        signInTab = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        signPanel.SuspendLayout()
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
        ' RoundCornerTextbox1
        ' 
        RoundCornerTextbox1.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerTextbox1.BorderStyle = BorderStyle.None
        RoundCornerTextbox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        RoundCornerTextbox1.ForeColor = SystemColors.WindowFrame
        RoundCornerTextbox1.Location = New Point(38, 153)
        RoundCornerTextbox1.Margin = New Padding(3, 5, 3, 3)
        RoundCornerTextbox1.Multiline = True
        RoundCornerTextbox1.Name = "RoundCornerTextbox1"
        RoundCornerTextbox1.Size = New Size(357, 42)
        RoundCornerTextbox1.TabIndex = 6
        RoundCornerTextbox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label1.Location = New Point(38, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 26)
        Label1.TabIndex = 5
        Label1.Text = "FIRST NAME"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerTextbox2
        ' 
        RoundCornerTextbox2.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerTextbox2.BorderStyle = BorderStyle.None
        RoundCornerTextbox2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        RoundCornerTextbox2.ForeColor = SystemColors.WindowFrame
        RoundCornerTextbox2.Location = New Point(38, 227)
        RoundCornerTextbox2.Multiline = True
        RoundCornerTextbox2.Name = "RoundCornerTextbox2"
        RoundCornerTextbox2.Size = New Size(357, 42)
        RoundCornerTextbox2.TabIndex = 8
        RoundCornerTextbox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label2.Location = New Point(38, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 26)
        Label2.TabIndex = 7
        Label2.Text = "LAST NAME"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerTextbox3
        ' 
        RoundCornerTextbox3.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerTextbox3.BorderStyle = BorderStyle.None
        RoundCornerTextbox3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        RoundCornerTextbox3.ForeColor = SystemColors.WindowFrame
        RoundCornerTextbox3.Location = New Point(38, 301)
        RoundCornerTextbox3.Multiline = True
        RoundCornerTextbox3.Name = "RoundCornerTextbox3"
        RoundCornerTextbox3.Size = New Size(357, 42)
        RoundCornerTextbox3.TabIndex = 10
        RoundCornerTextbox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label3.Location = New Point(38, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 26)
        Label3.TabIndex = 9
        Label3.Text = "EMAIL"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerTextbox4
        ' 
        RoundCornerTextbox4.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        RoundCornerTextbox4.BorderStyle = BorderStyle.None
        RoundCornerTextbox4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        RoundCornerTextbox4.ForeColor = SystemColors.WindowFrame
        RoundCornerTextbox4.Location = New Point(38, 375)
        RoundCornerTextbox4.Multiline = True
        RoundCornerTextbox4.Name = "RoundCornerTextbox4"
        RoundCornerTextbox4.PasswordChar = "*"c
        RoundCornerTextbox4.Size = New Size(357, 42)
        RoundCornerTextbox4.TabIndex = 12
        RoundCornerTextbox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        Label4.Location = New Point(38, 346)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 26)
        Label4.TabIndex = 11
        Label4.Text = "PASSWORD"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RoundCornerButton2
        ' 
        RoundCornerButton2.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        RoundCornerButton2.FlatAppearance.BorderSize = 0
        RoundCornerButton2.FlatStyle = FlatStyle.Flat
        RoundCornerButton2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        RoundCornerButton2.ForeColor = Color.White
        RoundCornerButton2.Location = New Point(291, 423)
        RoundCornerButton2.Name = "RoundCornerButton2"
        RoundCornerButton2.Size = New Size(104, 35)
        RoundCornerButton2.TabIndex = 16
        RoundCornerButton2.Text = "SIGN UP"
        RoundCornerButton2.UseVisualStyleBackColor = False
        ' 
        ' signPanel
        ' 
        signPanel.BackColor = Color.Transparent
        signPanel.Controls.Add(signInTab)
        signPanel.Location = New Point(38, 482)
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
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        ClientSize = New Size(433, 554)
        Controls.Add(signPanel)
        Controls.Add(RoundCornerButton2)
        Controls.Add(RoundCornerTextbox4)
        Controls.Add(Label4)
        Controls.Add(RoundCornerTextbox3)
        Controls.Add(Label3)
        Controls.Add(RoundCornerTextbox2)
        Controls.Add(Label2)
        Controls.Add(RoundCornerTextbox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        signPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents min As Panel
    Friend WithEvents btnClose As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RoundCornerTextbox1 As RoundCornerTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundCornerTextbox2 As RoundCornerTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundCornerTextbox3 As RoundCornerTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoundCornerTextbox4 As RoundCornerTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents RoundCornerButton2 As RoundCornerButton
    Friend WithEvents signPanel As RoundCornerPanel
    Friend WithEvents signInTab As Label
End Class
