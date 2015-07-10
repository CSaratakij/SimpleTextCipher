Public Class MainForm
    Dim encryptForm As EncryptionForm
    Dim decryptForm As DecryptionForm
    Dim aboutForm As AboutForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        encryptForm = New EncryptionForm
        decryptForm = New DecryptionForm
        aboutForm = New AboutForm
    End Sub

   
    Private Sub btnEncryption_Click(sender As Object, e As EventArgs) Handles btnEncryption.Click
        encryptForm.Show()
    End Sub


    Private Sub btnDecryption_Click(sender As Object, e As EventArgs) Handles btnDecryption.Click
        decryptForm.Show()
    End Sub


    Private Sub lnkAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAbout.LinkClicked
        aboutForm.ShowDialog()
    End Sub
End Class
