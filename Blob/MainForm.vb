Public Class MainForm

    Private player As Blob

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        player = New Blob

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        player.Draw(e.Graphics)

    End Sub

    Private Sub MainForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        Dim Key As String

        Key = e.KeyChar.ToString.ToUpper

        Select Case Key
            Case "W"
                player.Move("N")
            Case "A"
                player.Move("W")
            Case "S"
                player.Move("S")
            Case "D"
                player.Move("E")
        End Select

        PictureBox1.Refresh()

    End Sub
End Class
