' Frank Chen
' Last Modified: June 4, 2018
' Trivia game main form which displays the question
' and allows the user to choose the answer from 4 options

' List of enhancements
' 1. Multiple forms         ----------------- 1
' 2. Buttons                ----------------- 0.5
' 3. Timer                  ----------------- 1
' 4. Music                  ----------------- 0.5  ---> credit: 
'                                                       startup:    1. 'Ice Flow' by Kevin MacLeod
'                                                                   2. Link to his youtube channel: https://www.youtube.com/channel/UC88tlMjiS7kf8uhPWyBTn_A
'                                                                   3. 'Xenogenesis' by TheFatRat
'                                                       in game:    Kahoot
' 5. Rainbow color on startup page ---------- 1
' 6. Corresponding pictures for questions
'    are loaded from the internet  ---------- 0.5
' 7. Create a separate thread to prevent
'    the form from freezing when loading
'    resources in the background.  ---------- 1
' 8. Multiple levels: easy, hard   ---------- 0.5
' 9. Provide hints when there are only a
' certain number of seconds left.
' 10. Allow the user to change the way the
' game calculates the score by going into
' the settings form.       ------------------ 1


' List of minor enhancements
' 1. Check for internet connnection to make sure that images can load properly
' 2. Check the filename to ensure that 
'       a) The file exists
'       b) The file contains quiz questions


Public Class Main
    ' declare global variables
    Public Shared InFile As System.IO.StreamReader
    Public Shared readFileThread As System.Threading.Thread
    Public Shared score As Integer
    Public Shared numOfQuestions As Integer
    Public Shared numOfCorrectAnswers As Integer
    Public Shared time As Integer
    ' declare global variables for game settings
    Public Shared scoreIndex As Single = 1
    Public Shared hintIndex As Single = 2
    Public Shared hintTime As Integer = 15
    Public Shared countDownTime As Integer = 30

    ' declaration
    Private eof As Boolean = False
    Private choice(4) As Button
    Private question As String
    Private answer As String
    Private userSelection As Integer
    Private correct As Boolean
    Private hint As String
    Private currentScoreIndex As Single



    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' randomize random numbers
        Randomize()
        ' when opening this form, open the form that opens the file
        OpenFile.Show()
        Me.WindowState = FormWindowState.Minimized      ' minimize the form
        ' put the buttons into the array
        choice(1) = btn1
        choice(2) = btn2
        choice(3) = btn3
        choice(4) = btn4
        ' add event handler for the 4 options
        For i = 1 To 4
            AddHandler choice(i).Click, AddressOf OptionChosen
        Next
        ' control the threads
        readFileThread = New System.Threading.Thread(AddressOf readFile)
        ' block cross thread call warning
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub readFile()
        ' start looping through the file
        Do While Not eof
            ' read the question
            question = InFile.ReadLine()
            ' check if it is empty
            If question = Nothing Then
                eof = True
            Else
                currentScoreIndex = scoreIndex
                numOfQuestions += 1
                ' display the question
                lblQuestion.Text = question
                ' continue reading the four options and show them on the form
                For i = 1 To 4
                    choice(i).Text = InFile.ReadLine()
                Next
                ' read the answer
                answer = InFile.ReadLine()
                ' read the hint
                hint = InFile.ReadLine()
                ' play music
                My.Computer.Audio.Play(CStr(Int(Rnd() * 3) + 1) & ".wav", AudioPlayMode.Background)
                ' read image link
                pb.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(InFile.ReadLine())))
                ' reenable the buttons
                For i = 1 To 4
                    choice(i).Enabled = True
                Next


                Cursor = Cursors.Default

                ' wait for the answer
                readFileThread.Suspend()


            End If

            ' reset the colors and reenable the buttons
            For i = 1 To 4
                With choice(i)
                    .BackColor = Color.Gainsboro
                    .ForeColor = Color.Black
                    '.Enabled = True
                End With
            Next
        Loop
        InFile.Close()
        ' hide everything
        lblScore.Visible = False
        pb.Visible = False
        btnHint.Visible = False
        For i = 1 To 4
            With choice(i)
                .Visible = False
            End With
        Next
        lblQuestion.Visible = False
        lblTimer.Visible = False
        ' show the result
        MessageBox.Show("You got " & numOfCorrectAnswers & " out of " & numOfQuestions & " right and scored " & score & " points." & Environment.NewLine & _
                        "Percentage: " & FormatPercent(score / (numOfQuestions * 1000 * scoreIndex)))
        Me.Close()
    End Sub

    Private Sub OptionChosen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' change music to show answer
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("showAnswer.wav", AudioPlayMode.Background)
        ' stop the timer
        theTimer.Enabled = False
        ' get user selection number
        userSelection = Int(sender.Name.SubString(3, 1))

        ' hide the hint button
        btnHint.Visible = False

        ' check the answer
        If sender.text = answer Then
            ' make the selection green
            choice(userSelection).BackColor = Color.Green
            choice(userSelection).ForeColor = Color.White
            ' count the new score using the following formula
            score += (1000 - (countDownTime - time) * 22) * currentScoreIndex
            ' count correct answers
            numOfCorrectAnswers += 1
        Else
            ' make the selection red
            choice(userSelection).BackColor = Color.Red
            choice(userSelection).ForeColor = Color.White
            ' make the correct option green
            For i = 1 To 4
                If choice(i).Text = answer Then
                    With choice(i)
                        .BackColor = Color.Green
                        .ForeColor = Color.White
                    End With
                End If
            Next
        End If
        ' disable the buttons
        For i = 1 To 4
            choice(i).Enabled = False
        Next
        ' update the score
        lblScore.Text = "Punktzahl: " & score
        ' leave some time for the user to review the answer
        System.Threading.Thread.Sleep(2500)

        Cursor = Cursors.WaitCursor

        ' reset the timer
        time = countDownTime
        theTimer.Enabled = True

        readFileThread.Resume()
    End Sub

    Private Sub theTimer_Tick(sender As System.Object, e As System.EventArgs) Handles theTimer.Tick
        ' count down
        time -= 1
        lblTimer.Text = time

        ' when there's only 15 seconds left, provide some hints
        If time = hintTime Then
            btnHint.Visible = True
        End If

        ' when time is up
        If time = -1 Then
            ' change music to show answer
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play("showAnswer.wav", AudioPlayMode.Background)
            ' make the correct option green
            For i = 1 To 4
                If choice(i).Text = answer Then
                    With choice(i)
                        .BackColor = Color.Green
                        .ForeColor = Color.White
                    End With
                End If
            Next

            ' hide the hint button
            btnHint.Visible = False

            ' disable the buttons
            For i = 1 To 4
                choice(i).Enabled = False
            Next
            ' update the score
            lblScore.Text = "Score: " & score
            ' leave some time for the user to review the answer
            System.Threading.Thread.Sleep(2500)


            ' reset the timer
            time = countDownTime
            theTimer.Enabled = True
            readFileThread.Resume()
        End If


    End Sub

    Private Sub btnHint_Click(sender As System.Object, e As System.EventArgs) Handles btnHint.Click
        currentScoreIndex /= hintIndex
        ' show the hint
        MessageBox.Show(hint)
    End Sub
End Class
