<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenies
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
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_FechaOrdenie = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Lote = New System.Windows.Forms.Label()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.chk_SegundoOrdenie = New System.Windows.Forms.CheckBox()
        Me.group_TercerOrdenie = New System.Windows.Forms.GroupBox()
        Me.lbl_Lts3 = New System.Windows.Forms.Label()
        Me.txt_Cant3 = New System.Windows.Forms.TextBox()
        Me.lbl_Cant3 = New System.Windows.Forms.Label()
        Me.time_Fin3 = New System.Windows.Forms.DateTimePicker()
        Me.time_Inicio3 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraFin3 = New System.Windows.Forms.Label()
        Me.lbl_HoraInicio3 = New System.Windows.Forms.Label()
        Me.group_SegundoOrdenie = New System.Windows.Forms.GroupBox()
        Me.lbl_Lts2 = New System.Windows.Forms.Label()
        Me.txt_Cant2 = New System.Windows.Forms.TextBox()
        Me.lbl_Cant2 = New System.Windows.Forms.Label()
        Me.time_Fin2 = New System.Windows.Forms.DateTimePicker()
        Me.time_Inicio2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraFin2 = New System.Windows.Forms.Label()
        Me.lbl_HoraInicio2 = New System.Windows.Forms.Label()
        Me.chk_TercerOrdenie = New System.Windows.Forms.CheckBox()
        Me.chk_PrimerOrdenie = New System.Windows.Forms.CheckBox()
        Me.group_PrimerOrdenie = New System.Windows.Forms.GroupBox()
        Me.lbl_Lts1 = New System.Windows.Forms.Label()
        Me.txt_Cant1 = New System.Windows.Forms.TextBox()
        Me.lbl_Cant1 = New System.Windows.Forms.Label()
        Me.time_Fin1 = New System.Windows.Forms.DateTimePicker()
        Me.time_Inicio1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraFin1 = New System.Windows.Forms.Label()
        Me.lbl_HoraInicio1 = New System.Windows.Forms.Label()
        Me.group_TercerOrdenie.SuspendLayout()
        Me.group_SegundoOrdenie.SuspendLayout()
        Me.group_PrimerOrdenie.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Fecha.TabIndex = 0
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'date_FechaOrdenie
        '
        Me.date_FechaOrdenie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaOrdenie.Location = New System.Drawing.Point(66, 7)
        Me.date_FechaOrdenie.Name = "date_FechaOrdenie"
        Me.date_FechaOrdenie.Size = New System.Drawing.Size(103, 22)
        Me.date_FechaOrdenie.TabIndex = 1
        '
        'lbl_Lote
        '
        Me.lbl_Lote.AutoSize = True
        Me.lbl_Lote.Location = New System.Drawing.Point(175, 9)
        Me.lbl_Lote.Name = "lbl_Lote"
        Me.lbl_Lote.Size = New System.Drawing.Size(37, 16)
        Me.lbl_Lote.TabIndex = 2
        Me.lbl_Lote.Text = "Lote:"
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Items.AddRange(New Object() {"Vacas para ordeñe"})
        Me.cboLotes.Location = New System.Drawing.Point(218, 6)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(154, 24)
        Me.cboLotes.TabIndex = 14
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(247, 431)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(128, 26)
        Me.cmd_Cancelar.TabIndex = 22
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Enabled = False
        Me.cmd_Guardar.Location = New System.Drawing.Point(9, 431)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(128, 26)
        Me.cmd_Guardar.TabIndex = 21
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'chk_SegundoOrdenie
        '
        Me.chk_SegundoOrdenie.AutoSize = True
        Me.chk_SegundoOrdenie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_SegundoOrdenie.Enabled = False
        Me.chk_SegundoOrdenie.Location = New System.Drawing.Point(9, 175)
        Me.chk_SegundoOrdenie.Name = "chk_SegundoOrdenie"
        Me.chk_SegundoOrdenie.Size = New System.Drawing.Size(128, 20)
        Me.chk_SegundoOrdenie.TabIndex = 17
        Me.chk_SegundoOrdenie.Text = "Segundo Ordeñe:"
        Me.chk_SegundoOrdenie.UseVisualStyleBackColor = True
        '
        'group_TercerOrdenie
        '
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_Lts3)
        Me.group_TercerOrdenie.Controls.Add(Me.txt_Cant3)
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_Cant3)
        Me.group_TercerOrdenie.Controls.Add(Me.time_Fin3)
        Me.group_TercerOrdenie.Controls.Add(Me.time_Inicio3)
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_HoraFin3)
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_HoraInicio3)
        Me.group_TercerOrdenie.Enabled = False
        Me.group_TercerOrdenie.Location = New System.Drawing.Point(9, 326)
        Me.group_TercerOrdenie.Name = "group_TercerOrdenie"
        Me.group_TercerOrdenie.Size = New System.Drawing.Size(366, 87)
        Me.group_TercerOrdenie.TabIndex = 20
        Me.group_TercerOrdenie.TabStop = False
        Me.group_TercerOrdenie.Text = "3er Ordeñe"
        '
        'lbl_Lts3
        '
        Me.lbl_Lts3.AutoSize = True
        Me.lbl_Lts3.Location = New System.Drawing.Point(212, 58)
        Me.lbl_Lts3.Name = "lbl_Lts3"
        Me.lbl_Lts3.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts3.TabIndex = 20
        Me.lbl_Lts3.Text = "Lts."
        '
        'txt_Cant3
        '
        Me.txt_Cant3.Location = New System.Drawing.Point(137, 55)
        Me.txt_Cant3.Name = "txt_Cant3"
        Me.txt_Cant3.Size = New System.Drawing.Size(69, 22)
        Me.txt_Cant3.TabIndex = 19
        '
        'lbl_Cant3
        '
        Me.lbl_Cant3.AutoSize = True
        Me.lbl_Cant3.Location = New System.Drawing.Point(6, 58)
        Me.lbl_Cant3.Name = "lbl_Cant3"
        Me.lbl_Cant3.Size = New System.Drawing.Size(125, 16)
        Me.lbl_Cant3.TabIndex = 18
        Me.lbl_Cant3.Text = "Cantidad Producida:"
        '
        'time_Fin3
        '
        Me.time_Fin3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_Fin3.Location = New System.Drawing.Point(283, 24)
        Me.time_Fin3.Name = "time_Fin3"
        Me.time_Fin3.Size = New System.Drawing.Size(73, 22)
        Me.time_Fin3.TabIndex = 11
        '
        'time_Inicio3
        '
        Me.time_Inicio3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_Inicio3.Location = New System.Drawing.Point(103, 24)
        Me.time_Inicio3.Name = "time_Inicio3"
        Me.time_Inicio3.Size = New System.Drawing.Size(73, 22)
        Me.time_Inicio3.TabIndex = 10
        '
        'lbl_HoraFin3
        '
        Me.lbl_HoraFin3.AutoSize = True
        Me.lbl_HoraFin3.Location = New System.Drawing.Point(203, 28)
        Me.lbl_HoraFin3.Name = "lbl_HoraFin3"
        Me.lbl_HoraFin3.Size = New System.Drawing.Size(74, 16)
        Me.lbl_HoraFin3.TabIndex = 9
        Me.lbl_HoraFin3.Text = "Hora de fin:"
        '
        'lbl_HoraInicio3
        '
        Me.lbl_HoraInicio3.AutoSize = True
        Me.lbl_HoraInicio3.Location = New System.Drawing.Point(6, 28)
        Me.lbl_HoraInicio3.Name = "lbl_HoraInicio3"
        Me.lbl_HoraInicio3.Size = New System.Drawing.Size(91, 16)
        Me.lbl_HoraInicio3.TabIndex = 8
        Me.lbl_HoraInicio3.Text = "Hora de inicio:"
        '
        'group_SegundoOrdenie
        '
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_Lts2)
        Me.group_SegundoOrdenie.Controls.Add(Me.txt_Cant2)
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_Cant2)
        Me.group_SegundoOrdenie.Controls.Add(Me.time_Fin2)
        Me.group_SegundoOrdenie.Controls.Add(Me.time_Inicio2)
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_HoraFin2)
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_HoraInicio2)
        Me.group_SegundoOrdenie.Enabled = False
        Me.group_SegundoOrdenie.Location = New System.Drawing.Point(9, 207)
        Me.group_SegundoOrdenie.Name = "group_SegundoOrdenie"
        Me.group_SegundoOrdenie.Size = New System.Drawing.Size(366, 87)
        Me.group_SegundoOrdenie.TabIndex = 19
        Me.group_SegundoOrdenie.TabStop = False
        Me.group_SegundoOrdenie.Text = "2do Ordeñe"
        '
        'lbl_Lts2
        '
        Me.lbl_Lts2.AutoSize = True
        Me.lbl_Lts2.Location = New System.Drawing.Point(212, 59)
        Me.lbl_Lts2.Name = "lbl_Lts2"
        Me.lbl_Lts2.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts2.TabIndex = 17
        Me.lbl_Lts2.Text = "Lts."
        '
        'txt_Cant2
        '
        Me.txt_Cant2.Location = New System.Drawing.Point(137, 56)
        Me.txt_Cant2.Name = "txt_Cant2"
        Me.txt_Cant2.Size = New System.Drawing.Size(69, 22)
        Me.txt_Cant2.TabIndex = 16
        '
        'lbl_Cant2
        '
        Me.lbl_Cant2.AutoSize = True
        Me.lbl_Cant2.Location = New System.Drawing.Point(6, 59)
        Me.lbl_Cant2.Name = "lbl_Cant2"
        Me.lbl_Cant2.Size = New System.Drawing.Size(125, 16)
        Me.lbl_Cant2.TabIndex = 15
        Me.lbl_Cant2.Text = "Cantidad Producida:"
        '
        'time_Fin2
        '
        Me.time_Fin2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_Fin2.Location = New System.Drawing.Point(283, 24)
        Me.time_Fin2.Name = "time_Fin2"
        Me.time_Fin2.Size = New System.Drawing.Size(73, 22)
        Me.time_Fin2.TabIndex = 11
        '
        'time_Inicio2
        '
        Me.time_Inicio2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_Inicio2.Location = New System.Drawing.Point(103, 24)
        Me.time_Inicio2.Name = "time_Inicio2"
        Me.time_Inicio2.Size = New System.Drawing.Size(73, 22)
        Me.time_Inicio2.TabIndex = 10
        '
        'lbl_HoraFin2
        '
        Me.lbl_HoraFin2.AutoSize = True
        Me.lbl_HoraFin2.Location = New System.Drawing.Point(203, 28)
        Me.lbl_HoraFin2.Name = "lbl_HoraFin2"
        Me.lbl_HoraFin2.Size = New System.Drawing.Size(74, 16)
        Me.lbl_HoraFin2.TabIndex = 9
        Me.lbl_HoraFin2.Text = "Hora de fin:"
        '
        'lbl_HoraInicio2
        '
        Me.lbl_HoraInicio2.AutoSize = True
        Me.lbl_HoraInicio2.Location = New System.Drawing.Point(6, 28)
        Me.lbl_HoraInicio2.Name = "lbl_HoraInicio2"
        Me.lbl_HoraInicio2.Size = New System.Drawing.Size(91, 16)
        Me.lbl_HoraInicio2.TabIndex = 8
        Me.lbl_HoraInicio2.Text = "Hora de inicio:"
        '
        'chk_TercerOrdenie
        '
        Me.chk_TercerOrdenie.AutoSize = True
        Me.chk_TercerOrdenie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_TercerOrdenie.Enabled = False
        Me.chk_TercerOrdenie.Location = New System.Drawing.Point(9, 300)
        Me.chk_TercerOrdenie.Name = "chk_TercerOrdenie"
        Me.chk_TercerOrdenie.Size = New System.Drawing.Size(112, 20)
        Me.chk_TercerOrdenie.TabIndex = 18
        Me.chk_TercerOrdenie.Text = "Tercer Ordeñe:"
        Me.chk_TercerOrdenie.UseVisualStyleBackColor = True
        '
        'chk_PrimerOrdenie
        '
        Me.chk_PrimerOrdenie.AutoSize = True
        Me.chk_PrimerOrdenie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_PrimerOrdenie.Location = New System.Drawing.Point(9, 56)
        Me.chk_PrimerOrdenie.Name = "chk_PrimerOrdenie"
        Me.chk_PrimerOrdenie.Size = New System.Drawing.Size(115, 20)
        Me.chk_PrimerOrdenie.TabIndex = 16
        Me.chk_PrimerOrdenie.Text = "Primer Ordeñe:"
        Me.chk_PrimerOrdenie.UseVisualStyleBackColor = True
        '
        'group_PrimerOrdenie
        '
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_Lts1)
        Me.group_PrimerOrdenie.Controls.Add(Me.txt_Cant1)
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_Cant1)
        Me.group_PrimerOrdenie.Controls.Add(Me.time_Fin1)
        Me.group_PrimerOrdenie.Controls.Add(Me.time_Inicio1)
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_HoraFin1)
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_HoraInicio1)
        Me.group_PrimerOrdenie.Enabled = False
        Me.group_PrimerOrdenie.Location = New System.Drawing.Point(9, 82)
        Me.group_PrimerOrdenie.Name = "group_PrimerOrdenie"
        Me.group_PrimerOrdenie.Size = New System.Drawing.Size(366, 87)
        Me.group_PrimerOrdenie.TabIndex = 15
        Me.group_PrimerOrdenie.TabStop = False
        Me.group_PrimerOrdenie.Text = "1er Ordeñe"
        '
        'lbl_Lts1
        '
        Me.lbl_Lts1.AutoSize = True
        Me.lbl_Lts1.Location = New System.Drawing.Point(212, 58)
        Me.lbl_Lts1.Name = "lbl_Lts1"
        Me.lbl_Lts1.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts1.TabIndex = 14
        Me.lbl_Lts1.Text = "Lts."
        '
        'txt_Cant1
        '
        Me.txt_Cant1.Location = New System.Drawing.Point(137, 55)
        Me.txt_Cant1.Name = "txt_Cant1"
        Me.txt_Cant1.Size = New System.Drawing.Size(69, 22)
        Me.txt_Cant1.TabIndex = 13
        '
        'lbl_Cant1
        '
        Me.lbl_Cant1.AutoSize = True
        Me.lbl_Cant1.Location = New System.Drawing.Point(6, 58)
        Me.lbl_Cant1.Name = "lbl_Cant1"
        Me.lbl_Cant1.Size = New System.Drawing.Size(125, 16)
        Me.lbl_Cant1.TabIndex = 12
        Me.lbl_Cant1.Text = "Cantidad Producida:"
        '
        'time_Fin1
        '
        Me.time_Fin1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_Fin1.Location = New System.Drawing.Point(283, 24)
        Me.time_Fin1.Name = "time_Fin1"
        Me.time_Fin1.Size = New System.Drawing.Size(73, 22)
        Me.time_Fin1.TabIndex = 11
        '
        'time_Inicio1
        '
        Me.time_Inicio1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.time_Inicio1.Location = New System.Drawing.Point(103, 24)
        Me.time_Inicio1.Name = "time_Inicio1"
        Me.time_Inicio1.Size = New System.Drawing.Size(73, 22)
        Me.time_Inicio1.TabIndex = 10
        '
        'lbl_HoraFin1
        '
        Me.lbl_HoraFin1.AutoSize = True
        Me.lbl_HoraFin1.Location = New System.Drawing.Point(203, 28)
        Me.lbl_HoraFin1.Name = "lbl_HoraFin1"
        Me.lbl_HoraFin1.Size = New System.Drawing.Size(74, 16)
        Me.lbl_HoraFin1.TabIndex = 9
        Me.lbl_HoraFin1.Text = "Hora de fin:"
        '
        'lbl_HoraInicio1
        '
        Me.lbl_HoraInicio1.AutoSize = True
        Me.lbl_HoraInicio1.Location = New System.Drawing.Point(6, 28)
        Me.lbl_HoraInicio1.Name = "lbl_HoraInicio1"
        Me.lbl_HoraInicio1.Size = New System.Drawing.Size(91, 16)
        Me.lbl_HoraInicio1.TabIndex = 8
        Me.lbl_HoraInicio1.Text = "Hora de inicio:"
        '
        'frmOrdenies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(384, 471)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.chk_SegundoOrdenie)
        Me.Controls.Add(Me.group_TercerOrdenie)
        Me.Controls.Add(Me.group_SegundoOrdenie)
        Me.Controls.Add(Me.chk_TercerOrdenie)
        Me.Controls.Add(Me.chk_PrimerOrdenie)
        Me.Controls.Add(Me.group_PrimerOrdenie)
        Me.Controls.Add(Me.cboLotes)
        Me.Controls.Add(Me.lbl_Lote)
        Me.Controls.Add(Me.date_FechaOrdenie)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmOrdenies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordeñes"
        Me.group_TercerOrdenie.ResumeLayout(False)
        Me.group_TercerOrdenie.PerformLayout()
        Me.group_SegundoOrdenie.ResumeLayout(False)
        Me.group_SegundoOrdenie.PerformLayout()
        Me.group_PrimerOrdenie.ResumeLayout(False)
        Me.group_PrimerOrdenie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_FechaOrdenie As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Lote As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Guardar As System.Windows.Forms.Button
    Friend WithEvents chk_SegundoOrdenie As System.Windows.Forms.CheckBox
    Friend WithEvents group_TercerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Lts3 As System.Windows.Forms.Label
    Friend WithEvents txt_Cant3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cant3 As System.Windows.Forms.Label
    Friend WithEvents time_Fin3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time_Inicio3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraFin3 As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraInicio3 As System.Windows.Forms.Label
    Friend WithEvents group_SegundoOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Lts2 As System.Windows.Forms.Label
    Friend WithEvents txt_Cant2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cant2 As System.Windows.Forms.Label
    Friend WithEvents time_Fin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time_Inicio2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraFin2 As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraInicio2 As System.Windows.Forms.Label
    Friend WithEvents chk_TercerOrdenie As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PrimerOrdenie As System.Windows.Forms.CheckBox
    Friend WithEvents group_PrimerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Lts1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cant1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cant1 As System.Windows.Forms.Label
    Friend WithEvents time_Fin1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents time_Inicio1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraFin1 As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraInicio1 As System.Windows.Forms.Label
End Class
