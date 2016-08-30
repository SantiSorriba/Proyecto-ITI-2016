Public Class frmProduccion

    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmd_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Consultar.Click
        If cbo_Establecimientos.Text.Equals("") Then 'Si no selecciono un establecimiento
            MsgBox("Seleccione un establecimiento de la lista.")
        ElseIf date_FechaOrdenie.Value > DateTime.Now Then 'Si la fecha es mayor a la actual
            MsgBox("La fecha no puede ser superior a la fecha de hoy.")
        Else 'Si esta todo correcto
            group_Produccion.Enabled = True
            cmd_VerGrafica.Enabled = True
            'Busquedas.buscarproduccion(date_FechaOrdenies.Text)
        End If
    End Sub

    Private Sub cmd_VerGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_VerGrafica.Click
        MsgBox("La grafica no esta disponible.")
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class