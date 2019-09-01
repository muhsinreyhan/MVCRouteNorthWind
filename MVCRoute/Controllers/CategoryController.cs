using MVCRoute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoute.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Category

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Details(string CategoryName, int CategoryID, string ProductName, int ProductID)
        {
            return View();
        }
    }
}