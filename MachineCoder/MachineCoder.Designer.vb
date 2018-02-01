<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class machineCoder
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.line_draw = New System.Windows.Forms.Button()
        Me.circle_draw = New System.Windows.Forms.Button()
        Me.box_draw = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.x = New System.Windows.Forms.Label()
        Me.y = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.line_draw)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.circle_draw)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.box_draw)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(36, 349)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 49)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(36, 374)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'line_draw
        '
        Me.line_draw.Location = New System.Drawing.Point(0, 3)
        Me.line_draw.Name = "line_draw"
        Me.line_draw.Size = New System.Drawing.Size(33, 31)
        Me.line_draw.TabIndex = 2
        Me.line_draw.Text = "Line"
        Me.line_draw.UseVisualStyleBackColor = True
        '
        'circle_draw
        '
        Me.circle_draw.Location = New System.Drawing.Point(-1, 77)
        Me.circle_draw.Name = "circle_draw"
        Me.circle_draw.Size = New System.Drawing.Size(33, 31)
        Me.circle_draw.TabIndex = 1
        Me.circle_draw.Text = "Circle"
        Me.circle_draw.UseVisualStyleBackColor = True
        '
        'box_draw
        '
        Me.box_draw.Location = New System.Drawing.Point(-1, 40)
        Me.box_draw.Name = "box_draw"
        Me.box_draw.Size = New System.Drawing.Size(33, 31)
        Me.box_draw.TabIndex = 0
        Me.box_draw.Text = "Box"
        Me.box_draw.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.ToolStripMenuItem2
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1229, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "File"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.ToolStripMenuItem1.Text = "New"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(63, 20)
        Me.ToolStripMenuItem2.Text = "Window"
        '
        'x
        '
        Me.x.AutoSize = True
        Me.x.Location = New System.Drawing.Point(1077, 496)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(12, 13)
        Me.x.TabIndex = 5
        Me.x.Text = "x"
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.Location = New System.Drawing.Point(1145, 496)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(12, 13)
        Me.y.TabIndex = 6
        Me.y.Text = "y"
        '
        'machineCoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 518)
        Me.Controls.Add(Me.y)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "machineCoder"
        Me.Text = "Machine Coder"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents line_draw As Button
    Friend WithEvents circle_draw As Button
    Friend WithEvents box_draw As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents x As Label
    Friend WithEvents y As Label
End Class
