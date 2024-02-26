Public Class Asteroide
    Private rnd As New Random()
    Private _imagen As PictureBox
    Public Property imagen() As PictureBox
        Get
            Return _imagen
        End Get
        Set(ByVal value As PictureBox)
            _imagen = value
        End Set
    End Property

    Private _x As Integer
    Public Property x() As Integer
        Get
            Return imagen.Location.X
        End Get
        Set(ByVal value As Integer)
            _x = value
        End Set
    End Property

    Private _y As Integer
    Public Property y() As Integer
        Get
            Return imagen.Location.Y
        End Get
        Set(ByVal value As Integer)
            _y = value
        End Set
    End Property

    Private _dirx As Integer
    Public Property dirx() As Integer
        Get
            Return _dirx
        End Get
        Set(ByVal value As Integer)
            _dirx = value
        End Set
    End Property

    Private _diry As Integer
    Public Property diry() As Integer
        Get
            Return _diry
        End Get
        Set(ByVal value As Integer)
            _diry = value
        End Set
    End Property

    Private _activo As Boolean
    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    Public Sub New(ancho_ventana As Integer, alto_ventana As Integer, ancho_nave As Integer, alto_nave As Integer, velocidad As Integer)
        imagen = New PictureBox()
        imagen.Size = New Size(2 * ancho_nave, 2 * alto_nave)
        imagen.Location = New Point(rnd.Next(1, ancho_ventana - (imagen.Width + 20)), rnd.Next(1, alto_ventana - (imagen.Height + 50)))
        imagen.Image = Image.FromFile("img/meteoro.png")
        imagen.BackColor = Color.Transparent
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
        dirx = -velocidad
        diry = -velocidad
    End Sub

    Public Sub Mover(ancho As Integer, alto As Integer)
        'Rebotar en los bordes de la ventana
        If x <= 10 Or x >= ancho - imagen.Width Then
            dirx = -dirx
        End If
        If y <= 10 Or y >= alto - imagen.Height - 60 Then
            diry = -diry
        End If

        'Mover
        imagen.Location = New Point(x + dirx, y + diry)
    End Sub

    Public Sub IncrementarVelocidad(nivel)
        'dirx *= nivel
        'diry *= nivel
    End Sub
End Class
