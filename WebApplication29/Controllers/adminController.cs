using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        private readonly ThueXeDBEntities db = new ThueXeDBEntities();



        public ActionResult admin1()
        {
            var xe = db.Xes.ToList();
            return View(xe);
        } 
        public ActionResult Index()
        {
            return View();
        }

        
    }
}