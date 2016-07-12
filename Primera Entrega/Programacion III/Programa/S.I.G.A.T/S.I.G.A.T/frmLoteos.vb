Public Class frmLoteos

    Private Sub frmLoteos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If cboOrdenies.SelectedIndex.Equals(-1) Then
            MsgBox("Error, seleccione un ordeñe")
        Else
            MsgBox("Guardado")
        End If
    End Sub
End Class