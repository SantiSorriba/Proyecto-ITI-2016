Public Class frmLotes

    Private Sub frmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtNroLote.Text.Equals("") Then
            If MsgBox("El lote no existe. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                panelLotes.Visible = True
                cmdAgregar.Enabled = True
                cmdModificar.Enabled = False
                cmdBuscar.Enabled = False
            End If
        Else
            panelLotes.Visible = True
            cmdAgregar.Enabled = False
            cmdModificar.Enabled = True
            cmdBuscar.Enabled = True
        End If
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        If cmdAgregar.Enabled.Equals(True) And cmdModificar.Enabled.Equals(False) Then
            If MsgBox("¿Desea cancelar la creacion del nuevo lote y salir?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub numCantVacas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCantVacas.ValueChanged
        If numCantVacas.Value > 0 Then
            cmdAgregarAnimales.Enabled = True
        Else
            cmdAgregarAnimales.Enabled = False
        End If
    End Sub

End Class