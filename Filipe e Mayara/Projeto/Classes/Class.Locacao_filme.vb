Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Locacao_filme
    Private id_Locacao_filmes As Integer
    Private id_locacao As Integer
    Private cod_filme As Integer
    Private filme As String
    Private data_retirada As Date
    Private data_devolucao As Date
    Private preco As Double
    Public Property p_id_Locacao_filmes() As Integer
        Get
            Return id_Locacao_filmes
        End Get
        Set(ByVal value As Integer)
            id_Locacao_filmes = value
        End Set
    End Property
    Public Property p_id_locacao() As Integer
        Get
            Return id_locacao
        End Get
        Set(ByVal value As Integer)
            id_locacao = value
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
    Public Property p_data_retirada() As String
        Get
            Return data_retirada
        End Get
        Set(ByVal value As String)
            data_retirada = value
        End Set
    End Property
    Public Property p_data_devolucao() As String
        Get
            Return data_devolucao
        End Get
        Set(ByVal value As String)
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

    'lista dos itens da grid
    Public Function ListagemDataTableLocacao(ByVal l_filme As Locacao_filme) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM LOCACAO_FILME "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridlocacao_filme(ByVal l_filme As Locacao_filme) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT "
            sSql &= "fil.ID_FILME as COD, fil.FILME, fil.PRECO "
            sSql &= " FROM FILMES fil "
            If l_filme.p_filme <> "" Then
                sSql &= msWhere & " fil.FILME like '%" & l_filme.p_filme & "%'"
                msWhere = " AND "
            End If
            If l_filme.p_cod_filme > 0 Then
                sSql &= msWhere & " fil.ID_FILME = " & l_filme.p_cod_filme
                msWhere = " AND "
            End If
            If l_filme.p_preco <> "" Then
                sSql &= msWhere & " fil.PRECO like '%" & l_filme.p_preco & "%'"
                msWhere = " AND "
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar os dados do registro para alteração
    Public Function RetornarDadosLocacao_filme(ByVal L_filme As Locacao_filme) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            If L_filme.p_id_locacao <> 0 Then
                sSql = " SELECT "
                sSql &= "fil.ID_FILME as COD, fil.FILME, fil.PRECO "
                sSql &= " FROM FILMES fil "
                sSql &= "lf.DATA_RETIRADA, lf.DATA_DEVOLUCAO, "
                sSql &= " FROM LOCACAO_FILME lf "
                sSql &= " WHERE ID_LOCACAO_FILMES = " & L_filme.p_id_locacao_filmes

            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function Inserirlf(ByVal L_Filme As Locacao_filme) As DataTable
        Return ExecutaConsultalf(L_Filme, "I")
    End Function
    'alterando dados
    Public Function Alterarlf(ByVal L_Filme As Locacao_filme) As DataTable
        Return ExecutaConsultalf(L_Filme, "U")
    End Function
    'excluindo itens
    Public Function Excluirlf(ByVal L_Filme As Locacao_filme) As DataTable
        Return ExecutaConsultalf(L_Filme, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultalf(ByVal L_Filme As Locacao_filme, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Dim L_Cliente As New Locacao_cliente
        Try
            Dim sSql As String
            sSql = "sp_LOCACAO_FILMES "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_LOCACAO = " & L_Filme.p_id_locacao & ", "
            sSql &= "@P_ID_LOCACAO_FILMES = " & L_Filme.p_id_locacao_filmes & ", "
            sSql &= "@p_COD_FILME = " & L_Filme.p_cod_filme & ", "
            sSql &= "@p_DATA_RETIRADA = '" & L_Filme.p_data_retirada & "', "
            sSql &= "@p_DATA_DEVOLUCAO = '" & L_Filme.p_data_devolucao & "', "
            sSql &= "@p_PRECO = '" & L_Filme.p_preco.ToString.Replace(",", ".") & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
