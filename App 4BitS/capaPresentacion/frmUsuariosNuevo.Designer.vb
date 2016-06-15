<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosNuevo
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
        Dim CompareAgainstControlValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule
        Me.picFoto = New DevExpress.XtraEditors.PictureEdit
        Me.cmsFoto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TomarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SinFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit
        Me.txtClave = New DevExpress.XtraEditors.TextEdit
        Me.txtClave2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.dvpValidar = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.ckHabilitado = New DevExpress.XtraEditors.CheckEdit
        Me.lueUsuario = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.depError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.picFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFoto.SuspendLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckHabilitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(12, 24)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Properties.ContextMenuStrip = Me.cmsFoto
        Me.picFoto.Properties.ShowMenu = False
        Me.picFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.picFoto.Size = New System.Drawing.Size(111, 135)
        Me.picFoto.TabIndex = 0
        '
        'cmsFoto
        '
        Me.cmsFoto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TomarFotoToolStripMenuItem, Me.CargarFotoToolStripMenuItem, Me.SinFotoToolStripMenuItem})
        Me.cmsFoto.Name = "cmsFoto"
        Me.cmsFoto.Size = New System.Drawing.Size(135, 70)
        '
        'TomarFotoToolStripMenuItem
        '
        Me.TomarFotoToolStripMenuItem.Image = Global.namespace4BITS.My.Resources.Resources.web_camera
        Me.TomarFotoToolStripMenuItem.Name = "TomarFotoToolStripMenuItem"
        Me.TomarFotoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.TomarFotoToolStripMenuItem.Text = "Tomar foto"
        '
        'CargarFotoToolStripMenuItem
        '
        Me.CargarFotoToolStripMenuItem.Image = Global.namespace4BITS.My.Resources.Resources.digital_camera_image
        Me.CargarFotoToolStripMenuItem.Name = "CargarFotoToolStripMenuItem"
        Me.CargarFotoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CargarFotoToolStripMenuItem.Text = "Cargar foto"
        '
        'SinFotoToolStripMenuItem
        '
        Me.SinFotoToolStripMenuItem.Image = Global.namespace4BITS.My.Resources.Resources.web_camera_remove
        Me.SinFotoToolStripMenuItem.Name = "SinFotoToolStripMenuItem"
        Me.SinFotoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SinFotoToolStripMenuItem.Text = "Sin foto"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(149, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Nombre:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(150, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Usuario:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(159, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Clave:"
        '
        'txtNombre
        '
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(196, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 20)
        Me.txtNombre.TabIndex = 0
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Valor no válido"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtNombre, ConditionValidationRule1)
        '
        'txtUsuario
        '
        Me.txtUsuario.EnterMoveNextControl = True
        Me.txtUsuario.Location = New System.Drawing.Point(196, 56)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(174, 20)
        Me.txtUsuario.TabIndex = 1
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Valor no válido"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtUsuario, ConditionValidationRule2)
        '
        'txtClave
        '
        Me.txtClave.EnterMoveNextControl = True
        Me.txtClave.Location = New System.Drawing.Point(196, 91)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(174, 20)
        Me.txtClave.TabIndex = 2
        ConditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule3.ErrorText = "Valor no válido"
        ConditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtClave, ConditionValidationRule3)
        '
        'txtClave2
        '
        Me.txtClave2.EnterMoveNextControl = True
        Me.txtClave2.Location = New System.Drawing.Point(196, 125)
        Me.txtClave2.Name = "txtClave2"
        Me.txtClave2.Size = New System.Drawing.Size(174, 20)
        Me.txtClave2.TabIndex = 3
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals
        CompareAgainstControlValidationRule1.ErrorText = "No coiciden las contraseñas"
        CompareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtClave2, CompareAgainstControlValidationRule1)
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(142, 128)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Re-Clave:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.namespace4BITS.My.Resources.Resources.accept_vns1
        Me.btnAceptar.Location = New System.Drawing.Point(91, 206)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.namespace4BITS.My.Resources.Resources.delete_vns1
        Me.btnSalir.Location = New System.Drawing.Point(242, 206)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'ckHabilitado
        '
        Me.ckHabilitado.EditValue = True
        Me.ckHabilitado.Location = New System.Drawing.Point(23, 172)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Properties.Caption = "Habilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(75, 19)
        Me.ckHabilitado.TabIndex = 7
        '
        'lueUsuario
        '
        Me.lueUsuario.Location = New System.Drawing.Point(196, 161)
        Me.lueUsuario.Name = "lueUsuario"
        Me.lueUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUsuario.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idGrupo", "idGrupo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Grupo")})
        Me.lueUsuario.Properties.DisplayMember = "nombre"
        Me.lueUsuario.Properties.NullText = "[No hay grupos]"
        Me.lueUsuario.Properties.ValueMember = "idGrupo"
        Me.lueUsuario.Size = New System.Drawing.Size(174, 20)
        Me.lueUsuario.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(157, 164)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Grupo:"
        '
        'depError
        '
        Me.depError.ContainerControl = Me
        '
        'frmUsuariosNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 251)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.lueUsuario)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ckHabilitado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtClave2)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.picFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUsuariosNuevo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Usuarios"
        CType(Me.picFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFoto.ResumeLayout(False)
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckHabilitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picFoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClave2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmsFoto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TomarFotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarFotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinFotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dvpValidar As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents ckHabilitado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lueUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents depError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
