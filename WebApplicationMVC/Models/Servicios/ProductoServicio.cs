using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC.Models.Products;

namespace WebApplicationMVC.Models.Servicios
{
    public static class ProductoServicio
    {
        public static List<Product> GetProductos()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "Básico", Price = Convert.ToDecimal("23500.33") });
            products.Add(new Product() { Id = 2, Name = "Especial", Price = Convert.ToDecimal("42500.89") });
            products.Add(new Product() { Id = 3, Name = "Superior", Price = Convert.ToDecimal("56800.44") });

            return products;
        }
    }
}