Public Class Clientes
    Private Sub Clientes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fCarregaGrid()
    End Sub
    Private Sub btn_incluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incluir.Click
        Dim NewMDIChild As New Frm_cliente_titular
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_id_titular.Text = "0"
        NewMDIChild.txt_id_dados_pessoais.Text = "0"
        NewMDIChild.txt_operacao.Text = "I"
        NewMDIChild.Show()
    End Sub
    Private Sub btn_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alterar.Click
        Dim NewMDIChild As New Frm_cliente_titular
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_operacao.Text = "U"
        With Grid_Cliente_Titular
            NewMDIChild.txt_id_titular.Text = .CurrentRow.Cells(0).Value
        End With
        NewMDIChild.Show()
    End Sub
    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        If MsgBox("Deseja realmente excluir o Cliente selecionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Cliente Titular") = MsgBoxResult.Yes Then
            Dim dt As New DataTable
            Dim C_Titular As New Cliente_Titular
            Dim C_Adicional As New Cliente_Adicional

            With Grid_Cliente_Titular
                C_Titular.p_id_titular = .CurrentRow.Cells(0).Value
            End With
            If C_Titular.p_id_titular = C_Adicional.p_id_titular Then
                MessageBox.Show("Registro do Cliente não pode ser Excluído antes de seus Adicionais!!")
            End If
            dt = C_Titular.ExcluirCT(C_Titular)
            MessageBox.Show("Registro excluido com Sucesso!!")
            With Grid_Cliente_Titular
                .Rows.Remove(.CurrentRow())
                Me.Close()
            End With
        End If
    End Sub
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Dim dt As New DataTable
        Dim pTitular As New Cliente_Titular
        Dim Frm_Clientes As New Clientes

        If Trim(txt_nome_pesq.Text) <> "" Then
            pTitular.p_nome = Trim(txt_nome_pesq.Text)
        End If
        If Trim(txt_id_titular_pesq.Text) <> "" Then
            pTitular.p_id_titular = Trim(txt_id_titular_pesq.Text)
        End If
        dt = pTitular.LstGridCliente_Titular(pTitular)
        If dt.Rows.Count > 0 Then
            Frm_Clientes.Grid_Cliente_Titular.Rows.Clear()
            With Grid_Cliente_Titular
                .DataSource = dt
                .AutoResizeColumns()
            End With
        ElseIf dt.Rows.Count = 0 Then
            With Grid_Cliente_Titular
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Sub btn_incluir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incluir2.Click
        Dim NewMDIChild As New Frm_cliente_adicional
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_Id_Titular.Text = Grid_Cliente_Titular.CurrentRow.Cells(0).Value
        NewMDIChild.txt_id_adicional.Text = "0"
        NewMDIChild.txt_id_dados_pessoais.Text = "0"
        NewMDIChild.txt_operacao.Text = "I"
        NewMDIChild.Show()
    End Sub
    Private Sub btn_alterar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alterar2.Click
        Dim NewMDIChild As New Frm_cliente_adicional
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_operacao.Text = "U"
        With Grid_Cliente_Adicional
            NewMDIChild.txt_id_adicional.Text = .CurrentRow.Cells(0).Value
        End With
        NewMDIChild.Show()
    End Sub
    Private Sub btn_excluir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir2.Click
        If MsgBox("Deseja realmente excluir o Cliente selecionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Cliente Adcional") = MsgBoxResult.Yes Then
            Dim dt As New DataTable
            Dim C_Adicional As New Cliente_Adicional

            With Grid_Cliente_Adicional
                C_Adicional.p_id_adicional = .CurrentRow.Cells(0).Value
            End With
            dt = C_Adicional.ExcluirCA(C_Adicional)
            MessageBox.Show("Registro excluido com Sucesso!!")
            With Grid_Cliente_Adicional
                .Rows.Remove(.CurrentRow())
            End With
        End If
    End Sub
    Private Sub btn_pesquisar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar2.Click
        Dim dt As New DataTable
        Dim pAdicional As New Cliente_Adicional
        Dim Frm_Clientes As New Clientes

        If Trim(txt_id_adicional_pesq.Text) <> "" Then
            pAdicional.p_nome = Trim(txt_nome_pesq.Text)
        End If
        If Trim(txt_id_adicional_pesq.Text) <> "" Then
            pAdicional.p_id_adicional = Trim(txt_id_adicional_pesq.Text)
        End If
        dt = pAdicional.LstGridCliente_adicional(pAdicional)
        If dt.Rows.Count > 0 Then
            Frm_Clientes.Grid_Cliente_Adicional.Rows.Clear()
            With Grid_Cliente_Adicional
                .DataSource = dt
                .AutoResizeColumns()
            End With
        ElseIf dt.Rows.Count = 0 Then
            With Grid_Cliente_Adicional
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
    Private Sub btn_sair2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair2.Click
        Me.Close()
    End Sub
    Private Sub Grid_Cliente_Titular_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Cliente_Titular.CellClick
        Dim mId_Titular As Integer
        Dim clsAdicional As New Cliente_Adicional
        Dim Dt As New DataTable
        Dim frm_Clientes As New Clientes

        ' Inserir posicionamento dos Adicionais.
        mId_Titular = Grid_Cliente_Titular.CurrentRow.Cells(0).Value
        clsAdicional.p_id_titular = mId_Titular

        Dt = clsAdicional.LstGridCliente_adicional(clsAdicional)

        frm_Clientes.Grid_Cliente_Adicional.Rows.Clear()
        If Dt.Rows.Count > 0 Then
            With Grid_Cliente_Adicional
                .DataSource = Dt
                .AutoResizeColumns()
            End With
        ElseIf Dt.Rows.Count = 0 Then
            With Grid_Cliente_Adicional
                .DataSource = Dt
                .AutoResizeColumns()
            End With
        End If
    End Sub
    Private Function fCarregaGrid()
        Dim dt As New DataTable
        Dim C_Titular As New Cliente_Titular
        Dim mid_Cliente As Integer
        Dim Form As New Clientes


        'Cliente Titular
        dt = C_Titular.LstGridCliente_Titular(C_Titular)
        If dt.Rows.Count > 0 Then
            With Grid_Cliente_Titular
                Form.Grid_Cliente_Titular.Rows.Clear()
                Me.Grid_Cliente_Titular.DataSource = dt
                Me.Grid_Cliente_Titular.AutoResizeColumns()
                mid_Cliente = .CurrentRow.Cells(0).Value
            End With
        End If


        'Cliente Adicional
        Dim C_Adicional As New Cliente_Adicional

        C_Adicional.p_id_titular = mid_Cliente
        dt = C_Adicional.LstGridCliente_adicional(C_Adicional)
        If dt.Rows.Count > 0 Then
            With Grid_Cliente_Adicional
                Form.Grid_Cliente_Adicional.Rows.Clear()
                Me.Grid_Cliente_Adicional.DataSource = dt
                Me.Grid_Cliente_Adicional.AutoResizeColumns()
            End With
        End If
        dt = Nothing
        Return True
    End Function
End Class