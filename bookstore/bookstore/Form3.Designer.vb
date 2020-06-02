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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.store_no = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.TextBox()
        Me.state = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.zip = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookstoreDataSet = New bookstore.bookstoreDataSet()
        Me.BookstoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_storeTableAdapter = New bookstore.bookstoreDataSetTableAdapters.Book_storeTableAdapter()
        Me.StorenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(644, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BOOK STORE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(483, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STORE NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(536, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "STATE"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(568, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'store_no
        '
        Me.store_no.Location = New System.Drawing.Point(598, 160)
        Me.store_no.Name = "store_no"
        Me.store_no.Size = New System.Drawing.Size(177, 20)
        Me.store_no.TabIndex = 7
        '
        'city
        '
        Me.city.Location = New System.Drawing.Point(598, 206)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(177, 20)
        Me.city.TabIndex = 8
        '
        'state
        '
        Me.state.Location = New System.Drawing.Point(598, 251)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(177, 20)
        Me.state.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(678, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(536, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ZIP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 12
        '
        'zip
        '
        Me.zip.Location = New System.Drawing.Point(598, 309)
        Me.zip.Name = "zip"
        Me.zip.Size = New System.Drawing.Size(177, 20)
        Me.zip.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StorenoDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookstoreBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 299)
        Me.DataGridView1.TabIndex = 14
        '
        'BookstoreDataSet
        '
        Me.BookstoreDataSet.DataSetName = "bookstoreDataSet"
        Me.BookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookstoreBindingSource
        '
        Me.BookstoreBindingSource.DataMember = "Book_store"
        Me.BookstoreBindingSource.DataSource = Me.BookstoreDataSet
        '
        'Book_storeTableAdapter
        '
        Me.Book_storeTableAdapter.ClearBeforeFill = True
        '
        'StorenoDataGridViewTextBoxColumn
        '
        Me.StorenoDataGridViewTextBoxColumn.DataPropertyName = "store_no"
        Me.StorenoDataGridViewTextBoxColumn.HeaderText = "store_no"
        Me.StorenoDataGridViewTextBoxColumn.Name = "StorenoDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipDataGridViewTextBoxColumn
        '
        Me.ZipDataGridViewTextBoxColumn.DataPropertyName = "zip"
        Me.ZipDataGridViewTextBoxColumn.HeaderText = "zip"
        Me.ZipDataGridViewTextBoxColumn.Name = "ZipDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.zip)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.store_no)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents store_no As TextBox
    Friend WithEvents city As TextBox
    Friend WithEvents state As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents zip As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookstoreDataSet As bookstoreDataSet
    Friend WithEvents BookstoreBindingSource As BindingSource
    Friend WithEvents Book_storeTableAdapter As bookstoreDataSetTableAdapters.Book_storeTableAdapter
    Friend WithEvents StorenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
