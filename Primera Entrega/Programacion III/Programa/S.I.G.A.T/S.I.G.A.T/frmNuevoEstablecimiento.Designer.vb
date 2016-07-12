<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoEstablecimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevoEstablecimiento))
        Me.groupEstablecimiento = New System.Windows.Forms.GroupBox()
        Me.cmdParametros = New System.Windows.Forms.Button()
        Me.lblCant2 = New System.Windows.Forms.Label()
        Me.txtCantPrimerShow = New System.Windows.Forms.TextBox()
        Me.chkPrimerShow = New System.Windows.Forms.CheckBox()
        Me.lblCant1 = New System.Windows.Forms.Label()
        Me.txtCantHolando = New System.Windows.Forms.TextBox()
        Me.chkHolando = New System.Windows.Forms.CheckBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantJersey = New System.Windows.Forms.TextBox()
        Me.chkJersey = New System.Windows.Forms.CheckBox()
        Me.lblRazas = New System.Windows.Forms.Label()
        Me.rdoManual = New System.Windows.Forms.RadioButton()
        Me.rdoMecanico = New System.Windows.Forms.RadioButton()
        Me.lblOrdenie = New System.Windows.Forms.Label()
        Me.txtCantidadAnimales = New System.Windows.Forms.TextBox()
        Me.lblCantidadAnimales = New System.Windows.Forms.Label()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.txtHectareas = New System.Windows.Forms.TextBox()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.txtTelefonoEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lblTelefonoEstablecimiento = New System.Windows.Forms.Label()
        Me.txtDicose = New System.Windows.Forms.TextBox()
        Me.lblDicose = New System.Windows.Forms.Label()
        Me.txtBps = New System.Windows.Forms.TextBox()
        Me.lblBps = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.cboDeptEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.txtNombreEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblNombreEstablecimiento = New System.Windows.Forms.Label()
        Me.groupPropietario = New System.Windows.Forms.GroupBox()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.rdoSi = New System.Windows.Forms.RadioButton()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.cboDeptPropietario = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento1 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.txtTelefonoPropietario = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombrePropietario = New System.Windows.Forms.TextBox()
        Me.lblCorreoElectronico = New System.Windows.Forms.Label()
        Me.lblTelefonoPropietario = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombrePropietario = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.groupEstablecimiento.SuspendLayout()
        Me.groupPropietario.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupEstablecimiento
        '
        Me.groupEstablecimiento.Controls.Add(Me.cmdParametros)
        Me.groupEstablecimiento.Controls.Add(Me.lblCant2)
        Me.groupEstablecimiento.Controls.Add(Me.txtCantPrimerShow)
        Me.groupEstablecimiento.Controls.Add(Me.chkPrimerShow)
        Me.groupEstablecimiento.Controls.Add(Me.lblCant1)
        Me.groupEstablecimiento.Controls.Add(Me.txtCantHolando)
        Me.groupEstablecimiento.Controls.Add(Me.chkHolando)
        Me.groupEstablecimiento.Controls.Add(Me.lblCantidad)
        Me.groupEstablecimiento.Controls.Add(Me.txtCantJersey)
        Me.groupEstablecimiento.Controls.Add(Me.chkJersey)
        Me.groupEstablecimiento.Controls.Add(Me.lblRazas)
        Me.groupEstablecimiento.Controls.Add(Me.rdoManual)
        Me.groupEstablecimiento.Controls.Add(Me.rdoMecanico)
        Me.groupEstablecimiento.Controls.Add(Me.lblOrdenie)
        Me.groupEstablecimiento.Controls.Add(Me.txtCantidadAnimales)
        Me.groupEstablecimiento.Controls.Add(Me.lblCantidadAnimales)
        Me.groupEstablecimiento.Controls.Add(Me.lblHectareas)
        Me.groupEstablecimiento.Controls.Add(Me.txtHectareas)
        Me.groupEstablecimiento.Controls.Add(Me.lblSuperficie)
        Me.groupEstablecimiento.Controls.Add(Me.txtTelefonoEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.lblTelefonoEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.txtDicose)
        Me.groupEstablecimiento.Controls.Add(Me.lblDicose)
        Me.groupEstablecimiento.Controls.Add(Me.txtBps)
        Me.groupEstablecimiento.Controls.Add(Me.lblBps)
        Me.groupEstablecimiento.Controls.Add(Me.txtRut)
        Me.groupEstablecimiento.Controls.Add(Me.lblRut)
        Me.groupEstablecimiento.Controls.Add(Me.txtUbicacion)
        Me.groupEstablecimiento.Controls.Add(Me.cboDeptEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.lblDepartamento)
        Me.groupEstablecimiento.Controls.Add(Me.txtNombreEstablecimiento)
        Me.groupEstablecimiento.Controls.Add(Me.lblUbicacion)
        Me.groupEstablecimiento.Controls.Add(Me.lblNombreEstablecimiento)
        Me.groupEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupEstablecimiento.Location = New System.Drawing.Point(12, 12)
        Me.groupEstablecimiento.Name = "groupEstablecimiento"
        Me.groupEstablecimiento.Size = New System.Drawing.Size(860, 167)
        Me.groupEstablecimiento.TabIndex = 0
        Me.groupEstablecimiento.TabStop = False
        Me.groupEstablecimiento.Text = "Establecimiento"
        '
        'cmdParametros
        '
        Me.cmdParametros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdParametros.Location = New System.Drawing.Point(628, 107)
        Me.cmdParametros.Name = "cmdParametros"
        Me.cmdParametros.Size = New System.Drawing.Size(226, 23)
        Me.cmdParametros.TabIndex = 32
        Me.cmdParametros.Text = "Especificar Parámetros"
        Me.cmdParametros.UseVisualStyleBackColor = True
        '
        'lblCant2
        '
        Me.lblCant2.AutoSize = True
        Me.lblCant2.Enabled = False
        Me.lblCant2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant2.Location = New System.Drawing.Point(703, 141)
        Me.lblCant2.Name = "lblCant2"
        Me.lblCant2.Size = New System.Drawing.Size(78, 17)
        Me.lblCant2.TabIndex = 31
        Me.lblCant2.Text = "Cantidad:"
        '
        'txtCantPrimerShow
        '
        Me.txtCantPrimerShow.Enabled = False
        Me.txtCantPrimerShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantPrimerShow.Location = New System.Drawing.Point(785, 140)
        Me.txtCantPrimerShow.Multiline = True
        Me.txtCantPrimerShow.Name = "txtCantPrimerShow"
        Me.txtCantPrimerShow.Size = New System.Drawing.Size(69, 20)
        Me.txtCantPrimerShow.TabIndex = 30
        '
        'chkPrimerShow
        '
        Me.chkPrimerShow.AutoSize = True
        Me.chkPrimerShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrimerShow.Location = New System.Drawing.Point(575, 140)
        Me.chkPrimerShow.Name = "chkPrimerShow"
        Me.chkPrimerShow.Size = New System.Drawing.Size(121, 21)
        Me.chkPrimerShow.TabIndex = 29
        Me.chkPrimerShow.Text = "Primer Show"
        Me.chkPrimerShow.UseVisualStyleBackColor = True
        '
        'lblCant1
        '
        Me.lblCant1.AutoSize = True
        Me.lblCant1.Enabled = False
        Me.lblCant1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant1.Location = New System.Drawing.Point(407, 141)
        Me.lblCant1.Name = "lblCant1"
        Me.lblCant1.Size = New System.Drawing.Size(78, 17)
        Me.lblCant1.TabIndex = 28
        Me.lblCant1.Text = "Cantidad:"
        '
        'txtCantHolando
        '
        Me.txtCantHolando.Enabled = False
        Me.txtCantHolando.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantHolando.Location = New System.Drawing.Point(491, 141)
        Me.txtCantHolando.Multiline = True
        Me.txtCantHolando.Name = "txtCantHolando"
        Me.txtCantHolando.Size = New System.Drawing.Size(69, 20)
        Me.txtCantHolando.TabIndex = 27
        '
        'chkHolando
        '
        Me.chkHolando.AutoSize = True
        Me.chkHolando.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHolando.Location = New System.Drawing.Point(314, 140)
        Me.chkHolando.Name = "chkHolando"
        Me.chkHolando.Size = New System.Drawing.Size(87, 21)
        Me.chkHolando.TabIndex = 26
        Me.chkHolando.Text = "Holando"
        Me.chkHolando.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Enabled = False
        Me.lblCantidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(153, 141)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(78, 17)
        Me.lblCantidad.TabIndex = 25
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtCantJersey
        '
        Me.txtCantJersey.Enabled = False
        Me.txtCantJersey.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantJersey.Location = New System.Drawing.Point(237, 141)
        Me.txtCantJersey.Multiline = True
        Me.txtCantJersey.Name = "txtCantJersey"
        Me.txtCantJersey.Size = New System.Drawing.Size(69, 20)
        Me.txtCantJersey.TabIndex = 24
        '
        'chkJersey
        '
        Me.chkJersey.AutoSize = True
        Me.chkJersey.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJersey.Location = New System.Drawing.Point(70, 140)
        Me.chkJersey.Name = "chkJersey"
        Me.chkJersey.Size = New System.Drawing.Size(77, 21)
        Me.chkJersey.TabIndex = 23
        Me.chkJersey.Text = "Jersey"
        Me.chkJersey.UseVisualStyleBackColor = True
        '
        'lblRazas
        '
        Me.lblRazas.AutoSize = True
        Me.lblRazas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazas.Location = New System.Drawing.Point(6, 141)
        Me.lblRazas.Name = "lblRazas"
        Me.lblRazas.Size = New System.Drawing.Size(58, 17)
        Me.lblRazas.TabIndex = 22
        Me.lblRazas.Text = "Razas:"
        '
        'rdoManual
        '
        Me.rdoManual.AutoSize = True
        Me.rdoManual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoManual.Location = New System.Drawing.Point(544, 109)
        Me.rdoManual.Name = "rdoManual"
        Me.rdoManual.Size = New System.Drawing.Size(78, 21)
        Me.rdoManual.TabIndex = 21
        Me.rdoManual.TabStop = True
        Me.rdoManual.Text = "Manual"
        Me.rdoManual.UseVisualStyleBackColor = True
        '
        'rdoMecanico
        '
        Me.rdoMecanico.AutoSize = True
        Me.rdoMecanico.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMecanico.Location = New System.Drawing.Point(438, 109)
        Me.rdoMecanico.Name = "rdoMecanico"
        Me.rdoMecanico.Size = New System.Drawing.Size(96, 21)
        Me.rdoMecanico.TabIndex = 20
        Me.rdoMecanico.TabStop = True
        Me.rdoMecanico.Text = "Mecánico"
        Me.rdoMecanico.UseVisualStyleBackColor = True
        '
        'lblOrdenie
        '
        Me.lblOrdenie.AutoSize = True
        Me.lblOrdenie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenie.Location = New System.Drawing.Point(294, 111)
        Me.lblOrdenie.Name = "lblOrdenie"
        Me.lblOrdenie.Size = New System.Drawing.Size(122, 17)
        Me.lblOrdenie.TabIndex = 19
        Me.lblOrdenie.Text = "Tipo de ordeñe:"
        '
        'txtCantidadAnimales
        '
        Me.txtCantidadAnimales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAnimales.Location = New System.Drawing.Point(181, 108)
        Me.txtCantidadAnimales.Multiline = True
        Me.txtCantidadAnimales.Name = "txtCantidadAnimales"
        Me.txtCantidadAnimales.Size = New System.Drawing.Size(89, 20)
        Me.txtCantidadAnimales.TabIndex = 18
        '
        'lblCantidadAnimales
        '
        Me.lblCantidadAnimales.AutoSize = True
        Me.lblCantidadAnimales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadAnimales.Location = New System.Drawing.Point(6, 111)
        Me.lblCantidadAnimales.Name = "lblCantidadAnimales"
        Me.lblCantidadAnimales.Size = New System.Drawing.Size(169, 17)
        Me.lblCantidadAnimales.TabIndex = 17
        Me.lblCantidadAnimales.Text = "Cantidad de animales:"
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHectareas.Location = New System.Drawing.Point(772, 79)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(82, 17)
        Me.lblHectareas.TabIndex = 16
        Me.lblHectareas.Text = "hectáreas"
        '
        'txtHectareas
        '
        Me.txtHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHectareas.Location = New System.Drawing.Point(706, 77)
        Me.txtHectareas.Multiline = True
        Me.txtHectareas.Name = "txtHectareas"
        Me.txtHectareas.Size = New System.Drawing.Size(60, 20)
        Me.txtHectareas.TabIndex = 15
        '
        'lblSuperficie
        '
        Me.lblSuperficie.AutoSize = True
        Me.lblSuperficie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperficie.Location = New System.Drawing.Point(612, 79)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Size = New System.Drawing.Size(88, 17)
        Me.lblSuperficie.TabIndex = 14
        Me.lblSuperficie.Text = "Superficie:"
        '
        'txtTelefonoEstablecimiento
        '
        Me.txtTelefonoEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoEstablecimiento.Location = New System.Drawing.Point(422, 50)
        Me.txtTelefonoEstablecimiento.Multiline = True
        Me.txtTelefonoEstablecimiento.Name = "txtTelefonoEstablecimiento"
        Me.txtTelefonoEstablecimiento.Size = New System.Drawing.Size(144, 20)
        Me.txtTelefonoEstablecimiento.TabIndex = 13
        '
        'lblTelefonoEstablecimiento
        '
        Me.lblTelefonoEstablecimiento.AutoSize = True
        Me.lblTelefonoEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEstablecimiento.Location = New System.Drawing.Point(334, 50)
        Me.lblTelefonoEstablecimiento.Name = "lblTelefonoEstablecimiento"
        Me.lblTelefonoEstablecimiento.Size = New System.Drawing.Size(76, 17)
        Me.lblTelefonoEstablecimiento.TabIndex = 12
        Me.lblTelefonoEstablecimiento.Text = "Teléfono:"
        '
        'txtDicose
        '
        Me.txtDicose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDicose.Location = New System.Drawing.Point(438, 76)
        Me.txtDicose.Multiline = True
        Me.txtDicose.Name = "txtDicose"
        Me.txtDicose.Size = New System.Drawing.Size(168, 20)
        Me.txtDicose.TabIndex = 11
        '
        'lblDicose
        '
        Me.lblDicose.AutoSize = True
        Me.lblDicose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDicose.Location = New System.Drawing.Point(276, 79)
        Me.lblDicose.Name = "lblDicose"
        Me.lblDicose.Size = New System.Drawing.Size(156, 17)
        Me.lblDicose.TabIndex = 10
        Me.lblDicose.Text = "Numero de DICOSE:"
        '
        'txtBps
        '
        Me.txtBps.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBps.Location = New System.Drawing.Point(706, 50)
        Me.txtBps.Multiline = True
        Me.txtBps.Name = "txtBps"
        Me.txtBps.Size = New System.Drawing.Size(148, 20)
        Me.txtBps.TabIndex = 9
        '
        'lblBps
        '
        Me.lblBps.AutoSize = True
        Me.lblBps.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBps.Location = New System.Drawing.Point(572, 50)
        Me.lblBps.Name = "lblBps"
        Me.lblBps.Size = New System.Drawing.Size(128, 17)
        Me.lblBps.TabIndex = 8
        Me.lblBps.Text = "Numero de BPS:"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(140, 79)
        Me.txtRut.Multiline = True
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(130, 20)
        Me.txtRut.TabIndex = 7
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(6, 82)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(128, 17)
        Me.lblRut.TabIndex = 6
        Me.lblRut.Text = "Numero de RUT:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(98, 50)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(230, 20)
        Me.txtUbicacion.TabIndex = 5
        '
        'cboDeptEstablecimiento
        '
        Me.cboDeptEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptEstablecimiento.FormattingEnabled = True
        Me.cboDeptEstablecimiento.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres", ""})
        Me.cboDeptEstablecimiento.Location = New System.Drawing.Point(678, 21)
        Me.cboDeptEstablecimiento.Name = "cboDeptEstablecimiento"
        Me.cboDeptEstablecimiento.Size = New System.Drawing.Size(176, 23)
        Me.cboDeptEstablecimiento.TabIndex = 4
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.Location = New System.Drawing.Point(555, 22)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(117, 17)
        Me.lblDepartamento.TabIndex = 3
        Me.lblDepartamento.Text = "Departamento:"
        '
        'txtNombreEstablecimiento
        '
        Me.txtNombreEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEstablecimiento.Location = New System.Drawing.Point(228, 22)
        Me.txtNombreEstablecimiento.Multiline = True
        Me.txtNombreEstablecimiento.Name = "txtNombreEstablecimiento"
        Me.txtNombreEstablecimiento.Size = New System.Drawing.Size(321, 20)
        Me.txtNombreEstablecimiento.TabIndex = 2
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(6, 53)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(86, 17)
        Me.lblUbicacion.TabIndex = 1
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'lblNombreEstablecimiento
        '
        Me.lblNombreEstablecimiento.AutoSize = True
        Me.lblNombreEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEstablecimiento.Location = New System.Drawing.Point(6, 25)
        Me.lblNombreEstablecimiento.Name = "lblNombreEstablecimiento"
        Me.lblNombreEstablecimiento.Size = New System.Drawing.Size(216, 17)
        Me.lblNombreEstablecimiento.TabIndex = 0
        Me.lblNombreEstablecimiento.Text = "Nombre del establecimiento:"
        '
        'groupPropietario
        '
        Me.groupPropietario.Controls.Add(Me.rdoNo)
        Me.groupPropietario.Controls.Add(Me.rdoSi)
        Me.groupPropietario.Controls.Add(Me.lblCorreo)
        Me.groupPropietario.Controls.Add(Me.cboDeptPropietario)
        Me.groupPropietario.Controls.Add(Me.lblDepartamento1)
        Me.groupPropietario.Controls.Add(Me.txtCorreo)
        Me.groupPropietario.Controls.Add(Me.txtDireccion)
        Me.groupPropietario.Controls.Add(Me.txtCi)
        Me.groupPropietario.Controls.Add(Me.txtTelefonoPropietario)
        Me.groupPropietario.Controls.Add(Me.txtApellido)
        Me.groupPropietario.Controls.Add(Me.txtNombrePropietario)
        Me.groupPropietario.Controls.Add(Me.lblCorreoElectronico)
        Me.groupPropietario.Controls.Add(Me.lblTelefonoPropietario)
        Me.groupPropietario.Controls.Add(Me.lblDireccion)
        Me.groupPropietario.Controls.Add(Me.lblCi)
        Me.groupPropietario.Controls.Add(Me.lblApellido)
        Me.groupPropietario.Controls.Add(Me.lblNombrePropietario)
        Me.groupPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPropietario.Location = New System.Drawing.Point(12, 194)
        Me.groupPropietario.Name = "groupPropietario"
        Me.groupPropietario.Size = New System.Drawing.Size(860, 117)
        Me.groupPropietario.TabIndex = 1
        Me.groupPropietario.TabStop = False
        Me.groupPropietario.Text = "Propietario"
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNo.Location = New System.Drawing.Point(247, 84)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(46, 21)
        Me.rdoNo.TabIndex = 16
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'rdoSi
        '
        Me.rdoSi.AutoSize = True
        Me.rdoSi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSi.Location = New System.Drawing.Point(191, 84)
        Me.rdoSi.Name = "rdoSi"
        Me.rdoSi.Size = New System.Drawing.Size(40, 21)
        Me.rdoSi.TabIndex = 15
        Me.rdoSi.TabStop = True
        Me.rdoSi.Text = "Si"
        Me.rdoSi.UseVisualStyleBackColor = True
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(9, 86)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(166, 17)
        Me.lblCorreo.TabIndex = 14
        Me.lblCorreo.Text = "¿Correo Electrónico?"
        '
        'cboDeptPropietario
        '
        Me.cboDeptPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptPropietario.FormattingEnabled = True
        Me.cboDeptPropietario.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDeptPropietario.Location = New System.Drawing.Point(678, 48)
        Me.cboDeptPropietario.Name = "cboDeptPropietario"
        Me.cboDeptPropietario.Size = New System.Drawing.Size(176, 23)
        Me.cboDeptPropietario.TabIndex = 13
        '
        'lblDepartamento1
        '
        Me.lblDepartamento1.AutoSize = True
        Me.lblDepartamento1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento1.Location = New System.Drawing.Point(555, 54)
        Me.lblDepartamento1.Name = "lblDepartamento1"
        Me.lblDepartamento1.Size = New System.Drawing.Size(117, 17)
        Me.lblDepartamento1.TabIndex = 12
        Me.lblDepartamento1.Text = "Departamento:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(480, 84)
        Me.txtCorreo.Multiline = True
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(262, 20)
        Me.txtCorreo.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(407, 53)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(142, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'txtCi
        '
        Me.txtCi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCi.Location = New System.Drawing.Point(170, 53)
        Me.txtCi.Multiline = True
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(136, 20)
        Me.txtCi.TabIndex = 9
        '
        'txtTelefonoPropietario
        '
        Me.txtTelefonoPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoPropietario.Location = New System.Drawing.Point(694, 22)
        Me.txtTelefonoPropietario.Multiline = True
        Me.txtTelefonoPropietario.Name = "txtTelefonoPropietario"
        Me.txtTelefonoPropietario.Size = New System.Drawing.Size(160, 20)
        Me.txtTelefonoPropietario.TabIndex = 8
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(389, 22)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(210, 20)
        Me.txtApellido.TabIndex = 7
        '
        'txtNombrePropietario
        '
        Me.txtNombrePropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePropietario.Location = New System.Drawing.Point(83, 22)
        Me.txtNombrePropietario.Multiline = True
        Me.txtNombrePropietario.Name = "txtNombrePropietario"
        Me.txtNombrePropietario.Size = New System.Drawing.Size(210, 20)
        Me.txtNombrePropietario.TabIndex = 6
        '
        'lblCorreoElectronico
        '
        Me.lblCorreoElectronico.AutoSize = True
        Me.lblCorreoElectronico.Enabled = False
        Me.lblCorreoElectronico.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoElectronico.Location = New System.Drawing.Point(311, 86)
        Me.lblCorreoElectronico.Name = "lblCorreoElectronico"
        Me.lblCorreoElectronico.Size = New System.Drawing.Size(153, 17)
        Me.lblCorreoElectronico.TabIndex = 5
        Me.lblCorreoElectronico.Text = "Correo Electrónico:"
        '
        'lblTelefonoPropietario
        '
        Me.lblTelefonoPropietario.AutoSize = True
        Me.lblTelefonoPropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoPropietario.Location = New System.Drawing.Point(612, 25)
        Me.lblTelefonoPropietario.Name = "lblTelefonoPropietario"
        Me.lblTelefonoPropietario.Size = New System.Drawing.Size(76, 17)
        Me.lblTelefonoPropietario.TabIndex = 4
        Me.lblTelefonoPropietario.Text = "Teléfono:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(317, 56)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(84, 17)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(6, 56)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(158, 17)
        Me.lblCi.TabIndex = 2
        Me.lblCi.Text = "Cédula de Identidad:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(311, 25)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(72, 17)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombrePropietario
        '
        Me.lblNombrePropietario.AutoSize = True
        Me.lblNombrePropietario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePropietario.Location = New System.Drawing.Point(6, 25)
        Me.lblNombrePropietario.Name = "lblNombrePropietario"
        Me.lblNombrePropietario.Size = New System.Drawing.Size(71, 17)
        Me.lblNombrePropietario.TabIndex = 0
        Me.lblNombrePropietario.Text = "Nombre:"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(296, 317)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(188, 39)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.Location = New System.Drawing.Point(490, 317)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(188, 39)
        Me.cmdLimpiar.TabIndex = 3
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(684, 317)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(188, 39)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmNuevoEstablecimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(884, 362)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.groupPropietario)
        Me.Controls.Add(Me.groupEstablecimiento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNuevoEstablecimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Nuevo Establecimiento"
        Me.groupEstablecimiento.ResumeLayout(False)
        Me.groupEstablecimiento.PerformLayout()
        Me.groupPropietario.ResumeLayout(False)
        Me.groupPropietario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupEstablecimiento As System.Windows.Forms.GroupBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents txtNombreEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents lblNombreEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboDeptEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents txtHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblSuperficie As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonoEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txtDicose As System.Windows.Forms.TextBox
    Friend WithEvents lblDicose As System.Windows.Forms.Label
    Friend WithEvents txtBps As System.Windows.Forms.TextBox
    Friend WithEvents lblBps As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblCant2 As System.Windows.Forms.Label
    Friend WithEvents txtCantPrimerShow As System.Windows.Forms.TextBox
    Friend WithEvents chkPrimerShow As System.Windows.Forms.CheckBox
    Friend WithEvents lblCant1 As System.Windows.Forms.Label
    Friend WithEvents txtCantHolando As System.Windows.Forms.TextBox
    Friend WithEvents chkHolando As System.Windows.Forms.CheckBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantJersey As System.Windows.Forms.TextBox
    Friend WithEvents chkJersey As System.Windows.Forms.CheckBox
    Friend WithEvents lblRazas As System.Windows.Forms.Label
    Friend WithEvents rdoManual As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMecanico As System.Windows.Forms.RadioButton
    Friend WithEvents lblOrdenie As System.Windows.Forms.Label
    Friend WithEvents txtCantidadAnimales As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadAnimales As System.Windows.Forms.Label
    Friend WithEvents cmdParametros As System.Windows.Forms.Button
    Friend WithEvents groupPropietario As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSi As System.Windows.Forms.RadioButton
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents cboDeptPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento1 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoPropietario As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombrePropietario As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreoElectronico As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoPropietario As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombrePropietario As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
