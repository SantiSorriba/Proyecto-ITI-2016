Public Class frmABMC

    Private Sub frmABMC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtNumId.Text.Equals("") Then
            If MsgBox("No ingreso ningun numero identificador. ¿Desea registrar un nuevo animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmdBuscar.Enabled = False
                panelAnimales.Visible = True
                cmdAgregar.Enabled = True
                cmdModificar.Enabled = False
                cmdEliminar.Enabled = False
                cmdVerificar.Visible = True
            Else
                MsgBox("Ingrese un numero identificador.")
            End If
        Else
            panelAnimales.Visible = True
            cmdAgregar.Enabled = False
            cmdModificar.Enabled = True
            cmdEliminar.Enabled = True
            cmdVerificar.Visible = False
        End If
    End Sub

    Private Sub txtNumeroIdentificador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroIdentificador.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumId.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtNumeroIdentificador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroIdentificador.TextChanged
        If txtNumeroIdentificador.Text.Equals("") Then
            cmdVerificar.Enabled = False
        Else
            cmdVerificar.Enabled = True
        End If
    End Sub

End Class