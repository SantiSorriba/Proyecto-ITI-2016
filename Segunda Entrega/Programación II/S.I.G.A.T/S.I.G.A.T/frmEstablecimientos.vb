Public Class frmEstablecimientos

    Private Sub frmEstablecimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If cboEstablecimiento.SelectedIndex.Equals(-1) Then
            If MsgBox("No selecciono ningun establecimiento. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                panelEstablecimientos.Visible = True
                cmdModificar.Enabled = False
                cmdBuscar.Enabled = False
            Else
                MsgBox("Seleccione un establecimiento de la lista.")
            End If
        Else
            panelEstablecimientos.Visible = True
            cmdAgregar.Enabled = False
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

End Class