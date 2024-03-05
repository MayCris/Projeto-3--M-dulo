<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_locacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Sair = New System.Windows.Forms.Button
        Me.Grid_locacoes = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_excluir = New System.Windows.Forms.Button
        Me.btn_excluir2 = New System.Windows.Forms.Button
        Me.Grid_de_Locacoes = New System.Windows.Forms.DataGridView
        CType(Me.Grid_locacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid_de_Locacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Sair
        '
        Me.btn_Sair.Location = New System.Drawing.Point(459, 389)
        Me.btn_Sair.Name = "btn_Sair"
        Me.btn_Sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sair.TabIndex = 2
        Me.btn_Sair.Text = "Sair"
        Me.btn_Sair.UseVisualStyleBackColor = True
        '
        'Grid_locacoes
        '
        Me.Grid_locacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_locacoes.Location = New System.Drawing.Point(6, 204)
        Me.Grid_locacoes.Name = "Grid_locacoes"
        Me.Grid_locacoes.Size = New System.Drawing.Size(528, 150)
        Me.Grid_locacoes.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_excluir)
        Me.GroupBox2.Controls.Add(Me.btn_excluir2)
        Me.GroupBox2.Controls.Add(Me.Grid_de_Locacoes)
        Me.GroupBox2.Controls.Add(Me.Grid_locacoes)
        Me.GroupBox2.Controls.Add(Me.btn_Sair)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 418)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(459, 175)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 0
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_excluir2
        '
        Me.btn_excluir2.Location = New System.Drawing.Point(459, 360)
        Me.btn_excluir2.Name = "btn_excluir2"
        Me.btn_excluir2.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir2.TabIndex = 1
        Me.btn_excluir2.Text = "Excluir"
        Me.btn_excluir2.UseVisualStyleBackColor = True
        '
        'Grid_de_Locacoes
        '
        Me.Grid_de_Locacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_de_Locacoes.Location = New System.Drawing.Point(6, 19)
        Me.Grid_de_Locacoes.Name = "Grid_de_Locacoes"
        Me.Grid_de_Locacoes.Size = New System.Drawing.Size(528, 150)
        Me.Grid_de_Locacoes.TabIndex = 3
        '
        'Frm_Consulta_locacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 445)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Consulta_locacao"
        Me.Text = "Consulta Locação"
        CType(Me.Grid_locacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Grid_de_Locacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid_locacoes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Sair As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid_de_Locacoes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_excluir2 As System.Windows.Forms.Button
End Class
