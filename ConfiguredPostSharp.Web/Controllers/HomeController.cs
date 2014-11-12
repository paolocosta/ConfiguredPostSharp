using ConfiguredPostSharp.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConfiguredPostSharp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            new Class1().Test("232",2);
            return View();
        }
    }
}
