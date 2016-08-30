Public Class frmInventario

    Private Sub frmInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmd_Listar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Listar.Click
        If cbo_Establecimientos.Text.Equals("") Then
            MsgBox("Seleccione o ingrese un establecimiento.")
        Else
            grid_Animales.Visible = True
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class