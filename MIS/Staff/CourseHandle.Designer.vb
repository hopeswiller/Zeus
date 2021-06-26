<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseHandle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseHandle))
        Me.savebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.listbox2 = New System.Windows.Forms.CheckedListBox()
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.listbox = New System.Windows.Forms.CheckedListBox()
        Me.sem1Choice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sem2Choice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sem1Check = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.sem2Check = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.PanelRight2 = New System.Windows.Forms.Panel()
        Me.exitCourses = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dashbdTitle = New System.Windows.Forms.Label()
        Me.ToRight = New Bunifu.Framework.UI.BunifuTileButton()
        Me.deptName = New System.Windows.Forms.Label()
        Me.bks = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.rightPanel.SuspendLayout()
        Me.leftPanel.SuspendLayout()
        Me.PanelRight2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'savebtn
        '
        Me.savebtn.ActiveBorderThickness = 1
        Me.savebtn.ActiveCornerRadius = 20
        Me.savebtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.savebtn.ActiveForecolor = System.Drawing.Color.Gainsboro
        Me.savebtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.savebtn.BackColor = System.Drawing.Color.Gainsboro
        Me.savebtn.BackgroundImage = CType(resources.GetObject("savebtn.BackgroundImage"), System.Drawing.Image)
        Me.savebtn.ButtonText = "Save"
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.savebtn.IdleBorderThickness = 1
        Me.savebtn.IdleCornerRadius = 20
        Me.savebtn.IdleFillColor = System.Drawing.Color.Gainsboro
        Me.savebtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.savebtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.savebtn.Location = New System.Drawing.Point(756, 774)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(5)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(148, 70)
        Me.savebtn.TabIndex = 35
        Me.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listbox2
        '
        Me.listbox2.BackColor = System.Drawing.Color.Gainsboro
        Me.listbox2.CheckOnClick = True
        Me.listbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.listbox2.FormattingEnabled = True
        Me.listbox2.Location = New System.Drawing.Point(0, 7)
        Me.listbox2.Name = "listbox2"
        Me.listbox2.Size = New System.Drawing.Size(414, 556)
        Me.listbox2.TabIndex = 2
        '
        'rightPanel
        '
        Me.rightPanel.Controls.Add(Me.listbox2)
        Me.rightPanel.Location = New System.Drawing.Point(536, 183)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(417, 583)
        Me.rightPanel.TabIndex = 33
        '
        'listbox
        '
        Me.listbox.BackColor = System.Drawing.Color.Gainsboro
        Me.listbox.CheckOnClick = True
        Me.listbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.listbox.FormattingEnabled = True
        Me.listbox.HorizontalScrollbar = True
        Me.listbox.Location = New System.Drawing.Point(0, 7)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(421, 579)
        Me.listbox.Sorted = True
        Me.listbox.TabIndex = 3
        '
        'sem1Choice
        '
        Me.sem1Choice.AutoSize = True
        Me.sem1Choice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sem1Choice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sem1Choice.Location = New System.Drawing.Point(61, 25)
        Me.sem1Choice.Name = "sem1Choice"
        Me.sem1Choice.Size = New System.Drawing.Size(95, 20)
        Me.sem1Choice.TabIndex = 19
        Me.sem1Choice.Text = "Semester 1"
        '
        'sem2Choice
        '
        Me.sem2Choice.AutoSize = True
        Me.sem2Choice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sem2Choice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sem2Choice.Location = New System.Drawing.Point(225, 24)
        Me.sem2Choice.Name = "sem2Choice"
        Me.sem2Choice.Size = New System.Drawing.Size(95, 20)
        Me.sem2Choice.TabIndex = 20
        Me.sem2Choice.Text = "Semester 2"
        '
        'sem1Check
        '
        Me.sem1Check.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sem1Check.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sem1Check.Checked = False
        Me.sem1Check.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sem1Check.ForeColor = System.Drawing.Color.White
        Me.sem1Check.Location = New System.Drawing.Point(34, 25)
        Me.sem1Check.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sem1Check.Name = "sem1Check"
        Me.sem1Check.Size = New System.Drawing.Size(20, 20)
        Me.sem1Check.TabIndex = 17
        '
        'leftPanel
        '
        Me.leftPanel.Controls.Add(Me.listbox)
        Me.leftPanel.Location = New System.Drawing.Point(12, 183)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(424, 596)
        Me.leftPanel.TabIndex = 32
        '
        'sem2Check
        '
        Me.sem2Check.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sem2Check.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sem2Check.Checked = False
        Me.sem2Check.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sem2Check.ForeColor = System.Drawing.Color.White
        Me.sem2Check.Location = New System.Drawing.Point(198, 25)
        Me.sem2Check.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sem2Check.Name = "sem2Check"
        Me.sem2Check.Size = New System.Drawing.Size(20, 20)
        Me.sem2Check.TabIndex = 18
        '
        'PanelRight2
        '
        Me.PanelRight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRight2.Controls.Add(Me.sem1Choice)
        Me.PanelRight2.Controls.Add(Me.sem2Choice)
        Me.PanelRight2.Controls.Add(Me.sem1Check)
        Me.PanelRight2.Controls.Add(Me.sem2Check)
        Me.PanelRight2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PanelRight2.Location = New System.Drawing.Point(36, 79)
        Me.PanelRight2.Name = "PanelRight2"
        Me.PanelRight2.Size = New System.Drawing.Size(350, 69)
        Me.PanelRight2.TabIndex = 31
        '
        'exitCourses
        '
        Me.exitCourses.BackColor = System.Drawing.Color.Transparent
        Me.exitCourses.color = System.Drawing.Color.Transparent
        Me.exitCourses.colorActive = System.Drawing.Color.Transparent
        Me.exitCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitCourses.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.exitCourses.ForeColor = System.Drawing.Color.White
        Me.exitCourses.Image = CType(resources.GetObject("exitCourses.Image"), System.Drawing.Image)
        Me.exitCourses.ImagePosition = 0
        Me.exitCourses.ImageZoom = 50
        Me.exitCourses.LabelPosition = 0
        Me.exitCourses.LabelText = ""
        Me.exitCourses.Location = New System.Drawing.Point(852, 6)
        Me.exitCourses.Margin = New System.Windows.Forms.Padding(6)
        Me.exitCourses.Name = "exitCourses"
        Me.exitCourses.Size = New System.Drawing.Size(82, 43)
        Me.exitCourses.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dashbdTitle)
        Me.Panel1.Controls.Add(Me.exitCourses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 58)
        Me.Panel1.TabIndex = 27
        '
        'dashbdTitle
        '
        Me.dashbdTitle.AutoSize = True
        Me.dashbdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashbdTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.dashbdTitle.Location = New System.Drawing.Point(21, 9)
        Me.dashbdTitle.Name = "dashbdTitle"
        Me.dashbdTitle.Size = New System.Drawing.Size(410, 29)
        Me.dashbdTitle.TabIndex = 3
        Me.dashbdTitle.Text = "Staff Dashboard - Univeristy of Ghana"
        '
        'ToRight
        '
        Me.ToRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ToRight.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ToRight.colorActive = System.Drawing.Color.SeaGreen
        Me.ToRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToRight.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ToRight.ForeColor = System.Drawing.Color.White
        Me.ToRight.Image = CType(resources.GetObject("ToRight.Image"), System.Drawing.Image)
        Me.ToRight.ImagePosition = 0
        Me.ToRight.ImageZoom = 90
        Me.ToRight.LabelPosition = 0
        Me.ToRight.LabelText = ""
        Me.ToRight.Location = New System.Drawing.Point(445, 306)
        Me.ToRight.Margin = New System.Windows.Forms.Padding(6)
        Me.ToRight.Name = "ToRight"
        Me.ToRight.Size = New System.Drawing.Size(82, 85)
        Me.ToRight.TabIndex = 4
        '
        'deptName
        '
        Me.deptName.AutoSize = True
        Me.deptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deptName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.deptName.Location = New System.Drawing.Point(440, 95)
        Me.deptName.Name = "deptName"
        Me.deptName.Size = New System.Drawing.Size(209, 29)
        Me.deptName.TabIndex = 4
        Me.deptName.Text = "Department Name"
        '
        'bks
        '
        Me.bks.ActiveBorderThickness = 1
        Me.bks.ActiveCornerRadius = 20
        Me.bks.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.bks.ActiveForecolor = System.Drawing.Color.Gainsboro
        Me.bks.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.bks.BackColor = System.Drawing.Color.Gainsboro
        Me.bks.BackgroundImage = CType(resources.GetObject("bks.BackgroundImage"), System.Drawing.Image)
        Me.bks.ButtonText = "Remove"
        Me.bks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bks.ForeColor = System.Drawing.Color.SeaGreen
        Me.bks.IdleBorderThickness = 1
        Me.bks.IdleCornerRadius = 20
        Me.bks.IdleFillColor = System.Drawing.Color.Gainsboro
        Me.bks.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.bks.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.bks.Location = New System.Drawing.Point(561, 774)
        Me.bks.Margin = New System.Windows.Forms.Padding(5)
        Me.bks.Name = "bks"
        Me.bks.Size = New System.Drawing.Size(148, 70)
        Me.bks.TabIndex = 36
        Me.bks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CourseHandle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(970, 885)
        Me.Controls.Add(Me.bks)
        Me.Controls.Add(Me.deptName)
        Me.Controls.Add(Me.ToRight)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.PanelRight2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CourseHandle"
        Me.Text = "CourseHandle"
        Me.rightPanel.ResumeLayout(False)
        Me.leftPanel.ResumeLayout(False)
        Me.PanelRight2.ResumeLayout(False)
        Me.PanelRight2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents savebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents listbox2 As CheckedListBox
    Friend WithEvents rightPanel As Panel
    Friend WithEvents listbox As CheckedListBox
    Friend WithEvents sem1Choice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sem2Choice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sem1Check As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents leftPanel As Panel
    Friend WithEvents sem2Check As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents PanelRight2 As Panel
    Friend WithEvents exitCourses As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashbdTitle As Label
    Friend WithEvents ToRight As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents deptName As Label
    Friend WithEvents bks As Bunifu.Framework.UI.BunifuThinButton2
End Class
