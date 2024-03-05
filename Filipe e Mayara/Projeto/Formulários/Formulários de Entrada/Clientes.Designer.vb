<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.gpb_titular = New System.Windows.Forms.GroupBox
        Me.btn_sair = New System.Windows.Forms.Button
        Me.btn_excluir = New System.Windows.Forms.Button
        Me.btn_alterar = New System.Windows.Forms.Button
        Me.btn_incluir = New System.Windows.Forms.Button
        Me.Grid_Cliente_Titular = New System.Windows.Forms.DataGridView
        Me.txt_nome_pesq = New System.Windows.Forms.TextBox
        Me.txt_id_titular_pesq = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_nome_adcional_pesq = New System.Windows.Forms.TextBox
        Me.btn_pesquisar2 = New System.Windows.Forms.Button
        Me.txt_id_adicional_pesq = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_sair2 = New System.Windows.Forms.Button
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.btn_excluir2 = New System.Windows.Forms.Button
        Me.btn_alterar2 = New System.Windows.Forms.Button
        Me.btn_incluir2 = New System.Windows.Forms.Button
        Me.Grid_Cliente_Adicional = New System.Windows.Forms.DataGridView
        Me.gpb_titular.SuspendLayout()
        CType(Me.Grid_Cliente_Titular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid_Cliente_Adicional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpb_titular
        '
        Me.gpb_titular.Controls.Add(Me.btn_sair)
        Me.gpb_titular.Controls.Add(Me.btn_excluir)
        Me.gpb_titular.Controls.Add(Me.btn_alterar)
        Me.gpb_titular.Controls.Add(Me.btn_incluir)
        Me.gpb_titular.Controls.Add(Me.Grid_Cliente_Titular)
        Me.gpb_titular.Controls.Add(Me.txt_nome_pesq)
        Me.gpb_titular.Controls.Add(Me.txt_id_titular_pesq)
        Me.gpb_titular.Controls.Add(Me.Label15)
        Me.gpb_titular.Controls.Add(Me.Label1)
        Me.gpb_titular.Controls.Add(Me.btn_pesquisar)
        Me.gpb_titular.Location = New System.Drawing.Point(12, 12)
        Me.gpb_titular.Name = "gpb_titular"
        Me.gpb_titular.Size = New System.Drawing.Size(562, 235)
        Me.gpb_titular.TabIndex = 86
        Me.gpb_titular.TabStop = False
        Me.gpb_titular.Text = "TITULAR"
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(481, 206)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 6
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(400, 206)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 5
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(319, 206)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar.TabIndex = 4
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_incluir
        '
        Me.btn_incluir.Location = New System.Drawing.Point(238, 206)
        Me.btn_incluir.Name = "btn_incluir"
        Me.btn_incluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_incluir.TabIndex = 3
        Me.btn_incluir.Text = "Incluir"
        Me.btn_incluir.UseVisualStyleBackColor = True
        '
        'Grid_Cliente_Titular
        '
        Me.Grid_Cliente_Titular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Cliente_Titular.Location = New System.Drawing.Point(6, 74)
        Me.Grid_Cliente_Titular.Name = "Grid_Cliente_Titular"
        Me.Grid_Cliente_Titular.Size = New System.Drawing.Size(550, 126)
        Me.Grid_Cliente_Titular.TabIndex = 92
        '
        'txt_nome_pesq
        '
        Me.txt_nome_pesq.Location = New System.Drawing.Point(51, 19)
        Me.txt_nome_pesq.Name = "txt_nome_pesq"
        Me.txt_nome_pesq.Size = New System.Drawing.Size(505, 20)
        Me.txt_nome_pesq.TabIndex = 0
        '
        'txt_id_titular_pesq
        '
        Me.txt_id_titular_pesq.Location = New System.Drawing.Point(79, 45)
        Me.txt_id_titular_pesq.Name = "txt_id_titular_pesq"
        Me.txt_id_titular_pesq.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_titular_pesq.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "ID TITULAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "NOME"
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(481, 45)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar.TabIndex = 2
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_nome_adcional_pesq)
        Me.GroupBox1.Controls.Add(Me.btn_pesquisar2)
        Me.GroupBox1.Controls.Add(Me.txt_id_adicional_pesq)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_sair2)
        Me.GroupBox1.Controls.Add(Me.txt_operacao)
        Me.GroupBox1.Controls.Add(Me.btn_excluir2)
        Me.GroupBox1.Controls.Add(Me.btn_alterar2)
        Me.GroupBox1.Controls.Add(Me.btn_incluir2)
        Me.GroupBox1.Controls.Add(Me.Grid_Cliente_Adicional)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 235)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADICIONAL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "NOME"
        '
        'txt_nome_adcional_pesq
        '
        Me.txt_nome_adcional_pesq.Location = New System.Drawing.Point(51, 19)
        Me.txt_nome_adcional_pesq.Name = "txt_nome_adcional_pesq"
        Me.txt_nome_adcional_pesq.Size = New System.Drawing.Size(505, 20)
        Me.txt_nome_adcional_pesq.TabIndex = 7
        '
        'btn_pesquisar2
        '
        Me.btn_pesquisar2.Location = New System.Drawing.Point(481, 45)
        Me.btn_pesquisar2.Name = "btn_pesquisar2"
        Me.btn_pesquisar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar2.TabIndex = 9
        Me.btn_pesquisar2.Text = "Pesquisar"
        Me.btn_pesquisar2.UseVisualStyleBackColor = True
        '
        'txt_id_adicional_pesq
        '
        Me.txt_id_adicional_pesq.Location = New System.Drawing.Point(90, 45)
        Me.txt_id_adicional_pesq.Name = "txt_id_adicional_pesq"
        Me.txt_id_adicional_pesq.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_adicional_pesq.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "ID ADICIONAL"
        '
        'btn_sair2
        '
        Me.btn_sair2.Location = New System.Drawing.Point(481, 206)
        Me.btn_sair2.Name = "btn_sair2"
        Me.btn_sair2.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair2.TabIndex = 13
        Me.btn_sair2.Text = "Sair"
        Me.btn_sair2.UseVisualStyleBackColor = True
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(207, 208)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(25, 20)
        Me.txt_operacao.TabIndex = 98
        Me.txt_operacao.Visible = False
        '
        'btn_excluir2
        '
        Me.btn_excluir2.Location = New System.Drawing.Point(400, 207)
        Me.btn_excluir2.Name = "btn_excluir2"
        Me.btn_excluir2.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir2.TabIndex = 12
        Me.btn_excluir2.Text = "Excluir"
        Me.btn_excluir2.UseVisualStyleBackColor = True
        '
        'btn_alterar2
        '
        Me.btn_alterar2.Location = New System.Drawing.Point(319, 206)
        Me.btn_alterar2.Name = "btn_alterar2"
        Me.btn_alterar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar2.TabIndex = 11
        Me.btn_alterar2.Text = "Alterar"
        Me.btn_alterar2.UseVisualStyleBackColor = True
        '
        'btn_incluir2
        '
        Me.btn_incluir2.Location = New System.Drawing.Point(238, 206)
        Me.btn_incluir2.Name = "btn_incluir2"
        Me.btn_incluir2.Size = New System.Drawing.Size(75, 23)
        Me.btn_incluir2.TabIndex = 10
        Me.btn_incluir2.Text = "Incluir"
        Me.btn_incluir2.UseVisualStyleBackColor = True
        '
        'Grid_Cliente_Adicional
        '
        Me.Grid_Cliente_Adicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Cliente_Adicional.Location = New System.Drawing.Point(6, 74)
        Me.Grid_Cliente_Adicional.Name = "Grid_Cliente_Adicional"
        Me.Grid_Cliente_Adicional.Size = New System.Drawing.Size(550, 126)
        Me.Grid_Cliente_Adicional.TabIndex = 94
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 505)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpb_titular)
        Me.Name = "Clientes"
        Me.Text = "Entrada de Dados de Clientes"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpb_titular.ResumeLayout(False)
        Me.gpb_titular.PerformLayout()
        CType(Me.Grid_Cliente_Titular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid_Cliente_Adicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpb_titular As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nome_pesq As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_titular_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_alterar As System.Windows.Forms.Button
    Friend WithEvents btn_incluir As System.Windows.Forms.Button
    Friend WithEvents Grid_Cliente_Titular As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_nome_adcional_pesq As System.Windows.Forms.TextBox
    Friend WithEvents btn_pesquisar2 As System.Windows.Forms.Button
    Friend WithEvents txt_id_adicional_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_sair2 As System.Windows.Forms.Button
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents btn_excluir2 As System.Windows.Forms.Button
    Friend WithEvents btn_alterar2 As System.Windows.Forms.Button
    Friend WithEvents btn_incluir2 As System.Windows.Forms.Button
    Friend WithEvents Grid_Cliente_Adicional As System.Windows.Forms.DataGridView
End Class
