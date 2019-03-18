<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenFile))
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEasy = New System.Windows.Forms.Button()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.lblChooseLevel = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnChooseFile.Location = New System.Drawing.Point(277, 133)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(224, 72)
        Me.btnChooseFile.TabIndex = 0
        Me.btnChooseFile.Text = "Aus Datei wählen"
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'lblOr
        '
        Me.lblOr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOr.AutoSize = True
        Me.lblOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOr.Location = New System.Drawing.Point(345, 228)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(88, 37)
        Me.lblOr.TabIndex = 1
        Me.lblOr.Text = "Oder"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtFileName.Location = New System.Drawing.Point(200, 326)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(378, 26)
        Me.txtFileName.TabIndex = 2
        Me.txtFileName.Text = "hard.txt"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSubmit.Location = New System.Drawing.Point(247, 373)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(286, 63)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Die Datei Öffnen"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(46, 287)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(686, 20)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "Legen Sie die Datei in den Ordner ""Debug"" ab, und schreiben ihren Name in das Tex" &
    "tfeld unten. "
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(709, 12)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(52, 50)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "⚙"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 66)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Trivia Spiel"
        '
        'btnEasy
        '
        Me.btnEasy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEasy.Location = New System.Drawing.Point(650, 133)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(111, 34)
        Me.btnEasy.TabIndex = 8
        Me.btnEasy.Text = "Einfach"
        Me.btnEasy.UseVisualStyleBackColor = True
        '
        'btnHard
        '
        Me.btnHard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHard.Location = New System.Drawing.Point(650, 173)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(111, 34)
        Me.btnHard.TabIndex = 9
        Me.btnHard.Text = "Hart"
        Me.btnHard.UseVisualStyleBackColor = True
        '
        'lblChooseLevel
        '
        Me.lblChooseLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChooseLevel.AutoSize = True
        Me.lblChooseLevel.Location = New System.Drawing.Point(620, 107)
        Me.lblChooseLevel.Name = "lblChooseLevel"
        Me.lblChooseLevel.Size = New System.Drawing.Size(151, 20)
        Me.lblChooseLevel.TabIndex = 10
        Me.lblChooseLevel.Text = "Eingebaute Ebenen"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(650, 403)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 32)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OpenFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblChooseLevel)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(795, 503)
        Me.Name = "OpenFile"
        Me.Text = "Aus ... Öffnen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChooseFile As System.Windows.Forms.Button
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEasy As System.Windows.Forms.Button
    Friend WithEvents btnHard As System.Windows.Forms.Button
    Friend WithEvents lblChooseLevel As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
