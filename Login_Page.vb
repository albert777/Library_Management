Public Class Login_Page
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        New_User.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connect As New ConnectToDB
        Dim err As String = ""
        Dim flag As Boolean = True

        If String.IsNullOrWhiteSpace(txtSId.Text.ToString) Then
            flag = False
            err = "Enter the School Id"
        End If

        If String.IsNullOrWhiteSpace(txtPasswd.Text.ToString) Then
            flag = False
            err = err & vbNewLine & "Enter the Password"
        End If

        If flag Then
            connect.Connect()
            Dim query As String = "select count(*) as c,plan_id,first_name,Last_name from library.users where s_id='" & txtSId.Text.ToString & "' and password='" & txtPasswd.Text.ToString & "';"
            Dim result As Odbc.OdbcDataReader

            result = connect.ExecuteQuery(query)
            result.Read()
            Dim count As Integer = result("c")

            If count <> 1 Then
                MessageBox.Show("School Id or Password is incorrect", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSId.Clear()
                txtPasswd.Clear()
            Else
                Me.Hide()
                If txtSId.Text.ToLower.Contains("s") Then
                    Home_Page.Show()
                    Home_Page.lbV.Text = result("plan_id")
                    Home_Page.lbName.Text = "Welcome " & result("first_name") & " " & result("last_name")
                Else
                    Staff_Home_Page.Show()
                End If
            End If
        Else
            MessageBox.Show(err, "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPasswd.Clear()
            txtSId.Clear()
        End If
        connect.DisConnect()
    End Sub
End Class