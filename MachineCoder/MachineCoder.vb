﻿Public Class machineCoder
    Dim masterx As Integer
    Dim mastery As Integer
    Dim xxx As Integer
    Dim yyy As Integer
    Dim Xlen As Integer
    Dim ylen As Integer

    Protected Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim NewMDIChild As New doc()
        NewMDIChild.WindowState = FormWindowState.Maximized
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()

    End Sub





    Private Sub line_draw_Click(sender As Object, e As EventArgs) Handles line_draw.Click
        doc.CreateGraphics.DrawLine(Pens.Black, 10, 10, 20, 10)
    End Sub
End Class
