Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Filmes
    Private id_filme As Integer
    Private id_midia As Integer
    Private filme As String
    Private ano_lancamento As String
    Private genero As String
    Private nacionalidade As String
    Private duracao As Integer
    Private direcao As String
    Private sinopse As String
    Private preco As Double
    Public Property p_id_filme() As Integer
        Get
            Return id_filme
        End Get
        Set(ByVal value As Integer)
            id_filme = value
        End Set
    End Property
    Public Property p_id_midia() As Integer
        Get
            Return id_midia
        End Get
        Set(ByVal value As Integer)
            id_midia = value
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
    Public Property p_ano_lancamento() As String
        Get
            Return ano_lancamento
        End Get
        Set(ByVal value As String)
            ano_lancamento = value
        End Set
    End Property
    Public Property p_genero() As String
        Get
            Return genero
        End Get
        Set(ByVal value As String)
            genero = value
        End Set
    End Property
    Public Property p_nacionalidade() As String
        Get
            Return nacionalidade
        End Get
        Set(ByVal value As String)
            nacionalidade = value
        End Set
    End Property
    Public Property p_duracao() As Integer
        Get
            Return duracao
        End Get
        Set(ByVal value As Integer)
            duracao = value
        End Set
    End Property
    Public Property p_direcao() As String
        Get
            Return direcao
        End Get
        Set(ByVal value As String)
            direcao = value
        End Set
    End Property
    Public Property p_sinopse() As String
        Get
            Return sinopse
        End Get
        Set(ByVal value As String)
            sinopse = value
        End Set
    End Property
    Public Property p_preco() As Double
        Get
            Return preco
        End Get
        Set(ByVal value As Double)
            preco = value
        End Set
    End Property
    Protected ProgramaSQL As ProgramaSQL
    Public Function ListagemDataTableFilmes(ByVal F_Filmes As Filmes) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM FILMES "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar o ID do filme para a Variável
    Public Function RetornarID_FILME(ByVal F_Filmes As Filmes) As Integer
        ProgramaSQL = New ProgramaSQL
        Dim dt As DataTable
        Dim dr As DataRow

        Try
            Dim sSql As String
            sSql = "SELECT ID_FILME FROM FILMES "
            sSql &= " WHERE FILME = '" & Trim(F_Filmes.p_filme) & "' "

            dt = ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
            For Each dr In dt.Rows
                Return dr("ID_FILME")
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridFilmes(ByVal F_Filmes As Filmes) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere As String = " WHERE "
            Dim sSql As String = ""
            sSql = "SELECT "
            sSql &= "f.ID_FILME, f.FILME, "
            sSql &= "m.MIDIA as MIDIA,"
            sSql &= "f.ANO_LANCAMENTO, f.GENERO,"
            sSql &= "f.DURACAO, f.PRECO"
            sSql &= " FROM FILMES f "
            sSql &= " LEFT OUTER JOIN MIDIAS m ON f.ID_MIDIA = m.ID_MIDIA "
            If F_Filmes.p_filme <> "" Then
                sSql &= msWhere & " FILME like '%" & F_Filmes.p_filme & "%'"
                msWhere = " AND "
            End If
            If F_Filmes.p_id_filme > 0 Then
                sSql &= msWhere & " ID_FILME = " & F_Filmes.p_id_filme & " "
                msWhere = " AND "
            End If
            If F_Filmes.p_id_midia > 0 Then
                sSql &= msWhere & "m.ID_MIDIA = " & F_Filmes.p_id_midia & " "
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
    Public Function RetornarDadosFilmes(ByVal F_Filmes As Filmes) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere As String = " WHERE "
            Dim sSql As String = ""
            If F_Filmes.id_filme <> 0 Then
                sSql = "SELECT "
                sSql &= "f.ID_FILME,"
                sSql &= "m.ID_MIDIA as ID_MIDIA, "
                sSql &= "m.MIDIA as MIDIA,"
                sSql &= "f.FILME, f.ANO_LANCAMENTO, f.GENERO,"
                sSql &= "f.NACIONALIDADE, f.DURACAO, f.DIRECAO,"
                sSql &= "f.SINOPSE, f.PRECO"
                sSql &= " FROM FILMES f "
                sSql &= " LEFT OUTER JOIN MIDIAS m ON f.ID_MIDIA = m.ID_MIDIA "
                If F_Filmes.p_id_midia > 0 Then
                    sSql &= msWhere & " m.ID_MIDIA = " & F_Filmes.p_id_midia & " "
                End If
                If F_Filmes.p_filme <> "" Then
                    sSql &= msWhere & " FILME like '%" & F_Filmes.p_filme & "%'"
                    msWhere = " AND "
                End If
                If F_Filmes.p_id_filme > 0 Then
                    sSql &= msWhere & " ID_FILME = " & F_Filmes.p_id_filme & " "
                    msWhere = " AND "
                End If
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function InserirFilmes(ByVal F_Filmes As Filmes) As DataTable
        Return ExecutaConsultaFilmes(F_Filmes, "I")
    End Function
    'alterando dados
    Public Function AlterarFilmes(ByVal F_Filmes As Filmes) As DataTable
        Return ExecutaConsultaFilmes(F_Filmes, "U")
    End Function
    'excluindo itens
    Public Function ExcluirFilmes(ByVal F_Filmes As Filmes) As DataTable
        Return ExecutaConsultaFilmes(F_Filmes, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaFilmes(ByVal F_Filmes As Filmes, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_FILMES "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_FILME = " & F_Filmes.p_id_filme & ", "
            sSql &= "@p_ID_MIDIA = " & F_Filmes.p_id_midia & ", "
            sSql &= "@p_FILME = '" & F_Filmes.p_filme & "', "
            sSql &= "@p_ANO_LANCAMENTO = '" & F_Filmes.p_ano_lancamento & "', "
            sSql &= "@p_GENERO = '" & F_Filmes.p_genero & "', "
            sSql &= "@p_NACIONALIDADE = '" & F_Filmes.p_nacionalidade & "', "
            sSql &= "@p_DURACAO = " & F_Filmes.p_duracao & ", "
            sSql &= "@p_DIRECAO = '" & F_Filmes.p_direcao & "', "
            sSql &= "@p_SINOPSE = '" & F_Filmes.p_sinopse & "', "
            sSql &= "@p_PRECO = '" & F_Filmes.p_preco.ToString.Replace(",", ".") & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
