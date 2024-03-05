Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class ProgramaSQL
    'tipo de tranzação
    Public Enum tipoSql
        sql_procedure = 0   ' Não tem retorno de informações
        sql_texto = 1       ' Tem retorno de informações
    End Enum
    Protected strConn As String = "Data source=(local);Connect Timeout=1800;Initial Catalog=video_locadora;uid=;pwd=;Integrated Security=SSPI"
    Protected cnn As SqlConnection
    Protected cmd As SqlCommand
    Sub New()
        cnn = New SqlConnection(strConn)
        cmd = New SqlCommand
        Try
            cnn.ConnectionString = strConn
            cnn.Open()
            cmd.Connection = cnn
        Catch ex As Exception
            If Not strConn Is Nothing Then
                strConn = Nothing
            End If
            If Not cnn Is Nothing Then
                cnn = Nothing
            End If
            If Not cmd Is Nothing Then
                'cmd.Connection.Dispose()
                cmd = Nothing
            End If
            Throw ex
        End Try
    End Sub ' Minha Conexão
    Public Function ExecuteDataSet(ByVal v_tipoSql As tipoSql, ByVal sql As String) As DataSet
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim ds As DataSet = New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Public Function ExecuteDataSet(ByVal v_tipoSql As tipoSql, ByVal sql As String, ByVal params() As SqlParameter) As DataSet
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        FillParameters(cmd, params)
        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim ds As DataSet = New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Public Function ExecuteDataTable(ByVal v_tipoSql As tipoSql, ByVal sql As String) As DataTable
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ExecuteDataTable(ByVal v_tipoSql As tipoSql, ByVal sql As String, ByVal params() As SqlParameter) As DataTable
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        FillParameters(cmd, params)
        Dim da As SqlDataAdapter = New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ExecuteReader(ByVal v_tipoSql As tipoSql, ByVal sql As String) As SqlDataReader
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function
    Public Function ExecuteReader(ByVal v_tipoSql As tipoSql, ByVal sql As String, ByVal params() As SqlParameter) As SqlDataReader
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        FillParameters(cmd, params)

        Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
    End Function
    Public Function ExecuteNonQuery(ByVal v_tipoSql As tipoSql, ByVal query As String) As Integer
        cmd = New SqlCommand(query, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        Dim retval As Integer = cmd.ExecuteNonQuery()
        Return retval
    End Function
    Public Function ExecuteNonQuery(ByVal v_tipoSql As tipoSql, ByVal query As String, ByVal params() As SqlParameter) As Integer
        cmd = New SqlCommand(query, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        FillParameters(cmd, params)
        Dim retval As Integer = cmd.ExecuteNonQuery()
        Return retval
    End Function
    Public Function ExecuteScalar(ByVal v_tipoSql As tipoSql, ByVal sql As String) As Object
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        Dim retval As Object = cmd.ExecuteScalar()
        Return retval
    End Function
    Public Function ExecuteScalar(ByVal v_tipoSql As tipoSql, ByVal sql As String, ByVal params() As SqlParameter) As Object
        cmd = New SqlCommand(sql, cnn)
        Select Case v_tipoSql
            Case tipoSql.sql_procedure
                cmd.CommandType = CommandType.StoredProcedure
            Case tipoSql.sql_texto
                cmd.CommandType = CommandType.Text
        End Select
        FillParameters(cmd, params)
        Dim retval As Object = cmd.ExecuteScalar()
        Return retval
    End Function
    Protected Sub FillParameters(ByVal cmd As SqlCommand, ByVal parameters() As SqlParameter)
        Dim i As Integer
        For i = 0 To parameters.Length - 1
            cmd.Parameters.Add(parameters(i))
        Next
    End Sub
    Public Sub close()
        If Not cmd Is Nothing Then
            cmd.Connection.Dispose()
            cmd = Nothing
        End If
        If Not cnn Is Nothing Then
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            cnn = Nothing
        End If
        If Not strConn Is Nothing Then
            strConn = Nothing
        End If
    End Sub
End Class
