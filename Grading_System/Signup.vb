Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Signup
    Dim green As Color = Color.FromArgb(CByte(69), CByte(176), CByte(99))
    Dim mycon As New DBConnection
    Dim RegCode As New RegisterCode
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        Dim random As New Random

        ProfIDReg.Text = random.Next(100, 1000)

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
        ProfIDReg.Text = ""
        Fname.Text = ""
        Lname.Text = ""
        EmailReg.Text = ""
        PassReg.Text = ""
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

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim firstname As String = Fname.Text
        Dim lastname As String = Lname.Text
        Dim email As String = EmailReg.Text
        Dim password As String = PassReg.Text
        Dim professorID As String = ProfIDReg.Text

        If firstname.Trim().Equals("") Then
            FnameLabel.ForeColor = Color.Red
            MessageBox.Show("Fill up your first name")
        ElseIf lastname.Trim().Equals("") Then
            LnameLabel.ForeColor = Color.Red
            MessageBox.Show("Fill up your last name")
        ElseIf email.Trim().Equals("") Then
            EmailLabel.ForeColor = Color.Red
            MessageBox.Show("Fill up your email")
        ElseIf password.Trim().Equals("") Then
            PassLabel.ForeColor = Color.Red
            MessageBox.Show("Fill up your password")
        Else
            If RegCode.registerForm(professorID, firstname, lastname, email, password) Then
                MessageBox.Show("Register Complete")
                Fname.Text = ""
                Lname.Text = ""
                EmailReg.Text = ""
                PassReg.Text = ""
                ProfIDReg.Text = ""
                Dispose()
                Login.Show()
            Else
                MessageBox.Show("Register Fail")
            End If
        End If
    End Sub

    Private Sub Fname_Enter(sender As Object, e As EventArgs) Handles Fname.Enter
        FnameLabel.ForeColor = green
    End Sub

    Private Sub Lname_Enter(sender As Object, e As EventArgs) Handles Lname.Enter
        LnameLabel.ForeColor = green
    End Sub

    Private Sub EmailReg_Enter(sender As Object, e As EventArgs) Handles EmailReg.Enter
        EmailLabel.ForeColor = green
    End Sub

    Private Sub PassReg_Enter(sender As Object, e As EventArgs) Handles PassReg.Enter
        PassLabel.ForeColor = green
    End Sub
End Class