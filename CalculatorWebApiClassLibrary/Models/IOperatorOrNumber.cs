using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 介面-- 區分operator or operand
    /// </summary>
    public interface IOperatorOrNumber
    {
        /// <summary>
        /// 在建樹過程中的行為
        /// </summary>
        /// <param name="temp">代表節點</param>
        /// <param name="nodeOne">右子點</param>
        /// <param name="nodeTwo">左子點</param>
        /// <param name="stack">暫存的stack</param>
        void OperationInBuildExpressionTree(Node temp, Node nodeOne, Node nodeTwo, Stack<Node> stack);
    }
}