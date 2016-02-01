Public Class HowToDecryptionForm
    Private Sub HowToDecryptionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class