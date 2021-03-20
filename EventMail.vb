Public Class EventMail

    Private Sub txtplanType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrom.KeyPress
        If ((Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 91)) Or ((Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122)) Or (Asc(e.KeyChar) = 46) Then
            MsgBox("Characters & Symbols Not Allowed!", MsgBoxStyle.Exclamation)
            txtFrom.Clear()
        ElseIf ((Asc(e.KeyChar) = 32)) Then
            MsgBox("Space Not Allowed!", MsgBoxStyle.Exclamation)
            txtFrom.Clear()
        Else
        End If
    End Sub

End Class