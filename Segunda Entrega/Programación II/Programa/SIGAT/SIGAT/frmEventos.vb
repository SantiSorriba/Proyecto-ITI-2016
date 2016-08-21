Public Class frmEventos

    Private Sub frmEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NroIdentificador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Seleccionar.Click
        If txt_NroIdentificador.Text.Equals("") Then
            MsgBox("Porfavor, ingrese un numero de animal.")
        Else
            tab_Eventos.Enabled = True
            lbl_NroAnimal.Text = txt_NroIdentificador.Text
        End If
    End Sub

    Private Sub cbo_Eventos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Eventos.SelectedIndexChanged
        Select Case cbo_Eventos.SelectedIndex()
            Case 2
                group_Servicio.Enabled = True
                group_Enfermedad.Enabled = False
                group_Muerte.Enabled = False
                cbo_Enfermedad.SelectedIndex = -1
                rdo_Si.Checked = False
                rdo_No.Checked = False
                cbo_Medicacion.SelectedIndex = -1
                cbo_Causa.SelectedIndex = -1
            Case 3
                group_Servicio.Enabled = False
                group_Enfermedad.Enabled = True
                group_Muerte.Enabled = False
                cbo_Servicios.SelectedIndex = -1
                cbo_Causa.SelectedIndex = -1
            Case 4
                group_Servicio.Enabled = False
                group_Enfermedad.Enabled = False
                group_Muerte.Enabled = True
                cbo_Servicios.SelectedIndex = -1
                cbo_Enfermedad.SelectedIndex = -1
                rdo_Si.Checked = False
                rdo_No.Checked = False
                cbo_Medicacion.SelectedIndex = -1
        End Select

        If cbo_Eventos.SelectedIndex > -1 Then
            cbo_GuardarEvento.Enabled = True
        Else
            cbo_GuardarEvento.Enabled = False
        End If
    End Sub

    Private Sub rdo_Si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Si.CheckedChanged
        If rdo_Si.Checked Then
            cbo_Medicacion.Enabled = True
        Else
            cbo_Medicacion.Enabled = False
            cbo_Medicacion.SelectedIndex = -1
        End If
    End Sub

    Private Sub cbo_GuardarEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_GuardarEvento.Click

    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub

End Class