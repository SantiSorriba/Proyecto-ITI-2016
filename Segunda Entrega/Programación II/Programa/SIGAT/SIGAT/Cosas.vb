Module Rutinas

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

    ' Inicio variable idioma como buleano. La variable estara en false por defecto, lo cual significara
    ' que el programa esta en español. Si la variable es true, el programa estara en ingles. Basicamente
    ' sirve para identificar en que idioma esta el programa al momento de mostrar msgbox's.
    Public idioma As Boolean = False

    Public Sub ingles()
        'Cambio todo el idioma a ingles, por si esta en español
        idioma = True
        ' frmIdioma
        frmIdioma.Text = "Language"
        frmIdioma.lbl_Idioma.Text = "Language"
        frmIdioma.rdo_Espaniol.Text = "Spanish"
        frmIdioma.rdo_Ingles.Text = "English"
        frmIdioma.cmd_Seleccionar.Text = "Select Language"
        frmIdioma.cmd_Cancelar.Text = "Cancel"

        ' frmPricipal
        frmPrincipal.Text = "S.I.G.A.T - Principal Window"
        frmPrincipal.menu_Archivo.Text = "Archive"
        frmPrincipal.menu_Ingresar.Text = "Sign in"
        frmPrincipal.menu_CerrarSesion.Text = "Sign out"
        frmPrincipal.menu_Idioma.Text = "Language"
        frmPrincipal.menu_Salir.Text = "Exit"
        frmPrincipal.menu_Establecimientos.Text = "Establishments"
        frmPrincipal.menu_AdministrarEstablecimientos.Text = "Manage Establishments"
        frmPrincipal.menu_ConsultarProduccion.Text = "Check Production"
        frmPrincipal.menu_Animales.Text = "Animals"
        frmPrincipal.menu_AdministrarAnimales.Text = "Manage Animals"
        frmPrincipal.menu_Inventario.Text = "Animals Inventory"
        frmPrincipal.menu_Lotes.Text = "Lots"
        frmPrincipal.menu_Ordenies.Text = "Milking"
        frmPrincipal.menu_Eventos.Text = "Events"
        frmPrincipal.menu_Usuarios.Text = "Users"

        ' frmIngresar
        frmIngresar.Text = "Sing in"
        frmIngresar.lbl_Usuario.Text = "User"
        frmIngresar.lbl_Contrasenia.Text = "Password"
        frmIngresar.cmd_Ingresar.Text = "Sing in"
        frmIngresar.cmd_Cancelar.Text = "Cancel"

        ' frmEstablecimientos
        frmEstablecimientos.Text = "Manage Establishments"
        frmEstablecimientos.lbl_SeleccionarEstablecimiento.Text = "Select an Establishment"
        frmEstablecimientos.cmd_Buscar.Text = "Search"
        frmEstablecimientos.lbl_NombreEstablecimiento.Text = "Establishment Name:"
        frmEstablecimientos.lbl_DirEstablecimiento.Text = "Address:"
        frmEstablecimientos.lbl_DptoEstablecimiento.Text = "Department"

        MsgBox("Language Changed to English")
    End Sub

End Module

