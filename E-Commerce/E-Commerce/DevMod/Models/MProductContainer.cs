using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Models
{
    public class MProductContainer
    {
        public string id { get; set; }
        public string ProductId { get; set; }
        public string CategoryId { get; set; }
        public string BrandId { get; set; }
        public string ColorId { get; set; }
        public string SubCategoryId { get; set; }
        public string Discounted { get; set; }
        public string DiscountedPrice { get; set; }
        public string SizeId { get; set; }
        public string DiscountedPercent { get; set; }
    }
}