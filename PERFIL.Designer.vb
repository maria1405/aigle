<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PERFIL
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
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnircursos = New System.Windows.Forms.Button()
        Me.Label3lbllastname = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Gray
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(-9, 99)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(927, 10)
        Me.TextBox8.TabIndex = 34
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(-9, 83)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(927, 10)
        Me.TextBox7.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Maquetación.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(708, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 44)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "PERFIL"
        '
        'lblmail
        '
        Me.lblmail.AutoSize = True
        Me.lblmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.Location = New System.Drawing.Point(66, 221)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(268, 18)
        Me.lblmail.TabIndex = 31
        Me.lblmail.Text = "AQUI VA EL E-MAIL DEL USUARIO..."
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(66, 255)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(324, 18)
        Me.lblusername.TabIndex = 29
        Me.lblusername.Text = "AQUÍ VA EL PSEUDÓNIMO DEL USUARIO..."
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(66, 150)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(77, 18)
        Me.lblname.TabIndex = 27
        Me.lblname.Text = "NOMBRE"
        '
        'btnircursos
        '
        Me.btnircursos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnircursos.Location = New System.Drawing.Point(753, 364)
        Me.btnircursos.Name = "btnircursos"
        Me.btnircursos.Size = New System.Drawing.Size(139, 38)
        Me.btnircursos.TabIndex = 36
        Me.btnircursos.Text = "Ver Mis Cursos"
        Me.btnircursos.UseVisualStyleBackColor = True
        '
        'Label3lbllastname
        '
        Me.Label3lbllastname.AutoSize = True
        Me.Label3lbllastname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3lbllastname.Location = New System.Drawing.Point(66, 185)
        Me.Label3lbllastname.Name = "Label3lbllastname"
        Me.Label3lbllastname.Size = New System.Drawing.Size(294, 18)
        Me.Label3lbllastname.TabIndex = 28
        Me.Label3lbllastname.Text = "AQUI VA EL APELLIDO DEL USUARIO..."
        '
        'PERFIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 570)
        Me.Controls.Add(Me.btnircursos)
        Me.Controls.Add(Me.lblmail)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3lbllastname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PERFIL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERFIL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmail As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btnircursos As Button
    Friend WithEvents Label3lbllastname As Label
End Class
