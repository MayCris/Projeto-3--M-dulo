Public Class Frm_reserva

    Private Sub reservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim r_cliente As New Reserva_cliente
        Dim r_Filme As New Reserva_Filme

        'Locação Cliente
        dt = r_cliente.LstGridreserva_cliente(r_cliente)
        If dt.Rows.Count > 0 Then
            With Grid_reserva_cliente
                Me.Grid_reserva_cliente.Rows.Clear()
                Me.Grid_reserva_cliente.DataSource = dt
                Me.Grid_reserva_cliente.AutoResizeColumns()
            End With
        End If


        'Locação Filme
        dt = r_Filme.LstGridreserva_filme(r_Filme)
        If dt.Rows.Count > 0 Then
            With Grid_reserva_filme
                Me.Grid_reserva_filme.Rows.Clear()
                Me.Grid_reserva_filme.DataSource = dt
                Me.Grid_reserva_filme.AutoResizeColumns()
            End With
        End If


        'reserva
        If Trim(txt_operacao.Text) <> "I" And Trim(txt_id_reserva.Text) <> "" Then
            r_cliente.p_id_reserva = Trim(txt_id_reserva.Text)
            r_Filme.p_id_reserva = Trim(txt_id_reserva.Text)
            dt = r_cliente.RetornarDadosreserva_cliente(r_cliente)
            dt = r_Filme.RetornarDadosreserva_filme(r_Filme)

            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_reserva.Text = Trim(UCase(dr("ID_RESERVA")))
                    txt_id_filme.Text = Trim(UCase(dr("ID_FILME")))
                    If Not IsDBNull(dr("NOME")) Then
                        txt_nome.Text = dr("NOME")
                    End If
                    If Not IsDBNull(dr("DATA_RESERVA")) Then
                        Date_reserva.Text = dr("DATA_RESERVA")
                    End If
                    If Not IsDBNull(dr("PRECO")) Then
                        txt_preco.Text = dr("PRECO")
                    End If
                Next
            End If
            dt = Nothing
        End If
    End Sub
    Private Sub Btn_Inserir_Filme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Inserir_Filme.Click
        If Trim(Date_reserva.Text) = "" Then
            MsgBox("data de reserva Inválido!!!")
            Date_reserva.Focus()
            Exit Sub
        End If


        With Grid_reserva
            .Rows.Add(Grid_reserva_filme.CurrentRow.Cells(0).Value, _
                    Trim(UCase(Grid_reserva_filme.CurrentRow.Cells(1).Value)), _
                    Trim(UCase(Date_reserva.Text)), _
                    Trim(Grid_reserva_filme.CurrentRow.Cells(2).Value))
        End With
        Dim mTotalReser As Double

        mTotalReser = CType(txt_valor_reserva.Text, Decimal) + CType(Grid_reserva_filme.CurrentRow.Cells(2).Value, Decimal)
        txt_valor_reserva.Text = mTotalReser.ToString("#,##0.00")
    End Sub
    Private Sub btn_gravar_Click_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gravar.Click
        Dim sSql As String = ""
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim r_cliente As New Reserva_cliente
        Dim r_filme As New Reserva_Filme

        If Grid_reserva.Rows.Count = 0 Then
            MsgBox("Filme Inválido!!!")
            txt_id_filme.Focus()
            Exit Sub
        End If
        If txt_valor_reserva.Text = "" Then
            MsgBox("Valor total da Locação precisa ser preenchido!!!")
            txt_valor_reserva.Focus()
            Exit Sub
        End If
        If Date_reserva.Text = "" Then
            MsgBox("Data Inválida!!!")
            Date_reserva.Focus()
        End If

        'Preenchendo Datas de retirada e devolução da locação
        Dim AMD As String
        AMD = CDate(Date_reserva.Text).Day & "/" & CDate(Date_reserva.Text).Month & "/" & CDate(Date_reserva.Text).Year

        'Gravando os Dados do cliente
        Try
            r_cliente.p_id_reserva = txt_id_reserva.Text
            r_cliente.p_cod_cliente = Trim(Grid_reserva_cliente.CurrentRow.Cells(1).Value)
            r_cliente.p_tipo_cliente = Trim(Grid_reserva_cliente.CurrentRow.Cells(0).Value)
            r_cliente.p_nome = Trim(Grid_reserva_cliente.CurrentRow.Cells(2).Value)

            If txt_operacao.Text = "I" Then
                dt = r_cliente.Inserirrc(r_cliente)
            ElseIf txt_operacao.Text = "U" Then
                dt = r_cliente.Alterarrc(r_cliente)
            ElseIf txt_operacao.Text = "D" Then
                dt = r_cliente.Excluirrc(r_cliente)
            End If
            If dt.Rows.Count > 0 Then
                For Each dr In dt.Rows
                    txt_id_reserva.Text = dr("ID_RESERVA")
                Next
            End If

            dr = Nothing
        Catch ex As Exception
        End Try

        'Gravando os Dados de reserva do filme
        Try
            Dim vCont As Integer = 0
            With Grid_reserva
                If .RowCount > 0 Then
                    Do While Not .Rows(vCont).Cells(0).Value Is Nothing
                        r_filme.p_id_reserva = txt_id_reserva.Text
                        r_filme.p_cod_filme = .Rows(vCont).Cells(0).Value
                        r_filme.p_filme = .Rows(vCont).Cells(1).Value
                        r_filme.p_data_reserva = .Rows(vCont).Cells(2).Value
                        r_filme.p_preco = .Rows(vCont).Cells(3).Value
                        dt = r_filme.Inserirrf(r_filme)
                        vCont += 1
                    Loop
                End If
            End With

            MsgBox("Registro Gravado com Sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.Information, "Gravar Registro")

        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_pesquisar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar.Click
        Dim dt As New DataTable
        Dim r_cliente As New Reserva_cliente
        Dim reserva As New Frm_reserva

        If Trim(txt_nome.Text) <> "" Then
            r_cliente.p_nome = Trim(txt_nome.Text)
        End If

        dt = r_cliente.LstGridreserva_cliente(r_cliente)
        If dt.Rows.Count > 0 Then
            reserva.Grid_reserva_cliente.Rows.Clear()
            With Grid_reserva_cliente
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Sub btn_pesquisar_filme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pesquisar_filme.Click
        Dim dt As New DataTable
        Dim r_filme As New Reserva_Filme
        Dim reserva As New Frm_reserva


        If Trim(txt_id_filme.Text) <> "" Then
            r_filme.p_cod_filme = Trim(txt_id_filme.Text)
        End If

        dt = r_filme.LstGridreserva_filme(r_filme)
        If dt.Rows.Count > 0 Then
            reserva.Grid_reserva_filme.Rows.Clear()
            With Grid_reserva_filme
                .DataSource = dt
                .AutoResizeColumns()
            End With
        End If
        dt = Nothing
    End Sub
    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
    Private Sub Btn_Excluir_Filme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excluir_Filme.Click
        With Grid_reserva
            .Rows.Remove(.CurrentRow())
        End With
    End Sub
End Class