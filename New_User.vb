Public Class New_User

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As New ConnectToDB
        Dim errorMsg As String = ""
        Dim flag As Boolean = True

        If String.IsNullOrWhiteSpace(txtFirst.Text.ToString) Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Enter the First name"
        End If

        If String.IsNullOrWhiteSpace(txtLast.Text.ToString) Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Enter the Last name"
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text.ToString) Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Enter the Email id"
        ElseIf txtEmail.Text.Contains("@school.edu") = False Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Email id should be school email id"
        End If

        If String.IsNullOrWhiteSpace(txtPasswd.Text.ToString) Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Enter the Password"
        ElseIf String.Compare(txtPasswd.Text.ToString, txtCPasswd.Text.ToString) <> 0 Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Password and confirm password should be same"
        End If

        If String.IsNullOrWhiteSpace(txtSId.Text.ToString) Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "Enter the School Id"
        ElseIf txtSId.Text.Length < 6 Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "School Id is invalid"
        ElseIf txtSId.Text.ToLower.Contains("a") = False And txtSId.Text.ToLower.Contains("s") = False Then
            flag = False
            errorMsg = errorMsg & vbNewLine & "School Id is invalid"
        End If

        If txtSId.Text.ToLower.Contains("s") Then
            If String.IsNullOrWhiteSpace(cbPlan.Text.ToString) Then
                flag = False
                errorMsg = errorMsg & vbNewLine & "Select the plan"
            End If
        End If

        If flag Then
            connect.Connect()

            Dim query As String = "select count(*) as c from library.users where s_id='" & txtSId.Text.ToString & "' and password='" & txtPasswd.Text.ToString & "';"
            Dim result As Odbc.OdbcDataReader
            result = connect.ExecuteQuery(query)
            result.Read()
            Dim c As Integer = result("c")
            If c <> 1 Then
                Dim temp As String = ""
                Dim count As Integer = 0

                If txtSId.Text.ToLower.Contains("a") Then
                    temp = "Staff"
                Else
                    temp = "Student"
                    count = cbPlan.SelectedIndex + 1
                End If

                query = "insert into library.users values ('" & txtSId.Text.ToString & "','" & txtPasswd.Text.ToString & "', '" & txtFirst.Text.ToString & "', '" & txtLast.Text.ToString & "', '" & txtEmail.Text.ToString & "', " & count & ",'" & temp & "');"
                Dim value As Integer = connect.ExecuteQuery(query)
                If value <> 1 Then
                    MessageBox.Show("Issues while inserting values into DB", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                connect.DisConnect()
                Me.Close()
                Login_Page.Show()
            Else
                MessageBox.Show("User already registered", "warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Login_Page.Show()
            End If
        Else
            MessageBox.Show(errorMsg, "warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSId.Clear()
        txtPasswd.Clear()
        txtCPasswd.Clear()
        txtEmail.Clear()
        txtFirst.Clear()
        txtLast.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Login_Page.Show()
    End Sub

    Private Sub txtSId_TextChanged(sender As Object, e As EventArgs) Handles txtSId.Leave
        txtSId.Text = txtSId.Text.ToUpper()
        If txtSId.Text.ToLower.Contains("a") Then
            Label8.Hide()
            cbPlan.Hide()
        Else
            Label8.Show()
            cbPlan.Show()
        End If
    End Sub
End Class
