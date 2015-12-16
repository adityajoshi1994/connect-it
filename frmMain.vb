''' <summary>
''' learn to use ok cancle message box!
''' </summary>
''' <remarks></remarks>

Public Class frmMain

    'Udirected Graph for DFS BFS etc.
    Public Mygraph As New Graph

    'Directed Graph for dijkastra
    Dim DiaGraph As New DiaGraph

    'All the available nodes as per entered rows and columns
    Dim AllNode As New List(Of Node)

    'Nodes in graph
    Public MyNodes As New List(Of Node)

    'Temperary list used to mark edges
    Dim TempList As New List(Of Node)

    'List keeping records of Start and end node.
    Dim SElist As New List(Of Node)

    'List passed to algorith for execution of algorithm
    Dim shortestPath As New List(Of Node)

    'list of list passed to BFS for calculating shortest path
    Dim BFSpath As New List(Of List(Of Node))

    'List of traveld node by DFS
    Dim TravelList As New List(Of Node)

    'List of WeightLables
    Dim WeightLable As New List(Of Label)

    'List of Namelable
    Dim NameLable As New List(Of Label)

    'list of SOurce and dest
    Dim SDlist As New List(Of Node)

    Dim myNode As New Node
    Dim NodeCount As Integer
    '=============================================== control funtion ===============================================

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'windows state
        Me.WindowState = FormWindowState.Maximized

        'control positions
        Me.lblTitle.Left = (Width / 2) - (lblTitle.Width / 2)

        'invisible Controls
        lbAlgoStatistics.Visible = False

        'Direction Lable
        Me.lblDirection.Text = "1. Double click on form to create node." + Chr(13) + "2. Click on node to add it to graph" + Chr(13) + "3. Create edges and click ready or remove vertex" + Chr(13) _
     + "To create edge click on any two nodes and input its weight in dialog"

        'Disable appropriate text boxes
        Me.txtStart.Enabled = False
        Me.txtGoal.Enabled = False
        Me.btnGraph.Enabled = False


    End Sub

    Private Sub btnGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraph.Click
        For Each graphNode In MyNodes
            graphNode.BackColor = Color.Blue
        Next

        Me.RemoveEdgeToolStripMenuItem.Enabled = True
        Me.RemoveEdgeToolStripMenuItem.Enabled = True
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmHelp.Show()
    End Sub

    Private Sub ResetGraphToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetGraphToolStripMenuItem.Click
        PathAlgorithm.Reset(SElist, MyNodes, Mygraph)
        Me.PathAlgorithmsToolStripMenuItem.Enabled = True
    End Sub

    '===================================================== Function Creating Graph ================================

    ''' <summary>
    ''' Handling multiple tasks depending on backcolor of node
    ''' 1.White ---> Add it to graph and make it red
    ''' 2. Red ---> for click on two consecutive node add an edge and when graph
    '''             is ready make them all blue
    ''' 3.Blue ---> for consecutive click if two node make them start and goal make their back-color yellow
    ''' </summary>
    ''' <param name="sender"> sender is the node in form of button on the form</param>
    ''' <remarks>
    ''' 1. While creating many diffrent objects of graph use this 
    '''    function to add nodes and edges to graph
    ''' 
    ''' 2.Special thought is to be given while extending this proj as that won't be
    '''   single graph specific many graph should be created one by one in row!!!
    ''' 
    ''' </remarks>
    Private Sub MynodeClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tempEdge As New Edge
        Dim lblWeight As New Label

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.OrangeRed, 5)

        'Adds node to graph object
        If sender.backColor = Color.White Then
            Mygraph.AddNode(sender)
            DiaGraph.AddNode(sender)
            MyNodes.Add(sender)
            sender.BackColor = Color.Red

        ElseIf sender.backcolor = Color.Red Then
            'if it is red select two of them to be connect them (1st node clicked is source while the next one is destination)
            TempList.Add(sender)
            NodeCount += 1
            If NodeCount = 2 Then
                tempEdge.Source = TempList.Item(0)
                tempEdge.Destination = TempList.Item(1)

                If tempEdge.Source.NodeName = tempEdge.Destination.NodeName Then
                    MsgBox("You just added a self edge" _
                           + Chr(13) + "It is not visible but is added to graph")
                End If

                'Take input for edge weight
                DlgNodeName.txtNodeName.Focus()
