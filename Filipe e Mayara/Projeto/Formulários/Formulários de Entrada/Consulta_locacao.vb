Public Class Frm_Consulta_locacao

    Private Sub Frm_Consulta_locacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim C_locacao As New Consulta_locacao

        'Locação_clientes
        dt = C_locacao.ListagemDataTable2Consulta_Locacao(C_locacao)
        If dt.Rows.Count > 0 Then
            With Grid_de_Locacoes
                Me.Grid_de_Locacoes.Rows.Clear()
                Me.Grid_de_Locacoes.DataSource = dt
                Me.Grid_de_Locacoes.AutoResizeColumns()
            End With
        End If


        'Locação_filmes
        dt = C_locacao.ListagemDataTableConsulta_Locacao(C_locacao)
        If dt.Rows.Count > 0 Then
            With Grid_locacoes
                Me.Grid_locacoes.Rows.Clear()
                Me.Grid_locacoes.DataSource = dt
                Me.Grid_locacoes.AutoResizeColumns()
            End With
        End If
    End Sub

    Private Sub btn_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sair.Click
        Me.Close()
    End Sub
    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        With Grid_de_Locacoes
            .Rows.Remove(.CurrentRow())
        End With
    End Sub
    Private Sub btn_excluir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir2.Click
        With Grid_locacoes
            .Rows.Remove(.CurrentRow())
        End With
    End Sub
End Class