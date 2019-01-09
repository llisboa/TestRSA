Imports System.Security.Cryptography
Imports System.Text

Public Class TrataRSA

    Private _Chave As Dictionary(Of TipoChave, String)
    Public ReadOnly Property Chave(ByVal Tipo As TipoChave) As String
        Get
            Return _Chave(Tipo)
        End Get
    End Property
    Sub New()
        _Chave = CriaChave()
    End Sub
    Enum TipoChave
        Publica
        Privada
    End Enum
    Public Shared Function CriaChave() As Dictionary(Of TipoChave, String)
        Try
            Using RSA As New RSACryptoServiceProvider
                Dim Dict As New Dictionary(Of TipoChave, String)
                Dict.Add(TipoChave.Privada, RSA.ToXmlString(True))
                Dict.Add(TipoChave.Publica, RSA.ToXmlString(False))
                Return Dict
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message & " criando chave", ex)
        End Try
    End Function
    Public Function Encrypt(ByVal Data As String) As Result
        Return Encrypt(Data, Chave(TipoChave.Publica))
    End Function
    Public Shared Function Encrypt(ByVal Data As String, ByVal Publickey As String) As Result
        Try
            Dim ByteConverter As New UnicodeEncoding()
            Return Encrypt(ByteConverter.GetBytes(Data), Publickey)
        Catch ex As Exception
            Throw New Exception(ex.Message & " criptogravando texto" & ex.Message, ex)
        End Try
    End Function
    Public Shared Function Encrypt(ByVal Data() As Byte, ByVal Publickey As String) As Result
        Try
            Dim RSA As System.Security.Cryptography.RSACryptoServiceProvider = New System.Security.Cryptography.RSACryptoServiceProvider()
            RSA.FromXmlString(Publickey)
            Return New Result(RSAEncrypt(Data, RSA.ExportParameters(False), False))
        Catch ex As Exception
            Throw New Exception(ex.Message & " criptogravando dados", ex)
        End Try
    End Function
    Public Function Decrypt(ByVal Base64 As String) As Result
        Return Decrypt(Convert.FromBase64String(Base64))
    End Function
    Public Function Decrypt(ByVal Data() As Byte) As Result
        Return Decrypt(Data, Chave(TipoChave.Privada))
    End Function
    Public Shared Function Decrypt(ByVal Base64 As String, ByVal Privatekey As String) As Result
        Return Decrypt(Convert.FromBase64String(Base64), Privatekey)
    End Function
    Public Shared Function Decrypt(ByVal Data() As Byte, ByVal Privatekey As String) As Result
        Try
            Dim RSA As System.Security.Cryptography.RSACryptoServiceProvider = New System.Security.Cryptography.RSACryptoServiceProvider()
            RSA.FromXmlString(Privatekey)
            Dim Result As New Result(RSADecrypt(Data, RSA.ExportParameters(True), False))
            Return Result
        Catch ex As Exception
            Throw New Exception(ex.Message & " decriptogravando dados", ex)
        End Try
    End Function

    Public Class Result
        Private _Data() As Byte
        Public Sub New(ByVal Data() As Byte)
            _Data = Data
        End Sub
        Public ReadOnly Property AsBytes() As Byte()
            Get
                Return _Data
            End Get
        End Property
        Public ReadOnly Property AsString() As String
            Get
                Dim ByteConverter As New UnicodeEncoding()
                Return ByteConverter.GetString(_Data)
            End Get
        End Property
        Public ReadOnly Property AsBase64String() As String
            Get
                Return Convert.ToBase64String(_Data)
            End Get
        End Property
    End Class

    Private Shared Function RSAEncrypt(ByVal DataToEncrypt() As Byte, ByVal RSAKeyInfo As RSAParameters, ByVal DoOAEPPadding As Boolean) As Byte()
        Try
            Dim encryptedData() As Byte
            Using RSA As New RSACryptoServiceProvider
                RSA.ImportParameters(RSAKeyInfo)
                encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding)
            End Using
            Return encryptedData
        Catch e As CryptographicException
            Throw New Exception(e.Message & " gerando RSA", e)
        End Try
    End Function
    Private Shared Function RSADecrypt(ByVal DataToDecrypt() As Byte, ByVal RSAKeyInfo As RSAParameters, ByVal DoOAEPPadding As Boolean) As Byte()
        Try
            Dim decryptedData() As Byte
            Using RSA As New RSACryptoServiceProvider
                RSA.ImportParameters(RSAKeyInfo)
                decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding)
            End Using
            Return decryptedData
        Catch e As CryptographicException
            Throw New Exception(e.Message & " interpretando RSA", e)
        End Try
    End Function

End Class