jump:           Dim Weight As Integer = DlgNodeName.ShowDialog()
                If Weight = Windows.Forms.DialogResult.OK Then
                    If IsNumeric(DlgNodeName.txtNodeName.Text) Then
                        tempEdge.Weight = CInt(DlgNodeName.txtNodeName.Text)
                    Else
                        MsgBox("Please enter valid Numeric Value")
                        GoTo jump
                    End If

                    DlgNodeName.txtNodeName.Text = "Weight"
                    DlgNodeName.txtNodeName.SelectAll()
                    DlgNodeName.txtNodeName.Focus()

                    'Create a lable for Weight Display
                    lblWeight.Location = New Point((tempEdge.Source.Location.X + tempEdge.Destination.Location.X) / 2, (tempEdge.Source.Location.Y + tempEdge.Destination.Location.Y) / 2)
                    lblWeight.Text = tempEdge.Weight.ToString
                    lblWeight.ForeColor = Color.Yellow
                    lblWeight.BackColor = Color.RoyalBlue
                    lblWeight.Width = 40
                    lblWeight.Height = 10
                    WeightLable.Add(lblWeight)
                    Me.Controls.Add(lblWeight)

                    'Add the edge to graph
                    Mygraph.AddEdge(tempEdge)
                    DiaGraph.AddEdge(tempEdge)

                    'Draw the line
                    myGraphics.DrawLine(myPen, tempEdge.Source.Location, tempEdge.Destination.Location)

                    'reset count
                    NodeCount = 0
                    TempList.Clear()

                    RemoveVertexToolStripMenuItem.Enabled = True
                End If
            End If

        ElseIf sender.backcolor = Color.Blue Then
            'if its blue mark Start and goal node ( 1st node clicked is Start and next one is Node)
            Me.lblDirection.Text = "Select Start and goal" + Chr(13) + "choose your required algorithm"
            sender.backcolor = Color.Yellow
            SElist.Add(sender)
            If SElist.Count = 2 Then
                Me.txtStart.Text = SElist.Item(0).NodeName
                Me.txtGoal.Text = SElist.Item(1).NodeName
                CheckConnectivity()
            End If
            If SElist.Count > 2 Then
                sender.backColor = Color.Blue
                SElist.RemoveAt(2)
            End If

        ElseIf sender.backColor = Color.Yellow Then
            If SElist.Count < 2 Then
                SElist.Add(sender)
                If SElist.Count = 2 Then
                    Me.txtStart.Text = SElist.Item(0).NodeName
                    Me.txtGoal.Text = SElist.Item(1).NodeName
                    CheckConnectivity()
                End If
            End If

        ElseIf sender.backColor = Color.BurlyWood Or sender.backColor = Color.Black Then

            If sender.backColor = Color.Black Then
                MsgBox("Are you sure you want to remove Bridge Node?", MsgBoxStyle.OkCancel)
                Dim result As Integer = MsgBoxResult.Ok

                If result = 2 Then
                    For Each vertex In MyNodes
                        vertex.BackColor = Color.Blue
                    Next
                Else
                    Dim RemovedVertext As New Node

                    RemovedVertext = sender

                    PathAlgorithm.genNewGraph(Mygraph, MyNodes, RemovedVertext, Mygraph.GetAllEdges)

                    For Each vertex In MyNodes
                        vertex.BackColor = Color.Blue
                    Next

                End If
            Else
                Dim RemovedVertext As New Node

                RemovedVertext = sender

                PathAlgorithm.genNewGraph(Mygraph, MyNodes, RemovedVertext, Mygraph.GetAllEdges)

                For Each vertex In MyNodes
                    vertex.BackColor = Color.Blue
                Next
            End If
        ElseIf sender.backColor = Color.DarkCyan Then


            SDlist.Add(sender)

            If SDlist.Count = 2 Then
                PathAlgorithm.genNewGraphEdge(Mygraph, SDlist.Item(0), SDlist.Item(1), Mygraph.GetAllEdges)

                For Each vertex In MyNodes
                    vertex.BackColor = Color.Blue
                Next

                lblDirection.Text = "Black coloured edge is removed from Graph"
            End If

        End If

    End Sub

    ''' <summary>
    ''' Make A node visible to form.
    ''' Caution: every node visible on form is not part of GRAPH
    '''          Node is part of graph only when its clicked and made red!
    ''' 
    ''' All the nodes visible on form are collected in list 'AllNode'
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMain_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Dim Name As New Label
        Dim Bool As Boolean
        Dim result As Integer

        myNode = New Node
        Dim nodeLoc As Point = New Point(MousePosition.X - 5, MousePosition.Y - 5)

        myNode.Location = nodeLoc

        Dim lableLoc As Point = New Point(myNode.Location.X - 10, myNode.Location.Y - 10)
        Name.Height = 50
        Name.Width = 50

        'Enable control
        Me.btnGraph.Enabled = True

        'add handler for nodes
        AddHandler myNode.Click, AddressOf MynodeClick
        Me.Controls.Add(myNode)
        AllNode.Add(myNode)

        While Bool = False
            DlgNodeName.txtNodeName.Focus()
            result = DlgNodeName.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                Bool = CheckName(DlgNodeName.txtNodeName.Text, AllNode)
                If Bool = False Then
                    MsgBox("Node already exists")
                End If
            End If

        End While

        myNode.NodeName = DlgNodeName.txtNodeName.Text
        Name.Location = lableLoc
        Name.Text = myNode.NodeName
        Name.ForeColor = Color.Gold
        Name.BackColor = Color.Transparent

        'Add control of lable to form
        Me.Controls.Add(Name)
        NameLable.Add(Name)

        DlgNodeName.txtNodeName.Text = "Node Name"
        DlgNodeName.txtNodeName.Focus()
        DlgNodeName.txtNodeName.SelectAll()



    End Sub

    Public Sub NodeRightClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)

        Dim selection = CInt(item.Tag)

        Select Case (selection)
            Case 1
                For Each childNode In Mygraph.ChildrenOf(sender.Owner.sourcecontrol)
                    frmHelp.lbChildNodes.Items.Add(childNode.NodeName)
                Next
                frmHelp.txtDegree.Text = sender.Owner.sourcecontrol.getEdge().count / 2
                frmHelp.Show()
        End Select

    End Sub

    '=================================================== Path Algorithms =============================================

    ''' <summary>
    ''' Color the path out put by DFS
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DepthFirstSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepthFirstSearchToolStripMenuItem.Click
        Dim ShortPath As New List(Of Node)

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Green, 5)

        If SElist.Count >= 2 Then
            If SElist.Item(0).NodeName <> SElist.Item(1).NodeName Then

                For Each vertex In MyNodes
                    vertex.visited = False
                Next

                ShortPath = DFS(Mygraph, SElist.Item(0), SElist.Item(1), shortestPath)

                For loopVar As Integer = 0 To ShortPath.Count - 2
                    myGraphics.DrawLine(myPen, ShortPath.Item(loopVar).Location, ShortPath.Item(loopVar + 1).Location)
                Next

                SElist.Item(1).BackColor = Color.Green
            Else
                MsgBox(" You are currently on goal")
                SElist.Item(1).BackColor = Color.Green
            End If
        Else
            MsgBox("Start and Goal Not selected")
        End If

    End Sub

    ''' <summary>
    ''' Color the path out put by Dijkastra's Algorithm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DijkastrasAlgorithmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DijkastrasAlgorithmToolStripMenuItem.Click
        Dim ShortPath As New List(Of Node)

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Green, 5)

        If SElist.Count >= 2 Then
            If SElist.Item(0).NodeName <> SElist.Item(1).NodeName Then
                ShortPath = Dijkstra(Mygraph, SElist.Item(0), SElist.Item(1), MyNodes)

                For loopVar As Integer = 0 To ShortPath.Count - 2
                    myGraphics.DrawLine(myPen, ShortPath.Item(loopVar).Location, ShortPath.Item(loopVar + 1).Location)
                Next

                SElist.Item(1).BackColor = Color.Green
                lbAlgoStatistics.Visible = True

                If ShortPath.Count = 1 Then
                    MsgBox("goal reached by self edge" _
                           + Chr(13) + " Hence it may not be visible")
                End If
            Else
                MsgBox(" You are currently on goal")
                SElist.Item(1).BackColor = Color.Green
            End If
        Else
            MsgBox("Start and Goal Not selected")
        End If

        
    End Sub

    ''' <summary>
    ''' Color the path out put by BFS
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BreathFirstSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BreathFirstSearchToolStripMenuItem.Click
        Dim ShortPath As New List(Of Node)

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Green, 5)


        ShortPath = BFS(Mygraph, SElist.Item(0), SElist.Item(1), BFSpath)

        For loopVar As Integer = 0 To ShortPath.Count - 2
            myGraphics.DrawLine(myPen, ShortPath.Item(loopVar).Location, ShortPath.Item(loopVar + 1).Location)
        Next

        SElist.Item(1).BackColor = Color.Green

    End Sub

    ''' <summary>
    ''' Out put the propmt wheter goal is reachable or not
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CheckConnectivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckConnectivityToolStripMenuItem.Click
        CheckConnectivity()
    End Sub

    Private Sub CheckConnectivity()
        If SElist.Count = 2 Then
            Dim goalNode As Node = SElist.Item(1)
            Dim StartNode As Node = SElist.Item(0)

            For Each vertex In MyNodes
                vertex.visited = False
            Next


            connectivity(Mygraph, StartNode, TravelList, MyNodes)

            For Each nodeTravel In TravelList
                If goalNode.NodeName = nodeTravel.NodeName Then
                    MsgBox("Can be reached")
                    Exit Sub
                End If

            Next

            MsgBox("Cannot be reached")
            Me.PathAlgorithmsToolStripMenuItem.Enabled = False
        Else
            MsgBox("Start and Goal Not selected")
        End If
        

    End Sub

    ''' <summary>
    ''' Color the minimum spanning tree output by Prims algorithm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PrimsAlgorithmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrimsAlgorithmToolStripMenuItem.Click
        Dim ShortPath As New Dictionary(Of Node, Node)

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Green, 5)

        If SElist.Count >= 1 Then
            For Each vertex In MyNodes
                vertex.visited = False
            Next

            ShortPath = PrimsAlgo(Mygraph, SElist.Item(0), MyNodes)

            For i As Integer = 0 To ShortPath.Count - 1
                myGraphics.DrawLine(myPen, ShortPath.Keys(i).Location, ShortPath.Item(ShortPath.Keys(i)).Location)
            Next

            lbAlgoStatistics.Visible = True
        Else
            MsgBox("Start and Goal Not selected")
        End If
        
    End Sub

    ''' <summary>
    ''' Color the minimum spanning tree output by Kruskal's algorithm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub KruskalAlgorithmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KruskalAlgorithmToolStripMenuItem.Click
        Dim SpanedEdges As New List(Of Edge)

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Green, 5)

        If SElist.Count >= 1 Then
            SpanedEdges = PathAlgorithm.Kruskals(Mygraph.GetAllEdges, MyNodes)

            For Each eleEdge In SpanedEdges
                myGraphics.DrawLine(myPen, eleEdge.Source.Location, eleEdge.Destination.Location)
            Next
        Else
            MsgBox("Start and Goal Not selected")
        End If
        
    End Sub

    'Private Sub BellmanFordAlgorithmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BellmanFordAlgorithmToolStripMenuItem.Click
    '    Dim ShortPath As New List(Of Node)
    '    Dim int As Integer

    '    'drawing elements
    '    Dim myGraphics As Graphics = Me.CreateGraphics
    '    Dim myPen As Pen = New Pen(Color.Green, 5)

    '    int = BellmanFord(Mygraph, SElist.Item(0), SElist.Item(1), MyNodes, Mygraph.GetAllEdges)

    '    'For loopVar As Integer = 0 To ShortPath.Count - 2
    '    '    myGraphics.DrawLine(myPen, ShortPath.Item(loopVar).Location, ShortPath.Item(loopVar + 1).Location)
    '    'Next

    '    'SElist.Item(1).BackColor = Color.Green

    '    lbAlgoStatistics.Visible = True
    'End Sub


    ''' <summary>
    ''' Colors the bridge vertext of graph
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub VertexConnectivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VertexConnectivityToolStripMenuItem.Click
        fillarrival(MyNodes, MyNodes.Item(0))
        PathAlgorithm.vertexconnected(MyNodes.Item(0), 0, Mygraph)
        PathAlgorithm.colorNode()
    End Sub

    'Private Sub DijkastraV2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If SElist.Count = 2 Then
    '        PathAlgorithm.dijkstra_v2(Mygraph, SElist.Item(0), SElist.Item(1), MyNodes)
    '    Else
    '        MsgBox("Start and Goal Not selected")
    '    End If
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    PathAlgorithm.neg_dijkstra(SElist.Item(0), SElist.Item(1), MyNodes, Mygraph)
    'End Sub

    Private Sub AAlgorithmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AAlgorithmToolStripMenuItem.Click
        Dim ShortPath As New List(Of Node)

        'drawing elements
        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myPen As Pen = New Pen(Color.Green, 5)

        If SElist.Count >= 2 Then
            If SElist.Item(0).NodeName <> SElist.Item(1).NodeName Then
                ShortPath = A_Star(Mygraph, SElist.Item(0), SElist.Item(1), MyNodes)

                For loopVar As Integer = 0 To ShortPath.Count - 2
                    myGraphics.DrawLine(myPen, ShortPath.Item(loopVar).Location, ShortPath.Item(loopVar + 1).Location)
                Next

                SElist.Item(1).BackColor = Color.Green
                lbAlgoStatistics.Visible = True
            Else
                MsgBox(" You are currently on goal")
                SElist.Item(1).BackColor = Color.Green
            End If
        Else
            MsgBox("Start and Goal Not selected")
        End If

        
    End Sub

    'Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    PathAlgorithm.ClearAll(WeightLable, NameLable, MyNodes)
    'End Sub


    Private Sub RemoveVertexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveVertexToolStripMenuItem.Click

        Me.lblDirection.Text = "1.Click on vertex you want to remove"

        MsgBox("Black color nodes are bridge node" + Chr(13) + "Not removing them is recommended it can DISCONNECT your graph")

        For Each vertex In MyNodes
            vertex.BackColor = Color.BurlyWood
        Next

        fillarrival(MyNodes, MyNodes.Item(0))
        PathAlgorithm.vertexconnected(MyNodes.Item(0), 0, Mygraph)
        PathAlgorithm.colorNode()

        RemoveEdgeToolStripMenuItem.Enabled = False
    End Sub

    Private Sub EdgeConnectivityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EdgeConnectivityToolStripMenuItem.Click
        PathAlgorithm.edgeconnected(MyNodes.Item(0), 0, Mygraph)
        PathAlgorithm.coloredge()
    End Sub

    Private Sub RemoveEdgeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveEdgeToolStripMenuItem.Click
        For Each vertex In MyNodes
            vertex.BackColor = Color.DarkCyan
        Next
        PathAlgorithm.edgeconnected(MyNodes.Item(0), 0, Mygraph)
        PathAlgorithm.coloredge()

        lblDirection.Text = "Cyan colored edges are bridge edges" + Chr(13) + "Removing them can DISCONNECT your graph"
        Me.RemoveEdgeToolStripMenuItem.Enabled = False
    End Sub
End Class
