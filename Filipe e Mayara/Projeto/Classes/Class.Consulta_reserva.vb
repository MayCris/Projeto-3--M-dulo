Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Consulta_reserva
    Private id_reserva As Integer
    Private cod_cliente As Integer
    Private nome As String
    Private tipo_cliente As String
    Private cod_filme As Integer
    Private filme As String
    Private data_reserva As Date
    Private preco As Double
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
    Public Function ListagemDataTableConsulta_Reserva(ByVal C_Reserva As Consulta_reserva) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM RESERVA_FILMES "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function ListagemDataTable2Consulta_Reserva(ByVal C_Reserva As Consulta_reserva) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM RESERVA "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
