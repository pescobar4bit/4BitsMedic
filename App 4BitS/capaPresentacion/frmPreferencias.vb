Imports DevExpress.XtraEditors
Public Class frmPreferencias
    Dim vDTPreferenciasM As DataTable = Nothing
    Private vNuevaPreferencia As Boolean = False
    Private Sub frmPreferencias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        vDTPreferenciasM = Nothing
        vDTPreferenciasM = EjecutarSelect("select * from tpreferencia")
        If vDTPreferenciasM.Rows.Count > 0 Then
            txtDescuentoM.Text = vDTPreferenciasM.Rows(0).Item("DescuentoG")
            txtFotoDespues.Text = vDTPreferenciasM.Rows(0).Item("fotodespues")
            txtTamanioI.Text = vDTPreferenciasM.Rows(0).Item("tamanioi")
            txtTiempoO.Text = vDTPreferenciasM.Rows(0).Item("tiempoo")
            vNuevaPreferencia = False
        Else
            depError.SetError(txtDescuentoM, "Todavia no se ha configurado")
            depError.SetError(txtFotoDespues, "Todavía no se ha configurado")
            depError.SetError(txtTamanioI, "Todavía no se ha configurado")
            depError.SetError(txtTiempoO, "Todavía no se ha configurado")
            vNuevaPreferencia = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case vNuevaPreferencia
            Case True
                INSERTAR("insert into tpreferencia (tiempoo,descuentog,tamanioi,fotodespues) values(" & txtTiempoO.Text & "," _
                         & txtDescuentoM.Text & "," & txtTamanioI.Text & "," & txtFotoDespues.Text & ")")
                XtraMessageBox.Show("Datos guardados", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case False
                INSERTAR("update tpreferencia set tiempoo=" & txtTiempoO.Text & ",descuentog=" & txtDescuentoM.Text & ",tamanioi=" & txtTamanioI.Text & ",fotodespues=" & txtFotoDespues.Text & " where idpreferencia=" & vDTPreferenciasM.Rows(0).Item("idPreferencia"))
                XtraMessageBox.Show("Datos guardados", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
        Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class