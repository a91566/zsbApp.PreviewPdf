using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HiddenToolbars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog(this.pdfViewer1) == DialogResult.OK)
            {
                //Calling  method to open the selected document from file dialog.
                this.pdfViewer1.Open(this.openFileDialog1.FileName);
            }
          
        }

        private void Print_Click(object sender, EventArgs e)
        {
            //Calling method for print.
            this.pdfViewer1.Print();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // Calling mehtod to close the current document.
            this.pdfViewer1.Close();
        }

    }
}
