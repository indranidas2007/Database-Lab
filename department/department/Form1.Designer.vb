<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.staff_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.s_name = New System.Windows.Forms.TextBox()
        Me.des = New System.Windows.Forms.TextBox()
        Me.sal = New System.Windows.Forms.TextBox()
        Me.phn = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffDataSet = New department.staffDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New department.staffDataSetTableAdapters.staffTableAdapter()
        Me.StaffidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntrydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'staff_id
        '
        Me.staff_id.Location = New System.Drawing.Point(107, 65)
        Me.staff_id.Name = "staff_id"
        Me.staff_id.Size = New System.Drawing.Size(200, 20)
        Me.staff_id.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STAFF ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "STAFF NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DESIGNATION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SALARY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "PHONE NO."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ENTRY DATE"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 41)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        's_name
        '
        Me.s_name.Location = New System.Drawing.Point(107, 110)
        Me.s_name.Name = "s_name"
        Me.s_name.Size = New System.Drawing.Size(200, 20)
        Me.s_name.TabIndex = 11
        '
        'des
        '
        Me.des.Location = New System.Drawing.Point(107, 149)
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(200, 20)
        Me.des.TabIndex = 12
        '
        'sal
        '
        Me.sal.Location = New System.Drawing.Point(107, 187)
        Me.sal.Name = "sal"
        Me.sal.Size = New System.Drawing.Size(200, 20)
        Me.sal.TabIndex = 13
        '
        'phn
        '
        Me.phn.Location = New System.Drawing.Point(107, 216)
        Me.phn.Name = "phn"
        Me.phn.Size = New System.Drawing.Size(200, 20)
        Me.phn.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 256)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffidDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.DesgDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EntrydateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(313, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 277)
        Me.DataGridView1.TabIndex = 17
        '
        'StaffDataSet
        '
        Me.StaffDataSet.DataSetName = "staffDataSet"
        Me.StaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.StaffDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffidDataGridViewTextBoxColumn
        '
        Me.StaffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.HeaderText = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.Name = "StaffidDataGridViewTextBoxColumn"
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "s_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "s_name"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'DesgDataGridViewTextBoxColumn
        '
        Me.DesgDataGridViewTextBoxColumn.DataPropertyName = "desg"
        Me.DesgDataGridViewTextBoxColumn.HeaderText = "desg"
        Me.DesgDataGridViewTextBoxColumn.Name = "DesgDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'EntrydateDataGridViewTextBoxColumn
        '
        Me.EntrydateDataGridViewTextBoxColumn.DataPropertyName = "entry_date"
        Me.EntrydateDataGridViewTextBoxColumn.HeaderText = "entry_date"
        Me.EntrydateDataGridViewTextBoxColumn.Name = "EntrydateDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 448)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.phn)
        Me.Controls.Add(Me.sal)
        Me.Controls.Add(Me.des)
        Me.Controls.Add(Me.s_name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.staff_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents staff_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents s_name As TextBox
    Friend WithEvents des As TextBox
    Friend WithEvents sal As TextBox
    Friend WithEvents phn As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StaffDataSet As staffDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As staffDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntrydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
