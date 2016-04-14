using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCDay1_Homework_MyAccountingBook.Models
{
    public class IncomeAndPayRecordModel
    {
        [Required]
        [DisplayName("種類")]
        public string Category { get; set; }

        [Required]
        [DisplayName("金額")]
        public long Money { get; set; }

        [Required]
        [DisplayName("日期")]
        public DateTime ImplementDate { get; set; }

        [DisplayName("備註")]
        public string Remark { get; set; }
    }
}
