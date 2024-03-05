<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_funcionarios
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
        Me.gpb_endereco_adcional = New System.Windows.Forms.GroupBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_id_dados_pessoais = New System.Windows.Forms.TextBox
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.btn_sair = New System.Windows.Forms.Button
        Me.btn_gravar = New System.Windows.Forms.Button
        Me.txt_cep = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_estado = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_cidade = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_bairro = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_complemento = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_logradouro = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txt_cargo = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Date_admissao = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_horario_trabalho = New System.Windows.Forms.TextBox
        Me.txt_salario = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_id_funcionario = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_nome = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Date_funcionario = New System.Windows.Forms.DateTimePicker
        Me.cbx_estado_civil = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbx_sexo = New System.Windows.Forms.ComboBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_celular = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_telefone = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_cpf = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_rg = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.gpb_endereco_adcional.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpb_endereco_adcional
        '
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_numero)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label10)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_id_dados_pessoais)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_operacao)
        Me.gpb_endereco_adcional.Controls.Add(Me.btn_sair)
        Me.gpb_endereco_adcional.Controls.Add(Me.btn_gravar)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_cep)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label11)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_estado)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label12)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_cidade)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label13)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_bairro)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label14)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_complemento)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label20)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_logradouro)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label22)
        Me.gpb_endereco_adcional.Location = New System.Drawing.Point(12, 328)
        Me.gpb_endereco_adcional.Name = "gpb_endereco_adcional"
        Me.gpb_endereco_adcional.Size = New System.Drawing.Size(557, 153)
        Me.gpb_endereco_adcional.TabIndex = 26
        Me.gpb_endereco_adcional.TabStop = False
        Me.gpb_endereco_adcional.Text = "ENDEREÇO"
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(65, 45)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "NUMERO"
        '
        'txt_id_dados_pessoais
        '
        Me.txt_id_dados_pessoais.Location = New System.Drawing.Point(53, 127)
        Me.txt_id_dados_pessoais.Name = "txt_id_dados_pessoais"
        Me.txt_id_dados_pessoais.Size = New System.Drawing.Size(40, 20)
        Me.txt_id_dados_pessoais.TabIndex = 86
        Me.txt_id_dados_pessoais.Visible = False
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(6, 127)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(40, 20)
        Me.txt_operacao.TabIndex = 85
        Me.txt_operacao.Visible = False
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(476, 125)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 22
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(395, 125)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 21
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(407, 45)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(121, 20)
        Me.txt_cep.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(373, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "CEP"
        '
        'txt_estado
        '
        Me.txt_estado.Location = New System.Drawing.Point(62, 97)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(201, 20)
        Me.txt_estado.TabIndex = 20
        Me.txt_estado.Text = "SÃO PAULO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "ESTADO"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(369, 71)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(159, 20)
        Me.txt_cidade.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(316, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "CIDADE"
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(60, 71)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(250, 20)
        Me.txt_bairro.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "BAIRRO"
        '
        'txt_complemento
        '
        Me.txt_complemento.Location = New System.Drawing.Point(267, 45)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(100, 20)
        Me.txt_complemento.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(171, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 13)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "COMPLEMENTO"
        '
        'txt_logradouro
        '
        Me.txt_logradouro.Location = New System.Drawing.Point(96, 19)
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.Size = New System.Drawing.Size(453, 20)
        Me.txt_logradouro.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 13)
        Me.Label22.TabIndex = 73
        Me.Label22.Text = "LOGRADOURO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_cargo)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Date_admissao)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txt_horario_trabalho)
        Me.GroupBox4.Controls.Add(Me.txt_salario)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(557, 73)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'txt_cargo
        '
        Me.txt_cargo.Location = New System.Drawing.Point(282, 19)
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(190, 20)
        Me.txt_cargo.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 13)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "DATA DE ADMISSÃO"
        '
        'Date_admissao
        '
        Me.Date_admissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_admissao.Location = New System.Drawing.Point(125, 19)
        Me.Date_admissao.Name = "Date_admissao"
        Me.Date_admissao.Size = New System.Drawing.Size(100, 20)
        Me.Date_admissao.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(253, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "SALÁRIO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "HÓRARIO DE TRABAHO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(231, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "CARGO"
        '
        'txt_horario_trabalho
        '
        Me.txt_horario_trabalho.Location = New System.Drawing.Point(142, 45)
        Me.txt_horario_trabalho.Name = "txt_horario_trabalho"
        Me.txt_horario_trabalho.Size = New System.Drawing.Size(105, 20)
        Me.txt_horario_trabalho.TabIndex = 12
        '
        'txt_salario
        '
        Me.txt_salario.Location = New System.Drawing.Point(312, 45)
        Me.txt_salario.Name = "txt_salario"
        Me.txt_salario.Size = New System.Drawing.Size(130, 20)
        Me.txt_salario.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_id_funcionario)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 74)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FUNCIONÁRIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOME"
        '
        'txt_id_funcionario
        '
        Me.txt_id_funcionario.Location = New System.Drawing.Point(107, 45)
        Me.txt_id_funcionario.Name = "txt_id_funcionario"
        Me.txt_id_funcionario.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_funcionario.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "ID FUNCIONÁRIO"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(51, 19)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(498, 20)
        Me.txt_nome.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Date_funcionario)
        Me.GroupBox1.Controls.Add(Me.cbx_estado_civil)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cbx_sexo)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_celular)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_telefone)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_rg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 151)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Date_funcionario
        '
        Me.Date_funcionario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_funcionario.Location = New System.Drawing.Point(140, 72)
        Me.Date_funcionario.Name = "Date_funcionario"
        Me.Date_funcionario.Size = New System.Drawing.Size(100, 20)
        Me.Date_funcionario.TabIndex = 6
        '
        'cbx_estado_civil
        '
        Me.cbx_estado_civil.FormattingEnabled = True
        Me.cbx_estado_civil.Items.AddRange(New Object() {"CASADO(A)", "DIVORCIADO(A)", "SOLTEIRO(A)", "VIUVO(A)"})
        Me.cbx_estado_civil.Location = New System.Drawing.Point(261, 19)
        Me.cbx_estado_civil.Name = "cbx_estado_civil"
        Me.cbx_estado_civil.Size = New System.Drawing.Size(121, 21)
        Me.cbx_estado_civil.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(175, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 109
        Me.Label21.Text = "ESTADO CIVIL"
        '
        'cbx_sexo
        '
        Me.cbx_sexo.FormattingEnabled = True
        Me.cbx_sexo.Items.AddRange(New Object() {"Feminino", "Masculino"})
        Me.cbx_sexo.Location = New System.Drawing.Point(48, 19)
        Me.cbx_sexo.Name = "cbx_sexo"
        Me.cbx_sexo.Size = New System.Drawing.Size(121, 21)
        Me.cbx_sexo.TabIndex = 2
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(54, 124)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(497, 20)
        Me.txt_email.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "E-MAIL"
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(333, 98)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(180, 20)
        Me.txt_celular.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "CELULAR"
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(75, 98)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(190, 20)
        Me.txt_telefone.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "TELEFONE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "DATA DE NASCIMENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "SEXO"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(260, 46)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(180, 20)
        Me.txt_cpf.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "CPF"
        '
        'txt_rg
        '
        Me.txt_rg.Location = New System.Drawing.Point(35, 46)
        Me.txt_rg.Name = "txt_rg"
        Me.txt_rg.Size = New System.Drawing.Size(186, 20)
        Me.txt_rg.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "RG"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(41, -22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, -16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "CEP"
        '
        'Frm_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 496)
        Me.Controls.Add(Me.gpb_endereco_adcional)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_funcionarios"
        Me.Text = "Cadastro de Funcionários"
        Me.gpb_endereco_adcional.ResumeLayout(False)
        Me.gpb_endereco_adcional.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpb_endereco_adcional As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_id_dados_pessoais As System.Windows.Forms.TextBox
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents txt_cep As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_complemento As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_logradouro As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cargo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Date_admissao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_horario_trabalho As System.Windows.Forms.TextBox
    Friend WithEvents txt_salario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_id_funcionario As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Date_funcionario As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbx_estado_civil As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbx_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_telefone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cpf As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_rg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
