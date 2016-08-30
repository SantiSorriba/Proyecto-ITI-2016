<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmEstablecimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmEstablecimientos))
        Me.lbl_SeleccionarEstablecimiento = New System.Windows.Forms.Label()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.group_Establecimiento = New System.Windows.Forms.GroupBox()
        Me.txt_LimiteAnimales = New System.Windows.Forms.TextBox()
        Me.lbl_LimiteAnimales = New System.Windows.Forms.Label()
        Me.lbl_Hectareas = New System.Windows.Forms.Label()
        Me.txt_Superficie = New System.Windows.Forms.TextBox()
        Me.lbl_Superficie = New System.Windows.Forms.Label()
        Me.txt_NroBps = New System.Windows.Forms.TextBox()
        Me.lbl_NroBps = New System.Windows.Forms.Label()
        Me.txt_NroRut = New System.Windows.Forms.TextBox()
        Me.lbl_NroRut = New System.Windows.Forms.Label()
        Me.txt_NroDicose = New System.Windows.Forms.TextBox()
        Me.lbl_NroDicose = New System.Windows.Forms.Label()
        Me.cmd_EliminarTel1 = New System.Windows.Forms.Button()
        Me.cmd_AgregarTel1 = New System.Windows.Forms.Button()
        Me.cbo_TelEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.lbl_TelEstablecimiento = New System.Windows.Forms.Label()
        Me.txt_DirEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lbl_DirEstablecimiento = New System.Windows.Forms.Label()
        Me.cbo_DptoEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.lbl_DptoEstablecimiento = New System.Windows.Forms.Label()
        Me.txt_NombreEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lbl_NombreEstablecimiento = New System.Windows.Forms.Label()
        Me.group_Propietario = New System.Windows.Forms.GroupBox()
        Me.cmd_EliminarTel2 = New System.Windows.Forms.Button()
        Me.cmd_AgregarTel2 = New System.Windows.Forms.Button()
        Me.cbo_TelPropietario = New System.Windows.Forms.ComboBox()
        Me.lbl_TelPropietario = New System.Windows.Forms.Label()
        Me.cbo_DptoPropietario = New System.Windows.Forms.ComboBox()
        Me.lbl_DptoPropietario = New System.Windows.Forms.Label()
        Me.txt_DirPropietario = New System.Windows.Forms.TextBox()
        Me.lbl_DirPropietario = New System.Windows.Forms.Label()
        Me.txt_CedulaPropietario = New System.Windows.Forms.TextBox()
        Me.lbl_CedulaPropietario = New System.Windows.Forms.Label()
        Me.txt_ApellidoPropietario = New System.Windows.Forms.TextBox()
        Me.lbl_ApellidoPropietario = New System.Windows.Forms.Label()
        Me.txt_NombrePropietario = New System.Windows.Forms.TextBox()
        Me.lbl_NombrePropietario = New System.Windows.Forms.Label()
        Me.cmd_AgregarEstablecimiento = New System.Windows.Forms.Button()
        Me.cmd_ModificarEstablecimiento = New System.Windows.Forms.Button()
        Me.cmd_EliminarEstablecimiento = New System.Windows.Forms.Button()
        Me.cmd_Parametros = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.group_Establecimiento.SuspendLayout()
        Me.group_Propietario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_SeleccionarEstablecimiento
        '
        Me.lbl_SeleccionarEstablecimiento.AutoSize = True
        Me.lbl_SeleccionarEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SeleccionarEstablecimiento.Location = New System.Drawing.Point(12, 12)
        Me.lbl_SeleccionarEstablecimiento.Name = "lbl_SeleccionarEstablecimiento"
        Me.lbl_SeleccionarEstablecimiento.Size = New System.Drawing.Size(241, 20)
        Me.lbl_SeleccionarEstablecimiento.TabIndex = 0
        Me.lbl_SeleccionarEstablecimiento.Text = "Seleccione un establecimiento:"
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(259, 9)
        Me.cbo_Establecimientos.MaxDropDownItems = 10
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(341, 28)
        Me.cbo_Establecimientos.TabIndex = 1
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Buscar.Location = New System.Drawing.Point(606, 8)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(97, 29)
        Me.cmd_Buscar.TabIndex = 2
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'group_Establecimiento
        '
        Me.group_Establecimiento.Controls.Add(Me.txt_LimiteAnimales)
        Me.group_Establecimiento.Controls.Add(Me.lbl_LimiteAnimales)
        Me.group_Establecimiento.Controls.Add(Me.lbl_Hectareas)
        Me.group_Establecimiento.Controls.Add(Me.txt_Superficie)
        Me.group_Establecimiento.Controls.Add(Me.lbl_Superficie)
        Me.group_Establecimiento.Controls.Add(Me.txt_NroBps)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NroBps)
        Me.group_Establecimiento.Controls.Add(Me.txt_NroRut)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NroRut)
        Me.group_Establecimiento.Controls.Add(Me.txt_NroDicose)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NroDicose)
        Me.group_Establecimiento.Controls.Add(Me.cmd_EliminarTel1)
        Me.group_Establecimiento.Controls.Add(Me.cmd_AgregarTel1)
        Me.group_Establecimiento.Controls.Add(Me.cbo_TelEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_TelEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.txt_DirEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_DirEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.cbo_DptoEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_DptoEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.txt_NombreEstablecimiento)
        Me.group_Establecimiento.Controls.Add(Me.lbl_NombreEstablecimiento)
        Me.group_Establecimiento.Enabled = False
        Me.group_Establecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Establecimiento.Location = New System.Drawing.Point(12, 57)
        Me.group_Establecimiento.Name = "group_Establecimiento"
        Me.group_Establecimiento.Size = New System.Drawing.Size(693, 152)
        Me.group_Establecimiento.TabIndex = 6
        Me.group_Establecimiento.TabStop = False
        Me.group_Establecimiento.Text = "Datos del establecimiento"
        '
        'txt_LimiteAnimales
        '
        Me.txt_LimiteAnimales.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LimiteAnimales.Location = New System.Drawing.Point(136, 120)
        Me.txt_LimiteAnimales.Name = "txt_LimiteAnimales"
        Me.txt_LimiteAnimales.Size = New System.Drawing.Size(64, 24)
        Me.txt_LimiteAnimales.TabIndex = 24
        '
        'lbl_LimiteAnimales
        '
        Me.lbl_LimiteAnimales.AutoSize = True
        Me.lbl_LimiteAnimales.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LimiteAnimales.Location = New System.Drawing.Point(6, 123)
        Me.lbl_LimiteAnimales.Name = "lbl_LimiteAnimales"
        Me.lbl_LimiteAnimales.Size = New System.Drawing.Size(124, 17)
        Me.lbl_LimiteAnimales.TabIndex = 23
        Me.lbl_LimiteAnimales.Text = "Límite de Animales:"
        '
        'lbl_Hectareas
        '
        Me.lbl_Hectareas.AutoSize = True
        Me.lbl_Hectareas.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hectareas.Location = New System.Drawing.Point(379, 123)
        Me.lbl_Hectareas.Name = "lbl_Hectareas"
        Me.lbl_Hectareas.Size = New System.Drawing.Size(66, 17)
        Me.lbl_Hectareas.TabIndex = 27
        Me.lbl_Hectareas.Text = "hectáreas"
        '
        'txt_Superficie
        '
        Me.txt_Superficie.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Superficie.Location = New System.Drawing.Point(309, 120)
        Me.txt_Superficie.Name = "txt_Superficie"
        Me.txt_Superficie.Size = New System.Drawing.Size(64, 24)
        Me.txt_Superficie.TabIndex = 26
        '
        'lbl_Superficie
        '
        Me.lbl_Superficie.AutoSize = True
        Me.lbl_Superficie.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Superficie.Location = New System.Drawing.Point(234, 123)
        Me.lbl_Superficie.Name = "lbl_Superficie"
        Me.lbl_Superficie.Size = New System.Drawing.Size(69, 17)
        Me.lbl_Superficie.TabIndex = 25
        Me.lbl_Superficie.Text = "Superficie:"
        '
        'txt_NroBps
        '
        Me.txt_NroBps.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroBps.Location = New System.Drawing.Point(579, 92)
        Me.txt_NroBps.Name = "txt_NroBps"
        Me.txt_NroBps.Size = New System.Drawing.Size(108, 24)
        Me.txt_NroBps.TabIndex = 22
        '
        'lbl_NroBps
        '
        Me.lbl_NroBps.AutoSize = True
        Me.lbl_NroBps.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroBps.Location = New System.Drawing.Point(471, 95)
        Me.lbl_NroBps.Name = "lbl_NroBps"
        Me.lbl_NroBps.Size = New System.Drawing.Size(105, 17)
        Me.lbl_NroBps.TabIndex = 21
        Me.lbl_NroBps.Text = "Número de BPS:"
        '
        'txt_NroRut
        '
        Me.txt_NroRut.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroRut.Location = New System.Drawing.Point(361, 91)
        Me.txt_NroRut.Name = "txt_NroRut"
        Me.txt_NroRut.Size = New System.Drawing.Size(108, 24)
        Me.txt_NroRut.TabIndex = 20
        '
        'lbl_NroRut
        '
        Me.lbl_NroRut.AutoSize = True
        Me.lbl_NroRut.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroRut.Location = New System.Drawing.Point(250, 94)
        Me.lbl_NroRut.Name = "lbl_NroRut"
        Me.lbl_NroRut.Size = New System.Drawing.Size(107, 17)
        Me.lbl_NroRut.TabIndex = 19
        Me.lbl_NroRut.Text = "Número de RUT:"
        '
        'txt_NroDicose
        '
        Me.txt_NroDicose.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroDicose.Location = New System.Drawing.Point(139, 90)
        Me.txt_NroDicose.Name = "txt_NroDicose"
        Me.txt_NroDicose.Size = New System.Drawing.Size(108, 24)
        Me.txt_NroDicose.TabIndex = 18
        '
        'lbl_NroDicose
        '
        Me.lbl_NroDicose.AutoSize = True
        Me.lbl_NroDicose.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroDicose.Location = New System.Drawing.Point(5, 93)
        Me.lbl_NroDicose.Name = "lbl_NroDicose"
        Me.lbl_NroDicose.Size = New System.Drawing.Size(130, 17)
        Me.lbl_NroDicose.TabIndex = 17
        Me.lbl_NroDicose.Text = "Número de DICOSE:"
        '
        'cmd_EliminarTel1
        '
        Me.cmd_EliminarTel1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EliminarTel1.Location = New System.Drawing.Point(600, 60)
        Me.cmd_EliminarTel1.Name = "cmd_EliminarTel1"
        Me.cmd_EliminarTel1.Size = New System.Drawing.Size(66, 25)
        Me.cmd_EliminarTel1.TabIndex = 16
        Me.cmd_EliminarTel1.Text = "Eliminar"
        Me.cmd_EliminarTel1.UseVisualStyleBackColor = True
        '
        'cmd_AgregarTel1
        '
        Me.cmd_AgregarTel1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarTel1.Location = New System.Drawing.Point(526, 60)
        Me.cmd_AgregarTel1.Name = "cmd_AgregarTel1"
        Me.cmd_AgregarTel1.Size = New System.Drawing.Size(66, 25)
        Me.cmd_AgregarTel1.TabIndex = 15
        Me.cmd_AgregarTel1.Text = "Agregar"
        Me.cmd_AgregarTel1.UseVisualStyleBackColor = True
        '
        'cbo_TelEstablecimiento
        '
        Me.cbo_TelEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TelEstablecimiento.FormattingEnabled = True
        Me.cbo_TelEstablecimiento.Location = New System.Drawing.Point(408, 60)
        Me.cbo_TelEstablecimiento.Name = "cbo_TelEstablecimiento"
        Me.cbo_TelEstablecimiento.Size = New System.Drawing.Size(109, 25)
        Me.cbo_TelEstablecimiento.TabIndex = 14
        '
        'lbl_TelEstablecimiento
        '
        Me.lbl_TelEstablecimiento.AutoSize = True
        Me.lbl_TelEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TelEstablecimiento.Location = New System.Drawing.Point(333, 63)
        Me.lbl_TelEstablecimiento.Name = "lbl_TelEstablecimiento"
        Me.lbl_TelEstablecimiento.Size = New System.Drawing.Size(69, 17)
        Me.lbl_TelEstablecimiento.TabIndex = 13
        Me.lbl_TelEstablecimiento.Text = "Teléfonos:"
        '
        'txt_DirEstablecimiento
        '
        Me.txt_DirEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DirEstablecimiento.Location = New System.Drawing.Point(79, 60)
        Me.txt_DirEstablecimiento.Name = "txt_DirEstablecimiento"
        Me.txt_DirEstablecimiento.Size = New System.Drawing.Size(248, 24)
        Me.txt_DirEstablecimiento.TabIndex = 12
        '
        'lbl_DirEstablecimiento
        '
        Me.lbl_DirEstablecimiento.AutoSize = True
        Me.lbl_DirEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DirEstablecimiento.Location = New System.Drawing.Point(6, 63)
        Me.lbl_DirEstablecimiento.Name = "lbl_DirEstablecimiento"
        Me.lbl_DirEstablecimiento.Size = New System.Drawing.Size(67, 17)
        Me.lbl_DirEstablecimiento.TabIndex = 11
        Me.lbl_DirEstablecimiento.Text = "Dirección:"
        '
        'cbo_DptoEstablecimiento
        '
        Me.cbo_DptoEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_DptoEstablecimiento.FormattingEnabled = True
        Me.cbo_DptoEstablecimiento.Location = New System.Drawing.Point(552, 29)
        Me.cbo_DptoEstablecimiento.Name = "cbo_DptoEstablecimiento"
        Me.cbo_DptoEstablecimiento.Size = New System.Drawing.Size(133, 25)
        Me.cbo_DptoEstablecimiento.TabIndex = 10
        '
        'lbl_DptoEstablecimiento
        '
        Me.lbl_DptoEstablecimiento.AutoSize = True
        Me.lbl_DptoEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DptoEstablecimiento.Location = New System.Drawing.Point(446, 33)
        Me.lbl_DptoEstablecimiento.Name = "lbl_DptoEstablecimiento"
        Me.lbl_DptoEstablecimiento.Size = New System.Drawing.Size(100, 17)
        Me.lbl_DptoEstablecimiento.TabIndex = 9
        Me.lbl_DptoEstablecimiento.Text = "Departamento:"
        '
        'txt_NombreEstablecimiento
        '
        Me.txt_NombreEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreEstablecimiento.Location = New System.Drawing.Point(192, 30)
        Me.txt_NombreEstablecimiento.Name = "txt_NombreEstablecimiento"
        Me.txt_NombreEstablecimiento.Size = New System.Drawing.Size(248, 24)
        Me.txt_NombreEstablecimiento.TabIndex = 8
        '
        'lbl_NombreEstablecimiento
        '
        Me.lbl_NombreEstablecimiento.AutoSize = True
        Me.lbl_NombreEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreEstablecimiento.Location = New System.Drawing.Point(6, 33)
        Me.lbl_NombreEstablecimiento.Name = "lbl_NombreEstablecimiento"
        Me.lbl_NombreEstablecimiento.Size = New System.Drawing.Size(180, 17)
        Me.lbl_NombreEstablecimiento.TabIndex = 7
        Me.lbl_NombreEstablecimiento.Text = "Nombre del establecimiento:"
        '
        'group_Propietario
        '
        Me.group_Propietario.Controls.Add(Me.cmd_EliminarTel2)
        Me.group_Propietario.Controls.Add(Me.cmd_AgregarTel2)
        Me.group_Propietario.Controls.Add(Me.cbo_TelPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_TelPropietario)
        Me.group_Propietario.Controls.Add(Me.cbo_DptoPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_DptoPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_DirPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_DirPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_CedulaPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_CedulaPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_ApellidoPropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_ApellidoPropietario)
        Me.group_Propietario.Controls.Add(Me.txt_NombrePropietario)
        Me.group_Propietario.Controls.Add(Me.lbl_NombrePropietario)
        Me.group_Propietario.Enabled = False
        Me.group_Propietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Propietario.Location = New System.Drawing.Point(12, 223)
        Me.group_Propietario.Name = "group_Propietario"
        Me.group_Propietario.Size = New System.Drawing.Size(693, 128)
        Me.group_Propietario.TabIndex = 25
        Me.group_Propietario.TabStop = False
        Me.group_Propietario.Text = "Datos del propietario"
        '
        'cmd_EliminarTel2
        '
        Me.cmd_EliminarTel2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EliminarTel2.Location = New System.Drawing.Point(595, 90)
        Me.cmd_EliminarTel2.Name = "cmd_EliminarTel2"
        Me.cmd_EliminarTel2.Size = New System.Drawing.Size(66, 25)
        Me.cmd_EliminarTel2.TabIndex = 39
        Me.cmd_EliminarTel2.Text = "Eliminar"
        Me.cmd_EliminarTel2.UseVisualStyleBackColor = True
        '
        'cmd_AgregarTel2
        '
        Me.cmd_AgregarTel2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarTel2.Location = New System.Drawing.Point(523, 90)
        Me.cmd_AgregarTel2.Name = "cmd_AgregarTel2"
        Me.cmd_AgregarTel2.Size = New System.Drawing.Size(66, 25)
        Me.cmd_AgregarTel2.TabIndex = 38
        Me.cmd_AgregarTel2.Text = "Agregar"
        Me.cmd_AgregarTel2.UseVisualStyleBackColor = True
        '
        'cbo_TelPropietario
        '
        Me.cbo_TelPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TelPropietario.FormattingEnabled = True
        Me.cbo_TelPropietario.Location = New System.Drawing.Point(408, 90)
        Me.cbo_TelPropietario.Name = "cbo_TelPropietario"
        Me.cbo_TelPropietario.Size = New System.Drawing.Size(109, 25)
        Me.cbo_TelPropietario.TabIndex = 37
        '
        'lbl_TelPropietario
        '
        Me.lbl_TelPropietario.AutoSize = True
        Me.lbl_TelPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TelPropietario.Location = New System.Drawing.Point(333, 94)
        Me.lbl_TelPropietario.Name = "lbl_TelPropietario"
        Me.lbl_TelPropietario.Size = New System.Drawing.Size(69, 17)
        Me.lbl_TelPropietario.TabIndex = 36
        Me.lbl_TelPropietario.Text = "Teléfonos:"
        '
        'cbo_DptoPropietario
        '
        Me.cbo_DptoPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_DptoPropietario.FormattingEnabled = True
        Me.cbo_DptoPropietario.Location = New System.Drawing.Point(193, 90)
        Me.cbo_DptoPropietario.Name = "cbo_DptoPropietario"
        Me.cbo_DptoPropietario.Size = New System.Drawing.Size(133, 25)
        Me.cbo_DptoPropietario.TabIndex = 35
        '
        'lbl_DptoPropietario
        '
        Me.lbl_DptoPropietario.AutoSize = True
        Me.lbl_DptoPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DptoPropietario.Location = New System.Drawing.Point(6, 93)
        Me.lbl_DptoPropietario.Name = "lbl_DptoPropietario"
        Me.lbl_DptoPropietario.Size = New System.Drawing.Size(181, 17)
        Me.lbl_DptoPropietario.TabIndex = 34
        Me.lbl_DptoPropietario.Text = "Departamento de residencia:"
        '
        'txt_DirPropietario
        '
        Me.txt_DirPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DirPropietario.Location = New System.Drawing.Point(415, 60)
        Me.txt_DirPropietario.Name = "txt_DirPropietario"
        Me.txt_DirPropietario.Size = New System.Drawing.Size(248, 24)
        Me.txt_DirPropietario.TabIndex = 33
        '
        'lbl_DirPropietario
        '
        Me.lbl_DirPropietario.AutoSize = True
        Me.lbl_DirPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DirPropietario.Location = New System.Drawing.Point(342, 63)
        Me.lbl_DirPropietario.Name = "lbl_DirPropietario"
        Me.lbl_DirPropietario.Size = New System.Drawing.Size(67, 17)
        Me.lbl_DirPropietario.TabIndex = 32
        Me.lbl_DirPropietario.Text = "Dirección:"
        '
        'txt_CedulaPropietario
        '
        Me.txt_CedulaPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CedulaPropietario.Location = New System.Drawing.Point(241, 60)
        Me.txt_CedulaPropietario.Name = "txt_CedulaPropietario"
        Me.txt_CedulaPropietario.Size = New System.Drawing.Size(95, 24)
        Me.txt_CedulaPropietario.TabIndex = 31
        '
        'lbl_CedulaPropietario
        '
        Me.lbl_CedulaPropietario.AutoSize = True
        Me.lbl_CedulaPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CedulaPropietario.Location = New System.Drawing.Point(5, 63)
        Me.lbl_CedulaPropietario.Name = "lbl_CedulaPropietario"
        Me.lbl_CedulaPropietario.Size = New System.Drawing.Size(230, 17)
        Me.lbl_CedulaPropietario.TabIndex = 30
        Me.lbl_CedulaPropietario.Text = "Cédula de indentidad del propietario:"
        '
        'txt_ApellidoPropietario
        '
        Me.txt_ApellidoPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ApellidoPropietario.Location = New System.Drawing.Point(482, 30)
        Me.txt_ApellidoPropietario.Name = "txt_ApellidoPropietario"
        Me.txt_ApellidoPropietario.Size = New System.Drawing.Size(139, 24)
        Me.txt_ApellidoPropietario.TabIndex = 29
        '
        'lbl_ApellidoPropietario
        '
        Me.lbl_ApellidoPropietario.AutoSize = True
        Me.lbl_ApellidoPropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ApellidoPropietario.Location = New System.Drawing.Point(325, 33)
        Me.lbl_ApellidoPropietario.Name = "lbl_ApellidoPropietario"
        Me.lbl_ApellidoPropietario.Size = New System.Drawing.Size(151, 17)
        Me.lbl_ApellidoPropietario.TabIndex = 28
        Me.lbl_ApellidoPropietario.Text = "Apellido del propietario:"
        '
        'txt_NombrePropietario
        '
        Me.txt_NombrePropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombrePropietario.Location = New System.Drawing.Point(164, 30)
        Me.txt_NombrePropietario.Name = "txt_NombrePropietario"
        Me.txt_NombrePropietario.Size = New System.Drawing.Size(139, 24)
        Me.txt_NombrePropietario.TabIndex = 27
        '
        'lbl_NombrePropietario
        '
        Me.lbl_NombrePropietario.AutoSize = True
        Me.lbl_NombrePropietario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombrePropietario.Location = New System.Drawing.Point(6, 33)
        Me.lbl_NombrePropietario.Name = "lbl_NombrePropietario"
        Me.lbl_NombrePropietario.Size = New System.Drawing.Size(152, 17)
        Me.lbl_NombrePropietario.TabIndex = 26
        Me.lbl_NombrePropietario.Text = "Nombre del propietario:"
        '
        'cmd_AgregarEstablecimiento
        '
        Me.cmd_AgregarEstablecimiento.Enabled = False
        Me.cmd_AgregarEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarEstablecimiento.Location = New System.Drawing.Point(12, 357)
        Me.cmd_AgregarEstablecimiento.Name = "cmd_AgregarEstablecimiento"
        Me.cmd_AgregarEstablecimiento.Size = New System.Drawing.Size(87, 29)
        Me.cmd_AgregarEstablecimiento.TabIndex = 40
        Me.cmd_AgregarEstablecimiento.Text = "Agregar"
        Me.cmd_AgregarEstablecimiento.UseVisualStyleBackColor = True
        '
        'cmd_ModificarEstablecimiento
        '
        Me.cmd_ModificarEstablecimiento.Enabled = False
        Me.cmd_ModificarEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ModificarEstablecimiento.Location = New System.Drawing.Point(105, 357)
        Me.cmd_ModificarEstablecimiento.Name = "cmd_ModificarEstablecimiento"
        Me.cmd_ModificarEstablecimiento.Size = New System.Drawing.Size(94, 29)
        Me.cmd_ModificarEstablecimiento.TabIndex = 41
        Me.cmd_ModificarEstablecimiento.Text = "Modificar"
        Me.cmd_ModificarEstablecimiento.UseVisualStyleBackColor = True
        '
        'cmd_EliminarEstablecimiento
        '
        Me.cmd_EliminarEstablecimiento.Enabled = False
        Me.cmd_EliminarEstablecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EliminarEstablecimiento.Location = New System.Drawing.Point(205, 357)
        Me.cmd_EliminarEstablecimiento.Name = "cmd_EliminarEstablecimiento"
        Me.cmd_EliminarEstablecimiento.Size = New System.Drawing.Size(94, 29)
        Me.cmd_EliminarEstablecimiento.TabIndex = 42
        Me.cmd_EliminarEstablecimiento.Text = "Eliminar"
        Me.cmd_EliminarEstablecimiento.UseVisualStyleBackColor = True
        '
        'cmd_Parametros
        '
        Me.cmd_Parametros.Enabled = False
        Me.cmd_Parametros.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Parametros.Location = New System.Drawing.Point(305, 357)
        Me.cmd_Parametros.Name = "cmd_Parametros"
        Me.cmd_Parametros.Size = New System.Drawing.Size(109, 29)
        Me.cmd_Parametros.TabIndex = 43
        Me.cmd_Parametros.Text = "Parámetros"
        Me.cmd_Parametros.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Volver.Location = New System.Drawing.Point(596, 357)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(109, 29)
        Me.cmd_Volver.TabIndex = 44
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmAdmEstablecimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(717, 394)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_Parametros)
        Me.Controls.Add(Me.cmd_EliminarEstablecimiento)
        Me.Controls.Add(Me.cmd_ModificarEstablecimiento)
        Me.Controls.Add(Me.cmd_AgregarEstablecimiento)
        Me.Controls.Add(Me.group_Propietario)
        Me.Controls.Add(Me.group_Establecimiento)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.lbl_SeleccionarEstablecimiento)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAdmEstablecimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar establecimientos"
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
    Friend WithEvents lbl_NombreEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txt_NombreEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DptoEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cmd_EliminarTel1 As System.Windows.Forms.Button
    Friend WithEvents cmd_AgregarTel1 As System.Windows.Forms.Button
    Friend WithEvents cbo_TelEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TelEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txt_DirEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DirEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_DptoEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_NroBps As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NroBps As System.Windows.Forms.Label
    Friend WithEvents txt_NroRut As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NroRut As System.Windows.Forms.Label
    Friend WithEvents txt_NroDicose As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NroDicose As System.Windows.Forms.Label
    Friend WithEvents txt_Superficie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Superficie As System.Windows.Forms.Label
    Friend WithEvents lbl_LimiteAnimales As System.Windows.Forms.Label
    Friend WithEvents lbl_Hectareas As System.Windows.Forms.Label
    Friend WithEvents txt_LimiteAnimales As System.Windows.Forms.TextBox
    Friend WithEvents group_Propietario As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_EliminarTel2 As System.Windows.Forms.Button
    Friend WithEvents cmd_AgregarTel2 As System.Windows.Forms.Button
    Friend WithEvents cbo_TelPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TelPropietario As System.Windows.Forms.Label
    Friend WithEvents cbo_DptoPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_DptoPropietario As System.Windows.Forms.Label
    Friend WithEvents txt_DirPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DirPropietario As System.Windows.Forms.Label
    Friend WithEvents txt_CedulaPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CedulaPropietario As System.Windows.Forms.Label
    Friend WithEvents txt_ApellidoPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ApellidoPropietario As System.Windows.Forms.Label
    Friend WithEvents txt_NombrePropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombrePropietario As System.Windows.Forms.Label
    Friend WithEvents cmd_AgregarEstablecimiento As System.Windows.Forms.Button
    Friend WithEvents cmd_ModificarEstablecimiento As System.Windows.Forms.Button
    Friend WithEvents cmd_EliminarEstablecimiento As System.Windows.Forms.Button
    Friend WithEvents cmd_Parametros As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
