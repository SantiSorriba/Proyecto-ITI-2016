<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.menu_Principal = New System.Windows.Forms.MenuStrip()
        Me.menu_Archivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Ingresar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Establecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_AdmEstablecimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Produccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Animales = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_AdmAnimales = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Inventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_AdmLotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Ordenies = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Eventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_RegistrarEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_HistorialEventos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Parametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_Principal
        '
        Me.menu_Principal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.menu_Principal.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Archivo, Me.menu_Establecimientos, Me.menu_Animales, Me.menu_Eventos, Me.menu_Usuarios})
        Me.menu_Principal.Location = New System.Drawing.Point(0, 0)
        Me.menu_Principal.Name = "menu_Principal"
        Me.menu_Principal.Size = New System.Drawing.Size(1284, 24)
        Me.menu_Principal.TabIndex = 1
        Me.menu_Principal.Text = "MenuStrip1"
        '
        'menu_Archivo
        '
        Me.menu_Archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Ingresar, Me.menu_CerrarSesion, Me.menu_Salir})
        Me.menu_Archivo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.menu_Archivo.Name = "menu_Archivo"
        Me.menu_Archivo.Size = New System.Drawing.Size(59, 20)
        Me.menu_Archivo.Text = "Archivo"
        '
        'menu_Ingresar
        '
        Me.menu_Ingresar.Name = "menu_Ingresar"
        Me.menu_Ingresar.Size = New System.Drawing.Size(142, 22)
        Me.menu_Ingresar.Text = "Ingresar"
        '
        'menu_CerrarSesion
        '
        Me.menu_CerrarSesion.Name = "menu_CerrarSesion"
        Me.menu_CerrarSesion.Size = New System.Drawing.Size(142, 22)
        Me.menu_CerrarSesion.Text = "Cerrar Sesión"
        '
        'menu_Salir
        '
        Me.menu_Salir.Name = "menu_Salir"
        Me.menu_Salir.Size = New System.Drawing.Size(142, 22)
        Me.menu_Salir.Text = "Salir"
        '
        'menu_Establecimientos
        '
        Me.menu_Establecimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_AdmEstablecimientos, Me.menu_Parametros, Me.menu_Produccion})
        Me.menu_Establecimientos.Name = "menu_Establecimientos"
        Me.menu_Establecimientos.Size = New System.Drawing.Size(106, 20)
        Me.menu_Establecimientos.Text = "Establecimientos"
        '
        'menu_AdmEstablecimientos
        '
        Me.menu_AdmEstablecimientos.Name = "menu_AdmEstablecimientos"
        Me.menu_AdmEstablecimientos.Size = New System.Drawing.Size(225, 22)
        Me.menu_AdmEstablecimientos.Text = "Administrar establecimientos"
        '
        'menu_Produccion
        '
        Me.menu_Produccion.BackColor = System.Drawing.SystemColors.Control
        Me.menu_Produccion.Name = "menu_Produccion"
        Me.menu_Produccion.Size = New System.Drawing.Size(225, 22)
        Me.menu_Produccion.Text = "Consultar Producción"
        '
        'menu_Animales
        '
        Me.menu_Animales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_AdmAnimales, Me.menu_Inventario, Me.menu_AdmLotes, Me.menu_Ordenies})
        Me.menu_Animales.Name = "menu_Animales"
        Me.menu_Animales.Size = New System.Drawing.Size(67, 20)
        Me.menu_Animales.Text = "Animales"
        '
        'menu_AdmAnimales
        '
        Me.menu_AdmAnimales.Name = "menu_AdmAnimales"
        Me.menu_AdmAnimales.Size = New System.Drawing.Size(192, 22)
        Me.menu_AdmAnimales.Text = "Administrar animales"
        '
        'menu_Inventario
        '
        Me.menu_Inventario.Name = "menu_Inventario"
        Me.menu_Inventario.Size = New System.Drawing.Size(192, 22)
        Me.menu_Inventario.Text = "Inventario de animales"
        '
        'menu_AdmLotes
        '
        Me.menu_AdmLotes.Name = "menu_AdmLotes"
        Me.menu_AdmLotes.Size = New System.Drawing.Size(192, 22)
        Me.menu_AdmLotes.Text = "Administrar lotes"
        '
        'menu_Ordenies
        '
        Me.menu_Ordenies.Name = "menu_Ordenies"
        Me.menu_Ordenies.Size = New System.Drawing.Size(192, 22)
        Me.menu_Ordenies.Text = "Ordeñes"
        '
        'menu_Eventos
        '
        Me.menu_Eventos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_RegistrarEventos, Me.menu_HistorialEventos})
        Me.menu_Eventos.Name = "menu_Eventos"
        Me.menu_Eventos.Size = New System.Drawing.Size(60, 20)
        Me.menu_Eventos.Text = "Eventos"
        '
        'menu_RegistrarEventos
        '
        Me.menu_RegistrarEventos.Name = "menu_RegistrarEventos"
        Me.menu_RegistrarEventos.Size = New System.Drawing.Size(177, 22)
        Me.menu_RegistrarEventos.Text = "Registrar eventos"
        '
        'menu_HistorialEventos
        '
        Me.menu_HistorialEventos.Name = "menu_HistorialEventos"
        Me.menu_HistorialEventos.Size = New System.Drawing.Size(177, 22)
        Me.menu_HistorialEventos.Text = "Historial de eventos"
        '
        'menu_Usuarios
        '
        Me.menu_Usuarios.Name = "menu_Usuarios"
        Me.menu_Usuarios.Size = New System.Drawing.Size(64, 20)
        Me.menu_Usuarios.Text = "Usuarios"
        '
        'menu_Parametros
        '
        Me.menu_Parametros.Name = "menu_Parametros"
        Me.menu_Parametros.Size = New System.Drawing.Size(225, 22)
        Me.menu_Parametros.Text = "Administrar parámetros"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.SIGAT.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(1284, 662)
        Me.Controls.Add(Me.menu_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menu_Principal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGAT - Inicio"
        Me.menu_Principal.ResumeLayout(False)
        Me.menu_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu_Principal As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_Archivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Ingresar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_CerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Establecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Animales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Eventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_AdmEstablecimientos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Produccion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_AdmAnimales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Inventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_AdmLotes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Ordenies As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_RegistrarEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_HistorialEventos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_Parametros As System.Windows.Forms.ToolStripMenuItem

End Class
