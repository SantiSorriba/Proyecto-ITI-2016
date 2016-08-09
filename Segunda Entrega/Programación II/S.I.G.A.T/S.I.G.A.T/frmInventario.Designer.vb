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
        Me.lblEstablecimiento = New System.Windows.Forms.Label()
        Me.cboEstablecimiento = New System.Windows.Forms.ComboBox()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.gridAnimales = New System.Windows.Forms.DataGridView()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.cboLugar = New System.Windows.Forms.ComboBox()
        CType(Me.gridAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstablecimiento
        '
        Me.lblEstablecimiento.AutoSize = True
        Me.lblEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstablecimiento.Location = New System.Drawing.Point(12, 18)
        Me.lblEstablecimiento.Name = "lblEstablecimiento"
        Me.lblEstablecimiento.Size = New System.Drawing.Size(105, 16)
        Me.lblEstablecimiento.TabIndex = 0
        Me.lblEstablecimiento.Text = "Establecimiento:"
        '
        'cboEstablecimiento
        '
        Me.cboEstablecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstablecimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimiento.FormattingEnabled = True
        Me.cboEstablecimiento.Items.AddRange(New Object() {"Establecimiento Las Perdices", "Establecimiento Tala", "Establecimiento Los Juncales"})
        Me.cboEstablecimiento.Location = New System.Drawing.Point(123, 15)
        Me.cboEstablecimiento.MaxLength = 30
        Me.cboEstablecimiento.Name = "cboEstablecimiento"
        Me.cboEstablecimiento.Size = New System.Drawing.Size(256, 24)
        Me.cboEstablecimiento.TabIndex = 2
        '
        'cmdListar
        '
        Me.cmdListar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListar.Location = New System.Drawing.Point(307, 45)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(72, 25)
        Me.cmdListar.TabIndex = 3
        Me.cmdListar.Text = "Listar"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'gridAnimales
        '
        Me.gridAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAnimales.Location = New System.Drawing.Point(12, 83)
        Me.gridAnimales.Name = "gridAnimales"
        Me.gridAnimales.Size = New System.Drawing.Size(367, 242)
        Me.gridAnimales.TabIndex = 4
        Me.gridAnimales.Visible = False
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(264, 331)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(115, 23)
        Me.cmdVolver.TabIndex = 5
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(12, 49)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(44, 16)
        Me.lblLugar.TabIndex = 6
        Me.lblLugar.Text = "Lugar:"
        '
        'cboLugar
        '
        Me.cboLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLugar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.FormattingEnabled = True
        Me.cboLugar.Items.AddRange(New Object() {"Animales en el establecimiento", "Animales en el campo de recría"})
        Me.cboLugar.Location = New System.Drawing.Point(62, 45)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(237, 24)
        Me.cboLugar.TabIndex = 7
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(393, 362)
        Me.Controls.Add(Me.cboLugar)
        Me.Controls.Add(Me.lblLugar)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.gridAnimales)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.cboEstablecimiento)
        Me.Controls.Add(Me.lblEstablecimiento)
        Me.MaximizeBox = False
        Me.Name = "frmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Animales"
        CType(Me.gridAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents cboEstablecimiento As System.Windows.Forms.ComboBox
    Friend WithEvents cmdListar As System.Windows.Forms.Button
    Friend WithEvents gridAnimales As System.Windows.Forms.DataGridView
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents lblLugar As System.Windows.Forms.Label
    Friend WithEvents cboLugar As System.Windows.Forms.ComboBox
End Class
