using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 規範按下按鈕運作行為的介面
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Operator 的運算操作
        /// </summary>
        /// <param name="x">左子點的值</param>
        /// <param name="y">右子點的值</param>
        /// <returns>運算值</returns>
        decimal ExeCalculation(decimal x, decimal y);
    }
}