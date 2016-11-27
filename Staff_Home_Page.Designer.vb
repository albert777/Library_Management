<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_Home_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Home_Page))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbDept = New System.Windows.Forms.ComboBox()
        Me.btnBookDept = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBookIss = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNotify = New System.Windows.Forms.Button()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.btnUpdateBook = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbBooks = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(256, 338)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(153, 23)
        Me.btnLogout.TabIndex = 23
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnBookIss)
        Me.Panel1.Controls.Add(Me.btnBooks)
        Me.Panel1.Location = New System.Drawing.Point(15, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 227)
        Me.Panel1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cbDept)
        Me.Panel2.Controls.Add(Me.btnBookDept)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(18, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 109)
        Me.Panel2.TabIndex = 29
        '
        'cbDept
        '
        Me.cbDept.FormattingEnabled = True
        Me.cbDept.Location = New System.Drawing.Point(6, 34)
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(153, 21)
        Me.cbDept.TabIndex = 26
        '
        'btnBookDept
        '
        Me.btnBookDept.Location = New System.Drawing.Point(6, 70)
        Me.btnBookDept.Name = "btnBookDept"
        Me.btnBookDept.Size = New System.Drawing.Size(153, 23)
        Me.btnBookDept.TabIndex = 1
        Me.btnBookDept.Text = "Book Report by Department"
        Me.btnBookDept.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Select Department"
        '
        'btnBookIss
        '
        Me.btnBookIss.Location = New System.Drawing.Point(25, 188)
        Me.btnBookIss.Name = "btnBookIss"
        Me.btnBookIss.Size = New System.Drawing.Size(153, 23)
        Me.btnBookIss.TabIndex = 27
        Me.btnBookIss.Text = "Book Issued"
        Me.btnBookIss.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Location = New System.Drawing.Point(25, 14)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(153, 23)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Books Report"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Report Information"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.btnAddBook)
        Me.Panel3.Controls.Add(Me.btnNotify)
        Me.Panel3.Location = New System.Drawing.Point(230, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 227)
        Me.Panel3.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Staff Options"
        '
        'btnNotify
        '
        Me.btnNotify.Location = New System.Drawing.Point(25, 188)
        Me.btnNotify.Name = "btnNotify"
        Me.btnNotify.Size = New System.Drawing.Size(153, 23)
        Me.btnNotify.TabIndex = 0
        Me.btnNotify.Text = "Notify Student"
        Me.btnNotify.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.Location = New System.Drawing.Point(25, 14)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(153, 23)
        Me.btnAddBook.TabIndex = 1
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = True
        '
        'btnUpdateBook
        '
        Me.btnUpdateBook.Location = New System.Drawing.Point(6, 70)
        Me.btnUpdateBook.Name = "btnUpdateBook"
        Me.btnUpdateBook.Size = New System.Drawing.Size(153, 23)
        Me.btnUpdateBook.TabIndex = 3
        Me.btnUpdateBook.Text = "Update Book"
        Me.btnUpdateBook.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._0acd5002683fbcf2b720004f201ee530
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'cbBooks
        '
        Me.cbBooks.FormattingEnabled = True
        Me.cbBooks.Location = New System.Drawing.Point(6, 34)
        Me.cbBooks.Name = "cbBooks"
        Me.cbBooks.Size = New System.Drawing.Size(153, 21)
        Me.cbBooks.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cbBooks)
        Me.Panel4.Controls.Add(Me.btnUpdateBook)
        Me.Panel4.Location = New System.Drawing.Point(18, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(169, 109)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Select Book Name"
        '
        'Staff_Home_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 373)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Staff_Home_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff_Home_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnBookDept As Button
    Friend WithEvents cbDept As ComboBox
    Friend WithEvents btnBookIss As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNotify As Button
    Friend WithEvents btnAddBook As Button
    Friend WithEvents btnUpdateBook As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbBooks As ComboBox
End Class
