' Frank Chen
' Last Modified: June 4, 2018
' This form allows the user to change the settings for the game

Public Class Settings
    ' declaration
    Private scoreIndex As Single = 1
    Private hintIndex As Single = 2
    Private hintTime As Integer = 15
    Private countDownTime As Integer = 30

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        ' close the settings
        OpenFile.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        ' save all the changes to the main form
        If scoreIndex = 0 Then
            scoreIndex += 0.1
        End If
        Main.scoreIndex = scoreIndex
        If hintIndex = 0 Then
            hintIndex += 0.1
        End If
        Main.hintIndex = hintIndex
        Main.hintTime = hintTime - 1
        Main.countDownTime = countDownTime
        ' close the settings
        OpenFile.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub

    Private Sub tbScoreIndex_Scroll(sender As System.Object, e As System.EventArgs) Handles tbScoreIndex.Scroll
        ' update the index
        scoreIndex = tbScoreIndex.Value / 5
    End Sub

    Private Sub tbHintIndex_Scroll(sender As System.Object, e As System.EventArgs) Handles tbHintIndex.Scroll
        ' update the index
        hintIndex = tbHintIndex.Value / 2.5
    End Sub

    Private Sub tbCountDownTime_Scroll(sender As System.Object, e As System.EventArgs) Handles tbCountDownTime.Scroll
        ' update count down time
        countDownTime = tbCountDownTime.Value * 6
        ' check if the count down time is smaller than the hint time
        If countDownTime <= hintTime Then
            tbHintTime.Value = tbCountDownTime.Value * 2
        End If
    End Sub

    Private Sub tbHintTime_ValueChanged(sender As Object, e As System.EventArgs) Handles tbHintTime.ValueChanged
        ' update the time
        hintTime = tbHintTime.Value * 3
    End Sub

End Class