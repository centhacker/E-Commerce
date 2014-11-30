using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin.ContentPages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CacheData()
        {
            List<DevMod.Models.MCategory> allCategories = new List<DevMod.Models.MCategory>();
            List<DevMod.Models.MPrice> allPrice = new List<DevMod.Models.MPrice>();
            List<DevMod.Models.MProductContainer> allProductContainer = new List<DevMod.Models.MProductContainer>();
            List<DevMod.Models.MSubCategory> allSubCategories = new List<DevMod.Models.MSubCategory>();
            List<DevMod.Models.MCategoryContainer> allCategoryContainer = new List<DevMod.Models.MCategoryContainer>();
            List<DevMod.Models.MBrand> allBrands = new List<DevMod.Models.MBrand>();
            List<DevMod.Models.MColor> allColors = new List<DevMod.Models.MColor>();
            List<DevMod.Models.MCommon.MViewObjects.MViewProducts> allProducts = new List<DevMod.Models.MCommon.MViewObjects.MViewProducts>();
            DevMod.Classes.CSubCategory msc = new DevMod.Classes.CSubCategory();
            DevMod.Classes.CCommon.CViewObjects cv = new DevMod.Classes.CCommon.CViewObjects();
            DevMod.Classes.CCategory mc = new DevMod.Classes.CCategory();
            DevMod.Classes.CCategoryContainer mcc = new DevMod.Classes.CCategoryContainer();
            DevMod.Classes.CPrice cp = new DevMod.Classes.CPrice();
            DevMod.Classes.CBrand cb = new DevMod.Classes.CBrand();
            DevMod.Classes.CColor cc = new DevMod.Classes.CColor();
            DevMod.Classes.CProductContainer cpc = new DevMod.Classes.CProductContainer();
            allPrice = cp.GetAll();
            allSubCategories = msc.GetAll();
            allCategories = mc.GetAll();
            allCategoryContainer = mcc.GetAll();
            allBrands = cb.GetAll();
            allColors = cc.GetAll();
            allProductContainer = cpc.GetAll();
            allProducts = cv.GetAllProducts();
            HttpContext.Current.Cache.Remove("allPrice");
            HttpContext.Current.Cache.Remove("allCategories");
            HttpContext.Current.Cache.Remove("allSubCategories");
            HttpContext.Current.Cache.Remove("allCategoryContainer");
            HttpContext.Current.Cache.Remove("allProductContainer");
            HttpContext.Current.Cache["allSubCategories"] = allSubCategories;
            HttpContext.Current.Cache["allCategories"] = allCategories;
            HttpContext.Current.Cache["allCategoryContainer"] = allCategoryContainer;
            HttpContext.Current.Cache["allPrice"] = allPrice;
            HttpContext.Current.Cache["allBrands"] = allBrands;
            HttpContext.Current.Cache["allColors"] = allColors;
            HttpContext.Current.Cache["allProducts"] = allProducts;
            HttpContext.Current.Cache["allProductContainer"] = allProductContainer;

        }
    }
}