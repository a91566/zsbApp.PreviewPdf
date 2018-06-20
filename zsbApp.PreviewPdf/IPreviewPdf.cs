/*
 * 2018年5月4日 15:44:30 郑少宝
 */

namespace zsbApp.PreviewPdf
{
    public interface IPreviewPdf
    {
        /// <summary>
        /// 标识
        /// </summary>
        string Tag { get; }

        /// <summary>
        /// 获取控件，用于添加展示
        /// </summary>
        /// <returns></returns>
        System.Windows.Forms.Control GetControl();

        /// <summary>
        /// 载入 pdf 文件
        /// </summary>
        /// <param name="fileName">pdf 绝对路径</param>
        /// <returns></returns>
        string LoadFile(string fileName);

        /// <summary>
        /// 设置缩放（0-100）
        /// </summary>
        /// <param name="zoom"></param>
        void SetZoom(int zoom);


    }
}
