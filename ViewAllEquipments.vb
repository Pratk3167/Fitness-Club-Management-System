Imports Fitness_Club_Management_System

Public Class ViewAllEquipments
    Dim db As New Database
    Private Sub ViewAllEquipments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String
        db.open()
        str = "select * from Equipment"
        db.executeGrid(str, "Equipment")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Equipment"
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
        str = "select * from Equipment where [Name Of Equipment] like '%" & txtSearch.Text & "%' "
        db.executeGrid(str, "Equipment")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Equipment"
        db.close()
    End Sub

End Class