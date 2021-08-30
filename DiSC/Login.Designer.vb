<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.AccessButton = New System.Windows.Forms.Button()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserTextBox
        '
        Me.UserTextBox.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.UserTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.UserTextBox.Location = New System.Drawing.Point(279, 239)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(185, 19)
        Me.UserTextBox.TabIndex = 2
        '
        'AccessButton
        '
        Me.AccessButton.BackColor = System.Drawing.Color.CornflowerBlue
        Me.AccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccessButton.ForeColor = System.Drawing.Color.White
        Me.AccessButton.Location = New System.Drawing.Point(331, 292)
        Me.AccessButton.Name = "AccessButton"
        Me.AccessButton.Size = New System.Drawing.Size(75, 23)
        Me.AccessButton.TabIndex = 3
        Me.AccessButton.Text = "Access"
        Me.AccessButton.UseVisualStyleBackColor = False
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.BackColor = System.Drawing.Color.Silver
        Me.UserLabel.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.Location = New System.Drawing.Point(325, 203)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(99, 33)
        Me.UserLabel.TabIndex = 1
        Me.UserLabel.Text = "USER :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(711, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.AccessButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(704, 407)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.AccessButton)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents AccessButton As Button
    Friend WithEvents UserLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
