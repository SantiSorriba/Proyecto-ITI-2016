<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.listServicios = New System.Windows.Forms.ListBox()
        Me.cmdBorrarServicio = New System.Windows.Forms.Button()
        Me.cmdNuevoServicio = New System.Windows.Forms.Button()
        Me.cmdDatosServicio = New System.Windows.Forms.Button()
        Me.cmdHistorialServicio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listServicios
        '
        Me.listServicios.BackColor = System.Drawing.Color.Beige
        Me.listServicios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listServicios.FormattingEnabled = True
        Me.listServicios.ItemHeight = 17
        Me.listServicios.Items.AddRange(New Object() {"Servicio 1", "Servicio 2", "Servicio 3"})
        Me.listServicios.Location = New System.Drawing.Point(12, 12)
        Me.listServicios.Name = "listServicios"
        Me.listServicios.Size = New System.Drawing.Size(310, 174)
        Me.listServicios.TabIndex = 2
        '
        'cmdBorrarServicio
        '
        Me.cmdBorrarServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrarServicio.Location = New System.Drawing.Point(173, 194)
        Me.cmdBorrarServicio.Name = "cmdBorrarServicio"
        Me.cmdBorrarServicio.Size = New System.Drawing.Size(149, 26)
        Me.cmdBorrarServicio.TabIndex = 12
        Me.cmdBorrarServicio.Text = "Borrar servicio"
        Me.cmdBorrarServicio.UseVisualStyleBackColor = True
        '
        'cmdNuevoServicio
        '
        Me.cmdNuevoServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevoServicio.Location = New System.Drawing.Point(12, 194)
        Me.cmdNuevoServicio.Name = "cmdNuevoServicio"
        Me.cmdNuevoServicio.Size = New System.Drawing.Size(149, 26)
        Me.cmdNuevoServicio.TabIndex = 11
        Me.cmdNuevoServicio.Text = "Nuevo servicio"
        Me.cmdNuevoServicio.UseVisualStyleBackColor = True
        '
        'cmdDatosServicio
        '
        Me.cmdDatosServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatosServicio.Location = New System.Drawing.Point(12, 226)
        Me.cmdDatosServicio.Name = "cmdDatosServicio"
        Me.cmdDatosServicio.Size = New System.Drawing.Size(149, 26)
        Me.cmdDatosServicio.TabIndex = 9
        Me.cmdDatosServicio.Text = "Ver datos"
        Me.cmdDatosServicio.UseVisualStyleBackColor = True
        '
        'cmdHistorialServicio
        '
        Me.cmdHistorialServicio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistorialServicio.Location = New System.Drawing.Point(173, 226)
        Me.cmdHistorialServicio.Name = "cmdHistorialServicio"
        Me.cmdHistorialServicio.Size = New System.Drawing.Size(149, 26)
        Me.cmdHistorialServicio.TabIndex = 10
        Me.cmdHistorialServicio.Text = "Ver historial "
        Me.cmdHistorialServicio.UseVisualStyleBackColor = True
        '
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(334, 262)
        Me.Controls.Add(Me.cmdBorrarServicio)
        Me.Controls.Add(Me.cmdNuevoServicio)
        Me.Controls.Add(Me.cmdHistorialServicio)
        Me.Controls.Add(Me.cmdDatosServicio)
        Me.Controls.Add(Me.listServicios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Servicios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listServicios As System.Windows.Forms.ListBox
    Friend WithEvents cmdBorrarServicio As System.Windows.Forms.Button
    Friend WithEvents cmdNuevoServicio As System.Windows.Forms.Button
    Friend WithEvents cmdDatosServicio As System.Windows.Forms.Button
    Friend WithEvents cmdHistorialServicio As System.Windows.Forms.Button
End Class
