Public Class Parametres


    'Probabilités
    Private _Proba_Infection As Double
    Private _Proba_Symptomes As Double
    Private _Proba_Hopital As Double
    Private _Proba_Complications As Double
    Private _Proba_Mort As Double
    Private _Proba_Guerison As New Dictionary(Of Integer, Double)

    'Autres constantes
    Private _Confinement As Boolean
    Private _Zone_Infection As Integer
    Private _Rayon As Integer
    Private _Amplitude_Deplacement As Integer

    Public Sub New()
        Load_Default_Value()
    End Sub

    Public Sub Load_Default_Value()

        _Proba_Infection = 9 / 10
        _Proba_Symptomes = 1 / 100
        _Proba_Hopital = 1 / 100
        _Proba_Complications = 1 / 100
        _Proba_Mort = 1 / 20
        _Proba_Guerison = New Dictionary(Of Integer, Double) From {{1, 1 / 100}, {2, 1 / 200}, {3, 1 / 300}, {4, 1 / 400}}

        _Confinement = True
        _Zone_Infection = 10
        _Rayon = 1
        _Amplitude_Deplacement = 10

    End Sub

    Public Property Proba_Infection As Double
        Get
            Return _Proba_Infection
        End Get
        Set(value As Double)
            _Proba_Infection = value
        End Set
    End Property

    Public Property Proba_Symptomes As Double
        Get
            Return _Proba_Symptomes
        End Get
        Set(value As Double)
            _Proba_Symptomes = value
        End Set
    End Property

    Public Property Proba_Hopital As Double
        Get
            Return _Proba_Hopital
        End Get
        Set(value As Double)
            _Proba_Hopital = value
        End Set
    End Property

    Public Property Proba_Complications As Double
        Get
            Return _Proba_Complications
        End Get
        Set(value As Double)
            _Proba_Complications = value
        End Set
    End Property

    Public Property Proba_Mort As Double
        Get
            Return _Proba_Mort
        End Get
        Set(value As Double)
            _Proba_Mort = value
        End Set
    End Property

    Public Property Proba_Guerison As Dictionary(Of Integer, Double)
        Get
            Return _Proba_Guerison
        End Get
        Set(value As Dictionary(Of Integer, Double))
            _Proba_Guerison = value
        End Set
    End Property

    Public Property Confinement As Boolean
        Get
            Return _Confinement
        End Get
        Set(value As Boolean)
            _Confinement = value
        End Set
    End Property

    Public Property Zone_Infection As Integer
        Get
            Return _Zone_Infection
        End Get
        Set(value As Integer)
            _Zone_Infection = value
        End Set
    End Property

    Public Property Rayon As Integer
        Get
            Return _Rayon
        End Get
        Set(value As Integer)
            _Rayon = value
        End Set
    End Property

    Public Property Amplitude_Deplacement As Integer
        Get
            Return _Amplitude_Deplacement
        End Get
        Set(value As Integer)
            _Amplitude_Deplacement = value
        End Set
    End Property

End Class
