Public Class Form2

    'Private Sub DrawBulletBesideLabel()
    Private Sub Form2_Load(sender As Object, e As PaintEventArgs) Handles MyBase.Paint, MyBase.Load

        Dim g = e.Graphics
        Dim lineColor = Color.FromArgb(255, 255, 255)

        g.DrawLine(New Pen(lineColor, 1), 100, 290, 716, 290)
    End Sub


End Class