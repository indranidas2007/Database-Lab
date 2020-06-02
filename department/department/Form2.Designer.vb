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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.classid = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c_name = New System.Windows.Forms.TextBox()
        Me.strength = New System.Windows.Forms.TextBox()
        Me.year = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ClassDataSet = New department.classDataSet()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassTableAdapter = New department.classDataSetTableAdapters.classTableAdapter()
        Me.ClassidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(766, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(684, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'classid
        '
        Me.classid.Location = New System.Drawing.Point(716, 70)
        Me.classid.Name = "classid"
        Me.classid.Size = New System.Drawing.Size(192, 20)
        Me.classid.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(817, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(605, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CLASS ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(622, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(593, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "STRENGTH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(624, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "YEAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(421, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 9
        '
        'c_name
        '
        Me.c_name.Location = New System.Drawing.Point(716, 113)
        Me.c_name.Name = "c_name"
        Me.c_name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c_name.Size = New System.Drawing.Size(192, 20)
        Me.c_name.TabIndex = 10
        '
        'strength
        '
        Me.strength.Location = New System.Drawing.Point(716, 153)
        Me.strength.Name = "strength"
        Me.strength.Size = New System.Drawing.Size(192, 20)
        Me.strength.TabIndex = 11
        '
        'year
        '
        Me.year.Location = New System.Drawing.Point(716, 189)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(192, 20)
        Me.year.TabIndex = 12
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassidDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.StrengthDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ClassBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(86, 31)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(443, 287)
        Me.DataGridView2.TabIndex = 13
        '
        'ClassDataSet
        '
        Me.ClassDataSet.DataSetName = "classDataSet"
        Me.ClassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassBindingSource
        '
        Me.ClassBindingSource.DataMember = "class"
        Me.ClassBindingSource.DataSource = Me.ClassDataSet
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'ClassidDataGridViewTextBoxColumn
        '
        Me.ClassidDataGridViewTextBoxColumn.DataPropertyName = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.HeaderText = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.Name = "ClassidDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "c_name"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "c_name"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'StrengthDataGridViewTextBoxColumn
        '
        Me.StrengthDataGridViewTextBoxColumn.DataPropertyName = "strength"
        Me.StrengthDataGridViewTextBoxColumn.HeaderText = "strength"
        Me.StrengthDataGridViewTextBoxColumn.Name = "StrengthDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year_"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "year_"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 349)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.strength)
        Me.Controls.Add(Me.c_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.classid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents classid As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents c_name As TextBox
    Friend WithEvents year As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents strength As TextBox
    Friend WithEvents ClassDataSet As classDataSet
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As classDataSetTableAdapters.classTableAdapter
    Friend WithEvents ClassidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StrengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
