﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrow
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.book_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mem_id = New System.Windows.Forms.TextBox()
        Me.issue = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BORROW"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'book_id
        '
        Me.book_id.Location = New System.Drawing.Point(105, 94)
        Me.book_id.Name = "book_id"
        Me.book_id.Size = New System.Drawing.Size(164, 20)
        Me.book_id.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BOOK ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MEMBER ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DUE DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "RETURN DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ISSUE"
        '
        'mem_id
        '
        Me.mem_id.Location = New System.Drawing.Point(105, 134)
        Me.mem_id.Name = "mem_id"
        Me.mem_id.Size = New System.Drawing.Size(164, 20)
        Me.mem_id.TabIndex = 8
        '
        'issue
        '
        Me.issue.Location = New System.Drawing.Point(105, 257)
        Me.issue.Name = "issue"
        Me.issue.Size = New System.Drawing.Size(164, 20)
        Me.issue.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(105, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "DISPLAY"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(105, 180)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(105, 215)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 15
        '
        'borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.issue)
        Me.Controls.Add(Me.mem_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.book_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "borrow"
        Me.Text = "borrow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents book_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mem_id As TextBox
    Friend WithEvents issue As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
