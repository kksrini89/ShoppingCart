using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingWebAPI.Models;

namespace ShoppingWebAPI.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/products")]
        public IEnumerable<Product> GetProducts()
        {
            List<Product> productsList = new List<Product>();
            productsList.Add(new Product() { ProductImage = "/Images/Acer.jpg", ModelNo = "Acer 2014", Price = 18000 });
            productsList.Add(new Product() { ProductImage = "/Images/Compaq.jpg", ModelNo = "Compaq 2013", Price = 19500 });
            productsList.Add(new Product() { ProductImage = "/Images/Dell.jpg", ModelNo = "Dell 2015", Price = 23550 });
            productsList.Add(new Product() { ProductImage = "/Images/Samsung.jpg", ModelNo = "Samsung 2011", Price = 25500 });
            return productsList;
        }

        // GET api/product
        /*  public IEnumerable<string> Get()
          {
              return new string[] { "value1", "value2" };
          }

          // GET api/product/5
          public string Get(int id)
          {
              return "value";
          }

          // POST api/product
          public void Post([FromBody]string value)
          {
          }

          // PUT api/product/5
          public void Put(int id, [FromBody]string value)
          {
          }

          // DELETE api/product/5
          public void Delete(int id)
          {
          }*/
    }
}
