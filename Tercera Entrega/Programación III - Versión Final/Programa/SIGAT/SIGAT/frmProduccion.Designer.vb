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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduccion))
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_FechaOrdenie = New System.Windows.Forms.DateTimePicker()
        Me.cmd_Consultar = New System.Windows.Forms.Button()
        Me.group_Produccion = New System.Windows.Forms.GroupBox()
        Me.lbl_Lotenombre = New System.Windows.Forms.Label()
        Me.lbl_TipodeLeche = New System.Windows.Forms.Label()
        Me.lbl_Lts4 = New System.Windows.Forms.Label()
        Me.lbl_Lts3 = New System.Windows.Forms.Label()
        Me.lbl_Lts2 = New System.Windows.Forms.Label()
        Me.lbl_Lts1 = New System.Windows.Forms.Label()
        Me.lbl_CantidadTotal = New System.Windows.Forms.Label()
        Me.lbl_TercerOrdenie = New System.Windows.Forms.Label()
        Me.lbl_SegundoOrdenie = New System.Windows.Forms.Label()
        Me.lbl_PrimerOrdenie = New System.Windows.Forms.Label()
        Me.cmd_VerGrafica = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.lbl_Cant1 = New System.Windows.Forms.Label()
        Me.lbl_Cant2 = New System.Windows.Forms.Label()
        Me.lbl_Cant3 = New System.Windows.Forms.Label()
        Me.lbl_CantTotal = New System.Windows.Forms.Label()
        Me.lbl_Leche = New System.Windows.Forms.Label()
        Me.lbl_Lote = New System.Windows.Forms.Label()
        Me.group_Produccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(8, 10)
        Me.lbl_Establecimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(106, 17)
        Me.lbl_Establecimiento.TabIndex = 0
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(126, 6)
        Me.cbo_Establecimientos.MaxDropDownItems = 10
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(248, 25)
        Me.cbo_Establecimientos.TabIndex = 1
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(8, 41)
        Me.lbl_Fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(113, 17)
        Me.lbl_Fecha.TabIndex = 2
        Me.lbl_Fecha.Text = "Fecha del ordeñe:"
        '
        'date_FechaOrdenie
        '
        Me.date_FechaOrdenie.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaOrdenie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaOrdenie.Location = New System.Drawing.Point(126, 37)
        Me.date_FechaOrdenie.Name = "date_FechaOrdenie"
        Me.date_FechaOrdenie.Size = New System.Drawing.Size(113, 24)
        Me.date_FechaOrdenie.TabIndex = 3
        '
        'cmd_Consultar
        '
        Me.cmd_Consultar.Location = New System.Drawing.Point(252, 35)
        Me.cmd_Consultar.Name = "cmd_Consultar"
        Me.cmd_Consultar.Size = New System.Drawing.Size(121, 27)
        Me.cmd_Consultar.TabIndex = 4
        Me.cmd_Consultar.Text = "Consultar"
        Me.cmd_Consultar.UseVisualStyleBackColor = True
        '
        'group_Produccion
        '
        Me.group_Produccion.Controls.Add(Me.lbl_Lote)
        Me.group_Produccion.Controls.Add(Me.lbl_Leche)
        Me.group_Produccion.Controls.Add(Me.lbl_CantTotal)
        Me.group_Produccion.Controls.Add(Me.lbl_Cant3)
        Me.group_Produccion.Controls.Add(Me.lbl_Cant2)
        Me.group_Produccion.Controls.Add(Me.lbl_Cant1)
        Me.group_Produccion.Controls.Add(Me.lbl_Lotenombre)
        Me.group_Produccion.Controls.Add(Me.lbl_TipodeLeche)
        Me.group_Produccion.Controls.Add(Me.lbl_Lts4)
        Me.group_Produccion.Controls.Add(Me.lbl_Lts3)
        Me.group_Produccion.Controls.Add(Me.lbl_Lts2)
        Me.group_Produccion.Controls.Add(Me.lbl_Lts1)
        Me.group_Produccion.Controls.Add(Me.lbl_CantidadTotal)
        Me.group_Produccion.Controls.Add(Me.lbl_TercerOrdenie)
        Me.group_Produccion.Controls.Add(Me.lbl_SegundoOrdenie)
        Me.group_Produccion.Controls.Add(Me.lbl_PrimerOrdenie)
        Me.group_Produccion.Enabled = False
        Me.group_Produccion.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Produccion.Location = New System.Drawing.Point(12, 77)
        Me.group_Produccion.Name = "group_Produccion"
        Me.group_Produccion.Size = New System.Drawing.Size(361, 203)
        Me.group_Produccion.TabIndex = 5
        Me.group_Produccion.TabStop = False
        Me.group_Produccion.Text = "Datos de producción"
        '
        'lbl_Lotenombre
        '
        Me.lbl_Lotenombre.AutoSize = True
        Me.lbl_Lotenombre.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lotenombre.Location = New System.Drawing.Point(6, 173)
        Me.lbl_Lotenombre.Name = "lbl_Lotenombre"
        Me.lbl_Lotenombre.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Lotenombre.TabIndex = 20
        Me.lbl_Lotenombre.Text = "Lote:"
        '
        'lbl_TipodeLeche
        '
        Me.lbl_TipodeLeche.AutoSize = True
        Me.lbl_TipodeLeche.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipodeLeche.Location = New System.Drawing.Point(6, 143)
        Me.lbl_TipodeLeche.Name = "lbl_TipodeLeche"
        Me.lbl_TipodeLeche.Size = New System.Drawing.Size(89, 17)
        Me.lbl_TipodeLeche.TabIndex = 18
        Me.lbl_TipodeLeche.Text = "Tipo de leche:"
        '
        'lbl_Lts4
        '
        Me.lbl_Lts4.AutoSize = True
        Me.lbl_Lts4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lts4.Location = New System.Drawing.Point(230, 116)
        Me.lbl_Lts4.Name = "lbl_Lts4"
        Me.lbl_Lts4.Size = New System.Drawing.Size(29, 17)
        Me.lbl_Lts4.TabIndex = 17
        Me.lbl_Lts4.Text = "Lts."
        '
        'lbl_Lts3
        '
        Me.lbl_Lts3.AutoSize = True
        Me.lbl_Lts3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lts3.Location = New System.Drawing.Point(230, 89)
        Me.lbl_Lts3.Name = "lbl_Lts3"
        Me.lbl_Lts3.Size = New System.Drawing.Size(29, 17)
        Me.lbl_Lts3.TabIndex = 14
        Me.lbl_Lts3.Text = "Lts."
        '
        'lbl_Lts2
        '
        Me.lbl_Lts2.AutoSize = True
        Me.lbl_Lts2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lts2.Location = New System.Drawing.Point(230, 62)
        Me.lbl_Lts2.Name = "lbl_Lts2"
        Me.lbl_Lts2.Size = New System.Drawing.Size(29, 17)
        Me.lbl_Lts2.TabIndex = 11
        Me.lbl_Lts2.Text = "Lts."
        '
        'lbl_Lts1
        '
        Me.lbl_Lts1.AutoSize = True
        Me.lbl_Lts1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lts1.Location = New System.Drawing.Point(230, 35)
        Me.lbl_Lts1.Name = "lbl_Lts1"
        Me.lbl_Lts1.Size = New System.Drawing.Size(29, 17)
        Me.lbl_Lts1.TabIndex = 8
        Me.lbl_Lts1.Text = "Lts."
        '
        'lbl_CantidadTotal
        '
        Me.lbl_CantidadTotal.AutoSize = True
        Me.lbl_CantidadTotal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantidadTotal.Location = New System.Drawing.Point(5, 116)
        Me.lbl_CantidadTotal.Name = "lbl_CantidadTotal"
        Me.lbl_CantidadTotal.Size = New System.Drawing.Size(97, 17)
        Me.lbl_CantidadTotal.TabIndex = 15
        Me.lbl_CantidadTotal.Text = "Cantidad total:"
        '
        'lbl_TercerOrdenie
        '
        Me.lbl_TercerOrdenie.AutoSize = True
        Me.lbl_TercerOrdenie.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TercerOrdenie.Location = New System.Drawing.Point(6, 89)
        Me.lbl_TercerOrdenie.Name = "lbl_TercerOrdenie"
        Me.lbl_TercerOrdenie.Size = New System.Drawing.Size(94, 17)
        Me.lbl_TercerOrdenie.TabIndex = 12
        Me.lbl_TercerOrdenie.Text = "Tercer ordeñe:"
        '
        'lbl_SegundoOrdenie
        '
        Me.lbl_SegundoOrdenie.AutoSize = True
        Me.lbl_SegundoOrdenie.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SegundoOrdenie.Location = New System.Drawing.Point(5, 62)
        Me.lbl_SegundoOrdenie.Name = "lbl_SegundoOrdenie"
        Me.lbl_SegundoOrdenie.Size = New System.Drawing.Size(111, 17)
        Me.lbl_SegundoOrdenie.TabIndex = 9
        Me.lbl_SegundoOrdenie.Text = "Segundo ordeñe:"
        '
        'lbl_PrimerOrdenie
        '
        Me.lbl_PrimerOrdenie.AutoSize = True
        Me.lbl_PrimerOrdenie.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrimerOrdenie.Location = New System.Drawing.Point(6, 35)
        Me.lbl_PrimerOrdenie.Name = "lbl_PrimerOrdenie"
        Me.lbl_PrimerOrdenie.Size = New System.Drawing.Size(97, 17)
        Me.lbl_PrimerOrdenie.TabIndex = 6
        Me.lbl_PrimerOrdenie.Text = "Primer ordeñe:"
        '
        'cmd_VerGrafica
        '
        Me.cmd_VerGrafica.Enabled = False
        Me.cmd_VerGrafica.Location = New System.Drawing.Point(139, 286)
        Me.cmd_VerGrafica.Name = "cmd_VerGrafica"
        Me.cmd_VerGrafica.Size = New System.Drawing.Size(121, 27)
        Me.cmd_VerGrafica.TabIndex = 22
        Me.cmd_VerGrafica.Text = "Ver gráfica"
        Me.cmd_VerGrafica.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(275, 286)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(98, 27)
        Me.cmd_Volver.TabIndex = 23
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'lbl_Cant1
        '
        Me.lbl_Cant1.Location = New System.Drawing.Point(139, 33)
        Me.lbl_Cant1.Name = "lbl_Cant1"
        Me.lbl_Cant1.Size = New System.Drawing.Size(85, 19)
        Me.lbl_Cant1.TabIndex = 21
        Me.lbl_Cant1.Text = "0"
        Me.lbl_Cant1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Cant2
        '
        Me.lbl_Cant2.Location = New System.Drawing.Point(139, 60)
        Me.lbl_Cant2.Name = "lbl_Cant2"
        Me.lbl_Cant2.Size = New System.Drawing.Size(85, 19)
        Me.lbl_Cant2.TabIndex = 22
        Me.lbl_Cant2.Text = "0"
        Me.lbl_Cant2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Cant3
        '
        Me.lbl_Cant3.Location = New System.Drawing.Point(139, 87)
        Me.lbl_Cant3.Name = "lbl_Cant3"
        Me.lbl_Cant3.Size = New System.Drawing.Size(85, 19)
        Me.lbl_Cant3.TabIndex = 23
        Me.lbl_Cant3.Text = "0"
        Me.lbl_Cant3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_CantTotal
        '
        Me.lbl_CantTotal.Location = New System.Drawing.Point(139, 114)
        Me.lbl_CantTotal.Name = "lbl_CantTotal"
        Me.lbl_CantTotal.Size = New System.Drawing.Size(85, 19)
        Me.lbl_CantTotal.TabIndex = 24
        Me.lbl_CantTotal.Text = "0"
        Me.lbl_CantTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Leche
        '
        Me.lbl_Leche.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Leche.Location = New System.Drawing.Point(139, 141)
        Me.lbl_Leche.Name = "lbl_Leche"
        Me.lbl_Leche.Size = New System.Drawing.Size(85, 19)
        Me.lbl_Leche.TabIndex = 25
        Me.lbl_Leche.Text = "Ninguna"
        Me.lbl_Leche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Lote
        '
        Me.lbl_Lote.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lote.Location = New System.Drawing.Point(139, 171)
        Me.lbl_Lote.Name = "lbl_Lote"
        Me.lbl_Lote.Size = New System.Drawing.Size(85, 19)
        Me.lbl_Lote.TabIndex = 26
        Me.lbl_Lote.Text = "Ninguno"
        Me.lbl_Lote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(385, 321)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_VerGrafica)
        Me.Controls.Add(Me.group_Produccion)
        Me.Controls.Add(Me.cmd_Consultar)
        Me.Controls.Add(Me.date_FechaOrdenie)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.lbl_Establecimiento)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción"
        Me.group_Produccion.ResumeLayout(False)
        Me.group_Produccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_FechaOrdenie As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_Consultar As System.Windows.Forms.Button
    Friend WithEvents group_Produccion As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Lotenombre As System.Windows.Forms.Label
    Friend WithEvents lbl_TipodeLeche As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts1 As System.Windows.Forms.Label
    Friend WithEvents lbl_CantidadTotal As System.Windows.Forms.Label
    Friend WithEvents lbl_TercerOrdenie As System.Windows.Forms.Label
    Friend WithEvents lbl_SegundoOrdenie As System.Windows.Forms.Label
    Friend WithEvents lbl_PrimerOrdenie As System.Windows.Forms.Label
    Friend WithEvents cmd_VerGrafica As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
    Friend WithEvents lbl_Lote As System.Windows.Forms.Label
    Friend WithEvents lbl_Leche As System.Windows.Forms.Label
    Friend WithEvents lbl_CantTotal As System.Windows.Forms.Label
    Friend WithEvents lbl_Cant3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Cant2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Cant1 As System.Windows.Forms.Label
End Class
