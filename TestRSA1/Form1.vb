Public Class Form1

    Dim T As TrataRSA
    Private Sub btnChave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChave.Click
        T = New TrataRSA
        txtPublic.Text = T.Chave(TrataRSA.TipoChave.Publica)
        txtPrivad.Text = T.Chave(TrataRSA.TipoChave.Privada)

    End Sub

    Private Sub btnEnvia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvia.Click
        txtCryp.Text = T.Encrypt(txtMsg.Text).AsBase64String
    End Sub

    Private Sub btnRecebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecebe.Click
        txtDecryp.Text = T.Decrypt(txtCryp.Text).AsString
    End Sub

    Public Shared Function TituloVerApl() As String
        Return My.Application.Info.ProductName & " - " & My.Application.Info.CompanyName & " - " & VersaoApl()
    End Function

    Public Shared Function VersaoApl() As String
        Dim v() As String = Split(My.Application.Info.Version.ToString & ".0.0.0.0", ".")
        Return "V" & Format(Val(v(0)), "00") & "." & Format(Val(v(1)), "00") & "." & Format(Val(v(2)), "00") & "." & Format(Val(v(3)), "00")
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = TituloVerApl()
    End Sub
End Class
