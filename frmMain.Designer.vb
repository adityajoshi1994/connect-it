<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PathAlgorithmsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DepthFirstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BreathFirstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DijkastrasAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrimsAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KruskalAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckConnectivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VertexConnectivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EdgeConnectivityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveVertexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveEdgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblStart = New System.Windows.Forms.Label
        Me.lblGoal = New System.Windows.Forms.Label
        Me.txtStart = New System.Windows.Forms.TextBox
        Me.txtGoal = New System.Windows.Forms.TextBox
        Me.btnGraph = New System.Windows.Forms.Button
        Me.lbAlgoStatistics = New System.Windows.Forms.ListBox
        Me.lblDirection = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(427, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(303, 57)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "CONNECT IT!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathAlgorithmsToolStripMenuItem, Me.OptionToolStripMenuItem, Me.RemoveVertexToolStripMenuItem, Me.RemoveEdgeToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PathAlgorithmsToolStripMenuItem
        '
        Me.PathAlgorithmsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepthFirstSearchToolStripMenuItem, Me.BreathFirstSearchToolStripMenuItem, Me.DijkastrasAlgorithmToolStripMenuItem, Me.PrimsAlgorithmToolStripMenuItem, Me.KruskalAlgorithmToolStripMenuItem, Me.AAlgorithmToolStripMenuItem, Me.CheckConnectivityToolStripMenuItem, Me.VertexConnectivityToolStripMenuItem, Me.EdgeConnectivityToolStripMenuItem})
        Me.PathAlgorithmsToolStripMenuItem.Name = "PathAlgorithmsToolStripMenuItem"
        Me.PathAlgorithmsToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.PathAlgorithmsToolStripMenuItem.Text = "Path Algorithms"
        '
        'DepthFirstSearchToolStripMenuItem
        '
        Me.DepthFirstSearchToolStripMenuItem.Name = "DepthFirstSearchToolStripMenuItem"
        Me.DepthFirstSearchToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DepthFirstSearchToolStripMenuItem.Text = "Depth First Search"
        '
        'BreathFirstSearchToolStripMenuItem
        '
        Me.BreathFirstSearchToolStripMenuItem.Name = "BreathFirstSearchToolStripMenuItem"
        Me.BreathFirstSearchToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.BreathFirstSearchToolStripMenuItem.Text = "Breath first Search"
        '
        'DijkastrasAlgorithmToolStripMenuItem
        '
        Me.DijkastrasAlgorithmToolStripMenuItem.Name = "DijkastrasAlgorithmToolStripMenuItem"
        Me.DijkastrasAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DijkastrasAlgorithmToolStripMenuItem.Text = "Dijkastra's Algorithm"
        '
        'PrimsAlgorithmToolStripMenuItem
        '
        Me.PrimsAlgorithmToolStripMenuItem.Name = "PrimsAlgorithmToolStripMenuItem"
        Me.PrimsAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PrimsAlgorithmToolStripMenuItem.Text = "Prim's Algorithm"
        '
        'KruskalAlgorithmToolStripMenuItem
        '
        Me.KruskalAlgorithmToolStripMenuItem.Name = "KruskalAlgorithmToolStripMenuItem"
        Me.KruskalAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.KruskalAlgorithmToolStripMenuItem.Text = "Kruskal Algorithm"
        '
        'AAlgorithmToolStripMenuItem
        '
        Me.AAlgorithmToolStripMenuItem.Name = "AAlgorithmToolStripMenuItem"
        Me.AAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AAlgorithmToolStripMenuItem.Text = "A* Algorithm"
        '
        'CheckConnectivityToolStripMenuItem
        '
        Me.CheckConnectivityToolStripMenuItem.Name = "CheckConnectivityToolStripMenuItem"
        Me.CheckConnectivityToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CheckConnectivityToolStripMenuItem.Text = "CheckConnectivity"
        '
        'VertexConnectivityToolStripMenuItem
        '
        Me.VertexConnectivityToolStripMenuItem.Name = "VertexConnectivityToolStripMenuItem"
        Me.VertexConnectivityToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.VertexConnectivityToolStripMenuItem.Text = "VertexConnectivity"
        '
        'EdgeConnectivityToolStripMenuItem
        '
        Me.EdgeConnectivityToolStripMenuItem.Name = "EdgeConnectivityToolStripMenuItem"
        Me.EdgeConnectivityToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EdgeConnectivityToolStripMenuItem.Text = "Edge Connectivity"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetGraphToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'ResetGraphToolStripMenuItem
        '
        Me.ResetGraphToolStripMenuItem.Name = "ResetGraphToolStripMenuItem"
        Me.ResetGraphToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetGraphToolStripMenuItem.Text = "Reset Graph"
        '
        'RemoveVertexToolStripMenuItem
        '
        Me.RemoveVertexToolStripMenuItem.Name = "RemoveVertexToolStripMenuItem"
        Me.RemoveVertexToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.RemoveVertexToolStripMenuItem.Text = "Remove Vertex"
        '
        'RemoveEdgeToolStripMenuItem
        '
        Me.RemoveEdgeToolStripMenuItem.Name = "RemoveEdgeToolStripMenuItem"
        Me.RemoveEdgeToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.RemoveEdgeToolStripMenuItem.Text = "Remove Edge"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.HelpToolStripMenuItem.Text = "About Project"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.Gold
        Me.lblStart.Location = New System.Drawing.Point(953, 51)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(50, 22)
        Me.lblStart.TabIndex = 3
        Me.lblStart.Text = "Start"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.BackColor = System.Drawing.Color.Transparent
        Me.lblGoal.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.ForeColor = System.Drawing.Color.Gold
        Me.lblGoal.Location = New System.Drawing.Point(953, 89)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(47, 22)
        Me.lblGoal.TabIndex = 4
        Me.lblGoal.Text = "Goal"
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(1019, 52)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(49, 20)
        Me.txtStart.TabIndex = 5
        '
        'txtGoal
        '
        Me.txtGoal.Location = New System.Drawing.Point(1019, 91)
        Me.txtGoal.Name = "txtGoal"
        Me.txtGoal.Size = New System.Drawing.Size(49, 20)
        Me.txtGoal.TabIndex = 6
        '
        'btnGraph
        '
        Me.btnGraph.Location = New System.Drawing.Point(1097, 50)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(75, 23)
        Me.btnGraph.TabIndex = 7
        Me.btnGraph.Text = "Ready"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'lbAlgoStatistics
        '
        Me.lbAlgoStatistics.FormattingEnabled = True
        Me.lbAlgoStatistics.Location = New System.Drawing.Point(966, 138)
        Me.lbAlgoStatistics.Name = "lbAlgoStatistics"
        Me.lbAlgoStatistics.Size = New System.Drawing.Size(205, 277)
        Me.lbAlgoStatistics.TabIndex = 8
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.BackColor = System.Drawing.Color.Transparent
        Me.lblDirection.Font = New System.Drawing.Font("Monotype Corsiva", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.ForeColor = System.Drawing.Color.Gold
        Me.lblDirection.Location = New System.Drawing.Point(40, 114)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(50, 22)
        Me.lblDirection.TabIndex = 9
        Me.lblDirection.Text = "Start"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniProjectSem3Trial2.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.lbAlgoStatistics)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.txtGoal)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Connect It"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PathAlgorithmsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepthFirstSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BreathFirstSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DijkastrasAlgorithmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrimsAlgorithmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KruskalAlgorithmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AAlgorithmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblGoal As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtGoal As System.Windows.Forms.TextBox
    Friend WithEvents btnGraph As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckConnectivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbAlgoStatistics As System.Windows.Forms.ListBox
    Friend WithEvents VertexConnectivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveVertexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents EdgeConnectivityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveEdgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
