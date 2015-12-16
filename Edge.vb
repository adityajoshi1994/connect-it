Imports System.Drawing

Public Class Edge

    Dim _source As New Node
    Dim _dest As New Node
    Dim _Weight As Integer

    Public Property Source() As Node
        Get
            Return _source
        End Get
        Set(ByVal value As Node)
            _source = value
        End Set
    End Property

    Public Property Destination() As Node
        Get
            Return _dest
        End Get
        Set(ByVal value As Node)
            _dest = value
        End Set
    End Property

    Public Property Weight() As Integer
        Get
            Return _Weight
        End Get
        Set(ByVal value As Integer)
            _Weight = value
        End Set
    End Property


End Class