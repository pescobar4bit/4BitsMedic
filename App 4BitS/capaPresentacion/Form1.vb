Imports capaLogica.VINNS.MetodosConexiones

Public Class Form1
    Dim vLogica As New clsEjemplo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ds.DataSource = vLogica.ejecutarProcedimiento1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vLogica As New clsEjemplo
        vLogica.ejecutarProcedimiento2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim vLogica As New clsEjemplo
        vLogica.ejecutarProcedimiento3()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim vLogica As New clsEjemplo
        vLogica.obtenerDato()
    End Sub
End Class
