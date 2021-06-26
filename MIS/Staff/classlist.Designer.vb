<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class classlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(classlist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitProof = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.print = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.crs2 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.exitProof)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 58)
        Me.Panel1.TabIndex = 12
        '
        'exitProof
        '
        Me.exitProof.BackColor = System.Drawing.Color.Transparent
        Me.exitProof.color = System.Drawing.Color.Transparent
        Me.exitProof.colorActive = System.Drawing.Color.Transparent
        Me.exitProof.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitProof.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.exitProof.ForeColor = System.Drawing.Color.White
        Me.exitProof.Image = CType(resources.GetObject("exitProof.Image"), System.Drawing.Image)
        Me.exitProof.ImagePosition = 0
        Me.exitProof.ImageZoom = 50
        Me.exitProof.LabelPosition = 0
        Me.exitProof.LabelText = ""
        Me.exitProof.Location = New System.Drawing.Point(618, 9)
        Me.exitProof.Margin = New System.Windows.Forms.Padding(6)
        Me.exitProof.Name = "exitProof"
        Me.exitProof.Size = New System.Drawing.Size(82, 43)
        Me.exitProof.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class List"
        '
        'print
        '
        Me.print.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.print.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.print.BorderRadius = 0
        Me.print.ButtonText = "Print List"
        Me.print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.print.DisabledColor = System.Drawing.Color.Gray
        Me.print.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.print.Iconcolor = System.Drawing.Color.Transparent
        Me.print.Iconimage = Nothing
        Me.print.Iconimage_right = Nothing
        Me.print.Iconimage_right_Selected = Nothing
        Me.print.Iconimage_Selected = Nothing
        Me.print.IconMarginLeft = 0
        Me.print.IconMarginRight = 0
        Me.print.IconRightVisible = True
        Me.print.IconRightZoom = 0R
        Me.print.IconVisible = True
        Me.print.IconZoom = 90.0R
        Me.print.IsTab = False
        Me.print.Location = New System.Drawing.Point(0, 882)
        Me.print.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.print.Name = "print"
        Me.print.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.print.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.print.OnHoverTextColor = System.Drawing.Color.Gainsboro
        Me.print.selected = False
        Me.print.Size = New System.Drawing.Size(715, 59)
        Me.print.TabIndex = 16
        Me.print.Text = "Print List"
        Me.print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.print.Textcolor = System.Drawing.Color.Gainsboro
        Me.print.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(394, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Here are the list of ____________"
        '
        'crs2
        '
        Me.crs2.BackColor = System.Drawing.Color.Gainsboro
        Me.crs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crs2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.crs2.FormattingEnabled = True
        Me.crs2.Location = New System.Drawing.Point(49, 179)
        Me.crs2.Name = "crs2"
        Me.crs2.Size = New System.Drawing.Size(455, 33)
        Me.crs2.TabIndex = 32
        Me.crs2.Text = "select a course you teach"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(49, 240)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 548)
        Me.ListBox1.TabIndex = 33
        '
        'classlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(715, 941)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.crs2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "classlist"
        Me.Text = "classlist"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents exitProof As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents print As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents crs2 As ComboBox
    Friend WithEvents ListBox1 As ListBox
End Class
