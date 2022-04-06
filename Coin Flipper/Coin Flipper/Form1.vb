Public Class CoinFlipperForm

    'Variable for random number generator
    Shared random As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub FlipButton_Click(sender As Object, e As EventArgs) Handles FlipButton.Click
        'When button clicked
        'Generate random number between 1-1000
        Dim flipNum As Integer

        flipNum = random.Next(1, 1000)

        If flipNum Mod 2 = 0 Then
            'If number is EVEN, Option 1 wins
            ResultLabel.Text = Option1TextBox.Text
        Else
            'If number is ODD, Option 2 wins
            ResultLabel.Text = Option2TextBox.Text()
        End If

        flipNum = 0

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Option1TextBox.Text = ""
        Option2TextBox.Text = ""
        ResultLabel.Text = "Result"

    End Sub
End Class
