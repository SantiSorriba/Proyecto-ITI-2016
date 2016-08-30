<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarEvento))
        Me.lbl_NroIdentificador = New System.Windows.Forms.Label()
        Me.txt_NroIdentificador = New System.Windows.Forms.TextBox()
        Me.cmd_Seleccionar = New System.Windows.Forms.Button()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_FechaEvento = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Evento = New System.Windows.Forms.Label()
        Me.cbo_Evento = New System.Windows.Forms.ComboBox()
        Me.panel_Eventos = New System.Windows.Forms.Panel()
        Me.group_Control = New System.Windows.Forms.GroupBox()
        Me.cbo_Resultado = New System.Windows.Forms.ComboBox()
        Me.lbl_Resultado = New System.Windows.Forms.Label()
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
        Me.cmd_Registrar = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.panel_Eventos.SuspendLayout()
        Me.group_Control.SuspendLayout()
        Me.group_Enfermedad.SuspendLayout()
        Me.group_Muerte.SuspendLayout()
        Me.group_Servicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NroIdentificador
        '
        Me.lbl_NroIdentificador.AutoSize = True
        Me.lbl_NroIdentificador.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroIdentificador.Location = New System.Drawing.Point(12, 10)
        Me.lbl_NroIdentificador.Name = "lbl_NroIdentificador"
        Me.lbl_NroIdentificador.Size = New System.Drawing.Size(257, 20)
        Me.lbl_NroIdentificador.TabIndex = 0
        Me.lbl_NroIdentificador.Text = "Número identificador del animal:"
        '
        'txt_NroIdentificador
        '
        Me.txt_NroIdentificador.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroIdentificador.Location = New System.Drawing.Point(275, 6)
        Me.txt_NroIdentificador.Name = "txt_NroIdentificador"
        Me.txt_NroIdentificador.Size = New System.Drawing.Size(61, 28)
        Me.txt_NroIdentificador.TabIndex = 1
        '
        'cmd_Seleccionar
        '
        Me.cmd_Seleccionar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Seleccionar.Location = New System.Drawing.Point(344, 6)
        Me.cmd_Seleccionar.Name = "cmd_Seleccionar"
        Me.cmd_Seleccionar.Size = New System.Drawing.Size(160, 29)
        Me.cmd_Seleccionar.TabIndex = 2
        Me.cmd_Seleccionar.Text = "Seleccionar animal"
        Me.cmd_Seleccionar.UseVisualStyleBackColor = True
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(3, 18)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(46, 17)
        Me.lbl_Fecha.TabIndex = 4
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'date_FechaEvento
        '
        Me.date_FechaEvento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaEvento.Location = New System.Drawing.Point(55, 15)
        Me.date_FechaEvento.Name = "date_FechaEvento"
        Me.date_FechaEvento.Size = New System.Drawing.Size(111, 24)
        Me.date_FechaEvento.TabIndex = 5
        '
        'lbl_Evento
        '
        Me.lbl_Evento.AutoSize = True
        Me.lbl_Evento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Evento.Location = New System.Drawing.Point(206, 19)
        Me.lbl_Evento.Name = "lbl_Evento"
        Me.lbl_Evento.Size = New System.Drawing.Size(53, 17)
        Me.lbl_Evento.TabIndex = 6
        Me.lbl_Evento.Text = "Evento:"
        '
        'cbo_Evento
        '
        Me.cbo_Evento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Evento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Evento.FormattingEnabled = True
        Me.cbo_Evento.Items.AddRange(New Object() {"Parto", "Vendido", "Servicio", "Enfermedad", "Muerte", "Control"})
        Me.cbo_Evento.Location = New System.Drawing.Point(270, 15)
        Me.cbo_Evento.Name = "cbo_Evento"
        Me.cbo_Evento.Size = New System.Drawing.Size(206, 25)
        Me.cbo_Evento.TabIndex = 7
        '
        'panel_Eventos
        '
        Me.panel_Eventos.Controls.Add(Me.group_Control)
        Me.panel_Eventos.Controls.Add(Me.group_Enfermedad)
        Me.panel_Eventos.Controls.Add(Me.group_Muerte)
        Me.panel_Eventos.Controls.Add(Me.group_Servicio)
        Me.panel_Eventos.Controls.Add(Me.cbo_Evento)
        Me.panel_Eventos.Controls.Add(Me.lbl_Evento)
        Me.panel_Eventos.Controls.Add(Me.date_FechaEvento)
        Me.panel_Eventos.Controls.Add(Me.lbl_Fecha)
        Me.panel_Eventos.Enabled = False
        Me.panel_Eventos.Location = New System.Drawing.Point(12, 41)
        Me.panel_Eventos.Name = "panel_Eventos"
        Me.panel_Eventos.Size = New System.Drawing.Size(491, 379)
        Me.panel_Eventos.TabIndex = 3
        '
        'group_Control
        '
        Me.group_Control.Controls.Add(Me.cbo_Resultado)
        Me.group_Control.Controls.Add(Me.lbl_Resultado)
        Me.group_Control.Enabled = False
        Me.group_Control.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Control.Location = New System.Drawing.Point(6, 306)
        Me.group_Control.Name = "group_Control"
        Me.group_Control.Size = New System.Drawing.Size(368, 61)
        Me.group_Control.TabIndex = 22
        Me.group_Control.TabStop = False
        Me.group_Control.Text = "CONTROL"
        '
        'cbo_Resultado
        '
        Me.cbo_Resultado.FormattingEnabled = True
        Me.cbo_Resultado.Items.AddRange(New Object() {"Inseminacion satisfactoria", "Inseminacion fallida"})
        Me.cbo_Resultado.Location = New System.Drawing.Point(86, 27)
        Me.cbo_Resultado.Name = "cbo_Resultado"
        Me.cbo_Resultado.Size = New System.Drawing.Size(232, 25)
        Me.cbo_Resultado.TabIndex = 24
        '
        'lbl_Resultado
        '
        Me.lbl_Resultado.AutoSize = True
        Me.lbl_Resultado.Location = New System.Drawing.Point(6, 30)
        Me.lbl_Resultado.Name = "lbl_Resultado"
        Me.lbl_Resultado.Size = New System.Drawing.Size(71, 17)
        Me.lbl_Resultado.TabIndex = 23
        Me.lbl_Resultado.Text = "Resultado:"
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
        Me.group_Enfermedad.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Enfermedad.Location = New System.Drawing.Point(6, 115)
        Me.group_Enfermedad.Name = "group_Enfermedad"
        Me.group_Enfermedad.Size = New System.Drawing.Size(368, 118)
        Me.group_Enfermedad.TabIndex = 11
        Me.group_Enfermedad.TabStop = False
        Me.group_Enfermedad.Text = "ENFERMEDAD"
        '
        'cbo_Medicacion
        '
        Me.cbo_Medicacion.Enabled = False
        Me.cbo_Medicacion.FormattingEnabled = True
        Me.cbo_Medicacion.Items.AddRange(New Object() {"Ubremol"})
        Me.cbo_Medicacion.Location = New System.Drawing.Point(97, 83)
        Me.cbo_Medicacion.Name = "cbo_Medicacion"
        Me.cbo_Medicacion.Size = New System.Drawing.Size(217, 25)
        Me.cbo_Medicacion.TabIndex = 18
        '
        'lbl_Medicacion
        '
        Me.lbl_Medicacion.AutoSize = True
        Me.lbl_Medicacion.Location = New System.Drawing.Point(8, 87)
        Me.lbl_Medicacion.Name = "lbl_Medicacion"
        Me.lbl_Medicacion.Size = New System.Drawing.Size(80, 17)
        Me.lbl_Medicacion.TabIndex = 17
        Me.lbl_Medicacion.Text = "Medicación:"
        '
        'rdo_No
        '
        Me.rdo_No.AutoSize = True
        Me.rdo_No.Location = New System.Drawing.Point(251, 54)
        Me.rdo_No.Name = "rdo_No"
        Me.rdo_No.Size = New System.Drawing.Size(44, 21)
        Me.rdo_No.TabIndex = 16
        Me.rdo_No.TabStop = True
        Me.rdo_No.Text = "No"
        Me.rdo_No.UseVisualStyleBackColor = True
        '
        'rdo_Si
        '
        Me.rdo_Si.AutoSize = True
        Me.rdo_Si.Location = New System.Drawing.Point(207, 54)
        Me.rdo_Si.Name = "rdo_Si"
        Me.rdo_Si.Size = New System.Drawing.Size(36, 21)
        Me.rdo_Si.TabIndex = 15
        Me.rdo_Si.TabStop = True
        Me.rdo_Si.Text = "Si"
        Me.rdo_Si.UseVisualStyleBackColor = True
        '
        'lbl_Suminstra
        '
        Me.lbl_Suminstra.AutoSize = True
        Me.lbl_Suminstra.Location = New System.Drawing.Point(4, 55)
        Me.lbl_Suminstra.Name = "lbl_Suminstra"
        Me.lbl_Suminstra.Size = New System.Drawing.Size(190, 17)
        Me.lbl_Suminstra.TabIndex = 14
        Me.lbl_Suminstra.Text = "¿Se le suministra medicación? :"
        '
        'cbo_Enfermedad
        '
        Me.cbo_Enfermedad.FormattingEnabled = True
        Me.cbo_Enfermedad.Items.AddRange(New Object() {"Mastitis"})
        Me.cbo_Enfermedad.Location = New System.Drawing.Point(142, 22)
        Me.cbo_Enfermedad.Name = "cbo_Enfermedad"
        Me.cbo_Enfermedad.Size = New System.Drawing.Size(220, 25)
        Me.cbo_Enfermedad.TabIndex = 13
        '
        'lbl_TipoEnfermedad
        '
        Me.lbl_TipoEnfermedad.AutoSize = True
        Me.lbl_TipoEnfermedad.Location = New System.Drawing.Point(6, 26)
        Me.lbl_TipoEnfermedad.Name = "lbl_TipoEnfermedad"
        Me.lbl_TipoEnfermedad.Size = New System.Drawing.Size(131, 17)
        Me.lbl_TipoEnfermedad.TabIndex = 12
        Me.lbl_TipoEnfermedad.Text = "Tipo de enfermedad:"
        '
        'group_Muerte
        '
        Me.group_Muerte.Controls.Add(Me.cbo_Causa)
        Me.group_Muerte.Controls.Add(Me.lbl_Causa)
        Me.group_Muerte.Enabled = False
        Me.group_Muerte.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Muerte.Location = New System.Drawing.Point(6, 239)
        Me.group_Muerte.Name = "group_Muerte"
        Me.group_Muerte.Size = New System.Drawing.Size(299, 61)
        Me.group_Muerte.TabIndex = 19
        Me.group_Muerte.TabStop = False
        Me.group_Muerte.Text = "MUERTE"
        '
        'cbo_Causa
        '
        Me.cbo_Causa.FormattingEnabled = True
        Me.cbo_Causa.Items.AddRange(New Object() {"Desconocida", "Enfermedad", "Edad"})
        Me.cbo_Causa.Location = New System.Drawing.Point(61, 27)
        Me.cbo_Causa.Name = "cbo_Causa"
        Me.cbo_Causa.Size = New System.Drawing.Size(232, 25)
        Me.cbo_Causa.TabIndex = 21
        '
        'lbl_Causa
        '
        Me.lbl_Causa.AutoSize = True
        Me.lbl_Causa.Location = New System.Drawing.Point(6, 30)
        Me.lbl_Causa.Name = "lbl_Causa"
        Me.lbl_Causa.Size = New System.Drawing.Size(48, 17)
        Me.lbl_Causa.TabIndex = 20
        Me.lbl_Causa.Text = "Causa:"
        '
        'group_Servicio
        '
        Me.group_Servicio.Controls.Add(Me.cbo_Servicios)
        Me.group_Servicio.Controls.Add(Me.lbl_TipoServicio)
        Me.group_Servicio.Enabled = False
        Me.group_Servicio.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Servicio.Location = New System.Drawing.Point(6, 52)
        Me.group_Servicio.Name = "group_Servicio"
        Me.group_Servicio.Size = New System.Drawing.Size(326, 57)
        Me.group_Servicio.TabIndex = 8
        Me.group_Servicio.TabStop = False
        Me.group_Servicio.Text = "SERVICIO"
        '
        'cbo_Servicios
        '
        Me.cbo_Servicios.FormattingEnabled = True
        Me.cbo_Servicios.Items.AddRange(New Object() {"Veterinario", "Inseminacion artificial", "Entore"})
        Me.cbo_Servicios.Location = New System.Drawing.Point(115, 24)
        Me.cbo_Servicios.Name = "cbo_Servicios"
        Me.cbo_Servicios.Size = New System.Drawing.Size(205, 25)
        Me.cbo_Servicios.TabIndex = 10
        '
        'lbl_TipoServicio
        '
        Me.lbl_TipoServicio.AutoSize = True
        Me.lbl_TipoServicio.Location = New System.Drawing.Point(6, 28)
        Me.lbl_TipoServicio.Name = "lbl_TipoServicio"
        Me.lbl_TipoServicio.Size = New System.Drawing.Size(103, 17)
        Me.lbl_TipoServicio.TabIndex = 9
        Me.lbl_TipoServicio.Text = "Tipo de servicio:"
        '
        'cmd_Registrar
        '
        Me.cmd_Registrar.Enabled = False
        Me.cmd_Registrar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Registrar.Location = New System.Drawing.Point(12, 426)
        Me.cmd_Registrar.Name = "cmd_Registrar"
        Me.cmd_Registrar.Size = New System.Drawing.Size(143, 31)
        Me.cmd_Registrar.TabIndex = 25
        Me.cmd_Registrar.Text = "Registrar evento"
        Me.cmd_Registrar.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Volver.Location = New System.Drawing.Point(414, 426)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(90, 31)
        Me.cmd_Volver.TabIndex = 26
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmRegistrarEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(516, 464)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_Registrar)
        Me.Controls.Add(Me.panel_Eventos)
        Me.Controls.Add(Me.cmd_Seleccionar)
        Me.Controls.Add(Me.txt_NroIdentificador)
        Me.Controls.Add(Me.lbl_NroIdentificador)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRegistrarEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Eventos"
        Me.panel_Eventos.ResumeLayout(False)
        Me.panel_Eventos.PerformLayout()
        Me.group_Control.ResumeLayout(False)
        Me.group_Control.PerformLayout()
        Me.group_Enfermedad.ResumeLayout(False)
        Me.group_Enfermedad.PerformLayout()
        Me.group_Muerte.ResumeLayout(False)
        Me.group_Muerte.PerformLayout()
        Me.group_Servicio.ResumeLayout(False)
        Me.group_Servicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NroIdentificador As System.Windows.Forms.Label
    Friend WithEvents txt_NroIdentificador As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_FechaEvento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Evento As System.Windows.Forms.Label
    Friend WithEvents cbo_Evento As System.Windows.Forms.ComboBox
    Friend WithEvents panel_Eventos As System.Windows.Forms.Panel
    Friend WithEvents group_Control As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Resultado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Resultado As System.Windows.Forms.Label
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
    Friend WithEvents cmd_Registrar As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
