Public Class frmOrdenies

    Private Sub frmOrdenies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        'Cargar lotes
        Busquedas.cargarlotes(cbo_Lotes)
        'Cargar tipos de leche
        Busquedas.cargarleche(cbo_TipoLeche)
    End Sub

    Private Sub txt_Cant1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cant1.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Cant2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cant2.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Cant3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cant3.KeyPress
        solonumeros(e)
    End Sub

    Private Sub chkPrimerOrdenie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrimerOrdenie.CheckedChanged
        If chk_PrimerOrdenie.Checked.Equals(True) Then
            group_PrimerOrdenie.Enabled = True
            chk_SegundoOrdenie.Enabled = True
            cmd_Guardar.Enabled = True
        Else
            group_PrimerOrdenie.Enabled = False
            chk_SegundoOrdenie.Enabled = False
            cmd_Guardar.Enabled = False
            chk_SegundoOrdenie.Checked = False
            chk_TercerOrdenie.Checked = False
            txt_Cant1.Clear()
            txt_Cant2.Clear()
            txt_Cant3.Clear()
        End If
    End Sub

    Private Sub chkSegundoOrdenie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SegundoOrdenie.CheckedChanged
        If chk_SegundoOrdenie.Checked.Equals(True) Then
            group_SegundoOrdenie.Enabled = True
            chk_TercerOrdenie.Enabled = True
        Else
            group_SegundoOrdenie.Enabled = False
            chk_TercerOrdenie.Enabled = False
            chk_TercerOrdenie.Checked = False
            txt_Cant2.Clear()
            txt_Cant3.Clear()
        End If
    End Sub

    Private Sub chkTercerOrdenie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TercerOrdenie.CheckedChanged
        If chk_TercerOrdenie.Checked.Equals(True) Then
            group_TercerOrdenie.Enabled = True
        Else
            group_TercerOrdenie.Enabled = False
            txt_Cant3.Clear()
        End If
    End Sub

    Private Sub cmd_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Guardar.Click

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        Me.Close()
    End Sub

End Class