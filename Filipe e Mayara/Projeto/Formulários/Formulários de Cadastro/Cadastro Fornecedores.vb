Public Class Frm_fornecedores

    Private Sub Frm_fornecedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim Fornecedores_F As New f_Fornecedores

        'FORNECEDORES
        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_fornecedor.Text) <> "" Then
            Fornecedores_F.p_id_fornecedor = Trim(txt_id_fornecedor.Text)
            dt = Fornecedores_F.RetornarDadosFornecedores(Fornecedores_F)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_fornecedor.Text = Trim(UCase(dr("ID_FORNECEDOR")))
                    If Not IsDBNull(dr("RAZAO_SOCIAL")) Then
                        txt_razao_social.Text = dr("RAZAO_SOCIAL")
                    End If
                    If Not IsDBNull(dr("NOME_FANTASIA")) Then
                        txt_nome_fantasia.Text = dr("NOME_FANTASIA")
                    End If
                    If Not IsDBNull(dr("CNPJ")) Then
                        txt_cnpj.Text = dr("CNPJ")
                    End If
                    If Not IsDBNull(dr("CONTATO")) Then
                        txt_contato.Text = dr("CONTATO")
                    End If
                    If Not IsDBNull(dr("TELEFONE")) Then
                        txt_telefone.Text = dr("TELEFONE")
                    End If
                    If Not IsDBNull(dr("FAX")) Then
                        txt_fax.Text = dr("FAX")
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
        Dim Fornecedores_F As New f_Fornecedores

        If Trim(txt_razao_social.Text) = "" Then
            MsgBox("Razao Social Inválido!! Razao Social tem que ser preenchido")
            txt_razao_social.Focus()
            Exit Sub
        End If
        If txt_nome_fantasia.Text = "" Then
            MsgBox("Nome Fantasia Inválido!!!")
            txt_nome_fantasia.Focus()
            Exit Sub
        End If
        If txt_cnpj.Text = "" Then
            MsgBox("CNPJ Inválido!!!")
            txt_cnpj.Focus()
            Exit Sub
        End If
        If txt_contato.Text = "" Then
            MsgBox("Contato Inválido!!!")
            txt_contato.Focus()
            Exit Sub
        End If
        If txt_telefone.Text = "" Then
            MsgBox("Telefone Inválido!!!")
            txt_telefone.Focus()
            Exit Sub
        End If
        If txt_fax.Text = "" Then
            MsgBox("Fax Inválido!!!")
            txt_fax.Focus()
            Exit Sub
        End If
        If txt_email.Text = "" Then
            MsgBox("E_mail Inválido!!!")
            txt_email.Focus()
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


        'Gravando o Endereço caso não exista.
        Try

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
            

            'Gravando Dados do Fornecedor caso não exista
            Fornecedores_F.p_id_fornecedor = Trim(txt_id_fornecedor.Text)
            Fornecedores_F.p_razao_social = Trim(txt_razao_social.Text)
            Fornecedores_F.p_nome_fantasia = Trim(txt_nome_fantasia.Text)
            Fornecedores_F.p_cnpj = Trim(txt_cnpj.Text)
            Fornecedores_F.p_contato = Trim(txt_contato.Text)
            Fornecedores_F.p_telefone = Trim(txt_telefone.Text)
            Fornecedores_F.p_fax = Trim(txt_fax.Text)
            Fornecedores_F.p_e_mail = Trim(txt_email.Text)
            Fornecedores_F.p_cep = Trim(txt_cep.Text)


            If txt_operacao.Text = "I" Then
                dt = Fornecedores_F.InserirFornecedores(Fornecedores_F)
            ElseIf txt_operacao.Text = "U" Then
                dt = Fornecedores_F.AlterarFornecedores(Fornecedores_F)
            ElseIf txt_operacao.Text = "D" Then
                dt = Fornecedores_F.ExcluirFornecedores(Fornecedores_F)
            End If
            MsgBox("Registro Gravado com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.Information, "Gravar Registro")
            Me.Close()
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