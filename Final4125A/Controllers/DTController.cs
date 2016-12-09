using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final4125A.Controllers
{
    public class DTController : Controller
    {
        // GET: DT
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Today()
        {
            ViewBag.Message = System.Web.HttpUtility.HtmlEncode("Right now is " + DateTime.Now.ToString());
            return View();
            //return View("Right now is " + DateTime.Now.ToString());
        }
    }
}