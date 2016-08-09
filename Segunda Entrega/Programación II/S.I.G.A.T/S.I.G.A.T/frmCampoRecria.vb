Public Class frmCampoRecria

    Private Sub frmCampoRecria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        If cboEstablecimiento.SelectedIndex.Equals(-1) Then
            MsgBox("Seleccione un establecimiento.")
        Else
            panelAnimales.Visible = True
        End If
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub
    
End Class