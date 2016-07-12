<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarEstablecimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarEstablecimiento))
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.cboEstablecimientos = New System.Windows.Forms.ComboBox()
        Me.lblSeleccioneEstablecimiento = New System.Windows.Forms.Label()
        Me.groupDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.lblHectareas = New System.Windows.Forms.Label()
        Me.txtHectareas = New System.Windows.Forms.TextBox()
        Me.lblSuperficie = New System.Windows.Forms.Label()
        Me.txtTelefonoEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lblTelefonoEstablecimiento = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.txtNombreEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lblNombreEstablecimiento = New System.Windows.Forms.Label()
        Me.groupParametros = New System.Windows.Forms.GroupBox()
        Me.cmdModParametros = New System.Windows.Forms.Button()
        Me.txtPrimerShow = New System.Windows.Forms.TextBox()
        Me.txtHolando = New System.Windows.Forms.TextBox()
        Me.txtJersey = New System.Windows.Forms.TextBox()
        Me.chkPrimerShow = New System.Windows.Forms.CheckBox()
        Me.chkHolando = New System.Windows.Forms.CheckBox()
        Me.chkJersey = New System.Windows.Forms.CheckBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblRazas = New System.Windows.Forms.Label()
        Me.groupTercerOrdenie = New System.Windows.Forms.GroupBox()
        Me.txtFinTres2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFinTres1 = New System.Windows.Forms.TextBox()
        Me.txtInicioTres2 = New System.Windows.Forms.TextBox()
        Me.txtInicioTres1 = New System.Windows.Forms.TextBox()
        Me.lblFin3 = New System.Windows.Forms.Label()
        Me.lblInicio3 = New System.Windows.Forms.Label()
        Me.groupSegundoOrdenie = New System.Windows.Forms.GroupBox()
        Me.txtFinDos2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFinDos1 = New System.Windows.Forms.TextBox()
        Me.txtInicioDos2 = New System.Windows.Forms.TextBox()
        Me.txtInicioDos1 = New System.Windows.Forms.TextBox()
        Me.lblFin2 = New System.Windows.Forms.Label()
        Me.lblInicio2 = New System.Windows.Forms.Label()
        Me.groupPrimerOrdenie = New System.Windows.Forms.GroupBox()
        Me.txtFinUno2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSeparador = New System.Windows.Forms.Label()
        Me.txtFinUno1 = New System.Windows.Forms.TextBox()
        Me.txtInicioUno2 = New System.Windows.Forms.TextBox()
        Me.txtInicioUno1 = New System.Windows.Forms.TextBox()
        Me.lblFin1 = New System.Windows.Forms.Label()
        Me.lblInicio1 = New System.Windows.Forms.Label()
        Me.numOrdenies = New System.Windows.Forms.NumericUpDown()
        Me.lblCantOrdenies = New System.Windows.Forms.Label()
        Me.rdoManual = New System.Windows.Forms.RadioButton()
        Me.rdoMecanico = New System.Windows.Forms.RadioButton()
        Me.lblTipoOrdenie = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.groupDatosGenerales.SuspendLayout()
        Me.groupParametros.SuspendLayout()
        Me.groupTercerOrdenie.SuspendLayout()
        Me.groupSegundoOrdenie.SuspendLayout()
        Me.groupPrimerOrdenie.SuspendLayout()
        CType(Me.numOrdenies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 572
        Me.LineShape1.Y1 = 41
        Me.LineShape1.Y2 = 41
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(584, 432)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'cboEstablecimientos
        '
        Me.cboEstablecimientos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstablecimientos.FormattingEnabled = True
        Me.cboEstablecimientos.Location = New System.Drawing.Point(307, 9)
        Me.cboEstablecimientos.Name = "cboEstablecimientos"
        Me.cboEstablecimientos.Size = New System.Drawing.Size(270, 25)
        Me.cboEstablecimientos.TabIndex = 3
        '
        'lblSeleccioneEstablecimiento
        '
        Me.lblSeleccioneEstablecimiento.AutoSize = True
        Me.lblSeleccioneEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccioneEstablecimiento.Location = New System.Drawing.Point(8, 9)
        Me.lblSeleccioneEstablecimiento.Name = "lblSeleccioneEstablecimiento"
        Me.lblSeleccioneEstablecimiento.Size = New System.Drawing.Size(293, 22)
        Me.lblSeleccioneEstablecimiento.TabIndex = 2
        Me.lblSeleccioneEstablecimiento.Text = "Seleccione un establecimiento:"
        '
        'groupDatosGenerales
        '
        Me.groupDatosGenerales.Controls.Add(Me.lblHectareas)
        Me.groupDatosGenerales.Controls.Add(Me.txtHectareas)
        Me.groupDatosGenerales.Controls.Add(Me.lblSuperficie)
        Me.groupDatosGenerales.Controls.Add(Me.txtTelefonoEstablecimiento)
        Me.groupDatosGenerales.Controls.Add(Me.lblTelefonoEstablecimiento)
        Me.groupDatosGenerales.Controls.Add(Me.txtUbicacion)
        Me.groupDatosGenerales.Controls.Add(Me.lblUbicacion)
        Me.groupDatosGenerales.Controls.Add(Me.txtNombreEstablecimiento)
        Me.groupDatosGenerales.Controls.Add(Me.lblNombreEstablecimiento)
        Me.groupDatosGenerales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupDatosGenerales.Location = New System.Drawing.Point(8, 54)
        Me.groupDatosGenerales.Name = "groupDatosGenerales"
        Me.groupDatosGenerales.Size = New System.Drawing.Size(565, 121)
        Me.groupDatosGenerales.TabIndex = 7
        Me.groupDatosGenerales.TabStop = False
        Me.groupDatosGenerales.Text = "Datos Generales"
        '
        'lblHectareas
        '
        Me.lblHectareas.AutoSize = True
        Me.lblHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHectareas.Location = New System.Drawing.Point(479, 59)
        Me.lblHectareas.Name = "lblHectareas"
        Me.lblHectareas.Size = New System.Drawing.Size(82, 17)
        Me.lblHectareas.TabIndex = 20
        Me.lblHectareas.Text = "hectáreas"
        '
        'txtHectareas
        '
        Me.txtHectareas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHectareas.Location = New System.Drawing.Point(413, 56)
        Me.txtHectareas.Multiline = True
        Me.txtHectareas.Name = "txtHectareas"
        Me.txtHectareas.Size = New System.Drawing.Size(60, 20)
        Me.txtHectareas.TabIndex = 19
        '
        'lblSuperficie
        '
        Me.lblSuperficie.AutoSize = True
        Me.lblSuperficie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperficie.Location = New System.Drawing.Point(319, 56)
        Me.lblSuperficie.Name = "lblSuperficie"
        Me.lblSuperficie.Size = New System.Drawing.Size(88, 17)
        Me.lblSuperficie.TabIndex = 18
        Me.lblSuperficie.Text = "Superficie:"
        '
        'txtTelefonoEstablecimiento
        '
        Me.txtTelefonoEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoEstablecimiento.Location = New System.Drawing.Point(98, 87)
        Me.txtTelefonoEstablecimiento.Multiline = True
        Me.txtTelefonoEstablecimiento.Name = "txtTelefonoEstablecimiento"
        Me.txtTelefonoEstablecimiento.Size = New System.Drawing.Size(144, 20)
        Me.txtTelefonoEstablecimiento.TabIndex = 17
        '
        'lblTelefonoEstablecimiento
        '
        Me.lblTelefonoEstablecimiento.AutoSize = True
        Me.lblTelefonoEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEstablecimiento.Location = New System.Drawing.Point(6, 87)
        Me.lblTelefonoEstablecimiento.Name = "lblTelefonoEstablecimiento"
        Me.lblTelefonoEstablecimiento.Size = New System.Drawing.Size(76, 17)
        Me.lblTelefonoEstablecimiento.TabIndex = 16
        Me.lblTelefonoEstablecimiento.Text = "Teléfono:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(98, 55)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(215, 20)
        Me.txtUbicacion.TabIndex = 15
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(6, 58)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(86, 17)
        Me.lblUbicacion.TabIndex = 14
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'txtNombreEstablecimiento
        '
        Me.txtNombreEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEstablecimiento.Location = New System.Drawing.Point(228, 28)
        Me.txtNombreEstablecimiento.Multiline = True
        Me.txtNombreEstablecimiento.Name = "txtNombreEstablecimiento"
        Me.txtNombreEstablecimiento.Size = New System.Drawing.Size(321, 20)
        Me.txtNombreEstablecimiento.TabIndex = 4
        '
        'lblNombreEstablecimiento
        '
        Me.lblNombreEstablecimiento.AutoSize = True
        Me.lblNombreEstablecimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEstablecimiento.Location = New System.Drawing.Point(6, 31)
        Me.lblNombreEstablecimiento.Name = "lblNombreEstablecimiento"
        Me.lblNombreEstablecimiento.Size = New System.Drawing.Size(216, 17)
        Me.lblNombreEstablecimiento.TabIndex = 3
        Me.lblNombreEstablecimiento.Text = "Nombre del establecimiento:"
        '
        'groupParametros
        '
        Me.groupParametros.Controls.Add(Me.cmdModParametros)
        Me.groupParametros.Controls.Add(Me.txtPrimerShow)
        Me.groupParametros.Controls.Add(Me.txtHolando)
        Me.groupParametros.Controls.Add(Me.txtJersey)
        Me.groupParametros.Controls.Add(Me.chkPrimerShow)
        Me.groupParametros.Controls.Add(Me.chkHolando)
        Me.groupParametros.Controls.Add(Me.chkJersey)
        Me.groupParametros.Controls.Add(Me.lblCantidad)
        Me.groupParametros.Controls.Add(Me.lblRazas)
        Me.groupParametros.Controls.Add(Me.groupTercerOrdenie)
        Me.groupParametros.Controls.Add(Me.groupSegundoOrdenie)
        Me.groupParametros.Controls.Add(Me.groupPrimerOrdenie)
        Me.groupParametros.Controls.Add(Me.numOrdenies)
        Me.groupParametros.Controls.Add(Me.lblCantOrdenies)
        Me.groupParametros.Controls.Add(Me.rdoManual)
        Me.groupParametros.Controls.Add(Me.rdoMecanico)
        Me.groupParametros.Controls.Add(Me.lblTipoOrdenie)
        Me.groupParametros.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupParametros.Location = New System.Drawing.Point(8, 181)
        Me.groupParametros.Name = "groupParametros"
        Me.groupParametros.Size = New System.Drawing.Size(565, 214)
        Me.groupParametros.TabIndex = 8
        Me.groupParametros.TabStop = False
        Me.groupParametros.Text = "Parámetros"
        '
        'cmdModParametros
        '
        Me.cmdModParametros.Location = New System.Drawing.Point(9, 154)
        Me.cmdModParametros.Name = "cmdModParametros"
        Me.cmdModParametros.Size = New System.Drawing.Size(261, 43)
        Me.cmdModParametros.TabIndex = 36
        Me.cmdModParametros.Text = "Modificar los demas parámetros"
        Me.cmdModParametros.UseVisualStyleBackColor = True
        '
        'txtPrimerShow
        '
        Me.txtPrimerShow.Enabled = False
        Me.txtPrimerShow.Location = New System.Drawing.Point(453, 177)
        Me.txtPrimerShow.Multiline = True
        Me.txtPrimerShow.Name = "txtPrimerShow"
        Me.txtPrimerShow.Size = New System.Drawing.Size(56, 20)
        Me.txtPrimerShow.TabIndex = 35
        '
        'txtHolando
        '
        Me.txtHolando.Enabled = False
        Me.txtHolando.Location = New System.Drawing.Point(453, 151)
        Me.txtHolando.Multiline = True
        Me.txtHolando.Name = "txtHolando"
        Me.txtHolando.Size = New System.Drawing.Size(56, 20)
        Me.txtHolando.TabIndex = 34
        '
        'txtJersey
        '
        Me.txtJersey.Enabled = False
        Me.txtJersey.Location = New System.Drawing.Point(453, 125)
        Me.txtJersey.Multiline = True
        Me.txtJersey.Name = "txtJersey"
        Me.txtJersey.Size = New System.Drawing.Size(56, 20)
        Me.txtJersey.TabIndex = 33
        '
        'chkPrimerShow
        '
        Me.chkPrimerShow.AutoSize = True
        Me.chkPrimerShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrimerShow.Location = New System.Drawing.Point(283, 181)
        Me.chkPrimerShow.Name = "chkPrimerShow"
        Me.chkPrimerShow.Size = New System.Drawing.Size(110, 19)
        Me.chkPrimerShow.TabIndex = 32
        Me.chkPrimerShow.Text = "Primer Show"
        Me.chkPrimerShow.UseVisualStyleBackColor = True
        '
        'chkHolando
        '
        Me.chkHolando.AutoSize = True
        Me.chkHolando.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHolando.Location = New System.Drawing.Point(283, 154)
        Me.chkHolando.Name = "chkHolando"
        Me.chkHolando.Size = New System.Drawing.Size(80, 19)
        Me.chkHolando.TabIndex = 31
        Me.chkHolando.Text = "Holando"
        Me.chkHolando.UseVisualStyleBackColor = True
        '
        'chkJersey
        '
        Me.chkJersey.AutoSize = True
        Me.chkJersey.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJersey.Location = New System.Drawing.Point(283, 127)
        Me.chkJersey.Name = "chkJersey"
        Me.chkJersey.Size = New System.Drawing.Size(69, 19)
        Me.chkJersey.TabIndex = 30
        Me.chkJersey.Text = "Jersey"
        Me.chkJersey.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(440, 105)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(80, 18)
        Me.lblCantidad.TabIndex = 11
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblRazas
        '
        Me.lblRazas.AutoSize = True
        Me.lblRazas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazas.Location = New System.Drawing.Point(296, 105)
        Me.lblRazas.Name = "lblRazas"
        Me.lblRazas.Size = New System.Drawing.Size(57, 18)
        Me.lblRazas.TabIndex = 10
        Me.lblRazas.Text = "Razas"
        '
        'groupTercerOrdenie
        '
        Me.groupTercerOrdenie.Controls.Add(Me.txtFinTres2)
        Me.groupTercerOrdenie.Controls.Add(Me.Label7)
        Me.groupTercerOrdenie.Controls.Add(Me.Label8)
        Me.groupTercerOrdenie.Controls.Add(Me.txtFinTres1)
        Me.groupTercerOrdenie.Controls.Add(Me.txtInicioTres2)
        Me.groupTercerOrdenie.Controls.Add(Me.txtInicioTres1)
        Me.groupTercerOrdenie.Controls.Add(Me.lblFin3)
        Me.groupTercerOrdenie.Controls.Add(Me.lblInicio3)
        Me.groupTercerOrdenie.Location = New System.Drawing.Point(9, 105)
        Me.groupTercerOrdenie.Name = "groupTercerOrdenie"
        Me.groupTercerOrdenie.Size = New System.Drawing.Size(261, 43)
        Me.groupTercerOrdenie.TabIndex = 9
        Me.groupTercerOrdenie.TabStop = False
        Me.groupTercerOrdenie.Text = "3er Ordeñe"
        '
        'txtFinTres2
        '
        Me.txtFinTres2.Location = New System.Drawing.Point(219, 16)
        Me.txtFinTres2.Multiline = True
        Me.txtFinTres2.Name = "txtFinTres2"
        Me.txtFinTres2.Size = New System.Drawing.Size(25, 20)
        Me.txtFinTres2.TabIndex = 10
        Me.txtFinTres2.Text = "00"
        Me.txtFinTres2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ":"
        '
        'txtFinTres1
        '
        Me.txtFinTres1.Location = New System.Drawing.Point(177, 16)
        Me.txtFinTres1.Multiline = True
        Me.txtFinTres1.Name = "txtFinTres1"
        Me.txtFinTres1.Size = New System.Drawing.Size(25, 20)
        Me.txtFinTres1.TabIndex = 9
        Me.txtFinTres1.Text = "00"
        Me.txtFinTres1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInicioTres2
        '
        Me.txtInicioTres2.Location = New System.Drawing.Point(100, 17)
        Me.txtInicioTres2.Multiline = True
        Me.txtInicioTres2.Name = "txtInicioTres2"
        Me.txtInicioTres2.Size = New System.Drawing.Size(25, 20)
        Me.txtInicioTres2.TabIndex = 9
        Me.txtInicioTres2.Text = "00"
        Me.txtInicioTres2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInicioTres1
        '
        Me.txtInicioTres1.Location = New System.Drawing.Point(59, 17)
        Me.txtInicioTres1.Multiline = True
        Me.txtInicioTres1.Name = "txtInicioTres1"
        Me.txtInicioTres1.Size = New System.Drawing.Size(25, 20)
        Me.txtInicioTres1.TabIndex = 8
        Me.txtInicioTres1.Text = "00"
        Me.txtInicioTres1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFin3
        '
        Me.lblFin3.AutoSize = True
        Me.lblFin3.Location = New System.Drawing.Point(140, 19)
        Me.lblFin3.Name = "lblFin3"
        Me.lblFin3.Size = New System.Drawing.Size(31, 15)
        Me.lblFin3.TabIndex = 8
        Me.lblFin3.Text = "Fin:"
        '
        'lblInicio3
        '
        Me.lblInicio3.AutoSize = True
        Me.lblInicio3.Location = New System.Drawing.Point(6, 19)
        Me.lblInicio3.Name = "lblInicio3"
        Me.lblInicio3.Size = New System.Drawing.Size(47, 15)
        Me.lblInicio3.TabIndex = 8
        Me.lblInicio3.Text = "Inicio:"
        '
        'groupSegundoOrdenie
        '
        Me.groupSegundoOrdenie.Controls.Add(Me.txtFinDos2)
        Me.groupSegundoOrdenie.Controls.Add(Me.Label3)
        Me.groupSegundoOrdenie.Controls.Add(Me.Label4)
        Me.groupSegundoOrdenie.Controls.Add(Me.txtFinDos1)
        Me.groupSegundoOrdenie.Controls.Add(Me.txtInicioDos2)
        Me.groupSegundoOrdenie.Controls.Add(Me.txtInicioDos1)
        Me.groupSegundoOrdenie.Controls.Add(Me.lblFin2)
        Me.groupSegundoOrdenie.Controls.Add(Me.lblInicio2)
        Me.groupSegundoOrdenie.Location = New System.Drawing.Point(276, 56)
        Me.groupSegundoOrdenie.Name = "groupSegundoOrdenie"
        Me.groupSegundoOrdenie.Size = New System.Drawing.Size(261, 43)
        Me.groupSegundoOrdenie.TabIndex = 8
        Me.groupSegundoOrdenie.TabStop = False
        Me.groupSegundoOrdenie.Text = "2do Ordeñe"
        '
        'txtFinDos2
        '
        Me.txtFinDos2.Location = New System.Drawing.Point(219, 16)
        Me.txtFinDos2.Multiline = True
        Me.txtFinDos2.Name = "txtFinDos2"
        Me.txtFinDos2.Size = New System.Drawing.Size(25, 20)
        Me.txtFinDos2.TabIndex = 10
        Me.txtFinDos2.Text = "00"
        Me.txtFinDos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = ":"
        '
        'txtFinDos1
        '
        Me.txtFinDos1.Location = New System.Drawing.Point(177, 16)
        Me.txtFinDos1.Multiline = True
        Me.txtFinDos1.Name = "txtFinDos1"
        Me.txtFinDos1.Size = New System.Drawing.Size(25, 20)
        Me.txtFinDos1.TabIndex = 9
        Me.txtFinDos1.Text = "00"
        Me.txtFinDos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInicioDos2
        '
        Me.txtInicioDos2.Location = New System.Drawing.Point(100, 17)
        Me.txtInicioDos2.Multiline = True
        Me.txtInicioDos2.Name = "txtInicioDos2"
        Me.txtInicioDos2.Size = New System.Drawing.Size(25, 20)
        Me.txtInicioDos2.TabIndex = 9
        Me.txtInicioDos2.Text = "00"
        Me.txtInicioDos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInicioDos1
        '
        Me.txtInicioDos1.Location = New System.Drawing.Point(59, 17)
        Me.txtInicioDos1.Multiline = True
        Me.txtInicioDos1.Name = "txtInicioDos1"
        Me.txtInicioDos1.Size = New System.Drawing.Size(25, 20)
        Me.txtInicioDos1.TabIndex = 8
        Me.txtInicioDos1.Text = "00"
        Me.txtInicioDos1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFin2
        '
        Me.lblFin2.AutoSize = True
        Me.lblFin2.Location = New System.Drawing.Point(140, 19)
        Me.lblFin2.Name = "lblFin2"
        Me.lblFin2.Size = New System.Drawing.Size(31, 15)
        Me.lblFin2.TabIndex = 8
        Me.lblFin2.Text = "Fin:"
        '
        'lblInicio2
        '
        Me.lblInicio2.AutoSize = True
        Me.lblInicio2.Location = New System.Drawing.Point(6, 19)
        Me.lblInicio2.Name = "lblInicio2"
        Me.lblInicio2.Size = New System.Drawing.Size(47, 15)
        Me.lblInicio2.TabIndex = 8
        Me.lblInicio2.Text = "Inicio:"
        '
        'groupPrimerOrdenie
        '
        Me.groupPrimerOrdenie.Controls.Add(Me.txtFinUno2)
        Me.groupPrimerOrdenie.Controls.Add(Me.Label2)
        Me.groupPrimerOrdenie.Controls.Add(Me.lblSeparador)
        Me.groupPrimerOrdenie.Controls.Add(Me.txtFinUno1)
        Me.groupPrimerOrdenie.Controls.Add(Me.txtInicioUno2)
        Me.groupPrimerOrdenie.Controls.Add(Me.txtInicioUno1)
        Me.groupPrimerOrdenie.Controls.Add(Me.lblFin1)
        Me.groupPrimerOrdenie.Controls.Add(Me.lblInicio1)
        Me.groupPrimerOrdenie.Location = New System.Drawing.Point(9, 56)
        Me.groupPrimerOrdenie.Name = "groupPrimerOrdenie"
        Me.groupPrimerOrdenie.Size = New System.Drawing.Size(261, 43)
        Me.groupPrimerOrdenie.TabIndex = 5
        Me.groupPrimerOrdenie.TabStop = False
        Me.groupPrimerOrdenie.Text = "1er Ordeñe"
        '
        'txtFinUno2
        '
        Me.txtFinUno2.Location = New System.Drawing.Point(219, 16)
        Me.txtFinUno2.Multiline = True
        Me.txtFinUno2.Name = "txtFinUno2"
        Me.txtFinUno2.Size = New System.Drawing.Size(25, 20)
        Me.txtFinUno2.TabIndex = 10
        Me.txtFinUno2.Text = "00"
        Me.txtFinUno2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = ":"
        '
        'lblSeparador
        '
        Me.lblSeparador.AutoSize = True
        Me.lblSeparador.Location = New System.Drawing.Point(86, 20)
        Me.lblSeparador.Name = "lblSeparador"
        Me.lblSeparador.Size = New System.Drawing.Size(11, 15)
        Me.lblSeparador.TabIndex = 8
        Me.lblSeparador.Text = ":"
        '
        'txtFinUno1
        '
        Me.txtFinUno1.Location = New System.Drawing.Point(177, 16)
        Me.txtFinUno1.Multiline = True
        Me.txtFinUno1.Name = "txtFinUno1"
        Me.txtFinUno1.Size = New System.Drawing.Size(25, 20)
        Me.txtFinUno1.TabIndex = 9
        Me.txtFinUno1.Text = "00"
        Me.txtFinUno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInicioUno2
        '
        Me.txtInicioUno2.Location = New System.Drawing.Point(100, 17)
        Me.txtInicioUno2.Multiline = True
        Me.txtInicioUno2.Name = "txtInicioUno2"
        Me.txtInicioUno2.Size = New System.Drawing.Size(25, 20)
        Me.txtInicioUno2.TabIndex = 9
        Me.txtInicioUno2.Text = "00"
        Me.txtInicioUno2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInicioUno1
        '
        Me.txtInicioUno1.Location = New System.Drawing.Point(59, 17)
        Me.txtInicioUno1.Multiline = True
        Me.txtInicioUno1.Name = "txtInicioUno1"
        Me.txtInicioUno1.Size = New System.Drawing.Size(25, 20)
        Me.txtInicioUno1.TabIndex = 8
        Me.txtInicioUno1.Text = "00"
        Me.txtInicioUno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFin1
        '
        Me.lblFin1.AutoSize = True
        Me.lblFin1.Location = New System.Drawing.Point(140, 19)
        Me.lblFin1.Name = "lblFin1"
        Me.lblFin1.Size = New System.Drawing.Size(31, 15)
        Me.lblFin1.TabIndex = 8
        Me.lblFin1.Text = "Fin:"
        '
        'lblInicio1
        '
        Me.lblInicio1.AutoSize = True
        Me.lblInicio1.Location = New System.Drawing.Point(6, 19)
        Me.lblInicio1.Name = "lblInicio1"
        Me.lblInicio1.Size = New System.Drawing.Size(47, 15)
        Me.lblInicio1.TabIndex = 8
        Me.lblInicio1.Text = "Inicio:"
        '
        'numOrdenies
        '
        Me.numOrdenies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numOrdenies.Location = New System.Drawing.Point(498, 29)
        Me.numOrdenies.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numOrdenies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numOrdenies.Name = "numOrdenies"
        Me.numOrdenies.Size = New System.Drawing.Size(31, 23)
        Me.numOrdenies.TabIndex = 4
        Me.numOrdenies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCantOrdenies
        '
        Me.lblCantOrdenies.AutoSize = True
        Me.lblCantOrdenies.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantOrdenies.Location = New System.Drawing.Point(296, 33)
        Me.lblCantOrdenies.Name = "lblCantOrdenies"
        Me.lblCantOrdenies.Size = New System.Drawing.Size(196, 15)
        Me.lblCantOrdenies.TabIndex = 3
        Me.lblCantOrdenies.Text = "Cantidad de ordeñes diarios: "
        '
        'rdoManual
        '
        Me.rdoManual.AutoSize = True
        Me.rdoManual.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoManual.Location = New System.Drawing.Point(213, 31)
        Me.rdoManual.Name = "rdoManual"
        Me.rdoManual.Size = New System.Drawing.Size(72, 19)
        Me.rdoManual.TabIndex = 2
        Me.rdoManual.TabStop = True
        Me.rdoManual.Text = "Manual"
        Me.rdoManual.UseVisualStyleBackColor = True
        '
        'rdoMecanico
        '
        Me.rdoMecanico.AutoSize = True
        Me.rdoMecanico.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMecanico.Location = New System.Drawing.Point(119, 31)
        Me.rdoMecanico.Name = "rdoMecanico"
        Me.rdoMecanico.Size = New System.Drawing.Size(88, 19)
        Me.rdoMecanico.TabIndex = 1
        Me.rdoMecanico.TabStop = True
        Me.rdoMecanico.Text = "Mecánico"
        Me.rdoMecanico.UseVisualStyleBackColor = True
        '
        'lblTipoOrdenie
        '
        Me.lblTipoOrdenie.AutoSize = True
        Me.lblTipoOrdenie.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoOrdenie.Location = New System.Drawing.Point(6, 33)
        Me.lblTipoOrdenie.Name = "lblTipoOrdenie"
        Me.lblTipoOrdenie.Size = New System.Drawing.Size(107, 15)
        Me.lblTipoOrdenie.TabIndex = 0
        Me.lblTipoOrdenie.Text = "Tipo de ordeñe:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(473, 401)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 23)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(367, 401)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(100, 23)
        Me.cmdGuardar.TabIndex = 10
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'frmModificarEstablecimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(584, 432)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.groupParametros)
        Me.Controls.Add(Me.groupDatosGenerales)
        Me.Controls.Add(Me.cboEstablecimientos)
        Me.Controls.Add(Me.lblSeleccioneEstablecimiento)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmModificarEstablecimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.G.A.T - Modificar Establecimiento"
        Me.groupDatosGenerales.ResumeLayout(False)
        Me.groupDatosGenerales.PerformLayout()
        Me.groupParametros.ResumeLayout(False)
        Me.groupParametros.PerformLayout()
        Me.groupTercerOrdenie.ResumeLayout(False)
        Me.groupTercerOrdenie.PerformLayout()
        Me.groupSegundoOrdenie.ResumeLayout(False)
        Me.groupSegundoOrdenie.PerformLayout()
        Me.groupPrimerOrdenie.ResumeLayout(False)
        Me.groupPrimerOrdenie.PerformLayout()
        CType(Me.numOrdenies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents cboEstablecimientos As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccioneEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents groupDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefonoEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents lblHectareas As System.Windows.Forms.Label
    Friend WithEvents txtHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblSuperficie As System.Windows.Forms.Label
    Friend WithEvents groupParametros As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblRazas As System.Windows.Forms.Label
    Friend WithEvents groupTercerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents txtFinTres2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFinTres1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioTres2 As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioTres1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFin3 As System.Windows.Forms.Label
    Friend WithEvents lblInicio3 As System.Windows.Forms.Label
    Friend WithEvents groupSegundoOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents txtFinDos2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFinDos1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioDos2 As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioDos1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFin2 As System.Windows.Forms.Label
    Friend WithEvents lblInicio2 As System.Windows.Forms.Label
    Friend WithEvents groupPrimerOrdenie As System.Windows.Forms.GroupBox
    Friend WithEvents txtFinUno2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSeparador As System.Windows.Forms.Label
    Friend WithEvents txtFinUno1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioUno2 As System.Windows.Forms.TextBox
    Friend WithEvents txtInicioUno1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFin1 As System.Windows.Forms.Label
    Friend WithEvents lblInicio1 As System.Windows.Forms.Label
    Friend WithEvents numOrdenies As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCantOrdenies As System.Windows.Forms.Label
    Friend WithEvents rdoManual As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMecanico As System.Windows.Forms.RadioButton
    Friend WithEvents lblTipoOrdenie As System.Windows.Forms.Label
    Friend WithEvents txtPrimerShow As System.Windows.Forms.TextBox
    Friend WithEvents txtHolando As System.Windows.Forms.TextBox
    Friend WithEvents txtJersey As System.Windows.Forms.TextBox
    Friend WithEvents chkPrimerShow As System.Windows.Forms.CheckBox
    Friend WithEvents chkHolando As System.Windows.Forms.CheckBox
    Friend WithEvents chkJersey As System.Windows.Forms.CheckBox
    Friend WithEvents cmdModParametros As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
End Class
