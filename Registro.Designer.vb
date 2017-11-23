<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_conf_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_passw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(120, 89)
        Me.txt_nombre.Multiline = True
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(418, 20)
        Me.txt_nombre.TabIndex = 20
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(378, 310)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(160, 38)
        Me.btn_guardar.TabIndex = 25
        Me.btn_guardar.Text = "GUARDAR REGISTRO"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 44)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "REGISTRO"
        '
        'txt_conf_pass
        '
        Me.txt_conf_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_conf_pass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conf_pass.Location = New System.Drawing.Point(298, 267)
        Me.txt_conf_pass.Multiline = True
        Me.txt_conf_pass.Name = "txt_conf_pass"
        Me.txt_conf_pass.Size = New System.Drawing.Size(240, 20)
        Me.txt_conf_pass.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "NOMBRE"
        '
        'txt_passw
        '
        Me.txt_passw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_passw.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passw.Location = New System.Drawing.Point(174, 227)
        Me.txt_passw.Multiline = True
        Me.txt_passw.Name = "txt_passw"
        Me.txt_passw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_passw.Size = New System.Drawing.Size(364, 20)
        Me.txt_passw.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "APELLIDO PATERNO"
        '
        'txt_usu
        '
        Me.txt_usu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usu.Location = New System.Drawing.Point(232, 190)
        Me.txt_usu.Multiline = True
        Me.txt_usu.Name = "txt_usu"
        Me.txt_usu.Size = New System.Drawing.Size(306, 20)
        Me.txt_usu.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 28)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "NOMBRE DE USUARIO"
        '
        'txt_ap
        '
        Me.txt_ap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ap.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ap.Location = New System.Drawing.Point(213, 120)
        Me.txt_ap.Multiline = True
        Me.txt_ap.Name = "txt_ap"
        Me.txt_ap.Size = New System.Drawing.Size(324, 20)
        Me.txt_ap.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 28)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "CONTRASEÑA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "CONFIRAMAR CONTRASEÑA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.txt_ap)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_conf_pass)
        Me.GroupBox1.Controls.Add(Me.txt_usu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_passw)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 451)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(214, 310)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(160, 38)
        Me.btn_cancelar.TabIndex = 28
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(90, 156)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(448, 20)
        Me.txt_email.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 28)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "E-MAIL"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = Global.Maquetación.My.Resources.Resources.profile
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox4.Controls.Add(Me.LinkLabel1)
        Me.GroupBox4.Location = New System.Drawing.Point(597, 77)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 280)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 238)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(58, 25)
        Me.LinkLabel1.TabIndex = 26
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Editar"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(-10, 67)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(927, 10)
        Me.TextBox7.TabIndex = 29
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Gray
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(-10, 83)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(927, 10)
        Me.TextBox8.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Maquetación.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(707, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 570)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registro"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_conf_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_passw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
