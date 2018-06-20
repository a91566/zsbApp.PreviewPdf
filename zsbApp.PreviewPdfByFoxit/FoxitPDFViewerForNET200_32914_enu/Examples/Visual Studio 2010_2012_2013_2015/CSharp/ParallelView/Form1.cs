using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParallelView
{
    
    public partial class Form1 : Form
    {
        Foxit.PDF.Viewer.PdfDocument pdfDocument2 = null;

        public Form1()
        {
            InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void pdfViewerLeft_ViewChanged(object sender, Foxit.PDF.Viewer.ViewChangedEventArgs e)
        {
            if (pdfDocument2 != null && e.CurrentView.StartPageNumber <= pdfDocument2.PageCount)
            {
                pdfViewerRight.Navigate(e.CurrentView);

                pdfViewerLeft.Focus();
            }            
        }

        private void pdfViewerRight_FileOpened(object sender, Foxit.PDF.Viewer.FileOpenedEventArgs e)
        {
            pdfDocument2 = e.PdfDocument;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pdfViewerLeft.Focus();
        }        
    }
}
