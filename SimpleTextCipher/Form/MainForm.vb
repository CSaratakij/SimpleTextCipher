Public Class MainForm
    Dim encryptForm As EncryptionForm
    Dim decryptForm As DecryptionForm
    Dim aboutForm As AboutForm
    Dim howToEncryption As HowToEncryptionForm
    Dim howTodecryption As HowToDecryptionForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        encryptForm = New EncryptionForm
        decryptForm = New DecryptionForm
        aboutForm = New AboutForm
        howToEncryption = New HowToEncryptionForm
        howTodecryption = New HowToDecryptionForm
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

    Private Sub lnkEncryption_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEncryption.LinkClicked
        howToEncryption.Show()
    End Sub

    Private Sub lnkDescription_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDescription.LinkClicked
        howTodecryption.Show()
    End Sub
End Class
