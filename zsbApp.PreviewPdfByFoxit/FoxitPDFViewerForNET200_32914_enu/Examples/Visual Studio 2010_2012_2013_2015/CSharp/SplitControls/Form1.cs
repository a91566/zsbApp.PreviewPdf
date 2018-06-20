using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplitControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolbar1.AssociateToPdfViewer(pdfViewer1);
            navigationPanel1.AssociateToPdfViewer(pdfViewer1);
            navigationPanel2.AssociateToPdfViewer(pdfViewer2);
            navigationPanel2.Hide();
            navigationPanel2.Dock = DockStyle.None;
            navigationPanel1.Dock = DockStyle.Left;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                this.SuspendLayout();
                toolbar1.AssociateToPdfViewer(pdfViewer1);
                navigationPanel2.Hide();
                navigationPanel2.Dock = DockStyle.None;
                navigationPanel1.Dock = DockStyle.Left;
                navigationPanel1.Visible = true;
                this.ResumeLayout();
            }
            else
            {
                this.SuspendLayout();
                toolbar1.AssociateToPdfViewer(pdfViewer2);
                navigationPanel1.Hide();
                navigationPanel1.Dock = DockStyle.None;
                navigationPanel2.Dock = DockStyle.Left;
                navigationPanel2.Visible = true;
                this.ResumeLayout();
            }

        }
    }
}
