using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_SkillTree.Models
{
    /// <summary>
    /// 類別
    /// </summary>
    public enum MoneyType
    {
        支出,
        收入
    }

    public class Homework
    {
        public MoneyType HomeMoneyType { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string memo { get; set; }
    }
}