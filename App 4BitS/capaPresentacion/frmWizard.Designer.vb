<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizard
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.wcConfigInicial = New DevExpress.XtraWizard.WizardControl
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage
        Me.wpConfigurar = New DevExpress.XtraWizard.WizardPage
        Me.lblConexion = New DevExpress.XtraEditors.LabelControl
        Me.pbConectar = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.btnConectar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtClave = New DevExpress.XtraEditors.TextEdit
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtBdd = New DevExpress.XtraEditors.TextEdit
        Me.txtSource = New DevExpress.XtraEditors.TextEdit
        Me.wpFinal = New DevExpress.XtraWizard.CompletionWizardPage
        Me.wpSeleccionEmpresa = New DevExpress.XtraWizard.WizardPage
        Me.lblClave = New DevExpress.XtraEditors.LabelControl
        Me.btnConectarEmpresa = New DevExpress.XtraEditors.SimpleButton
        Me.txtClaveEmpresa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.lueEmpresas = New DevExpress.XtraEditors.LookUpEdit
        Me.wpActivacion = New DevExpress.XtraWizard.WizardPage
        Me.btnActivacion = New DevExpress.XtraEditors.SimpleButton
        Me.txtActivacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.wbProceso01 = New System.ComponentModel.BackgroundWorker
        Me.dvpValidar = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.depError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.wcConfigInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wcConfigInicial.SuspendLayout()
        Me.wpConfigurar.SuspendLayout()
        CType(Me.pbConectar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBdd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wpSeleccionEmpresa.SuspendLayout()
        CType(Me.txtClaveEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wpActivacion.SuspendLayout()
        CType(Me.txtActivacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wcConfigInicial
        '
        Me.wcConfigInicial.Controls.Add(Me.WelcomeWizardPage1)
        Me.wcConfigInicial.Controls.Add(Me.wpConfigurar)
        Me.wcConfigInicial.Controls.Add(Me.wpFinal)
        Me.wcConfigInicial.Controls.Add(Me.wpSeleccionEmpresa)
        Me.wcConfigInicial.Controls.Add(Me.wpActivacion)
        Me.wcConfigInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wcConfigInicial.FinishText = "&Finalizar"
        Me.wcConfigInicial.Image = Global.namespace4BITS.My.Resources.Resources._6_8_large
        Me.wcConfigInicial.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.wcConfigInicial.Location = New System.Drawing.Point(0, 0)
        Me.wcConfigInicial.Name = "wcConfigInicial"
        Me.wcConfigInicial.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.wpConfigurar, Me.wpSeleccionEmpresa, Me.wpActivacion, Me.wpFinal})
        Me.wcConfigInicial.PreviousText = "< & Atras"
        Me.wcConfigInicial.Size = New System.Drawing.Size(562, 402)
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.IntroductionText = "Este módulo le ayudara a configurar el sistema para para que pueda acceder a la b" & _
            "ase de datos. Debe de seleccionar a que empresa se va a conectar e ingresar la c" & _
            "lave proporcionada."
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.ProceedText = "Para continuar, click en siguiente. "
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(345, 246)
        Me.WelcomeWizardPage1.Text = "Bienvenido a la configuración del sistema"
        '
        'wpConfigurar
        '
        Me.wpConfigurar.Controls.Add(Me.lblConexion)
        Me.wpConfigurar.Controls.Add(Me.pbConectar)
        Me.wpConfigurar.Controls.Add(Me.btnConectar)
        Me.wpConfigurar.Controls.Add(Me.LabelControl4)
        Me.wpConfigurar.Controls.Add(Me.txtClave)
        Me.wpConfigurar.Controls.Add(Me.txtUsuario)
        Me.wpConfigurar.Controls.Add(Me.LabelControl3)
        Me.wpConfigurar.Controls.Add(Me.LabelControl2)
        Me.wpConfigurar.Controls.Add(Me.LabelControl1)
        Me.wpConfigurar.Controls.Add(Me.txtBdd)
        Me.wpConfigurar.Controls.Add(Me.txtSource)
        Me.wpConfigurar.DescriptionText = "Para configurar la base de datos ingrese los datos que se le piden y presione con" & _
            "ectar."
        Me.wpConfigurar.Name = "wpConfigurar"
        Me.wpConfigurar.Size = New System.Drawing.Size(530, 257)
        Me.wpConfigurar.Text = "Conexión a base de datos"
        '
        'lblConexion
        '
        Me.lblConexion.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexion.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblConexion.Location = New System.Drawing.Point(211, 213)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(111, 19)
        Me.lblConexion.TabIndex = 10
        Me.lblConexion.Text = "Si hay conexión"
        Me.lblConexion.Visible = False
        '
        'pbConectar
        '
        Me.pbConectar.EditValue = 0
        Me.pbConectar.Location = New System.Drawing.Point(96, 213)
        Me.pbConectar.Name = "pbConectar"
        Me.pbConectar.Size = New System.Drawing.Size(304, 22)
        Me.pbConectar.TabIndex = 9
        Me.pbConectar.Visible = False
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(226, 170)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(109, 23)
        Me.btnConectar.TabIndex = 4
        Me.btnConectar.Text = "Probar conexión"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(147, 137)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Clave"
        '
        'txtClave
        '
        Me.txtClave.EditValue = "Vinns2012"
        Me.txtClave.EnterMoveNextControl = True
        Me.txtClave.Location = New System.Drawing.Point(194, 134)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(187, 20)
        Me.txtClave.TabIndex = 3
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Valor no válido"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtClave, ConditionValidationRule1)
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = "uvinns"
        Me.txtUsuario.EnterMoveNextControl = True
        Me.txtUsuario.Location = New System.Drawing.Point(194, 94)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(187, 20)
        Me.txtUsuario.TabIndex = 2
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Valor no válido"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtUsuario, ConditionValidationRule2)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(138, 97)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Usuario"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(51, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Nombre de base de datos"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(48, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Servidor de base de datos"
        '
        'txtBdd
        '
        Me.txtBdd.EditValue = "bdd_sistemasvinns"
        Me.txtBdd.EnterMoveNextControl = True
        Me.txtBdd.Location = New System.Drawing.Point(194, 58)
        Me.txtBdd.Name = "txtBdd"
        Me.txtBdd.Size = New System.Drawing.Size(188, 20)
        Me.txtBdd.TabIndex = 1
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Valor no válido"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtBdd, ConditionValidationRule3)
        '
        'txtSource
        '
        Me.txtSource.EditValue = "jasmine.arvixe.com"
        Me.txtSource.EnterMoveNextControl = True
        Me.txtSource.Location = New System.Drawing.Point(194, 19)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(188, 20)
        Me.txtSource.TabIndex = 0
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule4.ErrorText = "Valor no válido"
        ConditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtSource, ConditionValidationRule4)
        '
        'wpFinal
        '
        Me.wpFinal.FinishText = "Usted a completado la configuración a la base de datos para el programa. Vuelva a" & _
            " iniciar el programa para empezar a trabajar con el sistema, con la nueva config" & _
            "uración."
        Me.wpFinal.Name = "wpFinal"
        Me.wpFinal.ProceedText = "Para aplicar la configuración, click en Finalizar. Si no desea aplicar esta confi" & _
            "guración, click en Cancelar."
        Me.wpFinal.Size = New System.Drawing.Size(345, 269)
        Me.wpFinal.Text = "Configuración completada"
        '
        'wpSeleccionEmpresa
        '
        Me.wpSeleccionEmpresa.Controls.Add(Me.lblClave)
        Me.wpSeleccionEmpresa.Controls.Add(Me.btnConectarEmpresa)
        Me.wpSeleccionEmpresa.Controls.Add(Me.txtClaveEmpresa)
        Me.wpSeleccionEmpresa.Controls.Add(Me.LabelControl6)
        Me.wpSeleccionEmpresa.Controls.Add(Me.LabelControl5)
        Me.wpSeleccionEmpresa.Controls.Add(Me.lueEmpresas)
        Me.wpSeleccionEmpresa.DescriptionText = "Seleccione a que empresa desea conectarse e ingresa la clave para conectarse a es" & _
            "a empresa"
        Me.wpSeleccionEmpresa.Name = "wpSeleccionEmpresa"
        Me.wpSeleccionEmpresa.Size = New System.Drawing.Size(530, 257)
        Me.wpSeleccionEmpresa.Text = "Selección De Empresa "
        '
        'lblClave
        '
        Me.lblClave.Location = New System.Drawing.Point(349, 228)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(66, 13)
        Me.lblClave.TabIndex = 14
        Me.lblClave.Text = "LabelControl7"
        Me.lblClave.Visible = False
        '
        'btnConectarEmpresa
        '
        Me.btnConectarEmpresa.Location = New System.Drawing.Point(217, 175)
        Me.btnConectarEmpresa.Name = "btnConectarEmpresa"
        Me.btnConectarEmpresa.Size = New System.Drawing.Size(75, 23)
        Me.btnConectarEmpresa.TabIndex = 2
        Me.btnConectarEmpresa.Text = "Conectar"
        '
        'txtClaveEmpresa
        '
        Me.txtClaveEmpresa.EnterMoveNextControl = True
        Me.txtClaveEmpresa.Location = New System.Drawing.Point(76, 135)
        Me.txtClaveEmpresa.Name = "txtClaveEmpresa"
        Me.txtClaveEmpresa.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveEmpresa.Size = New System.Drawing.Size(370, 20)
        Me.txtClaveEmpresa.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(76, 116)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(216, 13)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "Ingrese la clave para ingresar a esa empresa"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(76, 33)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(207, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Seleccione a que empresa se va a conectar"
        '
        'lueEmpresas
        '
        Me.lueEmpresas.EnterMoveNextControl = True
        Me.lueEmpresas.Location = New System.Drawing.Point(76, 52)
        Me.lueEmpresas.Name = "lueEmpresas"
        Me.lueEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Volver a cargar", Nothing, Nothing, True)})
        Me.lueEmpresas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idEmpresa", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empresa", "Empresa"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clave", "Clave", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueEmpresas.Properties.DisplayMember = "empresa"
        Me.lueEmpresas.Properties.NullText = "[No hay empresas definidas]"
        Me.lueEmpresas.Properties.ValueMember = "idEmpresa"
        Me.lueEmpresas.Size = New System.Drawing.Size(370, 20)
        Me.lueEmpresas.TabIndex = 0
        '
        'wpActivacion
        '
        Me.wpActivacion.Controls.Add(Me.btnActivacion)
        Me.wpActivacion.Controls.Add(Me.txtActivacion)
        Me.wpActivacion.Controls.Add(Me.LabelControl7)
        Me.wpActivacion.DescriptionText = "Ingrese la clave de activación del sistema."
        Me.wpActivacion.Name = "wpActivacion"
        Me.wpActivacion.Size = New System.Drawing.Size(530, 257)
        Me.wpActivacion.Text = "Activación"
        '
        'btnActivacion
        '
        Me.btnActivacion.Location = New System.Drawing.Point(222, 136)
        Me.btnActivacion.Name = "btnActivacion"
        Me.btnActivacion.Size = New System.Drawing.Size(75, 23)
        Me.btnActivacion.TabIndex = 2
        Me.btnActivacion.Text = "Activar"
        '
        'txtActivacion
        '
        Me.txtActivacion.EnterMoveNextControl = True
        Me.txtActivacion.Location = New System.Drawing.Point(76, 91)
        Me.txtActivacion.Name = "txtActivacion"
        Me.txtActivacion.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtActivacion.Size = New System.Drawing.Size(398, 20)
        Me.txtActivacion.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(76, 58)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Clave de activación"
        '
        'wbProceso01
        '
        '
        'depError
        '
        Me.depError.ContainerControl = Me
        '
        'frmWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 402)
        Me.Controls.Add(Me.wcConfigInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmWizard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente"
        CType(Me.wcConfigInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wcConfigInicial.ResumeLayout(False)
        Me.wpConfigurar.ResumeLayout(False)
        Me.wpConfigurar.PerformLayout()
        CType(Me.pbConectar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBdd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wpSeleccionEmpresa.ResumeLayout(False)
        Me.wpSeleccionEmpresa.PerformLayout()
        CType(Me.txtClaveEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wpActivacion.ResumeLayout(False)
        Me.wpActivacion.PerformLayout()
        CType(Me.txtActivacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wcConfigInicial As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents wpConfigurar As DevExpress.XtraWizard.WizardPage
    Friend WithEvents wpFinal As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents btnConectar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBdd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pbConectar As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents wbProceso01 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtSource As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dvpValidar As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents lblConexion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents wpSeleccionEmpresa As DevExpress.XtraWizard.WizardPage
    Friend WithEvents btnConectarEmpresa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClaveEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueEmpresas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblClave As DevExpress.XtraEditors.LabelControl
    Friend WithEvents depError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents wpActivacion As DevExpress.XtraWizard.WizardPage
    Friend WithEvents btnActivacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtActivacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
