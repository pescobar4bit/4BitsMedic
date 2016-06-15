Imports DevExpress.XtraEditors
Imports System.Threading
Imports DevExpress.Utils
Imports namespace4BITS.nsFuncionesVINNS
Public Class frmInputPass
    Dim mCancel As Boolean = True
    Dim vQueCoA As String = ""
    Dim waitDialgo As WaitDialogForm
    Dim midUsuario As Integer


    ReadOnly Property oCancelar() As Boolean
        Get
            Return mCancel
        End Get
    End Property

    ReadOnly Property oIdUsuario() As Integer
        Get
            Return midUsuario
        End Get
    End Property
    Private Sub frmInputPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Close()


        End Select
    End Sub



    Private Sub frmInputPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            'waitDialgo = New WaitDialogForm("Verificando datos....", "Espere por favor")
            mostarWait(Me, "Verificando datos...", "Espere por favor")
            Dim vDTPermi As DataTable = EjecutarSelect("select * from dbo.tGrupos INNER JOIN   dbo.tUsuarios ON dbo.tGrupos.idGrupo = dbo.tUsuarios.idGrupo where usuario='" & txtUsuario.Text.Trim & "' and dbo.tGrupos.idbodega=" & vConexion.vidBodega)
            Thread.Sleep(500)
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            Dim vSi As String = ""
            If vDTPermi Is Nothing Then vSi = ""

            If vDTPermi.Rows.Count > 0 Then



                If txtClave.Text.Trim <> EncryptString(vDTPermi.Rows(0).Item("clave"), "EJCGVINNS", DECRYPT) Then
                    vSi = ""
                Else
                    vSi = vDTPermi.Rows(0).Item("idGrupo")
                    midUsuario = vDTPermi.Rows(0).Item("idUsuario")
                End If



                If vSi = "" Then
                    mCancel = True
                    XtraMessageBox.Show("Acceso denegado. Usuario o contraseña incorrecta.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsuario.Focus()
                Else
                    Dim vSiTmpo As String = vSi

                    'waitDialgo = New WaitDialogForm("Verificando Permisos....", "Espere por favor")
                    mostarWait(Me, "Verificando permisos...", "Espere por favor")
                    vSi = ObtenerDato("tpermisos", "idPermiso", " idgrupo=" & vSiTmpo & " and nombre='" & vQueCoA & "' and habilitado=1")
                    Thread.Sleep(500)
                    'waitDialgo.Close()
                    mostarWait(Me, , , 1)
                    If vSi <> "" Then
                        mCancel = False
                        Close()
                    Else
                        XtraMessageBox.Show("Acceso denegado.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtUsuario.Focus()
                    End If
                End If
            Else
                mCancel = True
                XtraMessageBox.Show("Acceso denegado. Usuario o contraseña incorrecta.", "VINNS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Focus()
            End If
           
            'GridViewProductosD_FocusedRowChanged New Object,New )
        Catch ex As Exception
            'waitDialgo.Close()
            mostarWait(Me, , , 1)
            mCancel = True
            XtraMessageBox.Show("Error: " & ex.Message, "VINNS", MessageBoxButtons.OK)

        End Try

    End Sub

    Public Sub New(ByVal queControloAccion As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vQueCoA = queControloAccion
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        frmInputPass_KeyDown(New Object, New System.Windows.Forms.KeyEventArgs(Keys.Escape))
    End Sub

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Private Sub txtClave_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave.GotFocus
        txtClave.SelectAll()
    End Sub
End Class