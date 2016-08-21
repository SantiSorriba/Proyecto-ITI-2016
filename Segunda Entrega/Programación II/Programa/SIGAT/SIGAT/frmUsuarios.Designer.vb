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
        Me.lbl_Cedula = New System.Windows.Forms.Label()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.lbl_Cedula1 = New System.Windows.Forms.Label()
        Me.txt_Cedula2 = New System.Windows.Forms.TextBox()
        Me.lbl_TipoUsuario = New System.Windows.Forms.Label()
        Me.cbo_TipoUsuario = New System.Windows.Forms.ComboBox()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.txt_Dirección = New System.Windows.Forms.TextBox()
        Me.lbl_Departamento = New System.Windows.Forms.Label()
        Me.cbo_Departamentos = New System.Windows.Forms.ComboBox()
        Me.lbl_Teléfonos = New System.Windows.Forms.Label()
        Me.cbo_Telefonos = New System.Windows.Forms.ComboBox()
        Me.cmd_AgregarTel = New System.Windows.Forms.Button()
        Me.cmd_EliminarTel = New System.Windows.Forms.Button()
        Me.panel_Usuario = New System.Windows.Forms.Panel()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.panel_Usuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Cedula
        '
        Me.lbl_Cedula.AutoSize = True
        Me.lbl_Cedula.Location = New System.Drawing.Point(6, 8)
        Me.lbl_Cedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Cedula.Name = "lbl_Cedula"
        Me.lbl_Cedula.Size = New System.Drawing.Size(140, 17)
        Me.lbl_Cedula.TabIndex = 0
        Me.lbl_Cedula.Text = "Cédula de identidad:"
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(151, 5)
        Me.txt_Cedula.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(76, 25)
        Me.txt_Cedula.TabIndex = 1
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(239, 5)
        Me.cmd_Buscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(97, 24)
        Me.cmd_Buscar.TabIndex = 2
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(6, 13)
        Me.lbl_Nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(64, 17)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(74, 10)
        Me.txt_Nombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(150, 25)
        Me.txt_Nombre.TabIndex = 4
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(8, 44)
        Me.lbl_Apellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(62, 17)
        Me.lbl_Apellido.TabIndex = 5
        Me.lbl_Apellido.Text = "Apellido:"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Apellido.Location = New System.Drawing.Point(74, 41)
        Me.txt_Apellido.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(150, 25)
        Me.txt_Apellido.TabIndex = 6
        '
        'lbl_Cedula1
        '
        Me.lbl_Cedula1.AutoSize = True
        Me.lbl_Cedula1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cedula1.Location = New System.Drawing.Point(8, 75)
        Me.lbl_Cedula1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Cedula1.Name = "lbl_Cedula1"
        Me.lbl_Cedula1.Size = New System.Drawing.Size(58, 17)
        Me.lbl_Cedula1.TabIndex = 7
        Me.lbl_Cedula1.Text = "Cédula:"
        '
        'txt_Cedula2
        '
        Me.txt_Cedula2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cedula2.Location = New System.Drawing.Point(74, 72)
        Me.txt_Cedula2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Cedula2.Name = "txt_Cedula2"
        Me.txt_Cedula2.Size = New System.Drawing.Size(76, 25)
        Me.txt_Cedula2.TabIndex = 8
        '
        'lbl_TipoUsuario
        '
        Me.lbl_TipoUsuario.AutoSize = True
        Me.lbl_TipoUsuario.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoUsuario.Location = New System.Drawing.Point(7, 105)
        Me.lbl_TipoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_TipoUsuario.Name = "lbl_TipoUsuario"
        Me.lbl_TipoUsuario.Size = New System.Drawing.Size(111, 17)
        Me.lbl_TipoUsuario.TabIndex = 9
        Me.lbl_TipoUsuario.Text = "Tipo de usuario:"
        '
        'cbo_TipoUsuario
        '
        Me.cbo_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_TipoUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TipoUsuario.FormattingEnabled = True
        Me.cbo_TipoUsuario.Items.AddRange(New Object() {"Administrador del sistema"})
        Me.cbo_TipoUsuario.Location = New System.Drawing.Point(122, 103)
        Me.cbo_TipoUsuario.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbo_TipoUsuario.Name = "cbo_TipoUsuario"
        Me.cbo_TipoUsuario.Size = New System.Drawing.Size(208, 24)
        Me.cbo_TipoUsuario.TabIndex = 10
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Direccion.Location = New System.Drawing.Point(8, 136)
        Me.lbl_Direccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(74, 17)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Dirección:"
        '
        'txt_Dirección
        '
        Me.txt_Dirección.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Dirección.Location = New System.Drawing.Point(88, 133)
        Me.txt_Dirección.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_Dirección.Name = "txt_Dirección"
        Me.txt_Dirección.Size = New System.Drawing.Size(238, 25)
        Me.txt_Dirección.TabIndex = 12
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Departamento.Location = New System.Drawing.Point(8, 167)
        Me.lbl_Departamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(105, 17)
        Me.lbl_Departamento.TabIndex = 13
        Me.lbl_Departamento.Text = "Departamento:"
        '
        'cbo_Departamentos
        '
        Me.cbo_Departamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Departamentos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Departamentos.FormattingEnabled = True
        Me.cbo_Departamentos.Items.AddRange(New Object() {"Artigas", "Canelones", "Cerro Largo", "Colonia", "Durazno", "Flores", "Florida", "Lavalleja", "Maldonado", "Montevideo", "Paysandú", "Rio Negro", "Rivera", "Rocha", "Salto", "San José", "Soriano", "Tacuarembó", "Treinta y Tres"})
        Me.cbo_Departamentos.Location = New System.Drawing.Point(117, 164)
        Me.cbo_Departamentos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbo_Departamentos.MaxLength = 15
        Me.cbo_Departamentos.Name = "cbo_Departamentos"
        Me.cbo_Departamentos.Size = New System.Drawing.Size(151, 25)
        Me.cbo_Departamentos.TabIndex = 14
        '
        'lbl_Teléfonos
        '
        Me.lbl_Teléfonos.AutoSize = True
        Me.lbl_Teléfonos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Teléfonos.Location = New System.Drawing.Point(8, 218)
        Me.lbl_Teléfonos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Teléfonos.Name = "lbl_Teléfonos"
        Me.lbl_Teléfonos.Size = New System.Drawing.Size(74, 17)
        Me.lbl_Teléfonos.TabIndex = 15
        Me.lbl_Teléfonos.Text = "Teléfonos:"
        '
        'cbo_Telefonos
        '
        Me.cbo_Telefonos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Telefonos.FormattingEnabled = True
        Me.cbo_Telefonos.Location = New System.Drawing.Point(93, 215)
        Me.cbo_Telefonos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbo_Telefonos.Name = "cbo_Telefonos"
        Me.cbo_Telefonos.Size = New System.Drawing.Size(108, 25)
        Me.cbo_Telefonos.TabIndex = 16
        '
        'cmd_AgregarTel
        '
        Me.cmd_AgregarTel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarTel.Location = New System.Drawing.Point(205, 213)
        Me.cmd_AgregarTel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_AgregarTel.Name = "cmd_AgregarTel"
        Me.cmd_AgregarTel.Size = New System.Drawing.Size(118, 26)
        Me.cmd_AgregarTel.TabIndex = 17
        Me.cmd_AgregarTel.Text = "Agregar telefono"
        Me.cmd_AgregarTel.UseVisualStyleBackColor = True
        '
        'cmd_EliminarTel
        '
        Me.cmd_EliminarTel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EliminarTel.Location = New System.Drawing.Point(205, 244)
        Me.cmd_EliminarTel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd_EliminarTel.Name = "cmd_EliminarTel"
        Me.cmd_EliminarTel.Size = New System.Drawing.Size(118, 26)
        Me.cmd_EliminarTel.TabIndex = 18
        Me.cmd_EliminarTel.Text = "Eliminar telefono"
        Me.cmd_EliminarTel.UseVisualStyleBackColor = True
        '
        'panel_Usuario
        '
        Me.panel_Usuario.Controls.Add(Me.cmd_EliminarTel)
        Me.panel_Usuario.Controls.Add(Me.cmd_AgregarTel)
        Me.panel_Usuario.Controls.Add(Me.cbo_Telefonos)
        Me.panel_Usuario.Controls.Add(Me.lbl_Teléfonos)
        Me.panel_Usuario.Controls.Add(Me.cbo_Departamentos)
        Me.panel_Usuario.Controls.Add(Me.lbl_Departamento)
        Me.panel_Usuario.Controls.Add(Me.txt_Dirección)
        Me.panel_Usuario.Controls.Add(Me.lbl_Direccion)
        Me.panel_Usuario.Controls.Add(Me.cbo_TipoUsuario)
        Me.panel_Usuario.Controls.Add(Me.lbl_TipoUsuario)
        Me.panel_Usuario.Controls.Add(Me.txt_Cedula2)
        Me.panel_Usuario.Controls.Add(Me.lbl_Cedula1)
        Me.panel_Usuario.Controls.Add(Me.txt_Apellido)
        Me.panel_Usuario.Controls.Add(Me.lbl_Apellido)
        Me.panel_Usuario.Controls.Add(Me.txt_Nombre)
        Me.panel_Usuario.Controls.Add(Me.lbl_Nombre)
        Me.panel_Usuario.Enabled = False
        Me.panel_Usuario.Location = New System.Drawing.Point(5, 41)
        Me.panel_Usuario.Name = "panel_Usuario"
        Me.panel_Usuario.Size = New System.Drawing.Size(331, 279)
        Me.panel_Usuario.TabIndex = 19
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Enabled = False
        Me.cmd_Modificar.Location = New System.Drawing.Point(5, 326)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(123, 28)
        Me.cmd_Modificar.TabIndex = 20
        Me.cmd_Modificar.Text = "Modificar datos"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(261, 326)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(75, 28)
        Me.cmd_Volver.TabIndex = 21
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(343, 362)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.panel_Usuario)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.txt_Cedula)
        Me.Controls.Add(Me.lbl_Cedula)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos generales de usuarios"
        Me.panel_Usuario.ResumeLayout(False)
        Me.panel_Usuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Cedula As System.Windows.Forms.Label
    Friend WithEvents txt_Cedula As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cedula1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cedula2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TipoUsuario As System.Windows.Forms.Label
    Friend WithEvents cbo_TipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents txt_Dirección As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents cbo_Departamentos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Teléfonos As System.Windows.Forms.Label
    Friend WithEvents cbo_Telefonos As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_AgregarTel As System.Windows.Forms.Button
    Friend WithEvents cmd_EliminarTel As System.Windows.Forms.Button
    Friend WithEvents panel_Usuario As System.Windows.Forms.Panel
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
