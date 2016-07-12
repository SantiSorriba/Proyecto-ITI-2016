Public Class frmNuevoEstablecimiento

    Private Sub frmNuevoEstablecimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    
    Private Sub cmdParametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdParametros.Click
        frmParametros.Show()
    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        txtNombreEstablecimiento.Clear()
        cboDeptEstablecimiento.Text = ""
        txtUbicacion.Clear()
        txtTelefonoEstablecimiento.Clear()
        txtBps.Clear()
        txtRut.Clear()
        txtDicose.Clear()
        txtHectareas.Clear()
        txtCantidadAnimales.Clear()
        txtCantJersey.Clear()
        txtCantHolando.Clear()
        txtCantPrimerShow.Clear()
        txtNombrePropietario.Clear()
        txtApellido.Clear()
        txtTelefonoPropietario.Clear()
        txtCi.Clear()
        txtDireccion.Clear()
        cboDeptPropietario.Text = ""
        txtCorreo.Clear()
        chkJersey.Checked = False
        chkHolando.Checked = False
        chkPrimerShow.Checked = False
        rdoManual.Checked = False
        rdoMecanico.Checked = False
        rdoSi.Checked = False
        rdoNo.Checked = False
    End Sub

    Private Sub chkJersey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJersey.CheckedChanged
        If chkJersey.Checked Then
            lblCantidad.Enabled = True
            txtCantJersey.Enabled = True
        Else
            lblCantidad.Enabled = False
            txtCantJersey.Clear()
            txtCantJersey.Enabled = False
        End If
    End Sub

    Private Sub chkHolando_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHolando.CheckedChanged
        If chkHolando.Checked Then
            lblCant1.Enabled = True
            txtCantHolando.Enabled = True
        Else
            lblCant1.Enabled = False
            txtCantHolando.Clear()
            txtCantHolando.Enabled = False
        End If
    End Sub

    Private Sub chkPrimerShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrimerShow.CheckedChanged
        If chkPrimerShow.Checked Then
            lblCant2.Enabled = True
            txtCantPrimerShow.Enabled = True
        Else
            lblCant2.Enabled = False
            txtCantPrimerShow.Clear()
            txtCantPrimerShow.Enabled = False
        End If
    End Sub

    Private Sub rdoSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSi.CheckedChanged
        If rdoSi.Checked Then
            lblCorreoElectronico.Enabled = True
            txtCorreo.Enabled = True
        End If
        If rdoNo.Checked Then
            lblCorreoElectronico.Enabled = False
            txtCorreo.Clear()
            txtCorreo.Enabled = False
        End If
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        MsgBox("Datos Guardados")
        Me.Close()
    End Sub
End Class