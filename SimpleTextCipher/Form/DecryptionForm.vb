Imports SimpleTextCipher.MyTextCipher

Public Class DecryptionForm

    Private Sub DecryptionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rchText.Text = ""
    End Sub


    Private Sub btnDecrypts_Click(sender As Object, e As EventArgs) Handles btnDecrypts.Click
        rchText.Text = TextCipher.Decrypt(rchText.Text)
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If Not rchText.Text.Equals("") Then
            Clipboard.SetText(rchText.Text)
        End If
    End Sub


    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        rchText.Text = Clipboard.GetText()
    End Sub
End Class