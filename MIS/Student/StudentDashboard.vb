Imports System.Data.OleDb
Imports MIS.GV
Public Class StudentDashboard
    Dim objCon As New OleDb.OleDbConnection
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet

    Private Sub personalbtn_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        welcomeMsg.Visible = True
        info.Visible = True
        Panel2.Visible = False

    End Sub

    Private Sub Bottomsep_Load(sender As Object, e As EventArgs) Handles bottomsep.Load
        welcomeMsg.Visible = True
        info.Visible = True
        Panel2.Visible = False
        homebtn.Activecolor = Color.FromArgb(116, 32, 20)


        StartPosition = FormStartPosition.CenterScreen
        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

    End Sub

    Private Sub enqbtn_Click(sender As Object, e As EventArgs) Handles enqbtn.Click
        welcomeMsg.Visible = False
        info.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub RegCoursesbtn_Click(sender As Object, e As EventArgs) Handles RegCoursesbtn.Click
        Dim courses As New courses
        courses.ShowDialog()
    End Sub

    Private Sub Recordbtn_Click(sender As Object, e As EventArgs) Handles Recordbtn.Click
        Dim record As New Record
        record.ShowDialog()
    End Sub

    Private Sub classbtn_Click(sender As Object, e As EventArgs) Handles classbtn.Click
        dataset.Clear()
        strSQL = "Select RegCrs.Grade, Courses.CreditHrs from Courses inner join RegCrs on Courses.CourseName = RegCrs.Course where RegCrs.IndexNo= '" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        dataAdapter.Fill(dataset, "Database1")
        Dim y = dataset.Tables("Database1").Rows.Count
        ''crsCode.Items.Clear()
        ''hrs.Items.Clear()
        Dim f1 = 0.0
        Dim sum = 0.0
        Dim totalCredit = 0.0
        For i = 0 To (y - 1)
            c = dataset.Tables("Database1").Rows(i).Item("Grade")
            Dim u = dataset.Tables("Database1").Rows(i).Item("CreditHrs")

            If c = ga Then
                mk = 4.0
                f1 = u * mk
                sum += f1
                totalCredit += u
            ElseIf c = gbp Then
                mk = 3.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gb Then
                mk = 3.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gcp Then
                mk = 2.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gc Then
                mk = 2.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gdp Then
                mk = 1.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gd Then
                mk = 1.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = ge Then
                mk = 0.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gf Then
                mk = 0.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            End If


        Next
        Dim gpa = 0.0
        gpa = Math.Round(sum / totalCredit, 2)

        Dim gpa1 = gpa.ToString
        ''MsgBox("Hello " + FirstName + "," + vbNewLine + "This is your GPA " + gpa1)
        Dim tex As String = ""
        If gpa >= 3.6 And gpa <= 4.0 Then
            tex = "FIRST CLASS DIVISION"
        ElseIf gpa <= 3.59 And gpa >= 3.0 Then
            tex = "UPPER CLASS DIVISION"
        ElseIf gpa <= 2.99 And gpa >= 2.0 Then
            tex = "LOWER CLASS DIVISION"
        ElseIf gpa < 1.99 And gpa >= 1.0 Then
            tex = "THIRD CLASS DIVISION"
        ElseIf gpa < 0.9 And gpa > 0.0 Then
            tex = "PASS DIVISION"
        End If
        MsgBox("Hello " + FirstName + "," + vbNewLine + "This is your class division " + tex)
    End Sub

    Private Sub Proofbtn_Click(sender As Object, e As EventArgs) Handles Proofbtn.Click
        Dim proof As New ProofREG
        proof.StartPosition = FormStartPosition.CenterScreen
        proof.ShowDialog()
    End Sub

    Private Sub dropCoursesbtn_Click(sender As Object, e As EventArgs) Handles dropCoursesbtn.Click
        Dim drop As New CrsDrop
        drop.StartPosition = FormStartPosition.CenterScreen
        drop.ShowDialog()

    End Sub

    Private Sub gpabtn_Click(sender As Object, e As EventArgs) Handles gpabtn.Click

        dataset.Clear()
        strSQL = "Select RegCrs.Grade, Courses.CreditHrs from Courses inner join RegCrs on Courses.CourseName = RegCrs.Course where RegCrs.IndexNo= '" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        dataAdapter.Fill(dataset, "Database1")
        Dim y = dataset.Tables("Database1").Rows.Count
        Dim f1 = 0.0
        Dim sum = 0.0
        Dim totalCredit = 0.0
        For i = 0 To (y - 1)
            c = dataset.Tables("Database1").Rows(i).Item("Grade")
            Dim u = dataset.Tables("Database1").Rows(i).Item("CreditHrs")

            If c = ga Then
                mk = 4.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gbp Then
                mk = 3.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gb Then
                mk = 3.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gcp Then
                mk = 2.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gc Then
                mk = 2.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gdp Then
                mk = 1.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gd Then
                mk = 1.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = ge Then
                mk = 0.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gf Then
                mk = 0.0
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            End If


        Next
        Dim gpa = 0.0
        gpa = Math.Round(sum / totalCredit, 2)

        Dim gpa1 = gpa.ToString
        MsgBox("Hello " + FirstName + "," + vbNewLine + "This is your GPA " + gpa1)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class