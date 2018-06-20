namespace SplitControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.toolbar1 = new Foxit.PDF.Viewer.PdfToolStrip();
            this.navigationPanel1 = new Foxit.PDF.Viewer.PdfNavigationPanel();
            this.navigationPanel2 = new Foxit.PDF.Viewer.PdfNavigationPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pdfViewer1 = new Foxit.PDF.Viewer.PdfViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pdfViewer2 = new Foxit.PDF.Viewer.PdfViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(962, 56);
            this.title.TabIndex = 1;
            this.title.Text = resources.GetString("title.Text");
            // 
            // toolbar1
            // 
            this.toolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar1.Location = new System.Drawing.Point(0, 56);
            this.toolbar1.MinimumSize = new System.Drawing.Size(40, 35);
            this.toolbar1.Name = "toolbar1";
            this.toolbar1.Size = new System.Drawing.Size(962, 35);
            this.toolbar1.TabIndex = 2;
            this.toolbar1.Text = "toolbar1";
            // 
            // navigationPanel1
            // 
            this.navigationPanel1.BackColor = System.Drawing.Color.Gray;
            this.navigationPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel1.ShowNavigationIconsOnExpand = true;
            this.navigationPanel1.Location = new System.Drawing.Point(0, 91);
            this.navigationPanel1.MinimumSize = new System.Drawing.Size(55, 200);
            this.navigationPanel1.Name = "navigationPanel1";
            this.navigationPanel1.ShowShrinkIcon = false;
            this.navigationPanel1.Size = new System.Drawing.Size(55, 522);
            this.navigationPanel1.TabIndex = 3;
            this.navigationPanel1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None;
            // 
            // navigationPanel2
            // 
            this.navigationPanel2.BackColor = System.Drawing.Color.Gray;
            this.navigationPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel2.ShowNavigationIconsOnExpand = true;
            this.navigationPanel2.Location = new System.Drawing.Point(0, 91);
            this.navigationPanel2.MinimumSize = new System.Drawing.Size(55, 200);
            this.navigationPanel2.Name = "navigationPanel2";
            this.navigationPanel2.ShowShrinkIcon = false;
            this.navigationPanel2.Size = new System.Drawing.Size(55, 522);
            this.navigationPanel2.TabIndex = 3;
            this.navigationPanel2.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(55, 91);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 522);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(58, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 522);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pdfViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pdfViewer1.NavigationPanelWidth = 345;
            this.pdfViewer1.DisplayUnit = Foxit.PDF.Viewer.Units.Inches;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.PageColor = System.Drawing.Color.White;
            this.pdfViewer1.ShowNavigationPanel = false;
            this.pdfViewer1.ShowToolStrip = false;
            this.pdfViewer1.ShowStatusBar = true;
            this.pdfViewer1.Size = new System.Drawing.Size(890, 490);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pdfViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pdfViewer2
            // 
            this.pdfViewer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pdfViewer2.NavigationPanelWidth = 345;
            this.pdfViewer2.DisplayUnit = Foxit.PDF.Viewer.Units.Inches;
            this.pdfViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer2.Location = new System.Drawing.Point(3, 3);
            this.pdfViewer2.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer2.Name = "pdfViewer2";
            this.pdfViewer2.PageColor = System.Drawing.Color.White;
            this.pdfViewer2.ShowNavigationPanel = false;
            this.pdfViewer2.ShowToolStrip = false;
            this.pdfViewer2.ShowStatusBar = true;
            this.pdfViewer2.Size = new System.Drawing.Size(890, 490);
            this.pdfViewer2.TabIndex = 0;
            this.pdfViewer2.VisibleNavigationPane = Foxit.PDF.Viewer.NavigationPane.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 613);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.navigationPanel1);
            this.Controls.Add(this.navigationPanel2);
            this.Controls.Add(this.toolbar1);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FoxitPDF Viewer Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private Foxit.PDF.Viewer.PdfToolStrip toolbar1;
        private Foxit.PDF.Viewer.PdfNavigationPanel navigationPanel1;
        private Foxit.PDF.Viewer.PdfNavigationPanel navigationPanel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Foxit.PDF.Viewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Foxit.PDF.Viewer.PdfViewer pdfViewer2;
    }
}

