Imports MySql.Data.MySqlClient

Public Class DashboardMain

    Dim green As Color = Color.FromArgb(CByte(69), CByte(176), CByte(99))
    Dim transparent As Color = Color.Transparent
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub
    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None

        Dim arc As Integer = 20

        Dim D2D As New Drawing2D.GraphicsPath
        D2D.StartFigure()

        'Top Left
        D2D.AddArc(New Rectangle(0, 0, 2 * arc, 2 * arc), 180, 90)

        'Top Right
        D2D.AddArc(New Rectangle(obj.Width - 2 * arc, 0, 2 * arc, 2 * arc), -90, 90)

        'Bottom Right
        D2D.AddArc(New Rectangle(obj.Width - 2 * arc, obj.Height - 2 * arc, 2 * arc, 2 * arc), 0, 90)

        'Bottom Left
        D2D.AddArc(New Rectangle(0, obj.Height - 2 * arc, 2 * arc, 2 * arc), 90, 90)

        obj.Region = New Region(D2D)
    End Sub
    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DashboardMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabform(DashboardPanel)
        roundCorners(Me)

    End Sub

    Sub tabform(ByVal panel As Form)
        TabPanel.Controls.Clear()
        panel.TopLevel = False
        TabPanel.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub

    Private Sub DashBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        tabform(DashboardPanel)
        DashPanel.BackColor = green
    End Sub

    Private Sub DashBtn_MouseEnter(sender As Object, e As EventArgs) Handles DashboardBtn.MouseEnter
        DashPanel.BackColor = green
    End Sub

    Private Sub DashboardBtn_MouseLeave(sender As Object, e As EventArgs) Handles DashboardBtn.MouseLeave
        DashPanel.BackColor = transparent
    End Sub

    Private Sub ProfBtn_MouseEnter(sender As Object, e As EventArgs) Handles ProfBtn.MouseEnter
        ProfPanel.BackColor = green
    End Sub

    Private Sub ProfBtn_MouseLeave(sender As Object, e As EventArgs) Handles ProfBtn.MouseLeave
        ProfPanel.BackColor = transparent
    End Sub

    Private Sub GradeCalBtn_MouseEnter(sender As Object, e As EventArgs) Handles GradeCalBtn.MouseEnter
        GradeCalPanel.BackColor = green
    End Sub

    Private Sub GradeCalBtn_MouseLeave(sender As Object, e As EventArgs) Handles GradeCalBtn.MouseLeave
        GradeCalPanel.BackColor = transparent
    End Sub

    Private Sub GradeBtn_MouseEnter(sender As Object, e As EventArgs) Handles GradeBtn.MouseEnter
        GradePanel.BackColor = green
    End Sub

    Private Sub GradeBtn_MouseLeave(sender As Object, e As EventArgs) Handles GradeBtn.MouseLeave
        GradePanel.BackColor = transparent
    End Sub

    Private Sub LogoutBtn_MouseEnter(sender As Object, e As EventArgs) Handles LogoutBtn.MouseEnter
        LogoutPanel.BackColor = green
    End Sub

    Private Sub LogoutBtn_MouseLeave(sender As Object, e As EventArgs) Handles LogoutBtn.MouseLeave
        LogoutPanel.BackColor = transparent
    End Sub

    Private Sub ProfBtn_Click(sender As Object, e As EventArgs) Handles ProfBtn.Click
        ProfPanel.BackColor = green
        tabform(ProfManagement)
    End Sub

    Private Sub GradeCalBtn_Click(sender As Object, e As EventArgs) Handles GradeCalBtn.Click
        GradeCalPanel.BackColor = green
        tabform(SelectTerm)
    End Sub

    Private Sub GradeBtn_Click(sender As Object, e As EventArgs) Handles GradeBtn.Click
        GradingSheet.Show()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dispose()
        Login.Show()

    End Sub

End Class