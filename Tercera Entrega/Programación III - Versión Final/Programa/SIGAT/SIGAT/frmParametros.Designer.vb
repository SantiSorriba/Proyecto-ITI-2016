<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.panel_Parametros = New System.Windows.Forms.Panel()
        Me.lbl_Dias2 = New System.Windows.Forms.Label()
        Me.num_AnestroPostParto = New System.Windows.Forms.NumericUpDown()
        Me.lbl_AnestroPostParto = New System.Windows.Forms.Label()
        Me.lbl_Dias = New System.Windows.Forms.Label()
        Me.num_Control = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Meses = New System.Windows.Forms.Label()
        Me.num_Vaquillona = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Vaquillona = New System.Windows.Forms.Label()
        Me.lbl_Control = New System.Windows.Forms.Label()
        Me.rdo_Manual = New System.Windows.Forms.RadioButton()
        Me.rdo_Mecanico = New System.Windows.Forms.RadioButton()
        Me.lbl_TipoOrdenie = New System.Windows.Forms.Label()
        Me.num_CantVacas = New System.Windows.Forms.NumericUpDown()
        Me.lbl_CantVacas = New System.Windows.Forms.Label()
        Me.group_TercerOrdenie = New System.Windows.Forms.GroupBox()
        Me.time_HoraFin3 = New System.Windows.Forms.DateTimePicker()
        Me.time_HoraInicio3 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraFin3 = New System.Windows.Forms.Label()
        Me.lbl_HoraInicio3 = New System.Windows.Forms.Label()
        Me.group_SegundoOrdenie = New System.Windows.Forms.GroupBox()
        Me.time_HoraFin2 = New System.Windows.Forms.DateTimePicker()
        Me.time_HoraInicio2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraFin2 = New System.Windows.Forms.Label()
        Me.lbl_HoraInicio2 = New System.Windows.Forms.Label()
        Me.group_PrimerOrdenie = New System.Windows.Forms.GroupBox()
        Me.time_HoraFin1 = New System.Windows.Forms.DateTimePicker()
        Me.time_HoraInicio1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraFin1 = New System.Windows.Forms.Label()
        Me.lbl_HoraInicio1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_GuardarParametros = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.panel_Parametros.SuspendLayout()
        CType(Me.num_AnestroPostParto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Control, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Vaquillona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_CantVacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_TercerOrdenie.SuspendLayout()
        Me.group_SegundoOrdenie.SuspendLayout()
        Me.group_PrimerOrdenie.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(9, 15)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(106, 17)
        Me.lbl_Establecimiento.TabIndex = 0
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(121, 12)
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(215, 25)
        Me.cbo_Establecimientos.TabIndex = 1
        '
        'panel_Parametros
        '
        Me.panel_Parametros.Controls.Add(Me.lbl_Dias2)
        Me.panel_Parametros.Controls.Add(Me.num_AnestroPostParto)
        Me.panel_Parametros.Controls.Add(Me.lbl_AnestroPostParto)
        Me.panel_Parametros.Controls.Add(Me.lbl_Dias)
        Me.panel_Parametros.Controls.Add(Me.num_Control)
        Me.panel_Parametros.Controls.Add(Me.lbl_Meses)
        Me.panel_Parametros.Controls.Add(Me.num_Vaquillona)
        Me.panel_Parametros.Controls.Add(Me.lbl_Vaquillona)
        Me.panel_Parametros.Controls.Add(Me.lbl_Control)
        Me.panel_Parametros.Controls.Add(Me.rdo_Manual)
        Me.panel_Parametros.Controls.Add(Me.rdo_Mecanico)
        Me.panel_Parametros.Controls.Add(Me.lbl_TipoOrdenie)
        Me.panel_Parametros.Controls.Add(Me.num_CantVacas)
        Me.panel_Parametros.Controls.Add(Me.lbl_CantVacas)
        Me.panel_Parametros.Controls.Add(Me.group_TercerOrdenie)
        Me.panel_Parametros.Controls.Add(Me.group_SegundoOrdenie)
        Me.panel_Parametros.Controls.Add(Me.group_PrimerOrdenie)
        Me.panel_Parametros.Enabled = False
        Me.panel_Parametros.Location = New System.Drawing.Point(12, 46)
        Me.panel_Parametros.Name = "panel_Parametros"
        Me.panel_Parametros.Size = New System.Drawing.Size(365, 376)
        Me.panel_Parametros.TabIndex = 2
        '
        'lbl_Dias2
        '
        Me.lbl_Dias2.AutoSize = True
        Me.lbl_Dias2.Location = New System.Drawing.Point(192, 346)
        Me.lbl_Dias2.Name = "lbl_Dias2"
        Me.lbl_Dias2.Size = New System.Drawing.Size(32, 17)
        Me.lbl_Dias2.TabIndex = 19
        Me.lbl_Dias2.Text = "dias"
        '
        'num_AnestroPostParto
        '
        Me.num_AnestroPostParto.Location = New System.Drawing.Point(138, 343)
        Me.num_AnestroPostParto.Name = "num_AnestroPostParto"
        Me.num_AnestroPostParto.Size = New System.Drawing.Size(48, 24)
        Me.num_AnestroPostParto.TabIndex = 18
        '
        'lbl_AnestroPostParto
        '
        Me.lbl_AnestroPostParto.AutoSize = True
        Me.lbl_AnestroPostParto.Location = New System.Drawing.Point(3, 346)
        Me.lbl_AnestroPostParto.Name = "lbl_AnestroPostParto"
        Me.lbl_AnestroPostParto.Size = New System.Drawing.Size(128, 17)
        Me.lbl_AnestroPostParto.TabIndex = 17
        Me.lbl_AnestroPostParto.Text = "Anestro post-parto:"
        '
        'lbl_Dias
        '
        Me.lbl_Dias.AutoSize = True
        Me.lbl_Dias.Location = New System.Drawing.Point(234, 317)
        Me.lbl_Dias.Name = "lbl_Dias"
        Me.lbl_Dias.Size = New System.Drawing.Size(32, 17)
        Me.lbl_Dias.TabIndex = 16
        Me.lbl_Dias.Text = "dias"
        '
        'num_Control
        '
        Me.num_Control.Location = New System.Drawing.Point(179, 312)
        Me.num_Control.Name = "num_Control"
        Me.num_Control.Size = New System.Drawing.Size(48, 24)
        Me.num_Control.TabIndex = 15
        '
        'lbl_Meses
        '
        Me.lbl_Meses.AutoSize = True
        Me.lbl_Meses.Location = New System.Drawing.Point(166, 285)
        Me.lbl_Meses.Name = "lbl_Meses"
        Me.lbl_Meses.Size = New System.Drawing.Size(46, 17)
        Me.lbl_Meses.TabIndex = 14
        Me.lbl_Meses.Text = "meses"
        '
        'num_Vaquillona
        '
        Me.num_Vaquillona.Location = New System.Drawing.Point(113, 281)
        Me.num_Vaquillona.Name = "num_Vaquillona"
        Me.num_Vaquillona.Size = New System.Drawing.Size(48, 24)
        Me.num_Vaquillona.TabIndex = 13
        '
        'lbl_Vaquillona
        '
        Me.lbl_Vaquillona.AutoSize = True
        Me.lbl_Vaquillona.Location = New System.Drawing.Point(3, 284)
        Me.lbl_Vaquillona.Name = "lbl_Vaquillona"
        Me.lbl_Vaquillona.Size = New System.Drawing.Size(105, 17)
        Me.lbl_Vaquillona.TabIndex = 12
        Me.lbl_Vaquillona.Text = "Vaquillona a los:"
        '
        'lbl_Control
        '
        Me.lbl_Control.AutoSize = True
        Me.lbl_Control.Location = New System.Drawing.Point(2, 315)
        Me.lbl_Control.Name = "lbl_Control"
        Me.lbl_Control.Size = New System.Drawing.Size(169, 17)
        Me.lbl_Control.TabIndex = 8
        Me.lbl_Control.Text = "Control post-inseminación"
        '
        'rdo_Manual
        '
        Me.rdo_Manual.AutoSize = True
        Me.rdo_Manual.Location = New System.Drawing.Point(200, 221)
        Me.rdo_Manual.Name = "rdo_Manual"
        Me.rdo_Manual.Size = New System.Drawing.Size(72, 21)
        Me.rdo_Manual.TabIndex = 7
        Me.rdo_Manual.TabStop = True
        Me.rdo_Manual.Text = "Manual"
        Me.rdo_Manual.UseVisualStyleBackColor = True
        '
        'rdo_Mecanico
        '
        Me.rdo_Mecanico.AutoSize = True
        Me.rdo_Mecanico.Location = New System.Drawing.Point(110, 221)
        Me.rdo_Mecanico.Name = "rdo_Mecanico"
        Me.rdo_Mecanico.Size = New System.Drawing.Size(84, 21)
        Me.rdo_Mecanico.TabIndex = 6
        Me.rdo_Mecanico.TabStop = True
        Me.rdo_Mecanico.Text = "Mecánico"
        Me.rdo_Mecanico.UseVisualStyleBackColor = True
        '
        'lbl_TipoOrdenie
        '
        Me.lbl_TipoOrdenie.AutoSize = True
        Me.lbl_TipoOrdenie.Location = New System.Drawing.Point(3, 223)
        Me.lbl_TipoOrdenie.Name = "lbl_TipoOrdenie"
        Me.lbl_TipoOrdenie.Size = New System.Drawing.Size(101, 17)
        Me.lbl_TipoOrdenie.TabIndex = 5
        Me.lbl_TipoOrdenie.Text = "Tipo de ordeñe:"
        '
        'num_CantVacas
        '
        Me.num_CantVacas.Location = New System.Drawing.Point(178, 250)
        Me.num_CantVacas.Name = "num_CantVacas"
        Me.num_CantVacas.Size = New System.Drawing.Size(48, 24)
        Me.num_CantVacas.TabIndex = 4
        '
        'lbl_CantVacas
        '
        Me.lbl_CantVacas.AutoSize = True
        Me.lbl_CantVacas.Location = New System.Drawing.Point(3, 254)
        Me.lbl_CantVacas.Name = "lbl_CantVacas"
        Me.lbl_CantVacas.Size = New System.Drawing.Size(170, 17)
        Me.lbl_CantVacas.TabIndex = 3
        Me.lbl_CantVacas.Text = "Cantidad de vacas por lote:"
        '
        'group_TercerOrdenie
        '
        Me.group_TercerOrdenie.Controls.Add(Me.time_HoraFin3)
        Me.group_TercerOrdenie.Controls.Add(Me.time_HoraInicio3)
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_HoraFin3)
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_HoraInicio3)
        Me.group_TercerOrdenie.Location = New System.Drawing.Point(3, 145)
        Me.group_TercerOrdenie.Name = "group_TercerOrdenie"
        Me.group_TercerOrdenie.Size = New System.Drawing.Size(349, 65)
        Me.group_TercerOrdenie.TabIndex = 2
        Me.group_TercerOrdenie.TabStop = False
        Me.group_TercerOrdenie.Text = "Tercer Ordeñe"
        '
        'time_HoraFin3
        '
        Me.time_HoraFin3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_HoraFin3.Location = New System.Drawing.Point(267, 28)
        Me.time_HoraFin3.Name = "time_HoraFin3"
        Me.time_HoraFin3.Size = New System.Drawing.Size(75, 24)
        Me.time_HoraFin3.TabIndex = 3
        '
        'time_HoraInicio3
        '
        Me.time_HoraInicio3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_HoraInicio3.Location = New System.Drawing.Point(105, 28)
        Me.time_HoraInicio3.Name = "time_HoraInicio3"
        Me.time_HoraInicio3.Size = New System.Drawing.Size(75, 24)
        Me.time_HoraInicio3.TabIndex = 2
        '
        'lbl_HoraFin3
        '
        Me.lbl_HoraFin3.AutoSize = True
        Me.lbl_HoraFin3.Location = New System.Drawing.Point(186, 31)
        Me.lbl_HoraFin3.Name = "lbl_HoraFin3"
        Me.lbl_HoraFin3.Size = New System.Drawing.Size(77, 17)
        Me.lbl_HoraFin3.TabIndex = 1
        Me.lbl_HoraFin3.Text = "Hora de fin:"
        '
        'lbl_HoraInicio3
        '
        Me.lbl_HoraInicio3.AutoSize = True
        Me.lbl_HoraInicio3.Location = New System.Drawing.Point(6, 31)
        Me.lbl_HoraInicio3.Name = "lbl_HoraInicio3"
        Me.lbl_HoraInicio3.Size = New System.Drawing.Size(93, 17)
        Me.lbl_HoraInicio3.TabIndex = 0
        Me.lbl_HoraInicio3.Text = "Hora de inicio:"
        '
        'group_SegundoOrdenie
        '
        Me.group_SegundoOrdenie.Controls.Add(Me.time_HoraFin2)
        Me.group_SegundoOrdenie.Controls.Add(Me.time_HoraInicio2)
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_HoraFin2)
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_HoraInicio2)
        Me.group_SegundoOrdenie.Location = New System.Drawing.Point(3, 74)
        Me.group_SegundoOrdenie.Name = "group_SegundoOrdenie"
        Me.group_SegundoOrdenie.Size = New System.Drawing.Size(349, 65)
        Me.group_SegundoOrdenie.TabIndex = 1
        Me.group_SegundoOrdenie.TabStop = False
        Me.group_SegundoOrdenie.Text = "Segundo Ordeñe"
        '
        'time_HoraFin2
        '
        Me.time_HoraFin2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_HoraFin2.Location = New System.Drawing.Point(267, 28)
        Me.time_HoraFin2.Name = "time_HoraFin2"
        Me.time_HoraFin2.Size = New System.Drawing.Size(75, 24)
        Me.time_HoraFin2.TabIndex = 3
        '
        'time_HoraInicio2
        '
        Me.time_HoraInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_HoraInicio2.Location = New System.Drawing.Point(105, 28)
        Me.time_HoraInicio2.Name = "time_HoraInicio2"
        Me.time_HoraInicio2.Size = New System.Drawing.Size(75, 24)
        Me.time_HoraInicio2.TabIndex = 2
        '
        'lbl_HoraFin2
        '
        Me.lbl_HoraFin2.AutoSize = True
        Me.lbl_HoraFin2.Location = New System.Drawing.Point(186, 31)
        Me.lbl_HoraFin2.Name = "lbl_HoraFin2"
        Me.lbl_HoraFin2.Size = New System.Drawing.Size(77, 17)
        Me.lbl_HoraFin2.TabIndex = 1
        Me.lbl_HoraFin2.Text = "Hora de fin:"
        '
        'lbl_HoraInicio2
        '
        Me.lbl_HoraInicio2.AutoSize = True
        Me.lbl_HoraInicio2.Location = New System.Drawing.Point(6, 31)
        Me.lbl_HoraInicio2.Name = "lbl_HoraInicio2"
        Me.lbl_HoraInicio2.Size = New System.Drawing.Size(93, 17)
        Me.lbl_HoraInicio2.TabIndex = 0
        Me.lbl_HoraInicio2.Text = "Hora de inicio:"
        '
        'group_PrimerOrdenie
        '
        Me.group_PrimerOrdenie.Controls.Add(Me.time_HoraFin1)
        Me.group_PrimerOrdenie.Controls.Add(Me.time_HoraInicio1)
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_HoraFin1)
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_HoraInicio1)
        Me.group_PrimerOrdenie.Location = New System.Drawing.Point(5, 3)
        Me.group_PrimerOrdenie.Name = "group_PrimerOrdenie"
        Me.group_PrimerOrdenie.Size = New System.Drawing.Size(349, 65)
        Me.group_PrimerOrdenie.TabIndex = 0
        Me.group_PrimerOrdenie.TabStop = False
        Me.group_PrimerOrdenie.Text = "Primer Ordeñe"
        '
        'time_HoraFin1
        '
        Me.time_HoraFin1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_HoraFin1.Location = New System.Drawing.Point(267, 28)
        Me.time_HoraFin1.Name = "time_HoraFin1"
        Me.time_HoraFin1.Size = New System.Drawing.Size(75, 24)
        Me.time_HoraFin1.TabIndex = 3
        '
        'time_HoraInicio1
        '
        Me.time_HoraInicio1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_HoraInicio1.Location = New System.Drawing.Point(105, 28)
        Me.time_HoraInicio1.Name = "time_HoraInicio1"
        Me.time_HoraInicio1.Size = New System.Drawing.Size(75, 24)
        Me.time_HoraInicio1.TabIndex = 2
        '
        'lbl_HoraFin1
        '
        Me.lbl_HoraFin1.AutoSize = True
        Me.lbl_HoraFin1.Location = New System.Drawing.Point(186, 31)
        Me.lbl_HoraFin1.Name = "lbl_HoraFin1"
        Me.lbl_HoraFin1.Size = New System.Drawing.Size(77, 17)
        Me.lbl_HoraFin1.TabIndex = 1
        Me.lbl_HoraFin1.Text = "Hora de fin:"
        '
        'lbl_HoraInicio1
        '
        Me.lbl_HoraInicio1.AutoSize = True
        Me.lbl_HoraInicio1.Location = New System.Drawing.Point(6, 31)
        Me.lbl_HoraInicio1.Name = "lbl_HoraInicio1"
        Me.lbl_HoraInicio1.Size = New System.Drawing.Size(93, 17)
        Me.lbl_HoraInicio1.TabIndex = 0
        Me.lbl_HoraInicio1.Text = "Hora de inicio:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(342, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmd_GuardarParametros
        '
        Me.cmd_GuardarParametros.Enabled = False
        Me.cmd_GuardarParametros.Location = New System.Drawing.Point(12, 428)
        Me.cmd_GuardarParametros.Name = "cmd_GuardarParametros"
        Me.cmd_GuardarParametros.Size = New System.Drawing.Size(146, 28)
        Me.cmd_GuardarParametros.TabIndex = 4
        Me.cmd_GuardarParametros.Text = "Guardar parámetros"
        Me.cmd_GuardarParametros.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(325, 428)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(78, 28)
        Me.cmd_Volver.TabIndex = 5
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(409, 462)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_GuardarParametros)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.panel_Parametros)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.lbl_Establecimiento)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetros"
        Me.panel_Parametros.ResumeLayout(False)
        Me.panel_Parametros.PerformLayout()
        CType(Me.num_AnestroPostParto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Control, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Vaquillona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_CantVacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_TercerOrdenie.ResumeLayout(False)
        Me.group_TercerOrdenie.PerformLayout()
        Me.group_SegundoOrdenie.ResumeLayout(False)
        Me.group_SegundoOrdenie.PerformLayout()
        Me.group_PrimerOrdenie.ResumeLayout(False)
        Me.group_PrimerOrdenie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents panel_Parametros As System.Windows.Forms.Panel
    Friend WithEvents group_TercerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents time_HoraFin3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time_HoraInicio3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraFin3 As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraInicio3 As System.Windows.Forms.Label
    Friend WithEvents group_SegundoOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents time_HoraFin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time_HoraInicio2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraFin2 As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraInicio2 As System.Windows.Forms.Label
    Friend WithEvents group_PrimerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents time_HoraFin1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time_HoraInicio1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraFin1 As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraInicio1 As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoOrdenie As System.Windows.Forms.Label
    Friend WithEvents num_CantVacas As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_CantVacas As System.Windows.Forms.Label
    Friend WithEvents lbl_Dias As System.Windows.Forms.Label
    Friend WithEvents num_Control As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_Meses As System.Windows.Forms.Label
    Friend WithEvents num_Vaquillona As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_Vaquillona As System.Windows.Forms.Label
    Friend WithEvents lbl_Control As System.Windows.Forms.Label
    Friend WithEvents rdo_Manual As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Mecanico As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_Dias2 As System.Windows.Forms.Label
    Friend WithEvents num_AnestroPostParto As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_AnestroPostParto As System.Windows.Forms.Label
    Friend WithEvents cmd_GuardarParametros As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
