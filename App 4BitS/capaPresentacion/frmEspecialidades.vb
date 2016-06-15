Imports capaLogica.namespace4BITS

Public Class frmEspecialidades
    Dim gEspecialidades As New Conexiones.clsEspecialidades()

    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtTemp As DataTable
        dtTemp = gEspecialidades.pListarEspecialidades()
        gcEspecialidades.DataSource = dtTemp
    End Sub
End Class