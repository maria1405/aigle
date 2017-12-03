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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lessonTitle = New System.Windows.Forms.Label()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lessonDescrition = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.backToCourse = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lessonTitle.Location = New System.Drawing.Point(12, 41)
        Me.lessonTitle.Name = "lessonTitle"
        Me.lessonTitle.Size = New System.Drawing.Size(0, 44)
        Me.lessonTitle.TabIndex = 45
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.Location = New System.Drawing.Point(725, 99)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(176, 25)
        Me.LinkLabel7.TabIndex = 48
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "+ Agregar Contenido"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(583, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 275)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "AQUI VA LA IMAGEN QUE AGREGUE PARA IDENTIFICAR AL CURSO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 179)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONTENIDO"
        '
        'lessonDescrition
        '
        Me.lessonDescrition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lessonDescrition.Enabled = False
        Me.lessonDescrition.Location = New System.Drawing.Point(20, 137)
        Me.lessonDescrition.Multiline = True
        Me.lessonDescrition.Name = "lessonDescrition"
        Me.lessonDescrition.Size = New System.Drawing.Size(557, 90)
        Me.lessonDescrition.TabIndex = 50
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(12, 449)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(565, 90)
        Me.TextBox1.TabIndex = 51
        Me.TextBox1.Text = "COMENTARIOS"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(583, 511)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 28)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "ENVÍAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'backToCourse
        '
        Me.backToCourse.AutoSize = True
        Me.backToCourse.Location = New System.Drawing.Point(767, 72)
        Me.backToCourse.Name = "backToCourse"
        Me.backToCourse.Size = New System.Drawing.Size(90, 13)
        Me.backToCourse.TabIndex = 53
        Me.backToCourse.Text = "Regresar al curso"
        '
        'Leccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(913, 570)
        Me.Controls.Add(Me.backToCourse)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lessonDescrition)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lessonTitle)
        Me.Controls.Add(Me.LinkLabel7)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Leccion"
        Me.Text = "LECCION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lessonTitle As Label
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lessonDescrition As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents backToCourse As Label
End Class
