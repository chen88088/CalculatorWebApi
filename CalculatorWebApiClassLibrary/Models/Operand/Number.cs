using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理數字的物件
    /// </summary>
    public class Number : Bot, IInputToPostorder, IOperatorOrNumber
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="str">帶入符號</param>
        public Number(string str)
        {
            Text = str;
        }

        /// <summary>
        /// 方法--複寫Bot的抽象行為DoOperation
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            valueCube.InputTemp.Append(GetText());
            valueCube.TextBoxTemp.Clear();
            valueCube.TextBoxTemp.Append(valueCube.InputTemp);
        }

        /// <summary>
        /// 回傳優先級號碼
        /// </summary>
        /// <returns>Prio</returns>
        public int GetDealPriorityOfBot()
        {
            return -1;
        }

        /// <summary>
        /// 中序轉後序過程的要做的動作
        /// </summary>
        /// <param name="stack">暫存的stack</param>
        /// <param name="list">存放結果的list</param>
        public void ActionToPostorder(Stack<Bot> stack, List<Bot> list)
        {
            list.Add(this);
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
        /// 在建樹過程中的行為
        /// </summary>
        /// <param name="temp">代表之節點</param>
        /// <param name="nodeOne">右子點</param>
        /// <param name="nodeTwo">佐子點</param>
        /// <param name="stack">暫存的stack</param>
        public void OperationInBuildExpressionTree(Node temp, Node nodeOne, Node nodeTwo, Stack<Node> stack)
        {
            stack.Push(temp);
        }
    }
}