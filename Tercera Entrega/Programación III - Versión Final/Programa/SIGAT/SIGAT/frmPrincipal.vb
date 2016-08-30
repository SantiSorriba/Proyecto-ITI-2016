Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub menu_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Ingresar.Click
        frmLogin.Show()
    End Sub

    Private Sub menu_CerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_CerrarSesion.Click

    End Sub

    Private Sub menu_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Salir.Click
        Me.Close()
    End Sub

    Private Sub menu_AdmEstablecimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_AdmEstablecimientos.Click
        frmAdmEstablecimientos.Show()
    End Sub

    Private Sub menu_Parametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Parametros.Click
        frmParametros.Show()
    End Sub

    Private Sub menu_Produccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Produccion.Click
        frmProduccion.Show()
    End Sub

    Private Sub menu_AdmAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_AdmAnimales.Click
        frmAdmAnimales.Show()
    End Sub

    Private Sub menu_Inventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Inventario.Click
        frmInventario.Show()
    End Sub

    Private Sub menu_AdmLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_AdmLotes.Click
        frmAdmLotes.Show()
    End Sub

    Private Sub menu_Ordenies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Ordenies.Click
        frmOrdenies.Show()
    End Sub

    Private Sub menu_RegistrarEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_RegistrarEventos.Click
        frmRegistrarEvento.Show()
    End Sub

    Private Sub menu_HistorialEventos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_HistorialEventos.Click
        frmHistorialEventos.Show()
    End Sub

    Private Sub menu_Usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Usuarios.Click
        frmUsuarios.Show()
    End Sub

End Class
