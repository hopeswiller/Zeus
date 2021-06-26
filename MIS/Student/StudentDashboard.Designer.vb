<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDashboard))
        Me.sideMenu = New System.Windows.Forms.Panel()
        Me.homebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logoutbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.enqbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.menuSep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dashbdTitle = New System.Windows.Forms.Label()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.centerPanel2 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.classbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.RegCoursesbtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.dropCoursesbtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.gpabtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Proofbtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Recordbtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.info = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.welcomeMsg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.leftsep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.bottomsep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.topsep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.sideMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.centerPanel.SuspendLayout()
        Me.centerPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sideMenu
        '
        Me.sideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sideMenu.Controls.Add(Me.homebtn)
        Me.sideMenu.Controls.Add(Me.logoutbtn)
        Me.sideMenu.Controls.Add(Me.enqbtn)
        Me.sideMenu.Controls.Add(Me.menuSep)
        Me.sideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideMenu.Location = New System.Drawing.Point(0, 0)
        Me.sideMenu.Name = "sideMenu"
        Me.sideMenu.Size = New System.Drawing.Size(225, 750)
        Me.sideMenu.TabIndex = 0
        '
        'homebtn
        '
        Me.homebtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homebtn.BorderRadius = 7
        Me.homebtn.ButtonText = "Home"
        Me.homebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homebtn.DisabledColor = System.Drawing.Color.Gray
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.homebtn.Iconcolor = System.Drawing.Color.Transparent
        Me.homebtn.Iconimage = CType(resources.GetObject("homebtn.Iconimage"), System.Drawing.Image)
        Me.homebtn.Iconimage_right = Nothing
        Me.homebtn.Iconimage_right_Selected = Nothing
        Me.homebtn.Iconimage_Selected = Nothing
        Me.homebtn.IconMarginLeft = 0
        Me.homebtn.IconMarginRight = 0
        Me.homebtn.IconRightVisible = True
        Me.homebtn.IconRightZoom = 0R
        Me.homebtn.IconVisible = True
        Me.homebtn.IconZoom = 50.0R
        Me.homebtn.IsTab = False
        Me.homebtn.Location = New System.Drawing.Point(0, 173)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.homebtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.homebtn.OnHoverTextColor = System.Drawing.Color.White
        Me.homebtn.selected = False
        Me.homebtn.Size = New System.Drawing.Size(225, 54)
        Me.homebtn.TabIndex = 18
        Me.homebtn.Text = "Home"
        Me.homebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.homebtn.Textcolor = System.Drawing.Color.White
        Me.homebtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'logoutbtn
        '
        Me.logoutbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.logoutbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoutbtn.BorderRadius = 7
        Me.logoutbtn.ButtonText = "Logout"
        Me.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutbtn.DisabledColor = System.Drawing.Color.Gray
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.logoutbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.logoutbtn.Iconimage = CType(resources.GetObject("logoutbtn.Iconimage"), System.Drawing.Image)
        Me.logoutbtn.Iconimage_right = Nothing
        Me.logoutbtn.Iconimage_right_Selected = Nothing
        Me.logoutbtn.Iconimage_Selected = Nothing
        Me.logoutbtn.IconMarginLeft = 0
        Me.logoutbtn.IconMarginRight = 0
        Me.logoutbtn.IconRightVisible = True
        Me.logoutbtn.IconRightZoom = 0R
        Me.logoutbtn.IconVisible = True
        Me.logoutbtn.IconZoom = 80.0R
        Me.logoutbtn.IsTab = False
        Me.logoutbtn.Location = New System.Drawing.Point(0, 299)
        Me.logoutbtn.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.logoutbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.logoutbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.logoutbtn.selected = False
        Me.logoutbtn.Size = New System.Drawing.Size(225, 55)
        Me.logoutbtn.TabIndex = 16
        Me.logoutbtn.Text = "Logout"
        Me.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.logoutbtn.Textcolor = System.Drawing.Color.White
        Me.logoutbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'enqbtn
        '
        Me.enqbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.enqbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.enqbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enqbtn.BorderRadius = 7
        Me.enqbtn.ButtonText = " Enquiry"
        Me.enqbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enqbtn.DisabledColor = System.Drawing.Color.Gray
        Me.enqbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enqbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.enqbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.enqbtn.Iconimage = CType(resources.GetObject("enqbtn.Iconimage"), System.Drawing.Image)
        Me.enqbtn.Iconimage_right = Nothing
        Me.enqbtn.Iconimage_right_Selected = Nothing
        Me.enqbtn.Iconimage_Selected = Nothing
        Me.enqbtn.IconMarginLeft = 0
        Me.enqbtn.IconMarginRight = 0
        Me.enqbtn.IconRightVisible = True
        Me.enqbtn.IconRightZoom = 0R
        Me.enqbtn.IconVisible = True
        Me.enqbtn.IconZoom = 64.0R
        Me.enqbtn.IsTab = False
        Me.enqbtn.Location = New System.Drawing.Point(0, 231)
        Me.enqbtn.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.enqbtn.Name = "enqbtn"
        Me.enqbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.enqbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.enqbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.enqbtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.enqbtn.selected = False
        Me.enqbtn.Size = New System.Drawing.Size(225, 54)
        Me.enqbtn.TabIndex = 14
        Me.enqbtn.Text = " Enquiry"
        Me.enqbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.enqbtn.Textcolor = System.Drawing.Color.White
        Me.enqbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'menuSep
        '
        Me.menuSep.BackColor = System.Drawing.Color.Transparent
        Me.menuSep.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.menuSep.LineThickness = 1
        Me.menuSep.Location = New System.Drawing.Point(0, 119)
        Me.menuSep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.menuSep.Name = "menuSep"
        Me.menuSep.Size = New System.Drawing.Size(225, 43)
        Me.menuSep.TabIndex = 1
        Me.menuSep.Transparency = 255
        Me.menuSep.Vertical = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dashbdTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(225, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 58)
        Me.Panel1.TabIndex = 0
        '
        'dashbdTitle
        '
        Me.dashbdTitle.AutoSize = True
        Me.dashbdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashbdTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.dashbdTitle.Location = New System.Drawing.Point(19, 9)
        Me.dashbdTitle.Name = "dashbdTitle"
        Me.dashbdTitle.Size = New System.Drawing.Size(445, 29)
        Me.dashbdTitle.TabIndex = 1
        Me.dashbdTitle.Text = "Student Dashboard - Univeristy of Ghana"
        '
        'centerPanel
        '
        Me.centerPanel.Controls.Add(Me.centerPanel2)
        Me.centerPanel.Controls.Add(Me.leftsep)
        Me.centerPanel.Controls.Add(Me.bottomsep)
        Me.centerPanel.Controls.Add(Me.topsep)
        Me.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.centerPanel.Location = New System.Drawing.Point(225, 58)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(1010, 692)
        Me.centerPanel.TabIndex = 1
        '
        'centerPanel2
        '
        Me.centerPanel2.Controls.Add(Me.Panel2)
        Me.centerPanel2.Controls.Add(Me.info)
        Me.centerPanel2.Controls.Add(Me.welcomeMsg)
        Me.centerPanel2.Location = New System.Drawing.Point(45, 34)
        Me.centerPanel2.Name = "centerPanel2"
        Me.centerPanel2.Size = New System.Drawing.Size(956, 614)
        Me.centerPanel2.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.classbtn)
        Me.Panel2.Controls.Add(Me.RegCoursesbtn)
        Me.Panel2.Controls.Add(Me.dropCoursesbtn)
        Me.Panel2.Controls.Add(Me.gpabtn)
        Me.Panel2.Controls.Add(Me.Proofbtn)
        Me.Panel2.Controls.Add(Me.Recordbtn)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(942, 618)
        Me.Panel2.TabIndex = 7
        '
        'classbtn
        '
        Me.classbtn.ActiveBorderThickness = 1
        Me.classbtn.ActiveCornerRadius = 50
        Me.classbtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.classbtn.ActiveForecolor = System.Drawing.Color.Gainsboro
        Me.classbtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.classbtn.BackColor = System.Drawing.Color.Gainsboro
        Me.classbtn.BackgroundImage = CType(resources.GetObject("classbtn.BackgroundImage"), System.Drawing.Image)
        Me.classbtn.ButtonText = "Class Classification"
        Me.classbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.classbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classbtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.classbtn.IdleBorderThickness = 1
        Me.classbtn.IdleCornerRadius = 50
        Me.classbtn.IdleFillColor = System.Drawing.Color.Gainsboro
        Me.classbtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.classbtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.classbtn.Location = New System.Drawing.Point(20, 504)
        Me.classbtn.Margin = New System.Windows.Forms.Padding(5)
        Me.classbtn.Name = "classbtn"
        Me.classbtn.Size = New System.Drawing.Size(851, 79)
        Me.classbtn.TabIndex = 7
        Me.classbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegCoursesbtn
        '
        Me.RegCoursesbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.RegCoursesbtn.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.RegCoursesbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.RegCoursesbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegCoursesbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegCoursesbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.RegCoursesbtn.Image = CType(resources.GetObject("RegCoursesbtn.Image"), System.Drawing.Image)
        Me.RegCoursesbtn.ImagePosition = 14
        Me.RegCoursesbtn.ImageZoom = 50
        Me.RegCoursesbtn.LabelPosition = 29
        Me.RegCoursesbtn.LabelText = "Register Courses"
        Me.RegCoursesbtn.Location = New System.Drawing.Point(472, 275)
        Me.RegCoursesbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RegCoursesbtn.Name = "RegCoursesbtn"
        Me.RegCoursesbtn.Size = New System.Drawing.Size(267, 177)
        Me.RegCoursesbtn.TabIndex = 5
        '
        'dropCoursesbtn
        '
        Me.dropCoursesbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dropCoursesbtn.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dropCoursesbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.dropCoursesbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dropCoursesbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropCoursesbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.dropCoursesbtn.Image = CType(resources.GetObject("dropCoursesbtn.Image"), System.Drawing.Image)
        Me.dropCoursesbtn.ImagePosition = 14
        Me.dropCoursesbtn.ImageZoom = 50
        Me.dropCoursesbtn.LabelPosition = 29
        Me.dropCoursesbtn.LabelText = "Drop course"
        Me.dropCoursesbtn.Location = New System.Drawing.Point(128, 275)
        Me.dropCoursesbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dropCoursesbtn.Name = "dropCoursesbtn"
        Me.dropCoursesbtn.Size = New System.Drawing.Size(267, 177)
        Me.dropCoursesbtn.TabIndex = 4
        '
        'gpabtn
        '
        Me.gpabtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.gpabtn.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.gpabtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.gpabtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gpabtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpabtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.gpabtn.Image = CType(resources.GetObject("gpabtn.Image"), System.Drawing.Image)
        Me.gpabtn.ImagePosition = 14
        Me.gpabtn.ImageZoom = 50
        Me.gpabtn.LabelPosition = 29
        Me.gpabtn.LabelText = "Calculate GPA"
        Me.gpabtn.Location = New System.Drawing.Point(12, 40)
        Me.gpabtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpabtn.Name = "gpabtn"
        Me.gpabtn.Size = New System.Drawing.Size(267, 177)
        Me.gpabtn.TabIndex = 3
        '
        'Proofbtn
        '
        Me.Proofbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Proofbtn.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Proofbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Proofbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Proofbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proofbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Proofbtn.Image = CType(resources.GetObject("Proofbtn.Image"), System.Drawing.Image)
        Me.Proofbtn.ImagePosition = 14
        Me.Proofbtn.ImageZoom = 50
        Me.Proofbtn.LabelPosition = 29
        Me.Proofbtn.LabelText = "Registration"
        Me.Proofbtn.Location = New System.Drawing.Point(588, 40)
        Me.Proofbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Proofbtn.Name = "Proofbtn"
        Me.Proofbtn.Size = New System.Drawing.Size(267, 177)
        Me.Proofbtn.TabIndex = 2
        '
        'Recordbtn
        '
        Me.Recordbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Recordbtn.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Recordbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Recordbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Recordbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recordbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Recordbtn.Image = CType(resources.GetObject("Recordbtn.Image"), System.Drawing.Image)
        Me.Recordbtn.ImagePosition = 14
        Me.Recordbtn.ImageZoom = 50
        Me.Recordbtn.LabelPosition = 29
        Me.Recordbtn.LabelText = "Academic Record"
        Me.Recordbtn.Location = New System.Drawing.Point(306, 40)
        Me.Recordbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Recordbtn.Name = "Recordbtn"
        Me.Recordbtn.Size = New System.Drawing.Size(267, 177)
        Me.Recordbtn.TabIndex = 1
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.info.Location = New System.Drawing.Point(123, 111)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(0, 29)
        Me.info.TabIndex = 4
        '
        'welcomeMsg
        '
        Me.welcomeMsg.AutoSize = True
        Me.welcomeMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.welcomeMsg.Location = New System.Drawing.Point(286, 27)
        Me.welcomeMsg.Name = "welcomeMsg"
        Me.welcomeMsg.Size = New System.Drawing.Size(363, 38)
        Me.welcomeMsg.TabIndex = 0
        Me.welcomeMsg.Text = "Welcome, Dear Student"
        '
        'leftsep
        '
        Me.leftsep.BackColor = System.Drawing.Color.Transparent
        Me.leftsep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.leftsep.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.leftsep.LineThickness = 1
        Me.leftsep.Location = New System.Drawing.Point(6, 34)
        Me.leftsep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.leftsep.Name = "leftsep"
        Me.leftsep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.leftsep.Size = New System.Drawing.Size(50, 621)
        Me.leftsep.TabIndex = 3
        Me.leftsep.Transparency = 255
        Me.leftsep.Vertical = True
        '
        'bottomsep
        '
        Me.bottomsep.BackColor = System.Drawing.Color.Transparent
        Me.bottomsep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.bottomsep.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bottomsep.LineThickness = 1
        Me.bottomsep.Location = New System.Drawing.Point(7, 636)
        Me.bottomsep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bottomsep.Name = "bottomsep"
        Me.bottomsep.Size = New System.Drawing.Size(1063, 43)
        Me.bottomsep.TabIndex = 2
        Me.bottomsep.Transparency = 255
        Me.bottomsep.Vertical = False
        '
        'topsep
        '
        Me.topsep.BackColor = System.Drawing.Color.Transparent
        Me.topsep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.topsep.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.topsep.LineThickness = 1
        Me.topsep.Location = New System.Drawing.Point(8, 7)
        Me.topsep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.topsep.Name = "topsep"
        Me.topsep.Size = New System.Drawing.Size(1063, 43)
        Me.topsep.TabIndex = 1
        Me.topsep.Transparency = 255
        Me.topsep.Vertical = False
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1235, 750)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentDashboard"
        Me.sideMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.centerPanel.ResumeLayout(False)
        Me.centerPanel2.ResumeLayout(False)
        Me.centerPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sideMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents menuSep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents dashbdTitle As Label
    Friend WithEvents centerPanel As Panel

    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents enqbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logoutbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents welcomeMsg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents leftsep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents bottomsep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents topsep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents centerPanel2 As Panel
    Friend WithEvents info As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents homebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RegCoursesbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents dropCoursesbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Proofbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Recordbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents classbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents gpabtn As Bunifu.Framework.UI.BunifuTileButton
End Class
