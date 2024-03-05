Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Cliente_Titular
    Inherits Dados_Pessoais
    Private id_titular As Integer
    Private nome As String
    Private cep As String
    Private id_dados_pessoais As Integer
    Public Property p_id_titular() As Integer
        Get
            Return id_titular
        End Get
        Set(ByVal value As Integer)
            id_titular = value
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
    Public Function ListagemDataTableCliente_Titular(ByVal C_Titular As Cliente_Titular) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM CLIENTE_TITULAR "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar o ID do cliente titular para a Variável
    Public Function RetornarID_TITULAR(ByVal C_Titular As Cliente_Titular) As Integer
        ProgramaSQL = New ProgramaSQL
        Dim dt As DataTable
        Dim dr As DataRow

        Try
            Dim sSql As String
            sSql = "SELECT ID_TITULAR FROM CLIENTE_TITULAR "
            sSql &= " WHERE NOME = '" & Trim(C_Titular.p_nome) & "' "

            dt = ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
            For Each dr In dt.Rows
                Return dr("ID_TITULAR")
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridCliente_Titular(ByVal C_Titular As Cliente_Titular) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT  "
            sSql &= "ct.ID_TITULAR, ct.NOME,"
            sSql &= "dp.DATA_NASCIMENTO as DATA_NASCIMENTO,"
            sSql &= "dp.TELEFONE as TELEFONE,"
            sSql &= "dp.CELULAR as CELULAR,"
            sSql &= "dp.E_MAIL as E_MAIL"
            sSql &= " FROM CLIENTE_TITULAR ct "
            sSql &= " LEFT OUTER JOIN DADOS_PESSOAIS dp ON ct.ID_DADOS_PESSOAIS = dp.ID_DADOS_PESSOAIS "
            If C_Titular.p_nome <> "" Then
                sSql &= msWhere & " NOME like '%" & C_Titular.p_nome & "%'"
                msWhere = " AND "
            End If
            If C_Titular.p_id_titular > 0 Then
                sSql &= msWhere & " ID_TITULAR = " & C_Titular.p_id_titular
                msWhere = " AND "
            End If
            If C_Titular.p_id_dados_pessoais > 0 Then
                sSql &= msWhere & "ct.ID_DADOS_PESSOAIS = " & C_Titular.p_id_dados_pessoais
            End If

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar os dados do registro para alteração
    Public Function RetornarDadosCiente_Titular(ByVal C_Titular As Cliente_Titular) As DataTable
        ProgramaSQL = New ProgramaSQL

        Dim v_Dados_Pessoais As New Dados_Pessoais
        Try
            Dim sSql As String = ""
            If C_Titular.p_id_titular <> 0 Then
                sSql = "SELECT "
                sSql &= "ct.ID_TITULAR, ct.NOME, "
                sSql &= "ct.ID_DADOS_PESSOAIS as ID_DADOS_PESSOAIS, "
                sSql &= "dp.DATA_NASCIMENTO as DATA_NASCIMENTO,"
                sSql &= "dp.SEXO as SEXO,"
                sSql &= "dp.RG as RG,"
                sSql &= "dp.CPF as CPF,"
                sSql &= "dp.TELEFONE as TELEFONE,"
                sSql &= "dp.CELULAR as CELULAR,"
                sSql &= "dp.E_MAIL as E_MAIL,"
                sSql &= "ende.LOGRADOURO as LOGRADOURO,"
                sSql &= "ende.NUMERO as NUMERO,"
                sSql &= "ende.COMPLEMENTO as COMPLEMENTO,"
                sSql &= "ende.BAIRRO as BAIRRO,"
                sSql &= "ende.CIDADE as CIDADE,"
                sSql &= "ende.ESTADO as ESTADO,"
                sSql &= "ende.CEP as CEP "
                sSql &= " FROM CLIENTE_TITULAR ct "
                sSql &= " LEFT OUTER JOIN DADOS_PESSOAIS dp ON ct.ID_DADOS_PESSOAIS = dp.ID_DADOS_PESSOAIS "
                sSql &= " LEFT OUTER JOIN ENDERECOS ende ON ct.CEP = ende.CEP"
                If C_Titular.p_id_dados_pessoais > 0 Then
                    sSql &= " WHERE ct.ID_DADOS_PESSOAIS = " & C_Titular.p_id_dados_pessoais
                End If
                If C_Titular.p_cep > 0 Then
                    sSql &= " WHERE ct.CEP = " & C_Titular.p_cep
                End If
                If C_Titular.p_id_titular > 0 Then
                    sSql &= " WHERE ID_TITULAR = " & C_Titular.p_id_titular
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
    Public Function InserirCT(ByVal C_Titular As Cliente_Titular) As DataTable
        Return ExecutaConsultaCT(C_Titular, "I")
    End Function
    'alterando dados
    Public Function AlterarCT(ByVal C_Titular As Cliente_Titular) As DataTable
        Return ExecutaConsultaCT(C_Titular, "U")
    End Function
    'excluindo itens
    Public Function ExcluirCT(ByVal C_Titular As Cliente_Titular) As DataTable
        Return ExecutaConsultaCT(C_Titular, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaCT(ByVal C_Titular As Cliente_Titular, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_CLIENTE_TITULAR "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_TITULAR = " & C_Titular.p_id_titular & ", "
            sSql &= "@p_NOME = '" & C_Titular.p_nome & "', "
            sSql &= "@p_CEP = '" & C_Titular.p_cep & "', "
            sSql &= "@p_ID_DADOS_PESSOAIS = " & C_Titular.p_id_dados_pessoais & " "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class


