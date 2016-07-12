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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenies))
        Me.lblNumeroLote = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.groupProduccion = New System.Windows.Forms.GroupBox()
        Me.txtTercerOrdenie = New System.Windows.Forms.TextBox()
        Me.txtSegundoOrdenie = New System.Windows.Forms.TextBox()
        Me.lblLitros2 = New System.Windows.Forms.Label()
        Me.lblLitros1 = New System.Windows.Forms.Label()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.txtPrimerOrdenie = New System.Windows.Forms.TextBox()
        Me.lblTercerOrdenie = New System.Windows.Forms.Label()
        Me.lblSegundoOrdenie = New System.Windows.Forms.Label()
        Me.lblPrimerOrdenie = New System.Windows.Forms.Label()
        Me.lblProduccionTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblLitros3 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.txtNumeroLote = New System.Windows.Forms.TextBox()
        Me.dateFechaOrdenie = New System.Windows.Forms.DateTimePicker()
        Me.groupProduccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumeroLote
        '
        Me.lblNumeroLote.AutoSize = True
        Me.lblNumeroLote.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroLote.Location = New System.Drawing.Point(12, 9)
        Me.lblNumeroLote.Name = "lblNumeroLote"
        Me.lblNumeroLote.Size = New System.Drawing.Size(110, 15)
        Me.lblNumeroLote.TabIndex = 0
        Me.lblNumeroLote.Text = "Número de lote:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(12, 44)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 15)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha:"
        '
        'groupProduccion
        '
        Me.groupProduccion.Controls.Add(Me.txtTercerOrdenie)
        Me.groupProduccion.Controls.Add(Me.txtSegundoOrdenie)
        Me.groupProduccion.Controls.Add(Me.lblLitros2)
        Me.groupProduccion.Controls.Add(Me.lblLitros1)
        Me.groupProduccion.Controls.Add(Me.lblLitros)
        Me.groupProduccion.Controls.Add(Me.txtPrimerOrdenie)
        Me.groupProduccion.Controls.Add(Me.lblTercerOrdenie)
        Me.groupProduccion.Controls.Add(Me.lblSegundoOrdenie)
        Me.groupProduccion.Controls.Add(Me.lblPrimerOrdenie)
        Me.groupProduccion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupProduccion.Location = New System.Drawing.Point(15, 78)
        Me.groupProduccion.Name = "groupProduccion"
        Me.groupProduccion.Size = New System.Drawing.Size(291, 99)
        Me.groupProduccion.TabIndex = 2
        Me.groupProduccion.TabStop = False
        Me.groupProduccion.Text = "Cantidad producida"
        '
        'txtTercerOrdenie
        '
        Me.txtTercerOrdenie.Location = New System.Drawing.Point(131, 67)
        Me.txtTercerOrdenie.Multiline = True
        Me.txtTercerOrdenie.Name = "txtTercerOrdenie"
        Me.txtTercerOrdenie.Size = New System.Drawing.Size(86, 18)
        Me.txtTercerOrdenie.TabIndex = 8
        '
        'txtSegundoOrdenie
        '
        Me.txtSegundoOrdenie.Location = New System.Drawing.Point(131, 45)
        Me.txtSegundoOrdenie.Multiline = True
        Me.txtSegundoOrdenie.Name = "txtSegundoOrdenie"
        Me.txtSegundoOrdenie.Size = New System.Drawing.Size(86, 18)
        Me.txtSegundoOrdenie.TabIndex = 7
        '
        'lblLitros2
        '
        Me.lblLitros2.AutoSize = True
        Me.lblLitros2.Location = New System.Drawing.Point(223, 70)
        Me.lblLitros2.Name = "lblLitros2"
        Me.lblLitros2.Size = New System.Drawing.Size(41, 15)
        Me.lblLitros2.TabIndex = 6
        Me.lblLitros2.Text = "litros"
        '
        'lblLitros1
        '
        Me.lblLitros1.AutoSize = True
        Me.lblLitros1.Location = New System.Drawing.Point(223, 48)
        Me.lblLitros1.Name = "lblLitros1"
        Me.lblLitros1.Size = New System.Drawing.Size(41, 15)
        Me.lblLitros1.TabIndex = 5
        Me.lblLitros1.Text = "litros"
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Location = New System.Drawing.Point(223, 24)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(41, 15)
        Me.lblLitros.TabIndex = 4
        Me.lblLitros.Text = "litros"
        '
        'txtPrimerOrdenie
        '
        Me.txtPrimerOrdenie.Location = New System.Drawing.Point(131, 21)
        Me.txtPrimerOrdenie.Multiline = True
        Me.txtPrimerOrdenie.Name = "txtPrimerOrdenie"
        Me.txtPrimerOrdenie.Size = New System.Drawing.Size(86, 18)
        Me.txtPrimerOrdenie.TabIndex = 3
        '
        'lblTercerOrdenie
        '
        Me.lblTercerOrdenie.AutoSize = True
        Me.lblTercerOrdenie.Location = New System.Drawing.Point(6, 70)
        Me.lblTercerOrdenie.Name = "lblTercerOrdenie"
        Me.lblTercerOrdenie.Size = New System.Drawing.Size(106, 15)
        Me.lblTercerOrdenie.TabIndex = 2
        Me.lblTercerOrdenie.Text = "Tercer Ordeñe:"
        '
        'lblSegundoOrdenie
        '
        Me.lblSegundoOrdenie.AutoSize = True
        Me.lblSegundoOrdenie.Location = New System.Drawing.Point(6, 48)
        Me.lblSegundoOrdenie.Name = "lblSegundoOrdenie"
        Me.lblSegundoOrdenie.Size = New System.Drawing.Size(119, 15)
        Me.lblSegundoOrdenie.TabIndex = 1
        Me.lblSegundoOrdenie.Text = "Segundo Ordeñe:"
        '
        'lblPrimerOrdenie
        '
        Me.lblPrimerOrdenie.AutoSize = True
        Me.lblPrimerOrdenie.Location = New System.Drawing.Point(6, 25)
        Me.lblPrimerOrdenie.Name = "lblPrimerOrdenie"
        Me.lblPrimerOrdenie.Size = New System.Drawing.Size(107, 15)
        Me.lblPrimerOrdenie.TabIndex = 0
        Me.lblPrimerOrdenie.Text = "Primer Ordeñe:"
        '
        'lblProduccionTotal
        '
        Me.lblProduccionTotal.AutoSize = True
        Me.lblProduccionTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduccionTotal.Location = New System.Drawing.Point(12, 192)
        Me.lblProduccionTotal.Name = "lblProduccionTotal"
        Me.lblProduccionTotal.Size = New System.Drawing.Size(119, 15)
        Me.lblProduccionTotal.TabIndex = 3
        Me.lblProduccionTotal.Text = "Producción total:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(146, 189)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(86, 18)
        Me.txtTotal.TabIndex = 4
        '
        'lblLitros3
        '
        Me.lblLitros3.AutoSize = True
        Me.lblLitros3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros3.Location = New System.Drawing.Point(238, 192)
        Me.lblLitros3.Name = "lblLitros3"
        Me.lblLitros3.Size = New System.Drawing.Size(41, 15)
        Me.lblLitros3.TabIndex = 7
        Me.lblLitros3.Text = "litros"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(15, 219)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(156, 23)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(212, 219)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(156, 23)
        Me.cmdVolver.TabIndex = 9
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'txtNumeroLote
        '
        Me.txtNumeroLote.Location = New System.Drawing.Point(128, 7)
        Me.txtNumeroLote.Name = "txtNumeroLote"
        Me.txtNumeroLote.Size = New System.Drawing.Size(43, 20)
        Me.txtNumeroLote.TabIndex = 10
        '
        'dateFechaOrdenie
        '
        Me.dateFechaOrdenie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaOrdenie.Location = New System.Drawing.Point(69, 44)
        Me.dateFechaOrdenie.MaxDate = New Date(2016, 7, 7, 0, 0, 0, 0)
        Me.dateFechaOrdenie.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateFechaOrdenie.Name = "dateFechaOrdenie"
        Me.dateFechaOrdenie.Size = New System.Drawing.Size(87, 20)
        Me.dateFechaOrdenie.TabIndex = 11
        Me.dateFechaOrdenie.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'frmOrdenies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(380, 254)
        Me.Controls.Add(Me.dateFechaOrdenie)
        Me.Controls.Add(Me.txtNumeroLote)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.lblLitros3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblProduccionTotal)
        Me.Controls.Add(Me.groupProduccion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNumeroLote)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmOrdenies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Ordeñes"
        Me.groupProduccion.ResumeLayout(False)
        Me.groupProduccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumeroLote As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents groupProduccion As System.Windows.Forms.GroupBox
    Friend WithEvents lblTercerOrdenie As System.Windows.Forms.Label
    Friend WithEvents lblSegundoOrdenie As System.Windows.Forms.Label
    Friend WithEvents lblPrimerOrdenie As System.Windows.Forms.Label
    Friend WithEvents txtTercerOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents lblLitros2 As System.Windows.Forms.Label
    Friend WithEvents lblLitros1 As System.Windows.Forms.Label
    Friend WithEvents lblLitros As System.Windows.Forms.Label
    Friend WithEvents txtPrimerOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents lblProduccionTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblLitros3 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents txtNumeroLote As System.Windows.Forms.TextBox
    Friend WithEvents dateFechaOrdenie As System.Windows.Forms.DateTimePicker
End Class
