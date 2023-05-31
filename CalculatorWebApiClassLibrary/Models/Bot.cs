using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 抽象類別--bot--給所有按鈕繼承
    /// </summary>
    public abstract class Bot
    {
        /// <summary>
        /// 自己帶的文字
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 方法--取得自己帶的文字
        /// </summary>
        /// <returns>自帶的文字</returns>
        public string GetText()
        {
            return Text;
        }

        /// <summary>
        /// 抽象方法--按下按鈕後的動作
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        public abstract void DoOperation(ValueCube valueCube);

        /// <summary>
        /// 把資料取出來
        /// </summary>
        /// <param name="valueCube">取值容器</param>
        /// <returns></returns>
        public List<string> TakeOutRespondData(ValueCube valueCube)
        {
            string textbox = valueCube.OutPutForTextBoxRead();
            string progress = valueCube.OutPutForLabelRead();
            string preorder = valueCube.OutPutForLabelPreorderRead();
            string inorder = valueCube.OutPutForLabelInorderRead();
            string postorder = valueCube.OutPutForLabelPostorderRead();

            List<string> list = new List<string>
            {
                textbox,
                progress,
                preorder,
                inorder,
                postorder
            };

            return list;
        }
    }
}