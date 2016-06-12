Imports System.Management
Imports System.Security.Cryptography
Imports System.Text

Public Class helper

    Public Shared Function GetProcessorId() As String
        Dim manClass As ManagementClass = New ManagementClass("Win32_Processor")
        Dim manObjCol As ManagementObjectCollection = manClass.GetInstances()
        Dim ProcessorId As String = String.Empty
        For Each manObj As ManagementObject In manObjCol
            ProcessorId = manObj.Properties("ProcessorId").Value.ToString()
        Next
        Return ProcessorId
    End Function

    Public Shared Function GenerarMD5(ByVal sCadena As String) As String

        ' Objeto de codificación
        Dim ueCodigo As New UnicodeEncoding()
        ' Objeto para instanciar las codificación
        Dim Md5 As New MD5CryptoServiceProvider()

        ' Calcula el valor hash de la cadena recibida
        Dim bHash() As Byte = Md5.ComputeHash(ueCodigo.GetBytes(sCadena))

        ' Convierte el hash en una cadena y lo devuelve
        Return Convert.ToBase64String(bHash)

    End Function


End Class
