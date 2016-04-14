using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//須引入才能用IncomeAndPayRecordModel
using MVCDay1_Homework_MyAccountingBook.Models;

namespace MVCDay1_Homework_MyAccountingBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //此為ChildAction
        [ChildActionOnly]
        public ActionResult IncomeAndPayList()
        {
            List<IncomeAndPayRecordModel> record = new List<IncomeAndPayRecordModel>();

            record.Add(new IncomeAndPayRecordModel
            {
                Category = "支出",
                Money = 300,
                ImplementDate = DateTime.ParseExact("20160101", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
            });

            record.Add(new IncomeAndPayRecordModel
            {
                Category = "支出",
                Money = 16000,
                ImplementDate = DateTime.ParseExact("20160102", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
            });

            record.Add(new IncomeAndPayRecordModel
            {
                Category = "支出",
                Money = 8000,
                ImplementDate = DateTime.ParseExact("20160103", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)
            });

            return View(record);
        }
    }
}