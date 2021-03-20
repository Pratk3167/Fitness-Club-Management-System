Imports Fitness_Club_Management_System
Public Class ViewAllEmployees
    Dim db As New Database
    Private Sub ViewAllEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str As String
        db.open()
        str = "select * from Employee"
        db.executeGrid(str, "Employee")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Employee"
        db.close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        db.ds.Clear()
        dataGridView1.DataSource = db.ds
        datagridRefresh()
    End Sub

    Public Sub datagridRefresh()
        Dim str As String
        db.open()
        str = "select * from Employee where [First Name] like '%" & txtSearch.Text & "%' "
        db.executeGrid(str, "Employee")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Employee"
        db.close()
    End Sub

End Class