using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理 ". " 的物件
    /// </summary>
    public class Dot : Bot
    {
        /// <summary>
        /// Constructor--Dot
        /// </summary>
        /// <param name="str">攜帶符號</param>
        public Dot(string str)
        {
            Text = str;
        }

        /// <summary>
        /// 按下  " . " 要做的事
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            valueCube.DotAction(); 
        }
    }
}