Imports Fitness_Club_Management_System

Public Class AddEmployee
    Dim db As New Database

    Private Sub AddMember_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtID.Text = My.Settings.EmployeeID
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

    Private Sub button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            db.open()
            Dim str As String
            str = "insert into Employee([ID],[First Name],[Last Name],[Contact No],[Address],[Date Of Joining],[Role],[Schedule],[Salary]) values (?,?,?,?,?,?,?,?,?)"
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("ID", CType(txtID.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("First Name", CType(txtFirstName.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Last Name", CType(txtLastName.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Contact No", CType(txtContactNo.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Address", CType(txtAddress.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Date Of Joining", CType(dateTimePicker1.Value, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Role", CType(cmbRole.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Schedule", CType(cmbSchedule.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Salary", CType(txtSalary.Text, Integer)))

            db.executeCommand(str)
            MessageBox.Show("SAVED SUCCESSFULLY")
            My.Settings.EmployeeID += 1
            My.Settings.Save()
            txtID.Text = My.Settings.EmployeeID
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtContactNo.Text = ""
            txtAddress.Text = ""
            txtSalary.Text = ""
            dateTimePicker1.Value = DateValue(Now)
            cmbSchedule.Text = ""
            cmbRole.Text = ""
            db.close()
        Catch ex As Exception
            MessageBox.Show("Unable To Add Member Due To Some Problem")
            db.close()
        End Try

    End Sub
End Class