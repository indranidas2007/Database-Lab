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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bookid = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.TextBox()
        Me.genre = New System.Windows.Forms.TextBox()
        Me.stock = New System.Windows.Forms.TextBox()
        Me.book = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookDataSet = New bookstore.bookDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New bookstore.bookDataSetTableAdapters.booksTableAdapter()
        Me.BIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(516, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(620, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'bookid
        '
        Me.bookid.Location = New System.Drawing.Point(734, 54)
        Me.bookid.Name = "bookid"
        Me.bookid.Size = New System.Drawing.Size(170, 20)
        Me.bookid.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(655, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 55)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(801, 297)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 55)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(595, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AUTHOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(605, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "GENRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(607, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "STOCK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "BOOKS"
        '
        'author
        '
        Me.author.Location = New System.Drawing.Point(734, 102)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(170, 20)
        Me.author.TabIndex = 9
        '
        'genre
        '
        Me.genre.Location = New System.Drawing.Point(734, 148)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(170, 20)
        Me.genre.TabIndex = 10
        '
        'stock
        '
        Me.stock.Location = New System.Drawing.Point(734, 204)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(170, 20)
        Me.stock.TabIndex = 11
        '
        'book
        '
        Me.book.Location = New System.Drawing.Point(734, 262)
        Me.book.Name = "book"
        Me.book.Size = New System.Drawing.Size(170, 20)
        Me.book.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BIDDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.BookDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 278)
        Me.DataGridView1.TabIndex = 13
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "bookDataSet"
        Me.BookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.BookDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'BIDDataGridViewTextBoxColumn
        '
        Me.BIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID"
        Me.BIDDataGridViewTextBoxColumn.HeaderText = "B_ID"
        Me.BIDDataGridViewTextBoxColumn.Name = "BIDDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'BookDataGridViewTextBoxColumn
        '
        Me.BookDataGridViewTextBoxColumn.DataPropertyName = "Book"
        Me.BookDataGridViewTextBoxColumn.HeaderText = "Book"
        Me.BookDataGridViewTextBoxColumn.Name = "BookDataGridViewTextBoxColumn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(774, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "BOOK"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 433)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.book)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.genre)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bookid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bookid As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents author As TextBox
    Friend WithEvents genre As TextBox
    Friend WithEvents stock As TextBox
    Friend WithEvents book As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookDataSet As bookDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As bookDataSetTableAdapters.booksTableAdapter
    Friend WithEvents BIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
End Class
