<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enroll = New System.Windows.Forms.TextBox()
        Me.admission = New System.Windows.Forms.TextBox()
        Me.center_ad = New System.Windows.Forms.TextBox()
        Me.course_ad = New System.Windows.Forms.TextBox()
        Me.student_id = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mop = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(527, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMISSION DETAILS"
        '
        'enroll
        '
        Me.enroll.Location = New System.Drawing.Point(515, 69)
        Me.enroll.Name = "enroll"
        Me.enroll.Size = New System.Drawing.Size(213, 20)
        Me.enroll.TabIndex = 2
        '
        'admission
        '
        Me.admission.Location = New System.Drawing.Point(515, 216)
        Me.admission.Name = "admission"
        Me.admission.Size = New System.Drawing.Size(213, 20)
        Me.admission.TabIndex = 3
        '
        'center_ad
        '
        Me.center_ad.Location = New System.Drawing.Point(515, 178)
        Me.center_ad.Name = "center_ad"
        Me.center_ad.Size = New System.Drawing.Size(213, 20)
        Me.center_ad.TabIndex = 4
        '
        'course_ad
        '
        Me.course_ad.Location = New System.Drawing.Point(515, 141)
        Me.course_ad.Name = "course_ad"
        Me.course_ad.Size = New System.Drawing.Size(213, 20)
        Me.course_ad.TabIndex = 5
        '
        'student_id
        '
        Me.student_id.Location = New System.Drawing.Point(515, 106)
        Me.student_id.Name = "student_id"
        Me.student_id.Size = New System.Drawing.Size(213, 20)
        Me.student_id.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(653, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ENROLL ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "STUDENT ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "COURSE ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CENTER ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(389, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DATE OF ADMISSION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "MONTH OF PAYMENT"
        '
        'mop
        '
        Me.mop.Location = New System.Drawing.Point(515, 258)
        Me.mop.Name = "mop"
        Me.mop.Size = New System.Drawing.Size(213, 20)
        Me.mop.TabIndex = 14
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.student_id)
        Me.Controls.Add(Me.course_ad)
        Me.Controls.Add(Me.center_ad)
        Me.Controls.Add(Me.admission)
        Me.Controls.Add(Me.enroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents enroll As TextBox
    Friend WithEvents admission As TextBox
    Friend WithEvents center_ad As TextBox
    Friend WithEvents course_ad As TextBox
    Friend WithEvents student_id As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mop As TextBox
End Class
