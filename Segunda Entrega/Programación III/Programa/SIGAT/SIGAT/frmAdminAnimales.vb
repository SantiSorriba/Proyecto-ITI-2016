Public Class frmAdminAnimales

    Private Sub frmAdminAnimales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NroIdentificador1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador1.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_NroIdentificador2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroIdentificador2.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If txt_NroIdentificador1.Text.Equals("") Then 'Si no se ingreso un numero
            If MsgBox("No ingreso ningun numero identificador. ¿Desea ingresar un nuevo animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmd_Buscar.Enabled = False
                panel_Animal.Enabled = True
                cmd_Verificar.Enabled = True
                cmd_Agregar.Enabled = True
                cmd_Modificar.Enabled = False
                cmd_Eliminar.Enabled = False
            Else 'Si no desea ingresar nuevo animal
                MsgBox("Ingrese un numero identificador.")
            End If
        Else 'Si ingreso un numero
            Busquedas.buscaranimal(txt_NroIdentificador1.Text)
        End If
    End Sub

    Private Sub cmd_Verificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Verificar.Click
        If txt_NroIdentificador2.Text.Equals("") Then 'Si no ingreso numero
            MsgBox("Porfavor, ingrese un numero identificador para validar.")
        Else 'Si ingreso numero
            Busquedas.verificaranimal(txt_NroIdentificador2.Text)
        End If
    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        Modificaciones.modificaranimal(txt_NroIdentificador2.Text, cbo_TipoAnimal.SelectedIndex, txt_Nombre.Text, txt_Raza.Text, rdo_Hembra.Checked, date_FechaNac.Text, cbo_LugarActual.Text, txt_Nombre.Text)
    End Sub

    Private Sub cmd_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Eliminar.Click
        Bajas.eliminartipoanimal(txt_NroIdentificador2.Text, tipo_animal)
        Bajas.eliminaranimal(txt_NroIdentificador2.Text)
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        If cmd_Buscar.Enabled.Equals(False) Then 'Si se esta agregando un animal
            If MsgBox("¿Desea cancelar el ingreso del animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else 'Si no se esta agregando un animal
            Me.Close()
        End If
    End Sub

End Class