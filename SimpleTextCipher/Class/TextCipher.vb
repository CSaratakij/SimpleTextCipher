Namespace MyTextCipher

    Public NotInheritable Class TextCipher

        Public Shared Function Encrypt(ByVal text As String) As String
            Dim alphabet As Char() = text.ToCharArray
            Dim encryptText As String = ""

            For i = 0 To alphabet.Length - 1

                Select Case alphabet(i)

                    Case Decryption.A
                        encryptText += Encryption.A

                    Case Decryption.B
                        encryptText += Encryption.B

                    Case Decryption.C
                        encryptText += Encryption.C

                    Case Decryption.D
                        encryptText += Encryption.D

                    Case Decryption.E
                        encryptText += Encryption.E

                    Case Decryption.F
                        encryptText += Encryption.F

                    Case Decryption.G
                        encryptText += Encryption.G

                    Case Decryption.H
                        encryptText += Encryption.H

                    Case Decryption.I
                        encryptText += Encryption.I

                    Case Decryption.J
                        encryptText += Encryption.J

                    Case Decryption.K
                        encryptText += Encryption.K

                    Case Decryption.L
                        encryptText += Encryption.L

                    Case Decryption.M
                        encryptText += Encryption.M

                    Case Decryption.N
                        encryptText += Encryption.N

                    Case Decryption.O
                        encryptText += Encryption.O

                    Case Decryption.P
                        encryptText += Encryption.P

                    Case Decryption.Q
                        encryptText += Encryption.Q

                    Case Decryption.R
                        encryptText += Encryption.R

                    Case Decryption.S
                        encryptText += Encryption.S

                    Case Decryption.T
                        encryptText += Encryption.T

                    Case Decryption.U
                        encryptText += Encryption.U

                    Case Decryption.V
                        encryptText += Encryption.V

                    Case Decryption.W
                        encryptText += Encryption.W

                    Case Decryption.X
                        encryptText += Encryption.X

                    Case Decryption.Y
                        encryptText += Encryption.Y

                    Case Decryption.Z
                        encryptText += Encryption.Z

                    Case Decryption.LowerCaseA
                        encryptText += Encryption.LowerCaseA

                    Case Decryption.LowerCaseB
                        encryptText += Encryption.LowerCaseB

                    Case Decryption.LowerCaseC
                        encryptText += Encryption.LowerCaseC

                    Case Decryption.LowerCaseD
                        encryptText += Encryption.LowerCaseD

                    Case Decryption.LowerCaseE
                        encryptText += Encryption.LowerCaseE

                    Case Decryption.LowerCaseF
                        encryptText += Encryption.LowerCaseF

                    Case Decryption.LowerCaseG
                        encryptText += Encryption.LowerCaseG

                    Case Decryption.LowerCaseH
                        encryptText += Encryption.LowerCaseH

                    Case Decryption.LowerCaseI
                        encryptText += Encryption.LowerCaseI

                    Case Decryption.LowerCaseJ
                        encryptText += Encryption.LowerCaseJ

                    Case Decryption.LowerCaseK
                        encryptText += Encryption.LowerCaseK

                    Case Decryption.LowerCaseL
                        encryptText += Encryption.LowerCaseL

                    Case Decryption.LowerCaseM
                        encryptText += Encryption.LowerCaseM

                    Case Decryption.LowerCaseN
                        encryptText += Encryption.LowerCaseN

                    Case Decryption.LowerCaseO
                        encryptText += Encryption.LowerCaseO

                    Case Decryption.LowerCaseP
                        encryptText += Encryption.LowerCaseP

                    Case Decryption.LowerCaseQ
                        encryptText += Encryption.LowerCaseQ

                    Case Decryption.LowerCaseR
                        encryptText += Encryption.LowerCaseR

                    Case Decryption.LowerCaseS
                        encryptText += Encryption.LowerCaseS

                    Case Decryption.LowerCaseT
                        encryptText += Encryption.LowerCaseT

                    Case Decryption.LowerCaseU
                        encryptText += Encryption.LowerCaseU

                    Case Decryption.LowerCaseV
                        encryptText += Encryption.LowerCaseV

                    Case Decryption.LowerCaseW
                        encryptText += Encryption.LowerCaseW

                    Case Decryption.LowerCaseX
                        encryptText += Encryption.LowerCaseX

                    Case Decryption.LowerCaseY
                        encryptText += Encryption.LowerCaseY

                    Case Decryption.LowerCaseZ
                        encryptText += Encryption.LowerCaseZ

                    Case Decryption.NUM_0
                        encryptText += Encryption.NUM_0

                    Case Decryption.NUM_1
                        encryptText += Encryption.NUM_1

                    Case Decryption.NUM_2
                        encryptText += Encryption.NUM_2

                    Case Decryption.NUM_3
                        encryptText += Encryption.NUM_3

                    Case Decryption.NUM_4
                        encryptText += Encryption.NUM_4

                    Case Decryption.NUM_5
                        encryptText += Encryption.NUM_5

                    Case Decryption.NUM_6
                        encryptText += Encryption.NUM_6

                    Case Decryption.NUM_7
                        encryptText += Encryption.NUM_7

                    Case Decryption.NUM_8
                        encryptText += Encryption.NUM_8

                    Case Decryption.NUM_9
                        encryptText += Encryption.NUM_9

                    Case Decryption.SpaceBar
                        encryptText += Encryption.SpaceBar

                    Case Decryption.Dot
                        encryptText += Encryption.Dot

                    Case Decryption.ExclamationMark
                        encryptText += Encryption.ExclamationMark

                    Case Decryption.QuestionMark
                        encryptText += Encryption.QuestionMark

                    Case Decryption.SingleQuote
                        encryptText += Encryption.SingleQuote

                    Case Decryption.DoubleQuote
                        encryptText += Encryption.DoubleQuote

                    Case Decryption.Comma
                        encryptText += Encryption.Comma

                    Case Decryption.Colon
                        encryptText += Encryption.Colon

                    Case Decryption.SemiColon
                        encryptText += Encryption.SemiColon

                    Case Decryption.OpenParenthesis
                        encryptText += Encryption.OpenParenthesis

                    Case Decryption.CloseParenthesis
                        encryptText += Encryption.CloseParenthesis

                    Case Decryption.Plus
                        encryptText += Encryption.Plus

                    Case Decryption.Minus
                        encryptText += Encryption.Minus

                    Case Decryption.Asterisk
                        encryptText += Encryption.Asterisk

                    Case Decryption.ForwardSlash
                        encryptText += Encryption.ForwardSlash

                    Case Decryption.BackSlash
                        encryptText += Encryption.BackSlash

                    Case Decryption.UnderScore
                        encryptText += Encryption.UnderScore

                    Case Decryption.OpenBracket
                        encryptText += Encryption.OpenBracket

                    Case Decryption.CloseBracket
                        encryptText += Encryption.CloseBracket

                    Case Decryption.OpenCurlyBracket
                        encryptText += Encryption.OpenCurlyBracket

                    Case Decryption.CloseCurlyBracket
                        encryptText += Encryption.CloseCurlyBracket

                    Case Decryption.Ampersand
                        encryptText += Encryption.Ampersand

                    Case Decryption.Caret
                        encryptText += Encryption.Caret

                    Case Decryption.AtSign
                        encryptText += Encryption.AtSign

                    Case Decryption.PercentSign
                        encryptText += Encryption.PercentSign

                    Case Decryption.VerticalBar
                        encryptText += Encryption.VerticalBar

                    Case Decryption.GraveAccent
                        encryptText += Encryption.GraveAccent

                    Case Decryption.Tilde
                        encryptText += Encryption.Tilde

                    Case Decryption.LessThanSign
                        encryptText += Encryption.LessThanSign

                    Case Decryption.GreaterThanSign
                        encryptText += Encryption.GreaterThanSign

                    Case Decryption.BrokenBar
                        encryptText += Encryption.BrokenBar

                    Case Decryption.NumberSign
                        encryptText += Encryption.NumberSign

                    Case Decryption.DollarSign
                        encryptText += Encryption.DollarSign

                    Case Decryption.PoundSign
                        encryptText += Encryption.PoundSign

                    Case Decryption.BahtSign
                        encryptText += Encryption.BahtSign

                    Case Decryption.EqualSign
                        encryptText += Encryption.EqualSign

                End Select
            Next

            Return encryptText

        End Function


        Public Shared Function Decrypt(ByVal text As String) As String
            Dim encryptText As Char() = text.ToCharArray
            Dim decryptText As String = ""
            Dim checkText As String = ""
            Dim stepNum As Integer = 0

            For i = 0 To encryptText.Length - 1
                checkText += encryptText(i)
                stepNum += 1

                If stepNum = 2 Then
                    stepNum = 0

                    Select Case checkText

                        Case Encryption.A
                            decryptText += Decryption.A

                        Case Encryption.B
                            decryptText += Decryption.B

                        Case Encryption.C
                            decryptText += Decryption.C

                        Case Encryption.D
                            decryptText += Decryption.D

                        Case Encryption.E
                            decryptText += Decryption.E

                        Case Encryption.F
                            decryptText += Decryption.F

                        Case Encryption.G
                            decryptText += Decryption.G

                        Case Encryption.H
                            decryptText += Decryption.H

                        Case Encryption.I
                            decryptText += Decryption.I

                        Case Encryption.J
                            decryptText += Decryption.J

                        Case Encryption.K
                            decryptText += Decryption.K

                        Case Encryption.L
                            decryptText += Decryption.L

                        Case Encryption.M
                            decryptText += Decryption.M

                        Case Encryption.N
                            decryptText += Decryption.N

                        Case Encryption.O
                            decryptText += Decryption.O

                        Case Encryption.P
                            decryptText += Decryption.P

                        Case Encryption.Q
                            decryptText += Decryption.Q

                        Case Encryption.R
                            decryptText += Decryption.R

                        Case Encryption.S
                            decryptText += Decryption.S

                        Case Encryption.T
                            decryptText += Decryption.T

                        Case Encryption.U
                            decryptText += Decryption.U

                        Case Encryption.V
                            decryptText += Decryption.V

                        Case Encryption.W
                            decryptText += Decryption.W

                        Case Encryption.X
                            decryptText += Decryption.X

                        Case Encryption.Y
                            decryptText += Decryption.Y

                        Case Encryption.Z
                            decryptText += Decryption.Z

                        Case Encryption.LowerCaseA
                            decryptText += Decryption.LowerCaseA

                        Case Encryption.LowerCaseB
                            decryptText += Decryption.LowerCaseB

                        Case Encryption.LowerCaseC
                            decryptText += Decryption.LowerCaseC

                        Case Encryption.LowerCaseD
                            decryptText += Decryption.LowerCaseD

                        Case Encryption.LowerCaseE
                            decryptText += Decryption.LowerCaseE

                        Case Encryption.LowerCaseF
                            decryptText += Decryption.LowerCaseF

                        Case Encryption.LowerCaseG
                            decryptText += Decryption.LowerCaseG

                        Case Encryption.LowerCaseH
                            decryptText += Decryption.LowerCaseH

                        Case Encryption.LowerCaseI
                            decryptText += Decryption.LowerCaseI

                        Case Encryption.LowerCaseJ
                            decryptText += Decryption.LowerCaseJ

                        Case Encryption.LowerCaseK
                            decryptText += Decryption.LowerCaseK

                        Case Encryption.LowerCaseL
                            decryptText += Decryption.LowerCaseL

                        Case Encryption.LowerCaseM
                            decryptText += Decryption.LowerCaseM

                        Case Encryption.LowerCaseN
                            decryptText += Decryption.LowerCaseN

                        Case Encryption.LowerCaseO
                            decryptText += Decryption.LowerCaseO

                        Case Encryption.LowerCaseP
                            decryptText += Decryption.LowerCaseP

                        Case Encryption.LowerCaseQ
                            decryptText += Decryption.LowerCaseQ

                        Case Encryption.LowerCaseR
                            decryptText += Decryption.LowerCaseR

                        Case Encryption.LowerCaseS
                            decryptText += Decryption.LowerCaseS

                        Case Encryption.LowerCaseT
                            decryptText += Decryption.LowerCaseT

                        Case Encryption.LowerCaseU
                            decryptText += Decryption.LowerCaseU

                        Case Encryption.LowerCaseV
                            decryptText += Decryption.LowerCaseV

                        Case Encryption.LowerCaseW
                            decryptText += Decryption.LowerCaseW

                        Case Encryption.LowerCaseX
                            decryptText += Decryption.LowerCaseX

                        Case Encryption.LowerCaseY
                            decryptText += Decryption.LowerCaseY

                        Case Encryption.LowerCaseZ
                            decryptText += Decryption.LowerCaseZ

                        Case Encryption.NUM_0
                            decryptText += Decryption.NUM_0

                        Case Encryption.NUM_1
                            decryptText += Decryption.NUM_1

                        Case Encryption.NUM_2
                            decryptText += Decryption.NUM_2

                        Case Encryption.NUM_3
                            decryptText += Decryption.NUM_3

                        Case Encryption.NUM_4
                            decryptText += Decryption.NUM_4

                        Case Encryption.NUM_5
                            decryptText += Decryption.NUM_5

                        Case Encryption.NUM_6
                            decryptText += Decryption.NUM_6

                        Case Encryption.NUM_7
                            decryptText += Decryption.NUM_7

                        Case Encryption.NUM_8
                            decryptText += Decryption.NUM_8

                        Case Encryption.NUM_9
                            decryptText += Decryption.NUM_9

                        Case Encryption.SpaceBar
                            decryptText += Decryption.SpaceBar

                        Case Encryption.Dot
                            decryptText += Decryption.Dot

                        Case Encryption.ExclamationMark
                            decryptText += Decryption.ExclamationMark

                        Case Encryption.QuestionMark
                            decryptText += Decryption.QuestionMark

                        Case Encryption.SingleQuote
                            decryptText += Decryption.SingleQuote

                        Case Encryption.DoubleQuote
                            decryptText += Decryption.DoubleQuote

                        Case Encryption.Comma
                            decryptText += Decryption.Comma

                        Case Encryption.Colon
                            decryptText += Decryption.Colon

                        Case Encryption.SemiColon
                            decryptText += Decryption.SemiColon

                        Case Encryption.OpenParenthesis
                            decryptText += Decryption.OpenParenthesis

                        Case Encryption.CloseParenthesis
                            decryptText += Decryption.CloseParenthesis

                        Case Encryption.Plus
                            decryptText += Decryption.Plus

                        Case Encryption.Minus
                            decryptText += Decryption.Minus

                        Case Encryption.Asterisk
                            decryptText += Decryption.Asterisk

                        Case Encryption.ForwardSlash
                            decryptText += Decryption.ForwardSlash

                        Case Encryption.BackSlash
                            decryptText += Decryption.BackSlash

                        Case Encryption.UnderScore
                            decryptText += Decryption.UnderScore

                        Case Encryption.OpenBracket
                            decryptText += Decryption.OpenBracket

                        Case Encryption.CloseBracket
                            decryptText += Decryption.CloseBracket

                        Case Encryption.OpenCurlyBracket
                            decryptText += Decryption.OpenCurlyBracket

                        Case Encryption.CloseCurlyBracket
                            decryptText += Decryption.CloseCurlyBracket

                        Case Encryption.Ampersand
                            decryptText += Decryption.Ampersand

                        Case Encryption.Caret
                            decryptText += Decryption.Caret

                        Case Encryption.AtSign
                            decryptText += Decryption.AtSign

                        Case Encryption.PercentSign
                            decryptText += Decryption.PercentSign

                        Case Encryption.VerticalBar
                            decryptText += Decryption.VerticalBar

                        Case Encryption.GraveAccent
                            decryptText += Decryption.GraveAccent

                        Case Encryption.Tilde
                            decryptText += Decryption.Tilde

                        Case Encryption.LessThanSign
                            decryptText += Decryption.LessThanSign

                        Case Encryption.GreaterThanSign
                            decryptText += Decryption.GreaterThanSign

                        Case Encryption.BrokenBar
                            decryptText += Decryption.BrokenBar

                        Case Encryption.NumberSign
                            decryptText += Decryption.NumberSign

                        Case Encryption.DollarSign
                            decryptText += Decryption.DollarSign

                        Case Encryption.PoundSign
                            decryptText += Decryption.PoundSign

                        Case Encryption.BahtSign
                            decryptText += Decryption.BahtSign

                        Case Encryption.EqualSign
                            decryptText += Decryption.EqualSign

                    End Select

                    checkText = ""

                End If
            Next

            Return decryptText
        End Function
    End Class

End Namespace
