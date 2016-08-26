Module Busquedas
    'Modulo para todo lo que sean traer o cargar datos, ComboBox's, etc.(select)

    'Variables
    Public cedulapropietario As Integer 'Variable para guardar la cedula del propietario
    Public nro_dicose As Integer 'Variable para guardar el numero de dicose del establecimiento

    'Procedimiento para cargar los establecimientos en un ComboBox
    Public Sub cargarestablecimientos(ByRef combo As Object)
        sql = "select nombre from establecimientos"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al obtener los establecimientos.")
            Exit Sub
        End Try
        combo.Items.Clear()
        While Not rs.EOF
            combo.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    'Procedimiento para cargar los lotes en un ComboBox
    Public Sub cargarlotes(ByRef combo As Object)
        sql = "select nombre from lotes"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al obtener los lotes.")
            Exit Sub
        End Try
        combo.Items.Clear()
        While Not rs.EOF
            combo.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    'Procedimiento para cargar los tipos de leche en un ComboBox
    Public Sub cargarleche(ByVal combo As Object)
        sql = "select descripcion from leche"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al obtener los tipos de leche.")
            Exit Sub
        End Try
        combo.Items.Clear()
        While Not rs.EOF
            combo.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    'Procedimiento para guardar el numero de dicose en la variable "nro_dicose" declarada al principio
    Public Sub guardarnrodicose(ByVal nombre)
        sql = "select nro_dicose from establecimientos where nombre = '" & nombre & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro numero
            MsgBox("No se encontro el numero.")
        Else 'Se encontro numero
            nro_dicose = rs("nro_dicose").Value
        End If
        rs.Close()
    End Sub

    'Procedimiento para cargar datos del establecimiento y propietario
    Public Sub buscarestablecimiento(ByVal nombre_establecimiento)
        '-----Buscar establecimiento-----
        sql = "select * from establecimientos where nombre = '" & nombre_establecimiento & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro establecimiento
            If MsgBox("No ingreso ningun establecimiento. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                frmEstablecimientos.cmd_Buscar.Enabled = False
                frmEstablecimientos.group_Establecimiento.Enabled = True
                frmEstablecimientos.group_Propietario.Enabled = True
                frmEstablecimientos.cmd_Agregar.Enabled = True
                frmEstablecimientos.cmd_Parametros.Enabled = True
            Else
                MsgBox("Ingrese o seleccione un establecimiento.")
            End If
        Else 'Se encontro establecimiento
            cedulapropietario = rs("ci_propietario").Value
            frmEstablecimientos.group_Establecimiento.Enabled = True
            frmEstablecimientos.cmd_Agregar.Enabled = False
            frmEstablecimientos.cmd_Modificar.Enabled = True
            frmEstablecimientos.cmd_Eliminar.Enabled = True
            frmEstablecimientos.txt_NomEstablecimiento.Text = rs("nombre").Value
            frmEstablecimientos.txt_DirEstablecimiento.Text = rs("direccion").Value
            frmEstablecimientos.cbo_DptoEstablecimiento.Text = rs("departamento").Value
            frmEstablecimientos.txt_NroDicose.Text = rs("nro_dicose").Value
            frmEstablecimientos.txt_NroBps.Text = rs("nro_bps").Value
            frmEstablecimientos.txt_NroRut.Text = rs("nro_rut").Value
            frmEstablecimientos.txt_Superficie.Text = rs("superficie").Value
            frmEstablecimientos.txt_LimiteAnimales.Text = rs("limite_animales").Value
        End If
        rs.Close()


        '-----Buscar telefonos del establecimiento-----
        sql = "select telefono from telefonos_establecimiento where nro_dicose = " & Val(nro_dicose)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al obtener telefonos del establecimiento")
            Exit Sub
        End Try
        frmEstablecimientos.cbo_TelefonosEstablecimiento.Items.Clear()
        While Not rs.EOF
            frmEstablecimientos.cbo_TelefonosEstablecimiento.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()


        '-----Buscar propietario-----
        sql = "select * from propietario where ci = '" & cedulapropietario & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro propietario
            MsgBox("No se encontro propietario.")
        Else 'Se encontro propietario
            frmEstablecimientos.group_Propietario.Enabled = True
            frmEstablecimientos.cmd_Modificar.Enabled = True
            frmEstablecimientos.cmd_Eliminar.Enabled = True
            frmEstablecimientos.txt_NombrePropietario.Text = rs("nombre").Value
            frmEstablecimientos.txt_ApellidoPropietario.Text = rs("apellido").Value
            frmEstablecimientos.txt_Cedula.Text = cedulapropietario
            frmEstablecimientos.cbo_DptoPropietario.Text = rs("departamento").Value
            frmEstablecimientos.txt_DirPropietario.Text = rs("direccion").Value
        End If
        rs.Close()


        '-----Buscar telefonos del propietario-----
        sql = "select telefono from telefonos_propietario where ci = " & cedulapropietario
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al obtener telefonos del propietario")
            Exit Sub
        End Try
        frmEstablecimientos.cbo_TelefonosPropietario.Items.Clear()
        While Not rs.EOF
            frmEstablecimientos.cbo_TelefonosPropietario.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    'Procedimiento para cargar la producción
    Public Sub buscarproduccion(ByVal fecha)
        sql = "select * from produccion where fecha ='" & fecha & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro ordeñe
            MsgBox("No se ordeño en ese dia.")
        Else 'Se encontro ordeñe
            frmConsultarProduccion.txt_PrimerOrdenie.Text = rs("primer_ordenie").Value
            frmConsultarProduccion.txt_SegundoOrdenie = rs("segundo_ordenie").Value
            frmConsultarProduccion.txt_TercerOrdenie = rs("tercer_ordenie").Value
            frmConsultarProduccion.txt_CantidadTotal.Text = rs("cant_producida").Value
            'Tipo de Leche
            Select Case rs("tipo").Value
                Case 1
                Case 2
                Case 3
            End Select
            'Nombre del lote
        End If
        rs.Close()
    End Sub

    'Procedimiento para cargar animal
    Public Sub buscaranimal(ByVal nro_identificador As Integer)
        sql = "select * from animales where nro_identificador = " & Val(nro_identificador)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try

        If rs.RecordCount = 0 Then  'No se encontro animal
            If MsgBox("No se encontro ese animal. ¿Desea ingresar un nuevo animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Limpiar datos
                frmAdminAnimales.txt_Nombre.Clear()
                frmAdminAnimales.txt_Raza.Clear()
                frmAdminAnimales.cbo_Establecimientos.Text = ""
                frmAdminAnimales.cbo_Establecimientos.Items.Clear()
                frmAdminAnimales.rdo_Macho.Checked = False
                frmAdminAnimales.rdo_Hembra.Checked = False
                frmAdminAnimales.cbo_TipoAnimal.Text = ""
                frmAdminAnimales.cbo_LugarActual.Text = ""

                frmAdminAnimales.cmd_Buscar.Enabled = False
                frmAdminAnimales.panel_Animal.Enabled = True
                frmAdminAnimales.txt_NroIdentificador2.Enabled = False
                frmAdminAnimales.cmd_Verificar.Enabled = True
                frmAdminAnimales.cmd_Agregar.Enabled = True
                frmAdminAnimales.cmd_Modificar.Enabled = False
                frmAdminAnimales.cmd_Eliminar.Enabled = False
                frmAdminAnimales.txt_NroIdentificador2.Text = nro_identificador
                frmAdminAnimales.cmd_Verificar.Enabled = False
            Else
                MsgBox("Ingrese un numero identificador.")
            End If
        Else 'Se encontro animal
            frmAdminAnimales.panel_Animal.Enabled = True
            frmAdminAnimales.cmd_Agregar.Enabled = False
            frmAdminAnimales.cmd_Verificar.Enabled = False
            frmAdminAnimales.cmd_Modificar.Enabled = True
            frmAdminAnimales.cmd_Eliminar.Enabled = True
            frmAdminAnimales.txt_NroIdentificador2.Enabled = False
            'Cargo los datos
            frmAdminAnimales.panel_Animal.Enabled = True
            frmAdminAnimales.txt_NroIdentificador2.Text = frmAdminAnimales.txt_NroIdentificador1.Text
            frmAdminAnimales.txt_Nombre.Text = rs("nombre").Value
            frmAdminAnimales.txt_Raza.Text = rs("raza").Value
            'ESTABLECIMIENTO DEL ANIMAL
            frmAdminAnimales.date_FechaNac.Text = rs("fecha_nac").Value
            'Sexo del animal
            If rs("sexo").Value.Equals("Hembra") Then 'Si es hembra
                frmAdminAnimales.rdo_Hembra.Checked = True
            Else 'Si no es hembra
                frmAdminAnimales.rdo_Macho.Checked = True
            End If
            'Tipo de animal
            Select Case rs("id_animal").Value
                Case 1
                    frmAdminAnimales.cbo_TipoAnimal.SelectedIndex = 0
                Case 2
                    frmAdminAnimales.cbo_TipoAnimal.SelectedIndex = 1
                Case 3
                    frmAdminAnimales.cbo_TipoAnimal.SelectedIndex = 2
                Case 4
                    frmAdminAnimales.cbo_TipoAnimal.SelectedIndex = 3
            End Select
            'Lugar del animal
            If rs("lugar_actual").Value.Equals("Establecimiento") Then
                frmAdminAnimales.cbo_LugarActual.SelectedIndex = 0
            Else
                frmAdminAnimales.cbo_LugarActual.SelectedIndex = 1
            End If
        End If
        rs.Close()
    End Sub

    'Procedimiento para verificar si existe animal
    Public Sub verificaranimal(ByVal nro_identificador As Integer)
        sql = "select * from animales where nro_identificador = " & Val(nro_identificador)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro animal
            MsgBox("Ese número está disponible.")
        Else 'Se encontro animal
            MsgBox("Ese número no está disponible para el animal. Por favor, ingrese un nuevo número.")
        End If
        rs.Close()
    End Sub

    'Procedimiento para cargar lote
    Public Sub buscarlote(ByVal numlote As String)
        sql = "select * from lotes where nro_lote = " & Val(numlote)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro lote
            If MsgBox("No se encontro lote. ¿Desea ingresar uno nuevo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                frmLotes.cmd_Buscar.Enabled = False
                frmLotes.panel_Lote.Enabled = True
                frmLotes.cmd_AgregarLote.Enabled = True
                frmLotes.cmd_ModificarLote.Enabled = False
                frmLotes.cmd_EliminarLote.Enabled = False
            Else 'Si no quiere ingresar nuevo lote
                MsgBox("Ingrese un numero de lote valido.")
            End If
        Else 'Se encontro lote
            frmLotes.panel_Lote.Enabled = True
            frmLotes.cmd_AgregarLote.Enabled = False
            frmLotes.cmd_ModificarLote.Enabled = True
            frmLotes.cmd_EliminarLote.Enabled = True
            frmLotes.txt_NumLote2.Text = rs("nro_lote").Value
            frmLotes.txt_Nombre.Text = rs("nombre").Value
            frmLotes.num_CantAnimales.Value = rs("cant_animales").Value
            frmLotes.cbo_Criterio.Text = rs("criterio").Value
        End If
        rs.Close()
    End Sub

    'Procedimiento para verificar si existe lote
    Public Sub verificarlote(ByVal numlote As Integer)
        sql = "select * from lotes where nro_lote = " & Val(numlote)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro lote
            MsgBox("Ese número está disponible.")
        Else 'Se encontro lote
            MsgBox("Ese número esta en uso. Por favor, ingrese un nuevo número.")
        End If
        rs.Close()
    End Sub

    'Procedimiento para cargar datos de un usuario
    Public Sub buscarusuario(ByVal cedula_usuario As String)
        '-----Buscar usuario-----
        sql = "select * from usuarios where ci = " & Val(cedula_usuario)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al efectuar operación")
            Exit Sub
        End Try
        If rs.RecordCount = 0 Then  'No se encontro usuario
            MsgBox("No se encontro el usuario. Verifique su cédula.")
        Else 'Se encontro usuario
            'Cargo los datos
            frmUsuarios.panel_Usuario.Enabled = True
            frmUsuarios.cmd_Modificar.Enabled = True
            frmUsuarios.txt_Nombre.Text = rs("nombre").Value
            frmUsuarios.txt_Apellido.Text = rs("apellido").Value
            frmUsuarios.txt_Cedula2.Text = rs("ci").Value
            frmUsuarios.txt_Dirección.Text = rs("direccion").Value
            frmUsuarios.txt_NomUsu.Text = rs("nombre_usu").Value
            frmUsuarios.cbo_Departamentos.Text = rs("departamento").Value
            Select Case rs("id").Value 'Rol del usuario
                Case 1
                    frmUsuarios.cbo_TipoUsuario.SelectedIndex = 0
                Case 2
                    frmUsuarios.cbo_TipoUsuario.SelectedIndex = 1
                Case 3
                    frmUsuarios.cbo_TipoUsuario.SelectedIndex = 2
                Case 4
                    frmUsuarios.cbo_TipoUsuario.SelectedIndex = 3
            End Select

        End If
        rs.Close()

        '-----Buscar telefonos del usuario-----
        sql = "select telefono from telefonos_usuario where ci = " & Val(cedula_usuario)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al obtener telefonos")
            Exit Sub
        End Try
        frmUsuarios.cbo_Telefonos.Items.Clear()
        While Not rs.EOF
            frmUsuarios.cbo_Telefonos.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    'PROCEDIMIENTO PARA CARGAR ANIMALES EN DATAGRID! (Pendiente)

    'PROCEDIMIENTO PARA CARGAR EVENTOS EN DATAGRID! (Pendiente)

End Module
