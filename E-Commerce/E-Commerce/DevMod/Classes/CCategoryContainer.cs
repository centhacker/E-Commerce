using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CCategoryContainer
    {
        public List<Models.MCategoryContainer> GetAll()
        {
            List<Models.MCategoryContainer> subCategories = new List<Models.MCategoryContainer>();
            var q = from o in DBMod.CDBHandler.cdc.CatogoryContainers
                    select o;
            foreach (var item in q)
            {
                Models.MCategoryContainer ms = new Models.MCategoryContainer();                
                ms.id = item.id.ToString();
                ms.CategoryId = item.CatogoryId.ToString();
                ms.SubCategoryId = item.SubCategoryId.ToString();
                subCategories.Add(ms);
            }
            return subCategories;
        }
    }
}