Public Class Form1
    Private ran As New Random
    Private addend1 As Integer
    Private addend2 As Integer
    Private minuend As Integer
    Private subtrahend As Integer
    Private timeLeft As Integer

    Public Sub startQuiz()
        addend1 = ran.Next(51)
        addend2 = ran.Next(51)
        plusLeftLabel.Text = addend1.ToString()
        plusRightLabel.Text = addend2.ToString()
        sum.Value = 0

        minuend = ran.Next(1, 101)
        subtrahend = ran.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString()
        minusRightLabel.Text = subtrahend.ToString()
        difference.Value = 0

        timeLeft = 10
        timeLabel.Text = "10 seconds"
        Timer1.Start()
    End Sub

    Private Function check() As Boolean
        If addend1 + addend2 = sum.Value And minuend - subtrahend = difference.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        startQuiz()
        startButton.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If check() Then
            Timer1.Stop()
            MessageBox.Show("All answers are correct!")
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            timeLeft -= 1
            timeLabel.Text = timeLeft & " seconds"
        Else
            Timer1.Stop()
            timeLabel.Text = "Time is finished!"
            MessageBox.Show("You didn't finish in time!")
            sum.Value = addend1 + addend2
            difference.Value = minuend - subtrahend
            startButton.Enabled = True
        End If
    End Sub
End Class
