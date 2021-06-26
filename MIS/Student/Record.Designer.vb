<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Record
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dwnloadRules = New Bunifu.Framework.UI.BunifuTileButton()
        Me.exitRecord = New Bunifu.Framework.UI.BunifuTileButton()
        Me.DashbdTitle3 = New System.Windows.Forms.Label()
        Me.CrsTitle = New System.Windows.Forms.ListBox()
        Me.gradelist = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.crsCode = New System.Windows.Forms.ListBox()
        Me.hrs = New System.Windows.Forms.ListBox()
        Me.urGPa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dwnloadRules)
        Me.Panel1.Controls.Add(Me.exitRecord)
        Me.Panel1.Controls.Add(Me.DashbdTitle3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 58)
        Me.Panel1.TabIndex = 3
        '
        'dwnloadRules
        '
        Me.dwnloadRules.BackColor = System.Drawing.Color.Transparent
        Me.dwnloadRules.color = System.Drawing.Color.Transparent
        Me.dwnloadRules.colorActive = System.Drawing.Color.Transparent
        Me.dwnloadRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dwnloadRules.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.dwnloadRules.ForeColor = System.Drawing.Color.White
        Me.dwnloadRules.Image = CType(resources.GetObject("dwnloadRules.Image"), System.Drawing.Image)
        Me.dwnloadRules.ImagePosition = 0
        Me.dwnloadRules.ImageZoom = 50
        Me.dwnloadRules.LabelPosition = 0
        Me.dwnloadRules.LabelText = ""
        Me.dwnloadRules.Location = New System.Drawing.Point(723, 6)
        Me.dwnloadRules.Margin = New System.Windows.Forms.Padding(6)
        Me.dwnloadRules.Name = "dwnloadRules"
        Me.dwnloadRules.Size = New System.Drawing.Size(82, 43)
        Me.dwnloadRules.TabIndex = 3
        '
        'exitRecord
        '
        Me.exitRecord.BackColor = System.Drawing.Color.Transparent
        Me.exitRecord.color = System.Drawing.Color.Transparent
        Me.exitRecord.colorActive = System.Drawing.Color.Transparent
        Me.exitRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitRecord.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.exitRecord.ForeColor = System.Drawing.Color.White
        Me.exitRecord.Image = CType(resources.GetObject("exitRecord.Image"), System.Drawing.Image)
        Me.exitRecord.ImagePosition = 0
        Me.exitRecord.ImageZoom = 50
        Me.exitRecord.LabelPosition = 0
        Me.exitRecord.LabelText = ""
        Me.exitRecord.Location = New System.Drawing.Point(817, 6)
        Me.exitRecord.Margin = New System.Windows.Forms.Padding(6)
        Me.exitRecord.Name = "exitRecord"
        Me.exitRecord.Size = New System.Drawing.Size(82, 43)
        Me.exitRecord.TabIndex = 2
        '
        'DashbdTitle3
        '
        Me.DashbdTitle3.AutoSize = True
        Me.DashbdTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashbdTitle3.ForeColor = System.Drawing.Color.Gainsboro
        Me.DashbdTitle3.Location = New System.Drawing.Point(19, 9)
        Me.DashbdTitle3.Name = "DashbdTitle3"
        Me.DashbdTitle3.Size = New System.Drawing.Size(529, 29)
        Me.DashbdTitle3.TabIndex = 1
        Me.DashbdTitle3.Text = "Student Dashboard / Enquiry / Academic Record"
        '
        'CrsTitle
        '
        Me.CrsTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.CrsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.CrsTitle.FormattingEnabled = True
        Me.CrsTitle.ItemHeight = 25
        Me.CrsTitle.Location = New System.Drawing.Point(149, 127)
        Me.CrsTitle.Name = "CrsTitle"
        Me.CrsTitle.Size = New System.Drawing.Size(354, 554)
        Me.CrsTitle.TabIndex = 29
        '
        'gradelist
        '
        Me.gradelist.BackColor = System.Drawing.Color.Gainsboro
        Me.gradelist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradelist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.gradelist.FormattingEnabled = True
        Me.gradelist.ItemHeight = 25
        Me.gradelist.Location = New System.Drawing.Point(658, 127)
        Me.gradelist.Name = "gradelist"
        Me.gradelist.Size = New System.Drawing.Size(104, 554)
        Me.gradelist.TabIndex = 31
        '
        'ListBox5
        '
        Me.ListBox5.BackColor = System.Drawing.Color.Gainsboro
        Me.ListBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 25
        Me.ListBox5.Location = New System.Drawing.Point(792, 127)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(105, 554)
        Me.ListBox5.TabIndex = 32
        '
        'crsCode
        '
        Me.crsCode.BackColor = System.Drawing.Color.Gainsboro
        Me.crsCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crsCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.crsCode.FormattingEnabled = True
        Me.crsCode.ItemHeight = 25
        Me.crsCode.Location = New System.Drawing.Point(4, 127)
        Me.crsCode.Name = "crsCode"
        Me.crsCode.Size = New System.Drawing.Size(139, 554)
        Me.crsCode.TabIndex = 33
        '
        'hrs
        '
        Me.hrs.BackColor = System.Drawing.Color.Gainsboro
        Me.hrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hrs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.hrs.FormattingEnabled = True
        Me.hrs.ItemHeight = 25
        Me.hrs.Location = New System.Drawing.Point(509, 127)
        Me.hrs.Name = "hrs"
        Me.hrs.Size = New System.Drawing.Size(109, 554)
        Me.hrs.TabIndex = 34
        '
        'urGPa
        '
        Me.urGPa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.urGPa.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.urGPa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.urGPa.BorderRadius = 7
        Me.urGPa.ButtonText = "Know your GPA"
        Me.urGPa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.urGPa.DisabledColor = System.Drawing.Color.Gray
        Me.urGPa.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.urGPa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.urGPa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.urGPa.Iconcolor = System.Drawing.Color.Transparent
        Me.urGPa.Iconimage = Nothing
        Me.urGPa.Iconimage_right = Nothing
        Me.urGPa.Iconimage_right_Selected = Nothing
        Me.urGPa.Iconimage_Selected = Nothing
        Me.urGPa.IconMarginLeft = 0
        Me.urGPa.IconMarginRight = 0
        Me.urGPa.IconRightVisible = True
        Me.urGPa.IconRightZoom = 0R
        Me.urGPa.IconVisible = True
        Me.urGPa.IconZoom = 50.0R
        Me.urGPa.IsTab = False
        Me.urGPa.Location = New System.Drawing.Point(0, 748)
        Me.urGPa.Margin = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.urGPa.Name = "urGPa"
        Me.urGPa.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.urGPa.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.urGPa.OnHoverTextColor = System.Drawing.Color.White
        Me.urGPa.selected = False
        Me.urGPa.Size = New System.Drawing.Size(911, 60)
        Me.urGPa.TabIndex = 35
        Me.urGPa.Text = "Know your GPA"
        Me.urGPa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.urGPa.Textcolor = System.Drawing.Color.White
        Me.urGPa.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(157, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 29)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "COURESE TITLE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(668, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 29)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "GRADE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(493, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 29)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "CREDIT HRS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(789, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 29)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "POINT"
        '
        'Record
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(911, 808)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.urGPa)
        Me.Controls.Add(Me.hrs)
        Me.Controls.Add(Me.crsCode)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.gradelist)
        Me.Controls.Add(Me.CrsTitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dwnloadRules As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents exitRecord As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DashbdTitle3 As Label
    Friend WithEvents CrsTitle As ListBox
    Friend WithEvents gradelist As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents crsCode As ListBox
    Friend WithEvents hrs As ListBox
    Friend WithEvents urGPa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
