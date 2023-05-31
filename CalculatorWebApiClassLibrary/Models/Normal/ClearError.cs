using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理 CE 的物件
    /// </summary>
    public class ClearError : Bot
    {
        /// <summary>
        /// 按下CE要做的事--清空當下輸入
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            valueCube.InputTemp.Clear();
            valueCube.CurrentDotState = new DotAddBot();
            valueCube.TextBoxTemp.Clear();
            valueCube.TextBoxTemp.Append(valueCube.InputTemp);
        }
    }
}