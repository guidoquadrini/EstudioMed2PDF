<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Generador
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_serialnumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Obtener Nro de Serie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_serialnumber
        '
        Me.txt_serialnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_serialnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serialnumber.Location = New System.Drawing.Point(12, 12)
        Me.txt_serialnumber.Name = "txt_serialnumber"
        Me.txt_serialnumber.Size = New System.Drawing.Size(375, 22)
        Me.txt_serialnumber.TabIndex = 1
        '
        'Frm_Generador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 98)
        Me.Controls.Add(Me.txt_serialnumber)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Generador"
        Me.Text = "Generador de Numeros de Serie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt_serialnumber As TextBox
End Class
