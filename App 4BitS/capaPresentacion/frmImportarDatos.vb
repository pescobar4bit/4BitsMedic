Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils

Public Class frmImportarDatos
    Private Conexion As OleDbConnection
    Dim cmComand As OleDbCommand
    Dim vDTAcces As DataTable = Nothing
    Dim vDTDepartamentos As DataTable = Nothing
    Dim waitDialgo As WaitDialogForm
    Public Sub AbrirConexionAcces(Optional ByVal tipoC As Integer = 2, Optional ByVal vnServidor As String = "", Optional ByVal vUsuario As String = "", Optional ByVal vNBDD As String = "", Optional ByVal vConstrasenia As String = "")
        '  On Error GoTo MensajeC

        Select Case tipoC
            Case 1
                'Cn = New SqlConnection("Data Source=" & vnServidor & ";Initial Catalog=" & vNBDD & ";Integrated Security=false;user ID=" & vUsuario & ";password=" & vConstrasenia)
            Case Else


                'Dim tmpNbdd As String = movRegistro.leerRegistro("bdd") 'conexionAct.vBdd
                'Dim tmpSvbdd As String = movRegistro.leerRegistro("source") 'conexionAct.vServidor
                'Dim tmpPsbdd = movRegistro.leerRegistro("password") 'conexionAct.vPasswordbdd
                'Dim tmpUsbdd = movRegistro.leerRegistro("user") 'conexionAct.vUsuariobdd

                Dim tmpoDirec As String = "" 'movRegistro.leerRegistro("direc")
                If tmpoDirec = "" Then tmpoDirec = txtDirec.Text 'Application.StartupPath & "\" & vPreferencias.vBDD '"\contactosmarsa.mdb"

                'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";Integrated Security=false;user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
                'Cn = New SqlConnection("Data Source=" & tmpSvbdd & ";Initial Catalog=" & tmpNbdd & ";user ID=" & tmpUsbdd & ";password=" & tmpPsbdd)
                'Provider=SQLOLEDB;Data Source=TERMINAL01;User ID=sa;Initial Catalog=ovejasIPEA
                Conexion = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & tmpoDirec)
                'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="V:\VINNS\Marsa Varios\Contactos Marsa\contactosmarsa.mdb";Persist Security Info=True;Jet OLEDB:Database Password=Vinns2010
        End Select
        Try
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error. " & ex.Message)

        End Try

        'MensajeC:
        '        If Err.Number <> 0 Then
        '            MsgBox("Error en conexion" & vbCrLf & Err.Description & " " & Err.Number, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "VINNS")
        '            Err.Number = 0
        '            Exit Sub
        '        End If
    End Sub

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click

        ofdAbrir.ShowDialog()
        txtDirec.Text = ofdAbrir.FileName
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        If txtDirec.Text.Length <= 0 Then Exit Sub
        AbrirConexionAcces()
        Try

        
            vDTAcces = Nothing
            vDTAcces = EjecutarInstruccion("select * from consulta1 order by idtienda asc")
            GridControl1.DataSource = vDTAcces
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Function EjecutarInstruccion(ByVal vSql As String) As DataTable
        'Este ejecuta un select y lo devuelve en forma de dataset
        'los criterios del where se dan en forma de variables.
        EjecutarInstruccion = New DataTable
        Dim daVista As New OleDbDataAdapter ' SqlDataAdapter

        AbrirConexionAcces()
        cmComand = New OleDbCommand(vSql, Conexion)
        cmComand.CommandType = CommandType.Text

        daVista.SelectCommand = cmComand
        daVista.Fill(EjecutarInstruccion)
        CerrarConexionAccess()
        Return EjecutarInstruccion
    End Function
    Public Sub CerrarConexionAccess()
        Conexion.Close()
        Conexion.Dispose()
        Conexion = Nothing
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        If XtraMessageBox.Show("Desea realmente importar los datos?", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
        waitDialgo = New WaitDialogForm("Cargando Rutas....", "Espere por favor")
        For Each filaAcces In vDTAcces.Rows
            Dim vIdPropietario As String = ObtenerDato("tpropietarios", "idPropietario", "nombre='" & filaAcces("CLIENTES.Nombre") & "' and codigo='" & filaAcces("CODCLIENTE") & "'")
            If vIdPropietario = "" Then 'PARA EL ID DEL PROPIETARIO
                INSERTAR("insert into tpropietarios (nombre,apellido,telefono,direccion,codigo,habilitado,idbodega) values('" _
                & filaAcces("CLIENTES.Nombre") & "','" & filaAcces("CLIENTES.Nombre") & "','" & filaAcces("TELEFONO") & "','" & filaAcces("NO_CASA") & "','" & filaAcces("CODCLIENTE") & "',1," & vConexion.vidBodega & ")")
                vIdPropietario = ObtenerDato("tpropietarios", " MAX(idPropietario)", "idPropietario>0")

            End If
            Dim vidEmpleado As String = ObtenerDato("templeados", "idEmpleado", "nombre='" & filaAcces("empleados.Nombre") & "' and apellido='" & filaAcces("Apellido") & "' and codigo='" & filaAcces("CODIGOE") & "'")
            If vidEmpleado = "" Then ' PARA EL ID DEL EMPLEADO
                INSERTAR("INSERT into templeados (nombre,apellido,idBodega,idCargo,activo,codigo,FECHAingreso,fechanac,direccion,telefono,cedula,celular,clave) values('" _
                         & filaAcces("empleados.Nombre") & "','" & filaAcces("Apellido") & "'," & vConexion.vidBodega & ",1,1,'" & filaAcces("CODIGOE") & "','" & FormatDateTime(Now, DateFormat.ShortDate) & " " & FormatDateTime(Now, DateFormat.ShortTime) & "','" & FormatDateTime(Now, DateFormat.ShortDate) & "'," _
                         & "'','','','',0)")
                vidEmpleado = ObtenerDato("templeados", "max(idEmpleado)", "nombre<>'1'")
            End If
            Dim vidRuta As String = ObtenerDato("trutas", "idRuta", "codigo='" & filaAcces("CATEGORIA") & "'  and idEmpleado=" & vidEmpleado)
            If vidRuta = "" Then 'PARA EL ID DE RUTA
                INSERTAR("insert into trutas (Ruta,idDepartamento,idEmpleado,idBodega,codigo,zona,otro) values('" _
                         & filaAcces("DIRECCION") & "'," & lueDepartamento.EditValue & "," & vidEmpleado & "," & vConexion.vidBodega & ",'" & filaAcces("CATEGORIA") & "','','')")
                vidRuta = ObtenerDato("trutas", "MAX(idRuta)", "idRuta>0")
            End If
            Dim vidMunicipio As String = ObtenerDato("tmunicipios", "idMunicipio", "municipio='" & filaAcces("DIRECCION") & "' AND idDepartamento=" & lueDepartamento.EditValue)
            If vidMunicipio = "" Then ' para el id del municipio
                INSERTAR("insert into tmunicipios (municipio,idDepartamento) values('" _
                         & filaAcces("DIRECCION") & "'," & lueDepartamento.EditValue & ")")
                vidMunicipio = ObtenerDato("tmunicipios", "MAX(idMunicipio)", "municipio='" & filaAcces("DIRECCION") & "' AND idDepartamento=" & lueDepartamento.EditValue)
            End If
            'INSERTAR TIENDA
            Dim vContinuar As Boolean = True
            If ObtenerDato("ttiendas", "idTienda", "nit='" & filaAcces("NIT") & "' AND direccion='" & filaAcces("NO_CASA") & "' and tienda='" & filaAcces("CLIENTES.Nombre") & "'") <> "" Then
                If XtraMessageBox.Show("Hay un registro igual, idTienda." & filaAcces("idTienda") & ", se ingresa este otro?", "VINNS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                    vContinuar = False
                End If
            End If
            If vContinuar Then
                INSERTAR("insert into ttiendas (cliente,tienda,codigo,direccion,telefono,nit,idruta,direccionF,fechacreada,idpropietario,idDepartamento,idMunicipio,latitud,longitud,correo,telefononoti,distancia) values('" _
                         & filaAcces("CLIENTES.Nombre") & "','" & filaAcces("CLIENTES.Nombre") & "','" & filaAcces("CODCLIENTE") & "','" & filaAcces("NO_CASA") & "','" & filaAcces("TELEFONO") _
                         & "','" & filaAcces("NIT") & "'," & vidRuta & ",'" & filaAcces("DIRECCION") & "','" & FormatDateTime(Now, DateFormat.ShortDate) & " " & FormatDateTime(Now, DateFormat.ShortTime) & "'," _
                & vIdPropietario & "," & lueDepartamento.EditValue & "," & vidMunicipio & ",'','','','',0)")
            End If
        Next
        Thread.Sleep(500)
        waitDialgo.Close()
        XtraMessageBox.Show("Proceso terminado", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmImportarDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vDTDepartamentos = Nothing
        vDTDepartamentos = EjecutarSelect("select * from tdepartamentos")
        lueDepartamento.Properties.DataSource = vDTDepartamentos
        lueDepartamento.ItemIndex = 0
    End Sub
End Class