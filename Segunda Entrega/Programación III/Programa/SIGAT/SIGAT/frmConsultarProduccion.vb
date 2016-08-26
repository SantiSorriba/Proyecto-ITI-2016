Public Class frmConsultarProduccion

    Private Sub frmConsultarProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        'Cargar los establecimientos en el combo box
        Busquedas.cargarestablecimientos(cbo_Establecimientos)
    End Sub

    Private Sub cmd_ConsultarProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ConsultarProduccion.Click
        If cbo_Establecimientos.Text.Equals("") Then 'Si no selecciono un establecimiento
            MsgBox("Seleccione un establecimiento de la lista.")
        Else 'Si lo selecciono
            group_Datos.Enabled = True
            cmd_VerGrafica.Enabled = True
            Busquedas.buscarproduccion(date_FechaOrdenies.Text)
        End If
    End Sub

    Private Sub cmd_VerGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_VerGrafica.Click
        MsgBox("La grafica no esta disponible actualmente.")
        'Idea: Implementar grafica la cual entre un rango de dos fechas muestre la produccion por dia.
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class