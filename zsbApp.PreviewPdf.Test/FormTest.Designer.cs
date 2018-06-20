namespace zsbApp.PreviewPdf.Test
{
    partial class FormTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbInterface = new System.Windows.Forms.TextBox();
            this.lblInterfaceTag = new System.Windows.Forms.Label();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectInterface = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 461);
            this.panel1.TabIndex = 662;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(76, 38);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 461);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.txbInterface);
            this.tabPage1.Controls.Add(this.lblInterfaceTag);
            this.tabPage1.Controls.Add(this.txbFile);
            this.tabPage1.Controls.Add(this.btnSelectFile);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSelectInterface);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "接口预览 pdf";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txbInterface
            // 
            this.txbInterface.Location = new System.Drawing.Point(5, 31);
            this.txbInterface.Margin = new System.Windows.Forms.Padding(5);
            this.txbInterface.Multiline = true;
            this.txbInterface.Name = "txbInterface";
            this.txbInterface.Size = new System.Drawing.Size(753, 47);
            this.txbInterface.TabIndex = 21;
            // 
            // lblInterfaceTag
            // 
            this.lblInterfaceTag.AutoSize = true;
            this.lblInterfaceTag.ForeColor = System.Drawing.Color.Blue;
            this.lblInterfaceTag.Location = new System.Drawing.Point(88, 83);
            this.lblInterfaceTag.Name = "lblInterfaceTag";
            this.lblInterfaceTag.Size = new System.Drawing.Size(72, 16);
            this.lblInterfaceTag.TabIndex = 24;
            this.lblInterfaceTag.Text = "接口标识";
            // 
            // txbFile
            // 
            this.txbFile.Location = new System.Drawing.Point(5, 151);
            this.txbFile.Margin = new System.Windows.Forms.Padding(5);
            this.txbFile.Multiline = true;
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(753, 46);
            this.txbFile.TabIndex = 16;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Location = new System.Drawing.Point(768, 151);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(149, 38);
            this.btnSelectFile.TabIndex = 17;
            this.btnSelectFile.Text = "选择 pdf 文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "接口标识";
            // 
            // btnSelectInterface
            // 
            this.btnSelectInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectInterface.Location = new System.Drawing.Point(768, 36);
            this.btnSelectInterface.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectInterface.Name = "btnSelectInterface";
            this.btnSelectInterface.Size = new System.Drawing.Size(149, 38);
            this.btnSelectInterface.TabIndex = 22;
            this.btnSelectInterface.Text = "选择接口程序";
            this.btnSelectInterface.UseVisualStyleBackColor = true;
            this.btnSelectInterface.Click += new System.EventHandler(this.btnSelectInterface_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "其他";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(779, 209);
            this.textBox1.TabIndex = 24;
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(16, 229);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 38);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "重新载入";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 461);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTest";
            this.Text = "pdf 显示 测试";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbInterface;
        private System.Windows.Forms.Label lblInterfaceTag;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectInterface;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLoad;
    }
}

