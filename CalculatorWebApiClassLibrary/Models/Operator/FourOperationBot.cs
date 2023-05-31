using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 執行 +-*/共同動作的物件
    /// </summary>
    public class FourOperationBot : Bot, IOperatorOrNumber
    {
        /// <summary>
        /// 實作IOperation規範的行為
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation( ValueCube valueCube)
        {
            //把數字打包並加入linkedlist
            PackageNumber(valueCube);

            //把自己(operator)打包並加入linkedlist
            PackageOperator(valueCube);

            //更改label
            ChangeLabelProgress(valueCube);

            //輸入重置 
            ResetInputState(valueCube);
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

        /// <summary>
        /// 方法--把Input清空
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public void ResetInputState(ValueCube valueCube)
        {
            valueCube.InputTemp.Clear();
            valueCube.CurrentDotState = new DotAddBot();

            valueCube.TextBoxTemp.Clear();
            valueCube.TextBoxTemp.Append(valueCube.InputTemp);
        }

        /// <summary>
        /// 方法--把數字打包並加入linledlist
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public virtual void PackageNumber(ValueCube valueCube)
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
        /// 方法--把operator打包並加入linledlist
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public virtual void PackageOperator(ValueCube valueCube)
        {
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
            nodeOne = stack.Pop();
            nodeTwo = stack.Pop();

            temp.RightNode = nodeOne;
            temp.LeftNode = nodeTwo;

            stack.Push(temp);
        }
    }
}