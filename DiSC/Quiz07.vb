Public Class Quiz07

    Public most() As Integer = Quiz06.most  'Array for keeping most value
    Public least() As Integer = Quiz06.least 'Array for keeping least value

    Dim ansM As Integer 'Most's answer parameter
    Dim ansL As Integer 'Least's answer parameter

    Dim Degree() As String = {"Most", "Least"}

    Dim Quiz() As String = {"Sensitive, Becomes frustrated", "Stand up to opposition, right",
                            "Complacent, keeps feelings inside", "Tell my side of the story, want to be heard"}


    'Load Event
    Private Sub Quiz07_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NextButton.Enabled = False

        MostLabel.Text = Degree(0)
        LeastLabel.Text = Degree(1)

        For i As Integer = 0 To 3
            Controls("Label" & CStr(i + 1)).Text = Quiz(i)
        Next i

    End Sub

    Private Sub MostGroupBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles MButton1.CheckedChanged, MButton2.CheckedChanged,
        MButton3.CheckedChanged, MButton4.CheckedChanged

        ansM = CType(sender, RadioButton).TabIndex

    End Sub

    Private Sub LeastGroupBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles LButton1.CheckedChanged, LButton2.CheckedChanged,
        LButton3.CheckedChanged, LButton4.CheckedChanged

        ansL = CType(sender, RadioButton).TabIndex

        If MostPanel.Enabled Then
            NextButton.Enabled = True
        End If

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        ' Most value case
        Select Case ansM
            Case 0
                most(3) += 1
            Case 1
                most(0) += 1
            Case 2
                most(2) += 1
            Case 3
                most(4) += 0
        End Select

        ' Least value case
        Select Case ansL
            Case 0
                least(3) += 1
            Case 1
                least(0) += 1
            Case 2
                least(2) += 1
            Case 3
                least(1) += 1
        End Select

        Me.Hide()
        Quiz08.Show()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Quiz06.Show()
    End Sub

    Private Sub Quiz07_FormClosing _
        (sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim dialog As DialogResult

        dialog = MessageBox.Show("All your anwser will be lost, Are your sure?",
                            "Alert!", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub
End Class
