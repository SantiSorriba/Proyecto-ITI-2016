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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupMuerte = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.groupEnfermedad = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.groupMedicacion = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.groupServicio.SuspendLayout()
        Me.groupMuerte.SuspendLayout()
        Me.groupEnfermedad.SuspendLayout()
        Me.groupMedicacion.SuspendLayout()
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
        Me.cboEventos.Items.AddRange(New Object() {"Parto", "Vendido", "Servicio", "Enfermedad", "Medicación", "Muerte"})
        Me.cboEventos.Location = New System.Drawing.Point(432, 7)
        Me.cboEventos.Name = "cboEventos"
        Me.cboEventos.Size = New System.Drawing.Size(198, 24)
        Me.cboEventos.TabIndex = 5
        '
        'groupServicio
        '
        Me.groupServicio.Controls.Add(Me.cboServicios)
        Me.groupServicio.Controls.Add(Me.Label1)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de servicio:"
        '
        'groupMuerte
        '
        Me.groupMuerte.Controls.Add(Me.ComboBox3)
        Me.groupMuerte.Controls.Add(Me.Label4)
        Me.groupMuerte.Enabled = False
        Me.groupMuerte.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupMuerte.Location = New System.Drawing.Point(341, 96)
        Me.groupMuerte.Name = "groupMuerte"
        Me.groupMuerte.Size = New System.Drawing.Size(251, 61)
        Me.groupMuerte.TabIndex = 9
        Me.groupMuerte.TabStop = False
        Me.groupMuerte.Text = "MUERTE"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(61, 27)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(184, 24)
        Me.ComboBox3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Causa:"
        '
        'groupEnfermedad
        '
        Me.groupEnfermedad.Controls.Add(Me.ComboBox1)
        Me.groupEnfermedad.Controls.Add(Me.Label2)
        Me.groupEnfermedad.Enabled = False
        Me.groupEnfermedad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupEnfermedad.Location = New System.Drawing.Point(320, 35)
        Me.groupEnfermedad.Name = "groupEnfermedad"
        Me.groupEnfermedad.Size = New System.Drawing.Size(368, 55)
        Me.groupEnfermedad.TabIndex = 10
        Me.groupEnfermedad.TabStop = False
        Me.groupEnfermedad.Text = "ENFERMEDAD"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 24)
        Me.ComboBox1.TabIndex = 1
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
        'groupMedicacion
        '
        Me.groupMedicacion.Controls.Add(Me.ComboBox2)
        Me.groupMedicacion.Controls.Add(Me.Label3)
        Me.groupMedicacion.Enabled = False
        Me.groupMedicacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupMedicacion.Location = New System.Drawing.Point(15, 96)
        Me.groupMedicacion.Name = "groupMedicacion"
        Me.groupMedicacion.Size = New System.Drawing.Size(320, 61)
        Me.groupMedicacion.TabIndex = 11
        Me.groupMedicacion.TabStop = False
        Me.groupMedicacion.Text = "MEDICACIÓN"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(136, 27)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 24)
        Me.ComboBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo de medicación:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(598, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(598, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCargarEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(703, 169)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.groupMedicacion)
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
        Me.groupMedicacion.ResumeLayout(False)
        Me.groupMedicacion.PerformLayout()
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
    Friend WithEvents groupMedicacion As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
