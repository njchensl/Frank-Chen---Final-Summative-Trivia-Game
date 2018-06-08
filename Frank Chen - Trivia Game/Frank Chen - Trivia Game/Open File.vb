' Frank Chen
' Last Modified: June 4, 2018
' Trivia game game open file form which
' allows the user to choose from two
' options. 1st is a open file dialog. 
' 2nd is using the file name to open 
' the file. 

Public Class OpenFile
    ' declaration
    Private changeColorThread As System.Threading.Thread
    Private exception As Boolean
    Private r, g, b As Integer
    Private isQuestion As Boolean

    Private Sub changeColor()
        r = 255
        ' make rainbow color
        Do While True
            Me.BackColor = Color.FromArgb(r, g, b)
            If r > 0 And b = 0 And g < 255 Then
                g += 1
            End If
            If g = 255 And b = 0 And r <= 255 And r > 0 Then
                r -= 1
            End If
            If g = 255 And r = 0 And b <= 255 Then
                b += 1
            End If
            If b = 255 And g <= 255 And r = 0 And g > 0 Then
                g -= 1
            End If
            If g = 0 And b = 255 And r < 255 Then
                r += 1
            End If
            If r = 255 And b <= 255 And g = 0 And b > 0 Then
                b -= 1
            End If

            System.Threading.Thread.Sleep(10)
        Loop
    End Sub

    Private Sub OpenFile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' make numbers random
        Randomize()
        ' play music
        My.Computer.Audio.Play("Start" & CStr(Int(Rnd() * 3 + 1)) & ".wav", AudioPlayMode.BackgroundLoop)
        ' block cross thread call warning
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        changeColorThread = New System.Threading.Thread(AddressOf changeColor)

        changeColorThread.Start()
    End Sub

    Private Sub btnChooseFile_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseFile.Click
        ' choose from file
        If ofd.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Main.InFile = New System.IO.StreamReader(ofd.FileName)
            ' check if the file contains questions in proper format
            If Main.InFile.ReadLine() = "<Trivia Game Questions>" Then
                ' close this form and return to the previous form
                Main.WindowState = FormWindowState.Normal
                'start the reading file thread
                Main.readFileThread.Start()
                ' stop the music
                My.Computer.Audio.Stop()
                ' stop changing the backcolor
                changeColorThread.Abort()
                ' setup the timer
                Main.time = Main.countDownTime
                Main.theTimer.Enabled = True
                Cursor = Cursors.WaitCursor
                Me.Close()
            Else
                MessageBox.Show("File does not contain questions.")
            End If
        End If

        
        
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        ' try opening the file first to ensure that the file exists
        exception = False
        Try
            Main.InFile = New System.IO.StreamReader(txtFileName.Text)
        Catch ex As Exception
            MessageBox.Show("Cannot load file." & Environment.NewLine & ex.Message)
            exception = True
        End Try
        ' check internet
        Try
            Main.pb.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://www.google.ca/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png")))
        Catch ex As Exception
            MessageBox.Show("Please make sure that there is Interenet connection" & Environment.NewLine & ex.Message)
            exception = True
        End Try
        If Not exception Then
            ' choose file name
            Main.InFile = New System.IO.StreamReader(txtFileName.Text)
            
            ' check if the file contains questions in proper format
            If Main.InFile.ReadLine() = "<Trivia Game Questions>" Then
                ' close this form and return to the previous form
                Main.WindowState = FormWindowState.Normal
                ' start the reading file thread
                Main.readFileThread.Start()
                ' stop the music
                My.Computer.Audio.Stop()
                ' stop changing the backcolor
                changeColorThread.Abort()
                ' setup the timer
                Main.time = Main.countDownTime
                Main.theTimer.Enabled = True
                Cursor = Cursors.WaitCursor
                Me.Close()
            Else
                MessageBox.Show("File does not contain questions.")
            End If
        End If
        

    End Sub

    Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        Settings.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnEasy_Click(sender As System.Object, e As System.EventArgs) Handles btnEasy.Click
        Main.InFile = New System.IO.StreamReader("easy.txt")
        Main.InFile.ReadLine()
        ' close this form and return to the previous form
        Main.WindowState = FormWindowState.Normal
        'start the reading file thread
        Main.readFileThread.Start()
        ' stop the music
        My.Computer.Audio.Stop()
        ' stop changing the backcolor
        changeColorThread.Abort()
        ' setup the timer
        Main.time = Main.countDownTime
        Main.theTimer.Enabled = True
        Cursor = Cursors.WaitCursor
        Me.Close()
    End Sub

    Private Sub btnHard_Click(sender As System.Object, e As System.EventArgs) Handles btnHard.Click
        Main.InFile = New System.IO.StreamReader("hard.txt")
        Main.InFile.ReadLine()
        ' close this form and return to the previous form
        Main.WindowState = FormWindowState.Normal
        'start the reading file thread
        Main.readFileThread.Start()
        ' stop the music
        My.Computer.Audio.Stop()
        ' stop changing the backcolor
        changeColorThread.Abort()
        ' setup the timer
        Main.time = Main.countDownTime
        Main.theTimer.Enabled = True
        Cursor = Cursors.WaitCursor
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Cursor.Position = New Drawing.Point(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height + 100)

        ' stop everything
        changeColorThread.Abort()
        Main.Close()
    End Sub
End Class