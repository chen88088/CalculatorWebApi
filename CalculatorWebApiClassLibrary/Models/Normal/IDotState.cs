using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理dot 行為的interface
    /// </summary>
    public interface IDotState
    {
        /// <summary>
        /// dot狀態
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        void DotAction (ValueCube valueCube);
    }
}