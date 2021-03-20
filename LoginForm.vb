Imports System
Imports System.Data
Imports System.Data.OleDb
Imports Fitness_Club_Management_System
Imports System.Windows.Forms

Public Class LoginForm

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Timer1.Enabled = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity += 0.05
        If (Me.Opacity > 0.98) Then
            Timer1.Enabled = False
            textBox1.Enabled = True
            textBox2.Enabled = True
            textBox1.Focus()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.05
        If (Me.Opacity <= 0) Then
            Me.Visible = False
            Timer2.Enabled = False
            Main.Show()
            Me.Close()
        End If
    End Sub


    Private Sub button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim db As New Database
        db.open()
        Dim str As String
        str = "select * from LoginTable where Username='" & textBox1.Text & "' and Password='" & textBox2.Text & "'"
        db.executeReader(str)
        If db.dr.Read = True Then
            MessageBox.Show("             Login Successful         ")
            button1.Enabled = False
            db.close()
            Timer2.Enabled = True
            Timer2.Start()
        Else
            MessageBox.Show("          Incorrect Username or Password          ")
            textBox1.Text = ""
            textBox2.Text = ""
        End If
    End Sub
End Class
