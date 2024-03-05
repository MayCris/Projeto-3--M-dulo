Public Class filmes_midias

    Private Sub filmes_midias_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        fCarregaGrid()
    End Sub
    Private Sub btn_incluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incluir.Click
        Dim NewMDIChild As New Frm_Midias
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_id_midia.Text = "0"
        NewMDIChild.txt_operacao.Text = "I"
        NewMDIChild.Show()
    End Sub
    Private Sub btn_alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alterar.Click
        Dim NewMDIChild As New Frm_Midias
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_operacao.Text = "U"
        With Grid_midia
            NewMDIChild.txt_id_midia.Text = .CurrentRow.Cells(0).Value
        End With
        NewMDIChild.Show()
    End Sub
    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        If MsgBox("Deseja realmente excluir a Mídia selecionada", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Mídia") = MsgBoxResult.Yes Then
            Dim dt As New DataTable
            Dim F_Filmes As New Filmes
            Dim M_Midias As New Midias

            With Grid_midia
                M_Midias.p_id_midia = .CurrentRow.Cells(0).Value
            End With
            If M_Midias.p_id_midia = F_Filmes.p_id_midia Then
                MessageBox.Show("Registro desta Midia não pode ser Excluído antes do Filme!!")
            End If
            dt = M_Midias.ExcluirMidias(M_Midias)
            MessageBox.Show("Registro excluido com Sucesso!!")
            With Grid_midia
                .Rows.Remove(.CurrentRow())
            End With
        End If
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
    Private Sub btn_incluir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incluir2.Click
        Dim NewMDIChild As New Frm_filmes
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_Id_Midia.Text = Grid_midia.CurrentRow.Cells(0).Value
        NewMDIChild.txt_id_filme.Text = "0"
        NewMDIChild.txt_operacao.Text = "I"
        NewMDIChild.Show()
    End Sub
    Private Sub btn_alterar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alterar2.Click
        Dim NewMDIChild As New Frm_filmes
        NewMDIChild.MdiParent = MDIProjeto
        NewMDIChild.txt_operacao.Text = "U"
        With Grid_filme
            NewMDIChild.txt_id_filme.Text = .CurrentRow.Cells(0).Value
        End With
        NewMDIChild.Show()
    End Sub
    Private Sub btn_excluir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir2.Click
        If MsgBox("Deseja realmente excluir o Filme selecionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir Filme") = MsgBoxResult.Yes Then
            Dim dt As New DataTable
            Dim F_Filmes As New Filmes

            With Grid_filme
                F_Filmes.p_id_filme = .CurrentRow.Cells(0).Value
            End With
            dt = F_Filmes.ExcluirFilmes(F_Filmes)
            MessageBox.Show("Registro excluido com Sucesso!!")
            With Grid_filme
                .Rows.Remove(.CurrentRow())
            End With
        End If
    End Sub
    Private Sub btn_sair2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair2.Click
        Me.Close()
    End Sub
    Private Sub Grid_midia_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_midia.CellClick
        Dim mId_Midia As Integer
        Dim clsFilme As New Filmes
        Dim Dt As New DataTable
        Dim frm_filmes_midias As New filmes_midias

        ' Inserir posicionamento dos filmes.

        mId_Midia = Grid_midia.CurrentRow.Cells(0).Value
        clsFilme.p_id_midia = mId_Midia

        Dt = clsFilme.LstGridFilmes(clsFilme)

        frm_filmes_midias.Grid_filme.Rows.Clear()
        If Dt.Rows.Count > 0 Then
            With Grid_filme
                .DataSource = Dt
                .AutoResizeColumns()
            End With
        ElseIf Dt.Rows.Count = 0 Then
            With Grid_filme
                .DataSource = Dt
                .AutoResizeColumns()
            End With
        End If
    End Sub
    Private Sub btn_pesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Dim dt As New DataTable
        Dim pMidia As New Midias
        Dim Frm_filmes_midias As New filmes_midias

        If Trim(txt_midia_pesq.Text) <> "" Then
            pMidia.p_midia = Trim(txt_midia_pesq.Text)
        End If

        If Trim(txt_id_midia_pesq.Text) <> "" Then
            pMidia.p_id_midia = Trim(txt_id_midia_pesq.Text)
            pMidia.p_midia = Trim(txt_midia_pesq.Text)
        End If

        dt = pMidia.LstGridMidias(pMidia)
        If dt.Rows.Count > 0 Then
            Frm_filmes_midias.Grid_midia.Rows.Clear()
            With Grid_midia
                .DataSource = dt
                .AutoResizeColumns()
            End With
        ElseIf dt.Rows.Count = 0 Then
            With Grid_midia
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Sub btn_pesquisar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar2.Click
        Dim dt As New DataTable
        Dim pFilmes As New Filmes
        Dim Frm_filmes_midias As New filmes_midias

        If Trim(txt_filme_pesq.Text) <> "" Then
            pFilmes.p_filme = Trim(txt_filme_pesq.Text)
        End If

        If Trim(txt_id_filme_pesq.Text) <> "" Then
            pFilmes.p_id_filme = Trim(txt_id_filme_pesq.Text)
        End If

        dt = pFilmes.LstGridFilmes(pFilmes)
        If dt.Rows.Count > 0 Then
            Frm_filmes_midias.Grid_filme.Rows.Clear()
            With Grid_filme
                .DataSource = dt
                .AutoResizeColumns()
            End With
        ElseIf dt.Rows.Count = 0 Then
            With Grid_filme
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Function fCarregaGrid()
        Dim dt As New DataTable
        Dim F_Filmes As New Filmes
        Dim M_Midias As New Midias
        Dim mid_Midia As Integer
        Dim Form As New filmes_midias

        'Grid 
        dt = M_Midias.LstGridMidias(M_Midias)
        If dt.Rows.Count > 0 Then
            With Grid_midia
                Form.Grid_midia.Rows.Clear()
                Me.Grid_midia.DataSource = dt
                Me.Grid_midia.AutoResizeColumns()
                mid_Midia = .CurrentRow.Cells(0).Value
            End With
        End If
        dt = Nothing

        'Grid
        F_Filmes.p_id_midia = mid_Midia
        dt = F_Filmes.LstGridFilmes(F_Filmes)
        If dt.Rows.Count > 0 Then
            With Grid_filme
                Form.Grid_filme.Rows.Clear()
                Me.Grid_filme.DataSource = dt
                Me.Grid_filme.AutoResizeColumns()
            End With
        End If
        dt = Nothing
        Return True

    End Function
End Class