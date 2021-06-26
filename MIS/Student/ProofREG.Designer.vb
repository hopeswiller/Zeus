<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProofREG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProofREG))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitProof = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.ListBox()
        Me.regWel = New System.Windows.Forms.Label()
        Me.print = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
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
        Me.Panel1.Size = New System.Drawing.Size(741, 58)
        Me.Panel1.TabIndex = 2
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
        Me.exitProof.Location = New System.Drawing.Point(656, 9)
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
        Me.Label1.Size = New System.Drawing.Size(238, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Proof of Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(421, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Registered courses for the semester"
        '
        'title
        '
        Me.title.BackColor = System.Drawing.Color.Gainsboro
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.title.FormattingEnabled = True
        Me.title.ItemHeight = 29
        Me.title.Location = New System.Drawing.Point(36, 310)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(613, 439)
        Me.title.TabIndex = 8
        '
        'regWel
        '
        Me.regWel.AutoSize = True
        Me.regWel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regWel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.regWel.Location = New System.Drawing.Point(31, 89)
        Me.regWel.Name = "regWel"
        Me.regWel.Size = New System.Drawing.Size(266, 25)
        Me.regWel.TabIndex = 10
        Me.regWel.Text = "Dear Mr/Miss ____________"
        '
        'print
        '
        Me.print.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.print.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.print.BorderRadius = 0
        Me.print.ButtonText = "Print Proof"
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
        Me.print.Location = New System.Drawing.Point(0, 772)
        Me.print.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.print.Name = "print"
        Me.print.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.print.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.print.OnHoverTextColor = System.Drawing.Color.Gainsboro
        Me.print.selected = False
        Me.print.Size = New System.Drawing.Size(741, 59)
        Me.print.TabIndex = 11
        Me.print.Text = "Print Proof"
        Me.print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.print.Textcolor = System.Drawing.Color.Gainsboro
        Me.print.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ProofREG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(741, 831)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.regWel)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProofREG"
        Me.Text = "ProofREG"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents exitProof As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents title As ListBox
    Friend WithEvents regWel As Label
    Friend WithEvents print As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
