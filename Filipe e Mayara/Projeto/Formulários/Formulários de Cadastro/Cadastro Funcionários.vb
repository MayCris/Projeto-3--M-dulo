Public Class Frm_funcionarios

    Private Sub Frm_funcionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim F_Funcionarios As New Funcionarios

        'FUNCIONARIOS
        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_funcionario.Text) <> "" Then
            F_Funcionarios.p_id_funcionario = Trim(txt_id_funcionario.Text)
            dt = F_Funcionarios.RetornarDadosFuncionarios(F_Funcionarios)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_funcionario.Text = Trim(UCase(dr("ID_FUNCIONARIO")))
                    txt_id_dados_pessoais.Text = Trim(UCase(dr("ID_DADOS_PESSOAIS")))
                    If Not IsDBNull(dr("NOME")) Then
                        txt_nome.Text = dr("NOME")
                    End If
                    If Not IsDBNull(dr("SEXO")) Then
                        cbx_sexo.Text = dr("SEXO")
                    End If
                    If Not IsDBNull(dr("ESTADO_CIVIL")) Then
                        cbx_estado_civil.Text = dr("ESTADO_CIVIL")
                    End If
                    If Not IsDBNull(dr("RG")) Then
                        txt_rg.Text = dr("RG")
                    End If
                    If Not IsDBNull(dr("CPF")) Then
                        txt_cpf.Text = dr("CPF")
                    End If
                    If Not IsDBNull(dr("DATA_NASCIMENTO")) Then
                        Date_funcionario.Text = dr("DATA_NASCIMENTO")
                    End If
                    If Not IsDBNull(dr("TELEFONE")) Then
                        txt_telefone.Text = dr("TELEFONE")
                    End If
                    If Not IsDBNull(dr("CELULAR")) Then
                        txt_celular.Text = dr("CELULAR")
                    End If
                    If Not IsDBNull(dr("E_MAIL")) Then
                        txt_email.Text = dr("E_MAIL")
                    End If
                    If Not IsDBNull(dr("DATA_ADMISSAO")) Then
                        Date_admissao.Text = dr("DATA_ADMISSAO")
                    End If
                    If Not IsDBNull(dr("CARGO")) Then
                        txt_cargo.Text = dr("CARGO")
                    End If
                    If Not IsDBNull(dr("HORARIO_TRABALHO")) Then
                        txt_horario_trabalho.Text = dr("HORARIO_TRABALHO")
                    End If
                    If Not IsDBNull(dr("SALARIO")) Then
                        txt_salario.Text = ToString.Format(dr("SALARIO"), "0.00")
                    End If
                    If Not IsDBNull(dr("LOGRADOURO")) Then
                        txt_logradouro.Text = dr("LOGRADOURO")
                    End If
                    If Not IsDBNull(dr("NUMERO")) Then
                        txt_numero.Text = dr("NUMERO")
                    End If
                    If Not IsDBNull(dr("COMPLEMENTO")) Then
                        txt_complemento.Text = dr("COMPLEMENTO")
                    End If
                    If Not IsDBNull(dr("BAIRRO")) Then
                        txt_bairro.Text = dr("BAIRRO")
                    End If
                    If Not IsDBNull(dr("CIDADE")) Then
                        txt_cidade.Text = dr("CIDADE")
                    End If
                    If Not IsDBNull(dr("ESTADO")) Then
                        txt_estado.Text = dr("ESTADO")
                    End If
                    If Not IsDBNull(dr("CEP")) Then
                        txt_cep.Text = dr("CEP")
                    End If
                Next
            End If
            dt = Nothing
        End If
    End Sub
    Private Sub btn_gravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gravar.Click
        Dim sSql As String = ""
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim f_Funcionarios As New Funcionarios

        If Trim(txt_nome.Text) = "" Then
            MsgBox("Nome Inv�lido!! Nome tem que ser preenchido")
            txt_nome.Focus()
            Exit Sub
        End If
        If cbx_sexo.Text = "" Then
            MsgBox("Sexo Inv�lido!!!")
            cbx_sexo.Focus()
            Exit Sub
        End If
        If cbx_estado_civil.Text = "" Then
            MsgBox("Estado Civil Inv�lido!!!")
            cbx_estado_civil.Focus()
            Exit Sub
        End If
        If txt_rg.Text = "" Then
            MsgBox("RG Inv�lido!!!")
            txt_rg.Focus()
            Exit Sub
        End If
        If txt_cpf.Text = "" Then
            MsgBox("CPF Inv�lido!!!")
            txt_cpf.Focus()
            Exit Sub
        End If
        If Date_funcionario.Text = "" Then
            MsgBox("Data Nascimento Inv�lido!!!")
            Date_funcionario.Focus()
            Exit Sub
        End If
        If txt_telefone.Text = "" Then
            MsgBox("Telefone Inv�lido!!!")
            txt_telefone.Focus()
            Exit Sub
        End If
        If txt_celular.Text = "" Then
            MsgBox("Celular Inv�lido!!!")
            txt_celular.Focus()
            Exit Sub
        End If
        If Date_admissao.Text = "" Then
            MsgBox("Data Admissao Inv�lido!!!")
            Date_admissao.Focus()
            Exit Sub
        End If
        If txt_cargo.Text = "" Then
            MsgBox("Cargo Inv�lido!!!")
            txt_cargo.Focus()
            Exit Sub
        End If
        If txt_horario_trabalho.Text = "" Then
            MsgBox("Horario de Trabalho Inv�lido!!!")
            txt_horario_trabalho.Focus()
            Exit Sub
        End If
        If Val(Trim(txt_salario.Text)) = 0 Then
            MsgBox("Sal�rio Inv�lido!! Sal�rio tem que ser preenchido")
            txt_salario.Focus()
            Exit Sub
        End If
        If txt_logradouro.Text = "" Then
            MsgBox("LOGRADOURO Inv�lido!!!")
            txt_logradouro.Focus()
            Exit Sub
        End If
        If txt_numero.Text = "" Then
            MsgBox("NUMERO Inv�lido!!!")
            txt_numero.Focus()
            Exit Sub
        End If
        If txt_cep.Text = "" Then
            MsgBox("CEP Inv�lido!!!")
            txt_cep.Focus()
            Exit Sub
        End If

        'Preenchendo Data de Nascimento
        Dim AMD As String
        AMD = CDate(Date_funcionario.Text).Day & "/" & CDate(Date_funcionario.Text).Month & "/" & CDate(Date_funcionario.Text).Year

        'Preenchendo Data de Admiss�o
        Dim AMD_Admissao As String
        AMD_Admissao = CDate(Date_admissao.Text).Day & "/" & CDate(Date_admissao.Text).Month & "/" & CDate(Date_admissao.Text).Year

        'Formato de preenchimento do Sal�rio
        Dim Vl_Salario As Double
        Vl_Salario = Replace(txt_salario.Text, ".", "")
        Vl_Salario = Replace(Vl_Salario, ",", ".")


        'Gravando os Dados Pessoais do funcion�rio
        Dim mId_Dados_Pessoais As Integer
        Try
            Dim v_Dados_Pessoais As New Dados_Pessoais
            v_Dados_Pessoais.p_id_dados_pessoais = Trim(txt_id_dados_pessoais.Text)
            v_Dados_Pessoais.p_rg = Trim(txt_rg.Text)
            v_Dados_Pessoais.p_cpf = Trim(txt_cpf.Text)
            v_Dados_Pessoais.p_sexo = Trim(cbx_sexo.Text)
            v_Dados_Pessoais.p_data_nascimento = AMD
            v_Dados_Pessoais.p_telefone = Trim(txt_telefone.Text)
            v_Dados_Pessoais.p_celular = Trim(txt_celular.Text)
            v_Dados_Pessoais.p_e_mail = Trim(txt_email.Text)

            If txt_operacao.Text = "I" Then
                dt = v_Dados_Pessoais.InserirDP(v_Dados_Pessoais)
            ElseIf txt_operacao.Text = "U" Then
                dt = v_Dados_Pessoais.AlterarDP(v_Dados_Pessoais)
            ElseIf txt_operacao.Text = "D" Then
                dt = v_Dados_Pessoais.ExcluirDP(v_Dados_Pessoais)
            End If
            dr = Nothing

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    mId_Dados_Pessoais = dr("ID_DADOS_PESSOAIS")
                Next
            End If



            'Gravando o Endere�o caso n�o exista.
            Dim v_Enderecos As New Enderecos

            v_Enderecos.p_cep = Trim(txt_cep.Text)
            dt = v_Enderecos.RetornarDadosEnderecos(v_Enderecos)

            If dt.Rows.Count = 0 Then
                v_Enderecos.p_cep = Trim(txt_cep.Text)
                v_Enderecos.p_logradouro = Trim(txt_logradouro.Text)
                v_Enderecos.p_numero = Trim(txt_numero.Text)
                v_Enderecos.p_complemento = Trim(txt_complemento.Text)
                v_Enderecos.p_bairro = Trim(txt_bairro.Text)
                v_Enderecos.p_cidade = Trim(txt_cidade.Text)
                v_Enderecos.p_estado = Trim(txt_estado.Text)

                If txt_operacao.Text = "I" Then
                    dt = v_Enderecos.InserirEnderecos(v_Enderecos)
                ElseIf txt_operacao.Text = "U" Then
                    dt = v_Enderecos.AlterarEnderecos(v_Enderecos)
                ElseIf txt_operacao.Text = "D" Then
                    dt = v_Enderecos.ExcluirEnderecos(v_Enderecos)
                End If
            End If
            dr = Nothing



            'Gravando Dados do Funcionario caso n�o exista
            f_Funcionarios.p_id_funcionario = Trim(txt_id_funcionario.Text)
            f_Funcionarios.p_nome = Trim(txt_nome.Text)
            f_Funcionarios.p_horario_trabalho = Trim(txt_horario_trabalho.Text)
            f_Funcionarios.p_data_admissao = AMD_Admissao
            f_Funcionarios.p_cargo = Trim(txt_cargo.Text)
            f_Funcionarios.p_salario = Vl_Salario
            f_Funcionarios.p_estado_civil = Trim(cbx_estado_civil.Text)
            f_Funcionarios.p_id_dados_pessoais = mId_Dados_Pessoais
            f_Funcionarios.p_cep = Trim(txt_cep.Text)

            If txt_operacao.Text = "I" Then
                dt = f_Funcionarios.InserirFuncionarios(f_Funcionarios)
            ElseIf txt_operacao.Text = "U" Then
                dt = f_Funcionarios.AlterarFuncionarios(f_Funcionarios)
            ElseIf txt_operacao.Text = "D" Then
                dt = f_Funcionarios.ExcluirFuncionarios(f_Funcionarios)
            End If
            MsgBox("Registro Gravado com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.Information, "Gravar Registro")
            Me.Close()
            dr = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
    Private Sub txt_cep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cep.LostFocus
        txt_cep.Text = CType(txt_cep.Text, Decimal).ToString("0####-###")
    End Sub
End Class