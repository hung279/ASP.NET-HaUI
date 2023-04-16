using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap6.Controllers
{
    public class hauiController : Controller
    {
        // GET: haui
        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult TuyenSinh()
        {
            return View();
        }
        public ActionResult DaoTao()
        {
            return View();
        }
    }
}