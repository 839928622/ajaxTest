using SavaMutiData.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SavaMutiData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddInfo(string MainId, string dataJson) // 第一个参数用户接受主表id 第二个参数用于将多条数据转化
        {
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Fee>>(dataJson);

            foreach (var item in data)
            {
               
            }
            Fee a = new Fee
            {
                Money = "djj",
                Month = "j"
            };
            return Json(a,JsonRequestBehavior.AllowGet);
        }
       
    }
}