<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curso
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
        Me.courseName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tablelessons = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblvolcursos = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.addLesson = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'courseName
        '
        Me.courseName.AutoSize = True
        Me.courseName.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseName.Location = New System.Drawing.Point(31, 17)
        Me.courseName.Name = "courseName"
        Me.courseName.Size = New System.Drawing.Size(0, 44)
        Me.courseName.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Maquetación.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(699, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'tablelessons
        '
        Me.tablelessons.AutoSize = True
        Me.tablelessons.ColumnCount = 2
        Me.tablelessons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelessons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelessons.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.tablelessons.Location = New System.Drawing.Point(27, 49)
        Me.tablelessons.Name = "tablelessons"
        Me.tablelessons.Padding = New System.Windows.Forms.Padding(15, 35, 15, 35)
        Me.tablelessons.RowCount = 1
        Me.tablelessons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tablelessons.Size = New System.Drawing.Size(796, 70)
        Me.tablelessons.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.tablelessons)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 335)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lecciones disponibles"
        '
        'lblvolcursos
        '
        Me.lblvolcursos.AutoSize = True
        Me.lblvolcursos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvolcursos.Location = New System.Drawing.Point(750, 122)
        Me.lblvolcursos.Name = "lblvolcursos"
        Me.lblvolcursos.Size = New System.Drawing.Size(136, 18)
        Me.lblvolcursos.TabIndex = 35
        Me.lblvolcursos.Text = "<< Volver a cursos"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Gray
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(-10, 109)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(895, 10)
        Me.TextBox8.TabIndex = 45
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(-10, 93)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(896, 10)
        Me.TextBox7.TabIndex = 44
        '
        'addLesson
        '
        Me.addLesson.AutoSize = True
        Me.addLesson.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.addLesson.Location = New System.Drawing.Point(756, 155)
        Me.addLesson.Name = "addLesson"
        Me.addLesson.Size = New System.Drawing.Size(130, 18)
        Me.addLesson.TabIndex = 46
        Me.addLesson.TabStop = True
        Me.addLesson.Text = "+ Agregar lección"
        '
        'Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 570)
        Me.Controls.Add(Me.addLesson)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lblvolcursos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.courseName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Curso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents courseName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tablelessons As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblvolcursos As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents addLesson As LinkLabel
End Class
