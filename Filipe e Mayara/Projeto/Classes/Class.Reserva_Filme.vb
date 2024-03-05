Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Reserva_Filme
    Private id_reseva_filmes As Integer
    Private id_reserva As Integer
    Private cod_filme As Integer
    Private filme As String
    Private data_reserva As Date
    Private preco As Double
    Public Property p_id_reserva_filmes() As Integer
        Get
            Return id_reseva_filmes
        End Get
        Set(ByVal value As Integer)
            id_reseva_filmes = value
        End Set
    End Property
    Public Property p_id_reserva() As Integer
        Get
            Return id_reserva
        End Get
        Set(ByVal value As Integer)
            id_reserva = value
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
    Public Property p_data_reserva() As String
        Get
            Return data_reserva
        End Get
        Set(ByVal value As String)
            data_reserva = value
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
    Public Function ListagemDataTableReserva(ByVal r_filme As Reserva_Filme) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM RESERVA_FILME "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridreserva_filme(ByVal r_filme As Reserva_Filme) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT "
            sSql &= "fil.ID_FILME as COD, fil.FILME, fil.PRECO "
            sSql &= " FROM FILMES fil "
            If r_filme.p_filme <> "" Then
                sSql &= msWhere & " fil.FILME like '%" & r_filme.p_filme & "%'"
                msWhere = " AND "
            End If
            If r_filme.p_cod_filme > 0 Then
                sSql &= msWhere & " fil.ID_FILME = " & r_filme.p_cod_filme
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
    Public Function RetornarDadosreserva_filme(ByVal r_filme As Reserva_Filme) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            If r_filme.p_id_reserva <> 0 Then
                sSql = " SELECT "
                sSql &= "fil.ID_FILME as COD, fil.FILME, fil.PRECO, "
                sSql &= " FROM FILMES fil "
                sSql &= "lf.DATA_RESERVA, rf.VALOR_RESERVA "
                sSql &= " FROM RESERVA_FILME rf "
                sSql &= " WHERE ID_RESERVA = " & r_filme.p_id_reserva_filmes
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function Inserirrf(ByVal r_Filme As Reserva_Filme) As DataTable
        Return ExecutaConsultarf(r_Filme, "I")
    End Function
    'alterando dados
    Public Function Alterarrf(ByVal r_Filme As Reserva_Filme) As DataTable
        Return ExecutaConsultarf(r_Filme, "U")
    End Function
    'excluindo itens
    Public Function Excluirrf(ByVal r_Filme As Reserva_Filme) As DataTable
        Return ExecutaConsultarf(r_Filme, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultarf(ByVal r_Filme As Reserva_Filme, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_RESERVA_FILMES "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_RESERVA_FILMES = " & r_Filme.p_id_reserva_filmes & ", "
            sSql &= "@p_ID_RESERVA = " & r_Filme.p_id_reserva & ", "
            sSql &= "@p_COD_FILME = " & r_Filme.p_cod_filme & ", "
            sSql &= "@p_FILME = '" & r_Filme.p_filme & "', "
            sSql &= "@p_DATA_RESERVA = '" & r_Filme.p_data_reserva & "', "
            sSql &= "@p_PRECO = '" & r_Filme.p_preco.ToString.Replace(",", ".") & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
