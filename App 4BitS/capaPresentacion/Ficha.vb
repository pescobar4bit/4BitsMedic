Imports DevExpress.XtraReports.UI
Public Class Ficha
    Public DRFicha As DataRow = Nothing

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim DTTmpo As DataTable = EjecutarSelect("select * from tpersonas")
        Dim Binding As New XRBinding("Text", DTTmpo, "nombres")
        Me.DataSource = DTTmpo
        MsgBox(DTTmpo.Rows.Count)
        'XrTable1.DataBindings.Add(Binding)
        XrTableCell1.DataBindings.Add(Binding)
       

        lblNombre.Text = "Hola" ''DRFicha("nombres")
    End Sub
End Class