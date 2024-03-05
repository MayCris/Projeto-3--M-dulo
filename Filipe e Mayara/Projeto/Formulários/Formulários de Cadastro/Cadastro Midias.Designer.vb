<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Midias
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_operacao = New System.Windows.Forms.TextBox
        Me.txt_id_midia = New System.Windows.Forms.TextBox
        Me.txt_sair = New System.Windows.Forms.Button
        Me.btn_gravar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_midia = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_operacao)
        Me.GroupBox2.Controls.Add(Me.txt_id_midia)
        Me.GroupBox2.Controls.Add(Me.txt_sair)
        Me.GroupBox2.Controls.Add(Me.btn_gravar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_midia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 100)
        Me.GroupBox2.TabIndex = 133
        Me.GroupBox2.TabStop = False
        '
        'txt_operacao
        '
        Me.txt_operacao.Location = New System.Drawing.Point(6, 74)
        Me.txt_operacao.Name = "txt_operacao"
        Me.txt_operacao.Size = New System.Drawing.Size(32, 20)
        Me.txt_operacao.TabIndex = 135
        Me.txt_operacao.Visible = False
        '
        'txt_id_midia
        '
        Me.txt_id_midia.Location = New System.Drawing.Point(63, 45)
        Me.txt_id_midia.Name = "txt_id_midia"
        Me.txt_id_midia.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_midia.TabIndex = 125
        '
        'txt_sair
        '
        Me.txt_sair.Location = New System.Drawing.Point(171, 71)
        Me.txt_sair.Name = "txt_sair"
        Me.txt_sair.Size = New System.Drawing.Size(75, 23)
        Me.txt_sair.TabIndex = 2
        Me.txt_sair.Text = "Sair"
        Me.txt_sair.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(90, 71)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(75, 23)
        Me.btn_gravar.TabIndex = 1
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "ID MÍDIA"
        '
        'txt_midia
        '
        Me.txt_midia.Location = New System.Drawing.Point(49, 19)
        Me.txt_midia.Name = "txt_midia"
        Me.txt_midia.Size = New System.Drawing.Size(197, 20)
        Me.txt_midia.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "MÍDIA"
        '
        'Frm_Midias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 127)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Midias"
        Me.Text = "Cadastro de Midias"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id_midia As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_midia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_gravar As System.Windows.Forms.Button
    Friend WithEvents txt_sair As System.Windows.Forms.Button
    Friend WithEvents txt_operacao As System.Windows.Forms.TextBox
End Class
