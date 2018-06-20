using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zsbApp.PreviewPdf.Test
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }


        private zsbApp.PreviewPdf.IPreviewPdf iPreviewPdf;

        private void btnSelectInterface_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "可执行文件|*.dll;*.exe;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txbInterface.Text = openFileDialog.FileName;
                this.createIPreviewPdf(openFileDialog.FileName);
                if (this.iPreviewPdf != null)
                {
                    this.lblInterfaceTag.Text = this.iPreviewPdf.Tag;
                }
                else
                {
                    MessageBox.Show("没有找到对应的接口");
                }
            }
        }

        private void createIPreviewPdf(string file)
        {
            var asm = System.Reflection.Assembly.LoadFile(this.txbInterface.Text);
            foreach (var type in asm.GetTypes())
            {
                if (type.GetInterfaces().Contains(typeof(zsbApp.PreviewPdf.IPreviewPdf)))
                {
                    this.iPreviewPdf = Activator.CreateInstance(type) as zsbApp.PreviewPdf.IPreviewPdf;
                    if (this.iPreviewPdf != null)
                        break;
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (this.iPreviewPdf == null)
            {
                MessageBox.Show("没有找到对应的接口");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "pdf 文档 |*.pdf;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txbFile.Text = openFileDialog.FileName;
                this.btnLoad_Click(sender, e);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;
            f.Shown += (s, e1) =>
            {
                Control control = this.iPreviewPdf.GetControl();
                f.Controls.Add(control);
                control.Parent = f;
                control.Dock = DockStyle.Fill;
                var x = this.iPreviewPdf.LoadFile(this.txbFile.Text);
                if (!string.IsNullOrEmpty(x))
                {
                    MessageBox.Show(x);
                }
            };
            f.ShowDialog();
        }
        
    }
}
