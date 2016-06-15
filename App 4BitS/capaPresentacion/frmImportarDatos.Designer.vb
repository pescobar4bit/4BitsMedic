<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarDatos
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
        Me.txtDirec = New DevExpress.XtraEditors.TextEdit
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnConectar = New DevExpress.XtraEditors.SimpleButton
        Me.ofdAbrir = New System.Windows.Forms.OpenFileDialog
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnImportar = New DevExpress.XtraEditors.SimpleButton
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtDirec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDirec
        '
        Me.txtDirec.Location = New System.Drawing.Point(120, 18)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(288, 20)
        Me.txtDirec.TabIndex = 0
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(414, 15)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "&Examinar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Dirección BDD Access"
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(509, 15)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(121, 23)
        Me.btnConectar.TabIndex = 3
        Me.btnConectar.Text = "&Conectar y cargar"
        '
        'ofdAbrir
        '
        Me.ofdAbrir.FileName = "OpenFileDialog1"
        Me.ofdAbrir.Filter = "Archivos de access|*.mdb|Todos los archivos|*.*"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 67)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(739, 315)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(397, 388)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(138, 23)
        Me.btnImportar.TabIndex = 5
        Me.btnImportar.Text = "&Importar datos"
        '
        'lueDepartamento
        '
        Me.lueDepartamento.Location = New System.Drawing.Point(98, 388)
        Me.lueDepartamento.Name = "lueDepartamento"
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idDepartamento", "Name1", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("departamento", "Departamento")})
        Me.lueDepartamento.Properties.DisplayMember = "departamento"
        Me.lueDepartamento.Properties.ValueMember = "idDepartamento"
        Me.lueDepartamento.Size = New System.Drawing.Size(181, 20)
        Me.lueDepartamento.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 391)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Departamento"
        '
        'frmImportarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 434)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lueDepartamento)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.txtDirec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmImportarDatos"
        Me.Text = "frmImportarDatos"
        CType(Me.txtDirec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDirec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExaminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnConectar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ofdAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
