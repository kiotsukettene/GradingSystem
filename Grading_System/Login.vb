Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub exitBtn(sender As Object, e As EventArgs) Handles Panel2.Click
        Close()
    End Sub
    Private Sub minBtn(sender As Object, e As EventArgs) Handles Panel3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub register(sender As Object, e As EventArgs) Handles signUpTab.Click
        Me.Hide()
        Signup.Show()



    End Sub

    Private Sub hover(sender As Object, e As EventArgs) Handles signUpTab.MouseEnter
        signPanel.BackColor = Color.FromArgb(CByte(69), CByte(176), CByte(99))
        signUpTab.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
    End Sub

    Private Sub unhover(sender As Object, e As EventArgs) Handles signUpTab.MouseLeave
        signPanel.BackColor = Color.Transparent
        signUpTab.Font = New Font("Segoe UI", 12.0F, FontStyle.Underline, GraphicsUnit.Point)
    End Sub

    Private Sub RoundCornerTextbox2_TextChanged(sender As Object, e As EventArgs) Handles RoundCornerTextbox2.TextChanged
    End Sub
End Class


