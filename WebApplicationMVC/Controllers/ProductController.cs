using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models.Products;
using WebApplicationMVC.Models.Servicios;

namespace WebApplicationMVC.Controllers
{
    public class ProductController : Controller
    {
        // Constructor: Product
        public ProductController()
        {

        }
        // GET: Product
        public ActionResult Index()
        {
            var model = ProductoServicio.GetProductos();
            return View(model);
        }
        public ActionResult Create(Product producto)
        {
             
            return View(producto);
        }
        
    }
}