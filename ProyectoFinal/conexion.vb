Imports System.Data.OleDb
Module conexion
    Public conexion1 As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\CBTis137_antigua.accdb")
End Module
