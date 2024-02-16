Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Welcoming Form"

        ToolTipMe.SetToolTip(btnLoad, "Load Object Demo")
        ToolTipMe.SetToolTip(btnExit, "EXIT")

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.BackColor = Color.Red
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub LoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim objDemoForm As New frmObjectDemonstrations
        objDemoForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
