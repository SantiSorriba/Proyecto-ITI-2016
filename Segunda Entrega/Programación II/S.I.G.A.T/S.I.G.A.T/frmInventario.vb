Public Class frmInventario

    Private Sub frmInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListar.Click
        If cboEstablecimiento.SelectedIndex.Equals(-1) Then
            MsgBox("Seleccione un establecimiento.")
        ElseIf cboLugar.SelectedIndex.Equals(-1) Then
            MsgBox("Seleccione la ubicación de los animales")
        Else
            gridAnimales.Visible = True
        End If
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

End Class