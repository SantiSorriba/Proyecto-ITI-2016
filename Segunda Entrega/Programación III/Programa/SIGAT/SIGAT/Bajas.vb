Module Bajas
    'Modulo para todos los datos eliminados (delete)

    'PROCEDIMIENTO PARA ELIMINAR ESTABLECIMIENTO Y PROPIETARIO! (Pendiente)
    Public Sub eliminarestablecimiento()

    End Sub

    'Procedimiento para eliminar tipo de animal (de la tabla del animal)
    Public Sub eliminartipoanimal(ByVal nroidentificador As Integer, ByVal tipo_animal As String)
        sql = "delete from " & tipo_animal & " where nro_identificador = " & Val(nroidentificador)
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("Error al efectuar operación.")
        End Try
    End Sub

    'Procedimiento para eliminar animal
    Public Sub eliminaranimal(ByVal nroidentificador As Integer)
        sql = "delete from animales where nro_identificador = " & Val(nroidentificador)
        Try
            cn.Execute(sql)
            MsgBox("Animal eliminado.")
            'limpiar datos

        Catch ex As Exception
            MsgBox("Error al efectuar operación.")
        End Try
    End Sub

    'Procedimiento para eliminar lote
    Public Sub eliminarlote(ByVal nro_lote)
        sql = "delete from lotes where nro_lote = " & Val(nro_lote)
        Try
            cn.Execute(sql)
            MsgBox("Lote eliminado")
            'Limpiar datos
            frmLotes.txt_NumLote1.Text = ""
            frmLotes.txt_NumLote2.Text = ""
            frmLotes.txt_Nombre.Text = ""
            frmLotes.num_CantAnimales.Value = 0
            frmLotes.cbo_Criterio.Text = ""
        Catch ex As Exception
            MsgBox("Error al efectuar operación.")
        End Try
    End Sub

End Module
