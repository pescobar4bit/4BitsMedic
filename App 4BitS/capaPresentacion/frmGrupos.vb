Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports namespace4BITS.nsFuncionesVINNS
Public Class frmGrupos
    Dim frmPermisos As frmPrincipal
    Dim vCual As String = ""
    Dim vDTGrupos As DataTable = Nothing
    'Dim waitDialgo As WaitDialogForm
    Dim vDTPermisos As DataTable = Nothing
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'For y As Integer = 0 To frmPermisos.rcPrincipal.Pages.Count - 1
        '    ''For x As Integer = 0 To frmPermisos.rcPrincipal.Pages(y).Ribbon.Items.Count - 1
        '    MsgBox(frmPermisos.rcPrincipal.Categories)
        '    ''Next
        'Next
        'MsgBox(vCual)
    End Sub
    Private Sub limpiarControles(Optional ByVal vValor As Boolean = False, Optional ByVal nombrePesVer As String = "")
        For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcPrincipal.TabPages
            For Each controlTab In tabP.Controls
                If TypeOf controlTab Is DevExpress.XtraEditors.CheckedListBoxControl Then
                    ''LIMPIA EL CONTROL
                    Dim listado As DevExpress.XtraEditors.CheckedListBoxControl = CType(controlTab, DevExpress.XtraEditors.CheckedListBoxControl)
                    For x As Integer = 0 To listado.Items.Count - 1
                        listado.Items(x).CheckState = vValor.GetHashCode
                    Next
                End If
            Next
            nombrePesVer = nombrePesVer.Trim
            If nombrePesVer <> "" Then
                If UCase(tabP.Tag) = UCase(nombrePesVer) Then
                    tabP.PageVisible = True
                Else
                    tabP.PageVisible = False
                End If

            Else
                tabP.PageVisible = False
            End If
        Next

    End Sub
    Private Sub mostrarControl(ByVal nombrePesVer As String, ByVal vNombrePesta As String)
        For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcPrincipal.TabPages
            'For Each controlTab In tabP.Controls
            '    If TypeOf controlTab Is DevExpress.XtraEditors.CheckedListBoxControl Then
            '        ''LIMPIA EL CONTROL
            '        Dim listado As DevExpress.XtraEditors.CheckedListBoxControl = CType(controlTab, DevExpress.XtraEditors.CheckedListBoxControl)
            '        For x As Integer = 0 To listado.Items.Count - 1
            '            ''listado.Items(x).CheckState = CheckState.Unchecked
            '        Next
            '    End If
            'Next
            nombrePesVer = nombrePesVer.Trim
            If nombrePesVer <> "" Then
                If UCase(tabP.Tag) = UCase(nombrePesVer) Then
                    tabP.PageVisible = True
                    tabP.Text = vNombrePesta.Trim
                    
                Else
                    tabP.PageVisible = False
                End If

            Else
                tabP.PageVisible = False
            End If
        Next

    End Sub
    Private Function sacarPermisosControles(ByVal vIdValor As Integer, ByVal vDatosParaInsertar01 As datosInsertarInstruccion) As datosInsertarInstruccion
        For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcPrincipal.TabPages
            For Each controlTab In tabP.Controls
                If TypeOf controlTab Is DevExpress.XtraEditors.CheckedListBoxControl Then
                    ''LIMPIA EL CONTROL
                    Dim listado As DevExpress.XtraEditors.CheckedListBoxControl = CType(controlTab, DevExpress.XtraEditors.CheckedListBoxControl)
                    For x As Integer = 0 To listado.Items.Count - 1
                        If listado.Items(x).CheckState = CheckState.Checked Then
                            vDatosParaInsertar01 = AGREGARTRAN(vDatosParaInsertar01, "insert into tpermisos (nombre,boton,habilitado,idGrupo) values('" & listado.Items(x).Value & "',0," & listado.Items(x).CheckState.GetHashCode & "," & vIdValor & ")")
                        End If
                    Next
                End If
            Next

        Next
        Return vDatosParaInsertar01
    End Function
    Private Sub RecControles(ByVal control As Control)
        Dim vNombre As String = ""
        Dim vName As String = ""
        tlControles.Nodes.Clear()
        tlControles.BeginUnboundLoad()
        For x = 0 To frmPermisos.rcPrincipal.Pages.Count - 1
            Dim parentForRootNodes As TreeListNode = Nothing
            vNombre = frmPermisos.rcPrincipal.Pages(x).Text
            vName = frmPermisos.rcPrincipal.Pages(x).Name
            ''se crea los padres del arbol 1 nivel
            Dim rootNode As TreeListNode = tlControles.AppendNode(New Object() {vNombre, vName}, parentForRootNodes)
            rootNode.Tag = vName
            vCual += frmPermisos.rcPrincipal.Pages(x).Name & vbCrLf

            For y As Integer = 0 To frmPermisos.rcPrincipal.Pages(x).Groups.Count - 1
                vNombre = frmPermisos.rcPrincipal.Pages(x).Groups(y).Text
                vName = frmPermisos.rcPrincipal.Pages(x).Groups(y).Name
                ''Se crea los hijos del a
                Dim rootNode2 As TreeListNode = tlControles.AppendNode(New Object() {vNombre, vName}, rootNode)
                rootNode2.Tag = vName
                vCual += "-" & frmPermisos.rcPrincipal.Pages(x).Groups(y).Name & vbCrLf

                For z As Integer = 0 To frmPermisos.rcPrincipal.Pages(x).Groups(y).ItemLinks.Count - 1
                    vNombre = frmPermisos.rcPrincipal.Pages(x).Groups(y).ItemLinks(z).Caption
                    vName = frmPermisos.rcPrincipal.Pages(x).Groups(y).ItemLinks(z).Item.Name
                    tlControles.AppendNode(New Object() {vNombre, vName}, rootNode2)
                    'tlControles.Nodes.LastNode.Tag = vName
                    Dim noN1 As Integer = tlControles.Nodes.Count - 1
                    Dim noN2 As Integer = tlControles.Nodes(noN1).Nodes.Count - 1
                    Dim noN3 As Integer = tlControles.Nodes(noN1).Nodes(noN2).Nodes.Count - 1
                    tlControles.Nodes(noN1).Nodes(noN2).Nodes(noN3).Tag = frmPermisos.rcPrincipal.Pages(x).Groups(y).ItemLinks(z).Item.Name
                    vCual += "--" & frmPermisos.rcPrincipal.Pages(x).Groups(y).ItemLinks(z).Caption & vbCrLf
                Next
            Next

        Next
        tlControles.EndUnboundLoad()
        cargarImagenesTree()
        'For Each contHijo In control.Controls

        '    'Preguntamos si el control tiene uno o mas controles dentro de l mismo con la propiedad 'HasChildren'
        '    'Si el control tiene 1 o más controles, entonces llamamos al procedimiento de forma recursiva, para que siga
        '    'recorriendo los demás controles
        '    If contHijo.HasChildren Then Me.RecControles(contHijo)
        '    If TypeOf contHijo Is DevExpress.XtraBars.Ribbon.RibbonPage Then 'DevExpress.XtraBars.Ribbon.RibbonPageGroup
        '        MsgBox(contHijo.name)
        '    End If


        '    'End If
        '    'Aqui va la lógica de lo queramos hacer, en mi ejemplo, voy a pintar de color azul el fondo de todos los controles
        '    vCual += contHijo.name & vbCrLf

        'Next
    End Sub
    Private Sub cargarImagenesTree()
        'tlControles.Nodes.Item(0).ImageIndex = 0
        'tlControles.Nodes.Item(0).SelectImageIndex = 1
        'tlControles.Nodes.Item(1).ImageIndex = 0
        'tlControles.Nodes.Item(1).SelectImageIndex = 1
        'tlControles.Nodes.Item(2).ImageIndex = 0
        'tlControles.Nodes.Item(2).SelectImageIndex = 1
        For x As Integer = 0 To tlControles.Nodes.Count - 1
            tlControles.Nodes.Item(x).ImageIndex = 0
            tlControles.Nodes.Item(x).SelectImageIndex = 1

            'tlControles.Nodes.Item(x).GetDisplayText(0)
            For Each nodo As DevExpress.XtraTreeList.Nodes.TreeListNode In tlControles.Nodes(x).Nodes

                If nodo.HasChildren Then
                    For Each nodo2 As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo.Nodes
                        'MsgBox(nodo2.Tag)
                        nodo2.ImageIndex = 0
                        nodo2.SelectImageIndex = 1
                    Next
                End If
                nodo.ImageIndex = 0
                nodo.SelectImageIndex = 1
            Next
        Next
    End Sub
    Public Sub New(ByVal frmPri As frmPrincipal)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        frmPermisos = frmPri
        vCual = ""
        RecControles(frmPermisos)
        cargarGrupos()
        limpiarControles()
        limpiarControles(False, "ninguno")
        cargarPermisosDetalle()
    End Sub

    Private Sub tlControles_AfterCheckNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles tlControles.AfterCheckNode
        'MsgBox(e.Node.Level)
        'Select Case e.Node.Level
        '    Case 0
        'MsgBox("VALOR " & e.Node.GetValue(0) & " -: " & e.Node.GetDisplayText(0))
        'Case 1
        'MsgBox("Nivel 1 " & e.Node.GetValue(0))
        'End Select
        'If e.Node.Level = 2 Then MsgBox(e.Node.Tag)

        If e.Node.Level < 2 Then
            'If e.Node.Level = 1 Then MsgBox(e.Node.Tag)


            If e.Node.HasChildren Then
                'If e.Node.Level = 0 Then MsgBox(e.Node.Tag)
                For Each nodo1 As DevExpress.XtraTreeList.Nodes.TreeListNode In e.Node.Nodes
                    nodo1.Checked = e.Node.Checked
                    If nodo1.HasChildren Then
                        For Each nodo2 As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo1.Nodes
                            nodo2.Checked = e.Node.Checked
                        Next
                    End If
                Next

            End If
            'Else
            '    If e.Node.Checked Then
            '        e.Node.ParentNode.CheckState = CheckState.Indeterminate
            '        e.Node.ParentNode.Checked = True
            '    Else
            '        e.Node.ParentNode.CheckState = CheckState.Unchecked
            '        e.Node.ParentNode.Checked = False
            '    End If


        End If
    End Sub


    Private Sub frmUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub
    Private Sub cargarGrupos()
        Try

        
            'waitDialgo = New WaitDialogForm("Cargando Grupos....", "Espere por favor")
            mostarWait(Me, "Cargando Grupos...", "Espere por favor")
            vDTGrupos = Nothing
            vDTGrupos = EjecutarProcedimientoP("1", vConexion.vidBodega, "1", "paBGruposUsuariosPermisos")

            Thread.Sleep(500)
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            gridGrupos.DataSource = vDTGrupos
            'GridViewProductosD_FocusedRowChanged New Object,New )
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            XtraMessageBox.Show("Hay un error: " & ex.Message, "VINNS", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frmTmpo As frmGruposNuevo = New frmGruposNuevo
        frmTmpo.vNuevoGrupo = True
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            cargarGrupos()
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If GridViewGrupos.FocusedRowHandle < 0 Then Exit Sub
        If GridViewGrupos.RowCount < 1 Then Exit Sub
        Dim frmTmpo As frmGruposNuevo = New frmGruposNuevo
        frmTmpo.vDRModificarGrupo = GridViewGrupos.GetDataRow(GridViewGrupos.FocusedRowHandle)
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            cargarGrupos()
        End If
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Dim vNoGuardo As Boolean = False
        If GridViewGrupos.FocusedRowHandle < 0 Then vNoGuardo = True
        If GridViewGrupos.RowCount < 1 Then vNoGuardo = True
        If vNoGuardo Then
            XtraMessageBox.Show("No se han guardado los cambios.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If XtraMessageBox.Show("Desea guardar los permisos para el Grupo de: " & GridViewGrupos.GetRowCellValue(GridViewGrupos.FocusedRowHandle, "nombre"), "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Try


                Dim vDatosParaInsertar As datosInsertarInstruccion = Nothing
                Dim vidGrup As String = GridViewGrupos.GetRowCellValue(GridViewGrupos.FocusedRowHandle, "idGrupo")
                vDatosParaInsertar = INICIARTRANSACCION(vDatosParaInsertar)
                ''eliminar permisos antes del grupo para despues guardar

                ''vDatosParaInsertar.instruccion = "delete tpermisos where idgrupo=" & GridViewGrupos.GetRowCellValue(GridViewGrupos.FocusedRowHandle, "idGrupo") & " and boton=1"
                vDatosParaInsertar = AGREGARTRAN(vDatosParaInsertar, "delete tpermisos where idgrupo=" & vidGrup)

                ''PERMISOS PARA ACCESO A BOTONES***************
                For x As Integer = 0 To tlControles.Nodes.Count - 1
                    '' PRIMIR NIVEL   
                    vDatosParaInsertar = AGREGARTRAN(vDatosParaInsertar, "insert into tpermisos (nombre,boton,habilitado,idGrupo) values('" & tlControles.Nodes(x).Tag & "',1," & tlControles.Nodes(x).Checked.GetHashCode & "," & vidGrup & ")")

                    For Each nodo As DevExpress.XtraTreeList.Nodes.TreeListNode In tlControles.Nodes(x).Nodes

                        If nodo.HasChildren Then
                            For Each nodo2 As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo.Nodes
                                'MsgBox(nodo2.Tag)
                                vDatosParaInsertar = AGREGARTRAN(vDatosParaInsertar, "insert into tpermisos (nombre,boton,habilitado,idGrupo) values('" & nodo2.Tag & "',1," & nodo2.Checked.GetHashCode & "," & vidGrup & ")")
                            Next
                        End If
                        vDatosParaInsertar = AGREGARTRAN(vDatosParaInsertar, "insert into tpermisos (nombre,boton,habilitado,idGrupo) values('" & nodo.Tag & "',1," & nodo.Checked.GetHashCode & "," & vidGrup & ")")
                    Next

                Next
                ''PERMISOS PARA ACCIONES EN LOS FORMULARIOS
                vDatosParaInsertar = sacarPermisosControles(vidGrup, vDatosParaInsertar)
                Dim vError As String = TERMINARBIENTRAN(vDatosParaInsertar, "paInsertarInstrucciones")
                XtraMessageBox.Show("Permisos actualizados", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'TERMINARMALTRAN()
                XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        If GridViewGrupos.FocusedRowHandle < 0 Then Exit Sub
        If GridViewGrupos.RowCount < 1 Then Exit Sub
        Dim frmTmpo As frmUsuarios = New frmUsuarios
        frmTmpo.ShowDialog()
        If Not frmTmpo.oCancelar Then
            cargarGrupos()
        End If

    End Sub

    Private Sub GridViewGrupos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewGrupos.FocusedRowChanged
        cargarPermisos()
        cargarPermisosDetalle()
    End Sub


    Private Sub GridViewGrupos_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridViewGrupos.RowClick
        'cargarPermisos()
    End Sub
    Private Sub cargarPermisos()
        If GridViewGrupos.FocusedRowHandle < 0 Then Exit Sub
        If GridViewGrupos.RowCount < 1 Then Exit Sub
        Try
            'waitDialgo = New WaitDialogForm("Cargando Permisos....", "Espere por favor")
            mostarWait(Me, "Cargando Permisos...", "Espere por favor")

            Dim idGrup As String = GridViewGrupos.GetRowCellValue(GridViewGrupos.FocusedRowHandle, "idGrupo")
            vDTPermisos = Nothing
            vDTPermisos = EjecutarSelect("select * from tpermisos where idgrupo=" & idGrup)
            Thread.Sleep(500)
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            If vDTPermisos.Rows.Count > 0 Then

                Dim vDRRecorrido As DataRow() = Nothing
                For x As Integer = 0 To tlControles.Nodes.Count - 1
                    '' PRIMIR NIVEL   ARBOL
                    tlControles.Nodes(x).Checked = asignarPermiso(vDTPermisos.Select("nombre='" & tlControles.Nodes(x).Tag & "'"))

                    For Each nodo As DevExpress.XtraTreeList.Nodes.TreeListNode In tlControles.Nodes(x).Nodes

                        If nodo.HasChildren Then
                            For Each nodo2 As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo.Nodes
                                'MsgBox(nodo2.Tag)
                                ''TERCER NIVEL ARBOL
                                nodo2.Checked = asignarPermiso(vDTPermisos.Select("nombre='" & nodo2.Tag & "'"))
                            Next
                        End If
                        '' SEGUNDO NIVEL ARBOL
                        nodo.Checked = asignarPermiso(vDTPermisos.Select("nombre='" & nodo.Tag & "'"))
                    Next

                Next
           
            Else
                asignarPermisoFalso()
            End If

      

            'GridViewProductosD_FocusedRowChanged New Object,New )
       
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            asignarPermisoFalso()
            XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub asignarPermisoFalso()
        For x As Integer = 0 To tlControles.Nodes.Count - 1
            '' PRIMIR NIVEL   ARBOL
            tlControles.Nodes(x).Checked = False

            For Each nodo As DevExpress.XtraTreeList.Nodes.TreeListNode In tlControles.Nodes(x).Nodes

                If nodo.HasChildren Then
                    For Each nodo2 As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo.Nodes
                        'MsgBox(nodo2.Tag)
                        ''TERCER NIVEL ARBOL
                        nodo2.Checked = False
                    Next
                End If
                '' SEGUNDO NIVEL ARBOL
                nodo.Checked = False
            Next

        Next

    End Sub
    Private Function asignarPermiso(ByVal vValor As DataRow()) As Boolean
        Try

        
            If vValor.GetUpperBound(0) >= 0 Then

                If CBool(vValor(0).Item("habilitado").ToString) Then
                    Return True
                Else
                    Return False
                End If

            End If
        Catch ex As Exception
            XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Private Sub tlControles_AfterFocusNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles tlControles.AfterFocusNode
        If e.Node.Level = 2 Then mostrarControl(e.Node.Tag, e.Node.GetValue(0))
    End Sub

    Private Sub SeleccionarTodosPermisosParaCadaFormularioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarTodosPermisosParaCadaFormularioToolStripMenuItem.Click
        limpiarControles(True, "")
    End Sub

    Private Sub QuitarTodasLasSeleccionesEnLosPermisosParaCadaFormularioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarTodasLasSeleccionesEnLosPermisosParaCadaFormularioToolStripMenuItem.Click
        limpiarControles(False, "")
    End Sub
    Private Sub cargarPermisosDetalle()
        For Each tabP As DevExpress.XtraTab.XtraTabPage In xtcPrincipal.TabPages
            For Each controlTab In tabP.Controls
                Dim listado As DevExpress.XtraEditors.CheckedListBoxControl = CType(controlTab, DevExpress.XtraEditors.CheckedListBoxControl)
                For x As Integer = 0 To listado.Items.Count - 1
                    'If listado.Items(x).CheckState = CheckState.Checked Then
                    '    vDatosParaInsertar01 = AGREGARTRAN(vDatosParaInsertar01, "insert into tpermisos (nombre,boton,habilitado,idGrupo) values('" & listado.Items(x).Value & "',0," & listado.Items(x).CheckState.GetHashCode & "," & vIdValor & ")")
                    'End If
                    If verificarPermisoInterno(listado.Items(x).Value) Then
                        listado.Items(x).CheckState = CheckState.Checked
                    Else
                        listado.Items(x).CheckState = CheckState.Unchecked
                    End If

                Next
            Next
        Next
    End Sub
    Private Function verificarPermisoInterno(ByVal formu As String, Optional ByVal tipo As Integer = 0) As Boolean
        If IsDBNull(vDTPermisos) Then Return False
        If vDTPermisos.Rows.Count = 0 Then Return False
        If formu Is Nothing Then Return False
        Try
            Dim vDRDatos As DataRow() = vDTPermisos.Select("nombre='" & formu & "'")
            If vDRDatos.GetLength(0) > 0 Then
                If CBool(vDRDatos(0).Item("habilitado")) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False

        End Try
    End Function
End Class