<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.gbNodes = New System.Windows.Forms.GroupBox
        Me.lbChildNodes = New System.Windows.Forms.ListBox
        Me.txtDegree = New System.Windows.Forms.TextBox
        Me.lblDegree = New System.Windows.Forms.Label
        Me.lblChildNodes = New System.Windows.Forms.Label
        Me.gbHelp = New System.Windows.Forms.GroupBox
        Me.ddlAlgorithms = New System.Windows.Forms.ComboBox
        Me.txtAlgoHelp = New System.Windows.Forms.TextBox
        Me.lblAgloHelp = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblVisibility = New System.Windows.Forms.Label
        Me.nudVisibility = New System.Windows.Forms.NumericUpDown
        Me.lblWeight = New System.Windows.Forms.Label
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.lblSource = New System.Windows.Forms.Label
        Me.lblDestination = New System.Windows.Forms.Label
        Me.gbEdges = New System.Windows.Forms.GroupBox
        Me.ddlSource = New System.Windows.Forms.ComboBox
        Me.ddlDest = New System.Windows.Forms.ComboBox
        Me.gbNodes.SuspendLayout()
        Me.gbHelp.SuspendLayout()
        CType(Me.nudVisibility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEdges.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbNodes
        '
        Me.gbNodes.BackColor = System.Drawing.Color.Transparent
        Me.gbNodes.Controls.Add(Me.lbChildNodes)
        Me.gbNodes.Controls.Add(Me.txtDegree)
        Me.gbNodes.Controls.Add(Me.lblDegree)
        Me.gbNodes.Controls.Add(Me.lblChildNodes)
        Me.gbNodes.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNodes.ForeColor = System.Drawing.Color.Red
        Me.gbNodes.Location = New System.Drawing.Point(28, 117)
        Me.gbNodes.Name = "gbNodes"
        Me.gbNodes.Size = New System.Drawing.Size(365, 247)
        Me.gbNodes.TabIndex = 0
        Me.gbNodes.TabStop = False
        Me.gbNodes.Text = "Nodes Help"
        '
        'lbChildNodes
        '
        Me.lbChildNodes.FormattingEnabled = True
        Me.lbChildNodes.ItemHeight = 19
        Me.lbChildNodes.Location = New System.Drawing.Point(143, 119)
        Me.lbChildNodes.Name = "lbChildNodes"
        Me.lbChildNodes.Size = New System.Drawing.Size(187, 99)
        Me.lbChildNodes.TabIndex = 11
        '
        'txtDegree
        '
        Me.txtDegree.Location = New System.Drawing.Point(143, 36)
        Me.txtDegree.Name = "txtDegree"
        Me.txtDegree.Size = New System.Drawing.Size(187, 27)
        Me.txtDegree.TabIndex = 9
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.BackColor = System.Drawing.Color.Transparent
        Me.lblDegree.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegree.ForeColor = System.Drawing.Color.Red
        Me.lblDegree.Location = New System.Drawing.Point(12, 35)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(70, 26)
        Me.lblDegree.TabIndex = 7
        Me.lblDegree.Text = "Degree"
        '
        'lblChildNodes
        '
        Me.lblChildNodes.AutoSize = True
        Me.lblChildNodes.BackColor = System.Drawing.Color.Transparent
        Me.lblChildNodes.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildNodes.ForeColor = System.Drawing.Color.Red
        Me.lblChildNodes.Location = New System.Drawing.Point(12, 109)
        Me.lblChildNodes.Name = "lblChildNodes"
        Me.lblChildNodes.Size = New System.Drawing.Size(117, 26)
        Me.lblChildNodes.TabIndex = 6
        Me.lblChildNodes.Text = "Child Nodes"
        '
        'gbHelp
        '
        Me.gbHelp.BackColor = System.Drawing.Color.Transparent
        Me.gbHelp.Controls.Add(Me.ddlAlgorithms)
        Me.gbHelp.Controls.Add(Me.txtAlgoHelp)
        Me.gbHelp.Controls.Add(Me.lblAgloHelp)
        Me.gbHelp.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHelp.ForeColor = System.Drawing.Color.Red
        Me.gbHelp.Location = New System.Drawing.Point(438, 117)
        Me.gbHelp.Name = "gbHelp"
        Me.gbHelp.Size = New System.Drawing.Size(734, 533)
        Me.gbHelp.TabIndex = 1
        Me.gbHelp.TabStop = False
        Me.gbHelp.Text = "General Help"
        '
        'ddlAlgorithms
        '
        Me.ddlAlgorithms.FormattingEnabled = True
        Me.ddlAlgorithms.Items.AddRange(New Object() {"Prim's Algorithm", "Kruskal Algorithm", "Dijkastra's Algorithm", "Depth First Search", "Breadth First Search"})
        Me.ddlAlgorithms.Location = New System.Drawing.Point(223, 61)
        Me.ddlAlgorithms.Name = "ddlAlgorithms"
        Me.ddlAlgorithms.Size = New System.Drawing.Size(125, 27)
        Me.ddlAlgorithms.TabIndex = 20
        Me.ddlAlgorithms.Text = "Algorithms"
        '
        'txtAlgoHelp
        '
        Me.txtAlgoHelp.Location = New System.Drawing.Point(27, 107)
        Me.txtAlgoHelp.Multiline = True
        Me.txtAlgoHelp.Name = "txtAlgoHelp"
        Me.txtAlgoHelp.Size = New System.Drawing.Size(679, 398)
        Me.txtAlgoHelp.TabIndex = 19
        '
        'lblAgloHelp
        '
        Me.lblAgloHelp.AutoSize = True
        Me.lblAgloHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblAgloHelp.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgloHelp.ForeColor = System.Drawing.Color.Red
        Me.lblAgloHelp.Location = New System.Drawing.Point(22, 60)
        Me.lblAgloHelp.Name = "lblAgloHelp"
        Me.lblAgloHelp.Size = New System.Drawing.Size(199, 26)
        Me.lblAgloHelp.TabIndex = 19
        Me.lblAgloHelp.Text = "Help For Algorithm: "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(525, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(146, 57)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "HELP"
        '
        'lblVisibility
        '
        Me.lblVisibility.AutoSize = True
        Me.lblVisibility.BackColor = System.Drawing.Color.Transparent
        Me.lblVisibility.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisibility.ForeColor = System.Drawing.Color.Red
        Me.lblVisibility.Location = New System.Drawing.Point(40, 59)
        Me.lblVisibility.Name = "lblVisibility"
        Me.lblVisibility.Size = New System.Drawing.Size(155, 26)
        Me.lblVisibility.TabIndex = 12
        Me.lblVisibility.Text = "Increase Visibily"
        '
        'nudVisibility
        '
        Me.nudVisibility.Location = New System.Drawing.Point(201, 65)
        Me.nudVisibility.Name = "nudVisibility"
        Me.nudVisibility.Size = New System.Drawing.Size(120, 20)
        Me.nudVisibility.TabIndex = 14
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblWeight.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.Red
        Me.lblWeight.Location = New System.Drawing.Point(21, 177)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(75, 26)
        Me.lblWeight.TabIndex = 12
        Me.lblWeight.Text = "Weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(131, 178)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(187, 27)
        Me.txtWeight.TabIndex = 12
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.BackColor = System.Drawing.Color.Transparent
        Me.lblSource.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.ForeColor = System.Drawing.Color.Red
        Me.lblSource.Location = New System.Drawing.Point(21, 37)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(68, 26)
        Me.lblSource.TabIndex = 15
        Me.lblSource.Text = "Source"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.BackColor = System.Drawing.Color.Transparent
        Me.lblDestination.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.ForeColor = System.Drawing.Color.Red
        Me.lblDestination.Location = New System.Drawing.Point(21, 106)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(114, 26)
        Me.lblDestination.TabIndex = 16
        Me.lblDestination.Text = "Destination"
        '
        'gbEdges
        '
        Me.gbEdges.BackColor = System.Drawing.Color.Transparent
        Me.gbEdges.Controls.Add(Me.ddlDest)
        Me.gbEdges.Controls.Add(Me.ddlSource)
        Me.gbEdges.Controls.Add(Me.lblDestination)
        Me.gbEdges.Controls.Add(Me.lblSource)
        Me.gbEdges.Controls.Add(Me.txtWeight)
        Me.gbEdges.Controls.Add(Me.lblWeight)
        Me.gbEdges.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEdges.ForeColor = System.Drawing.Color.Red
        Me.gbEdges.Location = New System.Drawing.Point(28, 403)
        Me.gbEdges.Name = "gbEdges"
        Me.gbEdges.Size = New System.Drawing.Size(365, 247)
        Me.gbEdges.TabIndex = 1
        Me.gbEdges.TabStop = False
        Me.gbEdges.Text = "Edges Help"
        '
        'ddlSource
        '
        Me.ddlSource.FormattingEnabled = True
        Me.ddlSource.Location = New System.Drawing.Point(172, 36)
        Me.ddlSource.Name = "ddlSource"
        Me.ddlSource.Size = New System.Drawing.Size(121, 27)
        Me.ddlSource.TabIndex = 17
        '
        'ddlDest
        '
        Me.ddlDest.FormattingEnabled = True
        Me.ddlDest.Location = New System.Drawing.Point(172, 107)
        Me.ddlDest.Name = "ddlDest"
        Me.ddlDest.Size = New System.Drawing.Size(121, 27)
        Me.ddlDest.TabIndex = 18
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniProjectSem3Trial2.My.Resources.Resources.Processing
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.nudVisibility)
        Me.Controls.Add(Me.lblVisibility)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.gbEdges)
        Me.Controls.Add(Me.gbHelp)
        Me.Controls.Add(Me.gbNodes)
        Me.Name = "frmHelp"
        Me.Opacity = 0.6
        Me.Text = "frmHelp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbNodes.ResumeLayout(False)
        Me.gbNodes.PerformLayout()
        Me.gbHelp.ResumeLayout(False)
        Me.gbHelp.PerformLayout()
        CType(Me.nudVisibility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEdges.ResumeLayout(False)
        Me.gbEdges.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbNodes As System.Windows.Forms.GroupBox
    Friend WithEvents gbHelp As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lbChildNodes As System.Windows.Forms.ListBox
    Friend WithEvents txtDegree As System.Windows.Forms.TextBox
    Friend WithEvents lblDegree As System.Windows.Forms.Label
    Friend WithEvents lblChildNodes As System.Windows.Forms.Label
    Friend WithEvents txtAlgoHelp As System.Windows.Forms.TextBox
    Friend WithEvents lblAgloHelp As System.Windows.Forms.Label
    Friend WithEvents lblVisibility As System.Windows.Forms.Label
    Friend WithEvents nudVisibility As System.Windows.Forms.NumericUpDown
    Friend WithEvents ddlAlgorithms As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents gbEdges As System.Windows.Forms.GroupBox
    Friend WithEvents ddlDest As System.Windows.Forms.ComboBox
    Friend WithEvents ddlSource As System.Windows.Forms.ComboBox
End Class
