Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class f_Fornecedores
    Inherits Enderecos
    Private id_fornecedor As Integer
    Private razao_social As String
    Private nome_fantasia As String
    Private cnpj As String
    Private contato As String
    Private telefone As String
    Private fax As String
    Private e_mail As String
    Private cep As String
    Public Property p_id_fornecedor() As Integer
        Get
            Return id_fornecedor
        End Get
        Set(ByVal value As Integer)
            id_fornecedor = value
        End Set
    End Property
    Public Property p_razao_social() As String
        Get
            Return razao_social
        End Get
        Set(ByVal value As String)
            razao_social = value
        End Set
    End Property
    Public Property p_nome_fantasia() As String
        Get
            Return nome_fantasia
        End Get
        Set(ByVal value As String)
            nome_fantasia = value
        End Set
    End Property
    Public Property p_cnpj() As String
        Get
            Return cnpj
        End Get
        Set(ByVal value As String)
            cnpj = value
        End Set
    End Property
    Public Property p_contato() As String
        Get
            Return contato
        End Get
        Set(ByVal value As String)
            contato = value
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
    Public Property p_fax() As String
        Get
            Return fax
        End Get
        Set(ByVal value As String)
            fax = value
        End Set
    End Property
    Public Property p_e_mail() As String
        Get
            Return e_mail
        End Get
        Set(ByVal value As String)
            e_mail = value
        End Set
    End Property
    'lista dos itens da grid
    Public Function ListagemDataTableF_Fornecedores(ByVal Fornecedores_F As f_Fornecedores) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM FORNECEDORES "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar o ID do fornecedor para a Variável
    Public Function RetornarID_FORNECEDOR(ByVal fornecedores_f As f_Fornecedores) As Integer
        ProgramaSQL = New ProgramaSQL
        Dim dt As DataTable
        Dim dr As DataRow

        Try
            Dim sSql As String
            sSql = "SELECT ID_FORNECEDOR FROM FORNECEDORES "
            sSql &= " WHERE RAZAO_SOCIAL = '" & Trim(fornecedores_f.razao_social) & "' "

            dt = ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
            For Each dr In dt.Rows
                Return dr("ID_FORNECEDOR")
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridf_Fornecedores(ByVal Fornecedores_F As f_Fornecedores) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT  "
            sSql &= "forn.ID_FORNECEDOR, forn.RAZAO_SOCIAL, forn.NOME_FANTASIA,"
            sSql &= "forn.CNPJ, forn.CONTATO, forn.TELEFONE, forn.FAX"
            sSql &= " FROM FORNECEDORES forn "
            If Fornecedores_F.p_razao_social <> "" Then
                sSql &= msWhere & " RAZAO_SOCIAL like '%" & Fornecedores_F.razao_social & "%'"
                msWhere = " AND "
            End If
            If Fornecedores_F.p_id_fornecedor > 0 Then
                sSql &= msWhere & " ID_FORNECEDOR = " & Fornecedores_F.p_id_fornecedor
                msWhere = " AND "
            End If
            If Fornecedores_F.p_nome_fantasia <> "" Then
                sSql &= msWhere & " NOME_FANTASIA like '%" & Fornecedores_F.p_nome_fantasia & "%'"
                msWhere = " AND "
            End If
            If Fornecedores_F.p_cnpj <> "" Then
                sSql &= msWhere & " CNPJ like '%" & Fornecedores_F.p_cnpj & "%'"
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
    Public Function RetornarDadosFornecedores(ByVal fornecedores_f As f_Fornecedores) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            If fornecedores_f.id_fornecedor <> 0 Then
                sSql = "SELECT "
                sSql &= "forn.ID_FORNECEDOR, forn.RAZAO_SOCIAL, "
                sSql &= "forn.NOME_FANTASIA, forn.CNPJ, forn.CONTATO,"
                sSql &= "forn.TELEFONE, forn.FAX, forn.E_MAIL,"
                sSql &= "ende.LOGRADOURO as LOGRADOURO,"
                sSql &= "ende.NUMERO as NUMERO,"
                sSql &= "ende.COMPLEMENTO as COMPLEMENTO,"
                sSql &= "ende.BAIRRO as BAIRRO,"
                sSql &= "ende.CIDADE as CIDADE,"
                sSql &= "ende.ESTADO as ESTADO,"
                sSql &= "ende.CEP as CEP "
                sSql &= " FROM FORNECEDORES forn "
                sSql &= " LEFT OUTER JOIN ENDERECOS ende ON forn.CEP = ende.CEP "
                If fornecedores_f.p_cep > 0 Then
                    sSql &= " WHERE forn.CEP = " & fornecedores_f.p_cep
                End If
                If fornecedores_f.p_id_fornecedor > 0 Then
                    sSql &= " WHERE forn.ID_FORNECEDOR = " & fornecedores_f.p_id_fornecedor
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
    Public Function InserirFornecedores(ByVal Fornecedores_F As f_Fornecedores) As DataTable
        Return ExecutaConsultaFornecedores(Fornecedores_F, "I")
    End Function
    'alterando dados
    Public Function AlterarFornecedores(ByVal Fornecedores_F As f_Fornecedores) As DataTable
        Return ExecutaConsultaFornecedores(Fornecedores_F, "U")
    End Function
    'excluindo itens
    Public Function ExcluirFornecedores(ByVal Fornecedores_F As f_Fornecedores) As DataTable
        Return ExecutaConsultaFornecedores(Fornecedores_F, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaFornecedores(ByVal Fornecedores_F As f_Fornecedores, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_FORNECEDORES "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_FORNECEDOR = " & Fornecedores_F.p_id_fornecedor & ", "
            sSql &= "@p_RAZAO_SOCIAL= '" & Fornecedores_F.p_razao_social & "', "
            sSql &= "@p_NOME_FANTASIA = '" & Fornecedores_F.p_nome_fantasia & "', "
            sSql &= "@p_CNPJ = '" & Fornecedores_F.p_cnpj & "', "
            sSql &= "@p_CONTATO = '" & Fornecedores_F.p_contato & "', "
            sSql &= "@p_TELEFONE= '" & Fornecedores_F.p_telefone & "', "
            sSql &= "@p_FAX = '" & Fornecedores_F.p_fax & "', "
            sSql &= "@p_E_MAIL = '" & Fornecedores_F.p_e_mail & "', "
            sSql &= "@p_CEP = '" & Fornecedores_F.p_cep & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class

