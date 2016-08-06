Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        menuCerrarSesion.Enabled = False
        menuEstablecimientos.Enabled = False
        menuEntidades.Enabled = False
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
            Me.menuEntidades.Enabled = False
            Me.menuAnimales.Enabled = False
        End If
    End Sub

    Private Sub menuConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConfiguracion.Click
        frmConfiguracion.Show()
    End Sub

    Private Sub menuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalir.Click
        Me.Close()
    End Sub

    Private Sub menuNuevoEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuNuevoEstablecimiento.Click
        frmNuevoEstablecimiento.Show()
    End Sub

    Private Sub menuConsultarEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsultarEstablecimiento.Click
        frmConsultarEstablecimiento.Show()
    End Sub

    Private Sub menuModificarEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuModificarEstablecimiento.Click
        frmModificarEstablecimiento.Show()
    End Sub

    Private Sub menuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuClientes.Click
        frmClientes.Show()
    End Sub

    Private Sub menuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuProveedores.Click
        frmProveedores.Show()
    End Sub

    Private Sub menuServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuServicios.Click
        frmServicios.Show()
    End Sub

    Private Sub menuInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInventario.Click
        frmInventario.Show()
    End Sub

    Private Sub menuLoteos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLoteos.Click
        frmLoteos.Show()
    End Sub

    Private Sub menuConsultarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsultarAnimal.Click
        frmConsultarAnimal.Show()
    End Sub

    Private Sub menuAgregarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAgregarUsuario.Click
        frmAgregarUsuario.Show()
    End Sub

    Private Sub menuModificarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuModificarUsuario.Click
        frmModificarUsuario.Show()
    End Sub

    Private Sub menuBajaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBajaUsuario.Click
        frmBajaUsuario.Show()
    End Sub

    Private Sub menuAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAltas.Click
        frmAltas.Show()
    End Sub

    Private Sub menuBajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBajas.Click
        frmBajas.Show()
    End Sub

    Private Sub OrdeñesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdeñesToolStripMenuItem.Click
        frmOrdenies.Show()
    End Sub

    Private Sub lblFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFecha.Click

    End Sub
End Class
