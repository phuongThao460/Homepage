using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers
{
    public class ChiTietSanPhamController : Controller
    {
        BOOKSHOPEntities database = new BOOKSHOPEntities();
        // GET: ChiTietSanPham
        public ActionResult Index()
        {
            
            return View(database.SACHes.ToList());
        }
        public ActionResult Details(int id)
        {
            return View(database.SACHes.Where(s => s.ID_SACH == id).FirstOrDefault());
        }
    }
}