Public Class Nave
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

    Private _velocidad_max As Integer
    Public Property velocidad_max() As Integer
        Get
            Return _velocidad_max
        End Get
        Set(ByVal value As Integer)
            _velocidad_max = value
        End Set
    End Property

    Private _velocidad_min As Integer
    Public Property velocidad_min() As Integer
        Get
            Return _velocidad_min
        End Get
        Set(ByVal value As Integer)
            _velocidad_min = value
        End Set
    End Property

    Private _cambio As Integer
    Public Property cambio() As Integer
        Get
            Return _cambio
        End Get
        Set(ByVal value As Integer)
            _cambio = value
        End Set
    End Property

    Private _timer As Double
    Public Property timer() As Double
        Get
            Return _timer
        End Get
        Set(ByVal value As Double)
            _timer = value
        End Set
    End Property

    Public Sub New(ancho_ventana As Integer, alto_ventana As Integer, ancho As Integer, alto As Integer, velocidad As Integer)
        imagen = New PictureBox()
        imagen.Size = New Size(ancho, alto)
        imagen.Location = New Point(ancho_ventana / 2, alto_ventana - 150 - imagen.Height)
        imagen.Image = Image.FromFile("img/Ship.png")
        imagen.BackColor = Color.Transparent
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
        velocidad_min = velocidad
        velocidad_max = velocidad * 5
        cambio = velocidad_min
        timer = 3
    End Sub

    Public Sub Mover(ancho As Integer, alto As Integer)
        'Rebotar en los bordes de la ventana
        If x <= 10 Or x >= ancho - 50 Then
            dirx = -dirx
        End If
        If y <= 10 Or y >= alto - imagen.Height - 60 Then
            diry = -diry
        End If

        SeleccionarImagen()

        'Mover
        imagen.Location = New Point(x + dirx, y + diry)
    End Sub

    Public Sub Destruir(ancho_ventana As Integer, alto_ventana As Integer)
        dirx = 0
        diry = 0
        imagen.Location = New Point(ancho_ventana / 2, alto_ventana - 150 - imagen.Height)
    End Sub

    Public Sub SeleccionarImagen()
        Dim sentido As String
        sentido = ""
        If diry > 0 Then
            sentido += "s"
        ElseIf diry < 0 Then
            sentido += "n"
        End If

        If dirx > 0 Then
            sentido += "e"
        ElseIf dirx < 0 Then
            sentido += "w"
        End If

        imagen.Image = Image.FromFile("img/Ship" + sentido + ".png")
    End Sub

End Class
