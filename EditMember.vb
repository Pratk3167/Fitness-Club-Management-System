Imports Fitness_Club_Management_System

Public Class EditMember
    Dim db As New Database
    Dim delID As Integer
    Dim a As Integer
    Private Sub UpdateDeleteMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datagridRefresh()
        totalids()
        'txtDiscount.Text = ""
        txtPlanType.Text = ""
        txtAmount.Text = ""
        txtFinalAmount.Text = ""
    End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cmbRefresh()
    'End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            Dim str As String
            db.open()
            str = "update Member set [ID]=?,[First Name]=?,[Last Name]=?,[Contact No]=?,[Address]=?,[Amount]=?,[Plan Type]=?,[Date Of Joining]=?,[Final Amount]=? where [ID]=" & txtID.Text & ""
            db.cmd.Parameters.AddWithValue("ID", txtID.Text)
            db.cmd.Parameters.AddWithValue("First Name", txtFirstName.Text)
            db.cmd.Parameters.AddWithValue("Last Name", txtLastName.Text)
            db.cmd.Parameters.AddWithValue("Contact No", txtContactNo.Text)
            db.cmd.Parameters.AddWithValue("Address", txtAddress.Text)
            db.cmd.Parameters.AddWithValue("Amount", txtAmount.Text)
            db.cmd.Parameters.AddWithValue("Plan Type", txtPlanType.Text)
            db.cmd.Parameters.AddWithValue("Date Of Joining", CType(txtDOJ.Value, Date))
            ' db.cmd.Parameters.AddWithValue("Discount", txtDiscount.Text)
            db.cmd.Parameters.AddWithValue("Final Amount", txtFinalAmount.Text)
            'db.cmd.Parameters.AddWithValue("Date Of Joining", dateTimePicker1.Value)
            db.executeCommand(str)
            MessageBox.Show("Member Details Updated Successfully")
            db.close()
            'ComboBox2.Items.Clear()s
            'cmbRefresh()
            db.ds.Clear()
            dataGridView1.DataSource = db.ds
            datagridRefresh()
        Catch ex As Exception
            db.close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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
        str = "select * from Member where [First Name] like '%" & txtSearch.Text & "%' "
        db.executeGrid(str, "Member")
        dataGridView1.DataSource = db.ds
        dataGridView1.DataMember = "Member"
        db.close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        db.ds.Clear()
        dataGridView1.DataSource = db.ds
        datagridRefresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim str As String
            db.open()
            str = "delete from Member where [ID]=" & txtID.Text & ""
            db.executeCommand(str)
            MessageBox.Show("Member Data Deleted Successfully")
            My.Settings.MemberID -= 1
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
            txtAmount.Text = ""
            txtID.Text = ""
            txtSearch.Text = ""
            txtPlanType.Text = ""
            ' txtDiscount.Text = ""
            txtFinalAmount.Text = ""
            txtDOJ.Value = DateValue(Now)
            Dim i As Integer
            Dim str2 As String
            For i = 1 To subID
                db.open()
                str2 = "update Member set [ID]=" & delID & " where [ID]=" & (delID + 1) & ""
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

    Public Sub totalids()
        db.open()
        Dim str1 As String
        str1 = "Select * from Member"
        db.executeReader(str1)
        If db.dr.HasRows Then
            While db.dr.Read
                a += 1
            End While
        End If
        db.close()
    End Sub

    Private Sub dataGridView1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGridView1.Click
        Try
            txtID.Text = dataGridView1.Item(0, dataGridView1.CurrentRow.Index).Value
            txtFirstName.Text = dataGridView1.Item(1, dataGridView1.CurrentRow.Index).Value
            txtLastName.Text = dataGridView1.Item(2, dataGridView1.CurrentRow.Index).Value
            txtContactNo.Text = dataGridView1.Item(3, dataGridView1.CurrentRow.Index).Value
            txtAddress.Text = dataGridView1.Item(5, dataGridView1.CurrentRow.Index).Value
            txtAmount.Text = dataGridView1.Item(9, dataGridView1.CurrentRow.Index).Value
            txtPlanType.Text = dataGridView1.Item(8, dataGridView1.CurrentRow.Index).Value
            txtDOJ.Value = dataGridView1.Item(7, dataGridView1.CurrentRow.Index).Value
            ' txtDiscount.Text = dataGridView1.Item(10, dataGridView1.CurrentRow.Index).Value
            txtFinalAmount.Text = dataGridView1.Item(10, dataGridView1.CurrentRow.Index).Value
            delID = Val(txtID.Text)
        Catch ex As Exception
            '  MessageBox.Show("Invalid Data")
        End Try

    End Sub

    Public Function fixDateTimeForMsAccess(ByVal value As Date) As Date
        Return New Date(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second)
    End Function

    Private Sub btnPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.Click
        ViewAllPlans.Show()
    End Sub

    Private Sub TextBox8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinalAmount.MouseEnter
        txtFinalAmount.Text = Val(txtAmount.Text)

    End Sub

End Class
