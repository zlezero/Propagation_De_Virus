Imports SFML.System

Public Class Personne

    Private _Id As Integer
    Private _Pos As SFML.System.Vector2i
    Private _Etat As Statut_Infection
    Private _Pos_Domicile As SFML.System.Vector2i
    Private _Immunite As Boolean

    Private _Delta As SFML.System.Vector2i = Nothing

    Private _Game As Game

    Public Event Etat_Change As EventHandler

    Public Sub New(ByVal Id As Integer, ByVal InitPos As SFML.System.Vector2i, ByRef Game As Game)
        _Id = Id
        _Pos = InitPos
        _Etat = Statut_Infection.NON_INFECTE
        _Pos_Domicile = _Pos
        _Game = Game
        _Immunite = False
    End Sub

    Public Sub Move(ByVal NewPos As Vector2i)

        Dim Delta As New Vector2i(NewPos.X - _Pos.X, NewPos.Y - _Pos.Y)

        Dim X As Integer = _Pos.X
        Dim Y As Integer = _Pos.Y

        'Droite
        If _Pos.X + _Game.Parametres.Rayon + Delta.X > _Game.Largeur Then
            X = 2 * (_Game.Largeur - _Game.Parametres.Rayon) - X
            Delta = New Vector2i(-Delta.X, Delta.Y)
        End If

        'Gauche
        If _Pos.Y + _Game.Parametres.Rayon + Delta.Y > _Game.Hauteur Then
            Y = 2 * (_Game.Hauteur - _Game.Parametres.Rayon) - Y
            Delta = New Vector2i(Delta.X, -Delta.Y)
        End If

        'Bas
        If Y - _Game.Parametres.Rayon + Delta.Y < 0 Then
            Y = 2 - _Game.Parametres.Rayon - Y
            Delta = New Vector2i(Delta.X, -Delta.Y)
        End If

        X += Delta.X
        Y += Delta.Y

        _Pos = New Vector2i(X, Y)
        _Delta = New Vector2i(Delta.X, Delta.Y)

    End Sub

    Public Property Pos As Vector2i
        Get
            Return _Pos
        End Get
        Set(value As Vector2i)
            _Pos = value
            RaiseEvent Etat_Change(Me, New EventArgs)
        End Set
    End Property

    Public Property Etat As Statut_Infection
        Get
            Return _Etat
        End Get
        Set(value As Statut_Infection)
            _Etat = value
            RaiseEvent Etat_Change(Me, New EventArgs)
        End Set
    End Property

    Public Property Pos_Domicile As Vector2i
        Get
            Return _Pos_Domicile
        End Get
        Set(value As Vector2i)
            _Pos_Domicile = value
            RaiseEvent Etat_Change(Me, New EventArgs)
        End Set
    End Property

    Public Property Delta As Vector2i
        Get
            Return _Delta
        End Get
        Set(value As Vector2i)
            _Delta = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property Immunite As Boolean
        Get
            Return _Immunite
        End Get
        Set(value As Boolean)
            _Immunite = value
            RaiseEvent Etat_Change(Me, New EventArgs)
        End Set
    End Property

End Class
