Public Class frmInventario

    Private Sub frmInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        Busquedas.cargarestablecimientos(cbo_Establecimientos)
    End Sub

    Private Sub cmd_Listar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Listar.Click
        grid_Animales.Visible = True
        Busquedas.guardarnrodicose(cbo_Establecimientos.Text)
        Busquedas.cargoanimales(rs, grid_Animales)
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class