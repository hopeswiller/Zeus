<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.leftsep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.topsep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.info = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.welcomeMsg = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.classList = New Bunifu.Framework.UI.BunifuTileButton()
        Me.AddGradesbtn = New Bunifu.Framework.UI.BunifuTileButton()
        Me.crshandling = New Bunifu.Framework.UI.BunifuTileButton()
        Me.centerPanel2 = New System.Windows.Forms.Panel()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.bottomsep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dashbdTitle = New System.Windows.Forms.Label()
        Me.menuSep = New Bunifu.Framework.UI.BunifuSeparator()
        Me.homebtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logoutbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.enqbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.sideMenu = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.centerPanel2.SuspendLayout()
        Me.centerPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.sideMenu.SuspendLayout()
        Me.SuspendLayout()
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
        'topsep
        '
        Me.topsep.BackColor = System.Drawing.Color.Transparent
        Me.topsep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.topsep.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.topsep.LineThickness = 1
        Me.topsep.Location = New System.Drawing.Point(7, 7)
        Me.topsep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.topsep.Name = "topsep"
        Me.topsep.Size = New System.Drawing.Size(945, 43)
        Me.topsep.TabIndex = 1
        Me.topsep.Transparency = 255
        Me.topsep.Vertical = False
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
        Me.welcomeMsg.Location = New System.Drawing.Point(208, 32)
        Me.welcomeMsg.Name = "welcomeMsg"
        Me.welcomeMsg.Size = New System.Drawing.Size(171, 38)
        Me.welcomeMsg.TabIndex = 0
        Me.welcomeMsg.Text = "Welcome, "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(36, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 615)
        Me.Panel2.TabIndex = 7
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.classList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AddGradesbtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.crshandling, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(85, 58)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(785, 496)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'classList
        '
        Me.classList.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.classList.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.classList.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.classList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.classList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.classList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classList.ForeColor = System.Drawing.Color.Gainsboro
        Me.classList.Image = CType(resources.GetObject("classList.Image"), System.Drawing.Image)
        Me.classList.ImagePosition = 14
        Me.classList.ImageZoom = 50
        Me.classList.LabelPosition = 29
        Me.classList.LabelText = "Class List"
        Me.classList.Location = New System.Drawing.Point(4, 252)
        Me.classList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.classList.Name = "classList"
        Me.classList.Size = New System.Drawing.Size(384, 240)
        Me.classList.TabIndex = 6
        '
        'AddGradesbtn
        '
        Me.AddGradesbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.AddGradesbtn.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.AddGradesbtn.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.AddGradesbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddGradesbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddGradesbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddGradesbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.AddGradesbtn.Image = CType(resources.GetObject("AddGradesbtn.Image"), System.Drawing.Image)
        Me.AddGradesbtn.ImagePosition = 14
        Me.AddGradesbtn.ImageZoom = 50
        Me.AddGradesbtn.LabelPosition = 29
        Me.AddGradesbtn.LabelText = "Add Grades"
        Me.AddGradesbtn.Location = New System.Drawing.Point(4, 4)
        Me.AddGradesbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddGradesbtn.Name = "AddGradesbtn"
        Me.AddGradesbtn.Size = New System.Drawing.Size(384, 240)
        Me.AddGradesbtn.TabIndex = 5
        '
        'crshandling
        '
        Me.crshandling.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.crshandling.color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.crshandling.colorActive = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.crshandling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.crshandling.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crshandling.ForeColor = System.Drawing.Color.Gainsboro
        Me.crshandling.Image = CType(resources.GetObject("crshandling.Image"), System.Drawing.Image)
        Me.crshandling.ImagePosition = 14
        Me.crshandling.ImageZoom = 50
        Me.crshandling.LabelPosition = 29
        Me.crshandling.LabelText = "Course Handling"
        Me.crshandling.Location = New System.Drawing.Point(396, 4)
        Me.crshandling.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.crshandling.Name = "crshandling"
        Me.crshandling.Size = New System.Drawing.Size(385, 240)
        Me.crshandling.TabIndex = 7
        '
        'centerPanel2
        '
        Me.centerPanel2.Controls.Add(Me.info)
        Me.centerPanel2.Controls.Add(Me.welcomeMsg)
        Me.centerPanel2.Location = New System.Drawing.Point(36, 34)
        Me.centerPanel2.Name = "centerPanel2"
        Me.centerPanel2.Size = New System.Drawing.Size(916, 621)
        Me.centerPanel2.TabIndex = 5
        '
        'centerPanel
        '
        Me.centerPanel.Controls.Add(Me.Panel2)
        Me.centerPanel.Controls.Add(Me.centerPanel2)
        Me.centerPanel.Controls.Add(Me.leftsep)
        Me.centerPanel.Controls.Add(Me.bottomsep)
        Me.centerPanel.Controls.Add(Me.topsep)
        Me.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.centerPanel.Location = New System.Drawing.Point(225, 58)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(984, 692)
        Me.centerPanel.TabIndex = 4
        '
        'bottomsep
        '
        Me.bottomsep.BackColor = System.Drawing.Color.Transparent
        Me.bottomsep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.bottomsep.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bottomsep.LineThickness = 1
        Me.bottomsep.Location = New System.Drawing.Point(7, 643)
        Me.bottomsep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bottomsep.Name = "bottomsep"
        Me.bottomsep.Size = New System.Drawing.Size(945, 43)
        Me.bottomsep.TabIndex = 2
        Me.bottomsep.Transparency = 255
        Me.bottomsep.Vertical = False
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
        Me.Panel1.Size = New System.Drawing.Size(984, 58)
        Me.Panel1.TabIndex = 2
        '
        'dashbdTitle
        '
        Me.dashbdTitle.AutoSize = True
        Me.dashbdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashbdTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.dashbdTitle.Location = New System.Drawing.Point(19, 9)
        Me.dashbdTitle.Name = "dashbdTitle"
        Me.dashbdTitle.Size = New System.Drawing.Size(416, 29)
        Me.dashbdTitle.TabIndex = 1
        Me.dashbdTitle.Text = "Staff Dashboard - University  of Ghana"
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
        Me.logoutbtn.Location = New System.Drawing.Point(0, 289)
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
        Me.enqbtn.ButtonText = "Results Entry"
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
        Me.enqbtn.Location = New System.Drawing.Point(0, 232)
        Me.enqbtn.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.enqbtn.Name = "enqbtn"
        Me.enqbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.enqbtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.enqbtn.OnHoverTextColor = System.Drawing.Color.White
        Me.enqbtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.enqbtn.selected = False
        Me.enqbtn.Size = New System.Drawing.Size(225, 54)
        Me.enqbtn.TabIndex = 14
        Me.enqbtn.Text = "Results Entry"
        Me.enqbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.enqbtn.Textcolor = System.Drawing.Color.White
        Me.enqbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.sideMenu.TabIndex = 3
        '
        'Staff
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1209, 750)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sideMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.centerPanel2.ResumeLayout(False)
        Me.centerPanel2.PerformLayout()
        Me.centerPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.sideMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftsep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents topsep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents info As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents welcomeMsg As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddGradesbtn As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents centerPanel2 As Panel
    Friend WithEvents centerPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashbdTitle As Label
    Friend WithEvents menuSep As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents homebtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logoutbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents enqbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sideMenu As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents crshandling As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents classList As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents bottomsep As Bunifu.Framework.UI.BunifuSeparator
End Class
