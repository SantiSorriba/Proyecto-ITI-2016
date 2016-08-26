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
        If txt_NumLote1.Text.Equals("") Then 'Si no se ingreso un numero de lote
            If MsgBox("No ingreso ningun numero. ¿Desea ingresar un nuevo lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmd_Buscar.Enabled = False
                panel_Lote.Enabled = True
                cmd_Verificar.Enabled = True
                cmd_AgregarLote.Enabled = True
                cmd_ModificarLote.Enabled = False
                cmd_EliminarLote.Enabled = False
            Else 'Si no desea registrar un nuevo lote
                MsgBox("Ingrese un numero de lote.")
            End If
        Else 'Si se ingreso un numero de lote
            Busquedas.buscarlote(txt_NumLote1.Text)
        End If
    End Sub

    Private Sub cmd_Verificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Verificar.Click
        Busquedas.verificarlote(txt_NumLote2.Text)
    End Sub

    Private Sub cmd_AgregarAnimales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarAnimales.Click

    End Sub

    Private Sub cmd_AgregarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AgregarLote.Click
        Altas.registrarlote(txt_NumLote2.Text, txt_Nombre.Text, num_CantAnimales.Value, cbo_Criterio.Text)
    End Sub

    Private Sub cmd_ModificarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ModificarLote.Click
        Modificaciones.modificarlote(txt_NumLote2.Text, txt_Nombre.Text, num_CantAnimales.Value, cbo_Criterio.Text)
    End Sub

    Private Sub cmd_EliminarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EliminarLote.Click
        Bajas.eliminarlote(txt_NumLote2.Text)
    End Sub

    Private Sub cmd_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Volver.Click
        If cmd_Buscar.Enabled.Equals(False) Then 'Si esta registrando un nuevo lote
            If MsgBox("¿Desea cancelar el nuevo lote?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else 'Si no esta registrando un nuevo lote
            Me.Close()
        End If
    End Sub


End Class