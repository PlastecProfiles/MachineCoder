Public Class Doc
    Dim masterx As Integer
    Dim mastery As Integer
    Dim xxx As Integer
    Dim yyy As Integer
    Dim Xlen As Integer
    Dim ylen As Integer

    Private Sub Doc_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        masterx = xxx
        mastery = yyy
    End Sub

    Private Sub Doc_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Xlen = xxx
        ylen = yyy
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        x.Text = ""
        y.Text = ""
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        x.Text = ""
        y.Text = ""
    End Sub

    Private Sub TextBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        x.Text = "X:" & e.X
        y.Text = "Y:" & e.Y
        xxx = e.X
        yyy = e.Y
    End Sub

End Class