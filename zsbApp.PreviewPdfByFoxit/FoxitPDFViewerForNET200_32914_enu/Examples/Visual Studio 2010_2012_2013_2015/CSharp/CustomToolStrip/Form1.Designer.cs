namespace CustomToolStrip
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
            this.ChangeToolbarToCustom = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pdfViewer1 = new Foxit.PDF.Viewer.PdfViewer();
            this.RestoreViewerToolbar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeToolbarToCustom
            // 
            this.ChangeToolbarToCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeToolbarToCustom.Location = new System.Drawing.Point(888, 36);
            this.ChangeToolbarToCustom.Name = "ChangeToolbarToCustom";
            this.ChangeToolbarToCustom.Size = new System.Drawing.Size(105, 45);
            this.ChangeToolbarToCustom.TabIndex = 1;
            this.ChangeToolbarToCustom.Text = "Custom toolbar";
            this.ChangeToolbarToCustom.UseVisualStyleBackColor = true;
            this.ChangeToolbarToCustom.Click += new System.EventHandler(this.ChangeToolbarToCustom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pdfViewer1.InitialOrientation = null;
            this.pdfViewer1.InitialPage = 1;
            this.pdfViewer1.InitialPageMode = null;
            this.pdfViewer1.InitialVisibleNavigationPane = null;
            this.pdfViewer1.InitialZoomMode = null;
            this.pdfViewer1.InitialZoomPercent = null;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 26);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(200, 150);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.NavigationPanelWidth = 345;
            this.pdfViewer1.PageColor = System.Drawing.Color.White;
            this.pdfViewer1.ShowBookmarkIcon = true;
            this.pdfViewer1.ShowThumbnailIcon = true;
            this.pdfViewer1.ShowToolStrip = true;
            this.pdfViewer1.Size = new System.Drawing.Size(882, 530);
            this.pdfViewer1.TabIndex = 2;
            // 
            // RestoreViewerToolbar
            // 
            this.RestoreViewerToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreViewerToolbar.Enabled = false;
            this.RestoreViewerToolbar.Location = new System.Drawing.Point(888, 87);
            this.RestoreViewerToolbar.Name = "RestoreViewerToolbar";
            this.RestoreViewerToolbar.Size = new System.Drawing.Size(105, 45);
            this.RestoreViewerToolbar.TabIndex = 3;
            this.RestoreViewerToolbar.Text = "Restore Viewer Toolbar";
            this.RestoreViewerToolbar.UseVisualStyleBackColor = true;
            this.RestoreViewerToolbar.Click += new System.EventHandler(this.RestoreViewerToolbar_Click);
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
            this.label1.TabIndex = 4;
            this.label1.Text = "Example to demonstrate replacing default toolbar items of the viewer control with" +
                " custom toolbar items.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestoreViewerToolbar);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.ChangeToolbarToCustom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FoxitPDF Viewer Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeToolbarToCustom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Foxit.PDF.Viewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button RestoreViewerToolbar;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1());
        }
    }
}

