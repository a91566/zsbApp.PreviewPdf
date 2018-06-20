Public Class Form1
    Public Sub New()
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Toolbar1.AssociateToPdfViewer(PdfViewer1)
        NavigationPanel1.AssociateToPdfViewer(PdfViewer1)
        NavigationPanel2.AssociateToPdfViewer(PdfViewer2)
        NavigationPanel2.Hide()
        NavigationPanel2.Dock = DockStyle.None
        NavigationPanel1.Dock = DockStyle.Left
    End Sub

    Private Sub TabControl1_Selected(sender As System.Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If e.TabPageIndex = 0 Then
            Me.SuspendLayout()
            Toolbar1.AssociateToPdfViewer(PdfViewer1)
            NavigationPanel2.Hide()
            NavigationPanel2.Dock = DockStyle.None
            NavigationPanel1.Dock = DockStyle.Left
            NavigationPanel1.Visible = True
            Me.ResumeLayout()
        Else
            Me.SuspendLayout()
            Toolbar1.AssociateToPdfViewer(PdfViewer2)
            NavigationPanel1.Hide()
            NavigationPanel1.Dock = DockStyle.None
            NavigationPanel2.Dock = DockStyle.Left
            NavigationPanel2.Visible = True
            Me.ResumeLayout()
        End If

    End Sub
End Class
