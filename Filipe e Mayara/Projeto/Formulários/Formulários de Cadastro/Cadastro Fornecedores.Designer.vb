<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_fornecedores
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
        Me.gpb_endereco_adcional = New System.Windows.Forms.GroupBox
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.txt_numero = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.btn_sair = New System.Windows.Forms.Button
        Me.btn_gravar = New System.Windows.Forms.Button
        Me.txt_cep = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_estado = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_cidade = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_bairro = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_complemento = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_logradouro = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txt_contato = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_telefone = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.txt_fax = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_cnpj = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_nome_fantasia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_razao_social = New System.Windows.Forms.TextBox
        Me.txt_id_fornecedor = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.gpb_endereco_adcional.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.gpb_endereco_adcional)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 411)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FORNECEDOR"
        '
        'gpb_endereco_adcional
        '
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_operacao)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_numero)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label17)
        Me.gpb_endereco_adcional.Controls.Add(Me.btn_sair)
        Me.gpb_endereco_adcional.Controls.Add(Me.btn_gravar)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_cep)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label2)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_estado)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label6)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_cidade)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label10)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_bairro)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label11)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_complemento)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label12)
        Me.gpb_endereco_adcional.Controls.Add(Me.txt_logradouro)
        Me.gpb_endereco_adcional.Controls.Add(Me.Label13)
        Me.gpb_endereco_adcional.Location = New System.Drawing.Point(6, 254)
        Me.gpb_endereco_adcional.Name = "gpb_endereco_adcional"
        Me.gpb_endereco_adcional.Size = New System.Drawing.Size(549, 152)
        Me.gpb_endereco_adcional.TabIndex = 18
        Me.gpb_endereco_adcional.TabStop = False
        Me.gpb_endereco_adcional.Text = "ENDEREÇO"
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(5, 127)
        Me.txt_operacao.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(36, 20)
        Me.txt_operacao.TabIndex = 90
        Me.txt_operacao.Visible = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(65, 45)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 20)
        Me.txt_numero.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 48)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "NUMERO"
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(468, 123)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 15
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(387, 123)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 14
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(407, 45)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(121, 20)
        Me.txt_cep.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "CEP"
        '
        'txt_estado
        '
        Me.txt_estado.Location = New System.Drawing.Point(63, 97)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(201, 20)
        Me.txt_estado.TabIndex = 13
        Me.txt_estado.Text = "SÃO PAULO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "ESTADO"
        '
        'txt_cidade
        '
        Me.txt_cidade.Location = New System.Drawing.Point(369, 71)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(159, 20)
        Me.txt_cidade.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(316, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "CIDADE"
        '
        'txt_bairro
        '
        Me.txt_bairro.Location = New System.Drawing.Point(60, 71)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(250, 20)
        Me.txt_bairro.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "BAIRRO"
        '
        'txt_complemento
        '
        Me.txt_complemento.Location = New System.Drawing.Point(267, 45)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(100, 20)
        Me.txt_complemento.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(171, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "COMPLEMENTO"
        '
        'txt_logradouro
        '
        Me.txt_logradouro.Location = New System.Drawing.Point(96, 19)
        Me.txt_logradouro.Name = "txt_logradouro"
        Me.txt_logradouro.Size = New System.Drawing.Size(447, 20)
        Me.txt_logradouro.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "LOGRADOURO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_contato)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_telefone)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txt_email)
        Me.GroupBox4.Controls.Add(Me.txt_fax)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 149)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 99)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'txt_contato
        '
        Me.txt_contato.Location = New System.Drawing.Point(71, 19)
        Me.txt_contato.Name = "txt_contato"
        Me.txt_contato.Size = New System.Drawing.Size(472, 20)
        Me.txt_contato.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "TELEFONE"
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(75, 45)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(123, 20)
        Me.txt_telefone.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "CONTATO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "FAX"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(54, 71)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(337, 20)
        Me.txt_email.TabIndex = 6
        '
        'txt_fax
        '
        Me.txt_fax.Location = New System.Drawing.Point(237, 45)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(123, 20)
        Me.txt_fax.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "E-MAIL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_cnpj)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_nome_fantasia)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_razao_social)
        Me.GroupBox2.Controls.Add(Me.txt_id_fornecedor)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 124)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Location = New System.Drawing.Point(46, 71)
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(221, 20)
        Me.txt_cnpj.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "CNPJ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "NOME FANTASIA"
        '
        'txt_nome_fantasia
        '
        Me.txt_nome_fantasia.Location = New System.Drawing.Point(106, 45)
        Me.txt_nome_fantasia.Name = "txt_nome_fantasia"
        Me.txt_nome_fantasia.Size = New System.Drawing.Size(437, 20)
        Me.txt_nome_fantasia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "RAZÃO SOCIAL"
        '
        'txt_razao_social
        '
        Me.txt_razao_social.Location = New System.Drawing.Point(97, 19)
        Me.txt_razao_social.Name = "txt_razao_social"
        Me.txt_razao_social.Size = New System.Drawing.Size(446, 20)
        Me.txt_razao_social.TabIndex = 0
        '
        'txt_id_fornecedor
        '
        Me.txt_id_fornecedor.Location = New System.Drawing.Point(108, 97)
        Me.txt_id_fornecedor.Name = "txt_id_fornecedor"
        Me.txt_id_fornecedor.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_fornecedor.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "ID FORNECEDOR"
        '
        'Frm_fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 437)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Frm_fornecedores"
        Me.Text = "Cadastro de Fornecedores"
        Me.GroupBox3.ResumeLayout(False)
        Me.gpb_endereco_adcional.ResumeLayout(False)
        Me.gpb_endereco_adcional.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gpb_endereco_adcional As System.Windows.Forms.GroupBox
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents txt_cep As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cidade As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_bairro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_complemento As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_logradouro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_contato As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_telefone As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cnpj As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nome_fantasia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_razao_social As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_fornecedor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
