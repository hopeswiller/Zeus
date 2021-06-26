<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.PanelRight2 = New System.Windows.Forms.Panel()
        Me.stuChoice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.stafChoice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.stuCheck = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.stafCheck = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.IDnum = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.forgotPin = New System.Windows.Forms.Label()
        Me.backbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.sep2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.loginbtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PicZeus = New System.Windows.Forms.PictureBox()
        Me.sep3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.sep1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.Desc = New System.Windows.Forms.Label()
        Me.LabelAcct = New System.Windows.Forms.Label()
        Me.welcome = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PanelRight.SuspendLayout()
        Me.PanelRight2.SuspendLayout()
        CType(Me.PicZeus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCenter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelRight.Controls.Add(Me.PanelRight2)
        Me.PanelRight.Controls.Add(Me.Pass)
        Me.PanelRight.Controls.Add(Me.IDnum)
        Me.PanelRight.Controls.Add(Me.forgotPin)
        Me.PanelRight.Controls.Add(Me.backbtn)
        Me.PanelRight.Controls.Add(Me.sep2)
        Me.PanelRight.Controls.Add(Me.loginbtn)
        Me.PanelRight.Controls.Add(Me.PicZeus)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(626, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(358, 640)
        Me.PanelRight.TabIndex = 2
        '
        'PanelRight2
        '
        Me.PanelRight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRight2.Controls.Add(Me.stuChoice)
        Me.PanelRight2.Controls.Add(Me.stafChoice)
        Me.PanelRight2.Controls.Add(Me.stuCheck)
        Me.PanelRight2.Controls.Add(Me.stafCheck)
        Me.PanelRight2.Location = New System.Drawing.Point(58, 186)
        Me.PanelRight2.Name = "PanelRight2"
        Me.PanelRight2.Size = New System.Drawing.Size(249, 69)
        Me.PanelRight2.TabIndex = 21
        '
        'stuChoice
        '
        Me.stuChoice.AutoSize = True
        Me.stuChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stuChoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.stuChoice.Location = New System.Drawing.Point(61, 25)
        Me.stuChoice.Name = "stuChoice"
        Me.stuChoice.Size = New System.Drawing.Size(66, 20)
        Me.stuChoice.TabIndex = 19
        Me.stuChoice.Text = "Student"
        '
        'stafChoice
        '
        Me.stafChoice.AutoSize = True
        Me.stafChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stafChoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.stafChoice.Location = New System.Drawing.Point(182, 25)
        Me.stafChoice.Name = "stafChoice"
        Me.stafChoice.Size = New System.Drawing.Size(44, 20)
        Me.stafChoice.TabIndex = 20
        Me.stafChoice.Text = "Staff"
        '
        'stuCheck
        '
        Me.stuCheck.BackColor = System.Drawing.Color.White
        Me.stuCheck.ChechedOffColor = System.Drawing.Color.White
        Me.stuCheck.Checked = False
        Me.stuCheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.stuCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.stuCheck.Location = New System.Drawing.Point(34, 25)
        Me.stuCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stuCheck.Name = "stuCheck"
        Me.stuCheck.Size = New System.Drawing.Size(20, 20)
        Me.stuCheck.TabIndex = 17
        '
        'stafCheck
        '
        Me.stafCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.stafCheck.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.stafCheck.Checked = False
        Me.stafCheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.stafCheck.ForeColor = System.Drawing.Color.Gainsboro
        Me.stafCheck.Location = New System.Drawing.Point(155, 25)
        Me.stafCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stafCheck.Name = "stafCheck"
        Me.stafCheck.Size = New System.Drawing.Size(20, 20)
        Me.stafCheck.TabIndex = 18
        '
        'Pass
        '
        Me.Pass.AccessibleDescription = "Pass"
        Me.Pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Pass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Pass.HintText = "Password"
        Me.Pass.isPassword = True
        Me.Pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Pass.LineIdleColor = System.Drawing.Color.Gray
        Me.Pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Pass.LineThickness = 3
        Me.Pass.Location = New System.Drawing.Point(28, 336)
        Me.Pass.Margin = New System.Windows.Forms.Padding(4)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(308, 50)
        Me.Pass.TabIndex = 16
        Me.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'IDnum
        '
        Me.IDnum.AccessibleDescription = "IDnum"
        Me.IDnum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDnum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.IDnum.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.IDnum.HintText = "ID Number"
        Me.IDnum.isPassword = False
        Me.IDnum.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.IDnum.LineIdleColor = System.Drawing.Color.Gray
        Me.IDnum.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.IDnum.LineThickness = 4
        Me.IDnum.Location = New System.Drawing.Point(28, 262)
        Me.IDnum.Margin = New System.Windows.Forms.Padding(4)
        Me.IDnum.Name = "IDnum"
        Me.IDnum.Size = New System.Drawing.Size(308, 50)
        Me.IDnum.TabIndex = 1
        Me.IDnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'forgotPin
        '
        Me.forgotPin.AutoSize = True
        Me.forgotPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.forgotPin.Location = New System.Drawing.Point(129, 406)
        Me.forgotPin.Name = "forgotPin"
        Me.forgotPin.Size = New System.Drawing.Size(103, 20)
        Me.forgotPin.TabIndex = 14
        Me.forgotPin.Text = "Forgot PIN ?"
        '
        'backbtn
        '
        Me.backbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.backbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backbtn.BorderRadius = 7
        Me.backbtn.ButtonText = "GO BACK"
        Me.backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backbtn.DisabledColor = System.Drawing.Color.Gray
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.backbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.backbtn.Iconimage = CType(resources.GetObject("backbtn.Iconimage"), System.Drawing.Image)
        Me.backbtn.Iconimage_right = Nothing
        Me.backbtn.Iconimage_right_Selected = Nothing
        Me.backbtn.Iconimage_Selected = Nothing
        Me.backbtn.IconMarginLeft = 0
        Me.backbtn.IconMarginRight = 0
        Me.backbtn.IconRightVisible = True
        Me.backbtn.IconRightZoom = 0R
        Me.backbtn.IconVisible = False
        Me.backbtn.IconZoom = 90.0R
        Me.backbtn.IsTab = False
        Me.backbtn.Location = New System.Drawing.Point(72, 537)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.backbtn.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.backbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.backbtn.selected = False
        Me.backbtn.Size = New System.Drawing.Size(219, 51)
        Me.backbtn.TabIndex = 2
        Me.backbtn.Text = "GO BACK"
        Me.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.backbtn.Textcolor = System.Drawing.Color.Gainsboro
        Me.backbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'sep2
        '
        Me.sep2.BackColor = System.Drawing.Color.Transparent
        Me.sep2.LineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sep2.LineThickness = 1
        Me.sep2.Location = New System.Drawing.Point(11, 141)
        Me.sep2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(334, 38)
        Me.sep2.TabIndex = 1
        Me.sep2.Transparency = 255
        Me.sep2.Vertical = False
        '
        'loginbtn
        '
        Me.loginbtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginbtn.BorderRadius = 7
        Me.loginbtn.ButtonText = "LOGIN"
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.DisabledColor = System.Drawing.Color.Gray
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.loginbtn.Iconcolor = System.Drawing.Color.Transparent
        Me.loginbtn.Iconimage = Nothing
        Me.loginbtn.Iconimage_right = Nothing
        Me.loginbtn.Iconimage_right_Selected = Nothing
        Me.loginbtn.Iconimage_Selected = Nothing
        Me.loginbtn.IconMarginLeft = 0
        Me.loginbtn.IconMarginRight = 0
        Me.loginbtn.IconRightVisible = True
        Me.loginbtn.IconRightZoom = 0R
        Me.loginbtn.IconVisible = True
        Me.loginbtn.IconZoom = 90.0R
        Me.loginbtn.IsTab = False
        Me.loginbtn.Location = New System.Drawing.Point(72, 456)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.loginbtn.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.loginbtn.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.loginbtn.selected = False
        Me.loginbtn.Size = New System.Drawing.Size(219, 51)
        Me.loginbtn.TabIndex = 3
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginbtn.Textcolor = System.Drawing.Color.Gainsboro
        Me.loginbtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PicZeus
        '
        Me.PicZeus.AccessibleDescription = "PicZeus"
        Me.PicZeus.BackgroundImage = CType(resources.GetObject("PicZeus.BackgroundImage"), System.Drawing.Image)
        Me.PicZeus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicZeus.Location = New System.Drawing.Point(58, 12)
        Me.PicZeus.Name = "PicZeus"
        Me.PicZeus.Size = New System.Drawing.Size(249, 112)
        Me.PicZeus.TabIndex = 1
        Me.PicZeus.TabStop = False
        '
        'sep3
        '
        Me.sep3.BackColor = System.Drawing.Color.Transparent
        Me.sep3.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.sep3.LineThickness = 2
        Me.sep3.Location = New System.Drawing.Point(19, 127)
        Me.sep3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(30, 461)
        Me.sep3.TabIndex = 9
        Me.sep3.Transparency = 255
        Me.sep3.Vertical = True
        '
        'sep1
        '
        Me.sep1.BackColor = System.Drawing.Color.Transparent
        Me.sep1.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.sep1.LineThickness = 2
        Me.sep1.Location = New System.Drawing.Point(6, 82)
        Me.sep1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(613, 38)
        Me.sep1.TabIndex = 7
        Me.sep1.Transparency = 255
        Me.sep1.Vertical = False
        '
        'PanelTop
        '
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(626, 75)
        Me.PanelTop.TabIndex = 10
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.Desc)
        Me.PanelCenter.Controls.Add(Me.LabelAcct)
        Me.PanelCenter.Controls.Add(Me.welcome)
        Me.PanelCenter.Location = New System.Drawing.Point(56, 127)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(499, 444)
        Me.PanelCenter.TabIndex = 11
        '
        'Desc
        '
        Me.Desc.AutoSize = True
        Me.Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc.ForeColor = System.Drawing.Color.Gainsboro
        Me.Desc.Location = New System.Drawing.Point(14, 102)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(471, 200)
        Me.Desc.TabIndex = 14
        Me.Desc.Text = resources.GetString("Desc.Text")
        '
        'LabelAcct
        '
        Me.LabelAcct.AutoSize = True
        Me.LabelAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAcct.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelAcct.Location = New System.Drawing.Point(10, 381)
        Me.LabelAcct.Name = "LabelAcct"
        Me.LabelAcct.Size = New System.Drawing.Size(183, 20)
        Me.LabelAcct.TabIndex = 12
        Me.LabelAcct.Text = "Login into your account"
        '
        'welcome
        '
        Me.welcome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.ForeColor = System.Drawing.Color.Gainsboro
        Me.welcome.HintForeColor = System.Drawing.Color.Empty
        Me.welcome.HintText = ""
        Me.welcome.isPassword = False
        Me.welcome.LineFocusedColor = System.Drawing.Color.Gainsboro
        Me.welcome.LineIdleColor = System.Drawing.Color.Gray
        Me.welcome.LineMouseHoverColor = System.Drawing.Color.Gainsboro
        Me.welcome.LineThickness = 3
        Me.welcome.Location = New System.Drawing.Point(14, 14)
        Me.welcome.Margin = New System.Windows.Forms.Padding(7, 7, 7, 2)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(474, 57)
        Me.welcome.TabIndex = 10
        Me.welcome.Text = "Welcome, MIS Platform"
        Me.welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 640)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.sep3)
        Me.Controls.Add(Me.sep1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.PanelRight2.ResumeLayout(False)
        Me.PanelRight2.PerformLayout()
        CType(Me.PicZeus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCenter.ResumeLayout(False)
        Me.PanelCenter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRight As Panel
    Friend WithEvents backbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sep2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents loginbtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PicZeus As PictureBox
    Friend WithEvents sep3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents sep1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PanelTop As Panel
    Friend WithEvents forgotPin As Label
    Friend WithEvents IDnum As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PanelCenter As Panel
    Friend WithEvents LabelAcct As Label
    Friend WithEvents welcome As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents stuCheck As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents stuChoice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents stafCheck As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents PanelRight2 As Panel
    Friend WithEvents stafChoice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Desc As Label
End Class
