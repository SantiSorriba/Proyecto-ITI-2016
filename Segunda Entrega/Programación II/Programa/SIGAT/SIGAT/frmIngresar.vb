Public Class frmIngresar

    Private Sub frmIngresar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmd_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Ingresar.Click
        'Verificar que no esten los campos vacíos
        If txt_Usuario.Text.Equals("") Then
            MsgBox("Ingrese un nombre de usuario")
        ElseIf txt_Contrasenia.Text.Equals("") Then
            MsgBox("Ingrese una contraseña")
        Else 'Validar el usuario
            Try
                cn.Open("Binasoft", txt_Usuario.Text, txt_Contrasenia.Text)
            Catch ex As Exception
                MsgBox("Usuario o contraseña incorrectos.")
                Exit Sub
            End Try
            cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            MsgBox("Bienvenido")
            frmPrincipal.menu_Ingresar.Enabled = False
            frmPrincipal.menu_CerrarSesion.Enabled = True
            frmPrincipal.menu_Establecimientos.Enabled = True
            frmPrincipal.menu_Animales.Enabled = True
            frmPrincipal.menu_Eventos.Enabled = True
            frmPrincipal.menu_Usuarios.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        Me.Close()
    End Sub

End Class