Imports Fitness_Club_Management_System

Public Class AddMember
    Dim db As New Database
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Try
            db.open()
            Dim str As String
            str = "insert into Member([ID],[First Name],[Last Name],[Contact No],[Gender],[Address],[Date Of Joining],[Plan Type],[Amount],[Final Amount]) values (?,?,?,?,?,?,?,?,?,?)"
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("ID", CType(txtID.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("First Name", CType(txtFirstName.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Last Name", CType(txtLastName.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Contact No", CType(txtContactNo.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Gender", CType(cmbGender.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Address", CType(txtAddress.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Date Of Joining", CType(dateTimePicker1.Value, Date)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Plan Type", CType(txtPlan.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Amount", CType(txtAmount.Text, Integer)))
            'db.cmd.Parameters.Add(New OleDb.OleDbParameter("Discount", CType(txtDiscount.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Final Amount", CType(txtFinalAmount.Text, Integer)))

            db.executeCommand(str)
            MsgBox("Member Details Saved Successfully", MsgBoxStyle.Information)
            My.Settings.MemberID += 1
            My.Settings.Save()
            txtID.Text = My.Settings.MemberID
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtContactNo.Text = ""
            cmbGender.Text = ""
            txtAddress.Text = ""
            txtAmount.Text = ""
            ' txtDiscount.Text = ""
            txtFinalAmount.Text = ""
            dateTimePicker1.Value = DateValue(Now)
            txtPlan.Text = ""
            db.close()
        Catch ex As Exception
            MsgBox("Unable To Add Member Due To Some Problem", MsgBoxStyle.Critical)
            db.close()
        End Try

    End Sub

    Private Sub AddMember_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'My.Settings.MemberID = 1
        txtID.Text = My.Settings.MemberID
        'txtDiscount.Text = 0
    End Sub

    Private Sub btnPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.Click
        ViewAllPlans.Show()
    End Sub

    Private Sub txtFirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 8) Or (Asc(e.KeyChar) = 32) Then
        Else
            MsgBox("Numbers & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtFirstName.Clear()
        End If
    End Sub

    Private Sub txtLastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 8) Or (Asc(e.KeyChar) = 32) Then
        Else
            MsgBox("Numbers & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtLastName.Clear()
        End If
    End Sub

    Private Sub txtContactNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtContactNo.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtContactNo.Clear()
        Else
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmount.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmount.Clear()
        Else
        End If
    End Sub

    Private Sub txtFinalAmount_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinalAmount.MouseEnter
        txtFinalAmount.Text = Val(txtAmount.Text)
    End Sub

End Class