Public Class frmHistorialEventos

    Private Sub frmHistorialEventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NroIdentificador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cmd_Listar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Listar.Click
        If txt_NroIdentificador.Text.Equals("") Then
            MsgBox("Debe ingresar el numero identificador de un animal.")
        Else
            'mostar eventos.
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        Me.Close()
    End Sub
End Class