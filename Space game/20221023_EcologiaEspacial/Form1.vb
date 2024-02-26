Public Class Form1
    Private nivel, tiempo_nave, vidas, carga, puntos, ptsXnivel As Integer
    Private crono, temp As Double
    Private n_desechos, n_asteroides As Integer
    Private temp_des As Integer
    Private base As Base
    Private nave As Nave
    Private des As Desecho
    Private v_desechos(9) As Desecho
    Private ast As Asteroide
    Private v_asteroides(9) As Asteroide
    Private ancho_nave, alto_nave As Integer
    Private pxXtick, velocidad_min As Integer
    Private sig_nivel As Boolean

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Height = 630
        Me.Width = 1200
    End Sub

    Private Sub btn_jugar_Click(sender As Object, e As EventArgs) Handles btn_jugar.Click
        btn_jugar.Visible = False
        lbl_1.Visible = False
        lbl_2.Visible = False
        lbl_3.Visible = False
        lbl_4.Visible = False
        lbl_5.Visible = False
        lbl_6.Visible = False
        lbl_7.Visible = False
        lbl_8.Visible = False
        txt_aux.Visible = False
        NuevoJuego()
    End Sub

    Private Sub NuevoJuego()
        'Parametros del juego
        nivel = 1
        crono = 0
        tiempo_nave = 40
        temp = tiempo_nave
        vidas = 5
        carga = 0
        n_desechos = 10
        n_asteroides = 10
        temp_des = 5

        ancho_nave = 50
        alto_nave = 50

        ptsXnivel = 30
        velocidad_min = 10 'px por segundos
        pxXtick = velocidad_min * (tmr_Mover.Interval / 1000)

        'Inicializando objetos
        base = New Base(Me.Width, Me.Height, pxXtick)
        nave = New Nave(Me.Width, Me.Height, ancho_nave, alto_nave, pxXtick)

        Controls.Add(base.imagen)
        Controls.Add(nave.imagen)

        Dim i As Integer
        For i = 0 To n_desechos - 1
            des = New Desecho(Me.Width, Me.Height, ancho_nave, alto_nave, pxXtick, temp_des)
            v_desechos(i) = des
            des.activo = True
            Controls.Add(des.imagen)
        Next

        For i = 0 To n_asteroides - 1
            ast = New Asteroide(Me.Width, Me.Height, ancho_nave, alto_nave, pxXtick)
            v_asteroides(i) = ast
            If (i <= nivel - 1) Then
                ast.activo = True
                ast.imagen.Visible = True
            Else
                ast.activo = False
                ast.imagen.Visible = False
            End If
            Controls.Add(ast.imagen)
        Next

        ActualizarLbls()

        tmr_Mover.Start()
    End Sub

    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick
        'Tiempo y cronometro
        crono += tmr_Mover.Interval / 1000
        temp -= tmr_Mover.Interval / 1000
        'If nave.timer > 0 Then
        nave.timer -= tmr_Mover.Interval / 1000
        'End If

        'Mover objetos
        base.Mover(Me.Width)
        nave.Mover(Me.Width, Me.Height)

        'Verificar interseccion de nave con la base
        If nave.imagen.Bounds.IntersectsWith(base.imagen.Bounds) Then
            If nave.diry > nave.velocidad_min Or nave.diry < -nave.velocidad_min Or nave.dirx < -nave.velocidad_min Or nave.dirx > nave.velocidad_min Then
                'Se destruye la nave
                If nave.timer <= 0 Then
                    nave.Destruir(Me.Width, Me.Height)
                    nave.timer = 3
                    vidas -= 1
                End If
            Else
                'Rebotar nave
                nave.diry = -nave.diry
                'Incrementar puntos
                Dim puntos_antes As Integer = puntos
                puntos += 10 * carga
                'Incrementar nivel
                If puntos > puntos_antes And puntos > (nivel * ptsXnivel) - 1 Then
                    nivel += 1
                    sig_nivel = True
                End If
            End If
            carga = 0
            RestablecerTemp()
        End If

        'Verificar intersección de los desechos
        For Each des In v_desechos
            'Verificar si el desecho esta mostrado en la pantalla
            If (des.activo) Then
                'Verificar si colisiona con la nave
                If des.imagen.Bounds.IntersectsWith(nave.imagen.Bounds) Then
                    If carga < 3 Then
                        carga += 1
                        des.activo = False
                        des.imagen.Visible = False
                    End If
                Else
                    'Verificar si colisiona con algun asteroide
                    'Contabilizar asteroides en pantalla en ese momento
                    Dim j As Integer
                    j = 0
                    For Each ast In v_asteroides
                        'Verificar si el asteroide esta mostrado en pantalla
                        If ast.activo Then
                            j += 1
                            'ast.Mover(Me.Width, Me.Height)
                            If ast.imagen.Bounds.IntersectsWith(des.imagen.Bounds) Then
                                'Hacer que el desecho rebote
                                des.dirx = -des.dirx
                                des.diry = -des.diry

                                des.imagen.Location = New Point(des.imagen.Location.X + 15 * ast.dirx, des.imagen.Location.Y + 15 * -ast.diry)
                                des.Mover(Me.Width, Me.Height)
                            End If
                            If ast.imagen.Bounds.IntersectsWith(base.imagen.Bounds) Then
                                'Hacer que el asteroide rebote
                                ast.diry = -ast.diry
                            End If
                            If ast.imagen.Bounds.IntersectsWith(nave.imagen.Bounds) Then
                                'Destruir nave y restar una vida
                                If nave.timer <= 0 Then
                                    nave.Destruir(Me.Width, Me.Height)
                                    nave.timer = 3
                                    vidas -= 1
                                    carga = 0
                                    RestablecerTemp()
                                End If
                            End If
                            For Each asteroide In v_asteroides
                                If asteroide.activo Then
                                    If Not asteroide.Equals(ast) And ast.imagen.Bounds.IntersectsWith(asteroide.imagen.Bounds) Then
                                        'Hacer que ambos asteroides reboten
                                        ast.dirx = -ast.dirx
                                        ast.diry = -ast.diry
                                        asteroide.dirx = -asteroide.dirx
                                        asteroide.diry = -asteroide.diry
                                        asteroide.diry = -asteroide.diry
                                    End If
                                End If
                            Next
                            ast.Mover(Me.Width, Me.Height)
                        Else
                            If j < nivel Then
                                ast.activo = True
                                ast.imagen.Visible = True
                                j += 1
                            End If
                        End If
                        If sig_nivel Then
                            ast.dirx += pxXtick / 3
                            ast.diry += pxXtick / 3
                        End If
                    Next
                End If
                des.Mover(Me.Width, Me.Height)
            Else
                If (des.timer > 0) Then
                    des.timer -= tmr_Mover.Interval / 1000
                Else
                    des.activo = True
                    des.timer = 5
                    des.Reubicar(Me.Width, Me.Height)
                    des.imagen.Visible = True
                End If
            End If
            If sig_nivel Then
                des.dirx += pxXtick
                des.diry += pxXtick
            End If
        Next

        sig_nivel = False
        ActualizarLbls()

        'Terminar juego si no quedan vidas
        If vidas <= 0 Then
            tmr_Mover.Stop()
            txt_aux.Visible = True
            txt_aux.BringToFront()
            txt_aux.Text = "GAME OVER"
            Return
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        'Solamente se permite controlar la nave si hay tiempo en el cronometro
        If temp > 0 Then
            Select Case keyData
                Case Keys.Up
                    If nave.diry > -nave.velocidad_max Then
                        nave.diry -= nave.cambio
                    End If
                Case Keys.Down
                    If nave.diry < nave.velocidad_max Then
                        nave.diry += nave.cambio
                    End If
                Case Keys.Left
                    If nave.dirx > -nave.velocidad_max Then
                        nave.dirx -= nave.cambio
                    End If
                Case Keys.Right
                    If nave.dirx < nave.velocidad_max Then
                        nave.dirx += nave.cambio
                    End If
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub ActualizarLbls()
        lbl_nivel.Text = "Nivel: " & nivel
        lbl_puntos.Text = "Puntos: " & puntos
        lbl_tiempo.Text = "Crono: " & CInt(crono)
        lbl_carga.Text = "Carga: " & carga
        lbl_velocidad.Text = "px/seg: " & Velocidad()
        If temp >= 0 Then
            lbl_temp.Text = "Temp: " & CInt(temp)
        Else
            lbl_temp.Text = "Temp: 0"
        End If
        If vidas >= 0 Then
            lbl_vidas.Text = "Vidas: " & vidas
        Else
            lbl_vidas.Text = "Vidas: 0"
        End If
        'txt_aux.Text = ""
    End Sub

    Private Function Velocidad() As Integer
        Dim v_x, v_y, mayor As Integer
        v_x = nave.dirx
        If v_x < 0 Then
            v_x *= -1
        End If
        v_y = nave.diry
        If v_y < 0 Then
            v_y *= -1
        End If
        mayor = v_y
        If v_x > mayor Then
            mayor = v_x
        End If
        Return mayor * 10
    End Function

    Private Sub RestablecerTemp()
        temp = tiempo_nave
    End Sub

End Class
