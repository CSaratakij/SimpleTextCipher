Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SimpleTextCipher.MyTextCipher

Namespace MyTextCipher.Tests

    <TestClass()> Public Class DecryptTests
        <TestMethod()> Public Sub DecryptionTests_UpperCaseText()
            Dim encryptText, decryptText As String
            encryptText = "DJ77IMIMXL"
            decryptText = TextCipher.Decrypt(encryptText)
            Assert.AreEqual("HELLO", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_LowerCaseText()
            Dim encryptText, decryptText As String
            encryptText = "I7QBM1M107"
            decryptText = TextCipher.Decrypt(encryptText)
            Assert.AreEqual("hello", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_UpperCaseTextAndSpace()
            Dim encryptText, decryptText As String
            encryptText = "DJ77IMIMXL4CVOEJFRNM77"
            decryptText = TextCipher.Decrypt(encryptText)
            Assert.AreEqual("HELLO SPACE", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_LowerCaseTextAndSpace()
            Dim encryptText, decryptText As String
            encryptText = "I7QBM1M1074CE!(;ZPZOQB"
            decryptText = TextCipher.Decrypt(encryptText)
            Assert.AreEqual("hello space", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_UpperCaseAndLowerCaseText()
            Dim encryptText, decryptText As String
            encryptText = "DJQBM1M107"
            decryptText = TextCipher.Decrypt(encryptText)
            Assert.AreEqual("Hello", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_QuestionText()
            Dim encryptText, decryptText As String
            encryptText = "EEI7ZPZ^4CKOE!4C?H07FF2$4CQ9ZPFA072$KOZ^QB4CZOKOZ^?H21"
            decryptText = TextCipher.Decrypt(encryptText)
            Assert.AreEqual("What is your favorite city?", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_Number()
            Dim numText As String = "C7PP6BPB"
            Dim decryptText = TextCipher.Decrypt(numText)
            Assert.AreEqual("2015", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_DecimalNumber()
            Dim numText As String = "6BOSGG6BGG"
            Dim decryptText = TextCipher.Decrypt(numText)
            Assert.AreEqual("1.414", decryptText)
        End Sub


        <TestMethod()> Public Sub DecryptionTests_ArithmeticText()
            Dim arithmeticStatement As String = "C7PP4CIP4CJJGGMUC7GRDAC74CEY4CC7GG"
            Dim decryptText = TextCipher.Decrypt(arithmeticStatement)
            Assert.AreEqual("20 + (4*2)/2 = 24", decryptText)
        End Sub
    End Class

End Namespace

