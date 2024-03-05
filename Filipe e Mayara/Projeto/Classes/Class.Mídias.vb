Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Midias
    Private id_midia As Integer
    Private midia As String
    Public Property p_id_midia() As Integer
        Get
            Return id_midia
        End Get
        Set(ByVal value As Integer)
            id_midia = value
        End Set
    End Property
    Public Property p_midia() As String
        Get
            Return midia
        End Get
        Set(ByVal value As String)
            midia = value
        End Set
    End Property
    Protected ProgramaSQL As ProgramaSQL

    'lista dos itens da grid
    Public Function ListagemDataTableMidias(ByVal M_Midias As Midias) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM MIDIAS "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar o ID da midia para Variável
    Public Function RetornarID_Midia(ByVal M_Midias As Midias) As Integer
        ProgramaSQL = New ProgramaSQL
        Dim dt As DataTable
        Dim dr As DataRow

        Try
            Dim sSql As String
            sSql = "SELECT ID_MIDIA FROM MIDIAS "
            sSql &= " WHERE MIDIA = '" & M_Midias.p_midia & "' "

            dt = ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
            For Each dr In dt.Rows
                Return dr("MIDIA")
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridMidias(ByVal M_Midias As Midias) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere As String = " WHERE "
            Dim sSql As String = ""
            sSql = "SELECT "
            sSql &= "ID_MIDIA, MIDIA "
            sSql &= "FROM MIDIAS "
            If M_Midias.p_midia <> "" Then
                sSql &= msWhere & " MIDIA like '%" & M_Midias.p_midia & "%'"
                msWhere = " AND "
            End If
            If M_Midias.p_id_midia > 0 Then
                sSql &= msWhere & " ID_MIDIA = " & M_Midias.p_id_midia
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
    Public Function RetornarDadosMidias(ByVal M_Midias As Midias) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            If M_Midias.id_midia <> 0 Then
                sSql = "SELECT "
                sSql &= "ID_MIDIA, MIDIA "
                sSql &= " FROM MIDIAS "
                If M_Midias.p_id_midia > 0 Then
                    sSql &= "WHERE ID_MIDIA = " & M_Midias.p_id_midia
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
    Public Function InserirMidias(ByVal M_Midias As Midias) As DataTable
        Return ExecutaConsultaMidias(M_Midias, "I")
    End Function
    'alterando dados
    Public Function AlterarMidias(ByVal M_Midias As Midias) As DataTable
        Return ExecutaConsultaMidias(M_Midias, "U")
    End Function
    'excluindo itens
    Public Function ExcluirMidias(ByVal M_Midias As Midias) As DataTable
        Return ExecutaConsultaMidias(M_Midias, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaMidias(ByVal M_Midias As Midias, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_MIDIAS "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_MIDIA = " & M_Midias.p_id_midia & ", "
            sSql &= "@p_MIDIA = '" & M_Midias.p_midia & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
