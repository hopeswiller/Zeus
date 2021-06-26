Imports System.Data.OleDb
Imports MIS.courses
Imports MIS.GV
Public Class ProofREG
    Dim objCon As New OleDb.OleDbConnection

    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Private Sub exitProof_Click(sender As Object, e As EventArgs) Handles exitProof.Click
        StudentDashboard.Show()
        Me.Close()
    End Sub

    Private Sub ProofREG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'name.Items.Add(Item)
        StartPosition = FormStartPosition.CenterScreen
        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

        regWel.Text = " Dear " + FirstName.ToUpper + " " + LastName.ToUpper + ", here are the courses" +
                vbNewLine + " you registered at the begining of the semester" +
                vbNewLine + " You can print on the button below to print a " + vbNewLine + " proof of registration."

        table = "RegCrs"

        DataSet.Clear()
        strSQL = "Select Course from " & table & " where IndexNo ='" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a = dataAdapter.Fill(DataSet, "Database1")
        'MsgBox(a.ToString)
        Dim r = DataSet.Tables("Database1").Rows.Count

        For i = 0 To (r - 1)
            c = dataset.Tables("Database1").Rows(i).Item(0)
            title.Items.Insert(i, c.ToString)
            ''hrs.Items.Insert(i, co.ToString)
        Next
    End Sub

    ' Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    'Dim font As New Font("arial", 16, FontStyle.Regular)
    '   e.Graphics.(title.Items, font, Brushes.Black, 500, 700)
    'End Sub

    'Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
    '   PrintPreviewDialog1.ShowDialog()
    '''PrintDocument1.Print()
    'End Sub
End Class