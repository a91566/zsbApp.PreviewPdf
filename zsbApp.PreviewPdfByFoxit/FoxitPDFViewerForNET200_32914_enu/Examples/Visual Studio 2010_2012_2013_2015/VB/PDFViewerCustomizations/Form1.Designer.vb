<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.removeToolbarbutton = New System.Windows.Forms.Button()
        Me.AddNewTollbarButton = New System.Windows.Forms.Button()
        Me.MoveToolbarDownButton = New System.Windows.Forms.Button()
        Me.MoveToolbarTopButton = New System.Windows.Forms.Button()
        Me.MoveNPanelLeftButton = New System.Windows.Forms.Button()
        Me.MoveNPanelRightButton = New System.Windows.Forms.Button()
        Me.pdfViewerToolBar1 = New Foxit.PDF.Viewer.PdfToolStrip()
        Me.navigationPanel1 = New Foxit.PDF.Viewer.PdfNavigationPanel()
        Me.pdfViewer1 = New Foxit.PDF.Viewer.PdfViewer()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(995, 23)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Example to demonstrate separate controls like Navigation Panel and Toolbar"
        ' 
        ' MoveNPanelRightButton
        ' 
        Me.MoveNPanelRightButton.Location = New System.Drawing.Point(190, 34)
        Me.MoveNPanelRightButton.Name = "MoveNPanelRightButton"
        Me.MoveNPanelRightButton.Size = New System.Drawing.Size(158, 23)
        Me.MoveNPanelRightButton.TabIndex = 3
        Me.MoveNPanelRightButton.Text = "Move Navigation Panel Right"
        Me.MoveNPanelRightButton.UseVisualStyleBackColor = True
        AddHandler Me.MoveNPanelRightButton.Click, AddressOf Me.MoveNPanelRightButton_Click
        ' 
        ' MoveNPanelLeftButton
        ' 
        Me.MoveNPanelLeftButton.Location = New System.Drawing.Point(24, 34)
        Me.MoveNPanelLeftButton.Name = "MoveNPanelLeftButton"
        Me.MoveNPanelLeftButton.Size = New System.Drawing.Size(160, 23)
        Me.MoveNPanelLeftButton.TabIndex = 4
        Me.MoveNPanelLeftButton.Text = "Move Navigation Panel Left"
        Me.MoveNPanelLeftButton.UseVisualStyleBackColor = True
        AddHandler Me.MoveNPanelLeftButton.Click, AddressOf Me.MoveNPanelLeftButton_Click
        ' 
        ' MoveToolbarTopButton
        ' 
        Me.MoveToolbarTopButton.Location = New System.Drawing.Point(411, 34)
        Me.MoveToolbarTopButton.Name = "MoveToolbarTopButton"
        Me.MoveToolbarTopButton.Size = New System.Drawing.Size(125, 23)
        Me.MoveToolbarTopButton.TabIndex = 5
        Me.MoveToolbarTopButton.Text = "Move Toolbar Top"
        Me.MoveToolbarTopButton.UseVisualStyleBackColor = True
        AddHandler Me.MoveToolbarTopButton.Click, AddressOf Me.MoveToolbarTopButton_Click
        ' 
        ' MoveToolbarDownButton
        ' 
        Me.MoveToolbarDownButton.Location = New System.Drawing.Point(542, 34)
        Me.MoveToolbarDownButton.Name = "MoveToolbarDownButton"
        Me.MoveToolbarDownButton.Size = New System.Drawing.Size(119, 23)
        Me.MoveToolbarDownButton.TabIndex = 6
        Me.MoveToolbarDownButton.Text = "Move Toolbar Down"
        Me.MoveToolbarDownButton.UseVisualStyleBackColor = True
        AddHandler Me.MoveToolbarDownButton.Click, AddressOf Me.MoveToolbarDownButton_Click
        ' 
        ' AddNewTollbarButton
        ' 
        Me.AddNewTollbarButton.Location = New System.Drawing.Point(749, 34)
        Me.AddNewTollbarButton.Name = "AddNewTollbarButton"
        Me.AddNewTollbarButton.Size = New System.Drawing.Size(107, 23)
        Me.AddNewTollbarButton.TabIndex = 7
        Me.AddNewTollbarButton.Text = "Add New ToolBar"
        Me.AddNewTollbarButton.UseVisualStyleBackColor = True
        AddHandler Me.AddNewTollbarButton.Click, AddressOf Me.AddNewTollbarButton_Click
        ' 
        ' removeToolbarbutton
        ' 
        Me.removeToolbarbutton.Location = New System.Drawing.Point(873, 34)
        Me.removeToolbarbutton.Name = "removeToolbarbutton"
        Me.removeToolbarbutton.Size = New System.Drawing.Size(110, 23)
        Me.removeToolbarbutton.TabIndex = 8
        Me.removeToolbarbutton.Text = "Remove Toolbar"
        Me.removeToolbarbutton.UseVisualStyleBackColor = True
        AddHandler Me.removeToolbarbutton.Click, AddressOf Me.removeToolbarbutton_Click
        '
        'pdfViewerToolBar1
        '
        Me.pdfViewerToolBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewerToolBar1.Location = New System.Drawing.Point(0, 70)
        Me.pdfViewerToolBar1.MinimumSize = New System.Drawing.Size(40, 35)
        Me.pdfViewerToolBar1.Name = "pdfViewerToolBar1"
        Me.pdfViewerToolBar1.Size = New System.Drawing.Size(978, 35)
        Me.pdfViewerToolBar1.TabIndex = 12
        Me.pdfViewerToolBar1.Text = "pdfViewerToolBar1"
        '
        'navigationPanel1
        '
        Me.navigationPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.navigationPanel1.BackColor = System.Drawing.Color.Gray
        Me.navigationPanel1.ShowNavigationIconsOnExpand = True
        Me.navigationPanel1.Location = New System.Drawing.Point(7, 113)
        Me.navigationPanel1.MinimumSize = New System.Drawing.Size(55, 200)
        Me.navigationPanel1.Name = "navigationPanel1"
        Me.navigationPanel1.ShowShrinkIcon = False
        Me.navigationPanel1.Size = New System.Drawing.Size(261, 374)
        Me.navigationPanel1.TabIndex = 11
        Me.navigationPanel1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.Bookmark
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.pdfViewer1.DisplayUnit = Foxit.PDF.Viewer.Units.Inches
        Me.pdfViewer1.Location = New System.Drawing.Point(292, 113)
        Me.pdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.NavigationPanelWidth = 345
        Me.pdfViewer1.PageColor = System.Drawing.Color.White
        Me.pdfViewer1.ShowNavigationPanel = False
        Me.pdfViewer1.ShowStatusBar = True
        Me.pdfViewer1.ShowToolStrip = False
        Me.pdfViewer1.Size = New System.Drawing.Size(674, 374)
        Me.pdfViewer1.TabIndex = 10
        Me.pdfViewer1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 573)
        Me.Text = "Separate Controls Demo"
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.removeToolbarbutton)
        Me.Controls.Add(Me.AddNewTollbarButton)
        Me.Controls.Add(Me.MoveToolbarDownButton)
        Me.Controls.Add(Me.MoveToolbarTopButton)
        Me.Controls.Add(Me.MoveNPanelLeftButton)
        Me.Controls.Add(Me.MoveNPanelRightButton)
        Me.Controls.Add(Me.pdfViewerToolBar1)
        Me.Controls.Add(Me.navigationPanel1)
        Me.Controls.Add(Me.pdfViewer1)
        Me.Name = "Form1"
        AddHandler Me.Load, AddressOf Me.Form1_Load
        Me.ResumeLayout(False)
    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents removeToolbarbutton As System.Windows.Forms.Button
    Private WithEvents AddNewTollbarButton As System.Windows.Forms.Button
    Private WithEvents MoveToolbarDownButton As System.Windows.Forms.Button
    Private WithEvents MoveToolbarTopButton As System.Windows.Forms.Button
    Private WithEvents MoveNPanelLeftButton As System.Windows.Forms.Button
    Private WithEvents MoveNPanelRightButton As System.Windows.Forms.Button
    Private WithEvents pdfViewerToolBar1 As Foxit.PDF.Viewer.PdfToolStrip
    Private WithEvents navigationPanel1 As Foxit.PDF.Viewer.PdfNavigationPanel
    Private WithEvents pdfViewer1 As Foxit.PDF.Viewer.PdfViewer

End Class
