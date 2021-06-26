Imports MIS.GV
Imports MIS.Login
Imports System.Data.OleDb
Public Class Staff
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        welcomeMsg.Visible = True
        info.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub enqbtn_Click(sender As Object, e As EventArgs) Handles enqbtn.Click
        welcomeMsg.Visible = False
        info.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub bottomsep_Load(sender As Object, e As EventArgs) Handles bottomsep.Load, MyBase.Load
        welcomeMsg.Visible = True
        info.Visible = True
        Panel2.Visible = False
        StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub AddGradesbtn_Click(sender As Object, e As EventArgs) Handles AddGradesbtn.Click
        Dim addgrades As New AddGrades
        addgrades.StartPosition = FormStartPosition.CenterScreen
        addgrades.ShowDialog()
    End Sub

    Private Sub classList_Click(sender As Object, e As EventArgs) Handles classList.Click
        Dim prompt = "Please enter the course code"
        Dim title = "Course Selection"
        'courseEntered = InputBox(prompt, title)
        Dim classlist As New classlist
        classlist.StartPosition = FormStartPosition.CenterScreen
        classlist.ShowDialog()

    End Sub

    Private Sub crshandling_Click(sender As Object, e As EventArgs) Handles crshandling.Click
        Dim prompt = "Please enter the semester number  either 1 or 2"
        Dim title = "Semester Selection"
        semSelected = InputBox(prompt, title)

        Dim courseHandling As New CourseHandle
        courseHandling.StartPosition = FormStartPosition.CenterScreen
        courseHandling.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class