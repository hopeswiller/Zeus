<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrsDrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrsDrop))
        Me.savebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dpbtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.listbox2 = New System.Windows.Forms.CheckedListBox()
        Me.listbox = New System.Windows.Forms.CheckedListBox()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.exitCourses = New Bunifu.Framework.UI.BunifuTileButton()
        Me.DashbdTitle2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.qualif = New System.Windows.Forms.Label()
        Me.rightPanel.SuspendLayout()
        Me.leftPanel.SuspendLayout()
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
        Me.savebtn.Location = New System.Drawing.Point(581, 749)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(5)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(148, 70)
        Me.savebtn.TabIndex = 35
        Me.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dpbtn
        '
        Me.dpbtn.ActiveBorderThickness = 1
        Me.dpbtn.ActiveCornerRadius = 20
        Me.dpbtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.dpbtn.ActiveForecolor = System.Drawing.Color.Gainsboro
        Me.dpbtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.dpbtn.BackColor = System.Drawing.Color.Gainsboro
        Me.dpbtn.BackgroundImage = CType(resources.GetObject("dpbtn.BackgroundImage"), System.Drawing.Image)
        Me.dpbtn.ButtonText = "Drop "
        Me.dpbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dpbtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpbtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.dpbtn.IdleBorderThickness = 1
        Me.dpbtn.IdleCornerRadius = 20
        Me.dpbtn.IdleFillColor = System.Drawing.Color.Gainsboro
        Me.dpbtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.dpbtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.dpbtn.Location = New System.Drawing.Point(182, 749)
        Me.dpbtn.Margin = New System.Windows.Forms.Padding(5)
        Me.dpbtn.Name = "dpbtn"
        Me.dpbtn.Size = New System.Drawing.Size(135, 70)
        Me.dpbtn.TabIndex = 29
        Me.dpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rightPanel
        '
        Me.rightPanel.Controls.Add(Me.listbox2)
        Me.rightPanel.Location = New System.Drawing.Point(445, 166)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(417, 575)
        Me.rightPanel.TabIndex = 33
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
        Me.listbox2.Size = New System.Drawing.Size(414, 554)
        Me.listbox2.TabIndex = 2
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
        Me.listbox.Size = New System.Drawing.Size(396, 554)
        Me.listbox.TabIndex = 2
        '
        'leftPanel
        '
        Me.leftPanel.Controls.Add(Me.listbox)
        Me.leftPanel.Location = New System.Drawing.Point(24, 166)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(399, 575)
        Me.leftPanel.TabIndex = 32
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
        Me.exitCourses.Location = New System.Drawing.Point(775, 6)
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
        Me.DashbdTitle2.Size = New System.Drawing.Size(487, 29)
        Me.DashbdTitle2.TabIndex = 1
        Me.DashbdTitle2.Text = "Student Dashboard / Enquiry / Drop Courses"
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
        Me.Panel1.Size = New System.Drawing.Size(872, 58)
        Me.Panel1.TabIndex = 27
        '
        'qualif
        '
        Me.qualif.AutoSize = True
        Me.qualif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qualif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.qualif.Location = New System.Drawing.Point(65, 78)
        Me.qualif.Name = "qualif"
        Me.qualif.Size = New System.Drawing.Size(197, 29)
        Me.qualif.TabIndex = 36
        Me.qualif.Text = "This sections......."
        '
        'CrsDrop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(872, 885)
        Me.Controls.Add(Me.qualif)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.dpbtn)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrsDrop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrsDrop"
        Me.rightPanel.ResumeLayout(False)
        Me.leftPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents savebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents dpbtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents rightPanel As Panel
    Friend WithEvents listbox2 As CheckedListBox
    Friend WithEvents listbox As CheckedListBox
    Friend WithEvents leftPanel As Panel
    Friend WithEvents exitCourses As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DashbdTitle2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents qualif As Label
End Class
