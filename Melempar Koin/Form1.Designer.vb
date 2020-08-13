<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbrKepala = New System.Windows.Forms.PictureBox()
        Me.gbrEkor = New System.Windows.Forms.PictureBox()
        Me.tombolLempar = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.gbrKepala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbrEkor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbrKepala
        '
        Me.gbrKepala.Image = CType(resources.GetObject("gbrKepala.Image"), System.Drawing.Image)
        Me.gbrKepala.Location = New System.Drawing.Point(13, 13)
        Me.gbrKepala.Name = "gbrKepala"
        Me.gbrKepala.Size = New System.Drawing.Size(130, 128)
        Me.gbrKepala.TabIndex = 0
        Me.gbrKepala.TabStop = False
        Me.gbrKepala.Visible = False
        '
        'gbrEkor
        '
        Me.gbrEkor.Image = CType(resources.GetObject("gbrEkor.Image"), System.Drawing.Image)
        Me.gbrEkor.Location = New System.Drawing.Point(160, 13)
        Me.gbrEkor.Name = "gbrEkor"
        Me.gbrEkor.Size = New System.Drawing.Size(130, 128)
        Me.gbrEkor.TabIndex = 1
        Me.gbrEkor.TabStop = False
        Me.gbrEkor.Visible = False
        '
        'tombolLempar
        '
        Me.tombolLempar.Location = New System.Drawing.Point(13, 159)
        Me.tombolLempar.Name = "tombolLempar"
        Me.tombolLempar.Size = New System.Drawing.Size(130, 34)
        Me.tombolLempar.TabIndex = 2
        Me.tombolLempar.Text = "Lempar Koin"
        Me.ToolTip1.SetToolTip(Me.tombolLempar, "Klik untuk melempar koin")
        Me.tombolLempar.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(160, 159)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(130, 34)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.ToolTip1.SetToolTip(Me.tombolKeluar, "Klik untuk keluar")
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 215)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolLempar)
        Me.Controls.Add(Me.gbrEkor)
        Me.Controls.Add(Me.gbrKepala)
        Me.Name = "Form1"
        Me.Text = "Melempar Koin"
        CType(Me.gbrKepala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbrEkor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbrKepala As System.Windows.Forms.PictureBox
    Friend WithEvents gbrEkor As System.Windows.Forms.PictureBox
    Friend WithEvents tombolLempar As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
