using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class passingDataController : Controller
    {
        // GET: passingData
        public ActionResult Index()
        {
            List<product> Products = new List<product>();

            Products.Add(new product() { id = 1, name = "burger", price = 350, image = "1.png" });

            Products.Add(new product() { id = 2, name = "burgerking", price = 400, image = "1.png" });

            ViewBag.products = Products;

            ViewData["prod"] = Products;
            return View();
        }
    }
}