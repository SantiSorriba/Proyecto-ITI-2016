Module Altas
    'Modulo para todas las altas, ingreso de datos del programa a la base de datos (insert)

    'PROCEDIMIENTO PARA AGREGAR ESTABLECIMIENTO Y PROPIETARIO! (Pendiente)
    Public Sub agregarestablecimiento()

    End Sub

    'Procedimiento para agregar un lote
    Public Sub registrarlote(ByRef nro_lote, ByRef nombre, ByRef cant_animales, ByRef criterio)
        sql = "insert into lotes values (" & Val(nro_lote) & ", '" & nombre & "', " & Val(cant_animales) & ", '" & criterio & "')"
        Try
            cn.Execute(sql)
            MsgBox("Ingresado")
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
    End Sub

    'PROCEDIMIENTO PARA AGREGAR UN ANIMAL! (Pendiente)
    Public Sub registraranimal()

    End Sub

    'PROCEDIMIENTO PARA AGREGAR UN ORDEÑE! (Pendiente)
    Public Sub registrarordenie()

    End Sub

    'PROCEDIMIENTO PARA AGREGAR EVENTOS! (Pendiente)
    Public Sub registrarevento()

    End Sub

End Module
