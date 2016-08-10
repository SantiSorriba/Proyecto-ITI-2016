<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMC
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
        Me.lblNumeroId = New System.Windows.Forms.Label()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.panelAnimales = New System.Windows.Forms.Panel()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.rdoHembra = New System.Windows.Forms.RadioButton()
        Me.rdoMacho = New System.Windows.Forms.RadioButton()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cboLugarActual = New System.Windows.Forms.ComboBox()
        Me.lblLugarActual = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.txtNumeroIdentificador = New System.Windows.Forms.TextBox()
        Me.cboTipoAnimal = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.dateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cboRaza = New System.Windows.Forms.ComboBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmdVerificar = New System.Windows.Forms.Button()
        Me.lblNumeroIdentificador = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.panelAnimales.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumeroId
        '
        Me.lblNumeroId.AutoSize = True
        Me.lblNumeroId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroId.Location = New System.Drawing.Point(15, 12)
        Me.lblNumeroId.Name = "lblNumeroId"
        Me.lblNumeroId.Size = New System.Drawing.Size(130, 16)
        Me.lblNumeroId.TabIndex = 0
        Me.lblNumeroId.Text = "Número Identificador:"
        '
        'txtNumId
        '
        Me.txtNumId.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumId.Location = New System.Drawing.Point(151, 8)
        Me.txtNumId.MaxLength = 6
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(58, 25)
        Me.txtNumId.TabIndex = 1
        Me.txtNumId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(226, 6)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(111, 29)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar animal"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'panelAnimales
        '
        Me.panelAnimales.Controls.Add(Me.lblKg)
        Me.panelAnimales.Controls.Add(Me.txtPeso)
        Me.panelAnimales.Controls.Add(Me.lblPeso)
        Me.panelAnimales.Controls.Add(Me.rdoHembra)
        Me.panelAnimales.Controls.Add(Me.rdoMacho)
        Me.panelAnimales.Controls.Add(Me.lblSexo)
        Me.panelAnimales.Controls.Add(Me.cboLugarActual)
        Me.panelAnimales.Controls.Add(Me.lblLugarActual)
        Me.panelAnimales.Controls.Add(Me.cmdEliminar)
        Me.panelAnimales.Controls.Add(Me.cmdModificar)
        Me.panelAnimales.Controls.Add(Me.cmdAgregar)
        Me.panelAnimales.Controls.Add(Me.txtNumeroIdentificador)
        Me.panelAnimales.Controls.Add(Me.cboTipoAnimal)
        Me.panelAnimales.Controls.Add(Me.lblTipo)
        Me.panelAnimales.Controls.Add(Me.dateNacimiento)
        Me.panelAnimales.Controls.Add(Me.lblFechaNacimiento)
        Me.panelAnimales.Controls.Add(Me.cboEstablecimiento)
        Me.panelAnimales.Controls.Add(Me.lblEstablecimiento)
        Me.panelAnimales.Controls.Add(Me.cboRaza)
        Me.panelAnimales.Controls.Add(Me.lblRaza)
        Me.panelAnimales.Controls.Add(Me.txtNombre)
        Me.panelAnimales.Controls.Add(Me.lblNombre)
        Me.panelAnimales.Controls.Add(Me.cmdVerificar)
        Me.panelAnimales.Controls.Add(Me.lblNumeroIdentificador)
        Me.panelAnimales.Location = New System.Drawing.Point(12, 45)
        Me.panelAnimales.Name = "panelAnimales"
        Me.panelAnimales.Size = New System.Drawing.Size(402, 282)
        Me.panelAnimales.TabIndex = 3
        Me.panelAnimales.Visible = False
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg.Location = New System.Drawing.Point(115, 228)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(24, 16)
        Me.lblKg.TabIndex = 24
        Me.lblKg.Text = "Kg"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(51, 224)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(57, 22)
        Me.txtPeso.TabIndex = 23
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(3, 228)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(42, 16)
        Me.lblPeso.TabIndex = 22
        Me.lblPeso.Text = "Peso:"
        '
        'rdoHembra
        '
        Me.rdoHembra.AutoSize = True
        Me.rdoHembra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHembra.Location = New System.Drawing.Point(185, 141)
        Me.rdoHembra.Name = "rdoHembra"
        Me.rdoHembra.Size = New System.Drawing.Size(71, 20)
        Me.rdoHembra.TabIndex = 21
        Me.rdoHembra.TabStop = True
        Me.rdoHembra.Text = "Hembra"
        Me.rdoHembra.UseVisualStyleBackColor = True
        '
        'rdoMacho
        '
        Me.rdoMacho.AutoSize = True
        Me.rdoMacho.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMacho.Location = New System.Drawing.Point(118, 141)
        Me.rdoMacho.Name = "rdoMacho"
        Me.rdoMacho.Size = New System.Drawing.Size(65, 20)
        Me.rdoMacho.TabIndex = 20
        Me.rdoMacho.TabStop = True
        Me.rdoMacho.Text = "Macho"
        Me.rdoMacho.UseVisualStyleBackColor = True
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(3, 143)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(105, 16)
        Me.lblSexo.TabIndex = 19
        Me.lblSexo.Text = "Sexo del animal:"
        '
        'cboLugarActual
        '
        Me.cboLugarActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLugarActual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugarActual.FormattingEnabled = True
        Me.cboLugarActual.Items.AddRange(New Object() {"Establecimiento", "Campo de recria"})
        Me.cboLugarActual.Location = New System.Drawing.Point(152, 197)
        Me.cboLugarActual.Name = "cboLugarActual"
        Me.cboLugarActual.Size = New System.Drawing.Size(154, 24)
        Me.cboLugarActual.TabIndex = 18
        '
        'lblLugarActual
        '
        Me.lblLugarActual.AutoSize = True
        Me.lblLugarActual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugarActual.Location = New System.Drawing.Point(3, 200)
        Me.lblLugarActual.Name = "lblLugarActual"
        Me.lblLugarActual.Size = New System.Drawing.Size(146, 16)
        Me.lblLugarActual.TabIndex = 17
        Me.lblLugarActual.Text = "Lugar actual del animal:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Location = New System.Drawing.Point(276, 252)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(123, 27)
        Me.cmdEliminar.TabIndex = 16
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(139, 252)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(128, 27)
        Me.cmdModificar.TabIndex = 15
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(6, 252)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(123, 27)
        Me.cmdAgregar.TabIndex = 14
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'txtNumeroIdentificador
        '
        Me.txtNumeroIdentificador.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroIdentificador.Location = New System.Drawing.Point(139, 8)
        Me.txtNumeroIdentificador.MaxLength = 6
        Me.txtNumeroIdentificador.Name = "txtNumeroIdentificador"
        Me.txtNumeroIdentificador.Size = New System.Drawing.Size(58, 25)
        Me.txtNumeroIdentificador.TabIndex = 2
        '
        'cboTipoAnimal
        '
        Me.cboTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAnimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAnimal.FormattingEnabled = True
        Me.cboTipoAnimal.Items.AddRange(New Object() {"Vaca", "Toro", "Cria", "Animal no productivo"})
        Me.cboTipoAnimal.Location = New System.Drawing.Point(118, 167)
        Me.cboTipoAnimal.Name = "cboTipoAnimal"
        Me.cboTipoAnimal.Size = New System.Drawing.Size(145, 24)
        Me.cboTipoAnimal.TabIndex = 13
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(3, 170)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(96, 16)
        Me.lblTipo.TabIndex = 12
        Me.lblTipo.Text = "Tipo de animal:"
        '
        'dateNacimiento
        '
        Me.dateNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateNacimiento.Location = New System.Drawing.Point(142, 110)
        Me.dateNacimiento.Name = "dateNacimiento"
        Me.dateNacimiento.Size = New System.Drawing.Size(108, 22)
        Me.dateNacimiento.TabIndex = 11
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(3, 114)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(133, 16)
        Me.lblFechaNacimiento.TabIndex = 10
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'cboEstablecimiento
        '
        Me.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimiento.FormattingEnabled = True
        Me.cboEstablecimiento.Items.AddRange(New Object() {"Establecimiento Las Perdices", "Establecimiento Tala", "Establecimiento Los Juncales"})
        Me.cboEstablecimiento.Location = New System.Drawing.Point(114, 80)
        Me.cboEstablecimiento.MaxLength = 30
        Me.cboEstablecimiento.Name = "cboEstablecimiento"
        Me.cboEstablecimiento.Size = New System.Drawing.Size(232, 24)
        Me.cboEstablecimiento.TabIndex = 9
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(3, 83)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(105, 16)
        Me.lblEstablecimiento.TabIndex = 8
        Me.lblEstablecimiento.Text = "Establecimiento:"
        '
        'cboRaza
        '
        Me.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRaza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.Items.AddRange(New Object() {"Holando", "Jersey", "Primer Show"})
        Me.cboRaza.Location = New System.Drawing.Point(227, 43)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(119, 24)
        Me.cboRaza.TabIndex = 7
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(179, 48)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(42, 16)
        Me.lblRaza.TabIndex = 6
        Me.lblRaza.Text = "Raza:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(66, 45)
        Me.txtNombre.MaxLength = 15
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(107, 22)
        Me.txtNombre.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'cmdVerificar
        '
        Me.cmdVerificar.Enabled = False
        Me.cmdVerificar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerificar.Location = New System.Drawing.Point(214, 7)
        Me.cmdVerificar.Name = "cmdVerificar"
        Me.cmdVerificar.Size = New System.Drawing.Size(98, 26)
        Me.cmdVerificar.TabIndex = 3
        Me.cmdVerificar.Text = "Verificar"
        Me.cmdVerificar.UseVisualStyleBackColor = True
        '
        'lblNumeroIdentificador
        '
        Me.lblNumeroIdentificador.AutoSize = True
        Me.lblNumeroIdentificador.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroIdentificador.Location = New System.Drawing.Point(3, 14)
        Me.lblNumeroIdentificador.Name = "lblNumeroIdentificador"
        Me.lblNumeroIdentificador.Size = New System.Drawing.Size(130, 16)
        Me.lblNumeroIdentificador.TabIndex = 0
        Me.lblNumeroIdentificador.Text = "Número Identificador:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(339, 333)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmABMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(426, 364)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.panelAnimales)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtNumId)
        Me.Controls.Add(Me.lblNumeroId)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmABMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animales"
        Me.panelAnimales.ResumeLayout(False)
        Me.panelAnimales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumeroId As System.Windows.Forms.Label
    Friend WithEvents txtNumId As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents panelAnimales As System.Windows.Forms.Panel
    Friend WithEvents txtNumeroIdentificador As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroIdentificador As System.Windows.Forms.Label
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboRaza As System.Windows.Forms.ComboBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmdVerificar As System.Windows.Forms.Button
    Friend WithEvents cboEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cboTipoAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents dateNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cboLugarActual As System.Windows.Forms.ComboBox
    Friend WithEvents lblLugarActual As System.Windows.Forms.Label
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents rdoHembra As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMacho As System.Windows.Forms.RadioButton
    Friend WithEvents lblSexo As System.Windows.Forms.Label
End Class
