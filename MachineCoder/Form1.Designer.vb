<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
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
        Me.ToolStripContainer1.Location = New System.Drawing.Point(13, 51)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 883)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents line_draw As Button
    Friend WithEvents circle_draw As Button
    Friend WithEvents box_draw As Button
End Class
