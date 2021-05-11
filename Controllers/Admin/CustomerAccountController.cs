using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers.Admin
{
    public class CustomerAccountController : Controller
    {
        BOOKSHOPEntities db = new BOOKSHOPEntities();
        // GET: CustomerAccount
        public ActionResult Index()
        {
            return View(db.TAIKHOANKHACHHANGs.ToList());
        }
        public 
    }
}