using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 類別--表達樹
    /// </summary>
    public class ExpressionTree
    {
        /// <summary>
        /// 前序追蹤結果
        /// </summary>
        public StringBuilder PreorderPath{ get; set; }

        /// <summary>
        /// 中序追蹤結果
        /// </summary>
        public StringBuilder InorderPath{ get; set; }

        /// <summary>
        /// 後序追蹤結果
        /// </summary>
        public StringBuilder PostorderPath{ get; set; }
    
        /// <summary>
        /// ExpressionTree 建構子
        /// </summary>
        public ExpressionTree()
        {
            PreorderPath = new StringBuilder();
            InorderPath = new StringBuilder();
            PostorderPath = new StringBuilder();
        }

        /// <summary>
        /// 方法-- 用後序建構expression tree
        /// </summary>
        /// <param name="postfix">後序輸入</param>
        /// <returns>代表整棵樹的根節點</returns>
        public Node MakeExpressionTree(List<Bot> postfix)
        {
            Stack<Node> stack = new Stack<Node>();
            Node nodeOne = null;
            Node nodeTwo = null;
            Node temp = null;

            for (int i = 0; i < postfix.LongCount(); i++)
            {
                temp = new Node(postfix[i]);

                IOperatorOrNumber currentBot = (IOperatorOrNumber)postfix[i];
                currentBot.OperationInBuildExpressionTree(temp, nodeOne, nodeTwo, stack);
            }
            temp = stack.Pop();
            return temp;
        }

        /// <summary>
        /// Utility function to check if a given node is a leaf node
        /// </summary>
        /// <param name="node">節點</param>
        /// <returns>0</returns>
        public bool IsLeaf(Node node)
        {
            return node.LeftNode == null && node.RightNode == null;
        }

        /// <summary>
        /// Recursive function to evaluate a binary expression tree
        /// </summary>
        /// <param name="root">樹根</param>
        /// <returns>回傳值</returns>
        public decimal Evaluate(Node root)
        {
            // base case: invalid input
            if (root == null)
            {
                return 0;
            }

            // the leaves of a binary expression tree are operands
            if (IsLeaf(root))
            {
                return decimal.Parse(root.Data.GetText());
            }

            // recursively evaluate the left and right subtree
            decimal x = Evaluate(root.LeftNode);
            decimal y = Evaluate(root.RightNode);

            IOperation operation = (IOperation)root.Data;
            // apply the operator at the root to the values obtained in the previous step
            return operation.ExeCalculation(x, y);
        }

        /// <summary>
        /// 中序追蹤
        /// </summary>
        /// <param name="root">根節點</param>
        public void Inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Inorder(root.LeftNode);

            InorderPath.Append(" ");
            InorderPath.Append(root.Data.GetText());
            InorderPath.Append(" ");

            Inorder(root.RightNode);
        }

        /// <summary>
        /// 前序追蹤
        /// </summary>
        /// <param name="root">根節點</param>
        public void Preorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            PreorderPath.Append(" ");
            PreorderPath.Append(root.Data.GetText());
            PreorderPath.Append(" ");

            Preorder(root.LeftNode);

            Preorder(root.RightNode);
        }

        /// <summary>
        ///  後序追蹤
        /// </summary>
        /// <param name="root">根節點</param>
        public void Postorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Postorder(root.LeftNode);

            Postorder(root.RightNode);

            PostorderPath.Append(" ");
            PostorderPath.Append(root.Data.GetText());
            PostorderPath.Append(" ");
        }
    }
}