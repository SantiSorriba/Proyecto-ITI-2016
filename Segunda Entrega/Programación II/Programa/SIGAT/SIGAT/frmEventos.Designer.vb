<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventos
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
        Me.tab_Eventos = New System.Windows.Forms.TabControl()
        Me.tab_Ingresar = New System.Windows.Forms.TabPage()
        Me.cbo_GuardarEvento = New System.Windows.Forms.Button()
        Me.group_Enfermedad = New System.Windows.Forms.GroupBox()
        Me.cbo_Medicacion = New System.Windows.Forms.ComboBox()
        Me.lbl_Medicacion = New System.Windows.Forms.Label()
        Me.rdo_No = New System.Windows.Forms.RadioButton()
        Me.rdo_Si = New System.Windows.Forms.RadioButton()
        Me.lbl_Suminstra = New System.Windows.Forms.Label()
        Me.cbo_Enfermedad = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoEnfermedad = New System.Windows.Forms.Label()
        Me.group_Muerte = New System.Windows.Forms.GroupBox()
        Me.cbo_Causa = New System.Windows.Forms.ComboBox()
        Me.lbl_Causa = New System.Windows.Forms.Label()
        Me.group_Servicio = New System.Windows.Forms.GroupBox()
        Me.cbo_Servicios = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoServicio = New System.Windows.Forms.Label()
        Me.cbo_Eventos = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoEvento = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_FechaEvento = New System.Windows.Forms.DateTimePicker()
        Me.tab_Consultar = New System.Windows.Forms.TabPage()
        Me.lbl_NroAnimal = New System.Windows.Forms.Label()
        Me.grid_Eventos = New System.Windows.Forms.DataGridView()
        Me.lbl_Eventos = New System.Windows.Forms.Label()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.lbl_NroIdentificador = New System.Windows.Forms.Label()
        Me.txt_NroIdentificador = New System.Windows.Forms.TextBox()
        Me.cmd_Seleccionar = New System.Windows.Forms.Button()
        Me.tab_Eventos.SuspendLayout()
        Me.tab_Ingresar.SuspendLayout()
        Me.group_Enfermedad.SuspendLayout()
        Me.group_Muerte.SuspendLayout()
        Me.group_Servicio.SuspendLayout()
        Me.tab_Consultar.SuspendLayout()
        CType(Me.grid_Eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_Eventos
        '
        Me.tab_Eventos.Controls.Add(Me.tab_Ingresar)
        Me.tab_Eventos.Controls.Add(Me.tab_Consultar)
        Me.tab_Eventos.Enabled = False
        Me.tab_Eventos.Location = New System.Drawing.Point(5, 37)
        Me.tab_Eventos.Name = "tab_Eventos"
        Me.tab_Eventos.SelectedIndex = 0
        Me.tab_Eventos.Size = New System.Drawing.Size(554, 387)
        Me.tab_Eventos.TabIndex = 0
        '
        'tab_Ingresar
        '
        Me.tab_Ingresar.Controls.Add(Me.cbo_GuardarEvento)
        Me.tab_Ingresar.Controls.Add(Me.group_Enfermedad)
        Me.tab_Ingresar.Controls.Add(Me.group_Muerte)
        Me.tab_Ingresar.Controls.Add(Me.group_Servicio)
        Me.tab_Ingresar.Controls.Add(Me.cbo_Eventos)
        Me.tab_Ingresar.Controls.Add(Me.lbl_TipoEvento)
        Me.tab_Ingresar.Controls.Add(Me.lbl_Fecha)
        Me.tab_Ingresar.Controls.Add(Me.date_FechaEvento)
        Me.tab_Ingresar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_Ingresar.Location = New System.Drawing.Point(4, 22)
        Me.tab_Ingresar.Name = "tab_Ingresar"
        Me.tab_Ingresar.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Ingresar.Size = New System.Drawing.Size(546, 361)
        Me.tab_Ingresar.TabIndex = 0
        Me.tab_Ingresar.Text = "Ingresar eventos"
        Me.tab_Ingresar.UseVisualStyleBackColor = True
        '
        'cbo_GuardarEvento
        '
        Me.cbo_GuardarEvento.Enabled = False
        Me.cbo_GuardarEvento.Location = New System.Drawing.Point(397, 314)
        Me.cbo_GuardarEvento.Name = "cbo_GuardarEvento"
        Me.cbo_GuardarEvento.Size = New System.Drawing.Size(120, 27)
        Me.cbo_GuardarEvento.TabIndex = 17
        Me.cbo_GuardarEvento.Text = "Guardar evento"
        Me.cbo_GuardarEvento.UseVisualStyleBackColor = True
        '
        'group_Enfermedad
        '
        Me.group_Enfermedad.Controls.Add(Me.cbo_Medicacion)
        Me.group_Enfermedad.Controls.Add(Me.lbl_Medicacion)
        Me.group_Enfermedad.Controls.Add(Me.rdo_No)
        Me.group_Enfermedad.Controls.Add(Me.rdo_Si)
        Me.group_Enfermedad.Controls.Add(Me.lbl_Suminstra)
        Me.group_Enfermedad.Controls.Add(Me.cbo_Enfermedad)
        Me.group_Enfermedad.Controls.Add(Me.lbl_TipoEnfermedad)
        Me.group_Enfermedad.Enabled = False
        Me.group_Enfermedad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Enfermedad.Location = New System.Drawing.Point(20, 125)
        Me.group_Enfermedad.Name = "group_Enfermedad"
        Me.group_Enfermedad.Size = New System.Drawing.Size(368, 118)
        Me.group_Enfermedad.TabIndex = 16
        Me.group_Enfermedad.TabStop = False
        Me.group_Enfermedad.Text = "ENFERMEDAD"
        '
        'cbo_Medicacion
        '
        Me.cbo_Medicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Medicacion.Enabled = False
        Me.cbo_Medicacion.FormattingEnabled = True
        Me.cbo_Medicacion.Items.AddRange(New Object() {"Ubremol"})
        Me.cbo_Medicacion.Location = New System.Drawing.Point(97, 83)
        Me.cbo_Medicacion.Name = "cbo_Medicacion"
        Me.cbo_Medicacion.Size = New System.Drawing.Size(217, 24)
        Me.cbo_Medicacion.TabIndex = 6
        '
        'lbl_Medicacion
        '
        Me.lbl_Medicacion.AutoSize = True
        Me.lbl_Medicacion.Location = New System.Drawing.Point(8, 87)
        Me.lbl_Medicacion.Name = "lbl_Medicacion"
        Me.lbl_Medicacion.Size = New System.Drawing.Size(78, 16)
        Me.lbl_Medicacion.TabIndex = 5
        Me.lbl_Medicacion.Text = "Medicación:"
        '
        'rdo_No
        '
        Me.rdo_No.AutoSize = True
        Me.rdo_No.Location = New System.Drawing.Point(251, 52)
        Me.rdo_No.Name = "rdo_No"
        Me.rdo_No.Size = New System.Drawing.Size(42, 20)
        Me.rdo_No.TabIndex = 4
        Me.rdo_No.TabStop = True
        Me.rdo_No.Text = "No"
        Me.rdo_No.UseVisualStyleBackColor = True
        '
        'rdo_Si
        '
        Me.rdo_Si.AutoSize = True
        Me.rdo_Si.Location = New System.Drawing.Point(207, 52)
        Me.rdo_Si.Name = "rdo_Si"
        Me.rdo_Si.Size = New System.Drawing.Size(38, 20)
        Me.rdo_Si.TabIndex = 3
        Me.rdo_Si.TabStop = True
        Me.rdo_Si.Text = "Si"
        Me.rdo_Si.UseVisualStyleBackColor = True
        '
        'lbl_Suminstra
        '
        Me.lbl_Suminstra.AutoSize = True
        Me.lbl_Suminstra.Location = New System.Drawing.Point(4, 53)
        Me.lbl_Suminstra.Name = "lbl_Suminstra"
        Me.lbl_Suminstra.Size = New System.Drawing.Size(195, 16)
        Me.lbl_Suminstra.TabIndex = 2
        Me.lbl_Suminstra.Text = "¿Se le suministra medicación? :"
        '
        'cbo_Enfermedad
        '
        Me.cbo_Enfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Enfermedad.FormattingEnabled = True
        Me.cbo_Enfermedad.Items.AddRange(New Object() {"Mastitis"})
        Me.cbo_Enfermedad.Location = New System.Drawing.Point(137, 22)
        Me.cbo_Enfermedad.Name = "cbo_Enfermedad"
        Me.cbo_Enfermedad.Size = New System.Drawing.Size(213, 24)
        Me.cbo_Enfermedad.TabIndex = 1
        '
        'lbl_TipoEnfermedad
        '
        Me.lbl_TipoEnfermedad.AutoSize = True
        Me.lbl_TipoEnfermedad.Location = New System.Drawing.Point(6, 25)
        Me.lbl_TipoEnfermedad.Name = "lbl_TipoEnfermedad"
        Me.lbl_TipoEnfermedad.Size = New System.Drawing.Size(125, 16)
        Me.lbl_TipoEnfermedad.TabIndex = 0
        Me.lbl_TipoEnfermedad.Text = "Tipo de enfermedad:"
        '
        'group_Muerte
        '
        Me.group_Muerte.Controls.Add(Me.cbo_Causa)
        Me.group_Muerte.Controls.Add(Me.lbl_Causa)
        Me.group_Muerte.Enabled = False
        Me.group_Muerte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Muerte.Location = New System.Drawing.Point(20, 260)
        Me.group_Muerte.Name = "group_Muerte"
        Me.group_Muerte.Size = New System.Drawing.Size(299, 61)
        Me.group_Muerte.TabIndex = 15
        Me.group_Muerte.TabStop = False
        Me.group_Muerte.Text = "MUERTE"
        '
        'cbo_Causa
        '
        Me.cbo_Causa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Causa.FormattingEnabled = True
        Me.cbo_Causa.Items.AddRange(New Object() {"543fgdg", "gdfg"})
        Me.cbo_Causa.Location = New System.Drawing.Point(61, 27)
        Me.cbo_Causa.Name = "cbo_Causa"
        Me.cbo_Causa.Size = New System.Drawing.Size(232, 24)
        Me.cbo_Causa.TabIndex = 1
        '
        'lbl_Causa
        '
        Me.lbl_Causa.AutoSize = True
        Me.lbl_Causa.Location = New System.Drawing.Point(6, 30)
        Me.lbl_Causa.Name = "lbl_Causa"
        Me.lbl_Causa.Size = New System.Drawing.Size(49, 16)
        Me.lbl_Causa.TabIndex = 0
        Me.lbl_Causa.Text = "Causa:"
        '
        'group_Servicio
        '
        Me.group_Servicio.Controls.Add(Me.cbo_Servicios)
        Me.group_Servicio.Controls.Add(Me.lbl_TipoServicio)
        Me.group_Servicio.Enabled = False
        Me.group_Servicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Servicio.Location = New System.Drawing.Point(20, 52)
        Me.group_Servicio.Name = "group_Servicio"
        Me.group_Servicio.Size = New System.Drawing.Size(299, 57)
        Me.group_Servicio.TabIndex = 14
        Me.group_Servicio.TabStop = False
        Me.group_Servicio.Text = "SERVICIO"
        '
        'cbo_Servicios
        '
        Me.cbo_Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Servicios.FormattingEnabled = True
        Me.cbo_Servicios.Items.AddRange(New Object() {"terg", "gdf"})
        Me.cbo_Servicios.Location = New System.Drawing.Point(113, 24)
        Me.cbo_Servicios.Name = "cbo_Servicios"
        Me.cbo_Servicios.Size = New System.Drawing.Size(180, 24)
        Me.cbo_Servicios.TabIndex = 1
        '
        'lbl_TipoServicio
        '
        Me.lbl_TipoServicio.AutoSize = True
        Me.lbl_TipoServicio.Location = New System.Drawing.Point(6, 27)
        Me.lbl_TipoServicio.Name = "lbl_TipoServicio"
        Me.lbl_TipoServicio.Size = New System.Drawing.Size(101, 16)
        Me.lbl_TipoServicio.TabIndex = 0
        Me.lbl_TipoServicio.Text = "Tipo de servicio:"
        '
        'cbo_Eventos
        '
        Me.cbo_Eventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Eventos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Eventos.FormattingEnabled = True
        Me.cbo_Eventos.Items.AddRange(New Object() {"Parto", "Vendido", "Servicio", "Enfermedad", "Muerte"})
        Me.cbo_Eventos.Location = New System.Drawing.Point(306, 13)
        Me.cbo_Eventos.Name = "cbo_Eventos"
        Me.cbo_Eventos.Size = New System.Drawing.Size(198, 24)
        Me.cbo_Eventos.TabIndex = 6
        '
        'lbl_TipoEvento
        '
        Me.lbl_TipoEvento.AutoSize = True
        Me.lbl_TipoEvento.Location = New System.Drawing.Point(205, 17)
        Me.lbl_TipoEvento.Name = "lbl_TipoEvento"
        Me.lbl_TipoEvento.Size = New System.Drawing.Size(95, 16)
        Me.lbl_TipoEvento.TabIndex = 2
        Me.lbl_TipoEvento.Text = "Tipo de evento:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(17, 18)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Fecha.TabIndex = 1
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'date_FechaEvento
        '
        Me.date_FechaEvento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaEvento.Location = New System.Drawing.Point(71, 15)
        Me.date_FechaEvento.Name = "date_FechaEvento"
        Me.date_FechaEvento.Size = New System.Drawing.Size(108, 22)
        Me.date_FechaEvento.TabIndex = 0
        '
        'tab_Consultar
        '
        Me.tab_Consultar.Controls.Add(Me.lbl_NroAnimal)
        Me.tab_Consultar.Controls.Add(Me.grid_Eventos)
        Me.tab_Consultar.Controls.Add(Me.lbl_Eventos)
        Me.tab_Consultar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_Consultar.Location = New System.Drawing.Point(4, 22)
        Me.tab_Consultar.Name = "tab_Consultar"
        Me.tab_Consultar.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Consultar.Size = New System.Drawing.Size(546, 361)
        Me.tab_Consultar.TabIndex = 1
        Me.tab_Consultar.Text = "Consultar eventos"
        Me.tab_Consultar.UseVisualStyleBackColor = True
        '
        'lbl_NroAnimal
        '
        Me.lbl_NroAnimal.AutoSize = True
        Me.lbl_NroAnimal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroAnimal.Location = New System.Drawing.Point(185, 20)
        Me.lbl_NroAnimal.Name = "lbl_NroAnimal"
        Me.lbl_NroAnimal.Size = New System.Drawing.Size(81, 18)
        Me.lbl_NroAnimal.TabIndex = 6
        Me.lbl_NroAnimal.Text = "NroAnimal"
        '
        'grid_Eventos
        '
        Me.grid_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Eventos.Location = New System.Drawing.Point(19, 65)
        Me.grid_Eventos.Name = "grid_Eventos"
        Me.grid_Eventos.Size = New System.Drawing.Size(507, 277)
        Me.grid_Eventos.TabIndex = 5
        '
        'lbl_Eventos
        '
        Me.lbl_Eventos.AutoSize = True
        Me.lbl_Eventos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Eventos.Location = New System.Drawing.Point(16, 20)
        Me.lbl_Eventos.Name = "lbl_Eventos"
        Me.lbl_Eventos.Size = New System.Drawing.Size(163, 18)
        Me.lbl_Eventos.TabIndex = 0
        Me.lbl_Eventos.Text = "Eventos del animal Nº:"
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Volver.Location = New System.Drawing.Point(480, 430)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Volver.TabIndex = 1
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'lbl_NroIdentificador
        '
        Me.lbl_NroIdentificador.AutoSize = True
        Me.lbl_NroIdentificador.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroIdentificador.Location = New System.Drawing.Point(8, 9)
        Me.lbl_NroIdentificador.Name = "lbl_NroIdentificador"
        Me.lbl_NroIdentificador.Size = New System.Drawing.Size(232, 18)
        Me.lbl_NroIdentificador.TabIndex = 2
        Me.lbl_NroIdentificador.Text = "Número identificador del animal:"
        '
        'txt_NroIdentificador
        '
        Me.txt_NroIdentificador.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroIdentificador.Location = New System.Drawing.Point(246, 9)
        Me.txt_NroIdentificador.Name = "txt_NroIdentificador"
        Me.txt_NroIdentificador.Size = New System.Drawing.Size(63, 22)
        Me.txt_NroIdentificador.TabIndex = 3
        '
        'cmd_Seleccionar
        '
        Me.cmd_Seleccionar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Seleccionar.Location = New System.Drawing.Point(315, 7)
        Me.cmd_Seleccionar.Name = "cmd_Seleccionar"
        Me.cmd_Seleccionar.Size = New System.Drawing.Size(90, 24)
        Me.cmd_Seleccionar.TabIndex = 4
        Me.cmd_Seleccionar.Text = "Seleccionar"
        Me.cmd_Seleccionar.UseVisualStyleBackColor = True
        '
        'frmEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(563, 459)
        Me.Controls.Add(Me.cmd_Seleccionar)
        Me.Controls.Add(Me.txt_NroIdentificador)
        Me.Controls.Add(Me.lbl_NroIdentificador)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.tab_Eventos)
        Me.MaximizeBox = False
        Me.Name = "frmEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de eventos"
        Me.tab_Eventos.ResumeLayout(False)
        Me.tab_Ingresar.ResumeLayout(False)
        Me.tab_Ingresar.PerformLayout()
        Me.group_Enfermedad.ResumeLayout(False)
        Me.group_Enfermedad.PerformLayout()
        Me.group_Muerte.ResumeLayout(False)
        Me.group_Muerte.PerformLayout()
        Me.group_Servicio.ResumeLayout(False)
        Me.group_Servicio.PerformLayout()
        Me.tab_Consultar.ResumeLayout(False)
        Me.tab_Consultar.PerformLayout()
        CType(Me.grid_Eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab_Eventos As System.Windows.Forms.TabControl
    Friend WithEvents tab_Ingresar As System.Windows.Forms.TabPage
    Friend WithEvents tab_Consultar As System.Windows.Forms.TabPage
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
    Friend WithEvents lbl_NroIdentificador As System.Windows.Forms.Label
    Friend WithEvents txt_NroIdentificador As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents cbo_GuardarEvento As System.Windows.Forms.Button
    Friend WithEvents group_Enfermedad As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Medicacion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Medicacion As System.Windows.Forms.Label
    Friend WithEvents rdo_No As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Si As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Suminstra As System.Windows.Forms.Label
    Friend WithEvents cbo_Enfermedad As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoEnfermedad As System.Windows.Forms.Label
    Friend WithEvents group_Muerte As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Causa As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Causa As System.Windows.Forms.Label
    Friend WithEvents group_Servicio As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Servicios As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoServicio As System.Windows.Forms.Label
    Friend WithEvents cbo_Eventos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoEvento As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_FechaEvento As System.Windows.Forms.DateTimePicker
    Friend WithEvents grid_Eventos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Eventos As System.Windows.Forms.Label
    Friend WithEvents lbl_NroAnimal As System.Windows.Forms.Label
End Class
