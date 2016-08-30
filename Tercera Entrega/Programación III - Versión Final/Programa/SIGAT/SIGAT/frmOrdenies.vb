Public Class frmOrdenies

    Private Sub frmOrdenies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub num_Ordenies_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num_Ordenies.ValueChanged
        If num_Ordenies.Value.Equals(0) Then
            group_PrimerOrdenie.Enabled = False
            group_SegundoOrdenie.Enabled = False
            group_TercerOrdenie.Enabled = False
            txt_Cant1.Text = ""
            txt_Cant2.Text = ""
            txt_Cant3.Text = ""
            cmd_GuardarOrdenie.Enabled = False
        ElseIf num_Ordenies.Value.Equals(1) Then
            group_PrimerOrdenie.Enabled = True
            group_SegundoOrdenie.Enabled = False
            group_TercerOrdenie.Enabled = False
            txt_Cant2.Text = ""
            txt_Cant3.Text = ""
            cmd_GuardarOrdenie.Enabled = True
        ElseIf num_Ordenies.Value.Equals(2) Then
            group_PrimerOrdenie.Enabled = True
            group_SegundoOrdenie.Enabled = True
            group_TercerOrdenie.Enabled = False
            txt_Cant3.Text = ""
            cmd_GuardarOrdenie.Enabled = True
        ElseIf num_Ordenies.Value.Equals(3) Then
            group_PrimerOrdenie.Enabled = True
            group_SegundoOrdenie.Enabled = True
            group_TercerOrdenie.Enabled = True
            cmd_GuardarOrdenie.Enabled = True
        End If
    End Sub

    Private Sub txt_Cant1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cant1.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_Cant2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cant2.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_Cant3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cant3.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cmd_GuardarOrdenie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_GuardarOrdenie.Click
        'Verificar campos vacios
        If cbo_Lotes.Text.Equals("") Then 'Si no selecciono lote
            MsgBox("Debe seleccionar un lote.")
        ElseIf cbo_TipoLeche.Text.Equals("") Then 'Si no selecciono el tipo de leche
            MsgBox("Debe seleccionar un tipo de leche.")
        ElseIf txt_Cant1.Text.Equals("") Then 'Si no ingreso los litros para el primer ordeñe
            MsgBox("Debe ingresar al menos un ordeñe.")
        Else 'Si esta completo
            If MsgBox("¿Seguro desea guardar el ordeñe?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Guardar ordeñe
            End If
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class