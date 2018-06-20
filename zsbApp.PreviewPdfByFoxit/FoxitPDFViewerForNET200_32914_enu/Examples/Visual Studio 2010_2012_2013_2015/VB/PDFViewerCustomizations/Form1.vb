
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Partial Public Class Form1
    Inherits Form

    Private minorGap As Integer = 5
    Private newToolStripAdded As Boolean = False
    Private toolbar As Foxit.PDF.Viewer.PdfToolStrip
    Public Sub New()
        InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        pdfViewerToolBar1.AssociateToPdfViewer(pdfViewer1)
        navigationPanel1.AssociateToPdfViewer(pdfViewer1)

        pdfViewerToolBar1.Location = New Point(0, 70)
        pdfViewerToolBar1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top


        navigationPanel1.Location = New Point(minorGap, pdfViewerToolBar1.Bottom + minorGap)
        navigationPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Bottom

        pdfViewer1.Location = New Point(navigationPanel1.Right + minorGap, pdfViewerToolBar1.Bottom + minorGap)
        pdfViewer1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
    End Sub

    Private Sub MoveNPanelRightButton_Click(sender As Object, e As EventArgs)
        pdfViewer1.Location = New Point(minorGap, pdfViewer1.Location.Y)

        navigationPanel1.Location = New Point(pdfViewer1.Right + minorGap, navigationPanel1.Location.Y)
        navigationPanel1.Anchor = AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
    End Sub

    Private Sub MoveNPanelLeftButton_Click(sender As Object, e As EventArgs)
        navigationPanel1.Location = New Point(minorGap, navigationPanel1.Location.Y)
        navigationPanel1.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Bottom

        pdfViewer1.Location = New Point(navigationPanel1.Right + minorGap, pdfViewer1.Location.Y)
    End Sub

    Private Sub MoveToolbarTopButton_Click(sender As Object, e As EventArgs)
        pdfViewerToolBar1.Location = New Point(0, 70)
        pdfViewerToolBar1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top

        navigationPanel1.Location = New Point(navigationPanel1.Location.X, pdfViewerToolBar1.Bottom + minorGap)
        pdfViewer1.Location = New Point(pdfViewer1.Location.X, pdfViewerToolBar1.Bottom + minorGap)
    End Sub

    Private Sub MoveToolbarDownButton_Click(sender As Object, e As EventArgs)
        navigationPanel1.Location = New Point(navigationPanel1.Location.X, 70)
        pdfViewer1.Location = New Point(pdfViewer1.Location.X, 70)

        pdfViewerToolBar1.Location = New Point(0, pdfViewer1.Bottom + minorGap)
        pdfViewerToolBar1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom


    End Sub

    Private Sub AddNewTollbarButton_Click(sender As Object, e As EventArgs)
        If newToolStripAdded = False Then
            toolbar = New Foxit.PDF.Viewer.PdfToolStrip()

            Dim firstButton As ToolStripItem = toolbar.ToolStrip.Items(Foxit.PDF.Viewer.PdfToolStripItems.FirstPage)
            Dim previousButton As ToolStripItem = toolbar.ToolStrip.Items(Foxit.PDF.Viewer.PdfToolStripItems.PreviousPage)
            Dim nextButton As ToolStripItem = toolbar.ToolStrip.Items(Foxit.PDF.Viewer.PdfToolStripItems.NextPage)
            Dim lastButton As ToolStripItem = toolbar.ToolStrip.Items(Foxit.PDF.Viewer.PdfToolStripItems.LastPage)

            toolbar.ToolStrip.Items.Clear()
            toolbar.ToolStrip.Items.Add(firstButton)
            toolbar.ToolStrip.Items.Add(previousButton)
            toolbar.ToolStrip.Items.Add(nextButton)
            toolbar.ToolStrip.Items.Add(lastButton)

            toolbar.AssociateToPdfViewer(pdfViewer1)

            Me.Controls.Add(toolbar)
            toolbar.Dock = DockStyle.Bottom
            toolbar.Size = New Size(Me.ClientRectangle.Width, 50)
            newToolStripAdded = True
        End If

    End Sub

    Private Sub removeToolbarbutton_Click(sender As Object, e As EventArgs)
        If Not toolbar Is Nothing Then
            toolbar.AssociateToPdfViewer(Nothing)
            toolbar.Controls.Clear()
            Me.Controls.Remove(toolbar)
            newToolStripAdded = False
            toolbar = Nothing
        End If
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs)

    End Sub

End Class
