<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filmes_midias
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
        Me.btn_sair = New System.Windows.Forms.Button
        Me.Grid_midia = New System.Windows.Forms.DataGridView
        Me.txt_id_midia_pesq = New System.Windows.Forms.TextBox
        Me.btn_excluir = New System.Windows.Forms.Button
        Me.btn_alterar = New System.Windows.Forms.Button
        Me.btn_incluir = New System.Windows.Forms.Button
        Me.btn_pesquisar = New System.Windows.Forms.Button
        Me.txt_midia_pesq = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Grid_filme = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_sair2 = New System.Windows.Forms.Button
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.txt_id_filme_pesq = New System.Windows.Forms.TextBox
        Me.btn_excluir2 = New System.Windows.Forms.Button
        Me.btn_alterar2 = New System.Windows.Forms.Button
        Me.btn_incluir2 = New System.Windows.Forms.Button
        Me.btn_pesquisar2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_filme_pesq = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid_midia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_filme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_sair)
        Me.GroupBox1.Controls.Add(Me.Grid_midia)
        Me.GroupBox1.Controls.Add(Me.txt_id_midia_pesq)
        Me.GroupBox1.Controls.Add(Me.btn_excluir)
        Me.GroupBox1.Controls.Add(Me.btn_alterar)
        Me.GroupBox1.Controls.Add(Me.btn_incluir)
        Me.GroupBox1.Controls.Add(Me.btn_pesquisar)
        Me.GroupBox1.Controls.Add(Me.txt_midia_pesq)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 242)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(459, 213)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 6
        Me.btn_sair.Text = "Sair" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Grid_midia
        '
        Me.Grid_midia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_midia.Location = New System.Drawing.Point(7, 69)
        Me.Grid_midia.Name = "Grid_midia"
        Me.Grid_midia.Size = New System.Drawing.Size(527, 138)
        Me.Grid_midia.TabIndex = 100
        '
        'txt_id_midia_pesq
        '
        Me.txt_id_midia_pesq.Location = New System.Drawing.Point(61, 42)
        Me.txt_id_midia_pesq.Name = "txt_id_midia_pesq"
        Me.txt_id_midia_pesq.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_midia_pesq.TabIndex = 1
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(378, 213)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 5
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_alterar
        '
        Me.btn_alterar.Location = New System.Drawing.Point(297, 213)
        Me.btn_alterar.Name = "btn_alterar"
        Me.btn_alterar.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar.TabIndex = 4
        Me.btn_alterar.Text = "Alterar"
        Me.btn_alterar.UseVisualStyleBackColor = True
        '
        'btn_incluir
        '
        Me.btn_incluir.Location = New System.Drawing.Point(216, 213)
        Me.btn_incluir.Name = "btn_incluir"
        Me.btn_incluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_incluir.TabIndex = 3
        Me.btn_incluir.Text = "Incluir"
        Me.btn_incluir.UseVisualStyleBackColor = True
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Location = New System.Drawing.Point(459, 40)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar.TabIndex = 2
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'txt_midia_pesq
        '
        Me.txt_midia_pesq.Location = New System.Drawing.Point(47, 14)
        Me.txt_midia_pesq.Name = "txt_midia_pesq"
        Me.txt_midia_pesq.Size = New System.Drawing.Size(487, 20)
        Me.txt_midia_pesq.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "MÍDIA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "ID MÍDIA"
        '
        'Grid_filme
        '
        Me.Grid_filme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_filme.Location = New System.Drawing.Point(6, 74)
        Me.Grid_filme.Name = "Grid_filme"
        Me.Grid_filme.Size = New System.Drawing.Size(528, 138)
        Me.Grid_filme.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_sair2)
        Me.GroupBox2.Controls.Add(Me.txt_operacao)
        Me.GroupBox2.Controls.Add(Me.txt_id_filme_pesq)
        Me.GroupBox2.Controls.Add(Me.btn_excluir2)
        Me.GroupBox2.Controls.Add(Me.btn_alterar2)
        Me.GroupBox2.Controls.Add(Me.Grid_filme)
        Me.GroupBox2.Controls.Add(Me.btn_incluir2)
        Me.GroupBox2.Controls.Add(Me.btn_pesquisar2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_filme_pesq)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 247)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        '
        'btn_sair2
        '
        Me.btn_sair2.Location = New System.Drawing.Point(459, 218)
        Me.btn_sair2.Name = "btn_sair2"
        Me.btn_sair2.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair2.TabIndex = 13
        Me.btn_sair2.Text = "Sair" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.btn_sair2.UseVisualStyleBackColor = True
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(179, 220)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(31, 20)
        Me.txt_operacao.TabIndex = 105
        Me.txt_operacao.Visible = False
        '
        'txt_id_filme_pesq
        '
        Me.txt_id_filme_pesq.Location = New System.Drawing.Point(64, 45)
        Me.txt_id_filme_pesq.Name = "txt_id_filme_pesq"
        Me.txt_id_filme_pesq.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_filme_pesq.TabIndex = 8
        '
        'btn_excluir2
        '
        Me.btn_excluir2.Location = New System.Drawing.Point(378, 218)
        Me.btn_excluir2.Name = "btn_excluir2"
        Me.btn_excluir2.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir2.TabIndex = 12
        Me.btn_excluir2.Text = "Excluir"
        Me.btn_excluir2.UseVisualStyleBackColor = True
        '
        'btn_alterar2
        '
        Me.btn_alterar2.Location = New System.Drawing.Point(297, 218)
        Me.btn_alterar2.Name = "btn_alterar2"
        Me.btn_alterar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_alterar2.TabIndex = 11
        Me.btn_alterar2.Text = "Alterar"
        Me.btn_alterar2.UseVisualStyleBackColor = True
        '
        'btn_incluir2
        '
        Me.btn_incluir2.Location = New System.Drawing.Point(216, 218)
        Me.btn_incluir2.Name = "btn_incluir2"
        Me.btn_incluir2.Size = New System.Drawing.Size(75, 23)
        Me.btn_incluir2.TabIndex = 10
        Me.btn_incluir2.Text = "Incluir"
        Me.btn_incluir2.UseVisualStyleBackColor = True
        '
        'btn_pesquisar2
        '
        Me.btn_pesquisar2.Location = New System.Drawing.Point(459, 45)
        Me.btn_pesquisar2.Name = "btn_pesquisar2"
        Me.btn_pesquisar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_pesquisar2.TabIndex = 9
        Me.btn_pesquisar2.Text = "Pesquisar"
        Me.btn_pesquisar2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "FILME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "ID FILME"
        '
        'txt_filme_pesq
        '
        Me.txt_filme_pesq.Location = New System.Drawing.Point(50, 19)
        Me.txt_filme_pesq.Name = "txt_filme_pesq"
        Me.txt_filme_pesq.Size = New System.Drawing.Size(484, 20)
        Me.txt_filme_pesq.TabIndex = 7
        '
        'filmes_midias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "filmes_midias"
        Me.Text = "Entrada de Dados de Mídias e Filmes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid_midia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_filme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_pesquisar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_midia_pesq As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_alterar As System.Windows.Forms.Button
    Friend WithEvents btn_incluir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_excluir2 As System.Windows.Forms.Button
    Friend WithEvents btn_alterar2 As System.Windows.Forms.Button
    Friend WithEvents btn_incluir2 As System.Windows.Forms.Button
    Friend WithEvents Grid_filme As System.Windows.Forms.DataGridView
    Friend WithEvents btn_pesquisar2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filme_pesq As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_midia_pesq As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_filme_pesq As System.Windows.Forms.TextBox
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
    Friend WithEvents Grid_midia As System.Windows.Forms.DataGridView
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents btn_sair2 As System.Windows.Forms.Button
End Class
