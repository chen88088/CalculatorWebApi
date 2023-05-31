using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi.Models;

namespace Webapi.Controllers
{
    /// <summary>
    /// 計算機後台的controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorsController : ControllerBase
    {
        /// <summary>
        /// 計算機集合(字典)
        /// </summary>
        private Dictionary<string, ValueCube> CalculatorDictionary;

        /// <summary>
        /// 依賴注入(DI)(建構子)
        /// </summary>
        /// <param name="calculatorDictionary">後台的計算機總字典</param>
        public CalculatorsController(Dictionary<string, ValueCube> calculatorDictionary)
        {
            CalculatorDictionary = calculatorDictionary;
        }

        /// <summary>
        /// Check or Creat CalculatorId
        /// </summary>
        /// <returns>r計算機代號</returns>
        // Get: https://localhost:44396/api/Calculators/Cookie/CalculatorId
        [HttpGet("Cookie/CalculatorId")]
        public List<string> GetCalculatorId()
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            List<string> IdList = new List<string>();
            if (!CalculatorDictionary.Keys.Contains(calculatorId))
            {
                // 產生計算機代碼
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var CalculatorName = new char[8];
                var random = new Random();
                string newCalculatorId = string.Empty;

                // 避免代碼重複
                do
                {
                    for (int i = 0; i < CalculatorName.Length; i++)
                    {
                        CalculatorName[i] = characters[random.Next(characters.Length)];
                    }

                    newCalculatorId = new string(CalculatorName);
                }
                while (CalculatorDictionary.Keys.Contains(newCalculatorId));

                CalculatorDictionary.Add(newCalculatorId, new ValueCube());
                IdList.Add(newCalculatorId);
                return IdList;
            }
            else
            {
                IdList.Add(calculatorId);
                return IdList;
            }
        }

        /// <summary>
        /// DealingWithNumber
        /// </summary>
        /// <param name="id">傳入之數字</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Number/{id}
        [HttpPut("Number/{id}")]
        public List<string> PutNumber(string id)
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];
            
            Bot bot = new Number(id);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithPlus
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Operator/Plus
        [HttpPut("Operator/Plus")]
        public List<string> PutPlus(string operat = "+")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Plus(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithMinus
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Operator/minus
        [HttpPut("Operator/Minus")]
        public List<string> PutMinus(string operat = "-")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Minus(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithMulti
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Operator/multi
        [HttpPut("Operator/Multi")]
        public List<string> PutMulti(string operat = "*")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Multi(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithDivid
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Operator/Divid
        [HttpPut("Operator/Divid")]
        public List<string> PutDivid(string operat = "/")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Divid(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithSqurt
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Operator/Squrt
        [HttpPut("Operator/Squrt")]
        public List<string> PutSqurt(string operat = "^")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Squrt(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithLeftBrucket
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Brucket/LeftBrucket
        [HttpPut("Brucket/LeftBrucket")]
        public List<string> PutLeftBrucket(string operat = "(")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new LeftBrucket(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithRightBrucket
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Brucket/RightBrucket
        [HttpPut("Brucket/RightBrucket")]
        public List<string> PutRightBrucket(string operat = ")")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new RightBrucket(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithEqual
        /// </summary>
        /// <param name="operat">運算符</param>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/ExeResult/Equal
        [HttpPut("ExeResult/Equal")]
        public List<string> PutEqual(string operat = "=")
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Equal(operat);
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithDot
        /// </summary>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Normal/Dot
        [HttpPut("Normal/Dot")]
        public List<string> PutDot()
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Dot(".");
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithBack
        /// </summary>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Normal/Back
        [HttpPut("Normal/Back")]
        public List<string> PutBack()
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Back();
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithSign
        /// </summary>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Normal/Sign
        [HttpPut("Normal/Sign")]
        public List<string> PutSign()
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Sign();
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithClear
        /// </summary>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Normal/Clear
        [HttpPut("Normal/Clear")]
        public List<string> PutClear()
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new Clear();
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }

        /// <summary>
        /// DealingWithClearError
        /// </summary>
        /// <returns>處理結果</returns>
        // Put: https://localhost:44396/api/Calculators/Normal/ClearError
        [HttpPut("Normal/ClearError")]
        public List<string> PutClearError()
        {
            var calculatorId = Request.Cookies["CalculatorSignature"];

            Bot bot = new ClearError();
            bot.DoOperation(CalculatorDictionary[calculatorId]);
            List<string> dataList = bot.TakeOutRespondData(CalculatorDictionary[calculatorId]);
            return dataList;
        }
    }
}