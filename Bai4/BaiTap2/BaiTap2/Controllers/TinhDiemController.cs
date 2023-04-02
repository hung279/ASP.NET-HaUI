using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class TinhDiemController : Controller
    {
        // GET: TinhDiem
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TinhDiem()
        {
            string name = Request["name"];
            string familyStandard = Request["familyStandard"];
            string area = Request["area"];
            double mathScore = double.Parse(Request["math"]);
            double physicsScore = double.Parse(Request["physics"]);
            double chemistryScore = double.Parse(Request["chemistry"]);

            ViewBag.name = name;
            double areaScore = 0;
            double prioriry = 0;
            switch(area)
            {
                case "A":
                    areaScore = 1;
                    break;
                case "B":
                    areaScore = 2;
                    break;
                case "C":
                    areaScore = 3;
                    break;
                default:
                    break;
            }

            if(!String.IsNullOrEmpty(familyStandard))
            {
                prioriry = 1;
            }

            double result = mathScore + physicsScore + chemistryScore + areaScore + prioriry;
            ViewBag.score = result;
            if(result >= 20)
            {
                ViewBag.result = "Đỗ đại học";
            }
            else if (result >= 15)
            {
                ViewBag.result = "Đỗ cao đẳng";
            }
            else if (result >= 10)
            {
                ViewBag.result = "Đỗ trung cấp";
            }
            else
            {
                ViewBag.result = "Thi trượt";
            }

            return View();
        }
    }
}