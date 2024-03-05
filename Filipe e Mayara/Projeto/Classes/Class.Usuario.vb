Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Usuario
    Private Usuario As Integer
    Private Nome As String
    Private Senha As Integer
    Public Property p_id_Usuario()
        Get
            Return Usuario
        End Get
        Set(ByVal value)
            Usuario = value
        End Set
    End Property
    Public Property p_Nome()
        Get
            Return Nome
        End Get
        Set(ByVal value)
            Nome = value
        End Set
    End Property
    Public Property p_Senha()
        Get
            Return Senha
        End Get
        Set(ByVal value)
            Senha = value
        End Set
    End Property

    Protected ProgramaSql As ProgramaSQL

    'padrao sistema---------------------------------------------------------------------------
    'lista dos itens da grid
    Public Function ListagemDataTableUsuarios(ByVal v_Usuario As Usuario) As DataTable
        ProgramaSql = New ProgramaSQL
        Try
            'Dim v_params As SqlParameter() = New SqlParameter(2) {}
            'v_params(0) = New SqlParameter("@pOPERACAO", "L")
            'v_params(1) = New SqlParameter("@moCod", voUsuario.id_cliemp)
            'v_params(2) = New SqlParameter("@moOrder", voUsuario.order)

            Dim sSql As String = ""
            sSql = "SELECT * FROM USUARIOS WHERE NOME_USUARIO = '" & v_Usuario.p_Nome & "' "
            Return ProgramaSql.ExecuteDataTable(ProgramaSql.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSql.close()
        End Try
    End Function
End Class




