<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_filmes
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_Id_Midia = New System.Windows.Forms.TextBox
        Me.btn_sair = New System.Windows.Forms.Button
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.txt_preco = New System.Windows.Forms.TextBox
        Me.btn_gravar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_sinopse = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_direcao = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_duracao = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_nacionalidade = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbx_genero = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_ano_lancamento = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_id_filme = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_filme = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_Id_Midia)
        Me.GroupBox3.Controls.Add(Me.btn_sair)
        Me.GroupBox3.Controls.Add(Me.txt_operacao)
        Me.GroupBox3.Controls.Add(Me.txt_preco)
        Me.GroupBox3.Controls.Add(Me.btn_gravar)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_sinopse)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_direcao)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_duracao)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_nacionalidade)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbx_genero)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_ano_lancamento)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_id_filme)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_filme)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(493, 367)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'txt_Id_Midia
        '
        Me.txt_Id_Midia.Location = New System.Drawing.Point(291, 338)
        Me.txt_Id_Midia.Name = "txt_Id_Midia"
        Me.txt_Id_Midia.Size = New System.Drawing.Size(34, 20)
        Me.txt_Id_Midia.TabIndex = 147
        Me.txt_Id_Midia.Visible = False
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(412, 338)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 9
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(256, 338)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(29, 20)
        Me.txt_operacao.TabIndex = 130
        Me.txt_operacao.Visible = False
        '
        'txt_preco
        '
        Me.txt_preco.Location = New System.Drawing.Point(56, 338)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(100, 20)
        Me.txt_preco.TabIndex = 7
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(331, 338)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 8
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "PREÇO"
        '
        'txt_sinopse
        '
        Me.txt_sinopse.Location = New System.Drawing.Point(66, 202)
        Me.txt_sinopse.Multiline = True
        Me.txt_sinopse.Name = "txt_sinopse"
        Me.txt_sinopse.Size = New System.Drawing.Size(421, 130)
        Me.txt_sinopse.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "SINOPSE"
        '
        'txt_direcao
        '
        Me.txt_direcao.Location = New System.Drawing.Point(67, 176)
        Me.txt_direcao.Name = "txt_direcao"
        Me.txt_direcao.Size = New System.Drawing.Size(420, 20)
        Me.txt_direcao.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "DIREÇÃO"
        '
        'txt_duracao
        '
        Me.txt_duracao.Location = New System.Drawing.Point(72, 150)
        Me.txt_duracao.Name = "txt_duracao"
        Me.txt_duracao.Size = New System.Drawing.Size(114, 20)
        Me.txt_duracao.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "DURAÇÃO"
        '
        'txt_nacionalidade
        '
        Me.txt_nacionalidade.Location = New System.Drawing.Point(106, 97)
        Me.txt_nacionalidade.Name = "txt_nacionalidade"
        Me.txt_nacionalidade.Size = New System.Drawing.Size(132, 20)
        Me.txt_nacionalidade.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "NACIONALIDADE"
        '
        'cbx_genero
        '
        Me.cbx_genero.FormattingEnabled = True
        Me.cbx_genero.Items.AddRange(New Object() {"AÇÃO", "ANIMAÇÃO", "AVENTURA", "CINEMA ESTRANGEIRO", "CINEMA NACIONAL", "CLÁSSICOS", "COMÉDIA", "DOCUMENTÁRIO", "DRAMA", "ESPORTE", "FAROESTE", "FICÇÃO", "FILMES DE ÉPOCA", "INFANTIL", "MUSICAL", "POLICIAL", "RELIGIÃO", "ROMANCE", "SERIADOS", "SHOWS", "SUSPENSE", "TERROR"})
        Me.cbx_genero.Location = New System.Drawing.Point(65, 123)
        Me.cbx_genero.Name = "cbx_genero"
        Me.cbx_genero.Size = New System.Drawing.Size(121, 21)
        Me.cbx_genero.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "GÊNERO"
        '
        'txt_ano_lancamento
        '
        Me.txt_ano_lancamento.Location = New System.Drawing.Point(119, 71)
        Me.txt_ano_lancamento.Name = "txt_ano_lancamento"
        Me.txt_ano_lancamento.Size = New System.Drawing.Size(74, 20)
        Me.txt_ano_lancamento.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "ANO LANÇAMENTO"
        '
        'txt_id_filme
        '
        Me.txt_id_filme.Location = New System.Drawing.Point(64, 45)
        Me.txt_id_filme.Name = "txt_id_filme"
        Me.txt_id_filme.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_filme.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "ID FILME"
        '
        'txt_filme
        '
        Me.txt_filme.Location = New System.Drawing.Point(50, 19)
        Me.txt_filme.Name = "txt_filme"
        Me.txt_filme.Size = New System.Drawing.Size(437, 20)
        Me.txt_filme.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "FILME"
        '
        'Frm_filmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 394)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Frm_filmes"
        Me.Text = "Cadastro de Filmes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents txt_preco As System.Windows.Forms.TextBox
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_sinopse As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_direcao As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_duracao As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nacionalidade As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbx_genero As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ano_lancamento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_id_filme As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filme As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Id_Midia As System.Windows.Forms.TextBox
End Class
