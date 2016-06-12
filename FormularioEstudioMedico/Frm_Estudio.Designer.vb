<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Estudio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Estudio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomApe = New System.Windows.Forms.TextBox()
        Me.txt_profesional = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lst_imagenes = New System.Windows.Forms.ListView()
        Me.btn_agregar_imagen = New System.Windows.Forms.Button()
        Me.btn_borrar_lista = New System.Windows.Forms.Button()
        Me.btn_generar_pdf = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_licencia = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_diagnostico = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lst_img_recursos = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_destino = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.img_preview = New System.Windows.Forms.PictureBox()
        Me.btn_destino = New System.Windows.Forms.PictureBox()
        Me.img_plantilla = New System.Windows.Forms.PictureBox()
        Me.txt_prestador = New System.Windows.Forms.TextBox()
        Me.lbl_prestador = New System.Windows.Forms.Label()
        Me.txt_estudio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fec_estudio = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chk_incluir = New System.Windows.Forms.CheckBox()
        Me.chk_incluir_diagnostico = New System.Windows.Forms.CheckBox()
        CType(Me.img_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_destino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_plantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre y Apellido:"
        '
        'txt_nomApe
        '
        Me.txt_nomApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomApe.Location = New System.Drawing.Point(207, 9)
        Me.txt_nomApe.Name = "txt_nomApe"
        Me.txt_nomApe.Size = New System.Drawing.Size(269, 21)
        Me.txt_nomApe.TabIndex = 1
        '
        'txt_profesional
        '
        Me.txt_profesional.Enabled = False
        Me.txt_profesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profesional.Location = New System.Drawing.Point(207, 83)
        Me.txt_profesional.Name = "txt_profesional"
        Me.txt_profesional.Size = New System.Drawing.Size(269, 21)
        Me.txt_profesional.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Profesional:"
        '
        'txt_dni
        '
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(207, 46)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(269, 21)
        Me.txt_dni.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DNI:"
        '
        'lst_imagenes
        '
        Me.lst_imagenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_imagenes.Location = New System.Drawing.Point(511, 258)
        Me.lst_imagenes.Name = "lst_imagenes"
        Me.lst_imagenes.Size = New System.Drawing.Size(266, 137)
        Me.lst_imagenes.TabIndex = 11
        Me.lst_imagenes.UseCompatibleStateImageBehavior = False
        Me.lst_imagenes.View = System.Windows.Forms.View.List
        '
        'btn_agregar_imagen
        '
        Me.btn_agregar_imagen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_agregar_imagen.Location = New System.Drawing.Point(511, 402)
        Me.btn_agregar_imagen.Name = "btn_agregar_imagen"
        Me.btn_agregar_imagen.Size = New System.Drawing.Size(123, 36)
        Me.btn_agregar_imagen.TabIndex = 15
        Me.btn_agregar_imagen.Text = "Agregar Imagen"
        Me.btn_agregar_imagen.UseVisualStyleBackColor = True
        '
        'btn_borrar_lista
        '
        Me.btn_borrar_lista.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_borrar_lista.Location = New System.Drawing.Point(651, 401)
        Me.btn_borrar_lista.Name = "btn_borrar_lista"
        Me.btn_borrar_lista.Size = New System.Drawing.Size(123, 36)
        Me.btn_borrar_lista.TabIndex = 17
        Me.btn_borrar_lista.Text = "Borrar Lista"
        Me.btn_borrar_lista.UseVisualStyleBackColor = True
        '
        'btn_generar_pdf
        '
        Me.btn_generar_pdf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_generar_pdf.Location = New System.Drawing.Point(659, 474)
        Me.btn_generar_pdf.Name = "btn_generar_pdf"
        Me.btn_generar_pdf.Size = New System.Drawing.Size(138, 36)
        Me.btn_generar_pdf.TabIndex = 16
        Me.btn_generar_pdf.Text = "Generar PDF"
        Me.btn_generar_pdf.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Herramienta licenciada para "
        '
        'lbl_licencia
        '
        Me.lbl_licencia.Location = New System.Drawing.Point(156, 515)
        Me.lbl_licencia.Name = "lbl_licencia"
        Me.lbl_licencia.Size = New System.Drawing.Size(157, 13)
        Me.lbl_licencia.TabIndex = 17
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_salir.Location = New System.Drawing.Point(799, 474)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(138, 36)
        Me.btn_salir.TabIndex = 18
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(508, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Listado de Imagenes:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Fecha del Estudio:"
        '
        'txt_diagnostico
        '
        Me.txt_diagnostico.Enabled = False
        Me.txt_diagnostico.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_diagnostico.Location = New System.Drawing.Point(24, 258)
        Me.txt_diagnostico.Multiline = True
        Me.txt_diagnostico.Name = "txt_diagnostico"
        Me.txt_diagnostico.Size = New System.Drawing.Size(452, 239)
        Me.txt_diagnostico.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Diagnostico:"
        '
        'lst_img_recursos
        '
        Me.lst_img_recursos.ImageStream = CType(resources.GetObject("lst_img_recursos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lst_img_recursos.TransparentColor = System.Drawing.Color.Transparent
        Me.lst_img_recursos.Images.SetKeyName(0, "1col.png")
        Me.lst_img_recursos.Images.SetKeyName(1, "2col.png")
        Me.lst_img_recursos.Images.SetKeyName(2, "3col.png")
        Me.lst_img_recursos.Images.SetKeyName(3, "4col.png")
        Me.lst_img_recursos.Images.SetKeyName(4, "folder-36.png")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Seleccione una plantilla"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(508, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Seleccione carpeta de destino"
        '
        'lbl_destino
        '
        Me.lbl_destino.Location = New System.Drawing.Point(511, 38)
        Me.lbl_destino.Name = "lbl_destino"
        Me.lbl_destino.Size = New System.Drawing.Size(355, 20)
        Me.lbl_destino.TabIndex = 10
        Me.lbl_destino.Text = "C:\"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(552, 154)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.Text = "1 Columna"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(651, 154)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2 Columnas"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(552, 187)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.Text = "3 Columnas"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(587, 218)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.Text = "4 Columnas"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(508, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Vertical"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(508, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Horizontal"
        Me.Label11.Visible = False
        '
        'img_preview
        '
        Me.img_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_preview.Location = New System.Drawing.Point(780, 258)
        Me.img_preview.Name = "img_preview"
        Me.img_preview.Size = New System.Drawing.Size(158, 137)
        Me.img_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_preview.TabIndex = 32
        Me.img_preview.TabStop = False
        '
        'btn_destino
        '
        Me.btn_destino.Image = Global.EstudioMed2PDF.My.Resources.Resources.downloads_48
        Me.btn_destino.Location = New System.Drawing.Point(872, 28)
        Me.btn_destino.Name = "btn_destino"
        Me.btn_destino.Size = New System.Drawing.Size(36, 32)
        Me.btn_destino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_destino.TabIndex = 31
        Me.btn_destino.TabStop = False
        '
        'img_plantilla
        '
        Me.img_plantilla.Image = Global.EstudioMed2PDF.My.Resources.Resources._2col
        Me.img_plantilla.Location = New System.Drawing.Point(799, 99)
        Me.img_plantilla.Name = "img_plantilla"
        Me.img_plantilla.Size = New System.Drawing.Size(128, 118)
        Me.img_plantilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_plantilla.TabIndex = 11
        Me.img_plantilla.TabStop = False
        '
        'txt_prestador
        '
        Me.txt_prestador.Enabled = False
        Me.txt_prestador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prestador.Location = New System.Drawing.Point(207, 120)
        Me.txt_prestador.Name = "txt_prestador"
        Me.txt_prestador.Size = New System.Drawing.Size(269, 21)
        Me.txt_prestador.TabIndex = 4
        '
        'lbl_prestador
        '
        Me.lbl_prestador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prestador.Location = New System.Drawing.Point(21, 123)
        Me.lbl_prestador.Name = "lbl_prestador"
        Me.lbl_prestador.Size = New System.Drawing.Size(133, 20)
        Me.lbl_prestador.TabIndex = 4
        Me.lbl_prestador.Text = "Prestador:"
        '
        'txt_estudio
        '
        Me.txt_estudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_estudio.Location = New System.Drawing.Point(207, 157)
        Me.txt_estudio.Name = "txt_estudio"
        Me.txt_estudio.Size = New System.Drawing.Size(269, 21)
        Me.txt_estudio.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nombre del Estudio:"
        '
        'fec_estudio
        '
        Me.fec_estudio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fec_estudio.Location = New System.Drawing.Point(207, 196)
        Me.fec_estudio.Name = "fec_estudio"
        Me.fec_estudio.Size = New System.Drawing.Size(269, 20)
        Me.fec_estudio.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(175, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 58)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "["
        '
        'chk_incluir
        '
        Me.chk_incluir.AutoSize = True
        Me.chk_incluir.Location = New System.Drawing.Point(170, 108)
        Me.chk_incluir.Name = "chk_incluir"
        Me.chk_incluir.Size = New System.Drawing.Size(15, 14)
        Me.chk_incluir.TabIndex = 42
        Me.chk_incluir.UseVisualStyleBackColor = True
        '
        'chk_incluir_diagnostico
        '
        Me.chk_incluir_diagnostico.AutoSize = True
        Me.chk_incluir_diagnostico.Location = New System.Drawing.Point(422, 236)
        Me.chk_incluir_diagnostico.Name = "chk_incluir_diagnostico"
        Me.chk_incluir_diagnostico.Size = New System.Drawing.Size(54, 17)
        Me.chk_incluir_diagnostico.TabIndex = 43
        Me.chk_incluir_diagnostico.Text = "Incluir"
        Me.chk_incluir_diagnostico.UseVisualStyleBackColor = True
        '
        'Frm_Estudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(953, 537)
        Me.Controls.Add(Me.chk_incluir_diagnostico)
        Me.Controls.Add(Me.chk_incluir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fec_estudio)
        Me.Controls.Add(Me.txt_estudio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.img_preview)
        Me.Controls.Add(Me.btn_destino)
        Me.Controls.Add(Me.lbl_destino)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_diagnostico)
        Me.Controls.Add(Me.img_plantilla)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_licencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_generar_pdf)
        Me.Controls.Add(Me.btn_borrar_lista)
        Me.Controls.Add(Me.btn_agregar_imagen)
        Me.Controls.Add(Me.lst_imagenes)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_prestador)
        Me.Controls.Add(Me.lbl_prestador)
        Me.Controls.Add(Me.txt_profesional)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nomApe)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Estudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de estudios medicos"
        CType(Me.img_preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_destino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_plantilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nomApe As TextBox
    Friend WithEvents txt_profesional As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_imagenes As ListView
    Friend WithEvents btn_agregar_imagen As Button
    Friend WithEvents btn_borrar_lista As Button
    Friend WithEvents img_plantilla As PictureBox
    Friend WithEvents btn_generar_pdf As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_licencia As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_diagnostico As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lst_img_recursos As ImageList
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_destino As TextBox
    Friend WithEvents btn_destino As PictureBox
    Friend WithEvents img_preview As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_prestador As TextBox
    Friend WithEvents lbl_prestador As Label
    Friend WithEvents txt_estudio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fec_estudio As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents chk_incluir As CheckBox
    Friend WithEvents chk_incluir_diagnostico As CheckBox
End Class
