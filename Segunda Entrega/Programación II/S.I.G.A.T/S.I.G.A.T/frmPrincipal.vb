Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        menuCerrarSesion.Enabled = False
    End Sub

    Private Sub menuIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIngresar.Click
        frmIngresar.Show()
    End Sub

    Private Sub menuCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCerrarSesion.Click
        If MsgBox("¿Desea cerrar sesion?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.menuCerrarSesion.Enabled = False
            Me.menuIngresar.Enabled = True
            Me.menuEstablecimientos.Enabled = False
        End If
    End Sub

    Private Sub menuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSalir.Click
        If MsgBox("¿Desea salir completamente del sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Hasta luego!")
            Me.Close()
        End If
    End Sub

    
    Private Sub menuAdministrarEstablecimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAdministrarEstablecimientos.Click
        frmEstablecimientos.Show()
    End Sub

    Private Sub menuConsultarProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsultarProduccion.Click
        frmProduccion.show()
    End Sub

    Private Sub menuIdioma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIdioma.Click
        frmIdioma.show()
    End Sub

    Private Sub menuABMC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuABMC.Click
        frmABMC.Show()
    End Sub

    Private Sub menuInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInventario.Click
        frmInventario.show()
    End Sub

    Private Sub menuLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLotes.Click
        frmLotes.Show()
    End Sub

    Private Sub menuOrdenies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuOrdenies.Click
        frmOrdenies.show()
    End Sub

    Private Sub menuCampoRecria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCampoRecria.Click
        frmCampoRecria.show()
    End Sub

    Private Sub menuCargarEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCargarEvento.Click
        frmCargarEventos.show()
    End Sub

    Private Sub menuConsultarEventos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsultarEventos.Click
        frmConsultarEventos.show()
    End Sub

    Private Sub menuUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuUsuarios.Click
        frmUsuarios.show()
    End Sub
End Class
