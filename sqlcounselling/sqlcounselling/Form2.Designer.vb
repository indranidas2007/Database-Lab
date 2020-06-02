<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.student_name = New System.Windows.Forms.TextBox()
        Me.course_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ranking = New System.Windows.Forms.TextBox()
        Me.category = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnicounsellingDataSet3 = New sqlcounselling.unicounsellingDataSet3()
        Me.UnicounsellingDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UnicounsellingDataSet1 = New sqlcounselling.unicounsellingDataSet1()
        Me.UnicounsellingDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnicounsellingDataSet = New sqlcounselling.unicounsellingDataSet()
        Me.UnicounsellingDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New sqlcounselling.unicounsellingDataSet3TableAdapters.studentTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'student_name
        '
        Me.student_name.Location = New System.Drawing.Point(87, 60)
        Me.student_name.Name = "student_name"
        Me.student_name.Size = New System.Drawing.Size(189, 20)
        Me.student_name.TabIndex = 1
        '
        'course_name
        '
        Me.course_name.Location = New System.Drawing.Point(87, 104)
        Me.course_name.Name = "course_name"
        Me.course_name.Size = New System.Drawing.Size(189, 20)
        Me.course_name.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STUDENT FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "COURSE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RANKING"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CATEGORY"
        '
        'ranking
        '
        Me.ranking.Location = New System.Drawing.Point(87, 140)
        Me.ranking.Name = "ranking"
        Me.ranking.Size = New System.Drawing.Size(189, 20)
        Me.ranking.TabIndex = 8
        '
        'category
        '
        Me.category.Location = New System.Drawing.Point(87, 175)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(189, 20)
        Me.category.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.CourseidDataGridViewTextBoxColumn, Me.SRankDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(282, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 324)
        Me.DataGridView1.TabIndex = 10
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
        Me.StudentBindingSource.DataSource = Me.UnicounsellingDataSet3
        '
        'UnicounsellingDataSet3
        '
        Me.UnicounsellingDataSet3.DataSetName = "unicounsellingDataSet3"
        Me.UnicounsellingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 33)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UnicounsellingDataSet1
        '
        Me.UnicounsellingDataSet1.DataSetName = "unicounsellingDataSet1"
        Me.UnicounsellingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnicounsellingDataSet1BindingSource
        '
        Me.UnicounsellingDataSet1BindingSource.DataSource = Me.UnicounsellingDataSet1
        Me.UnicounsellingDataSet1BindingSource.Position = 0
        '
        'UnicounsellingDataSet
        '
        Me.UnicounsellingDataSet.DataSetName = "unicounsellingDataSet"
        Me.UnicounsellingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnicounsellingDataSetBindingSource
        '
        Me.UnicounsellingDataSetBindingSource.DataSource = Me.UnicounsellingDataSet
        Me.UnicounsellingDataSetBindingSource.Position = 0
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.ranking)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.course_name)
        Me.Controls.Add(Me.student_name)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents student_name As TextBox
    Friend WithEvents course_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ranking As TextBox
    Friend WithEvents category As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UnicounsellingDataSet2BindingSource As BindingSource
    ' Friend WithEvents UnicounsellingDataSet2 As unicounsellingDataSet2
    Friend WithEvents Button2 As Button
    Friend WithEvents UnicounsellingDataSet1BindingSource As BindingSource
    Friend WithEvents UnicounsellingDataSet1 As unicounsellingDataSet1
    Friend WithEvents UnicounsellingDataSetBindingSource As BindingSource
    Friend WithEvents UnicounsellingDataSet As unicounsellingDataSet
    Friend WithEvents UnicounsellingDataSet3 As unicounsellingDataSet3
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As unicounsellingDataSet3TableAdapters.studentTableAdapter
    Friend WithEvents SidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SRankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
