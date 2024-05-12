Public Class SelectTerm
    Sub tabform(ByVal panel As Form)
        DashboardMain.TabPanel.Controls.Clear()
        panel.TopLevel = False
        DashboardMain.TabPanel.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub
    Private Sub Midterm_Click(sender As Object, e As EventArgs) Handles Midterm.Click
        tabform(GeneralGradeComputation)
    End Sub

    Private Sub FinalTerm_Click(sender As Object, e As EventArgs) Handles FinalTerm.Click
        tabform(GeneralGradeComputationFinals)
    End Sub
End Class