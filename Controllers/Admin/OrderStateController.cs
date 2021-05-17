using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers
{
    public class OrderStateController : Controller
    {
        BOOKSHOPEntities db = new BOOKSHOPEntities();
        // GET: OrderState
        public RedirectToRouteResult Index()
        {
            return RedirectToRoute(new { controller = "OrderState", action = "DanhSachTrangThai" });
        }
        public ActionResult DanhSachTrangThai()
        {
            return View(db.TRANGTHAIDONHANGs.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Create(TRANGTHAIDONHANG state)
        {
            db.TRANGTHAIDONHANGs.Add(state);
            db.SaveChanges();
            return RedirectToRoute(new { controller = "OrderState", action = "DanhSachTrangThai" });
        }
        public ActionResult Details(int id)
        {
            return View(db.TRANGTHAIDONHANGs.Where(tt => tt.ID_TRANGTHAI == id).FirstOrDefault());
        }
        // GET: OrderState/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(db.TRANGTHAIDONHANGs.Where(s => s.ID_TRANGTHAI == id).FirstOrDefault());
        }

        // POST: OrderState/Edit/5
        [HttpPost]
        public ActionResult Edit(TRANGTHAIDONHANG tt)
        {
            int id = int.Parse(Url.RequestContext.RouteData.Values["id"].ToString());
            try
            {
                TRANGTHAIDONHANG d = db.TRANGTHAIDONHANGs.Where(s => s.ID_TRANGTHAI == id).FirstOrDefault();
                d.TEN_TRANGTHAI = tt.TEN_TRANGTHAI;
                db.SaveChanges();
                return RedirectToAction("DanhSachTrangThai", "OrderState");
            }
            catch
            {
                return View();
            }
        }
    }
}