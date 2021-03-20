Imports Fitness_Club_Management_System

Public Class EditEquipment
    Dim db As New Database
    Dim delID As Integer
    Dim a As Integer
    Private Sub UpdateDeleteMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagridRefresh()
        totalids()
    End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cmbRefresh()
    'End Sub


    'Public Sub cmbRefresh()
    '    Dim str As String
    '    db.open()
    '    str = "select * from Instructor where [First Name]='" & ComboBox2.Text & "'"
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
        str = "select * from Equipment where [Name Of Equipment] like '%" & txtSearch.Text & "%' "
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

    Public Sub totalids()
        db.open()
        Dim str1 As String
        str1 = "Select * from Equipment"
        db.executeReader(str1)
        If db.dr.HasRows Then
            While db.dr.Read
                a += 1
            End While
        End If
        db.close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim str As String
            db.open()
            str = "update Equipment set [ID]=?,[Name Of Equipment]=?,[Company]=?,[Total Quantity]=?,[Price Per Quantity]=?,[Total Price]=?,[Purchase Date]=? where [ID]=" & txtID.Text & ""
            db.cmd.Parameters.AddWithValue("ID", txtID.Text)
            db.cmd.Parameters.AddWithValue("Name Of Equipment", txtName.Text)
            db.cmd.Parameters.AddWithValue("Company", txtCompany.Text)
            db.cmd.Parameters.AddWithValue("Total Quantity", txtQuantity.Text)
            db.cmd.Parameters.AddWithValue("Price Per Quantity", txtPrice.Text)
            db.cmd.Parameters.AddWithValue("Total Price", txtTotalPrice.Text)
            db.cmd.Parameters.AddWithValue("Purchase Date", dateTimePicker1.Value)
            db.executeCommand(str)
            MessageBox.Show("Equipment Details Updated Successfully")
            db.close()
            'ComboBox2.Items.Clear()
            'cmbRefresh()
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
        Catch ex As Exception
            db.close()
            MessageBox.Show("Unable To Update Equipment Details")
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim str As String
            db.open()
            str = "delete from Equipment where [ID]=" & txtID.Text & ""
            db.executeCommand(str)
            MessageBox.Show("Equipment Data Deleted Successfully")
            My.Settings.EquipmentID -= 1
            db.close()
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
            Dim subID As Integer
            subID = a - delID
            txtCompany.Text = ""
            txtName.Text = ""
            txtPrice.Text = ""
            txtQuantity.Text = ""
            txtTotalPrice.Text = ""
            txtSearch.Text = ""
            dateTimePicker1.Value = DateValue(Now)
            Dim i As Integer
            Dim str2 As String
            For i = 1 To subID
                db.open()
                str2 = "update Equipment set [ID]=" & delID & " where [ID]=" & (delID + 1) & ""
                delID += 1
                db.executeCommand(str2)
                db.close()
            Next
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
        Catch ex As Exception
            db.close()
            MessageBox.Show("Unable To Delete Equipment Details")
        End Try

    End Sub

    Private Sub dataGridView1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGridView1.Click
        Try
            txtID.Text = dataGridView1.Item(0, dataGridView1.CurrentRow.Index).Value
            txtName.Text = dataGridView1.Item(1, dataGridView1.CurrentRow.Index).Value
            txtCompany.Text = dataGridView1.Item(2, dataGridView1.CurrentRow.Index).Value
            txtQuantity.Text = dataGridView1.Item(3, dataGridView1.CurrentRow.Index).Value
            txtPrice.Text = dataGridView1.Item(4, dataGridView1.CurrentRow.Index).Value
            txtTotalPrice.Text = dataGridView1.Item(5, dataGridView1.CurrentRow.Index).Value
            dateTimePicker1.Value = dataGridView1.Item(6, dataGridView1.CurrentRow.Index).Value
            delID = Val(txtID.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Data")
        End Try
    End Sub

    Private Sub txtTotalPrice_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalPrice.MouseEnter
        txtTotalPrice.Text = Val(txtPrice.Text) * Val(txtQuantity.Text)
    End Sub

End Class