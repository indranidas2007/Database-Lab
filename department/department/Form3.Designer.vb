<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.StaffidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssignDataSet = New department.assignDataSet()
        Me.AssignTableAdapter = New department.assignDataSetTableAdapters.assignTableAdapter()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS ASSIGNED"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(508, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ASSIGN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'classid
        '
        Me.classid.Location = New System.Drawing.Point(559, 82)
        Me.classid.Name = "classid"
        Me.classid.Size = New System.Drawing.Size(129, 20)
        Me.classid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CLASS ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(479, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "STAFF ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PROFESSOR NAME"
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(559, 118)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(129, 20)
        Me.sid.TabIndex = 6
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(559, 155)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(129, 20)
        Me.pname.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(613, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffidDataGridViewTextBoxColumn, Me.ClassidDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.AssignBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(54, 52)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(343, 206)
        Me.DataGridView3.TabIndex = 9
        '
        'StaffidDataGridViewTextBoxColumn
        '
        Me.StaffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.HeaderText = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.Name = "StaffidDataGridViewTextBoxColumn"
        '
        'ClassidDataGridViewTextBoxColumn
        '
        Me.ClassidDataGridViewTextBoxColumn.DataPropertyName = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.HeaderText = "class_id"
        Me.ClassidDataGridViewTextBoxColumn.Name = "ClassidDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "s_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "s_name"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'AssignBindingSource
        '
        Me.AssignBindingSource.DataMember = "assign"
        Me.AssignBindingSource.DataSource = Me.AssignDataSet
        '
        'AssignDataSet
        '
        Me.AssignDataSet.DataSetName = "assignDataSet"
        Me.AssignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssignTableAdapter
        '
        Me.AssignTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 277)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.classid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents classid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sid As TextBox
    Friend WithEvents pname As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents AssignDataSet As assignDataSet
    Friend WithEvents AssignBindingSource As BindingSource
    Friend WithEvents AssignTableAdapter As assignDataSetTableAdapters.assignTableAdapter
    Friend WithEvents StaffidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
