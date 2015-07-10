<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEncryption = New System.Windows.Forms.Button()
        Me.btnDecryption = New System.Windows.Forms.Button()
        Me.lnkAbout = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnEncryption
        '
        Me.btnEncryption.Location = New System.Drawing.Point(12, 40)
        Me.btnEncryption.Name = "btnEncryption"
        Me.btnEncryption.Size = New System.Drawing.Size(244, 88)
        Me.btnEncryption.TabIndex = 0
        Me.btnEncryption.Text = "Encryption"
        Me.btnEncryption.UseVisualStyleBackColor = True
        '
        'btnDecryption
        '
        Me.btnDecryption.Location = New System.Drawing.Point(12, 143)
        Me.btnDecryption.Name = "btnDecryption"
        Me.btnDecryption.Size = New System.Drawing.Size(244, 88)
        Me.btnDecryption.TabIndex = 1
        Me.btnDecryption.Text = "Decryption"
        Me.btnDecryption.UseVisualStyleBackColor = True
        '
        'lnkAbout
        '
        Me.lnkAbout.AutoSize = True
        Me.lnkAbout.Location = New System.Drawing.Point(221, 265)
        Me.lnkAbout.Name = "lnkAbout"
        Me.lnkAbout.Size = New System.Drawing.Size(35, 13)
        Me.lnkAbout.TabIndex = 3
        Me.lnkAbout.TabStop = True
        Me.lnkAbout.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 287)
        Me.Controls.Add(Me.lnkAbout)
        Me.Controls.Add(Me.btnDecryption)
        Me.Controls.Add(Me.btnEncryption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "SimpleTextCipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncryption As System.Windows.Forms.Button
    Friend WithEvents btnDecryption As System.Windows.Forms.Button
    Friend WithEvents lnkAbout As System.Windows.Forms.LinkLabel

End Class
