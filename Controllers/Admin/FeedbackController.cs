﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homepage.Models;

namespace Homepage.Controllers.Admin
{
    public class FeedbackController : Controller
    {
        BOOKSHOPEntities db = new BOOKSHOPEntities();
        // GET: Feedback
        public ActionResult Index()
        {
            return View(db.FEEDBACKs.ToList());
        }
    }
}