<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminAnimales
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
        Me.lbl_NroIdentificador1 = New System.Windows.Forms.Label()
        Me.txt_NroIdentificador1 = New System.Windows.Forms.TextBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.lbl_NroIdentificador2 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Raza = New System.Windows.Forms.Label()
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.lbl_FechaNac = New System.Windows.Forms.Label()
        Me.lbl_Sexo = New System.Windows.Forms.Label()
        Me.lbl_TipoAnimal = New System.Windows.Forms.Label()
        Me.lbl_LugarActual = New System.Windows.Forms.Label()
        Me.lbl_Peso = New System.Windows.Forms.Label()
        Me.lbl_Kg = New System.Windows.Forms.Label()
        Me.panel_Animal = New System.Windows.Forms.Panel()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.txt_Peso = New System.Windows.Forms.TextBox()
        Me.cbo_LugarActual = New System.Windows.Forms.ComboBox()
        Me.rdo_Hembra = New System.Windows.Forms.RadioButton()
        Me.rdo_Macho = New System.Windows.Forms.RadioButton()
        Me.date_FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cbo_TipoAnimal = New System.Windows.Forms.ComboBox()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.cbo_Raza = New System.Windows.Forms.ComboBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.cmd_Verificar = New System.Windows.Forms.Button()
        Me.txt_NroIdentificador2 = New System.Windows.Forms.TextBox()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.panel_Animal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NroIdentificador1
        '
        Me.lbl_NroIdentificador1.AutoSize = True
        Me.lbl_NroIdentificador1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroIdentificador1.Location = New System.Drawing.Point(12, 9)
        Me.lbl_NroIdentificador1.Name = "lbl_NroIdentificador1"
        Me.lbl_NroIdentificador1.Size = New System.Drawing.Size(157, 18)
        Me.lbl_NroIdentificador1.TabIndex = 0
        Me.lbl_NroIdentificador1.Text = "Número identificador:"
        '
        'txt_NroIdentificador1
        '
        Me.txt_NroIdentificador1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroIdentificador1.Location = New System.Drawing.Point(175, 7)
        Me.txt_NroIdentificador1.Name = "txt_NroIdentificador1"
        Me.txt_NroIdentificador1.Size = New System.Drawing.Size(57, 22)
        Me.txt_NroIdentificador1.TabIndex = 1
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Buscar.Location = New System.Drawing.Point(238, 5)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(104, 25)
        Me.cmd_Buscar.TabIndex = 2
        Me.cmd_Buscar.Text = "Buscar Animal"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_NroIdentificador2
        '
        Me.lbl_NroIdentificador2.AutoSize = True
        Me.lbl_NroIdentificador2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroIdentificador2.Location = New System.Drawing.Point(3, 10)
        Me.lbl_NroIdentificador2.Name = "lbl_NroIdentificador2"
        Me.lbl_NroIdentificador2.Size = New System.Drawing.Size(130, 16)
        Me.lbl_NroIdentificador2.TabIndex = 3
        Me.lbl_NroIdentificador2.Text = "Número Identificador:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(3, 38)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(57, 16)
        Me.lbl_Nombre.TabIndex = 4
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'lbl_Raza
        '
        Me.lbl_Raza.AutoSize = True
        Me.lbl_Raza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Raza.Location = New System.Drawing.Point(3, 66)
        Me.lbl_Raza.Name = "lbl_Raza"
        Me.lbl_Raza.Size = New System.Drawing.Size(42, 16)
        Me.lbl_Raza.TabIndex = 5
        Me.lbl_Raza.Text = "Raza:"
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(3, 95)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(105, 16)
        Me.lbl_Establecimiento.TabIndex = 6
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'lbl_FechaNac
        '
        Me.lbl_FechaNac.AutoSize = True
        Me.lbl_FechaNac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaNac.Location = New System.Drawing.Point(3, 125)
        Me.lbl_FechaNac.Name = "lbl_FechaNac"
        Me.lbl_FechaNac.Size = New System.Drawing.Size(133, 16)
        Me.lbl_FechaNac.TabIndex = 7
        Me.lbl_FechaNac.Text = "Fecha de nacimiento:"
        '
        'lbl_Sexo
        '
        Me.lbl_Sexo.AutoSize = True
        Me.lbl_Sexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sexo.Location = New System.Drawing.Point(3, 153)
        Me.lbl_Sexo.Name = "lbl_Sexo"
        Me.lbl_Sexo.Size = New System.Drawing.Size(42, 16)
        Me.lbl_Sexo.TabIndex = 8
        Me.lbl_Sexo.Text = "Sexo:"
        '
        'lbl_TipoAnimal
        '
        Me.lbl_TipoAnimal.AutoSize = True
        Me.lbl_TipoAnimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoAnimal.Location = New System.Drawing.Point(3, 181)
        Me.lbl_TipoAnimal.Name = "lbl_TipoAnimal"
        Me.lbl_TipoAnimal.Size = New System.Drawing.Size(96, 16)
        Me.lbl_TipoAnimal.TabIndex = 9
        Me.lbl_TipoAnimal.Text = "Tipo de animal:"
        '
        'lbl_LugarActual
        '
        Me.lbl_LugarActual.AutoSize = True
        Me.lbl_LugarActual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LugarActual.Location = New System.Drawing.Point(3, 209)
        Me.lbl_LugarActual.Name = "lbl_LugarActual"
        Me.lbl_LugarActual.Size = New System.Drawing.Size(146, 16)
        Me.lbl_LugarActual.TabIndex = 10
        Me.lbl_LugarActual.Text = "Lugar actual del animal:"
        '
        'lbl_Peso
        '
        Me.lbl_Peso.AutoSize = True
        Me.lbl_Peso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Peso.Location = New System.Drawing.Point(3, 238)
        Me.lbl_Peso.Name = "lbl_Peso"
        Me.lbl_Peso.Size = New System.Drawing.Size(42, 16)
        Me.lbl_Peso.TabIndex = 11
        Me.lbl_Peso.Text = "Peso:"
        '
        'lbl_Kg
        '
        Me.lbl_Kg.AutoSize = True
        Me.lbl_Kg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Kg.Location = New System.Drawing.Point(132, 238)
        Me.lbl_Kg.Name = "lbl_Kg"
        Me.lbl_Kg.Size = New System.Drawing.Size(28, 16)
        Me.lbl_Kg.TabIndex = 12
        Me.lbl_Kg.Text = "Kg."
        '
        'panel_Animal
        '
        Me.panel_Animal.Controls.Add(Me.cmd_Eliminar)
        Me.panel_Animal.Controls.Add(Me.cmd_Modificar)
        Me.panel_Animal.Controls.Add(Me.cmd_Agregar)
        Me.panel_Animal.Controls.Add(Me.txt_Peso)
        Me.panel_Animal.Controls.Add(Me.cbo_LugarActual)
        Me.panel_Animal.Controls.Add(Me.rdo_Hembra)
        Me.panel_Animal.Controls.Add(Me.rdo_Macho)
        Me.panel_Animal.Controls.Add(Me.date_FechaNac)
        Me.panel_Animal.Controls.Add(Me.cbo_TipoAnimal)
        Me.panel_Animal.Controls.Add(Me.cbo_Establecimientos)
        Me.panel_Animal.Controls.Add(Me.cbo_Raza)
        Me.panel_Animal.Controls.Add(Me.txt_Nombre)
        Me.panel_Animal.Controls.Add(Me.cmd_Verificar)
        Me.panel_Animal.Controls.Add(Me.txt_NroIdentificador2)
        Me.panel_Animal.Controls.Add(Me.lbl_Kg)
        Me.panel_Animal.Controls.Add(Me.lbl_Peso)
        Me.panel_Animal.Controls.Add(Me.lbl_LugarActual)
        Me.panel_Animal.Controls.Add(Me.lbl_TipoAnimal)
        Me.panel_Animal.Controls.Add(Me.lbl_Sexo)
        Me.panel_Animal.Controls.Add(Me.lbl_FechaNac)
        Me.panel_Animal.Controls.Add(Me.lbl_Establecimiento)
        Me.panel_Animal.Controls.Add(Me.lbl_Raza)
        Me.panel_Animal.Controls.Add(Me.lbl_Nombre)
        Me.panel_Animal.Controls.Add(Me.lbl_NroIdentificador2)
        Me.panel_Animal.Enabled = False
        Me.panel_Animal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_Animal.Location = New System.Drawing.Point(12, 48)
        Me.panel_Animal.Name = "panel_Animal"
        Me.panel_Animal.Size = New System.Drawing.Size(330, 304)
        Me.panel_Animal.TabIndex = 13
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Enabled = False
        Me.cmd_Eliminar.Location = New System.Drawing.Point(220, 273)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(106, 28)
        Me.cmd_Eliminar.TabIndex = 28
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Enabled = False
        Me.cmd_Modificar.Location = New System.Drawing.Point(114, 273)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(100, 28)
        Me.cmd_Modificar.TabIndex = 27
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Enabled = False
        Me.cmd_Agregar.Location = New System.Drawing.Point(6, 273)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(102, 28)
        Me.cmd_Agregar.TabIndex = 26
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'txt_Peso
        '
        Me.txt_Peso.Location = New System.Drawing.Point(54, 235)
        Me.txt_Peso.Name = "txt_Peso"
        Me.txt_Peso.Size = New System.Drawing.Size(72, 22)
        Me.txt_Peso.TabIndex = 25
        '
        'cbo_LugarActual
        '
        Me.cbo_LugarActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_LugarActual.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_LugarActual.FormattingEnabled = True
        Me.cbo_LugarActual.Items.AddRange(New Object() {"Establecimiento", "Campo de recria"})
        Me.cbo_LugarActual.Location = New System.Drawing.Point(155, 206)
        Me.cbo_LugarActual.Name = "cbo_LugarActual"
        Me.cbo_LugarActual.Size = New System.Drawing.Size(154, 23)
        Me.cbo_LugarActual.TabIndex = 24
        '
        'rdo_Hembra
        '
        Me.rdo_Hembra.AutoSize = True
        Me.rdo_Hembra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Hembra.Location = New System.Drawing.Point(132, 151)
        Me.rdo_Hembra.Name = "rdo_Hembra"
        Me.rdo_Hembra.Size = New System.Drawing.Size(71, 20)
        Me.rdo_Hembra.TabIndex = 23
        Me.rdo_Hembra.TabStop = True
        Me.rdo_Hembra.Text = "Hembra"
        Me.rdo_Hembra.UseVisualStyleBackColor = True
        '
        'rdo_Macho
        '
        Me.rdo_Macho.AutoSize = True
        Me.rdo_Macho.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Macho.Location = New System.Drawing.Point(61, 151)
        Me.rdo_Macho.Name = "rdo_Macho"
        Me.rdo_Macho.Size = New System.Drawing.Size(65, 20)
        Me.rdo_Macho.TabIndex = 22
        Me.rdo_Macho.TabStop = True
        Me.rdo_Macho.Text = "Macho"
        Me.rdo_Macho.UseVisualStyleBackColor = True
        '
        'date_FechaNac
        '
        Me.date_FechaNac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaNac.Location = New System.Drawing.Point(142, 122)
        Me.date_FechaNac.Name = "date_FechaNac"
        Me.date_FechaNac.Size = New System.Drawing.Size(108, 22)
        Me.date_FechaNac.TabIndex = 19
        '
        'cbo_TipoAnimal
        '
        Me.cbo_TipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_TipoAnimal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_TipoAnimal.FormattingEnabled = True
        Me.cbo_TipoAnimal.Items.AddRange(New Object() {"Vaca", "Toro", "Cria", "Animal no productivo"})
        Me.cbo_TipoAnimal.Location = New System.Drawing.Point(103, 177)
        Me.cbo_TipoAnimal.Name = "cbo_TipoAnimal"
        Me.cbo_TipoAnimal.Size = New System.Drawing.Size(206, 23)
        Me.cbo_TipoAnimal.TabIndex = 18
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(114, 93)
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(213, 23)
        Me.cbo_Establecimientos.TabIndex = 17
        '
        'cbo_Raza
        '
        Me.cbo_Raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Raza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Raza.FormattingEnabled = True
        Me.cbo_Raza.Items.AddRange(New Object() {"Holando", "Jersey", "Primer Show"})
        Me.cbo_Raza.Location = New System.Drawing.Point(53, 63)
        Me.cbo_Raza.Name = "cbo_Raza"
        Me.cbo_Raza.Size = New System.Drawing.Size(119, 24)
        Me.cbo_Raza.TabIndex = 16
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(65, 35)
        Me.txt_Nombre.MaxLength = 15
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(107, 22)
        Me.txt_Nombre.TabIndex = 15
        '
        'cmd_Verificar
        '
        Me.cmd_Verificar.Enabled = False
        Me.cmd_Verificar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Verificar.Location = New System.Drawing.Point(209, 7)
        Me.cmd_Verificar.Name = "cmd_Verificar"
        Me.cmd_Verificar.Size = New System.Drawing.Size(75, 22)
        Me.cmd_Verificar.TabIndex = 14
        Me.cmd_Verificar.Text = "Verificar"
        Me.cmd_Verificar.UseVisualStyleBackColor = True
        '
        'txt_NroIdentificador2
        '
        Me.txt_NroIdentificador2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroIdentificador2.Location = New System.Drawing.Point(146, 7)
        Me.txt_NroIdentificador2.Name = "txt_NroIdentificador2"
        Me.txt_NroIdentificador2.Size = New System.Drawing.Size(57, 22)
        Me.txt_NroIdentificador2.TabIndex = 13
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancelar.Location = New System.Drawing.Point(267, 358)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmd_Cancelar.TabIndex = 14
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'frmAdminAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(354, 394)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.panel_Animal)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.txt_NroIdentificador1)
        Me.Controls.Add(Me.lbl_NroIdentificador1)
        Me.MaximizeBox = False
        Me.Name = "frmAdminAnimales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de animales"
        Me.panel_Animal.ResumeLayout(False)
        Me.panel_Animal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NroIdentificador1 As System.Windows.Forms.Label
    Friend WithEvents txt_NroIdentificador1 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_NroIdentificador2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Raza As System.Windows.Forms.Label
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaNac As System.Windows.Forms.Label
    Friend WithEvents lbl_Sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoAnimal As System.Windows.Forms.Label
    Friend WithEvents lbl_LugarActual As System.Windows.Forms.Label
    Friend WithEvents lbl_Peso As System.Windows.Forms.Label
    Friend WithEvents lbl_Kg As System.Windows.Forms.Label
    Friend WithEvents panel_Animal As System.Windows.Forms.Panel
    Friend WithEvents cmd_Eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_Peso As System.Windows.Forms.TextBox
    Friend WithEvents cbo_LugarActual As System.Windows.Forms.ComboBox
    Friend WithEvents rdo_Hembra As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Macho As System.Windows.Forms.RadioButton
    Friend WithEvents date_FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_TipoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Raza As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Verificar As System.Windows.Forms.Button
    Friend WithEvents txt_NroIdentificador2 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
End Class
