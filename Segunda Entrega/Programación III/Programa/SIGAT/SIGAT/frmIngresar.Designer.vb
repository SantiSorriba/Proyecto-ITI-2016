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
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Ingresar = New System.Windows.Forms.Button()
        Me.txt_Contrasenia = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Contrasenia = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancelar.Location = New System.Drawing.Point(154, 83)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(118, 27)
        Me.cmd_Cancelar.TabIndex = 4
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Ingresar
        '
        Me.cmd_Ingresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Ingresar.Image = CType(resources.GetObject("cmd_Ingresar.Image"), System.Drawing.Image)
        Me.cmd_Ingresar.Location = New System.Drawing.Point(12, 97)
        Me.cmd_Ingresar.Name = "cmd_Ingresar"
        Me.cmd_Ingresar.Size = New System.Drawing.Size(56, 52)
        Me.cmd_Ingresar.TabIndex = 3
        Me.cmd_Ingresar.UseVisualStyleBackColor = True
        '
        'txt_Contrasenia
        '
        Me.txt_Contrasenia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contrasenia.Location = New System.Drawing.Point(111, 45)
        Me.txt_Contrasenia.MaxLength = 15
        Me.txt_Contrasenia.Name = "txt_Contrasenia"
        Me.txt_Contrasenia.Size = New System.Drawing.Size(165, 22)
        Me.txt_Contrasenia.TabIndex = 2
        Me.txt_Contrasenia.UseSystemPasswordChar = True
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.Location = New System.Drawing.Point(111, 17)
        Me.txt_Usuario.MaxLength = 15
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(165, 22)
        Me.txt_Usuario.TabIndex = 1
        '
        'lbl_Contrasenia
        '
        Me.lbl_Contrasenia.AutoSize = True
        Me.lbl_Contrasenia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contrasenia.Location = New System.Drawing.Point(12, 49)
        Me.lbl_Contrasenia.Name = "lbl_Contrasenia"
        Me.lbl_Contrasenia.Size = New System.Drawing.Size(93, 18)
        Me.lbl_Contrasenia.TabIndex = 6
        Me.lbl_Contrasenia.Text = "Contraseña:"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(66, 18)
        Me.lbl_Usuario.TabIndex = 5
        Me.lbl_Usuario.Text = "Usuario:"
        '
        'frmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Ingresar)
        Me.Controls.Add(Me.txt_Contrasenia)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.lbl_Contrasenia)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.MaximizeBox = False
        Me.Name = "frmIngresar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ingresar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Ingresar As System.Windows.Forms.Button
    Friend WithEvents txt_Contrasenia As System.Windows.Forms.TextBox
    Friend WithEvents txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Contrasenia As System.Windows.Forms.Label
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
End Class
