using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Calculator;

namespace Calculator
{
    /// <summary>
    /// 主要行為
    /// </summary>
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
        /// 發送HTTP REQREST的物件
        /// </summary>
        private HttpClient HttpClient ;

        /// <summary>
        /// 回傳值編碼
        /// </summary>
        public enum RespondSignature
        {
            textBox = 0,
            progress = 1,
            preorder = 2,
            inorder = 3,
            postorder = 4,
        }

        /// <summary>
        /// 計算機代碼--夾在cookie中送出與回傳
        /// </summary>
        private string CalculatorId { get; set; } = string.Empty;

        /// <summary>
        /// 唯一的按鈕
        /// </summary>
        /// <param name="sender">觸發事件按鈕輸入</param>
        /// <param name="e">參數</param>
        private void Bnt0_ClickAsync(object sender, EventArgs e)
        {
            // 加入calculatorid 並建立httpclient
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.Add(new Uri("https://localhost:44396/api/Calculators/Cookie/CalculatorId"), new Cookie("CalculatorSignature", CalculatorId));
            HttpClientHandler handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            HttpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:44396/api/Calculators/Cookie/CalculatorId")
            };

            // 發送Request並接收回傳內容
            HttpResponseMessage responseToGetCalculatorId = HttpClient.GetAsync("https://localhost:44396/api/Calculators/Cookie/CalculatorId").Result;
            string respondId = responseToGetCalculatorId.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            // 修剪字串
            char[] removeChar = { '[', ']', '/' };
            string newRespondstringId = respondId.Trim(removeChar).Replace(@"""", "");

            // 取得機算機代碼
            LabelCalculatorId.Text = newRespondstringId;
            CalculatorId = newRespondstringId;

            // 前端(按鈕)輸入(url)
            Button btn = (Button)sender;
            string urlLink = (string)btn.Tag;

            // 建立新cookie & httpclient
            cookieContainer = new CookieContainer();
            cookieContainer.Add(new Uri(urlLink), new Cookie("CalculatorSignature", CalculatorId));
            handler = new HttpClientHandler() { CookieContainer = cookieContainer };
            HttpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(urlLink)
            };

            // 發出 put Request 並取得結果
            HttpResponseMessage response = HttpClient.PutAsync(urlLink, null).Result;

            //將回應結果內容取出並轉為 string
            string respondString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            // 修剪字串
            string newRespondstring = respondString.Trim(removeChar).Replace(@"""", "");
            string[] newRespondStringArray = newRespondstring.Split(',');
            List<string> list = newRespondStringArray.ToList();

            // 填上去
            FillWithLabels(list);
        }

        /// <summary>
        /// 方法-- 把回傳內容填入各label
        /// </summary>
        /// <param name="list">回傳內容</param>
        public void FillWithLabels(List<string> list)
        {
            TxtInputResault.Text = list[(int)RespondSignature.textBox];
            LabelShowOp.Text = list[(int)RespondSignature.progress];
            LabelPreorder.Text = list[(int)RespondSignature.preorder];
            LabelInorder.Text = list[(int)RespondSignature.inorder];
            LabelPostorder.Text = list[(int)RespondSignature.postorder];
        }
    }
}