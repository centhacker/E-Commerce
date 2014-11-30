using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CNewArrivals
    {
        public List<Models.MNewArrivals> GetAll()
        {
            List<Models.MNewArrivals> list = new List<Models.MNewArrivals>();
            var q = from o in DBMod.CDBHandler.cdc.NewArrivals select o;
            foreach (var item in q)
            {
                Models.MNewArrivals model = new Models.MNewArrivals();
                model.id = item.id.ToString();
                model.ProductId = item.ProductId;
                list.Add(model);
            }
            return list;
        }
    }
}