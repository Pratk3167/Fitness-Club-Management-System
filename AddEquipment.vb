Imports Fitness_Club_Management_System
Public Class AddEquipment
    Dim db As New Database
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            db.open()
            Dim str As String
            str = "insert into Equipment([ID],[Name Of Equipment],[Company],[Total Quantity],[Price Per Quantity],[Total Price],[Purchase Date]) values (?,?,?,?,?,?,?)"
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("ID", CType(txtID.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Name Of Equipment", CType(txtName.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Company", CType(txtCompany.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Total Quantity", CType(txtQuantity.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Price Per Quantity", CType(txtPrice.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Total Price", CType(txtTotalPrice.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Purchase Date", CType(dateTimePicker1.Value, String)))
            db.executeCommand(str)
            MessageBox.Show("Equipment Details Saved Successfully")
            My.Settings.EquipmentID += 1
            My.Settings.Save()
            txtID.Text = My.Settings.EquipmentID
            txtName.Text = ""
            txtCompany.Text = ""
            txtPrice.Text = ""
            txtQuantity.Text = ""
            txtTotalPrice.Text = ""
            dateTimePicker1.Value = DateValue(Now)
            db.close()
        Catch ex As Exception
            MessageBox.Show("Unable To Add Equipment Due To Some Problem")
            db.close()
        End Try

    End Sub


    Private Sub AddEquipment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtID.Text = My.Settings.EquipmentID
    End Sub

    Private Sub txtTotalPrice_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalPrice.MouseEnter
        txtTotalPrice.Text = Val(txtPrice.Text) * Val(txtQuantity.Text)
    End Sub

End Class