Public Class Staff_Home_Page
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login_Page.Show()
        Login_Page.txtSId.Clear()
        Login_Page.txtPasswd.Clear()
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click

        Book_Report.dgBooks.Rows.Clear()

        Dim connect As New ConnectToDB
        Dim result As Odbc.OdbcDataReader
        Dim i As Integer = 0
        Dim query As String = "select * from library.books;"

        connect.Connect()
        result = connect.ExecuteQuery(query)

        While result.Read
            Book_Report.dgBooks.Rows.Add("", "", "", "", "")
            Book_Report.dgBooks.Rows(i).Cells(0).Value = result("bookId")
            Book_Report.dgBooks.Rows(i).Cells(1).Value = result("book_name")
            Book_Report.dgBooks.Rows(i).Cells(2).Value = result("publisher")
            Book_Report.dgBooks.Rows(i).Cells(3).Value = result("copies")
            Book_Report.dgBooks.Rows(i).Cells(4).Value = result("dept")
            i = i + 1
        End While

        connect.DisConnect()
        Book_Report.Show()

    End Sub

    Private Sub btnBookDept_Click(sender As Object, e As EventArgs) Handles btnBookDept.Click

        Book_Report.dgBooks.Rows.Clear()

        Dim connect As New ConnectToDB
        Dim result As Odbc.OdbcDataReader
        Dim i As Integer = 0
        Dim query As String = "select * from library.books where dept='" & cbDept.SelectedItem.ToString & "'"

        connect.Connect()
        result = connect.ExecuteQuery(query)

        While result.Read
            Book_Report.dgBooks.Rows.Add("", "", "", "", "")
            Book_Report.dgBooks.Rows(i).Cells(0).Value = result("bookId")
            Book_Report.dgBooks.Rows(i).Cells(1).Value = result("book_name")
            Book_Report.dgBooks.Rows(i).Cells(2).Value = result("publisher")
            Book_Report.dgBooks.Rows(i).Cells(3).Value = result("copies")
            Book_Report.dgBooks.Rows(i).Cells(4).Value = result("dept")
            i = i + 1
        End While

        connect.DisConnect()
        Book_Report.Show()

    End Sub

    Private Sub btnBookIss_Click(sender As Object, e As EventArgs) Handles btnBookIss.Click

        Book_Issued.dgBooks.Rows.Clear()

        Dim connect As New ConnectToDB
        Dim result As Odbc.OdbcDataReader
        Dim i As Integer = 0
        Dim query As String = "select borrow.return_date,users.s_id,users.first_name,users.email_id,books.bookId,books.book_name,books.publisher from library.borrow left join library.books on library.books.bookId = library.borrow.book_id left join library.users on library.users.s_id = library.borrow.s_id where library.borrow.flag=0;"

        connect.Connect()
        result = connect.ExecuteQuery(query)

        While result.Read
            Book_Issued.dgBooks.Rows.Add("", "", "", "", "", "")
            Dim temp As String = result("s_id")
            temp = temp.Substring(1, temp.Length - 1)
            Book_Issued.dgBooks.Rows(i).Cells(0).Value = temp.ToString
            Book_Issued.dgBooks.Rows(i).Cells(1).Value = result("first_name")
            Book_Issued.dgBooks.Rows(i).Cells(2).Value = result("email_id")
            Book_Issued.dgBooks.Rows(i).Cells(3).Value = result("bookId")
            Book_Issued.dgBooks.Rows(i).Cells(4).Value = result("book_name")
            Book_Issued.dgBooks.Rows(i).Cells(5).Value = result("publisher")
            Book_Issued.dgBooks.Rows(i).Cells(6).Value = result("return_date")
            i = i + 1
        End While

        connect.DisConnect()
        Book_Issued.Show()

    End Sub

    Private Sub btnNotify_Click(sender As Object, e As EventArgs) Handles btnNotify.Click

        Book_Issued.Button1.Text = "Notify"
        btnBookIss_Click(sender, e)

    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click

        Dim connect As New ConnectToDB
        Dim result As Odbc.OdbcDataReader
        Dim query As String = "select count(*) as c from library.books"

        connect.Connect()
        result = connect.ExecuteQuery(query)
        result.Read()
        Dim i As Integer = result("c")
        connect.DisConnect()

        Modify_books.txtBookId.Text = i + 1
        Modify_books.btnSubmit.Text = "Submit"
        Modify_books.Show()

    End Sub

    Private Sub Staff_Home_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New ConnectToDB
        Dim result As Odbc.OdbcDataReader
        Dim query As String = "select book_name from library.books"

        connect.Connect()
        result = connect.ExecuteQuery(query)

        While result.Read
            cbBooks.Items.Add(result("book_name"))
        End While

        query = "select dept from library.books group by dept"
        result = connect.ExecuteQuery(query)

        While result.Read
            cbDept.Items.Add(result("dept"))
        End While

        connect.DisConnect()
    End Sub

    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click

        Dim connect As New ConnectToDB
        Dim result As Odbc.OdbcDataReader
        Dim query As String
        Dim temp As String

        Try
            temp = cbBooks.SelectedItem.ToString

            query = "select * from library.books where book_name='" & temp & "'"

            connect.Connect()
            result = connect.ExecuteQuery(query)
            result.Read()

            Modify_books.txtBookId.Text = result("bookId")
            Modify_books.txtBookName.Text = result("book_name")
            Modify_books.txtPublisher.Text = result("publisher")
            Modify_books.txtCopies.Text = result("copies")
            Modify_books.txtDept.Text = result("dept")

            connect.DisConnect()

            Modify_books.btnSubmit.Text = "Update"
            Modify_books.Show()

        Catch ex As Exception
            MessageBox.Show("Select the Book Name to update the details", "warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class