using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 規範輸出前端之行為介面
    /// </summary>
    public interface IOutPut
    {
        /// <summary>
        /// 輸出textbox的行為
        /// </summary>
        /// <returns>輸出值</returns>
        string OutPutForTextBoxRead();

        /// <summary>
        /// 輸出LabelPreorder的行為
        /// </summary>
        /// <returns>輸出值</returns>
        string OutPutForLabelPreorderRead();

        /// <summary>
        /// 輸出LabelPoseorder的行為
        /// </summary>
        /// <returns>輸出值</returns>
        string OutPutForLabelPostorderRead();

        /// <summary>
        /// 輸出LabelInorder的行為
        /// </summary>
        /// <returns>輸出值</returns>
        string OutPutForLabelInorderRead();

        /// <summary>
        /// 輸出label的行為
        /// </summary>
        /// <returns>輸出值</returns>
        string OutPutForLabelRead();
    }
}