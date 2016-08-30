<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmAnimales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmAnimales))
        Me.lbl_NroAnimal = New System.Windows.Forms.Label()
        Me.txt_NroIdentificador = New System.Windows.Forms.TextBox()
        Me.cmd_BuscarAnimal = New System.Windows.Forms.Button()
        Me.group_Animal = New System.Windows.Forms.GroupBox()
        Me.cbo_LugarActual = New System.Windows.Forms.ComboBox()
        Me.lbl_LugarActual = New System.Windows.Forms.Label()
        Me.date_FechaNacAnimal = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaNacimiento = New System.Windows.Forms.Label()
        Me.rdo_Hembra = New System.Windows.Forms.RadioButton()
        Me.rdo_Macho = New System.Windows.Forms.RadioButton()
        Me.lbl_SexoAnimal = New System.Windows.Forms.Label()
        Me.cbo_Establecimiento = New System.Windows.Forms.ComboBox()
        Me.txt_Raza = New System.Windows.Forms.TextBox()
        Me.lbl_Raza = New System.Windows.Forms.Label()
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.cbo_TipoAnimal = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoAnimal = New System.Windows.Forms.Label()
        Me.txt_NombreAnimal = New System.Windows.Forms.TextBox()
        Me.lbl_NombreAnimal = New System.Windows.Forms.Label()
        Me.cmd_VerificarNumero = New System.Windows.Forms.Button()
        Me.txt_NroIdentificador2 = New System.Windows.Forms.TextBox()
        Me.lbl_NroAnimal2 = New System.Windows.Forms.Label()
        Me.cmd_AgregarAnimal = New System.Windows.Forms.Button()
        Me.cmd_ModificarAnimal = New System.Windows.Forms.Button()
        Me.cmd_EliminarAnimal = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.group_Animal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NroAnimal
        '
        Me.lbl_NroAnimal.AutoSize = True
        Me.lbl_NroAnimal.Location = New System.Drawing.Point(7, 9)
        Me.lbl_NroAnimal.Name = "lbl_NroAnimal"
        Me.lbl_NroAnimal.Size = New System.Drawing.Size(203, 17)
        Me.lbl_NroAnimal.TabIndex = 0
        Me.lbl_NroAnimal.Text = "Número identificador del animal:"
        '
        'txt_NroIdentificador
        '
        Me.txt_NroIdentificador.Location = New System.Drawing.Point(220, 6)
        Me.txt_NroIdentificador.Name = "txt_NroIdentificador"
        Me.txt_NroIdentificador.Size = New System.Drawing.Size(58, 24)
        Me.txt_NroIdentificador.TabIndex = 1
        '
        'cmd_BuscarAnimal
        '
        Me.cmd_BuscarAnimal.Location = New System.Drawing.Point(292, 6)
        Me.cmd_BuscarAnimal.Name = "cmd_BuscarAnimal"
        Me.cmd_BuscarAnimal.Size = New System.Drawing.Size(75, 24)
        Me.cmd_BuscarAnimal.TabIndex = 2
        Me.cmd_BuscarAnimal.Text = "Buscar"
        Me.cmd_BuscarAnimal.UseVisualStyleBackColor = True
        '
        'group_Animal
        '
        Me.group_Animal.Controls.Add(Me.cbo_LugarActual)
        Me.group_Animal.Controls.Add(Me.lbl_LugarActual)
        Me.group_Animal.Controls.Add(Me.date_FechaNacAnimal)
        Me.group_Animal.Controls.Add(Me.lbl_FechaNacimiento)
        Me.group_Animal.Controls.Add(Me.rdo_Hembra)
        Me.group_Animal.Controls.Add(Me.rdo_Macho)
        Me.group_Animal.Controls.Add(Me.lbl_SexoAnimal)
        Me.group_Animal.Controls.Add(Me.cbo_Establecimiento)
        Me.group_Animal.Controls.Add(Me.txt_Raza)
        Me.group_Animal.Controls.Add(Me.lbl_Raza)
        Me.group_Animal.Controls.Add(Me.lbl_Establecimiento)
        Me.group_Animal.Controls.Add(Me.cbo_TipoAnimal)
        Me.group_Animal.Controls.Add(Me.lbl_TipoAnimal)
        Me.group_Animal.Controls.Add(Me.txt_NombreAnimal)
        Me.group_Animal.Controls.Add(Me.lbl_NombreAnimal)
        Me.group_Animal.Controls.Add(Me.cmd_VerificarNumero)
        Me.group_Animal.Controls.Add(Me.txt_NroIdentificador2)
        Me.group_Animal.Controls.Add(Me.lbl_NroAnimal2)
        Me.group_Animal.Enabled = False
        Me.group_Animal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Animal.Location = New System.Drawing.Point(12, 53)
        Me.group_Animal.Name = "group_Animal"
        Me.group_Animal.Size = New System.Drawing.Size(355, 287)
        Me.group_Animal.TabIndex = 3
        Me.group_Animal.TabStop = False
        Me.group_Animal.Text = "Datos del animal"
        '
        'cbo_LugarActual
        '
        Me.cbo_LugarActual.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_LugarActual.FormattingEnabled = True
        Me.cbo_LugarActual.Location = New System.Drawing.Point(151, 250)
        Me.cbo_LugarActual.Name = "cbo_LugarActual"
        Me.cbo_LugarActual.Size = New System.Drawing.Size(198, 25)
        Me.cbo_LugarActual.TabIndex = 21
        '
        'lbl_LugarActual
        '
        Me.lbl_LugarActual.AutoSize = True
        Me.lbl_LugarActual.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LugarActual.Location = New System.Drawing.Point(6, 253)
        Me.lbl_LugarActual.Name = "lbl_LugarActual"
        Me.lbl_LugarActual.Size = New System.Drawing.Size(85, 17)
        Me.lbl_LugarActual.TabIndex = 20
        Me.lbl_LugarActual.Text = "Lugar actual:"
        '
        'date_FechaNacAnimal
        '
        Me.date_FechaNacAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaNacAnimal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaNacAnimal.Location = New System.Drawing.Point(151, 217)
        Me.date_FechaNacAnimal.Name = "date_FechaNacAnimal"
        Me.date_FechaNacAnimal.Size = New System.Drawing.Size(114, 24)
        Me.date_FechaNacAnimal.TabIndex = 19
        '
        'lbl_FechaNacimiento
        '
        Me.lbl_FechaNacimiento.AutoSize = True
        Me.lbl_FechaNacimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaNacimiento.Location = New System.Drawing.Point(6, 219)
        Me.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento"
        Me.lbl_FechaNacimiento.Size = New System.Drawing.Size(134, 17)
        Me.lbl_FechaNacimiento.TabIndex = 18
        Me.lbl_FechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'rdo_Hembra
        '
        Me.rdo_Hembra.AutoSize = True
        Me.rdo_Hembra.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Hembra.Location = New System.Drawing.Point(241, 187)
        Me.rdo_Hembra.Name = "rdo_Hembra"
        Me.rdo_Hembra.Size = New System.Drawing.Size(75, 21)
        Me.rdo_Hembra.TabIndex = 17
        Me.rdo_Hembra.TabStop = True
        Me.rdo_Hembra.Text = "Hembra"
        Me.rdo_Hembra.UseVisualStyleBackColor = True
        '
        'rdo_Macho
        '
        Me.rdo_Macho.AutoSize = True
        Me.rdo_Macho.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Macho.Location = New System.Drawing.Point(151, 187)
        Me.rdo_Macho.Name = "rdo_Macho"
        Me.rdo_Macho.Size = New System.Drawing.Size(68, 21)
        Me.rdo_Macho.TabIndex = 16
        Me.rdo_Macho.TabStop = True
        Me.rdo_Macho.Text = "Macho"
        Me.rdo_Macho.UseVisualStyleBackColor = True
        '
        'lbl_SexoAnimal
        '
        Me.lbl_SexoAnimal.AutoSize = True
        Me.lbl_SexoAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SexoAnimal.Location = New System.Drawing.Point(6, 189)
        Me.lbl_SexoAnimal.Name = "lbl_SexoAnimal"
        Me.lbl_SexoAnimal.Size = New System.Drawing.Size(103, 17)
        Me.lbl_SexoAnimal.TabIndex = 15
        Me.lbl_SexoAnimal.Text = "Sexo del animal:"
        '
        'cbo_Establecimiento
        '
        Me.cbo_Establecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimiento.FormattingEnabled = True
        Me.cbo_Establecimiento.Location = New System.Drawing.Point(151, 94)
        Me.cbo_Establecimiento.Name = "cbo_Establecimiento"
        Me.cbo_Establecimiento.Size = New System.Drawing.Size(198, 25)
        Me.cbo_Establecimiento.TabIndex = 10
        '
        'txt_Raza
        '
        Me.txt_Raza.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Raza.Location = New System.Drawing.Point(151, 155)
        Me.txt_Raza.Name = "txt_Raza"
        Me.txt_Raza.Size = New System.Drawing.Size(176, 24)
        Me.txt_Raza.TabIndex = 14
        '
        'lbl_Raza
        '
        Me.lbl_Raza.AutoSize = True
        Me.lbl_Raza.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Raza.Location = New System.Drawing.Point(6, 158)
        Me.lbl_Raza.Name = "lbl_Raza"
        Me.lbl_Raza.Size = New System.Drawing.Size(103, 17)
        Me.lbl_Raza.TabIndex = 13
        Me.lbl_Raza.Text = "Raza del animal:"
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(6, 97)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(106, 17)
        Me.lbl_Establecimiento.TabIndex = 9
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'cbo_TipoAnimal
        '
        Me.cbo_TipoAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TipoAnimal.FormattingEnabled = True
        Me.cbo_TipoAnimal.Location = New System.Drawing.Point(151, 63)
        Me.cbo_TipoAnimal.Name = "cbo_TipoAnimal"
        Me.cbo_TipoAnimal.Size = New System.Drawing.Size(165, 25)
        Me.cbo_TipoAnimal.TabIndex = 8
        '
        'lbl_TipoAnimal
        '
        Me.lbl_TipoAnimal.AutoSize = True
        Me.lbl_TipoAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoAnimal.Location = New System.Drawing.Point(6, 66)
        Me.lbl_TipoAnimal.Name = "lbl_TipoAnimal"
        Me.lbl_TipoAnimal.Size = New System.Drawing.Size(98, 17)
        Me.lbl_TipoAnimal.TabIndex = 7
        Me.lbl_TipoAnimal.Text = "Tipo de animal:"
        '
        'txt_NombreAnimal
        '
        Me.txt_NombreAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreAnimal.Location = New System.Drawing.Point(151, 125)
        Me.txt_NombreAnimal.Name = "txt_NombreAnimal"
        Me.txt_NombreAnimal.Size = New System.Drawing.Size(153, 24)
        Me.txt_NombreAnimal.TabIndex = 12
        '
        'lbl_NombreAnimal
        '
        Me.lbl_NombreAnimal.AutoSize = True
        Me.lbl_NombreAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreAnimal.Location = New System.Drawing.Point(6, 128)
        Me.lbl_NombreAnimal.Name = "lbl_NombreAnimal"
        Me.lbl_NombreAnimal.Size = New System.Drawing.Size(125, 17)
        Me.lbl_NombreAnimal.TabIndex = 11
        Me.lbl_NombreAnimal.Text = "Nombre del animal:"
        '
        'cmd_VerificarNumero
        '
        Me.cmd_VerificarNumero.Enabled = False
        Me.cmd_VerificarNumero.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_VerificarNumero.Location = New System.Drawing.Point(215, 31)
        Me.cmd_VerificarNumero.Name = "cmd_VerificarNumero"
        Me.cmd_VerificarNumero.Size = New System.Drawing.Size(122, 26)
        Me.cmd_VerificarNumero.TabIndex = 6
        Me.cmd_VerificarNumero.Text = "Verificar numero"
        Me.cmd_VerificarNumero.UseVisualStyleBackColor = True
        '
        'txt_NroIdentificador2
        '
        Me.txt_NroIdentificador2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroIdentificador2.Location = New System.Drawing.Point(151, 33)
        Me.txt_NroIdentificador2.Name = "txt_NroIdentificador2"
        Me.txt_NroIdentificador2.Size = New System.Drawing.Size(58, 24)
        Me.txt_NroIdentificador2.TabIndex = 5
        '
        'lbl_NroAnimal2
        '
        Me.lbl_NroAnimal2.AutoSize = True
        Me.lbl_NroAnimal2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroAnimal2.Location = New System.Drawing.Point(6, 36)
        Me.lbl_NroAnimal2.Name = "lbl_NroAnimal2"
        Me.lbl_NroAnimal2.Size = New System.Drawing.Size(139, 17)
        Me.lbl_NroAnimal2.TabIndex = 4
        Me.lbl_NroAnimal2.Text = "Número identificador:"
        '
        'cmd_AgregarAnimal
        '
        Me.cmd_AgregarAnimal.Enabled = False
        Me.cmd_AgregarAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarAnimal.Location = New System.Drawing.Point(12, 346)
        Me.cmd_AgregarAnimal.Name = "cmd_AgregarAnimal"
        Me.cmd_AgregarAnimal.Size = New System.Drawing.Size(76, 31)
        Me.cmd_AgregarAnimal.TabIndex = 22
        Me.cmd_AgregarAnimal.Text = "Registrar"
        Me.cmd_AgregarAnimal.UseVisualStyleBackColor = True
        '
        'cmd_ModificarAnimal
        '
        Me.cmd_ModificarAnimal.Enabled = False
        Me.cmd_ModificarAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ModificarAnimal.Location = New System.Drawing.Point(94, 346)
        Me.cmd_ModificarAnimal.Name = "cmd_ModificarAnimal"
        Me.cmd_ModificarAnimal.Size = New System.Drawing.Size(76, 31)
        Me.cmd_ModificarAnimal.TabIndex = 23
        Me.cmd_ModificarAnimal.Text = "Modificar"
        Me.cmd_ModificarAnimal.UseVisualStyleBackColor = True
        '
        'cmd_EliminarAnimal
        '
        Me.cmd_EliminarAnimal.Enabled = False
        Me.cmd_EliminarAnimal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EliminarAnimal.Location = New System.Drawing.Point(176, 346)
        Me.cmd_EliminarAnimal.Name = "cmd_EliminarAnimal"
        Me.cmd_EliminarAnimal.Size = New System.Drawing.Size(76, 31)
        Me.cmd_EliminarAnimal.TabIndex = 24
        Me.cmd_EliminarAnimal.Text = "Eliminar"
        Me.cmd_EliminarAnimal.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Volver.Location = New System.Drawing.Point(292, 346)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(76, 31)
        Me.cmd_Volver.TabIndex = 25
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmAdmAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(379, 384)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_EliminarAnimal)
        Me.Controls.Add(Me.cmd_ModificarAnimal)
        Me.Controls.Add(Me.cmd_AgregarAnimal)
        Me.Controls.Add(Me.group_Animal)
        Me.Controls.Add(Me.cmd_BuscarAnimal)
        Me.Controls.Add(Me.txt_NroIdentificador)
        Me.Controls.Add(Me.lbl_NroAnimal)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAdmAnimales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de animales"
        Me.group_Animal.ResumeLayout(False)
        Me.group_Animal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NroAnimal As System.Windows.Forms.Label
    Friend WithEvents txt_NroIdentificador As System.Windows.Forms.TextBox
    Friend WithEvents cmd_BuscarAnimal As System.Windows.Forms.Button
    Friend WithEvents group_Animal As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Raza As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Raza As System.Windows.Forms.Label
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_TipoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoAnimal As System.Windows.Forms.Label
    Friend WithEvents txt_NombreAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombreAnimal As System.Windows.Forms.Label
    Friend WithEvents cmd_VerificarNumero As System.Windows.Forms.Button
    Friend WithEvents txt_NroIdentificador2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NroAnimal2 As System.Windows.Forms.Label
    Friend WithEvents cbo_LugarActual As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_LugarActual As System.Windows.Forms.Label
    Friend WithEvents date_FechaNacAnimal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents rdo_Hembra As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Macho As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_SexoAnimal As System.Windows.Forms.Label
    Friend WithEvents cbo_Establecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_AgregarAnimal As System.Windows.Forms.Button
    Friend WithEvents cmd_ModificarAnimal As System.Windows.Forms.Button
    Friend WithEvents cmd_EliminarAnimal As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
