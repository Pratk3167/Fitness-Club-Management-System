<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.txtAmt1yr = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAmt6 = New System.Windows.Forms.TextBox
        Me.txtAmt3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAmt1 = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.btn = New System.Windows.Forms.Button
        Me.txtplanType = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Black
        Me.groupBox1.Controls.Add(Me.txtAmt1yr)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.txtAmt6)
        Me.groupBox1.Controls.Add(Me.txtAmt3)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.txtAmt1)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.btn)
        Me.groupBox1.Controls.Add(Me.txtplanType)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(56, 27)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(453, 353)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Fill the following information"
        '
        'txtAmt1yr
        '
        Me.txtAmt1yr.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAmt1yr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt1yr.ForeColor = System.Drawing.Color.White
        Me.txtAmt1yr.Location = New System.Drawing.Point(173, 245)
        Me.txtAmt1yr.Name = "txtAmt1yr"
        Me.txtAmt1yr.Size = New System.Drawing.Size(218, 24)
        Me.txtAmt1yr.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "1 Year Cost"
        '
        'txtAmt6
        '
        Me.txtAmt6.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAmt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt6.ForeColor = System.Drawing.Color.White
        Me.txtAmt6.Location = New System.Drawing.Point(173, 189)
        Me.txtAmt6.Name = "txtAmt6"
        Me.txtAmt6.Size = New System.Drawing.Size(218, 24)
        Me.txtAmt6.TabIndex = 4
        '
        'txtAmt3
        '
        Me.txtAmt3.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAmt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt3.ForeColor = System.Drawing.Color.White
        Me.txtAmt3.Location = New System.Drawing.Point(173, 137)
        Me.txtAmt3.Name = "txtAmt3"
        Me.txtAmt3.Size = New System.Drawing.Size(218, 24)
        Me.txtAmt3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "6 Month Cost"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "3 Month Cost"
        '
        'txtAmt1
        '
        Me.txtAmt1.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAmt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt1.ForeColor = System.Drawing.Color.White
        Me.txtAmt1.Location = New System.Drawing.Point(173, 86)
        Me.txtAmt1.Name = "txtAmt1"
        Me.txtAmt1.Size = New System.Drawing.Size(218, 24)
        Me.txtAmt1.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoEllipsis = True
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(48, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 20)
        Me.label2.TabIndex = 8
        Me.label2.Text = "1 Month Cost"
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.ForeColor = System.Drawing.Color.White
        Me.btn.Location = New System.Drawing.Point(173, 302)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(61, 28)
        Me.btn.TabIndex = 6
        Me.btn.Text = "Go"
        Me.btn.UseVisualStyleBackColor = False
        '
        'txtplanType
        '
        Me.txtplanType.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtplanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplanType.ForeColor = System.Drawing.Color.White
        Me.txtplanType.Location = New System.Drawing.Point(173, 40)
        Me.txtplanType.Name = "txtplanType"
        Me.txtplanType.Size = New System.Drawing.Size(218, 24)
        Me.txtplanType.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(48, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Plan Type"
        '
        'AddPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Fitness_Club_Management_System.My.Resources.Resources.gym_main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(564, 401)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "AddPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fitness Club Management"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtAmt1 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btn As System.Windows.Forms.Button
    Private WithEvents txtplanType As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtAmt1yr As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtAmt6 As System.Windows.Forms.TextBox
    Private WithEvents txtAmt3 As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
End Class
