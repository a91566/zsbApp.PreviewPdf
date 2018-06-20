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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.find = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.matchCase = New System.Windows.Forms.CheckBox()
        Me.matchWholeWord = New System.Windows.Forms.CheckBox()
        Me.pdfViewer1 = New Foxit.PDF.Viewer.PdfViewer()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.splitContainer1.Panel1.Controls.Add(Me.title)
        Me.splitContainer1.Panel1.Controls.Add(Me.groupBox1)
        Me.splitContainer1.Panel1MinSize = 75
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.pdfViewer1)
        Me.splitContainer1.Size = New System.Drawing.Size(880, 604)
        Me.splitContainer1.SplitterDistance = 90
        Me.splitContainer1.TabIndex = 10
        ' 
        ' title
        ' 
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(86, Byte))
        Me.title.ForeColor = System.Drawing.Color.Black
        Me.title.Location = New System.Drawing.Point(3, 5)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(585, 26)
        Me.title.TabIndex = 11
        Me.title.Text = "Example to demonstrate using custom search dialog which overrides the default sea" + "rch window."
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.groupBox1.Controls.Add(Me.find)
        Me.groupBox1.Controls.Add(Me.searchText)
        Me.groupBox1.Controls.Add(Me.matchCase)
        Me.groupBox1.Controls.Add(Me.matchWholeWord)
        Me.groupBox1.Enabled = False
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(4, 31)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.groupBox1.Size = New System.Drawing.Size(582, 50)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Tag = "200"
        Me.groupBox1.Text = "  Find "
        ' 
        ' find
        ' 
        Me.find.ForeColor = System.Drawing.Color.Black
        Me.find.Location = New System.Drawing.Point(295, 16)
        Me.find.Name = "find"
        Me.find.Size = New System.Drawing.Size(76, 23)
        Me.find.TabIndex = 15
        Me.find.Text = "Find Next"
        Me.find.UseVisualStyleBackColor = True
        AddHandler Me.find.Click, AddressOf Me.button3_Click
        ' 
        ' searchText
        ' 
        Me.searchText.Location = New System.Drawing.Point(22, 19)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(267, 20)
        Me.searchText.TabIndex = 13
        ' 
        ' matchCase
        ' 
        Me.matchCase.AutoSize = True
        Me.matchCase.ForeColor = System.Drawing.Color.Black
        Me.matchCase.Location = New System.Drawing.Point(376, 22)
        Me.matchCase.Name = "matchCase"
        Me.matchCase.Size = New System.Drawing.Size(82, 17)
        Me.matchCase.TabIndex = 1
        Me.matchCase.Text = "Match case"
        Me.matchCase.UseVisualStyleBackColor = True
        ' 
        ' matchWholeWord
        ' 
        Me.matchWholeWord.AutoSize = True
        Me.matchWholeWord.ForeColor = System.Drawing.Color.Black
        Me.matchWholeWord.Location = New System.Drawing.Point(464, 22)
        Me.matchWholeWord.Name = "matchWholeWord"
        Me.matchWholeWord.Size = New System.Drawing.Size(113, 17)
        Me.matchWholeWord.TabIndex = 0
        Me.matchWholeWord.Text = "Match whole word"
        Me.matchWholeWord.UseVisualStyleBackColor = True
        ' 
        ' pdfViewer1
        ' 
        Me.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewer1.InitialOrientation = Nothing
        Me.pdfViewer1.InitialPage = 1
        Me.pdfViewer1.InitialPageMode = Nothing
        Me.pdfViewer1.InitialVisibleNavigationPane = Nothing
        Me.pdfViewer1.InitialZoomMode = Nothing
        Me.pdfViewer1.InitialZoomPercent = Nothing
        Me.pdfViewer1.Location = New System.Drawing.Point(0, 0)
        Me.pdfViewer1.MinimumSize = New System.Drawing.Size(200, 150)
        Me.pdfViewer1.Name = "pdfViewer1"
        Me.pdfViewer1.NavigationPanelWidth = 345
        Me.pdfViewer1.PageColor = System.Drawing.Color.White
        Me.pdfViewer1.ShowBookmarkIcon = True
        Me.pdfViewer1.ShowThumbnailIcon = True
        Me.pdfViewer1.ShowToolStrip = True
        Me.pdfViewer1.Size = New System.Drawing.Size(880, 510)
        Me.pdfViewer1.TabIndex = 3
        AddHandler Me.pdfViewer1.SearchDialogShowing, AddressOf Me.pdfViewer1_SearchDialogShowing
        AddHandler Me.pdfViewer1.DocumentDisplayed, AddressOf Me.pdfViewer1_DocumentDisplayed
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(880, 604)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = CType(resources.GetObject("FoxitPDF"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(650, 400)
        Me.Name = "Form1"
        Me.Text = "FoxitPDF Viewer Example"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private find As System.Windows.Forms.Button
    Private searchText As System.Windows.Forms.TextBox
    Private matchCase As System.Windows.Forms.CheckBox
    Private matchWholeWord As System.Windows.Forms.CheckBox
    Private pdfViewer1 As Foxit.PDF.Viewer.PdfViewer
    Private title As System.Windows.Forms.Label
End Class
