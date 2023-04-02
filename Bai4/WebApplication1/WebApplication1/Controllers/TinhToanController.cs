using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TinhToanController : Controller
    {
        // GET: TinhToan
        public ActionResult Index()
        {
            var a = 0.0;
            var b = 0.0;
            a = double.Parse(Request["number_a"]);
            b = double.Parse(Request["number_b"]);
            string calOperator = Request["phep_tinh"];

            switch (calOperator)
            {
                case "+":
                    ViewBag.kq = a + b;
                    break;
                case "-":
                    ViewBag.kq = a - b;
                    break;
                case "*":
                    ViewBag.kq = a * b;
                    break;
                case "/":
                    ViewBag.kq = a / b;
                    break;
                default:
                    break;
            }

            return View();
        }
    }
}