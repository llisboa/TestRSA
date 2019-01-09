Public Class frmChave

    Dim T As TrataRSA
    Private Sub btnChave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChave.Click
        Try
            T = New TrataRSA
            txtPublic.Text = T.Chave(TrataRSA.TipoChave.Publica)
            txtPrivad.Text = T.Chave(TrataRSA.TipoChave.Privada)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Gerando Par de Chaves")
        End Try
    End Sub

    Private Sub btnEnvia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvia.Click
        Try
            txtCryp.Text = T.Encrypt(txtMsg.Text).AsBase64String
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Enviando Informação")
        End Try
    End Sub

    Private Sub btnRecebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecebe.Click
        Try
            txtDecryp.Text = T.Decrypt(txtCryp.Text).AsString
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Recebendo Informação")
        End Try
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

    Private Sub btnPublic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublic.Click
        Try
            Clipboard.Clear()
            If txtPublic.Text <> "" Then
                Clipboard.SetText(txtPublic.Text)
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Copiar Chave Pública")
        End Try
    End Sub

    Private Sub btnPriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPriv.Click
        Try
            Clipboard.Clear()
            If txtPublic.Text <> "" Then
                Clipboard.SetText(txtPrivad.Text)
            End If
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Copiar Chave Privada")
        End Try
    End Sub
End Class
