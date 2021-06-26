<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddGrades))
        Me.dashbdTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitgrades = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.crsdropdwn = New System.Windows.Forms.ComboBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.gradeWel = New System.Windows.Forms.Label()
        Me.sndGrades = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dashbdTitle
        '
        Me.dashbdTitle.AutoSize = True
        Me.dashbdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashbdTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.dashbdTitle.Location = New System.Drawing.Point(19, 9)
        Me.dashbdTitle.Name = "dashbdTitle"
        Me.dashbdTitle.Size = New System.Drawing.Size(410, 29)
        Me.dashbdTitle.TabIndex = 1
        Me.dashbdTitle.Text = "Staff Dashboard - Univeristy of Ghana"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.exitgrades)
        Me.Panel1.Controls.Add(Me.dashbdTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 58)
        Me.Panel1.TabIndex = 5
        '
        'exitgrades
        '
        Me.exitgrades.BackColor = System.Drawing.Color.Transparent
        Me.exitgrades.color = System.Drawing.Color.Transparent
        Me.exitgrades.colorActive = System.Drawing.Color.Transparent
        Me.exitgrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitgrades.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.exitgrades.ForeColor = System.Drawing.Color.White
        Me.exitgrades.Image = CType(resources.GetObject("exitgrades.Image"), System.Drawing.Image)
        Me.exitgrades.ImagePosition = 0
        Me.exitgrades.ImageZoom = 50
        Me.exitgrades.LabelPosition = 0
        Me.exitgrades.LabelText = ""
        Me.exitgrades.Location = New System.Drawing.Point(729, 6)
        Me.exitgrades.Margin = New System.Windows.Forms.Padding(6)
        Me.exitgrades.Name = "exitgrades"
        Me.exitgrades.Size = New System.Drawing.Size(82, 43)
        Me.exitgrades.TabIndex = 26
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.crsdropdwn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gradeWel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.sndGrades)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(802, 887)
        Me.SplitContainer1.SplitterDistance = 173
        Me.SplitContainer1.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(332, 635)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(161, 31)
        Me.TextBox3.TabIndex = 36
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(332, 544)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(161, 31)
        Me.TextBox4.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(332, 448)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 31)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(332, 363)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 31)
        Me.TextBox1.TabIndex = 33
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(62, 306)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(455, 33)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.Text = "choose an ID"
        '
        'crsdropdwn
        '
        Me.crsdropdwn.BackColor = System.Drawing.Color.Gainsboro
        Me.crsdropdwn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crsdropdwn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.crsdropdwn.FormattingEnabled = True
        Me.crsdropdwn.Location = New System.Drawing.Point(62, 245)
        Me.crsdropdwn.Name = "crsdropdwn"
        Me.crsdropdwn.Size = New System.Drawing.Size(455, 33)
        Me.crsdropdwn.TabIndex = 31
        Me.crsdropdwn.Text = "select a course you teach"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(7, 196)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(604, 42)
        Me.BunifuSeparator1.TabIndex = 30
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'gradeWel
        '
        Me.gradeWel.AutoSize = True
        Me.gradeWel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gradeWel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeWel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.gradeWel.Location = New System.Drawing.Point(62, 16)
        Me.gradeWel.Name = "gradeWel"
        Me.gradeWel.Size = New System.Drawing.Size(491, 176)
        Me.gradeWel.TabIndex = 2
        Me.gradeWel.Text = resources.GetString("gradeWel.Text")
        '
        'sndGrades
        '
        Me.sndGrades.Activecolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sndGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sndGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sndGrades.BorderRadius = 7
        Me.sndGrades.ButtonText = "Send Grades"
        Me.sndGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sndGrades.DisabledColor = System.Drawing.Color.Gray
        Me.sndGrades.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sndGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sndGrades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.sndGrades.Iconcolor = System.Drawing.Color.Transparent
        Me.sndGrades.Iconimage = Nothing
        Me.sndGrades.Iconimage_right = Nothing
        Me.sndGrades.Iconimage_right_Selected = Nothing
        Me.sndGrades.Iconimage_Selected = Nothing
        Me.sndGrades.IconMarginLeft = 0
        Me.sndGrades.IconMarginRight = 0
        Me.sndGrades.IconRightVisible = True
        Me.sndGrades.IconRightZoom = 0R
        Me.sndGrades.IconVisible = True
        Me.sndGrades.IconZoom = 50.0R
        Me.sndGrades.IsTab = False
        Me.sndGrades.Location = New System.Drawing.Point(0, 807)
        Me.sndGrades.Margin = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.sndGrades.Name = "sndGrades"
        Me.sndGrades.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.sndGrades.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.sndGrades.OnHoverTextColor = System.Drawing.Color.White
        Me.sndGrades.selected = False
        Me.sndGrades.Size = New System.Drawing.Size(623, 78)
        Me.sndGrades.TabIndex = 26
        Me.sndGrades.Text = "Send Grades"
        Me.sndGrades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sndGrades.Textcolor = System.Drawing.Color.White
        Me.sndGrades.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(93, 635)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 31)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Index number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(93, 544)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 31)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Index number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(93, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 31)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Index number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(93, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Index number"
        '
        'AddGrades
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(802, 945)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddGrades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dashbdTitle As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents sndGrades As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents gradeWel As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents exitgrades As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents crsdropdwn As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
