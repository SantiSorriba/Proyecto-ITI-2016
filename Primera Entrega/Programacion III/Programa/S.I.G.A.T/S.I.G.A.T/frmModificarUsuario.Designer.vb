<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarUsuario))
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboDeptUsu = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNomUsuario = New System.Windows.Forms.TextBox()
        Me.cboTipoUsu = New System.Windows.Forms.ComboBox()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.dateFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblNombreUsu = New System.Windows.Forms.Label()
        Me.lblApellidoUsu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(4, 12)
        Me.lblCi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(69, 18)
        Me.lblCi.TabIndex = 0
        Me.lblCi.Text = "Cédula:"
        '
        'txtCi
        '
        Me.txtCi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCi.Location = New System.Drawing.Point(81, 11)
        Me.txtCi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(137, 22)
        Me.txtCi.TabIndex = 1
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(226, 7)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(95, 31)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(4, 60)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 17)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(4, 86)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(72, 17)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(4, 114)
        Me.lblNombreUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(154, 17)
        Me.lblNombreUsuario.TabIndex = 5
        Me.lblNombreUsuario.Text = "Nombre de Usuario:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(4, 143)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(76, 17)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Teléfono:"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 318
        Me.LineShape1.Y1 = 47
        Me.LineShape1.Y2 = 47
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(334, 342)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(5, 171)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(117, 17)
        Me.lblDepartamento.TabIndex = 8
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(5, 199)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(79, 17)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Dirección"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(5, 258)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(125, 17)
        Me.lblTipo.TabIndex = 10
        Me.lblTipo.Text = "Tipo de usuario:"
        '
        'cboDeptUsu
        '
        Me.cboDeptUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptUsu.FormattingEnabled = True
        Me.cboDeptUsu.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDeptUsu.Location = New System.Drawing.Point(128, 168)
        Me.cboDeptUsu.Name = "cboDeptUsu"
        Me.cboDeptUsu.Size = New System.Drawing.Size(191, 20)
        Me.cboDeptUsu.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(128, 197)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(191, 22)
        Me.txtDireccion.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(128, 138)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 22)
        Me.txtTelefono.TabIndex = 13
        '
        'txtNomUsuario
        '
        Me.txtNomUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomUsuario.Location = New System.Drawing.Point(165, 109)
        Me.txtNomUsuario.Name = "txtNomUsuario"
        Me.txtNomUsuario.Size = New System.Drawing.Size(154, 22)
        Me.txtNomUsuario.TabIndex = 14
        '
        'cboTipoUsu
        '
        Me.cboTipoUsu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUsu.FormattingEnabled = True
        Me.cboTipoUsu.Items.AddRange(New Object() {"Administrador del Sistema", "Administrador de un Establecimiento", "Gerente Administrador", "Usuario Auxiliar"})
        Me.cboTipoUsu.Location = New System.Drawing.Point(138, 253)
        Me.cboTipoUsu.Name = "cboTipoUsu"
        Me.cboTipoUsu.Size = New System.Drawing.Size(183, 22)
        Me.cboTipoUsu.TabIndex = 15
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(5, 227)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(164, 17)
        Me.lblFechaNac.TabIndex = 16
        Me.lblFechaNac.Text = "Fecha de nacimiento:"
        '
        'dateFechaNac
        '
        Me.dateFechaNac.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaNac.Location = New System.Drawing.Point(193, 225)
        Me.dateFechaNac.MaxDate = New Date(2016, 7, 7, 0, 0, 0, 0)
        Me.dateFechaNac.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateFechaNac.Name = "dateFechaNac"
        Me.dateFechaNac.Size = New System.Drawing.Size(104, 21)
        Me.dateFechaNac.TabIndex = 17
        Me.dateFechaNac.Value = New Date(1998, 1, 1, 0, 0, 0, 0)
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(7, 295)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(140, 37)
        Me.cmdModificar.TabIndex = 18
        Me.cmdModificar.Text = "Modificar Datos"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(179, 295)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(140, 37)
        Me.cmdCancelar.TabIndex = 19
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 7
        Me.LineShape2.X2 = 317
        Me.LineShape2.Y1 = 285
        Me.LineShape2.Y2 = 285
        '
        'lblNombreUsu
        '
        Me.lblNombreUsu.AutoSize = True
        Me.lblNombreUsu.Location = New System.Drawing.Point(125, 60)
        Me.lblNombreUsu.Name = "lblNombreUsu"
        Me.lblNombreUsu.Size = New System.Drawing.Size(153, 17)
        Me.lblNombreUsu.TabIndex = 20
        Me.lblNombreUsu.Text = "Nombre del Usuario"
        '
        'lblApellidoUsu
        '
        Me.lblApellidoUsu.AutoSize = True
        Me.lblApellidoUsu.Location = New System.Drawing.Point(125, 86)
        Me.lblApellidoUsu.Name = "lblApellidoUsu"
        Me.lblApellidoUsu.Size = New System.Drawing.Size(154, 17)
        Me.lblApellidoUsu.TabIndex = 21
        Me.lblApellidoUsu.Text = "Apellido del Usuario"
        '
        'frmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(334, 342)
        Me.Controls.Add(Me.lblApellidoUsu)
        Me.Controls.Add(Me.lblNombreUsu)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.dateFechaNac)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.cboTipoUsu)
        Me.Controls.Add(Me.txtNomUsuario)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.cboDeptUsu)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Modificar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboDeptUsu As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNomUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoUsu As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents dateFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblNombreUsu As System.Windows.Forms.Label
    Friend WithEvents lblApellidoUsu As System.Windows.Forms.Label
End Class
