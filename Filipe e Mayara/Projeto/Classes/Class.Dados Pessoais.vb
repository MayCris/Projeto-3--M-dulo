Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Dados_Pessoais
    Inherits Enderecos
    Private id_dados_pessoais As Integer
    Private rg As String
    Private cpf As String
    Private sexo As String
    Private data_nascimento As Date
    Private telefone As String
    Private celular As String
    Private e_mail As String
    Public Property p_id_dados_pessoais() As Integer
        Get
            Return id_dados_pessoais
        End Get
        Set(ByVal value As Integer)
            id_dados_pessoais = value
        End Set
    End Property
    Public Property p_rg() As String
        Get
            Return rg
        End Get
        Set(ByVal value As String)
            rg = value
        End Set
    End Property
    Public Property p_cpf() As String
        Get
            Return cpf
        End Get
        Set(ByVal value As String)
            cpf = value
        End Set
    End Property
    Public Property p_sexo() As String
        Get
            Return sexo
        End Get
        Set(ByVal value As String)
            sexo = value
        End Set
    End Property
    Public Property p_data_nascimento() As Date
        Get
            Return data_nascimento
        End Get
        Set(ByVal value As Date)
            data_nascimento = value
        End Set
    End Property
    Public Property p_telefone() As String
        Get
            Return telefone
        End Get
        Set(ByVal value As String)
            telefone = value
        End Set
    End Property
    Public Property p_celular() As String
        Get
            Return celular
        End Get
        Set(ByVal value As String)
            celular = value
        End Set
    End Property
    Public Property p_e_mail() As String
        Get
            Return e_mail
        End Get
        Set(ByVal value As String)
            e_mail = value
        End Set
    End Property
    'retornar os dados do registro para alteração
    Public Function RetornarDadosDP(ByVal v_Dados_Pessoais As Dados_Pessoais) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            If v_Dados_Pessoais.id_dados_pessoais <> "" Then
                sSql = "SELECT * FROM DADOS_PESSOAIS "
                sSql &= " WHERE ID_DADOS_PESSOAIS = " & v_Dados_Pessoais.p_id_dados_pessoais & " "
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function InserirDP(ByVal v_Dados_Pessoais As Dados_Pessoais) As DataTable
        Return ExecutaConsultaDP(v_Dados_Pessoais, "I")
    End Function
    'alterando dados
    Public Function AlterarDP(ByVal v_dados_pessoais As Dados_Pessoais) As DataTable
        Return ExecutaConsultaDP(v_dados_pessoais, "U")
    End Function
    'excluindo itens
    Public Function ExcluirDP(ByVal v_dados_pessoais As Dados_Pessoais) As DataTable
        Return ExecutaConsultaDP(v_dados_pessoais, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaDP(ByVal v_dados_pessoais As Dados_Pessoais, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_DADOS_PESSOAIS "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_DADOS_PESSOAIS = " & v_dados_pessoais.p_id_dados_pessoais & ", "
            sSql &= "@p_RG = '" & v_dados_pessoais.p_rg & "',"
            sSql &= "@p_CPF = '" & v_dados_pessoais.p_cpf & "',"
            sSql &= "@p_SEXO = '" & v_dados_pessoais.p_sexo & "',"
            sSql &= "@p_DATA_NASCIMENTO = '" & v_dados_pessoais.p_data_nascimento & "',"
            sSql &= "@p_TELEFONE = '" & v_dados_pessoais.p_telefone & "',"
            sSql &= "@p_CELULAR = '" & v_dados_pessoais.p_celular & "',"
            sSql &= "@p_E_MAIL = '" & v_dados_pessoais.p_e_mail & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
