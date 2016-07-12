Public Class frmModificarUsuario

    Private Sub frmModificarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        lblNombreUsu.Visible = False
        lblApellidoUsu.Visible = False
    End Sub
End Class