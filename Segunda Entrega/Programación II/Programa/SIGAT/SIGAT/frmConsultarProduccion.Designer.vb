<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarProduccion
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
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.cmd_ConsultarProduccion = New System.Windows.Forms.Button()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.date_FechaOrdenies = New System.Windows.Forms.DateTimePicker()
        Me.group_Datos = New System.Windows.Forms.GroupBox()
        Me.txt_CantidadTotal = New System.Windows.Forms.TextBox()
        Me.txt_TercerOrdenie = New System.Windows.Forms.TextBox()
        Me.txt_SegundoOrdenie = New System.Windows.Forms.TextBox()
        Me.txt_PrimerOrdenie = New System.Windows.Forms.TextBox()
        Me.lbl_Lts4 = New System.Windows.Forms.Label()
        Me.lbl_Lts3 = New System.Windows.Forms.Label()
        Me.lbl_Lts2 = New System.Windows.Forms.Label()
        Me.lbl_Lts1 = New System.Windows.Forms.Label()
        Me.lbl_CantidadTotal = New System.Windows.Forms.Label()
        Me.lbl_TercerOrdenie = New System.Windows.Forms.Label()
        Me.lbl_SegundoOrdenie = New System.Windows.Forms.Label()
        Me.lbl_PrimerOrdenie = New System.Windows.Forms.Label()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.cmd_VerGrafica = New System.Windows.Forms.Button()
        Me.lbl_TipoLeche = New System.Windows.Forms.Label()
        Me.cbo_TipoLeche = New System.Windows.Forms.ComboBox()
        Me.lbl_Lote = New System.Windows.Forms.Label()
        Me.cbo_Lote = New System.Windows.Forms.ComboBox()
        Me.group_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(105, 16)
        Me.lbl_Establecimiento.TabIndex = 0
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(12, 38)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(48, 16)
        Me.lbl_Fecha.TabIndex = 1
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'cmd_ConsultarProduccion
        '
        Me.cmd_ConsultarProduccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ConsultarProduccion.Location = New System.Drawing.Point(178, 35)
        Me.cmd_ConsultarProduccion.Name = "cmd_ConsultarProduccion"
        Me.cmd_ConsultarProduccion.Size = New System.Drawing.Size(172, 23)
        Me.cmd_ConsultarProduccion.TabIndex = 2
        Me.cmd_ConsultarProduccion.Text = "Consultar producción"
        Me.cmd_ConsultarProduccion.UseVisualStyleBackColor = True
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(123, 6)
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(230, 24)
        Me.cbo_Establecimientos.TabIndex = 3
        '
        'date_FechaOrdenies
        '
        Me.date_FechaOrdenies.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_FechaOrdenies.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaOrdenies.Location = New System.Drawing.Point(66, 36)
        Me.date_FechaOrdenies.Name = "date_FechaOrdenies"
        Me.date_FechaOrdenies.Size = New System.Drawing.Size(106, 22)
        Me.date_FechaOrdenies.TabIndex = 7
        '
        'group_Datos
        '
        Me.group_Datos.Controls.Add(Me.cbo_Lote)
        Me.group_Datos.Controls.Add(Me.lbl_Lote)
        Me.group_Datos.Controls.Add(Me.cbo_TipoLeche)
        Me.group_Datos.Controls.Add(Me.lbl_TipoLeche)
        Me.group_Datos.Controls.Add(Me.txt_CantidadTotal)
        Me.group_Datos.Controls.Add(Me.txt_TercerOrdenie)
        Me.group_Datos.Controls.Add(Me.txt_SegundoOrdenie)
        Me.group_Datos.Controls.Add(Me.txt_PrimerOrdenie)
        Me.group_Datos.Controls.Add(Me.lbl_Lts4)
        Me.group_Datos.Controls.Add(Me.lbl_Lts3)
        Me.group_Datos.Controls.Add(Me.lbl_Lts2)
        Me.group_Datos.Controls.Add(Me.lbl_Lts1)
        Me.group_Datos.Controls.Add(Me.lbl_CantidadTotal)
        Me.group_Datos.Controls.Add(Me.lbl_TercerOrdenie)
        Me.group_Datos.Controls.Add(Me.lbl_SegundoOrdenie)
        Me.group_Datos.Controls.Add(Me.lbl_PrimerOrdenie)
        Me.group_Datos.Enabled = False
        Me.group_Datos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Datos.Location = New System.Drawing.Point(15, 78)
        Me.group_Datos.Name = "group_Datos"
        Me.group_Datos.Size = New System.Drawing.Size(335, 207)
        Me.group_Datos.TabIndex = 8
        Me.group_Datos.TabStop = False
        Me.group_Datos.Text = "Datos de producción"
        '
        'txt_CantidadTotal
        '
        Me.txt_CantidadTotal.Enabled = False
        Me.txt_CantidadTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CantidadTotal.Location = New System.Drawing.Point(140, 113)
        Me.txt_CantidadTotal.MaxLength = 5
        Me.txt_CantidadTotal.Multiline = True
        Me.txt_CantidadTotal.Name = "txt_CantidadTotal"
        Me.txt_CantidadTotal.Size = New System.Drawing.Size(85, 21)
        Me.txt_CantidadTotal.TabIndex = 11
        Me.txt_CantidadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_TercerOrdenie
        '
        Me.txt_TercerOrdenie.Enabled = False
        Me.txt_TercerOrdenie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TercerOrdenie.Location = New System.Drawing.Point(140, 86)
        Me.txt_TercerOrdenie.MaxLength = 5
        Me.txt_TercerOrdenie.Multiline = True
        Me.txt_TercerOrdenie.Name = "txt_TercerOrdenie"
        Me.txt_TercerOrdenie.Size = New System.Drawing.Size(85, 21)
        Me.txt_TercerOrdenie.TabIndex = 10
        Me.txt_TercerOrdenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_SegundoOrdenie
        '
        Me.txt_SegundoOrdenie.Enabled = False
        Me.txt_SegundoOrdenie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SegundoOrdenie.Location = New System.Drawing.Point(140, 59)
        Me.txt_SegundoOrdenie.MaxLength = 5
        Me.txt_SegundoOrdenie.Multiline = True
        Me.txt_SegundoOrdenie.Name = "txt_SegundoOrdenie"
        Me.txt_SegundoOrdenie.Size = New System.Drawing.Size(85, 21)
        Me.txt_SegundoOrdenie.TabIndex = 9
        Me.txt_SegundoOrdenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_PrimerOrdenie
        '
        Me.txt_PrimerOrdenie.Enabled = False
        Me.txt_PrimerOrdenie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PrimerOrdenie.Location = New System.Drawing.Point(140, 32)
        Me.txt_PrimerOrdenie.MaxLength = 5
        Me.txt_PrimerOrdenie.Multiline = True
        Me.txt_PrimerOrdenie.Name = "txt_PrimerOrdenie"
        Me.txt_PrimerOrdenie.Size = New System.Drawing.Size(85, 21)
        Me.txt_PrimerOrdenie.TabIndex = 8
        Me.txt_PrimerOrdenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Lts4
        '
        Me.lbl_Lts4.AutoSize = True
        Me.lbl_Lts4.Location = New System.Drawing.Point(231, 116)
        Me.lbl_Lts4.Name = "lbl_Lts4"
        Me.lbl_Lts4.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts4.TabIndex = 7
        Me.lbl_Lts4.Text = "Lts."
        '
        'lbl_Lts3
        '
        Me.lbl_Lts3.AutoSize = True
        Me.lbl_Lts3.Location = New System.Drawing.Point(231, 89)
        Me.lbl_Lts3.Name = "lbl_Lts3"
        Me.lbl_Lts3.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts3.TabIndex = 6
        Me.lbl_Lts3.Text = "Lts."
        '
        'lbl_Lts2
        '
        Me.lbl_Lts2.AutoSize = True
        Me.lbl_Lts2.Location = New System.Drawing.Point(231, 62)
        Me.lbl_Lts2.Name = "lbl_Lts2"
        Me.lbl_Lts2.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts2.TabIndex = 5
        Me.lbl_Lts2.Text = "Lts."
        '
        'lbl_Lts1
        '
        Me.lbl_Lts1.AutoSize = True
        Me.lbl_Lts1.Location = New System.Drawing.Point(231, 35)
        Me.lbl_Lts1.Name = "lbl_Lts1"
        Me.lbl_Lts1.Size = New System.Drawing.Size(30, 16)
        Me.lbl_Lts1.TabIndex = 4
        Me.lbl_Lts1.Text = "Lts."
        '
        'lbl_CantidadTotal
        '
        Me.lbl_CantidadTotal.AutoSize = True
        Me.lbl_CantidadTotal.Location = New System.Drawing.Point(7, 113)
        Me.lbl_CantidadTotal.Name = "lbl_CantidadTotal"
        Me.lbl_CantidadTotal.Size = New System.Drawing.Size(92, 16)
        Me.lbl_CantidadTotal.TabIndex = 3
        Me.lbl_CantidadTotal.Text = "Cantidad total:"
        '
        'lbl_TercerOrdenie
        '
        Me.lbl_TercerOrdenie.AutoSize = True
        Me.lbl_TercerOrdenie.Location = New System.Drawing.Point(7, 86)
        Me.lbl_TercerOrdenie.Name = "lbl_TercerOrdenie"
        Me.lbl_TercerOrdenie.Size = New System.Drawing.Size(90, 16)
        Me.lbl_TercerOrdenie.TabIndex = 2
        Me.lbl_TercerOrdenie.Text = "Tercer ordeñe:"
        '
        'lbl_SegundoOrdenie
        '
        Me.lbl_SegundoOrdenie.AutoSize = True
        Me.lbl_SegundoOrdenie.Location = New System.Drawing.Point(7, 59)
        Me.lbl_SegundoOrdenie.Name = "lbl_SegundoOrdenie"
        Me.lbl_SegundoOrdenie.Size = New System.Drawing.Size(106, 16)
        Me.lbl_SegundoOrdenie.TabIndex = 1
        Me.lbl_SegundoOrdenie.Text = "Segundo ordeñe:"
        '
        'lbl_PrimerOrdenie
        '
        Me.lbl_PrimerOrdenie.AutoSize = True
        Me.lbl_PrimerOrdenie.Location = New System.Drawing.Point(7, 32)
        Me.lbl_PrimerOrdenie.Name = "lbl_PrimerOrdenie"
        Me.lbl_PrimerOrdenie.Size = New System.Drawing.Size(93, 16)
        Me.lbl_PrimerOrdenie.TabIndex = 0
        Me.lbl_PrimerOrdenie.Text = "Primer ordeñe:"
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Volver.Location = New System.Drawing.Point(275, 291)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Volver.TabIndex = 9
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'cmd_VerGrafica
        '
        Me.cmd_VerGrafica.Enabled = False
        Me.cmd_VerGrafica.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_VerGrafica.Location = New System.Drawing.Point(194, 291)
        Me.cmd_VerGrafica.Name = "cmd_VerGrafica"
        Me.cmd_VerGrafica.Size = New System.Drawing.Size(75, 23)
        Me.cmd_VerGrafica.TabIndex = 10
        Me.cmd_VerGrafica.Text = "Ver Gráfica"
        Me.cmd_VerGrafica.UseVisualStyleBackColor = True
        '
        'lbl_TipoLeche
        '
        Me.lbl_TipoLeche.AutoSize = True
        Me.lbl_TipoLeche.Location = New System.Drawing.Point(7, 143)
        Me.lbl_TipoLeche.Name = "lbl_TipoLeche"
        Me.lbl_TipoLeche.Size = New System.Drawing.Size(89, 16)
        Me.lbl_TipoLeche.TabIndex = 12
        Me.lbl_TipoLeche.Text = "Tipo de leche:"
        '
        'cbo_TipoLeche
        '
        Me.cbo_TipoLeche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_TipoLeche.FormattingEnabled = True
        Me.cbo_TipoLeche.Location = New System.Drawing.Point(140, 140)
        Me.cbo_TipoLeche.Name = "cbo_TipoLeche"
        Me.cbo_TipoLeche.Size = New System.Drawing.Size(121, 24)
        Me.cbo_TipoLeche.TabIndex = 13
        '
        'lbl_Lote
        '
        Me.lbl_Lote.AutoSize = True
        Me.lbl_Lote.Location = New System.Drawing.Point(8, 173)
        Me.lbl_Lote.Name = "lbl_Lote"
        Me.lbl_Lote.Size = New System.Drawing.Size(37, 16)
        Me.lbl_Lote.TabIndex = 14
        Me.lbl_Lote.Text = "Lote:"
        '
        'cbo_Lote
        '
        Me.cbo_Lote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Lote.FormattingEnabled = True
        Me.cbo_Lote.Location = New System.Drawing.Point(51, 170)
        Me.cbo_Lote.Name = "cbo_Lote"
        Me.cbo_Lote.Size = New System.Drawing.Size(121, 24)
        Me.cbo_Lote.TabIndex = 15
        '
        'frmConsultarProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(362, 326)
        Me.Controls.Add(Me.cmd_VerGrafica)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.group_Datos)
        Me.Controls.Add(Me.date_FechaOrdenies)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.cmd_ConsultarProduccion)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.lbl_Establecimiento)
        Me.MaximizeBox = False
        Me.Name = "frmConsultarProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción"
        Me.group_Datos.ResumeLayout(False)
        Me.group_Datos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents cmd_ConsultarProduccion As System.Windows.Forms.Button
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents date_FechaOrdenies As System.Windows.Forms.DateTimePicker
    Friend WithEvents group_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_CantidadTotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_TercerOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents txt_SegundoOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents txt_PrimerOrdenie As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Lts4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lts1 As System.Windows.Forms.Label
    Friend WithEvents lbl_CantidadTotal As System.Windows.Forms.Label
    Friend WithEvents lbl_TercerOrdenie As System.Windows.Forms.Label
    Friend WithEvents lbl_SegundoOrdenie As System.Windows.Forms.Label
    Friend WithEvents lbl_PrimerOrdenie As System.Windows.Forms.Label
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
    Friend WithEvents cmd_VerGrafica As System.Windows.Forms.Button
    Friend WithEvents cbo_Lote As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Lote As System.Windows.Forms.Label
    Friend WithEvents cbo_TipoLeche As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoLeche As System.Windows.Forms.Label
End Class
