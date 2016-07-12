Public Class frmBajas

    Private Sub frmBajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

    Private Sub cmdDarBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDarBaja.Click
        If MsgBox("¿Desea dar de baja al animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Animal dado de baja.")
        End If
        Me.Close()
    End Sub

    Private Sub rdoNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNombre.CheckedChanged
        If rdoNombre.Checked Then
            txtBuscar.Enabled = True
        End If
    End Sub

    Private Sub rdoID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoID.CheckedChanged
        If rdoID.Checked Then
            txtBuscar.Enabled = True
        End If
    End Sub
End Class