Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inhabilitar acceso a ventanas
        Cosas.inhabilitarfunciones()
        'Fecha actual
        lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub menu_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Ingresar.Click
        frmIngresar.show()
    End Sub

    Private Sub menu_CerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_CerrarSesion.Click
        'Preguntar si esta seguro de cerrar sesión
        If MsgBox("¿Seguro desea cerrar sesion?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Cerrar conexión con la base de datos.
            Conexión.cerrarconexion()
            'Inhabilitar acceso a ventanas
            Cosas.inhabilitarfunciones()
        End If
    End Sub

    

    Private Sub menu_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Salir.Click
        'Pregunto si esta seguro de salir
        If MsgBox("¿Seguro desea salir completamente del sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub menu_AdministrarEstablecimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_AdministrarEstablecimientos.Click
        frmEstablecimientos.show()
    End Sub

    Private Sub menu_ConsultarProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ConsultarProduccion.Click
        frmConsultarProduccion.show()
    End Sub

    Private Sub menu_AdministrarAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_AdministrarAnimales.Click
        frmAdminAnimales.show()
    End Sub

    Private Sub menu_Inventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Inventario.Click
        frmInventario.show()
    End Sub

    Private Sub menu_Lotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Lotes.Click
        frmLotes.show()
    End Sub

    Private Sub menu_Ordenies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Ordenies.Click
        frmOrdenies.show()
    End Sub

    Private Sub menu_Eventos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Eventos.Click
        frmEventos.show()
    End Sub

    Private Sub menu_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Usuarios.Click
        frmUsuarios.show()
    End Sub

End Class
