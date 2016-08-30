Public Class frmParametros

    Private Sub frmParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbo_Establecimientos.Text.Equals("") Then
            MsgBox("Debe seleccionar o ingresar un establecimiento.")
        Else
            panel_Parametros.Enabled = True
            cmd_GuardarParametros.Enabled = True
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class