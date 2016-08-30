<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmLotes))
        Me.lbl_NroLote1 = New System.Windows.Forms.Label()
        Me.txt_NroLote = New System.Windows.Forms.TextBox()
        Me.cmd_BuscarLote = New System.Windows.Forms.Button()
        Me.group_Lote = New System.Windows.Forms.GroupBox()
        Me.cmd_VerificarLote = New System.Windows.Forms.Button()
        Me.txt_NroLote2 = New System.Windows.Forms.TextBox()
        Me.cbo_Criterio = New System.Windows.Forms.ComboBox()
        Me.lbl_Criterio = New System.Windows.Forms.Label()
        Me.cmd_AgregarAnimales = New System.Windows.Forms.Button()
        Me.num_CantAnimales = New System.Windows.Forms.NumericUpDown()
        Me.lbl_CantAnimales = New System.Windows.Forms.Label()
        Me.txt_NombreLote = New System.Windows.Forms.TextBox()
        Me.lbl_NombreLote = New System.Windows.Forms.Label()
        Me.lbl_NroLote2 = New System.Windows.Forms.Label()
        Me.cmd_Guardar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Eliminar = New System.Windows.Forms.Button()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.group_Lote.SuspendLayout()
        CType(Me.num_CantAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NroLote1
        '
        Me.lbl_NroLote1.AutoSize = True
        Me.lbl_NroLote1.Location = New System.Drawing.Point(7, 41)
        Me.lbl_NroLote1.Name = "lbl_NroLote1"
        Me.lbl_NroLote1.Size = New System.Drawing.Size(105, 17)
        Me.lbl_NroLote1.TabIndex = 2
        Me.lbl_NroLote1.Text = "Número de lote:"
        '
        'txt_NroLote
        '
        Me.txt_NroLote.Location = New System.Drawing.Point(118, 38)
        Me.txt_NroLote.Name = "txt_NroLote"
        Me.txt_NroLote.Size = New System.Drawing.Size(48, 24)
        Me.txt_NroLote.TabIndex = 3
        '
        'cmd_BuscarLote
        '
        Me.cmd_BuscarLote.Location = New System.Drawing.Point(184, 38)
        Me.cmd_BuscarLote.Name = "cmd_BuscarLote"
        Me.cmd_BuscarLote.Size = New System.Drawing.Size(133, 25)
        Me.cmd_BuscarLote.TabIndex = 4
        Me.cmd_BuscarLote.Text = "Buscar Lote"
        Me.cmd_BuscarLote.UseVisualStyleBackColor = True
        '
        'group_Lote
        '
        Me.group_Lote.Controls.Add(Me.cmd_VerificarLote)
        Me.group_Lote.Controls.Add(Me.txt_NroLote2)
        Me.group_Lote.Controls.Add(Me.cbo_Criterio)
        Me.group_Lote.Controls.Add(Me.lbl_Criterio)
        Me.group_Lote.Controls.Add(Me.cmd_AgregarAnimales)
        Me.group_Lote.Controls.Add(Me.num_CantAnimales)
        Me.group_Lote.Controls.Add(Me.lbl_CantAnimales)
        Me.group_Lote.Controls.Add(Me.txt_NombreLote)
        Me.group_Lote.Controls.Add(Me.lbl_NombreLote)
        Me.group_Lote.Controls.Add(Me.lbl_NroLote2)
        Me.group_Lote.Enabled = False
        Me.group_Lote.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Lote.Location = New System.Drawing.Point(12, 81)
        Me.group_Lote.Name = "group_Lote"
        Me.group_Lote.Size = New System.Drawing.Size(311, 163)
        Me.group_Lote.TabIndex = 5
        Me.group_Lote.TabStop = False
        Me.group_Lote.Text = "Datos del lote"
        '
        'cmd_VerificarLote
        '
        Me.cmd_VerificarLote.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_VerificarLote.Location = New System.Drawing.Point(172, 34)
        Me.cmd_VerificarLote.Name = "cmd_VerificarLote"
        Me.cmd_VerificarLote.Size = New System.Drawing.Size(133, 25)
        Me.cmd_VerificarLote.TabIndex = 8
        Me.cmd_VerificarLote.Text = "Verificar numero"
        Me.cmd_VerificarLote.UseVisualStyleBackColor = True
        '
        'txt_NroLote2
        '
        Me.txt_NroLote2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NroLote2.Location = New System.Drawing.Point(117, 35)
        Me.txt_NroLote2.Name = "txt_NroLote2"
        Me.txt_NroLote2.Size = New System.Drawing.Size(48, 24)
        Me.txt_NroLote2.TabIndex = 7
        '
        'cbo_Criterio
        '
        Me.cbo_Criterio.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Criterio.FormattingEnabled = True
        Me.cbo_Criterio.Location = New System.Drawing.Point(106, 127)
        Me.cbo_Criterio.Name = "cbo_Criterio"
        Me.cbo_Criterio.Size = New System.Drawing.Size(199, 25)
        Me.cbo_Criterio.TabIndex = 15
        '
        'lbl_Criterio
        '
        Me.lbl_Criterio.AutoSize = True
        Me.lbl_Criterio.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Criterio.Location = New System.Drawing.Point(6, 131)
        Me.lbl_Criterio.Name = "lbl_Criterio"
        Me.lbl_Criterio.Size = New System.Drawing.Size(56, 17)
        Me.lbl_Criterio.TabIndex = 14
        Me.lbl_Criterio.Text = "Criterio:"
        '
        'cmd_AgregarAnimales
        '
        Me.cmd_AgregarAnimales.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AgregarAnimales.Location = New System.Drawing.Point(213, 97)
        Me.cmd_AgregarAnimales.Name = "cmd_AgregarAnimales"
        Me.cmd_AgregarAnimales.Size = New System.Drawing.Size(92, 25)
        Me.cmd_AgregarAnimales.TabIndex = 13
        Me.cmd_AgregarAnimales.Text = "Añadir"
        Me.cmd_AgregarAnimales.UseVisualStyleBackColor = True
        '
        'num_CantAnimales
        '
        Me.num_CantAnimales.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_CantAnimales.Location = New System.Drawing.Point(152, 97)
        Me.num_CantAnimales.Name = "num_CantAnimales"
        Me.num_CantAnimales.Size = New System.Drawing.Size(55, 24)
        Me.num_CantAnimales.TabIndex = 12
        '
        'lbl_CantAnimales
        '
        Me.lbl_CantAnimales.AutoSize = True
        Me.lbl_CantAnimales.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantAnimales.Location = New System.Drawing.Point(6, 100)
        Me.lbl_CantAnimales.Name = "lbl_CantAnimales"
        Me.lbl_CantAnimales.Size = New System.Drawing.Size(140, 17)
        Me.lbl_CantAnimales.TabIndex = 11
        Me.lbl_CantAnimales.Text = "Cantidad de animales:"
        '
        'txt_NombreLote
        '
        Me.txt_NombreLote.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NombreLote.Location = New System.Drawing.Point(120, 67)
        Me.txt_NombreLote.Name = "txt_NombreLote"
        Me.txt_NombreLote.Size = New System.Drawing.Size(185, 24)
        Me.txt_NombreLote.TabIndex = 10
        '
        'lbl_NombreLote
        '
        Me.lbl_NombreLote.AutoSize = True
        Me.lbl_NombreLote.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreLote.Location = New System.Drawing.Point(6, 70)
        Me.lbl_NombreLote.Name = "lbl_NombreLote"
        Me.lbl_NombreLote.Size = New System.Drawing.Size(108, 17)
        Me.lbl_NombreLote.TabIndex = 9
        Me.lbl_NombreLote.Text = "Nombre del lote:"
        '
        'lbl_NroLote2
        '
        Me.lbl_NroLote2.AutoSize = True
        Me.lbl_NroLote2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NroLote2.Location = New System.Drawing.Point(6, 38)
        Me.lbl_NroLote2.Name = "lbl_NroLote2"
        Me.lbl_NroLote2.Size = New System.Drawing.Size(105, 17)
        Me.lbl_NroLote2.TabIndex = 6
        Me.lbl_NroLote2.Text = "Número de lote:"
        '
        'cmd_Guardar
        '
        Me.cmd_Guardar.Enabled = False
        Me.cmd_Guardar.Location = New System.Drawing.Point(12, 250)
        Me.cmd_Guardar.Name = "cmd_Guardar"
        Me.cmd_Guardar.Size = New System.Drawing.Size(78, 27)
        Me.cmd_Guardar.TabIndex = 16
        Me.cmd_Guardar.Text = "Guardar"
        Me.cmd_Guardar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Enabled = False
        Me.cmd_Modificar.Location = New System.Drawing.Point(96, 250)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(82, 27)
        Me.cmd_Modificar.TabIndex = 17
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Eliminar
        '
        Me.cmd_Eliminar.Enabled = False
        Me.cmd_Eliminar.Location = New System.Drawing.Point(184, 250)
        Me.cmd_Eliminar.Name = "cmd_Eliminar"
        Me.cmd_Eliminar.Size = New System.Drawing.Size(78, 27)
        Me.cmd_Eliminar.TabIndex = 18
        Me.cmd_Eliminar.Text = "Eliminar"
        Me.cmd_Eliminar.UseVisualStyleBackColor = True
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(268, 250)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(61, 27)
        Me.cmd_Volver.TabIndex = 19
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(6, 8)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(106, 17)
        Me.lbl_Establecimiento.TabIndex = 0
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(115, 4)
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(214, 25)
        Me.cbo_Establecimientos.TabIndex = 1
        '
        'frmAdmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(335, 285)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.lbl_Establecimiento)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.cmd_Eliminar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Guardar)
        Me.Controls.Add(Me.group_Lote)
        Me.Controls.Add(Me.cmd_BuscarLote)
        Me.Controls.Add(Me.txt_NroLote)
        Me.Controls.Add(Me.lbl_NroLote1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAdmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Lotes"
        Me.group_Lote.ResumeLayout(False)
        Me.group_Lote.PerformLayout()
        CType(Me.num_CantAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NroLote1 As System.Windows.Forms.Label
    Friend WithEvents txt_NroLote As System.Windows.Forms.TextBox
    Friend WithEvents cmd_BuscarLote As System.Windows.Forms.Button
    Friend WithEvents group_Lote As System.Windows.Forms.GroupBox
    Friend WithEvents num_CantAnimales As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_CantAnimales As System.Windows.Forms.Label
    Friend WithEvents txt_NombreLote As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NombreLote As System.Windows.Forms.Label
    Friend WithEvents lbl_NroLote2 As System.Windows.Forms.Label
    Friend WithEvents cmd_AgregarAnimales As System.Windows.Forms.Button
    Friend WithEvents cbo_Criterio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Criterio As System.Windows.Forms.Label
    Friend WithEvents cmd_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_VerificarLote As System.Windows.Forms.Button
    Friend WithEvents txt_NroLote2 As System.Windows.Forms.TextBox
End Class
