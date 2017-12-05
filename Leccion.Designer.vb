<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Leccion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lessonTitle = New System.Windows.Forms.Label()
        Me.lblactualizar = New System.Windows.Forms.LinkLabel()
        Me.lessonDescrition = New System.Windows.Forms.TextBox()
        Me.backToCourse = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Maquetación.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(707, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'lessonTitle
        '
        Me.lessonTitle.AutoSize = True
        Me.lessonTitle.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lessonTitle.Location = New System.Drawing.Point(12, 9)
        Me.lessonTitle.Name = "lessonTitle"
        Me.lessonTitle.Size = New System.Drawing.Size(0, 44)
        Me.lessonTitle.TabIndex = 45
        '
        'lblactualizar
        '
        Me.lblactualizar.AutoSize = True
        Me.lblactualizar.BackColor = System.Drawing.Color.Transparent
        Me.lblactualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactualizar.Location = New System.Drawing.Point(737, 169)
        Me.lblactualizar.Name = "lblactualizar"
        Me.lblactualizar.Size = New System.Drawing.Size(164, 18)
        Me.lblactualizar.TabIndex = 48
        Me.lblactualizar.TabStop = True
        Me.lblactualizar.Text = "+ Actualizar Contenido"
        '
        'lessonDescrition
        '
        Me.lessonDescrition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lessonDescrition.Enabled = False
        Me.lessonDescrition.Location = New System.Drawing.Point(17, 207)
        Me.lessonDescrition.Multiline = True
        Me.lessonDescrition.Name = "lessonDescrition"
        Me.lessonDescrition.Size = New System.Drawing.Size(881, 79)
        Me.lessonDescrition.TabIndex = 50
        '
        'backToCourse
        '
        Me.backToCourse.AutoSize = True
        Me.backToCourse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backToCourse.Location = New System.Drawing.Point(745, 142)
        Me.backToCourse.Name = "backToCourse"
        Me.backToCourse.Size = New System.Drawing.Size(153, 18)
        Me.backToCourse.TabIndex = 53
        Me.backToCourse.Text = "<< Regresar al curso"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Gray
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(-6, 110)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(927, 10)
        Me.TextBox8.TabIndex = 56
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(-6, 94)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(927, 10)
        Me.TextBox7.TabIndex = 55
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(186, 292)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(539, 328)
        Me.player.TabIndex = 57
        '
        'Leccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(913, 632)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.backToCourse)
        Me.Controls.Add(Me.lessonDescrition)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lessonTitle)
        Me.Controls.Add(Me.lblactualizar)
        Me.Name = "Leccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LECCION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lessonTitle As Label
    Friend WithEvents lblactualizar As LinkLabel
    Friend WithEvents lessonDescrition As TextBox
    Friend WithEvents backToCourse As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
End Class
