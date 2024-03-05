Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Consulta_locacao
    Private id_locacao As Integer
    Private cod_cliente As Integer
    Private nome As String
    Private tipo_cliente As String
    Private locacao_paga_ato As String
    Private valor_locacao As Double
    Private cod_filme As Integer
    Private filme As String
    Private data_retirada As Date
    Private data_devolucao As Date
    Private preco As Double
    Public Property p_id_locacao() As Integer
        Get
            Return id_locacao
        End Get
        Set(ByVal value As Integer)
            id_locacao = value
        End Set
    End Property
    Public Property p_cod_cliente() As Integer
        Get
            Return cod_cliente
        End Get
        Set(ByVal value As Integer)
            cod_cliente = value
        End Set
    End Property
    Public Property p_nome() As String
        Get
            Return nome
        End Get
        Set(ByVal value As String)
            nome = value
        End Set
    End Property
    Public Property p_tipo_cliente() As String
        Get
            Return tipo_cliente
        End Get
        Set(ByVal value As String)
            tipo_cliente = value
        End Set
    End Property
    Public Property p_locacao_paga_ato() As String
        Get
            Return locacao_paga_ato
        End Get
        Set(ByVal value As String)
            locacao_paga_ato = value
        End Set
    End Property
    Public Property p_valor_locacao() As String
        Get
            Return valor_locacao
        End Get
        Set(ByVal value As String)
            valor_locacao = value
        End Set
    End Property
    Public Property p_cod_filme() As Integer
        Get
            Return cod_filme
        End Get
        Set(ByVal value As Integer)
            cod_filme = value
        End Set
    End Property
    Public Property p_filme() As String
        Get
            Return filme
        End Get
        Set(ByVal value As String)
            filme = value
        End Set
    End Property
    Public Property p_data_retirada() As date
        Get
            Return data_retirada
        End Get
        Set(ByVal value As Date)
            data_retirada = value
        End Set
    End Property
    Public Property p_data_devolucao() As Date
        Get
            Return data_devolucao
        End Get
        Set(ByVal value As Date)
            data_devolucao = value
        End Set
    End Property
    Public Property p_preco() As String
        Get
            Return preco
        End Get
        Set(ByVal value As String)
            preco = value
        End Set
    End Property
    Protected ProgramaSQL As ProgramaSQL
    Public Function ListagemDataTableConsulta_Locacao(ByVal C_Locacao As Consulta_locacao) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM LOCACAO_FILMES "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function ListagemDataTable2Consulta_Locacao(ByVal C_Locacao As Consulta_locacao) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM LOCACAO "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'excluindo itens
    Public Function ExcluirCl(ByVal C_locacao As Consulta_locacao) As DataTable
        Return ExecutaConsultaCl(C_locacao, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaCl(ByVal C_locacao As Consulta_locacao, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL
        Dim l_cliente As New Locacao_cliente
        Try
            Dim sSql As String
            sSql = "sp_LOCACAO "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_LOCACAO = " & L_cliente.p_id_locacao & ", "
            sSql &= "@p_COD_CLIENTE = " & L_cliente.p_cod_cliente & ", "
            sSql &= "@p_TIPO_CLIENTE = '" & L_cliente.p_tipo_cliente & "', "
            sSql &= "@p_VALOR_LOCACAO = " & L_cliente.p_valor_locacao.ToString.Replace(",", ".") & ", "
            sSql &= "@p_LOCACAO_PAGA_ATO = '" & l_cliente.p_locacao_paga_ato & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
