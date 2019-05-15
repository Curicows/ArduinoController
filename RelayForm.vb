Public Class RelayForm
    Private Sub RelayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Relay1Status = True Then
            Panel1.BackColor = Color.Lime
        Else
            Panel1.BackColor = Color.Red
        End If

        If Relay2Status = True Then
            Panel2.BackColor = Color.Lime
        Else
            Panel2.BackColor = Color.Red
        End If
    End Sub
End Class