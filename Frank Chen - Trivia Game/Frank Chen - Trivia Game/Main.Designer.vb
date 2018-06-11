<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer




    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.theTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.btnHint = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn3
        '
        Me.btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn3.BackColor = System.Drawing.Color.Gainsboro
        Me.btn3.Enabled = False
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(12, 578)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(334, 102)
        Me.btn3.TabIndex = 0
        Me.btn3.Text = "Option 3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn4.BackColor = System.Drawing.Color.Gainsboro
        Me.btn4.Enabled = False
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(382, 578)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(334, 102)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "Option 4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn2.BackColor = System.Drawing.Color.Gainsboro
        Me.btn2.Enabled = False
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(382, 472)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(334, 100)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "Option 2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(87, 8)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(581, 95)
        Me.lblQuestion.TabIndex = 4
        Me.lblQuestion.Text = "Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(8, 12)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(59, 20)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Score: "
        '
        'theTimer
        '
        Me.theTimer.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(694, 10)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(27, 20)
        Me.lblTimer.TabIndex = 6
        Me.lblTimer.Text = "00"
        '
        'pb
        '
        Me.pb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pb.Location = New System.Drawing.Point(41, 106)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(652, 308)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb.TabIndex = 7
        Me.pb.TabStop = False
        '
        'btnHint
        '
        Me.btnHint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnHint.Location = New System.Drawing.Point(41, 420)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(652, 46)
        Me.btnHint.TabIndex = 8
        Me.btnHint.Text = "Show hint"
        Me.btnHint.UseVisualStyleBackColor = True
        Me.btnHint.Visible = False
        '
        'btn1
        '
        Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn1.BackColor = System.Drawing.Color.Gainsboro
        Me.btn1.Enabled = False
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 472)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(334, 100)
        Me.btn1.TabIndex = 3
        Me.btn1.Text = "Option 1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 714)
        Me.Name = "Main"
        Me.Text = "Trivia Game"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Public WithEvents theTimer As System.Windows.Forms.Timer
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button

End Class
