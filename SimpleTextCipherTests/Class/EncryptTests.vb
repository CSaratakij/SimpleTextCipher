Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SimpleTextCipher.MyTextCipher

Namespace MyTextCipher.Tests

    <TestClass()> Public Class EncryptTests
        <TestMethod()> Public Sub EncryptTests_UpperCaseText()
            Dim plainText, encryptText As String
            plainText = "HELLO"
            encryptText = TextCipher.Encrypt(plainText)
            Assert.AreEqual("DJ77IMIMXL", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_LowerCaseText()
            Dim plainText, encryptText As String
            plainText = "hello"
            encryptText = TextCipher.Encrypt(plainText)
            Assert.AreEqual("I7QBM1M107", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_UpperCaseTextAndSpace()
            Dim plainText, encryptText As String
            plainText = "HELLO SPACE"
            encryptText = TextCipher.Encrypt(plainText)
            Assert.AreEqual("DJ77IMIMXL4CVOEJFRNM77", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_LowerCaseTextAndSpace()
            Dim plainText, encryptText As String
            plainText = "hello space"
            encryptText = TextCipher.Encrypt(plainText)
            Assert.AreEqual("I7QBM1M1074CE!(;ZPZOQB", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_UpperCaseAndLowerCaseText()
            Dim plainText, encryptText As String
            plainText = "Hello"
            encryptText = TextCipher.Encrypt(plainText)
            Assert.AreEqual("DJQBM1M107", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_QuestionText()
            Dim plainText, encryptText As String
            plainText = "What is your favorite city?"
            encryptText = TextCipher.Encrypt(plainText)
            Assert.AreEqual("EEI7ZPZ^4CKOE!4C?H07FF2$4CQ9ZPFA072$KOZ^QB4CZOKOZ^?H21", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_Number()
            Dim num As Integer = 2015
            Dim encrypText = TextCipher.Encrypt(num)
            Assert.AreEqual("C7PP6BPB", encrypText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_DecimalNumber()
            Dim num As Single = 1.414
            Dim encrypText = TextCipher.Encrypt(num)
            Assert.AreEqual("6BOSGG6BGG", encrypText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_TextNumber()
            Dim num As String = "2015"
            Dim encrypText = TextCipher.Encrypt(num)
            Assert.AreEqual("C7PP6BPB", encrypText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_TextDecimalNumber()
            Dim num As String = "1.414"
            Dim encryptText = TextCipher.Encrypt(num)
            Assert.AreEqual("6BOSGG6BGG", encryptText)
        End Sub


        <TestMethod()> Public Sub EncryptTests_ArithmeticText()
            Dim arithmeticStatement As String = "20 + (4*2)/2 = 24"
            Dim encryptText = TextCipher.Encrypt(arithmeticStatement)
            Assert.AreEqual("C7PP4CIP4CJJGGMUC7GRDAC74CEY4CC7GG", encryptText)
        End Sub
    End Class

End Namespace
