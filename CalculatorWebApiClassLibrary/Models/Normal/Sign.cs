using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 負責變號的物件
    /// </summary>
    public class Sign : Bot
    {
        /// <summary>
        /// 按下Sign要做的事
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            string value = valueCube.InputTemp.ToString();
            valueCube.InputTemp.Clear();
            valueCube.InputTemp.Append(0 - decimal.Parse(value));
            valueCube.TextBoxTemp.Clear();
            valueCube.TextBoxTemp.Append(valueCube.InputTemp);
        }
    }
}