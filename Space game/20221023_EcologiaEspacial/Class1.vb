Public Class Base
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

    Public Sub New(ancho As Integer, alto As Integer, velocidad As Integer)
        imagen = New PictureBox()
        imagen.Size = New Size(300, 50)
        imagen.Location = New Point(0, alto - 50 - imagen.Height)
        imagen.Image = Image.FromFile("img/base.png")
        imagen.BackColor = Color.Transparent
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
        dirx = velocidad * 10
    End Sub

    Public Sub Mover(ancho_form As Integer)
        If x >= ancho_form Then
            imagen.Location = New Point(-(30 + imagen.Width), y)
        Else
            imagen.Location = New Point(x + dirx, y)
        End If
    End Sub

End Class
