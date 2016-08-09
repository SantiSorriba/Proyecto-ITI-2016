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
                    groupMedicacion.Enabled = False
                    groupMuerte.Enabled = False
                Case 3
                    groupServicio.Enabled = False
                    groupEnfermedad.Enabled = True
                    groupMedicacion.Enabled = False
                    groupMuerte.Enabled = False
                Case 4
                    groupServicio.Enabled = False
                    groupEnfermedad.Enabled = False
                    groupMedicacion.Enabled = True
                    groupMuerte.Enabled = False
                Case 5
                    groupServicio.Enabled = False
                    groupEnfermedad.Enabled = False
                    groupMedicacion.Enabled = False
                    groupMuerte.Enabled = True
            End Select
        End If
    End Sub

End Class