Public Class f_funcionarios

    Private Sub f_funcionarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fCarregaGrid()
    End Sub
    Private Sub btn_incluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incluir.Click
        Dim NewMDIChild As New Frm_funcionarios
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_id_funcionario.Text = "0"
        NewMDIChild.txt_id_dados_pessoais.Text = "0"
        NewMDIChild.txt_operacao.Text = "I"
        NewMDIChild.Show()
    End Sub
    Private Sub btn_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alterar.Click
        Dim NewMDIChild As New Frm_funcionarios
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_operacao.Text = "U"
        With Grid_funcionarios
            NewMDIChild.txt_id_funcionario.Text = .CurrentRow.Cells(0).Value
        End With
        NewMDIChild.Show()
    End Sub
    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        If MsgBox("Deseja realmente excluir o Funcionario selecionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Funcionario") = MsgBoxResult.Yes Then
            Dim dt As New DataTable
            Dim f_funcionarios As New Funcionarios

            With Grid_funcionarios
                f_funcionarios.p_id_funcionario = .CurrentRow.Cells(0).Value
            End With
            dt = f_funcionarios.ExcluirFuncionarios(f_funcionarios)
            MessageBox.Show("Registro excluido com Sucesso!!")
            With Grid_funcionarios
                .Rows.Remove(.CurrentRow())
            End With
        End If
    End Sub
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Dim dt As New DataTable
        Dim pFuncionarios As New Funcionarios
        Dim Frm_Funcionarios As New f_funcionarios

        If Trim(txt_nome_pesq.Text) <> "" Then
            pFuncionarios.p_nome = Trim(txt_nome_pesq.Text)
        End If

        If Trim(txt_id_funcionario_pesq.Text) <> "" Then
            pFuncionarios.p_id_funcionario = Trim(txt_id_funcionario_pesq.Text)
        End If

        dt = pFuncionarios.LstGridFuncionarios(pFuncionarios)
        If dt.Rows.Count > 0 Then
            Frm_Funcionarios.Grid_funcionarios.Rows.Clear()
            With Grid_funcionarios
                .DataSource = dt
                .AutoResizeColumns()
            End With
        ElseIf dt.Rows.Count = 0 Then
            With Grid_funcionarios
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
        Dim f_Funcionarios As New Funcionarios
        Dim Form As New f_funcionarios

        'Grid 
        dt = f_Funcionarios.LstGridFuncionarios(f_Funcionarios)
        If dt.Rows.Count > 0 Then
            Form.Grid_funcionarios.Rows.Clear()
            Me.Grid_funcionarios.DataSource = dt
            Me.Grid_funcionarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        End If
        dt = Nothing
        Return True
    End Function
End Class
