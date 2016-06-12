Public Class Frm_Generador
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_serialnumber.Text = helper.GenerarMD5(helper.GetProcessorId())
    End Sub
End Class