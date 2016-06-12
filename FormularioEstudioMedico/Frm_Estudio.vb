Public Class Frm_Estudio
    Dim controladora As New Ctrl_Estudio()
    Dim Plantilla As Integer
    Dim frm_preview As New frm_previsualizador

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar_imagen.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Seleccione las imagenes"
        fd.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        fd.Filter = "(Archivos de Imagenes)|*.jpg;*.png;*.bmp;*.gif;|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif"
        fd.Multiselect = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            For Each Nombre In fd.FileNames
                lst_imagenes.Items.Add(Nombre)
            Next
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_generar_pdf_Click(sender As Object, e As EventArgs) Handles btn_generar_pdf.Click
        Dim datos As New Dictionary(Of String, String)
        datos("nombre") = txt_nomApe.Text
        datos("profesional") = txt_profesional.Text
        datos("prestador") = txt_prestador.Text
        datos("dni") = txt_dni.Text
        datos("estudio") = txt_estudio.Text
        If chk_incluir_diagnostico.Checked Then
            datos("diagnostico") = txt_diagnostico.Text
        Else
            datos("diagnostico") = String.Empty
        End If
        datos("destino") = lbl_destino.Text
        datos("plantilla") = Plantilla
        datos("fec_estudio") = fec_estudio.Text
        datos("linea3") = chk_incluir.Checked.ToString
        Dim imagenes As New List(Of String)
        For Each ruta As ListViewItem In lst_imagenes.Items
            imagenes.Add(ruta.Text)
        Next
        controladora.GenerarDocumento(datos, imagenes)

    End Sub

    Private Sub btn_borrar_lista_Click(sender As Object, e As EventArgs) Handles btn_borrar_lista.Click
        lst_imagenes.Items.Clear()
        img_preview.Image = Nothing
    End Sub

    Private Sub Frm_Estudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.SerialNumber <> helper.GenerarMD5(helper.GetProcessorId()) Then
            MessageBox.Show("Programa sin licencia o la licencia es invalida. Se iniciara en modo DEMOSTRACION.",
        "Error de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        lbl_licencia.Text = My.Settings.propietario
        txt_profesional.Text = My.Settings.propietario
        txt_prestador.Text = My.Settings.prestador_default
        Plantilla = 1
        lbl_destino.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Estudios Generados\"



    End Sub

    Private Sub btn_destino_Click(sender As Object, e As EventArgs) Handles btn_destino.Click
        Dim dd As FolderBrowserDialog = New FolderBrowserDialog()
        If dd.ShowDialog() = DialogResult.OK Then
            lbl_destino.Text = dd.SelectedPath
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        img_plantilla.Image = lst_img_recursos.Images(0)
        Plantilla = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        img_plantilla.Image = lst_img_recursos.Images(1)
        Plantilla = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        img_plantilla.Image = lst_img_recursos.Images(2)
        Plantilla = 2
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        img_plantilla.Image = lst_img_recursos.Images(3)
        Plantilla = 3
    End Sub

    Private Sub lst_imagenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_imagenes.SelectedIndexChanged
        If lst_imagenes.SelectedItems.Count > 0 Then
            Dim elemento
            elemento = Me.lst_imagenes.SelectedItems(0)
            img_preview.Image = Image.FromFile(elemento.Text)
        End If

    End Sub

    Private Sub img_preview_Click(sender As Object, e As EventArgs) Handles img_preview.Click
        If (Me.img_preview.Image IsNot Nothing) Then
            frm_preview.img_frm_previsualizador.Image = Me.img_preview.Image
            frm_preview.ShowDialog(Me)
        End If
    End Sub

    Private Sub lst_imagenes_DoubleClick(sender As Object, e As EventArgs) Handles lst_imagenes.DoubleClick
        If (Me.img_preview.Image IsNot Nothing) Then
            frm_preview.img_frm_previsualizador.Image = Me.img_preview.Image
            frm_preview.ShowDialog(Me)
        End If
    End Sub

    Private Sub chk_incluir_CheckedChanged(sender As Object, e As EventArgs) Handles chk_incluir.CheckedChanged
        txt_profesional.Enabled = chk_incluir.Checked
        txt_prestador.Enabled = chk_incluir.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_incluir_diagnostico.CheckedChanged
        txt_diagnostico.Enabled = chk_incluir_diagnostico.Checked
    End Sub
End Class
