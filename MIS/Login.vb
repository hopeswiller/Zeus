Imports System.Data.OleDb
Imports MIS.GV

Public Class Login
    ReadOnly DbConnection As New OleDbConnection
    ReadOnly Config As Configuration.ConfigurationSettings
    ReadOnly ConnectionString As String = Config.AppSettings("MyDBConnectionString")

    Dim dataAdapter As New OleDbDataAdapter
    Dim dataset As New DataSet
    Dim attempt As Integer = 0
    Dim query As String

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        FirstPage.Show()

    End Sub

    Private Sub loginbtn_Click_1(sender As Object, e As EventArgs) Handles loginbtn.Click

        If stuCheck.Checked And Not stafCheck.Checked Then
            table = "Student"

            dataset.Clear()
            query = "Select * from " & table & " where IndexNo ='" & IDnum.Text & "' or Pin ='" & Pass.Text & "'"
            'dataAdapter contacts the connection object nd then executes a query ----> results stored in dataset
            dataAdapter = New OleDbDataAdapter(query, DbConnection)
            dataAdapter.Fill(dataset, "Database1")

            GV.id = dataset.Tables("Database1").Rows(0).Item("IndexNo")
            pin = dataset.Tables("Database1").Rows(0).Item("Pin")
            FirstName = dataset.Tables("Database1").Rows(0).Item("Firstname")
            LastName = dataset.Tables("Database1").Rows(0).Item("LastName")
            level = dataset.Tables("Database1").Rows(0).Item("Level")
            dept = dataset.Tables("Database1").Rows(0).Item("Dept")

            If IDnum.Text = id And Pass.Text = pin Then

                Dim StudentDashboard As New StudentDashboard
                StudentDashboard.Show()
                StudentDashboard.welcomeMsg.Text = " Welcome, Dear " + FirstName
                StudentDashboard.info.Text = " Welcome, " + FirstName.ToUpper + " " + LastName.ToUpper + " to the Dashboard for " +
                vbNewLine + " Students. " +
                vbNewLine + " Navigate through the menu pane on the left " + vbNewLine + " and click the required option in order to proceed. "
                Me.Hide()
                IDnum.Text = ""
                Pass.Text = ""

            ElseIf Not Pass.Text = pin Or Not IDnum.Text = id Then
                MsgBox("Login Unsuccessfull" + vbNewLine + " Please check the details entered", MsgBoxStyle.Exclamation)

            End If

        ElseIf stafCheck.Checked And Not stuCheck.Checked Then
            table = "Staff"

            dataset.Clear()
            query = "Select * from " & table & " where StaffID ='" & IDnum.Text & "' or Pin ='" & Pass.Text & "'"
            dataAdapter = New OleDb.OleDbDataAdapter(query, DbConnection)
            dataAdapter.Fill(dataset, "Database1")

            id = dataset.Tables("Database1").Rows(0).Item("StaffID")
            pin = dataset.Tables("Database1").Rows(0).Item("Pin")
            Dim Name = dataset.Tables("Database1").Rows(0).Item("Name")
            dept = dataset.Tables("Database1").Rows(0).Item("Dept")

            If IDnum.Text = id And Pass.Text = pin Then

                Dim Staff As New Staff
                Staff.Show()
                Staff.StartPosition = FormStartPosition.CenterScreen
                Staff.welcomeMsg.Text = " Welcome, Dear " + Name
                Staff.info.Text = " Welcome, " + Name.ToUpper + " to the Dashboard for " +
                vbNewLine + " Staff. " +
                vbNewLine + " Navigate through the menu pane on the left " + vbNewLine + " and click the required option in order to proceed. "
                Me.Hide()
                IDnum.Text = ""
                Pass.Text = ""

            ElseIf Not Pass.Text = pin Or Not IDnum.Text = id Then
                MsgBox("Login Unsuccessfull" + vbNewLine + " Please check the details entered", MsgBoxStyle.Exclamation)

            ElseIf stafCheck.Checked And stuCheck.Checked Then
                MsgBox("Login Unsuccessfull" + vbNewLine + " Please, you can only check one checkbox at a time", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub stuCheck_OnChange(sender As Object, e As EventArgs) Handles stuCheck.OnChange
        If stuCheck.Checked Then
            table = "student"
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stuCheck.Checked = True
        'stafCheck.Enabled = False

        StartPosition = FormStartPosition.CenterParent

        DbConnection.ConnectionString = ConnectionString
        If DbConnection.State = ConnectionState.Closed Then
            DbConnection.Open()
            ''MsgBox("succe")
        Else
            DbConnection.Close()
            MsgBox("failed")
        End If

        IDnum.Focus()
    End Sub

    Private Sub stafCheck_OnChange(sender As Object, e As EventArgs) Handles stafCheck.OnChange
        If stafCheck.Checked Then
            table = "staff"
        End If
    End Sub

    Private Sub stuChoice_Click(sender As Object, e As EventArgs) Handles stuChoice.Click
        If stuCheck.Checked Then
            stuCheck.Checked = False
            stafCheck.Enabled = True
            stafCheck.Checked = True
        Else
            stuCheck.Checked = True
            'stafCheck.Checked = False
        End If
    End Sub

    Private Sub stafChoice_Click(sender As Object, e As EventArgs) Handles stafChoice.Click
        'checked here
        If stafCheck.Checked Then
            stafCheck.Checked = False

        ElseIf stuCheck.Checked And Not stafCheck.Checked Then
            stafCheck.Checked = False

        ElseIf Not stafCheck.Checked And Not stuCheck.Checked Then
            stafCheck.Checked = True
        Else
            stafCheck.Checked = True

        End If
    End Sub

    Private Sub Pass_OnValueChanged(sender As Object, e As EventArgs) Handles Pass.OnValueChanged

    End Sub

End Class