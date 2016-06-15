Imports DevExpress.Utils
Imports System.Threading
Imports DevExpress.XtraEditors
Imports namespace4BITS.nsFuncionesVINNS
Imports DevExpress.DashboardCommon
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Public Class frmAnalisisDisenadorActu
    Dim vDTDatos As DataTable = Nothing
    Dim vDTSellIn As DataTable = Nothing
    Dim vDTDatosFactura As DataTable = Nothing
    Dim vDTPromedioRutas As DataTable = Nothing
    'Dim vDTPromedioSede As DataTable = Nothing

    Private Sub cargarSellIn()
        vDTSellIn = Nothing
        'Dim fecha1 As New Date
        'Dim fecha2 As New Date
        'fecha1 = "01/05/2012"
        'fecha2 = "30/05/2012"
        Try


            'waitDialgo = New WaitDialogForm("Calculando rotación....", "Espere por favor")
            mostarWait(Me, "Calculando Sell-In", "Espere por favor")
            vDTSellIn = EjecutarProcedimientoP(configuracionReportes.fechaInicio, DateAdd(DateInterval.Day, 1, configuracionReportes.fechaFin), -1 * vConexion.vidBodega, "paBRotacion")
            If vDTSellIn.Rows.Count > 0 Then

                Dim MiColum As DataColumn = New DataColumn
                MiColum.DataType = Type.GetType("System.Decimal")
                MiColum.AllowDBNull = True
                MiColum.DefaultValue = "0"
                MiColum.Caption = "totalfardo"
                MiColum.ColumnName = "totalfardo"
                vDTSellIn.Columns.Add(MiColum)

                For Each fila In vDTSellIn.Rows
                    fila("totalfardo") = fila("fardo") + fila("fardoboni")
                Next
                'gridSellIn.DataSource = vDTSellIn
                If DTUsuario.Rows(0).Item("idCasa") <> 0 Then

                    Dim vDRTmpo As DataRow() = vDTSellIn.Select("[casa] LIKE '%" & DTUsuario.Rows(0).Item("casa").ToString & "%'")
                    vDTSellIn.Clear()
                    If vDRTmpo.GetUpperBound(0) >= 0 Then
                        For x As Integer = 0 To vDRTmpo.GetUpperBound(0)
                            vDTSellIn.ImportRow(vDRTmpo(x))
                        Next
                    End If
                    'GridColumnCasa.FilterInfo = New ColumnFilterInfo(ColumnFilterType.AutoFilter, "[casa] LIKE '%" & DTUsuario.Rows(0).Item("casa").ToString & "%'")
                    'GridColumnCasa.Visible = False
                    'GridColumnCasa.OptionsColumn.AllowShowHide = False
                    'GridViewSellIn.OptionsView.ShowFilterPanelMode = Views.Base.ShowFilterPanelMode.Never
                End If
                'cargarAparienciaGrid()
                Thread.Sleep(500)
                'waitDialgo.Close()
                mostarWait(Me, , , 1)
                'DashboardDesigner1.Dashboard.DataSources.Clear()
                'If vDTDatos IsNot Nothing Then
                '    'Dim vDTTemporal As DataTable = vDTDatos.Copy

                '    DashboardDesigner1.Dashboard.AddDataSource("SellOut", vDTDatos)

                'End If
                ' DashboardDesigner1.Dashboard.AddDataSource("SellIn", vDTSellIn)
                DashboardDesigner1.Dashboard.DataSources(2).Data = vDTSellIn
            End If
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub cargarSellOut()
        Try
            mostarWait(Me, "Generando vista previa...", "Espere por favor")

            vDTDatos = Nothing
            'Dim vFech As Date = Format(CDate("01/02/2013"), "dd/MM/yyyy")
            If DTUsuario.Rows(0).Item("idCasa") <> 0 Then
                vDTDatos = EjecutarProcedimientoPDinamicoConResultadoTabla("paBReportesWeb", "casa", configuracionReportes.fechaInicio, configuracionReportes.fechaFin, "selloutnuevoweb", DTUsuario.Rows(0).Item("idCasa"))
                'GetType(frmAnalisisDisenador).Assembly.GetManifestResourceStream("C:\Users\Jans\Documents\Vinns\Distribuidora7\sellOutEnero_12_13.xml")
                'DashboardDesigner1.Dashboard.LoadFromXml("C:\Users\Jans\Documents\Vinns\Distribuidora7\sellOutEnero_12_13.xml")
                Dim vComplemento As String = ""
                ' ''If DTUsuario.Rows(0).Item("idCasa") <> 0 Then
                ' ''    vComplemento = " and [casa] LIKE '%" & DTUsuario.Rows(0).Item("casa").ToString & "%'"

                ' ''    Dim vDRCero As DataRow() = vDTDatos.Select("total<>0" & vComplemento)
                ' ''    Dim vDTSellOut2 As DataTable = Nothing
                ' ''    If vDRCero.GetUpperBound(0) Then

                ' ''        vDTSellOut2 = vDTDatos.Copy
                ' ''        vDTSellOut2.Clear()
                ' ''        For z As Integer = 0 To vDRCero.GetUpperBound(0)
                ' ''            vDTSellOut2.ImportRow(vDRCero(z))
                ' ''        Next
                ' ''    End If
                ' ''    vDTDatos.Clear()
                ' ''    vDTDatos = vDTSellOut2.Copy


                ' ''End If

            Else
                vDTDatos = EjecutarProcedimientoPDinamicoConResultadoTabla("pabReportesWEb", "todos", configuracionReportes.fechaInicio, configuracionReportes.fechaFin, "selloutnuevoweb", DTUsuario.Rows(0).Item("idCasa"))
            End If
            'DashboardDesigner1.Dashboard.DataSources.Clear()
            ' DashboardDesigner1.Dashboard.AddDataSource("SellOut", vDTDatos)
            DashboardDesigner1.Dashboard.DataSources(0).Data = vDTDatos
            'If vDTSellIn IsNot Nothing Then


            '    DashboardDesigner1.Dashboard.AddDataSource("SellIn", vDTSellIn)

            '    'DashboardDesigner1.Dashboar()
            'End If
            mostarWait(Me, , , 1)
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub cargarPromerioRuta()
        Try
            mostarWait(Me, "Generando vista previa...", "Espere por favor")

            vDTPromedioRutas = Nothing
            'Dim vFech As Date = Format(CDate("01/02/2013"), "dd/MM/yyyy")

            vDTPromedioRutas = EjecutarSelect("select * from dbo.fcalcularpromedioyahora(1,-1)") ''EjecutarProcedimientoP(vConexion.vidBodega * -1, configuracionReportes.fechaInicio, configuracionReportes.fechaFin, "paBVentasXProductosYOtros", "pedido2")
            'GetType(frmAnalisisDisenador).Assembly.GetManifestResourceStream("C:\Users\Jans\Documents\Vinns\Distribuidora7\sellOutEnero_12_13.xml")
            'DashboardDesigner1.Dashboard.LoadFromXml("C:\Users\Jans\Documents\Vinns\Distribuidora7\sellOutEnero_12_13.xml")
            ' ''Dim vComplemento As String = ""
            ' ''If DTUsuario.Rows(0).Item("idCasa") <> 0 Then
            ' ''    vComplemento = " and [casa] LIKE '%" & DTUsuario.Rows(0).Item("casa").ToString & "%'"

            ' ''    Dim vDRCero As DataRow() = vDTDatos.Select("total<>0 and anulada=0" & vComplemento)
            ' ''    Dim vDTSellOut2 As DataTable = Nothing
            ' ''    If vDRCero.GetUpperBound(0) Then

            ' ''        vDTSellOut2 = vDTDatos.Copy
            ' ''        vDTSellOut2.Clear()
            ' ''        For z As Integer = 0 To vDRCero.GetUpperBound(0)
            ' ''            vDTSellOut2.ImportRow(vDRCero(z))
            ' ''        Next
            ' ''    End If
            ' ''    vDTDatos.Clear()
            ' ''    vDTDatos = vDTSellOut2.Copy
            ' ''End If


            'DashboardDesigner1.Dashboard.DataSources.Clear()
            'DashboardDesigner1.Dashboard.AddDataSource("SellOut", vDTDatos)
            DashboardDesigner1.Dashboard.DataSources(3).Data = vDTPromedioRutas
            'If vDTSellIn IsNot Nothing Then


            '    DashboardDesigner1.Dashboard.AddDataSource("SellIn", vDTSellIn)

            '    'DashboardDesigner1.Dashboar()
            'End If
            mostarWait(Me, , , 1)
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)
        End Try
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If DTUsuario.Rows(0).Item("idCasa") <> 0 Then
            'AsitenteParaReporteSellInToolStripMenuItem.Visible = False
            'AsistenteParaVerPromedioRutaToolStripMenuItem.Visible = False
            'btnVentaPromedioRuta.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnSellIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        End If
        DashboardDesigner1.Dashboard.AddDataSource("SellOutPorProducto", vDTDatos)
        DashboardDesigner1.Dashboard.AddDataSource("SellOutPorPedido", vDTDatosFactura)
        DashboardDesigner1.Dashboard.AddDataSource("SellIn", vDTSellIn)
        DashboardDesigner1.Dashboard.AddDataSource("PromedioRutas", vDTPromedioRutas)
    End Sub

    Private Sub btnSellOutProducto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSellOutProducto.ItemClick
        Dim frmTmpo As frmWizardReportes = New frmWizardReportes(6)
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then

            cargarSellOut()

            barra.Caption = "Fecha de: " & configuracionReportes.fechaInicio & " a " & DateAdd(DateInterval.Day, -1, configuracionReportes.fechaFin)
        End If
    End Sub

    Private Sub btnVentaPromedioSede_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVentaPromedioSede.ItemClick
        'Dim frmTmpo As frmWizardReportes = New frmWizardReportes(6)
        'frmTmpo.ShowDialog()
        'If Not frmTmpo.oCancelar Then

        cargarPromerioRuta()

        barra.Caption = "" ''"Fecha de: " & configuracionReportes.fechaInicio & " a " & DateAdd(DateInterval.Day, -1, configuracionReportes.fechaFin)
        'End If
    End Sub

    Private Sub btnSellIn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSellIn.ItemClick
        Dim frmTmpo As frmWizardReportes = New frmWizardReportes(5)
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then

            cargarSellIn()
            'cargarAparienciaGrid()
            barra.Caption = "Reporte de Sell-In con fecha de: " & configuracionReportes.fechaInicio & " a " & DateAdd(DateInterval.Day, -1, configuracionReportes.fechaFin)
        End If
    End Sub

    Private Sub btnSellOutPedido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSellOutPedido.ItemClick
        Dim frmTmpo As frmWizardReportes = New frmWizardReportes(6)
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then

            ventasPedidos()
            'cargarAparienciaGrid()
            barra.Caption = "Reporte de SellOut por Pedido con fecha de: " & configuracionReportes.fechaInicio & " a " & DateAdd(DateInterval.Day, -1, configuracionReportes.fechaFin)
        End If
    End Sub
    Private Sub ventasPedidos()
        'waitDialgo = New WaitDialogForm("Calculando datos....", "Espere por favor")
        Try
            mostarWait(Me, "Calculando datos...", "Espere por favor")

            vDTDatosFactura = Nothing
            Dim qMandar As Integer = 0

            qMandar = vConexion.vidBodega * -1

            vDTDatosFactura = EjecutarProcedimientoPDinamicoConResultadoTabla("pabReportesWEb", "", configuracionReportes.fechaInicio, configuracionReportes.fechaFin, "selloutporpedidos", "")
            DashboardDesigner1.Dashboard.DataSources(1).Data = vDTDatosFactura

            Thread.Sleep(500)
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            XtraMessageBox.Show("Error: " & Err.Description, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   
End Class