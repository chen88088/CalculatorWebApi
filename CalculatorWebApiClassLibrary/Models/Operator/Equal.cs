using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理 = 的物件 (測試用)
    /// </summary>
    public class Equal : Bot
    {
        /// <summary>
        /// Constructor--Equal
        /// </summary>
        /// <param name="str">攜帶符號</param>
        public Equal(string str)
        {
            Text = str;
        }

        /// <summary>
        /// 按下 = 後做的動作
        /// </summary>
        /// <param name="valueCube">取值容器1</param>
        public override void DoOperation(ValueCube valueCube)
        {
            //把當前數字加進去
            PackageNumber(ref valueCube);

            //把輸入的串列用stack轉成posifix
            List<Bot> postorderString = TurnInfixToPostfix(valueCube.FomulaList);

            //用postfix建成expression tree
            ExpressionTree expressionTree = new ExpressionTree();
            Node root = expressionTree.MakeExpressionTree(postorderString);

            //對tree 做 inorder traversal
            expressionTree.Inorder(root);

            //對tree 做 preorder traversal
            expressionTree.Preorder(root);

            //對tree 做 postorder traversal
            expressionTree.Postorder(root);

            //把前中後序路徑填上去
            valueCube.LabelPreorderTemp = expressionTree.PreorderPath;
            valueCube.LabelInorderTemp = expressionTree.InorderPath;
            valueCube.LabelPostorderTemp = expressionTree.PostorderPath;

            //對expression tree 做運算
            valueCube.TextBoxTemp.Clear();
            valueCube.TextBoxTemp.Append(expressionTree.Evaluate(root));

            //更改label
            ChangeLabelProgress(ref valueCube);
            valueCube.LabelProgressTemp.Append(GetText());
        }

        /// <summary>
        /// 方法--更改labelProgress
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void ChangeLabelProgress(ref ValueCube valueCube)
        {
            valueCube.LabelProgressTemp.Clear();
            for (int i = 0; i < valueCube.FomulaList.LongCount(); i++)
            {
                valueCube.LabelProgressTemp.Append(" ");
                valueCube.LabelProgressTemp.Append(valueCube.FomulaList[i].Text);
                valueCube.LabelProgressTemp.Append(" ");
            }
        }

        /// <summary>
        /// 方法--把數字打包並加入linledlist
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void PackageNumber(ref ValueCube valueCube)
        {
            if (valueCube.InputTemp.ToString() == string.Empty)
            {
            }
            else
            {
                valueCube.FomulaList.Add(new Number(valueCube.InputTemp.ToString()));
            }
        }

        /// <summary>
        /// 方法--把串列組在一起
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void PrepareString(ref ValueCube valueCube)
        {
            for (int i = 0; i < valueCube.FomulaList.LongCount(); i++)
            {
                valueCube.PrepareBox.Append(valueCube.FomulaList[i].ToString());
            }
        }

        /// <summary>
        /// 方法--Infix To Postfix
        /// </summary>
        /// <param name="botList">expession 表達式</param>
        /// <returns>處理結果</returns>
        public List<Bot> TurnInfixToPostfix(List<Bot> botList)
        {
            List<Bot> resultList = new List<Bot>();
            Stack<Bot> stack = new Stack<Bot>();
            for (int i = 0; i < botList.Count(); ++i)
            {
                IInputToPostorder currentBot = (IInputToPostorder)botList[i];
                currentBot.ActionToPostorder(stack, resultList);
            }
            // pop all the operators from the stack
            while (stack.Count > 0) 
            {
                resultList.Add(stack.Pop());
            }
            return resultList;
        }
    }
}