Imports System.Data.Odbc

Public Class ConnectToDB


    Dim connection As String = "Driver={MySQL ODBC 5.3 ANSI Driver};SERVER=127.0.0.1;PORT=3306;DATABASE=library;USER=root;PASSWORD=root;OPTION=3"

    Dim odbcConnection As New OdbcConnection(connection)

    Dim odbcCommand As OdbcCommand

    Dim odbcReader As OdbcDataReader

    Dim odbcadapter As OdbcDataAdapter


    Public Sub Connect()
        Try
            odbcConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("DB Connection failed", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ExecuteQuery(query As String)
        odbcCommand = New OdbcCommand(query, odbcConnection)
        Try
            If query.Contains("select") Then
                odbcReader = odbcCommand.ExecuteReader()
                Return odbcReader
            ElseIf query.Contains("update") Then
                Dim value As Integer = odbcCommand.ExecuteNonQuery()
                Return value
            ElseIf query.Contains("insert") Then
                Dim value As Integer = odbcCommand.ExecuteNonQuery()
                Return value
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
        Return ""
    End Function

    Public Sub DisConnect()
        Try
            odbcConnection.Close()
        Catch ex As Exception
            MessageBox.Show("DB failed to close the connection", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class