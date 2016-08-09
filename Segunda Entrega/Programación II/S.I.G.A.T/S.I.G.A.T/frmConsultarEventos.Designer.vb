<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarEventos
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
        Me.lblNroAnimal = New System.Windows.Forms.Label()
        Me.txtNroAnimal = New System.Windows.Forms.TextBox()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.gridEventos = New System.Windows.Forms.DataGridView()
        Me.cmdVolver = New System.Windows.Forms.Button()
        CType(Me.gridEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNroAnimal
        '
        Me.lblNroAnimal.AutoSize = True
        Me.lblNroAnimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroAnimal.Location = New System.Drawing.Point(12, 9)
        Me.lblNroAnimal.Name = "lblNroAnimal"
        Me.lblNroAnimal.Size = New System.Drawing.Size(117, 16)
        Me.lblNroAnimal.TabIndex = 0
        Me.lblNroAnimal.Text = "Número de animal:"
        '
        'txtNroAnimal
        '
        Me.txtNroAnimal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroAnimal.Location = New System.Drawing.Point(138, 6)
        Me.txtNroAnimal.Name = "txtNroAnimal"
        Me.txtNroAnimal.Size = New System.Drawing.Size(55, 22)
        Me.txtNroAnimal.TabIndex = 1
        '
        'cmdListar
        '
        Me.cmdListar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListar.Location = New System.Drawing.Point(201, 4)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(84, 26)
        Me.cmdListar.TabIndex = 2
        Me.cmdListar.Text = "Listar eventos"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'gridEventos
        '
        Me.gridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEventos.Location = New System.Drawing.Point(12, 36)
        Me.gridEventos.Name = "gridEventos"
        Me.gridEventos.Size = New System.Drawing.Size(273, 199)
        Me.gridEventos.TabIndex = 3
        Me.gridEventos.Visible = False
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(215, 241)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(70, 27)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmConsultarEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(294, 272)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.gridEventos)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.txtNroAnimal)
        Me.Controls.Add(Me.lblNroAnimal)
        Me.Name = "frmConsultarEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar eventos"
        CType(Me.gridEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNroAnimal As System.Windows.Forms.Label
    Friend WithEvents txtNroAnimal As System.Windows.Forms.TextBox
    Friend WithEvents cmdListar As System.Windows.Forms.Button
    Friend WithEvents gridEventos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
