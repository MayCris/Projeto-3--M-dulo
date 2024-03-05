<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_reserva
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
        Me.Grid_reserva_filme = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_id_filme = New System.Windows.Forms.TextBox
        Me.txt_preco = New System.Windows.Forms.TextBox
        Me.btn_pesquisar_filme = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_id_reserva_filmes = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Grid_reserva = New System.Windows.Forms.DataGridView
        Me.Cod_Filme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Filme = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reserva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Preco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btn_Inserir_Filme = New System.Windows.Forms.Button
        Me.Btn_Excluir_Filme = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_valor_reserva = New System.Windows.Forms.TextBox
        Me.Date_reserva = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_id_reserva = New System.Windows.Forms.TextBox
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grid_reserva_cliente = New System.Windows.Forms.DataGridView
        Me.btn_gravar = New System.Windows.Forms.Button
        Me.btn_sair = New System.Windows.Forms.Button
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Grid_reserva_filme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Grid_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid_reserva_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txt_id_reserva_filmes)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btn_gravar)
        Me.GroupBox1.Controls.Add(Me.btn_sair)
        Me.GroupBox1.Controls.Add(Me.txt_operacao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 691)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Grid_reserva_filme)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_id_filme)
        Me.GroupBox3.Controls.Add(Me.txt_preco)
        Me.GroupBox3.Controls.Add(Me.btn_pesquisar_filme)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 199)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Grid_reserva_filme
        '
        Me.Grid_reserva_filme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_reserva_filme.Location = New System.Drawing.Point(6, 71)
        Me.Grid_reserva_filme.Name = "Grid_reserva_filme"
        Me.Grid_reserva_filme.RowTemplate.Height = 24
        Me.Grid_reserva_filme.Size = New System.Drawing.Size(444, 123)
        Me.Grid_reserva_filme.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "ID FILME"
        '
        'txt_id_filme
        '
        Me.txt_id_filme.Location = New System.Drawing.Point(61, 19)
        Me.txt_id_filme.Name = "txt_id_filme"
        Me.txt_id_filme.Size = New System.Drawing.Size(71, 20)
        Me.txt_id_filme.TabIndex = 2
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(56, 45)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(96, 20)
        Me.txt_preco.TabIndex = 4
        '
        'btn_pesquisar_filme
        '
        Me.btn_pesquisar_filme.Location = New System.Drawing.Point(375, 42)
        Me.btn_pesquisar_filme.Name = "btn_pesquisar_filme"
        Me.btn_pesquisar_filme.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar_filme.TabIndex = 3
        Me.btn_pesquisar_filme.Text = "Pesquisar"
        Me.btn_pesquisar_filme.UseVisualStyleBackColor = True
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
        'txt_id_reserva_filmes
        '
        Me.txt_id_reserva_filmes.Location = New System.Drawing.Point(262, 663)
        Me.txt_id_reserva_filmes.Name = "txt_id_reserva_filmes"
        Me.txt_id_reserva_filmes.Size = New System.Drawing.Size(34, 20)
        Me.txt_id_reserva_filmes.TabIndex = 161
        Me.txt_id_reserva_filmes.Text = "0"
        Me.txt_id_reserva_filmes.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Grid_reserva)
        Me.GroupBox4.Controls.Add(Me.Btn_Inserir_Filme)
        Me.GroupBox4.Controls.Add(Me.Btn_Excluir_Filme)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_valor_reserva)
        Me.GroupBox4.Controls.Add(Me.Date_reserva)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 429)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 228)
        Me.GroupBox4.TabIndex = 159
        Me.GroupBox4.TabStop = False
        '
        'Grid_reserva
        '
        Me.Grid_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_reserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Filme, Me.Filme, Me.Reserva, Me.Preco})
        Me.Grid_reserva.Location = New System.Drawing.Point(6, 70)
        Me.Grid_reserva.Name = "Grid_reserva"
        Me.Grid_reserva.RowTemplate.Height = 24
        Me.Grid_reserva.Size = New System.Drawing.Size(444, 123)
        Me.Grid_reserva.TabIndex = 149
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
        'Reserva
        '
        Me.Reserva.HeaderText = "Reserva"
        Me.Reserva.Name = "Reserva"
        '
        'Preco
        '
        Me.Preco.HeaderText = "Preco"
        Me.Preco.Name = "Preco"
        '
        'Btn_Inserir_Filme
        '
        Me.Btn_Inserir_Filme.Location = New System.Drawing.Point(294, 199)
        Me.Btn_Inserir_Filme.Name = "Btn_Inserir_Filme"
        Me.Btn_Inserir_Filme.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Inserir_Filme.TabIndex = 3
        Me.Btn_Inserir_Filme.Text = "Inserir"
        Me.Btn_Inserir_Filme.UseVisualStyleBackColor = True
        '
        'Btn_Excluir_Filme
        '
        Me.Btn_Excluir_Filme.Location = New System.Drawing.Point(375, 199)
        Me.Btn_Excluir_Filme.Name = "Btn_Excluir_Filme"
        Me.Btn_Excluir_Filme.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Excluir_Filme.TabIndex = 9
        Me.Btn_Excluir_Filme.Text = "Excluir"
        Me.Btn_Excluir_Filme.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "VALOR RESERVA"
        '
        'txt_valor_reserva
        '
        Me.txt_valor_reserva.Location = New System.Drawing.Point(109, 45)
        Me.txt_valor_reserva.Name = "txt_valor_reserva"
        Me.txt_valor_reserva.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor_reserva.TabIndex = 6
        Me.txt_valor_reserva.Text = "0,00"
        Me.txt_valor_reserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Date_reserva
        '
        Me.Date_reserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_reserva.Location = New System.Drawing.Point(102, 19)
        Me.Date_reserva.Name = "Date_reserva"
        Me.Date_reserva.Size = New System.Drawing.Size(100, 20)
        Me.Date_reserva.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DATA RESERVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_id_reserva)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_pesquisar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Grid_reserva_cliente)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 199)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENTE"
        '
        'txt_id_reserva
        '
        Me.txt_id_reserva.Location = New System.Drawing.Point(83, 18)
        Me.txt_id_reserva.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id_reserva.Name = "txt_id_reserva"
        Me.txt_id_reserva.Size = New System.Drawing.Size(71, 20)
        Me.txt_id_reserva.TabIndex = 95
        Me.txt_id_reserva.Text = "0"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(51, 43)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(299, 20)
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
        Me.btn_pesquisar.Location = New System.Drawing.Point(375, 41)
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
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "ID RESERVA"
        '
        'Grid_reserva_cliente
        '
        Me.Grid_reserva_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_reserva_cliente.Location = New System.Drawing.Point(6, 70)
        Me.Grid_reserva_cliente.Name = "Grid_reserva_cliente"
        Me.Grid_reserva_cliente.RowTemplate.Height = 24
        Me.Grid_reserva_cliente.Size = New System.Drawing.Size(444, 123)
        Me.Grid_reserva_cliente.TabIndex = 15
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(302, 663)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 8
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(383, 663)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 10
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(223, 663)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(33, 20)
        Me.txt_operacao.TabIndex = 97
        Me.txt_operacao.Visible = False
        '
        'Frm_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 718)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_reserva"
        Me.Text = "RESERVAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Grid_reserva_filme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Grid_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grid_reserva_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_reserva_filmes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid_reserva As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Inserir_Filme As System.Windows.Forms.Button
    Friend WithEvents Btn_Excluir_Filme As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_valor_reserva As System.Windows.Forms.TextBox
    Friend WithEvents Date_reserva As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grid_reserva_filme As System.Windows.Forms.DataGridView
    Friend WithEvents txt_preco As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_pesquisar_filme As System.Windows.Forms.Button
    Friend WithEvents txt_id_filme As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid_reserva_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Filme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Filme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_id_reserva As System.Windows.Forms.TextBox
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
