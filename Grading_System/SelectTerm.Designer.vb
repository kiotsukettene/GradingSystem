<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectTerm
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
        RoundCornerPanel1 = New RoundCornerPanel()
        Midterm = New Label()
        RoundCornerPanel2 = New RoundCornerPanel()
        FinalTerm = New Label()
        RoundCornerPanel1.SuspendLayout()
        RoundCornerPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundCornerPanel1
        ' 
        RoundCornerPanel1.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel1.Controls.Add(Midterm)
        RoundCornerPanel1.Location = New Point(192, 293)
        RoundCornerPanel1.Margin = New Padding(3, 2, 3, 2)
        RoundCornerPanel1.Name = "RoundCornerPanel1"
        RoundCornerPanel1.Size = New Size(219, 47)
        RoundCornerPanel1.TabIndex = 0
        ' 
        ' Midterm
        ' 
        Midterm.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Midterm.ForeColor = Color.Transparent
        Midterm.Location = New Point(18, 12)
        Midterm.Name = "Midterm"
        Midterm.Size = New Size(183, 25)
        Midterm.TabIndex = 2
        Midterm.Text = "Calculate Midterm"
        Midterm.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RoundCornerPanel2
        ' 
        RoundCornerPanel2.BackColor = Color.FromArgb(CByte(65), CByte(65), CByte(65))
        RoundCornerPanel2.Controls.Add(FinalTerm)
        RoundCornerPanel2.Location = New Point(436, 293)
        RoundCornerPanel2.Margin = New Padding(3, 2, 3, 2)
        RoundCornerPanel2.Name = "RoundCornerPanel2"
        RoundCornerPanel2.Size = New Size(219, 47)
        RoundCornerPanel2.TabIndex = 1
        ' 
        ' FinalTerm
        ' 
        FinalTerm.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FinalTerm.ForeColor = Color.Transparent
        FinalTerm.Location = New Point(18, 12)
        FinalTerm.Name = "FinalTerm"
        FinalTerm.Size = New Size(183, 25)
        FinalTerm.TabIndex = 3
        FinalTerm.Text = "Calculate Finalterm"
        FinalTerm.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SelectTerm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(861, 648)
        Controls.Add(RoundCornerPanel2)
        Controls.Add(RoundCornerPanel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "SelectTerm"
        Text = "SelectTerm"
        RoundCornerPanel1.ResumeLayout(False)
        RoundCornerPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundCornerPanel1 As RoundCornerPanel
    Friend WithEvents Midterm As Label
    Friend WithEvents RoundCornerPanel2 As RoundCornerPanel
    Friend WithEvents FinalTerm As Label
End Class
