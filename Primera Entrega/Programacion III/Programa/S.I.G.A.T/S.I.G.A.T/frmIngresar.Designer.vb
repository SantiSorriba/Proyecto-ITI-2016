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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresar))
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(271, 32)
        Me.lblNombreUsuario.TabIndex = 0
        Me.lblNombreUsuario.Text = "Nombre de Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(12, 44)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(258, 24)
        Me.txtUsuario.TabIndex = 1
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenia.Location = New System.Drawing.Point(60, 71)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(168, 32)
        Me.lblContrasenia.TabIndex = 2
        Me.lblContrasenia.Text = "Contraseña"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(12, 106)
        Me.txtContrasenia.MaxLength = 15
        Me.txtContrasenia.Multiline = True
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(258, 24)
        Me.txtContrasenia.TabIndex = 3
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresar.Location = New System.Drawing.Point(12, 148)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(128, 44)
        Me.cmdIngresar.TabIndex = 4
        Me.cmdIngresar.Text = "Ingresar"
        Me.cmdIngresar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(142, 148)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(128, 44)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(284, 212)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmIngresar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "S.I.G.A.T - Ingresar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
