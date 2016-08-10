<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarEventos
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
        Me.lblNumAnimal = New System.Windows.Forms.Label()
        Me.txtNumAnimal = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dateEvento = New System.Windows.Forms.DateTimePicker()
        Me.lblEvento = New System.Windows.Forms.Label()
        Me.cboEventos = New System.Windows.Forms.ComboBox()
        Me.groupServicio = New System.Windows.Forms.GroupBox()
        Me.cboServicios = New System.Windows.Forms.ComboBox()
        Me.lblTipoServicio = New System.Windows.Forms.Label()
        Me.groupMuerte = New System.Windows.Forms.GroupBox()
        Me.cboCausa = New System.Windows.Forms.ComboBox()
        Me.lblCausa = New System.Windows.Forms.Label()
        Me.groupEnfermedad = New System.Windows.Forms.GroupBox()
        Me.cboEnfermedad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblSuminstra = New System.Windows.Forms.Label()
        Me.rdoSi = New System.Windows.Forms.RadioButton()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.lblMedicacion = New System.Windows.Forms.Label()
        Me.cboMedicacion = New System.Windows.Forms.ComboBox()
        Me.groupServicio.SuspendLayout()
        Me.groupMuerte.SuspendLayout()
        Me.groupEnfermedad.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumAnimal
        '
        Me.lblNumAnimal.AutoSize = True
        Me.lblNumAnimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumAnimal.Location = New System.Drawing.Point(12, 10)
        Me.lblNumAnimal.Name = "lblNumAnimal"
        Me.lblNumAnimal.Size = New System.Drawing.Size(120, 16)
        Me.lblNumAnimal.TabIndex = 0
        Me.lblNumAnimal.Text = "Número del animal:"
        '
        'txtNumAnimal
        '
        Me.txtNumAnimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumAnimal.Location = New System.Drawing.Point(138, 7)
        Me.txtNumAnimal.Name = "txtNumAnimal"
        Me.txtNumAnimal.Size = New System.Drawing.Size(62, 22)
        Me.txtNumAnimal.TabIndex = 1
        Me.txtNumAnimal.Text = "555555"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(217, 10)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'dateEvento
        '
        Me.dateEvento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateEvento.Location = New System.Drawing.Point(271, 7)
        Me.dateEvento.Name = "dateEvento"
        Me.dateEvento.Size = New System.Drawing.Size(98, 22)
        Me.dateEvento.TabIndex = 3
        '
        'lblEvento
        '
        Me.lblEvento.AutoSize = True
        Me.lblEvento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvento.Location = New System.Drawing.Point(375, 10)
        Me.lblEvento.Name = "lblEvento"
        Me.lblEvento.Size = New System.Drawing.Size(51, 16)
        Me.lblEvento.TabIndex = 4
        Me.lblEvento.Text = "Evento:"
        '
        'cboEventos
        '
        Me.cboEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEventos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventos.FormattingEnabled = True
        Me.cboEventos.Items.AddRange(New Object() {"Parto", "Vendido", "Servicio", "Enfermedad", "Muerte"})
        Me.cboEventos.Location = New System.Drawing.Point(432, 7)
        Me.cboEventos.Name = "cboEventos"
        Me.cboEventos.Size = New System.Drawing.Size(198, 24)
        Me.cboEventos.TabIndex = 5
        '
        'groupServicio
        '
        Me.groupServicio.Controls.Add(Me.cboServicios)
        Me.groupServicio.Controls.Add(Me.lblTipoServicio)
        Me.groupServicio.Enabled = False
        Me.groupServicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupServicio.Location = New System.Drawing.Point(15, 33)
        Me.groupServicio.Name = "groupServicio"
        Me.groupServicio.Size = New System.Drawing.Size(299, 57)
        Me.groupServicio.TabIndex = 7
        Me.groupServicio.TabStop = False
        Me.groupServicio.Text = "SERVICIO"
        '
        'cboServicios
        '
        Me.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicios.FormattingEnabled = True
        Me.cboServicios.Location = New System.Drawing.Point(113, 24)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Size = New System.Drawing.Size(180, 24)
        Me.cboServicios.TabIndex = 1
        '
        'lblTipoServicio
        '
        Me.lblTipoServicio.AutoSize = True
        Me.lblTipoServicio.Location = New System.Drawing.Point(6, 27)
        Me.lblTipoServicio.Name = "lblTipoServicio"
        Me.lblTipoServicio.Size = New System.Drawing.Size(101, 16)
        Me.lblTipoServicio.TabIndex = 0
        Me.lblTipoServicio.Text = "Tipo de servicio:"
        '
        'groupMuerte
        '
        Me.groupMuerte.Controls.Add(Me.cboCausa)
        Me.groupMuerte.Controls.Add(Me.lblCausa)
        Me.groupMuerte.Enabled = False
        Me.groupMuerte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupMuerte.Location = New System.Drawing.Point(15, 96)
        Me.groupMuerte.Name = "groupMuerte"
        Me.groupMuerte.Size = New System.Drawing.Size(299, 61)
        Me.groupMuerte.TabIndex = 9
        Me.groupMuerte.TabStop = False
        Me.groupMuerte.Text = "MUERTE"
        '
        'cboCausa
        '
        Me.cboCausa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCausa.FormattingEnabled = True
        Me.cboCausa.Location = New System.Drawing.Point(61, 27)
        Me.cboCausa.Name = "cboCausa"
        Me.cboCausa.Size = New System.Drawing.Size(232, 24)
        Me.cboCausa.TabIndex = 1
        '
        'lblCausa
        '
        Me.lblCausa.AutoSize = True
        Me.lblCausa.Location = New System.Drawing.Point(6, 30)
        Me.lblCausa.Name = "lblCausa"
        Me.lblCausa.Size = New System.Drawing.Size(49, 16)
        Me.lblCausa.TabIndex = 0
        Me.lblCausa.Text = "Causa:"
        '
        'groupEnfermedad
        '
        Me.groupEnfermedad.Controls.Add(Me.cboMedicacion)
        Me.groupEnfermedad.Controls.Add(Me.lblMedicacion)
        Me.groupEnfermedad.Controls.Add(Me.rdoNo)
        Me.groupEnfermedad.Controls.Add(Me.rdoSi)
        Me.groupEnfermedad.Controls.Add(Me.lblSuminstra)
        Me.groupEnfermedad.Controls.Add(Me.cboEnfermedad)
        Me.groupEnfermedad.Controls.Add(Me.Label2)
        Me.groupEnfermedad.Enabled = False
        Me.groupEnfermedad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupEnfermedad.Location = New System.Drawing.Point(320, 35)
        Me.groupEnfermedad.Name = "groupEnfermedad"
        Me.groupEnfermedad.Size = New System.Drawing.Size(368, 104)
        Me.groupEnfermedad.TabIndex = 10
        Me.groupEnfermedad.TabStop = False
        Me.groupEnfermedad.Text = "ENFERMEDAD"
        '
        'cboEnfermedad
        '
        Me.cboEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnfermedad.FormattingEnabled = True
        Me.cboEnfermedad.Location = New System.Drawing.Point(137, 22)
        Me.cboEnfermedad.Name = "cboEnfermedad"
        Me.cboEnfermedad.Size = New System.Drawing.Size(213, 24)
        Me.cboEnfermedad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de enfermedad:"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(502, 145)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(90, 23)
        Me.cmdGuardar.TabIndex = 12
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(598, 145)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 23)
        Me.cmdCancelar.TabIndex = 13
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'lblSuminstra
        '
        Me.lblSuminstra.AutoSize = True
        Me.lblSuminstra.Location = New System.Drawing.Point(4, 53)
        Me.lblSuminstra.Name = "lblSuminstra"
        Me.lblSuminstra.Size = New System.Drawing.Size(195, 16)
        Me.lblSuminstra.TabIndex = 2
        Me.lblSuminstra.Text = "¿Se le suministra medicación? :"
        '
        'rdoSi
        '
        Me.rdoSi.AutoSize = True
        Me.rdoSi.Location = New System.Drawing.Point(207, 52)
        Me.rdoSi.Name = "rdoSi"
        Me.rdoSi.Size = New System.Drawing.Size(38, 20)
        Me.rdoSi.TabIndex = 3
        Me.rdoSi.TabStop = True
        Me.rdoSi.Text = "Si"
        Me.rdoSi.UseVisualStyleBackColor = True
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(251, 52)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(42, 20)
        Me.rdoNo.TabIndex = 4
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'lblMedicacion
        '
        Me.lblMedicacion.AutoSize = True
        Me.lblMedicacion.Location = New System.Drawing.Point(9, 79)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(78, 16)
        Me.lblMedicacion.TabIndex = 5
        Me.lblMedicacion.Text = "Medicación:"
        '
        'cboMedicacion
        '
        Me.cboMedicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedicacion.Enabled = False
        Me.cboMedicacion.FormattingEnabled = True
        Me.cboMedicacion.Items.AddRange(New Object() {"1", "2"})
        Me.cboMedicacion.Location = New System.Drawing.Point(93, 74)
        Me.cboMedicacion.Name = "cboMedicacion"
        Me.cboMedicacion.Size = New System.Drawing.Size(217, 24)
        Me.cboMedicacion.TabIndex = 6
        '
        'frmCargarEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(703, 175)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.groupEnfermedad)
        Me.Controls.Add(Me.groupMuerte)
        Me.Controls.Add(Me.groupServicio)
        Me.Controls.Add(Me.cboEventos)
        Me.Controls.Add(Me.lblEvento)
        Me.Controls.Add(Me.dateEvento)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtNumAnimal)
        Me.Controls.Add(Me.lblNumAnimal)
        Me.MaximizeBox = False
        Me.Name = "frmCargarEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Evento"
        Me.groupServicio.ResumeLayout(False)
        Me.groupServicio.PerformLayout()
        Me.groupMuerte.ResumeLayout(False)
        Me.groupMuerte.PerformLayout()
        Me.groupEnfermedad.ResumeLayout(False)
        Me.groupEnfermedad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumAnimal As System.Windows.Forms.Label
    Friend WithEvents txtNumAnimal As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dateEvento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEvento As System.Windows.Forms.Label
    Friend WithEvents cboEventos As System.Windows.Forms.ComboBox
    Friend WithEvents groupServicio As System.Windows.Forms.GroupBox
    Friend WithEvents groupMuerte As System.Windows.Forms.GroupBox
    Friend WithEvents groupEnfermedad As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoServicio As System.Windows.Forms.Label
    Friend WithEvents cboCausa As System.Windows.Forms.ComboBox
    Friend WithEvents lblCausa As System.Windows.Forms.Label
    Friend WithEvents cboEnfermedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSi As System.Windows.Forms.RadioButton
    Friend WithEvents lblSuminstra As System.Windows.Forms.Label
    Friend WithEvents cboMedicacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
End Class
