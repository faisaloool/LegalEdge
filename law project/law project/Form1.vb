Public Class Form1
    Private Sub Form1_Load(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim lineColor As Color = Color.FromArgb(220, 170, 90)

        g.DrawLine(New Pen(lineColor, 1), 400, 220, 400, 440)
        Me.Label1.Parent = Me.PictureBox2
    End Sub
End Class
