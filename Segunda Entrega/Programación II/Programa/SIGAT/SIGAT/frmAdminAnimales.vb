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

    Private Sub txt_Peso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Peso.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If txt_NroIdentificador1.Text.Equals("") Then
            If MsgBox("No ingreso ningun numero identificador. ¿Desea ingresar un nuevo animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                panel_Animal.Enabled = True
                cmd_Buscar.Enabled = False
                cmd_Verificar.Enabled = True
                cmd_Agregar.Enabled = True
                cmd_Modificar.Enabled = False
                cmd_Eliminar.Enabled = False
            Else
                MsgBox("Ingrese un numero identificador.")
            End If
        Else
            panel_Animal.Enabled = True
            cmd_Agregar.Enabled = False
            cmd_Verificar.Enabled = False
            cmd_Modificar.Enabled = True
            cmd_Eliminar.Enabled = True
        End If
    End Sub

    Private Sub cmd_Verificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Verificar.Click
        If txt_NroIdentificador2.Text.Equals("") Then
            MsgBox("Ingrese un numero identificador para validar")
        Else
            'Verificar en la base de datos si ya esta en uso por otro animal.
        End If
    End Sub

    Private Sub cmd_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click

    End Sub

    Private Sub cmd_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click

    End Sub

    Private Sub cmd_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Eliminar.Click

    End Sub

    Private Sub cmd_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        If cmd_Buscar.Enabled.Equals(False) Then
            If MsgBox("¿Desea cancelar el ingreso del animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class