Public Class Frm_locacao

    Private Sub Frm_locacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim L_cliente As New Locacao_cliente
        Dim L_Filme As New Locacao_filme
     
        'Locação Cliente
        dt = L_cliente.LstGridlocacao_cliente(L_cliente)
        If dt.Rows.Count > 0 Then
            With Grid_locacao_cliente
                Me.Grid_locacao_cliente.Rows.Clear()
                Me.Grid_locacao_cliente.DataSource = dt
                Me.Grid_locacao_cliente.AutoResizeColumns()
            End With
        End If


        'Locação Filme
        dt = L_Filme.LstGridlocacao_filme(L_Filme)
        If dt.Rows.Count > 0 Then
            With grid_locacao_filme
                Me.grid_locacao_filme.Rows.Clear()
                Me.grid_locacao_filme.DataSource = dt
                Me.grid_locacao_filme.AutoResizeColumns()
            End With
        End If


        
        'LOCAÇÃO
        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_locacao.Text) <> "" Then
            L_cliente.p_id_locacao = Trim(txt_id_locacao.Text)
            L_Filme.p_id_locacao = Trim(txt_id_locacao.Text)
            dt = L_cliente.RetornarDadosLocacao_cliente(L_cliente)
            dt = L_Filme.RetornarDadosLocacao_filme(L_Filme)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_locacao.Text = Trim(UCase(dr("ID_LOCACAO")))
                    txt_id_filme.Text = Trim(UCase(dr("ID_FILME")))
                    If Not IsDBNull(dr("NOME")) Then
                        txt_nome.Text = dr("NOME")
                    End If
                    
                    If Not IsDBNull(dr("DATA_RETIRADA")) Then
                        Date_retirada.Text = Trim(dr("DATA_RETIRADA"))
                    End If
                    If Not IsDBNull(dr("DATA_DEVOLUCAO")) Then
                        Date_devolucao.Text = dr("DATA_DEVOLUCAO")
                    End If
                    If Not IsDBNull(dr("PRECO")) Then
                        txt_preco.Text = dr("PRECO")
                    End If
                    If Not IsDBNull(dr("LOCACAO_PAGA_ATO")) Then
                        cbx_locacao_paga_ato.Text = dr("LOCACAO_PAGA_ATO")
                    End If
                    If Not IsDBNull(dr("VALOR_LOCACAO")) Then
                        txt_valor_locacao.Text = dr("VALOR_LOCACAO")
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
        Dim L_cliente As New Locacao_cliente
        Dim L_filme As New Locacao_filme

        If Grid_locacao.Rows.Count = 0 Then
            MsgBox("Filme Inválido!!!")
            txt_filme.Focus()
            Exit Sub
        End If
        If cbx_locacao_paga_ato.Text = "" Then
            MsgBox("Precisa ser preenchido se locação foi paga no ato ou não!!!")
            cbx_locacao_paga_ato.Focus()
            Exit Sub
        End If
        If txt_valor_locacao.Text = "" Then
            MsgBox("Valor total da Locação precisa ser preenchido!!!")
            txt_valor_locacao.Focus()
            Exit Sub
        End If


        'Preenchendo Datas de retirada e devolução da locação
        Dim AMD As String
        AMD = CDate(Date_retirada.Text).Day & "/" & CDate(Date_retirada.Text).Month & "/" & CDate(Date_retirada.Text).Year
        AMD = CDate(Date_devolucao.Text).Day & "/" & CDate(Date_devolucao.Text).Month & "/" & CDate(Date_devolucao.Text).Year



        'Gravando os Dados do cliente
        Try
            L_cliente.p_id_locacao = txt_id_locacao.Text
            L_cliente.p_cod_cliente = Trim(Grid_locacao_cliente.CurrentRow.Cells(1).Value)
            L_cliente.p_tipo_cliente = Trim(Grid_locacao_cliente.CurrentRow.Cells(0).Value)
            L_cliente.p_locacao_paga_ato = Trim(cbx_locacao_paga_ato.Text)
            L_cliente.p_valor_locacao = Trim(txt_valor_locacao.Text)


            If txt_operacao.Text = "I" Then
                dt = L_cliente.Inserirlc(L_cliente)
            ElseIf txt_operacao.Text = "U" Then
                dt = L_cliente.Alterarlc(L_cliente)
            ElseIf txt_operacao.Text = "D" Then
                dt = L_cliente.Excluirlc(L_cliente)
            End If
            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_locacao.Text = dr("ID_LOCACAO")
                Next
            End If

            dr = Nothing
        Catch ex As Exception
        End Try


        'Gravando os Dados de locacao do filme
        Try

            Dim vCont As Integer = 0

            With Grid_locacao

                If .RowCount > 0 Then
                    Do While Not .Rows(vCont).Cells(0).Value Is Nothing
                        L_filme.p_id_locacao = txt_id_locacao.Text
                        L_filme.p_cod_filme = .Rows(vCont).Cells(0).Value
                        L_filme.p_data_retirada = .Rows(vCont).Cells(2).Value
                        L_filme.p_data_devolucao = .Rows(vCont).Cells(3).Value
                        L_filme.p_preco = .Rows(vCont).Cells(4).Value
                        dt = L_filme.Inserirlf(L_filme)
                        vCont += 1
                    Loop
                End If
            End With

            MsgBox("Registro Gravado com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.Information, "Gravar Registro")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
    Private Sub Btn_Inserir_Filme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Inserir_Filme.Click
        If Trim(Date_retirada.Text) = "" Then
            MsgBox("data de retirada Inválido!!!")
            Date_retirada.Focus()
            Exit Sub
        End If
        If Trim(Date_devolucao.Text) = "" Then
            MsgBox("data de devolucao Inválido!!!")
            Date_devolucao.Focus()
            Exit Sub
        End If

        With Grid_locacao
            .Rows.Add(Grid_locacao_filme.CurrentRow.Cells(0).Value, _
                    Trim(UCase(Grid_locacao_filme.CurrentRow.Cells(1).Value)), _
                    Trim(UCase(Date_retirada.Text)), _
                    Trim(UCase(Date_devolucao.Text)), _
                    Trim(Grid_locacao_filme.CurrentRow.Cells(2).Value))
        End With
        Dim mTotalLoc As Double

        mTotalLoc = CType(txt_valor_locacao.Text, Decimal) + CType(Grid_locacao_filme.CurrentRow.Cells(2).Value, Decimal)
        txt_valor_locacao.Text = mTotalLoc.ToString("#,##0.00")
    End Sub

    Private Sub Btn_Excluir_Filme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excluir_Filme.Click
        With Grid_locacao
            .Rows.Remove(.CurrentRow())
        End With
    End Sub
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Dim dt As New DataTable
        Dim L_cliente As New Locacao_cliente
        Dim locacao As New Frm_locacao

        If Trim(txt_nome.Text) <> "" Then
            L_cliente.p_nome = Trim(txt_nome.Text)
        End If

        dt = L_cliente.LstGridlocacao_cliente(L_cliente)
        If dt.Rows.Count > 0 Then
            locacao.Grid_locacao_cliente.Rows.Clear()
            With Grid_locacao_cliente
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub

    Private Sub btn_pesquisar_filme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar_filme.Click
        Dim dt As New DataTable
        Dim l_filme As New Locacao_filme
        Dim locacao As New Frm_locacao


        If Trim(txt_id_filme.Text) <> "" Then
            l_filme.p_cod_filme = Trim(txt_id_filme.Text)
        End If

        dt = l_filme.LstGridlocacao_filme(l_filme)
        If dt.Rows.Count > 0 Then
            locacao.Grid_locacao_filme.Rows.Clear()
            With Grid_locacao_filme
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
End Class