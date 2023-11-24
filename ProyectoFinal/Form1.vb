Public Class frmMenu

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Gustavo Alonso Gutierrez'
        Dim frmAcercaDe As New frmAcercaDe
        frmAcercaDe.MdiParent = Me
        frmAcercaDe.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        'Gustavo Alonso Gutierrez'
        Dim frmAgregarUsuarios As New frmAgregarUsuarios
        frmAgregarUsuarios.MdiParent = Me
        frmAgregarUsuarios.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        'Gustavo Alonso Gutierrez'
        Dim frmListaUsuarios As New frmListaUsuarios
        frmListaUsuarios.MdiParent = Me
        frmListaUsuarios.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        'Gustavo Alonso Gutierrez'
        Dim frmAgregarAlumnos As New frmAgregarAlumnos
        frmAgregarAlumnos.MdiParent = Me
        frmAgregarAlumnos.Show()
    End Sub

    Private Sub ListaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem1.Click
        'Gustavo Alonso Gutierrez'
        Dim frmListaAlumnos As New frmListaAlumnos
        frmListaAlumnos.MdiParent = Me
        frmListaAlumnos.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem2.Click
        'Gustavo Alonso Gutierrez'
        Dim frmAgregarMaterias As New frmAgregarMaterias
        frmAgregarMaterias.MdiParent = Me
        frmAgregarMaterias.Show()
    End Sub

    Private Sub ListaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem2.Click
        'Gustavo Alonso Gutierrez'
        Dim frmListaMaterias As New frmListaMaterias
        frmListaMaterias.MdiParent = Me
        frmListaMaterias.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem3.Click
        'Gustavo Alonso Gutierrez'
        Dim frmAgregarCalificaciones As New frmAgregarCalificaciones
        frmAgregarCalificaciones.MdiParent = Me
        frmAgregarCalificaciones.Show()
    End Sub

    Private Sub ListaToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem3.Click
        'Gustavo Alonso Gutierrez'
        Dim frmListaCalificaciones As New frmListaCalificaciones
        frmListaCalificaciones.MdiParent = Me
        frmListaCalificaciones.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
