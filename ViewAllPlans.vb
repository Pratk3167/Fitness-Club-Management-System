Imports Fitness_Club_Management_System

Public Class ViewAllPlans

    Dim db As New Database

  
    Private Sub ViewAllPlans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String
        db.open()
        str = "select * from Plan"
        db.executeGrid(str, "Plan")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Plan"
        db.close()
    End Sub

    Private Sub dataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGridView1.Click
       
    End Sub

    Private Sub dataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        Try
            'AddMember.txtAmount.Text = dataGridView1.Item(1, dataGridView1.CurrentRow.Index).Value
            AddMember.txtAmount.Text = dataGridView1.Item(1, dataGridView1.CurrentRow.Index).Value
            AddMember.txtPlan.Text = dataGridView1.Item(0, dataGridView1.CurrentRow.Index).Value
            EditMember.txtAmount.Text = dataGridView1.Item(1, dataGridView1.CurrentRow.Index).Value
            EditMember.txtPlanType.Text = dataGridView1.Item(0, dataGridView1.CurrentRow.Index).Value
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Invalid Data")
            Me.Close()
        End Try
    End Sub
End Class