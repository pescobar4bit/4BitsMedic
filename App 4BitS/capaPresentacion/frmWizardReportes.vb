Public Class frmWizardReportes
    Dim vQueReporte As Integer = -1
    Dim mCancel As Boolean = True
  
    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property


    Private Sub wpFinal_PageCommit(ByVal sender As Object, ByVal e As System.EventArgs) Handles wpFinal.PageCommit
        mCancel = False
    End Sub

    Private Sub wcConfigReportes_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraWizard.WizardPageChangedEventArgs) Handles wcConfigReportes.SelectedPageChanged
        Select Case vQueReporte
            Case 0 ''REPORTE DE CORTE DE ORDENES
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = deFechaI.DateTime.Date
                    configuracionReportes.fechaFin = DateAdd(DateInterval.Day, 1, deFechaF.DateTime.Date)
                    configuracionReportes.vOpcion1 = rgTipo.SelectedIndex
                    'If rgTipo.SelectedIndex = 0 Then

                    '    configuracionReportes.vOpcion1 = 
                    'End If

                End If
            Case 1 'TRASLADOS
                configuracionReportes = Nothing
                configuracionReportes.fechaInicio = deFechaI.DateTime.Date
                configuracionReportes.fechaFin = DateAdd(DateInterval.Day, 1, deFechaF.DateTime.Date)
                configuracionReportes.vOpcion1 = rgTipo.SelectedIndex
            Case 2 'TRASLADOS
                configuracionReportes = Nothing
                configuracionReportes.fechaInicio = deFechaI.DateTime.Date
                configuracionReportes.fechaFin = DateAdd(DateInterval.Day, 1, deFechaF.DateTime.Date)
                configuracionReportes.vOpcion1 = rgTipo.SelectedIndex
            Case 3
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = CDate("01/" & txtMes1.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    configuracionReportes.fechaFin = CDate("28/" & txtMes2.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    configuracionReportes.vOpcion1 = txtAnio.Text
                End If
            Case 4
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = CDate("01/" & Month(mcCalendario.SelectionRange.Start) & "/" & Year(mcCalendario.SelectionRange.Start))
                    Dim vFechaTmpo As Date = mcCalendario.SelectionRange.Start '' CDate("01/" & txtMes2.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    vFechaTmpo = DateAdd(DateInterval.Day, 1, vFechaTmpo)
                    'vFechaTmpo = DateAdd(DateInterval.Day, -1, vFechaTmpo)
                    configuracionReportes.fechaFin = vFechaTmpo ''CDate("28/" & txtMes2.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    configuracionReportes.vOpcion1 = Year(vFechaTmpo)
                End If
            Case 5
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = deFechaI.DateTime.Date
                    configuracionReportes.fechaFin = DateAdd(DateInterval.Day, 1, deFechaF.DateTime.Date)
                    configuracionReportes.vOpcion1 = rgTipo.SelectedIndex

                End If
            Case 6
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = deFechaI.DateTime.Date
                    configuracionReportes.fechaFin = DateAdd(DateInterval.Day, 1, deFechaF.DateTime.Date)
                    configuracionReportes.vOpcion1 = rgTipo.SelectedIndex

                End If
            Case 7 ''PARA REPORTE DE ESTADO DE RESULTADOS
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = FormatDateTime("01/" & txtMes2.EditValue & "/" & txtAnio.EditValue) ''deFechaI.DateTime.Date
                    Dim vFechaFin As Date
                    If txtMes2.EditValue = Month(Now.Date) And txtAnio.EditValue = Year(Now.Date) Then
                        vFechaFin = Now.Date
                    Else
                        Dim vTmpo As Date = FormatDateTime("01/" & txtMes2.EditValue & "/" & txtAnio.EditValue)
                        vTmpo = DateAdd(DateInterval.Month, 1, vTmpo)
                        'vTmpo = DateAdd(DateInterval.Day, -1, vTmpo)
                        vFechaFin = vTmpo
                    End If
                    configuracionReportes.fechaFin = vFechaFin
                    ''configuracionReportes.vOpcion1 = rgTipo.SelectedIndex
                End If
            Case 8 'PARA REPORTE DIARIO DE DON EDWIN
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = CDate("01/" & txtMes1.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    Dim vFechaFin As Date = CDate("01/" & txtMes2.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    vFechaFin = DateAdd(DateInterval.Month, 1, vFechaFin)
                    'vFechaFin = DateAdd(DateInterval.Day, -1, vFechaFin)
                    configuracionReportes.fechaFin = vFechaFin ''CDate("28/" & txtMes2.SelectedIndex + 1 & "/" & Int(txtAnio.Text))
                    configuracionReportes.vOpcion1 = txtAnio.Text
                End If
            Case 9 'PARA REPORTE DE APOYOS Y DESCUENTOS
                If e.Page Is wpFinal Then
                    configuracionReportes = Nothing
                    configuracionReportes.fechaInicio = deFechaI.DateTime.Date
                    configuracionReportes.fechaFin = DateAdd(DateInterval.Day, 1, deFechaF.DateTime.Date)
                    configuracionReportes.vOpcion1 = rgTipo.SelectedIndex

                End If

        End Select
       
    End Sub
    Private Sub configuracionVistaReportes()
        wpObjetivos.Visible = False
        wpObjetivosFecha.Visible = False
        Select Case vQueReporte
            Case 0 ''REPORTE DE CORTE DE ORDENES
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de cortes realizados."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de los cortes ya realizados con los parámetros y configuraciones que usted necesita, tomando la fecha que fue hecho el corte."
                rgTipo.Visible = False
            Case -1
                WelcomeWizardPage1.AllowNext = False
            Case 1 ''REPORTE DE TRASLADOS
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de Traslados de productos"
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de traslados de productos con los parámetros y configuraciones que usted necesita"
                rgTipo.Visible = False
            Case 2 ''REPORTE DE DETALLE DE MOVIMIENTOS
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de el detalle de observaciones de movimientos de créditos."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de las notas y otros de créditos con los parámetros y configuraciones que usted necesita"
                rgTipo.Visible = False
            Case 3 ''REPORTE DE OBJETIVOS DEL MES O MESES
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de objetivos definidos para cada vendedor."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de los objetivos y otros, con los parámetros y configuraciones que usted necesita"
                ''rgTipo.Visible = False
                wpFecha.Visible = False
                wpObjetivos.Visible = True
                txtMes1.SelectedIndex = Month(Date.Now) - 1
                txtMes2.SelectedIndex = Month(Date.Now) - 1
                txtAnio.Text = Year(Date.Now)
            Case 4 ''REPORTE DE SEGUIMIENTO DE OBJETIVOS DEL MES
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de seguimiento de objetivos para cada vendedor."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de los objetivos y otros, con los parámetros y configuraciones que usted necesita"
                ''rgTipo.Visible = False
                wpFecha.Visible = False
                wpObjetivos.Visible = False
                'txtMes1.SelectedIndex = Month(Date.Now) - 1
                'txtMes2.SelectedIndex = Month(Date.Now) - 1
                'txtAnio.Text = Year(Date.Now)
                'txtMes1.Visible = False
                'lblMes.Visible = False
                mcCalendario.ShowTodayCircle = True
                mcCalendario.ShowWeekNumbers = True
                wpObjetivosFecha.Visible = True
                lblCualMes.Text = UCase(Format(mcCalendario.SelectionRange.Start, "MMMM"))
            Case 5 ''REPORTE DE SELL IN
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de Sell-In de los productos."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de las compras y otros de los produtos con los parámetros y configuraciones que usted necesita"
                rgTipo.Visible = False
            Case 6 ''REPORTE DE GENERA
                WelcomeWizardPage1.Text = "Bienvenido al asistente para obtener los datos."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte con los parámetros y configuraciones que usted necesita"
                rgTipo.Visible = False
            Case 7
                WelcomeWizardPage1.Text = "Bienvenido al asistente para obtener los datos."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte con los parámetros y configuraciones que usted necesita"
                wpObjetivos.Visible = True
                wpFecha.Visible = False
                txtMes1.Visible = False
                LabelControl4.Visible = False
                lblMes.Text = "   Mes"
                txtMes2.EditValue = 1
                txtAnio.Text = Year(Date.Now)
            Case 8
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de datos diarios de la operación."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de datos y otros, con los parámetros y configuraciones que usted necesita"
                ''rgTipo.Visible = False
                wpFecha.Visible = False
                wpObjetivos.Visible = True
                txtMes1.SelectedIndex = Month(Date.Now) - 1
                txtMes2.SelectedIndex = Month(Date.Now) - 1
                txtAnio.Text = Year(Date.Now)
            Case 9
                WelcomeWizardPage1.Text = "Bienvenido al asistente para el reporte de apoyos y descuentos de los productos."
                WelcomeWizardPage1.IntroductionText = "Este asistente le guiará para poder sacar el reporte de apoyos y descuentos de los produtos con los parámetros y configuraciones que usted necesita"
                rgTipo.Visible = False
        End Select
    End Sub
    Private Sub frmWizardReportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFechaI.DateTime = Date.Now
        deFechaI.Properties.NullText = Date.Now
        deFechaF.DateTime = Date.Now
        deFechaF.Properties.NullText = Date.Now
        configuracionVistaReportes()
    End Sub

    Public Sub New(ByVal TipoReportes As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vQueReporte = TipoReportes
    End Sub

   
    Private Sub mcCalendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcCalendario.DateChanged
        lblCualMes.Text = UCase(Format(mcCalendario.SelectionRange.Start, "MMMM"))
    End Sub
End Class