<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotes
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
        Me.lbl_NroLote1 = New System.Windows.Forms.Label()
        Me.txt_NumLote1 = New System.Windows.Forms.TextBox()
        Me.cmd_Buscar = New System.Windows.Forms.Button()
        Me.txt_NumLote2 = New System.Windows.Forms.TextBox()
        Me.lbl_NroLote2 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_CantAnimales = New System.Windows.Forms.Label()
        Me.num_CantAnimales = New System.Windows.Forms.NumericUpDown()
        Me.cmd_AgregarAnimales = New System.Windows.Forms.Button()
        Me.lbl_Criterio = New System.Windows.Forms.Label()
        Me.cbo_Criterio = New System.Windows.Forms.ComboBox()
        Me.cmd_AgregarLote = New System.Windows.Forms.Button()
        Me.cmd_ModificarLote = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.panel_Lote = New System.Windows.Forms.Panel()
        Me.cmd_Verificar = New System.Windows.Forms.Button()
        Me.cmd_EliminarLote = New System.Windows.Forms.Button()
        CType(Me.num_CantAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Lote.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NroLote1
        '
        Me.lbl_NroLote1.AutoSize = True
        Me.lbl_NroLote1.Location = New System.Drawing.Point(12, 15)
        Me.lbl_NroLote1.Name = "lbl_NroLote1"
        Me.lbl_NroLote1.Size = New System.Drawing.Size(116, 17)
        Me.lbl_NroLote1.TabIndex = 0
        Me.lbl_NroLote1.Text = "Número de Lote:"
        '
        'txt_NumLote1
        '
        Me.txt_NumLote1.Location = New System.Drawing.Point(143, 12)
        Me.txt_NumLote1.Name = "txt_NumLote1"
        Me.txt_NumLote1.Size = New System.Drawing.Size(43, 25)
        Me.txt_NumLote1.TabIndex = 1
        '
        'cmd_Buscar
        '
        Me.cmd_Buscar.Location = New System.Drawing.Point(212, 11)
        Me.cmd_Buscar.Name = "cmd_Buscar"
        Me.cmd_Buscar.Size = New System.Drawing.Size(80, 25)
        Me.cmd_Buscar.TabIndex = 2
        Me.cmd_Buscar.Text = "Buscar"
        Me.cmd_Buscar.UseVisualStyleBackColor = True
        '
        'txt_NumLote2
        '
        Me.txt_NumLote2.Enabled = False
        Me.txt_NumLote2.Location = New System.Drawing.Point(131, 9)
        Me.txt_NumLote2.Name = "txt_NumLote2"
        Me.txt_NumLote2.Size = New System.Drawing.Size(43, 25)
        Me.txt_NumLote2.TabIndex = 4
        '
        'lbl_NroLote2
        '
        Me.lbl_NroLote2.AutoSize = True
        Me.lbl_NroLote2.Location = New System.Drawing.Point(7, 12)
        Me.lbl_NroLote2.Name = "lbl_NroLote2"
        Me.lbl_NroLote2.Size = New System.Drawing.Size(116, 17)
        Me.lbl_NroLote2.TabIndex = 3
        Me.lbl_NroLote2.Text = "Número de Lote:"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(7, 43)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(64, 17)
        Me.lbl_Nombre.TabIndex = 5
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(77, 40)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(174, 25)
        Me.txt_Nombre.TabIndex = 6
        '
        'lbl_CantAnimales
        '
        Me.lbl_CantAnimales.AutoSize = True
        Me.lbl_CantAnimales.Location = New System.Drawing.Point(7, 75)
        Me.lbl_CantAnimales.Name = "lbl_CantAnimales"
        Me.lbl_CantAnimales.Size = New System.Drawing.Size(153, 17)
        Me.lbl_CantAnimales.TabIndex = 7
        Me.lbl_CantAnimales.Text = "Cantidad de animales:"
        '
        'num_CantAnimales
        '
        Me.num_CantAnimales.Location = New System.Drawing.Point(166, 71)
        Me.num_CantAnimales.Name = "num_CantAnimales"
        Me.num_CantAnimales.Size = New System.Drawing.Size(55, 25)
        Me.num_CantAnimales.TabIndex = 8
        '
        'cmd_AgregarAnimales
        '
        Me.cmd_AgregarAnimales.Location = New System.Drawing.Point(227, 70)
        Me.cmd_AgregarAnimales.Name = "cmd_AgregarAnimales"
        Me.cmd_AgregarAnimales.Size = New System.Drawing.Size(82, 26)
        Me.cmd_AgregarAnimales.TabIndex = 9
        Me.cmd_AgregarAnimales.Text = "Agregar"
        Me.cmd_AgregarAnimales.UseVisualStyleBackColor = True
        '
        'lbl_Criterio
        '
        Me.lbl_Criterio.AutoSize = True
        Me.lbl_Criterio.Location = New System.Drawing.Point(7, 108)
        Me.lbl_Criterio.Name = "lbl_Criterio"
        Me.lbl_Criterio.Size = New System.Drawing.Size(59, 17)
        Me.lbl_Criterio.TabIndex = 10
        Me.lbl_Criterio.Text = "Criterio:"
        '
        'cbo_Criterio
        '
        Me.cbo_Criterio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Criterio.FormattingEnabled = True
        Me.cbo_Criterio.Items.AddRange(New Object() {"Enfermedad", "Ordeñe", "Preñadas", "Secas", "Animales no productivos"})
        Me.cbo_Criterio.Location = New System.Drawing.Point(76, 106)
        Me.cbo_Criterio.Name = "cbo_Criterio"
        Me.cbo_Criterio.Size = New System.Drawing.Size(211, 24)
        Me.cbo_Criterio.TabIndex = 11
        '
        'cmd_AgregarLote
        '
        Me.cmd_AgregarLote.Enabled = False
        Me.cmd_AgregarLote.Location = New System.Drawing.Point(7, 193)
        Me.cmd_AgregarLote.Name = "cmd_AgregarLote"
        Me.cmd_AgregarLote.Size = New System.Drawing.Size(76, 27)
        Me.cmd_AgregarLote.TabIndex = 12
        Me.cmd_AgregarLote.Text = "Agregar"
        Me.cmd_AgregarLote.UseVisualStyleBackColor = True
        '
        'cmd_ModificarLote
        '
        Me.cmd_ModificarLote.Enabled = False
        Me.cmd_ModificarLote.Location = New System.Drawing.Point(87, 193)
        Me.cmd_ModificarLote.Name = "cmd_ModificarLote"
        Me.cmd_ModificarLote.Size = New System.Drawing.Size(78, 27)
        Me.cmd_ModificarLote.TabIndex = 13
        Me.cmd_ModificarLote.Text = "Modificar"
        Me.cmd_ModificarLote.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(253, 193)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(68, 27)
        Me.cmd_Volver.TabIndex = 14
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'panel_Lote
        '
        Me.panel_Lote.Controls.Add(Me.cmd_Verificar)
        Me.panel_Lote.Controls.Add(Me.cbo_Criterio)
        Me.panel_Lote.Controls.Add(Me.lbl_Criterio)
        Me.panel_Lote.Controls.Add(Me.cmd_AgregarAnimales)
        Me.panel_Lote.Controls.Add(Me.num_CantAnimales)
        Me.panel_Lote.Controls.Add(Me.lbl_CantAnimales)
        Me.panel_Lote.Controls.Add(Me.txt_Nombre)
        Me.panel_Lote.Controls.Add(Me.lbl_Nombre)
        Me.panel_Lote.Controls.Add(Me.txt_NumLote2)
        Me.panel_Lote.Controls.Add(Me.lbl_NroLote2)
        Me.panel_Lote.Enabled = False
        Me.panel_Lote.Location = New System.Drawing.Point(5, 44)
        Me.panel_Lote.Name = "panel_Lote"
        Me.panel_Lote.Size = New System.Drawing.Size(316, 141)
        Me.panel_Lote.TabIndex = 15
        '
        'cmd_Verificar
        '
        Me.cmd_Verificar.Enabled = False
        Me.cmd_Verificar.Location = New System.Drawing.Point(180, 9)
        Me.cmd_Verificar.Name = "cmd_Verificar"
        Me.cmd_Verificar.Size = New System.Drawing.Size(129, 25)
        Me.cmd_Verificar.TabIndex = 12
        Me.cmd_Verificar.Text = "Verificar numero"
        Me.cmd_Verificar.UseVisualStyleBackColor = True
        '
        'cmd_EliminarLote
        '
        Me.cmd_EliminarLote.Enabled = False
        Me.cmd_EliminarLote.Location = New System.Drawing.Point(171, 193)
        Me.cmd_EliminarLote.Name = "cmd_EliminarLote"
        Me.cmd_EliminarLote.Size = New System.Drawing.Size(78, 27)
        Me.cmd_EliminarLote.TabIndex = 16
        Me.cmd_EliminarLote.Text = "Eliminar"
        Me.cmd_EliminarLote.UseVisualStyleBackColor = True
        '
        'frmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(326, 227)
        Me.Controls.Add(Me.cmd_EliminarLote)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.panel_Lote)
        Me.Controls.Add(Me.cmd_ModificarLote)
        Me.Controls.Add(Me.cmd_Buscar)
        Me.Controls.Add(Me.cmd_AgregarLote)
        Me.Controls.Add(Me.txt_NumLote1)
        Me.Controls.Add(Me.lbl_NroLote1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes"
        CType(Me.num_CantAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Lote.ResumeLayout(False)
        Me.panel_Lote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NroLote1 As System.Windows.Forms.Label
    Friend WithEvents txt_NumLote1 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_NumLote2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NroLote2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CantAnimales As System.Windows.Forms.Label
    Friend WithEvents num_CantAnimales As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmd_AgregarAnimales As System.Windows.Forms.Button
    Friend WithEvents lbl_Criterio As System.Windows.Forms.Label
    Friend WithEvents cbo_Criterio As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_AgregarLote As System.Windows.Forms.Button
    Friend WithEvents cmd_ModificarLote As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
    Friend WithEvents panel_Lote As System.Windows.Forms.Panel
    Friend WithEvents cmd_EliminarLote As System.Windows.Forms.Button
    Friend WithEvents cmd_Verificar As System.Windows.Forms.Button
End Class
