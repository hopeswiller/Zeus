<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstPage))
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.closeApp = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.sep2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.getStat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.Desc = New System.Windows.Forms.Label()
        Me.LabelStat = New System.Windows.Forms.Label()
        Me.welcome = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.sep1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.sep3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRight.SuspendLayout()
        Me.PanelCenter.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelRight.Controls.Add(Me.Label1)
        Me.PanelRight.Controls.Add(Me.PictureBox1)
        Me.PanelRight.Controls.Add(Me.closeApp)
        Me.PanelRight.Controls.Add(Me.sep2)
        Me.PanelRight.Controls.Add(Me.getStat)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(682, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(358, 686)
        Me.PanelRight.TabIndex = 0
        '
        'closeApp
        '
        Me.closeApp.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.closeApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.closeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.closeApp.BorderRadius = 7
        Me.closeApp.ButtonText = "Close Application"
        Me.closeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeApp.DisabledColor = System.Drawing.Color.Gray
        Me.closeApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.closeApp.Iconcolor = System.Drawing.Color.Transparent
        Me.closeApp.Iconimage = CType(resources.GetObject("closeApp.Iconimage"), System.Drawing.Image)
        Me.closeApp.Iconimage_right = Nothing
        Me.closeApp.Iconimage_right_Selected = Nothing
        Me.closeApp.Iconimage_Selected = Nothing
        Me.closeApp.IconMarginLeft = 0
        Me.closeApp.IconMarginRight = 0
        Me.closeApp.IconRightVisible = True
        Me.closeApp.IconRightZoom = 0R
        Me.closeApp.IconVisible = False
        Me.closeApp.IconZoom = 90.0R
        Me.closeApp.IsTab = False
        Me.closeApp.Location = New System.Drawing.Point(72, 520)
        Me.closeApp.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.closeApp.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.closeApp.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.closeApp.selected = False
        Me.closeApp.Size = New System.Drawing.Size(219, 51)
        Me.closeApp.TabIndex = 2
        Me.closeApp.Text = "Close Application"
        Me.closeApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.closeApp.Textcolor = System.Drawing.Color.Gainsboro
        Me.closeApp.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'sep2
        '
        Me.sep2.BackColor = System.Drawing.Color.Transparent
        Me.sep2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sep2.LineColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sep2.LineThickness = 1
        Me.sep2.Location = New System.Drawing.Point(11, 291)
        Me.sep2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sep2.Name = "sep2"
        Me.sep2.Size = New System.Drawing.Size(334, 38)
        Me.sep2.TabIndex = 1
        Me.sep2.Transparency = 255
        Me.sep2.Vertical = False
        '
        'getStat
        '
        Me.getStat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.getStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.getStat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.getStat.BorderRadius = 7
        Me.getStat.ButtonText = "Get Started"
        Me.getStat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.getStat.DisabledColor = System.Drawing.Color.Gray
        Me.getStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.getStat.Iconcolor = System.Drawing.Color.Transparent
        Me.getStat.Iconimage = CType(resources.GetObject("getStat.Iconimage"), System.Drawing.Image)
        Me.getStat.Iconimage_right = Nothing
        Me.getStat.Iconimage_right_Selected = Nothing
        Me.getStat.Iconimage_Selected = Nothing
        Me.getStat.IconMarginLeft = 0
        Me.getStat.IconMarginRight = 0
        Me.getStat.IconRightVisible = True
        Me.getStat.IconRightZoom = 0R
        Me.getStat.IconVisible = True
        Me.getStat.IconZoom = 90.0R
        Me.getStat.IsTab = False
        Me.getStat.Location = New System.Drawing.Point(72, 434)
        Me.getStat.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.getStat.Name = "getStat"
        Me.getStat.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.getStat.OnHovercolor = System.Drawing.Color.Gainsboro
        Me.getStat.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.getStat.selected = False
        Me.getStat.Size = New System.Drawing.Size(219, 51)
        Me.getStat.TabIndex = 1
        Me.getStat.Text = "Get Started"
        Me.getStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.getStat.Textcolor = System.Drawing.Color.Gainsboro
        Me.getStat.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelTop
        '
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(682, 75)
        Me.PanelTop.TabIndex = 1
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.Desc)
        Me.PanelCenter.Controls.Add(Me.LabelStat)
        Me.PanelCenter.Controls.Add(Me.welcome)
        Me.PanelCenter.Location = New System.Drawing.Point(56, 127)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(532, 461)
        Me.PanelCenter.TabIndex = 3
        '
        'Desc
        '
        Me.Desc.AutoSize = True
        Me.Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc.ForeColor = System.Drawing.Color.Gainsboro
        Me.Desc.Location = New System.Drawing.Point(10, 89)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(514, 240)
        Me.Desc.TabIndex = 13
        Me.Desc.Text = resources.GetString("Desc.Text")
        '
        'LabelStat
        '
        Me.LabelStat.AutoSize = True
        Me.LabelStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStat.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelStat.Location = New System.Drawing.Point(10, 381)
        Me.LabelStat.Name = "LabelStat"
        Me.LabelStat.Size = New System.Drawing.Size(242, 20)
        Me.LabelStat.TabIndex = 12
        Me.LabelStat.Text = "Get Started As Student or Staff"
        '
        'welcome
        '
        Me.welcome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.ForeColor = System.Drawing.Color.Gainsboro
        Me.welcome.HintForeColor = System.Drawing.Color.Gainsboro
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
        'sep1
        '
        Me.sep1.BackColor = System.Drawing.Color.Transparent
        Me.sep1.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.sep1.LineThickness = 2
        Me.sep1.Location = New System.Drawing.Point(6, 82)
        Me.sep1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(613, 38)
        Me.sep1.TabIndex = 2
        Me.sep1.Transparency = 255
        Me.sep1.Vertical = False
        '
        'sep3
        '
        Me.sep3.BackColor = System.Drawing.Color.Transparent
        Me.sep3.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.sep3.LineThickness = 2
        Me.sep3.Location = New System.Drawing.Point(19, 127)
        Me.sep3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sep3.Name = "sep3"
        Me.sep3.Size = New System.Drawing.Size(30, 488)
        Me.sep3.TabIndex = 4
        Me.sep3.Transparency = 255
        Me.sep3.Vertical = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 238)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(52, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "developed by the Zeus"
        '
        'FirstPage
        '
        Me.AccessibleDescription = "FirstPage"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 686)
        Me.Controls.Add(Me.sep3)
        Me.Controls.Add(Me.sep1)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FirstPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FirstPage"
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.PanelCenter.ResumeLayout(False)
        Me.PanelCenter.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelRight As Panel
    Friend WithEvents getStat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents sep2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelCenter As Panel
    Friend WithEvents sep1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents welcome As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents sep3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents closeApp As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LabelStat As Label
    Friend WithEvents Desc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
