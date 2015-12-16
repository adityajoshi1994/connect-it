Public Class DiaGraph

    Private _NodeList As New List(Of Node)
    Private _EdgeList As New List(Of Edge)
    Private Edge As New Dictionary(Of Node, List(Of Node))

    Public Sub AddNode(ByVal NewNode As Node)
        Dim ListChild As New List(Of Node)

        If _NodeList.Contains(NewNode) Then
            MsgBox("Duplicate Node", MsgBoxStyle.OkOnly)
        Else
            _NodeList.Add(NewNode)
            Edge.Add(NewNode, ListChild)

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

                _EdgeList.Add(NewEdge)

                source.setEdge(NewEdge)
                dest.setEdge(NewEdge)
            Else
                MsgBox("confusig Error")
            End If
        End If

    End Sub

    Public Function ParentOf(ByVal ParentNode As Node)
        Dim ChildList As New List(Of Node)

        ChildList = Edge.Item(ParentNode)

        Return ChildList

    End Function

    Public Function GraphNodes()
        Return _NodeList.Count
    End Function
End Class
