<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresar
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 24)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(66, 18)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(12, 57)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(93, 18)
        Me.lblContrasenia.TabIndex = 1
        Me.lblContrasenia.Text = "Contraseña:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(107, 21)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(165, 26)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(107, 53)
        Me.txtContrasenia.MaxLength = 15
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(165, 26)
        Me.txtContrasenia.TabIndex = 3
        Me.txtContrasenia.UseSystemPasswordChar = True
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Location = New System.Drawing.Point(12, 95)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(118, 27)
        Me.cmdIngresar.TabIndex = 4
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(154, 95)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 27)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 130)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblUsuario)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmIngresar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "S.I.G.A.T - Ingresar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
