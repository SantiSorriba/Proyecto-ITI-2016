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
        Me.lbl_FechaOrdenie = New System.Windows.Forms.Label()
        Me.date_FechaOrdenie = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Lote = New System.Windows.Forms.Label()
        Me.cbo_Lotes = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoLeche = New System.Windows.Forms.Label()
        Me.cbo_TipoLeche = New System.Windows.Forms.ComboBox()
        Me.group_PrimerOrdenie = New System.Windows.Forms.GroupBox()
        Me.lbl_Litros1 = New System.Windows.Forms.Label()
        Me.txt_Cant1 = New System.Windows.Forms.TextBox()
        Me.lbl_Cantidad1 = New System.Windows.Forms.Label()
        Me.group_SegundoOrdenie = New System.Windows.Forms.GroupBox()
        Me.lbl_Litros2 = New System.Windows.Forms.Label()
        Me.txt_Cant2 = New System.Windows.Forms.TextBox()
        Me.lbl_Cantidad2 = New System.Windows.Forms.Label()
        Me.group_TercerOrdenie = New System.Windows.Forms.GroupBox()
        Me.lbl_Litros3 = New System.Windows.Forms.Label()
        Me.txt_Cant3 = New System.Windows.Forms.TextBox()
        Me.lbl_Cantidad3 = New System.Windows.Forms.Label()
        Me.lbl_CantOrdenies = New System.Windows.Forms.Label()
        Me.num_Ordenies = New System.Windows.Forms.NumericUpDown()
        Me.cmd_GuardarOrdenie = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.group_PrimerOrdenie.SuspendLayout()
        Me.group_SegundoOrdenie.SuspendLayout()
        Me.group_TercerOrdenie.SuspendLayout()
        CType(Me.num_Ordenies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_FechaOrdenie
        '
        Me.lbl_FechaOrdenie.AutoSize = True
        Me.lbl_FechaOrdenie.Location = New System.Drawing.Point(8, 12)
        Me.lbl_FechaOrdenie.Name = "lbl_FechaOrdenie"
        Me.lbl_FechaOrdenie.Size = New System.Drawing.Size(46, 17)
        Me.lbl_FechaOrdenie.TabIndex = 0
        Me.lbl_FechaOrdenie.Text = "Fecha:"
        '
        'date_FechaOrdenie
        '
        Me.date_FechaOrdenie.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_FechaOrdenie.Location = New System.Drawing.Point(57, 9)
        Me.date_FechaOrdenie.Name = "date_FechaOrdenie"
        Me.date_FechaOrdenie.Size = New System.Drawing.Size(111, 24)
        Me.date_FechaOrdenie.TabIndex = 1
        '
        'lbl_Lote
        '
        Me.lbl_Lote.AutoSize = True
        Me.lbl_Lote.Location = New System.Drawing.Point(174, 12)
        Me.lbl_Lote.Name = "lbl_Lote"
        Me.lbl_Lote.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Lote.TabIndex = 2
        Me.lbl_Lote.Text = "Lote:"
        '
        'cbo_Lotes
        '
        Me.cbo_Lotes.FormattingEnabled = True
        Me.cbo_Lotes.Location = New System.Drawing.Point(217, 9)
        Me.cbo_Lotes.Name = "cbo_Lotes"
        Me.cbo_Lotes.Size = New System.Drawing.Size(154, 25)
        Me.cbo_Lotes.TabIndex = 3
        '
        'lbl_TipoLeche
        '
        Me.lbl_TipoLeche.AutoSize = True
        Me.lbl_TipoLeche.Location = New System.Drawing.Point(8, 45)
        Me.lbl_TipoLeche.Name = "lbl_TipoLeche"
        Me.lbl_TipoLeche.Size = New System.Drawing.Size(150, 17)
        Me.lbl_TipoLeche.TabIndex = 4
        Me.lbl_TipoLeche.Text = "Tipo de leche ordeñada:"
        '
        'cbo_TipoLeche
        '
        Me.cbo_TipoLeche.FormattingEnabled = True
        Me.cbo_TipoLeche.Location = New System.Drawing.Point(177, 42)
        Me.cbo_TipoLeche.Name = "cbo_TipoLeche"
        Me.cbo_TipoLeche.Size = New System.Drawing.Size(182, 25)
        Me.cbo_TipoLeche.TabIndex = 5
        '
        'group_PrimerOrdenie
        '
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_Litros1)
        Me.group_PrimerOrdenie.Controls.Add(Me.txt_Cant1)
        Me.group_PrimerOrdenie.Controls.Add(Me.lbl_Cantidad1)
        Me.group_PrimerOrdenie.Enabled = False
        Me.group_PrimerOrdenie.Location = New System.Drawing.Point(11, 109)
        Me.group_PrimerOrdenie.Name = "group_PrimerOrdenie"
        Me.group_PrimerOrdenie.Size = New System.Drawing.Size(354, 57)
        Me.group_PrimerOrdenie.TabIndex = 8
        Me.group_PrimerOrdenie.TabStop = False
        Me.group_PrimerOrdenie.Text = "Primer Ordeñe"
        '
        'lbl_Litros1
        '
        Me.lbl_Litros1.AutoSize = True
        Me.lbl_Litros1.Location = New System.Drawing.Point(276, 25)
        Me.lbl_Litros1.Name = "lbl_Litros1"
        Me.lbl_Litros1.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Litros1.TabIndex = 11
        Me.lbl_Litros1.Text = "litros"
        '
        'txt_Cant1
        '
        Me.txt_Cant1.Location = New System.Drawing.Point(194, 22)
        Me.txt_Cant1.Name = "txt_Cant1"
        Me.txt_Cant1.Size = New System.Drawing.Size(76, 24)
        Me.txt_Cant1.TabIndex = 10
        '
        'lbl_Cantidad1
        '
        Me.lbl_Cantidad1.AutoSize = True
        Me.lbl_Cantidad1.Location = New System.Drawing.Point(6, 25)
        Me.lbl_Cantidad1.Name = "lbl_Cantidad1"
        Me.lbl_Cantidad1.Size = New System.Drawing.Size(182, 17)
        Me.lbl_Cantidad1.TabIndex = 9
        Me.lbl_Cantidad1.Text = "Cantidad producida de leche:"
        '
        'group_SegundoOrdenie
        '
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_Litros2)
        Me.group_SegundoOrdenie.Controls.Add(Me.txt_Cant2)
        Me.group_SegundoOrdenie.Controls.Add(Me.lbl_Cantidad2)
        Me.group_SegundoOrdenie.Enabled = False
        Me.group_SegundoOrdenie.Location = New System.Drawing.Point(11, 176)
        Me.group_SegundoOrdenie.Name = "group_SegundoOrdenie"
        Me.group_SegundoOrdenie.Size = New System.Drawing.Size(354, 57)
        Me.group_SegundoOrdenie.TabIndex = 12
        Me.group_SegundoOrdenie.TabStop = False
        Me.group_SegundoOrdenie.Text = "Segundo Ordeñe"
        '
        'lbl_Litros2
        '
        Me.lbl_Litros2.AutoSize = True
        Me.lbl_Litros2.Location = New System.Drawing.Point(276, 25)
        Me.lbl_Litros2.Name = "lbl_Litros2"
        Me.lbl_Litros2.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Litros2.TabIndex = 15
        Me.lbl_Litros2.Text = "litros"
        '
        'txt_Cant2
        '
        Me.txt_Cant2.Location = New System.Drawing.Point(194, 22)
        Me.txt_Cant2.Name = "txt_Cant2"
        Me.txt_Cant2.Size = New System.Drawing.Size(76, 24)
        Me.txt_Cant2.TabIndex = 14
        '
        'lbl_Cantidad2
        '
        Me.lbl_Cantidad2.AutoSize = True
        Me.lbl_Cantidad2.Location = New System.Drawing.Point(6, 25)
        Me.lbl_Cantidad2.Name = "lbl_Cantidad2"
        Me.lbl_Cantidad2.Size = New System.Drawing.Size(182, 17)
        Me.lbl_Cantidad2.TabIndex = 13
        Me.lbl_Cantidad2.Text = "Cantidad producida de leche:"
        '
        'group_TercerOrdenie
        '
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_Litros3)
        Me.group_TercerOrdenie.Controls.Add(Me.txt_Cant3)
        Me.group_TercerOrdenie.Controls.Add(Me.lbl_Cantidad3)
        Me.group_TercerOrdenie.Enabled = False
        Me.group_TercerOrdenie.Location = New System.Drawing.Point(11, 243)
        Me.group_TercerOrdenie.Name = "group_TercerOrdenie"
        Me.group_TercerOrdenie.Size = New System.Drawing.Size(354, 57)
        Me.group_TercerOrdenie.TabIndex = 16
        Me.group_TercerOrdenie.TabStop = False
        Me.group_TercerOrdenie.Text = "Tercer Ordeñe"
        '
        'lbl_Litros3
        '
        Me.lbl_Litros3.AutoSize = True
        Me.lbl_Litros3.Location = New System.Drawing.Point(276, 25)
        Me.lbl_Litros3.Name = "lbl_Litros3"
        Me.lbl_Litros3.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Litros3.TabIndex = 19
        Me.lbl_Litros3.Text = "litros"
        '
        'txt_Cant3
        '
        Me.txt_Cant3.Location = New System.Drawing.Point(194, 22)
        Me.txt_Cant3.Name = "txt_Cant3"
        Me.txt_Cant3.Size = New System.Drawing.Size(76, 24)
        Me.txt_Cant3.TabIndex = 18
        '
        'lbl_Cantidad3
        '
        Me.lbl_Cantidad3.AutoSize = True
        Me.lbl_Cantidad3.Location = New System.Drawing.Point(6, 25)
        Me.lbl_Cantidad3.Name = "lbl_Cantidad3"
        Me.lbl_Cantidad3.Size = New System.Drawing.Size(182, 17)
        Me.lbl_Cantidad3.TabIndex = 17
        Me.lbl_Cantidad3.Text = "Cantidad producida de leche:"
        '
        'lbl_CantOrdenies
        '
        Me.lbl_CantOrdenies.AutoSize = True
        Me.lbl_CantOrdenies.Location = New System.Drawing.Point(8, 76)
        Me.lbl_CantOrdenies.Name = "lbl_CantOrdenies"
        Me.lbl_CantOrdenies.Size = New System.Drawing.Size(199, 17)
        Me.lbl_CantOrdenies.TabIndex = 6
        Me.lbl_CantOrdenies.Text = "Cantidad de ordeñes realizados:"
        '
        'num_Ordenies
        '
        Me.num_Ordenies.Location = New System.Drawing.Point(216, 73)
        Me.num_Ordenies.Name = "num_Ordenies"
        Me.num_Ordenies.Size = New System.Drawing.Size(37, 24)
        Me.num_Ordenies.TabIndex = 7
        '
        'cmd_GuardarOrdenie
        '
        Me.cmd_GuardarOrdenie.Enabled = False
        Me.cmd_GuardarOrdenie.Location = New System.Drawing.Point(11, 306)
        Me.cmd_GuardarOrdenie.Name = "cmd_GuardarOrdenie"
        Me.cmd_GuardarOrdenie.Size = New System.Drawing.Size(170, 30)
        Me.cmd_GuardarOrdenie.TabIndex = 20
        Me.cmd_GuardarOrdenie.Text = "Guardar ordeñe"
        Me.cmd_GuardarOrdenie.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(196, 306)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(169, 30)
        Me.cmd_Volver.TabIndex = 21
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmOrdenies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(377, 344)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_GuardarOrdenie)
        Me.Controls.Add(Me.num_Ordenies)
        Me.Controls.Add(Me.lbl_CantOrdenies)
        Me.Controls.Add(Me.group_TercerOrdenie)
        Me.Controls.Add(Me.group_SegundoOrdenie)
        Me.Controls.Add(Me.group_PrimerOrdenie)
        Me.Controls.Add(Me.cbo_TipoLeche)
        Me.Controls.Add(Me.lbl_TipoLeche)
        Me.Controls.Add(Me.cbo_Lotes)
        Me.Controls.Add(Me.lbl_Lote)
        Me.Controls.Add(Me.date_FechaOrdenie)
        Me.Controls.Add(Me.lbl_FechaOrdenie)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmOrdenies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordeñes"
        Me.group_PrimerOrdenie.ResumeLayout(False)
        Me.group_PrimerOrdenie.PerformLayout()
        Me.group_SegundoOrdenie.ResumeLayout(False)
        Me.group_SegundoOrdenie.PerformLayout()
        Me.group_TercerOrdenie.ResumeLayout(False)
        Me.group_TercerOrdenie.PerformLayout()
        CType(Me.num_Ordenies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_FechaOrdenie As System.Windows.Forms.Label
    Friend WithEvents date_FechaOrdenie As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Lote As System.Windows.Forms.Label
    Friend WithEvents cbo_Lotes As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoLeche As System.Windows.Forms.Label
    Friend WithEvents cbo_TipoLeche As System.Windows.Forms.ComboBox
    Friend WithEvents group_PrimerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Litros1 As System.Windows.Forms.Label
    Friend WithEvents txt_Cant1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cantidad1 As System.Windows.Forms.Label
    Friend WithEvents group_SegundoOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Litros2 As System.Windows.Forms.Label
    Friend WithEvents txt_Cant2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cantidad2 As System.Windows.Forms.Label
    Friend WithEvents group_TercerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Litros3 As System.Windows.Forms.Label
    Friend WithEvents txt_Cant3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Cantidad3 As System.Windows.Forms.Label
    Friend WithEvents lbl_CantOrdenies As System.Windows.Forms.Label
    Friend WithEvents num_Ordenies As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmd_GuardarOrdenie As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
