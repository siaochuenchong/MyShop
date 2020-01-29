using MyShop.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MyShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public class ABC
        {
            public int Total { get; set; } = 155;
            public List<SubList> Subs { get; set; } = new List<SubList>()
            {
                new SubList()
                {
                     id = 1,
                     Name ="Saya"
                },
                new SubList()
                {
                    id = 2,
                    Name = "AKU",
                }
            };
            
        }
        public class SubList
        {
            public int id { get; set; }
            public String Name { get; set; }
        }
        public ActionResult Index()
        {
            ABC model = new ABC();

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(model);

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
    }
}