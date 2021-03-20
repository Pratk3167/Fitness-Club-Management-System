Imports System.Speech
Imports Fitness_Club_Management_System

Public Class Voice_Command
    Dim WithEvents reg As New Recognition.SpeechRecognitionEngine

    'OPEN ADD FUNCTIONS
    Private Sub openAddMember(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        AddMember.Show()
    End Sub
    Private Sub openAddEmployee(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        AddEmployee.Show()
    End Sub
    Private Sub openAddEquipment(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        AddEquipment.Show()
    End Sub
    Private Sub openAddPlan(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        AddPlan.Show()
    End Sub

    'CLOSE ADD FUNCTIONS
    Private Sub closeAddMember(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (AddMember.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            AddMember.Close()
        End If
    End Sub
    Private Sub closeAddEmployee(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (AddEmployee.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            AddEmployee.Close()
        End If
    End Sub
    Private Sub closeAddEquipment(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (AddEquipment.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            AddEquipment.Close()
        End If
    End Sub
    Private Sub closeAddPlan(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (AddPlan.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            AddPlan.Close()
        End If
    End Sub

    'CLOSE EDIT FUNCTIONS
    Private Sub closeEditMember(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (EditMember.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            EditMember.Close()
        End If
    End Sub
    Private Sub closeEditEmployee(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (EditEmployee.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            EditEmployee.Close()
        End If
    End Sub
    Private Sub closeEditEquipment(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (EditEquipment.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            EditEquipment.Close()
        End If
    End Sub
    Private Sub closeEditPlan(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (EditPlan.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            EditPlan.Close()
        End If
    End Sub

    'CLOSE VIEW ALL FUNCTIONS
    Private Sub closeViewAllMembers(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (ViewAllMembers.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            ViewAllMembers.Close()
        End If
    End Sub
    Private Sub closeViewAllEmployees(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (ViewAllEmployees.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            ViewAllEmployees.Close()
        End If
    End Sub
    Private Sub closeViewAllEquipment(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (ViewAllEquipments.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            ViewAllEquipments.Close()
        End If
    End Sub
    Private Sub closeViewAllPlans(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        If (ViewAllPlans.Enabled = True) Then
            synth.SpeakAsync("Closing " + Name)
            ViewAllPlans.Close()
        End If
    End Sub

    'OPEN EDIT FUNCTIONS
    Private Sub openEditMember(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        EditMember.Show()
    End Sub
    Private Sub openEditEmployee(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        EditEmployee.Show()
    End Sub
    Private Sub openEditEquipment(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        EditEquipment.Show()
    End Sub
    Private Sub openEditPlan(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        EditPlan.Show()
    End Sub

    'OPEN VIEW ALL FUNCTIONS
    Private Sub openViewAllMembers(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        ViewAllMembers.Show()
    End Sub
    Private Sub openViewAllEmployees(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        ViewAllEmployees.Show()
    End Sub
    Private Sub openViewAllEquipments(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        ViewAllEquipments.Show()
    End Sub
    Private Sub openViewAllPlans(ByVal Name As String)
        Dim synth As New Synthesis.SpeechSynthesizer
        synth.SpeakAsync("Opening " + Name)
        ViewAllPlans.Show()
    End Sub


    'FORM LOAD EVENT
    Private Sub Voice_Command_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reg.SetInputToDefaultAudioDevice()

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim form As New Recognition.SrgsGrammar.SrgsRule("Forms")
        Dim formlist As New Recognition.SrgsGrammar.SrgsOneOf("Add", "Open Add Employee", "Open Add Equipment", "Open Add Plan", "Open Edit Member", "Open Edit Employee", "Open Edit Equipment", "Open Edit Plan", "Open View All Members", "Open View All Employees", "Open View All Equipments", "Open View All Plans", "Close Add Member", "Close Add Employee", "Close Add Equipment", "Close Add Plan", "Close Edit Member", "Close Edit Employee", "Close Edit Equipment", "Close Edit Plan", "Close View All Members", "Close View All Employees", "Close View All Equipments", "Close VIew All Plans")
        form.Add(formlist)
        gram.Rules.Add(form)
        gram.Root = form
        reg.LoadGrammar(New Recognition.Grammar(gram))
        reg.RecognizeAsync()
    End Sub

    Private Sub reg_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reg.RecognizeCompleted
        reg.RecognizeAsync()
    End Sub

    Private Sub reg_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.SpeechRecognizedEventArgs) Handles reg.SpeechRecognized
        Select Case e.Result.Text
            Case "Add"
                openAddMember("Form Add Member")

            Case "Open Add Employee"
                openAddMember("Form Add Employee")

            Case "Open Add Equipment"
                openAddMember("Form Add Equipment")

            Case "Open Add Plan"
                openAddMember("Form Add Plan")

            Case "Open Edit Member"
                openEditMember("Form Edit Member")

            Case "Open Edit Employee"
                openEditEmployee("Form Edit Employee")

            Case "Open Edit Equipment"
                openAddEquipment("Form Edit Equipment")

            Case "Open Edit Plan"
                openEditPlan("Form Edit Plan")

            Case "Open View All Members"
                openViewAllMembers("Form View All Members")

            Case "Open View All Employees"
                openViewAllEmployees("Form View All Employees")

            Case "Open View All Equipments"
                openViewAllEquipments("Form View All Equipments")

            Case "Open View All Plans"
                openViewAllPlans("Form View All Plans")

            Case "Close Add Member"
                closeAddMember("Form Add Member")

            Case "Close Add Employee"
                closeAddEmployee("Form Add Employee")

            Case "Close Add Equipment"
                closeAddEquipment("Form Add Equipment")

            Case "Close Add Plan"
                closeAddPlan("Form Add Plan")

            Case "Close Edit Member"
                closeEditMember("Form Edit Plan")

            Case "Close Edit Employee"
                closeEditEmployee("Form Edit Employee")

            Case "Close Edit Equipment"
                closeEditEquipment("Form Edit Equipment")

            Case "Close Edit Plan"
                closeEditPlan("Form Edit Plan")

            Case "Close View All Members"
                closeViewAllMembers("Form View All Members")

            Case "Close View All Employees"
                closeViewAllEmployees("Form View All Employees")

            Case "Close View All Equipments"
                closeViewAllEquipment("Form View All Equipments")

            Case "Close View All Plans"
                closeViewAllPlans("Form View All Plans")

        End Select
    End Sub
End Class