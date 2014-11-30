using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CSubCategory
    {
        public List<Models.MSubCategory> GetAll()
        {
            List<Models.MSubCategory> subCategories = new List<Models.MSubCategory>();
            var q = from o in DBMod.CDBHandler.cdc.SubCategoryMasters
                    select o;
            foreach (var item in q)
            {
                Models.MSubCategory ms = new Models.MSubCategory();
                ms.Code = item.Code;
                ms.id = item.id.ToString();
                ms.ImageUrl = item.ImageUrl;
                ms.Name = item.Name;
                subCategories.Add(ms);
            }
            return subCategories;
        }
        public int Save(Models.MSubCategory mb)
        {
            try
            {

                DBMod.SubCategoryMaster cm = new DBMod.SubCategoryMaster();
                cm.Name = mb.Name;
                cm.Code = mb.Code;
                cm.ImageUrl = mb.ImageUrl;
                DBMod.CDBHandler.cdc.SubCategoryMasters.InsertOnSubmit(cm);
                DBMod.CDBHandler.cdc.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;

            }
        }
    }
}