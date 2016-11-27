Public Class Modify_books
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim connect As New ConnectToDB
        Dim count As Integer = 0
        Dim query As String = ""
        Dim flag As Boolean = True
        Dim err As String = ""

        If String.IsNullOrWhiteSpace(txtBookName.Text.ToString) Then
            flag = False
            err = err & vbNewLine & "Enter the book name"
        End If

        If String.IsNullOrWhiteSpace(txtDept.Text.ToString) Then
            flag = False
            err = err & vbNewLine & "Enter the Department"
        End If

        If String.IsNullOrWhiteSpace(txtPublisher.Text.ToString) Then
            flag = False
            err = err & vbNewLine & "Enter the Publisher"
        End If

        If String.IsNullOrWhiteSpace(txtCopies.Text.ToString) Then
            flag = False
            err = err & vbNewLine & "Enter the number of copies available"
        Else
            Try
                Integer.Parse(txtCopies.Text.ToString)
            Catch ex As Exception
                flag = False
                err = err & vbNewLine & "Copies value should be in numeric"
            End Try
        End If

        If flag Then
            connect.Connect()

            If btnSubmit.Text.ToString.ToLower = "submit" Then
                query = "insert into library.books values(" & txtBookId.Text.ToString & ",'" & txtBookName.Text.ToString & "','" & txtPublisher.Text.ToString & "'," & txtCopies.Text.ToString & ",'" & txtDept.Text.ToString & "')"
            ElseIf btnSubmit.Text.ToString.ToLower = "update" Then
                query = "update library.books set book_name='" & txtBookName.Text.ToString & "',publisher='" & txtPublisher.Text.ToString & "',copies='" & txtCopies.Text.ToString & "',dept='" & txtDept.Text.ToString & "' where bookId=" & txtBookId.Text.ToString & ";"
            End If

            count = connect.ExecuteQuery(query)
            If count <> 1 Then
                MessageBox.Show("Issues while inserting values into DB", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(txtBookName.Text.ToString & " book details is updated to database", "information message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            connect.DisConnect()
            Me.Close()
            Staff_Home_Page.Close()
            Staff_Home_Page.Show()
        Else
            MessageBox.Show(err, "warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub
End Class