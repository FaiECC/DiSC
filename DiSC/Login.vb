Public Class Login

    Public Lang As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLabel.Text = "USER"
        AccessButton.Text = "ACCESS"
        UserTextBox.Focus()
    End Sub

    Private Sub AccessButton_Click(sender As Object, e As EventArgs) Handles AccessButton.Click
        If UserTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter your username", "Alert!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserTextBox.Focus()
        Else
            Me.Hide()
            Quiz01.Show()
        End If

    End Sub

End Class
