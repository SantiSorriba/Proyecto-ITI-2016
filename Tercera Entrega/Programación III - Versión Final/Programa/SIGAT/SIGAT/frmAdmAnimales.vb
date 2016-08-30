Public Class frmAdmAnimales

    Private Sub frmAdmAnimales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NroIdentificador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_NroIdentificador2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador2.KeyPress
        Cosas.solonumeros(e)
    End Sub
    '
    Private Sub cmd_BuscarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BuscarAnimal.Click
        If txt_NroIdentificador.Text.Equals("") Then 'Si no se ingreso un numero
            If MsgBox("No ingreso ningun numero identificador. ¿Desea ingresar un nuevo animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Habilitar/Inhabilitar objetos
                cmd_BuscarAnimal.Enabled = False
                group_Animal.Enabled = True
                cmd_VerificarNumero.Enabled = True
                cmd_AgregarAnimal.Enabled = True
                cmd_ModificarAnimal.Enabled = False
                cmd_EliminarAnimal.Enabled = False

                'Limpiar datos establecimiento
                txt_NroIdentificador2.Text = ""
                cbo_TipoAnimal.Text = ""
                cbo_Establecimiento.Text = ""
                txt_NombreAnimal.Text = ""
                txt_Raza.Text = ""
                rdo_Hembra.Checked = False
                rdo_Macho.Checked = False
                date_FechaNacAnimal.Value = Date.Now
                cbo_LugarActual.Text = ""
            Else 'Si no desea ingresar nuevo animal
                MsgBox("Ingrese un numero identificador.")
            End If
        Else 'Si ingreso un numero
            'Buscar animal
        End If
    End Sub

    Private Sub cmd_VerificarNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_VerificarNumero.Click
        'Verificar numero identificador
    End Sub

    Private Sub cmd_AgregarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarAnimal.Click
        'Verificar campos vacíos
        If txt_NroIdentificador2.Text.Equals("") Then 'Si esta vacio el numero identificador
            MsgBox("Debe ingresar un numero identificador para el animal.")
        ElseIf cbo_TipoAnimal.Text.Equals("") Then 'Si no hay especificado tipo de animal
            MsgBox("Seleccione un tipo de animal.")
        ElseIf cbo_Establecimiento.Text.Equals("") Then 'Si no hay especificado un establecimiento
            MsgBox("Seleccione el establecimiento al cual pertenece el animal.")
        ElseIf txt_NombreAnimal.Text.Equals("") Then 'Si no ingreso nombre del animal
            MsgBox("Debe ingresar un nombre para el animal.")
        ElseIf txt_Raza.Text.Equals("") Then 'Si no ingreso raza del animal
            MsgBox("Debe ingresar la raza del animal.")
        ElseIf rdo_Hembra.Checked.Equals(False) And rdo_Macho.Checked.Equals(False) Then 'Si no selecciono sexo
            MsgBox("Seleccione el sexo del animal.")
        ElseIf date_FechaNacAnimal.Value > DateTime.Now Then 'Si la fecha es mayor que el dia actual
            MsgBox("La fecha de nacimiento no puede ser mayor al dia de hoy.")
        ElseIf cbo_LugarActual.Text.Equals("") Then 'Si no selecciono el lugar del animal
            MsgBox("Debe seleccionar el lugar actual del animal.")
        Else 'Si todos los campos estan llenos
            If MsgBox("¿Seguro desea registrar el animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Guardar animal
            End If
        End If
    End Sub

    Private Sub cmd_ModificarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ModificarAnimal.Click
        If MsgBox("¿Seguro desea modificar el animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'modificar animal
        End If
    End Sub

    Private Sub cmd_EliminarAnimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarAnimal.Click
        If MsgBox("¿Seguro desea eliminar el animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Eliminar animal
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        If cmd_BuscarAnimal.Enabled.Equals(False) Then
            If MsgBox("¿Seguro desea salir del registro del nuevo animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

End Class