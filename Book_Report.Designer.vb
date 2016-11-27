<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book_Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_Report))
        Me.dgBooks = New System.Windows.Forms.DataGridView()
        Me.bookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.copies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgBooks
        '
        Me.dgBooks.AllowUserToAddRows = False
        Me.dgBooks.AllowUserToDeleteRows = False
        Me.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookId, Me.book_name, Me.pub, Me.copies, Me.dept})
        Me.dgBooks.Location = New System.Drawing.Point(3, 3)
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.ReadOnly = True
        Me.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBooks.Size = New System.Drawing.Size(561, 230)
        Me.dgBooks.TabIndex = 24
        '
        'bookId
        '
        Me.bookId.HeaderText = "Book Id"
        Me.bookId.Name = "bookId"
        Me.bookId.ReadOnly = True
        '
        'book_name
        '
        Me.book_name.HeaderText = "Book Name"
        Me.book_name.Name = "book_name"
        Me.book_name.ReadOnly = True
        '
        'pub
        '
        Me.pub.HeaderText = "Publisher"
        Me.pub.Name = "pub"
        Me.pub.ReadOnly = True
        '
        'copies
        '
        Me.copies.HeaderText = "Copies"
        Me.copies.Name = "copies"
        Me.copies.ReadOnly = True
        '
        'dept
        '
        Me.dept.HeaderText = "Department"
        Me.dept.Name = "dept"
        Me.dept.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._0acd5002683fbcf2b720004f201ee530
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Available Books Report"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgBooks)
        Me.Panel1.Location = New System.Drawing.Point(12, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 238)
        Me.Panel1.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Print the Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(282, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Book_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 399)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Book_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book_Report"
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgBooks As DataGridView
    Friend WithEvents bookId As DataGridViewTextBoxColumn
    Friend WithEvents book_name As DataGridViewTextBoxColumn
    Friend WithEvents pub As DataGridViewTextBoxColumn
    Friend WithEvents copies As DataGridViewTextBoxColumn
    Friend WithEvents dept As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintForm As PowerPacks.Printing.PrintForm
    Friend WithEvents Button2 As Button
End Class
