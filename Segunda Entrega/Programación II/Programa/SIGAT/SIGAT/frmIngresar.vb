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
            usuario = txt_Usuario.Text
            contrasenia = txt_Contrasenia.Text
            Conexión.conectarse() 'Conecto
            MsgBox("¡Bienvenido!")
            permisos(usuario) 'Doy los permisos
            Me.Close()
        End If
    End Sub

    Public Sub permisos(ByVal usuario As String)
        'Procedimiento para habilitar funcionalidades segun el rol del usuario.
        If cn.State <> 1 Then
            MsgBox("La conexión con la base de datos no está abierta")
        Else
            sql = "select id from usuarios where nombre_usu='" & usuario & "'"
            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                MsgBox("Error al obtener el id del usuario")
                Exit Sub
            End Try
        End If
        If rs.RecordCount() = 0 Then 'No se encontro el id
            MsgBox("No se encontro id.")
        Else 'Se encontro el id
            Select Case rs(0).Value
                Case 1 'Administrador del Sistema
                    frmPrincipal.menu_Establecimientos.Enabled = True
                    frmPrincipal.menu_Animales.Enabled = True
                    frmPrincipal.menu_Eventos.Enabled = True
                    frmPrincipal.menu_Usuarios.Enabled = True
                    Cosas.id_usuario = 1
                Case 2 'Administrador de un establecimiento
                    frmPrincipal.menu_Establecimientos.Enabled = True
                    frmPrincipal.menu_Animales.Enabled = True
                    frmPrincipal.menu_Eventos.Enabled = True
                    Cosas.id_usuario = 2
                Case 3 'Gerente Administrador
                    frmPrincipal.menu_Establecimientos.Enabled = True
                    frmPrincipal.menu_Animales.Enabled = True
                    frmPrincipal.menu_Eventos.Enabled = True
                    Cosas.id_usuario = 3
                Case (4) 'Auxiliar
                    frmPrincipal.menu_Establecimientos.Enabled = True
                    frmPrincipal.menu_Animales.Enabled = True
                    frmPrincipal.menu_Eventos.Enabled = True
                    Cosas.id_usuario = 4
            End Select
            frmPrincipal.menu_Ingresar.Enabled = False
            frmPrincipal.menu_CerrarSesion.Enabled = True
        End If
        rs.Close()
    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        Me.Close()
    End Sub

End Class