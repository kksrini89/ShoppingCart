using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartAPI.Models
{
    public class Product
    {
        #region member variables

        private string productImage;
        private string modelNo;
        private double price;

        #endregion

        #region Properties
        public string ProductImage
        {
            get { return productImage; }
            set { productImage = value; }
        }

        public string ModelNo
        {
            get { return modelNo; }
            set { modelNo = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion
    }
}