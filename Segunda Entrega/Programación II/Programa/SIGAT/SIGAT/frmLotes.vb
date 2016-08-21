Public Class frmLotes

    Private Sub frmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub txt_NumLote1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NumLote1.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txt_NumLote2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NumLote2.KeyPress
        solonumeros(e)
    End Sub

    Private Sub cmd_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Buscar.Click
        If txt_NumLote1.Text.Equals("") Then
            If MsgBox("No ingreso ningun numero. ¿Desea ingresar un nuevo lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                panel_Lote.Enabled = True
                cmd_Buscar.Enabled = False
                cmd_AgregarLote.Enabled = True
                cmd_ModificarLote.Enabled = False
                cmd_EliminarLote.Enabled = False
            Else
                MsgBox("Ingrese un numero de lote.")
            End If
        Else
            panel_Lote.Enabled = True
            cmd_AgregarLote.Enabled = False
            cmd_ModificarLote.Enabled = True
            cmd_EliminarLote.Enabled = True
        End If
    End Sub

    Private Sub cmd_AgregarAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarAnimales.Click

    End Sub

    Private Sub cmd_AgregarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarLote.Click

    End Sub

    Private Sub cmd_ModificarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ModificarLote.Click

    End Sub

    Private Sub cmd_EliminarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarLote.Click

    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        If cmd_Buscar.Enabled.Equals(False) Then
            If MsgBox("¿Desea cancelar el nuevo lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

End Class