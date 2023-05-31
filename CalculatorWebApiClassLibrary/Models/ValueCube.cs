using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Models
{
    /// <summary>
    /// 所有運算相關的取值物件
    /// </summary>
    public class ValueCube : IOutPut
    {
        /// <summary>
        /// 屬性: DotState
        /// </summary>
        private IDotState DotState {get; set; } 

        /// <summary>
        /// 用來改變dotstate屬性的屬性
        /// </summary>
        public IDotState CurrentDotState
        {
            get {return DotState; }
            set {DotState = value;  }
        }

        /// <summary>
        /// List used to store operator and operand
        /// </summary>
        public List<Bot> FomulaList { get; set; }

        /// <summary>
        /// 輸入值暫存器
        /// </summary>
        public StringBuilder InputTemp {get; set; }

        /// <summary>
        /// prepare to be dealtwith
        /// </summary>
        public StringBuilder PrepareBox { get; set; }

        /// <summary>
        /// textBox取值暫存器
        /// </summary>
        public StringBuilder TextBoxTemp {get; set; }

        /// <summary>
        /// label取值暫存器
        /// </summary>
        public StringBuilder LabelProgressTemp {get; set; }

        /// <summary>
        /// LabelPreorder取值暫存器
        /// </summary>
        public StringBuilder LabelPreorderTemp { get; set; }

        /// <summary>
        /// LabelInorder取值暫存器
        /// </summary>
        public StringBuilder LabelInorderTemp { get; set; }

        /// <summary>
        /// LabelPostorder取值暫存器
        /// </summary>
        public StringBuilder LabelPostorderTemp { get; set; }

        /// <summary>
        /// ValueCube 建構子
        /// </summary>
        public ValueCube()
        {
            DotState = new DotAddBot();
            FomulaList = new List<Bot>();
            InputTemp = new StringBuilder();
            PrepareBox = new StringBuilder();
            TextBoxTemp = new StringBuilder();
            LabelProgressTemp = new StringBuilder();
            LabelPreorderTemp = new StringBuilder();
            LabelPostorderTemp = new StringBuilder();
            LabelInorderTemp = new StringBuilder();
        }

        /// <summary>
        /// 執行DOT狀態行為
        /// </summary>
        public void DotAction()
        {
            DotState.DotAction(this);
        }

        /// <summary>
        /// 實作"輸出介面"的"輸出textbox"行為
        /// </summary>
        /// <returns></returns>
        public string OutPutForTextBoxRead()
        {
            return TextBoxTemp.ToString();
        }

        /// <summary>
        /// 實作"輸出介面"的"輸出label"行為
        /// </summary>
        /// <returns></returns>
        public string OutPutForLabelRead()
        {
            return LabelProgressTemp.ToString();
        }

        /// <summary>
        /// 實作"輸出介面"的"輸出LabelPreorder的行為
        /// </summary>
        /// <returns>輸出值</returns>
        public string OutPutForLabelPreorderRead()
        {
            return LabelPreorderTemp.ToString();
        }

        /// <summary>
        /// 實作"輸出介面"的"輸出LabelPoseorder的行為
        /// </summary>
        /// <returns>輸出值</returns>
        public string OutPutForLabelPostorderRead()
        {
            return LabelPostorderTemp.ToString();
        }

        /// <summary>
        /// 實作"輸出介面"的"輸出LabelInorder的行為
        /// </summary>
        /// <returns>輸出值</returns>
        public string OutPutForLabelInorderRead()
        {
            return LabelInorderTemp.ToString();
        }
    }
}