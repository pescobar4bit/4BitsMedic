Imports System.Net
Imports System.IO
Imports DevExpress.XtraEditors
Imports namespace4BITS.nsFuncionesVINNS
Public Class frmHojaCalculo
    Dim vPathAplicacion As String = Application.StartupPath & "\"
    Dim vFechaLocal As Date
    Dim vFechaWeb As Date
    Dim vHoraLocal As Date
    Dim vHoraWeb As Date
    Dim vDirectorioWeb As String = "ftp://sistemasvinns.com/farmalidersa/archivos/"
    Dim vUsuarioWeb As String = "uactualizar"
    Dim vClaveWeb As String = "Vinns2011"
    Dim vHojaMofificada As Boolean = False
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ' hoja.LoadDocument("C:\Users\Jans\Downloads\tomapedido.xls")
        hoja.Document.Worksheets(hoja.Document.Worksheets.Count - 1).Name = "Hoja 1"
    End Sub

    Private Sub btnTomaPedidos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTomaPedidos.ItemClick

    End Sub
    Private Sub inicioDescarga(nombreArchivo As String)
        If My.Computer.Network.IsAvailable = True Then
            If Not Directory.Exists(vPathAplicacion & "archivos\") Then
                Try
                    ''  lblBitacora.Text += "Revisando directorio..."

                    Directory.CreateDirectory(vPathAplicacion & "archivos\")

                Catch ex As Exception
                    MsgBox("El programa debe ejecutarse con privilegios de administrador", MsgBoxStyle.Critical, "VINNS")
                    End
                End Try

            End If


            'If datosLocales() Then
            '    lblEstado.Text = "Verificando si hay actualizaciones..."
            '    lblBitacora.Text += vbCrLf & "Conectando con el servidor para revisar si hay actualizaciones..."
            '    bwProceso01.RunWorkerAsync()
            'Else
            '    MsgBox("No se encuentra el archivo, verifique", MsgBoxStyle.Critical, "VINNS")
            '    End
            'End If

        Else
            'ejecutarPrograma()
        End If
    End Sub
    Private Function verDatosLocales(nombreArchivo As String) As Boolean
        If File.Exists(vPathAplicacion & nombreArchivo) Then
            Try

                For Each sFichero As String In Directory.GetFiles(vPathAplicacion, nombreArchivo, SearchOption.TopDirectoryOnly)
                    Dim vArchivo As New FileInfo(sFichero)
                    Dim item As New ListViewItem(vArchivo.Name.ToString)
                    Dim tmpoFecha As String = vArchivo.LastWriteTime.ToShortDateString
                    If IsDate(tmpoFecha) Then
                        vFechaLocal = tmpoFecha
                        vHoraLocal = vArchivo.LastWriteTime.ToShortDateString & " " & vArchivo.LastWriteTime.ToShortTimeString
                        Return True
                    End If
                    Exit For
                Next
            Catch ex As Exception
                Return False
            End Try
        End If
    End Function
    Private Function verDatosWeb(nombreArchivo As String) As Boolean
        Dim FtpRequest As Net.FtpWebRequest
        Dim FtpResponse As Net.FtpWebResponse
        Dim FileSize As Integer
        Try
            FtpRequest = Net.FtpWebRequest.Create(vDirectorioWeb & nombreArchivo)
            Dim cr As New NetworkCredential(vUsuarioWeb, vClaveWeb)
            FtpRequest.Credentials = cr
            FtpRequest.Method = Net.WebRequestMethods.Ftp.GetDateTimestamp
            FtpResponse = FtpRequest.GetResponse

            FileSize = FtpResponse.ContentLength
            Dim tmpoFecha = FtpResponse.LastModified

            If IsDate(tmpoFecha) Then
                vHoraWeb = tmpoFecha
                vFechaWeb = vFechaWeb
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub btnPedidoSugerido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPedidoSugerido.ItemClick
        Try
            mostarWait(Me, "Espere por favor", "Cargando datos...")
        
        hoja.Document.Worksheets.Add()
        Dim vNumeroHoja As Integer = hoja.Document.Worksheets.Count - 1
        hoja.Document.Worksheets(vNumeroHoja).Name = "Pedido Sug. " & vNumeroHoja

        With hoja.Document.Worksheets(vNumeroHoja)
            .Cells("A1").Value = "COD"
                .Cells("B1").Value = "PRODUCTO"
                .Cells("C1").Value = "CASA"
            .Cells("D1").Value = Format(DateAdd(DateInterval.Month, -6, Date.Now), "MM/yy")
                .Cells("E1").Value = Format(DateAdd(DateInterval.Month, -5, Date.Now), "MM/yy")
                .Cells("F1").Value = Format(DateAdd(DateInterval.Month, -4, Date.Now), "MM/yy")
                .Cells("G1").Value = Format(DateAdd(DateInterval.Month, -3, Date.Now), "MM/yy")
                .Cells("H1").Value = Format(DateAdd(DateInterval.Month, -2, Date.Now), "MM/yy")
                .Cells("I1").Value = Format(DateAdd(DateInterval.Month, -1, Date.Now), "MM/yy")
                .Cells("J1").Value = "PROMEDIO MENSUAL"
                .Cells("K1").Value = "DMD"
                .Cells("L1").Value = "INVENTARIO"
                .Cells("M1").Value = "DIAS INV." 'INVENTARIO/DMD
                .Cells("N1").Value = "PEDIDO SUG." 'INVENTARIO/DMD
                .Cells("O1").Value = "DIAS INV." 'EDITABLE L+INV/PROMED

                Dim vDTRotacion As DataTable = Nothing
                Dim vFechaInicial As Date = CDate("01/" & Month(DateAdd(DateInterval.Month, -6, Date.Now)) & "/" & Year(DateAdd(DateInterval.Month, -6, Date.Now)))
                Dim vFechaFinal As Date = DateAdd(DateInterval.Month, 1, vFechaInicial)
                Dim vPosicion As Integer = 2
                Dim vPrimeraVez As Boolean = True
                Dim vDTRotacionDetalle As DataTable = Nothing
                For x As Integer = 1 To 6

                    mostarWait(Me, "Espere por favor...", "Cargando Rotación " & x)
                    vDTRotacion = EjecutarProcedimientoP(vFechaInicial, vFechaFinal, vConexion.vidBodega, "paBRotacion")
                    If vDTRotacion.Rows.Count > 0 Then
                        If x > 1 Then vPrimeraVez = False
                        Dim MiColum As DataColumn = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "totalfardo"
                        MiColum.ColumnName = "totalfardo"
                        vDTRotacion.Columns.Add(MiColum)

                        MiColum = Nothing
                        MiColum = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "rota1"
                        MiColum.ColumnName = "rota1"
                        vDTRotacion.Columns.Add(MiColum)

                        MiColum = Nothing
                        MiColum = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "rota2"
                        MiColum.ColumnName = "rota2"
                        vDTRotacion.Columns.Add(MiColum)

                        MiColum = Nothing
                        MiColum = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "rota3"
                        MiColum.ColumnName = "rota3"
                        vDTRotacion.Columns.Add(MiColum)

                        MiColum = Nothing
                        MiColum = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "rota4"
                        MiColum.ColumnName = "rota4"
                        vDTRotacion.Columns.Add(MiColum)

                        MiColum = Nothing
                        MiColum = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "rota5"
                        MiColum.ColumnName = "rota5"
                        vDTRotacion.Columns.Add(MiColum)

                        MiColum = Nothing
                        MiColum = New DataColumn
                        MiColum.DataType = Type.GetType("System.Decimal")
                        MiColum.AllowDBNull = True
                        MiColum.DefaultValue = "0"
                        MiColum.Caption = "rota6"
                        MiColum.ColumnName = "rota6"
                        vDTRotacion.Columns.Add(MiColum)


                        vPosicion = 2
                        For Each fila In vDTRotacion.Rows
                            fila("totalfardo") = fila("fardo") + fila("fardoboni") + fila("fardoboniesp")
                            If x = 1 Then
                                fila("rota1") = fila("totalfardo")
                                If vDTRotacionDetalle Is Nothing Then
                                    vDTRotacionDetalle = vDTRotacion.Clone
                                    vDTRotacionDetalle.Clear()
                                End If
                                vDTRotacionDetalle.ImportRow(fila)
                            End If

                        Next
                        If vPrimeraVez Then

                            vPrimeraVez = False
                        Else

                            For Each fila In vDTRotacionDetalle.Rows
                                Dim vDRRota As DataRow() = vDTRotacion.Select("CodigoB='" & fila("CodigoB") & "'")
                                If vDRRota.GetUpperBound(0) >= 0 Then
                                    fila("rota" & x) = vDRRota(0)("totalfardo")
                                End If
                            Next

                        End If
                    End If

                    If x = 2 Then x = 8

                    vFechaInicial = DateAdd(DateInterval.Month, 1, vFechaInicial)
                    vFechaFinal = DateAdd(DateInterval.Month, 1, vFechaInicial)
                    System.Threading.Thread.Sleep(500)
                    mostarWait(Me, , , 1)
                Next
                mostarWait(Me, "Espere por favor...", "Llenando celdas")

                For Each fila In vDTRotacionDetalle.Rows
                    .Cells("A" & vPosicion).Value = fila("CodigoB").ToString
                    .Cells("B" & vPosicion).Value = fila("Producto").ToString
                    .Cells("C" & vPosicion).Value = fila("casa").ToString
                    .Cells("D" & vPosicion).Formula = CDec(fila("rota1").ToString)
                    .Cells("E" & vPosicion).Formula = CDec(fila("rota2").ToString)
                    .Cells("F" & vPosicion).Value = CDec(fila("rota3").ToString)
                    .Cells("G" & vPosicion).Value = CDec(fila("rota4").ToString)
                    .Cells("H" & vPosicion).Value = CDec(fila("rota5").ToString)
                    .Cells("I" & vPosicion).Value = CDec(fila("rota6").ToString)
                    .Cells("J" & vPosicion).Formula = "=PROMEDIO(D" & vPosicion & ":I" & vPosicion & ")"
                    vPosicion += 1
                    If vPosicion = 10 Then Exit For
                Next

                System.Threading.Thread.Sleep(500)
                mostarWait(Me, , , 1)
            End With
            System.Threading.Thread.Sleep(500)
            mostarWait(Me, , , 1)
        Catch ex As Exception
            mostarWait(Me, , , 1)

            XtraMessageBox.Show("Error " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class