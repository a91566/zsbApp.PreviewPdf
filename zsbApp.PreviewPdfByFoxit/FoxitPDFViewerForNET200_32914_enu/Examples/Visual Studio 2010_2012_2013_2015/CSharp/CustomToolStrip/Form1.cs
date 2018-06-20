using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomToolStrip
{
    public partial class Form1 : Form
    {
        private ToolStrip oldToolStrip = null;
        public Form1()
        {
           InitializeComponent();
            // In the form constructor do not use any Viewer methods (Open, Print etc.) that perform UI activities.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.AddNewToolbar();
        }

        private void ChangeToolbarToCustom_Click(object sender, EventArgs e)
        {
            ChangeToolbarToCustom.Enabled = false;
            RestoreViewerToolbar.Enabled = true;            
            this.AddNewToolbar();
        }

        private void OpenFile(object sender, EventArgs e)
        {
           if (this.openFileDialog1.ShowDialog(this.pdfViewer1) == DialogResult.OK)
            {
               // Calling method to open the selected document from the file dialog.
                this.pdfViewer1.Open(this.openFileDialog1.FileName);
            }
        }

        private void CloseFile(object sender, EventArgs e)
        {
            //Calling method for close.
            this.pdfViewer1.Close();
        }

        private void AboutDialog(object sender, EventArgs e)
        {
            //Displaying information about viewer control.
            pdfViewer1.ShowAboutBox();
        }

        private void AddNewToolbar()
        {
            //Creating new custom toolstrip to replace the viewer toolbar.
            ToolStrip customToolStrip = new ToolStrip();
            customToolStrip.AutoSize = false;
            customToolStrip.Width = this.pdfViewer1.Width;
            customToolStrip.Height = this.pdfViewer1.ToolStrip.Height;
            customToolStrip.RenderMode = ToolStripRenderMode.System;
            customToolStrip.Dock = DockStyle.Top;
            customToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            customToolStrip.Location = new System.Drawing.Point(this.pdfViewer1.Left, this.pdfViewer1.Top);
            customToolStrip.SuspendLayout();
            //
            //Open Button
            //
            ToolStripButton open = new ToolStripButton();
            open.DisplayStyle = ToolStripItemDisplayStyle.Text;                        
            open.Text = "Open";
            open.AutoSize = false;
            open.Name = "OpenControl";
            open.Size = new System.Drawing.Size(70, 30);
            open.ToolTipText = "Open";
            open.Visible = true;
            open.Margin = new Padding(0, 1, 8, 2);
            open.Click += new EventHandler(this.OpenFile);
            //
            //Close Button
            //
            ToolStripButton close = new ToolStripButton();
            close.DisplayStyle = ToolStripItemDisplayStyle.Text;
            close.Text = "Close";
            close.ToolTipText = "Close";
            close.AutoSize = false;
            close.Size = new System.Drawing.Size(70, 30);
            close.Margin = new Padding(0, 1, 4, 2);
            close.ImageTransparentColor = Color.White;
            close.Click += new System.EventHandler(this.CloseFile);

            ToolStripButton about = new ToolStripButton();
            about.DisplayStyle = ToolStripItemDisplayStyle.Text;
            about.Text = "About";
            about.ToolTipText = "About";
            about.AutoSize = false;
            about.Size = new System.Drawing.Size(70, 30);
            about.Margin = new Padding(0, 1, 4, 2);
            about.ImageTransparentColor = Color.White;
            about.Click += new System.EventHandler(this.AboutDialog);
            
            customToolStrip.Items.Add(open);            
            customToolStrip.Items.Add(close);
            customToolStrip.Items.Add(about);
            customToolStrip.ResumeLayout();

            //Storing the viewer toolstrip for future use.
            this.oldToolStrip = this.pdfViewer1.ToolStrip;

            //Replacing the viewer toolstrip with the custom toolstrip.
            this.pdfViewer1.ToolStrip = customToolStrip;
        }

        private void RestoreViewerToolbar_Click(object sender, EventArgs e)
        {
            RestoreViewerToolbar.Enabled = false;
            ChangeToolbarToCustom.Enabled = true;

            this.pdfViewer1.ToolStrip = this.oldToolStrip;
        }

       
    }
}
