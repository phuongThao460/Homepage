using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers
{
    public class NhaCungCapController : Controller
    {
        BookshopEntity db = new BookshopEntity();
        // GET: NhaCungCap
        public ActionResult Index()
        {
            return View(db.NHACUNGCAPs.ToList());
        }

        // GET: NhaCungCap/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhaCungCap/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap/Create
        [HttpPost]
        public ActionResult Create(NHACUNGCAP ncc)
        {
            try
            {
                db.NHACUNGCAPs.Add(ncc);
                db.SaveChanges();
                return RedirectToAction("Index", "NhaCungCap");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaCungCap/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.NHACUNGCAPs.Where(s => s.ID_NCC == id).First());
        }

        // POST: NhaCungCap/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NHACUNGCAP ncc)
        {
            try
            {
                NHACUNGCAP d = db.NHACUNGCAPs.Where(s => s.ID_NCC == ncc.ID_NCC).First();
                d.TEN_NHACUNGCAP = ncc.TEN_NHACUNGCAP;
                db.SaveChanges();
                return RedirectToAction("Index", "NhaXuatBan");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaCungCap/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhaCungCap/Delete/5
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
