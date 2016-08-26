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

    'Procedimiento para agregar un ordeñe
    Public Sub registrarordenie(ByRef tipo, ByRef nro_lote, ByRef fecha, ByRef ordenie1, ByRef ordenie2, ByRef ordenie3, ByVal cantidadtotal)
        sql = "insert into producen values (" & Val(tipo) & ", " & Val(nro_lote) & ", '" & fecha & "', " & Val(ordenie1) & "," & Val(ordenie2) & ", " & Val(ordenie3) & ", " & Val(cantidadtotal) & ")"
        Try
            MsgBox(sql)
            cn.Execute(sql)
            MsgBox("Ingresado")
        Catch ex As Exception
            MsgBox("Error al efectuar operación" + ex.Message + ex.ToString)
            Exit Sub
        End Try
    End Sub

    'PROCEDIMIENTO PARA AGREGAR EVENTOS! (Pendiente)
    Public Sub registrarevento(ByVal nro_evento, ByVal nro_animal, ByVal fecha, ByVal id_evento)
        'COMO SABER EL ULTIMO NUMERO DE EVENTO
        sql = "insert into eventos values (" & Val(nro_evento) & ", " & Val(nro_animal) & ", '" & fecha & "', " & Val(id_evento) & ")"
        Try
            cn.Execute(sql)
            MsgBox("Ingresado")
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
    End Sub

End Module
