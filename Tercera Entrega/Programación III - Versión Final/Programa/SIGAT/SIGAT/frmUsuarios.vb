Public Class frmUsuarios

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_CedulaUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CedulaUsuario.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cbo_Telefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Telefonos.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If txt_CedulaUsuario.Text.Equals("") Then
            MsgBox("Ingrese una cedula.")
        Else
            'mostrar datos
        End If
    End Sub

    Private Sub cmd_AgregarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTel.Click

    End Sub

    Private Sub cmd_EliminarTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarTel.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        If MsgBox("¿Seguro desea modificar los datos del usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'modificar usuario
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub

    
End Class