using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.interface_class;
using System.Windows.Forms;

namespace Calculator.interface_class
{
    /// <summary>
    /// 負責變號的物件
    /// </summary>
    class SignBot : IOperationBot
    {
        /// <summary>
        /// 按下Sign要做的事
        /// </summary>
        /// <param name="input">輸入值</param>
        /// <param name="valueCube">取值容器</param>
        /// <returns></returns>
        public ValueCube DoOperation(Button button, ValueCube valueCube)
        {
            valueCube.textBoxTemp = (0 - double.Parse(valueCube.textBoxTemp)).ToString();

            return valueCube;
        }
    }
}
