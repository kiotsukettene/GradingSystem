<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPanel
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
        SectionDataView = New DataGridView()
        Panel3 = New Panel()
        BSCSSection = New ComboBox()
        Label12 = New Label()
        RoundCornerPanel9 = New RoundCornerPanel()
        TotalEMC = New Label()
        Label5 = New Label()
        Program4 = New Label()
        RoundCornerPanel8 = New RoundCornerPanel()
        TotalIS = New Label()
        Label4 = New Label()
        Program3 = New Label()
        RoundCornerPanel7 = New RoundCornerPanel()
        TotalIT = New Label()
        Label3 = New Label()
        Program2 = New Label()
        RoundCornerPanel6 = New RoundCornerPanel()
        TotalCS = New Label()
        Label2 = New Label()
        Program1 = New Label()
        WelcomeDisplay = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        SearchBox = New TextBox()
        BSITSection = New ComboBox()
        BSISSection = New ComboBox()
        BSEMCSection = New ComboBox()
        CType(SectionDataView, ComponentModel.ISupportInitialize).BeginInit()
        RoundCornerPanel9.SuspendLayout()
        RoundCornerPanel8.SuspendLayout()
        RoundCornerPanel7.SuspendLayout()
        RoundCornerPanel6.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SectionDataView
        ' 
        SectionDataView.AllowUserToAddRows = False
        SectionDataView.AllowUserToDeleteRows = False
        SectionDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        SectionDataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        SectionDataView.BackgroundColor = Color.White
        SectionDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SectionDataView.GridColor = Color.Black
        SectionDataView.Location = New Point(7, 321)
        SectionDataView.Name = "SectionDataView"
        SectionDataView.ReadOnly = True
        SectionDataView.RowHeadersVisible = False
        SectionDataView.RowHeadersWidth = 51
        SectionDataView.RowTemplate.Height = 25
        SectionDataView.Size = New Size(847, 322)
        SectionDataView.TabIndex = 28
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.search__1_
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(561, 288)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(22, 30)
        Panel3.TabIndex = 27
        ' 
        ' BSCSSection
        ' 
        BSCSSection.BackColor = Color.FromArgb(CByte(244), CByte(194), CByte(12))
        BSCSSection.FlatStyle = FlatStyle.Flat
        BSCSSection.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BSCSSection.ForeColor = Color.White
        BSCSSection.FormattingEnabled = True
        BSCSSection.Items.AddRange(New Object() {"2A", "2B"})
        BSCSSection.Location = New Point(53, 226)
        BSCSSection.Name = "BSCSSection"
        BSCSSection.Size = New Size(121, 23)
        BSCSSection.Sorted = True
        BSCSSection.TabIndex = 23
        BSCSSection.Text = "Select Section..."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label12.Location = New Point(7, 288)
        Label12.Name = "Label12"
        Label12.Size = New Size(143, 25)
        Label12.TabIndex = 21
        Label12.Text = "List of Students"
        ' 
        ' RoundCornerPanel9
        ' 
        RoundCornerPanel9.BackColor = Color.Red
        RoundCornerPanel9.BackgroundImage = My.Resources.Resources.safeimagekit_emc_removebg_preview__1_
        RoundCornerPanel9.BackgroundImageLayout = ImageLayout.Center
        RoundCornerPanel9.Controls.Add(TotalEMC)
        RoundCornerPanel9.Controls.Add(Label5)
        RoundCornerPanel9.Controls.Add(Program4)
        RoundCornerPanel9.Location = New Point(649, 91)
        RoundCornerPanel9.Name = "RoundCornerPanel9"
        RoundCornerPanel9.Size = New Size(205, 129)
        RoundCornerPanel9.TabIndex = 20
        ' 
        ' TotalEMC
        ' 
        TotalEMC.AutoSize = True
        TotalEMC.BackColor = Color.Transparent
        TotalEMC.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalEMC.ForeColor = Color.White
        TotalEMC.Location = New Point(146, 33)
        TotalEMC.Name = "TotalEMC"
        TotalEMC.Size = New Size(56, 65)
        TotalEMC.TabIndex = 33
        TotalEMC.Text = "1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(13, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 20)
        Label5.TabIndex = 31
        Label5.Text = "TOTAL SECTION"
        ' 
        ' Program4
        ' 
        Program4.AutoSize = True
        Program4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Program4.ForeColor = Color.White
        Program4.Location = New Point(10, 87)
        Program4.Name = "Program4"
        Program4.Size = New Size(106, 37)
        Program4.TabIndex = 10
        Program4.Text = "BSEMC"
        ' 
        ' RoundCornerPanel8
        ' 
        RoundCornerPanel8.BackColor = Color.FromArgb(CByte(102), CByte(61), CByte(216))
        RoundCornerPanel8.BackgroundImage = My.Resources.Resources.safeimagekit_IS_removebg_preview__1_
        RoundCornerPanel8.BackgroundImageLayout = ImageLayout.Center
        RoundCornerPanel8.Controls.Add(TotalIS)
        RoundCornerPanel8.Controls.Add(Label4)
        RoundCornerPanel8.Controls.Add(Program3)
        RoundCornerPanel8.Location = New Point(435, 91)
        RoundCornerPanel8.Name = "RoundCornerPanel8"
        RoundCornerPanel8.Size = New Size(205, 129)
        RoundCornerPanel8.TabIndex = 19
        ' 
        ' TotalIS
        ' 
        TotalIS.AutoSize = True
        TotalIS.BackColor = Color.Transparent
        TotalIS.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalIS.ForeColor = Color.White
        TotalIS.Location = New Point(146, 33)
        TotalIS.Name = "TotalIS"
        TotalIS.Size = New Size(56, 65)
        TotalIS.TabIndex = 32
        TotalIS.Text = "4"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(13, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 20)
        Label4.TabIndex = 32
        Label4.Text = "TOTAL SECTION"
        ' 
        ' Program3
        ' 
        Program3.AutoSize = True
        Program3.BackColor = Color.Transparent
        Program3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Program3.ForeColor = Color.White
        Program3.Location = New Point(10, 87)
        Program3.Name = "Program3"
        Program3.Size = New Size(73, 37)
        Program3.TabIndex = 10
        Program3.Text = "BSIS"
        ' 
        ' RoundCornerPanel7
        ' 
        RoundCornerPanel7.BackColor = Color.FromArgb(CByte(51), CByte(111), CByte(255))
        RoundCornerPanel7.BackgroundImage = My.Resources.Resources.safeimagekit_375957968_218071294580303_6718703472572984364_n_removebg_preview__1_
        RoundCornerPanel7.BackgroundImageLayout = ImageLayout.Center
        RoundCornerPanel7.Controls.Add(TotalIT)
        RoundCornerPanel7.Controls.Add(Label3)
        RoundCornerPanel7.Controls.Add(Program2)
        RoundCornerPanel7.Location = New Point(221, 91)
        RoundCornerPanel7.Name = "RoundCornerPanel7"
        RoundCornerPanel7.Size = New Size(205, 129)
        RoundCornerPanel7.TabIndex = 18
        ' 
        ' TotalIT
        ' 
        TotalIT.AutoSize = True
        TotalIT.BackColor = Color.Transparent
        TotalIT.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalIT.ForeColor = Color.White
        TotalIT.Location = New Point(146, 33)
        TotalIT.Name = "TotalIT"
        TotalIT.Size = New Size(56, 65)
        TotalIT.TabIndex = 31
        TotalIT.Text = "2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(13, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 20)
        Label3.TabIndex = 31
        Label3.Text = "TOTAL SECTION"
        ' 
        ' Program2
        ' 
        Program2.AutoSize = True
        Program2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Program2.ForeColor = Color.White
        Program2.Location = New Point(10, 87)
        Program2.Name = "Program2"
        Program2.Size = New Size(74, 37)
        Program2.TabIndex = 9
        Program2.Text = "BSIT"
        ' 
        ' RoundCornerPanel6
        ' 
        RoundCornerPanel6.BackColor = Color.FromArgb(CByte(244), CByte(194), CByte(12))
        RoundCornerPanel6.BackgroundImage = My.Resources.Resources.safeimagekit_cs_removebg_preview__1___3_
        RoundCornerPanel6.BackgroundImageLayout = ImageLayout.Center
        RoundCornerPanel6.Controls.Add(TotalCS)
        RoundCornerPanel6.Controls.Add(Label2)
        RoundCornerPanel6.Controls.Add(Program1)
        RoundCornerPanel6.Location = New Point(7, 91)
        RoundCornerPanel6.Name = "RoundCornerPanel6"
        RoundCornerPanel6.Size = New Size(205, 129)
        RoundCornerPanel6.TabIndex = 17
        ' 
        ' TotalCS
        ' 
        TotalCS.AutoSize = True
        TotalCS.BackColor = Color.Transparent
        TotalCS.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TotalCS.ForeColor = Color.White
        TotalCS.Location = New Point(146, 33)
        TotalCS.Name = "TotalCS"
        TotalCS.Size = New Size(56, 65)
        TotalCS.TabIndex = 30
        TotalCS.Text = "6"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(13, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 30
        Label2.Text = "TOTAL SECTION"
        ' 
        ' Program1
        ' 
        Program1.AutoSize = True
        Program1.BackColor = Color.Transparent
        Program1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Program1.ForeColor = Color.White
        Program1.Location = New Point(10, 87)
        Program1.Name = "Program1"
        Program1.Size = New Size(81, 37)
        Program1.TabIndex = 8
        Program1.Text = "BSCS"
        ' 
        ' WelcomeDisplay
        ' 
        WelcomeDisplay.AutoSize = True
        WelcomeDisplay.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        WelcomeDisplay.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        WelcomeDisplay.Location = New Point(4, 54)
        WelcomeDisplay.Name = "WelcomeDisplay"
        WelcomeDisplay.Size = New Size(226, 25)
        WelcomeDisplay.TabIndex = 16
        WelcomeDisplay.Text = "WELCOME, PROFESSOR "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label6.Location = New Point(2, -44)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 32)
        Label6.TabIndex = 15
        Label6.Text = "DASHBOARD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label1.Location = New Point(4, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 32)
        Label1.TabIndex = 29
        Label1.Text = "DASHBOARD"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(SearchBox)
        Panel1.Location = New Point(584, 288)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 30)
        Panel1.TabIndex = 30
        ' 
        ' SearchBox
        ' 
        SearchBox.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SearchBox.BorderStyle = BorderStyle.None
        SearchBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        SearchBox.Location = New Point(4, 5)
        SearchBox.Name = "SearchBox"
        SearchBox.PlaceholderText = "Search Here..."
        SearchBox.Size = New Size(243, 20)
        SearchBox.TabIndex = 0
        ' 
        ' BSITSection
        ' 
        BSITSection.BackColor = Color.FromArgb(CByte(51), CByte(111), CByte(255))
        BSITSection.FlatStyle = FlatStyle.Flat
        BSITSection.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BSITSection.ForeColor = Color.White
        BSITSection.FormattingEnabled = True
        BSITSection.Location = New Point(268, 226)
        BSITSection.Name = "BSITSection"
        BSITSection.Size = New Size(121, 23)
        BSITSection.Sorted = True
        BSITSection.TabIndex = 31
        BSITSection.Text = "Select Section..."
        ' 
        ' BSISSection
        ' 
        BSISSection.BackColor = Color.FromArgb(CByte(102), CByte(61), CByte(216))
        BSISSection.FlatStyle = FlatStyle.Flat
        BSISSection.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BSISSection.ForeColor = Color.White
        BSISSection.FormattingEnabled = True
        BSISSection.Location = New Point(478, 226)
        BSISSection.Name = "BSISSection"
        BSISSection.Size = New Size(121, 23)
        BSISSection.TabIndex = 32
        BSISSection.Text = "Select Section..."
        ' 
        ' BSEMCSection
        ' 
        BSEMCSection.BackColor = Color.Red
        BSEMCSection.FlatStyle = FlatStyle.Flat
        BSEMCSection.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BSEMCSection.ForeColor = Color.White
        BSEMCSection.FormattingEnabled = True
        BSEMCSection.Location = New Point(691, 226)
        BSEMCSection.Name = "BSEMCSection"
        BSEMCSection.Size = New Size(121, 23)
        BSEMCSection.TabIndex = 33
        BSEMCSection.Text = "Select Section..."
        ' 
        ' DashboardPanel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(BSEMCSection)
        Controls.Add(BSISSection)
        Controls.Add(BSITSection)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(SectionDataView)
        Controls.Add(Panel3)
        Controls.Add(BSCSSection)
        Controls.Add(Label12)
        Controls.Add(RoundCornerPanel9)
        Controls.Add(RoundCornerPanel8)
        Controls.Add(RoundCornerPanel7)
        Controls.Add(RoundCornerPanel6)
        Controls.Add(WelcomeDisplay)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(861, 648)
        MinimumSize = New Size(861, 644)
        Name = "DashboardPanel"
        Text = "DashboardPanel"
        CType(SectionDataView, ComponentModel.ISupportInitialize).EndInit()
        RoundCornerPanel9.ResumeLayout(False)
        RoundCornerPanel9.PerformLayout()
        RoundCornerPanel8.ResumeLayout(False)
        RoundCornerPanel8.PerformLayout()
        RoundCornerPanel7.ResumeLayout(False)
        RoundCornerPanel7.PerformLayout()
        RoundCornerPanel6.ResumeLayout(False)
        RoundCornerPanel6.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SectionDataView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BSCSSection As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RoundCornerPanel9 As RoundCornerPanel
    Friend WithEvents Program4 As Label
    Friend WithEvents RoundCornerPanel8 As RoundCornerPanel
    Friend WithEvents Program3 As Label
    Friend WithEvents RoundCornerPanel7 As RoundCornerPanel
    Friend WithEvents Program2 As Label
    Friend WithEvents RoundCornerPanel6 As RoundCornerPanel
    Friend WithEvents Program1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents WelcomeDisplay As Label
    Friend WithEvents TotalEMC As Label
    Friend WithEvents TotalIS As Label
    Friend WithEvents TotalIT As Label
    Friend WithEvents TotalCS As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents BSITSection As ComboBox
    Friend WithEvents BSISSection As ComboBox
    Friend WithEvents BSEMCSection As ComboBox
End Class
