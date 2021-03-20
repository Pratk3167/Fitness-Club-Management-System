Imports Fitness_Club_Management_System

Public Class EditEmployee
    Dim db As New Database
    Dim delID As Integer
    Dim a As Integer
    Private Sub UpdateDeleteMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagridRefresh()
        totalids()
        cmbRole.Items.Add("Manager")
        cmbRole.Items.Add("Trainer")
        cmbRole.Items.Add("Dietician/Dietitian")
        cmbRole.Items.Add("Receptionist")
        cmbRole.Items.Add("House-Keeping")
        cmbRole.Items.Add("Other")

        cmbSchedule.Items.Add("Morning")
        cmbSchedule.Items.Add("Evening")
        cmbSchedule.Items.Add("Full-Day")
    End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cmbRefresh()
    'End Sub


    'Public Sub cmbRefresh()
    '    Dim str As String
    '    db.open()
    '    str = "select * from Employee where [First Name]='" & ComboBox2.Text & "'"
    '    db.executeReader(str)
    '    If db.dr.HasRows Then
    '        While db.dr.Read
    '            TextBox6.Text = Val(db.dr("ID"))
    '            TextBox1.Text = db.dr("First Name").ToString
    '            textBox2.Text = db.dr("Last Name").ToString
    '            textBox3.Text = db.dr("Contact No")
    '            textBox4.Text = db.dr("Address").ToString
    '            textBox5.Text = Val(db.dr("Amount"))
    '            dateTimePicker1.Value = db.dr("Date Of Joining")
    '            comboBox1.Text = db.dr("Plan Type")
    '        End While
    '    End If
    '    db.close()
    'End Sub

    Public Sub datagridRefresh()
        Dim str As String
        db.open()
        str = "select * from Employee where [First Name] like '%" & txtSearch.Text & "%' "
        db.executeGrid(str, "Employee")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Employee"
        db.close()
    End Sub

    Public Sub totalids()
        db.open()
        Dim str1 As String
        str1 = "Select * from Employee"
        db.executeReader(str1)
        If db.dr.HasRows Then
            While db.dr.Read
                a += 1
            End While
        End If
        db.close()
    End Sub

    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        db.ds.Clear()
        dataGridView1.DataSource = db.ds
        datagridRefresh()
    End Sub



    Private Sub dataGridView1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGridView1.Click
        Try
            txtFirstName.Text = dataGridView1.Item(1, dataGridView1.CurrentRow.Index).Value
            txtLastName.Text = dataGridView1.Item(2, dataGridView1.CurrentRow.Index).Value
            txtID.Text = dataGridView1.Item(0, dataGridView1.CurrentRow.Index).Value
            txtContactNo.Text = dataGridView1.Item(3, dataGridView1.CurrentRow.Index).Value
            txtAddress.Text = dataGridView1.Item(4, dataGridView1.CurrentRow.Index).Value
            dateTimePicker1.Value = dataGridView1.Item(5, dataGridView1.CurrentRow.Index).Value
            cmbRole.Text = dataGridView1.Item(6, dataGridView1.CurrentRow.Index).Value
            cmbSchedule.Text = dataGridView1.Item(7, dataGridView1.CurrentRow.Index).Value
            txtSalary.Text = dataGridView1.Item(8, dataGridView1.CurrentRow.Index).Value
            delID = Val(txtID.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Data")
        End Try
    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim str As String
            db.open()
            str = "update Employee set [ID]=?,[First Name]=?,[Last Name]=?,[Contact No]=?,[Address]=?,[Role]=?,[Schedule]=?,[Salary]=? where [ID]=" & txtID.Text & "" '[Date Of Joining]=?
            db.cmd.Parameters.AddWithValue("ID", txtID.Text)
            db.cmd.Parameters.AddWithValue("First Name", txtFirstName.Text)
            db.cmd.Parameters.AddWithValue("Last Name", txtLastName.Text)
            db.cmd.Parameters.AddWithValue("Contact No", txtContactNo.Text)
            db.cmd.Parameters.AddWithValue("Address", txtAddress.Text)
            'db.cmd.Parameters.AddWithValue("Date Of Joining", dateTimePicker1.Value)
            db.cmd.Parameters.AddWithValue("Role", cmbRole.Text)
            db.cmd.Parameters.AddWithValue("Schedule", cmbSchedule.Text)
            db.cmd.Parameters.AddWithValue("Salary", txtSalary.Text)
            db.executeCommand(str)
            MessageBox.Show("Member Details Updated Successfully")
            db.close()
            'ComboBox2.Items.Clear()
            'cmbRefresh()
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
        Catch ex As Exception
            db.close()
            MessageBox.Show("Unable To Update Member Data")
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim str As String
            db.open()
            str = "delete from Employee where [ID]=" & txtID.Text & ""
            db.executeCommand(str)
            MessageBox.Show("Member Data Deleted Successfully")
            My.Settings.EmployeeID -= 1
            db.close()
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
            Dim subID As Integer
            subID = a - delID
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtContactNo.Text = ""
            txtAddress.Text = ""
            txtSalary.Text = ""
            txtID.Text = ""
            txtSearch.Text = ""
            cmbSchedule.Text = ""
            cmbRole.Text = ""
            dateTimePicker1.Value = DateValue(Now)
            Dim i As Integer
            Dim str2 As String
            For i = 1 To subID
                db.open()
                str2 = "update Employee set [ID]=" & delID & " where [ID]=" & (delID + 1) & ""
                delID += 1
                db.executeCommand(str2)
                db.close()
            Next
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
        Catch ex As Exception
            db.close()
            MessageBox.Show("Unable To Delete Member Data")
        End Try
    End Sub
End Class