<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fornecedores
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
        Me.Grid_fornecedores = New System.Windows.Forms.DataGridView
        Me.btn_sair = New System.Windows.Forms.Button
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.txt_id_fornecedor_pesq = New System.Windows.Forms.TextBox
        Me.btn_excluir = New System.Windows.Forms.Button
        Me.btn_incluir = New System.Windows.Forms.Button
        Me.btn_alterar = New System.Windows.Forms.Button
        Me.txt_cnpj_pesq = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_nome_fantasia_pesq = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_razao_social_pesq = New System.Windows.Forms.TextBox
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.Grid_fornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Grid_fornecedores)
        Me.GroupBox3.Controls.Add(Me.btn_sair)
        Me.GroupBox3.Controls.Add(Me.txt_operacao)
        Me.GroupBox3.Controls.Add(Me.txt_id_fornecedor_pesq)
        Me.GroupBox3.Controls.Add(Me.btn_excluir)
        Me.GroupBox3.Controls.Add(Me.btn_incluir)
        Me.GroupBox3.Controls.Add(Me.btn_alterar)
        Me.GroupBox3.Controls.Add(Me.txt_cnpj_pesq)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_nome_fantasia_pesq)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_razao_social_pesq)
        Me.GroupBox3.Controls.Add(Me.btn_pesquisar)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 310)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        '
        'Grid_fornecedores
        '
        Me.Grid_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_fornecedores.Location = New System.Drawing.Point(6, 123)
        Me.Grid_fornecedores.Name = "Grid_fornecedores"
        Me.Grid_fornecedores.Size = New System.Drawing.Size(544, 151)
        Me.Grid_fornecedores.TabIndex = 95
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(475, 280)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 8
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(192, 282)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(34, 20)
        Me.txt_operacao.TabIndex = 93
        Me.txt_operacao.Visible = False
        '
        'txt_id_fornecedor_pesq
        '
        Me.txt_id_fornecedor_pesq.Location = New System.Drawing.Point(108, 97)
        Me.txt_id_fornecedor_pesq.Name = "txt_id_fornecedor_pesq"
        Me.txt_id_fornecedor_pesq.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_fornecedor_pesq.TabIndex = 3
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(394, 279)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 7
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_incluir
        '
        Me.btn_incluir.Location = New System.Drawing.Point(232, 279)
        Me.btn_incluir.Name = "btn_incluir"
        Me.btn_incluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_incluir.TabIndex = 5
        Me.btn_incluir.Text = "Incluir"
        Me.btn_incluir.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(313, 279)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar.TabIndex = 6
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'txt_cnpj_pesq
        '
        Me.txt_cnpj_pesq.Location = New System.Drawing.Point(46, 71)
        Me.txt_cnpj_pesq.Name = "txt_cnpj_pesq"
        Me.txt_cnpj_pesq.Size = New System.Drawing.Size(221, 20)
        Me.txt_cnpj_pesq.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "CNPJ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "NOME FANTASIA"
        '
        'txt_nome_fantasia_pesq
        '
        Me.txt_nome_fantasia_pesq.Location = New System.Drawing.Point(103, 45)
        Me.txt_nome_fantasia_pesq.Name = "txt_nome_fantasia_pesq"
        Me.txt_nome_fantasia_pesq.Size = New System.Drawing.Size(447, 20)
        Me.txt_nome_fantasia_pesq.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "RAZÃO SOCIAL"
        '
        'txt_razao_social_pesq
        '
        Me.txt_razao_social_pesq.Location = New System.Drawing.Point(94, 19)
        Me.txt_razao_social_pesq.Name = "txt_razao_social_pesq"
        Me.txt_razao_social_pesq.Size = New System.Drawing.Size(456, 20)
        Me.txt_razao_social_pesq.TabIndex = 0
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(475, 94)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar.TabIndex = 4
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "ID FORNECEDOR"
        '
        'Fornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 336)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Fornecedores"
        Me.Text = "Entrada de Dados dos Fornecedores"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Grid_fornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cnpj_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nome_fantasia_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_razao_social_pesq As System.Windows.Forms.TextBox
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_alterar As System.Windows.Forms.Button
    Friend WithEvents btn_incluir As System.Windows.Forms.Button
    Friend WithEvents txt_id_fornecedor_pesq As System.Windows.Forms.TextBox
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents Grid_fornecedores As System.Windows.Forms.DataGridView
End Class
