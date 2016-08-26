Public Class frmUsuarios

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        MsgBox("Los teléfonos se modifican independientemente de los demás datos.")
    End Sub

    Private Sub txt_Cedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cedula.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Cedula2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cedula2.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cbo_Telefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Telefonos.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If txt_Cedula.Text.Equals("") Then 'Si no se ingreso cédula
            MsgBox("Error, no ingreso ninguna cédula.")
        Else 'Si se ingreso cédula
            Busquedas.buscarusuario(txt_Cedula.Text)
            panel_Usuario.Enabled = True
            cmd_Modificar.Enabled = True
        End If
    End Sub

    Private Sub cmd_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTel.Click

    End Sub

    Private Sub cmd_EliminarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarTel.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        'Preguntar si esta seguro de cambiar los datos
        If MsgBox("¿Seguro desea cambiar los datos de este usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cedula_ingresada As Integer = Val(txt_Cedula.Text)
            Dim cedula_modificada As Integer = Val(txt_Cedula2.Text)
            Dim id As Integer
            Modificaciones.modificarusuario(txt_Nombre.Text, txt_Apellido.Text, cedula_ingresada, cedula_modificada, id, txt_Dirección.Text, cbo_Departamentos.Text, txt_NomUsu.Text)
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class