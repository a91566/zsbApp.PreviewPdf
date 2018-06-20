using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFViewerCustomizations
{
    public partial class Form1 : Form
    {

        int minorGap = 5;
        bool newToolStripAdded = false;
        Foxit.PDF.Viewer.PdfToolStrip toolbar;
        public Form1()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pdfViewerToolBar1.AssociateToPdfViewer(pdfViewer1);
            navigationPanel1.AssociateToPdfViewer(pdfViewer1);

            pdfViewerToolBar1.Location = new Point(0, 70);
            pdfViewerToolBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;


            navigationPanel1.Location = new Point(minorGap, pdfViewerToolBar1.Bottom + minorGap);
            navigationPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            pdfViewer1.Location = new Point(navigationPanel1.Right + minorGap, pdfViewerToolBar1.Bottom + minorGap);
            pdfViewer1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void MoveNPanelRightButton_Click(object sender, EventArgs e)
        {
            pdfViewer1.Location = new Point(minorGap, pdfViewer1.Location.Y);

            navigationPanel1.Location = new Point(pdfViewer1.Right + minorGap, navigationPanel1.Location.Y);
            navigationPanel1.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void MoveNPanelLeftButton_Click(object sender, EventArgs e)
        {
            navigationPanel1.Location = new Point(minorGap, navigationPanel1.Location.Y);
            navigationPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            pdfViewer1.Location = new Point(navigationPanel1.Right + minorGap, pdfViewer1.Location.Y);
        }

        private void MoveToolbarTopButton_Click(object sender, EventArgs e)
        {
            pdfViewerToolBar1.Location = new Point(0, 70);
            pdfViewerToolBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            navigationPanel1.Location = new Point(navigationPanel1.Location.X, pdfViewerToolBar1.Bottom + minorGap);
            pdfViewer1.Location = new Point(pdfViewer1.Location.X, pdfViewerToolBar1.Bottom + minorGap);
        }

        private void MoveToolbarDownButton_Click(object sender, EventArgs e)
        {
            navigationPanel1.Location = new Point(navigationPanel1.Location.X, 70);
            pdfViewer1.Location = new Point(pdfViewer1.Location.X, 70);

            pdfViewerToolBar1.Location = new Point(0, pdfViewer1.Bottom + minorGap);
            pdfViewerToolBar1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
         
            
        }

        private void AddNewTollbarButton_Click(object sender, EventArgs e)
        {
            if (newToolStripAdded == false)
            {
                toolbar = new Foxit.PDF.Viewer.PdfToolStrip();

                ToolStripItem firstButton = toolbar.ToolStrip.Items[Foxit.PDF.Viewer.PdfToolStripItems.FirstPage];
                ToolStripItem previousButton = toolbar.ToolStrip.Items[Foxit.PDF.Viewer.PdfToolStripItems.PreviousPage];
                ToolStripItem nextButton = toolbar.ToolStrip.Items[Foxit.PDF.Viewer.PdfToolStripItems.NextPage];
                ToolStripItem lastButton = toolbar.ToolStrip.Items[Foxit.PDF.Viewer.PdfToolStripItems.LastPage];

                toolbar.ToolStrip.Items.Clear();
                toolbar.ToolStrip.Items.Add(firstButton);
                toolbar.ToolStrip.Items.Add(previousButton);
                toolbar.ToolStrip.Items.Add(nextButton);
                toolbar.ToolStrip.Items.Add(lastButton);

                toolbar.AssociateToPdfViewer(pdfViewer1);

                this.Controls.Add(toolbar);
                toolbar.Dock = DockStyle.Bottom;
                toolbar.Size = new Size(this.ClientRectangle.Width, 50);
                newToolStripAdded = true;
            }

        }

        private void removeToolbarbutton_Click(object sender, EventArgs e)
        {
            if (toolbar != null)
            {
                toolbar.AssociateToPdfViewer(null);
                toolbar.Controls.Clear();
                this.Controls.Remove(toolbar);
                newToolStripAdded = false;
                toolbar = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
