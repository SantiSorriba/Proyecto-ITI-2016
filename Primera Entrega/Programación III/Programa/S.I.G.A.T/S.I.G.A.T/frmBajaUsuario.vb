Public Class frmBajaUsuario

    Private Sub frmBajaUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        lblNombre.Visible = False
        lblNombreUsu.Visible = False
        lblApellido.Visible = False
        lblApellidoUsu.Visible = False
        lblActivo.Visible = False
        lblFechaIngreso.Visible = False
        cmdEliminarUsu.Visible = False
        cmdCancelar.Visible = False
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtCi.Text.Equals("") Then
            MsgBox("Error, debe ingresar una cedula.")
        Else
            lblNombre.Visible = True
            lblNombreUsu.Visible = True
            lblApellido.Visible = True
            lblApellidoUsu.Visible = True
            lblActivo.Visible = True
            lblFechaIngreso.Visible = True
            cmdEliminarUsu.Visible = True
            cmdCancelar.Visible = True
        End If
    End Sub
End Class