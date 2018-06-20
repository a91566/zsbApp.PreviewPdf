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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.title = New System.Windows.Forms.Label()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.pdfViewerLeft = New Foxit.PDF.Viewer.PdfViewer()
        Me.pdfViewerRight = New Foxit.PDF.Viewer.PdfViewer()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.title)
        Me.splitContainer1.Panel1MinSize = 20
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.splitContainer2)
        Me.splitContainer1.Size = New System.Drawing.Size(834, 587)
        Me.splitContainer1.SplitterDistance = 40
        Me.splitContainer1.TabIndex = 0
        '
        'title
        '
        Me.title.AutoEllipsis = True
        Me.title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.SystemColors.Control
        Me.title.Location = New System.Drawing.Point(0, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(834, 40)
        Me.title.TabIndex = 0
        Me.title.Text = "Example to demonstrate comparing two PDFs side by side." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Changes made in the page" & _
    " view in the viewer control on the left hand side will be reflected automaticall" & _
    "y on the right hand side."
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.pdfViewerLeft)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.pdfViewerRight)
        Me.splitContainer2.Size = New System.Drawing.Size(834, 543)
        Me.splitContainer2.SplitterDistance = 414
        Me.splitContainer2.TabIndex = 4
        '
        'pdfViewerLeft
        '
        Me.pdfViewerLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerLeft.InitialPage = 1
        Me.pdfViewerLeft.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewerLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.pdfViewerLeft.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewerLeft.Name = "pdfViewerLeft"
        Me.pdfViewerLeft.NavigationPanelWidth = 345
        Me.pdfViewerLeft.Size = New System.Drawing.Size(414, 543)
        Me.pdfViewerLeft.TabIndex = 1
        Me.pdfViewerLeft.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'pdfViewerRight
        '
        Me.pdfViewerRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerRight.InitialPage = 1
        Me.pdfViewerRight.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewerRight.Margin = New System.Windows.Forms.Padding(0)
        Me.pdfViewerRight.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewerRight.Name = "pdfViewerRight"
        Me.pdfViewerRight.NavigationPanelWidth = 345
        Me.pdfViewerRight.Size = New System.Drawing.Size(416, 543)
        Me.pdfViewerRight.TabIndex = 2
        Me.pdfViewerRight.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(834, 587)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FoxitPDF Viewer Example"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private splitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents pdfViewerLeft As Foxit.PDF.Viewer.PdfViewer
    Friend WithEvents pdfViewerRight As Foxit.PDF.Viewer.PdfViewer
    Private title As System.Windows.Forms.Label
    Private resources As System.ComponentModel.ComponentResourceManager
End Class
