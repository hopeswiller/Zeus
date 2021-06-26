<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class courses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(courses))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitCourses = New Bunifu.Framework.UI.BunifuTileButton()
        Me.DashbdTitle2 = New System.Windows.Forms.Label()
        Me.qualif = New System.Windows.Forms.Label()
        Me.PanelRight2 = New System.Windows.Forms.Panel()
        Me.sem1Choice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sem2Choice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sem1Check = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.sem2Check = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.depts = New System.Windows.Forms.ComboBox()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.listbox = New System.Windows.Forms.CheckedListBox()
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.listbox2 = New System.Windows.Forms.CheckedListBox()
        Me.registerbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.deleteCourses = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.savebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelRight2.SuspendLayout()
        Me.leftPanel.SuspendLayout()
        Me.rightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.exitCourses)
        Me.Panel1.Controls.Add(Me.DashbdTitle2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 58)
        Me.Panel1.TabIndex = 2
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
        Me.exitCourses.Location = New System.Drawing.Point(803, 6)
        Me.exitCourses.Margin = New System.Windows.Forms.Padding(6)
        Me.exitCourses.Name = "exitCourses"
        Me.exitCourses.Size = New System.Drawing.Size(82, 43)
        Me.exitCourses.TabIndex = 2
        '
        'DashbdTitle2
        '
        Me.DashbdTitle2.AutoSize = True
        Me.DashbdTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashbdTitle2.ForeColor = System.Drawing.Color.Gainsboro
        Me.DashbdTitle2.Location = New System.Drawing.Point(19, 9)
        Me.DashbdTitle2.Name = "DashbdTitle2"
        Me.DashbdTitle2.Size = New System.Drawing.Size(525, 29)
        Me.DashbdTitle2.TabIndex = 1
        Me.DashbdTitle2.Text = "Student Dashboard / Enquiry / Register Courses"
        '
        'qualif
        '
        Me.qualif.AutoSize = True
        Me.qualif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qualif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.qualif.Location = New System.Drawing.Point(546, 70)
        Me.qualif.Name = "qualif"
        Me.qualif.Size = New System.Drawing.Size(267, 29)
        Me.qualif.TabIndex = 3
        Me.qualif.Text = "Select your qualification"
        '
        'PanelRight2
        '
        Me.PanelRight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRight2.Controls.Add(Me.sem1Choice)
        Me.PanelRight2.Controls.Add(Me.sem2Choice)
        Me.PanelRight2.Controls.Add(Me.sem1Check)
        Me.PanelRight2.Controls.Add(Me.sem2Check)
        Me.PanelRight2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PanelRight2.Location = New System.Drawing.Point(504, 118)
        Me.PanelRight2.Name = "PanelRight2"
        Me.PanelRight2.Size = New System.Drawing.Size(350, 69)
        Me.PanelRight2.TabIndex = 22
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
        'depts
        '
        Me.depts.BackColor = System.Drawing.Color.Gainsboro
        Me.depts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.depts.FormattingEnabled = True
        Me.depts.Items.AddRange(New Object() {"University Required Courses", "Accounting", "Finance", "Marketing & Customer Management", "English", "Linguitics", "Modern Language", "French", "Economics", "Political Science", "Pyschology" & Global.Microsoft.VisualBasic.ChrW(9), "Information Studies", "Mathematics", "Computer Science", "Statistics"})
        Me.depts.Location = New System.Drawing.Point(12, 186)
        Me.depts.Name = "depts"
        Me.depts.Size = New System.Drawing.Size(455, 33)
        Me.depts.TabIndex = 21
        Me.depts.Text = "Apply filter by department"
        '
        'leftPanel
        '
        Me.leftPanel.Controls.Add(Me.listbox)
        Me.leftPanel.Location = New System.Drawing.Point(12, 249)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(441, 575)
        Me.leftPanel.TabIndex = 23
        '
        'listbox
        '
        Me.listbox.BackColor = System.Drawing.Color.Gainsboro
        Me.listbox.CheckOnClick = True
        Me.listbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox.FormattingEnabled = True
        Me.listbox.HorizontalScrollbar = True
        Me.listbox.Location = New System.Drawing.Point(0, 7)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(432, 554)
        Me.listbox.TabIndex = 2
        '
        'rightPanel
        '
        Me.rightPanel.Controls.Add(Me.listbox2)
        Me.rightPanel.Location = New System.Drawing.Point(468, 249)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(417, 575)
        Me.rightPanel.TabIndex = 24
        '
        'listbox2
        '
        Me.listbox2.BackColor = System.Drawing.Color.Gainsboro
        Me.listbox2.CheckOnClick = True
        Me.listbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox2.FormattingEnabled = True
        Me.listbox2.Location = New System.Drawing.Point(0, 7)
        Me.listbox2.Name = "listbox2"
        Me.listbox2.Size = New System.Drawing.Size(414, 554)
        Me.listbox2.TabIndex = 2
        '
        'registerbtn
        '
        Me.registerbtn.ActiveBorderThickness = 1
        Me.registerbtn.ActiveCornerRadius = 20
        Me.registerbtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.registerbtn.ActiveForecolor = System.Drawing.Color.Gainsboro
        Me.registerbtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.registerbtn.BackColor = System.Drawing.Color.Gainsboro
        Me.registerbtn.BackgroundImage = CType(resources.GetObject("registerbtn.BackgroundImage"), System.Drawing.Image)
        Me.registerbtn.ButtonText = "Register "
        Me.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.registerbtn.IdleBorderThickness = 1
        Me.registerbtn.IdleCornerRadius = 20
        Me.registerbtn.IdleFillColor = System.Drawing.Color.Gainsboro
        Me.registerbtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.registerbtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.registerbtn.Location = New System.Drawing.Point(160, 841)
        Me.registerbtn.Margin = New System.Windows.Forms.Padding(5)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(135, 70)
        Me.registerbtn.TabIndex = 4
        Me.registerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'deleteCourses
        '
        Me.deleteCourses.ActiveBorderThickness = 1
        Me.deleteCourses.ActiveCornerRadius = 20
        Me.deleteCourses.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.deleteCourses.ActiveForecolor = System.Drawing.Color.Gainsboro
        Me.deleteCourses.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.deleteCourses.BackColor = System.Drawing.Color.Gainsboro
        Me.deleteCourses.BackgroundImage = CType(resources.GetObject("deleteCourses.BackgroundImage"), System.Drawing.Image)
        Me.deleteCourses.ButtonText = "Delete "
        Me.deleteCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteCourses.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteCourses.ForeColor = System.Drawing.Color.SeaGreen
        Me.deleteCourses.IdleBorderThickness = 1
        Me.deleteCourses.IdleCornerRadius = 20
        Me.deleteCourses.IdleFillColor = System.Drawing.Color.Gainsboro
        Me.deleteCourses.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.deleteCourses.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.deleteCourses.Location = New System.Drawing.Point(528, 841)
        Me.deleteCourses.Margin = New System.Windows.Forms.Padding(5)
        Me.deleteCourses.Name = "deleteCourses"
        Me.deleteCourses.Size = New System.Drawing.Size(148, 70)
        Me.deleteCourses.TabIndex = 25
        Me.deleteCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.savebtn.Location = New System.Drawing.Point(344, 841)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(5)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(148, 70)
        Me.savebtn.TabIndex = 26
        Me.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Check a semester ............."
        '
        'courses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(916, 940)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.deleteCourses)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.depts)
        Me.Controls.Add(Me.PanelRight2)
        Me.Controls.Add(Me.qualif)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "courses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "courses"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelRight2.ResumeLayout(False)
        Me.PanelRight2.PerformLayout()
        Me.leftPanel.ResumeLayout(False)
        Me.rightPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents exitCourses As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DashbdTitle2 As Label
    Friend WithEvents qualif As Label
    Friend WithEvents PanelRight2 As Panel
    Friend WithEvents sem1Choice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sem2Choice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sem1Check As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents sem2Check As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents depts As ComboBox
    Friend WithEvents leftPanel As Panel
    Friend WithEvents rightPanel As Panel
    Friend WithEvents listbox As CheckedListBox
    Friend WithEvents listbox2 As CheckedListBox
    Friend WithEvents registerbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents deleteCourses As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents savebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
End Class
