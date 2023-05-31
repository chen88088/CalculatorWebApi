using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理back的物件
    /// </summary>
    public class Back : Bot
    {
        /// <summary>
        /// 按下Back要做的事
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            try
            {
                //檢查下一個欲刪除的是否為dot
                CheckWhetherDeleteTextIsDot(valueCube);
                valueCube.InputTemp.Remove(valueCube.InputTemp.ToString().Length - 1, 1);

                valueCube.TextBoxTemp.Clear();
                valueCube.TextBoxTemp.Append(valueCube.InputTemp);
            }
            catch (ArgumentOutOfRangeException)
            {
                valueCube.InputTemp.Append (valueCube.FomulaList.Last().GetText());
                CheckWhetherDeleteTextIsDot(valueCube);
                valueCube.InputTemp.Remove(valueCube.InputTemp.ToString().Length - 1, 1);

                // 移除前面的串列末項 並更新運算過程
                valueCube.FomulaList.RemoveAt(int.Parse(valueCube.FomulaList.Count().ToString()) - 1);
                ChangeLabelProgress(valueCube);

                // 更改輸出
                valueCube.TextBoxTemp.Clear();
                valueCube.TextBoxTemp.Append(valueCube.InputTemp);
            }
        }

        /// <summary>
        /// 方法--檢查欲刪除的是否為dot
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void CheckWhetherDeleteTextIsDot(ValueCube valueCube)
        {
            //取最後一個字元
            string check = valueCube.InputTemp.ToString().Remove(0, valueCube.InputTemp.ToString().Length - 1);
            if (check == ".")
            {
                valueCube.CurrentDotState = new DotAddBot();
            }
        }

        /// <summary>
        /// 方法--更改labelProgress
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void ChangeLabelProgress(ValueCube valueCube)
        {
            valueCube.LabelProgressTemp.Clear();
            for (int i = 0; i < valueCube.FomulaList.LongCount(); i++)
            {
                valueCube.LabelProgressTemp.Append(" ");
                valueCube.LabelProgressTemp.Append(valueCube.FomulaList[i].Text);
                valueCube.LabelProgressTemp.Append(" ");
            }
        }
    }
}