using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.SMO
{
    public class SharedMemoryObjects
    {
        SharedMemoryObjects()
        {
            allBrands = null;
            allCategory = null;
            allColors = null;
            allNewArrivals = null;
            allPrice = null;
            allProductContainer = null;
            allProducts = null;
            allSize = null;
            allSubCategoies = null;

        }
        public static List<Models.MBrand> allBrands = new List<Models.MBrand>();
        public static List<Models.MCategory> allCategory = new List<Models.MCategory>();
        public static List<Models.MColor> allColors = new List<Models.MColor>();
        public static List<Models.MNewArrivals> allNewArrivals = new List<Models.MNewArrivals>();
        public static List<Models.MPrice> allPrice = new List<Models.MPrice>();
        public static List<Models.MProductContainer> allProductContainer = new List<Models.MProductContainer>();
        public static List<Models.MProducts> allProducts = new List<Models.MProducts>();
        public static List<Models.MSize> allSize = new List<Models.MSize>();
        public static List<Models.MSubCategory> allSubCategoies = new List<Models.MSubCategory>();


        public class Pager
        {
            public string PageNumber { get; set; }
            public string Class { get; set; }
            public string PageDisplay { get; set; }
        }
    }
}