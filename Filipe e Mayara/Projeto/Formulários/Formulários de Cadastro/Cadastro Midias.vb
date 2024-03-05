Public Class Frm_Midias

    Private Sub Frm_Midias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim M_Midias As New Midias

        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_midia.Text) <> "" Then
            M_Midias.p_id_midia = Trim(txt_id_midia.Text)
            dt = M_Midias.RetornarDadosMidias(M_Midias)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_midia.Text = Trim(UCase(dr("ID_MIDIA")))
                    If Not IsDBNull(dr("MIDIA")) Then
                        txt_midia.Text = dr("MIDIA")
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
        Dim M_Midias As New Midias

        If Trim(txt_midia.Text) = "" Then
            MsgBox("Midia Inválida!! Midia tem que ser preenchida")
            txt_midia.Focus()
            Exit Sub
        End If

        Try
            'Gravando A MIDIA caso não exista
            M_Midias.p_id_midia = Trim(txt_id_midia.Text)
            M_Midias.p_midia = Trim(txt_midia.Text)

            If txt_operacao.Text = "I" Then
                dt = M_Midias.InserirMidias(M_Midias)
            ElseIf txt_operacao.Text = "U" Then
                dt = M_Midias.AlterarMidias(M_Midias)
            ElseIf txt_operacao.Text = "D" Then
                dt = M_Midias.ExcluirMidias(M_Midias)
            End If
            MsgBox("Registro Gravado com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.Information, "Gravar Registro")
            Me.Close()
            dr = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sair.Click
        Me.Close()
    End Sub
End Class