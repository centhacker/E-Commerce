using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.DevMod.Classes
{
    public class CSize
    {
        public List<Models.MSize> GetAll()
        {
            List<Models.MSize> list = new List<Models.MSize>();
            var q = from o in DBMod.CDBHandler.cdc.SizeMasters select o;
            foreach (var item in q)
            {
                Models.MSize model = new Models.MSize();
                model.id = item.id.ToString();
                model.Size = item.Size ;
                list.Add(model);
            }
            return list;
        }


        
    }
}