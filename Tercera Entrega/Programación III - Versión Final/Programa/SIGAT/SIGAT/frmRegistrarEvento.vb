Public Class frmRegistrarEvento

    Private Sub frmRegistrarEvento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NroIdentificador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cmd_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Seleccionar.Click
        If txt_NroIdentificador.Text.Equals("") Then
            MsgBox("Debe ingresar un numero identificador del animal.")
        Else
            panel_Eventos.Enabled = True
        End If
    End Sub

    Private Sub cbo_Evento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Evento.SelectedIndexChanged
        If cbo_Evento.Text.Equals("") Then
            cmd_Registrar.Enabled = False
        Else
            cmd_Registrar.Enabled = True
        End If

        Select Case cbo_Evento.SelectedIndex
            Case 2
                group_Servicio.Enabled = True
                group_Enfermedad.Enabled = False
                cbo_Enfermedad.Text = ""
                cbo_Medicacion.Text = ""
                rdo_Si.Checked = False
                rdo_No.Checked = False
                group_Muerte.Enabled = False
                cbo_Causa.Text = ""
                group_Control.Enabled = False
                cbo_Resultado.Text = ""
            Case 3
                group_Servicio.Enabled = False
                cbo_Servicios.Text = ""
                group_Enfermedad.Enabled = True
                group_Muerte.Enabled = False
                cbo_Causa.Text = ""
                group_Control.Enabled = False
                cbo_Resultado.Text = ""
            Case 4
                group_Servicio.Enabled = False
                cbo_Servicios.Text = ""
                group_Enfermedad.Enabled = False
                cbo_Enfermedad.Text = ""
                cbo_Medicacion.Text = ""
                rdo_Si.Checked = False
                rdo_No.Checked = False
                group_Muerte.Enabled = True
                group_Control.Enabled = False
                cbo_Resultado.Text = ""
            Case 5
                group_Servicio.Enabled = False
                cbo_Servicios.Text = ""
                group_Enfermedad.Enabled = False
                cbo_Enfermedad.Text = ""
                cbo_Medicacion.Text = ""
                rdo_Si.Checked = False
                rdo_No.Checked = False
                group_Muerte.Enabled = False
                cbo_Causa.Text = ""
                group_Control.Enabled = True
        End Select
    End Sub

    Private Sub rdo_Si_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Si.CheckedChanged
        If rdo_Si.Checked.Equals(True) Then
            cbo_Medicacion.Enabled = True
        Else
            cbo_Medicacion.Enabled = False
            cbo_Medicacion.Text = ""
        End If
    End Sub

    Private Sub cmd_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Registrar.Click
        'Verificar campos vacios
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub

End Class