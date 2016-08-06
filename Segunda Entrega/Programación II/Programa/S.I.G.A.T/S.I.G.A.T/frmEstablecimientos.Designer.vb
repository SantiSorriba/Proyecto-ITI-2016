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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstablecimientos))
        Me.lblSeleccioneEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimientos = New System.Windows.Forms.ComboBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.panelEstablecimiento = New System.Windows.Forms.Panel()
        Me.cmdProduccion = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdParametros = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.groupPropietario = New System.Windows.Forms.GroupBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombrePropietario = New System.Windows.Forms.TextBox()
        Me.txtDirPropietario = New System.Windows.Forms.TextBox()
        Me.cmdQuitarTel2 = New System.Windows.Forms.Button()
        Me.cmdAgregarTel2 = New System.Windows.Forms.Button()
        Me.cboTelPropietario = New System.Windows.Forms.ComboBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.cboDeptPropietario = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento1 = New System.Windows.Forms.Label()
        Me.lblDirPropietario = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombrePropietario = New System.Windows.Forms.Label()
        Me.groupEstablecimiento = New System.Windows.Forms.GroupBox()
        Me.cmdQuitarTel = New System.Windows.Forms.Button()
        Me.cmdAgregarTel = New System.Windows.Forms.Button()
        Me.cboTelEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.lblTelefonoEstablecimiento = New System.Windows.Forms.Label()
        Me.txtBps = New System.Windows.Forms.TextBox()
        Me.lblBps = New System.Windows.Forms.Label()
        Me.txtDicose = New System.Windows.Forms.TextBox()
        Me.lblDicose = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.txtHectareas = New System.Windows.Forms.TextBox()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombreEstablecimiento = New System.Windows.Forms.Label()
        Me.cboDeptEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.txtNombreEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.panelEstablecimiento.SuspendLayout()
        Me.groupPropietario.SuspendLayout()
        Me.groupEstablecimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeleccioneEstablecimiento
        '
        Me.lblSeleccioneEstablecimiento.AutoSize = True
        Me.lblSeleccioneEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneEstablecimiento.Location = New System.Drawing.Point(12, 9)
        Me.lblSeleccioneEstablecimiento.Name = "lblSeleccioneEstablecimiento"
        Me.lblSeleccioneEstablecimiento.Size = New System.Drawing.Size(293, 22)
        Me.lblSeleccioneEstablecimiento.TabIndex = 3
        Me.lblSeleccioneEstablecimiento.Text = "Seleccione un establecimiento:"
        '
        'cboEstablecimientos
        '
        Me.cboEstablecimientos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimientos.FormattingEnabled = True
        Me.cboEstablecimientos.Location = New System.Drawing.Point(311, 9)
        Me.cboEstablecimientos.MaxLength = 20
        Me.cboEstablecimientos.Name = "cboEstablecimientos"
        Me.cboEstablecimientos.Size = New System.Drawing.Size(260, 25)
        Me.cboEstablecimientos.TabIndex = 4
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(577, 9)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(96, 25)
        Me.cmdBuscar.TabIndex = 5
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'panelEstablecimiento
        '
        Me.panelEstablecimiento.Controls.Add(Me.cmdProduccion)
        Me.panelEstablecimiento.Controls.Add(Me.cmdCancelar)
        Me.panelEstablecimiento.Controls.Add(Me.cmdParametros)
        Me.panelEstablecimiento.Controls.Add(Me.cmdModificar)
        Me.panelEstablecimiento.Controls.Add(Me.cmdAgregar)
        Me.panelEstablecimiento.Controls.Add(Me.groupPropietario)
        Me.panelEstablecimiento.Controls.Add(Me.groupEstablecimiento)
        Me.panelEstablecimiento.Location = New System.Drawing.Point(12, 37)
        Me.panelEstablecimiento.Name = "panelEstablecimiento"
        Me.panelEstablecimiento.Size = New System.Drawing.Size(661, 304)
        Me.panelEstablecimiento.TabIndex = 6
        '
        'cmdProduccion
        '
        Me.cmdProduccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProduccion.Location = New System.Drawing.Point(298, 273)
        Me.cmdProduccion.Name = "cmdProduccion"
        Me.cmdProduccion.Size = New System.Drawing.Size(153, 28)
        Me.cmdProduccion.TabIndex = 13
        Me.cmdProduccion.Text = "Datos de producción"
        Me.cmdProduccion.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(562, 273)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(96, 28)
        Me.cmdCancelar.TabIndex = 12
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdParametros
        '
        Me.cmdParametros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdParametros.Location = New System.Drawing.Point(457, 273)
        Me.cmdParametros.Name = "cmdParametros"
        Me.cmdParametros.Size = New System.Drawing.Size(99, 28)
        Me.cmdParametros.TabIndex = 11
        Me.cmdParametros.Text = "Parámetros"
        Me.cmdParametros.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(189, 273)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(103, 28)
        Me.cmdModificar.TabIndex = 10
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(4, 273)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(179, 28)
        Me.cmdAgregar.TabIndex = 9
        Me.cmdAgregar.Text = "Agregar establecimiento"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'groupPropietario
        '
        Me.groupPropietario.Controls.Add(Me.txtCi)
        Me.groupPropietario.Controls.Add(Me.txtApellido)
        Me.groupPropietario.Controls.Add(Me.txtNombrePropietario)
        Me.groupPropietario.Controls.Add(Me.txtDirPropietario)
        Me.groupPropietario.Controls.Add(Me.cmdQuitarTel2)
        Me.groupPropietario.Controls.Add(Me.cmdAgregarTel2)
        Me.groupPropietario.Controls.Add(Me.cboTelPropietario)
        Me.groupPropietario.Controls.Add(Me.lblTel)
        Me.groupPropietario.Controls.Add(Me.cboDeptPropietario)
        Me.groupPropietario.Controls.Add(Me.lblDepartamento1)
        Me.groupPropietario.Controls.Add(Me.lblDirPropietario)
        Me.groupPropietario.Controls.Add(Me.lblCi)
        Me.groupPropietario.Controls.Add(Me.lblApellido)
        Me.groupPropietario.Controls.Add(Me.lblNombrePropietario)
        Me.groupPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPropietario.Location = New System.Drawing.Point(4, 152)
        Me.groupPropietario.Name = "groupPropietario"
        Me.groupPropietario.Size = New System.Drawing.Size(654, 115)
        Me.groupPropietario.TabIndex = 8
        Me.groupPropietario.TabStop = False
        Me.groupPropietario.Text = "Propietario"
        '
        'txtCi
        '
        Me.txtCi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCi.Location = New System.Drawing.Point(166, 53)
        Me.txtCi.Multiline = True
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(140, 20)
        Me.txtCi.TabIndex = 37
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(384, 25)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(248, 20)
        Me.txtApellido.TabIndex = 36
        '
        'txtNombrePropietario
        '
        Me.txtNombrePropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePropietario.Location = New System.Drawing.Point(83, 27)
        Me.txtNombrePropietario.Multiline = True
        Me.txtNombrePropietario.Name = "txtNombrePropietario"
        Me.txtNombrePropietario.Size = New System.Drawing.Size(217, 20)
        Me.txtNombrePropietario.TabIndex = 35
        '
        'txtDirPropietario
        '
        Me.txtDirPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirPropietario.Location = New System.Drawing.Point(402, 51)
        Me.txtDirPropietario.Multiline = True
        Me.txtDirPropietario.Name = "txtDirPropietario"
        Me.txtDirPropietario.Size = New System.Drawing.Size(230, 20)
        Me.txtDirPropietario.TabIndex = 34
        '
        'cmdQuitarTel2
        '
        Me.cmdQuitarTel2.Location = New System.Drawing.Point(536, 82)
        Me.cmdQuitarTel2.Name = "cmdQuitarTel2"
        Me.cmdQuitarTel2.Size = New System.Drawing.Size(60, 23)
        Me.cmdQuitarTel2.TabIndex = 33
        Me.cmdQuitarTel2.Text = "Quitar"
        Me.cmdQuitarTel2.UseVisualStyleBackColor = True
        '
        'cmdAgregarTel2
        '
        Me.cmdAgregarTel2.Location = New System.Drawing.Point(458, 82)
        Me.cmdAgregarTel2.Name = "cmdAgregarTel2"
        Me.cmdAgregarTel2.Size = New System.Drawing.Size(72, 23)
        Me.cmdAgregarTel2.TabIndex = 32
        Me.cmdAgregarTel2.Text = "Agregar"
        Me.cmdAgregarTel2.UseVisualStyleBackColor = True
        '
        'cboTelPropietario
        '
        Me.cboTelPropietario.FormattingEnabled = True
        Me.cboTelPropietario.Location = New System.Drawing.Point(334, 82)
        Me.cboTelPropietario.Name = "cboTelPropietario"
        Me.cboTelPropietario.Size = New System.Drawing.Size(118, 23)
        Me.cboTelPropietario.TabIndex = 31
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(244, 85)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(84, 17)
        Me.lblTel.TabIndex = 30
        Me.lblTel.Text = "Teléfonos:"
        '
        'cboDeptPropietario
        '
        Me.cboDeptPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptPropietario.FormattingEnabled = True
        Me.cboDeptPropietario.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDeptPropietario.Location = New System.Drawing.Point(130, 80)
        Me.cboDeptPropietario.Name = "cboDeptPropietario"
        Me.cboDeptPropietario.Size = New System.Drawing.Size(107, 23)
        Me.cboDeptPropietario.TabIndex = 16
        '
        'lblDepartamento1
        '
        Me.lblDepartamento1.AutoSize = True
        Me.lblDepartamento1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento1.Location = New System.Drawing.Point(6, 85)
        Me.lblDepartamento1.Name = "lblDepartamento1"
        Me.lblDepartamento1.Size = New System.Drawing.Size(117, 17)
        Me.lblDepartamento1.TabIndex = 15
        Me.lblDepartamento1.Text = "Departamento:"
        '
        'lblDirPropietario
        '
        Me.lblDirPropietario.AutoSize = True
        Me.lblDirPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirPropietario.Location = New System.Drawing.Point(312, 57)
        Me.lblDirPropietario.Name = "lblDirPropietario"
        Me.lblDirPropietario.Size = New System.Drawing.Size(84, 17)
        Me.lblDirPropietario.TabIndex = 13
        Me.lblDirPropietario.Text = "Dirección:"
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(6, 57)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(158, 17)
        Me.lblCi.TabIndex = 11
        Me.lblCi.Text = "Cédula de Identidad:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(306, 28)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(72, 17)
        Me.lblApellido.TabIndex = 9
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombrePropietario
        '
        Me.lblNombrePropietario.AutoSize = True
        Me.lblNombrePropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePropietario.Location = New System.Drawing.Point(6, 28)
        Me.lblNombrePropietario.Name = "lblNombrePropietario"
        Me.lblNombrePropietario.Size = New System.Drawing.Size(71, 17)
        Me.lblNombrePropietario.TabIndex = 7
        Me.lblNombrePropietario.Text = "Nombre:"
        '
        'groupEstablecimiento
        '
        Me.groupEstablecimiento.Controls.Add(Me.cmdQuitarTel)
        Me.groupEstablecimiento.Controls.Add(Me.cmdAgregarTel)
        Me.groupEstablecimiento.Controls.Add(Me.cboTelEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.lblTelefonoEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.txtBps)
        Me.groupEstablecimiento.Controls.Add(Me.lblBps)
        Me.groupEstablecimiento.Controls.Add(Me.txtDicose)
        Me.groupEstablecimiento.Controls.Add(Me.lblDicose)
        Me.groupEstablecimiento.Controls.Add(Me.txtRut)
        Me.groupEstablecimiento.Controls.Add(Me.lblRut)
        Me.groupEstablecimiento.Controls.Add(Me.lblHectareas)
        Me.groupEstablecimiento.Controls.Add(Me.txtHectareas)
        Me.groupEstablecimiento.Controls.Add(Me.lblSuperficie)
        Me.groupEstablecimiento.Controls.Add(Me.txtUbicacion)
        Me.groupEstablecimiento.Controls.Add(Me.lblDireccion)
        Me.groupEstablecimiento.Controls.Add(Me.lblNombreEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.cboDeptEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.txtNombreEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.lblDepartamento)
        Me.groupEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupEstablecimiento.Location = New System.Drawing.Point(4, 3)
        Me.groupEstablecimiento.Name = "groupEstablecimiento"
        Me.groupEstablecimiento.Size = New System.Drawing.Size(654, 143)
        Me.groupEstablecimiento.TabIndex = 7
        Me.groupEstablecimiento.TabStop = False
        Me.groupEstablecimiento.Text = "Establecimiento"
        '
        'cmdQuitarTel
        '
        Me.cmdQuitarTel.Location = New System.Drawing.Point(586, 109)
        Me.cmdQuitarTel.Name = "cmdQuitarTel"
        Me.cmdQuitarTel.Size = New System.Drawing.Size(60, 23)
        Me.cmdQuitarTel.TabIndex = 29
        Me.cmdQuitarTel.Text = "Quitar"
        Me.cmdQuitarTel.UseVisualStyleBackColor = True
        '
        'cmdAgregarTel
        '
        Me.cmdAgregarTel.Location = New System.Drawing.Point(508, 109)
        Me.cmdAgregarTel.Name = "cmdAgregarTel"
        Me.cmdAgregarTel.Size = New System.Drawing.Size(72, 23)
        Me.cmdAgregarTel.TabIndex = 28
        Me.cmdAgregarTel.Text = "Agregar"
        Me.cmdAgregarTel.UseVisualStyleBackColor = True
        '
        'cboTelEstablecimiento
        '
        Me.cboTelEstablecimiento.FormattingEnabled = True
        Me.cboTelEstablecimiento.Location = New System.Drawing.Point(384, 109)
        Me.cboTelEstablecimiento.Name = "cboTelEstablecimiento"
        Me.cboTelEstablecimiento.Size = New System.Drawing.Size(118, 23)
        Me.cboTelEstablecimiento.TabIndex = 27
        '
        'lblTelefonoEstablecimiento
        '
        Me.lblTelefonoEstablecimiento.AutoSize = True
        Me.lblTelefonoEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEstablecimiento.Location = New System.Drawing.Point(294, 112)
        Me.lblTelefonoEstablecimiento.Name = "lblTelefonoEstablecimiento"
        Me.lblTelefonoEstablecimiento.Size = New System.Drawing.Size(84, 17)
        Me.lblTelefonoEstablecimiento.TabIndex = 26
        Me.lblTelefonoEstablecimiento.Text = "Teléfonos:"
        '
        'txtBps
        '
        Me.txtBps.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBps.Location = New System.Drawing.Point(140, 112)
        Me.txtBps.Multiline = True
        Me.txtBps.Name = "txtBps"
        Me.txtBps.Size = New System.Drawing.Size(148, 20)
        Me.txtBps.TabIndex = 25
        '
        'lblBps
        '
        Me.lblBps.AutoSize = True
        Me.lblBps.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBps.Location = New System.Drawing.Point(6, 112)
        Me.lblBps.Name = "lblBps"
        Me.lblBps.Size = New System.Drawing.Size(128, 17)
        Me.lblBps.TabIndex = 24
        Me.lblBps.Text = "Numero de BPS:"
        '
        'txtDicose
        '
        Me.txtDicose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDicose.Location = New System.Drawing.Point(446, 83)
        Me.txtDicose.Multiline = True
        Me.txtDicose.Name = "txtDicose"
        Me.txtDicose.Size = New System.Drawing.Size(168, 20)
        Me.txtDicose.TabIndex = 23
        '
        'lblDicose
        '
        Me.lblDicose.AutoSize = True
        Me.lblDicose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDicose.Location = New System.Drawing.Point(284, 85)
        Me.lblDicose.Name = "lblDicose"
        Me.lblDicose.Size = New System.Drawing.Size(156, 17)
        Me.lblDicose.TabIndex = 22
        Me.lblDicose.Text = "Numero de DICOSE:"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(140, 82)
        Me.txtRut.Multiline = True
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(130, 20)
        Me.txtRut.TabIndex = 21
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(6, 86)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(128, 17)
        Me.lblRut.TabIndex = 20
        Me.lblRut.Text = "Numero de RUT:"
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHectareas.Location = New System.Drawing.Point(512, 59)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(82, 17)
        Me.lblHectareas.TabIndex = 19
        Me.lblHectareas.Text = "hectáreas"
        '
        'txtHectareas
        '
        Me.txtHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHectareas.Location = New System.Drawing.Point(446, 56)
        Me.txtHectareas.Multiline = True
        Me.txtHectareas.Name = "txtHectareas"
        Me.txtHectareas.Size = New System.Drawing.Size(60, 20)
        Me.txtHectareas.TabIndex = 18
        '
        'lblSuperficie
        '
        Me.lblSuperficie.AutoSize = True
        Me.lblSuperficie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperficie.Location = New System.Drawing.Point(352, 59)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Size = New System.Drawing.Size(88, 17)
        Me.lblSuperficie.TabIndex = 17
        Me.lblSuperficie.Text = "Superficie:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(98, 56)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(230, 20)
        Me.txtUbicacion.TabIndex = 8
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(6, 56)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(84, 17)
        Me.lblDireccion.TabIndex = 7
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblNombreEstablecimiento
        '
        Me.lblNombreEstablecimiento.AutoSize = True
        Me.lblNombreEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEstablecimiento.Location = New System.Drawing.Point(6, 29)
        Me.lblNombreEstablecimiento.Name = "lblNombreEstablecimiento"
        Me.lblNombreEstablecimiento.Size = New System.Drawing.Size(216, 17)
        Me.lblNombreEstablecimiento.TabIndex = 3
        Me.lblNombreEstablecimiento.Text = "Nombre del establecimiento:"
        '
        'cboDeptEstablecimiento
        '
        Me.cboDeptEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptEstablecimiento.FormattingEnabled = True
        Me.cboDeptEstablecimiento.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres", ""})
        Me.cboDeptEstablecimiento.Location = New System.Drawing.Point(530, 28)
        Me.cboDeptEstablecimiento.Name = "cboDeptEstablecimiento"
        Me.cboDeptEstablecimiento.Size = New System.Drawing.Size(118, 23)
        Me.cboDeptEstablecimiento.TabIndex = 6
        '
        'txtNombreEstablecimiento
        '
        Me.txtNombreEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEstablecimiento.Location = New System.Drawing.Point(228, 29)
        Me.txtNombreEstablecimiento.MaxLength = 20
        Me.txtNombreEstablecimiento.Multiline = True
        Me.txtNombreEstablecimiento.Name = "txtNombreEstablecimiento"
        Me.txtNombreEstablecimiento.Size = New System.Drawing.Size(173, 20)
        Me.txtNombreEstablecimiento.TabIndex = 4
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.Location = New System.Drawing.Point(407, 29)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(117, 17)
        Me.lblDepartamento.TabIndex = 5
        Me.lblDepartamento.Text = "Departamento:"
        '
        'frmEstablecimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(685, 353)
        Me.Controls.Add(Me.panelEstablecimiento)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cboEstablecimientos)
        Me.Controls.Add(Me.lblSeleccioneEstablecimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEstablecimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Establecimientos"
        Me.panelEstablecimiento.ResumeLayout(False)
        Me.groupPropietario.ResumeLayout(False)
        Me.groupPropietario.PerformLayout()
        Me.groupEstablecimiento.ResumeLayout(False)
        Me.groupEstablecimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeleccioneEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents panelEstablecimiento As System.Windows.Forms.Panel
    Friend WithEvents cboDeptEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents txtNombreEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents groupEstablecimiento As System.Windows.Forms.GroupBox
    Friend WithEvents cmdQuitarTel As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTel As System.Windows.Forms.Button
    Friend WithEvents cboTelEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lblTelefonoEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txtBps As System.Windows.Forms.TextBox
    Friend WithEvents lblBps As System.Windows.Forms.Label
    Friend WithEvents txtDicose As System.Windows.Forms.TextBox
    Friend WithEvents lblDicose As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents txtHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblSuperficie As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents groupPropietario As System.Windows.Forms.GroupBox
    Friend WithEvents cmdQuitarTel2 As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTel2 As System.Windows.Forms.Button
    Friend WithEvents cboTelPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents cboDeptPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento1 As System.Windows.Forms.Label
    Friend WithEvents lblDirPropietario As System.Windows.Forms.Label
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombrePropietario As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdParametros As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombrePropietario As System.Windows.Forms.TextBox
    Friend WithEvents txtDirPropietario As System.Windows.Forms.TextBox
    Friend WithEvents cmdProduccion As System.Windows.Forms.Button
End Class
