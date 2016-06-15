<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGruposNuevo
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
        Me.txtGrupo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ckHabilitado = New DevExpress.XtraEditors.CheckEdit
        Me.dvpValidar = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lueCategorias = New DevExpress.XtraEditors.LookUpEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckHabilitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCategorias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtGrupo
        '
        Me.txtGrupo.EnterMoveNextControl = True
        Me.txtGrupo.Location = New System.Drawing.Point(232, 26)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(206, 20)
        Me.txtGrupo.TabIndex = 0
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Este valor no es válido"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
        Me.dvpValidar.SetValidationRule(Me.txtGrupo, ConditionValidationRule1)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(194, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Grupo:"
        '
        'ckHabilitado
        '
        Me.ckHabilitado.EditValue = True
        Me.ckHabilitado.Location = New System.Drawing.Point(230, 99)
        Me.ckHabilitado.Name = "ckHabilitado"
        Me.ckHabilitado.Properties.Caption = "Habilitado"
        Me.ckHabilitado.Size = New System.Drawing.Size(75, 19)
        Me.ckHabilitado.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(117, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Que Casa en reportes:"
        '
        'lueCategorias
        '
        Me.lueCategorias.EnterMoveNextControl = True
        Me.lueCategorias.Location = New System.Drawing.Point(232, 61)
        Me.lueCategorias.Name = "lueCategorias"
        Me.lueCategorias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo)})
        Me.lueCategorias.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCasa", "Nombre1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("casa", "Casa/Socio Comerical"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "Dirección"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "Teléfono")})
        Me.lueCategorias.Properties.DisplayMember = "casa"
        Me.lueCategorias.Properties.NullText = "[No hay casas definidas]"
        Me.lueCategorias.Properties.ValueMember = "idCasa"
        Me.lueCategorias.Size = New System.Drawing.Size(206, 20)
        Me.lueCategorias.TabIndex = 1
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.namespace4BITS.My.Resources.Resources.users1
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(99, 106)
        Me.PictureEdit1.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.namespace4BITS.My.Resources.Resources.delete_vns1
        Me.btnSalir.Location = New System.Drawing.Point(363, 124)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.namespace4BITS.My.Resources.Resources.accept_vns1
        Me.btnAceptar.Location = New System.Drawing.Point(232, 124)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmGruposNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 170)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.lueCategorias)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ckHabilitado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtGrupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGruposNuevo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupo"
        CType(Me.txtGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckHabilitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvpValidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCategorias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGrupo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckHabilitado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dvpValidar As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueCategorias As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
