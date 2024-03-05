Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Reserva_cliente
    Private id_reserva As Integer
    Private cod_cliente As Integer
    Private nome As String
    Private tipo_cliente As String
    Private telefone As String
    Public Property p_id_reserva() As Integer
        Get
            Return id_reserva
        End Get
        Set(ByVal value As Integer)
            id_reserva = value
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
    Public Property p_telefone() As String
        Get
            Return telefone
        End Get
        Set(ByVal value As String)
            telefone = value
        End Set
    End Property
    Protected ProgramaSQL As ProgramaSQL

    'lista dos itens da grid
    Public Function ListagemDataTableReserva(ByVal r_cliente As Reserva_cliente) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM RESERVA_CLIENTE "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridreserva_cliente(ByVal r_cliente As Reserva_cliente) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere1 = "WHERE"
            Dim msWhere2 = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT "
            sSql &= "'TIT' as TIPO, tit.ID_TITULAR as COD, tit.NOME "
            sSql &= " FROM CLIENTE_TITULAR tit "
            If r_cliente.p_nome <> "" Then
                sSql &= msWhere1 & " tit.NOME like '%" & r_cliente.p_nome & "%'"
                msWhere1 = " AND "
            End If
            sSql &= " UNION ALL "
            sSql &= " SELECT 'ADC' as TIPO, adc.ID_ADICIONAL as COD, adc.NOME "
            sSql &= " FROM CLIENTE_ADICIONAL adc "
            If r_cliente.p_nome <> "" Then
                sSql &= msWhere2 & " adc.NOME like '%" & r_cliente.p_nome & "%'"
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
    Public Function RetornarDadosreserva_cliente(ByVal r_cliente As Reserva_cliente) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            If r_cliente.p_id_reserva <> 0 Then
                sSql = " SELECT "
                sSql &= "'TIT' as TIPO, tit.ID_TITULAR as COD, tit.NOME "
                sSql &= " FROM CLIENTE_TITULAR tit "
                sSql &= " UNION(ALL) SELECT 'ADC' as TIPO, adc.ID_ADCIONAL as COD, adc.NOME "
                sSql &= " FROM CLIENTE_ADCIONAL adc "
                sSql &= " WHERE ID_RESERVA = " & r_cliente.p_id_reserva
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'incluir dados 
    Public Function Inserirrc(ByVal r_cliente As Reserva_cliente) As DataTable
        Return ExecutaConsultarc(r_cliente, "I")
    End Function
    'alterando dados
    Public Function Alterarrc(ByVal r_cliente As Reserva_cliente) As DataTable
        Return ExecutaConsultarc(r_cliente, "U")
    End Function
    'excluindo itens
    Public Function Excluirrc(ByVal r_cliente As Reserva_cliente) As DataTable
        Return ExecutaConsultarc(r_cliente, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultarc(ByVal r_cliente As Reserva_cliente, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_RESERVA "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_RESERVA = " & r_cliente.p_id_reserva & ", "
            sSql &= "@p_COD_CLIENTE = " & r_cliente.p_cod_cliente & ", "
            sSql &= "@p_NOME = '" & r_cliente.p_nome & "', "
            sSql &= "@p_TIPO_CLIENTE = '" & r_cliente.p_tipo_cliente & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
