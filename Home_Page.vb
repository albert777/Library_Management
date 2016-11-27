Public Class Home_Page
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login_Page.txtPasswd.Clear()
        Login_Page.txtSId.Clear()
        Login_Page.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim query As String
        Dim connect As New ConnectToDB
        dgBook.Rows.Clear()

        If String.IsNullOrWhiteSpace(txtBookName.Text.ToString) = False Then
            query = "select book_name,publisher,copies,bookId from library.books where book_name like '%" & txtBookName.Text.ToString & "%';"
        Else
            query = "select book_name,publisher,copies,bookId from library.books where dept='" & cbDept.SelectedItem.ToString & "';"
        End If

        connect.Connect()
        Dim result As Odbc.OdbcDataReader = connect.ExecuteQuery(query)
        Dim i As Integer = 0

        While result.Read
            dgBook.Rows.Add("", "", "")
            dgBook.Rows(i).Cells(0).Value = result("bookId")
            dgBook.Rows(i).Cells(1).Value = result("book_name")
            dgBook.Rows(i).Cells(2).Value = result("publisher")
            dgBook.Rows(i).Cells(3).Value = result("copies")
            i = i + 1
        End While

        txtBookName.Clear()
        connect.DisConnect()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        Dim connect As New ConnectToDB
        Dim query As String = ""
        Dim result As Odbc.OdbcDataReader

        connect.Connect()

        query = "select count from library.plan where plan_id=" & lbV.Text.ToString & ";"
        result = connect.ExecuteQuery(query)
        result.Read()
        Dim allowCount As Integer = result("count")

        query = "select count(*) as c from library.borrow where s_id='" & Login_Page.txtSId.Text.ToString & "' and flag=0;"
        result = connect.ExecuteQuery(query)
        result.Read()
        Dim usedCount As Integer = result("c")

        If allowCount > usedCount Then

            Dim id As Integer = dgBook.Rows(dgBook.CurrentCell.RowIndex).Cells(0).Value
            Dim copies As Integer = dgBook.Rows(dgBook.CurrentCell.RowIndex).Cells(3).Value

            If copies <> 0 Then
                Dim notify As String = "**Please collect the " & dgBook.Rows(dgBook.CurrentCell.RowIndex).Cells(1).Value & " book at library front desk. You must return the book on " & Date.Now.AddDays(7) & ""
                notify = rcBox.Text.ToString & vbNewLine & notify
                rcBox.Text = notify

                query = "insert into library.borrow values ('" & Login_Page.txtSId.Text.ToString & "'," & id & ",CURRENT_TIMESTAMP,date_add(now(), interval 7 day),0,'" & notify & "');"
                Dim count As Integer = connect.ExecuteQuery(query)

                If count <> 1 Then
                    MessageBox.Show("Issue in database Insertion", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                query = "update library.books set books.copies=" & copies - 1 & " where bookId=" & id & ""
                count = connect.ExecuteQuery(query)

                If count <> 1 Then
                    MessageBox.Show("Issue in database update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                MessageBox.Show("Please collect the " & dgBook.Rows(dgBook.CurrentCell.RowIndex).Cells(1).Value & " book at library front desk. You must return the book on " & Date.Now.AddDays(7) & "", "information message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("" & dgBook.Rows(dgBook.CurrentCell.RowIndex).Cells(1).Value & "Book unavailable in the library, Will drop you a mail once the book is available", "Error Messgage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            connect.DisConnect()
        Else
            MessageBox.Show("You have exceded the limit, Please update your plan (or) return any book ", "information message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New ConnectToDB
        Dim query As String = "select notificartion from library.borrow where s_id='" & Login_Page.txtSId.Text.ToString & "'"
        connect.Connect()
        Dim result As Odbc.OdbcDataReader = connect.ExecuteQuery(query)

        While result.Read
            rcBox.Text = result("notificartion")
        End While

        query = "select dept from library.books group by dept"
        result = connect.ExecuteQuery(query)

        While result.Read
            cbDept.Items.Add(result("dept"))
        End While

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        Dim connect As New ConnectToDB
        Dim query As String = ""
        Dim result As Odbc.OdbcDataReader

        If String.IsNullOrWhiteSpace(txtReturn.Text.ToString) Then
            MessageBox.Show("Enter the book number to return the book", "information message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            connect.Connect()
            query = "select copies,book_name from library.books where bookId=" & txtReturn.Text.ToString & ""
            result = connect.ExecuteQuery(query)
            result.Read()
            Dim copies As Integer = result("copies")
            Dim name As String = result("book_name")
            Dim notify As String = rcBox.Text.ToString
            Dim count As Integer = 0

            notify = notify & vbNewLine & "**Thank you for returning the " & name & " book"

            query = "update library.borrow set borrow.flag=1,borrow.notificartion='" & notify & "' where s_id='" & Login_Page.txtSId.Text.ToString & "' and book_id=" & txtReturn.Text.ToString & ""
            count = connect.ExecuteQuery(query)
            If count <> 1 Then
                MessageBox.Show("You didn't borrow the " & name & " book", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Thank you for returning the " & name & " book", "information message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rcBox.Text = notify

                query = "update library.books set books.copies=" & copies + 1 & " where bookId=" & txtReturn.Text.ToString & ""
                count = connect.ExecuteQuery(query)
                If count <> 1 Then
                    MessageBox.Show("Issue in database update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        txtReturn.Clear()
        connect.DisConnect()

    End Sub
End Class