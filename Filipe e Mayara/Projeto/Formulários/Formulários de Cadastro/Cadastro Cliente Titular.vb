Public Class Frm_cliente_titular

    Private Sub Frm_cliente_titular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim C_Titular As New Cliente_Titular

        'CLIENTE TITULAR
        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_titular.Text) <> "" Then
            C_Titular.p_id_titular = Trim(txt_id_titular.Text)
            dt = C_Titular.RetornarDadosCiente_Titular(C_Titular)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_titular.Text = Trim(UCase(dr("ID_TITULAR")))
                    txt_id_dados_pessoais.Text = Trim(UCase(dr("ID_DADOS_PESSOAIS")))
                    If Not IsDBNull(dr("NOME")) Then
                        txt_nome.Text = Trim(UCase(dr("NOME")))
                    End If
                    If Not IsDBNull(dr("DATA_NASCIMENTO")) Then
                        Date_titular.Text = dr("DATA_NASCIMENTO")
                    End If
                    If Not IsDBNull(dr("SEXO")) Then
                        cbx_sexo.Text = Trim(dr("SEXO"))
                    End If
                    If Not IsDBNull(dr("RG")) Then
                        txt_rg.Text = dr("RG")
                    End If
                    If Not IsDBNull(dr("CPF")) Then
                        txt_cpf.Text = dr("CPF")
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
        Dim C_Titular As New Cliente_Titular

        If Trim(txt_nome.Text) = "" Then
            MsgBox("Nome Inválido!! Nome tem que ser preenchido")
            txt_nome.Focus()
            Exit Sub
        End If
        If Date_titular.Text = "" Then
            MsgBox("Data Nascimento Inválido!!!")
            Date_titular.Focus()
            Exit Sub
        End If
        If txt_cpf.Text = "" Then
            MsgBox("CPF Inválido!!!")
            txt_cpf.Focus()
            Exit Sub
        End If
        If txt_telefone.Text = "" Then
            MsgBox("TELEFONE Inválido!!!")
            txt_telefone.Focus()
            Exit Sub
        End If
        If txt_celular.Text = "" Then
            MsgBox("CELULAR Inválido!!!")
            txt_celular.Focus()
            Exit Sub
        End If
        If txt_logradouro.Text = "" Then
            MsgBox("LOGRADOURO Inválido!!!")
            txt_logradouro.Focus()
            Exit Sub
        End If
        If txt_numero.Text = "" Then
            MsgBox("NUMERO Inválido!!!")
            txt_numero.Focus()
            Exit Sub
        End If
        If txt_cep.Text = "" Then
            MsgBox("CEP Inválido!!!")
            txt_cep.Focus()
            Exit Sub
        End If

        'Preenchendo Data de Nascimento
        Dim AMD As String
        AMD = CDate(Date_titular.Text).Day & "/" & CDate(Date_titular.Text).Month & "/" & CDate(Date_titular.Text).Year


        'Gravando os Dados Pessoais do cliente
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



            'Gravando o Endereço caso não exista.
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


            'Gravando Dados do Cliente caso não exista
            C_Titular.p_id_titular = Trim(txt_id_titular.Text)
            C_Titular.p_nome = Trim(txt_nome.Text)
            C_Titular.p_cep = Trim(txt_cep.Text)
            C_Titular.p_id_dados_pessoais = mId_Dados_Pessoais

            If txt_operacao.Text = "I" Then
                dt = C_Titular.InserirCT(C_Titular)
            ElseIf txt_operacao.Text = "U" Then
                dt = C_Titular.AlterarCT(C_Titular)
            ElseIf txt_operacao.Text = "D" Then
                dt = C_Titular.ExcluirCT(C_Titular)
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
