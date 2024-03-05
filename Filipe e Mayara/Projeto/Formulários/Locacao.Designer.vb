<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_locacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Grid_locacao_filme = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_id_filme = New System.Windows.Forms.TextBox
        Me.btn_pesquisar_filme = New System.Windows.Forms.Button
        Me.txt_preco = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_id_locacao_filmes = New System.Windows.Forms.TextBox
        Me.txt_filme = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Grid_locacao = New System.Windows.Forms.DataGridView
        Me.Cod_Filme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Filme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Retirada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Devolucao = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cbx_locacao_paga_ato = New System.Windows.Forms.ComboBox
        Me.Btn_Inserir_Filme = New System.Windows.Forms.Button
        Me.Btn_Excluir_Filme = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_valor_locacao = New System.Windows.Forms.TextBox
        Me.Date_devolucao = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Date_retirada = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_tipo_cliente = New System.Windows.Forms.TextBox
        Me.txt_id_adcional = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_id_locacao = New System.Windows.Forms.TextBox
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid_locacao_cliente = New System.Windows.Forms.DataGridView
        Me.btn_gravar = New System.Windows.Forms.Button
        Me.btn_sair = New System.Windows.Forms.Button
        Me.txt_id_titular = New System.Windows.Forms.TextBox
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Grid_locacao_filme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Grid_locacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid_locacao_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txt_id_locacao_filmes)
        Me.GroupBox1.Controls.Add(Me.txt_filme)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txt_tipo_cliente)
        Me.GroupBox1.Controls.Add(Me.txt_id_adcional)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_gravar)
        Me.GroupBox1.Controls.Add(Me.btn_sair)
        Me.GroupBox1.Controls.Add(Me.txt_id_titular)
        Me.GroupBox1.Controls.Add(Me.txt_operacao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 717)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Grid_locacao_filme)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_id_filme)
        Me.GroupBox3.Controls.Add(Me.btn_pesquisar_filme)
        Me.GroupBox3.Controls.Add(Me.txt_preco)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 200)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FILME"
        '
        'Grid_locacao_filme
        '
        Me.Grid_locacao_filme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_locacao_filme.Location = New System.Drawing.Point(2, 72)
        Me.Grid_locacao_filme.Name = "Grid_locacao_filme"
        Me.Grid_locacao_filme.RowTemplate.Height = 24
        Me.Grid_locacao_filme.Size = New System.Drawing.Size(548, 123)
        Me.Grid_locacao_filme.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "ID FILME"
        '
        'txt_id_filme
        '
        Me.txt_id_filme.Location = New System.Drawing.Point(64, 19)
        Me.txt_id_filme.Name = "txt_id_filme"
        Me.txt_id_filme.Size = New System.Drawing.Size(64, 20)
        Me.txt_id_filme.TabIndex = 3
        '
        'btn_pesquisar_filme
        '
        Me.btn_pesquisar_filme.Location = New System.Drawing.Point(475, 43)
        Me.btn_pesquisar_filme.Name = "btn_pesquisar_filme"
        Me.btn_pesquisar_filme.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar_filme.TabIndex = 4
        Me.btn_pesquisar_filme.Text = "Pesquisar"
        Me.btn_pesquisar_filme.UseVisualStyleBackColor = True
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(56, 45)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(96, 20)
        Me.txt_preco.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "PREÇO"
        '
        'txt_id_locacao_filmes
        '
        Me.txt_id_locacao_filmes.Location = New System.Drawing.Point(360, 690)
        Me.txt_id_locacao_filmes.Name = "txt_id_locacao_filmes"
        Me.txt_id_locacao_filmes.Size = New System.Drawing.Size(34, 20)
        Me.txt_id_locacao_filmes.TabIndex = 161
        Me.txt_id_locacao_filmes.Text = "0"
        Me.txt_id_locacao_filmes.Visible = False
        '
        'txt_filme
        '
        Me.txt_filme.Location = New System.Drawing.Point(65, 689)
        Me.txt_filme.Name = "txt_filme"
        Me.txt_filme.Size = New System.Drawing.Size(96, 20)
        Me.txt_filme.TabIndex = 160
        Me.txt_filme.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Grid_locacao)
        Me.GroupBox4.Controls.Add(Me.cbx_locacao_paga_ato)
        Me.GroupBox4.Controls.Add(Me.Btn_Inserir_Filme)
        Me.GroupBox4.Controls.Add(Me.Btn_Excluir_Filme)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_valor_locacao)
        Me.GroupBox4.Controls.Add(Me.Date_devolucao)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Date_retirada)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 429)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 253)
        Me.GroupBox4.TabIndex = 159
        Me.GroupBox4.TabStop = False
        '
        'Grid_locacao
        '
        Me.Grid_locacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_locacao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Filme, Me.Filme, Me.Retirada, Me.Devolucao, Me.Valor})
        Me.Grid_locacao.Location = New System.Drawing.Point(6, 71)
        Me.Grid_locacao.Name = "Grid_locacao"
        Me.Grid_locacao.RowTemplate.Height = 24
        Me.Grid_locacao.Size = New System.Drawing.Size(544, 123)
        Me.Grid_locacao.TabIndex = 149
        '
        'Cod_Filme
        '
        Me.Cod_Filme.HeaderText = "Cod Filme"
        Me.Cod_Filme.Name = "Cod_Filme"
        '
        'Filme
        '
        Me.Filme.HeaderText = "Filme"
        Me.Filme.Name = "Filme"
        '
        'Retirada
        '
        Me.Retirada.HeaderText = "Retirada"
        Me.Retirada.Name = "Retirada"
        '
        'Devolucao
        '
        Me.Devolucao.HeaderText = "Devolução"
        Me.Devolucao.Name = "Devolucao"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'cbx_locacao_paga_ato
        '
        Me.cbx_locacao_paga_ato.FormattingEnabled = True
        Me.cbx_locacao_paga_ato.Items.AddRange(New Object() {"NÃO", "SIM"})
        Me.cbx_locacao_paga_ato.Location = New System.Drawing.Point(92, 226)
        Me.cbx_locacao_paga_ato.Name = "cbx_locacao_paga_ato"
        Me.cbx_locacao_paga_ato.Size = New System.Drawing.Size(72, 21)
        Me.cbx_locacao_paga_ato.TabIndex = 9
        '
        'Btn_Inserir_Filme
        '
        Me.Btn_Inserir_Filme.Location = New System.Drawing.Point(394, 224)
        Me.Btn_Inserir_Filme.Name = "Btn_Inserir_Filme"
        Me.Btn_Inserir_Filme.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Inserir_Filme.TabIndex = 10
        Me.Btn_Inserir_Filme.Text = "Inserir"
        Me.Btn_Inserir_Filme.UseVisualStyleBackColor = True
        '
        'Btn_Excluir_Filme
        '
        Me.Btn_Excluir_Filme.Location = New System.Drawing.Point(475, 224)
        Me.Btn_Excluir_Filme.Name = "Btn_Excluir_Filme"
        Me.Btn_Excluir_Filme.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Excluir_Filme.TabIndex = 13
        Me.Btn_Excluir_Filme.Text = "Excluir"
        Me.Btn_Excluir_Filme.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "VALOR LOCAÇÃO"
        '
        'txt_valor_locacao
        '
        Me.txt_valor_locacao.Location = New System.Drawing.Point(108, 200)
        Me.txt_valor_locacao.Name = "txt_valor_locacao"
        Me.txt_valor_locacao.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor_locacao.TabIndex = 8
        Me.txt_valor_locacao.Text = "0,00"
        Me.txt_valor_locacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Date_devolucao
        '
        Me.Date_devolucao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_devolucao.Location = New System.Drawing.Point(117, 45)
        Me.Date_devolucao.Name = "Date_devolucao"
        Me.Date_devolucao.Size = New System.Drawing.Size(100, 20)
        Me.Date_devolucao.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DATA DEVOLUÇÃO"
        '
        'Date_retirada
        '
        Me.Date_retirada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_retirada.Location = New System.Drawing.Point(106, 19)
        Me.Date_retirada.Name = "Date_retirada"
        Me.Date_retirada.Size = New System.Drawing.Size(100, 20)
        Me.Date_retirada.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "PAGA NO ATO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DATA RETIRADA"
        '
        'txt_tipo_cliente
        '
        Me.txt_tipo_cliente.Location = New System.Drawing.Point(167, 690)
        Me.txt_tipo_cliente.Name = "txt_tipo_cliente"
        Me.txt_tipo_cliente.Size = New System.Drawing.Size(55, 20)
        Me.txt_tipo_cliente.TabIndex = 121
        Me.txt_tipo_cliente.Visible = False
        '
        'txt_id_adcional
        '
        Me.txt_id_adcional.Location = New System.Drawing.Point(308, 690)
        Me.txt_id_adcional.Name = "txt_id_adcional"
        Me.txt_id_adcional.Size = New System.Drawing.Size(34, 20)
        Me.txt_id_adcional.TabIndex = 120
        Me.txt_id_adcional.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_id_locacao)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_pesquisar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Grid_locacao_cliente)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 198)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENTE"
        '
        'txt_id_locacao
        '
        Me.txt_id_locacao.Location = New System.Drawing.Point(82, 18)
        Me.txt_id_locacao.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_locacao.Name = "txt_id_locacao"
        Me.txt_id_locacao.Size = New System.Drawing.Size(71, 20)
        Me.txt_id_locacao.TabIndex = 95
        Me.txt_id_locacao.Text = "0"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(51, 43)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(417, 20)
        Me.txt_nome.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "NOME"
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(475, 41)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar.TabIndex = 1
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "ID LOCAÇÃO"
        '
        'Grid_locacao_cliente
        '
        Me.Grid_locacao_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_locacao_cliente.Location = New System.Drawing.Point(6, 69)
        Me.Grid_locacao_cliente.Name = "Grid_locacao_cliente"
        Me.Grid_locacao_cliente.RowTemplate.Height = 24
        Me.Grid_locacao_cliente.Size = New System.Drawing.Size(544, 123)
        Me.Grid_locacao_cliente.TabIndex = 15
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(400, 688)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 11
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(481, 688)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 14
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'txt_id_titular
        '
        Me.txt_id_titular.Location = New System.Drawing.Point(228, 690)
        Me.txt_id_titular.Name = "txt_id_titular"
        Me.txt_id_titular.Size = New System.Drawing.Size(34, 20)
        Me.txt_id_titular.TabIndex = 89
        Me.txt_id_titular.Visible = False
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(269, 690)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(33, 20)
        Me.txt_operacao.TabIndex = 97
        Me.txt_operacao.Visible = False
        '
        'Frm_locacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 747)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_locacao"
        Me.Text = "Locação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Grid_locacao_filme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Grid_locacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grid_locacao_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid_locacao_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents txt_id_titular As System.Windows.Forms.TextBox
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_adcional As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo_cliente As System.Windows.Forms.TextBox
    Friend WithEvents btn_pesquisar_filme As System.Windows.Forms.Button
    Friend WithEvents txt_id_filme As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Grid_locacao_filme As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid_locacao As System.Windows.Forms.DataGridView
    Friend WithEvents Cod_Filme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Filme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Retirada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Devolucao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbx_locacao_paga_ato As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Inserir_Filme As System.Windows.Forms.Button
    Friend WithEvents Btn_Excluir_Filme As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_valor_locacao As System.Windows.Forms.TextBox
    Friend WithEvents Date_devolucao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Date_retirada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_preco As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_filme As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_locacao_filmes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_locacao As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
