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
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Open = New System.Windows.Forms.ToolStripButton()
        Me.Print = New System.Windows.Forms.ToolStripButton()
        Me.CloseDoc = New System.Windows.Forms.ToolStripButton()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pdfViewer1 = New Foxit.PDF.Viewer.PdfViewer()
        Me.toolStrip1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = False
        Me.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Open, Me.Print, Me.CloseDoc})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(712, 41)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'Open
        '
        Me.Open.AutoSize = False
        Me.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(70, 40)
        Me.Open.Text = "Open"
        '
        'Print
        '
        Me.Print.AutoSize = False
        Me.Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(70, 40)
        Me.Print.Text = "Print"
        '
        'CloseDoc
        '
        Me.CloseDoc.AutoSize = False
        Me.CloseDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CloseDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseDoc.Name = "CloseDoc"
        Me.CloseDoc.Size = New System.Drawing.Size(70, 40)
        Me.CloseDoc.Text = "Close"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 41)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.splitContainer1.Panel1.Controls.Add(Me.label1)
        Me.splitContainer1.Panel1MinSize = 20
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.pdfViewer1)
        Me.splitContainer1.Size = New System.Drawing.Size(712, 456)
        Me.splitContainer1.SplitterDistance = 25
        Me.splitContainer1.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(712, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Example to demonstrate hidden toolbar and navigation panel. The toolbar at the to" & _
    "p is not part of the viewer control."
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewer1.InitialPage = 1
        Me.pdfViewer1.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.NavigationPanelWidth = 345
        Me.pdfViewer1.ShowBookmarkIcon = False
        Me.pdfViewer1.ShowThumbnailIcon = False
        Me.pdfViewer1.ShowToolStrip = False
        Me.pdfViewer1.Size = New System.Drawing.Size(712, 427)
        Me.pdfViewer1.TabIndex = 4
        Me.pdfViewer1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 497)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FoxitPDF Viewer Example"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private Print As System.Windows.Forms.ToolStripButton
    Private CloseDoc As System.Windows.Forms.ToolStripButton
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private label1 As System.Windows.Forms.Label
    Private pdfViewer1 As Foxit.PDF.Viewer.PdfViewer
    Private Open As System.Windows.Forms.ToolStripButton
End Class
