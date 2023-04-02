using BaiTap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TinhLuong(NhanVien nv)
        {
            return View("TinhLuong", nv);
        }
    }
}