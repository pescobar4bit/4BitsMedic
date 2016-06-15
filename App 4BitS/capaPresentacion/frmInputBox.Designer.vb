<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBox
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
        Me.txtTexto = New DevExpress.XtraEditors.TextEdit
        Me.lblTexto = New DevExpress.XtraEditors.LabelControl
        Me.dxCmdOK = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtTexto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(39, 61)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(318, 20)
        Me.txtTexto.TabIndex = 0
        '
        'lblTexto
        '
        Me.lblTexto.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Appearance.Options.UseFont = True
        Me.lblTexto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTexto.Location = New System.Drawing.Point(39, 12)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(318, 23)
        Me.lblTexto.TabIndex = 1
        Me.lblTexto.Text = "LabelControl1"
        '
        'dxCmdOK
        '
        Me.dxCmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.dxCmdOK.Location = New System.Drawing.Point(289, 96)
        Me.dxCmdOK.Name = "dxCmdOK"
        Me.dxCmdOK.Size = New System.Drawing.Size(68, 28)
        Me.dxCmdOK.TabIndex = 3
        Me.dxCmdOK.Text = "OK"
        Me.dxCmdOK.Visible = False
        '
        'frmInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 136)
        Me.Controls.Add(Me.dxCmdOK)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.txtTexto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmInputBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInputBox"
        CType(Me.txtTexto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTexto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTexto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dxCmdOK As DevExpress.XtraEditors.SimpleButton
End Class
