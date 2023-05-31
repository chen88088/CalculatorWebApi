using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理開根號的物件
    /// </summary>
    public class Squrt : FourOperationBot, IInputToPostorder, IOperation
    {
        /// <summary>
        /// Constructor--Squrt
        /// </summary>
        /// <param name="str">攜帶符號</param>
        public Squrt(string str)
        {
            Text = str;
        }

        /// <summary>
        /// 方法--複寫取數字的動作
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void PackageNumber(ValueCube valueCube)
        {
        }

        /// <summary>
        /// 方法--複寫輸入操作符號的動作
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void PackageOperator(ValueCube valueCube)
        {
            if (CheckIfNumberIsNegative(valueCube))
            {
                valueCube.FomulaList.Add((new LeftBrucket("(")));
                valueCube.FomulaList.Add((new Number(valueCube.InputTemp.ToString())));
                valueCube.FomulaList.Add(this);
                valueCube.FomulaList.Add((new Number("0.5")));
                valueCube.FomulaList.Add((new RightBrucket(")")));
            }
        }

        /// <summary>
        /// 方法--檢查開根號值不可為負數
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        /// <returns>bool回傳值</returns>
        public bool CheckIfNumberIsNegative(ValueCube valueCube)
        {
            string check = valueCube.InputTemp.ToString();
            if (decimal.Parse(check) < 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 回傳優先級號碼
        /// </summary>
        /// <returns>Priority</returns>
        public int GetDealPriorityOfBot()
        {
            return 3;
        }

        /// <summary>
        /// 中序轉後序過程的要做的動作
        /// </summary>
        /// <param name="stack">暫存的stack</param>
        /// <param name="list">存放結果的list</param>
        public void ActionToPostorder(Stack<Bot> stack, List<Bot> list)
        {
            while (stack.Count > 0 && this.GetDealPriorityOfBot() <= ((IInputToPostorder)stack.Peek()).GetDealPriorityOfBot())
            {
                list.Add(stack.Pop());
            }
            stack.Push(this);
        }

        /// <summary>
        /// 回報自己是不是左括號
        /// </summary>
        /// <returns></returns>
        public bool IsLeftBrucket()
        {
            return false;
        }

        /// <summary>
        /// Operator "^"的運算操作
        /// </summary>
        /// <param name="x">左子點的值</param>
        /// <param name="y">右子點的值</param>
        /// <returns>運算結果</returns>
        public decimal ExeCalculation (decimal x, decimal y)
        {
            return Convert.ToDecimal(Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y)));
        }
    }
}