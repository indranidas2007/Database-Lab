﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnicounsellingDataSet1 = New sqlcounselling.unicounsellingDataSet1()
        Me.StudentTableAdapter = New sqlcounselling.unicounsellingDataSet1TableAdapters.studentTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.CourseidDataGridViewTextBoxColumn, Me.SRankDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(247, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 270)
        Me.DataGridView1.TabIndex = 0
        '
        'SidDataGridViewTextBoxColumn
        '
        Me.SidDataGridViewTextBoxColumn.DataPropertyName = "s_id"
        Me.SidDataGridViewTextBoxColumn.HeaderText = "s_id"
        Me.SidDataGridViewTextBoxColumn.Name = "SidDataGridViewTextBoxColumn"
        Me.SidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "s_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "s_name"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'CourseidDataGridViewTextBoxColumn
        '
        Me.CourseidDataGridViewTextBoxColumn.DataPropertyName = "course_id"
        Me.CourseidDataGridViewTextBoxColumn.HeaderText = "course_id"
        Me.CourseidDataGridViewTextBoxColumn.Name = "CourseidDataGridViewTextBoxColumn"
        '
        'SRankDataGridViewTextBoxColumn
        '
        Me.SRankDataGridViewTextBoxColumn.DataPropertyName = "s_Rank"
        Me.SRankDataGridViewTextBoxColumn.HeaderText = "s_Rank"
        Me.SRankDataGridViewTextBoxColumn.Name = "SRankDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.UnicounsellingDataSet1
        '
        'UnicounsellingDataSet1
        '
        Me.UnicounsellingDataSet1.DataSetName = "unicounsellingDataSet1"
        Me.UnicounsellingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(441, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT INFORMATION"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ADD NEW STUDENT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(387, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ADD ADDRESS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(505, 389)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 24)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "PAYMENT DETAILS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(630, 389)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 24)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "ADMISSION DETAIL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(27, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 36)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "VIEW STUDENT DETAILS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ADMIN PAGE"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(27, 136)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(147, 37)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "ADMIN LOGIN"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UnicounsellingDataSet1 As unicounsellingDataSet1
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As unicounsellingDataSet1TableAdapters.studentTableAdapter
    Friend WithEvents SidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SRankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
End Class
