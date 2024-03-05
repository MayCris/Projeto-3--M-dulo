<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_funcionarios
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
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_sair = New System.Windows.Forms.Button
        Me.Grid_funcionarios = New System.Windows.Forms.DataGridView
        Me.txt_nome_pesq = New System.Windows.Forms.TextBox
        Me.btn_excluir = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.btn_alterar = New System.Windows.Forms.Button
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.btn_incluir = New System.Windows.Forms.Button
        Me.txt_id_funcionario_pesq = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.Grid_funcionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(186, 216)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(30, 20)
        Me.txt_operacao.TabIndex = 106
        Me.txt_operacao.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_sair)
        Me.GroupBox3.Controls.Add(Me.txt_operacao)
        Me.GroupBox3.Controls.Add(Me.Grid_funcionarios)
        Me.GroupBox3.Controls.Add(Me.txt_nome_pesq)
        Me.GroupBox3.Controls.Add(Me.btn_excluir)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btn_alterar)
        Me.GroupBox3.Controls.Add(Me.btn_pesquisar)
        Me.GroupBox3.Controls.Add(Me.btn_incluir)
        Me.GroupBox3.Controls.Add(Me.txt_id_funcionario_pesq)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(546, 247)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(465, 216)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 6
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Grid_funcionarios
        '
        Me.Grid_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_funcionarios.Location = New System.Drawing.Point(6, 73)
        Me.Grid_funcionarios.Name = "Grid_funcionarios"
        Me.Grid_funcionarios.Size = New System.Drawing.Size(534, 137)
        Me.Grid_funcionarios.TabIndex = 100
        '
        'txt_nome_pesq
        '
        Me.txt_nome_pesq.Location = New System.Drawing.Point(51, 19)
        Me.txt_nome_pesq.Name = "txt_nome_pesq"
        Me.txt_nome_pesq.Size = New System.Drawing.Size(489, 20)
        Me.txt_nome_pesq.TabIndex = 0
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(384, 216)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 5
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
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
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(303, 216)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar.TabIndex = 4
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(465, 44)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar.TabIndex = 2
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'btn_incluir
        '
        Me.btn_incluir.Location = New System.Drawing.Point(222, 216)
        Me.btn_incluir.Name = "btn_incluir"
        Me.btn_incluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_incluir.TabIndex = 3
        Me.btn_incluir.Text = "Incluir"
        Me.btn_incluir.UseVisualStyleBackColor = True
        '
        'txt_id_funcionario_pesq
        '
        Me.txt_id_funcionario_pesq.Location = New System.Drawing.Point(107, 45)
        Me.txt_id_funcionario_pesq.Name = "txt_id_funcionario_pesq"
        Me.txt_id_funcionario_pesq.Size = New System.Drawing.Size(119, 20)
        Me.txt_id_funcionario_pesq.TabIndex = 1
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
        'f_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 275)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "f_funcionarios"
        Me.Text = "Funcionarios"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Grid_funcionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nome_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents txt_id_funcionario_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_alterar As System.Windows.Forms.Button
    Friend WithEvents btn_incluir As System.Windows.Forms.Button
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents Grid_funcionarios As System.Windows.Forms.DataGridView
End Class
