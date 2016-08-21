Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inhabilitar ventanas
        menu_CerrarSesion.Enabled = False
        menu_Establecimientos.Enabled = True
        menu_Animales.Enabled = True
        menu_Eventos.Enabled = True
        menu_Usuarios.Enabled = True

        'Fecha actual
        lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub menu_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Ingresar.Click
        frmIngresar.show()
    End Sub

    Private Sub menu_CerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_CerrarSesion.Click
        'Pregunto si desea cerrar sesión
        If MsgBox("¿Desea cerrar sesion?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cn.Close()
            Me.menu_Ingresar.Enabled = True
            Me.menu_CerrarSesion.Enabled = False
            Me.menu_Establecimientos.Enabled = False
            Me.menu_Animales.Enabled = False
            Me.menu_Eventos.Enabled = False
            Me.menu_Usuarios.Enabled = False
        End If
    End Sub

    Private Sub menu_Idioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Idioma.Click
        frmIdioma.show()
    End Sub

    Private Sub menu_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Salir.Click
        If idioma.Equals(False) Then
            If MsgBox("¿Desea salir completamente del sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MsgBox("Hasta luego!")
                Me.Close()
            End If
        Else
            If MsgBox("¿Do you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MsgBox("Goodbye!")
                Me.Close()
            End If
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
