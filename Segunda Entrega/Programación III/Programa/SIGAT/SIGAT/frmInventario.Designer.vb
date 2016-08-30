<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.lbl_Establecimiento = New System.Windows.Forms.Label()
        Me.cbo_Establecimientos = New System.Windows.Forms.ComboBox()
        Me.lbl_Mostrar = New System.Windows.Forms.Label()
        Me.chk_Vendidos = New System.Windows.Forms.CheckBox()
        Me.chk_Muertos = New System.Windows.Forms.CheckBox()
        Me.cmd_Listar = New System.Windows.Forms.Button()
        Me.grid_Animales = New System.Windows.Forms.DataGridView()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        CType(Me.grid_Animales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Establecimiento
        '
        Me.lbl_Establecimiento.AutoSize = True
        Me.lbl_Establecimiento.Location = New System.Drawing.Point(9, 9)
        Me.lbl_Establecimiento.Name = "lbl_Establecimiento"
        Me.lbl_Establecimiento.Size = New System.Drawing.Size(116, 17)
        Me.lbl_Establecimiento.TabIndex = 0
        Me.lbl_Establecimiento.Text = "Establecimiento:"
        '
        'cbo_Establecimientos
        '
        Me.cbo_Establecimientos.FormattingEnabled = True
        Me.cbo_Establecimientos.Location = New System.Drawing.Point(131, 6)
        Me.cbo_Establecimientos.Name = "cbo_Establecimientos"
        Me.cbo_Establecimientos.Size = New System.Drawing.Size(363, 25)
        Me.cbo_Establecimientos.TabIndex = 1
        '
        'lbl_Mostrar
        '
        Me.lbl_Mostrar.AutoSize = True
        Me.lbl_Mostrar.Location = New System.Drawing.Point(9, 39)
        Me.lbl_Mostrar.Name = "lbl_Mostrar"
        Me.lbl_Mostrar.Size = New System.Drawing.Size(203, 17)
        Me.lbl_Mostrar.TabIndex = 2
        Me.lbl_Mostrar.Text = "Mostrar también los animales:"
        '
        'chk_Vendidos
        '
        Me.chk_Vendidos.AutoSize = True
        Me.chk_Vendidos.Location = New System.Drawing.Point(221, 38)
        Me.chk_Vendidos.Name = "chk_Vendidos"
        Me.chk_Vendidos.Size = New System.Drawing.Size(86, 21)
        Me.chk_Vendidos.TabIndex = 3
        Me.chk_Vendidos.Text = "Vendidos"
        Me.chk_Vendidos.UseVisualStyleBackColor = True
        '
        'chk_Muertos
        '
        Me.chk_Muertos.AutoSize = True
        Me.chk_Muertos.Location = New System.Drawing.Point(313, 38)
        Me.chk_Muertos.Name = "chk_Muertos"
        Me.chk_Muertos.Size = New System.Drawing.Size(79, 21)
        Me.chk_Muertos.TabIndex = 4
        Me.chk_Muertos.Text = "Muertos"
        Me.chk_Muertos.UseVisualStyleBackColor = True
        '
        'cmd_Listar
        '
        Me.cmd_Listar.Location = New System.Drawing.Point(398, 35)
        Me.cmd_Listar.Name = "cmd_Listar"
        Me.cmd_Listar.Size = New System.Drawing.Size(88, 27)
        Me.cmd_Listar.TabIndex = 5
        Me.cmd_Listar.Text = "Listar"
        Me.cmd_Listar.UseVisualStyleBackColor = True
        '
        'grid_Animales
        '
        Me.grid_Animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Animales.Location = New System.Drawing.Point(12, 68)
        Me.grid_Animales.Name = "grid_Animales"
        Me.grid_Animales.Size = New System.Drawing.Size(482, 365)
        Me.grid_Animales.TabIndex = 6
        Me.grid_Animales.Visible = False
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Image = CType(resources.GetObject("cmd_Volver.Image"), System.Drawing.Image)
        Me.cmd_Volver.Location = New System.Drawing.Point(527, 284)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(41, 40)
        Me.cmd_Volver.TabIndex = 7
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(644, 472)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.grid_Animales)
        Me.Controls.Add(Me.cmd_Listar)
        Me.Controls.Add(Me.chk_Muertos)
        Me.Controls.Add(Me.chk_Vendidos)
        Me.Controls.Add(Me.lbl_Mostrar)
        Me.Controls.Add(Me.cbo_Establecimientos)
        Me.Controls.Add(Me.lbl_Establecimiento)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Animales"
        CType(Me.grid_Animales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Establecimiento As System.Windows.Forms.Label
    Friend WithEvents cbo_Establecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Mostrar As System.Windows.Forms.Label
    Friend WithEvents chk_Vendidos As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Muertos As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_Listar As System.Windows.Forms.Button
    Friend WithEvents grid_Animales As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
