Public Class frmOrdenies

    Private Sub frmOrdenies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub chkPrimerOrdenie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrimerOrdenie.CheckedChanged
        If chkPrimerOrdenie.Checked.Equals(True) Then
            groupPrimerOrdenie.Enabled = True
            chkSegundoOrdenie.Enabled = True
            cmdGuardar.Enabled = True
        Else
            groupPrimerOrdenie.Enabled = False
            chkSegundoOrdenie.Enabled = False
            cmdGuardar.Enabled = False
            chkSegundoOrdenie.Checked = False
            chkTercerOrdenie.Checked = False
        End If
    End Sub

    Private Sub chkSegundoOrdenie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSegundoOrdenie.CheckedChanged
        If chkSegundoOrdenie.Checked.Equals(True) Then
            groupSegundoOrdenie.Enabled = True
            chkTercerOrdenie.Enabled = True
        Else
            groupSegundoOrdenie.Enabled = False
            chkTercerOrdenie.Enabled = False
            chkTercerOrdenie.Checked = False
        End If
    End Sub

    Private Sub chkTercerOrdenie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTercerOrdenie.CheckedChanged
        If chkTercerOrdenie.Checked.Equals(True) Then
            groupTercerOrdenie.Enabled = True
        Else
            groupTercerOrdenie.Enabled = False
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub






    
End Class