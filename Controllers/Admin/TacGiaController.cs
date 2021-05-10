using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers
{
    public class TacGiaController : Controller
    {
        BOOKSHOPEntities db = new BOOKSHOPEntities();
        // GET: TacGia
        public ActionResult Index()
        {
            return View(db.TACGIAs.ToList());
        }

        // GET: TacGia/Details/5
        public ActionResult Details(int id)
        {
            var select = db.TACGIAs.Where(tg => tg.ID_TACGIA == id).FirstOrDefault();

            return View(select);
        }

        [HttpGet]
        // GET: TacGia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TacGia/Create
        [HttpPost]
        public ActionResult Create(TACGIA tg)
        {
            try
            {
                // TODO: Add insert logic here

                db.TACGIAs.Add(tg);
                db.SaveChanges();
                return RedirectToAction("Index", "TacGia");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: TacGia/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.TACGIAs.Where(s => s.ID_TACGIA == id).FirstOrDefault());
        }

        // POST: TacGia/Edit/5
        [HttpPost]
        public ActionResult Edit(TACGIA tg)
        {
            try
            {
                TACGIA d = db.TACGIAs.Where(s => s.ID_TACGIA == tg.ID_TACGIA).FirstOrDefault();
                d.TEN_TACGIA = tg.TEN_TACGIA;
                db.SaveChanges();
                return RedirectToAction("Index", "TacGia");
            }
            catch
            {
                return View();
            }
        }

    }
}
