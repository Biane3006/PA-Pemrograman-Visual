Public Class Loading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Timer1.Start()
        Timer2.Start()
        'Atur posisi logo
        logoPlus.Size = New Size(200, 200)
        logoPlus.Location = New Point((Me.Width / 2) - (logoPlus.Width / 2), 10)
        'atur posisi tulisan
        labelLogin.Location = New Point((Me.Width / 2) - (labelLogin.Width / 2), logoPlus.Bottom + 10)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 10
        Else
            Timer1.Stop()
            Me.Dispose()
            Login.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub
End Class