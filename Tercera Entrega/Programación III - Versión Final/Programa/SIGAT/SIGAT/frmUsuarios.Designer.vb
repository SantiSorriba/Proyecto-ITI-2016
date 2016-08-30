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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.lbl_ci = New System.Windows.Forms.Label()
        Me.txt_CedulaUsuario = New System.Windows.Forms.TextBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.group_Usuario = New System.Windows.Forms.GroupBox()
        Me.cmd_EliminarTel = New System.Windows.Forms.Button()
        Me.cmd_AgregarTel = New System.Windows.Forms.Button()
        Me.lbl_NomUsu = New System.Windows.Forms.Label()
        Me.cbo_Telefonos = New System.Windows.Forms.ComboBox()
        Me.cbo_Establecimiento = New System.Windows.Forms.ComboBox()
        Me.cbo_TipoUsuario = New System.Windows.Forms.ComboBox()
        Me.cbo_DptoUsuario = New System.Windows.Forms.ComboBox()
        Me.date_FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txt_DirUsuario = New System.Windows.Forms.TextBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Telefonos = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lbl_TrabajaEn = New System.Windows.Forms.Label()
        Me.lbl_DptoUsuario = New System.Windows.Forms.Label()
        Me.lbl_DirUsuario = New System.Windows.Forms.Label()
        Me.lbl_TipoUsuario = New System.Windows.Forms.Label()
        Me.lbl_FechaNac = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.group_Usuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_ci
        '
        Me.lbl_ci.AutoSize = True
        Me.lbl_ci.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ci.Location = New System.Drawing.Point(12, 19)
        Me.lbl_ci.Name = "lbl_ci"
        Me.lbl_ci.Size = New System.Drawing.Size(155, 19)
        Me.lbl_ci.TabIndex = 0
        Me.lbl_ci.Text = "Cédula de Identidad:"
        '
        'txt_CedulaUsuario
        '
        Me.txt_CedulaUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CedulaUsuario.Location = New System.Drawing.Point(173, 16)
        Me.txt_CedulaUsuario.Name = "txt_CedulaUsuario"
        Me.txt_CedulaUsuario.Size = New System.Drawing.Size(93, 27)
        Me.txt_CedulaUsuario.TabIndex = 1
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Buscar.Location = New System.Drawing.Point(272, 16)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(69, 27)
        Me.cmd_Buscar.TabIndex = 2
        Me.cmd_Buscar.Text = "Buscar "
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'group_Usuario
        '
        Me.group_Usuario.Controls.Add(Me.cmd_EliminarTel)
        Me.group_Usuario.Controls.Add(Me.cmd_AgregarTel)
        Me.group_Usuario.Controls.Add(Me.lbl_NomUsu)
        Me.group_Usuario.Controls.Add(Me.cbo_Telefonos)
        Me.group_Usuario.Controls.Add(Me.cbo_Establecimiento)
        Me.group_Usuario.Controls.Add(Me.cbo_TipoUsuario)
        Me.group_Usuario.Controls.Add(Me.cbo_DptoUsuario)
        Me.group_Usuario.Controls.Add(Me.date_FechaNac)
        Me.group_Usuario.Controls.Add(Me.txt_DirUsuario)
        Me.group_Usuario.Controls.Add(Me.txt_Apellido)
        Me.group_Usuario.Controls.Add(Me.txt_Usuario)
        Me.group_Usuario.Controls.Add(Me.lbl_Telefonos)
        Me.group_Usuario.Controls.Add(Me.lblNombreUsuario)
        Me.group_Usuario.Controls.Add(Me.lbl_TrabajaEn)
        Me.group_Usuario.Controls.Add(Me.lbl_DptoUsuario)
        Me.group_Usuario.Controls.Add(Me.lbl_DirUsuario)
        Me.group_Usuario.Controls.Add(Me.lbl_TipoUsuario)
        Me.group_Usuario.Controls.Add(Me.lbl_FechaNac)
        Me.group_Usuario.Controls.Add(Me.lbl_Apellido)
        Me.group_Usuario.Controls.Add(Me.lbl_Nombre)
        Me.group_Usuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Usuario.Location = New System.Drawing.Point(12, 52)
        Me.group_Usuario.Name = "group_Usuario"
        Me.group_Usuario.Size = New System.Drawing.Size(329, 316)
        Me.group_Usuario.TabIndex = 3
        Me.group_Usuario.TabStop = False
        Me.group_Usuario.Text = "Datos del usuario"
        '
        'cmd_EliminarTel
        '
        Me.cmd_EliminarTel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EliminarTel.Location = New System.Drawing.Point(257, 280)
        Me.cmd_EliminarTel.Name = "cmd_EliminarTel"
        Me.cmd_EliminarTel.Size = New System.Drawing.Size(61, 25)
        Me.cmd_EliminarTel.TabIndex = 19
        Me.cmd_EliminarTel.Text = "Eliminar"
        Me.cmd_EliminarTel.UseVisualStyleBackColor = True
        '
        'cmd_AgregarTel
        '
        Me.cmd_AgregarTel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarTel.Location = New System.Drawing.Point(193, 280)
        Me.cmd_AgregarTel.Name = "cmd_AgregarTel"
        Me.cmd_AgregarTel.Size = New System.Drawing.Size(61, 25)
        Me.cmd_AgregarTel.TabIndex = 18
        Me.cmd_AgregarTel.Text = "Agregar"
        Me.cmd_AgregarTel.UseVisualStyleBackColor = True
        '
        'lbl_NomUsu
        '
        Me.lbl_NomUsu.AutoSize = True
        Me.lbl_NomUsu.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomUsu.Location = New System.Drawing.Point(140, 219)
        Me.lbl_NomUsu.Name = "lbl_NomUsu"
        Me.lbl_NomUsu.Size = New System.Drawing.Size(127, 17)
        Me.lbl_NomUsu.TabIndex = 17
        Me.lbl_NomUsu.Text = "Nombre del usuario"
        '
        'cbo_Telefonos
        '
        Me.cbo_Telefonos.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Telefonos.FormattingEnabled = True
        Me.cbo_Telefonos.Location = New System.Drawing.Point(82, 280)
        Me.cbo_Telefonos.Name = "cbo_Telefonos"
        Me.cbo_Telefonos.Size = New System.Drawing.Size(106, 25)
        Me.cbo_Telefonos.TabIndex = 16
        '
        'cbo_Establecimiento
        '
        Me.cbo_Establecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimiento.FormattingEnabled = True
        Me.cbo_Establecimiento.Location = New System.Drawing.Point(82, 249)
        Me.cbo_Establecimiento.Name = "cbo_Establecimiento"
        Me.cbo_Establecimiento.Size = New System.Drawing.Size(236, 25)
        Me.cbo_Establecimiento.TabIndex = 15
        '
        'cbo_TipoUsuario
        '
        Me.cbo_TipoUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TipoUsuario.FormattingEnabled = True
        Me.cbo_TipoUsuario.Location = New System.Drawing.Point(142, 181)
        Me.cbo_TipoUsuario.Name = "cbo_TipoUsuario"
        Me.cbo_TipoUsuario.Size = New System.Drawing.Size(175, 25)
        Me.cbo_TipoUsuario.TabIndex = 14
        '
        'cbo_DptoUsuario
        '
        Me.cbo_DptoUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_DptoUsuario.FormattingEnabled = True
        Me.cbo_DptoUsuario.Location = New System.Drawing.Point(142, 150)
        Me.cbo_DptoUsuario.Name = "cbo_DptoUsuario"
        Me.cbo_DptoUsuario.Size = New System.Drawing.Size(131, 25)
        Me.cbo_DptoUsuario.TabIndex = 13
        '
        'date_FechaNac
        '
        Me.date_FechaNac.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaNac.Location = New System.Drawing.Point(143, 89)
        Me.date_FechaNac.Name = "date_FechaNac"
        Me.date_FechaNac.Size = New System.Drawing.Size(111, 24)
        Me.date_FechaNac.TabIndex = 12
        '
        'txt_DirUsuario
        '
        Me.txt_DirUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DirUsuario.Location = New System.Drawing.Point(79, 120)
        Me.txt_DirUsuario.Name = "txt_DirUsuario"
        Me.txt_DirUsuario.Size = New System.Drawing.Size(238, 24)
        Me.txt_DirUsuario.TabIndex = 11
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Apellido.Location = New System.Drawing.Point(142, 59)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(175, 24)
        Me.txt_Apellido.TabIndex = 10
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.Location = New System.Drawing.Point(142, 29)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(175, 24)
        Me.txt_Usuario.TabIndex = 9
        '
        'lbl_Telefonos
        '
        Me.lbl_Telefonos.AutoSize = True
        Me.lbl_Telefonos.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telefonos.Location = New System.Drawing.Point(6, 284)
        Me.lbl_Telefonos.Name = "lbl_Telefonos"
        Me.lbl_Telefonos.Size = New System.Drawing.Size(69, 17)
        Me.lbl_Telefonos.TabIndex = 8
        Me.lbl_Telefonos.Text = "Teléfonos:"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(6, 219)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(127, 17)
        Me.lblNombreUsuario.TabIndex = 7
        Me.lblNombreUsuario.Text = "Nombre de usuario:"
        '
        'lbl_TrabajaEn
        '
        Me.lbl_TrabajaEn.AutoSize = True
        Me.lbl_TrabajaEn.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TrabajaEn.Location = New System.Drawing.Point(6, 251)
        Me.lbl_TrabajaEn.Name = "lbl_TrabajaEn"
        Me.lbl_TrabajaEn.Size = New System.Drawing.Size(73, 17)
        Me.lbl_TrabajaEn.TabIndex = 6
        Me.lbl_TrabajaEn.Text = "Trabaja en:"
        '
        'lbl_DptoUsuario
        '
        Me.lbl_DptoUsuario.AutoSize = True
        Me.lbl_DptoUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DptoUsuario.Location = New System.Drawing.Point(6, 158)
        Me.lbl_DptoUsuario.Name = "lbl_DptoUsuario"
        Me.lbl_DptoUsuario.Size = New System.Drawing.Size(100, 17)
        Me.lbl_DptoUsuario.TabIndex = 5
        Me.lbl_DptoUsuario.Text = "Departamento:"
        '
        'lbl_DirUsuario
        '
        Me.lbl_DirUsuario.AutoSize = True
        Me.lbl_DirUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DirUsuario.Location = New System.Drawing.Point(6, 123)
        Me.lbl_DirUsuario.Name = "lbl_DirUsuario"
        Me.lbl_DirUsuario.Size = New System.Drawing.Size(67, 17)
        Me.lbl_DirUsuario.TabIndex = 4
        Me.lbl_DirUsuario.Text = "Dirección:"
        '
        'lbl_TipoUsuario
        '
        Me.lbl_TipoUsuario.AutoSize = True
        Me.lbl_TipoUsuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoUsuario.Location = New System.Drawing.Point(6, 189)
        Me.lbl_TipoUsuario.Name = "lbl_TipoUsuario"
        Me.lbl_TipoUsuario.Size = New System.Drawing.Size(103, 17)
        Me.lbl_TipoUsuario.TabIndex = 3
        Me.lbl_TipoUsuario.Text = "Tipo de usuario:"
        '
        'lbl_FechaNac
        '
        Me.lbl_FechaNac.AutoSize = True
        Me.lbl_FechaNac.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaNac.Location = New System.Drawing.Point(6, 92)
        Me.lbl_FechaNac.Name = "lbl_FechaNac"
        Me.lbl_FechaNac.Size = New System.Drawing.Size(134, 17)
        Me.lbl_FechaNac.TabIndex = 2
        Me.lbl_FechaNac.Text = "Fecha de nacimiento:"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(6, 62)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(129, 17)
        Me.lbl_Apellido.TabIndex = 1
        Me.lbl_Apellido.Text = "Apellido del usuario:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(6, 32)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(130, 17)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre del usuario:"
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Modificar.Location = New System.Drawing.Point(12, 374)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(138, 33)
        Me.cmd_Modificar.TabIndex = 4
        Me.cmd_Modificar.Text = "Modificar datos"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Volver.Location = New System.Drawing.Point(253, 374)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(88, 33)
        Me.cmd_Volver.TabIndex = 5
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(353, 413)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.group_Usuario)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.txt_CedulaUsuario)
        Me.Controls.Add(Me.lbl_ci)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Usuarios"
        Me.group_Usuario.ResumeLayout(False)
        Me.group_Usuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_ci As System.Windows.Forms.Label
    Friend WithEvents txt_CedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents group_Usuario As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TrabajaEn As System.Windows.Forms.Label
    Friend WithEvents lbl_DptoUsuario As System.Windows.Forms.Label
    Friend WithEvents lbl_DirUsuario As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoUsuario As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaNac As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents date_FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_DirUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefonos As System.Windows.Forms.Label
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lbl_NomUsu As System.Windows.Forms.Label
    Friend WithEvents cbo_Telefonos As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Establecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_TipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_DptoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_EliminarTel As System.Windows.Forms.Button
    Friend WithEvents cmd_AgregarTel As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
