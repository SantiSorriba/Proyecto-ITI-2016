Public Class frmConsultarProduccion

    Private Sub frmConsultarProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmd_ConsultarProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ConsultarProduccion.Click
        group_Datos.Enabled = True
    End Sub

    Private Sub cmd_VerGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_VerGrafica.Click
        'IDEA
        'Implementar una gráfica con un rango entre 2 fechas, la cual represente la produccion por dia entre esas 2 fechas
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class