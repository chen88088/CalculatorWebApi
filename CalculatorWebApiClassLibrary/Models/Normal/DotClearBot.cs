using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理重複點情況的物件
    /// </summary>
    public class DotClearBot : IDotState
    {
        /// <summary>
        /// dot防呆方法
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void DotAction(ValueCube valueCube)
        {            
            valueCube.CurrentDotState = new DotClearBot();
        }
    }
}