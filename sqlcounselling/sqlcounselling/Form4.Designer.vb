<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.student_id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.amount = New System.Windows.Forms.TextBox()
        Me.mop = New System.Windows.Forms.TextBox()
        Me.d_date = New System.Windows.Forms.TextBox()
        Me.t_id = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(563, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENT DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STUDENT ID"
        '
        'student_id
        '
        Me.student_id.Location = New System.Drawing.Point(529, 99)
        Me.student_id.Name = "student_id"
        Me.student_id.Size = New System.Drawing.Size(188, 20)
        Me.student_id.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TRANSACTION ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "AMOUNT(In Rs.)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "MONTH OF  PAYMENT"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(529, 211)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(188, 20)
        Me.amount.TabIndex = 8
        '
        'mop
        '
        Me.mop.Location = New System.Drawing.Point(529, 248)
        Me.mop.Name = "mop"
        Me.mop.Size = New System.Drawing.Size(188, 20)
        Me.mop.TabIndex = 9
        '
        'd_date
        '
        Me.d_date.Location = New System.Drawing.Point(529, 180)
        Me.d_date.Name = "d_date"
        Me.d_date.Size = New System.Drawing.Size(188, 20)
        Me.d_date.TabIndex = 10
        '
        't_id
        '
        Me.t_id.Location = New System.Drawing.Point(529, 143)
        Me.t_id.Name = "t_id"
        Me.t_id.Size = New System.Drawing.Size(188, 20)
        Me.t_id.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(602, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.t_id)
        Me.Controls.Add(Me.d_date)
        Me.Controls.Add(Me.mop)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.student_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents student_id As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents amount As TextBox
    Friend WithEvents mop As TextBox
    Friend WithEvents d_date As TextBox
    Friend WithEvents t_id As TextBox
    Friend WithEvents Button2 As Button
End Class
