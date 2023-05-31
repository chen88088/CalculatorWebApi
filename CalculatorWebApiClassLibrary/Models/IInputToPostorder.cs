using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 介面-- 輸入轉後續
    /// </summary>
    public interface IInputToPostorder
    {
        /// <summary>
        /// 中序轉後序過程的要做的動作
        /// </summary>
        /// <param name="stack">暫存的stack</param>
        /// <param name="list">存放結果的list</param>
        void ActionToPostorder(Stack<Bot> stack, List<Bot> list);

        /// <summary>
        /// 回傳優先級號碼
        /// </summary>
        /// <returns>Prio</returns>
        int GetDealPriorityOfBot();

        /// <summary>
        /// 回報自己是不是左括號
        /// </summary>
        /// <returns></returns>
        bool IsLeftBrucket();
    }
}