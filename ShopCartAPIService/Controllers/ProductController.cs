using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ShopCartAPIService.Models;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Web.Hosting;
using System.Drawing.Imaging;

namespace ShopCartAPIService.Controllers
{
    [EnableCors(origins: "http://localhost:22731", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private List<Product> products;
        public ProductController()
        {
            products = new List<Product>();
        }

        //[Route("api/products")]
        //[HttpGet]
        public IEnumerable<Product> Get()
        {
            //products.Add(new Product() { ProductImage = getImage("/Images/Acer.jpg"), ModelNo = "Acer 2014", Price = 18000 });
            products.Add(new Product() { ProductImage = "/Images/Compaq.jpg", ModelNo = "Compaq 2013", Price = 19500 });
            products.Add(new Product() { ProductImage = "/Images/Dell.jpg", ModelNo = "Dell 2015", Price = 23550 });
            products.Add(new Product() { ProductImage = "/Images/Samsung.jpg", ModelNo = "Samsung 2011", Price = 25500 });
            return products;
        }

        private string getImage(string p)
        {
            //2
            TypeConverter typeConverter = TypeDescriptor.GetConverter(typeof(Bitmap));
            Bitmap bmp = (Bitmap)typeConverter.ConvertFrom(p);

            //3
            var Fs = new FileStream(HostingEnvironment.MapPath("~/Images") + "Acer.png", FileMode.Create);//@"\I" + Id.ToString() + 
            bmp.Save(Fs, ImageFormat.Png);
            bmp.Dispose();


            //4
            Image img = Image.FromStream(Fs);
            Fs.Close();
            Fs.Dispose();


            //5
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);


            //6
            //response.Content = new ByteArrayContent(ms.ToArray());
            ms.Close();
            ms.Dispose();
            return null;
        }
    }
}
