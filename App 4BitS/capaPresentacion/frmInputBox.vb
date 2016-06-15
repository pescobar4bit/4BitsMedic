Public Class frmInputBox
    Dim mCancel As Boolean = True
    ReadOnly Property resultadoInput() As String
        Get
            resultadoInput = Trim(txtTexto.Text)
        End Get
    End Property
    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property
    Public Sub New(ByRef vEtiqueta As String, ByRef vLabel As String, Optional ByRef vTexto As String = "", Optional ByVal vCaracter As String = "", Optional ByVal esNumero As Boolean = False)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.Text = vEtiqueta
        lblTexto.Text = vLabel
        txtTexto.Text = vTexto
        txtTexto.Properties.PasswordChar = vCaracter
        If esNumero Then
            txtTexto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            txtTexto.Properties.DisplayFormat.FormatString = "n2"
            txtTexto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            txtTexto.Properties.EditFormat.FormatString = "n2"
            txtTexto.Properties.NullText = "0.00"

            txtTexto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txtTexto.Properties.Mask.EditMask = "n2"
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmInputBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If txtTexto.Text <> "" Then mCancel = False

                Me.Close()
                Me.Dispose()
            Case Keys.Escape
                mCancel = True
                Me.Close()
                Me.Dispose()
        End Select
    End Sub

    
End Class