<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentManagement
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
        Label2 = New Label()
        LeftBtn = New RoundCornerButton()
        RightBtn = New RoundCornerButton()
        Panel11 = New Panel()
        DisplayStudentNo = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 32)
        Label1.TabIndex = 31
        Label1.Text = "GRADE CALCULATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label2.Location = New Point(52, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 30)
        Label2.TabIndex = 32
        Label2.Text = "LORETO, Russell Kelvin Anthony"
        ' 
        ' LeftBtn
        ' 
        LeftBtn.BackColor = Color.Transparent
        LeftBtn.FlatAppearance.BorderSize = 0
        LeftBtn.FlatStyle = FlatStyle.Flat
        LeftBtn.Image = My.Resources.Resources.left_arrow
        LeftBtn.Location = New Point(16, 56)
        LeftBtn.Name = "LeftBtn"
        LeftBtn.Size = New Size(30, 30)
        LeftBtn.TabIndex = 33
        LeftBtn.UseVisualStyleBackColor = False
        ' 
        ' RightBtn
        ' 
        RightBtn.BackColor = Color.Transparent
        RightBtn.FlatAppearance.BorderSize = 0
        RightBtn.FlatStyle = FlatStyle.Flat
        RightBtn.Image = My.Resources.Resources.right_arrow__1_
        RightBtn.Location = New Point(387, 56)
        RightBtn.Name = "RightBtn"
        RightBtn.Size = New Size(30, 30)
        RightBtn.TabIndex = 34
        RightBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.DarkGray
        Panel11.Location = New Point(16, 97)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(825, 1)
        Panel11.TabIndex = 35
        ' 
        ' DisplayStudentNo
        ' 
        DisplayStudentNo.AutoSize = True
        DisplayStudentNo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DisplayStudentNo.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        DisplayStudentNo.Location = New Point(52, 100)
        DisplayStudentNo.Name = "DisplayStudentNo"
        DisplayStudentNo.Size = New Size(100, 21)
        DisplayStudentNo.TabIndex = 36
        DisplayStudentNo.Text = "20221210-N"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label4.Location = New Point(164, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 21)
        Label4.TabIndex = 37
        Label4.Text = "BSCS 2B"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label5.Location = New Point(567, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(242, 21)
        Label5.TabIndex = 38
        Label5.Text = "INFORMATION MANAGEMENT"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(52, 141)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(757, 424)
        DataGridView1.TabIndex = 39
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ACTIVITIES"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "QUIZZES"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "PERFORMANCE"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "MIDTERM EXAM"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "MIDTERM GRADE"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' StudentManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DisplayStudentNo)
        Controls.Add(Panel11)
        Controls.Add(RightBtn)
        Controls.Add(LeftBtn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(861, 648)
        MinimumSize = New Size(861, 644)
        Name = "StudentManagement"
        Text = "StudentManagement"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LeftBtn As RoundCornerButton
    Friend WithEvents RightBtn As RoundCornerButton
    Friend WithEvents Panel11 As Panel
    Friend WithEvents DisplayStudentNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
