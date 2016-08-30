Public Class frmAdmLotes

    Private Sub frmAdmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NroLote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroLote.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub txt_NroLote2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NroLote2.KeyPress
        Cosas.solonumeros(e)
    End Sub

    Private Sub cmd_BuscarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BuscarLote.Click
        If cbo_Establecimientos.Text.Equals("") Then
            MsgBox("Seleccione o ingrese el nombre de un establecimiento.")
        ElseIf txt_NroLote.Text.Equals("") Then
            If MsgBox("No ingreso ningun numero de lote. ¿Desea ingresar un nuevo lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Habilitar/Inhabilitar objetos
                cmd_BuscarLote.Enabled = False
                group_Lote.Enabled = True
                cmd_Guardar.Enabled = True
                cmd_Modificar.Enabled = False
                cmd_Eliminar.Enabled = False

                'Limpiar datos 
                txt_NroLote2.Text = ""
                txt_NombreLote.Text = ""
                num_CantAnimales.Value = 0
                cbo_Criterio.Text = ""
            Else 'Si no desea ingresar nuevo lote
                MsgBox("Ingrese un numero de lote.")
            End If
        Else
            'Buscar lote
        End If
    End Sub

    Private Sub cmd_VerificarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_VerificarLote.Click
        'Verificar lote
    End Sub

    Private Sub cmd_AgregarAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarAnimales.Click
        'Agregar animales (Formulario)
    End Sub

    Private Sub cmd_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Guardar.Click
        'Verificar campos vacíos
        If txt_NroLote2.Text.Equals("") Then 'Si no hay numero identificador del lote
            MsgBox("Debe ingresar un numero de lote.")
        ElseIf txt_NombreLote.Text.Equals("") Then 'Si el lote no tiene nombre
            MsgBox("Debe ingresarle un nombre al lote.")
        ElseIf num_CantAnimales.Value.Equals(0) Then 'Si la cantidad de animales es 0
            MsgBox("El lote debe contener al menos 1 animal.")
        ElseIf cbo_Criterio.Text.Equals("") Then 'Si no hay criterio
            MsgBox("Seleccione el criterio con el que se ordenan.")
        Else 'Si esta todo completo
            If MsgBox("¿Seguro desea guardar el lote " & txt_NombreLote.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Guardar lote
            End If
        End If
    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        If MsgBox("¿Seguro desea modificar el lote " & txt_NombreLote.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Modificar lote
        End If
    End Sub

    Private Sub cmd_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Eliminar.Click
        If MsgBox("¿Seguro desea eliminar el lote " & txt_NombreLote.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Eliminar lote
        End If
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        If cmd_BuscarLote.Enabled.Equals(False) Then
            If MsgBox("¿Seguro desea salir del registro del nuevo lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

End Class