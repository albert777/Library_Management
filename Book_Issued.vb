Public Class Book_Issued
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text.ToString = "Notify" Then
            Dim name As String = dgBooks.Rows(dgBooks.CurrentCell.RowIndex).Cells(1).Value
            Dim id As Integer = dgBooks.Rows(dgBooks.CurrentCell.RowIndex).Cells(0).Value
            Dim bookId As Integer = dgBooks.Rows(dgBooks.CurrentCell.RowIndex).Cells(3).Value
            Dim book_name As String = dgBooks.Rows(dgBooks.CurrentCell.RowIndex).Cells(4).Value
            Dim connect As New ConnectToDB
            Dim count As Integer = 0
            Dim query As String = ""
            Dim result As Odbc.OdbcDataReader

            connect.Connect()
            query = "select notificartion from library.borrow where book_id=" & bookId & " and s_id='S" & id & "'"
            result = connect.ExecuteQuery(query)
            result.Read()
            Dim notify As String = result("notificartion")
            notify = notify & vbNewLine & "**** Return the " & book_name & " book ASAP..!!"

            query = "update library.borrow set notificartion='" & notify & "' where book_id=" & bookId & " and s_id='S" & id & "';"
            count = connect.ExecuteQuery(query)
            If count <> 1 Then
                MessageBox.Show("Issues while inserting values into DB", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Notification has been sent to " & name)
            End If
        Else
            Me.PrintForm.PrinterSettings.DefaultPageSettings.Landscape = True
            PrintForm.Print()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class