Module PathAlgorithm
    Dim predecessor As New Dictionary(Of Node, Node)
    Dim heap As New List(Of Node)
    Dim distance As New Dictionary(Of Node, Integer)

    'Public Variables used
    Dim visited As New Dictionary(Of Node, Integer)
    Dim arrival As New Dictionary(Of Node, Integer)
    Dim brignode As New List(Of Node)
    Dim time As Integer
    Dim brigedge As New List(Of Edge)


    Public Function DFS(ByVal graph As Graph, ByVal startNode As Node, ByVal goalNode As Node, ByRef Shortestpath As List(Of Node))
        Dim newPath As New List(Of Node)

        Shortestpath.Add(startNode)
        startNode.visited = True

        If startNode.NodeName = goalNode.NodeName Then
            Return Shortestpath
        End If

        For Each eleNode In graph.ChildrenOf(startNode)
            'If Not Shortestpath.Contains(eleNode) Then
            If Not eleNode.visited = True Then

                newPath = DFS(graph, eleNode, goalNode, Shortestpath)
                If Not newPath.Count = 0 Then
                    Return newPath
                Else
                    Return 0
                End If
            End If
        Next
    End Function

    Public Sub connectivity(ByVal graph As Graph, ByVal startNode As Node, ByRef TravelList As List(Of Node), ByVal myNodes As List(Of Node))
        Dim newPath As New List(Of Node)

        TravelList.Add(startNode)
        startNode.visited = True

        For Each eleNode In graph.ChildrenOf(startNode)

            If eleNode.visited = False Then
                connectivity(graph, eleNode, TravelList, myNodes)
            End If
        Next


    End Sub

    Public Function BFS(ByVal graph As Graph, ByVal startNode As Node, ByVal endNode As Node, ByRef queue As List(Of List(Of Node)))
        Dim initPath As New List(Of Node)
        Dim tempPath As New List(Of Node)
        Dim newPath As New List(Of Node)
        Dim lastNode As Node

        initPath.Add(startNode)
        queue.Add(initPath)

        While (queue.Count <> 0)
            tempPath = queue.Item(0)
            queue.Remove(item:=queue.Item(0))
            lastNode = tempPath.Item(tempPath.Count - 1)
            If lastNode.NodeName = endNode.NodeName Then
                Return tempPath
            End If
            For Each linkNode In graph.ChildrenOf(lastNode)
                If Not linkNode.visited = True Then
                    tempPath.Add(linkNode)
                    newPath = tempPath
                    queue.Add(newPath)
                    'linkNode.visited = True
                End If
            Next
        End While

        Return 0
    End Function

    Public Function Dijkstra(ByVal graph As Graph, ByVal start As Node, ByVal goal As Node, ByVal graphNodes As List(Of Node))
        Dim ShortestPath As New List(Of Node)               '------> strores Shortest path
        Dim distance As New Dictionary(Of Node, Integer)    '------> a dictianry maintain min cost of nodes from goal in formate {"node": cost}
        Dim queue As New List(Of Node)                      '------> a queue which will pop vertices with min distance (greedy queue)
        Dim minNode As New Node                             '------> node to hold temp min distance node
        Dim weightedEdge As New Edge                        '------> temp edge to access weight as weight is prop of edge
        Dim previousNode As New Dictionary(Of Node, Node)   '------> will hold node who updated the node used for back tracking

        Dim infi As Integer = Integer.MaxValue       'very big cost!!
        Dim newDist As Integer          'variable for updating distance

        For Each eleNode In graphNodes  'all distances except for start marked infi
            distance.Item(eleNode) = infi
        Next
        distance.Item(start) = 0        'cost of start node is zero

        For Each eleNode In graphNodes  'add al nodes in queue
            queue.Add(eleNode)
        Next

        While (queue.Count)
            minNode = queue.Item(0)
            For Each eleNode In queue
                If distance.Item(eleNode) < distance.Item(minNode) Then
                    minNode = eleNode
                End If
            Next
            queue.Remove(minNode)   'pop node with min distance

            If minNode.NodeName = goal.NodeName Then 'Base condition
                Exit While
            End If
            For Each eleNode In graph.ChildrenOf(minNode)
                For Each edgee In minNode.getEdge
                    If edgee.Destination.NodeName = eleNode.NodeName Then
                        weightedEdge = edgee
                    ElseIf edgee.Source.NodeName = eleNode.NodeName Then
                        weightedEdge = edgee                                'acessing weight of particular weight
                    End If
                Next
                newDist = distance.Item(minNode) + weightedEdge.Weight 'checking for Updating distance
                If newDist < distance(eleNode) Then
                    distance(eleNode) = newDist     'Updating distance
                    previousNode.Item(eleNode) = minNode
                    'print statistics
                    Dim StatString As String = eleNode.NodeName + ":  " + distance.Item(eleNode).ToString
                    frmMain.lbAlgoStatistics.Items.Add(StatString)
                End If
            Next
        End While

        ShortestPath.Add(goal)
        Dim tempNode As Node
        tempNode = goal

        While (tempNode.NodeName <> start.NodeName)
            ShortestPath.Add(tempNode)
            tempNode = previousNode.Item(tempNode)
        End While

        ShortestPath.Add(start)

        Return ShortestPath
    End Function

    Public Function A_Star(ByVal graph As Graph, ByVal start As Node, ByVal goal As Node, ByVal graphNodes As List(Of Node))
        Dim ShortestPath As New List(Of Node)               '------> strores Shortest path
        Dim distance As New Dictionary(Of Node, Integer)    '------> a dictianry maintain min cost of nodes from goal in formate {"node": cost}
        Dim queue As New List(Of Node)                      '------> a queue which will pop vertices with min distance (greedy queue)
        Dim minNode As New Node                             '------> node to hold temp min distance node
        Dim weightedEdge As New Edge                        '------> temp edge to access weight as weight is prop of edge
        Dim previousNode As New Dictionary(Of Node, Node)   '------> will hold node who updated the node used for back tracking
        Dim huristic As Integer = 0


        Dim infi As Integer = Integer.MaxValue       'very big cost!!
        Dim newDist As Integer          'variable for updating distance

        For Each eleNode In graphNodes  'all distances except for start marked infi
            distance.Item(eleNode) = infi
        Next
        distance.Item(start) = 0        'cost of start node is zero

        For Each eleNode In graphNodes  'add al nodes in queue
            queue.Add(eleNode)
        Next

        While (queue.Count)
            minNode = queue.Item(0)
            For Each eleNode In queue
                If distance.Item(eleNode) < distance.Item(minNode) Then
                    minNode = eleNode
                End If
            Next
            queue.Remove(minNode)   'pop node with min distance

            If minNode.NodeName = goal.NodeName Then 'Base condition
                Exit While
            End If
            For Each eleNode In graph.ChildrenOf(minNode)
                For Each edgee In minNode.getEdge
                    If edgee.Destination.NodeName = eleNode.NodeName Then
                        weightedEdge = edgee
                    ElseIf edgee.Source.NodeName = eleNode.NodeName Then
                        weightedEdge = edgee                                'acessing weight of particular weight
                    End If
                Next
                newDist = distance.Item(minNode) + weightedEdge.Weight + huristic 'checking for Updating distance
                If newDist < distance(eleNode) Then
                    distance(eleNode) = newDist     'Updating distance
                    previousNode.Item(eleNode) = minNode
                    'print statistics
                    Dim StatString As String = eleNode.NodeName + ":  " + distance.Item(eleNode).ToString
                    frmMain.lbAlgoStatistics.Items.Add(StatString)
                End If
            Next
        End While

        ShortestPath.Add(goal)
        Dim tempNode As Node
        tempNode = goal

        While (tempNode.NodeName <> start.NodeName)
            ShortestPath.Add(tempNode)
            tempNode = previousNode.Item(tempNode)
        End While

        ShortestPath.Add(start)

        Return ShortestPath
    End Function

    Public Function TwoEdgeConnected(ByVal graph As Graph, ByVal start As Node, ByVal goal As Node) As Boolean


    End Function

    Public Function PrimsAlgo(ByVal graph As Graph, ByVal start As Node, ByVal graphNodes As List(Of Node))
        Dim ShortestPath As New List(Of Node)               '------> strores Shortest path
        Dim distance As New Dictionary(Of Node, Integer)    '------> a dictianry maintain min cost of nodes from goal in formate {"node": cost}
        Dim queue As New List(Of Node)                      '------> a queue which will pop vertices with min distance (greedy queue)
        Dim minNode As New Node                             '------> node to hold temp min distance node
        Dim weightedEdge As New Edge                        '------> temp edge to access weight as weight is prop of edge
        Dim previousNode As New Dictionary(Of Node, Node)   '------> will hold node who updated the node used for back tracking

        Dim infi As Integer = 999       'very big cost!!
        Dim newDist As Integer          'variable for updating distance

        For Each eleNode In graphNodes  'all distances except for start marked infi
            distance.Item(eleNode) = infi
        Next
        distance.Item(start) = 0        'cost of start node is zero

        For Each eleNode In graphNodes  'add al nodes in queue
            queue.Add(eleNode)
        Next

        While (queue.Count)
            minNode = queue.Item(0)
            For Each eleNode In queue
                If distance.Item(eleNode) < distance.Item(minNode) Then
                    minNode = eleNode
                End If
            Next
            queue.Remove(minNode)   'pop node with min distance
            minNode.visited = True

            For Each eleNode In graph.ChildrenOf(minNode)
                For Each edgee In minNode.getEdge
                    If edgee.Destination.NodeName = eleNode.NodeName Then
                        weightedEdge = edgee
                    ElseIf edgee.Source.NodeName = eleNode.NodeName Then
                        weightedEdge = edgee                                'acessing weight of particular weight
                    End If
                Next
                newDist = weightedEdge.Weight 'checking for Updating distance
                If newDist < distance(eleNode) And eleNode.visited = False Then
                    distance(eleNode) = newDist     'Updating distance
                    previousNode.Item(eleNode) = minNode
                    'print statistics
                    Dim StatString1 As String = eleNode.NodeName + ":  " + distance.Item(eleNode).ToString
                    Dim StatString As String = eleNode.NodeName + ":  " + minNode.NodeName
                    frmMain.lbAlgoStatistics.Items.Add(StatString + "  " + StatString1)
                End If
            Next
        End While

        Return previousNode

    End Function

    Public Function Kruskals(ByVal listEdge As List(Of Edge), ByVal listNode As List(Of Node))
        Dim SpanningEdges As New List(Of Edge)

        'key is son father is value!!!!
        Dim fatherSon As New Dictionary(Of Node, Node)
        Dim tempedge As New Edge
        Dim tempNode As New Node
        Dim RootV1 As New Node
        Dim RootV2 As New Node

        'sorting Edges according to weights

        For i As Integer = 0 To listEdge.Count - 1
            For j As Integer = 0 To listEdge.Count - 1
                If listEdge.Item(i).Weight < listEdge.Item(j).Weight Then
                    tempedge = listEdge.Item(j)
                    listEdge.Item(j) = listEdge.Item(i)
                    listEdge.Item(i) = tempedge
                End If
            Next
        Next


        For Each eleNode In listNode
            fatherSon.Item(eleNode) = eleNode
        Next

        For Each eleEdge In listEdge
            RootV1 = eleEdge.Source
            RootV2 = eleEdge.Destination

            While (fatherSon.Item(RootV1).NodeName <> RootV1.NodeName)
                RootV1 = fatherSon.Item(RootV1)
            End While

            While (fatherSon.Item(RootV2).NodeName <> RootV2.NodeName)
                RootV2 = fatherSon.Item(RootV2)
            End While

            If RootV1.NodeName = RootV2.NodeName Then
                'Reject Edge
            Else
                SpanningEdges.Add(eleEdge)
                fatherSon.Item(RootV2) = RootV1
            End If
        Next
        Return SpanningEdges
    End Function

    Public Function BellmanFord(ByVal graph As Graph, ByVal start As Node, ByVal goal As Node, ByVal graphNodes As List(Of Node), ByVal graphEdges As List(Of Edge))
        Dim pathLength As New Dictionary(Of Node, Integer)
        Dim preceder As New Dictionary(Of Node, Node)
        Dim infinity As Integer = Integer.MaxValue
        Dim LableVer As New Node
        Dim shortestPath As New List(Of Node)
        Dim queue As New List(Of Node)
        Dim newDist As Integer
        Dim WeightedEdge As New Edge
        Dim flag As Boolean

        For Each eleNode In graphNodes
            pathLength.Item(eleNode) = infinity
        Next

        pathLength.Item(start) = 0
        For Each vertex In graphNodes
            flag = False
            For Each line In graphEdges
                If pathLength.Item(line.Destination) > pathLength.Item(line.Source) + getweight(line.Source, line.Destination) Then
                    pathLength.Item(line.Destination) = pathLength.Item(line.Source) + getweight(line.Source, line.Destination)
                    flag = True
                    Dim StatString As String = line.Destination.NodeName + ":  " + pathLength.Item(line.Destination).ToString
                    frmMain.lbAlgoStatistics.Items.Add(StatString)
                End If
            Next
            If flag = False Then
                Exit For
            End If
        Next
        For Each line In graphEdges
            If pathLength.Item(line.Destination) > pathLength.Item(line.Source) + getweight(line.Source, line.Destination) Then
                Return 0
            End If
        Next
        Return 1
    End Function

    Public Function vertexconnected(ByVal vertex As Node, ByRef prev As Integer, ByVal graph As Graph) As Integer
        Dim smv As Integer
        Dim j As Integer

        arrival.Item(vertex) = time
        time = time + 1
        vertex.visited = True
        smv = arrival.Item(vertex)

        If arrival.Item(vertex) = 0 Then
            Dim k As Integer
            For Each elenode In graph.ChildrenOf(vertex)
                k = vertexconnected(elenode, arrival.Item(vertex), graph)
            Next
            Return k


        ElseIf arrival.Item(vertex) = 1 Then
            For Each elenode In graph.ChildrenOf(vertex)

                If Not elenode.visited = True Then
                    j = vertexconnected(elenode, arrival.Item(vertex), graph)

                    If j = 999 Then
                        brignode.Add(vertex)
                    Else
                        smv = minimum(smv, j)
                    End If


                Else
                    smv = minimum(smv, arrival.Item(elenode))

                End If
            Next
            Return smv


        Else
            For Each elenode In graph.ChildrenOf(vertex)

                If Not elenode.visited = True Then
                    j = vertexconnected(elenode, arrival.Item(vertex), graph)

                    If j = 999 Then
                        brignode.Add(vertex)
                    Else
                        smv = minimum(smv, j)
                    End If
                Else
                    smv = minimum(smv, arrival.Item(elenode))
                End If

            Next

            If smv = prev Then
                Return 999
            Else
                Return smv
            End If

        End If


    End Function

    Public Sub dijkstra_v2(ByVal graph As Graph, ByVal start As Node, ByVal goal As Node, ByVal graphNodes As List(Of Node))
        Dim minNode As New Node
        Dim infi As Integer = 999
        Dim weightedEdge As New Edge
        Dim tempNode As New Node

        For Each elenode In graphNodes
            distance.Item(elenode) = infi
            visited.Item(elenode) = 0
            heap.Add(elenode)
        Next
        distance.Item(start) = 0
        predecessor.Item(start) = start
        visited.Item(start) = 1
        decrease_priority(start)

        While (heap.Count)
            minNode = heap.Item(0)
            'heap.Remove(minNode)
            visited.Item(minNode) = 1
            heap.RemoveAt(0)
            'frmMain.ListBox1.Items.Add(heap.Count)

            For Each elenode1 In graph.ChildrenOf(minNode)

                If visited.Item(elenode1) Then
                    Continue For
                Else

                    distance.Item(elenode1) = min(distance.Item(elenode1), distance.Item(minNode) + getweight(elenode1, minNode), elenode1, minNode)
                    decrease_priority(elenode1)
                End If
            Next
        End While

        give_path(goal)
    End Sub

    Public Sub neg_dijkstra(ByVal start As Node, ByVal dest As Node, ByVal graphNodes As List(Of Node), ByVal graph As Graph)
        For Each elenode In graphNodes
            distance.Item(elenode) = 999
        Next
        distance.Item(start) = 0
        predecessor.Item(start) = start
        start.visited = True
        graphNodes.Remove(start)
        For Each elenode In graphNodes
            elenode.visited = True
            For Each elenode1 In graph.ChildrenOf(elenode)
                If elenode1.visited = True Then
                    distance.Item(elenode) = min(distance.Item(elenode), distance.Item(elenode1) + getweight(elenode1, elenode), elenode, elenode1)
                End If
            Next
        Next
        give_path(dest)
    End Sub

    Public Function edgeconnected(ByVal vertex As Node, ByRef prev As Integer, ByVal graph As Graph) As Integer
        Dim dbe As Integer
        Dim j As Integer

        arrival.Item(vertex) = time
        time = time + 1
        vertex.visited = True
        dbe = arrival.Item(vertex)

        If arrival.Item(vertex) = 0 Then
            Dim k As Integer
            For Each elenode In graph.ChildrenOf(vertex)
                k = edgeconnected(elenode, arrival.Item(vertex), graph)

                If k = 999 Then
                    brigedge.Add(getedge(elenode, vertex, graph))
                End If

            Next
            Return k

        Else
            For Each elenode In graph.ChildrenOf(vertex)

                If Not elenode.visited = True Then
                    j = edgeconnected(elenode, arrival.Item(vertex), graph)

                    If j = 999 Then
                        brigedge.Add(getedge(elenode, vertex, graph))
                    Else
                        dbe = minimum(dbe, j)
                    End If
                Else

                    If arrival.Item(elenode) = prev Then
                        Continue For
                    Else
                        dbe = minimum(dbe, arrival.Item(elenode))
                    End If


                End If

            Next

            If dbe = arrival.Item(vertex) Then
                Return 999
            Else
                Return dbe
            End If

        End If


    End Function

    '========================================================= Helper Functions =========================================

    Public Function minimum(ByVal integer1 As Integer, ByVal integer2 As Integer) As Integer

        If integer1 < integer2 Then
            Return integer1
        Else
            Return integer2
        End If

    End Function

    Public Sub fillarrival(ByVal graphNodes As List(Of Node), ByVal start As Node)
        For Each elenode In graphNodes
            arrival.Item(elenode) = 0
        Next
        brignode.Add(start)
    End Sub

    Public Sub colorNode()

        For loopVar As Integer = 1 To brignode.Count - 1
            brignode.Item(loopVar).BackColor = Color.Black
        Next

    End Sub

    Public Function getedge(ByRef elenode1 As Node, ByRef minNode As Node, ByVal graph As Graph) As Edge
        For Each edgee In minNode.getEdge
            If edgee.Destination.NodeName = elenode1.NodeName Then
                Return edgee
            ElseIf edgee.Source.NodeName = elenode1.NodeName Then
                Return edgee
            End If

        Next
    End Function

    Public Sub coloredge()

        If brigedge.Count() > 0 Then
            For Each Edge In brigedge
                Dim myGraphics As Graphics = frmMain.CreateGraphics
                Dim myPen As Pen = New Pen(Color.Cyan, 5)
                myGraphics.DrawLine(myPen, Edge.Source.Location, Edge.Destination.Location)
            Next
        Else
            MessageBox.Show("Connection Absolute")
        End If

    End Sub


    Public Sub decrease_priority(ByRef node As Node)
        Dim count As Integer
        Dim temp1 As Integer
        Dim temp2 As Integer

        count = 0
        heap.Remove(node)
        For Each elenode In heap
            temp1 = distance.Item(elenode)
            temp2 = distance.Item(node)

            If (temp1 < temp2) Then
                count = count + 1
            Else
                heap.Insert(count, node)
                Exit For
            End If
        Next
    End Sub

    Public Function getweight(ByRef elenode1 As Node, ByRef minNode As Node) As Integer
        For Each edgee In minNode.getEdge
            If edgee.Destination.NodeName = elenode1.NodeName Then
                Return edgee.Weight
            ElseIf edgee.Source.NodeName = elenode1.NodeName Then
                Return edgee.Weight
            End If

        Next
    End Function

    Public Sub give_path(ByVal node As Node)

        If predecessor.Item(node).NodeName <> node.NodeName Then
            'drawing elements
            Dim myGraphics As Graphics = frmMain.CreateGraphics
            Dim myPen As Pen = New Pen(Color.Green, 5)
            myGraphics.DrawLine(myPen, node.Location, predecessor.Item(node).Location)
            give_path(predecessor.Item(node))
        End If

    End Sub

    Public Function min(ByVal integer1 As Integer, ByVal integer2 As Integer, ByVal elenode As Node, ByVal pred As Node) As Integer
        If (integer1 < integer2) Then
            Return integer1

        Else
            predecessor.Item(elenode) = pred
            Return integer2
        End If
    End Function

    Public Sub ClearAll(ByVal wLable As List(Of Label), ByVal nLable As List(Of Label), ByVal myNodes As List(Of Node))

        frmMain.Invalidate()

        For Each targetLable In wLable
            targetLable.Visible = False
        Next

        For Each targetLable In nLable
            targetLable.Visible = False
        Next

        For Each vertex In myNodes
            vertex.Visible = False
        Next

    End Sub

    Public Function getNewListVertex(ByVal RemovedVertex As Node, ByVal myNodes As List(Of Node), ByVal myEdge As List(Of Edge))
        Dim NewList As New List(Of Node)


        For Each vertex In myNodes
            If vertex.NodeName <> RemovedVertex.NodeName Then

            End If
        Next
    End Function

    Public Function genNewGraph(ByRef graph As Graph, ByRef myNodes As List(Of Node), ByRef removedVertex As Node, ByRef Edgelist As List(Of Edge))
        Dim chidList As New List(Of Node)
        Dim tempChildList As New List(Of Node)

        'drawing elements
        Dim myGraphics As Graphics = frmMain.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Black, 5)

        chidList = graph.ChildrenOf(removedVertex)

        For Each vertex In chidList
            myGraphics.DrawLine(myPen, removedVertex.Location, vertex.Location)
            For Each tempChild In graph.ChildrenOf(vertex)
                If tempChild.nodeName = removedVertex.NodeName Then
                    graph.ChildrenOf(vertex).Remove(tempChild)
                    'Remove edge from edge list

                    For Each eleEdge In Edgelist
                        If eleEdge.Source.NodeName = vertex.NodeName And eleEdge.Destination.NodeName = tempChild.NodeName Then
                            Edgelist.Remove(eleEdge)
                            Exit For
                        ElseIf eleEdge.Source.NodeName = tempChild.NodeName And eleEdge.Destination.NodeName = vertex.NodeName Then
                            Edgelist.Remove(eleEdge)
                            Exit For
                        End If
                    Next

                    Exit For
                End If
            Next
        Next


        While (chidList.Count <> 0)
            chidList.RemoveAt(0)
        End While

        myNodes.Remove(removedVertex)

        removedVertex.BackColor = Color.Black
        removedVertex.Enabled = False

        Return graph
    End Function

    Public Function genNewGraphEdge(ByRef graph As Graph, ByVal Source As Node, ByVal Dest As Node, ByRef Edgelist As List(Of Edge))
        For Each vertex In graph.ChildrenOf(Source)
            If vertex.NodeName = Dest.NodeName Then
                graph.ChildrenOf(Source).Remove(vertex)
                Exit For
            End If
        Next

        For Each vertex In graph.ChildrenOf(Dest)
            If vertex.NodeName = Source.NodeName Then
                graph.ChildrenOf(Dest).Remove(vertex)
                Exit For
            End If
        Next

        For Each eleEdge In Edgelist
            If eleEdge.Source.NodeName = Source.NodeName And eleEdge.Destination.NodeName = Dest.NodeName Then
                Edgelist.Remove(eleEdge)
                Exit For
            ElseIf eleEdge.Source.NodeName = Dest.NodeName And eleEdge.Destination.NodeName = Source.NodeName Then
                Edgelist.Remove(eleEdge)
                Exit For
            End If
        Next

        'drawing elements
        Dim myGraphics As Graphics = frmMain.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Black, 5)

        myGraphics.DrawLine(myPen, Source.Location, Dest.Location)

        Return graph
    End Function

    Public Sub Reset(ByVal SElist As List(Of Node), ByVal MyNodes As List(Of Node), ByVal MyGraph As Graph)
        'Make SElist empty to reset goal and start

        If SElist.Count = 1 Then
            SElist.RemoveAt(0)
        ElseIf SElist.Count = 2 Then
            SElist.RemoveAt(0)
            SElist.RemoveAt(0)
        Else
            'do nothing
        End If



        'Reset the Nodes to select new goal and start
        For Each eleNode In MyNodes
            eleNode.BackColor = Color.Red
        Next

        'Make the weight list empty and invisible.

        If frmMain.lbAlgoStatistics.Visible = True Then
            frmMain.lbAlgoStatistics.Visible = False

            While (frmMain.lbAlgoStatistics.Items.Count <> 0)
                frmMain.lbAlgoStatistics.Items.RemoveAt(0)
            End While
        End If

        'Make the Start and goal textBox empty
        frmMain.txtGoal.Text = ""
        frmMain.txtStart.Text = ""


        'drawing elements
        Dim myGraphics As Graphics = frmMain.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Red, 5)


        'make all edges red again
        For Each eleEdge In Mygraph.GetAllEdges
            myGraphics.DrawLine(myPen, eleEdge.Source.Location, eleEdge.Destination.Location)
        Next
    End Sub

    Public Function CheckName(ByVal name As String, ByVal AllNodes As List(Of Node)) As Boolean
        Dim bool As Boolean = True
        For loopVar As Integer = 0 To AllNodes.Count - 2
            If AllNodes.Item(loopVar).NodeName = name Then
                bool = False
                Exit For
            Else
                bool = True
            End If
        Next
       
        Return bool
    End Function
End Module