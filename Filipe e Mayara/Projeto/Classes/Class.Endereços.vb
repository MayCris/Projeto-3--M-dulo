Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Enderecos
    Private cep As String
    Private logradouro As String
    Private numero As Integer
    Private complemento As String
    Private bairro As String
    Private cidade As String
    Private estado As String
    Public Property p_cep() As String
        Get
            Return cep
        End Get
        Set(ByVal value As String)
            cep = value
        End Set
    End Property
    Public Property p_logradouro() As String
        Get
            Return logradouro
        End Get
        Set(ByVal value As String)
            logradouro = value
        End Set
    End Property
    Public Property p_numero() As Integer
        Get
            Return numero
        End Get
        Set(ByVal value As Integer)
            numero = value
        End Set
    End Property
    Public Property p_complemento() As String
        Get
            Return complemento
        End Get
        Set(ByVal value As String)
            complemento = value
        End Set
    End Property
    Public Property p_bairro() As String
        Get
            Return bairro
        End Get
        Set(ByVal value As String)
            bairro = value
        End Set
    End Property
    Public Property p_cidade() As String
        Get
            Return cidade
        End Get
        Set(ByVal value As String)
            cidade = value
        End Set
    End Property
    Public Property p_estado() As String
        Get
            Return estado
        End Get
        Set(ByVal value As String)
            estado = value
        End Set
    End Property
    Protected ProgramaSQL As ProgramaSQL

    'retornar os dados do registro para alteração
    Public Function RetornarDadosEnderecos(ByVal v_Enderecos As Enderecos) As DataTable
        ProgramaSQL = New ProgramaSQL

        Dim sSql As String = ""
        Try
            If v_Enderecos.p_cep <> "" Then
                sSql &= "SELECT * FROM ENDERECOS "
                sSql &= " WHERE CEP = '" & v_Enderecos.p_cep & "' "
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function InserirEnderecos(ByVal v_Enderecos As Enderecos) As DataTable
        Return ExecutaConsultaEnderecos(v_Enderecos, "I")
    End Function
    'alterando dados
    Public Function AlterarEnderecos(ByVal v_Enderecos As Enderecos) As DataTable
        Return ExecutaConsultaEnderecos(v_Enderecos, "U")
    End Function
    'excluindo itens
    Public Function ExcluirEnderecos(ByVal v_Enderecos As Enderecos) As DataTable
        Return ExecutaConsultaEnderecos(v_Enderecos, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaEnderecos(ByVal v_Enderecos As Enderecos, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_ENDERECOS "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_CEP = '" & v_Enderecos.p_cep & "', "
            sSql &= "@p_LOGRADOURO = '" & v_Enderecos.p_logradouro & "', "
            sSql &= "@p_NUMERO = " & v_Enderecos.p_numero & ", "
            sSql &= "@p_COMPLEMENTO = '" & v_Enderecos.p_complemento & " ',"
            sSql &= "@p_BAIRRO = '" & v_Enderecos.p_bairro & "', "
            sSql &= "@p_CIDADE = '" & v_Enderecos.p_cidade & "', "
            sSql &= "@p_ESTADO = '" & v_Enderecos.p_estado & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
            ProgramaSQL.close()
        End Try
    End Function
End Class
