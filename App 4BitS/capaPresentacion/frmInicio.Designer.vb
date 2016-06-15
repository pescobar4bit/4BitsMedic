<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim ConditionValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.proceso01 = New System.ComponentModel.BackgroundWorker()
        Me.cmsConfigurarBDD = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MantenimientoBDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtServidor = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dvpValidar = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.picInicio = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmsConfigurarBDD.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsConfigurarBDD
        '
        Me.cmsConfigurarBDD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoBDDToolStripMenuItem})
        Me.cmsConfigurarBDD.Name = "cmsConfigurarBDD"
        Me.cmsConfigurarBDD.ShowCheckMargin = True
        Me.cmsConfigurarBDD.Size = New System.Drawing.Size(205, 26)
        '
        'MantenimientoBDDToolStripMenuItem
        '
        Me.MantenimientoBDDToolStripMenuItem.CheckOnClick = True
        Me.MantenimientoBDDToolStripMenuItem.Image = Global.namespace4BITS.My.Resources.Resources.database_down
        Me.MantenimientoBDDToolStripMenuItem.Name = "MantenimientoBDDToolStripMenuItem"
        Me.MantenimientoBDDToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.MantenimientoBDDToolStripMenuItem.Text = "Mantenimiento BDD"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtServidor)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtClave)
        Me.PanelControl1.Controls.Add(Me.txtUsuario)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(187, 13)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(316, 159)
        Me.PanelControl1.TabIndex = 0
        '
        'txtServidor
        '
        Me.txtServidor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txtServidor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtServidor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txtServidor.Location = New System.Drawing.Point(121, 94)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(155, 60)
        Me.txtServidor.TabIndex = 15
        Me.txtServidor.Text = "servidor"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(73, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Usuario:"
        '
        'txtClave
        '
        Me.txtClave.EnterMoveNextControl = True
        Me.txtClave.Location = New System.Drawing.Point(121, 68)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Properties.Appearance.Options.UseFont = True
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(157, 20)
        Me.txtClave.TabIndex = 1
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Valor no válido"
        Me.dvpValidar.SetValidationRule(Me.txtClave, ConditionValidationRule3)
        '
        'txtUsuario
        '
        Me.txtUsuario.EnterMoveNextControl = True
        Me.txtUsuario.Location = New System.Drawing.Point(121, 42)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(157, 20)
        Me.txtUsuario.TabIndex = 0
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Valor no válido"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtUsuario, ConditionValidationRule1)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(48, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Constraseña:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(69, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Servidor:"
        '
        'picInicio
        '
        Me.picInicio.EditValue = Global.namespace4BITS.My.Resources.Resources.farmalider01
        Me.picInicio.Location = New System.Drawing.Point(3, 2)
        Me.picInicio.Name = "picInicio"
        Me.picInicio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.picInicio.Properties.Appearance.Options.UseBackColor = True
        Me.picInicio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.picInicio.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.picInicio.Properties.ShowMenu = False
        Me.picInicio.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picInicio.Size = New System.Drawing.Size(183, 212)
        Me.picInicio.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.namespace4BITS.My.Resources.Resources.accept_vns1
        Me.SimpleButton1.Location = New System.Drawing.Point(214, 178)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Aceptar"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.namespace4BITS.My.Resources.Resources.delete_vns1
        Me.btnSalir.Location = New System.Drawing.Point(390, 178)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "&Salir"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 213)
        Me.ContextMenuStrip = Me.cmsConfigurarBDD
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.picInicio)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.cmsConfigurarBDD.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents picInicio As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents proceso01 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmsConfigurarBDD As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MantenimientoBDDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServidor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dvpValidar As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
