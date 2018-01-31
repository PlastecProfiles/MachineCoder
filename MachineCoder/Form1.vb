Public Class Form1
    Private Sub line_draw_Click(sender As Object, e As EventArgs) Handles line_draw.Click

    End Sub

    Protected Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim NewMDIChild As New Form2()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
    End Sub
End Class
