Public Class frmEstablecimientos

    Private Sub frmEstablecimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If cbo_Establecimientos.Text.Equals("") Then
            If MsgBox("No selecciono ningun establecimiento. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                group_Establecimiento.Enabled = True
                group_Propietario.Enabled = True
                cmd_Buscar.Enabled = False
                cmd_Agregar.Enabled = True
                cmd_Parametros.Enabled = True
            Else
                MsgBox("Seleccione un establecimiento de la lista o ingrese el nombre correctamente.")
            End If
        Else
            group_Establecimiento.Enabled = True
            group_Propietario.Enabled = True
            cmd_Modificar.Enabled = True
        End If
    End Sub

    Private Sub txt_NroDicose_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroDicose.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_NroRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroRut.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_NroBps_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroBps.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Superficie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Superficie.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_LimiteAnimales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LimiteAnimales.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cbo_TelefonosEstablecimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_TelefonosEstablecimiento.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_Cedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cedula.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cbo_TelefonosPropietario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_TelefonosPropietario.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_AgregarTelefono1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTelefono1.Click

    End Sub

    Private Sub cmd_BorrarTelefono1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BorrarTelefono1.Click

    End Sub

    Private Sub cmd_AgregarTelefono2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTelefono2.Click

    End Sub

    Private Sub cmd_BorrarTelefono2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BorrarTelefono2.Click

    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click

    End Sub

    Private Sub cmd_Parametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Parametros.Click

    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        If cmd_Buscar.Enabled.Equals(False) Then
            If MsgBox("¿Desea cancelar el ingreso del establecimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

End Class