<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialEventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorialEventos))
        Me.lbl_NroIdentificador = New System.Windows.Forms.Label()
        Me.txt_NroIdentificador = New System.Windows.Forms.TextBox()
        Me.cmd_Listar = New System.Windows.Forms.Button()
        Me.grid_Eventos = New System.Windows.Forms.DataGridView()
        Me.cmd_Volver = New System.Windows.Forms.Button()
        CType(Me.grid_Eventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NroIdentificador
        '
        Me.lbl_NroIdentificador.AutoSize = True
        Me.lbl_NroIdentificador.Location = New System.Drawing.Point(12, 10)
        Me.lbl_NroIdentificador.Name = "lbl_NroIdentificador"
        Me.lbl_NroIdentificador.Size = New System.Drawing.Size(257, 20)
        Me.lbl_NroIdentificador.TabIndex = 0
        Me.lbl_NroIdentificador.Text = "Número identificador del animal:"
        '
        'txt_NroIdentificador
        '
        Me.txt_NroIdentificador.Location = New System.Drawing.Point(274, 6)
        Me.txt_NroIdentificador.Name = "txt_NroIdentificador"
        Me.txt_NroIdentificador.Size = New System.Drawing.Size(64, 28)
        Me.txt_NroIdentificador.TabIndex = 1
        '
        'cmd_Listar
        '
        Me.cmd_Listar.Location = New System.Drawing.Point(345, 6)
        Me.cmd_Listar.Name = "cmd_Listar"
        Me.cmd_Listar.Size = New System.Drawing.Size(128, 28)
        Me.cmd_Listar.TabIndex = 2
        Me.cmd_Listar.Text = "Listar eventos"
        Me.cmd_Listar.UseVisualStyleBackColor = True
        '
        'grid_Eventos
        '
        Me.grid_Eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Eventos.Location = New System.Drawing.Point(12, 53)
        Me.grid_Eventos.Name = "grid_Eventos"
        Me.grid_Eventos.Size = New System.Drawing.Size(461, 286)
        Me.grid_Eventos.TabIndex = 3
        '
        'cmd_Volver
        '
        Me.cmd_Volver.Location = New System.Drawing.Point(398, 345)
        Me.cmd_Volver.Name = "cmd_Volver"
        Me.cmd_Volver.Size = New System.Drawing.Size(75, 28)
        Me.cmd_Volver.TabIndex = 4
        Me.cmd_Volver.Text = "Volver"
        Me.cmd_Volver.UseVisualStyleBackColor = True
        '
        'frmHistorialEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(485, 379)
        Me.Controls.Add(Me.cmd_Volver)
        Me.Controls.Add(Me.grid_Eventos)
        Me.Controls.Add(Me.cmd_Listar)
        Me.Controls.Add(Me.txt_NroIdentificador)
        Me.Controls.Add(Me.lbl_NroIdentificador)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmHistorialEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de eventos"
        CType(Me.grid_Eventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_NroIdentificador As System.Windows.Forms.Label
    Friend WithEvents txt_NroIdentificador As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Listar As System.Windows.Forms.Button
    Friend WithEvents grid_Eventos As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Volver As System.Windows.Forms.Button
End Class
