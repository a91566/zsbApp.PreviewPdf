/*
 * 2018年5月4日 16:16:29 郑少宝
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zsbApp.PreviewPdf;

namespace zsbApp
{
    public class PreviewPdfByAdobeCOM : BasePreviewPdf, IPreviewPdf, IDisposable
    {

        AxAcroPDFLib.AxAcroPDF axAcroPDF1;

        /// <summary>
        /// 本接口的标识
        /// </summary>
        string IPreviewPdf.Tag
        {
            get { return "ByAdobeCOM"; }
        }

        /// <summary>
        /// 获取控件，用于添加展示
        /// </summary>
        /// <returns></returns>
        System.Windows.Forms.Control IPreviewPdf.GetControl()
        {
            if (this.axAcroPDF1 == null)
            {
                this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            }
            return this.axAcroPDF1;
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
                this.axAcroPDF1.LoadFile(fileName);
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
            this.axAcroPDF1.setZoom(zoom);
        }

        public void Dispose()
        {
            this.axAcroPDF1 = null;
        }
    }
}
