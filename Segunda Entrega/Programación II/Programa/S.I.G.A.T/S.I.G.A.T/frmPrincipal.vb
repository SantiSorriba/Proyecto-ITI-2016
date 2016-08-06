Public Class frmPrincipal

    Private Sub menuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        menuCerrarSesion.Enabled = False
        menuEstablecimientos.Enabled = False
        menuAnimales.Enabled = False
        menuUsuarios.Enabled = False
    End Sub

    Private Sub menuIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIngreso.Click
        frmIngresar.Show()
    End Sub

    Private Sub menuCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCerrarSesion.Click
        If MsgBox("¿Desea cerrar sesion?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.menuCerrarSesion.Enabled = False
            Me.menuIngreso.Enabled = True
            Me.menuEstablecimientos.Enabled = False
            Me.menuAnimales.Enabled = False
            Me.menuUsuarios.Enabled = False
        End If
    End Sub

    Private Sub menuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalir.Click
        If MsgBox("¿Desea salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub menuConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConfig.Click
        frmConfiguracion.show()
    End Sub

    Private Sub menuEstablecimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEstablecimientos.Click
        frmEstablecimientos.Show()
    End Sub
End Class
