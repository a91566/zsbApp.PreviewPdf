using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomSearchDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void pdfViewer1_SearchDialogShowing(object sender, Foxit.PDF.Viewer.SearchDialogShowingEventArgs e)
        {
            e.Cancel = true;
            searchText.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchText.Text))
            {
                Foxit.PDF.Viewer.MatchOptions matchOptions = Foxit.PDF.Viewer.MatchOptions.All; ;
                if ((matchWholeWord.Checked == true) && (matchCase.Checked == true))
                {
                    matchOptions = Foxit.PDF.Viewer.MatchOptions.All;
                }
                else if ((matchWholeWord.Checked == true) && (matchCase.Checked == false))
                {
                    matchOptions = Foxit.PDF.Viewer.MatchOptions.WholeWordOnly;
                }
                else if ((matchWholeWord.Checked == false) && (matchCase.Checked == true))
                {
                    matchOptions = Foxit.PDF.Viewer.MatchOptions.CaseSensitive;
                }
                else
                {
                    matchOptions = Foxit.PDF.Viewer.MatchOptions.None;
                }

                pdfViewer1.SearchForward(searchText.Text, matchOptions);
            }
        }

        private void pdfViewer1_DocumentDisplayed(object sender, Foxit.PDF.Viewer.DocumentDisplayedEventArgs e)
        {
            groupBox1.Enabled = true;
            title.Text = "Type a search term in the 'Find' text box and click on 'Find Next'.";
        }

        
    }
}
