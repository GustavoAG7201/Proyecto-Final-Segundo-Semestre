Imports System.Data.OleDb

Public Class frmLogin

    Private conexion As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & Application.StartupPath & "\CBTis137.accdb")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Alonso Gutierrez Gustavo'
        frmMenu.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Gustavo Alonso Gutierrez'
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'


    End Sub
End Class
