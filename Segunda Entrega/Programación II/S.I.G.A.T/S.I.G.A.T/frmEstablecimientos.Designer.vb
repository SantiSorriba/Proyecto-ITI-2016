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
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.panelEstablecimientos = New System.Windows.Forms.Panel()
        Me.cmdParametros = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.groupPropietario = New System.Windows.Forms.GroupBox()
        Me.txtTelPropietario = New System.Windows.Forms.TextBox()
        Me.lblTelPropietario = New System.Windows.Forms.Label()
        Me.txtDirPropietario = New System.Windows.Forms.TextBox()
        Me.lblDirPropietario = New System.Windows.Forms.Label()
        Me.cboDptoPropietario = New System.Windows.Forms.ComboBox()
        Me.lblDptoPropietario = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNomPropietario = New System.Windows.Forms.TextBox()
        Me.lblNomPropietario = New System.Windows.Forms.Label()
        Me.groupEstablecimiento = New System.Windows.Forms.GroupBox()
        Me.txtLimiteAnimales = New System.Windows.Forms.TextBox()
        Me.lblLimiteAnimales = New System.Windows.Forms.Label()
        Me.txtNroRut = New System.Windows.Forms.TextBox()
        Me.lblNroRut = New System.Windows.Forms.Label()
        Me.lblNroBps = New System.Windows.Forms.Label()
        Me.txtNroBps = New System.Windows.Forms.TextBox()
        Me.txtNroDicose = New System.Windows.Forms.TextBox()
        Me.lblNroDicose = New System.Windows.Forms.Label()
        Me.txtTelTambo = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDirTambo = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.txtSuperficie = New System.Windows.Forms.TextBox()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.cboDptoTambo = New System.Windows.Forms.ComboBox()
        Me.lblDptoTambo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.panelEstablecimientos.SuspendLayout()
        Me.groupPropietario.SuspendLayout()
        Me.groupEstablecimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(9, 9)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(124, 18)
        Me.lblEstablecimiento.TabIndex = 0
        Me.lblEstablecimiento.Text = "Establecimiento:"
        '
        'cboEstablecimiento
        '
        Me.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimiento.FormattingEnabled = True
        Me.cboEstablecimiento.Items.AddRange(New Object() {"Establecimiento Las Perdices", "Establecimiento Tala", "Establecimiento Los Juncales"})
        Me.cboEstablecimiento.Location = New System.Drawing.Point(139, 7)
        Me.cboEstablecimiento.MaxLength = 30
        Me.cboEstablecimiento.Name = "cboEstablecimiento"
        Me.cboEstablecimiento.Size = New System.Drawing.Size(295, 24)
        Me.cboEstablecimiento.TabIndex = 1
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(440, 7)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(60, 25)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'panelEstablecimientos
        '
        Me.panelEstablecimientos.Controls.Add(Me.cmdParametros)
        Me.panelEstablecimientos.Controls.Add(Me.cmdModificar)
        Me.panelEstablecimientos.Controls.Add(Me.cmdAgregar)
        Me.panelEstablecimientos.Controls.Add(Me.groupPropietario)
        Me.panelEstablecimientos.Controls.Add(Me.groupEstablecimiento)
        Me.panelEstablecimientos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEstablecimientos.Location = New System.Drawing.Point(12, 38)
        Me.panelEstablecimientos.Name = "panelEstablecimientos"
        Me.panelEstablecimientos.Size = New System.Drawing.Size(488, 335)
        Me.panelEstablecimientos.TabIndex = 3
        Me.panelEstablecimientos.Visible = False
        '
        'cmdParametros
        '
        Me.cmdParametros.Location = New System.Drawing.Point(340, 302)
        Me.cmdParametros.Name = "cmdParametros"
        Me.cmdParametros.Size = New System.Drawing.Size(140, 30)
        Me.cmdParametros.TabIndex = 4
        Me.cmdParametros.Text = "Parámetros"
        Me.cmdParametros.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(170, 302)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(164, 30)
        Me.cmdModificar.TabIndex = 3
        Me.cmdModificar.Text = "Modificar Datos"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(3, 302)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(161, 30)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "Agregar Establecimiento"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'groupPropietario
        '
        Me.groupPropietario.Controls.Add(Me.txtTelPropietario)
        Me.groupPropietario.Controls.Add(Me.lblTelPropietario)
        Me.groupPropietario.Controls.Add(Me.txtDirPropietario)
        Me.groupPropietario.Controls.Add(Me.lblDirPropietario)
        Me.groupPropietario.Controls.Add(Me.cboDptoPropietario)
        Me.groupPropietario.Controls.Add(Me.lblDptoPropietario)
        Me.groupPropietario.Controls.Add(Me.txtCedula)
        Me.groupPropietario.Controls.Add(Me.lblCedula)
        Me.groupPropietario.Controls.Add(Me.txtApellido)
        Me.groupPropietario.Controls.Add(Me.lblApellido)
        Me.groupPropietario.Controls.Add(Me.txtNomPropietario)
        Me.groupPropietario.Controls.Add(Me.lblNomPropietario)
        Me.groupPropietario.Location = New System.Drawing.Point(3, 176)
        Me.groupPropietario.Name = "groupPropietario"
        Me.groupPropietario.Size = New System.Drawing.Size(477, 120)
        Me.groupPropietario.TabIndex = 1
        Me.groupPropietario.TabStop = False
        Me.groupPropietario.Text = "Propietario"
        '
        'txtTelPropietario
        '
        Me.txtTelPropietario.Location = New System.Drawing.Point(340, 86)
        Me.txtTelPropietario.MaxLength = 5
        Me.txtTelPropietario.Multiline = True
        Me.txtTelPropietario.Name = "txtTelPropietario"
        Me.txtTelPropietario.Size = New System.Drawing.Size(79, 20)
        Me.txtTelPropietario.TabIndex = 12
        '
        'lblTelPropietario
        '
        Me.lblTelPropietario.AutoSize = True
        Me.lblTelPropietario.Location = New System.Drawing.Point(275, 88)
        Me.lblTelPropietario.Name = "lblTelPropietario"
        Me.lblTelPropietario.Size = New System.Drawing.Size(59, 16)
        Me.lblTelPropietario.TabIndex = 11
        Me.lblTelPropietario.Text = "Teléfono:"
        '
        'txtDirPropietario
        '
        Me.txtDirPropietario.Location = New System.Drawing.Point(80, 85)
        Me.txtDirPropietario.MaxLength = 25
        Me.txtDirPropietario.Multiline = True
        Me.txtDirPropietario.Name = "txtDirPropietario"
        Me.txtDirPropietario.Size = New System.Drawing.Size(189, 20)
        Me.txtDirPropietario.TabIndex = 10
        '
        'lblDirPropietario
        '
        Me.lblDirPropietario.AutoSize = True
        Me.lblDirPropietario.Location = New System.Drawing.Point(6, 89)
        Me.lblDirPropietario.Name = "lblDirPropietario"
        Me.lblDirPropietario.Size = New System.Drawing.Size(66, 16)
        Me.lblDirPropietario.TabIndex = 9
        Me.lblDirPropietario.Text = "Dirección:"
        '
        'cboDptoPropietario
        '
        Me.cboDptoPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDptoPropietario.FormattingEnabled = True
        Me.cboDptoPropietario.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDptoPropietario.Location = New System.Drawing.Point(340, 53)
        Me.cboDptoPropietario.MaxLength = 15
        Me.cboDptoPropietario.Name = "cboDptoPropietario"
        Me.cboDptoPropietario.Size = New System.Drawing.Size(121, 24)
        Me.cboDptoPropietario.TabIndex = 8
        '
        'lblDptoPropietario
        '
        Me.lblDptoPropietario.AutoSize = True
        Me.lblDptoPropietario.Location = New System.Drawing.Point(245, 59)
        Me.lblDptoPropietario.Name = "lblDptoPropietario"
        Me.lblDptoPropietario.Size = New System.Drawing.Size(93, 16)
        Me.lblDptoPropietario.TabIndex = 7
        Me.lblDptoPropietario.Text = "Departamento:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(137, 57)
        Me.txtCedula.MaxLength = 8
        Me.txtCedula.Multiline = True
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(102, 20)
        Me.txtCedula.TabIndex = 6
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(6, 59)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(126, 16)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cédula de Identidad:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(266, 27)
        Me.txtApellido.MaxLength = 15
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(127, 20)
        Me.txtApellido.TabIndex = 4
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(202, 29)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 16)
        Me.lblApellido.TabIndex = 3
        Me.lblApellido.Text = "Apellido:"
        '
        'txtNomPropietario
        '
        Me.txtNomPropietario.Location = New System.Drawing.Point(69, 26)
        Me.txtNomPropietario.MaxLength = 15
        Me.txtNomPropietario.Multiline = True
        Me.txtNomPropietario.Name = "txtNomPropietario"
        Me.txtNomPropietario.Size = New System.Drawing.Size(127, 20)
        Me.txtNomPropietario.TabIndex = 2
        '
        'lblNomPropietario
        '
        Me.lblNomPropietario.AutoSize = True
        Me.lblNomPropietario.Location = New System.Drawing.Point(6, 30)
        Me.lblNomPropietario.Name = "lblNomPropietario"
        Me.lblNomPropietario.Size = New System.Drawing.Size(57, 16)
        Me.lblNomPropietario.TabIndex = 1
        Me.lblNomPropietario.Text = "Nombre:"
        '
        'groupEstablecimiento
        '
        Me.groupEstablecimiento.Controls.Add(Me.txtLimiteAnimales)
        Me.groupEstablecimiento.Controls.Add(Me.lblLimiteAnimales)
        Me.groupEstablecimiento.Controls.Add(Me.txtNroRut)
        Me.groupEstablecimiento.Controls.Add(Me.lblNroRut)
        Me.groupEstablecimiento.Controls.Add(Me.lblNroBps)
        Me.groupEstablecimiento.Controls.Add(Me.txtNroBps)
        Me.groupEstablecimiento.Controls.Add(Me.txtNroDicose)
        Me.groupEstablecimiento.Controls.Add(Me.lblNroDicose)
        Me.groupEstablecimiento.Controls.Add(Me.txtTelTambo)
        Me.groupEstablecimiento.Controls.Add(Me.lblTelefono)
        Me.groupEstablecimiento.Controls.Add(Me.txtDirTambo)
        Me.groupEstablecimiento.Controls.Add(Me.lblDireccion)
        Me.groupEstablecimiento.Controls.Add(Me.lblHectareas)
        Me.groupEstablecimiento.Controls.Add(Me.txtSuperficie)
        Me.groupEstablecimiento.Controls.Add(Me.lblSuperficie)
        Me.groupEstablecimiento.Controls.Add(Me.cboDptoTambo)
        Me.groupEstablecimiento.Controls.Add(Me.lblDptoTambo)
        Me.groupEstablecimiento.Controls.Add(Me.txtNombre)
        Me.groupEstablecimiento.Controls.Add(Me.lblNombre)
        Me.groupEstablecimiento.Location = New System.Drawing.Point(3, 3)
        Me.groupEstablecimiento.Name = "groupEstablecimiento"
        Me.groupEstablecimiento.Size = New System.Drawing.Size(477, 167)
        Me.groupEstablecimiento.TabIndex = 0
        Me.groupEstablecimiento.TabStop = False
        Me.groupEstablecimiento.Text = "Establecimiento"
        '
        'txtLimiteAnimales
        '
        Me.txtLimiteAnimales.Location = New System.Drawing.Point(359, 136)
        Me.txtLimiteAnimales.MaxLength = 5
        Me.txtLimiteAnimales.Name = "txtLimiteAnimales"
        Me.txtLimiteAnimales.Size = New System.Drawing.Size(78, 22)
        Me.txtLimiteAnimales.TabIndex = 18
        '
        'lblLimiteAnimales
        '
        Me.lblLimiteAnimales.AutoSize = True
        Me.lblLimiteAnimales.Location = New System.Drawing.Point(232, 139)
        Me.lblLimiteAnimales.Name = "lblLimiteAnimales"
        Me.lblLimiteAnimales.Size = New System.Drawing.Size(121, 16)
        Me.lblLimiteAnimales.TabIndex = 17
        Me.lblLimiteAnimales.Text = "Límite de animales:"
        '
        'txtNroRut
        '
        Me.txtNroRut.Location = New System.Drawing.Point(124, 137)
        Me.txtNroRut.MaxLength = 12
        Me.txtNroRut.Multiline = True
        Me.txtNroRut.Name = "txtNroRut"
        Me.txtNroRut.Size = New System.Drawing.Size(99, 20)
        Me.txtNroRut.TabIndex = 16
        '
        'lblNroRut
        '
        Me.lblNroRut.AutoSize = True
        Me.lblNroRut.Location = New System.Drawing.Point(6, 139)
        Me.lblNroRut.Name = "lblNroRut"
        Me.lblNroRut.Size = New System.Drawing.Size(103, 16)
        Me.lblNroRut.TabIndex = 15
        Me.lblNroRut.Text = "Número de RUT:"
        '
        'lblNroBps
        '
        Me.lblNroBps.AutoSize = True
        Me.lblNroBps.Location = New System.Drawing.Point(232, 114)
        Me.lblNroBps.Name = "lblNroBps"
        Me.lblNroBps.Size = New System.Drawing.Size(106, 16)
        Me.lblNroBps.TabIndex = 14
        Me.lblNroBps.Text = "Número de BPS:"
        '
        'txtNroBps
        '
        Me.txtNroBps.Location = New System.Drawing.Point(344, 110)
        Me.txtNroBps.MaxLength = 10
        Me.txtNroBps.Multiline = True
        Me.txtNroBps.Name = "txtNroBps"
        Me.txtNroBps.Size = New System.Drawing.Size(84, 20)
        Me.txtNroBps.TabIndex = 13
        '
        'txtNroDicose
        '
        Me.txtNroDicose.Location = New System.Drawing.Point(137, 111)
        Me.txtNroDicose.MaxLength = 10
        Me.txtNroDicose.Multiline = True
        Me.txtNroDicose.Name = "txtNroDicose"
        Me.txtNroDicose.Size = New System.Drawing.Size(86, 20)
        Me.txtNroDicose.TabIndex = 12
        '
        'lblNroDicose
        '
        Me.lblNroDicose.AutoSize = True
        Me.lblNroDicose.Location = New System.Drawing.Point(6, 114)
        Me.lblNroDicose.Name = "lblNroDicose"
        Me.lblNroDicose.Size = New System.Drawing.Size(128, 16)
        Me.lblNroDicose.TabIndex = 11
        Me.lblNroDicose.Text = "Número de DICOSE:"
        '
        'txtTelTambo
        '
        Me.txtTelTambo.Location = New System.Drawing.Point(340, 84)
        Me.txtTelTambo.MaxLength = 5
        Me.txtTelTambo.Multiline = True
        Me.txtTelTambo.Name = "txtTelTambo"
        Me.txtTelTambo.Size = New System.Drawing.Size(79, 20)
        Me.txtTelTambo.TabIndex = 10
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(275, 87)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(59, 16)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtDirTambo
        '
        Me.txtDirTambo.Location = New System.Drawing.Point(80, 83)
        Me.txtDirTambo.MaxLength = 25
        Me.txtDirTambo.Multiline = True
        Me.txtDirTambo.Name = "txtDirTambo"
        Me.txtDirTambo.Size = New System.Drawing.Size(189, 20)
        Me.txtDirTambo.TabIndex = 8
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(6, 87)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(66, 16)
        Me.lblDireccion.TabIndex = 7
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Location = New System.Drawing.Point(393, 57)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(65, 16)
        Me.lblHectareas.TabIndex = 6
        Me.lblHectareas.Text = "hectáreas"
        '
        'txtSuperficie
        '
        Me.txtSuperficie.Location = New System.Drawing.Point(310, 54)
        Me.txtSuperficie.MaxLength = 5
        Me.txtSuperficie.Multiline = True
        Me.txtSuperficie.Name = "txtSuperficie"
        Me.txtSuperficie.Size = New System.Drawing.Size(77, 20)
        Me.txtSuperficie.TabIndex = 5
        Me.txtSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSuperficie
        '
        Me.lblSuperficie.AutoSize = True
        Me.lblSuperficie.Location = New System.Drawing.Point(235, 57)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Size = New System.Drawing.Size(69, 16)
        Me.lblSuperficie.TabIndex = 4
        Me.lblSuperficie.Text = "Superficie:"
        '
        'cboDptoTambo
        '
        Me.cboDptoTambo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDptoTambo.FormattingEnabled = True
        Me.cboDptoTambo.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDptoTambo.Location = New System.Drawing.Point(105, 54)
        Me.cboDptoTambo.MaxLength = 15
        Me.cboDptoTambo.Name = "cboDptoTambo"
        Me.cboDptoTambo.Size = New System.Drawing.Size(121, 24)
        Me.cboDptoTambo.TabIndex = 3
        '
        'lblDptoTambo
        '
        Me.lblDptoTambo.AutoSize = True
        Me.lblDptoTambo.Location = New System.Drawing.Point(6, 57)
        Me.lblDptoTambo.Name = "lblDptoTambo"
        Me.lblDptoTambo.Size = New System.Drawing.Size(93, 16)
        Me.lblDptoTambo.TabIndex = 2
        Me.lblDptoTambo.Text = "Departamento:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(185, 28)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(269, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(173, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre del establecimiento:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(398, 379)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 23)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmEstablecimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(508, 407)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.panelEstablecimientos)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cboEstablecimiento)
        Me.Controls.Add(Me.lblEstablecimiento)
        Me.MaximizeBox = False
        Me.Name = "frmEstablecimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Establecimientos"
        Me.panelEstablecimientos.ResumeLayout(False)
        Me.groupPropietario.ResumeLayout(False)
        Me.groupPropietario.PerformLayout()
        Me.groupEstablecimiento.ResumeLayout(False)
        Me.groupEstablecimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents panelEstablecimientos As System.Windows.Forms.Panel
    Friend WithEvents groupEstablecimiento As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cboDptoTambo As System.Windows.Forms.ComboBox
    Friend WithEvents lblDptoTambo As System.Windows.Forms.Label
    Friend WithEvents cmdParametros As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents groupPropietario As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lblTelPropietario As System.Windows.Forms.Label
    Friend WithEvents txtDirPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lblDirPropietario As System.Windows.Forms.Label
    Friend WithEvents cboDptoPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents lblDptoPropietario As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtNomPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lblNomPropietario As System.Windows.Forms.Label
    Friend WithEvents txtNroRut As System.Windows.Forms.TextBox
    Friend WithEvents lblNroRut As System.Windows.Forms.Label
    Friend WithEvents lblNroBps As System.Windows.Forms.Label
    Friend WithEvents txtNroBps As System.Windows.Forms.TextBox
    Friend WithEvents txtNroDicose As System.Windows.Forms.TextBox
    Friend WithEvents lblNroDicose As System.Windows.Forms.Label
    Friend WithEvents txtTelTambo As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDirTambo As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents txtSuperficie As System.Windows.Forms.TextBox
    Friend WithEvents lblSuperficie As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents txtLimiteAnimales As System.Windows.Forms.TextBox
    Friend WithEvents lblLimiteAnimales As System.Windows.Forms.Label
End Class
