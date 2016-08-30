Public Class frmAdmEstablecimientos

    Private Sub frmAdmEstablecimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cbo_TelEstablecimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_TelEstablecimiento.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_NroDicose_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroDicose.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_NroRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroRut.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_NroBps_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroBps.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_LimiteAnimales_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LimiteAnimales.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_Superficie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Superficie.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_CedulaPropietario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CedulaPropietario.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cbo_TelPropietario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_TelPropietario.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If cbo_Establecimientos.Text.Equals("") Then 'Si esta vacio, preguntar si desea ingresar uno nuevo
            If MsgBox("No selecciono ningun establecimiento. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Habilitar/Inhabilitar objetos
                cmd_Buscar.Enabled = False
                group_Establecimiento.Enabled = True
                group_Propietario.Enabled = True
                cmd_AgregarEstablecimiento.Enabled = True
                cmd_ModificarEstablecimiento.Enabled = False
                cmd_EliminarEstablecimiento.Enabled = False
                cmd_Parametros.Enabled = True

                'Limpiar datos establecimiento
                cbo_Establecimientos.Text = ""
                txt_NombreEstablecimiento.Text = ""
                cbo_DptoEstablecimiento.Text = ""
                txt_DirEstablecimiento.Text = ""
                cbo_TelEstablecimiento.Items.Clear()
                cbo_TelEstablecimiento.Text = ""
                txt_NroDicose.Text = ""
                txt_NroRut.Text = ""
                txt_NroBps.Text = ""
                txt_LimiteAnimales.Text = ""
                txt_Superficie.Text = ""

                'Limpiar datos propietario
                txt_NombrePropietario.Text = ""
                txt_ApellidoPropietario.Text = ""
                txt_CedulaPropietario.Text = ""
                txt_DirPropietario.Text = ""
                cbo_TelPropietario.Items.Clear()
                cbo_TelPropietario.Text = ""

            Else 'Si no desea crear uno nuevo
                MsgBox("Seleccione un establecimiento de la lista o ingrese el nombre correctamente.")
            End If
        Else 'Si contiene un establecimiento
            'Mostrar datos
        End If
    End Sub

    Private Sub cmd_AgregarTel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTel1.Click

    End Sub

    Private Sub cmd_EliminarTel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarTel1.Click

    End Sub

    Private Sub cmd_AgregarTel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarTel2.Click

    End Sub

    Private Sub cmd_EliminarTel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarTel2.Click

    End Sub

    Private Sub cmd_AgregarEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarEstablecimiento.Click
        'Verificar campos vacios
        If txt_NombreEstablecimiento.Text.Equals("") Then 'Si no se ingreso nombre
            MsgBox("Debe ingresar un nombre para el establecimiento.")
        ElseIf cbo_DptoEstablecimiento.Text.Equals("") Then 'Si no se selecciono departamento
            MsgBox("Debe seleccionar un departamento para el establecimiento.")
        ElseIf txt_DirEstablecimiento.Text.Equals("") Then 'Si no se ingreso direccion
            MsgBox("Debe ingresar una dirección para el establecimiento.")
        ElseIf cbo_TelEstablecimiento.Items.Count.Equals(0) Then 'Si no hay ni un telefono
            MsgBox("Debe ingresar al menos un telefono para el establecimiento.")
        ElseIf txt_NroDicose.Text.Equals("") Then 'Si no se ingreso numero de dicose
            MsgBox("Debe ingresar un numero de DICOSE.")
        ElseIf txt_NroRut.Text.Equals("") Then 'Si no se ingreso numero de rut
            MsgBox("Debe ingresar un numero de RUT.")
        ElseIf txt_NroBps.Text.Equals("") Then 'Si no se ingreso numero de bps
            MsgBox("Debe ingresar un numero de BPS.")
        ElseIf txt_LimiteAnimales.Text.Equals("") Then 'Si no se ingreso limite de animales
            MsgBox("Debe ingresar un limite de animales.")
        ElseIf txt_Superficie.Text.Equals("") Then 'Si no se ingreso superficie
            MsgBox("Debe ingresar la superficie del establecimiento.")
        ElseIf txt_NombrePropietario.Text.Equals("") Then 'Si no se ingreso nombre del propietario
            MsgBox("Debe ingresar el nombre del propietario.")
        ElseIf txt_ApellidoPropietario.Text.Equals("") Then 'Si no se ingreso apellido del propietario
            MsgBox("Debe ingresar el apellido del propietario.")
        ElseIf txt_CedulaPropietario.Text.Equals("") Then 'Si no se ingreso la cedula del propietario
            MsgBox("Debe ingresar la cedula del propietario.")
        ElseIf txt_DirPropietario.Text.Equals("") Then 'Si no se ingreso direccion
            MsgBox("Debe ingresar la direccion del propietario.")
        ElseIf cbo_DptoPropietario.Text.Equals("") Then 'Si no se selecciono departamento
            MsgBox("Debe seleccionar un departamento para el propietario.")
        ElseIf cbo_TelPropietario.Items.Count.Equals(0) Then 'Si no hay ni un telefono
            MsgBox("Debe ingresar al menos un telefono para el propietario.")
        Else 'Si esta todo completo
            If MsgBox("¿Seguro desea registrar el establecimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Guardar establecimiento
            End If
        End If
    End Sub

    Private Sub cmd_ModificarEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ModificarEstablecimiento.Click
        If MsgBox("¿Seguro desea modificar el establecimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'modificar establecimiento
        End If
    End Sub

    Private Sub cmd_EliminarEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarEstablecimiento.Click
        If MsgBox("¿Seguro desea eliminar el establecimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'eliminar establecimiento
        End If
    End Sub

    Private Sub cmd_Parametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Parametros.Click
        frmParametros.Show()
        frmParametros.cbo_Establecimientos.Text = Me.txt_NombreEstablecimiento.Text
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        If cmd_Buscar.Enabled.Equals(False) Then
            If MsgBox("¿Seguro desea salir del registro del nuevo establecimiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class