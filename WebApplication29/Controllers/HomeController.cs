using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication29.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace WebApplication28.Controllers
{
    public class HomeController : Controller
    {
        private readonly ThueXeDBEntities db = new ThueXeDBEntities();



        public ActionResult TrangChu()
        {
            var xe = db.Xes.ToList();
            return View(xe);
        }
        public ActionResult TrangChu1()
        {
            var xe = db.Xes.ToList();
            return View(xe);
        }


        // Giữ Index để route mặc định không bị lỗi
        public ActionResult Index()  
        {
            return RedirectToAction("TrangChu");
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
        public ActionResult ChiTiet(int id)
        {
            var xe = db.Xes.ToList();
            return View(xe);
        }
        public ActionResult Thanhtoan(int id)
        {
            var xe = db.Xes.ToList();
            return View(xe);
        }
        public ActionResult admin(int? id)
        {
            var xe = db.Xes.ToList();
            return View(xe); // hoặc xử lý theo id nếu cần
        }
    }
}