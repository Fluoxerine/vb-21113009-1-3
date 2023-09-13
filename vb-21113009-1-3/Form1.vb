Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = 200
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Call mymove()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call mymove()
    End Sub
    Sub mymove()
        Label1.Left = Label1.Left + 5
        If Label1.Left > Me.Width Then Label1.Left = 0
    End Sub
End Class
