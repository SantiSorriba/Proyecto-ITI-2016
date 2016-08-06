Public Class frmEstablecimientos

    Private Sub frmEstablecimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        panelEstablecimiento.Visible = False
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If cboEstablecimientos.Text.Equals("") Then
            MsgBox("Debe ingresar un establecimiento o seleccionar uno de la lista.")
        Else
            panelEstablecimiento.Visible = True
        End If
    End Sub

    Private Sub cmdParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdParametros.Click
        frmParametros.Show()
    End Sub
End Class