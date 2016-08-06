Public Class frmIngresar

    Private Sub frmIngresar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click
        If txtUsuario.Text.Equals("") Then
            MsgBox("Error, debe ingresar un usuario.")
        ElseIf txtContrasenia.Text.Equals("") Then
            MsgBox("Error, debe ingresar una contraseña.")
        Else
            MsgBox("Bienvenido!")
            Me.Close()
            frmPrincipal.menuIngreso.Enabled = False
            frmPrincipal.menuCerrarSesion.Enabled = True
            frmPrincipal.menuEstablecimientos.Enabled = True
            frmPrincipal.menuAnimales.Enabled = True
            frmPrincipal.menuUsuarios.Enabled = True
        End If
    End Sub
End Class