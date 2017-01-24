Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Run Exercise 5 (a to e)
        exercise5a_out()
        exercise5b_out()
        exercise5c_out()
        exercise5d_out()
        exercise5e_out()
    End Sub
    Public Sub exercise5a_out()
        Dim strMsg As String = "This is the text in for this variable"
        lblSize.Text = strMsg.Length
    End Sub
    Public Sub exercise5b_out()
        Dim strCity As String = "San Jose"
        lblCity.Text = strCity.Trim
    End Sub
    Public Sub exercise5c_out()
        Dim strWord As String = "mouse"
        strWord = strWord.Remove(3, 2)
        lblWord1.Text = strWord.Insert(3, "th")
    End Sub
    Public Sub exercise5d_out()
        Dim strWord As String = "mend"
        lblWord2.Text = strWord.Insert(0, "a")
    End Sub
    Public Sub exercise5e_out()
        Dim strPay As String = "235.67"
        lblPay.Text = strPay.Insert(0, "****")
    End Sub
End Class
