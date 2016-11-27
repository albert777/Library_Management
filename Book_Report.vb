Public Class Book_Report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PrintForm.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm.Print()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Staff_Home_Page.Close()
        Staff_Home_Page.Show()
    End Sub
End Class