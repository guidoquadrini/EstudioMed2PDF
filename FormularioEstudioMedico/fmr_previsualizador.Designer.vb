<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_previsualizador
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
        Me.img_frm_previsualizador = New System.Windows.Forms.PictureBox()
        CType(Me.img_frm_previsualizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_frm_previsualizador
        '
        Me.img_frm_previsualizador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img_frm_previsualizador.Location = New System.Drawing.Point(0, 0)
        Me.img_frm_previsualizador.Name = "img_frm_previsualizador"
        Me.img_frm_previsualizador.Size = New System.Drawing.Size(685, 490)
        Me.img_frm_previsualizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_frm_previsualizador.TabIndex = 0
        Me.img_frm_previsualizador.TabStop = False
        '
        'frm_previsualizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 490)
        Me.Controls.Add(Me.img_frm_previsualizador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_previsualizador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Previsualizador de Imagen"
        CType(Me.img_frm_previsualizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents img_frm_previsualizador As PictureBox
End Class
