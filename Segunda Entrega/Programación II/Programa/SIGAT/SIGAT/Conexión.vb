Module Conexión

    'Variables para conexion, consultas, etc.
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    'Variables para validar el login
    Public usuario, contrasenia As String

    'Procedimiento para validar el login en la base de datos
    Public Sub conectarse()
        Try
            cn.Open("Binasoft", usuario, contrasenia)
        Catch ex As Exception
            MsgBox("Hubo un error al conectarse con la base de datos.")
            Exit Sub
        End Try
        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    End Sub

    'Procedimiento para cerrar conexión
    Public Sub cerrarconexion()
        cn.Close()
    End Sub

End Module
