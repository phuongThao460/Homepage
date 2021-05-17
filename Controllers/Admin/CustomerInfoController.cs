using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers.Admin
{
    public class CustomerInfoController : Controller
    {
        // Ví dụ tui thêm dòng này
        // Xong save
        BOOKSHOPEntities db = new BOOKSHOPEntities();
        // GET: CustomerInfo
        public ActionResult Index()
        {
            return View(db.THONGTINKHACHHANGs.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiTKKH/Create
        [HttpPost]
        public ActionResult Create(THONGTINKHACHHANG collection)
        {
            try
            {
                db.THONGTINKHACHHANGs.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index", "CustomerInfo");
            }
            catch
            {
                return View();
            }
        }
        
    }
}