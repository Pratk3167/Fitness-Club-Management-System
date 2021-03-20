Imports System
Imports System.Data
Imports System.Windows.Forms
Imports Fitness_Club_Management_System


Public Class StartupForm

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        While (ProgressBar1.Value <> 100)
            ProgressBar1.Value += 1
        End While
        If (ProgressBar1.Value > 50) Then
            Label1.Text = "Loading.."
            Timer2.Enabled = True
            Timer2.Start()
        Else
            Timer1.Stop()
            Timer1.Enabled = False
        End If
        If (ProgressBar1.Value > 100) Then
            Label1.Text = "Loading ..."
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.03

        If (Me.Opacity <= 0) Then
            Timer2.Enabled = False
            Me.Visible = False
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub StartupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Loading."
    End Sub

End Class




