using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCDay1_Homework_MyAccountingBook.Models.ViewModels
{
    public class IncomeAndPayRecordModel
    {
        //必要欄位
        [Required]
        //顯示出來的字
        [DisplayName("種類")]
        public string Category { get; set; }

        [Required]
        //設定數字格式是從個位數開始數每三位加一個逗點
        [DisplayFormat(DataFormatString = "{0:0,0}")]
        [DisplayName("金額")]
        public long Money { get; set; }

        [Required]
        //設定日期格式是西元年(4位數)-月份(2位數)-日(2位數)
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("日期")]
        public DateTime ImplementDate { get; set; }

        [DisplayName("備註")]
        public string Remark { get; set; }
    }
}
