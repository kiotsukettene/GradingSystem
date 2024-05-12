<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardMain
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
        Panel1 = New Panel()
        LogoutPanel = New RoundCornerPanel()
        LogoutBtn = New Label()
        GradePanel = New RoundCornerPanel()
        GradeBtn = New Label()
        GradeCalPanel = New RoundCornerPanel()
        GradeCalBtn = New Label()
        ProfPanel = New RoundCornerPanel()
        ProfBtn = New Label()
        DashPanel = New RoundCornerPanel()
        DashboardBtn = New Label()
        Panel2 = New Panel()
        Logo = New Panel()
        BtnMin = New Panel()
        BtnClose = New Panel()
        Panel4 = New Panel()
        TabPanel = New Panel()
        Panel1.SuspendLayout()
        LogoutPanel.SuspendLayout()
        GradePanel.SuspendLayout()
        GradeCalPanel.SuspendLayout()
        ProfPanel.SuspendLayout()
        DashPanel.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Panel1.Controls.Add(LogoutPanel)
        Panel1.Controls.Add(GradePanel)
        Panel1.Controls.Add(GradeCalPanel)
        Panel1.Controls.Add(ProfPanel)
        Panel1.Controls.Add(DashPanel)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 691)
        Panel1.TabIndex = 0
        ' 
        ' LogoutPanel
        ' 
        LogoutPanel.BackColor = Color.Transparent
        LogoutPanel.Controls.Add(LogoutBtn)
        LogoutPanel.Location = New Point(13, 461)
        LogoutPanel.Name = "LogoutPanel"
        LogoutPanel.Size = New Size(215, 46)
        LogoutPanel.TabIndex = 6
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LogoutBtn.ForeColor = Color.White
        LogoutBtn.Image = My.Resources.Resources.logout
        LogoutBtn.ImageAlign = ContentAlignment.MiddleLeft
        LogoutBtn.Location = New Point(14, 11)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(198, 29)
        LogoutBtn.TabIndex = 2
        LogoutBtn.Text = "          LOG OUT"
        LogoutBtn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GradePanel
        ' 
        GradePanel.BackColor = Color.Transparent
        GradePanel.Controls.Add(GradeBtn)
        GradePanel.Location = New Point(13, 409)
        GradePanel.Name = "GradePanel"
        GradePanel.Size = New Size(215, 46)
        GradePanel.TabIndex = 5
        ' 
        ' GradeBtn
        ' 
        GradeBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GradeBtn.ForeColor = Color.White
        GradeBtn.Image = My.Resources.Resources.google_docs
        GradeBtn.ImageAlign = ContentAlignment.MiddleLeft
        GradeBtn.Location = New Point(14, 11)
        GradeBtn.Name = "GradeBtn"
        GradeBtn.Size = New Size(198, 29)
        GradeBtn.TabIndex = 2
        GradeBtn.Text = "          GENERATE GRADING SHEET"
        GradeBtn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GradeCalPanel
        ' 
        GradeCalPanel.BackColor = Color.Transparent
        GradeCalPanel.Controls.Add(GradeCalBtn)
        GradeCalPanel.Location = New Point(13, 357)
        GradeCalPanel.Name = "GradeCalPanel"
        GradeCalPanel.Size = New Size(215, 46)
        GradeCalPanel.TabIndex = 4
        ' 
        ' GradeCalBtn
        ' 
        GradeCalBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        GradeCalBtn.ForeColor = Color.White
        GradeCalBtn.Image = My.Resources.Resources.calculator__2_
        GradeCalBtn.ImageAlign = ContentAlignment.MiddleLeft
        GradeCalBtn.Location = New Point(14, 11)
        GradeCalBtn.Name = "GradeCalBtn"
        GradeCalBtn.Size = New Size(198, 29)
        GradeCalBtn.TabIndex = 2
        GradeCalBtn.Text = "          GRADE CALCULATION"
        GradeCalBtn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ProfPanel
        ' 
        ProfPanel.BackColor = Color.Transparent
        ProfPanel.Controls.Add(ProfBtn)
        ProfPanel.Location = New Point(13, 305)
        ProfPanel.Name = "ProfPanel"
        ProfPanel.Size = New Size(215, 46)
        ProfPanel.TabIndex = 3
        ' 
        ' ProfBtn
        ' 
        ProfBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ProfBtn.ForeColor = Color.White
        ProfBtn.Image = My.Resources.Resources.mentor
        ProfBtn.ImageAlign = ContentAlignment.MiddleLeft
        ProfBtn.Location = New Point(14, 11)
        ProfBtn.Name = "ProfBtn"
        ProfBtn.Size = New Size(198, 29)
        ProfBtn.TabIndex = 2
        ProfBtn.Text = "          PROFESSOR MANAGEMENT"
        ProfBtn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DashPanel
        ' 
        DashPanel.BackColor = Color.Transparent
        DashPanel.Controls.Add(DashboardBtn)
        DashPanel.Location = New Point(13, 253)
        DashPanel.Name = "DashPanel"
        DashPanel.Size = New Size(215, 46)
        DashPanel.TabIndex = 2
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.Transparent
        DashboardBtn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DashboardBtn.ForeColor = Color.White
        DashboardBtn.Image = My.Resources.Resources.dashboard__1_
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(14, 11)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(198, 29)
        DashboardBtn.TabIndex = 2
        DashboardBtn.Text = "          DASHBOARD"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Logo)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(244, 206)
        Panel2.TabIndex = 2
        ' 
        ' Logo
        ' 
        Logo.BackgroundImage = My.Resources.Resources.gradigenius_high_resolution_logo_transparent__1___2_
        Logo.Location = New Point(9, 12)
        Logo.Name = "Logo"
        Logo.Size = New Size(191, 177)
        Logo.TabIndex = 2
        ' 
        ' BtnMin
        ' 
        BtnMin.BackgroundImage = My.Resources.Resources.minus
        BtnMin.BackgroundImageLayout = ImageLayout.Center
        BtnMin.Cursor = Cursors.Hand
        BtnMin.Location = New Point(797, 3)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(33, 34)
        BtnMin.TabIndex = 1
        ' 
        ' BtnClose
        ' 
        BtnClose.BackgroundImage = My.Resources.Resources.reject
        BtnClose.BackgroundImageLayout = ImageLayout.Center
        BtnClose.Cursor = Cursors.Hand
        BtnClose.Location = New Point(827, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(33, 34)
        BtnClose.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(6), CByte(81), CByte(189))
        Panel4.Controls.Add(BtnMin)
        Panel4.Controls.Add(BtnClose)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(244, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(861, 39)
        Panel4.TabIndex = 1
        ' 
        ' TabPanel
        ' 
        TabPanel.Location = New Point(244, 43)
        TabPanel.MaximumSize = New Size(861, 648)
        TabPanel.MinimumSize = New Size(861, 648)
        TabPanel.Name = "TabPanel"
        TabPanel.Size = New Size(861, 648)
        TabPanel.TabIndex = 15
        ' 
        ' DashboardMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1105, 691)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(TabPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "DashboardMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardMain"
        Panel1.ResumeLayout(False)
        LogoutPanel.ResumeLayout(False)
        GradePanel.ResumeLayout(False)
        GradeCalPanel.ResumeLayout(False)
        ProfPanel.ResumeLayout(False)
        DashPanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMin As Panel
    Friend WithEvents BtnClose As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DashPanel As RoundCornerPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Logo As Panel
    Friend WithEvents DashboardBtn As Label
    Friend WithEvents LogoutPanel As RoundCornerPanel
    Friend WithEvents LogoutBtn As Label
    Friend WithEvents GradePanel As RoundCornerPanel
    Friend WithEvents GradeBtn As Label
    Friend WithEvents GradeCalPanel As RoundCornerPanel
    Friend WithEvents GradeCalBtn As Label
    Friend WithEvents ProfPanel As RoundCornerPanel
    Friend WithEvents ProfBtn As Label
    Friend WithEvents TabPanel As Panel
End Class
