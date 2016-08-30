<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.group_Acceso = New System.Windows.Forms.GroupBox()
        Me.txt_Contrasenia = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Contrasenia = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.img_Login = New System.Windows.Forms.PictureBox()
        Me.cmd_Ingresar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.group_Acceso.SuspendLayout()
        CType(Me.img_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'group_Acceso
        '
        Me.group_Acceso.Controls.Add(Me.txt_Contrasenia)
        Me.group_Acceso.Controls.Add(Me.txt_Usuario)
        Me.group_Acceso.Controls.Add(Me.lbl_Contrasenia)
        Me.group_Acceso.Controls.Add(Me.lbl_Usuario)
        Me.group_Acceso.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_Acceso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.group_Acceso.Location = New System.Drawing.Point(170, 12)
        Me.group_Acceso.Name = "group_Acceso"
        Me.group_Acceso.Size = New System.Drawing.Size(236, 145)
        Me.group_Acceso.TabIndex = 0
        Me.group_Acceso.TabStop = False
        Me.group_Acceso.Text = "Acceso al Sistema"
        '
        'txt_Contrasenia
        '
        Me.txt_Contrasenia.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contrasenia.Location = New System.Drawing.Point(10, 105)
        Me.txt_Contrasenia.Name = "txt_Contrasenia"
        Me.txt_Contrasenia.Size = New System.Drawing.Size(199, 24)
        Me.txt_Contrasenia.TabIndex = 3
        Me.txt_Contrasenia.UseSystemPasswordChar = True
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usuario.Location = New System.Drawing.Point(9, 51)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(199, 24)
        Me.txt_Usuario.TabIndex = 2
        '
        'lbl_Contrasenia
        '
        Me.lbl_Contrasenia.AutoSize = True
        Me.lbl_Contrasenia.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contrasenia.Location = New System.Drawing.Point(6, 83)
        Me.lbl_Contrasenia.Name = "lbl_Contrasenia"
        Me.lbl_Contrasenia.Size = New System.Drawing.Size(88, 19)
        Me.lbl_Contrasenia.TabIndex = 1
        Me.lbl_Contrasenia.Text = "Contraseña"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(6, 31)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(63, 19)
        Me.lbl_Usuario.TabIndex = 0
        Me.lbl_Usuario.Text = "Usuario"
        '
        'img_Login
        '
        Me.img_Login.Image = Global.SIGAT.My.Resources.Resources.login
        Me.img_Login.Location = New System.Drawing.Point(12, 12)
        Me.img_Login.Name = "img_Login"
        Me.img_Login.Size = New System.Drawing.Size(152, 191)
        Me.img_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_Login.TabIndex = 1
        Me.img_Login.TabStop = False
        '
        'cmd_Ingresar
        '
        Me.cmd_Ingresar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Ingresar.Location = New System.Drawing.Point(170, 163)
        Me.cmd_Ingresar.Name = "cmd_Ingresar"
        Me.cmd_Ingresar.Size = New System.Drawing.Size(112, 40)
        Me.cmd_Ingresar.TabIndex = 2
        Me.cmd_Ingresar.Text = "Ingresar"
        Me.cmd_Ingresar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancelar.Location = New System.Drawing.Point(294, 163)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(112, 40)
        Me.cmd_Cancelar.TabIndex = 3
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(417, 215)
        Me.Controls.Add(Me.cmd_Cancelar)
        Me.Controls.Add(Me.cmd_Ingresar)
        Me.Controls.Add(Me.img_Login)
        Me.Controls.Add(Me.group_Acceso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Login"
        Me.group_Acceso.ResumeLayout(False)
        Me.group_Acceso.PerformLayout()
        CType(Me.img_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents group_Acceso As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Contrasenia As System.Windows.Forms.TextBox
    Friend WithEvents txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Contrasenia As System.Windows.Forms.Label
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents img_Login As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_Ingresar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
End Class
