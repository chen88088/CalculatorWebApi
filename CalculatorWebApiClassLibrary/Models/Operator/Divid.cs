using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理"/"的物件
    /// </summary>
    public class Divid : FourOperationBot, IInputToPostorder, IOperation
    {
        /// <summary>
        /// Constructor--Divid 
        /// </summary>
        /// <param name="str">攜帶符號</param>
        public Divid(string str)
        {
            Text = str;
        }

        /// <summary>
        /// 方法--把operator (Divid) 打包並加入list
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void PackageOperator(ValueCube valueCube)
        {
            valueCube.FomulaList.Add(this);
        }

        /// <summary>
        /// 回傳優先級號碼
        /// </summary>
        /// <returns>Priority</returns>
        public int GetDealPriorityOfBot()
        {
            return 2;
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
        /// Operator "*"的運算操作
        /// </summary>
        /// <param name="x">左子點的值</param>
        /// <param name="y">右子點的值</param>
        /// <returns>運算結果</returns>
        public decimal ExeCalculation(decimal x, decimal y)
        {
            return (x / y);
        }
    }
}