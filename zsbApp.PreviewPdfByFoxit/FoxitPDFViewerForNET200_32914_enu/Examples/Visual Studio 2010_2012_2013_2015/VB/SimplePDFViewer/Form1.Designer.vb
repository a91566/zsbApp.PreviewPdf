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
        Me.pdfViewer1 = New Foxit.PDF.Viewer.PdfViewer()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pdfViewer1
        '
        Me.pdfViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.pdfViewer1.InitialOrientation = Nothing
        Me.pdfViewer1.InitialPage = Nothing
        Me.pdfViewer1.InitialPageMode = Nothing
        Me.pdfViewer1.InitialVisibleNavigationPane = Nothing
        Me.pdfViewer1.InitialZoomMode = Nothing
        Me.pdfViewer1.InitialZoomPercent = Nothing
        Me.pdfViewer1.Location = New System.Drawing.Point(2, 26)
        Me.pdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.NavigationPanelWidth = 345
        Me.pdfViewer1.PageColor = System.Drawing.Color.White
        Me.pdfViewer1.ShowBookmarkIcon = True
        Me.pdfViewer1.ShowThumbnailIcon = True
        Me.pdfViewer1.ShowToolStrip = True
        Me.pdfViewer1.Size = New System.Drawing.Size(764, 488)
        Me.pdfViewer1.TabIndex = 0
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
        Me.label1.Size = New System.Drawing.Size(764, 23)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Example to demonstrate default viewer control behaviour."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 514)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pdfViewer1)
        Me.Icon = CType(resources.GetObject("FoxitPDF"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FoxitPDF Viewer Example"
        Me.ResumeLayout(False)

    End Sub
    Private pdfViewer1 As Foxit.PDF.Viewer.PdfViewer
    Private label1 As System.Windows.Forms.Label
End Class
