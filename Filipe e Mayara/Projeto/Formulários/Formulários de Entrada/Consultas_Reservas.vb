Public Class Frm_Consultas_reservas

    Private Sub Frm_Consultas_reservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim C_reserva As New Consulta_reserva

        'Reserva_clientes
        dt = C_reserva.ListagemDataTable2Consulta_reserva(C_reserva)
        If dt.Rows.Count > 0 Then
            With Grid_de_reservas
                Me.Grid_de_reservas.Rows.Clear()
                Me.Grid_de_reservas.DataSource = dt
                Me.Grid_de_reservas.AutoResizeColumns()
            End With
        End If


        'reserva_filmes
        dt = C_reserva.ListagemDataTableConsulta_reserva(C_reserva)
        If dt.Rows.Count > 0 Then
            With Grid_reservas
                Me.Grid_reservas.Rows.Clear()
                Me.Grid_reservas.DataSource = dt
                Me.Grid_reservas.AutoResizeColumns()
            End With
        End If
    End Sub

    Private Sub btn_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sair.Click
        Me.Close()
    End Sub
    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        With Grid_de_reservas
            .Rows.Remove(.CurrentRow())
        End With
    End Sub
    Private Sub btn_excluir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir2.Click
        With Grid_reservas
            .Rows.Remove(.CurrentRow())
        End With
    End Sub
End Class