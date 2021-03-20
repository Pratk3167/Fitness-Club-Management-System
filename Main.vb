Public Class Main

    Private Sub quitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub quiiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiiToolStripMenuItem.Click
        Me.Visible = False
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(2000, "Gym Management System Is Running In Background", "Gym Software Has Been Minimized To System Tray!", ToolTipIcon.Info)
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Me.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Visible = True
        NotifyIcon1.Visible = False
    End Sub

    Private Sub addToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToolStripMenuItem.Click
        AddMember.Show()
    End Sub

    Private Sub editToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editToolStripMenuItem.Click
        EditMember.Show()
    End Sub

    Private Sub viewAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllToolStripMenuItem1.Click
        ViewAllMembers.Show()
    End Sub

    Private Sub addToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToolStripMenuItem1.Click
        AddPlan.Show()
    End Sub

    Private Sub editToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editToolStripMenuItem1.Click
        EditPlan.Show()
    End Sub

    Private Sub viewAllToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllToolStripMenuItem2.Click
        ViewAllPlans.Show()
    End Sub

    Private Sub addToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToolStripMenuItem2.Click
        AddEmployee.Show()
    End Sub

    Private Sub editToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editToolStripMenuItem2.Click
        EditEmployee.Show()
    End Sub

    Private Sub viewAllToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllToolStripMenuItem3.Click
        ViewAllEmployees.Show()
    End Sub

    Private Sub addToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToolStripMenuItem3.Click
        AddEquipment.Show()
    End Sub

    Private Sub editToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editToolStripMenuItem3.Click
        EditEquipment.Show()
    End Sub

    Private Sub viewAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllToolStripMenuItem.Click
        ViewAllEquipments.Show()
    End Sub

    Private Sub aboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub SendPromotionalMailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PromotionalEmails.Show()
    End Sub

    Private Sub SendPromotionalMessagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PromotionalMessages.Show()
    End Sub

    Private Sub SendEventInvitesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EventMail.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        memberrpt.Show()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesToolStripMenuItem.Click
        employeerpt.Show()
    End Sub

    Private Sub EquipmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentsToolStripMenuItem.Click
        equipmentsrpt.Show()
    End Sub

    Private Sub PlansToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlansToolStripMenuItem.Click
        plansrpt.Show()
    End Sub

End Class