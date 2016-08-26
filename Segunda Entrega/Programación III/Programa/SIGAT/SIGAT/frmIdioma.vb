Public Class frmIdioma

    Private Sub frmIdioma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmd_Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Seleccionar.Click
        If rdo_Espaniol.Checked Then
            'Cambio todo el programa a español, por si esta en ingles
            idioma = False
        Else
            ingles()
        End If

    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        Me.Close()
    End Sub

End Class