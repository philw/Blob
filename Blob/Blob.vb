Public Class Blob

    Private positionX As Integer
    Private positionY As Integer
    Private size As Integer

    Public Sub New()

        size = 15

        ' put the player in the middle
        positionX = MainForm.PictureBox1.Width \ 2
        positionY = MainForm.PictureBox1.Height \ 2

    End Sub

    Public Sub Draw(g As Graphics)

        Dim brush As New SolidBrush(Color.MidnightBlue)

        g.FillEllipse(brush, positionX, positionY, size, size)

    End Sub

    Public Sub Move(direction As String)

        Select Case direction
            Case "N"
                positionY -= 5
            Case "W"
                positionX -= 5
            Case "S"
                positionY += 5
            Case "E"
                positionX += 5
        End Select

    End Sub

End Class
