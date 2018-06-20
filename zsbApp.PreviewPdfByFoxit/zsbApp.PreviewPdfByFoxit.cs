/*
 * 2018年5月4日 16:09:42 郑少宝
 */
using System;
using zsbApp.PreviewPdf;

namespace zsbApp
{
    public class PreviewPdfByFoxit : BasePreviewPdf, IPreviewPdf, IDisposable
    {

        Foxit.PDF.Viewer.PdfViewer pdfViewer1;

        /// <summary>
        /// 本接口的标识
        /// </summary>
        string IPreviewPdf.Tag
        {
            get { return "ByFoxit"; }
        }

        /// <summary>
        /// 获取控件，用于添加展示
        /// </summary>
        /// <returns></returns>
        System.Windows.Forms.Control IPreviewPdf.GetControl()
        {
            if (this.pdfViewer1 == null)
            {
                this.pdfViewer1 = new Foxit.PDF.Viewer.PdfViewer();
                this.pdfViewer1.ShowNavigationPanel = false;
            }
            return this.pdfViewer1;
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
                this.pdfViewer1.Open(fileName);
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
            this.pdfViewer1 = null;
        }
    }
}
