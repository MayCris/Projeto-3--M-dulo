Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Public Class Login
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim V_Usuario As New Usuario
        Dim vDataSet As New DataTable

        Dim strSql As String = ""

        'monstagem da string para execução da query
        V_Usuario.p_Nome = Trim(UsernameTextBox.Text)
        vDataSet = V_Usuario.ListagemDataTableUsuarios(V_Usuario)



        If vDataSet.Rows.Count > 0 Then
            'Compara a senha digitada com a senha da Base
            If Trim(vDataSet.Rows(0).Item("SENHA").ToString()) = Trim(PasswordTextBox.Text) Then
                ' MDI_Projeto.ClientesToolStripMenuItem.Enabled = False
                MDIProjeto.Enabled = True
            Else
                MsgBox("Senha Inválida!!!!")
                PasswordTextBox.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Usuário Inválido!!!!")
            UsernameTextBox.Focus()
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
End Class
