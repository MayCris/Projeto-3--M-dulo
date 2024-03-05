<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consultas_reservas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_excluir = New System.Windows.Forms.Button
        Me.btn_excluir2 = New System.Windows.Forms.Button
        Me.btn_Sair = New System.Windows.Forms.Button
        Me.Grid_de_reservas = New System.Windows.Forms.DataGridView
        Me.Grid_reservas = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid_de_reservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_reservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_excluir)
        Me.GroupBox1.Controls.Add(Me.btn_excluir2)
        Me.GroupBox1.Controls.Add(Me.btn_Sair)
        Me.GroupBox1.Controls.Add(Me.Grid_de_reservas)
        Me.GroupBox1.Controls.Add(Me.Grid_reservas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 423)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(467, 175)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 0
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_excluir2
        '
        Me.btn_excluir2.Location = New System.Drawing.Point(467, 360)
        Me.btn_excluir2.Name = "btn_excluir2"
        Me.btn_excluir2.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir2.TabIndex = 1
        Me.btn_excluir2.Text = "Excluir"
        Me.btn_excluir2.UseVisualStyleBackColor = True
        '
        'btn_Sair
        '
        Me.btn_Sair.Location = New System.Drawing.Point(467, 389)
        Me.btn_Sair.Name = "btn_Sair"
        Me.btn_Sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sair.TabIndex = 2
        Me.btn_Sair.Text = "Sair"
        Me.btn_Sair.UseVisualStyleBackColor = True
        '
        'Grid_de_reservas
        '
        Me.Grid_de_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_de_reservas.Location = New System.Drawing.Point(6, 19)
        Me.Grid_de_reservas.Name = "Grid_de_reservas"
        Me.Grid_de_reservas.Size = New System.Drawing.Size(536, 150)
        Me.Grid_de_reservas.TabIndex = 1
        '
        'Grid_reservas
        '
        Me.Grid_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_reservas.Location = New System.Drawing.Point(6, 204)
        Me.Grid_reservas.Name = "Grid_reservas"
        Me.Grid_reservas.Size = New System.Drawing.Size(536, 150)
        Me.Grid_reservas.TabIndex = 0
        '
        'Frm_Consultas_reservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Consultas_reservas"
        Me.Text = "Consulta Reservas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grid_de_reservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_reservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Sair As System.Windows.Forms.Button
    Friend WithEvents Grid_de_reservas As System.Windows.Forms.DataGridView
    Friend WithEvents Grid_reservas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_excluir2 As System.Windows.Forms.Button
End Class
