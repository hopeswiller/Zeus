<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rules))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitRules = New Bunifu.Framework.UI.BunifuTileButton()
        Me.dwnloadRules = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dwnloadRules)
        Me.Panel1.Controls.Add(Me.exitRules)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 58)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Dashboard / Rules"
        '
        'exitRules
        '
        Me.exitRules.BackColor = System.Drawing.Color.Transparent
        Me.exitRules.color = System.Drawing.Color.Transparent
        Me.exitRules.colorActive = System.Drawing.Color.Transparent
        Me.exitRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitRules.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.exitRules.ForeColor = System.Drawing.Color.White
        Me.exitRules.Image = CType(resources.GetObject("exitRules.Image"), System.Drawing.Image)
        Me.exitRules.ImagePosition = 0
        Me.exitRules.ImageZoom = 50
        Me.exitRules.LabelPosition = 0
        Me.exitRules.LabelText = ""
        Me.exitRules.Location = New System.Drawing.Point(728, 6)
        Me.exitRules.Margin = New System.Windows.Forms.Padding(6)
        Me.exitRules.Name = "exitRules"
        Me.exitRules.Size = New System.Drawing.Size(82, 43)
        Me.exitRules.TabIndex = 2
        '
        'dwnloadRules
        '
        Me.dwnloadRules.BackColor = System.Drawing.Color.Transparent
        Me.dwnloadRules.color = System.Drawing.Color.Transparent
        Me.dwnloadRules.colorActive = System.Drawing.Color.Transparent
        Me.dwnloadRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dwnloadRules.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.dwnloadRules.ForeColor = System.Drawing.Color.White
        Me.dwnloadRules.Image = CType(resources.GetObject("dwnloadRules.Image"), System.Drawing.Image)
        Me.dwnloadRules.ImagePosition = 0
        Me.dwnloadRules.ImageZoom = 50
        Me.dwnloadRules.LabelPosition = 0
        Me.dwnloadRules.LabelText = ""
        Me.dwnloadRules.Location = New System.Drawing.Point(634, 6)
        Me.dwnloadRules.Margin = New System.Windows.Forms.Padding(6)
        Me.dwnloadRules.Name = "dwnloadRules"
        Me.dwnloadRules.Size = New System.Drawing.Size(82, 43)
        Me.dwnloadRules.TabIndex = 3
        '
        'rules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(825, 658)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "rules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rules"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents exitRules As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents dwnloadRules As Bunifu.Framework.UI.BunifuTileButton
End Class
