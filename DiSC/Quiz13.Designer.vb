<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quiz13
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MButton1 = New System.Windows.Forms.RadioButton()
        Me.MButton2 = New System.Windows.Forms.RadioButton()
        Me.MButton3 = New System.Windows.Forms.RadioButton()
        Me.MButton4 = New System.Windows.Forms.RadioButton()
        Me.MostGroupBox = New System.Windows.Forms.GroupBox()
        Me.MostPanel = New System.Windows.Forms.Panel()
        Me.MostLabel = New System.Windows.Forms.Label()
        Me.LeastGroupBox = New System.Windows.Forms.GroupBox()
        Me.LeastPanel = New System.Windows.Forms.Panel()
        Me.LButton4 = New System.Windows.Forms.RadioButton()
        Me.LButton3 = New System.Windows.Forms.RadioButton()
        Me.LButton2 = New System.Windows.Forms.RadioButton()
        Me.LButton1 = New System.Windows.Forms.RadioButton()
        Me.LeastLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.MostGroupBox.SuspendLayout()
        Me.MostPanel.SuspendLayout()
        Me.LeastGroupBox.SuspendLayout()
        Me.LeastPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(400, 201)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(89, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(243, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(388, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(114, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(536, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MButton1
        '
        Me.MButton1.AutoSize = True
        Me.MButton1.Location = New System.Drawing.Point(18, 9)
        Me.MButton1.Name = "MButton1"
        Me.MButton1.Size = New System.Drawing.Size(14, 13)
        Me.MButton1.TabIndex = 0
        Me.MButton1.TabStop = True
        Me.MButton1.UseVisualStyleBackColor = True
        '
        'MButton2
        '
        Me.MButton2.AutoSize = True
        Me.MButton2.Location = New System.Drawing.Point(167, 9)
        Me.MButton2.Name = "MButton2"
        Me.MButton2.Size = New System.Drawing.Size(14, 13)
        Me.MButton2.TabIndex = 1
        Me.MButton2.TabStop = True
        Me.MButton2.UseVisualStyleBackColor = True
        '
        'MButton3
        '
        Me.MButton3.AutoSize = True
        Me.MButton3.Location = New System.Drawing.Point(316, 9)
        Me.MButton3.Name = "MButton3"
        Me.MButton3.Size = New System.Drawing.Size(14, 13)
        Me.MButton3.TabIndex = 2
        Me.MButton3.TabStop = True
        Me.MButton3.UseVisualStyleBackColor = True
        '
        'MButton4
        '
        Me.MButton4.AutoSize = True
        Me.MButton4.Location = New System.Drawing.Point(465, 9)
        Me.MButton4.Name = "MButton4"
        Me.MButton4.Size = New System.Drawing.Size(14, 13)
        Me.MButton4.TabIndex = 3
        Me.MButton4.TabStop = True
        Me.MButton4.UseVisualStyleBackColor = True
        '
        'MostGroupBox
        '
        Me.MostGroupBox.Controls.Add(Me.MostPanel)
        Me.MostGroupBox.Controls.Add(Me.MostLabel)
        Me.MostGroupBox.Location = New System.Drawing.Point(14, 80)
        Me.MostGroupBox.Name = "MostGroupBox"
        Me.MostGroupBox.Size = New System.Drawing.Size(661, 41)
        Me.MostGroupBox.TabIndex = 0
        Me.MostGroupBox.TabStop = False
        '
        'MostPanel
        '
        Me.MostPanel.Controls.Add(Me.MButton4)
        Me.MostPanel.Controls.Add(Me.MButton3)
        Me.MostPanel.Controls.Add(Me.MButton2)
        Me.MostPanel.Controls.Add(Me.MButton1)
        Me.MostPanel.Location = New System.Drawing.Point(104, 10)
        Me.MostPanel.Name = "MostPanel"
        Me.MostPanel.Size = New System.Drawing.Size(545, 25)
        Me.MostPanel.TabIndex = 5
        '
        'MostLabel
        '
        Me.MostLabel.AutoSize = True
        Me.MostLabel.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MostLabel.Location = New System.Drawing.Point(23, 17)
        Me.MostLabel.Name = "MostLabel"
        Me.MostLabel.Size = New System.Drawing.Size(35, 13)
        Me.MostLabel.TabIndex = 4
        Me.MostLabel.Text = "Most"
        '
        'LeastGroupBox
        '
        Me.LeastGroupBox.Controls.Add(Me.LeastPanel)
        Me.LeastGroupBox.Controls.Add(Me.LeastLabel)
        Me.LeastGroupBox.Location = New System.Drawing.Point(14, 121)
        Me.LeastGroupBox.Name = "LeastGroupBox"
        Me.LeastGroupBox.Size = New System.Drawing.Size(661, 41)
        Me.LeastGroupBox.TabIndex = 1
        Me.LeastGroupBox.TabStop = False
        '
        'LeastPanel
        '
        Me.LeastPanel.Controls.Add(Me.LButton4)
        Me.LeastPanel.Controls.Add(Me.LButton3)
        Me.LeastPanel.Controls.Add(Me.LButton2)
        Me.LeastPanel.Controls.Add(Me.LButton1)
        Me.LeastPanel.Location = New System.Drawing.Point(105, 9)
        Me.LeastPanel.Name = "LeastPanel"
        Me.LeastPanel.Size = New System.Drawing.Size(543, 27)
        Me.LeastPanel.TabIndex = 5
        '
        'LButton4
        '
        Me.LButton4.AutoSize = True
        Me.LButton4.Location = New System.Drawing.Point(465, 6)
        Me.LButton4.Name = "LButton4"
        Me.LButton4.Size = New System.Drawing.Size(14, 13)
        Me.LButton4.TabIndex = 3
        Me.LButton4.TabStop = True
        Me.LButton4.UseVisualStyleBackColor = True
        '
        'LButton3
        '
        Me.LButton3.AutoSize = True
        Me.LButton3.Location = New System.Drawing.Point(316, 6)
        Me.LButton3.Name = "LButton3"
        Me.LButton3.Size = New System.Drawing.Size(14, 13)
        Me.LButton3.TabIndex = 2
        Me.LButton3.TabStop = True
        Me.LButton3.UseVisualStyleBackColor = True
        '
        'LButton2
        '
        Me.LButton2.AutoSize = True
        Me.LButton2.Location = New System.Drawing.Point(167, 6)
        Me.LButton2.Name = "LButton2"
        Me.LButton2.Size = New System.Drawing.Size(14, 13)
        Me.LButton2.TabIndex = 1
        Me.LButton2.TabStop = True
        Me.LButton2.UseVisualStyleBackColor = True
        '
        'LButton1
        '
        Me.LButton1.AutoSize = True
        Me.LButton1.Location = New System.Drawing.Point(18, 6)
        Me.LButton1.Name = "LButton1"
        Me.LButton1.Size = New System.Drawing.Size(14, 13)
        Me.LButton1.TabIndex = 0
        Me.LButton1.TabStop = True
        Me.LButton1.UseVisualStyleBackColor = True
        '
        'LeastLabel
        '
        Me.LeastLabel.AutoSize = True
        Me.LeastLabel.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LeastLabel.Location = New System.Drawing.Point(23, 15)
        Me.LeastLabel.Name = "LeastLabel"
        Me.LeastLabel.Size = New System.Drawing.Size(38, 13)
        Me.LeastLabel.TabIndex = 4
        Me.LeastLabel.Text = "Least"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(225, 201)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Quiz12
        '
        Me.AcceptButton = Me.NextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 244)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.MostGroupBox)
        Me.Controls.Add(Me.LeastGroupBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NextButton)
        Me.MaximizeBox = False
        Me.Name = "Quiz12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISC Quiz12"
        Me.MostGroupBox.ResumeLayout(False)
        Me.MostGroupBox.PerformLayout()
        Me.MostPanel.ResumeLayout(False)
        Me.MostPanel.PerformLayout()
        Me.LeastGroupBox.ResumeLayout(False)
        Me.LeastGroupBox.PerformLayout()
        Me.LeastPanel.ResumeLayout(False)
        Me.LeastPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NextButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MButton1 As RadioButton
    Friend WithEvents MButton2 As RadioButton
    Friend WithEvents MButton3 As RadioButton
    Friend WithEvents MButton4 As RadioButton
    Friend WithEvents MostGroupBox As GroupBox
    Friend WithEvents MostLabel As Label
    Friend WithEvents LeastGroupBox As GroupBox
    Friend WithEvents LeastLabel As Label
    Friend WithEvents LButton4 As RadioButton
    Friend WithEvents LButton3 As RadioButton
    Friend WithEvents LButton2 As RadioButton
    Friend WithEvents LButton1 As RadioButton
    Friend WithEvents MostPanel As Panel
    Friend WithEvents LeastPanel As Panel
    Friend WithEvents BackButton As Button
End Class
