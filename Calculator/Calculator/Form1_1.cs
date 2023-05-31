using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;
using Calculator.interface_class;

namespace Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 起步
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取值容器
        /// </summary>
        public static ValueCube valueCube = new ValueCube();

        /// <summary>
        /// 唯一的按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bnt0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            IOperationBot bot = (IOperationBot)btn.Tag;

            valueCube = bot.DoOperation(btn, valueCube);

            TxtInputResault.Text = valueCube.textBoxTemp;
            LabelShowOp.Text = valueCube.labelTemp;

        }

        /// <summary>
        /// 執行過程
        /// </summary>
        /// <param name="sender">傳入的東西</param>
        /// <param name="e">事件觸發</param>
        private void LabelShowOp_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 輸入欄位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">事件觸發</param>
        private void TxtInputResault_TextChanged(object sender, EventArgs e)
        {

        }

    }

        
    
}
