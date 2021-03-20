Imports CrystalDecisions.CrystalReports.Engine

Public Class MemberReport

    Private Sub MemberReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\Mazhar\Documents\Fitness Club Management System\Fitness Club Management System\Fitness Club Management System\Members.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class