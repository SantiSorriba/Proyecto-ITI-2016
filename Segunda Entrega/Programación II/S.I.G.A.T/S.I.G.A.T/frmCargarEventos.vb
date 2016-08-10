Public Class frmCargarEventos

    Private Sub frmCargarEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cboEventos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEventos.SelectedIndexChanged
        If txtNumAnimal.Text.Equals("") Then
            MsgBox("Ingrese un numero de animal")
        Else
            Select cboEventos.SelectedIndex()
                Case 2
                    groupServicio.Enabled = True
                    groupEnfermedad.Enabled = False
                    groupMuerte.Enabled = False
                Case 3
                    groupServicio.Enabled = False
                    groupEnfermedad.Enabled = True
                    groupMuerte.Enabled = False
                Case 4
                    groupServicio.Enabled = False
                    groupEnfermedad.Enabled = False
                    groupMuerte.Enabled = True
            End Select
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub rdoSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSi.CheckedChanged
        If rdoSi.Checked Then
            cboMedicacion.Enabled = True
        Else
            cboMedicacion.Enabled = False
            cboMedicacion.SelectedIndex = -1
        End If
    End Sub
End Class