<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_nivel = New System.Windows.Forms.Label()
        Me.lbl_puntos = New System.Windows.Forms.Label()
        Me.lbl_tiempo = New System.Windows.Forms.Label()
        Me.txt_aux = New System.Windows.Forms.TextBox()
        Me.lbl_vidas = New System.Windows.Forms.Label()
        Me.lbl_carga = New System.Windows.Forms.Label()
        Me.lbl_velocidad = New System.Windows.Forms.Label()
        Me.lbl_temp = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.lbl_5 = New System.Windows.Forms.Label()
        Me.lbl_6 = New System.Windows.Forms.Label()
        Me.lbl_7 = New System.Windows.Forms.Label()
        Me.lbl_8 = New System.Windows.Forms.Label()
        Me.btn_jugar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmr_Mover
        '
        '
        'lbl_nivel
        '
        Me.lbl_nivel.AutoSize = True
        Me.lbl_nivel.ForeColor = System.Drawing.Color.White
        Me.lbl_nivel.Location = New System.Drawing.Point(5, 10)
        Me.lbl_nivel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nivel.Name = "lbl_nivel"
        Me.lbl_nivel.Size = New System.Drawing.Size(46, 20)
        Me.lbl_nivel.TabIndex = 0
        Me.lbl_nivel.Text = "Nivel:"
        '
        'lbl_puntos
        '
        Me.lbl_puntos.AutoSize = True
        Me.lbl_puntos.ForeColor = System.Drawing.Color.White
        Me.lbl_puntos.Location = New System.Drawing.Point(66, 10)
        Me.lbl_puntos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_puntos.Name = "lbl_puntos"
        Me.lbl_puntos.Size = New System.Drawing.Size(56, 20)
        Me.lbl_puntos.TabIndex = 1
        Me.lbl_puntos.Text = "Puntos:"
        '
        'lbl_tiempo
        '
        Me.lbl_tiempo.AutoSize = True
        Me.lbl_tiempo.ForeColor = System.Drawing.Color.White
        Me.lbl_tiempo.Location = New System.Drawing.Point(166, 10)
        Me.lbl_tiempo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_tiempo.Name = "lbl_tiempo"
        Me.lbl_tiempo.Size = New System.Drawing.Size(63, 20)
        Me.lbl_tiempo.TabIndex = 2
        Me.lbl_tiempo.Text = "Tiempo:"
        '
        'txt_aux
        '
        Me.txt_aux.Location = New System.Drawing.Point(334, 321)
        Me.txt_aux.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_aux.Name = "txt_aux"
        Me.txt_aux.Size = New System.Drawing.Size(121, 27)
        Me.txt_aux.TabIndex = 3
        Me.txt_aux.Visible = False
        '
        'lbl_vidas
        '
        Me.lbl_vidas.AutoSize = True
        Me.lbl_vidas.ForeColor = System.Drawing.Color.White
        Me.lbl_vidas.Location = New System.Drawing.Point(260, 10)
        Me.lbl_vidas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_vidas.Name = "lbl_vidas"
        Me.lbl_vidas.Size = New System.Drawing.Size(48, 20)
        Me.lbl_vidas.TabIndex = 4
        Me.lbl_vidas.Text = "Vidas:"
        '
        'lbl_carga
        '
        Me.lbl_carga.AutoSize = True
        Me.lbl_carga.ForeColor = System.Drawing.Color.White
        Me.lbl_carga.Location = New System.Drawing.Point(322, 10)
        Me.lbl_carga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_carga.Name = "lbl_carga"
        Me.lbl_carga.Size = New System.Drawing.Size(51, 20)
        Me.lbl_carga.TabIndex = 5
        Me.lbl_carga.Text = "Carga:"
        '
        'lbl_velocidad
        '
        Me.lbl_velocidad.AutoSize = True
        Me.lbl_velocidad.ForeColor = System.Drawing.Color.White
        Me.lbl_velocidad.Location = New System.Drawing.Point(391, 10)
        Me.lbl_velocidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_velocidad.Name = "lbl_velocidad"
        Me.lbl_velocidad.Size = New System.Drawing.Size(57, 20)
        Me.lbl_velocidad.TabIndex = 6
        Me.lbl_velocidad.Text = "px/seg:"
        '
        'lbl_temp
        '
        Me.lbl_temp.AutoSize = True
        Me.lbl_temp.ForeColor = System.Drawing.Color.White
        Me.lbl_temp.Location = New System.Drawing.Point(486, 10)
        Me.lbl_temp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_temp.Name = "lbl_temp"
        Me.lbl_temp.Size = New System.Drawing.Size(49, 20)
        Me.lbl_temp.TabIndex = 7
        Me.lbl_temp.Text = "Temp:"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_1.ForeColor = System.Drawing.Color.White
        Me.lbl_1.Location = New System.Drawing.Point(266, 81)
        Me.lbl_1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(259, 20)
        Me.lbl_1.TabIndex = 8
        Me.lbl_1.Text = "Universidad Tecnológica de Panamá"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.ForeColor = System.Drawing.Color.White
        Me.lbl_2.Location = New System.Drawing.Point(219, 110)
        Me.lbl_2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(357, 20)
        Me.lbl_2.TabIndex = 9
        Me.lbl_2.Text = "Facultad de Ingeniería de Sistemas Computacionales"
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.ForeColor = System.Drawing.Color.White
        Me.lbl_3.Location = New System.Drawing.Point(267, 141)
        Me.lbl_3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(265, 20)
        Me.lbl_3.TabIndex = 10
        Me.lbl_3.Text = "Licenciatura en Desarrollo de Software"
        '
        'lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.ForeColor = System.Drawing.Color.White
        Me.lbl_4.Location = New System.Drawing.Point(304, 192)
        Me.lbl_4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(174, 20)
        Me.lbl_4.TabIndex = 11
        Me.lbl_4.Text = "Desarrollo de Software 8"
        '
        'lbl_5
        '
        Me.lbl_5.AutoSize = True
        Me.lbl_5.ForeColor = System.Drawing.Color.White
        Me.lbl_5.Location = New System.Drawing.Point(324, 225)
        Me.lbl_5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(131, 20)
        Me.lbl_5.TabIndex = 12
        Me.lbl_5.Text = "Prof. Ricardo Chan"
        '
        'lbl_6
        '
        Me.lbl_6.AutoSize = True
        Me.lbl_6.ForeColor = System.Drawing.Color.White
        Me.lbl_6.Location = New System.Drawing.Point(293, 271)
        Me.lbl_6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(204, 20)
        Me.lbl_6.TabIndex = 13
        Me.lbl_6.Text = "Proyecto 2: Limpieza Espacial"
        '
        'lbl_7
        '
        Me.lbl_7.AutoSize = True
        Me.lbl_7.ForeColor = System.Drawing.Color.White
        Me.lbl_7.Location = New System.Drawing.Point(299, 299)
        Me.lbl_7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_7.Name = "lbl_7"
        Me.lbl_7.Size = New System.Drawing.Size(179, 20)
        Me.lbl_7.TabIndex = 14
        Me.lbl_7.Text = "Jose Vasquez  8-915-1712"
        '
        'lbl_8
        '
        Me.lbl_8.AutoSize = True
        Me.lbl_8.ForeColor = System.Drawing.Color.White
        Me.lbl_8.Location = New System.Drawing.Point(330, 361)
        Me.lbl_8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_8.Name = "lbl_8"
        Me.lbl_8.Size = New System.Drawing.Size(118, 20)
        Me.lbl_8.TabIndex = 15
        Me.lbl_8.Text = "II Semestre 2023"
        '
        'btn_jugar
        '
        Me.btn_jugar.Location = New System.Drawing.Point(639, 350)
        Me.btn_jugar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_jugar.Name = "btn_jugar"
        Me.btn_jugar.Size = New System.Drawing.Size(90, 27)
        Me.btn_jugar.TabIndex = 16
        Me.btn_jugar.Text = "Jugar"
        Me.btn_jugar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 459)
        Me.Controls.Add(Me.btn_jugar)
        Me.Controls.Add(Me.lbl_8)
        Me.Controls.Add(Me.lbl_7)
        Me.Controls.Add(Me.lbl_6)
        Me.Controls.Add(Me.lbl_5)
        Me.Controls.Add(Me.lbl_4)
        Me.Controls.Add(Me.lbl_3)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.lbl_temp)
        Me.Controls.Add(Me.lbl_velocidad)
        Me.Controls.Add(Me.lbl_carga)
        Me.Controls.Add(Me.lbl_vidas)
        Me.Controls.Add(Me.txt_aux)
        Me.Controls.Add(Me.lbl_tiempo)
        Me.Controls.Add(Me.lbl_puntos)
        Me.Controls.Add(Me.lbl_nivel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmr_Mover As Timer
    Friend WithEvents lbl_nivel As Label
    Friend WithEvents lbl_puntos As Label
    Friend WithEvents lbl_tiempo As Label
    Friend WithEvents txt_aux As TextBox
    Friend WithEvents lbl_vidas As Label
    Friend WithEvents lbl_carga As Label
    Friend WithEvents lbl_velocidad As Label
    Friend WithEvents lbl_temp As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_3 As Label
    Friend WithEvents lbl_4 As Label
    Friend WithEvents lbl_5 As Label
    Friend WithEvents lbl_6 As Label
    Friend WithEvents lbl_7 As Label
    Friend WithEvents lbl_8 As Label
    Friend WithEvents btn_jugar As Button
End Class
