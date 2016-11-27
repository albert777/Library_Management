<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.dgBook = New System.Windows.Forms.DataGridView()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.copies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtReturn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.rcBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbV = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(556, 406)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(94, 23)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtBookName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbDept)
        Me.Panel1.Location = New System.Drawing.Point(12, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 100)
        Me.Panel1.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(222, 70)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(195, 44)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(121, 20)
        Me.txtBookName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search by Book"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search by Department"
        '
        'cbDept
        '
        Me.cbDept.FormattingEnabled = True
        Me.cbDept.Location = New System.Drawing.Point(195, 12)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(121, 21)
        Me.cbDept.TabIndex = 0
        '
        'dgBook
        '
        Me.dgBook.AllowUserToAddRows = False
        Me.dgBook.AllowUserToDeleteRows = False
        Me.dgBook.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.book_id, Me.book_name, Me.pub, Me.copies})
        Me.dgBook.Location = New System.Drawing.Point(0, 0)
        Me.dgBook.MultiSelect = False
        Me.dgBook.Name = "dgBook"
        Me.dgBook.ReadOnly = True
        Me.dgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBook.Size = New System.Drawing.Size(342, 150)
        Me.dgBook.TabIndex = 5
        '
        'book_id
        '
        Me.book_id.HeaderText = "Book Id"
        Me.book_id.Name = "book_id"
        Me.book_id.ReadOnly = True
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
        Me.copies.HeaderText = "copies"
        Me.copies.Name = "copies"
        Me.copies.ReadOnly = True
        Me.copies.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnReturn)
        Me.Panel2.Controls.Add(Me.txtReturn)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(374, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 100)
        Me.Panel2.TabIndex = 6
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(156, 46)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(92, 23)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtReturn
        '
        Me.txtReturn.Location = New System.Drawing.Point(123, 12)
        Me.txtReturn.Name = "txtReturn"
        Me.txtReturn.Size = New System.Drawing.Size(125, 20)
        Me.txtReturn.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Book Number"
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(241, 155)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(97, 23)
        Me.btnBorrow.TabIndex = 7
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'rcBox
        '
        Me.rcBox.BackColor = System.Drawing.SystemColors.Info
        Me.rcBox.Location = New System.Drawing.Point(374, 217)
        Me.rcBox.Name = "rcBox"
        Me.rcBox.ReadOnly = True
        Me.rcBox.Size = New System.Drawing.Size(276, 183)
        Me.rcBox.TabIndex = 8
        Me.rcBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Available Books"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Notifications"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Borrow Books"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Return Books"
        '
        'lbV
        '
        Me.lbV.AutoSize = True
        Me.lbV.Location = New System.Drawing.Point(451, 334)
        Me.lbV.Name = "lbV"
        Me.lbV.Size = New System.Drawing.Size(0, 13)
        Me.lbV.TabIndex = 13
        Me.lbV.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgBook)
        Me.Panel3.Controls.Add(Me.btnBorrow)
        Me.Panel3.Location = New System.Drawing.Point(12, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(343, 183)
        Me.Panel3.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._0acd5002683fbcf2b720004f201ee530
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(495, 9)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(0, 13)
        Me.lbName.TabIndex = 16
        '
        'Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(662, 441)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rcBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDept As ComboBox
    Friend WithEvents dgBook As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBorrow As Button
    Friend WithEvents rcBox As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReturn As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lbV As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents book_id As DataGridViewTextBoxColumn
    Friend WithEvents book_name As DataGridViewTextBoxColumn
    Friend WithEvents pub As DataGridViewTextBoxColumn
    Friend WithEvents copies As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbName As Label
End Class
