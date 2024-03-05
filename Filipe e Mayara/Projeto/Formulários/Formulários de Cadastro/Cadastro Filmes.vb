Public Class Frm_filmes

    Private Sub Frm_filmes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim F_Filmes As New Filmes

        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_filme.Text) <> "" Then
            F_Filmes.p_id_filme = Trim(txt_id_filme.Text)
            dt = F_Filmes.RetornarDadosFilmes(F_Filmes)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_filme.Text = Trim(UCase(dr("ID_FILME")))
                    txt_Id_Midia.Text = Trim(UCase(dr("ID_MIDIA")))
                    If Not IsDBNull(dr("FILME")) Then
                        txt_filme.Text = Trim(dr("FILME"))
                    End If
                    If Not IsDBNull(dr("ID_MIDIA")) Then
                        txt_Id_Midia.Text = Trim(dr("ID_MIDIA"))
                    End If
                    If Not IsDBNull(dr("ANO_LANCAMENTO")) Then
                        txt_ano_lancamento.Text = Trim(dr("ANO_LANCAMENTO"))
                    End If
                    If Not IsDBNull(dr("GENERO")) Then
                        cbx_genero.Text = Trim(dr("GENERO"))
                    End If
                    If Not IsDBNull(dr("NACIONALIDADE")) Then
                        txt_nacionalidade.Text = Trim(dr("NACIONALIDADE"))
                    End If
                    If Not IsDBNull(dr("DURACAO")) Then
                        txt_duracao.Text = Trim(dr("DURACAO"))
                    End If
                    If Not IsDBNull(dr("DIRECAO")) Then
                        txt_direcao.Text = Trim(dr("DIRECAO"))
                    End If
                    If Not IsDBNull(dr("SINOPSE")) Then
                        txt_sinopse.Text = Trim(dr("SINOPSE"))
                    End If
                    If Not IsDBNull(dr("PRECO")) Then
                        txt_preco.Text = Trim(dr("PRECO"))
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

        If Trim(txt_filme.Text) = "" Then
            MsgBox("Filme Inválido!! Filme tem que ser preenchido")
            txt_filme.Focus()
            Exit Sub
        End If
        If txt_ano_lancamento.Text = "" Then
            MsgBox("Ano de Lancamento Inválido!!!")
            txt_ano_lancamento.Focus()
            Exit Sub
        End If
        If cbx_genero.Text = "" Then
            MsgBox("Genero Inválido!!!")
            cbx_genero.Focus()
            Exit Sub
        End If
        If txt_nacionalidade.Text = "" Then
            MsgBox("Nacionalidade Inválida!!!")
            txt_nacionalidade.Focus()
            Exit Sub
        End If
        If txt_duracao.Text = "" Then
            MsgBox("Duracao Inválida!!!")
            txt_duracao.Focus()
            Exit Sub
        End If
        If txt_direcao.Text = "" Then
            MsgBox("Direcao Inválida!!!")
            txt_direcao.Focus()
            Exit Sub
        End If
        If txt_sinopse.Text = "" Then
            MsgBox("Sinopse Inválida!!!")
            txt_sinopse.Focus()
            Exit Sub
        End If
        If Val(Trim(txt_preco.Text)) = 0 Then
            MsgBox("Preço do Filme Inválido!!")
            txt_preco.Focus()
            Exit Sub
        End If


        Try
            'Gravando Dados do Filme
            Dim F_Filmes As New Filmes
            F_Filmes.p_id_filme = Trim(txt_id_filme.Text)
            F_Filmes.p_filme = Trim(txt_filme.Text)
            F_Filmes.p_id_midia = Trim(txt_Id_Midia.Text)
            F_Filmes.p_ano_lancamento = Trim(txt_ano_lancamento.Text)
            F_Filmes.p_genero = Trim(cbx_genero.Text)
            F_Filmes.p_nacionalidade = Trim(txt_nacionalidade.Text)
            F_Filmes.p_duracao = Trim(txt_duracao.Text)
            F_Filmes.p_direcao = Trim(txt_direcao.Text)
            F_Filmes.p_sinopse = Trim(txt_sinopse.Text)
            F_Filmes.p_preco = CType(txt_preco.Text, Decimal)

            MsgBox("Registro Gravado com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.Information, "Gravar Registro")

            If txt_operacao.Text = "I" Then
                dt = F_Filmes.InserirFilmes(F_Filmes)
            ElseIf txt_operacao.Text = "U" Then
                dt = F_Filmes.AlterarFilmes(F_Filmes)
            ElseIf txt_operacao.Text = "D" Then
                dt = F_Filmes.ExcluirFilmes(F_Filmes)
            End If
            Me.Close()
            dr = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
End Class