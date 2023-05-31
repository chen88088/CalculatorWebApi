using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 負責將dot加進去的物件
    /// </summary>
    public class DotAddBot : IDotState
    {
        /// <summary>
        /// 加dot的方法
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void DotAction(ValueCube valueCube)
        {
            valueCube.InputTemp.Append(".");
            valueCube.TextBoxTemp.Clear();
            valueCube.TextBoxTemp.Append(valueCube.InputTemp.ToString());

            // set next DotStae
            valueCube.CurrentDotState = new DotClearBot();
        }
    }
}