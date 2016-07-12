Public Class frmModificarEstablecimiento

    Private Sub frmModificarEstablecimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdModParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModParametros.Click
        frmParametros.Show()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        MsgBox("Datos guardados")
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub chkJersey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJersey.CheckedChanged
        If chkJersey.Checked Then
            txtJersey.Enabled = True
        Else
            txtJersey.Enabled = False
            txtJersey.Clear()
        End If
    End Sub

    Private Sub chkHolando_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHolando.CheckedChanged
        If chkHolando.Checked Then
            txtHolando.Enabled = True
        Else
            txtHolando.Clear()
            txtHolando.Enabled = False
        End If
    End Sub

    Private Sub chkPrimerShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrimerShow.CheckedChanged
        If chkPrimerShow.Checked Then
            txtPrimerShow.Enabled = True
        Else
            txtPrimerShow.Clear()
            txtPrimerShow.Enabled = False
        End If
    End Sub

    Private Sub numOrdenies_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numOrdenies.ValueChanged
        If numOrdenies.Value.Equals(1) Then
            groupPrimerOrdenie.Enabled = True
            groupSegundoOrdenie.Enabled = False
            groupTercerOrdenie.Enabled = False
        ElseIf numOrdenies.Value.Equals(2) Then
            groupPrimerOrdenie.Enabled = True
            groupSegundoOrdenie.Enabled = True
            groupTercerOrdenie.Enabled = False
        Else
            groupPrimerOrdenie.Enabled = True
            groupSegundoOrdenie.Enabled = True
            groupTercerOrdenie.Enabled = True
        End If
    End Sub
End Class