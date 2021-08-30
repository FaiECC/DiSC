Public Class Quiz01

    Public most(5) As Integer  'Array for keeping most value
    Public least(5) As Integer 'Array for keeping least value

    Dim ansM As Integer 'Most's answer parameter
    Dim ansL As Integer 'Least's answer parameter

    Dim Degree() As String = {"Most", "Least"}

    Dim Quiz1() As String = {"Trusting, Enthusiastic", "Tolerant, Respectful",
                            "Courageous, Adventurous", "Agreeable, Accommodating"}


    'Load Event
    Private Sub Quiz01_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("Please complete your answer within 5 minutes or as close to that as possible.",
                            "Rules", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        NextButton.Enabled = False

        MostLabel.Text = Degree(0)
        LeastLabel.Text = Degree(1)

        For i As Integer = 0 To 3
            Controls("Label" & CStr(i + 1)).Text = Quiz1(i)
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
                most(1) += 1
            Case 1
                most(3) += 1
            Case 2
                most(4) += 0
            Case 3
                most(2) += 1
        End Select

        ' Least value case
        Select Case ansL
            Case 0
                least(1) += 1
            Case 1
                least(3) += 1
            Case 2
                least(0) += 1
            Case 3
                least(2) += 1
        End Select

        Me.Hide()
        Quiz02.Show()

    End Sub

    Private Sub Quiz01_FormClosing _
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
