<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modify_books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modify_books))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtBookId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._0acd5002683fbcf2b720004f201ee530
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(143, 306)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 23)
        Me.btnSubmit.TabIndex = 24
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDept)
        Me.Panel1.Controls.Add(Me.txtCopies)
        Me.Panel1.Controls.Add(Me.txtPublisher)
        Me.Panel1.Controls.Add(Me.txtBookName)
        Me.Panel1.Controls.Add(Me.txtBookId)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 187)
        Me.Panel1.TabIndex = 25
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(3, 133)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(100, 20)
        Me.txtDept.TabIndex = 9
        '
        'txtCopies
        '
        Me.txtCopies.Location = New System.Drawing.Point(130, 82)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(100, 20)
        Me.txtCopies.TabIndex = 8
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(3, 82)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(100, 20)
        Me.txtPublisher.TabIndex = 7
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(130, 30)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(100, 20)
        Me.txtBookName.TabIndex = 6
        '
        'txtBookId
        '
        Me.txtBookId.Enabled = False
        Me.txtBookId.Location = New System.Drawing.Point(3, 30)
        Me.txtBookId.Name = "txtBookId"
        Me.txtBookId.Size = New System.Drawing.Size(100, 20)
        Me.txtBookId.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Copies"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Publisher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Add / Update Book Details"
        '
        'Modify_books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 338)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modify_books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify_books"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDept As TextBox
    Friend WithEvents txtCopies As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtBookId As TextBox
    Friend WithEvents Label6 As Label
End Class
