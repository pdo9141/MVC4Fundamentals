﻿using eManager.Domain;
using eManager.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentDataSource _db;

        public DepartmentController()
        {
            _db = new DepartmentDb();
        }

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Detail(int id)
        {
            var model = _db.Departments.Single(d => d.Id == id);
            return View(model);
        }
    }
}