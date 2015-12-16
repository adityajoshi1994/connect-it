Public Class frmHelp

    Private Sub frmHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.nudVisibility.Value = 60

        'disable the text boxes
        Me.txtDegree.Enabled = False
        Me.txtAlgoHelp.Enabled = False
        Me.lbChildNodes.Enabled = False

        For Each vertex In frmMain.MyNodes
            ddlSource.Items.Add(vertex.NodeName)
            ddlDest.Items.Add(vertex.NodeName)
        Next


    End Sub


    Private Sub nudVisibility_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudVisibility.ValueChanged
        Me.Opacity = (nudVisibility.Value / 100)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlAlgorithms.SelectedIndexChanged
        If ddlAlgorithms.SelectedIndex = -1 Then
            'Do nothing
        Else
            Dim selectVar As Integer = ddlAlgorithms.SelectedIndex
            Select Case selectVar
                Case 0
                    Dim prims As String = "D:\Vb project\Graph mini proj all\Graph miniProjectDynamictest\MiniProjectSem3Trial2\Resources\Prim's Algorithm.txt"
                    read(prims)
                Case 1
                    Dim kruskal As String = "D:\Vb project\Graph mini proj all\Graph miniProjectDynamictest\MiniProjectSem3Trial2\Resources\Kruskal.txt"
                    read(kruskal)
                Case 2
                    Dim dijkastra As String = ""
                    read(dijkastra)
            End Select
        End If
    End Sub

    Private Sub read(ByVal filePath As String)

        Dim myreader As New System.IO.StreamReader(filePath)
        While myreader.Peek() <> -1
            Me.txtAlgoHelp.Text = myreader.ReadToEnd & myreader.ReadLine() & vbNewLine
        End While

    End Sub

    Private Sub getWeight()
        Dim flag As Boolean = False
        If ddlDest.SelectedIndex <> -1 And ddlSource.SelectedIndex <> -1 Then
            For Each eleEdge In frmMain.Mygraph.GetAllEdges()
                'MsgBox("EleS :" + eleEdge.Source.NodeName + Chr(13) + "EleD" + eleEdge.Destination.NodeName)
                'MsgBox("EleS :" + frmMain.MyNodes.Item(ddlSource.SelectedIndex).NodeName + Chr(13) + "EleD" + frmMain.MyNodes.Item(ddlDest.SelectedIndex).NodeName)
                If eleEdge.Source.NodeName = frmMain.MyNodes.Item(ddlSource.SelectedIndex).NodeName And eleEdge.Destination.NodeName = frmMain.MyNodes.Item(ddlDest.SelectedIndex).NodeName Then
                    'If eleEdge.Source.NodeName = ddlSource.SelectedItem. And eleEdge.Destination.NodeName = frmMain.MyNodes.Item(ddlDest.SelectedIndex).NodeName Then
                    Me.txtWeight.Text = eleEdge.Weight.ToString
                    flag = True
                    Exit For
                ElseIf eleEdge.Source.NodeName = frmMain.MyNodes.Item(ddlDest.SelectedIndex).NodeName And eleEdge.Destination.NodeName = frmMain.MyNodes.Item(ddlSource.SelectedIndex).NodeName Then
                    Me.txtWeight.Text = eleEdge.Weight.ToString
                    flag = True
                    Exit For
                    'Else

                    'MsgBox("EleS :" + eleEdge.Source.NodeName + Chr(13) + "EleD" + eleEdge.Destination.NodeName)
                    'MsgBox("EleS :" + frmMain.MyNodes.Item(ddlSource.SelectedIndex).NodeName + Chr(13) + "EleD" + frmMain.MyNodes.Item(ddlDest.SelectedIndex).NodeName)
                    'Exit For
                End If
            Next
            If flag = False Then
                Me.txtWeight.Text = "Edge Not Present"
            End If
        End If
    End Sub

    Private Sub ddlSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlSource.SelectedIndexChanged
        Me.getWeight()
    End Sub

    Private Sub ddlDest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlDest.SelectedIndexChanged
        Me.getWeight()
    End Sub
End Class