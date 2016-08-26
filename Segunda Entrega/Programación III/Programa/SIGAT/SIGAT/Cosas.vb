Module Cosas

    Public id_usuario As Integer 'Variable para guardar el id del usuario logueado

    'Inhabilitar funciones
    Public Sub inhabilitarfunciones()
        frmPrincipal.menu_Ingresar.Enabled = True
        frmPrincipal.menu_CerrarSesion.Enabled = False
        frmPrincipal.menu_Establecimientos.Enabled = False
        frmPrincipal.menu_Animales.Enabled = False
        frmPrincipal.menu_Eventos.Enabled = False
        frmPrincipal.menu_Usuarios.Enabled = False
    End Sub

    'Permitir solo el ingreso de numeros en un cuadro de texto
    Public Sub solonumeros(ByRef e As Object)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Module

