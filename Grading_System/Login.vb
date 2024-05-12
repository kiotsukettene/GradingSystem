Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Login

    Dim mycon As New DBConnection
    Dim conAdapter As MySqlDataAdapter
    Dim dataTable As DataTable



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub
    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        Dim email As String = emailBox.Text
        Dim password As String = PasswordBox.Text
        Dim Fname As String
        Dim Lname As String
        Dim EmailAdd As String
        Dim PasswordVar As String
        Dim ProfID As String
        Dim qry As String
        Dim mycon As New DBConnection

        'dataTable = New DataTable
        'dataTable.Clear()
        mycon.open()
        qry = "SELECT * FROM `user_info` WHERE `email`=@email AND `password`=@password"
        'cmd.CommandText = "SELECT * FROM `user_info` WHERE `email`=@email AND `password`=@password"
        Dim cmd As New MySqlCommand(qry, mycon.getCon())

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
        cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        Dim DR As MySqlDataReader

        DR = cmd.ExecuteReader

        If DR.HasRows Then
            While DR.Read
                Fname = DR.GetString("firstname")
                Lname = DR.GetString("lastname")
                EmailAdd = DR.GetString("email")
                PasswordVar = DR.GetString("password")
                ProfID = DR.GetString("prof_id")
            End While

            DashboardPanel.WelcomeDisplay.Text = "WElCOME, PROFESSOR " & Fname.ToUpper & " " & Lname.ToUpper
            ProfManagement.DisplayFname.Text = Fname.ToUpper
            ProfManagement.DisplayLname.Text = Lname.ToUpper
            ProfManagement.DisplayEmail.Text = EmailAdd
            ProfManagement.DisplayPass.Text = PasswordVar
            ProfManagement.DisplayProfID.Text = ProfID
            MsgBox("Logging in...")
            DashboardMain.Show()
            emailBox.Text = ""
            PasswordBox.Text = ""
            Me.Hide()
            mycon.close()
        Else
            MessageBox.Show("Invalid username and password")
            mycon.close()
        End If


        'conAdapter = New MySqlDataAdapter With {
        '.SelectCommand = cmd
        '}

        'conAdapter.Fill(dataTable)


        'If dataTable.Rows.Count() <= 0 Then

        'MsgBox("username and password are invalid")
        'mycon.close()
        ' Else
        'MsgBox("Logging in...")
        'Me.Hide()
        'DashboardMain.Show()
        'emailBox.Text = ""
        'PasswordBox.Text = ""
        'End If

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
        emailBox.Text = ""
        PasswordBox.Text = ""
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

    Private Sub RoundCornerTextbox2_TextChanged(sender As Object, e As EventArgs)
    End Sub


End Class


