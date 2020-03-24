Imports System.Random

Public Class Game

    Private _Largeur As Integer
    Private _Hauteur As Integer

    Private _Population As List(Of Personne)
    Private _TaillePop As Integer
    Private _Compteurs As New Dictionary(Of Statut_Infection, Integer)
    Private _Correspondance_Compteurs_Label As New Dictionary(Of Statut_Infection, Label) From {{Statut_Infection.NON_INFECTE, Main.Label_Main_Compteurs_Valeur_NI}, {Statut_Infection.INFECTE_ASYMPTOTIQUE, Main.Label_Main_Compteurs_Valeur_A}, {Statut_Infection.INFECTE_SYMPTOMATIQUE_NH, Main.Label_Main_Compteurs_Valeur_SNH}, {Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FAIBLE, Main.Label_Main_Compteurs_Valeur_SHFa}, {Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FORT, Main.Label_Main_Compteurs_Valeur_SHFo}, {Statut_Infection.INFECTE_DECEDE, Main.Label_Main_Compteurs_Valeur_Deces}}

    Private _Parametres As Parametres

    Private _Pause As Boolean
    Private _Quitter As Boolean
    Private _SimulerOneTurn As Boolean

    Private _Log As List(Of String)

    Public Event Log_Modifie As EventHandler

    Protected Overridable Sub OnReceive(e As EventArgs)
        RaiseEvent Log_Modifie(Me, e)
    End Sub

    Public Sub New(ByVal Largeur As Integer, ByVal Hauteur As Integer, ByRef Parametres As Parametres)

        _Largeur = Largeur
        _Hauteur = Hauteur
        _TaillePop = Parametres.TaillePop

        _Parametres = Parametres

        _Pause = False
        _Quitter = False
        _SimulerOneTurn = False

        For Each Etat In System.Enum.GetValues(GetType(Statut_Infection))
            _Compteurs.Add(Etat, 0)
        Next

        _Log = New List(Of String)

        InitPop()

    End Sub

    Public Sub InitPop()

        Dim Rand As New Random()

        _Population = New List(Of Personne)

        For I As Integer = 0 To _TaillePop
            _Population.Add(New Personne(I, New SFML.System.Vector2i(Rand.Next(0, Largeur), Rand.Next(0, Hauteur)), Me))
        Next

        _Compteurs(Statut_Infection.NON_INFECTE) = _TaillePop - 1

        Dim Patient0 As Integer = CInt((_Population.Count + 1) * Rand.NextDouble())

        _Population(Patient0).Etat = Statut_Infection.INFECTE_ASYMPTOTIQUE
        _Compteurs(Statut_Infection.INFECTE_ASYMPTOTIQUE) = 1
        Log_Add_Status_Switch(_Population(Patient0).Id, Statut_Infection.NON_INFECTE, Statut_Infection.INFECTE_ASYMPTOTIQUE)

    End Sub

    Public Sub UpdateCompteur(ByVal CompteurEtat As Statut_Infection, ByVal NouvelleValeur As Integer)
        _Compteurs(CompteurEtat.ToString) = NouvelleValeur
    End Sub

    Public Sub Next_Turn()

        Dim DX As Integer = 0
        Dim DY As Integer = 0

        Dim Rand As New Random()

        For Each personne In _Population

            Dim Old_Etat As Statut_Infection = personne.Etat

            DX = _Parametres.Amplitude_Deplacement * (-1 + 2 * Rand.NextDouble())
            DY = _Parametres.Amplitude_Deplacement * (-1 + 2 * Rand.NextDouble())

            If personne.Etat = Statut_Infection.NON_INFECTE And Not personne.Immunite Then
                For Each personne2 In _Population
                    If personne2.Etat = Statut_Infection.INFECTE_ASYMPTOTIQUE Then
                        Dim distancePersonne As Integer = Math.Pow(personne2.Pos.X - personne.Pos.X, 2) + Math.Pow(personne2.Pos.Y - personne.Pos.Y, 2)
                        If (distancePersonne <= Math.Pow(_Parametres.Zone_Infection, 2) And Rand.NextDouble() < _Parametres.Proba_Infection) Then
                            personne.Immunite = True
                            personne.Etat = Statut_Infection.INFECTE_ASYMPTOTIQUE
                        End If
                    End If
                Next
            End If

            If personne.Etat = Statut_Infection.INFECTE_DECEDE Then
                DX = 0
                DY = 0
            End If

            If personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FORT Then
                DX = 0
                DY = 0
                If Rand.NextDouble() < _Parametres.Proba_Mort Then
                    personne.Etat = Statut_Infection.INFECTE_DECEDE
                End If
            End If

            If personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FAIBLE Then
                DX = 0
                DY = 0
                If Rand.NextDouble() < _Parametres.Proba_Complications Then
                    personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FORT
                End If
            End If

            If personne.Etat = Statut_Infection.INFECTE_ASYMPTOTIQUE Then
                If Rand.NextDouble() < _Parametres.Proba_Symptomes Then
                    personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_NH
                Else
                    personne.Etat = Statut_Infection.INFECTE_ASYMPTOTIQUE
                End If
            End If

            If personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_NH Then

                If _Parametres.Confinement Then
                    DX = 0
                    DY = 0
                End If

                If Rand.NextDouble() < _Parametres.Proba_Hopital Then
                    personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FAIBLE
                    DX = -personne.Pos.X
                    DY = -personne.Pos.Y
                End If

            End If

            If personne.Etat > 0 AndAlso personne.Etat < 5 AndAlso Rand.NextDouble() < _Parametres.Proba_Guerison(personne.Etat) Then
                If personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FAIBLE Or personne.Etat = Statut_Infection.INFECTE_SYMPTOMATIQUE_H_FORT Then
                    DX = personne.Pos_Domicile.X
                    DY = personne.Pos_Domicile.Y
                End If
                personne.Etat = Statut_Infection.NON_INFECTE
            End If

            personne.Move(New SFML.System.Vector2i(personne.Pos.X + DX, personne.Pos.Y + DY))

            If Old_Etat <> personne.Etat Then
                Log_Add_Status_Switch(personne.Id, Old_Etat, personne.Etat)
                Maj_Compteurs(Old_Etat, personne.Etat)
            End If

        Next

        _SimulerOneTurn = False

    End Sub

    Private Sub Maj_Compteurs(ByVal Old_Statut As Statut_Infection, ByVal New_Statut As Statut_Infection)
        _Compteurs(Old_Statut) -= 1
        _Compteurs(New_Statut) += 1
    End Sub

    Private Sub Log_Add_Status_Switch(ByVal Id As Integer, ByVal OldStatut As Statut_Infection, ByVal NewStatut As Statut_Infection)
        Dim Str As String = "Personne " + CType(Id, String) + " est passée de " + OldStatut.ToString() + " à " + NewStatut.ToString()
        _Log.Add(Str)
        _Population(Id).Add_Log(Str)
        Raise_Log_Modife()
    End Sub

    Private Sub Raise_Log_Modife()
        RaiseEvent Log_Modifie(Me, New System.EventArgs)
    End Sub

    Public Property Largeur As Integer
        Get
            Return _Largeur
        End Get
        Set(value As Integer)
            _Largeur = value
        End Set
    End Property

    Public Property Hauteur As Integer
        Get
            Return _Hauteur
        End Get
        Set(value As Integer)
            _Hauteur = value
        End Set
    End Property

    Public Property TaillePop As Integer
        Get
            Return _TaillePop
        End Get
        Set(value As Integer)
            _TaillePop = value
        End Set
    End Property

    Public Property Population As List(Of Personne)
        Get
            Return _Population
        End Get
        Set(value As List(Of Personne))
            _Population = value
        End Set
    End Property

    Public Property Compteurs As Dictionary(Of Statut_Infection, Integer)
        Get
            Return _Compteurs
        End Get
        Set(value As Dictionary(Of Statut_Infection, Integer))
            _Compteurs = value
        End Set
    End Property

    Public Property Correspondance_Compteurs_Label As Dictionary(Of Statut_Infection, Label)
        Get
            Return _Correspondance_Compteurs_Label
        End Get
        Set(value As Dictionary(Of Statut_Infection, Label))
            _Correspondance_Compteurs_Label = value
        End Set
    End Property

    Public Property Pause As Boolean
        Get
            Return _Pause
        End Get
        Set(value As Boolean)
            _Pause = value
        End Set
    End Property

    Public Property Quitter As Boolean
        Get
            Return _Quitter
        End Get
        Set(value As Boolean)
            _Quitter = value
        End Set
    End Property

    Public Property Log As List(Of String)
        Get
            Return _Log
        End Get
        Set(value As List(Of String))
            _Log = value
        End Set
    End Property

    Public Property SimulerOneTurn As Boolean
        Get
            Return _SimulerOneTurn
        End Get
        Set(value As Boolean)
            _SimulerOneTurn = value
        End Set
    End Property

    Public Property Parametres As Parametres
        Get
            Return _Parametres
        End Get
        Set(value As Parametres)
            _Parametres = value
        End Set
    End Property

End Class
