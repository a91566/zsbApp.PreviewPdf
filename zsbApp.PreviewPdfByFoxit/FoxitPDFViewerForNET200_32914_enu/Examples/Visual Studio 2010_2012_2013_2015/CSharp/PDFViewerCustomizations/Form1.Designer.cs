namespace PDFViewerCustomizations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdfViewer1 = new Foxit.PDF.Viewer.PdfViewer();
            this.navigationPanel1 = new Foxit.PDF.Viewer.PdfNavigationPanel();
            this.pdfViewerToolBar1 = new Foxit.PDF.Viewer.PdfToolStrip();
            this.MoveNPanelRightButton = new System.Windows.Forms.Button();
            this.MoveNPanelLeftButton = new System.Windows.Forms.Button();
            this.MoveToolbarTopButton = new System.Windows.Forms.Button();
            this.MoveToolbarDownButton = new System.Windows.Forms.Button();
            this.AddNewTollbarButton = new System.Windows.Forms.Button();
            this.removeToolbarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pdfViewer1.DisplayUnit = Foxit.PDF.Viewer.Units.Inches;
            this.pdfViewer1.Location = new System.Drawing.Point(292, 113);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.NavigationPanelWidth = 345;
            this.pdfViewer1.PageColor = System.Drawing.Color.White;
            this.pdfViewer1.ShowNavigationPanel = false;
            this.pdfViewer1.ShowStatusBar = true;
            this.pdfViewer1.ShowToolStrip = false;
            this.pdfViewer1.Size = new System.Drawing.Size(691, 407);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None;
            // 
            // navigationPanel1
            // 
            this.navigationPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navigationPanel1.BackColor = System.Drawing.Color.Gray;
            this.navigationPanel1.ShowNavigationIconsOnExpand = true;
            this.navigationPanel1.Location = new System.Drawing.Point(7, 113);
            this.navigationPanel1.MinimumSize = new System.Drawing.Size(55, 200);
            this.navigationPanel1.Name = "navigationPanel1";
            this.navigationPanel1.ShowShrinkIcon = false;
            this.navigationPanel1.Size = new System.Drawing.Size(261, 407);
            this.navigationPanel1.TabIndex = 1;
            this.navigationPanel1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.Bookmark;
            // 
            // pdfViewerToolBar1
            // 
            this.pdfViewerToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewerToolBar1.Location = new System.Drawing.Point(0, 70);
            this.pdfViewerToolBar1.MinimumSize = new System.Drawing.Size(40, 35);
            this.pdfViewerToolBar1.Name = "pdfViewerToolBar1";
            this.pdfViewerToolBar1.Size = new System.Drawing.Size(995, 35);
            this.pdfViewerToolBar1.TabIndex = 2;
            this.pdfViewerToolBar1.Text = "pdfViewerToolBar1";
            // 
            // MoveNPanelRightButton
            // 
            this.MoveNPanelRightButton.Location = new System.Drawing.Point(190, 34);
            this.MoveNPanelRightButton.Name = "MoveNPanelRightButton";
            this.MoveNPanelRightButton.Size = new System.Drawing.Size(158, 23);
            this.MoveNPanelRightButton.TabIndex = 3;
            this.MoveNPanelRightButton.Text = "Move Navigation Panel Right";
            this.MoveNPanelRightButton.UseVisualStyleBackColor = true;
            this.MoveNPanelRightButton.Click += new System.EventHandler(this.MoveNPanelRightButton_Click);
            // 
            // MoveNPanelLeftButton
            // 
            this.MoveNPanelLeftButton.Location = new System.Drawing.Point(24, 34);
            this.MoveNPanelLeftButton.Name = "MoveNPanelLeftButton";
            this.MoveNPanelLeftButton.Size = new System.Drawing.Size(160, 23);
            this.MoveNPanelLeftButton.TabIndex = 4;
            this.MoveNPanelLeftButton.Text = "Move Navigation Panel Left";
            this.MoveNPanelLeftButton.UseVisualStyleBackColor = true;
            this.MoveNPanelLeftButton.Click += new System.EventHandler(this.MoveNPanelLeftButton_Click);
            // 
            // MoveToolbarTopButton
            // 
            this.MoveToolbarTopButton.Location = new System.Drawing.Point(411, 34);
            this.MoveToolbarTopButton.Name = "MoveToolbarTopButton";
            this.MoveToolbarTopButton.Size = new System.Drawing.Size(125, 23);
            this.MoveToolbarTopButton.TabIndex = 5;
            this.MoveToolbarTopButton.Text = "Move Toolbar Top";
            this.MoveToolbarTopButton.UseVisualStyleBackColor = true;
            this.MoveToolbarTopButton.Click += new System.EventHandler(this.MoveToolbarTopButton_Click);
            // 
            // MoveToolbarDownButton
            // 
            this.MoveToolbarDownButton.Location = new System.Drawing.Point(542, 34);
            this.MoveToolbarDownButton.Name = "MoveToolbarDownButton";
            this.MoveToolbarDownButton.Size = new System.Drawing.Size(119, 23);
            this.MoveToolbarDownButton.TabIndex = 6;
            this.MoveToolbarDownButton.Text = "Move Toolbar Down";
            this.MoveToolbarDownButton.UseVisualStyleBackColor = true;
            this.MoveToolbarDownButton.Click += new System.EventHandler(this.MoveToolbarDownButton_Click);
            // 
            // AddNewTollbarButton
            // 
            this.AddNewTollbarButton.Location = new System.Drawing.Point(749, 34);
            this.AddNewTollbarButton.Name = "AddNewTollbarButton";
            this.AddNewTollbarButton.Size = new System.Drawing.Size(107, 23);
            this.AddNewTollbarButton.TabIndex = 7;
            this.AddNewTollbarButton.Text = "Add New ToolBar";
            this.AddNewTollbarButton.UseVisualStyleBackColor = true;
            this.AddNewTollbarButton.Click += new System.EventHandler(this.AddNewTollbarButton_Click);
            // 
            // removeToolbarbutton
            // 
            this.removeToolbarbutton.Location = new System.Drawing.Point(873, 34);
            this.removeToolbarbutton.Name = "removeToolbarbutton";
            this.removeToolbarbutton.Size = new System.Drawing.Size(110, 23);
            this.removeToolbarbutton.TabIndex = 8;
            this.removeToolbarbutton.Text = "Remove Toolbar";
            this.removeToolbarbutton.UseVisualStyleBackColor = true;
            this.removeToolbarbutton.Click += new System.EventHandler(this.removeToolbarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(995, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Example to demonstrate separate controls like Navigation Panel and Toolbar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeToolbarbutton);
            this.Controls.Add(this.AddNewTollbarButton);
            this.Controls.Add(this.MoveToolbarDownButton);
            this.Controls.Add(this.MoveToolbarTopButton);
            this.Controls.Add(this.MoveNPanelLeftButton);
            this.Controls.Add(this.MoveNPanelRightButton);
            this.Controls.Add(this.pdfViewerToolBar1);
            this.Controls.Add(this.navigationPanel1);
            this.Controls.Add(this.pdfViewer1);
            this.Name = "Form1";
            this.Text = "Separate Controls Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Foxit.PDF.Viewer.PdfViewer pdfViewer1;
        private Foxit.PDF.Viewer.PdfNavigationPanel navigationPanel1;
        private Foxit.PDF.Viewer.PdfToolStrip pdfViewerToolBar1;
        private System.Windows.Forms.Button MoveNPanelRightButton;
        private System.Windows.Forms.Button MoveNPanelLeftButton;
        private System.Windows.Forms.Button MoveToolbarTopButton;
        private System.Windows.Forms.Button MoveToolbarDownButton;
        private System.Windows.Forms.Button AddNewTollbarButton;
        private System.Windows.Forms.Button removeToolbarbutton;
        private System.Windows.Forms.Label label1;
    }
}

