Public Class frm
    
    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' MessageBox.Show("Form is loaded")
        btnSubmit.Enabled = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Button is clicked")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.BackColor = Color.Red
        btnSubmit.Enabled = True
    End Sub
End Class
