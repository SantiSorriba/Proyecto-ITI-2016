Module Modificaciones
    'Modulo para las modificaciones de datos (update)

    'PROCEDIMIENTO PARA MODIFICAR DATOS DEL ESTABLECIMIENTO Y PROPIETARIO (Pendiente)
    Public Sub modificarestablecimiento()

    End Sub

    'Procedimiento para modificar datos de un animal
    Public Sub modificaranimal(ByVal nro_identificador, ByVal id, ByVal nombre, ByVal raza, ByVal sexo, ByVal fecha_nac, ByVal lugar_actual, ByVal nro_dicose)
        'verificar el tipo de animal
        Select Case id
            Case 0
                id = 1
            Case 1
                id = 2
            Case 2
                id = 3
            Case 3
                id = 4
        End Select
        sql = "update animales set nro_identificador=" & Val(nro_identificador) & ", id_animal=" & Val(id) & ", nombre='" & nombre & "', raza='" & raza & "', sexo='" & sexo & "', fecha_nac='" & fecha_nac & "', lugar_actual='" & lugar_actual & "', nro_dicose=" & Val(nro_dicose) & " where nro_dicose=" & Val(nro_dicose)
        Try
            cn.Execute(sql)
            MsgBox("Datos Modificados.")
        Catch ex As Exception
            MsgBox("ERROR, no se pudo actualizar los datos del animal.")
        End Try
    End Sub

    'Procedimiento para modificar datos de un lote
    Public Sub modificarlote(ByVal nro_lote, ByVal nombre, ByVal cant_animales, ByVal criterio)
        sql = "update lotes set nro_lote=" & Val(nro_lote) & ", nombre='" & nombre & "', cant_animales=" & Val(cant_animales) & ", criterio='" & criterio & "' where nro_lote=" & Val(nro_lote) & ""
        Try
            cn.Execute(sql)
            MsgBox("Datos Modificados.")
        Catch ex As Exception
            MsgBox("ERROR, no se pudo actualizar los datos del lote.")
        End Try
    End Sub

    'Procedimiento para modificar datos de un usuario
    Public Sub modificarusuario(ByVal nombre As String, ByVal apellido As String, ByVal cedula1 As Integer, ByVal cedula2 As Integer, ByVal id As Integer, ByVal direccion As String, ByVal departamento As String, ByVal nombreusu As String)
        '-----Cambiar datos del usuario-----
        'Verificar el tipo de usuario
        Select Case id
            Case 0
                id = 1
            Case 1
                id = 2
            Case 2
                id = 3
            Case 3
                id = 4
        End Select
        sql = "update usuarios set ci='" & cedula2 & "', id='" & id & "', nombre='" & nombre & "', apellido='" & apellido & "', direccion='" & direccion & "', departamento='" & departamento & "', nombre_usu='" & nombreusu & "', nro_bps='" & 123456789 & "' where ci='" & cedula1 & "'"
        Try
            cn.Execute(sql)
            MsgBox("Datos Modificados.")
        Catch ex As Exception
            MsgBox("ERROR, no se pudo actualizar los datos del usuario.")
        End Try

        '-----Cambiar telefonos del usuario-----

    End Sub

    'PROCEDIMIENTO PARA MODIFICAR PARÁMETROS (Pendiente)
    Public Sub modificarparametros()

    End Sub

End Module
