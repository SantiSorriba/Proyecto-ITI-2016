Public Class frmConsultarEventos

    Private Sub frmConsultarEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        If txtNroAnimal.Text.Equals("") Then
            MsgBox("No ingreso ningun numero de animal")
        Else
            gridEventos.Visible = True
        End If
    End Sub
End Class