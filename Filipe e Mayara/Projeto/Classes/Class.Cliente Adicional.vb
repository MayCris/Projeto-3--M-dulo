Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Cliente_Adicional
    Inherits Dados_Pessoais
    Private id_adicional As Integer
    Private id_titular As Integer
    Private nome As String
    Private cep As String
    Private id_dados_pessoais As Integer
    Private grau_parentesco As String
    Public Property p_id_adicional() As Integer
        Get
            Return id_adicional
        End Get
        Set(ByVal value As Integer)
            id_adicional = value
        End Set
    End Property
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
    Public Property p_dados_pessoais() As Integer
        Get
            Return id_dados_pessoais
        End Get
        Set(ByVal value As Integer)
            id_dados_pessoais = value
        End Set
    End Property
    Public Property p_grau_parentesco() As String
        Get
            Return grau_parentesco
        End Get
        Set(ByVal value As String)
            grau_parentesco = value
        End Set
    End Property
    'lista dos itens da grid
    Public Function ListagemDataTableCliente_Adicional(ByVal C_Adicional As Cliente_Adicional) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM CLIENTE_ADICIONAL"

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar o ID do cliente adicional para a Variável
    Public Function RetornarID_ADICIONAL(ByVal C_Adicional As Cliente_Adicional) As Integer
        ProgramaSQL = New ProgramaSQL
        Dim dt As DataTable
        Dim dr As DataRow

        Try
            Dim sSql As String
            sSql = "SELECT ID_ADICIONAL FROM CLIENTE_ADICIONAL"
            sSql &= "WHERE NOME = '" & Trim(C_Adicional.p_nome) & "', "

            dt = ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
            For Each dr In dt.Rows
                Return dr("ID_ADICIONAL")
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridCliente_adicional(ByVal C_Adicional As Cliente_Adicional) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere As String = " WHERE "
            Dim sSql As String = ""
            sSql = " SELECT  "
            sSql &= "ca.ID_ADICIONAL, ca.NOME,"
            sSql &= "ct.ID_TITULAR as ID_TITULAR,"
            sSql &= "ct.NOME as NOME_TITULAR,"
            sSql &= "dp.DATA_NASCIMENTO as DATA_NASCIMENTO,"
            sSql &= "dp.TELEFONE as TELEFONE,"
            sSql &= "dp.CELULAR as CELULAR "
            sSql &= " FROM CLIENTE_ADICIONAL ca "
            sSql &= " LEFT OUTER JOIN CLIENTE_TITULAR ct ON ca.ID_TITULAR = ct.ID_TITULAR "
            sSql &= " LEFT OUTER JOIN DADOS_PESSOAIS dp ON ca.ID_DADOS_PESSOAIS = dp.ID_DADOS_PESSOAIS "
            If C_Adicional.p_nome <> "" Then
                sSql &= msWhere & " ca.NOME like '%" & C_Adicional.p_nome & "%'"
                msWhere = " AND "
            End If
            If C_Adicional.p_id_adicional > 0 Then
                sSql &= msWhere & " ID_ADICIONAL = " & C_Adicional.p_id_adicional
                msWhere = " AND "
            End If
            If C_Adicional.p_id_titular > 0 Then
                sSql &= msWhere & "ct.ID_TITULAR = " & C_Adicional.p_id_titular
                msWhere = " AND "
            End If
            If C_Adicional.p_id_dados_pessoais > 0 Then
                sSql &= msWhere & "dp.ID_DADOS_PESSOAIS = " & C_Adicional.p_id_dados_pessoais
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
    Public Function RetornarDadosCliente_Adicional(ByVal C_Adicional As Cliente_Adicional) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere As String = " WHERE "
            Dim sSql As String = ""
            If C_Adicional.p_id_adicional <> 0 Then
                sSql = "SELECT "
                sSql &= "ca.ID_ADICIONAL, ca.GRAU_PARENTESCO,"
                sSql &= "ca.ID_DADOS_PESSOAIS as ID_DADOS_PESSOAIS, "
                sSql &= "ca.NOME as NOME, "
                sSql &= "ca.ID_TITULAR as ID_TITULAR,"
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
                sSql &= " FROM CLIENTE_ADICIONAL ca "
                sSql &= " LEFT OUTER JOIN CLIENTE_TITULAR ct ON ca.ID_TITULAR = ct.ID_TITULAR "
                sSql &= " LEFT OUTER JOIN DADOS_PESSOAIS dp ON ca.ID_DADOS_PESSOAIS = dp.ID_DADOS_PESSOAIS "
                sSql &= " LEFT OUTER JOIN ENDERECOS ende ON ca.CEP = ende.CEP "
                If C_Adicional.p_id_titular > 0 Then
                    sSql &= "WHERE ca.ID_TITULAR = " & C_Adicional.p_id_titular
                End If
                If C_Adicional.p_id_dados_pessoais > 0 Then
                    sSql &= " WHERE ca.ID_DADOS_PESSOAIS = " & C_Adicional.p_id_dados_pessoais
                End If
                If C_Adicional.p_cep > 0 Then
                    sSql &= " WHERE ca.CEP = " & C_Adicional.p_cep
                End If
                If C_Adicional.p_id_adicional > 0 Then
                    sSql &= " WHERE ID_ADICIONAL = " & C_Adicional.p_id_adicional
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
    Public Function InserirCA(ByVal C_Adicional As Cliente_Adicional) As DataTable
        Return ExecutaConsultaCA(C_Adicional, "I")
    End Function
    'alterando dados
    Public Function AlterarCA(ByVal C_Adicional As Cliente_Adicional) As DataTable
        Return ExecutaConsultaCA(C_Adicional, "U")
    End Function
    'excluindo itens
    Public Function ExcluirCA(ByVal C_Adicional As Cliente_Adicional) As DataTable
        Return ExecutaConsultaCA(C_Adicional, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaCA(ByVal C_Adicional As Cliente_Adicional, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_CLIENTE_ADICIONAL "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_ADICIONAL = " & C_Adicional.p_id_adicional & ", "
            sSql &= "@p_ID_TITULAR = " & C_Adicional.p_id_titular & ", "
            sSql &= "@p_NOME = '" & C_Adicional.p_nome & "', "
            sSql &= "@p_CEP = '" & C_Adicional.p_cep & "', "
            sSql &= "@p_ID_DADOS_PESSOAIS = " & C_Adicional.p_id_dados_pessoais & ", "
            sSql &= "@p_GRAU_PARENTESCO = '" & C_Adicional.p_grau_parentesco & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class




