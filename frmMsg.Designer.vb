<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsg
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
        Me.boton = New System.Windows.Forms.Button()
        Me.detalle = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'boton
        '
        Me.boton.Location = New System.Drawing.Point(79, 159)
        Me.boton.Name = "boton"
        Me.boton.Size = New System.Drawing.Size(75, 23)
        Me.boton.TabIndex = 5
        Me.boton.Text = "Button1"
        Me.boton.UseVisualStyleBackColor = True
        '
        'detalle
        '
        Me.detalle.AutoSize = True
        Me.detalle.Location = New System.Drawing.Point(52, 118)
        Me.detalle.Name = "detalle"
        Me.detalle.Size = New System.Drawing.Size(39, 13)
        Me.detalle.TabIndex = 4
        Me.detalle.Text = "Label2"
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Location = New System.Drawing.Point(97, 79)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(39, 13)
        Me.titulo.TabIndex = 3
        Me.titulo.Text = "Label1"
        '
        'frmMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.boton)
        Me.Controls.Add(Me.detalle)
        Me.Controls.Add(Me.titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boton As System.Windows.Forms.Button
    Friend WithEvents detalle As System.Windows.Forms.Label
    Friend WithEvents titulo As System.Windows.Forms.Label
End Class
