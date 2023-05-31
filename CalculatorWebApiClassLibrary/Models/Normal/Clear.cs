using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 清除的物件
    /// </summary>
    public class Clear : Bot
    {
        /// <summary>
        /// 按下C後要做的事
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            valueCube.CurrentDotState = new DotAddBot();
            valueCube.FomulaList.Clear();
            valueCube.PrepareBox.Clear();
            valueCube.InputTemp.Clear();
            valueCube.TextBoxTemp.Clear();
            valueCube.LabelProgressTemp.Clear();
            valueCube.LabelPreorderTemp.Clear();
            valueCube.LabelInorderTemp.Clear();
            valueCube.LabelPostorderTemp.Clear();
        }
    }
}