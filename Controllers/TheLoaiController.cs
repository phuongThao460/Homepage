using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers
{
    public class TheLoaiController : Controller
    {
        BookshopEntity db  = new BookshopEntity();
        public ActionResult Index()
        {
            return View(db.THELOAIs.ToList());
        }

        // GET: TheLoai/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TheLoai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TheLoai/Create
        [HttpPost]
        public ActionResult Create(THELOAI tl)
        {
            try
            {
                db.THELOAIs.Add(tl);
                db.SaveChanges();
                return RedirectToAction("Index", "TheLoai");
            }
            catch
            {
                return View();
            }
        }

        // GET: TheLoai/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.THELOAIs.Where(s => s.ID_THELOAI == id).First());
        }

        // POST: TheLoai/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, THELOAI tl)
        {
            try
            {
                THELOAI d = db.THELOAIs.Where(s => s.ID_THELOAI == tl.ID_THELOAI).First();
                d.TEN_THELOAI = tl.TEN_THELOAI;
                db.SaveChanges();
                return RedirectToAction("Index", "TheLoai");
            }
            catch
            {
                return View();
            }
        }

        // GET: TheLoai/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TheLoai/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
