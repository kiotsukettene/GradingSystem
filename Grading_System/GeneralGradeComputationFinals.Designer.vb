<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneralGradeComputationFinals
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
        RoundCornerPanel3 = New RoundCornerPanel()
        Label8 = New Label()
        RoundCornerPanel2 = New RoundCornerPanel()
        Label7 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        RoundCornerPanel3.SuspendLayout()
        RoundCornerPanel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RoundCornerPanel3
        ' 
        RoundCornerPanel3.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel3.Controls.Add(Label8)
        RoundCornerPanel3.Location = New Point(15, 579)
        RoundCornerPanel3.Name = "RoundCornerPanel3"
        RoundCornerPanel3.Size = New Size(133, 34)
        RoundCornerPanel3.TabIndex = 54
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(4, 4)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 27)
        Label8.TabIndex = 42
        Label8.Text = "ADD"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RoundCornerPanel2
        ' 
        RoundCornerPanel2.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel2.Controls.Add(Label7)
        RoundCornerPanel2.Location = New Point(703, 579)
        RoundCornerPanel2.Name = "RoundCornerPanel2"
        RoundCornerPanel2.Size = New Size(133, 34)
        RoundCornerPanel2.TabIndex = 53
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 15)
        Label7.TabIndex = 42
        Label7.Text = "CALCULATE GRADE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label1.Location = New Point(15, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(565, 32)
        Label1.TabIndex = 52
        Label1.Text = "GENERAL GRADING CALCULATION - FINALTERM" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label5.Location = New Point(99, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(242, 21)
        Label5.TabIndex = 51
        Label5.Text = "INFORMATION MANAGEMENT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        Label4.Location = New Point(24, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 21)
        Label4.TabIndex = 50
        Label4.Text = "BSCS 2B"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 107)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(821, 311)
        DataGridView1.TabIndex = 49
        ' 
        ' GeneralGradeComputationFinals
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(RoundCornerPanel3)
        Controls.Add(RoundCornerPanel2)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "GeneralGradeComputationFinals"
        Text = "GeneralGradeComputationFinals"
        RoundCornerPanel3.ResumeLayout(False)
        RoundCornerPanel2.ResumeLayout(False)
        RoundCornerPanel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RoundCornerPanel3 As RoundCornerPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents RoundCornerPanel2 As RoundCornerPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
