using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers
{
    public class OrderController : Controller
    {
        BOOKSHOPEntities db = new BOOKSHOPEntities();
        // GET: Order
        public RedirectToRouteResult Index()
        {
            return RedirectToRoute(new { controller = "Order", action = "DanhSachDonHang" });
        }
        public ActionResult DanhSachDonHang()
        {
            return View(db.DONHANGs.ToList());
        }
        public ActionResult Create()
        {
            DONHANG p = new DONHANG();
            ViewBag.ID_TTKH = new SelectList(db.THONGTINKHACHHANGs, "ID_TTKH", "TEN_KHACHHANG");
            ViewBag.ID_TRANGTHAI = new SelectList(db.TRANGTHAIDONHANGs, "ID_TRANGTHAI", "TEN_TRANGTHAI");

            return View(p);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DONHANG dh)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    db.DONHANGs.Add(dh);
                    db.SaveChanges();
                    return RedirectToAction("DanhSachDonHang");
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            ViewBag.ID_TTKH = new SelectList(db.THONGTINKHACHHANGs, "ID_TTKH", "TEN_KHACHHANG");
            ViewBag.ID_TRANGTHAI = new SelectList(db.TRANGTHAIDONHANGs, "ID_TRANGTHAI", "TEN_TRANGTHAI");
            return View(dh);
        }
        public ActionResult Details()
        {
            int id = int.Parse(Url.RequestContext.RouteData.Values["id"].ToString());
            var select = db.DONHANGs.Where(s => s.ID_DONHANG == id).FirstOrDefault();

            return View(select);
        }

        public ActionResult Edit(int id)
        {

            return View(db.DONHANGs.Where(s => s.ID_DONHANG == id).FirstOrDefault());
        }

        // POST: OrderState/Edit/5
        [HttpPost]
        public ActionResult Edit(DONHANG tt)
        {
            int id = int.Parse(Url.RequestContext.RouteData.Values["id"].ToString());
            try
            {
                DONHANG d = db.DONHANGs.Where(s => s.ID_DONHANG == id).FirstOrDefault();
                d.THONGTINKHACHHANG = tt.THONGTINKHACHHANG;
                db.SaveChanges();
                return RedirectToAction("DanhSachDonHang", "Order");
            }
            catch
            {
                return View();
            }
        }

    }
}