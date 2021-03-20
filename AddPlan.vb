Public Class AddPlan

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        Dim db As New Database
        Try
            db.open()
            Dim str As String
            str = "insert into Plan([Plan Name],[One Month Amount],[Three Month Amount],[Six Month Amount],[one Year Amount]) values (?,?,?,?,?)"
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Plan Name", CType(txtplanType.Text, String)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("One Month Amount", CType(txtAmt1.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Three Month Amount", CType(txtAmt3.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("Six Month Amount", CType(txtAmt6.Text, Integer)))
            db.cmd.Parameters.Add(New OleDb.OleDbParameter("One Year Amount", CType(txtAmt1yr.Text, Integer)))

            db.executeCommand(str)
            MsgBox("Plan Details Saved Successfully", MsgBoxStyle.Information)
            My.Settings.MemberID += 1
            My.Settings.Save()
            txtplanType.Text = ""
            txtAmt1.Text = ""
            txtAmt3.Text = ""
            txtAmt6.Text = ""
            txtAmt1yr.Text = ""
            db.close()
        Catch ex As Exception
            MsgBox("Unable To Add Plan Due To Some Problem", MsgBoxStyle.Critical)
            db.close()
        End Try

    End Sub

    Private Sub txtplanType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtplanType.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 8) Or (Asc(e.KeyChar) = 32) Then
        Else
            MsgBox("Numbers & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtplanType.Clear()
        End If
    End Sub

    Private Sub txtAmt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt1.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt1.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt1.Clear()
        Else
        End If
    End Sub

    Private Sub txtAmt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt3.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt3.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt3.Clear()
        Else
        End If
    End Sub

    Private Sub txtAmt6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt6.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt6.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt6.Clear()
        Else
        End If
    End Sub

    Private Sub txtAmt1yr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt1yr.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt1yr.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtAmt1yr.Clear()
        Else
        End If
    End Sub

End Class