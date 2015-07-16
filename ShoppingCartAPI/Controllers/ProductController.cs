using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCartAPI.Models;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace ShoppingCartAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private List<Product> products;
        public ProductController()
        {
            products = new List<Product>();
        }

        [Route("api/products")]
        public IEnumerable<Product> GetProducts()
        {
            products.Add(new Product() { ProductImage = "/Images/Acer.jpg", ModelNo = "Acer 2014", Price = 18000 });
            products.Add(new Product() { ProductImage = "/Images/Compaq.jpg", ModelNo = "Compaq 2013", Price = 19500 });
            products.Add(new Product() { ProductImage = "/Images/Dell.jpg", ModelNo = "Dell 2015", Price = 23550 });
            products.Add(new Product() { ProductImage = "/Images/Samsung.jpg", ModelNo = "Samsung 2011", Price = 25500 });
            return products;
        }
    }
}
