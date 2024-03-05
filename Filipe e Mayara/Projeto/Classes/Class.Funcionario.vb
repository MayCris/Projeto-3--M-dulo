Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Funcionarios
    Inherits Dados_Pessoais
    Private id_funcionario As Integer
    Private nome As String
    Private horario_trabalho As String
    Private data_admissao As Date
    Private cargo As String
    Private salario As Double
    Private estado_civil As String
    Private id_dados_pessoais As Integer
    Private cep As String
    Public Property p_id_funcionario() As Integer
        Get
            Return id_funcionario
        End Get
        Set(ByVal value As Integer)
            id_funcionario = value
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
    Public Property p_horario_trabalho() As String
        Get
            Return horario_trabalho
        End Get
        Set(ByVal value As String)
            horario_trabalho = value
        End Set
    End Property
    Public Property p_data_admissao() As Date
        Get
            Return data_admissao
        End Get
        Set(ByVal value As Date)
            data_admissao = value
        End Set
    End Property
    Public Property p_cargo() As String
        Get
            Return cargo
        End Get
        Set(ByVal value As String)
            cargo = value
        End Set
    End Property
    Public Property p_salario() As Double
        Get
            Return salario
        End Get
        Set(ByVal value As Double)
            salario = value
        End Set
    End Property
    Public Property p_estado_civil() As String
        Get
            Return estado_civil
        End Get
        Set(ByVal value As String)
            estado_civil = value
        End Set
    End Property
    'lista dos itens da grid
    Public Function ListagemDataTablef_Funcionarios(ByVal funcionarios As f_funcionarios) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String = ""
            sSql = "SELECT * FROM FUNCIONARIOS "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    'retornar o ID do funcionario para Variável
    Public Function RetornarID_FUNCIONARIO(ByVal f_funcionarios As Funcionarios) As Integer
        ProgramaSQL = New ProgramaSQL
        Dim dt As DataTable
        Dim dr As DataRow

        Try
            Dim sSql As String
            sSql = "SELECT ID_FUNCIONARIO FROM FUNCIONARIOS "
            sSql &= " WHERE NOME = '" & Trim(f_funcionarios.p_nome) & "' "

            dt = ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
            For Each dr In dt.Rows
                Return dr("ID_FUNCIONARIO")
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
    Public Function LstGridFuncionarios(ByVal f_funcionarios As Funcionarios) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            dim msWhere = "WHERE"
            Dim sSql As String = ""
            sSql = " SELECT  "
            sSql &= "fun.ID_FUNCIONARIO, fun.NOME,"
            sSql &= "fun.HORARIO_TRABALHO,"
            sSql &= "fun.CARGO,"
            sSql &= "dp.TELEFONE as TELEFONE,"
            sSql &= "dp.CELULAR as CELULAR "
            sSql &= " FROM FUNCIONARIOS fun "
            sSql &= " LEFT OUTER JOIN DADOS_PESSOAIS dp ON fun.ID_DADOS_PESSOAIS = dp.ID_DADOS_PESSOAIS "
            If f_funcionarios.id_dados_pessoais > 0 Then
                sSql &= msWhere & " dp.ID_DADOS_PESSOAIS = " & f_funcionarios.id_dados_pessoais
                msWhere = " AND "
            End If
            If f_funcionarios.id_funcionario > 0 Then
                sSql &= msWhere & " ID_FUNCIONARIO = " & f_funcionarios.id_funcionario
                msWhere = " AND "
            End If
            If f_funcionarios.p_nome <> "" Then
                sSql &= msWhere & " NOME like '%" & f_funcionarios.p_nome & "%'"
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
    Public Function RetornarDadosFuncionarios(ByVal f_funcionarios As Funcionarios) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim msWhere = "WHERE"
            Dim sSql As String = ""
            If f_funcionarios.id_funcionario <> 0 Then
                sSql = "SELECT "
                sSql &= "fun.ID_FUNCIONARIO, fun.NOME, "
                sSql &= "fun.ID_DADOS_PESSOAIS as ID_DADOS_PESSOAIS, "
                sSql &= "fun.HORARIO_TRABALHO, fun.DATA_ADMISSAO,"
                sSql &= "fun.CARGO, fun.SALARIO, fun.ESTADO_CIVIL,"
                sSql &= "dp.DATA_NASCIMENTO as DATA_NASCIMENTO,"
                sSql &= "dp.SEXO as SEXO,"
                sSql &= "dp.RG as RG,"
                sSql &= "dp.CPF as CPF,"
                sSql &= "dp.TELEFONE as TELEFONE,"
                sSql &= "dp.CELULAR as CELULAR,"
                sSql &= "dp.E_MAIL as E_MAIL,"
                sSql &= "ende.LOGRADOURO as LOGRADOURO,"
                sSql &= "ende.NUMERO as NUMERO, "
                sSql &= "ende.COMPLEMENTO as COMPLEMENTO,"
                sSql &= "ende.BAIRRO as BAIRRO,"
                sSql &= "ende.CIDADE as CIDADE,"
                sSql &= "ende.ESTADO as ESTADO,"
                sSql &= "ende.CEP as CEP "
                sSql &= " FROM FUNCIONARIOS fun "
                sSql &= " LEFT OUTER JOIN DADOS_PESSOAIS dp ON fun.ID_DADOS_PESSOAIS = dp.ID_DADOS_PESSOAIS "
                sSql &= " LEFT OUTER JOIN ENDERECOS ende ON fun.CEP = ende.CEP "
                If f_funcionarios.id_dados_pessoais > 0 Then
                    sSql &= " WHERE fun.ID_DADOS_PESSOAIS = " & f_funcionarios.p_id_dados_pessoais
                End If
                If f_funcionarios.p_cep > 0 Then
                    sSql &= " WHERE fun.CEP = " & f_funcionarios.p_cep
                End If
                If f_funcionarios.p_id_funcionario > 0 Then
                    sSql &= " WHERE ID_FUNCIONARIO = " & f_funcionarios.p_id_funcionario
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
    Public Function InserirFuncionarios(ByVal F_Funcionarios As Funcionarios) As DataTable
        Return ExecutaConsultaFuncionarios(F_Funcionarios, "I")
    End Function
    'alterando dados
    Public Function AlterarFuncionarios(ByVal F_Funcionarios As Funcionarios) As DataTable
        Return ExecutaConsultaFuncionarios(F_Funcionarios, "U")
    End Function
    'excluindo itens
    Public Function ExcluirFuncionarios(ByVal F_Funcionarios As Funcionarios) As DataTable
        Return ExecutaConsultaFuncionarios(F_Funcionarios, "D")
    End Function
    'executa consulta padrão do banco
    Protected Function ExecutaConsultaFuncionarios(ByVal F_Funcionarios As Funcionarios, ByVal v_tipo As String) As DataTable
        ProgramaSQL = New ProgramaSQL

        Try
            Dim sSql As String
            sSql = "sp_FUNCIONARIOS "
            sSql &= "@p_Opcao = '" & v_tipo & "', "
            sSql &= "@p_ID_FUNCIONARIO = " & F_Funcionarios.p_id_funcionario & ", "
            sSql &= "@p_NOME = '" & F_Funcionarios.p_nome & "', "
            sSql &= "@p_HORARIO_TRABALHO = '" & F_Funcionarios.p_horario_trabalho & "', "
            sSql &= "@p_DATA_ADMISSAO = '" & F_Funcionarios.p_data_admissao & "', "
            sSql &= "@p_CARGO = '" & F_Funcionarios.p_cargo & "', "
            sSql &= "@p_SALARIO = '" & F_Funcionarios.p_salario & "', "
            sSql &= "@P_ESTADO_CIVIL = '" & F_Funcionarios.p_estado_civil & "', "
            sSql &= "@p_ID_DADOS_PESSOAIS = " & F_Funcionarios.p_id_dados_pessoais & ", "
            sSql &= "@p_CEP = '" & F_Funcionarios.p_cep & "' "

            Return ProgramaSQL.ExecuteDataTable(ProgramaSQL.tipoSql.sql_texto, sSql)
        Catch ex As Exception
            Throw ex
        Finally
            ProgramaSQL.close()
        End Try
    End Function
End Class
