Imports System.Drawing

Public Class Graph
    Private _NodeList As New List(Of Node)
    Private _EdgeList As New List(Of Edge)
    Private Edge As New Dictionary(Of Node, List(Of Node))


    Public ReadOnly Property NodeList() As List(Of Node)
        Get
            Return _NodeList
        End Get
    End Property

    Public Sub AddNode(ByVal NewNode As Node)
        Dim ListChild As New List(Of Node)

        If _NodeList.Contains(NewNode) Then
            MsgBox("Duplicate Node", MsgBoxStyle.OkOnly)
        Else
            _NodeList.Add(NewNode)
            Edge.Add(NewNode, ListChild)
            'MsgBox(Edge.Keys.Count)
            'Edge.Item(NewNode) = ListChild
        End If
    End Sub

    Public Sub AddEdge(ByVal NewEdge As Edge)
        Dim source As Node = NewEdge.Source
        Dim dest As Node = NewEdge.Destination

        If Not (_NodeList.Contains(source) Or _NodeList.Contains(dest)) Then
            MsgBox("Node does not exist", MsgBoxStyle.Critical)
        Else
            If Edge.ContainsKey(source) Then
                Edge.Item(source).Add(dest)
                Edge.Item(dest).Add(source) '(THINK ABOUT IT)

                source.NodeEdge = NewEdge
                dest.NodeEdge = NewEdge

                source.Degree = 1
                dest.Degree = 1

                _EdgeList.Add(NewEdge)

                source.setEdge(NewEdge)
                dest.setEdge(NewEdge)
            Else
                MsgBox("confusig Error")
            End If
        End If

    End Sub

    Public Function ChildrenOf(ByVal ParentNode As Node)
        Dim ChildList As New List(Of Node)

        ChildList = Edge.Item(ParentNode)

        Return ChildList

    End Function

    Public Function GraphNodes()
        Return _NodeList.Count
    End Function

    Public Function GetAllEdges()
        Return _EdgeList
    End Function


    '============================ Not Necessary Function!! ===================================================================

    Public Function ReturnEdge(ByVal SourceNode As Node)
        Dim myEdges As New List(Of Edge)

        For Each eleEdge In _EdgeList
            If eleEdge.Source.NodeName = SourceNode.NodeName Then
                myEdges.Add(eleEdge)
            ElseIf eleEdge.Destination.NodeName = SourceNode.NodeName Then
                myEdges.Add(eleEdge)
            End If
        Next
        MsgBox(myEdges.Count)

        Return myEdges
    End Function
End Class