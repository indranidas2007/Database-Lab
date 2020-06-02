<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminviewvb
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnicounsellingDataSet = New sqlcounselling.unicounsellingDataSet()
        Me.UnicounsellingDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnicounsellingDataSet3 = New sqlcounselling.unicounsellingDataSet3()
        Me.UnicounsellingDataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnicounsellingDataSet2 = New sqlcounselling.unicounsellingDataSet2()
        Me.PaymentdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payment_detailsTableAdapter = New sqlcounselling.unicounsellingDataSet2TableAdapters.payment_detailsTableAdapter()
        Me.SidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthofpaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnicounsellingDataSet4 = New sqlcounselling.unicounsellingDataSet4()
        Me.AdmissiondetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Admission_detailsTableAdapter = New sqlcounselling.unicounsellingDataSet4TableAdapters.admission_detailsTableAdapter()
        Me.EnrollIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CenteridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnicounsellingDataSet5 = New sqlcounselling.unicounsellingDataSet5()
        Me.AddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddressTableAdapter = New sqlcounselling.unicounsellingDataSet5TableAdapters.addressTableAdapter()
        Me.SidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VillageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnicounsellingDataSet6 = New sqlcounselling.unicounsellingDataSet6()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New sqlcounselling.unicounsellingDataSet6TableAdapters.studentTableAdapter()
        Me.SidDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdmissiondetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnicounsellingDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn3, Me.SnameDataGridViewTextBoxColumn, Me.CourseidDataGridViewTextBoxColumn1, Me.SRankDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn2, Me.VillageDataGridViewTextBoxColumn, Me.PoDataGridViewTextBoxColumn, Me.PsDataGridViewTextBoxColumn, Me.ZipcodeDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.DistrictDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.AddressBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(545, 59)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(544, 271)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn, Me.TidDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.MonthofpaymentDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.PaymentdetailsBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(12, 336)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(508, 271)
        Me.DataGridView3.TabIndex = 2
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnrollIDDataGridViewTextBoxColumn, Me.SidDataGridViewTextBoxColumn1, Me.CourseidDataGridViewTextBoxColumn, Me.CenteridDataGridViewTextBoxColumn, Me.DOADataGridViewTextBoxColumn, Me.MOPDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.AdmissiondetailsBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(545, 336)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(544, 271)
        Me.DataGridView4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "VIEW STUDENT DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ADMIN PAGE"
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
        'UnicounsellingDataSet3
        '
        Me.UnicounsellingDataSet3.DataSetName = "unicounsellingDataSet3"
        Me.UnicounsellingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnicounsellingDataSet3BindingSource
        '
        Me.UnicounsellingDataSet3BindingSource.DataSource = Me.UnicounsellingDataSet3
        Me.UnicounsellingDataSet3BindingSource.Position = 0
        '
        'UnicounsellingDataSet2
        '
        Me.UnicounsellingDataSet2.DataSetName = "unicounsellingDataSet2"
        Me.UnicounsellingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentdetailsBindingSource
        '
        Me.PaymentdetailsBindingSource.DataMember = "payment_details"
        Me.PaymentdetailsBindingSource.DataSource = Me.UnicounsellingDataSet2
        '
        'Payment_detailsTableAdapter
        '
        Me.Payment_detailsTableAdapter.ClearBeforeFill = True
        '
        'SidDataGridViewTextBoxColumn
        '
        Me.SidDataGridViewTextBoxColumn.DataPropertyName = "s_id"
        Me.SidDataGridViewTextBoxColumn.HeaderText = "s_id"
        Me.SidDataGridViewTextBoxColumn.Name = "SidDataGridViewTextBoxColumn"
        '
        'TidDataGridViewTextBoxColumn
        '
        Me.TidDataGridViewTextBoxColumn.DataPropertyName = "t_id"
        Me.TidDataGridViewTextBoxColumn.HeaderText = "t_id"
        Me.TidDataGridViewTextBoxColumn.Name = "TidDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'MonthofpaymentDataGridViewTextBoxColumn
        '
        Me.MonthofpaymentDataGridViewTextBoxColumn.DataPropertyName = "Month_of_payment"
        Me.MonthofpaymentDataGridViewTextBoxColumn.HeaderText = "Month_of_payment"
        Me.MonthofpaymentDataGridViewTextBoxColumn.Name = "MonthofpaymentDataGridViewTextBoxColumn"
        '
        'UnicounsellingDataSet4
        '
        Me.UnicounsellingDataSet4.DataSetName = "unicounsellingDataSet4"
        Me.UnicounsellingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdmissiondetailsBindingSource
        '
        Me.AdmissiondetailsBindingSource.DataMember = "admission_details"
        Me.AdmissiondetailsBindingSource.DataSource = Me.UnicounsellingDataSet4
        '
        'Admission_detailsTableAdapter
        '
        Me.Admission_detailsTableAdapter.ClearBeforeFill = True
        '
        'EnrollIDDataGridViewTextBoxColumn
        '
        Me.EnrollIDDataGridViewTextBoxColumn.DataPropertyName = "enroll_ID"
        Me.EnrollIDDataGridViewTextBoxColumn.HeaderText = "enroll_ID"
        Me.EnrollIDDataGridViewTextBoxColumn.Name = "EnrollIDDataGridViewTextBoxColumn"
        '
        'SidDataGridViewTextBoxColumn1
        '
        Me.SidDataGridViewTextBoxColumn1.DataPropertyName = "s_id"
        Me.SidDataGridViewTextBoxColumn1.HeaderText = "s_id"
        Me.SidDataGridViewTextBoxColumn1.Name = "SidDataGridViewTextBoxColumn1"
        '
        'CourseidDataGridViewTextBoxColumn
        '
        Me.CourseidDataGridViewTextBoxColumn.DataPropertyName = "course_id"
        Me.CourseidDataGridViewTextBoxColumn.HeaderText = "course_id"
        Me.CourseidDataGridViewTextBoxColumn.Name = "CourseidDataGridViewTextBoxColumn"
        '
        'CenteridDataGridViewTextBoxColumn
        '
        Me.CenteridDataGridViewTextBoxColumn.DataPropertyName = "center_id"
        Me.CenteridDataGridViewTextBoxColumn.HeaderText = "center_id"
        Me.CenteridDataGridViewTextBoxColumn.Name = "CenteridDataGridViewTextBoxColumn"
        '
        'DOADataGridViewTextBoxColumn
        '
        Me.DOADataGridViewTextBoxColumn.DataPropertyName = "DOA"
        Me.DOADataGridViewTextBoxColumn.HeaderText = "DOA"
        Me.DOADataGridViewTextBoxColumn.Name = "DOADataGridViewTextBoxColumn"
        '
        'MOPDataGridViewTextBoxColumn
        '
        Me.MOPDataGridViewTextBoxColumn.DataPropertyName = "MOP"
        Me.MOPDataGridViewTextBoxColumn.HeaderText = "MOP"
        Me.MOPDataGridViewTextBoxColumn.Name = "MOPDataGridViewTextBoxColumn"
        '
        'UnicounsellingDataSet5
        '
        Me.UnicounsellingDataSet5.DataSetName = "unicounsellingDataSet5"
        Me.UnicounsellingDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddressBindingSource
        '
        Me.AddressBindingSource.DataMember = "address"
        Me.AddressBindingSource.DataSource = Me.UnicounsellingDataSet5
        '
        'AddressTableAdapter
        '
        Me.AddressTableAdapter.ClearBeforeFill = True
        '
        'SidDataGridViewTextBoxColumn2
        '
        Me.SidDataGridViewTextBoxColumn2.DataPropertyName = "s_id"
        Me.SidDataGridViewTextBoxColumn2.HeaderText = "s_id"
        Me.SidDataGridViewTextBoxColumn2.Name = "SidDataGridViewTextBoxColumn2"
        '
        'VillageDataGridViewTextBoxColumn
        '
        Me.VillageDataGridViewTextBoxColumn.DataPropertyName = "village"
        Me.VillageDataGridViewTextBoxColumn.HeaderText = "village"
        Me.VillageDataGridViewTextBoxColumn.Name = "VillageDataGridViewTextBoxColumn"
        '
        'PoDataGridViewTextBoxColumn
        '
        Me.PoDataGridViewTextBoxColumn.DataPropertyName = "po"
        Me.PoDataGridViewTextBoxColumn.HeaderText = "po"
        Me.PoDataGridViewTextBoxColumn.Name = "PoDataGridViewTextBoxColumn"
        '
        'PsDataGridViewTextBoxColumn
        '
        Me.PsDataGridViewTextBoxColumn.DataPropertyName = "ps"
        Me.PsDataGridViewTextBoxColumn.HeaderText = "ps"
        Me.PsDataGridViewTextBoxColumn.Name = "PsDataGridViewTextBoxColumn"
        '
        'ZipcodeDataGridViewTextBoxColumn
        '
        Me.ZipcodeDataGridViewTextBoxColumn.DataPropertyName = "zipcode"
        Me.ZipcodeDataGridViewTextBoxColumn.HeaderText = "zipcode"
        Me.ZipcodeDataGridViewTextBoxColumn.Name = "ZipcodeDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'DistrictDataGridViewTextBoxColumn
        '
        Me.DistrictDataGridViewTextBoxColumn.DataPropertyName = "district"
        Me.DistrictDataGridViewTextBoxColumn.HeaderText = "district"
        Me.DistrictDataGridViewTextBoxColumn.Name = "DistrictDataGridViewTextBoxColumn"
        '
        'UnicounsellingDataSet6
        '
        Me.UnicounsellingDataSet6.DataSetName = "unicounsellingDataSet6"
        Me.UnicounsellingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.UnicounsellingDataSet6
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'SidDataGridViewTextBoxColumn3
        '
        Me.SidDataGridViewTextBoxColumn3.DataPropertyName = "s_id"
        Me.SidDataGridViewTextBoxColumn3.HeaderText = "s_id"
        Me.SidDataGridViewTextBoxColumn3.Name = "SidDataGridViewTextBoxColumn3"
        Me.SidDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "s_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "s_name"
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        '
        'CourseidDataGridViewTextBoxColumn1
        '
        Me.CourseidDataGridViewTextBoxColumn1.DataPropertyName = "course_id"
        Me.CourseidDataGridViewTextBoxColumn1.HeaderText = "course_id"
        Me.CourseidDataGridViewTextBoxColumn1.Name = "CourseidDataGridViewTextBoxColumn1"
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
        'adminviewvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 628)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "adminviewvb"
        Me.Text = "adminviewvb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdmissiondetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnicounsellingDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UnicounsellingDataSetBindingSource As BindingSource
    Friend WithEvents UnicounsellingDataSet As unicounsellingDataSet
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents UnicounsellingDataSet3BindingSource As BindingSource
    Friend WithEvents UnicounsellingDataSet3 As unicounsellingDataSet3
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnicounsellingDataSet2 As unicounsellingDataSet2
    Friend WithEvents PaymentdetailsBindingSource As BindingSource
    Friend WithEvents Payment_detailsTableAdapter As unicounsellingDataSet2TableAdapters.payment_detailsTableAdapter
    Friend WithEvents SidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthofpaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnicounsellingDataSet4 As unicounsellingDataSet4
    Friend WithEvents AdmissiondetailsBindingSource As BindingSource
    Friend WithEvents Admission_detailsTableAdapter As unicounsellingDataSet4TableAdapters.admission_detailsTableAdapter
    Friend WithEvents EnrollIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CourseidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CenteridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnicounsellingDataSet5 As unicounsellingDataSet5
    Friend WithEvents AddressBindingSource As BindingSource
    Friend WithEvents AddressTableAdapter As unicounsellingDataSet5TableAdapters.addressTableAdapter
    Friend WithEvents SidDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents VillageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistrictDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnicounsellingDataSet6 As unicounsellingDataSet6
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As unicounsellingDataSet6TableAdapters.studentTableAdapter
    Friend WithEvents SidDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SRankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
