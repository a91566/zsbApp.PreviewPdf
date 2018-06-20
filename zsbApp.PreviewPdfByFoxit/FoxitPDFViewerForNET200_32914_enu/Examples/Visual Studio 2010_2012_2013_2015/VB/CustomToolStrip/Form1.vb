Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class Form1
    Inherits System.Windows.Forms.Form

    Private oldToolStrip As ToolStrip = Nothing

    Public Sub Form1()
        InitializeComponent()
        ' In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
    End Sub

    Private Sub ChangeToolbarToCustom_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        ChangeToolbarToCustom.Enabled = False
        RestoreViewerToolbar.Enabled = True
        Me.AddNewToolbar()
    End Sub

    Private Sub OpenFile(ByVal sender As System.Object, ByVal e As EventArgs)
        If (Me.openFileDialog1.ShowDialog(Me.pdfViewer1) = DialogResult.OK) Then
            ' Calling method to open the selected document from the file dialog.
            Me.pdfViewer1.Open(Me.openFileDialog1.FileName)
        End If
    End Sub

    Private Sub CloseFile(ByVal sender As System.Object, ByVal e As EventArgs)
        'Calling method for close.
        Me.pdfViewer1.Close()
    End Sub

    Private Sub AboutDialog(ByVal sender As System.Object, ByVal e As EventArgs)
        pdfViewer1.ShowAboutBox()
    End Sub

    Private Sub AddNewToolbar()

        'Creating new custom toolstrip to replace the viewer toolbar.
        Dim customToolStrip As ToolStrip = New ToolStrip()
        customToolStrip.AutoSize = False
        customToolStrip.Width = Me.pdfViewer1.Width
        customToolStrip.Height = Me.pdfViewer1.ToolStrip.Height
        customToolStrip.RenderMode = ToolStripRenderMode.System
        customToolStrip.Dock = DockStyle.Top
        customToolStrip.GripStyle = ToolStripGripStyle.Hidden
        customToolStrip.Location = New System.Drawing.Point(Me.pdfViewer1.Left, Me.pdfViewer1.Top)
        customToolStrip.SuspendLayout()
        '
        ''Open Button
        '
        Dim open As ToolStripButton = New ToolStripButton()
        open.DisplayStyle = ToolStripItemDisplayStyle.Text
        open.Text = "Open"
        open.AutoSize = False
        open.Name = "OpenControl"
        open.Size = New System.Drawing.Size(70, 30)
        open.ToolTipText = "Open"
        open.Visible = True
        open.Margin = New Padding(0, 1, 8, 2)
        AddHandler open.Click, AddressOf Me.OpenFile
        'Close Button
        '
        Dim Close As ToolStripButton = New ToolStripButton()
        Close.DisplayStyle = ToolStripItemDisplayStyle.Text
        Close.Text = "Close"
        Close.ToolTipText = "Close"
        Close.AutoSize = False
        Close.Size = New System.Drawing.Size(70, 30)
        Close.Margin = New Padding(0, 1, 4, 2)
        Close.ImageTransparentColor = Color.White
        AddHandler Close.Click, AddressOf Me.CloseFile

        Dim about As ToolStripButton = New ToolStripButton()
        about.DisplayStyle = ToolStripItemDisplayStyle.Text
        about.Text = "About"
        about.ToolTipText = "About"
        about.AutoSize = False
        about.Size = New System.Drawing.Size(70, 30)
        about.Margin = New Padding(0, 1, 4, 2)
        about.ImageTransparentColor = Color.White
        AddHandler about.Click, AddressOf Me.AboutDialog

        customToolStrip.Items.Add(open)
        customToolStrip.Items.Add(Close)
        customToolStrip.Items.Add(about)
        customToolStrip.ResumeLayout()

        'Storing the viewer toolstrip for future use.
        Me.oldToolStrip = Me.pdfViewer1.ToolStrip

        'Replacing the viewer toolstrip with the custom toolstrip.
        Me.pdfViewer1.ToolStrip = customToolStrip
    End Sub
    Private Sub RestoreViewerToolbar_Click(ByVal sender As System.Object, ByVal e As EventArgs)
        RestoreViewerToolbar.Enabled = False
        ChangeToolbarToCustom.Enabled = True
        Me.pdfViewer1.ToolStrip = Me.oldToolStrip
    End Sub
End Class
