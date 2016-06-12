Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

''' <summary>
''' Carpeta Fonts debe estar creada y con el archivo arial.ttf
''' Capteta Estudios debe estar creada
''' </summary>

Public Class Ctrl_Estudio

    Public Sub GenerarDocumento(ByVal datos As Dictionary(Of String, String), ByVal imagenes As List(Of String))
        Dim linea3 As String = datos("linea3")
        Dim fec_estudio As String = datos("fec_estudio")
        Dim prestador As String = datos("prestador")
        Dim columnas As Integer = datos("plantilla") + 1
        Dim paciente As String = datos("nombre")
        Dim estudio As String = datos("estudio")
        Dim nombre_archivo = DateTime.Now.ToString("yyddMMHHmm") + paciente + "-" + estudio
        Dim destino As String = datos("destino") + nombre_archivo + ".pdf"
        Dim titulo As String = datos("estudio")
        Dim dni As String = datos("dni")
        Dim diagnostico As String = datos("diagnostico")
        Dim profesional As String = datos("profesional")
        Dim documento As iTextSharp.text.Document
        Dim CarpetaAplicacion As String = My.Computer.FileSystem.CurrentDirectory

        If (destino = "") Then
            destino = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Estudios Generados\" + nombre_archivo + ".pdf"
        End If

        documento = New iTextSharp.text.Document()
        Dim tam_pagina As Rectangle
        If True Then '(columnas <= 2) Then
            tam_pagina = PageSize.A4
        Else
            tam_pagina = New Rectangle(PageSize.A4.Height, PageSize.A4.Width)
        End If
        documento.SetPageSize(tam_pagina)
        documento.SetMargins(28.35, 28.35, 72, 28.35)
        'Metadata del Archivo
        documento.AddAuthor(profesional)
        documento.AddCreator("Generador de Informes Medicos")
        documento.AddCreationDate()
        documento.AddTitle(estudio + " de " + paciente)
        documento.AddSubject(diagnostico)
        documento.AddKeywords(profesional + ";" + estudio)

        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim fuente_demo As New Font(BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.EMBEDDED), 42, Font.BOLD, BaseColor.RED)
        Dim h1 As New Font(BaseFont.CreateFont(CarpetaAplicacion + "/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 14, Font.BOLD)
        Dim h2 As New Font(BaseFont.CreateFont(CarpetaAplicacion + "/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 12, Font.BOLD)
        Dim font_parrafo As New Font(BaseFont.CreateFont(CarpetaAplicacion + "/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 12)

        pdfw = PdfWriter.GetInstance(documento, New FileStream(destino, FileMode.Create, FileAccess.Write, FileShare.None))
        pdfw.PageEvent = New ExtensionEventos(paciente, dni, prestador, profesional, estudio, fec_estudio, linea3)
        documento.Open()
        documento.NewPage()

        'Dim Fecha As Paragraph = New Paragraph(DateTime.Now.ToString("dddd dd \de MMMM \del yyyy"), font_parrafo)
        'Fecha.Alignment = Element.ALIGN_RIGHT
        'documento.Add(Fecha)

        Dim Titulo_estudio As Paragraph = New Paragraph(50, titulo, h1)
        Titulo_estudio.Alignment = Element.ALIGN_CENTER
        documento.Add(Titulo_estudio)

        If diagnostico IsNot String.Empty Then
            Dim titulo_diagnostico As Paragraph = New Paragraph(50, "Diagnostico:", h2)
            titulo_diagnostico.Alignment = Element.ALIGN_LEFT
            documento.Add(titulo_diagnostico)

            Dim parrafo As Paragraph = New Paragraph(diagnostico, font_parrafo)
            parrafo.Alignment = Element.ALIGN_JUSTIFIED
            documento.Add(parrafo)
            Dim linebreak As New Chunk(New draw.DottedLineSeparator)
            documento.Add(linebreak)

        End If

        Dim table As New PdfPTable(columnas)
        Dim AnchoColumnas As Single() = {}
        Dim i As Integer
        Select Case columnas
            Case 1
                AnchoColumnas = {PageSize.A4.Width}
            Case 2
                AnchoColumnas = {PageSize.A4.Width / columnas, PageSize.A4.Width / columnas}
            Case 3
                AnchoColumnas = {PageSize.A4.Width / columnas, PageSize.A4.Width / columnas, PageSize.A4.Width / columnas}
            Case 4
                AnchoColumnas = {PageSize.A4.Width / columnas, PageSize.A4.Width / columnas, PageSize.A4.Width / columnas, PageSize.A4.Width / columnas}
        End Select
        table.SetWidthPercentage(AnchoColumnas, PageSize.A4)
        For Each ruta_img As String In imagenes
            table.AddCell(createImageCell(ruta_img))
        Next

        'Correccion celdas vacias.
        Dim Filas_ocupadas = Int(imagenes.Count / columnas)
        Dim Fotos_restantes = imagenes.Count - (columnas * Filas_ocupadas)
        Dim Nro_vacios = columnas - Fotos_restantes
        Dim cell_vacia As New PdfPCell()
        cell_vacia.AddElement(New Paragraph(""))
        cell_vacia.Border = 0
        For i = 0 To Nro_vacios
            table.AddCell(cell_vacia)
        Next
        documento.Add(table)

        pdfw.Flush()
        documento.Close()
        MessageBox.Show("El documento fue generado existosamente. ",
        "Proceso completo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


        pdfw = Nothing
        documento = Nothing
        ShellExecute(destino)

    End Sub

    Private Function ShellExecute(ByVal File As String) As Boolean
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        Try
            myProcess.Start()
            myProcess.Dispose()
        Catch ex As Exception
            MessageBox.Show("No se puede abrir el archivo PDF generado, revise su visualizador de PDF en el sistema.",
        "Atencion requerida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try

    End Function

    Public Shared Function createImageCell(Path As String) As PdfPCell 'throws DocumentException, IOException {
        Dim img As Image = Image.GetInstance(Path)
        Dim cell As New PdfPCell(img, True)
        Return cell
    End Function

    Public Class ExtensionEventos
        Inherits PdfPageEventHelper
        Property paciente As String
        Property dni As String
        Property estudio As String
        Property prestador As String
        Property profesional As String
        Property fec_estudio As String
        Property linea3 As String
        Property cb As PdfContentByte
        Property template As PdfTemplate
        Dim fuente As New Font(BaseFont.CreateFont(My.Computer.FileSystem.CurrentDirectory + "/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 12)
        Dim fuente_demo As New Font(BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.EMBEDDED), 42, Font.BOLD, BaseColor.RED)

        Protected watermark As New Phrase("Esta es una version DEMO.", fuente_demo)
        Public Sub New(pPaciente, pdni, pprestador, pprofesional, pestudio, pfec_estudio, plinea3)
            Me.paciente = pPaciente
            Me.dni = pdni
            Me.estudio = pestudio
            Me.prestador = pprestador
            Me.profesional = pprofesional
            Me.fec_estudio = pfec_estudio
            Me.linea3 = plinea3
        End Sub
        Public Overrides Sub OnOpenDocument(writer As PdfWriter, document As Document)
            cb = writer.DirectContent
            template = cb.CreateTemplate(50, 50)
        End Sub
        Overrides Sub onEndPage(writer As PdfWriter, document As Document)
            Dim bf As BaseFont = BaseFont.CreateFont(
                        BaseFont.HELVETICA,
                        BaseFont.CP1252,
                        BaseFont.EMBEDDED)
            Dim Font As New Font(bf, 8)
            MyBase.OnStartPage(writer, document)
            Dim cabecera As New PdfPTable(6)

            Dim cols_cabecera As Single() = {13, 16, 18, 15, 15, 29}
            cabecera.SetWidthPercentage(cols_cabecera, document.PageSize)
            cabecera.TotalWidth = document.Right - document.Left


            Dim campo As PdfPCell
            Dim alto_fila = 50

            campo = New PdfPCell(New Paragraph("Paciente:", Font))
            campo.Colspan = 1
            cabecera.AddCell(campo)
            campo = New PdfPCell(New Paragraph(paciente, Font))
            campo.Colspan = 3
            cabecera.AddCell(campo)
            campo = New PdfPCell(New Paragraph("DNI:", Font))
            campo.Colspan = 1
            cabecera.AddCell(campo)
            campo = New PdfPCell(New Paragraph(dni, Font))
            campo.Colspan = 1
            cabecera.AddCell(campo)

            campo = New PdfPCell(New Paragraph("Estudio:", Font))
            campo.Colspan = 1
            cabecera.AddCell(campo)
            campo = New PdfPCell(New Paragraph(estudio, Font))
            campo.Colspan = 3
            cabecera.AddCell(campo)
            campo = New PdfPCell(New Paragraph("Fecha:", Font))
            campo.Colspan = 1
            cabecera.AddCell(campo)
            campo = New PdfPCell(New Paragraph(fec_estudio, Font))
            campo.Colspan = 1
            cabecera.AddCell(campo)

            If linea3 = "True" Then
                campo = New PdfPCell(New Paragraph("Prestador:", Font))
                campo.Colspan = 1
                cabecera.AddCell(campo)
                campo = New PdfPCell(New Paragraph(prestador, Font))
                campo.Colspan = 2
                cabecera.AddCell(campo)
                campo = New PdfPCell(New Paragraph("Profesional:", Font))
                campo.Colspan = 1
                cabecera.AddCell(campo)
                campo = New PdfPCell(New Paragraph(profesional, Font))
                campo.Colspan = 2
                cabecera.AddCell(campo)
            End If
            cabecera.WriteSelectedRows(0, -1, document.Left, iTextSharp.text.PageSize.A4.Height - 28.35F, writer.DirectContent)

            Dim pageN As Integer = writer.PageNumber
            Dim text As [String] = "Pagina " + pageN.ToString() + " de "
            Dim len As Single = text.Length

            Dim pageSize As iTextSharp.text.Rectangle = document.PageSize

            cb.SetRGBColorFill(100, 100, 100)

            cb.BeginText()
            cb.SetFontAndSize(BaseFont.CreateFont(My.Computer.FileSystem.CurrentDirectory + "/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 12)
            cb.SetTextMatrix(document.PageSize.Width - document.RightMargin - 90, pageSize.GetBottom(document.BottomMargin))
            cb.ShowText(text)

            cb.EndText()

            cb.AddTemplate(template, document.PageSize.Width - document.RightMargin - 20, pageSize.GetBottom(document.BottomMargin))

            If My.Settings.SerialNumber <> helper.GenerarMD5(helper.GetProcessorId()) Then
                MessageBox.Show("Programa sin licencia o la licencia es invalida.",
            "Error de Licencia", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Dim canvas As PdfContentByte = writer.DirectContentUnder()
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_CENTER, watermark, 298, 421, 45)
            End If

        End Sub
        Public Overrides Sub OnCloseDocument(writer As PdfWriter, document As Document)
            MyBase.OnCloseDocument(writer, document)
            template.BeginText()
            template.SetFontAndSize(BaseFont.CreateFont(My.Computer.FileSystem.CurrentDirectory + "/fonts/arial.ttf", BaseFont.WINANSI, BaseFont.EMBEDDED), 12)
            template.SetTextMatrix(0, 0)
            template.ShowText(" " + CStr(writer.PageNumber))
            template.EndText()
        End Sub
    End Class


End Class

