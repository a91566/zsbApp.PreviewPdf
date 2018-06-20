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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Toolbar1 = New Foxit.PDF.Viewer.PdfToolStrip()
        Me.NavigationPanel1 = New Foxit.PDF.Viewer.PdfNavigationPanel()
        Me.NavigationPanel2 = New Foxit.PDF.Viewer.PdfNavigationPanel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PdfViewer1 = New Foxit.PDF.Viewer.PdfViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PdfViewer2 = New Foxit.PDF.Viewer.PdfViewer()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.label1.Size = New System.Drawing.Size(1006, 55)
        Me.label1.TabIndex = 6
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'Toolbar1
        '
        Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Toolbar1.Location = New System.Drawing.Point(0, 55)
        Me.Toolbar1.MinimumSize = New System.Drawing.Size(40, 35)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(1006, 35)
        Me.Toolbar1.TabIndex = 7
        Me.Toolbar1.Text = "Toolbar1"
        '
        'NavigationPanel1
        '
        Me.NavigationPanel1.BackColor = System.Drawing.Color.Gray
        Me.NavigationPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavigationPanel1.ShowNavigationIconsOnExpand = True
        Me.NavigationPanel1.Location = New System.Drawing.Point(55, 90)
        Me.NavigationPanel1.MinimumSize = New System.Drawing.Size(55, 200)
        Me.NavigationPanel1.Name = "NavigationPanel1"
        Me.NavigationPanel1.ShowShrinkIcon = False
        Me.NavigationPanel1.Size = New System.Drawing.Size(55, 503)
        Me.NavigationPanel1.TabIndex = 8
        Me.NavigationPanel1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'NavigationPanel2
        '
        Me.NavigationPanel2.BackColor = System.Drawing.Color.Gray
        Me.NavigationPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavigationPanel2.ShowNavigationIconsOnExpand = True
        Me.NavigationPanel2.Location = New System.Drawing.Point(0, 90)
        Me.NavigationPanel2.MinimumSize = New System.Drawing.Size(55, 200)
        Me.NavigationPanel2.Name = "NavigationPanel2"
        Me.NavigationPanel2.ShowShrinkIcon = False
        Me.NavigationPanel2.Size = New System.Drawing.Size(55, 503)
        Me.NavigationPanel2.TabIndex = 8
        Me.NavigationPanel2.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(110, 90)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 503)
        Me.Splitter1.TabIndex = 9
        Me.Splitter1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(113, 90)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(893, 503)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PdfViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(487, 477)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PdfViewer1
        '
        Me.PdfViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PdfViewer1.NavigationPanelWidth = 345
        Me.PdfViewer1.DisplayUnit = Foxit.PDF.Viewer.Units.Inches
        Me.PdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewer1.Location = New System.Drawing.Point(3, 3)
        Me.PdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.PageColor = System.Drawing.Color.White
        Me.PdfViewer1.ShowNavigationPanel = False
        Me.PdfViewer1.ShowToolStrip = False
        Me.PdfViewer1.ShowStatusBar = True
        Me.PdfViewer1.Size = New System.Drawing.Size(481, 471)
        Me.PdfViewer1.TabIndex = 0
        Me.PdfViewer1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PdfViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(885, 477)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PdfViewer2
        '
        Me.PdfViewer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PdfViewer2.NavigationPanelWidth = 345
        Me.PdfViewer2.DisplayUnit = Foxit.PDF.Viewer.Units.Inches
        Me.PdfViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewer2.Location = New System.Drawing.Point(3, 3)
        Me.PdfViewer2.MinimumSize = New System.Drawing.Size(200, 150)
        Me.PdfViewer2.Name = "PdfViewer2"
        Me.PdfViewer2.PageColor = System.Drawing.Color.White
        Me.PdfViewer2.ShowNavigationPanel = False
        Me.PdfViewer2.ShowToolStrip = False
        Me.PdfViewer2.ShowStatusBar = True
        Me.PdfViewer2.Size = New System.Drawing.Size(879, 471)
        Me.PdfViewer2.TabIndex = 0
        Me.PdfViewer2.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 593)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.NavigationPanel1)
        Me.Controls.Add(Me.NavigationPanel2)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FoxitPDF Viewer Example"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Toolbar1 As Foxit.PDF.Viewer.PdfToolStrip
    Friend WithEvents NavigationPanel1 As Foxit.PDF.Viewer.PdfNavigationPanel
    Friend WithEvents NavigationPanel2 As Foxit.PDF.Viewer.PdfNavigationPanel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PdfViewer1 As Foxit.PDF.Viewer.PdfViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PdfViewer2 As Foxit.PDF.Viewer.PdfViewer

End Class
