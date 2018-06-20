/*
 * 2018年5月4日 16:09:42 郑少宝
 */
using System;
using zsbApp.PreviewPdf;

namespace zsbApp
{
    public class PreviewPdfByWebBrowser : BasePreviewPdf, IPreviewPdf, IDisposable
    {

        System.Windows.Forms.WebBrowser webBrowser1;

        /// <summary>
        /// 本接口的标识
        /// </summary>
        string IPreviewPdf.Tag
        {
            get { return "WebBrowser"; }
        }

        /// <summary>
        /// 获取控件，用于添加展示
        /// </summary>
        /// <returns></returns>
        System.Windows.Forms.Control IPreviewPdf.GetControl()
        {
            if (this.webBrowser1 == null)
            {
                this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            }
            return this.webBrowser1;
        }

        /// <summary>
        /// 载入 pdf 文件
        /// </summary>
        /// <param name="fileName">pdf 绝对路径</param>
        /// <returns></returns>
        string IPreviewPdf.LoadFile(string fileName)
        {
            try
            {
                this.webBrowser1.Navigate(@"file:///" + fileName);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 设置缩放（0-100）
        /// </summary>
        /// <param name="zoom"></param>
        void IPreviewPdf.SetZoom(int zoom)
        {
 
        }

        public void Dispose()
        {
            this.webBrowser1 = null;
        }
    }
}
