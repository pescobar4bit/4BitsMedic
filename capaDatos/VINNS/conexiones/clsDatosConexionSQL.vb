Namespace VINNS.conexiones
    Public NotInheritable Class clsDatosConexionSQL
        Private Const _nombreServidor As String = "jasmine.arvixe.com"
        Private Const _nombreBD As String = "imedicobdd"
        Private Const _claveBD As String = "Medico2016."
        Private Const _usuarioBD As String = "uimedicobdd"
        Public Shared ReadOnly cadenaConexion = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", clsDatosConexionSQL._nombreServidor, clsDatosConexionSQL._nombreBD, clsDatosConexionSQL._usuarioBD, clsDatosConexionSQL._claveBD)
    End Class
End Namespace