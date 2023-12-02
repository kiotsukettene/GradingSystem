Public Class Signup
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
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

    Private Sub close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub signInTab_Click(sender As Object, e As EventArgs) Handles signInTab.Click
        Dispose()
        Login.Show()
    End Sub

    Private Sub signIn_MouseEnter(sender As Object, e As EventArgs) Handles signInTab.MouseEnter
        signPanel.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        signInTab.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

    Private Sub signInTab_MouseLeave(sender As Object, e As EventArgs) Handles signInTab.MouseLeave
        signPanel.BackColor = Color.Transparent
        signInTab.Font = New Font("Segoe UI", 12.0F, FontStyle.Underline, GraphicsUnit.Point)
    End Sub
End Class