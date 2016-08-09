<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduccion
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
        Me.cmdVerProduccion = New System.Windows.Forms.Button()
        Me.groupDatos = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPrimerOrdenie = New System.Windows.Forms.TextBox()
        Me.lblLts4 = New System.Windows.Forms.Label()
        Me.lblLts3 = New System.Windows.Forms.Label()
        Me.lblLts2 = New System.Windows.Forms.Label()
        Me.lblLts1 = New System.Windows.Forms.Label()
        Me.lblCantidadTotal = New System.Windows.Forms.Label()
        Me.lblTercerOrdenie = New System.Windows.Forms.Label()
        Me.lblSegundoOrdenie = New System.Windows.Forms.Label()
        Me.lblPrimerOrdenie = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimientos = New System.Windows.Forms.ComboBox()
        Me.groupDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdVerProduccion
        '
        Me.cmdVerProduccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerProduccion.Location = New System.Drawing.Point(221, 35)
        Me.cmdVerProduccion.Name = "cmdVerProduccion"
        Me.cmdVerProduccion.Size = New System.Drawing.Size(123, 33)
        Me.cmdVerProduccion.TabIndex = 4
        Me.cmdVerProduccion.Text = "Ver producción"
        Me.cmdVerProduccion.UseVisualStyleBackColor = True
        '
        'groupDatos
        '
        Me.groupDatos.Controls.Add(Me.TextBox3)
        Me.groupDatos.Controls.Add(Me.TextBox2)
        Me.groupDatos.Controls.Add(Me.TextBox1)
        Me.groupDatos.Controls.Add(Me.txtPrimerOrdenie)
        Me.groupDatos.Controls.Add(Me.lblLts4)
        Me.groupDatos.Controls.Add(Me.lblLts3)
        Me.groupDatos.Controls.Add(Me.lblLts2)
        Me.groupDatos.Controls.Add(Me.lblLts1)
        Me.groupDatos.Controls.Add(Me.lblCantidadTotal)
        Me.groupDatos.Controls.Add(Me.lblTercerOrdenie)
        Me.groupDatos.Controls.Add(Me.lblSegundoOrdenie)
        Me.groupDatos.Controls.Add(Me.lblPrimerOrdenie)
        Me.groupDatos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDatos.Location = New System.Drawing.Point(15, 74)
        Me.groupDatos.Name = "groupDatos"
        Me.groupDatos.Size = New System.Drawing.Size(267, 149)
        Me.groupDatos.TabIndex = 5
        Me.groupDatos.TabStop = False
        Me.groupDatos.Text = "Datos de producción"
        Me.groupDatos.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(140, 113)
        Me.TextBox3.MaxLength = 5
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(85, 21)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(140, 86)
        Me.TextBox2.MaxLength = 5
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(85, 21)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(140, 59)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 21)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrimerOrdenie
        '
        Me.txtPrimerOrdenie.Enabled = False
        Me.txtPrimerOrdenie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerOrdenie.Location = New System.Drawing.Point(140, 32)
        Me.txtPrimerOrdenie.MaxLength = 5
        Me.txtPrimerOrdenie.Multiline = True
        Me.txtPrimerOrdenie.Name = "txtPrimerOrdenie"
        Me.txtPrimerOrdenie.Size = New System.Drawing.Size(85, 21)
        Me.txtPrimerOrdenie.TabIndex = 8
        Me.txtPrimerOrdenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLts4
        '
        Me.lblLts4.AutoSize = True
        Me.lblLts4.Location = New System.Drawing.Point(231, 116)
        Me.lblLts4.Name = "lblLts4"
        Me.lblLts4.Size = New System.Drawing.Size(30, 16)
        Me.lblLts4.TabIndex = 7
        Me.lblLts4.Text = "Lts."
        '
        'lblLts3
        '
        Me.lblLts3.AutoSize = True
        Me.lblLts3.Location = New System.Drawing.Point(231, 89)
        Me.lblLts3.Name = "lblLts3"
        Me.lblLts3.Size = New System.Drawing.Size(30, 16)
        Me.lblLts3.TabIndex = 6
        Me.lblLts3.Text = "Lts."
        '
        'lblLts2
        '
        Me.lblLts2.AutoSize = True
        Me.lblLts2.Location = New System.Drawing.Point(231, 62)
        Me.lblLts2.Name = "lblLts2"
        Me.lblLts2.Size = New System.Drawing.Size(30, 16)
        Me.lblLts2.TabIndex = 5
        Me.lblLts2.Text = "Lts."
        '
        'lblLts1
        '
        Me.lblLts1.AutoSize = True
        Me.lblLts1.Location = New System.Drawing.Point(231, 35)
        Me.lblLts1.Name = "lblLts1"
        Me.lblLts1.Size = New System.Drawing.Size(30, 16)
        Me.lblLts1.TabIndex = 4
        Me.lblLts1.Text = "Lts."
        '
        'lblCantidadTotal
        '
        Me.lblCantidadTotal.AutoSize = True
        Me.lblCantidadTotal.Location = New System.Drawing.Point(9, 116)
        Me.lblCantidadTotal.Name = "lblCantidadTotal"
        Me.lblCantidadTotal.Size = New System.Drawing.Size(92, 16)
        Me.lblCantidadTotal.TabIndex = 3
        Me.lblCantidadTotal.Text = "Cantidad total:"
        '
        'lblTercerOrdenie
        '
        Me.lblTercerOrdenie.AutoSize = True
        Me.lblTercerOrdenie.Location = New System.Drawing.Point(7, 89)
        Me.lblTercerOrdenie.Name = "lblTercerOrdenie"
        Me.lblTercerOrdenie.Size = New System.Drawing.Size(90, 16)
        Me.lblTercerOrdenie.TabIndex = 2
        Me.lblTercerOrdenie.Text = "Tercer ordeñe:"
        '
        'lblSegundoOrdenie
        '
        Me.lblSegundoOrdenie.AutoSize = True
        Me.lblSegundoOrdenie.Location = New System.Drawing.Point(6, 62)
        Me.lblSegundoOrdenie.Name = "lblSegundoOrdenie"
        Me.lblSegundoOrdenie.Size = New System.Drawing.Size(106, 16)
        Me.lblSegundoOrdenie.TabIndex = 1
        Me.lblSegundoOrdenie.Text = "Segundo ordeñe:"
        '
        'lblPrimerOrdenie
        '
        Me.lblPrimerOrdenie.AutoSize = True
        Me.lblPrimerOrdenie.Location = New System.Drawing.Point(6, 35)
        Me.lblPrimerOrdenie.Name = "lblPrimerOrdenie"
        Me.lblPrimerOrdenie.Size = New System.Drawing.Size(93, 16)
        Me.lblPrimerOrdenie.TabIndex = 0
        Me.lblPrimerOrdenie.Text = "Primer ordeñe:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(12, 41)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(71, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 22)
        Me.DateTimePicker1.TabIndex = 6
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(277, 229)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(67, 24)
        Me.cmdVolver.TabIndex = 7
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(12, 9)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(105, 16)
        Me.lblEstablecimiento.TabIndex = 8
        Me.lblEstablecimiento.Text = "Establecimiento:"
        '
        'cboEstablecimientos
        '
        Me.cboEstablecimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstablecimientos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimientos.FormattingEnabled = True
        Me.cboEstablecimientos.Items.AddRange(New Object() {"Establecimiento Las Perdices"})
        Me.cboEstablecimientos.Location = New System.Drawing.Point(119, 7)
        Me.cboEstablecimientos.Name = "cboEstablecimientos"
        Me.cboEstablecimientos.Size = New System.Drawing.Size(225, 23)
        Me.cboEstablecimientos.TabIndex = 9
        '
        'frmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(356, 259)
        Me.Controls.Add(Me.cboEstablecimientos)
        Me.Controls.Add(Me.lblEstablecimiento)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.groupDatos)
        Me.Controls.Add(Me.cmdVerProduccion)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción"
        Me.groupDatos.ResumeLayout(False)
        Me.groupDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdVerProduccion As System.Windows.Forms.Button
    Friend WithEvents groupDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents lblLts4 As System.Windows.Forms.Label
    Friend WithEvents lblLts3 As System.Windows.Forms.Label
    Friend WithEvents lblLts2 As System.Windows.Forms.Label
    Friend WithEvents lblLts1 As System.Windows.Forms.Label
    Friend WithEvents lblCantidadTotal As System.Windows.Forms.Label
    Friend WithEvents lblTercerOrdenie As System.Windows.Forms.Label
    Friend WithEvents lblSegundoOrdenie As System.Windows.Forms.Label
    Friend WithEvents lblPrimerOrdenie As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimientos As System.Windows.Forms.ComboBox
End Class
