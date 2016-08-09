Public Class frmProduccion

    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerProduccion.Click
        If cboEstablecimientos.SelectedIndex.Equals(-1) Then
            MsgBox("No selecciono ningun establecimiento")
        Else
            groupDatos.Visible = True
        End If
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

End Class