Public Class frmConfiguracion

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdIngles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngles.Click
        Me.Text = "S.I.G.A.T - Configuration"
        cmdEspaniol.Text = "Change language to Spanish"
        cmdIngles.Text = "Change laguange to English"
        tabIdioma.Text = "Language"
        tabPreferencias.Text = "Preferences"
        MsgBox("Language changed to english")
        'Por ahora solo cambia el texto de la ventana configuración. El idioma se traducira a ingles una vez que 
        'el programa este finalizado.
    End Sub

    Private Sub cmdEspaniol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEspaniol.Click
        Me.Text = "S.I.G.A.T - Configuración"
        cmdEspaniol.Text = "Cambiar idioma a español"
        cmdIngles.Text = "Cambiar idioma a ingles"
        tabIdioma.Text = "Lenguaje"
        tabPreferencias.Text = "Preferencias"
        MsgBox("Idioma cambiado a español")
        'Por ahora solo cambia el texto de la ventana configuración. El idioma se traducira a ingles una vez que 
        'el programa este finalizado.
    End Sub
End Class