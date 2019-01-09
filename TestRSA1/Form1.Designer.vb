<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnChave = New System.Windows.Forms.Button
        Me.txtPublic = New System.Windows.Forms.TextBox
        Me.txtPrivad = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMsg = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDecryp = New System.Windows.Forms.TextBox
        Me.btnEnvia = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCryp = New System.Windows.Forms.TextBox
        Me.btnRecebe = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnChave
        '
        Me.btnChave.Location = New System.Drawing.Point(22, 18)
        Me.btnChave.Name = "btnChave"
        Me.btnChave.Size = New System.Drawing.Size(82, 37)
        Me.btnChave.TabIndex = 0
        Me.btnChave.Text = "Gera Chave"
        Me.btnChave.UseVisualStyleBackColor = True
        '
        'txtPublic
        '
        Me.txtPublic.Location = New System.Drawing.Point(195, 18)
        Me.txtPublic.Multiline = True
        Me.txtPublic.Name = "txtPublic"
        Me.txtPublic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPublic.Size = New System.Drawing.Size(396, 61)
        Me.txtPublic.TabIndex = 1
        '
        'txtPrivad
        '
        Me.txtPrivad.Location = New System.Drawing.Point(195, 83)
        Me.txtPrivad.Multiline = True
        Me.txtPrivad.Name = "txtPrivad"
        Me.txtPrivad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrivad.Size = New System.Drawing.Size(396, 61)
        Me.txtPrivad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pública"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Privada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Criptografa com a chave pública"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Decriptografa com a chave privada"
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(86, 181)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMsg.Size = New System.Drawing.Size(504, 36)
        Me.txtMsg.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mensagem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Mensagem"
        '
        'txtDecryp
        '
        Me.txtDecryp.Location = New System.Drawing.Point(86, 340)
        Me.txtDecryp.Multiline = True
        Me.txtDecryp.Name = "txtDecryp"
        Me.txtDecryp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecryp.Size = New System.Drawing.Size(505, 36)
        Me.txtDecryp.TabIndex = 7
        '
        'btnEnvia
        '
        Me.btnEnvia.Location = New System.Drawing.Point(86, 223)
        Me.btnEnvia.Name = "btnEnvia"
        Me.btnEnvia.Size = New System.Drawing.Size(89, 23)
        Me.btnEnvia.TabIndex = 9
        Me.btnEnvia.Text = "Envia"
        Me.btnEnvia.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Crypto"
        '
        'txtCryp
        '
        Me.txtCryp.Location = New System.Drawing.Point(86, 259)
        Me.txtCryp.Multiline = True
        Me.txtCryp.Name = "txtCryp"
        Me.txtCryp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCryp.Size = New System.Drawing.Size(504, 36)
        Me.txtCryp.TabIndex = 10
        '
        'btnRecebe
        '
        Me.btnRecebe.Location = New System.Drawing.Point(86, 310)
        Me.btnRecebe.Name = "btnRecebe"
        Me.btnRecebe.Size = New System.Drawing.Size(89, 23)
        Me.btnRecebe.TabIndex = 12
        Me.btnRecebe.Text = "Recebe"
        Me.btnRecebe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 420)
        Me.Controls.Add(Me.btnRecebe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCryp)
        Me.Controls.Add(Me.btnEnvia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDecryp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrivad)
        Me.Controls.Add(Me.txtPublic)
        Me.Controls.Add(Me.btnChave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChave As System.Windows.Forms.Button
    Friend WithEvents txtPublic As System.Windows.Forms.TextBox
    Friend WithEvents txtPrivad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDecryp As System.Windows.Forms.TextBox
    Friend WithEvents btnEnvia As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCryp As System.Windows.Forms.TextBox
    Friend WithEvents btnRecebe As System.Windows.Forms.Button

End Class
