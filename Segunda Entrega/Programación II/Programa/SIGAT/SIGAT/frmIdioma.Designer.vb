<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdioma
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
        Me.lbl_Idioma = New System.Windows.Forms.Label()
        Me.rdo_Ingles = New System.Windows.Forms.RadioButton()
        Me.rdo_Espaniol = New System.Windows.Forms.RadioButton()
        Me.cmd_Seleccionar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Idioma
        '
        Me.lbl_Idioma.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Idioma.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Idioma.Name = "lbl_Idioma"
        Me.lbl_Idioma.Size = New System.Drawing.Size(157, 33)
        Me.lbl_Idioma.TabIndex = 0
        Me.lbl_Idioma.Text = "Idioma"
        Me.lbl_Idioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdo_Ingles
        '
        Me.rdo_Ingles.AutoSize = True
        Me.rdo_Ingles.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Ingles.Location = New System.Drawing.Point(46, 92)
        Me.rdo_Ingles.Name = "rdo_Ingles"
        Me.rdo_Ingles.Size = New System.Drawing.Size(66, 22)
        Me.rdo_Ingles.TabIndex = 4
        Me.rdo_Ingles.Text = "Ingles"
        Me.rdo_Ingles.UseVisualStyleBackColor = True
        '
        'rdo_Espaniol
        '
        Me.rdo_Espaniol.AutoSize = True
        Me.rdo_Espaniol.Checked = True
        Me.rdo_Espaniol.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Espaniol.Location = New System.Drawing.Point(46, 59)
        Me.rdo_Espaniol.Name = "rdo_Espaniol"
        Me.rdo_Espaniol.Size = New System.Drawing.Size(83, 22)
        Me.rdo_Espaniol.TabIndex = 3
        Me.rdo_Espaniol.TabStop = True
        Me.rdo_Espaniol.Text = "Español"
        Me.rdo_Espaniol.UseVisualStyleBackColor = True
        '
        'cmd_Seleccionar
        '
        Me.cmd_Seleccionar.Location = New System.Drawing.Point(12, 132)
        Me.cmd_Seleccionar.Name = "cmd_Seleccionar"
        Me.cmd_Seleccionar.Size = New System.Drawing.Size(157, 23)
        Me.cmd_Seleccionar.TabIndex = 5
        Me.cmd_Seleccionar.Text = "Seleccionar Idioma"
        Me.cmd_Seleccionar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(12, 161)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(157, 23)
        Me.cmd_Cancelar.TabIndex = 6
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'frmIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(181, 191)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Seleccionar)
        Me.Controls.Add(Me.rdo_Ingles)
        Me.Controls.Add(Me.rdo_Espaniol)
        Me.Controls.Add(Me.lbl_Idioma)
        Me.MaximizeBox = False
        Me.Name = "frmIdioma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Idioma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Idioma As System.Windows.Forms.Label
    Friend WithEvents rdo_Ingles As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Espaniol As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
End Class
