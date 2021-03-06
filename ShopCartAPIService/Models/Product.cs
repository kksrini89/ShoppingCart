﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ShopCartAPIService.Models
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