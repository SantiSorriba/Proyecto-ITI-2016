<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstablecimientos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_SeleccionarEstablecimiento = New System.Windows.Forms.Label()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.group_Establecimiento = New System.Windows.Forms.GroupBox()
        Me.cmd_BorrarTelefono1 = New System.Windows.Forms.Button()
        Me.cmd_AgregarTelefono1 = New System.Windows.Forms.Button()
        Me.cbo_TelefonosEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.txt_LimiteAnimales = New System.Windows.Forms.TextBox()
        Me.txt_Superficie = New System.Windows.Forms.TextBox()
        Me.txt_NroBps = New System.Windows.Forms.TextBox()
        Me.txt_NroRut = New System.Windows.Forms.TextBox()
        Me.txt_NroDicose = New System.Windows.Forms.TextBox()
        Me.cbo_DptoEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.txt_DirEstablecimiento = New System.Windows.Forms.TextBox()
        Me.txt_NomEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lbl_TelefonosEstablecimiento = New System.Windows.Forms.Label()
        Me.lbl_Hectareas = New System.Windows.Forms.Label()
        Me.lbl_DirEstablecimiento = New System.Windows.Forms.Label()
        Me.lbl_NroBps = New System.Windows.Forms.Label()
        Me.lbl_NroRut = New System.Windows.Forms.Label()
        Me.lbl_NroDicose = New System.Windows.Forms.Label()
        Me.lbl_LimiteAnimales = New System.Windows.Forms.Label()
        Me.lbl_Superficie = New System.Windows.Forms.Label()
        Me.lbl_DptoEstablecimiento = New System.Windows.Forms.Label()
        Me.lbl_NombreEstablecimiento = New System.Windows.Forms.Label()
        Me.group_Propietario = New System.Windows.Forms.GroupBox()
        Me.cmd_BorrarTelefono2 = New System.Windows.Forms.Button()
        Me.cmd_AgregarTelefono2 = New System.Windows.Forms.Button()
        Me.cbo_TelefonosPropietario = New System.Windows.Forms.ComboBox()
        Me.cbo_DptoPropietario = New System.Windows.Forms.ComboBox()
        Me.txt_DirPropietario = New System.Windows.Forms.TextBox()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.txt_ApellidoPropietario = New System.Windows.Forms.TextBox()
        Me.txt_NombrePropietario = New System.Windows.Forms.TextBox()
        Me.lbl_TelefonosPropietario = New System.Windows.Forms.Label()
        Me.lbl_DirPropietario = New System.Windows.Forms.Label()
        Me.lbl_DptoPropietario = New System.Windows.Forms.Label()
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.lbl_NombrePropietario = New System.Windows.Forms.Label()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Parametros = New System.Windows.Forms.Button()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.group_Establecimiento.SuspendLayout()
        Me.group_Propietario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_SeleccionarEstablecimiento
        '
        Me.lbl_SeleccionarEstablecimiento.AutoSize = True
        Me.lbl_SeleccionarEstablecimiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SeleccionarEstablecimiento.Location = New System.Drawing.Point(12, 12)
        Me.lbl_SeleccionarEstablecimiento.Name = "lbl_SeleccionarEstablecimiento"
        Me.lbl_SeleccionarEstablecimiento.Size = New System.Drawing.Size(224, 18)
        Me.lbl_SeleccionarEstablecimiento.TabIndex = 0
        Me.lbl_SeleccionarEstablecimiento.Text = "Seleccione un establecimiento:"
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(242, 9)
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(246, 24)
        Me.cbo_Establecimientos.TabIndex = 1
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Buscar.Location = New System.Drawing.Point(494, 8)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(83, 24)
        Me.cmd_Buscar.TabIndex = 2
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'group_Establecimiento
        '
        Me.group_Establecimiento.Controls.Add(Me.cmd_BorrarTelefono1)
        Me.group_Establecimiento.Controls.Add(Me.cmd_AgregarTelefono1)
        Me.group_Establecimiento.Controls.Add(Me.cbo_TelefonosEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.txt_LimiteAnimales)
        Me.group_Establecimiento.Controls.Add(Me.txt_Superficie)
        Me.group_Establecimiento.Controls.Add(Me.txt_NroBps)
        Me.group_Establecimiento.Controls.Add(Me.txt_NroRut)
        Me.group_Establecimiento.Controls.Add(Me.txt_NroDicose)
        Me.group_Establecimiento.Controls.Add(Me.cbo_DptoEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.txt_DirEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.txt_NomEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_TelefonosEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_Hectareas)
        Me.group_Establecimiento.Controls.Add(Me.lbl_DirEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NroBps)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NroRut)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NroDicose)
        Me.group_Establecimiento.Controls.Add(Me.lbl_LimiteAnimales)
        Me.group_Establecimiento.Controls.Add(Me.lbl_Superficie)
        Me.group_Establecimiento.Controls.Add(Me.lbl_DptoEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NombreEstablecimiento)
        Me.group_Establecimiento.Enabled = False
        Me.group_Establecimiento.Location = New System.Drawing.Point(12, 43)
        Me.group_Establecimiento.Name = "group_Establecimiento"
        Me.group_Establecimiento.Size = New System.Drawing.Size(565, 166)
        Me.group_Establecimiento.TabIndex = 3
        Me.group_Establecimiento.TabStop = False
        Me.group_Establecimiento.Text = "ESTABLECIMIENTO"
        '
        'cmd_BorrarTelefono1
        '
        Me.cmd_BorrarTelefono1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_BorrarTelefono1.Location = New System.Drawing.Point(475, 133)
        Me.cmd_BorrarTelefono1.Name = "cmd_BorrarTelefono1"
        Me.cmd_BorrarTelefono1.Size = New System.Drawing.Size(75, 23)
        Me.cmd_BorrarTelefono1.TabIndex = 20
        Me.cmd_BorrarTelefono1.Text = "Borrar"
        Me.cmd_BorrarTelefono1.UseVisualStyleBackColor = True
        '
        'cmd_AgregarTelefono1
        '
        Me.cmd_AgregarTelefono1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarTelefono1.Location = New System.Drawing.Point(387, 133)
        Me.cmd_AgregarTelefono1.Name = "cmd_AgregarTelefono1"
        Me.cmd_AgregarTelefono1.Size = New System.Drawing.Size(75, 23)
        Me.cmd_AgregarTelefono1.TabIndex = 19
        Me.cmd_AgregarTelefono1.Text = "Agregar"
        Me.cmd_AgregarTelefono1.UseVisualStyleBackColor = True
        '
        'cbo_TelefonosEstablecimiento
        '
        Me.cbo_TelefonosEstablecimiento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TelefonosEstablecimiento.FormattingEnabled = True
        Me.cbo_TelefonosEstablecimiento.Location = New System.Drawing.Point(271, 134)
        Me.cbo_TelefonosEstablecimiento.Name = "cbo_TelefonosEstablecimiento"
        Me.cbo_TelefonosEstablecimiento.Size = New System.Drawing.Size(98, 23)
        Me.cbo_TelefonosEstablecimiento.TabIndex = 18
        '
        'txt_LimiteAnimales
        '
        Me.txt_LimiteAnimales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LimiteAnimales.Location = New System.Drawing.Point(133, 134)
        Me.txt_LimiteAnimales.Name = "txt_LimiteAnimales"
        Me.txt_LimiteAnimales.Size = New System.Drawing.Size(46, 22)
        Me.txt_LimiteAnimales.TabIndex = 17
        '
        'txt_Superficie
        '
        Me.txt_Superficie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Superficie.Location = New System.Drawing.Point(333, 106)
        Me.txt_Superficie.Name = "txt_Superficie"
        Me.txt_Superficie.Size = New System.Drawing.Size(58, 22)
        Me.txt_Superficie.TabIndex = 16
        '
        'txt_NroBps
        '
        Me.txt_NroBps.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroBps.Location = New System.Drawing.Point(118, 106)
        Me.txt_NroBps.Name = "txt_NroBps"
        Me.txt_NroBps.Size = New System.Drawing.Size(134, 22)
        Me.txt_NroBps.TabIndex = 15
        '
        'txt_NroRut
        '
        Me.txt_NroRut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroRut.Location = New System.Drawing.Point(389, 78)
        Me.txt_NroRut.Name = "txt_NroRut"
        Me.txt_NroRut.Size = New System.Drawing.Size(134, 22)
        Me.txt_NroRut.TabIndex = 14
        '
        'txt_NroDicose
        '
        Me.txt_NroDicose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroDicose.Location = New System.Drawing.Point(140, 78)
        Me.txt_NroDicose.Name = "txt_NroDicose"
        Me.txt_NroDicose.Size = New System.Drawing.Size(134, 22)
        Me.txt_NroDicose.TabIndex = 13
        '
        'cbo_DptoEstablecimiento
        '
        Me.cbo_DptoEstablecimiento.FormattingEnabled = True
        Me.cbo_DptoEstablecimiento.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cbo_DptoEstablecimiento.Location = New System.Drawing.Point(429, 50)
        Me.cbo_DptoEstablecimiento.MaxLength = 15
        Me.cbo_DptoEstablecimiento.Name = "cbo_DptoEstablecimiento"
        Me.cbo_DptoEstablecimiento.Size = New System.Drawing.Size(121, 21)
        Me.cbo_DptoEstablecimiento.TabIndex = 12
        '
        'txt_DirEstablecimiento
        '
        Me.txt_DirEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DirEstablecimiento.Location = New System.Drawing.Point(78, 50)
        Me.txt_DirEstablecimiento.Name = "txt_DirEstablecimiento"
        Me.txt_DirEstablecimiento.Size = New System.Drawing.Size(246, 22)
        Me.txt_DirEstablecimiento.TabIndex = 11
        '
        'txt_NomEstablecimiento
        '
        Me.txt_NomEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NomEstablecimiento.Location = New System.Drawing.Point(185, 24)
        Me.txt_NomEstablecimiento.Name = "txt_NomEstablecimiento"
        Me.txt_NomEstablecimiento.Size = New System.Drawing.Size(246, 22)
        Me.txt_NomEstablecimiento.TabIndex = 10
        '
        'lbl_TelefonosEstablecimiento
        '
        Me.lbl_TelefonosEstablecimiento.AutoSize = True
        Me.lbl_TelefonosEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TelefonosEstablecimiento.Location = New System.Drawing.Point(199, 137)
        Me.lbl_TelefonosEstablecimiento.Name = "lbl_TelefonosEstablecimiento"
        Me.lbl_TelefonosEstablecimiento.Size = New System.Drawing.Size(66, 16)
        Me.lbl_TelefonosEstablecimiento.TabIndex = 9
        Me.lbl_TelefonosEstablecimiento.Text = "Teléfonos:"
        '
        'lbl_Hectareas
        '
        Me.lbl_Hectareas.AutoSize = True
        Me.lbl_Hectareas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hectareas.Location = New System.Drawing.Point(397, 109)
        Me.lbl_Hectareas.Name = "lbl_Hectareas"
        Me.lbl_Hectareas.Size = New System.Drawing.Size(65, 16)
        Me.lbl_Hectareas.TabIndex = 8
        Me.lbl_Hectareas.Text = "hectáreas"
        '
        'lbl_DirEstablecimiento
        '
        Me.lbl_DirEstablecimiento.AutoSize = True
        Me.lbl_DirEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DirEstablecimiento.Location = New System.Drawing.Point(6, 53)
        Me.lbl_DirEstablecimiento.Name = "lbl_DirEstablecimiento"
        Me.lbl_DirEstablecimiento.Size = New System.Drawing.Size(66, 16)
        Me.lbl_DirEstablecimiento.TabIndex = 7
        Me.lbl_DirEstablecimiento.Text = "Dirección:"
        '
        'lbl_NroBps
        '
        Me.lbl_NroBps.AutoSize = True
        Me.lbl_NroBps.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroBps.Location = New System.Drawing.Point(6, 109)
        Me.lbl_NroBps.Name = "lbl_NroBps"
        Me.lbl_NroBps.Size = New System.Drawing.Size(106, 16)
        Me.lbl_NroBps.TabIndex = 6
        Me.lbl_NroBps.Text = "Número de BPS:"
        '
        'lbl_NroRut
        '
        Me.lbl_NroRut.AutoSize = True
        Me.lbl_NroRut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroRut.Location = New System.Drawing.Point(280, 81)
        Me.lbl_NroRut.Name = "lbl_NroRut"
        Me.lbl_NroRut.Size = New System.Drawing.Size(103, 16)
        Me.lbl_NroRut.TabIndex = 5
        Me.lbl_NroRut.Text = "Número de RUT:"
        '
        'lbl_NroDicose
        '
        Me.lbl_NroDicose.AutoSize = True
        Me.lbl_NroDicose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroDicose.Location = New System.Drawing.Point(6, 81)
        Me.lbl_NroDicose.Name = "lbl_NroDicose"
        Me.lbl_NroDicose.Size = New System.Drawing.Size(128, 16)
        Me.lbl_NroDicose.TabIndex = 4
        Me.lbl_NroDicose.Text = "Número de DICOSE:"
        '
        'lbl_LimiteAnimales
        '
        Me.lbl_LimiteAnimales.AutoSize = True
        Me.lbl_LimiteAnimales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LimiteAnimales.Location = New System.Drawing.Point(6, 137)
        Me.lbl_LimiteAnimales.Name = "lbl_LimiteAnimales"
        Me.lbl_LimiteAnimales.Size = New System.Drawing.Size(121, 16)
        Me.lbl_LimiteAnimales.TabIndex = 3
        Me.lbl_LimiteAnimales.Text = "Limite de animales:"
        '
        'lbl_Superficie
        '
        Me.lbl_Superficie.AutoSize = True
        Me.lbl_Superficie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Superficie.Location = New System.Drawing.Point(258, 109)
        Me.lbl_Superficie.Name = "lbl_Superficie"
        Me.lbl_Superficie.Size = New System.Drawing.Size(69, 16)
        Me.lbl_Superficie.TabIndex = 2
        Me.lbl_Superficie.Text = "Superficie:"
        '
        'lbl_DptoEstablecimiento
        '
        Me.lbl_DptoEstablecimiento.AutoSize = True
        Me.lbl_DptoEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DptoEstablecimiento.Location = New System.Drawing.Point(330, 53)
        Me.lbl_DptoEstablecimiento.Name = "lbl_DptoEstablecimiento"
        Me.lbl_DptoEstablecimiento.Size = New System.Drawing.Size(93, 16)
        Me.lbl_DptoEstablecimiento.TabIndex = 1
        Me.lbl_DptoEstablecimiento.Text = "Departamento:"
        '
        'lbl_NombreEstablecimiento
        '
        Me.lbl_NombreEstablecimiento.AutoSize = True
        Me.lbl_NombreEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreEstablecimiento.Location = New System.Drawing.Point(6, 27)
        Me.lbl_NombreEstablecimiento.Name = "lbl_NombreEstablecimiento"
        Me.lbl_NombreEstablecimiento.Size = New System.Drawing.Size(173, 16)
        Me.lbl_NombreEstablecimiento.TabIndex = 0
        Me.lbl_NombreEstablecimiento.Text = "Nombre del establecimiento:"
        '
        'group_Propietario
        '
        Me.group_Propietario.Controls.Add(Me.cmd_BorrarTelefono2)
        Me.group_Propietario.Controls.Add(Me.cmd_AgregarTelefono2)
        Me.group_Propietario.Controls.Add(Me.cbo_TelefonosPropietario)
        Me.group_Propietario.Controls.Add(Me.cbo_DptoPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_DirPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_Cedula)
        Me.group_Propietario.Controls.Add(Me.txt_ApellidoPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_NombrePropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_TelefonosPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_DirPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_DptoPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_Cedula)
        Me.group_Propietario.Controls.Add(Me.lbl_Apellido)
        Me.group_Propietario.Controls.Add(Me.lbl_NombrePropietario)
        Me.group_Propietario.Enabled = False
        Me.group_Propietario.Location = New System.Drawing.Point(12, 228)
        Me.group_Propietario.Name = "group_Propietario"
        Me.group_Propietario.Size = New System.Drawing.Size(565, 117)
        Me.group_Propietario.TabIndex = 4
        Me.group_Propietario.TabStop = False
        Me.group_Propietario.Text = "PROPIETARIO"
        '
        'cmd_BorrarTelefono2
        '
        Me.cmd_BorrarTelefono2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_BorrarTelefono2.Location = New System.Drawing.Point(482, 81)
        Me.cmd_BorrarTelefono2.Name = "cmd_BorrarTelefono2"
        Me.cmd_BorrarTelefono2.Size = New System.Drawing.Size(75, 23)
        Me.cmd_BorrarTelefono2.TabIndex = 22
        Me.cmd_BorrarTelefono2.Text = "Borrar"
        Me.cmd_BorrarTelefono2.UseVisualStyleBackColor = True
        '
        'cmd_AgregarTelefono2
        '
        Me.cmd_AgregarTelefono2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarTelefono2.Location = New System.Drawing.Point(403, 81)
        Me.cmd_AgregarTelefono2.Name = "cmd_AgregarTelefono2"
        Me.cmd_AgregarTelefono2.Size = New System.Drawing.Size(75, 23)
        Me.cmd_AgregarTelefono2.TabIndex = 21
        Me.cmd_AgregarTelefono2.Text = "Agregar"
        Me.cmd_AgregarTelefono2.UseVisualStyleBackColor = True
        '
        'cbo_TelefonosPropietario
        '
        Me.cbo_TelefonosPropietario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TelefonosPropietario.FormattingEnabled = True
        Me.cbo_TelefonosPropietario.Location = New System.Drawing.Point(299, 82)
        Me.cbo_TelefonosPropietario.Name = "cbo_TelefonosPropietario"
        Me.cbo_TelefonosPropietario.Size = New System.Drawing.Size(98, 23)
        Me.cbo_TelefonosPropietario.TabIndex = 19
        '
        'cbo_DptoPropietario
        '
        Me.cbo_DptoPropietario.FormattingEnabled = True
        Me.cbo_DptoPropietario.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cbo_DptoPropietario.Location = New System.Drawing.Point(103, 81)
        Me.cbo_DptoPropietario.MaxLength = 15
        Me.cbo_DptoPropietario.Name = "cbo_DptoPropietario"
        Me.cbo_DptoPropietario.Size = New System.Drawing.Size(121, 21)
        Me.cbo_DptoPropietario.TabIndex = 13
        '
        'txt_DirPropietario
        '
        Me.txt_DirPropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DirPropietario.Location = New System.Drawing.Point(299, 54)
        Me.txt_DirPropietario.Name = "txt_DirPropietario"
        Me.txt_DirPropietario.Size = New System.Drawing.Size(246, 22)
        Me.txt_DirPropietario.TabIndex = 12
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cedula.Location = New System.Drawing.Point(140, 53)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(73, 22)
        Me.txt_Cedula.TabIndex = 8
        '
        'txt_ApellidoPropietario
        '
        Me.txt_ApellidoPropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ApellidoPropietario.Location = New System.Drawing.Point(291, 26)
        Me.txt_ApellidoPropietario.Name = "txt_ApellidoPropietario"
        Me.txt_ApellidoPropietario.Size = New System.Drawing.Size(144, 22)
        Me.txt_ApellidoPropietario.TabIndex = 7
        '
        'txt_NombrePropietario
        '
        Me.txt_NombrePropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombrePropietario.Location = New System.Drawing.Point(69, 25)
        Me.txt_NombrePropietario.Name = "txt_NombrePropietario"
        Me.txt_NombrePropietario.Size = New System.Drawing.Size(144, 22)
        Me.txt_NombrePropietario.TabIndex = 6
        '
        'lbl_TelefonosPropietario
        '
        Me.lbl_TelefonosPropietario.AutoSize = True
        Me.lbl_TelefonosPropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TelefonosPropietario.Location = New System.Drawing.Point(227, 86)
        Me.lbl_TelefonosPropietario.Name = "lbl_TelefonosPropietario"
        Me.lbl_TelefonosPropietario.Size = New System.Drawing.Size(66, 16)
        Me.lbl_TelefonosPropietario.TabIndex = 5
        Me.lbl_TelefonosPropietario.Text = "Teléfonos:"
        '
        'lbl_DirPropietario
        '
        Me.lbl_DirPropietario.AutoSize = True
        Me.lbl_DirPropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DirPropietario.Location = New System.Drawing.Point(227, 57)
        Me.lbl_DirPropietario.Name = "lbl_DirPropietario"
        Me.lbl_DirPropietario.Size = New System.Drawing.Size(66, 16)
        Me.lbl_DirPropietario.TabIndex = 4
        Me.lbl_DirPropietario.Text = "Dirección:"
        '
        'lbl_DptoPropietario
        '
        Me.lbl_DptoPropietario.AutoSize = True
        Me.lbl_DptoPropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DptoPropietario.Location = New System.Drawing.Point(6, 83)
        Me.lbl_DptoPropietario.Name = "lbl_DptoPropietario"
        Me.lbl_DptoPropietario.Size = New System.Drawing.Size(93, 16)
        Me.lbl_DptoPropietario.TabIndex = 3
        Me.lbl_DptoPropietario.Text = "Departamento:"
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cedula.Location = New System.Drawing.Point(6, 56)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(126, 16)
        Me.lbl_Cedula.TabIndex = 2
        Me.lbl_Cedula.Text = "Cédula de Identidad:"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(227, 28)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(58, 16)
        Me.lbl_Apellido.TabIndex = 1
        Me.lbl_Apellido.Text = "Apellido:"
        '
        'lbl_NombrePropietario
        '
        Me.lbl_NombrePropietario.AutoSize = True
        Me.lbl_NombrePropietario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombrePropietario.Location = New System.Drawing.Point(6, 26)
        Me.lbl_NombrePropietario.Name = "lbl_NombrePropietario"
        Me.lbl_NombrePropietario.Size = New System.Drawing.Size(57, 16)
        Me.lbl_NombrePropietario.TabIndex = 0
        Me.lbl_NombrePropietario.Text = "Nombre:"
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Enabled = False
        Me.cmd_Agregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Agregar.Location = New System.Drawing.Point(12, 360)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(99, 28)
        Me.cmd_Agregar.TabIndex = 5
        Me.cmd_Agregar.Text = "Agregar "
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Enabled = False
        Me.cmd_Modificar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Modificar.Location = New System.Drawing.Point(115, 360)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(104, 28)
        Me.cmd_Modificar.TabIndex = 6
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancelar.Location = New System.Drawing.Point(460, 360)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(117, 28)
        Me.cmd_Cancelar.TabIndex = 8
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Parametros
        '
        Me.cmd_Parametros.Enabled = False
        Me.cmd_Parametros.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Parametros.Location = New System.Drawing.Point(343, 360)
        Me.cmd_Parametros.Name = "cmd_Parametros"
        Me.cmd_Parametros.Size = New System.Drawing.Size(111, 28)
        Me.cmd_Parametros.TabIndex = 7
        Me.cmd_Parametros.Text = "Parámetros"
        Me.cmd_Parametros.UseVisualStyleBackColor = True
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Enabled = False
        Me.cmd_Eliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Eliminar.Location = New System.Drawing.Point(225, 360)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(112, 28)
        Me.cmd_Eliminar.TabIndex = 9
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'frmEstablecimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(589, 399)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.cmd_Parametros)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.group_Propietario)
        Me.Controls.Add(Me.group_Establecimiento)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.lbl_SeleccionarEstablecimiento)
        Me.MaximizeBox = False
        Me.Name = "frmEstablecimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de establecimientos"
        Me.group_Establecimiento.ResumeLayout(False)
        Me.group_Establecimiento.PerformLayout()
        Me.group_Propietario.ResumeLayout(False)
        Me.group_Propietario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_SeleccionarEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents group_Establecimiento As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_NroDicose As System.Windows.Forms.Label
    Friend WithEvents lbl_LimiteAnimales As System.Windows.Forms.Label
    Friend WithEvents lbl_Superficie As System.Windows.Forms.Label
    Friend WithEvents lbl_DptoEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cmd_BorrarTelefono1 As System.Windows.Forms.Button
    Friend WithEvents cmd_AgregarTelefono1 As System.Windows.Forms.Button
    Friend WithEvents cbo_TelefonosEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_LimiteAnimales As System.Windows.Forms.TextBox
    Friend WithEvents txt_Superficie As System.Windows.Forms.TextBox
    Friend WithEvents txt_NroBps As System.Windows.Forms.TextBox
    Friend WithEvents txt_NroRut As System.Windows.Forms.TextBox
    Friend WithEvents txt_NroDicose As System.Windows.Forms.TextBox
    Friend WithEvents cbo_DptoEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_DirEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents txt_NomEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TelefonosEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_Hectareas As System.Windows.Forms.Label
    Friend WithEvents lbl_DirEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_NroBps As System.Windows.Forms.Label
    Friend WithEvents lbl_NroRut As System.Windows.Forms.Label
    Friend WithEvents group_Propietario As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_BorrarTelefono2 As System.Windows.Forms.Button
    Friend WithEvents cmd_AgregarTelefono2 As System.Windows.Forms.Button
    Friend WithEvents cbo_TelefonosPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_DptoPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents txt_DirPropietario As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cedula As System.Windows.Forms.TextBox
    Friend WithEvents txt_ApellidoPropietario As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombrePropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TelefonosPropietario As System.Windows.Forms.Label
    Friend WithEvents lbl_DirPropietario As System.Windows.Forms.Label
    Friend WithEvents lbl_DptoPropietario As System.Windows.Forms.Label
    Friend WithEvents lbl_Cedula As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_NombrePropietario As System.Windows.Forms.Label
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Parametros As System.Windows.Forms.Button
    Friend WithEvents cmd_Eliminar As System.Windows.Forms.Button
End Class
