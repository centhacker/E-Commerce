using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CProducts
    {
        public List<Models.MProducts> GetAll()
        {
            List<Models.MProducts> list = new List<Models.MProducts>();
            var q = from o in DBMod.CDBHandler.cdc.ProductMasters select o;
            foreach (var item in q)
            {
                Models.MProducts model = new Models.MProducts();
                model.id = item.id.ToString();
                model.Name1 = item.Name1;
                model.Name2 = item.Name2;
                model.Name3 = item.Name3;
                model.Price = item.Price;
                model.ImageUrl1 = item.ImageUrl1;
                model.ImageUrl2 = item.ImageUrl2;
                model.ImageUrl3 = item.ImageUrl3;
                model.Description = item.Description;
                model.Code = item.Code;
                list.Add(model);
            }
            return list;
        }

        public int Save(Models.MProducts mp)
        {
            try
            {
                DBMod.ProductMaster pm = new DBMod.ProductMaster();
                pm.Code = mp.Code;
                pm.Description = mp.Description;
                pm.ImageUrl1 = mp.ImageUrl1;
                pm.ImageUrl2 = mp.ImageUrl2;
                pm.ImageUrl3 = mp.ImageUrl3;
                pm.Name1 = mp.Name1;
                pm.Name2 = mp.Name2;
                pm.Name3 = mp.Name3;
                pm.Price = mp.Price;
                DBMod.CDBHandler.cdc.ProductMasters.InsertOnSubmit(pm);
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