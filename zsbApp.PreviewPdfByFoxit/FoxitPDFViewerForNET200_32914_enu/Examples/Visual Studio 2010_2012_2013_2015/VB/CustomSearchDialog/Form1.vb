Public Class Form1

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub
    Private Sub pdfViewer1_SearchDialogShowing(ByVal sender As System.Object, ByVal e As Foxit.PDF.Viewer.SearchDialogShowingEventArgs)
        e.Cancel = True
        searchText.Focus()
    End Sub
    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim matchOptions As Foxit.PDF.Viewer.MatchOptions
        If (Not String.IsNullOrEmpty(searchText.Text)) Then
            matchOptions = Foxit.PDF.Viewer.MatchOptions.All
            If ((matchWholeWord.Checked = True) And (matchCase.Checked = True)) Then
                matchOptions = Foxit.PDF.Viewer.MatchOptions.All
            ElseIf ((matchWholeWord.Checked = True) And (matchCase.Checked = False)) Then
                matchOptions = Foxit.PDF.Viewer.MatchOptions.WholeWordOnly
            ElseIf ((matchWholeWord.Checked = False) And (matchCase.Checked = True)) Then
                matchOptions = Foxit.PDF.Viewer.MatchOptions.CaseSensitive
            Else
                matchOptions = Foxit.PDF.Viewer.MatchOptions.None
            End If
            pdfViewer1.SearchForward(searchText.Text, matchOptions)
        End If
    End Sub
    Private Sub pdfViewer1_DocumentDisplayed(ByVal sender As System.Object, ByVal e As Foxit.PDF.Viewer.DocumentDisplayedEventArgs)
        groupBox1.Enabled = True
        title.Text = "Type a search term in the 'Find' text box and click on 'Find Next'."
    End Sub
End Class
