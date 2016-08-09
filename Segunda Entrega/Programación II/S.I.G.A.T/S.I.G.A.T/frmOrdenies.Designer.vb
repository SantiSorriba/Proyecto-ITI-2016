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
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.groupPrimerOrdenie = New System.Windows.Forms.GroupBox()
        Me.lblLts1 = New System.Windows.Forms.Label()
        Me.txtCant1 = New System.Windows.Forms.TextBox()
        Me.lblCant1 = New System.Windows.Forms.Label()
        Me.timeFin1 = New System.Windows.Forms.DateTimePicker()
        Me.timeInicio1 = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFin1 = New System.Windows.Forms.Label()
        Me.lblHoraInicio1 = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.chkPrimerOrdenie = New System.Windows.Forms.CheckBox()
        Me.chkSegundoOrdenie = New System.Windows.Forms.CheckBox()
        Me.chkTercerOrdenie = New System.Windows.Forms.CheckBox()
        Me.groupSegundoOrdenie = New System.Windows.Forms.GroupBox()
        Me.lblLts2 = New System.Windows.Forms.Label()
        Me.txtCant2 = New System.Windows.Forms.TextBox()
        Me.lblCant2 = New System.Windows.Forms.Label()
        Me.timeFin2 = New System.Windows.Forms.DateTimePicker()
        Me.timeInicio2 = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFin2 = New System.Windows.Forms.Label()
        Me.lblHoraInicio2 = New System.Windows.Forms.Label()
        Me.groupTercerOrdenie = New System.Windows.Forms.GroupBox()
        Me.lblLts3 = New System.Windows.Forms.Label()
        Me.txtCant3 = New System.Windows.Forms.TextBox()
        Me.lblCant3 = New System.Windows.Forms.Label()
        Me.timeFin3 = New System.Windows.Forms.DateTimePicker()
        Me.timeInicio3 = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFin3 = New System.Windows.Forms.Label()
        Me.lblHoraInicio3 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cboLotes = New System.Windows.Forms.ComboBox()
        Me.groupPrimerOrdenie.SuspendLayout()
        Me.groupSegundoOrdenie.SuspendLayout()
        Me.groupTercerOrdenie.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(12, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(56, 18)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'dateFecha
        '
        Me.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFecha.Location = New System.Drawing.Point(74, 9)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(95, 22)
        Me.dateFecha.TabIndex = 1
        '
        'groupPrimerOrdenie
        '
        Me.groupPrimerOrdenie.Controls.Add(Me.lblLts1)
        Me.groupPrimerOrdenie.Controls.Add(Me.txtCant1)
        Me.groupPrimerOrdenie.Controls.Add(Me.lblCant1)
        Me.groupPrimerOrdenie.Controls.Add(Me.timeFin1)
        Me.groupPrimerOrdenie.Controls.Add(Me.timeInicio1)
        Me.groupPrimerOrdenie.Controls.Add(Me.lblHoraFin1)
        Me.groupPrimerOrdenie.Controls.Add(Me.lblHoraInicio1)
        Me.groupPrimerOrdenie.Enabled = False
        Me.groupPrimerOrdenie.Location = New System.Drawing.Point(12, 75)
        Me.groupPrimerOrdenie.Name = "groupPrimerOrdenie"
        Me.groupPrimerOrdenie.Size = New System.Drawing.Size(366, 87)
        Me.groupPrimerOrdenie.TabIndex = 2
        Me.groupPrimerOrdenie.TabStop = False
        Me.groupPrimerOrdenie.Text = "1er Ordeñe"
        '
        'lblLts1
        '
        Me.lblLts1.AutoSize = True
        Me.lblLts1.Location = New System.Drawing.Point(212, 58)
        Me.lblLts1.Name = "lblLts1"
        Me.lblLts1.Size = New System.Drawing.Size(30, 16)
        Me.lblLts1.TabIndex = 14
        Me.lblLts1.Text = "Lts."
        '
        'txtCant1
        '
        Me.txtCant1.Location = New System.Drawing.Point(137, 55)
        Me.txtCant1.Name = "txtCant1"
        Me.txtCant1.Size = New System.Drawing.Size(69, 22)
        Me.txtCant1.TabIndex = 13
        '
        'lblCant1
        '
        Me.lblCant1.AutoSize = True
        Me.lblCant1.Location = New System.Drawing.Point(6, 58)
        Me.lblCant1.Name = "lblCant1"
        Me.lblCant1.Size = New System.Drawing.Size(125, 16)
        Me.lblCant1.TabIndex = 12
        Me.lblCant1.Text = "Cantidad Producida:"
        '
        'timeFin1
        '
        Me.timeFin1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeFin1.Location = New System.Drawing.Point(283, 23)
        Me.timeFin1.Name = "timeFin1"
        Me.timeFin1.Size = New System.Drawing.Size(73, 22)
        Me.timeFin1.TabIndex = 11
        '
        'timeInicio1
        '
        Me.timeInicio1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeInicio1.Location = New System.Drawing.Point(103, 23)
        Me.timeInicio1.Name = "timeInicio1"
        Me.timeInicio1.Size = New System.Drawing.Size(73, 22)
        Me.timeInicio1.TabIndex = 10
        '
        'lblHoraFin1
        '
        Me.lblHoraFin1.AutoSize = True
        Me.lblHoraFin1.Location = New System.Drawing.Point(203, 28)
        Me.lblHoraFin1.Name = "lblHoraFin1"
        Me.lblHoraFin1.Size = New System.Drawing.Size(74, 16)
        Me.lblHoraFin1.TabIndex = 9
        Me.lblHoraFin1.Text = "Hora de fin:"
        '
        'lblHoraInicio1
        '
        Me.lblHoraInicio1.AutoSize = True
        Me.lblHoraInicio1.Location = New System.Drawing.Point(6, 28)
        Me.lblHoraInicio1.Name = "lblHoraInicio1"
        Me.lblHoraInicio1.Size = New System.Drawing.Size(91, 16)
        Me.lblHoraInicio1.TabIndex = 8
        Me.lblHoraInicio1.Text = "Hora de inicio:"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Location = New System.Drawing.Point(175, 9)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(43, 18)
        Me.lblLote.TabIndex = 12
        Me.lblLote.Text = "Lote:"
        '
        'chkPrimerOrdenie
        '
        Me.chkPrimerOrdenie.AutoSize = True
        Me.chkPrimerOrdenie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPrimerOrdenie.Location = New System.Drawing.Point(12, 49)
        Me.chkPrimerOrdenie.Name = "chkPrimerOrdenie"
        Me.chkPrimerOrdenie.Size = New System.Drawing.Size(115, 20)
        Me.chkPrimerOrdenie.TabIndex = 4
        Me.chkPrimerOrdenie.Text = "Primer Ordeñe:"
        Me.chkPrimerOrdenie.UseVisualStyleBackColor = True
        '
        'chkSegundoOrdenie
        '
        Me.chkSegundoOrdenie.AutoSize = True
        Me.chkSegundoOrdenie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSegundoOrdenie.Enabled = False
        Me.chkSegundoOrdenie.Location = New System.Drawing.Point(12, 174)
        Me.chkSegundoOrdenie.Name = "chkSegundoOrdenie"
        Me.chkSegundoOrdenie.Size = New System.Drawing.Size(128, 20)
        Me.chkSegundoOrdenie.TabIndex = 5
        Me.chkSegundoOrdenie.Text = "Segundo Ordeñe:"
        Me.chkSegundoOrdenie.UseVisualStyleBackColor = True
        '
        'chkTercerOrdenie
        '
        Me.chkTercerOrdenie.AutoSize = True
        Me.chkTercerOrdenie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTercerOrdenie.Enabled = False
        Me.chkTercerOrdenie.Location = New System.Drawing.Point(12, 293)
        Me.chkTercerOrdenie.Name = "chkTercerOrdenie"
        Me.chkTercerOrdenie.Size = New System.Drawing.Size(112, 20)
        Me.chkTercerOrdenie.TabIndex = 6
        Me.chkTercerOrdenie.Text = "Tercer Ordeñe:"
        Me.chkTercerOrdenie.UseVisualStyleBackColor = True
        '
        'groupSegundoOrdenie
        '
        Me.groupSegundoOrdenie.Controls.Add(Me.lblLts2)
        Me.groupSegundoOrdenie.Controls.Add(Me.txtCant2)
        Me.groupSegundoOrdenie.Controls.Add(Me.lblCant2)
        Me.groupSegundoOrdenie.Controls.Add(Me.timeFin2)
        Me.groupSegundoOrdenie.Controls.Add(Me.timeInicio2)
        Me.groupSegundoOrdenie.Controls.Add(Me.lblHoraFin2)
        Me.groupSegundoOrdenie.Controls.Add(Me.lblHoraInicio2)
        Me.groupSegundoOrdenie.Enabled = False
        Me.groupSegundoOrdenie.Location = New System.Drawing.Point(12, 200)
        Me.groupSegundoOrdenie.Name = "groupSegundoOrdenie"
        Me.groupSegundoOrdenie.Size = New System.Drawing.Size(366, 87)
        Me.groupSegundoOrdenie.TabIndex = 7
        Me.groupSegundoOrdenie.TabStop = False
        Me.groupSegundoOrdenie.Text = "2do Ordeñe"
        '
        'lblLts2
        '
        Me.lblLts2.AutoSize = True
        Me.lblLts2.Location = New System.Drawing.Point(212, 59)
        Me.lblLts2.Name = "lblLts2"
        Me.lblLts2.Size = New System.Drawing.Size(30, 16)
        Me.lblLts2.TabIndex = 17
        Me.lblLts2.Text = "Lts."
        '
        'txtCant2
        '
        Me.txtCant2.Location = New System.Drawing.Point(137, 56)
        Me.txtCant2.Name = "txtCant2"
        Me.txtCant2.Size = New System.Drawing.Size(69, 22)
        Me.txtCant2.TabIndex = 16
        '
        'lblCant2
        '
        Me.lblCant2.AutoSize = True
        Me.lblCant2.Location = New System.Drawing.Point(6, 59)
        Me.lblCant2.Name = "lblCant2"
        Me.lblCant2.Size = New System.Drawing.Size(125, 16)
        Me.lblCant2.TabIndex = 15
        Me.lblCant2.Text = "Cantidad Producida:"
        '
        'timeFin2
        '
        Me.timeFin2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeFin2.Location = New System.Drawing.Point(283, 23)
        Me.timeFin2.Name = "timeFin2"
        Me.timeFin2.Size = New System.Drawing.Size(73, 22)
        Me.timeFin2.TabIndex = 11
        '
        'timeInicio2
        '
        Me.timeInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeInicio2.Location = New System.Drawing.Point(103, 23)
        Me.timeInicio2.Name = "timeInicio2"
        Me.timeInicio2.Size = New System.Drawing.Size(73, 22)
        Me.timeInicio2.TabIndex = 10
        '
        'lblHoraFin2
        '
        Me.lblHoraFin2.AutoSize = True
        Me.lblHoraFin2.Location = New System.Drawing.Point(203, 28)
        Me.lblHoraFin2.Name = "lblHoraFin2"
        Me.lblHoraFin2.Size = New System.Drawing.Size(74, 16)
        Me.lblHoraFin2.TabIndex = 9
        Me.lblHoraFin2.Text = "Hora de fin:"
        '
        'lblHoraInicio2
        '
        Me.lblHoraInicio2.AutoSize = True
        Me.lblHoraInicio2.Location = New System.Drawing.Point(6, 28)
        Me.lblHoraInicio2.Name = "lblHoraInicio2"
        Me.lblHoraInicio2.Size = New System.Drawing.Size(91, 16)
        Me.lblHoraInicio2.TabIndex = 8
        Me.lblHoraInicio2.Text = "Hora de inicio:"
        '
        'groupTercerOrdenie
        '
        Me.groupTercerOrdenie.Controls.Add(Me.lblLts3)
        Me.groupTercerOrdenie.Controls.Add(Me.txtCant3)
        Me.groupTercerOrdenie.Controls.Add(Me.lblCant3)
        Me.groupTercerOrdenie.Controls.Add(Me.timeFin3)
        Me.groupTercerOrdenie.Controls.Add(Me.timeInicio3)
        Me.groupTercerOrdenie.Controls.Add(Me.lblHoraFin3)
        Me.groupTercerOrdenie.Controls.Add(Me.lblHoraInicio3)
        Me.groupTercerOrdenie.Enabled = False
        Me.groupTercerOrdenie.Location = New System.Drawing.Point(12, 319)
        Me.groupTercerOrdenie.Name = "groupTercerOrdenie"
        Me.groupTercerOrdenie.Size = New System.Drawing.Size(366, 87)
        Me.groupTercerOrdenie.TabIndex = 8
        Me.groupTercerOrdenie.TabStop = False
        Me.groupTercerOrdenie.Text = "3er Ordeñe"
        '
        'lblLts3
        '
        Me.lblLts3.AutoSize = True
        Me.lblLts3.Location = New System.Drawing.Point(212, 58)
        Me.lblLts3.Name = "lblLts3"
        Me.lblLts3.Size = New System.Drawing.Size(30, 16)
        Me.lblLts3.TabIndex = 20
        Me.lblLts3.Text = "Lts."
        '
        'txtCant3
        '
        Me.txtCant3.Location = New System.Drawing.Point(137, 55)
        Me.txtCant3.Name = "txtCant3"
        Me.txtCant3.Size = New System.Drawing.Size(69, 22)
        Me.txtCant3.TabIndex = 19
        '
        'lblCant3
        '
        Me.lblCant3.AutoSize = True
        Me.lblCant3.Location = New System.Drawing.Point(6, 58)
        Me.lblCant3.Name = "lblCant3"
        Me.lblCant3.Size = New System.Drawing.Size(125, 16)
        Me.lblCant3.TabIndex = 18
        Me.lblCant3.Text = "Cantidad Producida:"
        '
        'timeFin3
        '
        Me.timeFin3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeFin3.Location = New System.Drawing.Point(283, 23)
        Me.timeFin3.Name = "timeFin3"
        Me.timeFin3.Size = New System.Drawing.Size(73, 22)
        Me.timeFin3.TabIndex = 11
        '
        'timeInicio3
        '
        Me.timeInicio3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeInicio3.Location = New System.Drawing.Point(103, 23)
        Me.timeInicio3.Name = "timeInicio3"
        Me.timeInicio3.Size = New System.Drawing.Size(73, 22)
        Me.timeInicio3.TabIndex = 10
        '
        'lblHoraFin3
        '
        Me.lblHoraFin3.AutoSize = True
        Me.lblHoraFin3.Location = New System.Drawing.Point(203, 28)
        Me.lblHoraFin3.Name = "lblHoraFin3"
        Me.lblHoraFin3.Size = New System.Drawing.Size(74, 16)
        Me.lblHoraFin3.TabIndex = 9
        Me.lblHoraFin3.Text = "Hora de fin:"
        '
        'lblHoraInicio3
        '
        Me.lblHoraInicio3.AutoSize = True
        Me.lblHoraInicio3.Location = New System.Drawing.Point(6, 28)
        Me.lblHoraInicio3.Name = "lblHoraInicio3"
        Me.lblHoraInicio3.Size = New System.Drawing.Size(91, 16)
        Me.lblHoraInicio3.TabIndex = 8
        Me.lblHoraInicio3.Text = "Hora de inicio:"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Location = New System.Drawing.Point(12, 424)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(128, 26)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(250, 424)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(128, 26)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cboLotes
        '
        Me.cboLotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLotes.FormattingEnabled = True
        Me.cboLotes.Location = New System.Drawing.Point(224, 7)
        Me.cboLotes.Name = "cboLotes"
        Me.cboLotes.Size = New System.Drawing.Size(154, 24)
        Me.cboLotes.TabIndex = 13
        '
        'frmOrdenies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(390, 462)
        Me.Controls.Add(Me.cboLotes)
        Me.Controls.Add(Me.lblLote)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.chkSegundoOrdenie)
        Me.Controls.Add(Me.groupTercerOrdenie)
        Me.Controls.Add(Me.groupSegundoOrdenie)
        Me.Controls.Add(Me.chkTercerOrdenie)
        Me.Controls.Add(Me.chkPrimerOrdenie)
        Me.Controls.Add(Me.groupPrimerOrdenie)
        Me.Controls.Add(Me.dateFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmOrdenies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordeñes"
        Me.groupPrimerOrdenie.ResumeLayout(False)
        Me.groupPrimerOrdenie.PerformLayout()
        Me.groupSegundoOrdenie.ResumeLayout(False)
        Me.groupSegundoOrdenie.PerformLayout()
        Me.groupTercerOrdenie.ResumeLayout(False)
        Me.groupTercerOrdenie.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dateFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupPrimerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents timeFin1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeInicio1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoraFin1 As System.Windows.Forms.Label
    Friend WithEvents lblHoraInicio1 As System.Windows.Forms.Label
    Friend WithEvents chkPrimerOrdenie As System.Windows.Forms.CheckBox
    Friend WithEvents chkSegundoOrdenie As System.Windows.Forms.CheckBox
    Friend WithEvents chkTercerOrdenie As System.Windows.Forms.CheckBox
    Friend WithEvents groupSegundoOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents timeFin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeInicio2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoraFin2 As System.Windows.Forms.Label
    Friend WithEvents lblHoraInicio2 As System.Windows.Forms.Label
    Friend WithEvents groupTercerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents timeFin3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeInicio3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHoraFin3 As System.Windows.Forms.Label
    Friend WithEvents lblHoraInicio3 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents cboLotes As System.Windows.Forms.ComboBox
    Friend WithEvents lblLts1 As System.Windows.Forms.Label
    Friend WithEvents txtCant1 As System.Windows.Forms.TextBox
    Friend WithEvents lblCant1 As System.Windows.Forms.Label
    Friend WithEvents lblLts2 As System.Windows.Forms.Label
    Friend WithEvents txtCant2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCant2 As System.Windows.Forms.Label
    Friend WithEvents lblLts3 As System.Windows.Forms.Label
    Friend WithEvents txtCant3 As System.Windows.Forms.TextBox
    Friend WithEvents lblCant3 As System.Windows.Forms.Label
End Class
