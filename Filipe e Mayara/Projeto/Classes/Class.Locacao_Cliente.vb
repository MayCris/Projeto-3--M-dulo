Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Locacao_cliente
    Private id_locacao As Integer
    Private cod_cliente As Integer
    Private nome As String
    Private tipo_cliente As String
    Private locacao_paga_ato As String
    Private valor_locacao As Double
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
    Protected ProgramaSQL As ProgramaSQL

    'lista dos itens da grid
    Public Function ListagemDataTableLocacoes(ByVal l_cliente As Locacao_cliente) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM LOCACAO_CLIENTE "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridlocacao_cliente(ByVal l_cliente As Locacao_cliente) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere1 = "WHERE"
            Dim msWhere2 = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT "
            sSql &= "'TIT' as TIPO, tit.ID_TITULAR as COD, tit.NOME "
            sSql &= " FROM CLIENTE_TITULAR tit "
            If l_cliente.p_nome <> "" Then
                sSql &= msWhere1 & " tit.NOME like '%" & l_cliente.p_nome & "%'"
                msWhere1 = " AND "
            End If
            sSql &= " UNION ALL "
            sSql &= " SELECT 'ADC' as TIPO, adc.ID_ADICIONAL as COD, adc.NOME "
            sSql &= " FROM CLIENTE_ADICIONAL adc "
            If l_cliente.p_nome <> "" Then
                sSql &= msWhere2 & " adc.NOME like '%" & l_cliente.p_nome & "%'"
                msWhere2 = " AND "
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar os dados do registro para alteração
    Public Function RetornarDadosLocacao_cliente(ByVal L_cliente As Locacao_cliente) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            If L_cliente.p_id_locacao <> 0 Then
                sSql = " SELECT "
                sSql &= "'TIT' as TIPO, tit.ID_TITULAR as COD, tit.NOME "
                sSql &= " FROM CLIENTE_TITULAR tit "
                sSql &= " UNION(ALL) SELECT 'ADC' as TIPO, adc.ID_ADICIONAL as COD, adc.NOME "
                sSql &= " FROM CLIENTE_ADICIONAL adc "
                sSql &= " lf.PRECO, lc.LOCACAO_PAGA_ATO, lc.VALOR_LOCACAO "
                sSql &= " FROM LOCACAO_CLIENTE lc "
                sSql &= " WHERE ID_LOCACAO = " & L_cliente.p_id_locacao

            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function Inserirlc(ByVal L_cliente As Locacao_cliente) As DataTable
        Return ExecutaConsultalc(L_cliente, "I")
    End Function
    'alterando dados
    Public Function Alterarlc(ByVal L_cliente As Locacao_cliente) As DataTable
        Return ExecutaConsultalc(L_cliente, "U")
    End Function
    'excluindo itens
    Public Function Excluirlc(ByVal L_cliente As Locacao_cliente) As DataTable
        Return ExecutaConsultalc(L_cliente, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultalc(ByVal L_cliente As Locacao_cliente, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_LOCACAO "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_LOCACAO = " & L_cliente.p_id_locacao & ", "
            sSql &= "@p_COD_CLIENTE = " & L_cliente.p_cod_cliente & ", "
            sSql &= "@p_TIPO_CLIENTE = '" & L_cliente.p_tipo_cliente & "', "
            sSql &= "@p_VALOR_LOCACAO = " & L_cliente.p_valor_locacao.ToString.Replace(",", ".") & ", "
            sSql &= "@p_LOCACAO_PAGA_ATO = '" & L_cliente.p_locacao_paga_ato & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
