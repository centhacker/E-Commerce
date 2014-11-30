using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CProductContainer
    {
        public List<Models.MProductContainer> GetAll()
        {
            List<Models.MProductContainer> list = new List<Models.MProductContainer>();
            var q = from o in DBMod.CDBHandler.cdc.ProductContainers select o;
            foreach (var item in q)
            {
                Models.MProductContainer model = new Models.MProductContainer();
                model.id = item.id.ToString();
                model.BrandId = item.BrandId;
                model.CategoryId = item.CategoryId;
                model.ColorId = item.ColorId;
                model.Discounted = item.Discounted;
                model.DiscountedPercent = item.DiscountedPercent;
                model.DiscountedPrice = item.DiscountedPrice;
                model.ProductId = item.ProductId;
                model.SizeId = item.SizeId;
                model.SubCategoryId = item.SubCategoryId;
                    
                list.Add(model);
            }
            return list;
        }


        public int Save(Models.MProductContainer mp)
        {
            DBMod.ProductContainer pc = new DBMod.ProductContainer();
            pc.BrandId = mp.BrandId;
            pc.CategoryId = mp.CategoryId;
            pc.ColorId = mp.ColorId;
            pc.Discounted = mp.Discounted;
            pc.DiscountedPercent = mp.DiscountedPercent;
            pc.DiscountedPrice = mp.DiscountedPrice;
            pc.ProductId = mp.ProductId;
            pc.SizeId = mp.SizeId;
            pc.SubCategoryId = "";
            DBMod.CDBHandler.cdc.ProductContainers.InsertOnSubmit(pc);
            DBMod.CDBHandler.cdc.SubmitChanges();
            return 1;
        }
    }
}