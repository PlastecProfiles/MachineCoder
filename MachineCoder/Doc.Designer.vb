<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doc
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
        Me.y = New System.Windows.Forms.Label()
        Me.x = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.BackColor = System.Drawing.SystemColors.Control
        Me.y.Location = New System.Drawing.Point(242, 239)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(0, 13)
        Me.y.TabIndex = 8
        '
        'x
        '
        Me.x.AutoSize = True
        Me.x.BackColor = System.Drawing.SystemColors.Control
        Me.x.Location = New System.Drawing.Point(186, 239)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(0, 13)
        Me.x.TabIndex = 7
        '
        'Doc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.y)
        Me.Controls.Add(Me.x)
        Me.Name = "Doc"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Doc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents y As Label
    Friend WithEvents x As Label

End Class
