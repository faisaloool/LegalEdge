Public Class Form3
    Private Sub Form3_Load(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim g = e.Graphics
        Dim lineColor = Color.FromArgb(255, 255, 255)

        g.DrawLine(New Pen(lineColor, 1), 100, 270, 716, 270)
    End Sub

End Class