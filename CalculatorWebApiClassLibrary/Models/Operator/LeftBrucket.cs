﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 處理左括號行為的物件
    /// </summary>
    public class LeftBrucket : Bot, IInputToPostorder
    {
        /// <summary>
        /// Constructor--LeftBrucket
        /// </summary>
        /// <param name="str">攜帶符號</param>
        public LeftBrucket(string str)
        {
            Text = str;
        }

        /// <summary>
        /// 方法--複寫Bot之DoOperation行為
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public override void DoOperation(ValueCube valueCube)
        {
            //把自己(brocket)打包並加入linkedlist
            valueCube.FomulaList.Add(new LeftBrucket(GetText()));

            //更改label
            ChangeLabelProgress(valueCube);
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
            stack.Push(this);
        }

        /// <summary>
        /// 回報自己是不是左括號
        /// </summary>
        /// <returns></returns>
        public bool IsLeftBrucket()
        {
            return true;
        }
    }
}