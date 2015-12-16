Imports System.Drawing
''' <summary>
''' Problem in list of edge! not particulat to node!
''' </summary>
''' <remarks></remarks>
Public Class Node
    Inherits Button

    Dim _name As String
    Dim _cordinate As Point
    Dim _Edge As New List(Of Edge)
    Dim _Degree As Integer

    'Not necessary property
    Dim __edge As Edge

    Public visited As Boolean = False



    Public Sub New()
        Width = 20
        Height = 20
        BackColor = Color.White
    End Sub

    Public Property NodeName() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Property Nodecordinate() As Point
        Get
            Return _cordinate
        End Get
        Set(ByVal value As Point)
            _cordinate = value
        End Set
    End Property

    Public Property Degree() As Integer
        Get
            Return _Degree
        End Get
        Set(ByVal value As Integer)
            _Degree += value
        End Set
    End Property


    ''' <summary>
    ''' NOT NECESSARY PROPERTY!!!!
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NodeEdge() As Edge
        Get
            Return __edge
        End Get
        Set(ByVal value As Edge)
            __edge = value
        End Set
    End Property

    Public Function getEdge()
        Return _Edge
    End Function

    Public Sub setEdge(ByVal targetEdge As Edge)
        _Edge.Add(targetEdge)
    End Sub

    Private Sub Node_MouseUP(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim cms = New ContextMenuStrip

            'Item first
            Dim item1 = cms.Items.Add("Properties")
            item1.Tag = 1
            AddHandler item1.Click, AddressOf frmMain.NodeRightClick

            cms.Show(sender, e.Location)
        End If
    End Sub
    
End Class
