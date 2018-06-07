<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.tbScoreIndex = New System.Windows.Forms.TrackBar()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblScoreIndex1 = New System.Windows.Forms.Label()
        Me.lblScoreIndex2 = New System.Windows.Forms.Label()
        Me.lblScoreIndex0 = New System.Windows.Forms.Label()
        Me.gbScoreIndex = New System.Windows.Forms.GroupBox()
        Me.gbHintIndex = New System.Windows.Forms.GroupBox()
        Me.lblHintIndex0 = New System.Windows.Forms.Label()
        Me.lblHintIndex4 = New System.Windows.Forms.Label()
        Me.lblHintIndex2 = New System.Windows.Forms.Label()
        Me.tbHintIndex = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHintTime0 = New System.Windows.Forms.Label()
        Me.lblHintTime30 = New System.Windows.Forms.Label()
        Me.lblHintTime15 = New System.Windows.Forms.Label()
        Me.tbHintTime = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCountDownTime0 = New System.Windows.Forms.Label()
        Me.lblCountDownTime60 = New System.Windows.Forms.Label()
        Me.lblCountDownTime30 = New System.Windows.Forms.Label()
        Me.tbCountDownTime = New System.Windows.Forms.TrackBar()
        CType(Me.tbScoreIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbScoreIndex.SuspendLayout()
        Me.gbHintIndex.SuspendLayout()
        CType(Me.tbHintIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbHintTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbCountDownTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbScoreIndex
        '
        Me.tbScoreIndex.Location = New System.Drawing.Point(31, 37)
        Me.tbScoreIndex.Name = "tbScoreIndex"
        Me.tbScoreIndex.Size = New System.Drawing.Size(299, 69)
        Me.tbScoreIndex.TabIndex = 0
        Me.tbScoreIndex.Value = 5
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(656, 322)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(122, 44)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(784, 322)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 44)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblScoreIndex1
        '
        Me.lblScoreIndex1.AutoSize = True
        Me.lblScoreIndex1.Location = New System.Drawing.Point(172, 86)
        Me.lblScoreIndex1.Name = "lblScoreIndex1"
        Me.lblScoreIndex1.Size = New System.Drawing.Size(18, 20)
        Me.lblScoreIndex1.TabIndex = 3
        Me.lblScoreIndex1.Text = "1"
        '
        'lblScoreIndex2
        '
        Me.lblScoreIndex2.AutoSize = True
        Me.lblScoreIndex2.Location = New System.Drawing.Point(302, 86)
        Me.lblScoreIndex2.Name = "lblScoreIndex2"
        Me.lblScoreIndex2.Size = New System.Drawing.Size(18, 20)
        Me.lblScoreIndex2.TabIndex = 4
        Me.lblScoreIndex2.Text = "2"
        '
        'lblScoreIndex0
        '
        Me.lblScoreIndex0.AutoSize = True
        Me.lblScoreIndex0.Location = New System.Drawing.Point(44, 86)
        Me.lblScoreIndex0.Name = "lblScoreIndex0"
        Me.lblScoreIndex0.Size = New System.Drawing.Size(18, 20)
        Me.lblScoreIndex0.TabIndex = 5
        Me.lblScoreIndex0.Text = "0"
        '
        'gbScoreIndex
        '
        Me.gbScoreIndex.Controls.Add(Me.lblScoreIndex0)
        Me.gbScoreIndex.Controls.Add(Me.lblScoreIndex2)
        Me.gbScoreIndex.Controls.Add(Me.lblScoreIndex1)
        Me.gbScoreIndex.Controls.Add(Me.tbScoreIndex)
        Me.gbScoreIndex.Location = New System.Drawing.Point(57, 23)
        Me.gbScoreIndex.Name = "gbScoreIndex"
        Me.gbScoreIndex.Size = New System.Drawing.Size(364, 128)
        Me.gbScoreIndex.TabIndex = 6
        Me.gbScoreIndex.TabStop = False
        Me.gbScoreIndex.Text = "Score Index"
        '
        'gbHintIndex
        '
        Me.gbHintIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbHintIndex.Controls.Add(Me.lblHintIndex0)
        Me.gbHintIndex.Controls.Add(Me.lblHintIndex4)
        Me.gbHintIndex.Controls.Add(Me.lblHintIndex2)
        Me.gbHintIndex.Controls.Add(Me.tbHintIndex)
        Me.gbHintIndex.Location = New System.Drawing.Point(57, 157)
        Me.gbHintIndex.Name = "gbHintIndex"
        Me.gbHintIndex.Size = New System.Drawing.Size(364, 128)
        Me.gbHintIndex.TabIndex = 7
        Me.gbHintIndex.TabStop = False
        Me.gbHintIndex.Text = "Hint Index"
        '
        'lblHintIndex0
        '
        Me.lblHintIndex0.AutoSize = True
        Me.lblHintIndex0.Location = New System.Drawing.Point(44, 86)
        Me.lblHintIndex0.Name = "lblHintIndex0"
        Me.lblHintIndex0.Size = New System.Drawing.Size(18, 20)
        Me.lblHintIndex0.TabIndex = 5
        Me.lblHintIndex0.Text = "0"
        '
        'lblHintIndex4
        '
        Me.lblHintIndex4.AutoSize = True
        Me.lblHintIndex4.Location = New System.Drawing.Point(302, 86)
        Me.lblHintIndex4.Name = "lblHintIndex4"
        Me.lblHintIndex4.Size = New System.Drawing.Size(18, 20)
        Me.lblHintIndex4.TabIndex = 4
        Me.lblHintIndex4.Text = "4"
        '
        'lblHintIndex2
        '
        Me.lblHintIndex2.AutoSize = True
        Me.lblHintIndex2.Location = New System.Drawing.Point(172, 86)
        Me.lblHintIndex2.Name = "lblHintIndex2"
        Me.lblHintIndex2.Size = New System.Drawing.Size(18, 20)
        Me.lblHintIndex2.TabIndex = 3
        Me.lblHintIndex2.Text = "2"
        '
        'tbHintIndex
        '
        Me.tbHintIndex.Location = New System.Drawing.Point(31, 37)
        Me.tbHintIndex.Name = "tbHintIndex"
        Me.tbHintIndex.Size = New System.Drawing.Size(299, 69)
        Me.tbHintIndex.TabIndex = 0
        Me.tbHintIndex.Value = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblHintTime0)
        Me.GroupBox1.Controls.Add(Me.lblHintTime30)
        Me.GroupBox1.Controls.Add(Me.lblHintTime15)
        Me.GroupBox1.Controls.Add(Me.tbHintTime)
        Me.GroupBox1.Location = New System.Drawing.Point(498, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 128)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hint Time"
        '
        'lblHintTime0
        '
        Me.lblHintTime0.AutoSize = True
        Me.lblHintTime0.Location = New System.Drawing.Point(44, 86)
        Me.lblHintTime0.Name = "lblHintTime0"
        Me.lblHintTime0.Size = New System.Drawing.Size(18, 20)
        Me.lblHintTime0.TabIndex = 5
        Me.lblHintTime0.Text = "0"
        '
        'lblHintTime30
        '
        Me.lblHintTime30.AutoSize = True
        Me.lblHintTime30.Location = New System.Drawing.Point(302, 86)
        Me.lblHintTime30.Name = "lblHintTime30"
        Me.lblHintTime30.Size = New System.Drawing.Size(27, 20)
        Me.lblHintTime30.TabIndex = 4
        Me.lblHintTime30.Text = "30"
        '
        'lblHintTime15
        '
        Me.lblHintTime15.AutoSize = True
        Me.lblHintTime15.Location = New System.Drawing.Point(167, 86)
        Me.lblHintTime15.Name = "lblHintTime15"
        Me.lblHintTime15.Size = New System.Drawing.Size(27, 20)
        Me.lblHintTime15.TabIndex = 3
        Me.lblHintTime15.Text = "15"
        '
        'tbHintTime
        '
        Me.tbHintTime.Location = New System.Drawing.Point(31, 37)
        Me.tbHintTime.Name = "tbHintTime"
        Me.tbHintTime.Size = New System.Drawing.Size(299, 69)
        Me.tbHintTime.TabIndex = 0
        Me.tbHintTime.Value = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblCountDownTime0)
        Me.GroupBox2.Controls.Add(Me.lblCountDownTime60)
        Me.GroupBox2.Controls.Add(Me.lblCountDownTime30)
        Me.GroupBox2.Controls.Add(Me.tbCountDownTime)
        Me.GroupBox2.Location = New System.Drawing.Point(498, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 128)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Count Down Time"
        '
        'lblCountDownTime0
        '
        Me.lblCountDownTime0.AutoSize = True
        Me.lblCountDownTime0.Location = New System.Drawing.Point(44, 86)
        Me.lblCountDownTime0.Name = "lblCountDownTime0"
        Me.lblCountDownTime0.Size = New System.Drawing.Size(18, 20)
        Me.lblCountDownTime0.TabIndex = 5
        Me.lblCountDownTime0.Text = "0"
        '
        'lblCountDownTime60
        '
        Me.lblCountDownTime60.AutoSize = True
        Me.lblCountDownTime60.Location = New System.Drawing.Point(302, 86)
        Me.lblCountDownTime60.Name = "lblCountDownTime60"
        Me.lblCountDownTime60.Size = New System.Drawing.Size(27, 20)
        Me.lblCountDownTime60.TabIndex = 4
        Me.lblCountDownTime60.Text = "60"
        '
        'lblCountDownTime30
        '
        Me.lblCountDownTime30.AutoSize = True
        Me.lblCountDownTime30.Location = New System.Drawing.Point(167, 86)
        Me.lblCountDownTime30.Name = "lblCountDownTime30"
        Me.lblCountDownTime30.Size = New System.Drawing.Size(27, 20)
        Me.lblCountDownTime30.TabIndex = 3
        Me.lblCountDownTime30.Text = "30"
        '
        'tbCountDownTime
        '
        Me.tbCountDownTime.Location = New System.Drawing.Point(31, 37)
        Me.tbCountDownTime.Name = "tbCountDownTime"
        Me.tbCountDownTime.Size = New System.Drawing.Size(299, 69)
        Me.tbCountDownTime.TabIndex = 0
        Me.tbCountDownTime.Value = 5
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 379)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbHintIndex)
        Me.Controls.Add(Me.gbScoreIndex)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.tbScoreIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbScoreIndex.ResumeLayout(False)
        Me.gbScoreIndex.PerformLayout()
        Me.gbHintIndex.ResumeLayout(False)
        Me.gbHintIndex.PerformLayout()
        CType(Me.tbHintIndex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbHintTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbCountDownTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbScoreIndex As System.Windows.Forms.TrackBar
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblScoreIndex1 As System.Windows.Forms.Label
    Friend WithEvents lblScoreIndex2 As System.Windows.Forms.Label
    Friend WithEvents lblScoreIndex0 As System.Windows.Forms.Label
    Friend WithEvents gbScoreIndex As System.Windows.Forms.GroupBox
    Friend WithEvents gbHintIndex As System.Windows.Forms.GroupBox
    Friend WithEvents lblHintIndex0 As System.Windows.Forms.Label
    Friend WithEvents lblHintIndex4 As System.Windows.Forms.Label
    Friend WithEvents lblHintIndex2 As System.Windows.Forms.Label
    Friend WithEvents tbHintIndex As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHintTime0 As System.Windows.Forms.Label
    Friend WithEvents lblHintTime30 As System.Windows.Forms.Label
    Friend WithEvents lblHintTime15 As System.Windows.Forms.Label
    Friend WithEvents tbHintTime As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCountDownTime0 As System.Windows.Forms.Label
    Friend WithEvents lblCountDownTime60 As System.Windows.Forms.Label
    Friend WithEvents lblCountDownTime30 As System.Windows.Forms.Label
    Friend WithEvents tbCountDownTime As System.Windows.Forms.TrackBar
End Class
