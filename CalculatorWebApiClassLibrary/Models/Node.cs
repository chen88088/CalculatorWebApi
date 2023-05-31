using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 樹的節點
    /// </summary>
    public class Node
    {
        /// <summary>
        /// 節點文字
        /// </summary>
        public Bot Data { get; set; }

        /// <summary>
        /// 左子點
        /// </summary>
        public Node LeftNode { get; set; }

        /// <summary>
        /// 右子點
        /// </summary>
        public Node RightNode { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="bot">帶入之按鈕物件</param>
        public Node(Bot bot)
        {
            Data = bot;

            LeftNode = null;
            RightNode = null;
        }
    }
}