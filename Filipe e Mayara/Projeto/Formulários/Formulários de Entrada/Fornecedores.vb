Public Class Fornecedores

    Private Sub Fornecedores_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fCarregaGrid()
    End Sub
    Private Sub btn_incluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incluir.Click
        Dim NewMDIChild As New Frm_fornecedores
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_id_fornecedor.Text = "0"
        NewMDIChild.txt_operacao.Text = "I"
        NewMDIChild.Show()
    End Sub
    Private Sub btn_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alterar.Click
        Dim NewMDIChild As New Frm_fornecedores
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_operacao.Text = "U"
        With Grid_fornecedores
            NewMDIChild.txt_id_fornecedor.Text = .CurrentRow.Cells(0).Value
        End With
        NewMDIChild.Show()
    End Sub
    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        If MsgBox("Deseja realmente excluir registro do Fornecedor selecionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Fornecedor") = MsgBoxResult.Yes Then
            Dim dt As New DataTable
            Dim Fornecedores_F As New f_Fornecedores

            With Grid_fornecedores
                Fornecedores_F.p_id_fornecedor = .CurrentRow.Cells(0).Value
            End With
            dt = Fornecedores_F.ExcluirFornecedores(Fornecedores_F)
            MessageBox.Show("Registro excluido com Sucesso!!")
            With Grid_fornecedores
                .Rows.Remove(.CurrentRow())
            End With
        End If
    End Sub
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Dim dt As New DataTable
        Dim pFornecedores As New f_Fornecedores
        Dim Frm_Fornecedores As New Fornecedores

        If Trim(txt_razao_social_pesq.Text) <> "" Then
            pFornecedores.p_razao_social = Trim(txt_razao_social_pesq.Text)
        End If

        If Trim(txt_id_fornecedor_pesq.Text) <> "" Then
            pFornecedores.p_id_fornecedor = Trim(txt_id_fornecedor_pesq.Text)
        End If

        If Trim(txt_nome_fantasia_pesq.Text) <> "" Then
            pFornecedores.p_nome_fantasia = Trim(txt_nome_fantasia_pesq.Text)
        End If

        If Trim(txt_cnpj_pesq.Text) <> "" Then
            pFornecedores.p_cnpj = Trim(txt_cnpj_pesq.Text)
        End If

        dt = pFornecedores.LstGridf_Fornecedores(pFornecedores)
        If dt.Rows.Count > 0 Then
            Frm_Fornecedores.Grid_fornecedores.Rows.Clear()
            With Grid_fornecedores
                .DataSource = dt
                .AutoResizeColumns()
            End With
        ElseIf dt.Rows.Count = 0 Then
            With Grid_fornecedores
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
    Private Function fCarregaGrid()
        Dim dt As New DataTable
        Dim Fornecedores_F As New f_Fornecedores
        Dim form As New Fornecedores

        'Grid 
        dt = Fornecedores_F.LstGridf_Fornecedores(Fornecedores_F)
        If dt.Rows.Count > 0 Then
            Form.Grid_fornecedores.Rows.Clear()
            Me.Grid_fornecedores.DataSource = dt
            Me.Grid_fornecedores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        End If
        dt = Nothing
        Return True
    End Function
End Class