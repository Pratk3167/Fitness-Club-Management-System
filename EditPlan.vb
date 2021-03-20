Imports Fitness_Club_Management_System

Public Class EditPlan
    Dim db As New Database
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim str As String
            db.open()
            str = "update Plan set [Plan Name]=?,[One Month Amount]=?,[Three Month Amount]=?,[Six Month Amount]=?,[One Year Amount]=? where [Plan Name]='" & cmbPlanType.Text & "'"
            db.cmd.Parameters.AddWithValue("Plan Name", cmbPlanType.Text)
            db.cmd.Parameters.AddWithValue("One Month Amount", txtAmt1.Text)
            db.cmd.Parameters.AddWithValue("Three Month Amount", txtAmt3.Text)
            db.cmd.Parameters.AddWithValue("Six Month Amount", txtAmt6.Text)
            db.cmd.Parameters.AddWithValue("One Year Amount", txtAmt1yr.Text)

            db.executeCommand(str)
            MessageBox.Show("Plan Details Updated Successfully")
            db.close()
            db.ds.Clear()
            cmbPlanType.Text = ""
            txtAmt1.Text = ""
            txtAmt3.Text = ""
            txtAmt6.Text = ""
            txtAmt1yr.Text = ""
        Catch ex As Exception
            db.close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbRefresh()
    End Sub

    Public Sub cmbRefresh()
        Dim str As String
        db.open()
        str = "select * from Plan"
        db.executeReader(str)
        If db.dr.HasRows Then
            While db.dr.Read
                cmbPlanType.Items.Add(db.dr("Plan Name"))
            End While
        End If
        db.close()
    End Sub

    Private Sub cmbPlanType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlanType.SelectedIndexChanged
        Dim str As String
        db.open()
        str = "select * from Plan where [Plan Name]='" & cmbPlanType.Text & "'"
        db.executeReader(str)
        If db.dr.HasRows Then
            While db.dr.Read
                txtAmt1.Text = db.dr("One Month Amount")
                txtAmt3.Text = db.dr("Three Month Amount")
                txtAmt6.Text = db.dr("Six Month Amount")
                txtAmt1yr.Text = db.dr("One Year Amount")
            End While
        End If
        db.close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim str As String
            db.open()
            str = "delete from Plan where [Plan Name]='" & cmbPlanType.Text & "'"
            db.executeCommand(str)
            MessageBox.Show("Plan Data Deleted Successfully")
            db.close()
            db.ds.Clear()
            cmbPlanType.Text = ""
            txtAmt1.Text = ""
            txtAmt3.Text = ""
            txtAmt6.Text = ""
            txtAmt1yr.Text = ""
        Catch ex As Exception
            db.close()
            MessageBox.Show("Unable To Delete Plan Data")
        End Try

    End Sub
End Class