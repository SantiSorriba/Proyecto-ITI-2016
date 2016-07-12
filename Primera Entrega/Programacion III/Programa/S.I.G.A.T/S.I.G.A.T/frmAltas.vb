Public Class frmAltas

    Private Sub frmAltas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        If rdoJersey.Checked.Equals(False) And rdoHolando.Checked.Equals(False) And rdoPrimerShow.Checked.Equals(False) Then
            MsgBox("Error, seleccione una raza.")
        Else
            MsgBox("Guardado")
        End If
    End Sub
End Class