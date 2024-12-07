Public Class Form2

    Public start As Integer = 3
    Public stage As Integer = 1

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If start = 3 Then
            stage += 1
            labelm.Text = stage
        End If

        If start = -1 Then
            Me.Hide()
            Timer1.Enabled = False
            start = 3
            Form1.Timer1.Enabled = True
        End If

        start -= 1

    End Sub



End Class