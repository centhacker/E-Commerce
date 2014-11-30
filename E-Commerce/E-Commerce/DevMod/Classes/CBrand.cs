using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CBrand
    {
        public List<Models.MBrand> GetAll() 
        {
            List<Models.MBrand> allBrands = new List<Models.MBrand>();
            var q = from o in DBMod.CDBHandler.cdc.BrandMasters
                    select o;
            foreach (var item in q)
            {
                Models.MBrand mb = new Models.MBrand();
                mb.Code = item.Code;
                mb.id = item.id.ToString();
                mb.Name = item.Name;
                allBrands.Add(mb);
            }
            return allBrands;
        }

        public int Save(Models.MBrand mb)
        {
            try
            {
                DBMod.BrandMaster bm = new DBMod.BrandMaster();
                bm.Code = mb.Code;
                bm.Name = mb.Name;
                DBMod.CDBHandler.cdc.BrandMasters.InsertOnSubmit(bm);
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