<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.lblCi = New System.Windows.Forms.Label()
        Me.txtCi = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.panelUsuario = New System.Windows.Forms.Panel()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNomUsu = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cboDepartamentos = New System.Windows.Forms.ComboBox()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cboTelefonos = New System.Windows.Forms.ComboBox()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.panelUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Location = New System.Drawing.Point(12, 9)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(126, 16)
        Me.lblCi.TabIndex = 0
        Me.lblCi.Text = "Cédula de identidad:"
        '
        'txtCi
        '
        Me.txtCi.Location = New System.Drawing.Point(144, 6)
        Me.txtCi.Name = "txtCi"
        Me.txtCi.Size = New System.Drawing.Size(70, 22)
        Me.txtCi.TabIndex = 1
        Me.txtCi.Text = "51305728"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(220, 5)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 23)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar Usuario"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'panelUsuario
        '
        Me.panelUsuario.Controls.Add(Me.cmdModificar)
        Me.panelUsuario.Controls.Add(Me.cboTelefonos)
        Me.panelUsuario.Controls.Add(Me.cmdBorrar)
        Me.panelUsuario.Controls.Add(Me.cmdAgregar)
        Me.panelUsuario.Controls.Add(Me.cboTipoUsuario)
        Me.panelUsuario.Controls.Add(Me.cboDepartamentos)
        Me.panelUsuario.Controls.Add(Me.txtDireccion)
        Me.panelUsuario.Controls.Add(Me.txtNomUsu)
        Me.panelUsuario.Controls.Add(Me.txtApellido)
        Me.panelUsuario.Controls.Add(Me.txtNombre)
        Me.panelUsuario.Controls.Add(Me.lblTelefonos)
        Me.panelUsuario.Controls.Add(Me.lblNombreUsuario)
        Me.panelUsuario.Controls.Add(Me.lblDepartamento)
        Me.panelUsuario.Controls.Add(Me.lblDireccion)
        Me.panelUsuario.Controls.Add(Me.lblTipoUsuario)
        Me.panelUsuario.Controls.Add(Me.lblApellido)
        Me.panelUsuario.Controls.Add(Me.lblNombre)
        Me.panelUsuario.Location = New System.Drawing.Point(6, 34)
        Me.panelUsuario.Name = "panelUsuario"
        Me.panelUsuario.Size = New System.Drawing.Size(316, 244)
        Me.panelUsuario.TabIndex = 3
        Me.panelUsuario.Visible = False
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(4, 69)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(121, 16)
        Me.lblNombreUsuario.TabIndex = 5
        Me.lblNombreUsuario.Text = "Nombre de usuario:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(4, 155)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(93, 16)
        Me.lblDepartamento.TabIndex = 4
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(4, 127)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(66, 16)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Location = New System.Drawing.Point(4, 96)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(100, 16)
        Me.lblTipoUsuario.TabIndex = 2
        Me.lblTipoUsuario.Text = "Tipo de usuario:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(4, 42)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 16)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(4, 14)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Location = New System.Drawing.Point(4, 184)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(66, 16)
        Me.lblTelefonos.TabIndex = 6
        Me.lblTelefonos.Text = "Teléfonos:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(67, 11)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(108, 22)
        Me.txtNombre.TabIndex = 7
        Me.txtNombre.Text = "Jshfgdhrtyfhgdt"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(67, 39)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(108, 22)
        Me.txtApellido.TabIndex = 8
        Me.txtApellido.Text = "Jshfgdhrtyfhgdt"
        '
        'txtNomUsu
        '
        Me.txtNomUsu.Location = New System.Drawing.Point(131, 67)
        Me.txtNomUsu.Name = "txtNomUsu"
        Me.txtNomUsu.Size = New System.Drawing.Size(108, 22)
        Me.txtNomUsu.TabIndex = 9
        Me.txtNomUsu.Text = "Jshfgdhrtyfhgdt"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(76, 125)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(180, 22)
        Me.txtDireccion.TabIndex = 10
        Me.txtDireccion.Text = "Jshfgdhrtyfhgdt7465746354"
        '
        'cboDepartamentos
        '
        Me.cboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamentos.FormattingEnabled = True
        Me.cboDepartamentos.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cboDepartamentos.Location = New System.Drawing.Point(103, 152)
        Me.cboDepartamentos.MaxLength = 15
        Me.cboDepartamentos.Name = "cboDepartamentos"
        Me.cboDepartamentos.Size = New System.Drawing.Size(121, 24)
        Me.cboDepartamentos.TabIndex = 12
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Items.AddRange(New Object() {"Administrador de establecimiento"})
        Me.cboTipoUsuario.Location = New System.Drawing.Point(110, 95)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(203, 23)
        Me.cboTipoUsuario.TabIndex = 13
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(178, 180)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 14
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Location = New System.Drawing.Point(259, 180)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(51, 23)
        Me.cmdBorrar.TabIndex = 4
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cboTelefonos
        '
        Me.cboTelefonos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTelefonos.FormattingEnabled = True
        Me.cboTelefonos.Items.AddRange(New Object() {"323213", "312321412", "453534"})
        Me.cboTelefonos.Location = New System.Drawing.Point(80, 181)
        Me.cboTelefonos.MaxDropDownItems = 10
        Me.cboTelefonos.Name = "cboTelefonos"
        Me.cboTelefonos.Size = New System.Drawing.Size(92, 23)
        Me.cboTelefonos.TabIndex = 18
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(9, 212)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(301, 29)
        Me.cmdModificar.TabIndex = 4
        Me.cmdModificar.Text = "Modificar datos"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(244, 284)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(331, 311)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.panelUsuario)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtCi)
        Me.Controls.Add(Me.lblCi)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.Text = "Usuarios"
        Me.panelUsuario.ResumeLayout(False)
        Me.panelUsuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtCi As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents panelUsuario As System.Windows.Forms.Panel
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTipoUsuario As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNomUsu As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonos As System.Windows.Forms.Label
    Friend WithEvents cboDepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cboTipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cboTelefonos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
