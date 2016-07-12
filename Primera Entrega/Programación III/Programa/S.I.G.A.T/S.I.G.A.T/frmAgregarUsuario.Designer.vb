<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarUsuario))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cboDeptUsu = New System.Windows.Forms.ComboBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.dateFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rdoAdministradorEstablecimiento = New System.Windows.Forms.RadioButton()
        Me.rdoAdminstradorSistema = New System.Windows.Forms.RadioButton()
        Me.rdoGerente = New System.Windows.Forms.RadioButton()
        Me.rdoAuxiliar = New System.Windows.Forms.RadioButton()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtNomUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.cmdAgregarUsuario = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(3, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(76, 18)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(94, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(183, 22)
        Me.txtNombre.TabIndex = 1
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.Black
        Me.lblApellido.Location = New System.Drawing.Point(3, 46)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(77, 18)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(94, 44)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(183, 22)
        Me.txtApellido.TabIndex = 2
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.Black
        Me.lblCedula.Location = New System.Drawing.Point(3, 72)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(91, 18)
        Me.lblCedula.TabIndex = 4
        Me.lblCedula.Text = "Nº Cédula:"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(100, 70)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(177, 22)
        Me.txtCedula.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.Black
        Me.lblDireccion.Location = New System.Drawing.Point(3, 133)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(90, 18)
        Me.lblDireccion.TabIndex = 6
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.ForeColor = System.Drawing.Color.Black
        Me.lblDepartamento.Location = New System.Drawing.Point(3, 103)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(128, 18)
        Me.lblDepartamento.TabIndex = 7
        Me.lblDepartamento.Text = "Departamento:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(99, 131)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(178, 22)
        Me.txtDireccion.TabIndex = 5
        '
        'cboDeptUsu
        '
        Me.cboDeptUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptUsu.FormattingEnabled = True
        Me.cboDeptUsu.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDeptUsu.Location = New System.Drawing.Point(136, 101)
        Me.cboDeptUsu.Name = "cboDeptUsu"
        Me.cboDeptUsu.Size = New System.Drawing.Size(141, 20)
        Me.cboDeptUsu.TabIndex = 4
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.Black
        Me.lblTelefono.Location = New System.Drawing.Point(3, 161)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(82, 18)
        Me.lblTelefono.TabIndex = 15
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(99, 162)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(178, 22)
        Me.txtTelefono.TabIndex = 6
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.ForeColor = System.Drawing.Color.Black
        Me.lblFechaNac.Location = New System.Drawing.Point(3, 190)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(181, 18)
        Me.lblFechaNac.TabIndex = 17
        Me.lblFechaNac.Text = "Fecha de Nacimiento:"
        '
        'dateFechaNac
        '
        Me.dateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaNac.Location = New System.Drawing.Point(190, 190)
        Me.dateFechaNac.MaxDate = New Date(2016, 7, 7, 0, 0, 0, 0)
        Me.dateFechaNac.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateFechaNac.Name = "dateFechaNac"
        Me.dateFechaNac.Size = New System.Drawing.Size(87, 20)
        Me.dateFechaNac.TabIndex = 7
        Me.dateFechaNac.Value = New Date(1998, 1, 1, 0, 0, 0, 0)
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUsuario.Location = New System.Drawing.Point(81, 227)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(130, 18)
        Me.lblTipoUsuario.TabIndex = 19
        Me.lblTipoUsuario.Text = "Tipo de usuario"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(284, 562)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 8
        Me.LineShape2.X2 = 278
        Me.LineShape2.Y1 = 374
        Me.LineShape2.Y2 = 374
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 276
        Me.LineShape1.Y1 = 251
        Me.LineShape1.Y2 = 251
        '
        'rdoAdministradorEstablecimiento
        '
        Me.rdoAdministradorEstablecimiento.AutoSize = True
        Me.rdoAdministradorEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdministradorEstablecimiento.Location = New System.Drawing.Point(12, 294)
        Me.rdoAdministradorEstablecimiento.Name = "rdoAdministradorEstablecimiento"
        Me.rdoAdministradorEstablecimiento.Size = New System.Drawing.Size(265, 19)
        Me.rdoAdministradorEstablecimiento.TabIndex = 9
        Me.rdoAdministradorEstablecimiento.TabStop = True
        Me.rdoAdministradorEstablecimiento.Text = "Administrador de un Establecimiento"
        Me.rdoAdministradorEstablecimiento.UseVisualStyleBackColor = True
        '
        'rdoAdminstradorSistema
        '
        Me.rdoAdminstradorSistema.AutoSize = True
        Me.rdoAdminstradorSistema.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAdminstradorSistema.Location = New System.Drawing.Point(12, 269)
        Me.rdoAdminstradorSistema.Name = "rdoAdminstradorSistema"
        Me.rdoAdminstradorSistema.Size = New System.Drawing.Size(197, 19)
        Me.rdoAdminstradorSistema.TabIndex = 8
        Me.rdoAdminstradorSistema.TabStop = True
        Me.rdoAdminstradorSistema.Text = "Administrador del Sistema"
        Me.rdoAdminstradorSistema.UseVisualStyleBackColor = True
        '
        'rdoGerente
        '
        Me.rdoGerente.AutoSize = True
        Me.rdoGerente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoGerente.Location = New System.Drawing.Point(12, 319)
        Me.rdoGerente.Name = "rdoGerente"
        Me.rdoGerente.Size = New System.Drawing.Size(174, 19)
        Me.rdoGerente.TabIndex = 10
        Me.rdoGerente.TabStop = True
        Me.rdoGerente.Text = "Gerente Administrador"
        Me.rdoGerente.UseVisualStyleBackColor = True
        '
        'rdoAuxiliar
        '
        Me.rdoAuxiliar.AutoSize = True
        Me.rdoAuxiliar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAuxiliar.Location = New System.Drawing.Point(12, 344)
        Me.rdoAuxiliar.Name = "rdoAuxiliar"
        Me.rdoAuxiliar.Size = New System.Drawing.Size(129, 19)
        Me.rdoAuxiliar.TabIndex = 11
        Me.rdoAuxiliar.TabStop = True
        Me.rdoAuxiliar.Text = "Usuario Auxiliar"
        Me.rdoAuxiliar.UseVisualStyleBackColor = True
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(68, 387)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(159, 18)
        Me.lblNombreUsuario.TabIndex = 25
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenia.Location = New System.Drawing.Point(91, 441)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(102, 18)
        Me.lblContrasenia.TabIndex = 26
        Me.lblContrasenia.Text = "Contraseña"
        '
        'txtNomUsuario
        '
        Me.txtNomUsuario.Enabled = False
        Me.txtNomUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomUsuario.Location = New System.Drawing.Point(39, 408)
        Me.txtNomUsuario.Name = "txtNomUsuario"
        Me.txtNomUsuario.Size = New System.Drawing.Size(215, 22)
        Me.txtNomUsuario.TabIndex = 12
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Enabled = False
        Me.txtContrasenia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(39, 462)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(215, 22)
        Me.txtContrasenia.TabIndex = 13
        '
        'cmdAgregarUsuario
        '
        Me.cmdAgregarUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarUsuario.Location = New System.Drawing.Point(6, 499)
        Me.cmdAgregarUsuario.Name = "cmdAgregarUsuario"
        Me.cmdAgregarUsuario.Size = New System.Drawing.Size(125, 51)
        Me.cmdAgregarUsuario.TabIndex = 14
        Me.cmdAgregarUsuario.Text = "Agregar Usuario"
        Me.cmdAgregarUsuario.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(150, 499)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(127, 51)
        Me.cmdCancelar.TabIndex = 15
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmAgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(284, 562)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAgregarUsuario)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtNomUsuario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.rdoAuxiliar)
        Me.Controls.Add(Me.rdoGerente)
        Me.Controls.Add(Me.rdoAdminstradorSistema)
        Me.Controls.Add(Me.rdoAdministradorEstablecimiento)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.Controls.Add(Me.dateFechaNac)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.cboDeptUsu)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Agregar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cboDeptUsu As System.Windows.Forms.ComboBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents dateFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTipoUsuario As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents rdoAdministradorEstablecimiento As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAdminstradorSistema As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGerente As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAuxiliar As System.Windows.Forms.RadioButton
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents txtNomUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgregarUsuario As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
